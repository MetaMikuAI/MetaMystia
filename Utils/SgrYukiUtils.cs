using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SgrYuki.Utils;

public static class Extensions
{
    public static T GetRandomOne<T>(this IEnumerable<T> source)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        // 如果是 IReadOnlyList / List / Array，走 O(1)
        if (source is IReadOnlyList<T> list)
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Collection is empty.");

            return list[UnityEngine.Random.Range(0, list.Count)];
        }

        // 否则用水塘抽样
        T result = default;
        int count = 0;

        foreach (var item in source)
        {
            count++;
            if (UnityEngine.Random.Range(0, count) == 0)
                result = item;
        }

        if (count == 0)
            throw new InvalidOperationException("Collection is empty.");

        return result;
    }
    
    public static Il2CppSystem.Collections.Generic.IEnumerable<T> ToIEnumerable<T>(this Il2CppSystem.Collections.Generic.List<T> list)
    {
        return new Il2CppSystem.Collections.Generic.IEnumerable<T>(list.Pointer);
    }

    public static Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<T> ToIl2CppReferenceArray<T>(
        this Il2CppSystem.Collections.Generic.IEnumerable<T> enumerable) where T : Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase
    {
        return enumerable.TryCast<Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<T>>();
    }

    public static Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<T> SortByToString<T>(
            this Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<T> source)
            where T : Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        int length = source.Length;
        if (length <= 1)
            return source; // 0/1 个元素无需排序

        // 拷贝到托管数组
        T[] managed = new T[length];
        for (int i = 0; i < length; i++)
        {
            managed[i] = source[i];
        }

        // 排序（注意 null 处理）
        Array.Sort(managed, (a, b) =>
        {
            if (ReferenceEquals(a, b)) return 0;
            if (a is null) return -1;
            if (b is null) return 1;

            string sa = a.ToString();
            string sb = b.ToString();

            return string.Compare(
                sa, sb,
                StringComparison.Ordinal
            );
        });

        // 构造新的 Il2CppReferenceArray
        var result = new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<T>(length);
        for (int i = 0; i < length; i++)
        {
            result[i] = managed[i];
        }

        return result;
    }
    
    public static string DumpElements<T>(
        this Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<T> array,
        string separator = ", ")
        where T : Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase
    {
        if (array == null)
            return "<Il2CppReferenceArray: null>";

        int length = array.Length;
        if (length == 0)
            return "<Il2CppReferenceArray: empty>";

        var sb = new System.Text.StringBuilder(256);

        sb.Append($"Il2CppReferenceArray<{typeof(T).Name}>[{length}] {{ ");

        for (int i = 0; i < length; i++)
        {
            if (i > 0)
                sb.Append(separator);

            T element = array[i];

            if (element == null)
            {
                sb.Append("null");
                continue;
            }

            try
            {
                sb.Append((element as UnityEngine.Object).ToString());
            }
            catch (Exception ex)
            {
                sb.Append($"<ToString threw {ex.GetType().Name}>");
            }
        }

        sb.Append(" }");
        return sb.ToString();
    }

    public static System.Collections.Generic.List<KeyT> FilterKey<KeyT, ValueT>(
        this Il2CppSystem.Collections.Generic.Dictionary<KeyT, ValueT> dict, Predicate<ValueT> condition)
    {
        var result = new System.Collections.Generic.List<KeyT>();
        foreach (var kv in dict)
        {
            if (condition(kv.Value)) result.Add(kv.Key);
        }
        return result;
    }

    public static Il2CppSystem.Collections.Generic.Dictionary<TKey, TValue> ToIl2CppDictionary<TKey, TValue>(
        this System.Collections.Generic.Dictionary<TKey, TValue> dict)
    {
        if (dict == null) return null;
        var result = new Il2CppSystem.Collections.Generic.Dictionary<TKey, TValue>();
        foreach (var kvp in dict)
        {
            result.Add(kvp.Key, kvp.Value);
        }
        return result;
    }

    public static System.Collections.Generic.List<T> ToManagedList<T>(
            this Il2CppSystem.Collections.Generic.List<T> il2cppList)
    {
        if (il2cppList == null)
            return null;

        var result = new System.Collections.Generic.List<T>(il2cppList.Count);
        for (int i = 0; i < il2cppList.Count; i++)
        {
            result.Add(il2cppList[i]);
        }

        return result;
    }
}

