using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text.Json;
using System.Threading.Tasks;
using MetaMystia;

namespace SgrYuki.Utils;

[AutoLog]
public static partial class MetricsReporter
{
    private const string MetaMystiaVersionApiUrl = "https://api.izakaya.cc/version/meta-mystia";
    private const string TrackingServiceEndpoint = "https://track.izakaya.cc/api.php";
    private const string UserAgent = "MetaMystia/1.0 (+https://github.com/MetaMikuAI/MetaMystia)";

    private static string BuildTrackingUrl(string userId, Dictionary<string, string> parameters)
    {
        var baseParams = new Dictionary<string, string>
        {
            ["idsite"] = "13",
            ["rec"] = "1",
            ["_id"] = userId,
            ["uid"] = userId
        };

        foreach (var param in parameters)
        {
            baseParams[param.Key] = param.Value;
        }

        var queryString = string.Join("&", baseParams.Select(kvp => $"{kvp.Key}={Uri.EscapeDataString(kvp.Value)}"));
        return $"{TrackingServiceEndpoint}?{queryString}";
    }

    private static readonly System.Net.Http.HttpClient _githubApiClient = new()
    {
        BaseAddress = new Uri("https://api.github.com/"),
        Timeout = TimeSpan.FromSeconds(10)
    };

    private static readonly System.Net.Http.HttpClient _metricsClient = new()
    {
        Timeout = TimeSpan.FromSeconds(10)
    };

