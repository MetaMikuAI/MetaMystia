using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class MapDecidedAction : NetAction
{
    public override ActionType Type => ActionType.MAP_DECIDED;
    public string MapLabel { get; set; } = "";
    public int Level { get; set; } = 0;
    public override void OnReceivedDerived()
    {
        // 接收 CONFIRM 包
        // -> 检查已有选择，不匹配则应强制修改
        // -> 展示「确认」对话
        // -> 对话回调中调用 _OnGuideMapInitialize_b__21_0 以结束

        PluginManager.Instance.RunOnMainThread(() =>
        {
            IzakayaSelectorPanelPatch.cachedSpots.TryGetValue(MapLabel, out var spot);
            var targetLevel = (Common.UI.IzakayaLevel)Level;
            PeerManager.IzakayaLevel = Level;
            PeerManager.IzakayaMapLabel = MapLabel;

            Dialog.ShowConfirmDialog(MapLabel, () =>
            {
                IzakayaSelectorPanelPatch.instanceRef.m_CurrentSelectedSpot = spot;
                IzakayaSelectorPanelPatch.instanceRef.m_CurrentSelectedIzakayaLevel = targetLevel;
                SgrYuki.Utils.Panel.CloseActivePanelsBeforeSceneTransit();
                IzakayaSelectorPanelPatch._OnGuideMapInitialize_b__21_0_Original(IzakayaSelectorPanelPatch.instanceRef);
            });
        });
    }

    public static void Send(string mapLabel, int level)
    {
        new MapDecidedAction
        {
            MapLabel = mapLabel,
            Level = level
        }.SendToHostOrBroadcast();
    }
}
