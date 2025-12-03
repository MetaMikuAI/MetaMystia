using BepInEx.Unity.IL2CPP.Utils;
using TMPro;
using UnityEngine;

namespace MetaMystia;

public static class FloatingTextHelper
{
    private static GameObject activeTextPeer;
    private static GameObject activeTextSelf;

    private static void ShowFloatingText(DayScene.Interactables.Collections.ConditionComponents.CharacterConditionComponent comp, string text, float duration = 3f)
    {
        if (activeTextPeer != null)
        {
            UnityEngine.Object.Destroy(activeTextPeer);
        }
        var go = new GameObject("FloatingText");

        go.transform.SetParent(comp.transform, false);
        go.transform.localPosition = new Vector3(0, 1.5f, 0);

        var tmp = go.AddComponent<TextMeshPro>();
        tmp.text = text;
        tmp.fontSize = 5f;
        tmp.alignment = TextAlignmentOptions.Center;
        tmp.color = Color.white;

        activeTextPeer = go;
        comp.StartCoroutine(FadeAndDestroy(tmp, duration));
    }

    private static void ShowFloatingTextSelf(string text, float duration = 3f)
    {
        if (activeTextSelf != null)
        {
            UnityEngine.Object.Destroy(activeTextSelf);
        }
        var go = new GameObject("FloatingText");
        var character = MystiaManager.Instance.GetInputGenerator().Character;

        go.transform.SetParent(character.transform, false);
        go.transform.localPosition = new Vector3(0, 1.5f, 0);

        var tmp = go.AddComponent<TextMeshPro>();
        tmp.text = text;
        tmp.fontSize = 5f;
        tmp.alignment = TextAlignmentOptions.Center;
        tmp.color = Color.white;

        activeTextSelf = go;
        character.StartCoroutine(FadeAndDestroy(tmp, duration));
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

    public static void ShowFloatingTextOnMainThread(DayScene.Interactables.Collections.ConditionComponents.CharacterConditionComponent component, string Message)
    {
        PluginManager.Instance.RunOnMainThread(() =>
        {
            try
            {
                ShowFloatingText(component, Message);
            }
            catch (System.Exception ex)
            {
                Plugin.Instance.Log.LogError($"showing floating text fail, {ex.Message}, {ex.StackTrace}");
            }
        });
    }

    public static void ShowFloatingTextSelfOnMainThread(string Message)
    {
        PluginManager.Instance.RunOnMainThread(() =>
        {
            try
            {
                ShowFloatingTextSelf(Message);
            }
            catch (System.Exception ex)
            {
                Plugin.Instance.Log.LogError($"showing floating text fail, {ex.Message}, {ex.StackTrace}");
            }
        });
    }
}
