using BepInEx.Unity.IL2CPP.Utils;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using MetaMystia;
using System.Linq;
using SgrYuki.Utils;

namespace SgrYuki;

[AutoLog]
public static partial class NotifyOverlay
{
    // ===== 内部结构 =====
    private class EntryState
    {
        public TextMeshProUGUI Tmp;
        public float TargetY;
        public Coroutine MoveCoroutine;
    }

    // ===== UI =====
    private static Canvas overlayCanvas;
    private static RectTransform stackRoot;
    private static Material _sharedOutlineMat;

    // ===== 配置 =====
    private const int MaxLines = 8;
    private const float FontSize = 40f;
    private const float Spacing = 25f;
    private const float LineHeight = FontSize + Spacing;

    private const float BottomHeight = 60f;
    private const float HorizontalSize = 1000f;

    private const float MoveDuration = 0.2f;
    private const float RemoveMoveDistance = 400f;
    private const float RemoveFadeTime = 1f;

    private static float OutlineWidth = 0.06f;
    private static Color Color = Color.white;

    private static readonly List<EntryState> _entries = new();

    private static List<TextMeshProUGUI> TextMeshProUGUIs => Object.FindObjectsOfType<TextMeshProUGUI>().ToList();
    private static TextMeshProUGUI NotifyTMPUGUI
        => TextMeshProUGUIs.FirstOrDefault((tmp) => tmp.font.name.Equals("江西拙楷2.0") && tmp.fontMaterial.mainTexture.name.Equals("江西拙楷2.0 Atlas"));

    private static TextMeshProUGUI _cachedTMPUGUI;
    private static TMP_FontAsset _cachedFontAsset;
    private static Material _cachedFontMaterial;

    public static void CacheTMPUGUI(string text)
    {
        _cachedTMPUGUI ??= TextMeshProUGUIs.FirstOrDefault((tmp) => tmp.text.Equals(text));
        if (_cachedTMPUGUI != null)
        {
            _cachedFontAsset = _cachedTMPUGUI.font;
            _cachedFontMaterial = _cachedTMPUGUI.fontMaterial;
            Log.InfoCaller($"cached {_cachedTMPUGUI.font.name}");
        }
    }
    public static void NotifyAndEnsureTMPUGUI(string text)
    {
        Notify.ShowOnNextAvailableScene(text, () => CacheTMPUGUI(text));
    }

    // ====================================================================
    // UI 初始化
    // ====================================================================
    private static void EnsureUI()
    {
        if (overlayCanvas != null) return;

        var canvasGO = new GameObject("NotifyCanvas");
        Object.DontDestroyOnLoad(canvasGO);

        overlayCanvas = canvasGO.AddComponent<Canvas>();
        overlayCanvas.renderMode = RenderMode.ScreenSpaceOverlay;
        overlayCanvas.sortingOrder = short.MaxValue;

        var scaler = canvasGO.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1920, 1080);

        canvasGO.AddComponent<GraphicRaycaster>();

        var rootGO = new GameObject("NotifyStack");
        rootGO.transform.SetParent(canvasGO.transform, false);

