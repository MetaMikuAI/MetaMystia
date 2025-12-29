using Common.DialogUtility;
using DEYU.AssetHandleUtility;
using HarmonyLib;
using Il2CppSystem.Collections.Generic;


namespace MetaMystia;


[HarmonyPatch(typeof(Common.DialogUtility.DialogPannel))]
[AutoLog]
public partial class DialogPannelPatch
{
    
    // [HarmonyPatch(nameof(DialogPannel.GetSpeakerName))]
    // [HarmonyPostfix]
    // public static void GetSpeakerName_Postfix(ref string line, DialogMeta meta, string speakerName)
    // {
    //     Log.LogWarning($" with meta.SpeakerID: {meta.ToString()}, line: {line}, speakerName: {speakerName}");
    // }

    [HarmonyPatch(nameof(DialogPannel.GetSpeakerVisual))]
    [HarmonyPrefix]
    public static bool GetSpeakerVisual_Prefix(IAssetHandleArray<UnityEngine.Sprite> playerPortrayalCollection, IReadOnlyDictionary<int, IAssetHandleArray<UnityEngine.Sprite>> specialNPCPortrayalCollectionDictionary, IReadOnlyDictionary<DialogMeta, IAssetHandle<UnityEngine.Sprite>> overrideDialogMetaToSprites, DialogMeta meta, ref UnityEngine.Sprite visual)
    {        
        var id = meta.speakerIdentity.speakerId;
        var type = meta.speakerIdentity.speakerType.ToString();
        var pid = meta.speakerIdentity.speakerPortrayalVariationId;

        if (ResourceExManager.ExistsCharacterConfig(id, type))
        {
            visual = ResourceExManager.GetPortraitSprite(id, pid);
            return false;
        }
        
        return true;
    }

}