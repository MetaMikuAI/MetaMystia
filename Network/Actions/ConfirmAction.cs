using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class ConfirmAction : NetAction
{
    public override ActionType Type => ActionType.CONFIRM;
    public string MapLabel { get; set; } = "";
    public int Level { get; set; } = 0;
    public override void OnReceived()
    {
        // 接收 CONFIRM 包 
        // -> 检查已有选择，不匹配则应强制修改
        // -> 展示「确认」对话
        // -> 对话回调中调用 _OnGuideMapInitialize_b__21_0 以结束
        LogActionReceived();

        PluginManager.Instance.RunOnMainThread(() =>
        {
            if (IzakayaSelectorPanelPatch.cachedSpots.TryGetValue(MapLabel, out var spot))
            {
                IzakayaSelectorPanelPatch.instanceRef.OnGuideMapSpotSelected(spot);
            }
            var targetLevel = (Common.UI.IzakayaLevel)Level;
            var currentLevel = IzakayaSelectorPanelPatch.instanceRef.m_CurrentSelectedIzakayaLevel;
            IzakayaSelectorPanelPatch.instanceRef.TryChangeIzakayaLevel(ref currentLevel, targetLevel);
            IzakayaSelectorPanelPatch.instanceRef.m_CurrentSelectedIzakayaLevel = currentLevel;

            static void closePanelCallback()
            {
                IzakayaSelectorPanelPatch._skipPatchIzakayaSelectionConfirmation = true;
                IzakayaSelectorPanelPatch.instanceRef._OnGuideMapInitialize_b__21_0();
                IzakayaSelectorPanelPatch._skipPatchIzakayaSelectionConfirmation = false;
            }
            KyoukoManager.IzakayaLevel = Level;
            KyoukoManager.IzakayaMapLabel = MapLabel;
            Dialog.ShowConfirmDialog(MapLabel, closePanelCallback);
        });
    }

    public static void Send(string mapLabel, int level)
    {
        NetPacket packet = new([new ConfirmAction
        {
            MapLabel = mapLabel,
            Level = level
        }]);
        SendToPeer(packet);
    }
}