        stackRoot = rootGO.AddComponent<RectTransform>();
        stackRoot.anchorMin = new Vector2(0f, 0f);
        stackRoot.anchorMax = new Vector2(0f, 0f);
        stackRoot.pivot = new Vector2(0f, 0f);
        stackRoot.anchoredPosition = new Vector2(20f, BottomHeight);
        stackRoot.sizeDelta = new Vector2(
            HorizontalSize,
            MaxLines * LineHeight + BottomHeight
        );
    }

    // ====================================================================
    // 公共接口
    // ====================================================================
    [OnMainThread]
    public static void Show(string text, float duration = 8f)
        => Show(PluginManager.Instance, text, duration);

    [OnMainThread]
    public static void Show(MonoBehaviour host, string text, float duration)
    {
        EnsureUI();

        // ===== 超出最大行数 =====
        if (_entries.Count >= MaxLines)
        {
            var oldest = _entries[0];
            _entries.RemoveAt(0);

            if (oldest?.Tmp != null)
                host.StartCoroutine(FadeMoveAndDestroy(oldest.Tmp));
        }

        // ===== 新条目 =====
        var tmp = CreateItem(text);
        var state = new EntryState
        {
            Tmp = tmp,
            TargetY = BottomHeight
        };

        _entries.Add(state);

        RefreshTargets(host);

        host.StartCoroutine(FadeIn(tmp));
        host.StartCoroutine(FadeAndRemove(state, duration));
    }

    // ====================================================================
    // 创建文本
    // ====================================================================
    private static TextMeshProUGUI CreateItem(string text)
    {
        var go = new GameObject("NotifyItem");
        go.transform.SetParent(stackRoot, false);

        var tmp = go.AddComponent<TextMeshProUGUI>();

        if (_cachedFontAsset != null && _cachedFontMaterial != null)
        {
            tmp.font = _cachedFontAsset;
            tmp.fontMaterial = _cachedFontMaterial;
            tmp.outlineWidth = OutlineWidth;
            tmp.color = Color;
        }
        else
        {
            Log.InfoCaller($"failed to get native TMP");
            tmp.font = TMP_Settings.defaultFontAsset;
            ApplySharedOutline(tmp);
            tmp.color = Color.yellow;
            tmp.fontWeight = FontWeight.Heavy;
            tmp.raycastTarget = false;
        }

        tmp.enableWordWrapping = true;
        tmp.text = text;
        tmp.fontSize = FontSize;
        tmp.alignment = TextAlignmentOptions.BottomLeft;

        var rt = tmp.rectTransform;
        rt.anchorMin = rt.anchorMax = new Vector2(0f, 0f);
        rt.pivot = new Vector2(0f, 0f);
        rt.sizeDelta = new Vector2(HorizontalSize, FontSize);
        rt.anchoredPosition = new Vector2(0f, BottomHeight);
        // rt.anchoredPosition = new Vector2(0f, 0f);

        return tmp;
    }

    private static void ApplySharedOutline(TextMeshProUGUI tmp)
    {
        if (_sharedOutlineMat == null)
        {
            _sharedOutlineMat = Object.Instantiate(tmp.fontMaterial);
            _sharedOutlineMat.EnableKeyword("OUTLINE_ON");
            _sharedOutlineMat.SetColor("_OutlineColor", Color.black);
            _sharedOutlineMat.SetFloat("_OutlineWidth", FontSize / 1000f);
        }

        tmp.fontMaterial = _sharedOutlineMat;
    }

    // ====================================================================
    // 核心：刷新所有条目的目标位置
    // ====================================================================
    private static void RefreshTargets(MonoBehaviour host)
    {
        for (int i = 0; i < _entries.Count; i++)
        {
            var e = _entries[i];
            if (e?.Tmp == null) continue;

            float targetY = BottomHeight + (_entries.Count - 1 - i) * LineHeight;
            e.TargetY = targetY;

            if (e.MoveCoroutine != null)
                host.StopCoroutine(e.MoveCoroutine);

            e.MoveCoroutine = host.StartCoroutine(
                AnimateMoveToY(e.Tmp.rectTransform, targetY)
            );
        }
    }

    // ====================================================================
    // 动画
    // ====================================================================
    private static System.Collections.IEnumerator AnimateMoveToY(
        RectTransform rt, float targetY)
    {
        if (rt == null) yield break;

        Vector2 start = rt.anchoredPosition;
        Vector2 end = new Vector2(start.x, targetY);

        float t = 0f;
        while (t < MoveDuration)
        {
            if (rt == null) yield break;

            t += Time.unscaledDeltaTime;
            float p = Mathf.Clamp01(t / MoveDuration);
            rt.anchoredPosition = Vector2.Lerp(start, end, p);

            yield return null;
        }

        if (rt != null)
            rt.anchoredPosition = end;
    }

    private static System.Collections.IEnumerator FadeIn(TextMeshProUGUI tmp)
    {
        if (tmp == null) yield break;

        var c = tmp.color;
        c.a = 0f;
        tmp.color = c;

        float t = 0f;
        while (t < 0.2f)
        {
            if (tmp == null) yield break;

            t += Time.unscaledDeltaTime;
            c.a = Mathf.Lerp(0f, 1f, t / 0.2f);
            tmp.color = c;
            yield return null;
        }
    }

    private static System.Collections.IEnumerator FadeAndRemove(
        EntryState state, float duration)
    {
        yield return new WaitForSecondsRealtime(duration);

        if (state?.Tmp == null) yield break;

        float t = 0f;
        var tmp = state.Tmp;

        while (t < 1f)
        {
            if (tmp == null) yield break;

            t += Time.unscaledDeltaTime;
            var c = tmp.color;
            c.a = Mathf.Lerp(1f, 0f, t);
            tmp.color = c;

            yield return null;
        }

        if (tmp != null)
        {
            _entries.Remove(state);
            Object.Destroy(tmp.gameObject);
        }
    }

    private static System.Collections.IEnumerator FadeMoveAndDestroy(
        TextMeshProUGUI tmp)
    {
        if (tmp == null) yield break;

        var rt = tmp.rectTransform;
        var go = tmp.gameObject;

        Vector2 startPos = rt.anchoredPosition;
        Vector2 endPos = startPos + Vector2.up * RemoveMoveDistance;
        Color startColor = tmp.color;

        float t = 0f;
        while (t < RemoveFadeTime)
        {
            if (tmp == null || rt == null || go == null) yield break;

            t += Time.unscaledDeltaTime;
            float p = t / RemoveFadeTime;

            rt.anchoredPosition = Vector2.Lerp(startPos, endPos, p);

            var c = startColor;
            c.a = Mathf.Lerp(1f, 0f, p);
            tmp.color = c;

            yield return null;
        }

        if (go != null)
            Object.Destroy(go);
    }
}
