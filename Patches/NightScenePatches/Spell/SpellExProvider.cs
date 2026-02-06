using System.Collections.Generic;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage.Collections;
using MetaMiku;
using SgrYuki.Utils;
using UnityEngine;

namespace MetaMystia;

public static class SpellExProvider<T> where T : SpellEx
{
    public static bool Registered { get; private set; } = false;
    public static int GuestId;
    public static GameData.CoreLanguage.LanguageBase PositiveSpellLang;
    public static GameData.CoreLanguage.LanguageBase NegativeSpellLang;

    // 对于 counted buff, 如果需要，可以使用 $a 来替换执行的次数
    public static GameData.CoreLanguage.ObjectLanguageBase PositiveBuffDescription;
    public static GameData.CoreLanguage.ObjectLanguageBase NegativeBuffDescription;
    public static ExtendedBuff.Type PositiveBuffType;
    public static ExtendedBuff.Type NegativeBuffType;

    public static Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppReferenceArray<GameData.CoreLanguage.LanguageBase> SpellLang
        => new List<GameData.CoreLanguage.LanguageBase> { PositiveSpellLang, NegativeSpellLang }.ToIl2CppReferenceArray();

    private static ShigureIAssetHandleHelper<SpellBase> SpellAsset;
    private static ShigureIAssetHandleHelper<Sprite> PositiveSpellPortrayal;
    private static ShigureIAssetHandleHelper<Sprite> NegativeSpellPortrayal;

    public static void Register(ResourceEx.Models.CharacterConfig charConfig)
    {
        RegisterSpell();
        RegisterSpellLang();
        RegisterSpellPortrayal(charConfig);
        Registered = true;
    }

    private static void RegisterSpell()
    {
        SpellAsset = ShigureIAssetHandleHelper<SpellBase>.CreateAssetHandle(ScriptableObject.CreateInstance<T>());
        DataBaseNight.SpecialGuestSpell[GuestId] = SpellAsset;

        GameData.Core.Collections.CharacterUtility.DataBaseCharacter.CharacterHasSpell[GuestId] = true;
    }

    private static void RegisterSpellLang()
    {
        DataBaseLanguage.SpellLang[GuestId] = SpellLang;
        if (PositiveBuffType != ExtendedBuff.Type.Null)
        {
            DataBaseLanguage.BuffDescription[PositiveBuffType.GameBuffType()] = PositiveBuffDescription;
        }

        if (NegativeBuffType != ExtendedBuff.Type.Null)
        {
            DataBaseLanguage.BuffDescription[NegativeBuffType.GameBuffType()] = NegativeBuffDescription;
        }
    }

    private static void RegisterSpellPortrayal(ResourceEx.Models.CharacterConfig charConfig)
    {
        PositiveSpellPortrayal = ShigureIAssetHandleHelper<Sprite>.CreateAssetHandle(
            ResourceExManager.GetSprite(charConfig.portraits[0].path, charConfig.PackageRoot, useCache: false));
        NegativeSpellPortrayal = ShigureIAssetHandleHelper<Sprite>.CreateAssetHandle(
            ResourceExManager.GetSprite(charConfig.portraits[1].path, charConfig.PackageRoot, useCache: false));

        Il2CppSystem.ValueTuple<DEYU.AssetHandleUtility.IAssetHandle<Sprite>, DEYU.AssetHandleUtility.IAssetHandle<Sprite>> mySprites = new(PositiveSpellPortrayal, NegativeSpellPortrayal);
        DataBaseNight.SpecialGuestSpellPortrayal.ForceAddOrUpdateValueTuple(GuestId, mySprites);
    }

    public static void DeRegisterAssetHandle()
    {
        SpellAsset?.InvalidateAsset();
        PositiveSpellPortrayal?.InvalidateAsset();
        NegativeSpellPortrayal?.InvalidateAsset();
        Registered = false;
    }
}
