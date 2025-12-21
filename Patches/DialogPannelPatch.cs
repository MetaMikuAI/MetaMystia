using HarmonyLib;
using Common.DialogUtility;
using Il2CppSystem.Collections.Generic;
using DEYU.AssetHandleUtility;
using DEYU.Utils;
using Il2CppSystem.IO;
using UnityEngine;
using System;
using System.IO;
using Il2CppSystem.Runtime.Remoting.Messaging;


namespace MetaMystia;


[HarmonyPatch(typeof(Common.DialogUtility.DialogPannel))]
public class DialogPannelPatch : PatchBase<DialogPannelPatch>
{
    
    [HarmonyPatch(nameof(DialogPannel.GetSpeakerName))] // (ref string line, DialogMeta meta, out string speakerName)
    [HarmonyPostfix]
    public static void GetSpeakerName_Postfix(ref string line, DialogMeta meta, string speakerName)
    {
        Log.LogWarning($"{LOG_TAG} GetSpeakerName called with meta.SpeakerID: {meta.ToString()}, line: {line}, speakerName: {speakerName}");
    }

    // prefix
    [HarmonyPatch(nameof(DialogPannel.GetSpeakerVisual))]
    [HarmonyPrefix]
    public static bool GetSpeakerVisual_Prefix(IAssetHandleArray<UnityEngine.Sprite> playerPortrayalCollection, IReadOnlyDictionary<int, IAssetHandleArray<UnityEngine.Sprite>> specialNPCPortrayalCollectionDictionary, IReadOnlyDictionary<DialogMeta, IAssetHandle<UnityEngine.Sprite>> overrideDialogMetaToSprites, DialogMeta meta, ref UnityEngine.Sprite visual)
    {
        // Log.LogWarning($"{LOG_TAG} [Prefix] GetSpeakerVisual called with meta.SpeakerID: {meta.ToString()}, visual: {visual}");
        
        var config = ResourceExManager.GetCharacterConfig(meta.speakerIdentity.speakerId, meta.speakerIdentity.speakerType.ToString());
        if (config != null && config.portraits != null && config.portraits.Count > 0)
        {
            // Assuming we want the first portrait for now, or logic to select based on expression if available
            var portrait = config.portraits[0]; 
            if (portrait != null && !string.IsNullOrEmpty(portrait.path))
            {
                // Log.LogWarning($"{LOG_TAG} [Prefix] Detected Special Guest with ID {meta.speakerIdentity.speakerId}, substituting visual from {portrait.path}.");
                visual = ResourceExManager.GetSprite(portrait.path);
                return false;
            }
        }
        
        return true;
    }

}