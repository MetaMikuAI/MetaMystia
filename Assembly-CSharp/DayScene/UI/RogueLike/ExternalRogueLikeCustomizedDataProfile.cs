using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000440 RID: 1088
	[Token(Token = "0x2000440")]
	[JsonObject(MemberSerialization.OptIn)]
	public class ExternalRogueLikeCustomizedDataProfile : IRogueLikeCustomizedDataProfile
	{
		// Token: 0x170002BA RID: 698
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BA")]
		public IReadOnlyList<Product> InitialProducts
		{
			[Token(Token = "0x60017FB")]
			[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BB")]
		public IReadOnlyList<int> InitialRecipePool
		{
			[Token(Token = "0x60017FC")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BC")]
		public IReadOnlyList<int> InitialBevPool
		{
			[Token(Token = "0x60017FD")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BD")]
		public IReadOnlyList<Vector2Int> BevLevelLinkToNum
		{
			[Token(Token = "0x60017FE")]
			[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x060017FF RID: 6143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BE")]
		public IReadOnlyList<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup> RoundSetups
		{
			[Token(Token = "0x60017FF")]
			[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002BF")]
		public IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup> MapSetups
		{
			[Token(Token = "0x6001800")]
			[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001801 RID: 6145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C0")]
		public IReadOnlyList<DLC5_RogueLikeDataProfile.CookerPriceSetup> CookerPriceSetups
		{
			[Token(Token = "0x6001801")]
			[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C1")]
		public IReadOnlyList<TriggerCardData> GachaTriggerData
		{
			[Token(Token = "0x6001802")]
			[Address(RVA = "0x440290", Offset = "0x43EC90", VA = "0x180440290", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C2")]
		public IReadOnlyList<RogueLikeCardRewardPair> GachaRewardPairData
		{
			[Token(Token = "0x6001803")]
			[Address(RVA = "0x440270", Offset = "0x43EC70", VA = "0x180440270", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002C3")]
		public IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest> SpecialGuestVisitEverywhere
		{
			[Token(Token = "0x6001804")]
			[Address(RVA = "0x477F80", Offset = "0x476980", VA = "0x180477F80", Slot = "44")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x00008E08 File Offset: 0x00007008
		[Token(Token = "0x170002C4")]
		[JsonProperty("RoundDuration")]
		public int RoundDuration
		{
			[Token(Token = "0x6001805")]
			[Address(RVA = "0x477F70", Offset = "0x476970", VA = "0x180477F70", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x00008E20 File Offset: 0x00007020
		[Token(Token = "0x170002C5")]
		[JsonProperty("GlobalProductMultiplier")]
		public float GlobalProductMultiplier
		{
			[Token(Token = "0x6001806")]
			[Address(RVA = "0x4402E0", Offset = "0x43ECE0", VA = "0x1804402E0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x00008E38 File Offset: 0x00007038
		[Token(Token = "0x170002C6")]
		[JsonProperty("Level1RecipePriceMultiplier")]
		public float Level1RecipePriceMultiplier
		{
			[Token(Token = "0x6001807")]
			[Address(RVA = "0x477F10", Offset = "0x476910", VA = "0x180477F10", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x00008E50 File Offset: 0x00007050
		[Token(Token = "0x170002C7")]
		[JsonProperty("Level2RecipePriceMultiplier")]
		public float Level2RecipePriceMultiplier
		{
			[Token(Token = "0x6001808")]
			[Address(RVA = "0x477F20", Offset = "0x476920", VA = "0x180477F20", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x00008E68 File Offset: 0x00007068
		[Token(Token = "0x170002C8")]
		[JsonProperty("Level3RecipePriceMultiplier")]
		public float Level3RecipePriceMultiplier
		{
			[Token(Token = "0x6001809")]
			[Address(RVA = "0x477F30", Offset = "0x476930", VA = "0x180477F30", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x00008E80 File Offset: 0x00007080
		[Token(Token = "0x170002C9")]
		[JsonProperty("Level4RecipePriceMultiplier")]
		public float Level4RecipePriceMultiplier
		{
			[Token(Token = "0x600180A")]
			[Address(RVA = "0x477F40", Offset = "0x476940", VA = "0x180477F40", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x00008E98 File Offset: 0x00007098
		[Token(Token = "0x170002CA")]
		[JsonProperty("Level5RecipePriceMultiplier")]
		public float Level5RecipePriceMultiplier
		{
			[Token(Token = "0x600180B")]
			[Address(RVA = "0x477F50", Offset = "0x476950", VA = "0x180477F50", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x00008EB0 File Offset: 0x000070B0
		[Token(Token = "0x170002CB")]
		[JsonProperty("PartnerBasePrice")]
		public int PartnerBasePrice
		{
			[Token(Token = "0x600180C")]
			[Address(RVA = "0x477F60", Offset = "0x476960", VA = "0x180477F60", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x00008EC8 File Offset: 0x000070C8
		[Token(Token = "0x170002CC")]
		[JsonProperty("SpecialGuestPrice")]
		public int SpecialGuestPrice
		{
			[Token(Token = "0x600180D")]
			[Address(RVA = "0x4404D0", Offset = "0x43EED0", VA = "0x1804404D0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x00008EE0 File Offset: 0x000070E0
		[Token(Token = "0x170002CD")]
		[JsonProperty("EliteSpecialGuestPrice")]
		public int EliteSpecialGuestPrice
		{
			[Token(Token = "0x600180E")]
			[Address(RVA = "0x4404E0", Offset = "0x43EEE0", VA = "0x1804404E0", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x00008EF8 File Offset: 0x000070F8
		[Token(Token = "0x170002CE")]
		[JsonProperty("ClothesPrice")]
		public int ClothesPrice
		{
			[Token(Token = "0x600180F")]
			[Address(RVA = "0x4171F0", Offset = "0x415BF0", VA = "0x1804171F0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001810 RID: 6160 RVA: 0x00008F10 File Offset: 0x00007110
		[Token(Token = "0x170002CF")]
		[JsonProperty("DecorationPrice")]
		public int DecorationPrice
		{
			[Token(Token = "0x6001810")]
			[Address(RVA = "0x440460", Offset = "0x43EE60", VA = "0x180440460", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x00008F28 File Offset: 0x00007128
		[Token(Token = "0x170002D0")]
		[JsonProperty("GachaNeedComboNum")]
		public int GachaNeedComboNum
		{
			[Token(Token = "0x6001811")]
			[Address(RVA = "0x4405B0", Offset = "0x43EFB0", VA = "0x1804405B0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001812 RID: 6162 RVA: 0x00008F40 File Offset: 0x00007140
		[Token(Token = "0x170002D1")]
		[JsonProperty("GachaNeedSpellNum")]
		public int GachaNeedSpellNum
		{
			[Token(Token = "0x6001812")]
			[Address(RVA = "0x4405C0", Offset = "0x43EFC0", VA = "0x1804405C0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001813 RID: 6163 RVA: 0x00008F58 File Offset: 0x00007158
		[Token(Token = "0x170002D2")]
		[JsonProperty("GachaMaxCardNum")]
		public int GachaMaxCardNum
		{
			[Token(Token = "0x6001813")]
			[Address(RVA = "0x477F00", Offset = "0x476900", VA = "0x180477F00", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x00008F70 File Offset: 0x00007170
		[Token(Token = "0x170002D3")]
		[JsonProperty("BeginToSpawnDangerousCardRoundIndex")]
		public int BeginToSpawnDangerousCardRoundIndex
		{
			[Token(Token = "0x6001814")]
			[Address(RVA = "0x477EF0", Offset = "0x4768F0", VA = "0x180477EF0", Slot = "28")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x00008F88 File Offset: 0x00007188
		[Token(Token = "0x170002D4")]
		[JsonProperty("UnlockAllLevel2SpotRoundIndex")]
		public int UnlockAllLevel2SpotRoundIndex
		{
			[Token(Token = "0x6001815")]
			[Address(RVA = "0x477F90", Offset = "0x476990", VA = "0x180477F90", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x00008FA0 File Offset: 0x000071A0
		[Token(Token = "0x170002D5")]
		[JsonProperty("UnlockAllLevel3SpotRoundIndex")]
		public int UnlockAllLevel3SpotRoundIndex
		{
			[Token(Token = "0x6001816")]
			[Address(RVA = "0x477FA0", Offset = "0x4769A0", VA = "0x180477FA0", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06001817 RID: 6167 RVA: 0x00008FB8 File Offset: 0x000071B8
		[Token(Token = "0x170002D6")]
		[JsonProperty("LuckyLeafExtraMultiplier")]
		public float LuckyLeafExtraMultiplier
		{
			[Token(Token = "0x6001817")]
			[Address(RVA = "0x440550", Offset = "0x43EF50", VA = "0x180440550", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x00008FD0 File Offset: 0x000071D0
		[Token(Token = "0x170002D7")]
		[JsonProperty("AyaNewsBeginRoundIndex")]
		public int AyaNewsBeginRoundIndex
		{
			[Token(Token = "0x6001818")]
			[Address(RVA = "0x409E40", Offset = "0x408840", VA = "0x180409E40", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06001819 RID: 6169 RVA: 0x00008FE8 File Offset: 0x000071E8
		[Token(Token = "0x170002D8")]
		[JsonProperty("PriceToRefreshAyaNews")]
		public int PriceToRefreshAyaNews
		{
			[Token(Token = "0x6001819")]
			[Address(RVA = "0x409E50", Offset = "0x408850", VA = "0x180409E50", Slot = "33")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x00009000 File Offset: 0x00007200
		[Token(Token = "0x170002D9")]
		[JsonProperty("AkyuuWashiPrice")]
		public int AkyuuWashiPrice
		{
			[Token(Token = "0x600181A")]
			[Address(RVA = "0x440420", Offset = "0x43EE20", VA = "0x180440420", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00009018 File Offset: 0x00007218
		[Token(Token = "0x170002DA")]
		[JsonProperty("EllenCandyPrice")]
		public int EllenCandyPrice
		{
			[Token(Token = "0x600181B")]
			[Address(RVA = "0x4404B0", Offset = "0x43EEB0", VA = "0x1804404B0", Slot = "35")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x00009030 File Offset: 0x00007230
		[Token(Token = "0x170002DB")]
		[JsonProperty("KourindouDiscount")]
		public float KourindouDiscount
		{
			[Token(Token = "0x600181C")]
			[Address(RVA = "0x440520", Offset = "0x43EF20", VA = "0x180440520", Slot = "36")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x00009048 File Offset: 0x00007248
		[Token(Token = "0x170002DC")]
		[JsonProperty("GachaRecipeInitialNum")]
		public int GachaRecipeInitialNum
		{
			[Token(Token = "0x600181D")]
			[Address(RVA = "0x43AEF0", Offset = "0x4398F0", VA = "0x18043AEF0", Slot = "37")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x00009060 File Offset: 0x00007260
		[Token(Token = "0x170002DD")]
		[JsonProperty("GachaBevInitialNum")]
		public int GachaBevInitialNum
		{
			[Token(Token = "0x600181E")]
			[Address(RVA = "0x409CD0", Offset = "0x4086D0", VA = "0x180409CD0", Slot = "38")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x00009078 File Offset: 0x00007278
		[Token(Token = "0x170002DE")]
		[JsonProperty("SelectRecipeInitialNum")]
		public int SelectRecipeInitialNum
		{
			[Token(Token = "0x600181F")]
			[Address(RVA = "0x409CF0", Offset = "0x4086F0", VA = "0x180409CF0", Slot = "39")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x00009090 File Offset: 0x00007290
		[Token(Token = "0x170002DF")]
		[JsonProperty("BaseGachaNumWhenSettle")]
		public int BaseGachaNumWhenSettle
		{
			[Token(Token = "0x6001820")]
			[Address(RVA = "0x409D00", Offset = "0x408700", VA = "0x180409D00", Slot = "40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x000090A8 File Offset: 0x000072A8
		[Token(Token = "0x170002E0")]
		[JsonProperty("BaseMoveAction")]
		public int BaseMoveAction
		{
			[Token(Token = "0x6001821")]
			[Address(RVA = "0x4404F0", Offset = "0x43EEF0", VA = "0x1804404F0", Slot = "41")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06001822 RID: 6178 RVA: 0x000090C0 File Offset: 0x000072C0
		[Token(Token = "0x170002E1")]
		[JsonProperty("BaseIngredientNumWhenGetRecipe")]
		public int BaseIngredientNumWhenGetRecipe
		{
			[Token(Token = "0x6001822")]
			[Address(RVA = "0x4404C0", Offset = "0x43EEC0", VA = "0x1804404C0", Slot = "42")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x000090D8 File Offset: 0x000072D8
		[Token(Token = "0x170002E2")]
		[JsonProperty("StartFund")]
		public int StartFund
		{
			[Token(Token = "0x6001823")]
			[Address(RVA = "0x440580", Offset = "0x43EF80", VA = "0x180440580", Slot = "43")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001824")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public ExternalRogueLikeCustomizedDataProfile()
		{
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001825")]
		[Address(RVA = "0x477CA0", Offset = "0x4766A0", VA = "0x180477CA0")]
		[JsonConstructor]
		public ExternalRogueLikeCustomizedDataProfile(Product[] initialProducts, DLC5_RogueLikeDataProfile.RogueLikeRoundSetup[] roundSetups, DLC5_RogueLikeDataProfile.MapSetup[] mapSetups, DLC5_RogueLikeDataProfile.CookerPriceSetup[] cookerPriceSetups, TriggerCardData[] gachaTriggerData, RogueLikeCardRewardPair[] gachaRewardPairData, int roundDuration, float globalProductMultiplier, float level1RecipePriceMultiplier, float level2RecipePriceMultiplier, float level3RecipePriceMultiplier, float level4RecipePriceMultiplier, float level5RecipePriceMultiplier, int partnerBasePrice, int specialGuestPrice, int eliteSpecialGuestPrice, int clothesPrice, int decorationPrice, int gachaNeedComboNum, int gachaNeedSpellNum, int gachaMaxCardNum, int beginToSpawnDangerousCardRoundIndex, int unlockAllLevel2SpotRoundIndex, int unlockAllLevel3SpotRoundIndex, float luckyLeafExtraMultiplier, int ayaNewsBeginRoundIndex, int priceToRefreshAyaNews, int akyuuWashiPrice, int ellenCandyPrice, float kourindouDiscount, int gachaRecipeInitialNum, int gachaBevInitialNum, int selectRecipeInitialNum, int baseGachaNumWhenSettle, int baseMoveAction, int baseIngredientNumWhenGetRecipe, DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest[] specialGuestVisitEverywhere, int startFund)
		{
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001826")]
		[Address(RVA = "0x4776E0", Offset = "0x4760E0", VA = "0x1804776E0")]
		public ExternalRogueLikeCustomizedDataProfile(IRogueLikeCustomizedDataProfile rogueLikeCustomizedDataProfile)
		{
		}

		// Token: 0x0400168F RID: 5775
		[Token(Token = "0x400168F")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("InitialProducts")]
		private Product[] m_InitialProducts;

		// Token: 0x04001690 RID: 5776
		[Token(Token = "0x4001690")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("InitialRecipePool")]
		private int[] m_InitialRecipePool;

		// Token: 0x04001691 RID: 5777
		[Token(Token = "0x4001691")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("InitialBevPool")]
		private int[] m_InitialBevPool;

		// Token: 0x04001692 RID: 5778
		[Token(Token = "0x4001692")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("BevLevelLinkToNum")]
		private Vector2Int[] m_BevLevelLinkToNum;

		// Token: 0x04001693 RID: 5779
		[Token(Token = "0x4001693")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("RoundSetups")]
		private DLC5_RogueLikeDataProfile.RogueLikeRoundSetup[] m_RoundSetups;

		// Token: 0x04001694 RID: 5780
		[Token(Token = "0x4001694")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("MapSetups")]
		private DLC5_RogueLikeDataProfile.MapSetup[] m_MapSetups;

		// Token: 0x04001695 RID: 5781
		[Token(Token = "0x4001695")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("CookerPriceSetups")]
		private DLC5_RogueLikeDataProfile.CookerPriceSetup[] m_CookerPriceSetups;

		// Token: 0x04001696 RID: 5782
		[Token(Token = "0x4001696")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("GachaTriggerData")]
		private TriggerCardData[] m_GachaTriggerData;

		// Token: 0x04001697 RID: 5783
		[Token(Token = "0x4001697")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty("GachaRewardPairData")]
		private RogueLikeCardRewardPair[] m_GachaRewardPairData;

		// Token: 0x04001698 RID: 5784
		[Token(Token = "0x4001698")]
		[FieldOffset(Offset = "0x58")]
		[JsonProperty("SpecialGuestVisitEverywhere")]
		public DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest[] m_SpecialGuestVisitEverywhere;
	}
}
