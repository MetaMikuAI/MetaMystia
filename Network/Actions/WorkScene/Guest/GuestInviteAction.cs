
using MemoryPack;
using System.Collections.Generic;
using System.Linq;

using GameData.RunTime.Common;

using MetaMystia.Patch;

namespace MetaMystia.Network;

/// <summary>
/// 客机 → 主机：告知主机被邀请稀客列表
/// </summary>
[MemoryPackable]
public partial class GuestInviteAction : Action
{
    public override ActionType Type => ActionType.GUEST_INVITE;
    public List<int> InvitedGuestIDs;

    public override void OnReceivedDerived()
    {
        if (!MpManager.IsConnectedHost)
        {
            return;
        }

        PluginManager.Instance.RunOnMainThread(() =>
        {
            InvitedGuestIDs
                .Where(PlayerManager.SpecialGuestAvailable)
                .ToList()
                .ForEach(guest => StatusTrackerPatch.RecordInvitedGuest_Original(StatusTracker.Instance, guest));
        });
    }

    public static void Send(List<int> invitedGuestIDs)
    {
        if (!MpManager.IsConnectedClient)
        {
            return;
        }

        var action = new GuestInviteAction
        {
            InvitedGuestIDs = invitedGuestIDs
        };
        action.SendToHostOrBroadcast();
    }
}
