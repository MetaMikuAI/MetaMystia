using System;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage.Collections;
using NightScene.EventUtility;

namespace MetaMystia;

using Spell_Daiyousei_Info = SpellExProvider<Spell_Daiyousei>;
public class Spell_Daiyousei : SpellEx
{
    public Spell_Daiyousei()
    {
    }

    public Spell_Daiyousei(IntPtr pointer) : base(pointer)
    {
    }

    public override string OnGettingSpellOwnerIdentifier()
    {
        return "Daiyousei";
    }

    public override Il2CppSystem.Collections.IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
    {
        var a = EventManager.Instance.SelectFromDatabase(
            iOType: EventManager.InventoryIOType.Beverage,
            amount: 1,
            tag: 0,
            priceMin: 100,
            priceMax: 900);
        EventManager.Instance.InventoryOut(a);
        Notify.Show($"mETAm1KU太坏了，偷偷的把你的酒水偷走！");
        return null;
    }

    public override Il2CppSystem.Collections.IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
    {
        var a = EventManager.Instance.SelectFromDatabase(
            iOType: EventManager.InventoryIOType.Beverage,
            amount: 1,
            excludeTag: 0,
            priceMin: 430,
            priceMax: 900);
        EventManager.Instance.InventoryIn(a);
        Notify.Show($"Sgr太好了，送你十四夜喝");
        return null;
    }

    public static void Register(ResourceEx.Models.CharacterConfig charConfig)
    {
        Spell_Daiyousei_Info.GuestId = 9000;
        Spell_Daiyousei_Info.PositiveSpellLang = new("Sgr符「爆肝mod」", "Sgr太好了，会送你十四夜喝");
        Spell_Daiyousei_Info.NegativeSpellLang = new("mETA符「偷懒」", "mETAm1KU太坏了，偷偷的把你的酒水偷走！");
        Spell_Daiyousei_Info.PositiveBuffDescription = new("Sgr符「爆肝mod」", "Sgr太好了，会送你十四夜喝", EventManager.BuffType.Murasa_Positive.RefBuffLang().Visual);
        Spell_Daiyousei_Info.PositiveBuffType = ExtendedBuff.Type.Daiyousei;

        Spell_Daiyousei_Info.Register(charConfig);
    }

    public static void DeRegister() => Spell_Daiyousei_Info.DeRegisterAssetHandle();
    public static bool Registered => Spell_Daiyousei_Info.Registered;
}