    private static string GetActiveMacAddress()
    {
        try
        {
            foreach (var nic in NetworkInterface.GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up)
                .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback))
            {
                var props = nic.GetIPProperties();
                if (props.UnicastAddresses.Any(u => u.Address.AddressFamily == AddressFamily.InterNetwork))
                {
                    var macAddress = nic.GetPhysicalAddress().ToString().Trim();
                    if (!string.IsNullOrEmpty(macAddress)) return macAddress;
                }
            }
        }
        catch (Exception ex)
        {
            Log.Warning($"Failed to get MAC address: {ex.Message}");
        }
        return null;
    }

    private static string GetMachineId()
    {
        try
        {
            var computerName = Environment.MachineName;
            var userName = Environment.UserName;
            var osVersion = Environment.OSVersion.VersionString;
            var processorCount = Environment.ProcessorCount;

            var combined = $"{computerName}|{userName}|{osVersion}|{processorCount}";
            return combined;
        }
        catch (Exception ex)
        {
            Log.Warning($"Failed to get machine ID: {ex.Message}");
            return null;
        }
    }

    private static string MD5(string input) => Convert.ToHexString(System.Security.Cryptography.MD5.HashData(System.Text.Encoding.UTF8.GetBytes(input))).ToLowerInvariant();

    private static readonly Lazy<string> _cachedUserId = new(() =>
    {
        var identifiers = new List<string>();

        var machineId = GetMachineId();
        if (!string.IsNullOrEmpty(machineId))
            identifiers.Add($"MACHINE:{machineId}");

        var macAddress = GetActiveMacAddress();
        if (!string.IsNullOrEmpty(macAddress))
            identifiers.Add($"MAC:{macAddress}");

        if (identifiers.Count > 0)
        {
            var combined = MD5(string.Join("|", identifiers));
            Log.Message($"User ID generated from: {combined}");
            return combined;
        }

        var fallbackId = Guid.NewGuid().ToString("N");
        Log.Warning($"No stable identifiers found, using random GUID: {fallbackId}");
        return fallbackId;
    });

    private static string GetUserId() => _cachedUserId.Value;

    static MetricsReporter()
    {
        _githubApiClient.DefaultRequestHeaders.UserAgent.ParseAdd(UserAgent);
        _githubApiClient.DefaultRequestHeaders.Accept.ParseAdd("application/vnd.github+json");
        _metricsClient.DefaultRequestHeaders.UserAgent.ParseAdd(UserAgent);
        _metricsClient.DefaultRequestHeaders.Accept.ParseAdd("application/json");
    }

    private static async Task<string> GetLatestReleaseTagUsingGithubAsync(
        string owner,
        string repo)
    {
        try
        {
            var response = await _githubApiClient.GetAsync($"repos/{owner}/{repo}/releases/latest");

            if (!response.IsSuccessStatusCode) return null;

            var json = await response.Content.ReadAsStringAsync();
            var dict = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json);
            // 200: {"tag_name":"v0.11.0"}
            if (dict != null && dict.TryGetValue("tag_name", out var tag))
            {
                return tag.ToString().TrimStart('v');
            }
        }
        catch (Exception ex)
        {
            Log.Warning($"Failed to get latest release from GitHub: {ex.Message}");
        }
        return null;
    }

    private static async Task<string> GetLatestReleaseTagAsync()
    {
        try
        {
            var response = await _metricsClient.GetAsync(MetaMystiaVersionApiUrl);

            if (!response.IsSuccessStatusCode) return null;

            var json = await response.Content.ReadAsStringAsync();
            var dict = JsonSerializer.Deserialize<Dictionary<string, JsonElement>>(json);
            // 200: {"dll":"0.11.0","zip":"0.4.5"}
            if (dict != null && dict.TryGetValue("dll", out var ver))
            {
                return ver.ToString();
            }
        }
        catch (Exception ex)
        {
            Log.Warning($"Failed to get latest release: {ex.Message}");
        }
        return null;
    }

    public static Task<string> GetPluginLatestTagAsync(bool useGithub = false)
    {
        if (useGithub)
        {
            return GetLatestReleaseTagUsingGithubAsync("MetaMikuAI", "MetaMystia");
        }
        return GetLatestReleaseTagAsync();
    }

    private static Task ReportAsync(Func<Task> reportAction, string actionName)
    {
        return Task.Run(async () =>
        {
            try
            {
                await reportAction();
            }
            catch (Exception ex)
            {
                Log.Warning($"[{actionName}] Failed: {ex.Message}");
            }
        });
    }

    private static async Task<bool> SendTrackingRequestAsync(string url, string actionName)
    {
        try
        {
            var response = await _metricsClient.GetAsync(url);
            var success = response.IsSuccessStatusCode;

            if (success)
            {
                Log.Info($"[{actionName}] Success");
            }
            else
            {
                Log.Warning($"[{actionName}] Failed with status: {response.StatusCode}");
            }

            return success;
        }
        catch (Exception ex)
        {
            Log.Warning($"[{actionName}] Exception: {ex.Message}");
            return false;
        }
    }

    /// <summary>
    /// 上报自定义事件
    /// </summary>
    /// <param name="category">事件类别</param>
    /// <param name="action">事件动作</param>
    /// <param name="name">事件名称（可选）</param>
    public static Task ReportEvent(string category, string action, string name = null)
    {
        return ReportAsync(async () =>
        {
            var userId = GetUserId();
            var parameters = new Dictionary<string, string>
            {
                ["ca"] = "1",
                ["e_c"] = category,
                ["e_a"] = action
            };

            if (!string.IsNullOrEmpty(name))
                parameters["e_n"] = name;

            var url = BuildTrackingUrl(userId, parameters);
            await SendTrackingRequestAsync(url, $"ReportEvent({category}/{action}{(name == null ? "" : $"/{name}")})");
        }, "ReportEvent");
    }

    public static Task SendHeartbeat()
    {
        return ReportAsync(async () =>
        {
            var userId = GetUserId();
            var url = BuildTrackingUrl(userId, new Dictionary<string, string>
            {
                ["ping"] = "1"
            });

            await SendTrackingRequestAsync(url, "Heartbeat");
        }, "SendHeartbeat");
    }

    public static void OnPluginInitialized()
    {
        CommandScheduler.RunInBackGround(async () =>
            {
                try
                {
                    var currentVer = MpManager.ModVersion;
                    var latest = await GetPluginLatestTagAsync();
                    if (!PluginManager.DEBUG) _ = ReportEvent("Client", "Run", currentVer);
                    Log.Message($"您的mod版本为 {currentVer}, 最新版为 {latest}");
                    if (!currentVer.Equals(latest))
                    {
                        Notify.ShowOnNextAvailableScene($"您的mod版本为 {currentVer}, 最新版为 {latest}, 建议更新到最新版！");
                    }
                }
                catch (Exception ex)
                {
                    Log.Error($"cannot get plugin version, {ex.Message}, {ex.StackTrace}");
                }
            });
    }
}
