using MemoryPack;
using System;
using System.Collections.Generic;
using System.Text;
using Common.CharacterUtility;
using Cpp2IL.Core.Extensions;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.DaySceneUtility;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.RunTime.Common;

using MetaMystia.Network;
using SgrYuki;


namespace MetaMystia;

[MemoryPackable]
[AutoLog]
public partial class PlayerSkin
{
    public int CharacterId = -1; // -1 means Mystia
    public CharacterSkinSets.SelectedType SelectedType =  CharacterSkinSets.SelectedType.Default;
    public int SkinIndex = 0;

    /// <summary>
    /// 解析 CharacterSpriteSetCompact
    /// </summary>
    public CharacterSpriteSetCompact ResolveSkin()
    {
        if (CharacterId == -1)
        {
            return ResolveSkin(DataBaseCharacter.SelfSpriteSet, SelectedType, SkinIndex);
        }

        if (DataBaseCharacter.SpecialGuestVisual.ContainsKey(CharacterId))
        {
            return ResolveSkin(DataBaseCharacter.SpecialGuestVisual[CharacterId]?.CharacterPixel, SelectedType, SkinIndex);
        }

        Log.Warning($"CharacterId {CharacterId} not found in SpecialGuestVisual, returning Fallback skin");
        return DataBaseCharacter.FallbackFullPixel;
    }

    private static CharacterSpriteSetCompact ResolveSkin(
        CharacterSkinSets skinSets, CharacterSkinSets.SelectedType type, int index)
    {
        if (skinSets is null) return null;

        return type switch
        {
            CharacterSkinSets.SelectedType.Default => skinSets.defaultSkin,
            CharacterSkinSets.SelectedType.Explicit => (index >= 0 && index < skinSets.explicits.Length)
                ? skinSets.explicits[index] : skinSets.defaultSkin,
            CharacterSkinSets.SelectedType.DLC => (index >= 0 && index < skinSets.dlcs.Length)
                ? skinSets.dlcs[index] : skinSets.defaultSkin,
            _ => skinSets.defaultSkin
        };
    }

    /// <summary>
    /// 设定皮肤
    /// </summary>
    /// <param name="characterId"></param>
    /// <param name="selectedType"></param>
    /// <param name="skinIndex"></param>
    public void SetSkin(int characterId, CharacterSkinSets.SelectedType selectedType, int skinIndex)
    {
        CharacterId = characterId;
        SelectedType = selectedType;
        SkinIndex = skinIndex;
    }

    /// <summary>
    /// 将当前皮肤应用到指定 unit 上
    /// </summary>
    /// <param name="unit"></param>
    public void ApplyToUnit(CharacterControllerUnit unit)
        => unit?.UpdateCharacterSprite(ResolveSkin());


    /// <summary>
    /// 获取全部可用皮肤的表格字符串，格式为 "name: CharacterId SelectedType SkinIndex"
    /// </summary>
    /// <returns></returns>
    public static string GetAllSkinsTable()
    {
        var table = new StringBuilder();
        foreach (var skin in ListAllSkins())
        {
            table.AppendLine($"{skin.name}: {skin.skin.CharacterId} {skin.skin.SelectedType} {skin.skin.SkinIndex}");
        }
        return table.ToString();
    }

    /// <summary>
    /// 列举全部可用皮肤
    /// </summary>
    /// <returns></returns>
    private static List<(PlayerSkin skin, string name)> ListAllSkins()
    {
        List<(PlayerSkin, string)> skins = [];
        skins.AddRange(ListSkinsFromSets(DataBaseCharacter.SelfSpriteSet, -1));
        foreach (int characterId in  DataBaseCharacter.SpecialGuestVisual.Keys)
        {
            skins.AddRange(ListSkinsFromSets(DataBaseCharacter.SpecialGuestVisual[characterId]?.CharacterPixel, characterId));
        }

        return skins;
    }

    private static List<(PlayerSkin skin, string name)> ListSkinsFromSets(CharacterSkinSets skinSets, int characterId)
    {
        if (skinSets is null) return [];
        List<(PlayerSkin, string)> skins = [];

        skins.Add((new PlayerSkin
        {
            CharacterId = characterId,
            SelectedType = CharacterSkinSets.SelectedType.Default,
        }, skinSets.defaultSkin?.name ?? "Default"));

        for(var i = 0; i < skinSets.explicits?.Length; i++)
        {
            var skin = skinSets.explicits[i];
            skins.Add((new PlayerSkin
            {
                CharacterId = characterId,
                SelectedType = CharacterSkinSets.SelectedType.Explicit,
                SkinIndex = i
            }, skin?.name ?? $"Explicit_{i}"));
        }

        for (var i = 0; i < skinSets.dlcs?.Length; i++)
        {
            var skin = skinSets.dlcs[i];
            skins.Add((new PlayerSkin
            {
                CharacterId = characterId,
                SelectedType = CharacterSkinSets.SelectedType.DLC,
                SkinIndex = i
            }, skin?.name ?? $"DLC_{i}"));
        }

        return skins;
    }
}
