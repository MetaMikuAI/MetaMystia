using System;
using System.Collections.Generic;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000381 RID: 897
	[Token(Token = "0x2000381")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeDataProfile", menuName = "GameData Profile/Rogue Like Data Profile", order = 0)]
	public class DLC5_RogueLikeDataProfile : ScriptableObject, IRogueLikeCustomizedDataProfile
	{
		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FE")]
		public IReadOnlyList<Product> InitialProducts
		{
			[Token(Token = "0x60013E1")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FF")]
		public IReadOnlyList<int> InitialRecipePool
		{
			[Token(Token = "0x60013E2")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000200")]
		public IReadOnlyList<int> InitialBevPool
		{
			[Token(Token = "0x60013E3")]
			[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060013E4 RID: 5092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000201")]
		public IReadOnlyList<Vector2Int> BevLevelLinkToNum
		{
			[Token(Token = "0x60013E4")]
			[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060013E5 RID: 5093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000202")]
		public IReadOnlyList<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup> RoundSetups
		{
			[Token(Token = "0x60013E5")]
			[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013E6")]
		[Address(RVA = "0x440330", Offset = "0x43ED30", VA = "0x180440330")]
		public void SetRoundSetups(List<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup> newRoundSetup)
		{
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000203")]
		public IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup> MapSetups
		{
			[Token(Token = "0x60013E7")]
			[Address(RVA = "0x440290", Offset = "0x43EC90", VA = "0x180440290", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000204")]
		public IReadOnlyList<DLC5_RogueLikeDataProfile.CookerPriceSetup> CookerPriceSetups
		{
			[Token(Token = "0x60013E8")]
			[Address(RVA = "0x440320", Offset = "0x43ED20", VA = "0x180440320", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000205")]
		public IReadOnlyList<TriggerCardData> GachaTriggerData
		{
			[Token(Token = "0x60013E9")]
			[Address(RVA = "0x440500", Offset = "0x43EF00", VA = "0x180440500", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000206")]
		public IReadOnlyList<RogueLikeCardRewardPair> GachaRewardPairData
		{
			[Token(Token = "0x60013EA")]
			[Address(RVA = "0x426F70", Offset = "0x425970", VA = "0x180426F70", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x000076B0 File Offset: 0x000058B0
		[Token(Token = "0x17000207")]
		public int RoundDuration
		{
			[Token(Token = "0x60013EB")]
			[Address(RVA = "0x440570", Offset = "0x43EF70", VA = "0x180440570", Slot = "13")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x000076C8 File Offset: 0x000058C8
		[Token(Token = "0x17000208")]
		public float GlobalProductMultiplier
		{
			[Token(Token = "0x60013EC")]
			[Address(RVA = "0x440510", Offset = "0x43EF10", VA = "0x180440510", Slot = "14")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x000076E0 File Offset: 0x000058E0
		[Token(Token = "0x17000209")]
		public float Level1RecipePriceMultiplier
		{
			[Token(Token = "0x60013ED")]
			[Address(RVA = "0x440530", Offset = "0x43EF30", VA = "0x180440530", Slot = "15")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x000076F8 File Offset: 0x000058F8
		[Token(Token = "0x1700020A")]
		public float Level2RecipePriceMultiplier
		{
			[Token(Token = "0x60013EE")]
			[Address(RVA = "0x440540", Offset = "0x43EF40", VA = "0x180440540", Slot = "16")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060013EF RID: 5103 RVA: 0x00007710 File Offset: 0x00005910
		[Token(Token = "0x1700020B")]
		public float Level3RecipePriceMultiplier
		{
			[Token(Token = "0x60013EF")]
			[Address(RVA = "0x440310", Offset = "0x43ED10", VA = "0x180440310", Slot = "17")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060013F0 RID: 5104 RVA: 0x00007728 File Offset: 0x00005928
		[Token(Token = "0x1700020C")]
		public float Level4RecipePriceMultiplier
		{
			[Token(Token = "0x60013F0")]
			[Address(RVA = "0x4402D0", Offset = "0x43ECD0", VA = "0x1804402D0", Slot = "18")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x1700020D")]
		public float Level5RecipePriceMultiplier
		{
			[Token(Token = "0x60013F1")]
			[Address(RVA = "0x4402F0", Offset = "0x43ECF0", VA = "0x1804402F0", Slot = "19")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060013F2 RID: 5106 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x1700020E")]
		public int PartnerBasePrice
		{
			[Token(Token = "0x60013F2")]
			[Address(RVA = "0x440560", Offset = "0x43EF60", VA = "0x180440560", Slot = "20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x00007770 File Offset: 0x00005970
		[Token(Token = "0x1700020F")]
		public int SpecialGuestPrice
		{
			[Token(Token = "0x60013F3")]
			[Address(RVA = "0x440590", Offset = "0x43EF90", VA = "0x180440590", Slot = "21")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x00007788 File Offset: 0x00005988
		[Token(Token = "0x17000210")]
		public int EliteSpecialGuestPrice
		{
			[Token(Token = "0x60013F4")]
			[Address(RVA = "0x3EBD10", Offset = "0x3EA710", VA = "0x1803EBD10", Slot = "22")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x000077A0 File Offset: 0x000059A0
		[Token(Token = "0x17000211")]
		public int ClothesPrice
		{
			[Token(Token = "0x60013F5")]
			[Address(RVA = "0x3EBDA0", Offset = "0x3EA7A0", VA = "0x1803EBDA0", Slot = "23")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x000077B8 File Offset: 0x000059B8
		[Token(Token = "0x17000212")]
		public int DecorationPrice
		{
			[Token(Token = "0x60013F6")]
			[Address(RVA = "0x440490", Offset = "0x43EE90", VA = "0x180440490", Slot = "24")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x000077D0 File Offset: 0x000059D0
		[Token(Token = "0x17000213")]
		public int GachaNeedComboNum
		{
			[Token(Token = "0x60013F7")]
			[Address(RVA = "0x4404D0", Offset = "0x43EED0", VA = "0x1804404D0", Slot = "25")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060013F8 RID: 5112 RVA: 0x000077E8 File Offset: 0x000059E8
		[Token(Token = "0x17000214")]
		public int GachaNeedSpellNum
		{
			[Token(Token = "0x60013F8")]
			[Address(RVA = "0x4404E0", Offset = "0x43EEE0", VA = "0x1804404E0", Slot = "26")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x17000215")]
		public int GachaMaxCardNum
		{
			[Token(Token = "0x60013F9")]
			[Address(RVA = "0x4171F0", Offset = "0x415BF0", VA = "0x1804171F0", Slot = "27")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060013FA RID: 5114 RVA: 0x00007818 File Offset: 0x00005A18
		[Token(Token = "0x17000216")]
		public int BeginToSpawnDangerousCardRoundIndex
		{
			[Token(Token = "0x60013FA")]
			[Address(RVA = "0x440460", Offset = "0x43EE60", VA = "0x180440460", Slot = "28")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x00007830 File Offset: 0x00005A30
		[Token(Token = "0x17000217")]
		public int UnlockAllLevel2SpotRoundIndex
		{
			[Token(Token = "0x60013FB")]
			[Address(RVA = "0x4405B0", Offset = "0x43EFB0", VA = "0x1804405B0", Slot = "29")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060013FC RID: 5116 RVA: 0x00007848 File Offset: 0x00005A48
		[Token(Token = "0x17000218")]
		public int UnlockAllLevel3SpotRoundIndex
		{
			[Token(Token = "0x60013FC")]
			[Address(RVA = "0x4405C0", Offset = "0x43EFC0", VA = "0x1804405C0", Slot = "30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x00007860 File Offset: 0x00005A60
		[Token(Token = "0x17000219")]
		public float LuckyLeafExtraMultiplier
		{
			[Token(Token = "0x60013FD")]
			[Address(RVA = "0x440550", Offset = "0x43EF50", VA = "0x180440550", Slot = "31")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060013FE RID: 5118 RVA: 0x00007878 File Offset: 0x00005A78
		[Token(Token = "0x1700021A")]
		public int AyaNewsBeginRoundIndex
		{
			[Token(Token = "0x60013FE")]
			[Address(RVA = "0x409E40", Offset = "0x408840", VA = "0x180409E40", Slot = "32")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x00007890 File Offset: 0x00005A90
		[Token(Token = "0x1700021B")]
		public int PriceToRefreshAyaNews
		{
			[Token(Token = "0x60013FF")]
			[Address(RVA = "0x409E50", Offset = "0x408850", VA = "0x180409E50", Slot = "33")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06001400 RID: 5120 RVA: 0x000078A8 File Offset: 0x00005AA8
		[Token(Token = "0x1700021C")]
		public int AkyuuWashiPrice
		{
			[Token(Token = "0x6001400")]
			[Address(RVA = "0x440420", Offset = "0x43EE20", VA = "0x180440420", Slot = "34")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06001401 RID: 5121 RVA: 0x000078C0 File Offset: 0x00005AC0
		[Token(Token = "0x1700021D")]
		public int EllenCandyPrice
		{
			[Token(Token = "0x6001401")]
			[Address(RVA = "0x4404B0", Offset = "0x43EEB0", VA = "0x1804404B0", Slot = "35")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06001402 RID: 5122 RVA: 0x000078D8 File Offset: 0x00005AD8
		[Token(Token = "0x1700021E")]
		public float KourindouDiscount
		{
			[Token(Token = "0x6001402")]
			[Address(RVA = "0x440520", Offset = "0x43EF20", VA = "0x180440520", Slot = "36")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06001403 RID: 5123 RVA: 0x000078F0 File Offset: 0x00005AF0
		[Token(Token = "0x1700021F")]
		public float CookerCollectWeight
		{
			[Token(Token = "0x6001403")]
			[Address(RVA = "0x409CE0", Offset = "0x4086E0", VA = "0x180409CE0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06001404 RID: 5124 RVA: 0x00007908 File Offset: 0x00005B08
		[Token(Token = "0x17000220")]
		public float DecorationCollectWeight
		{
			[Token(Token = "0x6001404")]
			[Address(RVA = "0x440480", Offset = "0x43EE80", VA = "0x180440480")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06001405 RID: 5125 RVA: 0x00007920 File Offset: 0x00005B20
		[Token(Token = "0x17000221")]
		public float ClothesCollectWeight
		{
			[Token(Token = "0x6001405")]
			[Address(RVA = "0x440470", Offset = "0x43EE70", VA = "0x180440470")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06001406 RID: 5126 RVA: 0x00007938 File Offset: 0x00005B38
		[Token(Token = "0x17000222")]
		public float EachMapMaxCollectRate
		{
			[Token(Token = "0x6001406")]
			[Address(RVA = "0x4404A0", Offset = "0x43EEA0", VA = "0x1804404A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06001407 RID: 5127 RVA: 0x00007950 File Offset: 0x00005B50
		[Token(Token = "0x17000223")]
		public int GachaRecipeInitialNum
		{
			[Token(Token = "0x6001407")]
			[Address(RVA = "0x4404F0", Offset = "0x43EEF0", VA = "0x1804404F0", Slot = "37")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06001408 RID: 5128 RVA: 0x00007968 File Offset: 0x00005B68
		[Token(Token = "0x17000224")]
		public int GachaBevInitialNum
		{
			[Token(Token = "0x6001408")]
			[Address(RVA = "0x4404C0", Offset = "0x43EEC0", VA = "0x1804404C0", Slot = "38")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06001409 RID: 5129 RVA: 0x00007980 File Offset: 0x00005B80
		[Token(Token = "0x17000225")]
		public int SelectRecipeInitialNum
		{
			[Token(Token = "0x6001409")]
			[Address(RVA = "0x440580", Offset = "0x43EF80", VA = "0x180440580", Slot = "39")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x00007998 File Offset: 0x00005B98
		[Token(Token = "0x17000226")]
		public int BaseGachaNumWhenSettle
		{
			[Token(Token = "0x600140A")]
			[Address(RVA = "0x440430", Offset = "0x43EE30", VA = "0x180440430", Slot = "40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x000079B0 File Offset: 0x00005BB0
		[Token(Token = "0x17000227")]
		public int BaseMoveAction
		{
			[Token(Token = "0x600140B")]
			[Address(RVA = "0x440450", Offset = "0x43EE50", VA = "0x180440450", Slot = "41")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x000079C8 File Offset: 0x00005BC8
		[Token(Token = "0x17000228")]
		public int BaseIngredientNumWhenGetRecipe
		{
			[Token(Token = "0x600140C")]
			[Address(RVA = "0x440440", Offset = "0x43EE40", VA = "0x180440440", Slot = "42")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000229")]
		public IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest> SpecialGuestVisitEverywhere
		{
			[Token(Token = "0x600140D")]
			[Address(RVA = "0x4405A0", Offset = "0x43EFA0", VA = "0x1804405A0", Slot = "44")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x000079E0 File Offset: 0x00005BE0
		[Token(Token = "0x1700022A")]
		public int StartFund
		{
			[Token(Token = "0x600140E")]
			[Address(RVA = "0x429B20", Offset = "0x428520", VA = "0x180429B20", Slot = "43")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600140F")]
		[Address(RVA = "0x440390", Offset = "0x43ED90", VA = "0x180440390")]
		public DLC5_RogueLikeDataProfile()
		{
		}

		// Token: 0x04001226 RID: 4646
		[Token(Token = "0x4001226")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Product[] m_InitialProducts;

		// Token: 0x04001227 RID: 4647
		[Token(Token = "0x4001227")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int[] m_InitialRecipePool;

		// Token: 0x04001228 RID: 4648
		[Token(Token = "0x4001228")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int[] m_InitialBevPool;

		// Token: 0x04001229 RID: 4649
		[Token(Token = "0x4001229")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2Int[] m_BevLevelLinkToNum;

		// Token: 0x0400122A RID: 4650
		[Token(Token = "0x400122A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int m_RoundDuration;

		// Token: 0x0400122B RID: 4651
		[Token(Token = "0x400122B")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float m_GlobalProductMultiplier;

		// Token: 0x0400122C RID: 4652
		[Token(Token = "0x400122C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DLC5_RogueLikeDataProfile.RogueLikeRoundSetup[] m_RoundSetups;

		// Token: 0x0400122D RID: 4653
		[Token(Token = "0x400122D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private DLC5_RogueLikeDataProfile.MapSetup[] m_MapSetups;

		// Token: 0x0400122E RID: 4654
		[Token(Token = "0x400122E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_Level1RecipePriceMultiplier;

		// Token: 0x0400122F RID: 4655
		[Token(Token = "0x400122F")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_Level2RecipePriceMultiplier;

		// Token: 0x04001230 RID: 4656
		[Token(Token = "0x4001230")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_Level3RecipePriceMultiplier;

		// Token: 0x04001231 RID: 4657
		[Token(Token = "0x4001231")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_Level4RecipePriceMultiplier;

		// Token: 0x04001232 RID: 4658
		[Token(Token = "0x4001232")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_Level5RecipePriceMultiplier;

		// Token: 0x04001233 RID: 4659
		[Token(Token = "0x4001233")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int m_PartnerBasePrice;

		// Token: 0x04001234 RID: 4660
		[Token(Token = "0x4001234")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int m_SpecialGuestPrice;

		// Token: 0x04001235 RID: 4661
		[Token(Token = "0x4001235")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private int m_EliteSpecialGuestPrice;

		// Token: 0x04001236 RID: 4662
		[Token(Token = "0x4001236")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int m_ClothesPrice;

		// Token: 0x04001237 RID: 4663
		[Token(Token = "0x4001237")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private int m_DecorationPrice;

		// Token: 0x04001238 RID: 4664
		[Token(Token = "0x4001238")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private DLC5_RogueLikeDataProfile.CookerPriceSetup[] m_CookerPriceSetups;

		// Token: 0x04001239 RID: 4665
		[Token(Token = "0x4001239")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private int m_GachaNeedComboNum;

		// Token: 0x0400123A RID: 4666
		[Token(Token = "0x400123A")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private int m_GachaNeedSpellNum;

		// Token: 0x0400123B RID: 4667
		[Token(Token = "0x400123B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private int m_GachaMaxCardNum;

		// Token: 0x0400123C RID: 4668
		[Token(Token = "0x400123C")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private int m_BeginToSpawnDangerousCardRoundIndex;

		// Token: 0x0400123D RID: 4669
		[Token(Token = "0x400123D")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private int m_UnlockAllLevel2SpotRoundIndex;

		// Token: 0x0400123E RID: 4670
		[Token(Token = "0x400123E")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private int m_UnlockAllLevel3SpotRoundIndex;

		// Token: 0x0400123F RID: 4671
		[Token(Token = "0x400123F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TriggerCardData[] m_GachaTriggerData;

		// Token: 0x04001240 RID: 4672
		[Token(Token = "0x4001240")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RogueLikeCardRewardPair[] m_GachaRewardPairData;

		// Token: 0x04001241 RID: 4673
		[Token(Token = "0x4001241")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float m_LuckyLeafExtraMultiplier;

		// Token: 0x04001242 RID: 4674
		[Token(Token = "0x4001242")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private int m_AyaNewsBeginRoundIndex;

		// Token: 0x04001243 RID: 4675
		[Token(Token = "0x4001243")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private int m_PriceToRefreshAyaNews;

		// Token: 0x04001244 RID: 4676
		[Token(Token = "0x4001244")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private int m_AkyuuWashiPrice;

		// Token: 0x04001245 RID: 4677
		[Token(Token = "0x4001245")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private int m_EllenCandyPrice;

		// Token: 0x04001246 RID: 4678
		[Token(Token = "0x4001246")]
		[FieldOffset(Offset = "0xBC")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_KourindouDiscount;

		// Token: 0x04001247 RID: 4679
		[Token(Token = "0x4001247")]
		[FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_CookerCollectWeight;

		// Token: 0x04001248 RID: 4680
		[Token(Token = "0x4001248")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_DecorationCollectWeight;

		// Token: 0x04001249 RID: 4681
		[Token(Token = "0x4001249")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_ClothesCollectWeight;

		// Token: 0x0400124A RID: 4682
		[Token(Token = "0x400124A")]
		[FieldOffset(Offset = "0xCC")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_EachMapMaxCollectRate;

		// Token: 0x0400124B RID: 4683
		[Token(Token = "0x400124B")]
		[FieldOffset(Offset = "0xD0")]
		[Header("初始抽取食谱备选数")]
		[SerializeField]
		private int m_GachaRecipeInitialNum;

		// Token: 0x0400124C RID: 4684
		[Token(Token = "0x400124C")]
		[FieldOffset(Offset = "0xD4")]
		[Header("初始抽取酒水备选数")]
		[SerializeField]
		private int m_GachaBevInitialNum;

		// Token: 0x0400124D RID: 4685
		[Token(Token = "0x400124D")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Header("初始可选择食谱数")]
		private int m_SelectRecipeInitialNum;

		// Token: 0x0400124E RID: 4686
		[Token(Token = "0x400124E")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		[Header("初始指标抽卡数")]
		private int m_BaseGachaNumWhenSettle;

		// Token: 0x0400124F RID: 4687
		[Token(Token = "0x400124F")]
		[FieldOffset(Offset = "0xE0")]
		[Header("初始可移动距离")]
		[SerializeField]
		private int m_BaseMoveAction;

		// Token: 0x04001250 RID: 4688
		[Token(Token = "0x4001250")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[Header("食谱附赠素材数量")]
		private int m_BaseIngredientNumWhenGetRecipe;

		// Token: 0x04001251 RID: 4689
		[Token(Token = "0x4001251")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Header("设置-部分可全区域出没的稀客")]
		private DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest[] m_SpecialGuestVisitEverywhere;

		// Token: 0x04001252 RID: 4690
		[Token(Token = "0x4001252")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Header("初始金钱")]
		private int m_StartFund;

		// Token: 0x02000382 RID: 898
		[Token(Token = "0x2000382")]
		[JsonObject(MemberSerialization.OptIn)]
		[Serializable]
		public class RogueLikeRoundSetup
		{
			// Token: 0x06001410 RID: 5136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001410")]
			[Address(RVA = "0x450640", Offset = "0x44F040", VA = "0x180450640")]
			public RogueLikeRoundSetup(int incomeRequirement, float guestSpawnRateMultiplier, float guestFundMultiplier, int[] recipeAddToPoolAfterWave, int[] bevAddToPoolAfterWave)
			{
			}

			// Token: 0x1700022B RID: 555
			// (get) Token: 0x06001411 RID: 5137 RVA: 0x000079F8 File Offset: 0x00005BF8
			[Token(Token = "0x1700022B")]
			public int IncomeRequirement
			{
				[Token(Token = "0x6001411")]
				[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700022C RID: 556
			// (get) Token: 0x06001412 RID: 5138 RVA: 0x00007A10 File Offset: 0x00005C10
			[Token(Token = "0x1700022C")]
			public int IncomeRequirementN
			{
				[Token(Token = "0x6001412")]
				[Address(RVA = "0x403840", Offset = "0x402240", VA = "0x180403840")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700022D RID: 557
			// (get) Token: 0x06001413 RID: 5139 RVA: 0x00007A28 File Offset: 0x00005C28
			[Token(Token = "0x1700022D")]
			public int IncomeRequirementH
			{
				[Token(Token = "0x6001413")]
				[Address(RVA = "0x403830", Offset = "0x402230", VA = "0x180403830")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700022E RID: 558
			// (get) Token: 0x06001414 RID: 5140 RVA: 0x00007A40 File Offset: 0x00005C40
			[Token(Token = "0x1700022E")]
			public int IncomeRequirementL
			{
				[Token(Token = "0x6001414")]
				[Address(RVA = "0x4506E0", Offset = "0x44F0E0", VA = "0x1804506E0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700022F RID: 559
			// (get) Token: 0x06001415 RID: 5141 RVA: 0x00007A58 File Offset: 0x00005C58
			[Token(Token = "0x1700022F")]
			public float GuestSpawnRateMultiplier
			{
				[Token(Token = "0x6001415")]
				[Address(RVA = "0x4506D0", Offset = "0x44F0D0", VA = "0x1804506D0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000230 RID: 560
			// (get) Token: 0x06001416 RID: 5142 RVA: 0x00007A70 File Offset: 0x00005C70
			[Token(Token = "0x17000230")]
			public float GuestFundMultiplier
			{
				[Token(Token = "0x6001416")]
				[Address(RVA = "0x4506C0", Offset = "0x44F0C0", VA = "0x1804506C0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000231 RID: 561
			// (get) Token: 0x06001417 RID: 5143 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000231")]
			public int[] RecipeAddToPoolAfterWave
			{
				[Token(Token = "0x6001417")]
				[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000232 RID: 562
			// (get) Token: 0x06001418 RID: 5144 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000232")]
			public int[] BevAddToPoolAfterWave
			{
				[Token(Token = "0x6001418")]
				[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
				get
				{
					return null;
				}
			}

			// Token: 0x04001253 RID: 4691
			[Token(Token = "0x4001253")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty("IncomeRequirement")]
			[SerializeField]
			private int m_IncomeRequirement;

			// Token: 0x04001254 RID: 4692
			[Token(Token = "0x4001254")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			[JsonProperty("IncomeRequirementN")]
			private int m_IncomeRequirementN;

			// Token: 0x04001255 RID: 4693
			[Token(Token = "0x4001255")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[JsonProperty("IncomeRequirementH")]
			private int m_IncomeRequirementH;

			// Token: 0x04001256 RID: 4694
			[Token(Token = "0x4001256")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			[JsonProperty("IncomeRequirementL")]
			private int m_IncomeRequirementL;

			// Token: 0x04001257 RID: 4695
			[Token(Token = "0x4001257")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Range(2f, 0.001f)]
			[JsonProperty("GuestSpawnRateMultiplier")]
			private float m_GuestSpawnRateMultiplier;

			// Token: 0x04001258 RID: 4696
			[Token(Token = "0x4001258")]
			[FieldOffset(Offset = "0x24")]
			[SerializeField]
			[JsonProperty("GuestFundMultiplier")]
			[Range(10f, 0.001f)]
			private float m_GuestFundMultiplier;

			// Token: 0x04001259 RID: 4697
			[Token(Token = "0x4001259")]
			[FieldOffset(Offset = "0x28")]
			[JsonProperty("RecipeAddToPoolAfterWave")]
			[SerializeField]
			private int[] m_RecipeAddToPoolAfterWave;

			// Token: 0x0400125A RID: 4698
			[Token(Token = "0x400125A")]
			[FieldOffset(Offset = "0x30")]
			[JsonProperty("BevAddToPoolAfterWave")]
			[SerializeField]
			private int[] m_BevAddToPoolAfterWave;
		}

		// Token: 0x02000383 RID: 899
		[Token(Token = "0x2000383")]
		[JsonObject(MemberSerialization.OptIn)]
		[Serializable]
		public struct MapSetup
		{
			// Token: 0x17000233 RID: 563
			// (get) Token: 0x06001419 RID: 5145 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000233")]
			public string MapName
			{
				[Token(Token = "0x6001419")]
				[Address(RVA = "0x4070A0", Offset = "0x405AA0", VA = "0x1804070A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000234 RID: 564
			// (get) Token: 0x0600141A RID: 5146 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000234")]
			public IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange> Ingredients
			{
				[Token(Token = "0x600141A")]
				[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000235 RID: 565
			// (get) Token: 0x0600141B RID: 5147 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000235")]
			public IReadOnlyList<int> PartnerId
			{
				[Token(Token = "0x600141B")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000236 RID: 566
			// (get) Token: 0x0600141C RID: 5148 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000236")]
			public IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest> SpawnedSpecialGuestId
			{
				[Token(Token = "0x600141C")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000237 RID: 567
			// (get) Token: 0x0600141D RID: 5149 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000237")]
			public IReadOnlyList<int> SpecialGuestId
			{
				[Token(Token = "0x600141D")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000238 RID: 568
			// (get) Token: 0x0600141E RID: 5150 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000238")]
			public IReadOnlyList<int> ClothesId
			{
				[Token(Token = "0x600141E")]
				[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000239 RID: 569
			// (get) Token: 0x0600141F RID: 5151 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000239")]
			public IReadOnlyList<int> DecorationId
			{
				[Token(Token = "0x600141F")]
				[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700023A RID: 570
			// (get) Token: 0x06001420 RID: 5152 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700023A")]
			public IReadOnlyList<int> CookerId
			{
				[Token(Token = "0x6001420")]
				[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700023B RID: 571
			// (get) Token: 0x06001421 RID: 5153 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700023B")]
			public IReadOnlyList<int> RecipeId
			{
				[Token(Token = "0x6001421")]
				[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700023C RID: 572
			// (get) Token: 0x06001422 RID: 5154 RVA: 0x00007A88 File Offset: 0x00005C88
			[Token(Token = "0x1700023C")]
			public Vector2 MerchantIngredientDiscount
			{
				[Token(Token = "0x6001422")]
				[Address(RVA = "0x44F240", Offset = "0x44DC40", VA = "0x18044F240")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x0400125B RID: 4699
			[Token(Token = "0x400125B")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			[JsonProperty("MapName")]
			private string m_MapName;

			// Token: 0x0400125C RID: 4700
			[Token(Token = "0x400125C")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			[JsonProperty("Ingredients")]
			private DLC5_RogueLikeDataProfile.MapSetup.IngredientRange[] m_Ingredients;

			// Token: 0x0400125D RID: 4701
			[Token(Token = "0x400125D")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[JsonProperty("PartnerId")]
			private int[] m_PartnerId;

			// Token: 0x0400125E RID: 4702
			[Token(Token = "0x400125E")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[JsonProperty("SpawnedSpecialGuestId")]
			private DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest[] m_SpawnedSpecialGuestId;

			// Token: 0x0400125F RID: 4703
			[Token(Token = "0x400125F")]
			[FieldOffset(Offset = "0x20")]
			[JsonProperty("SpecialGuestId")]
			[SerializeField]
			private int[] m_SpecialGuestId;

			// Token: 0x04001260 RID: 4704
			[Token(Token = "0x4001260")]
			[FieldOffset(Offset = "0x28")]
			[JsonProperty("ClothesId")]
			[SerializeField]
			private int[] m_ClothesId;

			// Token: 0x04001261 RID: 4705
			[Token(Token = "0x4001261")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			[JsonProperty("DecorationId")]
			private int[] m_DecorationId;

			// Token: 0x04001262 RID: 4706
			[Token(Token = "0x4001262")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			[JsonProperty("CookerId")]
			private int[] m_CookerId;

			// Token: 0x04001263 RID: 4707
			[Token(Token = "0x4001263")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			[JsonProperty("RecipeId")]
			private int[] m_RecipeId;

			// Token: 0x04001264 RID: 4708
			[Token(Token = "0x4001264")]
			[FieldOffset(Offset = "0x48")]
			[JsonProperty("MerchantIngredientDiscount")]
			[SerializeField]
			private Vector2 m_MerchantIngredientDiscount;

			// Token: 0x02000384 RID: 900
			[Token(Token = "0x2000384")]
			[JsonObject(MemberSerialization.OptIn)]
			[Serializable]
			public struct IngredientRange
			{
				// Token: 0x1700023D RID: 573
				// (get) Token: 0x06001423 RID: 5155 RVA: 0x00007AA0 File Offset: 0x00005CA0
				[Token(Token = "0x1700023D")]
				public int IngredientId
				{
					[Token(Token = "0x6001423")]
					[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
					get
					{
						return 0;
					}
				}

				// Token: 0x1700023E RID: 574
				// (get) Token: 0x06001424 RID: 5156 RVA: 0x00007AB8 File Offset: 0x00005CB8
				[Token(Token = "0x1700023E")]
				public Vector2Int Range
				{
					[Token(Token = "0x6001424")]
					[Address(RVA = "0x44F230", Offset = "0x44DC30", VA = "0x18044F230")]
					get
					{
						return default(Vector2Int);
					}
				}

				// Token: 0x1700023F RID: 575
				// (get) Token: 0x06001425 RID: 5157 RVA: 0x00007AD0 File Offset: 0x00005CD0
				[Token(Token = "0x1700023F")]
				public bool IsBeverage
				{
					[Token(Token = "0x6001425")]
					[Address(RVA = "0x44F220", Offset = "0x44DC20", VA = "0x18044F220")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x04001265 RID: 4709
				[Token(Token = "0x4001265")]
				[FieldOffset(Offset = "0x0")]
				[SerializeField]
				[JsonProperty("IngredientId")]
				private int m_IngredientId;

				// Token: 0x04001266 RID: 4710
				[Token(Token = "0x4001266")]
				[FieldOffset(Offset = "0x4")]
				[SerializeField]
				[JsonProperty("Range")]
				private Vector2Int m_Range;

				// Token: 0x04001267 RID: 4711
				[Token(Token = "0x4001267")]
				[FieldOffset(Offset = "0xC")]
				[SerializeField]
				[JsonProperty("IsBeverage")]
				private bool m_IsBeverage;
			}

			// Token: 0x02000385 RID: 901
			[Token(Token = "0x2000385")]
			[JsonObject(MemberSerialization.OptIn)]
			[Serializable]
			public struct ConditionalSpecialGuest
			{
				// Token: 0x17000240 RID: 576
				// (get) Token: 0x06001426 RID: 5158 RVA: 0x00007AE8 File Offset: 0x00005CE8
				[Token(Token = "0x17000240")]
				public int SpecialGuestId
				{
					[Token(Token = "0x6001426")]
					[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
					get
					{
						return 0;
					}
				}

				// Token: 0x17000241 RID: 577
				// (get) Token: 0x06001427 RID: 5159 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000241")]
				public IReadOnlyList<string> DependentAreaName
				{
					[Token(Token = "0x6001427")]
					[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000242 RID: 578
				// (get) Token: 0x06001428 RID: 5160 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000242")]
				public IReadOnlyList<string> ShowAreaName
				{
					[Token(Token = "0x6001428")]
					[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
					get
					{
						return null;
					}
				}

				// Token: 0x17000243 RID: 579
				// (get) Token: 0x06001429 RID: 5161 RVA: 0x00007B00 File Offset: 0x00005D00
				[Token(Token = "0x17000243")]
				public bool ShowOnlyAfterPlayerUnlock
				{
					[Token(Token = "0x6001429")]
					[Address(RVA = "0x438D10", Offset = "0x437710", VA = "0x180438D10")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17000244 RID: 580
				// (get) Token: 0x0600142A RID: 5162 RVA: 0x00007B18 File Offset: 0x00005D18
				[Token(Token = "0x17000244")]
				public float ShowWeight
				{
					[Token(Token = "0x600142A")]
					[Address(RVA = "0x43B0A0", Offset = "0x439AA0", VA = "0x18043B0A0")]
					get
					{
						return 0f;
					}
				}

				// Token: 0x04001268 RID: 4712
				[Token(Token = "0x4001268")]
				[FieldOffset(Offset = "0x0")]
				[SerializeField]
				private int m_SpecialGuestId;

				// Token: 0x04001269 RID: 4713
				[Token(Token = "0x4001269")]
				[FieldOffset(Offset = "0x8")]
				[SerializeField]
				private string[] m_DependentAreaName;

				// Token: 0x0400126A RID: 4714
				[Token(Token = "0x400126A")]
				[FieldOffset(Offset = "0x10")]
				[SerializeField]
				private string[] m_ShowAreaName;

				// Token: 0x0400126B RID: 4715
				[Token(Token = "0x400126B")]
				[FieldOffset(Offset = "0x18")]
				[SerializeField]
				private bool m_ShowOnlyAfterPlayerUnlock;

				// Token: 0x0400126C RID: 4716
				[Token(Token = "0x400126C")]
				[FieldOffset(Offset = "0x1C")]
				[SerializeField]
				private float m_ShowWeight;
			}
		}

		// Token: 0x02000386 RID: 902
		[Token(Token = "0x2000386")]
		[JsonObject(MemberSerialization.OptIn)]
		[Serializable]
		public struct CookerPriceSetup
		{
			// Token: 0x17000245 RID: 581
			// (get) Token: 0x0600142B RID: 5163 RVA: 0x00007B30 File Offset: 0x00005D30
			[Token(Token = "0x17000245")]
			public int Price
			{
				[Token(Token = "0x600142B")]
				[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000246 RID: 582
			// (get) Token: 0x0600142C RID: 5164 RVA: 0x00007B48 File Offset: 0x00005D48
			[Token(Token = "0x17000246")]
			public Cooker.CookerSeries CookerSeries
			{
				[Token(Token = "0x600142C")]
				[Address(RVA = "0x43B0B0", Offset = "0x439AB0", VA = "0x18043B0B0")]
				get
				{
					return Cooker.CookerSeries.Base;
				}
			}

			// Token: 0x0400126D RID: 4717
			[Token(Token = "0x400126D")]
			[FieldOffset(Offset = "0x0")]
			[JsonProperty("Price")]
			[SerializeField]
			private int m_Price;

			// Token: 0x0400126E RID: 4718
			[Token(Token = "0x400126E")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			[JsonProperty("CookerSeries")]
			private Cooker.CookerSeries m_CookerSeries;
		}

		// Token: 0x02000387 RID: 903
		[Token(Token = "0x2000387")]
		[Serializable]
		public struct RogueLikeAchievement
		{
			// Token: 0x0400126F RID: 4719
			[Token(Token = "0x400126F")]
			[FieldOffset(Offset = "0x0")]
			public DLC5_RogueLikeDataProfile.RogueLikeAchievementType m_RogueLikeAchievementType;

			// Token: 0x04001270 RID: 4720
			[Token(Token = "0x4001270")]
			[FieldOffset(Offset = "0x4")]
			public DLC5_RogueLikeDataProfile.RogueLikeAchievementTriggerType m_RogueLikeAchievementTriggerType;

			// Token: 0x04001271 RID: 4721
			[Token(Token = "0x4001271")]
			[FieldOffset(Offset = "0x8")]
			public int m_BadgeId;

			// Token: 0x04001272 RID: 4722
			[Token(Token = "0x4001272")]
			[FieldOffset(Offset = "0xC")]
			public int m_TargetIntValue;

			// Token: 0x04001273 RID: 4723
			[Token(Token = "0x4001273")]
			[FieldOffset(Offset = "0x10")]
			public int[] m_TargetIntArrayValue;

			// Token: 0x04001274 RID: 4724
			[Token(Token = "0x4001274")]
			[FieldOffset(Offset = "0x18")]
			public float m_TargetFloatValue;

			// Token: 0x04001275 RID: 4725
			[Token(Token = "0x4001275")]
			[FieldOffset(Offset = "0x20")]
			public DLC5_RogueLikeDataProfile.CardRequired[] m_CardRequired;
		}

		// Token: 0x02000388 RID: 904
		[Token(Token = "0x2000388")]
		[Serializable]
		public struct CardRequired
		{
			// Token: 0x04001276 RID: 4726
			[Token(Token = "0x4001276")]
			[FieldOffset(Offset = "0x0")]
			public RogueLikeCardBase.CardType CardType;

			// Token: 0x04001277 RID: 4727
			[Token(Token = "0x4001277")]
			[FieldOffset(Offset = "0x4")]
			public int needNum;
		}

		// Token: 0x02000389 RID: 905
		[Token(Token = "0x2000389")]
		public enum RogueLikeAchievementType
		{
			// Token: 0x04001279 RID: 4729
			[Token(Token = "0x4001279")]
			万物皆可肉鸽,
			// Token: 0x0400127A RID: 4730
			[Token(Token = "0x400127A")]
			肉鸽的灵魂在于选择,
			// Token: 0x0400127B RID: 4731
			[Token(Token = "0x400127B")]
			你所不知道的卡牌黑市,
			// Token: 0x0400127C RID: 4732
			[Token(Token = "0x400127C")]
			强欲之夜雀,
			// Token: 0x0400127D RID: 4733
			[Token(Token = "0x400127D")]
			鱼肉菜蛋营养管饱,
			// Token: 0x0400127E RID: 4734
			[Token(Token = "0x400127E")]
			完美的黄金回旋,
			// Token: 0x0400127F RID: 4735
			[Token(Token = "0x400127F")]
			大吉猫咪的聚宝功,
			// Token: 0x04001280 RID: 4736
			[Token(Token = "0x4001280")]
			Buff栏要塞不下了,
			// Token: 0x04001281 RID: 4737
			[Token(Token = "0x4001281")]
			宝货盈门金卡满堂,
			// Token: 0x04001282 RID: 4738
			[Token(Token = "0x4001282")]
			鸟脑袋的地狱试炼官,
			// Token: 0x04001283 RID: 4739
			[Token(Token = "0x4001283")]
			一个筋斗这头到那头,
			// Token: 0x04001284 RID: 4740
			[Token(Token = "0x4001284")]
			一元购,
			// Token: 0x04001285 RID: 4741
			[Token(Token = "0x4001285")]
			粮粮粮粮粮草征收人,
			// Token: 0x04001286 RID: 4742
			[Token(Token = "0x4001286")]
			风风火火闯九州,
			// Token: 0x04001287 RID: 4743
			[Token(Token = "0x4001287")]
			轮回终末,
			// Token: 0x04001288 RID: 4744
			[Token(Token = "0x4001288")]
			擦弹与决死,
			// Token: 0x04001289 RID: 4745
			[Token(Token = "0x4001289")]
			记忆开始收束,
			// Token: 0x0400128A RID: 4746
			[Token(Token = "0x400128A")]
			营业额冲刺学徒,
			// Token: 0x0400128B RID: 4747
			[Token(Token = "0x400128B")]
			营业额冲刺大师,
			// Token: 0x0400128C RID: 4748
			[Token(Token = "0x400128C")]
			营业额冲刺MAAAAX,
			// Token: 0x0400128D RID: 4749
			[Token(Token = "0x400128D")]
			香霖堂至尊VIP客户,
			// Token: 0x0400128E RID: 4750
			[Token(Token = "0x400128E")]
			收集狂,
			// Token: 0x0400128F RID: 4751
			[Token(Token = "0x400128F")]
			胜利的法则已然确定,
			// Token: 0x04001290 RID: 4752
			[Token(Token = "0x4001290")]
			Roguelike模式制霸的证明,
			// Token: 0x04001291 RID: 4753
			[Token(Token = "0x4001291")]
			实石求石,
			// Token: 0x04001292 RID: 4754
			[Token(Token = "0x4001292")]
			代理巫女,
			// Token: 0x04001293 RID: 4755
			[Token(Token = "0x4001293")]
			恶属性效果绝佳,
			// Token: 0x04001294 RID: 4756
			[Token(Token = "0x4001294")]
			结束了
		}

		// Token: 0x0200038A RID: 906
		[Token(Token = "0x200038A")]
		public enum RogueLikeAchievementTriggerType
		{
			// Token: 0x04001296 RID: 4758
			[Token(Token = "0x4001296")]
			[InspectorName("进入肉鸽")]
			FirstOpen,
			// Token: 0x04001297 RID: 4759
			[Token(Token = "0x4001297")]
			[InspectorName("获得指定数量营业卡牌")]
			GetCard,
			// Token: 0x04001298 RID: 4760
			[Token(Token = "0x4001298")]
			[InspectorName("一次营业内获得指定数量营业卡牌")]
			GetCardOneNight,
			// Token: 0x04001299 RID: 4761
			[Token(Token = "0x4001299")]
			[InspectorName("获得指定数量全局卡牌")]
			GetPersistentCard,
			// Token: 0x0400129A RID: 4762
			[Token(Token = "0x400129A")]
			[InspectorName("获得指定营业卡牌")]
			GetCard_CollectTarget,
			// Token: 0x0400129B RID: 4763
			[Token(Token = "0x400129B")]
			[InspectorName("怒押必中专用")]
			GetCard_InstantHit,
			// Token: 0x0400129C RID: 4764
			[Token(Token = "0x400129C")]
			[InspectorName("鬼渡试炼专用")]
			GetPersistentCard_HellTrail,
			// Token: 0x0400129D RID: 4765
			[Token(Token = "0x400129D")]
			[InspectorName("香霖堂折扣专用")]
			GetPersistentCard_KourindouDiscount,
			// Token: 0x0400129E RID: 4766
			[Token(Token = "0x400129E")]
			[InspectorName("买空食材专用")]
			GetPersistentCard_BuyAllIngredients,
			// Token: 0x0400129F RID: 4767
			[Token(Token = "0x400129F")]
			[InspectorName("开店专用")]
			GetPersistentCard_CollectIzakaya,
			// Token: 0x040012A0 RID: 4768
			[Token(Token = "0x40012A0")]
			[InspectorName("擦弹专用")]
			LimitPass,
			// Token: 0x040012A1 RID: 4769
			[Token(Token = "0x40012A1")]
			[InspectorName("获得指定全局卡牌")]
			GetPersistentCard_CollectTarget,
			// Token: 0x040012A2 RID: 4770
			[Token(Token = "0x40012A2")]
			[InspectorName("获得指定数量菜谱")]
			CollectRecipe,
			// Token: 0x040012A3 RID: 4771
			[Token(Token = "0x40012A3")]
			[InspectorName("最高营业额")]
			CollectMoney,
			// Token: 0x040012A4 RID: 4772
			[Token(Token = "0x40012A4")]
			[InspectorName("香霖堂消费")]
			CostInKourindou,
			// Token: 0x040012A5 RID: 4773
			[Token(Token = "0x40012A5")]
			[InspectorName("收集率")]
			CollectRate,
			// Token: 0x040012A6 RID: 4774
			[Token(Token = "0x40012A6")]
			[InspectorName("通关")]
			FinishRogueLike,
			// Token: 0x040012A7 RID: 4775
			[Token(Token = "0x40012A7")]
			[InspectorName("全成就")]
			AllAchievement,
			// Token: 0x040012A8 RID: 4776
			[Token(Token = "0x40012A8")]
			[InspectorName("完成时空乱流")]
			FinishElite,
			// Token: 0x040012A9 RID: 4777
			[Token(Token = "0x40012A9")]
			[InspectorName("击败幽幽子幻象-正常")]
			FinishYuyukoElite_Feed,
			// Token: 0x040012AA RID: 4778
			[Token(Token = "0x40012AA")]
			[InspectorName("击败幽幽子幻象-厄厄")]
			FinishYuyukoElite_Repell
		}
	}
}