public static class Il2CppEnumerableExtensions
{
    /// <summary>
    /// 是否至少存在一个元素
    /// </summary>
    public static bool Any(this Il2CppSystem.Collections.IEnumerable source)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));

        var enumerator = source.GetEnumerator();
        return enumerator.MoveNext();
    }

    /// <summary>
    /// 是否存在满足条件的元素
    /// </summary>
    public static bool Any(
        this Il2CppSystem.Collections.IEnumerable source,
        Func<object, bool> predicate)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));
        if (predicate == null)
            throw new ArgumentNullException(nameof(predicate));

        var enumerator = source.GetEnumerator();
        while (enumerator.MoveNext())
        {
            if (predicate(enumerator.Current))
                return true;
        }

        return false;
    }

    /// <summary>
    /// 是否所有元素都满足条件
    /// （空集合返回 true，符合 LINQ 语义）
    /// </summary>
    public static bool All(
        this Il2CppSystem.Collections.IEnumerable source,
        Func<object, bool> predicate)
    {
        if (source == null)
            throw new ArgumentNullException(nameof(source));
        if (predicate == null)
            throw new ArgumentNullException(nameof(predicate));

        var enumerator = source.GetEnumerator();
        while (enumerator.MoveNext())
        {
            if (!predicate(enumerator.Current))
                return false;
        }

        return true;
    }
}

public sealed class LogWrapper
{
    public readonly BepInEx.Logging.ManualLogSource _inner;
    public readonly string _tag;

    public LogWrapper(BepInEx.Logging.ManualLogSource inner, string tag)
    {
        _inner = inner;
        _tag = tag;
    }

    private static string GetTime() => DateTime.Now.ToString("HH:mm:ss.fff");

    private string TagString(bool withTag) => withTag ? $"[{_tag}] " : "";

    public void Debug(string msg, bool withTag = true) => _inner.LogDebug($"[{GetTime()}] {TagString(withTag)}{msg}");
    public void Info(string msg, bool withTag = true) => _inner.LogInfo($"[{GetTime()}] {TagString(withTag)}{msg}");
    public void Message(string msg, bool withTag = true) => _inner.LogMessage($"[{GetTime()}] {TagString(withTag)}{msg}");
    public void Warning(string msg, bool withTag = true) => _inner.LogWarning($"[{GetTime()}] {TagString(withTag)}{msg}");
    public void Error(string msg, bool withTag = true) => _inner.LogError($"[{GetTime()}] {TagString(withTag)}{msg}");
    public void Fatal(string msg, bool withTag = true) => _inner.LogFatal($"[{GetTime()}] {TagString(withTag)}{msg}");

    public void LogDebug(string msg, bool withTag = true) => Debug(msg, withTag);
    public void LogInfo(string msg, bool withTag = true) => Info(msg, withTag);
    public void LogMessage(string msg, bool withTag = true) => Message(msg, withTag);
    public void LogWarning(string msg, bool withTag = true) => Warning(msg, withTag);
    public void LogError(string msg, bool withTag = true) => Error(msg, withTag);
    public void LogFatal(string msg, bool withTag = true) => Fatal(msg, withTag);

    public void LogStacktrace() => Functional.LogStacktrace(_inner);
}

// Support "foreach" any container that implements [] operator and Count member method
public readonly struct IndexableWrapper
{
    private readonly object _inner;

    public IndexableWrapper(object inner)
    {
        _inner = inner ?? throw new ArgumentNullException(nameof(inner));
    }

    /* =========================
     * foreach 支持
     * ========================= */

    public Enumerator GetEnumerator()
        => new Enumerator(_inner);

    public struct Enumerator
    {
        private readonly object _container;
        private int _index;

        public Enumerator(object container)
        {
            _container = container;
            _index = -1;
        }

        public readonly object Current => ((dynamic)_container)[_index];

        public bool MoveNext()
        {
            return ++_index < ((dynamic)_container).Count();
        }
    }

    /* =========================
     * Any / All（内建）
     * ========================= */

    /// <summary>
    /// 是否至少存在一个元素
    /// </summary>
    public bool Any()
    {
        var e = GetEnumerator();
        return e.MoveNext();
    }

    /// <summary>
    /// 是否存在满足条件的元素
    /// </summary>
    public bool Any(Func<object, bool> predicate)
    {
        if (predicate == null)
            throw new ArgumentNullException(nameof(predicate));

        var e = GetEnumerator();
        while (e.MoveNext())
        {
            if (predicate(e.Current))
                return true;
        }
        return false;
    }

    /// <summary>
    /// 是否所有元素都满足条件
    /// （空集合返回 true，符合 LINQ 语义）
    /// </summary>
    public bool All(Func<object, bool> predicate)
    {
        if (predicate == null)
            throw new ArgumentNullException(nameof(predicate));

        var e = GetEnumerator();
        while (e.MoveNext())
        {
            if (!predicate(e.Current))
                return false;
        }
        return true;
    }
}

public class ConcurrentHashSet<T>
{
    private readonly System.Collections.Concurrent.ConcurrentDictionary<T, byte> _dict = new();

    public bool Add(T item)
        => _dict.TryAdd(item, 0);

    public bool Remove(T item)
        => _dict.TryRemove(item, out _);

    public bool Contains(T item)
        => _dict.ContainsKey(item);

