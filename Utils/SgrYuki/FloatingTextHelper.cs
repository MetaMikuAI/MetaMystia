using BepInEx.Unity.IL2CPP.Utils;
using MetaMystia;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace SgrYuki;

public static class FloatingTextHelper
{
    private static GameObject activeTextPeer;
    private static GameObject activeTextSelf;

    #region 持久玩家标签（显示玩家 ID）

    private static readonly Dictionary<int, GameObject> playerLabels = new();

    /// <summary>
    /// 在角色脚下方创建/更新持久标签（显示玩家 ID）。
    /// 仅在联机且状态信息可见时显示。
    /// </summary>
    public static void SetPlayerLabel(int uid, string displayName, Transform parent)
    {
        if (parent == null) return;
        RemovePlayerLabel(uid);

        var go = new GameObject($"PlayerLabel_{uid}");
        go.transform.SetParent(parent, false);
        go.transform.localPosition = new Vector3(0, 1.2f, 0);

        var tmp = go.AddComponent<TextMeshPro>();
        tmp.text = displayName;
        tmp.fontSize = 3.5f;
        tmp.alignment = TextAlignmentOptions.Center;
        tmp.color = new Color(1f, 1f, 0.7f, 0.85f);

        tmp.fontMaterial.EnableKeyword("OUTLINE_ON");
        tmp.outlineColor = Color.black;
        tmp.outlineWidth = 0.075f;

        go.SetActive(PluginManager.IsStatusVisible);

        playerLabels[uid] = go;
    }

    /// <summary>
    /// 更新已有标签的显示文本（例如玩家改名时），若标签不存在则忽略
    /// </summary>
    public static void UpdatePlayerLabel(int uid, string displayName)
    {
        if (playerLabels.TryGetValue(uid, out var go) && go != null)
        {
            var tmp = go.GetComponent<TextMeshPro>();
            if (tmp != null) tmp.text = displayName;
        }
    }

    public static void RemovePlayerLabel(int uid)
    {
        if (playerLabels.TryGetValue(uid, out var go))
        {
            if (go != null) Object.Destroy(go);
            playerLabels.Remove(uid);
        }
    }

    public static void ClearAllLabels()
    {
        foreach (var go in playerLabels.Values)
        {
            if (go != null) Object.Destroy(go);
        }
        playerLabels.Clear();
    }

    public static void SetLabelsVisible(bool visible)
    {
        foreach (var go in playerLabels.Values)
        {
            if (go != null) go.SetActive(visible);
        }
    }

    #endregion

    private static GameObject MakeFloatingText(Transform parent, string text)
    {
        var go = new GameObject("FloatingText");
        go.transform.SetParent(parent, false);
        go.transform.localPosition = new Vector3(0, 2.0f, 0);

        var tmp = go.AddComponent<TextMeshPro>();
        tmp.text = text;
        tmp.fontSize = 5f;
        tmp.alignment = TextAlignmentOptions.Center;
        tmp.color = Color.white;

        tmp.fontMaterial.EnableKeyword("OUTLINE_ON");      // 描边
        tmp.outlineColor = Color.black;
        tmp.outlineWidth = 0.075f;                         // 描边粗细，范围 0~1

        return go;
    }
    private static void ShowFloatingText(Common.CharacterUtility.CharacterControllerUnit comp, string text, float duration = 5f)
    {
        if (activeTextPeer != null)
        {
            UnityEngine.Object.Destroy(activeTextPeer);
        }
        if (comp == null)
        {
            return;
        }
        activeTextPeer = MakeFloatingText(comp.transform, text);
        comp.StartCoroutine(FadeAndDestroy(activeTextPeer.GetComponent<TextMeshPro>(), duration));
    }

    private static void ShowFloatingTextSelf(string text, float duration = 5f)
    {
        if (activeTextSelf != null)
        {
            UnityEngine.Object.Destroy(activeTextSelf);
        }

        var character = PlayerManager.Local.GetCharacterUnit();
        if (character == null)
        {
            return;
        }
        activeTextSelf = MakeFloatingText(character.transform, text);
        character.StartCoroutine(FadeAndDestroy(activeTextSelf.GetComponent<TextMeshPro>(), duration));
    }

    private static System.Collections.IEnumerator FadeAndDestroy(TextMeshPro tmp, float duration)
    {
        float t = 0f;

        while (t < duration)
        {
            t += Time.deltaTime;
            yield return null;
        }

        float fade = 0f;
        while (fade < 0.5f)
        {
            fade += Time.deltaTime;
            float alpha = Mathf.Lerp(1f, 0f, fade / 0.5f);

            var c = tmp.color;
            c.a = alpha;
            tmp.color = c;

            yield return null;
        }

        if (tmp != null && tmp.gameObject != null)
        {
            GameObject.Destroy(tmp.gameObject);
        }
    }

    public static void ShowFloatingTextOnMainThread(Common.CharacterUtility.CharacterControllerUnit component, string Message)
    {
        PluginManager.Instance.RunOnMainThread(() => ShowFloatingText(component, Message));
    }

    public static void ShowFloatingTextSelfOnMainThread(string Message)
    {
        PluginManager.Instance.RunOnMainThread(() => ShowFloatingTextSelf(Message));
    }
}
