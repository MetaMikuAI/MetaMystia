using System;
using System.Collections.Generic;
using System.Linq;

using MetaMystia.ResourceEx.Models;

namespace MetaMystia.ResourceEx.AssetManagement;

// TODO: DLC Manager 加载过晚，而依赖验证需要 DLC Manager

/// <summary>
/// Validates resource package dependencies including:
///   - Rejecting packages with reserved built-in labels (CORE, DLC1–DLC5, DLCMUSIC)
///   - Checking that all declared dependencies are satisfiable
///   - Detecting circular dependency chains
/// </summary>
[AutoLog]
public static partial class DependencyValidator
{
    /// <summary>
    /// Labels reserved for the game's built-in packages. Third-party resource
    /// packages MUST NOT use any of these labels.
    /// </summary>
    public static readonly HashSet<string> ReservedLabels = new(StringComparer.OrdinalIgnoreCase)
    {
        "CORE", "DLC1", "DLC2", "DLC3", "DLC4", "DLC5", "DLCMUSIC"
    };

    /// <summary>
    /// Result of the dependency validation pass.
    /// </summary>
    public class DependencyValidationResult
    {
        /// <summary>Packages that passed all dependency checks and are safe to load.</summary>
        public List<T> Accepted<T>() where T : class => throw new NotSupportedException();

        public List<string> RejectedReasons { get; } = new();
    }

