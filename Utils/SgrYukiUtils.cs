using System;
using System.Linq;
using System.Reflection;
using Il2CppSystem.IO;

namespace SgrYuki.Utils;

public static class Il2CppContainerExtensions
{
    public static unsafe string Il2CppStringToManaged(IntPtr ptr)
    {
        if (ptr == IntPtr.Zero)
            return null;

        int length = *(int*)(ptr + IntPtr.Size * 2);
        char* chars = (char*)(ptr + IntPtr.Size * 2 + sizeof(int));

        return new string(chars, 0, length);
    }

    extension<T>(System.Collections.Generic.IEnumerable<T> source)
    {
        public T GetRandomOne()
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            // 如果是 IReadOnlyList / List / Array，走 O(1)
            if (source is System.Collections.Generic.IReadOnlyList<T> list)
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

        public string DumpElements(
            string separator = ", ")
        {
            if (source == null) return "";

            if (source is System.Collections.Generic.IReadOnlyList<T> list)
            {
                if (list.Count == 0) return "";
            }

            var sb = new System.Text.StringBuilder(1024);
            sb.Append('{');
            foreach (var item in source)
            {
                try
                {
                    sb.Append(item.ToString());
                    sb.Append(separator);
                }
                catch (Exception ex)
                {
                    sb.Append($"<ToString threw {ex.GetType().Name}>");
                }
            }
            sb.Append(" }");
            return sb.ToString();
        }

    }

    extension<T>(Il2CppSystem.Collections.Generic.List<T> list)
    {
        public Il2CppSystem.Collections.Generic.IEnumerable<T> ToIEnumerable()
        {
            return new Il2CppSystem.Collections.Generic.IEnumerable<T>(list.Pointer);
        }
    }


    public static Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<T> ToIl2CppReferenceArray<T>
        (this Il2CppSystem.Collections.Generic.IEnumerable<T> enumerable)
        where T : Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase
    {
        return enumerable.ToArray().ToIl2CppReferenceArray();
    }

    public static Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<T> ToIl2CppReferenceArray<T>
        (this System.Collections.Generic.IEnumerable<T> source)
        where T : Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase
    {
        return new Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<T>(source.ToArray());
    }

    extension<T>(Il2CppSystem.Collections.Generic.IEnumerable<T> enumerable)
    {
        public Il2CppSystem.Collections.Generic.List<T> ToIl2CppList()
        {
            return new Il2CppSystem.Collections.Generic.List<T>(enumerable);
        }

        public T GetRandomOne()
        {
            return enumerable.ToIl2CppList().ToManagedList().GetRandomOne();
        }
    }

    extension<T>(Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<T> source) where T : Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase
    {
        public Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<T> SortByToString(
)
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
    }

    extension<KeyT, ValueT>(Il2CppSystem.Collections.Generic.Dictionary<KeyT, ValueT> dict)
    {
        public System.Collections.Generic.List<KeyT> FilterKey(Predicate<ValueT> condition)
        {
            var result = new System.Collections.Generic.List<KeyT>();
            foreach (var kv in dict)
            {
                if (condition(kv.Value)) result.Add(kv.Key);
            }
            return result;
        }

        public System.Collections.Generic.List<KeyT> GetKeys()
        {
            var result = new System.Collections.Generic.List<KeyT>();
            foreach (var kv in dict)
            {
                result.Add(kv.Key);
            }
            return result;
        }

        public System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<KeyT, ValueT>> ToList()
        {
            var result = new System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<KeyT, ValueT>>();
            foreach (var kv in dict)
            {
                result.Add(new System.Collections.Generic.KeyValuePair<KeyT, ValueT>(kv.Key, kv.Value));
            }
            return result;
        }
    }

    extension<TKey, TValue>(System.Collections.Generic.Dictionary<TKey, TValue> dict)
    {
        public Il2CppSystem.Collections.Generic.Dictionary<TKey, TValue> ToIl2CppDictionary(
)
        {
            if (dict == null) return null;
            var result = new Il2CppSystem.Collections.Generic.Dictionary<TKey, TValue>();
            foreach (var kvp in dict)
            {
                result.Add(kvp.Key, kvp.Value);
            }
            return result;
        }
    }

    extension<T>(Il2CppSystem.Collections.Generic.List<T> il2cppList)
    {
        public System.Collections.Generic.List<T> ToManagedList(
)
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



