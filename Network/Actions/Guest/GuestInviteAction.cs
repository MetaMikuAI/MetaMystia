
using System.Collections.Generic;
using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class GuestInviteAction : NetAction
{
    public override ActionType Type => ActionType.GUEST_INVITE;
    public List<int> InvitedGuestIDs;
    public override void OnReceived()
    {
        LogActionReceived();
        PluginManager.Instance.RunOnMainThread(() =>
        {
            foreach (var item in InvitedGuestIDs)
            {
                GameData.RunTime.Common.StatusTracker.Instance.RecordInvitedGuest(item);
            }
        });
    }

    public static void Send(List<int> invitedGuestIDs)
    {
        NetPacket packet = new([new GuestInviteAction
        {
            InvitedGuestIDs = invitedGuestIDs
        }]);
        SendToPeer(packet);
    }
}
