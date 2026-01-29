using System.Linq;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using MetaMystia.ResourceEx.Models;
using UnityEngine;

namespace MetaMystia.ResourceEx.Mappers;

/// <summary>
/// Builder for creating SpecialGuest instances from template (DataBaseCharacter.SpecialGuest[0])
/// </summary>
internal class SpecialGuestBuilder
{
    private readonly SpecialGuest _template;

    private int _id;
    private string _stringId;
    private Vector2Int _fundRange;
    private int[] _hateFoodTag;
    private Il2CppReferenceArray<SpecialGuest.WeightedTag> _likeFoodTag;
    private Il2CppReferenceArray<SpecialGuest.WeightedTag> _likeBevTag;

    private SpecialGuestBuilder(SpecialGuest template)
    {
        _template = template ?? throw new System.ArgumentNullException(nameof(template));
    }

    public static SpecialGuestBuilder FromTemplate(SpecialGuest template) => new SpecialGuestBuilder(template);

    public SpecialGuestBuilder WithId(int id)
    {
        _id = id;
        return this;
    }

    public SpecialGuestBuilder WithStringId(string stringId)
    {
        _stringId = stringId;
        return this;
    }

    public SpecialGuestBuilder WithFundRange(int lower, int upper)
    {
        _fundRange = new Vector2Int(lower, upper);
        return this;
    }

    public SpecialGuestBuilder WithHateFoodTags(System.Collections.Generic.List<int> tags)
    {
        _hateFoodTag = tags?.ToArray() ?? new int[0];
        return this;
    }

    public SpecialGuestBuilder WithLikeFoodTags(System.Collections.Generic.List<WeightedTagConfig> tags)
    {
        _likeFoodTag = new Il2CppReferenceArray<SpecialGuest.WeightedTag>(
            tags?.Select(x => new SpecialGuest.WeightedTag(x.tagId, x.weight)).ToArray() ?? []);
        return this;
    }

    public SpecialGuestBuilder WithLikeBevTags(System.Collections.Generic.List<WeightedTagConfig> tags)
    {
        _likeBevTag = new Il2CppReferenceArray<SpecialGuest.WeightedTag>(
            tags?.Select(x => new SpecialGuest.WeightedTag(x.tagId, x.weight)).ToArray() ?? []);
        return this;
    }

    public SpecialGuest Build()
    {
        var specialGuest = new SpecialGuest(
            _id,
            _stringId,  // 字符串 id，label
            _fundRange, // 资金范围
            _hateFoodTag,   // 讨厌的食物标签
            _likeFoodTag,   // 喜欢的食物标签权重
            _likeBevTag,    // 喜欢的饮品标签权重
            _template.Reaction, // ？
            _template.destination,  // ？
            _template.CommisionAreaLabel,   // 委托采集对应地图标签，例如 (0)Wriggle 是 BeastForest，(3)Akyuu 是 HumanVillage，似乎对尚未实现自定义地图的 mod 无用
            _template.characterKizunaLevel1Welcome,
            _template.characterKizunaLevel2Welcome,
            _template.characterKizunaLevel3Welcome,
            _template.characterKizunaLevel4Welcome,
            _template.characterKizunaLevel5Welcome,
            _template.characterKizunaLevel1ChatData,
            _template.characterKizunaLevel2ChatData,
            _template.characterKizunaLevel3ChatData,
            _template.characterKizunaLevel4ChatData,
            _template.characterKizunaLevel5ChatData,
            _template.characterKizunaLevel2InviteSucceed,
            _template.characterKizunaLevel2InviteFailed,
            _template.characterKizunaLevel3InviteSucceed,
            _template.characterKizunaLevel3InviteFailed,
            _template.characterKizunaLevel4InviteSucceed,
            _template.characterKizunaLevel4InviteFailed,
            _template.characterKizunaLevel5InviteSucceed,
            _template.characterKizunaLevel3RequestIngerdient,
            _template.characterKizunaLevel4RequestIngerdient,
            _template.characterKizunaLevel5RequestIngerdient,
            _template.characterKizunaLevel4RequestBeverage,
            _template.characterKizunaLevel5RequestBeverage,
            _template.characterKizunaLevel5Commision,
            _template.characterKizunaLevel5CommisionFinish,
            _template.hideInAlbum,
            _template.IsParticular,
            _template.IsCollabCharacter,
            _template.SpawnType,
            _template.unifiedSpawnExclusion,
            _template.unifiedSpawnWhereAfterEventOrMission,
            _template.unifiedSpawnProb,
            _template.m_SpecialGuestExtraDialogDataAsset,
            _template.doNotShowInNightByDefault,
            _template.doNotShowInChallenge,
            _template.guestFoodEasterEggData
        );

        specialGuest.stringId = _stringId;
        return specialGuest;
    }
}


/* 字段猜测
GameData.Core.Collections.CharacterUtility.DataBaseCharacter.SpecialGuest

public SpecialGuest(int id,
	string stringId,
	Vector2Int fundRange, // 资金范围
	int[] hateFoodTag, // 讨厌的食物标签
	SpecialGuest.WeightedTag[] likeFoodTag, // 喜欢的食物标签权重
	SpecialGuest.WeightedTag[] likeBevTag,  // 喜欢的饮品标签权重
	SpecialGuest.Prespective reaction, // ？
	NPC.Destination destination,  // ？
	string commisionAreaLabel,  // 委托采集对应地图标签，例如 (0)Wriggle 是 BeastForest，(3)Akyuu 是 HumanVillage，似乎对尚未实现自定义地图的 mod 无用
	DialogPackage[] characterKizunaLevel1Welcome,
	DialogPackage[] characterKizunaLevel2Welcome,
	DialogPackage[] characterKizunaLevel3Welcome,
	DialogPackage[] characterKizunaLevel4Welcome,
	DialogPackage[] characterKizunaLevel5Welcome,
	string[] characterKizunaLevel1ChatData,
	string[] characterKizunaLevel2ChatData,
	string[] characterKizunaLevel3ChatData,
	string[] characterKizunaLevel4ChatData,
	string[] characterKizunaLevel5ChatData,
	DialogPackage[] characterKizunaLevel2InviteSucceed,
	DialogPackage[] characterKizunaLevel2InviteFailed,
	DialogPackage[] characterKizunaLevel3InviteSucceed,
	DialogPackage[] characterKizunaLevel3InviteFailed,
	DialogPackage[] characterKizunaLevel4InviteSucceed,
	DialogPackage[] characterKizunaLevel4InviteFailed,
	DialogPackage[] characterKizunaLevel5InviteSucceed,
	DialogPackage[] characterKizunaLevel3RequestIngerdient,
	DialogPackage[] characterKizunaLevel4RequestIngerdient,
	DialogPackage[] characterKizunaLevel5RequestIngerdient,
	DialogPackage[] characterKizunaLevel4RequestBeverage,
	DialogPackage[] characterKizunaLevel5RequestBeverage,
	DialogPackage[] characterKizunaLevel5Commision,
	DialogPackage[] characterKizunaLevel5CommisionFinish,
	bool hideInAlbum,
	bool isParticular,
	bool isCollabCharacter,
	SpecialGuest.WorkSceneSpawnType spawnType,
	string[] unifiedSpawnExclusion,
	string unifiedSpawnWhereAfterEventOrMission,
	float unifiedSpawnProb,
	AssetReferenceT<SpecialGuestExtraDialogData> specialGuestExtraDialogData,
	bool doNotShowInNightByDefault,
	bool doNotShowInChallenge,
	GuestFoodEasterEggData guestFoodEasterEggData);

*/
