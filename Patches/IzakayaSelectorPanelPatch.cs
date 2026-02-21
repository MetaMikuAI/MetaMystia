using System.Collections.Generic;
using HarmonyLib;
using MetaMystia.Network;

namespace MetaMystia;


[HarmonyPatch(typeof(Common.UI.IzakayaSelectorPanel_New))]
[AutoLog]
public partial class IzakayaSelectorPanelPatch
{
    public static Common.UI.IzakayaSelectorPanel_New instanceRef = null;
    public static Dictionary<string, Common.UI.GlobalMap.IGuideMapSpot> cachedSpots = new Dictionary<string, Common.UI.GlobalMap.IGuideMapSpot>();

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.OnGuideMapInitialize))]
    [HarmonyPrefix]
    public static void OnGuideMapInitialize_Prefix(Common.UI.IzakayaSelectorPanel_New __instance)
    {
        instanceRef = __instance;
        Log.LogInfo($"OnGuideMapInitialize called");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New._OnGuideMapInitialize_b__21_0))]
    [HarmonyPrefix]
    public static bool _OnGuideMapInitialize_b__21_0_Prefix(ref Common.UI.IzakayaSelectorPanel_New __instance)
    {
        // MetaMiku 注:
        //     这里原本实际上是选择 Izakaya 的逻辑
        //     同样采用对称的设计，下面以 A 首先做出选择，B 之后进行确认来描述流程
        //     一共是四种事件，两件来自玩家，两件来自网络
        //
        //     Peer A -> 「前往营业」
        //            -> 检查对端是否已经选择地图
        //                 -> 否 -> 发送 SELECT 包并跳过 _OnGuideMapInitialize_b__21_0，展示对话
        //                 -> 是 -> 对称，略
        //
        //     Peer A -> 接收 CONFIRM 包
        //            -> 检查已有选择，不匹配则应强制修改
        //            -> 展示「确认」对话
        //            -> 对话回调中调用 _OnGuideMapInitialize_b__21_0 以结束
        //
        //     Peer B -> 接收 SELECT 包，缓存并展示「提示」对话
        //
        //     Peer B -> 「前往营业」
        //            -> 检查对端是否已经选择地图
        //                -> 否 -> 对称，略
        //                -> 是 -> 检查 地图/level 是否匹配
        //                          -> 否 -> 展示「拒绝」对话
        //                          -> 是 -> 发送 CONFIRM 包
        //                                -> 展示「确认」对话
        //                                -> 对话回调中调用 _OnGuideMapInitialize_b__21_0 以结束

        Log.LogInfo($"_OnGuideMapInitialize_b__21_0 called");

        if (!MpManager.IsConnected)
        {
            Log.LogWarning($"Not in multiplayer session, skipping patch");
            return true;
        }

        if (MpManager.PeerScene == Common.UI.Scene.IzakayaPrepScene || MpManager.PeerScene == Common.UI.Scene.WorkScene)
        {
            Log.Error($"peer already in prep scene, will disconnect");
            Notify.ShowOnMainThread(TextId.PeerAlreadyInScene.Get());
            MpManager.DisconnectPeer();
            return true;
        }

        // 参考 Common.UI.IzakayaLevel
        // public enum IzakayaLevel
        // {
        //     Level1 = 1,
        //     Level2 = 2,
        //     Level3 = 3,
        //     Null = 0
        // }

        var izakayaMapLabel = __instance.m_CurrentSelectedSpot.PrimaryName;
        var izakayaLevel = (int)__instance.m_CurrentSelectedIzakayaLevel;
        Log.LogWarning($"Selected Spot: {izakayaMapLabel}, Level: {izakayaLevel}");

        var mySelect = $"{Utils.GetMapLabelNameCN(izakayaMapLabel)} {Utils.GetMapLevelNameCN(izakayaLevel)}";
        if (PeerManager.IzakayaMapLabel == "" || PeerManager.IzakayaLevel == 0)
        {
            Log.LogWarning($"Kyouko has not selected an Izakaya yet -> send SELECT and skip");
            SelectAction.Send(izakayaMapLabel, izakayaLevel);
            Notify.ShowOnMainThread(TextId.SelectedIzakaya.Get(mySelect));
            return false;
        }

        if (izakayaMapLabel != PeerManager.IzakayaMapLabel || izakayaLevel != PeerManager.IzakayaLevel)
        {
            var peerSelect = $"{Utils.GetMapLabelNameCN(PeerManager.IzakayaMapLabel)} {Utils.GetMapLevelNameCN(PeerManager.IzakayaLevel)}";
            Log.LogWarning($"Selected Izakaya does not match Kyouko's selection -> show rejection dialog");
            Notify.ShowOnMainThread(TextId.SelectedIzakayaMismatch.Get(mySelect, peerSelect));
            return false;
        }

        Log.LogWarning($"Selected Izakaya matches Kyouko's selection -> send CONFIRM and show confirmation dialog");
        MapDecidedAction.Send(izakayaMapLabel, izakayaLevel);

        System.Action closePanelCallback = () =>
        {
            cachedSpots.TryGetValue(izakayaMapLabel, out var spot);
            instanceRef.m_CurrentSelectedSpot = spot;
            instanceRef.m_CurrentSelectedIzakayaLevel = (Common.UI.IzakayaLevel)izakayaLevel;
            SgrYuki.Utils.Panel.CloseActivePanelsBeforeSceneTransit();
            _OnGuideMapInitialize_b__21_0_Original(instanceRef);
        };
        Dialog.ShowConfirmDialog(izakayaMapLabel, closePanelCallback);
        return false;
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New._OnGuideMapInitialize_b__21_0))]
    [HarmonyReversePatch]
    public static void _OnGuideMapInitialize_b__21_0_Original(Common.UI.IzakayaSelectorPanel_New __instance)
    {
        throw new System.NotImplementedException("Bad Bad Metamiku");
    }

    [HarmonyPatch(nameof(Common.UI.IzakayaSelectorPanel_New.OnGuideMapSpotSelected))]
    [HarmonyPrefix]
    public static void OnGuideMapSpotSelected_Prefix(ref Common.UI.GlobalMap.IGuideMapSpot guideMapSpot)
    {
        if (guideMapSpot != null && !string.IsNullOrEmpty(guideMapSpot.PrimaryName))
        {
            cachedSpots[guideMapSpot.PrimaryName] = guideMapSpot;
        }

        Log.Info($"OnGuideMapSpotSelected called, guideMapSpot.PrimaryName: {guideMapSpot.PrimaryName}");
    }
}
