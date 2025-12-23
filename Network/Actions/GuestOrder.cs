using System;
using GameData.Core.Collections.NightSceneUtility;
using MemoryPack;
using static NightScene.GuestManagementUtility.GuestsManager;

namespace MetaMystia;

[MemoryPackable]
public partial class GuestOrder
{
    public int RequestFoodIdOrTag;
    public int RequestBevIdOrTag;
    public int DeskCode;
    public bool NotShowInUI;
    public bool IsFree;

    public GuestOrder(int requestFoodIdOrTag, int requestBevIdOrTag, int deskCode, bool notShowInUI, bool isFree)
    {
        RequestFoodIdOrTag = requestFoodIdOrTag;
        RequestBevIdOrTag = requestBevIdOrTag;
        DeskCode = deskCode;
        NotShowInUI = notShowInUI;
        IsFree = isFree;
    }

    public NormalOrder ToNormalOrder(GuestBase guest)
    {
        return new NormalOrder(guest, RequestFoodIdOrTag, RequestBevIdOrTag, DeskCode, NotShowInUI, IsFree)
        {
            _Type_k__BackingField = OrderBase.OrderType.Normal,
        };
    }

    public SpecialOrder ToSpecialOrder(IntPtr guestIntPtr)
    {
        return new SpecialOrder(new SpecialGuest(guestIntPtr), RequestFoodIdOrTag, RequestBevIdOrTag, DeskCode, NotShowInUI, IsFree)
        {
            _Type_k__BackingField = OrderBase.OrderType.Special
        };
    }
}
