using System;
using Common.DataBaseProfiles;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.U2D;

namespace GameData.Profile
{
	// Token: 0x02000B89 RID: 2953
	[Token(Token = "0x2000B89")]
	[CreateAssetMenu(fileName = "ExpandableGameDataPack", menuName = "GameData Profile/ExpandableGameDataPack", order = 0)]
	public class ExpandableGameDataPack : ScriptableObject
	{
		// Token: 0x06004639 RID: 17977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004639")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public ExpandableGameDataPack()
		{
		}

		// Token: 0x04003E30 RID: 15920
		[Token(Token = "0x4003E30")]
		[FieldOffset(Offset = "0x18")]
		public ExpandableGameDataPack.MapAdditiveData[] mapAdditiveData;

		// Token: 0x04003E31 RID: 15921
		[Token(Token = "0x4003E31")]
		[FieldOffset(Offset = "0x20")]
		public ExpandableGameDataPack.IzakayaAdditiveData[] izakayaAdditiveData;

		// Token: 0x04003E32 RID: 15922
		[Token(Token = "0x4003E32")]
		[FieldOffset(Offset = "0x28")]
		public ExpandableGameDataPack.SchedulerConnectionData[] schedulerConnectionData;

		// Token: 0x04003E33 RID: 15923
		[Token(Token = "0x4003E33")]
		[FieldOffset(Offset = "0x30")]
		public ExpandableGameDataPack.SchedulerNewsData[] schedulerNewsData;

		// Token: 0x04003E34 RID: 15924
		[Token(Token = "0x4003E34")]
		[FieldOffset(Offset = "0x38")]
		public ExpandableGameDataPack.SpecialGuestAdditiveData[] specialGuestAdditiveData;

		// Token: 0x04003E35 RID: 15925
		[Token(Token = "0x4003E35")]
		[FieldOffset(Offset = "0x40")]
		[Header("Marker")]
		public AssetReference DLCMarker;

		// Token: 0x04003E36 RID: 15926
		[Token(Token = "0x4003E36")]
		[FieldOffset(Offset = "0x48")]
		[Header("Core")]
		public AssetReference IngredientProfile;

		// Token: 0x04003E37 RID: 15927
		[Token(Token = "0x4003E37")]
		[FieldOffset(Offset = "0x50")]
		public AssetReference BeverageProfile;

		// Token: 0x04003E38 RID: 15928
		[Token(Token = "0x4003E38")]
		[FieldOffset(Offset = "0x58")]
		public AssetReference FoodProfile;

		// Token: 0x04003E39 RID: 15929
		[Token(Token = "0x4003E39")]
		[FieldOffset(Offset = "0x60")]
		public AssetReference RecipeProfile;

		// Token: 0x04003E3A RID: 15930
		[Token(Token = "0x4003E3A")]
		[FieldOffset(Offset = "0x68")]
		public AssetReference CookerProfile;

		// Token: 0x04003E3B RID: 15931
		[Token(Token = "0x4003E3B")]
		[FieldOffset(Offset = "0x70")]
		public AssetReference IzakayaProfile;

		// Token: 0x04003E3C RID: 15932
		[Token(Token = "0x4003E3C")]
		[FieldOffset(Offset = "0x78")]
		public AssetReference ItemProfile;

		// Token: 0x04003E3D RID: 15933
		[Token(Token = "0x4003E3D")]
		[FieldOffset(Offset = "0x80")]
		public AssetReference BadgeProfile;

		// Token: 0x04003E3E RID: 15934
		[Token(Token = "0x4003E3E")]
		[FieldOffset(Offset = "0x88")]
		public AssetReference ClothesProfile;

		// Token: 0x04003E3F RID: 15935
		[Token(Token = "0x4003E3F")]
		[FieldOffset(Offset = "0x90")]
		public AssetReference DecorationProfile;

		// Token: 0x04003E40 RID: 15936
		[Token(Token = "0x4003E40")]
		[FieldOffset(Offset = "0x98")]
		public AssetReference RecordProfile;

		// Token: 0x04003E41 RID: 15937
		[Token(Token = "0x4003E41")]
		[FieldOffset(Offset = "0xA0")]
		public AssetReference TrophyProfile;

		// Token: 0x04003E42 RID: 15938
		[Token(Token = "0x4003E42")]
		[FieldOffset(Offset = "0xA8")]
		public AssetReference FoodTagRuleProfile;

		// Token: 0x04003E43 RID: 15939
		[Token(Token = "0x4003E43")]
		[FieldOffset(Offset = "0xB0")]
		[Header("Day")]
		public AssetReference CollectableProfile;

		// Token: 0x04003E44 RID: 15940
		[Token(Token = "0x4003E44")]
		[FieldOffset(Offset = "0xB8")]
		public AssetReference NormalNpcProfile;

		// Token: 0x04003E45 RID: 15941
		[Token(Token = "0x4003E45")]
		[FieldOffset(Offset = "0xC0")]
		public AssetReference[] DialogCollectionProfile;

