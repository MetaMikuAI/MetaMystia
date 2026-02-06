using System;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage.Collections;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace MetaMystia;

using Spell_Koakuma_Info = SpellExProvider<Spell_Koakuma>;

public class Spell_Koakuma : SpellBase, ISpellEx
{
    public Spell_Koakuma(IntPtr pointer) : base(pointer)
    {
    }

    public override string OnGettingSpellOwnerIdentifier()
    {
        return "Koakuma";
    }

    public override Il2CppSystem.Collections.IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
    {
        Notify.Show($"黑卡触发了，但是好像什么也没有发生");
        return null;
    }

    public override Il2CppSystem.Collections.IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
    {
        EventManager.Instance.RegisterCountedBuff(ExtendedBuff.Type.Koakuma.GameBuffType(), MaxNotifyCount, EventManager.MathOperation.Add, null, null);
        return null;
    }

    public static void TryTriggerPositiveBuffEffect(GuestGroupController guestGroup)
    {
        if (guestGroup.ControllType == GuestsManager.GuestType.Special && CheckBuff())
        {
            var order = guestGroup.PeekOrders();
            if (order == null) return;
            var foodTag = order.foodRequest.GetFoodTag();
            Notify.Show($"似乎 {guestGroup.OnGetGuestName()} 想要 {foodTag} 的料理...");

            Deduct();
        }
    }

    public static bool CheckBuff() => Registered && EventManager.Instance.CheckCountedBuffExists(ExtendedBuff.Type.Koakuma.GameBuffType());
    private static void Deduct() => EventManager.Instance.TryDeductCountedBuffValue(ExtendedBuff.Type.Koakuma.GameBuffType());

    public const int MaxNotifyCount = 3;

    public static void Register(ResourceEx.Models.CharacterConfig charConfig)
    {
        Spell_Koakuma_Info.GuestId = 9001;
        Spell_Koakuma_Info.PositiveSpellLang = new("灵符「遗失典籍的回响」", "小恶魔从图书馆搬来一本百科全书，接下来 3 次稀客点单会告诉你具体tag");
        Spell_Koakuma_Info.NegativeSpellLang = new("幻符「馆藏乱序」", "小恶魔...啥也不干...?");
        Spell_Koakuma_Info.PositiveBuffDescription = new("灵符「遗失典籍的回响」", "小恶魔从图书馆搬来一本百科全书，接下来 $a 次稀客点单会告诉你具体tag", EventManager.BuffType.PhilosopherStone.RefBuffLang().Visual); ;
        Spell_Koakuma_Info.PositiveBuffType = ExtendedBuff.Type.Koakuma;

        (SpellHandle, PositiveSpellPortrayal, NegativeSpellPortrayal) = Spell_Koakuma_Info.Register(charConfig);
    }

    public static DEYU.AssetHandleUtility.IAssetHandle<SpellBase> SpellHandle;
    public static DEYU.AssetHandleUtility.IAssetHandle<Sprite> PositiveSpellPortrayal;
    public static DEYU.AssetHandleUtility.IAssetHandle<Sprite> NegativeSpellPortrayal;
    public static void DeRegister() => Spell_Koakuma_Info.DeRegisterAssetHandle();
    public static bool Registered => Spell_Koakuma_Info.Registered;

}



