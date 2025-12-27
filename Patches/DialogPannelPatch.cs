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

    // prefix
    [HarmonyPatch(nameof(DialogPannel.GetSpeakerVisual))]
    [HarmonyPrefix]
    public static bool GetSpeakerVisual_Prefix(IAssetHandleArray<UnityEngine.Sprite> playerPortrayalCollection, IReadOnlyDictionary<int, IAssetHandleArray<UnityEngine.Sprite>> specialNPCPortrayalCollectionDictionary, IReadOnlyDictionary<DialogMeta, IAssetHandle<UnityEngine.Sprite>> overrideDialogMetaToSprites, DialogMeta meta, ref UnityEngine.Sprite visual)
    {        
        var config = ResourceExManager.GetCharacterConfig(meta.speakerIdentity.speakerId, meta.speakerIdentity.speakerType.ToString());
        if (config != null && config.portraits != null && config.portraits.Count > 0)
        {
            var portrait = config.portraits[0]; 
            if (portrait != null && !string.IsNullOrEmpty(portrait.path))
            {
                visual = ResourceExManager.GetSprite(portrait.path, config.ModRoot);
                Log.LogInfo($"GetSpeakerVisual_Prefix: Loaded custom sprite for characterType {meta.speakerIdentity.speakerType} characterId {meta.speakerIdentity.speakerId} from path {portrait.path} (ModRoot: {config.ModRoot})");
                return false;
            }
        }
        
        return true;
    }

}