		// Token: 0x04003E46 RID: 15942
		[Token(Token = "0x4003E46")]
		[FieldOffset(Offset = "0xC8")]
		public AssetReference MerchantProfile;

		// Token: 0x04003E47 RID: 15943
		[Token(Token = "0x4003E47")]
		[FieldOffset(Offset = "0xD0")]
		public AssetReference DaySceneMapProfile;

		// Token: 0x04003E48 RID: 15944
		[Token(Token = "0x4003E48")]
		[FieldOffset(Offset = "0xD8")]
		public AssetReference KourindoStaticMerchandiseProfile;

		// Token: 0x04003E49 RID: 15945
		[Token(Token = "0x4003E49")]
		[FieldOffset(Offset = "0xE0")]
		public AssetReference IgnoreIngredientsProfile;

		// Token: 0x04003E4A RID: 15946
		[Token(Token = "0x4003E4A")]
		[FieldOffset(Offset = "0xE8")]
		public AssetReference MissionIngredientsProfile;

		// Token: 0x04003E4B RID: 15947
		[Token(Token = "0x4003E4B")]
		[FieldOffset(Offset = "0xF0")]
		public AssetReference OnlyOneDayItemsProfile;

		// Token: 0x04003E4C RID: 15948
		[Token(Token = "0x4003E4C")]
		[FieldOffset(Offset = "0xF8")]
		public AssetReference PublicExtraDialogSelectionProfile;

		// Token: 0x04003E4D RID: 15949
		[Token(Token = "0x4003E4D")]
		[FieldOffset(Offset = "0x100")]
		public AssetReference FlandreHomeFurnitureProfile;

		// Token: 0x04003E4E RID: 15950
		[Token(Token = "0x4003E4E")]
		[FieldOffset(Offset = "0x108")]
		[Header("Character")]
		public AssetReference NormalGuestPixelProfile;

		// Token: 0x04003E4F RID: 15951
		[Token(Token = "0x4003E4F")]
		[FieldOffset(Offset = "0x110")]
		public AssetReference SpecialGuestVisualProfile;

		// Token: 0x04003E50 RID: 15952
		[Token(Token = "0x4003E50")]
		[FieldOffset(Offset = "0x118")]
		public AssetReference DaySceneNormalGuestVisual;

		// Token: 0x04003E51 RID: 15953
		[Token(Token = "0x4003E51")]
		[FieldOffset(Offset = "0x120")]
		public AssetReference NormalNPCIndexMappingProfile;

		// Token: 0x04003E52 RID: 15954
		[Token(Token = "0x4003E52")]
		[FieldOffset(Offset = "0x128")]
		public AssetReference SpecialNPCIndexMappingProfile;

		// Token: 0x04003E53 RID: 15955
		[Token(Token = "0x4003E53")]
		[FieldOffset(Offset = "0x130")]
		public AssetReference NormalGuestProfile;

		// Token: 0x04003E54 RID: 15956
		[Token(Token = "0x4003E54")]
		[FieldOffset(Offset = "0x138")]
		public AssetReference SpecialGuestProfile;

		// Token: 0x04003E55 RID: 15957
		[Token(Token = "0x4003E55")]
		[FieldOffset(Offset = "0x140")]
		public AssetReference PartnerInfoProfile;

		// Token: 0x04003E56 RID: 15958
		[Token(Token = "0x4003E56")]
		[FieldOffset(Offset = "0x148")]
		public AssetReference SpecialGuestMappingRuleProfile;

		// Token: 0x04003E57 RID: 15959
		[Token(Token = "0x4003E57")]
		[FieldOffset(Offset = "0x150")]
		[Header("Scheduler")]
		public AssetReference SchedulerProfile;

		// Token: 0x04003E58 RID: 15960
		[Token(Token = "0x4003E58")]
		[FieldOffset(Offset = "0x158")]
		public AssetReference CGProfile;

		// Token: 0x04003E59 RID: 15961
		[Token(Token = "0x4003E59")]
		[FieldOffset(Offset = "0x160")]
		public AssetReference CGProfileAlt;

		// Token: 0x04003E5A RID: 15962
		[Token(Token = "0x4003E5A")]
		[FieldOffset(Offset = "0x168")]
		[Header("Night")]
		public AssetReference SpellProfile;

		// Token: 0x04003E5B RID: 15963
		[Token(Token = "0x4003E5B")]
		[FieldOffset(Offset = "0x170")]
		public ExpandableGameDataPack.AssetReferenceIdPair[] IzakayaMusicProfile;

		// Token: 0x04003E5C RID: 15964
		[Token(Token = "0x4003E5C")]
		[FieldOffset(Offset = "0x178")]
		[Header("MusicGame")]
		public AssetReference MusicMappingProfile;

		// Token: 0x04003E5D RID: 15965
		[Token(Token = "0x4003E5D")]
		[FieldOffset(Offset = "0x180")]
		public AssetReference MusicChapterProfile;