    extension<T>(Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<T> array) where T : Il2CppInterop.Runtime.InteropTypes.Il2CppObjectBase
    {
        public string DumpElements(string separator = ", ")
        {
            if (array == null)
                return "<Il2CppReferenceArray: null>";

            int length = array.Length;
            if (length == 0)
                return "<Il2CppReferenceArray: empty>";

            var sb = new System.Text.StringBuilder(1024);

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
    }

    extension(Action action)
    {
        public Il2CppSystem.Action ToIl2cppAction()
        {
            return Il2CppInterop.Runtime.DelegateSupport.ConvertDelegate<Il2CppSystem.Action>(action);
        }
    }

    extension<T>(Action<T> action)
    {
        public Il2CppSystem.Action<T> ToIl2cppAction()
        {
            return Il2CppInterop.Runtime.DelegateSupport.ConvertDelegate<Il2CppSystem.Action<T>>(action);
        }
    }
}

public static class Il2CppIEnumerableExtensions
{
    extension(Il2CppSystem.Collections.IEnumerable source)
    {
        /// <summary>
        /// 是否至少存在一个元素
        /// </summary>
        public bool Any()
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            var enumerator = source.GetEnumerator();
            return enumerator.MoveNext();
        }

        /// <summary>
        /// 是否存在满足条件的元素
        /// </summary>
        public bool Any(
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
        public bool All(
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
}


public sealed class LogWrapper
{
    public readonly BepInEx.Logging.ManualLogSource _inner;
    public readonly string _class_tag;

    public LogWrapper(BepInEx.Logging.ManualLogSource inner, string tag)
    {
        _inner = inner;
        _class_tag = tag;
    }

    private static string GetTime() => DateTime.Now.ToString("HH:mm:ss.fff");

    private string TagString(bool withTag) => withTag ? $"[{_class_tag}] " : "";

    public void Debug(string msg, bool withTag = true) => _inner.LogDebug($"[{GetTime()}] {TagString(withTag)}{msg}");
    public void Info(string msg, bool withTag = true) => _inner.LogInfo($"[{GetTime()}] {TagString(withTag)}{msg}");
    public void Message(string msg, bool withTag = true) => _inner.LogMessage($"[{GetTime()}] {TagString(withTag)}{msg}");
    public void Warning(string msg, bool withTag = true) => _inner.LogWarning($"[{GetTime()}] {TagString(withTag)}{msg}");
    public void Error(string msg, bool withTag = true) => _inner.LogError($"[{GetTime()}] {TagString(withTag)}{msg}");
    public void Fatal(string msg, bool withTag = true) => _inner.LogFatal($"[{GetTime()}] {TagString(withTag)}{msg}");

    public void DebugCaller(string msg, bool withTag = true) => _inner.LogDebug($"[{GetTime()}] {TagString(withTag)}[{GetOuterCallerName()}] {msg}");
    public void InfoCaller(string msg, bool withTag = true) => _inner.LogInfo($"[{GetTime()}] {TagString(withTag)}[{GetOuterCallerName()}] {msg}");
    public void MessageCaller(string msg, bool withTag = true) => _inner.LogMessage($"[{GetTime()}] {TagString(withTag)}[{GetOuterCallerName()}] {msg}");
    public void WarningCaller(string msg, bool withTag = true) => _inner.LogWarning($"[{GetTime()}] {TagString(withTag)}[{GetOuterCallerName()}] {msg}");
    public void ErrorCaller(string msg, bool withTag = true) => _inner.LogError($"[{GetTime()}] {TagString(withTag)}[{GetOuterCallerName()}] {msg}");
    public void FatalCaller(string msg, bool withTag = true) => _inner.LogFatal($"[{GetTime()}] {TagString(withTag)}[{GetOuterCallerName()}] {msg}");

    public void LogDebug(string msg, bool withTag = true) => Debug(msg, withTag);
    public void LogInfo(string msg, bool withTag = true) => Info(msg, withTag);
    public void LogMessage(string msg, bool withTag = true) => Message(msg, withTag);
    public void LogWarning(string msg, bool withTag = true) => Warning(msg, withTag);
    public void LogError(string msg, bool withTag = true) => Error(msg, withTag);
    public void LogFatal(string msg, bool withTag = true) => Fatal(msg, withTag);

    public void LogStacktrace() => Functional.LogStacktrace(_inner);
    public string GetCallerName([System.Runtime.CompilerServices.CallerMemberName] string caller = null) => caller;
    public string GetOuterCallerName() => Functional.GetCallerName(3);
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

    public static string GetCallerName(int layer = 1) => new System.Diagnostics.StackTrace().GetFrame(layer)?.GetMethod()?.Name;

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
public static partial class Panel
{
    public static Il2CppSystem.Collections.Generic.Stack<Il2CppSystem.Collections.Generic.Stack<DEYU.AdpUISystem.PanelCollection.UIPanelImpl>> PanelStack => DEYU.AdpUISystem.Managers.AdpUIPanelManager.Instance?.m_PanelStack;
    public static Il2CppSystem.Collections.Generic.Stack<DEYU.AdpUISystem.PanelCollection.UIPanelImpl> TopPanelStack => PanelStack != null && PanelStack.Count > 0 ? PanelStack.Peek() : null;
    public static DEYU.AdpUISystem.PanelCollection.UIPanelImpl TopPanel => TopPanelStack != null && TopPanelStack.Count > 0 ? TopPanelStack.Peek() : null;
    public static string TopPanelName => TopPanel?.ControlledPanelName;
    public static Common.DialogUtility.DialogPannel TopPanelAsDialog => TopPanel?.ControlledPanel as Common.DialogUtility.DialogPannel;
    public static void CloseTopDialogPanel() => TopPanelAsDialog?.InterruptDialog(new UnityEngine.InputSystem.InputAction.CallbackContext());

    private static Il2CppSystem.Action<DEYU.AdpUISystem.PanelCollection.FadeType> _dialog_panel_close_callback;


    public static void CloseTopPanel()
    {
        void OnDialogPanelFadeFinished(DEYU.AdpUISystem.PanelCollection.FadeType _, Common.DialogUtility.DialogPannel currentPanel)
        {
            if (TopPanelAsDialog != null)
            {
                CloseTopDialogPanel();
                return;
            }
            currentPanel.remove_OnPanelOpenCloseFadeFinishCallback(_dialog_panel_close_callback);
            Log.Warning("All dialog panels closed, callback removed.");
            CloseActivePanelsBeforeSceneTransit();
        }
        ;

        void RegisterDialogPanelCloseCallback(Common.DialogUtility.DialogPannel currentPanel)
        {
            System.Action<DEYU.AdpUISystem.PanelCollection.FadeType> managed = _ => OnDialogPanelFadeFinished(_, currentPanel);
            _dialog_panel_close_callback = Il2CppInterop.Runtime.DelegateSupport.ConvertDelegate<Il2CppSystem.Action<DEYU.AdpUISystem.PanelCollection.FadeType>>(managed);
            TopPanelAsDialog.add_OnPanelOpenCloseFadeFinishCallback(_dialog_panel_close_callback);
        }
        ;

        if (TopPanelAsDialog != null)
        {
            Log.Warning($"Closed dialog panel {TopPanelName}");
            var currentPanel = TopPanelAsDialog;
            CloseTopDialogPanel();
            RegisterDialogPanelCloseCallback(currentPanel);     // Interrupt all dialog panels
        }
        else
        {
            if ("DialogPannel(Clone)".Equals(TopPanelName))
            {
                Log.Error($"TopPanelName is {TopPanelName}, will try convert then close");
                CloseTopDialogPanel();
            }
            else if ("WorkSceneSustainedPannel(Clone)".Equals(TopPanelName))
            {
                Log.Warning($"Will not close {TopPanelName}");
            }
            else
            {
                if (TopPanel?.ControlledPanel?.IsPanelOpened is true)
                {
                    Log.Warning($"Closed regular panel {TopPanelName}");
                    TopPanel?.ControlledPanel?.ClosePanel();
                }
                else
                {
                    Log.Error($"regular panel {TopPanelName} is not opened!");
                }
            }
        }
    }



    /// <summary>
    /// API Common.UI.GeneralSustainedPannel.CurrentActiveSustainedPannel.CloseActivePannel()
    /// Can close:
    /// DayScene_FastTravelPannel(Clone)
    /// NoteBook_ProfilePannel(Clone)
    /// NoteBook_ProfilePannel_Page#1(Clone)
    /// NoteBook_ProfilePannel_Page#2(Clone)
    /// NoteBook_ProfilePannel_Page#3(Clone)
    /// NoteBook_RecipePannel(Clone)
    /// NoteBook_NewsPannel(Clone)
    /// NoteBook_MissionPannel(Clone)
    /// NoteBook_NewsPanelSelector(Clone)
    /// NoteBook_AlbumPannel(Clone)
    /// NoteBook_AlbumGuestSubSubPannel(Clone)
    /// NoteBook_AlbumItemSubPannel(Clone)
    /// Storage_MainPannel(Clone)
    /// Storage_OtherPannel(Clone)
    ///
    /// Cannot close and will throw exception, then game will stuck:
    /// DayScene_FastTravelConfirmPannel(Clone)
    /// FlattenedFilterPanel(Clone)
    /// EscMenu_LoadSubPannel(Clone)
    /// IzakayaDetailPanel(Clone) (not try yet)
    /// IzakayaConfigRemindSubPanel(Clone)
    /// IzakayaPresetPannel(Clone)
    /// IzakayaConfigPannelSubPannel(Clone)
    /// </summary>
    public static void CloseActivePanelsBeforeSceneTransit()
    {
        string[] PanelToBeClosed = ["NoteBook", "Storage", "DayScene_FastTravelPannel", "EscMenu"];
        string[] PanelMustBeClosedFirst = ["DayScene_FastTravelConfirmPannel(Clone)", "FlattenedFilterPanel(Clone)", "EscMenu_LoadSubPannel(Clone)",
            "DialogPannel(Clone)",
            "IzakayaDetailPanel(Clone)", "IzakayaConfigRemindSubPanel(Clone)", "IzakayaPresetPannel(Clone), IzakayaConfigPannelSubPannel(Clone)",
            "WorkSceneQTEPannel(Clone)",
            // "WorkSceneServePannel(Clone)", "WorkSceneTrayPannel(Clone)"
            ];

        if (TopPanel == null) return;
        var count = TopPanelStack.Count;
        for (int i = 0; i < 2; i++)
        {
            if (PanelMustBeClosedFirst.Any((panel) => panel.Equals(TopPanelName)))
            {
                CloseTopPanel();
            }
            else
            {
                break;
            }
        }

        if (TopPanel == null) return;
        if (PanelToBeClosed.Any((panel) => TopPanelName.Contains(panel)))
        {
            Log.Warning($"Closed panel {TopPanelName} in SustainedPannel");
            Common.UI.GeneralSustainedPannel.CurrentActiveSustainedPannel.CloseActivePannel();
        }
    }

    public static void CloseTargetPannelIfOnTop(string name)
    {
        if (name.Equals(TopPanelName))   // "IzakayaConfigRemindSubPanel(Clone)"
        {
            CloseTopPanel();
        }
    }

    public static void ClosePanelUntil(string name, string[] exclude)
    {
        while (true)
        {
            if (TopPanel == null) return;
            if (!name.Equals(TopPanelName) && !exclude.Any((ex) => ex.Equals(name)))
            {
                CloseTopPanel();
            }
            else
            {
                return;
            }
        }
        // GameData.Core.Collections.CharacterUtility.DataBaseCharacter.port.
        // GameData.Core.Collections.CharacterUtility.DataBaseCharacter.m_PlayerActiveSkinPortrayal;
        // GameData.RunTime.Common.RunTimeAlbum.ChangePlayerSkin(1);   // changed skin, but not album. Parameter: skin id
        // GameData.Core.Collections.CharacterUtility.DataBaseCharacter.LoadActivePlayerSkinAsync(GameData.RunTime.Common.RunTimeStorage.GetAllClothes()[1]);  // changed album, not skin
        // GameData.Core.Collections.DaySceneUtility.DataBaseDay.allNPCs["Kosuzu"].GetVisual();
        // MetaMystia.MystiaManager.Instance.GetCharacterUnit(false).UpdateCharacterSprite(GameData.Core.Collections.DaySceneUtility.DataBaseDay.allNPCs["Kosuzu"].GetVisual());
    }
}

public static class NativeDllExtractor
{
    public static string Extract(string resourceName, string fileName)
    {
        string targetPath = System.IO.Path.Combine(
            AppContext.BaseDirectory,
            fileName
        );

        if (System.IO.File.Exists(targetPath))
            return targetPath;

        using var stream =
            Assembly.GetExecutingAssembly()
                    .GetManifestResourceStream(resourceName)
            ?? throw new Exception("Resource not found: " + resourceName);

        using var file = System.IO.File.Create(targetPath);
        stream.CopyTo(file);

        return targetPath;
    }
}

public class TestClass
{
    public static GameData.Profile.DLC1_YuumaBossData Test()
    {
        return NightScene.SceneManager.Instance.m_LoadedBossData as GameData.Profile.DLC1_YuumaBossData;
    }
}
