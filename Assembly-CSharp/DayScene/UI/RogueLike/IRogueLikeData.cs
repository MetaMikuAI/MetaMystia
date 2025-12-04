using System;
using System.Collections.Generic;
using GameData;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000442 RID: 1090
	[Token(Token = "0x2000442")]
	public struct IRogueLikeData : IRogueLikeCustomizedDataProfile
	{
		// Token: 0x06001850 RID: 6224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001850")]
		[Address(RVA = "0x40C360", Offset = "0x40AD60", VA = "0x18040C360")]
		public IRogueLikeData(IRogueLikeCustomizedDataProfile customizedData, DLC5_RogueLikeDataProfileUnchangeable unchangeableData)
		{
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x000090F0 File Offset: 0x000072F0
		[Token(Token = "0x6001851")]
		[Address(RVA = "0x477FB0", Offset = "0x4769B0", VA = "0x180477FB0")]
		public bool EnsureDataValid()
		{
			return default(bool);
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030C")]
		public IReadOnlyList<Product> InitialProducts
		{
			[Token(Token = "0x6001852")]
			[Address(RVA = "0x478810", Offset = "0x477210", VA = "0x180478810", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030D")]
		public IReadOnlyList<int> InitialRecipePool
		{
			[Token(Token = "0x6001853")]
			[Address(RVA = "0x478860", Offset = "0x477260", VA = "0x180478860", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030E")]
		public IReadOnlyList<int> InitialBevPool
		{
			[Token(Token = "0x6001854")]
			[Address(RVA = "0x478780", Offset = "0x477180", VA = "0x180478780", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700030F")]
		public IReadOnlyList<Vector2Int> BevLevelLinkToNum
		{
			[Token(Token = "0x6001855")]
			[Address(RVA = "0x478200", Offset = "0x476C00", VA = "0x180478200", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000310")]
		public IReadOnlyList<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup> RoundSetups
		{
			[Token(Token = "0x6001856")]
			[Address(RVA = "0x478DA0", Offset = "0x4777A0", VA = "0x180478DA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000311")]
		public IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup> MapSetups
		{
			[Token(Token = "0x6001857")]
			[Address(RVA = "0x478B60", Offset = "0x477560", VA = "0x180478B60", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000312")]
		public IReadOnlyList<DLC5_RogueLikeDataProfile.CookerPriceSetup> CookerPriceSetups
		{
			[Token(Token = "0x6001858")]
			[Address(RVA = "0x478360", Offset = "0x476D60", VA = "0x180478360", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06001859 RID: 6233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000313")]
		public IReadOnlyList<TriggerCardData> GachaTriggerData
		{
			[Token(Token = "0x6001859")]
			[Address(RVA = "0x4786E0", Offset = "0x4770E0", VA = "0x1804786E0", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600185A RID: 6234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000314")]
		public IReadOnlyList<RogueLikeCardRewardPair> GachaRewardPairData
		{
			[Token(Token = "0x600185A")]
			[Address(RVA = "0x478690", Offset = "0x477090", VA = "0x180478690", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x00009108 File Offset: 0x00007308
		[Token(Token = "0x17000315")]
		public int RoundDuration
		{
			[Token(Token = "0x600185B")]
			[Address(RVA = "0x478D50", Offset = "0x477750", VA = "0x180478D50", Slot = "13")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600185C RID: 6236 RVA: 0x00009120 File Offset: 0x00007320
		[Token(Token = "0x17000316")]
		public float GlobalProductMultiplier
		{
			[Token(Token = "0x600185C")]
			[Address(RVA = "0x478730", Offset = "0x477130", VA = "0x180478730", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x00009138 File Offset: 0x00007338
		[Token(Token = "0x17000317")]
		public float Level1RecipePriceMultiplier
		{
			[Token(Token = "0x600185D")]
			[Address(RVA = "0x478980", Offset = "0x477380", VA = "0x180478980", Slot = "15")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x00009150 File Offset: 0x00007350
		[Token(Token = "0x17000318")]
		public float Level2RecipePriceMultiplier
		{
			[Token(Token = "0x600185E")]
			[Address(RVA = "0x4789D0", Offset = "0x4773D0", VA = "0x1804789D0", Slot = "16")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x00009168 File Offset: 0x00007368
		[Token(Token = "0x17000319")]
		public float Level3RecipePriceMultiplier
		{
			[Token(Token = "0x600185F")]
			[Address(RVA = "0x478A20", Offset = "0x477420", VA = "0x180478A20", Slot = "17")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x00009180 File Offset: 0x00007380
		[Token(Token = "0x1700031A")]
		public float Level4RecipePriceMultiplier
		{
			[Token(Token = "0x6001860")]
			[Address(RVA = "0x478A70", Offset = "0x477470", VA = "0x180478A70", Slot = "18")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x00009198 File Offset: 0x00007398
		[Token(Token = "0x1700031B")]
		public float Level5RecipePriceMultiplier
		{
			[Token(Token = "0x6001861")]
			[Address(RVA = "0x478AC0", Offset = "0x4774C0", VA = "0x180478AC0", Slot = "19")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x000091B0 File Offset: 0x000073B0
		[Token(Token = "0x1700031C")]
		public int PartnerBasePrice
		{
			[Token(Token = "0x6001862")]
			[Address(RVA = "0x478BB0", Offset = "0x4775B0", VA = "0x180478BB0", Slot = "20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06001863 RID: 6243 RVA: 0x000091C8 File Offset: 0x000073C8
		[Token(Token = "0x1700031D")]
		public int SpecialGuestPrice
		{
			[Token(Token = "0x6001863")]
			[Address(RVA = "0x478E40", Offset = "0x477840", VA = "0x180478E40", Slot = "21")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x000091E0 File Offset: 0x000073E0
		[Token(Token = "0x1700031E")]
		public int EliteSpecialGuestPrice
		{
			[Token(Token = "0x6001864")]
			[Address(RVA = "0x478440", Offset = "0x476E40", VA = "0x180478440", Slot = "22")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x000091F8 File Offset: 0x000073F8
		[Token(Token = "0x1700031F")]
		public int ClothesPrice
		{
			[Token(Token = "0x6001865")]
			[Address(RVA = "0x478310", Offset = "0x476D10", VA = "0x180478310", Slot = "23")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x00009210 File Offset: 0x00007410
		[Token(Token = "0x17000320")]
		public int DecorationPrice
		{
			[Token(Token = "0x6001866")]
			[Address(RVA = "0x4783B0", Offset = "0x476DB0", VA = "0x1804783B0", Slot = "24")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x00009228 File Offset: 0x00007428
		[Token(Token = "0x17000321")]
		public int GachaNeedComboNum
		{
			[Token(Token = "0x6001867")]
			[Address(RVA = "0x4785A0", Offset = "0x476FA0", VA = "0x1804785A0", Slot = "25")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06001868 RID: 6248 RVA: 0x00009240 File Offset: 0x00007440
		[Token(Token = "0x17000322")]
		public int GachaNeedSpellNum
		{
			[Token(Token = "0x6001868")]
			[Address(RVA = "0x4785F0", Offset = "0x476FF0", VA = "0x1804785F0", Slot = "26")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06001869 RID: 6249 RVA: 0x00009258 File Offset: 0x00007458
		[Token(Token = "0x17000323")]
		public int GachaMaxCardNum
		{
			[Token(Token = "0x6001869")]
			[Address(RVA = "0x478550", Offset = "0x476F50", VA = "0x180478550", Slot = "27")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x00009270 File Offset: 0x00007470
		[Token(Token = "0x17000324")]
		public int BeginToSpawnDangerousCardRoundIndex
		{
			[Token(Token = "0x600186A")]
			[Address(RVA = "0x4781B0", Offset = "0x476BB0", VA = "0x1804781B0", Slot = "28")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x0600186B RID: 6251 RVA: 0x00009288 File Offset: 0x00007488
		[Token(Token = "0x17000325")]
		public int UnlockAllLevel2SpotRoundIndex
		{
			[Token(Token = "0x600186B")]
			[Address(RVA = "0x478F30", Offset = "0x477930", VA = "0x180478F30", Slot = "29")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x0600186C RID: 6252 RVA: 0x000092A0 File Offset: 0x000074A0
		[Token(Token = "0x17000326")]
		public int UnlockAllLevel3SpotRoundIndex
		{
			[Token(Token = "0x600186C")]
			[Address(RVA = "0x478F80", Offset = "0x477980", VA = "0x180478F80", Slot = "30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x000092B8 File Offset: 0x000074B8
		[Token(Token = "0x17000327")]
		public float LuckyLeafExtraMultiplier
		{
			[Token(Token = "0x600186D")]
			[Address(RVA = "0x478B10", Offset = "0x477510", VA = "0x180478B10", Slot = "31")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x0600186E RID: 6254 RVA: 0x000092D0 File Offset: 0x000074D0
		[Token(Token = "0x17000328")]
		public int AyaNewsBeginRoundIndex
		{
			[Token(Token = "0x600186E")]
			[Address(RVA = "0x478070", Offset = "0x476A70", VA = "0x180478070", Slot = "32")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x000092E8 File Offset: 0x000074E8
		[Token(Token = "0x17000329")]
		public int PriceToRefreshAyaNews
		{
			[Token(Token = "0x600186F")]
			[Address(RVA = "0x478C40", Offset = "0x477640", VA = "0x180478C40", Slot = "33")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001870 RID: 6256 RVA: 0x00009300 File Offset: 0x00007500
		[Token(Token = "0x1700032A")]
		public int AkyuuWashiPrice
		{
			[Token(Token = "0x6001870")]
			[Address(RVA = "0x478020", Offset = "0x476A20", VA = "0x180478020", Slot = "34")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x00009318 File Offset: 0x00007518
		[Token(Token = "0x1700032B")]
		public int EllenCandyPrice
		{
			[Token(Token = "0x6001871")]
			[Address(RVA = "0x478490", Offset = "0x476E90", VA = "0x180478490", Slot = "35")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x00009330 File Offset: 0x00007530
		[Token(Token = "0x1700032C")]
		public float KourindouDiscount
		{
			[Token(Token = "0x6001872")]
			[Address(RVA = "0x478930", Offset = "0x477330", VA = "0x180478930", Slot = "36")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x00009348 File Offset: 0x00007548
		[Token(Token = "0x1700032D")]
		public int GachaRecipeInitialNum
		{
			[Token(Token = "0x6001873")]
			[Address(RVA = "0x478640", Offset = "0x477040", VA = "0x180478640", Slot = "37")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x00009360 File Offset: 0x00007560
		[Token(Token = "0x1700032E")]
		public int GachaBevInitialNum
		{
			[Token(Token = "0x6001874")]
			[Address(RVA = "0x478500", Offset = "0x476F00", VA = "0x180478500", Slot = "38")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x00009378 File Offset: 0x00007578
		[Token(Token = "0x1700032F")]
		public int SelectRecipeInitialNum
		{
			[Token(Token = "0x6001875")]
			[Address(RVA = "0x478DF0", Offset = "0x4777F0", VA = "0x180478DF0", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x00009390 File Offset: 0x00007590
		[Token(Token = "0x17000330")]
		public int BaseGachaNumWhenSettle
		{
			[Token(Token = "0x6001876")]
			[Address(RVA = "0x4780C0", Offset = "0x476AC0", VA = "0x1804780C0", Slot = "40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x000093A8 File Offset: 0x000075A8
		[Token(Token = "0x17000331")]
		public int BaseMoveAction
		{
			[Token(Token = "0x6001877")]
			[Address(RVA = "0x478160", Offset = "0x476B60", VA = "0x180478160", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x000093C0 File Offset: 0x000075C0
		[Token(Token = "0x17000332")]
		public int BaseIngredientNumWhenGetRecipe
		{
			[Token(Token = "0x6001878")]
			[Address(RVA = "0x478110", Offset = "0x476B10", VA = "0x180478110", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x000093D8 File Offset: 0x000075D8
		[Token(Token = "0x17000333")]
		public int StartFund
		{
			[Token(Token = "0x6001879")]
			[Address(RVA = "0x478EE0", Offset = "0x4778E0", VA = "0x180478EE0", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000334")]
		public IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest> SpecialGuestVisitEverywhere
		{
			[Token(Token = "0x600187A")]
			[Address(RVA = "0x478E90", Offset = "0x477890", VA = "0x180478E90", Slot = "44")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000335")]
		public DLC5_RogueLikePoolResultPanel RoguelikePoolEditMessagePanel
		{
			[Token(Token = "0x600187B")]
			[Address(RVA = "0x478CF0", Offset = "0x4776F0", VA = "0x180478CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000336")]
		public DLC5_RogueLikePoolViewerPanel RoguelikePoolViewerPanel
		{
			[Token(Token = "0x600187C")]
			[Address(RVA = "0x478D10", Offset = "0x477710", VA = "0x180478D10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000337")]
		public AssetReference RoguelikeTutorialPanel
		{
			[Token(Token = "0x600187D")]
			[Address(RVA = "0x478D30", Offset = "0x477730", VA = "0x180478D30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000338")]
		public AssetReference RogueLikeCardScorePanel
		{
			[Token(Token = "0x600187E")]
			[Address(RVA = "0x478CD0", Offset = "0x4776D0", VA = "0x180478CD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000339")]
		public DLC5_RogueLikeCardSelectorPanel CardSelectorPanel
		{
			[Token(Token = "0x600187F")]
			[Address(RVA = "0x4782B0", Offset = "0x476CB0", VA = "0x1804782B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033A")]
		public RogueLikeCard[] Cards
		{
			[Token(Token = "0x6001880")]
			[Address(RVA = "0x4782F0", Offset = "0x476CF0", VA = "0x1804782F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033B")]
		public MultiLanguageTextMesh.MultiLanguageTextAsset CardDescriptionLang
		{
			[Token(Token = "0x6001881")]
			[Address(RVA = "0x478290", Offset = "0x476C90", VA = "0x180478290")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700033C")]
		public RogueLikeCardPersistent[] CardsPersistent
		{
			[Token(Token = "0x6001882")]
			[Address(RVA = "0x4782D0", Offset = "0x476CD0", VA = "0x1804782D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x000093F0 File Offset: 0x000075F0
		[Token(Token = "0x1700033D")]
		public float RecipeCollectRateWeight
		{
			[Token(Token = "0x6001883")]
			[Address(RVA = "0x478C90", Offset = "0x477690", VA = "0x180478C90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x00009408 File Offset: 0x00007608
		[Token(Token = "0x1700033E")]
		public float ItemCollectRateWeight
		{
			[Token(Token = "0x6001884")]
			[Address(RVA = "0x4788F0", Offset = "0x4772F0", VA = "0x1804788F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x00009420 File Offset: 0x00007620
		[Token(Token = "0x1700033F")]
		public float PartnerCollectRateWeight
		{
			[Token(Token = "0x6001885")]
			[Address(RVA = "0x478C00", Offset = "0x477600", VA = "0x180478C00")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x00009438 File Offset: 0x00007638
		[Token(Token = "0x17000340")]
		public float IzakayaCollectRateWeight
		{
			[Token(Token = "0x6001886")]
			[Address(RVA = "0x478910", Offset = "0x477310", VA = "0x180478910")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000341")]
		public DLC5_RogueLikeDataProfile.RogueLikeAchievement[] RogueLikeAchievements
		{
			[Token(Token = "0x6001887")]
			[Address(RVA = "0x478CB0", Offset = "0x4776B0", VA = "0x180478CB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000342")]
		public Vector2Int[] PartnerPrice
		{
			[Token(Token = "0x6001888")]
			[Address(RVA = "0x478C20", Offset = "0x477620", VA = "0x180478C20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x00009450 File Offset: 0x00007650
		[Token(Token = "0x17000343")]
		public int FirstRefreshCardPrice
		{
			[Token(Token = "0x6001889")]
			[Address(RVA = "0x4784E0", Offset = "0x476EE0", VA = "0x1804784E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000344")]
		public RogueLikeRunTimeData.EliteChallengeBase[] EliteChallengeProfiles
		{
			[Token(Token = "0x600188A")]
			[Address(RVA = "0x478400", Offset = "0x476E00", VA = "0x180478400")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000345")]
		public DLC5_RogueLikeEliteRewardSelectionPanel EliteRewardSelectionPanel
		{
			[Token(Token = "0x600188B")]
			[Address(RVA = "0x478420", Offset = "0x476E20", VA = "0x180478420")]
			get
			{
				return null;
			}
		}

		// Token: 0x040016B8 RID: 5816
		[Token(Token = "0x40016B8")]
		[FieldOffset(Offset = "0x0")]
		private IRogueLikeCustomizedDataProfile m_CustomizedData;

		// Token: 0x040016B9 RID: 5817
		[Token(Token = "0x40016B9")]
		[FieldOffset(Offset = "0x8")]
		private DLC5_RogueLikeDataProfileUnchangeable m_UnchangeableData;
	}
}
