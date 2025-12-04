using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using DEYU.Singletons;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace GameData.RunTime.Common
{
	// Token: 0x02000820 RID: 2080
	[Token(Token = "0x2000820")]
	[GenerateCleanupMethod]
	public class StatusTracker : Singleton<StatusTracker>
	{
		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06003122 RID: 12578 RVA: 0x00011F10 File Offset: 0x00010110
		// (set) Token: 0x06003123 RID: 12579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000659")]
		public int MissionIncome
		{
			[Token(Token = "0x6003122")]
			[Address(RVA = "0x4171F0", Offset = "0x415BF0", VA = "0x1804171F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003123")]
			[Address(RVA = "0x417210", Offset = "0x415C10", VA = "0x180417210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06003124 RID: 12580 RVA: 0x00011F28 File Offset: 0x00010128
		// (set) Token: 0x06003125 RID: 12581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065A")]
		public int BussinessIncome
		{
			[Token(Token = "0x6003124")]
			[Address(RVA = "0x440460", Offset = "0x43EE60", VA = "0x180440460")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003125")]
			[Address(RVA = "0x655DE0", Offset = "0x6547E0", VA = "0x180655DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06003126 RID: 12582 RVA: 0x00011F40 File Offset: 0x00010140
		// (set) Token: 0x06003127 RID: 12583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065B")]
		public int Fee
		{
			[Token(Token = "0x6003126")]
			[Address(RVA = "0x4405B0", Offset = "0x43EFB0", VA = "0x1804405B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003127")]
			[Address(RVA = "0x656A30", Offset = "0x655430", VA = "0x180656A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06003128 RID: 12584 RVA: 0x00011F58 File Offset: 0x00010158
		[Token(Token = "0x1700065C")]
		public int NetProfit
		{
			[Token(Token = "0x6003128")]
			[Address(RVA = "0x656A00", Offset = "0x655400", VA = "0x180656A00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06003129 RID: 12585 RVA: 0x00011F70 File Offset: 0x00010170
		// (set) Token: 0x0600312A RID: 12586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065D")]
		public int MissionExpense
		{
			[Token(Token = "0x6003129")]
			[Address(RVA = "0x4405C0", Offset = "0x43EFC0", VA = "0x1804405C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600312A")]
			[Address(RVA = "0x656A70", Offset = "0x655470", VA = "0x180656A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x0600312B RID: 12587 RVA: 0x00011F88 File Offset: 0x00010188
		// (set) Token: 0x0600312C RID: 12588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065E")]
		public int ShoppingExpense
		{
			[Token(Token = "0x600312B")]
			[Address(RVA = "0x477F00", Offset = "0x476900", VA = "0x180477F00")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600312C")]
			[Address(RVA = "0x4D2350", Offset = "0x4D0D50", VA = "0x1804D2350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x0600312D RID: 12589 RVA: 0x00011FA0 File Offset: 0x000101A0
		// (set) Token: 0x0600312E RID: 12590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065F")]
		public int DebtExpense
		{
			[Token(Token = "0x600312D")]
			[Address(RVA = "0x477EF0", Offset = "0x4768F0", VA = "0x180477EF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600312E")]
			[Address(RVA = "0x4D2360", Offset = "0x4D0D60", VA = "0x1804D2360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x0600312F RID: 12591 RVA: 0x00011FB8 File Offset: 0x000101B8
		// (set) Token: 0x06003130 RID: 12592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000660")]
		public int PartnerExpense
		{
			[Token(Token = "0x600312F")]
			[Address(RVA = "0x477F90", Offset = "0x476990", VA = "0x180477F90")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003130")]
			[Address(RVA = "0x4D2480", Offset = "0x4D0E80", VA = "0x1804D2480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06003131 RID: 12593 RVA: 0x00011FD0 File Offset: 0x000101D0
		// (set) Token: 0x06003132 RID: 12594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000661")]
		public int PerformanceCount
		{
			[Token(Token = "0x6003131")]
			[Address(RVA = "0x477FA0", Offset = "0x4769A0", VA = "0x180477FA0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003132")]
			[Address(RVA = "0x48AAC0", Offset = "0x4894C0", VA = "0x18048AAC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06003133 RID: 12595 RVA: 0x00011FE8 File Offset: 0x000101E8
		// (set) Token: 0x06003134 RID: 12596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000662")]
		public int PerformanceSucceededCount
		{
			[Token(Token = "0x6003133")]
			[Address(RVA = "0x48B8E0", Offset = "0x48A2E0", VA = "0x18048B8E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003134")]
			[Address(RVA = "0x656A90", Offset = "0x655490", VA = "0x180656A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06003135 RID: 12597 RVA: 0x00012000 File Offset: 0x00010200
		// (set) Token: 0x06003136 RID: 12598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000663")]
		public int PerformanceFullComboCount
		{
			[Token(Token = "0x6003135")]
			[Address(RVA = "0x409E40", Offset = "0x408840", VA = "0x180409E40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003136")]
			[Address(RVA = "0x409E70", Offset = "0x408870", VA = "0x180409E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06003137 RID: 12599 RVA: 0x00012018 File Offset: 0x00010218
		// (set) Token: 0x06003138 RID: 12600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000664")]
		public int SuccessRiceBallCount
		{
			[Token(Token = "0x6003137")]
			[Address(RVA = "0x409E50", Offset = "0x408850", VA = "0x180409E50")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003138")]
			[Address(RVA = "0x409E80", Offset = "0x408880", VA = "0x180409E80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06003139 RID: 12601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000665")]
		public IEnumerable<int> BussinessFoodConsumesValue
		{
			[Token(Token = "0x6003139")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x0600313A RID: 12602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000666")]
		public IEnumerable<int> BussinessBeverageConsumesValue
		{
			[Token(Token = "0x600313A")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x0600313B RID: 12603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000667")]
		public IEnumerable<int> BussinessIngredientsConsumesValue
		{
			[Token(Token = "0x600313B")]
			[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x0600313C RID: 12604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000668")]
		public IEnumerable<Sprite> BussinessFoodConsumes
		{
			[Token(Token = "0x600313C")]
			[Address(RVA = "0x656450", Offset = "0x654E50", VA = "0x180656450")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x0600313D RID: 12605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000669")]
		public IEnumerable<Sprite> BussinessBeverageConsumes
		{
			[Token(Token = "0x600313D")]
			[Address(RVA = "0x656330", Offset = "0x654D30", VA = "0x180656330")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x0600313E RID: 12606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700066A")]
		public IEnumerable<int> MissionIngredientsConsumesValue
		{
			[Token(Token = "0x600313E")]
			[Address(RVA = "0x48A940", Offset = "0x489340", VA = "0x18048A940")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x0600313F RID: 12607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700066B")]
		public IEnumerable<int> MissionFoodConsumesValue
		{
			[Token(Token = "0x600313F")]
			[Address(RVA = "0x440300", Offset = "0x43ED00", VA = "0x180440300")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06003140 RID: 12608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700066C")]
		public IEnumerable<int> MissionBeverageConsumesValue
		{
			[Token(Token = "0x6003140")]
			[Address(RVA = "0x48B8D0", Offset = "0x48A2D0", VA = "0x18048B8D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06003141 RID: 12609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700066D")]
		public IEnumerable<Sprite> MissionIngredientConsumes
		{
			[Token(Token = "0x6003141")]
			[Address(RVA = "0x6568E0", Offset = "0x6552E0", VA = "0x1806568E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06003142 RID: 12610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700066E")]
		public IEnumerable<Sprite> MissionFoodConsumes
		{
			[Token(Token = "0x6003142")]
			[Address(RVA = "0x6567C0", Offset = "0x6551C0", VA = "0x1806567C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06003143 RID: 12611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700066F")]
		public IEnumerable<Sprite> MissionBeverageConsumes
		{
			[Token(Token = "0x6003143")]
			[Address(RVA = "0x6566A0", Offset = "0x6550A0", VA = "0x1806566A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06003144 RID: 12612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000670")]
		public IEnumerable<int> InvalidFoodsValue
		{
			[Token(Token = "0x6003144")]
			[Address(RVA = "0x477F80", Offset = "0x476980", VA = "0x180477F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06003145 RID: 12613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000671")]
		public IEnumerable<Sprite> InvalidFoods
		{
			[Token(Token = "0x6003145")]
			[Address(RVA = "0x656570", Offset = "0x654F70", VA = "0x180656570")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06003146 RID: 12614 RVA: 0x00012030 File Offset: 0x00010230
		// (set) Token: 0x06003147 RID: 12615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000672")]
		public int GainExperience
		{
			[Token(Token = "0x6003146")]
			[Address(RVA = "0x440420", Offset = "0x43EE20", VA = "0x180440420")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003147")]
			[Address(RVA = "0x656A40", Offset = "0x655440", VA = "0x180656A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06003148 RID: 12616 RVA: 0x00012048 File Offset: 0x00010248
		// (set) Token: 0x06003149 RID: 12617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000673")]
		public int MaxCombo
		{
			[Token(Token = "0x6003148")]
			[Address(RVA = "0x4404B0", Offset = "0x43EEB0", VA = "0x1804404B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003149")]
			[Address(RVA = "0x656A50", Offset = "0x655450", VA = "0x180656A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x0600314A RID: 12618 RVA: 0x00012060 File Offset: 0x00010260
		// (set) Token: 0x0600314B RID: 12619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000674")]
		public int MaxPassion
		{
			[Token(Token = "0x600314A")]
			[Address(RVA = "0x656690", Offset = "0x655090", VA = "0x180656690")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600314B")]
			[Address(RVA = "0x656A60", Offset = "0x655460", VA = "0x180656A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x0600314C RID: 12620 RVA: 0x00012078 File Offset: 0x00010278
		// (set) Token: 0x0600314D RID: 12621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000675")]
		public int Visitors
		{
			[Token(Token = "0x600314C")]
			[Address(RVA = "0x43AEF0", Offset = "0x4398F0", VA = "0x18043AEF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600314D")]
			[Address(RVA = "0x448380", Offset = "0x446D80", VA = "0x180448380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x0600314E RID: 12622 RVA: 0x00012090 File Offset: 0x00010290
		// (set) Token: 0x0600314F RID: 12623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000676")]
		public int NormalGuestReception
		{
			[Token(Token = "0x600314E")]
			[Address(RVA = "0x409CD0", Offset = "0x4086D0", VA = "0x180409CD0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600314F")]
			[Address(RVA = "0x409D10", Offset = "0x408710", VA = "0x180409D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06003150 RID: 12624 RVA: 0x000120A8 File Offset: 0x000102A8
		// (set) Token: 0x06003151 RID: 12625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000677")]
		public int SpecialGuestReception
		{
			[Token(Token = "0x6003150")]
			[Address(RVA = "0x409CF0", Offset = "0x4086F0", VA = "0x180409CF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003151")]
			[Address(RVA = "0x409D30", Offset = "0x408730", VA = "0x180409D30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06003152 RID: 12626 RVA: 0x000120C0 File Offset: 0x000102C0
		// (set) Token: 0x06003153 RID: 12627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000678")]
		public int PositiveSkillTriggered
		{
			[Token(Token = "0x6003152")]
			[Address(RVA = "0x409D00", Offset = "0x408700", VA = "0x180409D00")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003153")]
			[Address(RVA = "0x409D40", Offset = "0x408740", VA = "0x180409D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06003154 RID: 12628 RVA: 0x000120D8 File Offset: 0x000102D8
		// (set) Token: 0x06003155 RID: 12629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000679")]
		public int NegativeSkillTriggered
		{
			[Token(Token = "0x6003154")]
			[Address(RVA = "0x4404F0", Offset = "0x43EEF0", VA = "0x1804404F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003155")]
			[Address(RVA = "0x656A80", Offset = "0x655480", VA = "0x180656A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06003156 RID: 12630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700067A")]
		public List<int> InvitedGuests
		{
			[Token(Token = "0x6003156")]
			[Address(RVA = "0x48A4C0", Offset = "0x488EC0", VA = "0x18048A4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06003157 RID: 12631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700067B")]
		public List<int> IgnoredGuests
		{
			[Token(Token = "0x6003157")]
			[Address(RVA = "0x449340", Offset = "0x447D40", VA = "0x180449340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06003158 RID: 12632 RVA: 0x000120F0 File Offset: 0x000102F0
		// (set) Token: 0x06003159 RID: 12633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067C")]
		public bool CleanWorkSessionTracking
		{
			[Token(Token = "0x6003158")]
			[Address(RVA = "0x418FE0", Offset = "0x4179E0", VA = "0x180418FE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003159")]
			[Address(RVA = "0x419010", Offset = "0x417A10", VA = "0x180419010")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600315A")]
		[Address(RVA = "0x655E50", Offset = "0x654850", VA = "0x180655E50")]
		public void UpdateMissionIncome(int addAmount)
		{
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600315B")]
		[Address(RVA = "0x655DE0", Offset = "0x6547E0", VA = "0x180655DE0")]
		public void SetBussinessIncome(int currentAmount)
		{
		}

		// Token: 0x0600315C RID: 12636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600315C")]
		[Address(RVA = "0x4D2480", Offset = "0x4D0E80", VA = "0x1804D2480")]
		public void SetPartnerExpense(int currentAmount)
		{
		}

		// Token: 0x0600315D RID: 12637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600315D")]
		[Address(RVA = "0x654670", Offset = "0x653070", VA = "0x180654670")]
		public void AddFee(int currentAmount)
		{
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600315E")]
		[Address(RVA = "0x655E40", Offset = "0x654840", VA = "0x180655E40")]
		public void UpdateMissionExpense(int addAmount)
		{
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600315F")]
		[Address(RVA = "0x655E80", Offset = "0x654880", VA = "0x180655E80")]
		public void UpdateShoppingExpense(int addAmount)
		{
		}

		// Token: 0x06003160 RID: 12640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003160")]
		[Address(RVA = "0x4D2360", Offset = "0x4D0D60", VA = "0x1804D2360")]
		public void UpdateDebtExpense(int amount)
		{
		}

		// Token: 0x06003161 RID: 12641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003161")]
		[Address(RVA = "0x654A20", Offset = "0x653420", VA = "0x180654A20")]
		public void AddPerformanceCount()
		{
		}

		// Token: 0x06003162 RID: 12642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003162")]
		[Address(RVA = "0x654A40", Offset = "0x653440", VA = "0x180654A40")]
		public void AddPerformanceSucceedCount()
		{
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003163")]
		[Address(RVA = "0x654A30", Offset = "0x653430", VA = "0x180654A30")]
		public void AddPerformanceFullComboCount()
		{
		}

		// Token: 0x06003164 RID: 12644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003164")]
		[Address(RVA = "0x6545B0", Offset = "0x652FB0", VA = "0x1806545B0")]
		public void AddBussinessFoodConsumes(IEnumerable<int> ids)
		{
		}

		// Token: 0x06003165 RID: 12645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003165")]
		[Address(RVA = "0x654550", Offset = "0x652F50", VA = "0x180654550")]
		public void AddBussinessBeverageConsumes(IEnumerable<int> ids)
		{
		}

		// Token: 0x06003166 RID: 12646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003166")]
		[Address(RVA = "0x654F70", Offset = "0x653970", VA = "0x180654F70")]
		public void DeductBussinessBeverageConsumes(IEnumerable<int> ids)
		{
		}

		// Token: 0x06003167 RID: 12647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003167")]
		[Address(RVA = "0x654610", Offset = "0x653010", VA = "0x180654610")]
		public void AddBussinessIngredientConsumes(IEnumerable<int> ids)
		{
		}

		// Token: 0x06003168 RID: 12648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003168")]
		[Address(RVA = "0x654800", Offset = "0x653200", VA = "0x180654800")]
		public void AddMissionIngredientConsumes(IEnumerable<int> ids)
		{
		}

		// Token: 0x06003169 RID: 12649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003169")]
		[Address(RVA = "0x6547A0", Offset = "0x6531A0", VA = "0x1806547A0")]
		public void AddMissionFoodConsumes(IEnumerable<int> ids)
		{
		}

		// Token: 0x0600316A RID: 12650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316A")]
		[Address(RVA = "0x654740", Offset = "0x653140", VA = "0x180654740")]
		public void AddMissionBeverageConsumes(IEnumerable<int> ids)
		{
		}

		// Token: 0x0600316B RID: 12651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316B")]
		[Address(RVA = "0x6546E0", Offset = "0x6530E0", VA = "0x1806546E0")]
		public void AddInvalidConsumes(IEnumerable<int> ids)
		{
		}

		// Token: 0x0600316C RID: 12652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316C")]
		[Address(RVA = "0x654680", Offset = "0x653080", VA = "0x180654680")]
		public void AddInvalidConsumes(params int[] ids)
		{
		}

		// Token: 0x0600316D RID: 12653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316D")]
		[Address(RVA = "0x654C40", Offset = "0x653640", VA = "0x180654C40")]
		public void CleanInValidConsumes()
		{
		}

		// Token: 0x0600316E RID: 12654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316E")]
		[Address(RVA = "0x655DF0", Offset = "0x6547F0", VA = "0x180655DF0")]
		public void UpdateExperience(int addAmount)
		{
		}

		// Token: 0x0600316F RID: 12655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600316F")]
		[Address(RVA = "0x655E00", Offset = "0x654800", VA = "0x180655E00")]
		public void UpdateMaxCombo(int currentCombo)
		{
		}

		// Token: 0x06003170 RID: 12656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003170")]
		[Address(RVA = "0x655E20", Offset = "0x654820", VA = "0x180655E20")]
		public void UpdateMaxPassion(int currentPassion, int _)
		{
		}

		// Token: 0x06003171 RID: 12657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003171")]
		[Address(RVA = "0x655EA0", Offset = "0x6548A0", VA = "0x180655EA0")]
		public void UpdateVisitors(int vistorAmount)
		{
		}

		// Token: 0x06003172 RID: 12658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003172")]
		[Address(RVA = "0x655B30", Offset = "0x654530", VA = "0x180655B30")]
		public void RecordNormalGuestReception(int guestAmount)
		{
		}

		// Token: 0x06003173 RID: 12659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003173")]
		[Address(RVA = "0x655C00", Offset = "0x654600", VA = "0x180655C00")]
		public void RecordSpecialGuestReception(int guestAmount)
		{
		}

		// Token: 0x06003174 RID: 12660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003174")]
		[Address(RVA = "0x655E70", Offset = "0x654870", VA = "0x180655E70")]
		public void UpdatePositiveSkillTriggerAmount()
		{
		}

		// Token: 0x06003175 RID: 12661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003175")]
		[Address(RVA = "0x655E60", Offset = "0x654860", VA = "0x180655E60")]
		public void UpdateNegativeSkillTriggerAmount()
		{
		}

		// Token: 0x06003176 RID: 12662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003176")]
		[Address(RVA = "0x655E90", Offset = "0x654890", VA = "0x180655E90")]
		public void UpdateSucceededRiceBallAmount()
		{
		}

		// Token: 0x06003177 RID: 12663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003177")]
		[Address(RVA = "0x6559B0", Offset = "0x6543B0", VA = "0x1806559B0")]
		public void RecordInvitedGuest(int guestId)
		{
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003178")]
		[Address(RVA = "0x655C70", Offset = "0x654670", VA = "0x180655C70")]
		public void RepeatRecordInvitedGuest(int guestId)
		{
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003179")]
		[Address(RVA = "0x6558B0", Offset = "0x6542B0", VA = "0x1806558B0")]
		public void RecordIgnoredGuest(int guestId)
		{
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600317A")]
		[Address(RVA = "0x655D10", Offset = "0x654710", VA = "0x180655D10")]
		public void Reset()
		{
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600317B")]
		[Address(RVA = "0x655670", Offset = "0x654070", VA = "0x180655670", Slot = "4")]
		protected override void OnDispose()
		{
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x00012108 File Offset: 0x00010308
		[Token(Token = "0x600317C")]
		[Address(RVA = "0x655400", Offset = "0x653E00", VA = "0x180655400")]
		public bool HasNPCInvited(int guestId)
		{
			return default(bool);
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600317D")]
		[Address(RVA = "0x6557E0", Offset = "0x6541E0", VA = "0x1806557E0")]
		public void RecordCommission(string characterLabel, DialogPackage commissionFinishDialog, IEnumerable<Product> commisionProduct)
		{
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x00012120 File Offset: 0x00010320
		[Token(Token = "0x600317E")]
		[Address(RVA = "0x655260", Offset = "0x653C60", VA = "0x180655260")]
		public bool HasCommission(string characterLabel)
		{
			return default(bool);
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x00012138 File Offset: 0x00010338
		[Token(Token = "0x600317F")]
		[Address(RVA = "0x6556C0", Offset = "0x6540C0", VA = "0x1806556C0")]
		public UniTask ReceiveCommissionsAsync()
		{
			return default(UniTask);
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003180")]
		[Address(RVA = "0x655780", Offset = "0x654180", VA = "0x180655780")]
		public void RecordChatNPCLabel(string npcLabel)
		{
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x00012150 File Offset: 0x00010350
		[Token(Token = "0x6003181")]
		[Address(RVA = "0x6553A0", Offset = "0x653DA0", VA = "0x1806553A0")]
		public bool HasNPCChat(string npcLabel)
		{
			return default(bool);
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003182")]
		[Address(RVA = "0x655C10", Offset = "0x654610", VA = "0x180655C10")]
		public void RecordTemptInviteNPCLabel(string npcLabel)
		{
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x00012168 File Offset: 0x00010368
		[Token(Token = "0x6003183")]
		[Address(RVA = "0x6554D0", Offset = "0x653ED0", VA = "0x1806554D0")]
		public bool HasTemptInvited(string npcLabel)
		{
			return default(bool);
		}

		// Token: 0x06003184 RID: 12676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003184")]
		[Address(RVA = "0x655BA0", Offset = "0x6545A0", VA = "0x180655BA0")]
		public void RecordRequestIngredientNPCLabel(string npcLabel)
		{
		}

		// Token: 0x06003185 RID: 12677 RVA: 0x00012180 File Offset: 0x00010380
		[Token(Token = "0x6003185")]
		[Address(RVA = "0x655340", Offset = "0x653D40", VA = "0x180655340")]
		public bool HasIngredientRequested(string npcLabel)
		{
			return default(bool);
		}

		// Token: 0x06003186 RID: 12678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003186")]
		[Address(RVA = "0x655B40", Offset = "0x654540", VA = "0x180655B40")]
		public void RecordRequestBeverageNPCLabel(string npcLabel)
		{
		}

		// Token: 0x06003187 RID: 12679 RVA: 0x00012198 File Offset: 0x00010398
		[Token(Token = "0x6003187")]
		[Address(RVA = "0x655200", Offset = "0x653C00", VA = "0x180655200")]
		public bool HasBeverageRequested(string npcLabel)
		{
			return default(bool);
		}

		// Token: 0x06003188 RID: 12680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003188")]
		[Address(RVA = "0x654B60", Offset = "0x653560", VA = "0x180654B60")]
		public void AddToPartner(int specialNPCId, PartnerBase.PartnerType partnerType)
		{
		}

		// Token: 0x06003189 RID: 12681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003189")]
		[Address(RVA = "0x654A50", Offset = "0x653450", VA = "0x180654A50")]
		public void AddToPartner(int specialNPCId, PartnerBase partner)
		{
		}

		// Token: 0x0600318A RID: 12682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600318A")]
		[Address(RVA = "0x654C90", Offset = "0x653690", VA = "0x180654C90")]
		public void CleanPartner()
		{
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600318B")]
		[Address(RVA = "0x440320", Offset = "0x43ED20", VA = "0x180440320")]
		public IEnumerable<ValueTuple<int, PartnerBase>> GetPartners()
		{
			return null;
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600318C")]
		[Address(RVA = "0x654860", Offset = "0x653260", VA = "0x180654860")]
		public void AddPartnerEnjoySpring(int partnerId)
		{
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x000121B0 File Offset: 0x000103B0
		[Token(Token = "0x600318D")]
		[Address(RVA = "0x655460", Offset = "0x653E60", VA = "0x180655460")]
		public bool HasPartnerEnjoySpring(int partnerId)
		{
			return default(bool);
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x000121C8 File Offset: 0x000103C8
		[Token(Token = "0x600318E")]
		[Address(RVA = "0x655150", Offset = "0x653B50", VA = "0x180655150")]
		public int GetComponentNum(string componentLabel)
		{
			return 0;
		}

		// Token: 0x0600318F RID: 12687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600318F")]
		[Address(RVA = "0x655530", Offset = "0x653F30", VA = "0x180655530")]
		public void IncreaseComponentNum(string componentLabel)
		{
		}

		// Token: 0x06003190 RID: 12688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003190")]
		[Address(RVA = "0x654F10", Offset = "0x653910", VA = "0x180654F10")]
		public void ClearComponentNum(string componentLabel)
		{
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003191")]
		[Address(RVA = "0x654CF0", Offset = "0x6536F0", VA = "0x180654CF0", Slot = "5")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06003192 RID: 12690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003192")]
		[Address(RVA = "0x655EB0", Offset = "0x6548B0", VA = "0x180655EB0")]
		public StatusTracker()
		{
		}

		// Token: 0x04002C2D RID: 11309
		[Token(Token = "0x4002C2D")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<int> buffedSpringPartners;

		// Token: 0x04002C2E RID: 11310
		[Token(Token = "0x4002C2E")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<int> bussinessBeverageConsumes;

		// Token: 0x04002C2F RID: 11311
		[Token(Token = "0x4002C2F")]
		[FieldOffset(Offset = "0x20")]
		private readonly List<int> bussinessFoodConsumes;

		// Token: 0x04002C30 RID: 11312
		[Token(Token = "0x4002C30")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<int> bussinessIngredientConsumes;

		// Token: 0x04002C31 RID: 11313
		[Token(Token = "0x4002C31")]
		[FieldOffset(Offset = "0x30")]
		private readonly List<string> hasChatNPC;

		// Token: 0x04002C32 RID: 11314
		[Token(Token = "0x4002C32")]
		[FieldOffset(Offset = "0x38")]
		private readonly Dictionary<string, int> hasInitializedComponent;

		// Token: 0x04002C33 RID: 11315
		[Token(Token = "0x4002C33")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<string> hasRequestedBeveragesNPC;

		// Token: 0x04002C34 RID: 11316
		[Token(Token = "0x4002C34")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<string> hasRequestedIngredientsNPC;

		// Token: 0x04002C35 RID: 11317
		[Token(Token = "0x4002C35")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<string> hasTemptInviteNPC;

		// Token: 0x04002C36 RID: 11318
		[Token(Token = "0x4002C36")]
		[FieldOffset(Offset = "0x58")]
		private readonly List<int> invalidFoods;

		// Token: 0x04002C37 RID: 11319
		[Token(Token = "0x4002C37")]
		[FieldOffset(Offset = "0x60")]
		private readonly List<int> missionBeverageConsumes;

		// Token: 0x04002C38 RID: 11320
		[Token(Token = "0x4002C38")]
		[FieldOffset(Offset = "0x68")]
		private readonly List<int> missionFoodConsumes;

		// Token: 0x04002C39 RID: 11321
		[Token(Token = "0x4002C39")]
		[FieldOffset(Offset = "0x70")]
		private readonly List<int> missionIngredientConsumes;

		// Token: 0x04002C3A RID: 11322
		[Token(Token = "0x4002C3A")]
		[FieldOffset(Offset = "0x78")]
		private readonly List<ValueTuple<int, PartnerBase>> partners;

		// Token: 0x04002C3B RID: 11323
		[Token(Token = "0x4002C3B")]
		[FieldOffset(Offset = "0x80")]
		[TupleElementNames(new string[] { "CharacterLabel", "FinishDialog", "ProductCollection" })]
		private readonly Queue<ValueTuple<string, DialogPackage, IEnumerable<Product>>> processingCommissions;
	}
}