    /// <summary>
    /// Runs full dependency validation on a set of candidate packages.
    /// Returns only the packages whose dependencies are fully satisfiable.
    /// Rejected packages produce log errors and queued Notify messages.
    /// </summary>
    /// <typeparam name="T">Candidate type carrying a Config property.</typeparam>
    /// <param name="candidates">All candidates that have already passed ID/signature validation.</param>
    /// <param name="getName">Extracts a human-readable package name from a candidate.</param>
    /// <param name="getConfig">Extracts the <see cref="ResourceConfig"/> from a candidate.</param>
    /// <returns>The subset of candidates eligible for loading.</returns>
    public static List<T> Validate<T>(
        List<T> candidates,
        Func<T, string> getName,
        Func<T, ResourceConfig> getConfig,
        bool enforceDependency = true)
    {
        if (!enforceDependency)
        {
            Log.LogWarning("[DependencyValidator] Dependency check is DISABLED. All packages will be loaded without dependency validation.");
            return new List<T>(candidates);
        }

        // ── Phase 1: Reject packages that use reserved labels ─────────
        var afterReservedCheck = new List<T>();
        foreach (var candidate in candidates)
        {
            var label = getConfig(candidate)?.packInfo?.label;
            if (!string.IsNullOrEmpty(label) && ReservedLabels.Contains(label))
            {
                var name = getName(candidate);
                Log.LogError($"[{name}] Rejected: label '{label}' is reserved for built-in game packages.");
                Notify.ShowOnNextAvailableScene(() => TextId.ResourcePackageReservedLabel.Get(name, label));
                continue;
            }
            afterReservedCheck.Add(candidate);
        }

        // ── Phase 2: Build label → candidate lookup ───────────────────
        // Active built-in DLCs are always considered "available".
        var availableLabels = new HashSet<string>(
            DLCManager.ActiveDLCLabel ?? Enumerable.Empty<string>(),
            StringComparer.OrdinalIgnoreCase);

        // Also treat all reserved labels that are active as available.
        // (ActiveDLCLabel already covers active ones; we don't add inactive
        //  reserved labels so that dependencies on unowned DLC correctly fail.)

        var candidateByLabel = new Dictionary<string, T>(StringComparer.OrdinalIgnoreCase);
        foreach (var candidate in afterReservedCheck)
        {
            var label = getConfig(candidate)?.packInfo?.label;
            if (!string.IsNullOrEmpty(label))
            {
                candidateByLabel[label] = candidate;
            }
        }

        // ── Phase 3: Detect circular dependencies ─────────────────────
        //   DFS-based cycle detection across the candidate graph.
        //   Nodes: candidate labels  +  built-in labels (leaves, no outgoing edges)
        //   Edges: label → dependency labels

        // enum-like states for Tarjan-style coloring
        const int White = 0; // not visited
        const int Gray = 1;  // in current DFS path
        const int Black = 2; // fully processed, no cycle

        var color = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        var rejected = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        // Track the DFS path for error reporting
        var pathStack = new List<string>();

        foreach (var candidate in afterReservedCheck)
        {
            var label = getConfig(candidate)?.packInfo?.label;
            if (!string.IsNullOrEmpty(label))
                color[label] = White;
        }

        bool HasCycle(string label)
        {
            if (!color.TryGetValue(label, out var c))
                return false; // built-in or unknown — treated as leaf
            if (c == Black)
                return false;
            if (c == Gray)
                return true; // back-edge detected

            color[label] = Gray;
            pathStack.Add(label);

            if (candidateByLabel.TryGetValue(label, out var cand))
            {
                var deps = getConfig(cand)?.packInfo?.dependencies;
                if (deps != null)
                {
                    foreach (var dep in deps)
                    {
                        if (HasCycle(dep))
                            return true;
                    }
                }
            }

            pathStack.RemoveAt(pathStack.Count - 1);
            color[label] = Black;
            return false;
        }

        foreach (var candidate in afterReservedCheck)
        {
            var label = getConfig(candidate)?.packInfo?.label;
            if (string.IsNullOrEmpty(label))
                continue;

            if (color.TryGetValue(label, out var c) && c != White)
                continue;

            pathStack.Clear();
            if (HasCycle(label))
            {
                // Extract the cycle portion from pathStack
                int cycleStart = pathStack.IndexOf(label);
                var cycleLabels = cycleStart >= 0
                    ? pathStack.Skip(cycleStart).ToList()
                    : pathStack.ToList();
                cycleLabels.Add(label); // close the loop for display

                string chain = string.Join(" → ", cycleLabels);
                var name = getName(candidate);

                Log.LogError($"[{name}] Rejected: circular dependency detected: {chain}");
                Notify.ShowOnNextAvailableScene(() => TextId.ResourcePackageCircularDependency.Get(name, chain));

                // Mark all participants in the cycle as rejected
                foreach (var cl in cycleLabels)
                    rejected.Add(cl);

                // Reset colors for cycle participants so subsequent packages
                // that depend on them will also fail
                foreach (var cl in cycleLabels)
                {
                    if (color.ContainsKey(cl))
                        color[cl] = Black; // mark processed to avoid re-visiting
                }

                pathStack.Clear();
            }
        }

        // ── Phase 4: Topological dependency resolution ────────────────
        //   Iteratively resolve: a package is loadable iff all its
        //   dependencies are either built-in (active) or loadable candidates.
        //   Repeat until stable (handles transitive deps without recursion).

        var loadable = new HashSet<string>(availableLabels, StringComparer.OrdinalIgnoreCase);
        var pending = new List<T>(afterReservedCheck);

        // Packages without a label have no dependency semantics — always loadable
        var noLabelPackages = pending.Where(c => string.IsNullOrEmpty(getConfig(c)?.packInfo?.label)).ToList();
        pending = pending.Where(c => !string.IsNullOrEmpty(getConfig(c)?.packInfo?.label)).ToList();

        // Remove cycle-rejected packages from pending
        pending.RemoveAll(c =>
        {
            var l = getConfig(c)?.packInfo?.label;
            return !string.IsNullOrEmpty(l) && rejected.Contains(l);
        });

        bool changed = true;
        while (changed)
        {
            changed = false;
            for (int i = pending.Count - 1; i >= 0; i--)
            {
                var candidate = pending[i];
                var deps = getConfig(candidate)?.packInfo?.dependencies;
                var label = getConfig(candidate)?.packInfo?.label;

                bool allSatisfied = true;
                if (deps != null)
                {
                    foreach (var dep in deps)
                    {
                        if (!loadable.Contains(dep))
                        {
                            allSatisfied = false;
                            break;
                        }
                    }
                }

                if (allSatisfied)
                {
                    if (!string.IsNullOrEmpty(label))
                        loadable.Add(label);
                    pending.RemoveAt(i);
                    changed = true;
                }
            }
        }

        // Anything still in pending has unsatisfied dependencies
        foreach (var candidate in pending)
        {
            var name = getName(candidate);
            var deps = getConfig(candidate)?.packInfo?.dependencies ?? new List<string>();
            var missing = deps.Where(d => !loadable.Contains(d)).ToList();

            foreach (var dep in missing)
            {
                Log.LogError($"[{name}] Rejected: dependency '{dep}' is not available.");
                var capturedDep = dep;
                Notify.ShowOnNextAvailableScene(() => TextId.ResourcePackageMissingDependency.Get(name, capturedDep));
            }
        }

        // ── Build final list: no-label packages + resolved labeled ones ──
        var resolved = new HashSet<string>(loadable, StringComparer.OrdinalIgnoreCase);
        // Remove built-in labels from resolved (they are not candidates)
        foreach (var r in ReservedLabels)
            resolved.Remove(r);

        var result = new List<T>(noLabelPackages);
        foreach (var candidate in afterReservedCheck)
        {
            var label = getConfig(candidate)?.packInfo?.label;
            if (!string.IsNullOrEmpty(label) && resolved.Contains(label) && !rejected.Contains(label))
            {
                result.Add(candidate);
            }
        }

        return result;
    }
}
