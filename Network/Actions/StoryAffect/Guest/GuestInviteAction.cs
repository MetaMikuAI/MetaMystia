
using System.Collections.Generic;
using System.Linq;
using MemoryPack;

namespace MetaMystia;

[MemoryPackable]
public partial class GuestInviteAction : SendAffectStoryAction
{
    public override ActionType Type => ActionType.GUEST_INVITE;
    public List<int> InvitedGuestIDs;
    
    public override void OnReceivedDerived()
    {
        if (MpManager.IsConnectedHost)
        {
            PluginManager.Instance.RunOnMainThread(() =>
            {
                foreach (var item in InvitedGuestIDs.Where(item => DLCManager.SpecialGuestAvailable(item)))
                {
                    StatusTrackerPatch.RecordInvitedGuest_Original(GameData.RunTime.Common.StatusTracker.Instance, item);
                }
            });
        }
    }

    public static void Send(List<int> invitedGuestIDs)
    {
        var action = new GuestInviteAction
        {
            InvitedGuestIDs = invitedGuestIDs
        };
        action.SendToHostOrBroadcast();
    }
}