		// Token: 0x04003E5E RID: 15966
		[Token(Token = "0x4003E5E")]
		[FieldOffset(Offset = "0x188")]
		[Header("Sprite Atlases")]
		public AssetReferenceT<SpriteAtlas> MainItemSpriteAtlas;

		// Token: 0x04003E5F RID: 15967
		[Token(Token = "0x4003E5F")]
		[FieldOffset(Offset = "0x190")]
		public AssetReferenceT<SpriteAtlas> BuffSpriteAtlas;

		// Token: 0x04003E60 RID: 15968
		[Token(Token = "0x4003E60")]
		[FieldOffset(Offset = "0x198")]
		[Header("Core Sprites")]
		[SerializeField]
		public AssetReference IngredientSprite;

		// Token: 0x04003E61 RID: 15969
		[Token(Token = "0x4003E61")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		public AssetReference ItemSprite;

		// Token: 0x04003E62 RID: 15970
		[Token(Token = "0x4003E62")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		public AssetReference BadgeSprite;

		// Token: 0x04003E63 RID: 15971
		[Token(Token = "0x4003E63")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		public AssetReference BeverageSprite;

		// Token: 0x04003E64 RID: 15972
		[Token(Token = "0x4003E64")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		public AssetReference FoodSprite;

		// Token: 0x04003E65 RID: 15973
		[Token(Token = "0x4003E65")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		public AssetReference CookerSprite;

		// Token: 0x04003E66 RID: 15974
		[Token(Token = "0x4003E66")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		public AssetReference IzakayaSprite;

		// Token: 0x04003E67 RID: 15975
		[Token(Token = "0x4003E67")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		public AssetReference BuffSprite;

		// Token: 0x04003E68 RID: 15976
		[Token(Token = "0x4003E68")]
		[FieldOffset(Offset = "0x1D8")]
		public AssetReferenceT<SpriteAtlas> IngredientItemBadgeBeverageFoodCookerIzakayaSpriteAtlas;

		// Token: 0x04003E69 RID: 15977
		[Token(Token = "0x4003E69")]
		[FieldOffset(Offset = "0x1E0")]
		[Header("Core Langauge")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference CommonPhraseLang;

		// Token: 0x04003E6A RID: 15978
		[Token(Token = "0x4003E6A")]
		[FieldOffset(Offset = "0x1E8")]
		public AssetReference BeverageTagProfile;

		// Token: 0x04003E6B RID: 15979
		[Token(Token = "0x4003E6B")]
		[FieldOffset(Offset = "0x1F0")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference BeverageTagsLang;

		// Token: 0x04003E6C RID: 15980
		[Token(Token = "0x4003E6C")]
		[FieldOffset(Offset = "0x1F8")]
		public AssetReference FoodTagProfile;

		// Token: 0x04003E6D RID: 15981
		[Token(Token = "0x4003E6D")]
		[FieldOffset(Offset = "0x200")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference FoodTagsLang;

		// Token: 0x04003E6E RID: 15982
		[Token(Token = "0x4003E6E")]
		[FieldOffset(Offset = "0x208")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference FoodPrefixLang;

		// Token: 0x04003E6F RID: 15983
		[Token(Token = "0x4003E6F")]
		[FieldOffset(Offset = "0x210")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference IngredientsLang;

		// Token: 0x04003E70 RID: 15984
		[Token(Token = "0x4003E70")]
		[FieldOffset(Offset = "0x218")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference ItemsLang;

		// Token: 0x04003E71 RID: 15985
		[Token(Token = "0x4003E71")]
		[FieldOffset(Offset = "0x220")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference BadgeLang;

		// Token: 0x04003E72 RID: 15986
		[Token(Token = "0x4003E72")]
		[FieldOffset(Offset = "0x228")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference BeveragesLang;

		// Token: 0x04003E73 RID: 15987
		[Token(Token = "0x4003E73")]
		[FieldOffset(Offset = "0x230")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference FoodsLang;

		// Token: 0x04003E74 RID: 15988
		[Token(Token = "0x4003E74")]
		[FieldOffset(Offset = "0x238")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference MissionsLang;

		// Token: 0x04003E75 RID: 15989
		[Token(Token = "0x4003E75")]
		[FieldOffset(Offset = "0x240")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference NewsLang;

		// Token: 0x04003E76 RID: 15990
		[Token(Token = "0x4003E76")]
		[FieldOffset(Offset = "0x248")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference CookersLang;

		// Token: 0x04003E77 RID: 15991
		[Token(Token = "0x4003E77")]
		[FieldOffset(Offset = "0x250")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference IzakayasLang;

		// Token: 0x04003E78 RID: 15992
		[Token(Token = "0x4003E78")]
		[FieldOffset(Offset = "0x258")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference NormalGuestLang;

		// Token: 0x04003E79 RID: 15993
		[Token(Token = "0x4003E79")]
		[FieldOffset(Offset = "0x260")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference SpecialGuestLang;

		// Token: 0x04003E7A RID: 15994
		[Token(Token = "0x4003E7A")]
		[FieldOffset(Offset = "0x268")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference SpecialGuestFoodRequestLang;

		// Token: 0x04003E7B RID: 15995
		[Token(Token = "0x4003E7B")]
		[FieldOffset(Offset = "0x270")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference SpecialGuestBevRequestLang;

		// Token: 0x04003E7C RID: 15996
		[Token(Token = "0x4003E7C")]
		[FieldOffset(Offset = "0x278")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference BuffDescriptionLang;

		// Token: 0x04003E7D RID: 15997
		[Token(Token = "0x4003E7D")]
		[FieldOffset(Offset = "0x280")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference MissionFinishConditionLang;

		// Token: 0x04003E7E RID: 15998
		[Token(Token = "0x4003E7E")]
		[FieldOffset(Offset = "0x288")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference RewardConditionLang;

		// Token: 0x04003E7F RID: 15999
		[Token(Token = "0x4003E7F")]
		[FieldOffset(Offset = "0x290")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference PartnerJobLang;

		// Token: 0x04003E80 RID: 16000
		[Token(Token = "0x4003E80")]
		[FieldOffset(Offset = "0x298")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference CGDataLang;

		// Token: 0x04003E81 RID: 16001
		[Token(Token = "0x4003E81")]
		[FieldOffset(Offset = "0x2A0")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference MusicNameDataLang;

		// Token: 0x04003E82 RID: 16002
		[Token(Token = "0x4003E82")]
		[FieldOffset(Offset = "0x2A8")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference SpellLang;

		// Token: 0x04003E83 RID: 16003
		[Token(Token = "0x4003E83")]
		[FieldOffset(Offset = "0x2B0")]
		[Header("Night Langauge")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference SpecialEvalLang;

		// Token: 0x04003E84 RID: 16004
		[Token(Token = "0x4003E84")]
		[FieldOffset(Offset = "0x2B8")]
		public AssetReference NormalEvalIndex;

		// Token: 0x04003E85 RID: 16005
		[Token(Token = "0x4003E85")]
		[FieldOffset(Offset = "0x2C0")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference NormalEvalLang;

		// Token: 0x04003E86 RID: 16006
		[Token(Token = "0x4003E86")]
		[FieldOffset(Offset = "0x2C8")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference SpecialConvLang;

		// Token: 0x04003E87 RID: 16007
		[Token(Token = "0x4003E87")]
		[FieldOffset(Offset = "0x2D0")]
		public AssetReference NormalConvProfile;

		// Token: 0x04003E88 RID: 16008
		[Token(Token = "0x4003E88")]
		[FieldOffset(Offset = "0x2D8")]
		public AssetReference SpecialConvProfile;

		// Token: 0x04003E89 RID: 16009
		[Token(Token = "0x4003E89")]
		[FieldOffset(Offset = "0x2E0")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference NormalConvLang;

		// Token: 0x04003E8A RID: 16010
		[Token(Token = "0x4003E8A")]
		[FieldOffset(Offset = "0x2E8")]
		[Header("Day Langauge")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference DaySceneNPCNameLang;

		// Token: 0x04003E8B RID: 16011
		[Token(Token = "0x4003E8B")]
		[FieldOffset(Offset = "0x2F0")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference DaySceneInteractableEntitiesNameLang;

		// Token: 0x04003E8C RID: 16012
		[Token(Token = "0x4003E8C")]
		[FieldOffset(Offset = "0x2F8")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference MapLang;

		// Token: 0x04003E8D RID: 16013
		[Token(Token = "0x4003E8D")]
		[FieldOffset(Offset = "0x300")]
		[Header("Achievement")]
		public AssetReference AchievementProfile;

		// Token: 0x04003E8E RID: 16014
		[Token(Token = "0x4003E8E")]
		[FieldOffset(Offset = "0x308")]
		[Header("Staff")]
		public AssetReference[] AdditionalStaffPages;

		// Token: 0x04003E8F RID: 16015
		[Token(Token = "0x4003E8F")]
		[FieldOffset(Offset = "0x310")]
		public ConcertProfile ConcertProfile;

		// Token: 0x04003E90 RID: 16016
		[Token(Token = "0x4003E90")]
		[FieldOffset(Offset = "0x318")]
		public ConcertProfile ConcertProfileAlt;

		// Token: 0x02000B8A RID: 2954
		[Token(Token = "0x2000B8A")]
		[Serializable]
		public enum MapAddtiveType
		{
			// Token: 0x04003E92 RID: 16018
			[Token(Token = "0x4003E92")]
			Target,
			// Token: 0x04003E93 RID: 16019
			[Token(Token = "0x4003E93")]
			All
		}

		// Token: 0x02000B8B RID: 2955
		[Token(Token = "0x2000B8B")]
		[Serializable]
		public struct IzakayaAdditiveData
		{
			// Token: 0x04003E94 RID: 16020
			[Token(Token = "0x4003E94")]
			[FieldOffset(Offset = "0x0")]
			public int izakayaId;

			// Token: 0x04003E95 RID: 16021
			[Token(Token = "0x4003E95")]
			[FieldOffset(Offset = "0x8")]
			public Izakaya.NormalGuestGroup[] additiveNormalGuestPool;

			// Token: 0x04003E96 RID: 16022
			[Token(Token = "0x4003E96")]
			[FieldOffset(Offset = "0x10")]
			public Izakaya.SpecialGuestGroup[] additiveSpecialGuestPool;

			// Token: 0x04003E97 RID: 16023
			[Token(Token = "0x4003E97")]
			[FieldOffset(Offset = "0x18")]
			public ExpandableGameDataPack.AssetReferenceIdPair[] additiveIzakayaSkin;
		}

		// Token: 0x02000B8C RID: 2956
		[Token(Token = "0x2000B8C")]
		[Serializable]
		public struct MapAdditiveData
		{
			// Token: 0x04003E98 RID: 16024
			[Token(Token = "0x4003E98")]
			[FieldOffset(Offset = "0x0")]
			public ExpandableGameDataPack.MapAddtiveType type;

			// Token: 0x04003E99 RID: 16025
			[Token(Token = "0x4003E99")]
			[FieldOffset(Offset = "0x8")]
			public string mapKey;

			// Token: 0x04003E9A RID: 16026
			[Token(Token = "0x4003E9A")]
			[FieldOffset(Offset = "0x10")]
			public AssetReference additionalObjectReference;

			// Token: 0x04003E9B RID: 16027
			[Token(Token = "0x4003E9B")]
			[FieldOffset(Offset = "0x18")]
			public bool enableCustomPosition;

			// Token: 0x04003E9C RID: 16028
			[Token(Token = "0x4003E9C")]
			[FieldOffset(Offset = "0x1C")]
			public Vector2 worldPosition;
		}

		// Token: 0x02000B8D RID: 2957
		[Token(Token = "0x2000B8D")]
		[Serializable]
		public struct SchedulerConnectionData
		{
			// Token: 0x04003E9D RID: 16029
			[Token(Token = "0x4003E9D")]
			[FieldOffset(Offset = "0x0")]
			public string sourceNode;

			// Token: 0x04003E9E RID: 16030
			[Token(Token = "0x4003E9E")]
			[FieldOffset(Offset = "0x8")]
			public string targetNode;

			// Token: 0x04003E9F RID: 16031
			[Token(Token = "0x4003E9F")]
			[FieldOffset(Offset = "0x10")]
			public bool finishAfterPerformance;
		}

		// Token: 0x02000B8E RID: 2958
		[Token(Token = "0x2000B8E")]
		[Serializable]
		public struct SchedulerNewsData
		{
			// Token: 0x04003EA0 RID: 16032
			[Token(Token = "0x4003EA0")]
			[FieldOffset(Offset = "0x0")]
			public string sourceNode;

			// Token: 0x04003EA1 RID: 16033
			[Token(Token = "0x4003EA1")]
			[FieldOffset(Offset = "0x8")]
			public string targetNews;

			// Token: 0x04003EA2 RID: 16034
			[Token(Token = "0x4003EA2")]
			[FieldOffset(Offset = "0x10")]
			public SchedulerNode.Day triggerDay;
		}

		// Token: 0x02000B8F RID: 2959
		[Token(Token = "0x2000B8F")]
		[Serializable]
		public struct AssetReferenceIdPair
		{
			// Token: 0x04003EA3 RID: 16035
			[Token(Token = "0x4003EA3")]
			[FieldOffset(Offset = "0x0")]
			public int id;

			// Token: 0x04003EA4 RID: 16036
			[Token(Token = "0x4003EA4")]
			[FieldOffset(Offset = "0x8")]
			public AssetReference data;
		}

		// Token: 0x02000B90 RID: 2960
		[Token(Token = "0x2000B90")]
		[Serializable]
		public struct SpecialGuestAdditiveData
		{
			// Token: 0x17000A1E RID: 2590
			// (get) Token: 0x0600463A RID: 17978 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A1E")]
			public int[] AdditiveHateFoodTag
			{
				[Token(Token = "0x600463A")]
				[Address(RVA = "0x7418D0", Offset = "0x7402D0", VA = "0x1807418D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A1F RID: 2591
			// (get) Token: 0x0600463B RID: 17979 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A1F")]
			public SpecialGuest.WeightedTag[] AdditiveLikeFoodTag
			{
				[Token(Token = "0x600463B")]
				[Address(RVA = "0x7419B0", Offset = "0x7403B0", VA = "0x1807419B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A20 RID: 2592
			// (get) Token: 0x0600463C RID: 17980 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A20")]
			public SpecialGuest.WeightedTag[] AdditiveLikeBevTag
			{
				[Token(Token = "0x600463C")]
				[Address(RVA = "0x741960", Offset = "0x740360", VA = "0x180741960")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A21 RID: 2593
			// (get) Token: 0x0600463D RID: 17981 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A21")]
			public string[] AdditiveUnifiedSpawnExclusion
			{
				[Token(Token = "0x600463D")]
				[Address(RVA = "0x741A00", Offset = "0x740400", VA = "0x180741A00")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A22 RID: 2594
			// (get) Token: 0x0600463E RID: 17982 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A22")]
			public DialogPackage[] AdditiveCharacterKizunaLevel1Welcome
			{
				[Token(Token = "0x600463E")]
				[Address(RVA = "0x7411A0", Offset = "0x73FBA0", VA = "0x1807411A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A23 RID: 2595
			// (get) Token: 0x0600463F RID: 17983 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A23")]
			public DialogPackage[] AdditiveCharacterKizunaLevel2Welcome
			{
				[Token(Token = "0x600463F")]
				[Address(RVA = "0x7412E0", Offset = "0x73FCE0", VA = "0x1807412E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A24 RID: 2596
			// (get) Token: 0x06004640 RID: 17984 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A24")]
			public DialogPackage[] AdditiveCharacterKizunaLevel3Welcome
			{
				[Token(Token = "0x6004640")]
				[Address(RVA = "0x741470", Offset = "0x73FE70", VA = "0x180741470")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A25 RID: 2597
			// (get) Token: 0x06004641 RID: 17985 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A25")]
			public DialogPackage[] AdditiveCharacterKizunaLevel4Welcome
			{
				[Token(Token = "0x6004641")]
				[Address(RVA = "0x741650", Offset = "0x740050", VA = "0x180741650")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A26 RID: 2598
			// (get) Token: 0x06004642 RID: 17986 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A26")]
			public DialogPackage[] AdditiveCharacterKizunaLevel5Welcome
			{
				[Token(Token = "0x6004642")]
				[Address(RVA = "0x741880", Offset = "0x740280", VA = "0x180741880")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A27 RID: 2599
			// (get) Token: 0x06004643 RID: 17987 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A27")]
			public string[] AdditiveCharacterKizunaLevel1ChatData
			{
				[Token(Token = "0x6004643")]
				[Address(RVA = "0x741150", Offset = "0x73FB50", VA = "0x180741150")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A28 RID: 2600
			// (get) Token: 0x06004644 RID: 17988 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A28")]
			public string[] AdditiveCharacterKizunaLevel2ChatData
			{
				[Token(Token = "0x6004644")]
				[Address(RVA = "0x7411F0", Offset = "0x73FBF0", VA = "0x1807411F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A29 RID: 2601
			// (get) Token: 0x06004645 RID: 17989 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A29")]
			public string[] AdditiveCharacterKizunaLevel3ChatData
			{
				[Token(Token = "0x6004645")]
				[Address(RVA = "0x741330", Offset = "0x73FD30", VA = "0x180741330")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A2A RID: 2602
			// (get) Token: 0x06004646 RID: 17990 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A2A")]
			public string[] AdditiveCharacterKizunaLevel4ChatData
			{
				[Token(Token = "0x6004646")]
				[Address(RVA = "0x7414C0", Offset = "0x73FEC0", VA = "0x1807414C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A2B RID: 2603
			// (get) Token: 0x06004647 RID: 17991 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A2B")]
			public string[] AdditiveCharacterKizunaLevel5ChatData
			{
				[Token(Token = "0x6004647")]
				[Address(RVA = "0x7416A0", Offset = "0x7400A0", VA = "0x1807416A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A2C RID: 2604
			// (get) Token: 0x06004648 RID: 17992 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A2C")]
			public DialogPackage[] AdditiveCharacterKizunaLevel2InviteSucceed
			{
				[Token(Token = "0x6004648")]
				[Address(RVA = "0x741290", Offset = "0x73FC90", VA = "0x180741290")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A2D RID: 2605
			// (get) Token: 0x06004649 RID: 17993 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A2D")]
			public DialogPackage[] AdditiveCharacterKizunaLevel2InviteFailed
			{
				[Token(Token = "0x6004649")]
				[Address(RVA = "0x741240", Offset = "0x73FC40", VA = "0x180741240")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A2E RID: 2606
			// (get) Token: 0x0600464A RID: 17994 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A2E")]
			public DialogPackage[] AdditiveCharacterKizunaLevel3InviteSucceed
			{
				[Token(Token = "0x600464A")]
				[Address(RVA = "0x7413D0", Offset = "0x73FDD0", VA = "0x1807413D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A2F RID: 2607
			// (get) Token: 0x0600464B RID: 17995 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A2F")]
			public DialogPackage[] AdditiveCharacterKizunaLevel3InviteFailed
			{
				[Token(Token = "0x600464B")]
				[Address(RVA = "0x741380", Offset = "0x73FD80", VA = "0x180741380")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A30 RID: 2608
			// (get) Token: 0x0600464C RID: 17996 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A30")]
			public DialogPackage[] AdditiveCharacterKizunaLevel4InviteSucceed
			{
				[Token(Token = "0x600464C")]
				[Address(RVA = "0x741560", Offset = "0x73FF60", VA = "0x180741560")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A31 RID: 2609
			// (get) Token: 0x0600464D RID: 17997 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A31")]
			public DialogPackage[] AdditiveCharacterKizunaLevel4InviteFailed
			{
				[Token(Token = "0x600464D")]
				[Address(RVA = "0x741510", Offset = "0x73FF10", VA = "0x180741510")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A32 RID: 2610
			// (get) Token: 0x0600464E RID: 17998 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A32")]
			public DialogPackage[] AdditiveCharacterKizunaLevel5InviteSucceed
			{
				[Token(Token = "0x600464E")]
				[Address(RVA = "0x741790", Offset = "0x740190", VA = "0x180741790")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A33 RID: 2611
			// (get) Token: 0x0600464F RID: 17999 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A33")]
			public DialogPackage[] AdditiveCharacterKizunaLevel3RequestIngerdient
			{
				[Token(Token = "0x600464F")]
				[Address(RVA = "0x741420", Offset = "0x73FE20", VA = "0x180741420")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A34 RID: 2612
			// (get) Token: 0x06004650 RID: 18000 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A34")]
			public DialogPackage[] AdditiveCharacterKizunaLevel4RequestIngerdient
			{
				[Token(Token = "0x6004650")]
				[Address(RVA = "0x741600", Offset = "0x740000", VA = "0x180741600")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A35 RID: 2613
			// (get) Token: 0x06004651 RID: 18001 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A35")]
			public DialogPackage[] AdditiveCharacterKizunaLevel5RequestIngerdient
			{
				[Token(Token = "0x6004651")]
				[Address(RVA = "0x741830", Offset = "0x740230", VA = "0x180741830")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A36 RID: 2614
			// (get) Token: 0x06004652 RID: 18002 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A36")]
			public DialogPackage[] AdditiveCharacterKizunaLevel4RequestBeverage
			{
				[Token(Token = "0x6004652")]
				[Address(RVA = "0x7415B0", Offset = "0x73FFB0", VA = "0x1807415B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A37 RID: 2615
			// (get) Token: 0x06004653 RID: 18003 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A37")]
			public DialogPackage[] AdditiveCharacterKizunaLevel5RequestBeverage
			{
				[Token(Token = "0x6004653")]
				[Address(RVA = "0x7417E0", Offset = "0x7401E0", VA = "0x1807417E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A38 RID: 2616
			// (get) Token: 0x06004654 RID: 18004 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A38")]
			public DialogPackage[] AdditiveCharacterKizunaLevel5Commision
			{
				[Token(Token = "0x6004654")]
				[Address(RVA = "0x741740", Offset = "0x740140", VA = "0x180741740")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A39 RID: 2617
			// (get) Token: 0x06004655 RID: 18005 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A39")]
			public DialogPackage[] AdditiveCharacterKizunaLevel5CommisionFinish
			{
				[Token(Token = "0x6004655")]
				[Address(RVA = "0x7416F0", Offset = "0x7400F0", VA = "0x1807416F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004656 RID: 18006 RVA: 0x000194E8 File Offset: 0x000176E8
			[Token(Token = "0x6004656")]
			[Address(RVA = "0x741A50", Offset = "0x740450", VA = "0x180741A50")]
			public static ExpandableGameDataPack.SpecialGuestAdditiveData operator +(ExpandableGameDataPack.SpecialGuestAdditiveData current, ExpandableGameDataPack.SpecialGuestAdditiveData next)
			{
				return default(ExpandableGameDataPack.SpecialGuestAdditiveData);
			}

			// Token: 0x04003EA5 RID: 16037
			[Token(Token = "0x4003EA5")]
			[FieldOffset(Offset = "0x0")]
			public int id;

			// Token: 0x04003EA6 RID: 16038
			[Token(Token = "0x4003EA6")]
			[FieldOffset(Offset = "0x8")]
			private string[] additiveCharacterKizunaLevel1ChatData;

			// Token: 0x04003EA7 RID: 16039
			[Token(Token = "0x4003EA7")]
			[FieldOffset(Offset = "0x10")]
			private DialogPackage[] additiveCharacterKizunaLevel1Welcome;

			// Token: 0x04003EA8 RID: 16040
			[Token(Token = "0x4003EA8")]
			[FieldOffset(Offset = "0x18")]
			private string[] additiveCharacterKizunaLevel2ChatData;

			// Token: 0x04003EA9 RID: 16041
			[Token(Token = "0x4003EA9")]
			[FieldOffset(Offset = "0x20")]
			private DialogPackage[] additiveCharacterKizunaLevel2InviteFailed;

			// Token: 0x04003EAA RID: 16042
			[Token(Token = "0x4003EAA")]
			[FieldOffset(Offset = "0x28")]
			private DialogPackage[] additiveCharacterKizunaLevel2InviteSucceed;

			// Token: 0x04003EAB RID: 16043
			[Token(Token = "0x4003EAB")]
			[FieldOffset(Offset = "0x30")]
			private DialogPackage[] additiveCharacterKizunaLevel2Welcome;

			// Token: 0x04003EAC RID: 16044
			[Token(Token = "0x4003EAC")]
			[FieldOffset(Offset = "0x38")]
			private string[] additiveCharacterKizunaLevel3ChatData;

			// Token: 0x04003EAD RID: 16045
			[Token(Token = "0x4003EAD")]
			[FieldOffset(Offset = "0x40")]
			private DialogPackage[] additiveCharacterKizunaLevel3InviteFailed;

			// Token: 0x04003EAE RID: 16046
			[Token(Token = "0x4003EAE")]
			[FieldOffset(Offset = "0x48")]
			private DialogPackage[] additiveCharacterKizunaLevel3InviteSucceed;

			// Token: 0x04003EAF RID: 16047
			[Token(Token = "0x4003EAF")]
			[FieldOffset(Offset = "0x50")]
			private DialogPackage[] additiveCharacterKizunaLevel3RequestIngerdient;

			// Token: 0x04003EB0 RID: 16048
			[Token(Token = "0x4003EB0")]
			[FieldOffset(Offset = "0x58")]
			private DialogPackage[] additiveCharacterKizunaLevel3Welcome;

			// Token: 0x04003EB1 RID: 16049
			[Token(Token = "0x4003EB1")]
			[FieldOffset(Offset = "0x60")]
			private string[] additiveCharacterKizunaLevel4ChatData;

			// Token: 0x04003EB2 RID: 16050
			[Token(Token = "0x4003EB2")]
			[FieldOffset(Offset = "0x68")]
			private DialogPackage[] additiveCharacterKizunaLevel4InviteFailed;

			// Token: 0x04003EB3 RID: 16051
			[Token(Token = "0x4003EB3")]
			[FieldOffset(Offset = "0x70")]
			private DialogPackage[] additiveCharacterKizunaLevel4InviteSucceed;

			// Token: 0x04003EB4 RID: 16052
			[Token(Token = "0x4003EB4")]
			[FieldOffset(Offset = "0x78")]
			private DialogPackage[] additiveCharacterKizunaLevel4RequestBeverage;

			// Token: 0x04003EB5 RID: 16053
			[Token(Token = "0x4003EB5")]
			[FieldOffset(Offset = "0x80")]
			private DialogPackage[] additiveCharacterKizunaLevel4RequestIngerdient;

			// Token: 0x04003EB6 RID: 16054
			[Token(Token = "0x4003EB6")]
			[FieldOffset(Offset = "0x88")]
			private DialogPackage[] additiveCharacterKizunaLevel4Welcome;

			// Token: 0x04003EB7 RID: 16055
			[Token(Token = "0x4003EB7")]
			[FieldOffset(Offset = "0x90")]
			private string[] additiveCharacterKizunaLevel5ChatData;

			// Token: 0x04003EB8 RID: 16056
			[Token(Token = "0x4003EB8")]
			[FieldOffset(Offset = "0x98")]
			private DialogPackage[] additiveCharacterKizunaLevel5Commision;

			// Token: 0x04003EB9 RID: 16057
			[Token(Token = "0x4003EB9")]
			[FieldOffset(Offset = "0xA0")]
			private DialogPackage[] additiveCharacterKizunaLevel5CommisionFinish;

			// Token: 0x04003EBA RID: 16058
			[Token(Token = "0x4003EBA")]
			[FieldOffset(Offset = "0xA8")]
			private DialogPackage[] additiveCharacterKizunaLevel5InviteSucceed;

			// Token: 0x04003EBB RID: 16059
			[Token(Token = "0x4003EBB")]
			[FieldOffset(Offset = "0xB0")]
			private DialogPackage[] additiveCharacterKizunaLevel5RequestBeverage;

			// Token: 0x04003EBC RID: 16060
			[Token(Token = "0x4003EBC")]
			[FieldOffset(Offset = "0xB8")]
			private DialogPackage[] additiveCharacterKizunaLevel5RequestIngerdient;

			// Token: 0x04003EBD RID: 16061
			[Token(Token = "0x4003EBD")]
			[FieldOffset(Offset = "0xC0")]
			private DialogPackage[] additiveCharacterKizunaLevel5Welcome;

			// Token: 0x04003EBE RID: 16062
			[Token(Token = "0x4003EBE")]
			[FieldOffset(Offset = "0xC8")]
			private int[] additiveHateFoodTag;

			// Token: 0x04003EBF RID: 16063
			[Token(Token = "0x4003EBF")]
			[FieldOffset(Offset = "0xD0")]
			private SpecialGuest.WeightedTag[] additiveLikeBevTag;

			// Token: 0x04003EC0 RID: 16064
			[Token(Token = "0x4003EC0")]
			[FieldOffset(Offset = "0xD8")]
			private SpecialGuest.WeightedTag[] additiveLikeFoodTag;

			// Token: 0x04003EC1 RID: 16065
			[Token(Token = "0x4003EC1")]
			[FieldOffset(Offset = "0xE0")]
			private string[] additiveUnifiedSpawnExclusion;
		}
	}
}
