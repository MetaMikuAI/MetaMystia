using BepInEx.Unity.IL2CPP.Utils;
using TMPro;
using UnityEngine;

namespace MetaMystia;

public static class FloatingTextHelper
{
    private static GameObject activeTextPeer;
    private static GameObject activeTextSelf;

    private static GameObject MakeFloatingText(Transform parent, string text)
    {
        var go = new GameObject("FloatingText");
        go.transform.SetParent(parent, false);
        go.transform.localPosition = new Vector3(0, 1.6f, 0);

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
    private static void ShowFloatingText(DayScene.Interactables.Collections.ConditionComponents.CharacterConditionComponent comp, string text, float duration = 5f)
    {
        if (activeTextPeer != null)
        {
            UnityEngine.Object.Destroy(activeTextPeer);
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
        
        var character = MystiaManager.Instance.GetCharacterUnit();
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

    public static void ShowFloatingTextOnMainThread(DayScene.Interactables.Collections.ConditionComponents.CharacterConditionComponent component, string Message)
    {
        PluginManager.Instance.RunOnMainThread(() => ShowFloatingText(component, Message));
    }

    public static void ShowFloatingTextSelfOnMainThread(string Message)
    {
        PluginManager.Instance.RunOnMainThread(() => ShowFloatingTextSelf(Message));
    }
}