    public int Count
        => _dict.Count;

    public void Clear()
        => _dict.Clear();

    public System.Collections.Generic.IEnumerable<T> Items
        => _dict.Keys;
}

public static class Functional
{

    // Note: only available for those functions are patched. Not patched functions will not appear in the stacktrace
    public static bool CheckStacktraceContains(string funcName)
    {
        var stack = new System.Diagnostics.StackTrace();
        // foreach (var frame in stack.GetFrames())
        // {
        //     var method = frame.GetMethod();
        //     Log.LogInfo($"{LOG_TAG} \t at {method.Name}");
        // }
        return stack.GetFrames().Any(frame => frame.GetMethod().Name.Contains(funcName));
    }

    public static void LogStacktrace(BepInEx.Logging.ManualLogSource Log)
    {
        string stack = Environment.StackTrace;
        string[] lines = stack.Split([Environment.NewLine], StringSplitOptions.None);

        System.Text.StringBuilder sb = new();
        // ignore this layer and upper layer
        for (int i = 2; i < lines.Length; i++)
        {
            sb.AppendLine(lines[i]);
        }

        Log.LogInfo(sb.ToString());
    }

    public static void ModifyReadonlyField<T, FieldT>(T instance, string fieldName, FieldT newValue)
    {
        var field = typeof(T).GetField(
            fieldName,
            BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
        );

        field.SetValue(instance, newValue);
    }
}


[MetaMystia.AutoLog]
public static partial class CommandScheduler
{
    private sealed class Command
    {
        public Func<bool> CanExecute;
        public Action Execute;
        public string ExecuteInfo;
        public Action OnTimeout;
        public float ExpireTime; // unscaled time
    }

    private static readonly System.Collections.Concurrent.ConcurrentQueue<Command> _pending = new();

    private static readonly System.Collections.Generic.Queue<Command> _queue = new ();

    private static void onTimeoutDefault(string text) => Log.LogWarning($"{text} timeout!");


    // ================================
    // Public API 
    // ================================
    public static void Enqueue(
        Func<bool> executeWhen,
        Action execute,
        string executeInfo = "",
        float timeoutSeconds = 60f,
        Action onTimeout = null)
    {
        if (executeWhen == null)
            throw new ArgumentNullException(nameof(executeWhen));
        if (execute == null)
            throw new ArgumentNullException(nameof(execute));

        onTimeout ??= () => onTimeoutDefault(executeInfo);

        _pending.Enqueue(new Command
        {
            CanExecute = executeWhen,
            Execute = execute,
            ExecuteInfo = executeInfo,
            OnTimeout = onTimeout,
            ExpireTime = UnityEngine.Time.unscaledTime + timeoutSeconds
        });
    }

    // ================================
    // Main-thread tick 
    // ================================
    public static void Tick()
    {
        // 转移后台提交
        while (_pending.TryDequeue(out var cmd))
        {
            _queue.Enqueue(cmd);
        }

        // FIFO 扫描
        int count = _queue.Count;

        for (int i = 0; i < count; i++)
        {
            var cmd = _queue.Dequeue();

            if (UnityEngine.Time.unscaledTime > cmd.ExpireTime)
            {
                cmd.OnTimeout?.Invoke();
                continue;
            }

            bool canExecute = false;
            try
            {
                canExecute = cmd.CanExecute();
            }
            catch (MetaMystia.NightGuestManager.GuestInvalidatedException e)
            {
                Log.Warning($"ignore action {cmd.ExecuteInfo} for {e.Message}");
                continue;
            }
            catch (Exception e)
            {
                Log.Error($"Error when checking action {cmd.ExecuteInfo}, reason: {e.Message}");
                continue;
            }

            if (canExecute)
            {
                try
                {
                    cmd.Execute();
                }
                catch (Exception e)
                {
                    Log.Error($"Error when executing action {cmd.ExecuteInfo}, reason: {e.Message}, stacktrace {e.StackTrace}");
                }
            }
            else
            {
                _queue.Enqueue(cmd);
            }
        }
    }
}

[MetaMystia.AutoLog]
public static partial class Panel
{
    public static void CloseMoreThan2ActivePannels(){
        string[] PanelToBeClosed = ["NoteBook_MainPannel", "Storage_MainPannel"];
        if (DEYU.AdpUISystem.Managers.AdpUIPanelManager.s_ActivePanelTransform.Count > 2)
        {
            var top = DEYU.AdpUISystem.Managers.AdpUIPanelManager.s_ActivePanelTransform.Peek();
            if (PanelToBeClosed.Any((panel) => top.Item1.name.Contains(panel)))
            {
                Log.LogWarning($"popped {top.Item1.name}, enabled {top.Item1.isActiveAndEnabled}");
                Common.UI.GeneralSustainedPannel.CurrentActiveSustainedPannel.CloseActivePannel();
            }
        }
    }
}