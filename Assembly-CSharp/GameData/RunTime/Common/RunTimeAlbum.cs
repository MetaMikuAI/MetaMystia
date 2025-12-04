using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using GameData.Core;
using GameData.Core.Collections;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace GameData.RunTime.Common
{
	// Token: 0x02000824 RID: 2084
	[Token(Token = "0x2000824")]
	public static class RunTimeAlbum
	{
		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x0600319F RID: 12703 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031A0 RID: 12704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067D")]
		private static List<int> NormalGuests
		{
			[Token(Token = "0x600319F")]
			[Address(RVA = "0x62D930", Offset = "0x62C330", VA = "0x18062D930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60031A0")]
			[Address(RVA = "0x62E1E0", Offset = "0x62CBE0", VA = "0x18062E1E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031A2 RID: 12706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067E")]
		private static List<int> Foods
		{
			[Token(Token = "0x60031A1")]
			[Address(RVA = "0x62D750", Offset = "0x62C150", VA = "0x18062D750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60031A2")]
			[Address(RVA = "0x62DF60", Offset = "0x62C960", VA = "0x18062DF60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060031A3 RID: 12707 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031A4 RID: 12708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700067F")]
		private static List<int> Beverages
		{
			[Token(Token = "0x60031A3")]
			[Address(RVA = "0x62D510", Offset = "0x62BF10", VA = "0x18062D510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60031A4")]
			[Address(RVA = "0x62DCA0", Offset = "0x62C6A0", VA = "0x18062DCA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060031A5 RID: 12709 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031A6 RID: 12710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000680")]
		private static List<int> Ingredients
		{
			[Token(Token = "0x60031A5")]
			[Address(RVA = "0x62D870", Offset = "0x62C270", VA = "0x18062D870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60031A6")]
			[Address(RVA = "0x62E0E0", Offset = "0x62CAE0", VA = "0x18062E0E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060031A7 RID: 12711 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031A8 RID: 12712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000681")]
		private static List<int> Cookers
		{
			[Token(Token = "0x60031A7")]
			[Address(RVA = "0x62D570", Offset = "0x62BF70", VA = "0x18062D570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60031A8")]
			[Address(RVA = "0x62DD20", Offset = "0x62C720", VA = "0x18062DD20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060031A9 RID: 12713 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031AA RID: 12714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000682")]
		private static List<int> Items
		{
			[Token(Token = "0x60031A9")]
			[Address(RVA = "0x62D8D0", Offset = "0x62C2D0", VA = "0x18062D8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60031AA")]
			[Address(RVA = "0x62E160", Offset = "0x62CB60", VA = "0x18062E160")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060031AB RID: 12715 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031AC RID: 12716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000683")]
		private static List<int> Badges
		{
			[Token(Token = "0x60031AB")]
			[Address(RVA = "0x62D4B0", Offset = "0x62BEB0", VA = "0x18062D4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60031AC")]
			[Address(RVA = "0x62DC20", Offset = "0x62C620", VA = "0x18062DC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060031AD RID: 12717 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031AE RID: 12718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000684")]
		private static List<string> HistoryCollectables
		{
			[Token(Token = "0x60031AD")]
			[Address(RVA = "0x62D7B0", Offset = "0x62C1B0", VA = "0x18062D7B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60031AE")]
			[Address(RVA = "0x62DFE0", Offset = "0x62C9E0", VA = "0x18062DFE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060031AF RID: 12719 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031B0 RID: 12720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000685")]
		private static List<int> UsedDecorations
		{
			[Token(Token = "0x60031AF")]
			[Address(RVA = "0x62DBC0", Offset = "0x62C5C0", VA = "0x18062DBC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60031B0")]
			[Address(RVA = "0x62E4B0", Offset = "0x62CEB0", VA = "0x18062E4B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060031B1 RID: 12721 RVA: 0x000121F8 File Offset: 0x000103F8
		// (set) Token: 0x060031B2 RID: 12722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000686")]
		public static bool UseCurrentSkinAtNight
		{
			[Token(Token = "0x60031B1")]
			[Address(RVA = "0x62DB00", Offset = "0x62C500", VA = "0x18062DB00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60031B2")]
			[Address(RVA = "0x62E3F0", Offset = "0x62CDF0", VA = "0x18062E3F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060031B3 RID: 12723 RVA: 0x00012210 File Offset: 0x00010410
		// (set) Token: 0x060031B4 RID: 12724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000687")]
		public static bool UseSpecialShopSkinAtNight
		{
			[Token(Token = "0x60031B3")]
			[Address(RVA = "0x62DB60", Offset = "0x62C560", VA = "0x18062DB60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60031B4")]
			[Address(RVA = "0x62E450", Offset = "0x62CE50", VA = "0x18062E450")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060031B5 RID: 12725 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031B6 RID: 12726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000688")]
		public static Dictionary<int, int> IngCollectCount
		{
			[Token(Token = "0x60031B5")]
			[Address(RVA = "0x62D810", Offset = "0x62C210", VA = "0x18062D810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60031B6")]
			[Address(RVA = "0x62E060", Offset = "0x62CA60", VA = "0x18062E060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060031B7 RID: 12727 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031B8 RID: 12728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000689")]
		public static Dictionary<int, int> UnsatisfiedTagCount
		{
			[Token(Token = "0x60031B7")]
			[Address(RVA = "0x62DAA0", Offset = "0x62C4A0", VA = "0x18062DAA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60031B8")]
			[Address(RVA = "0x62E370", Offset = "0x62CD70", VA = "0x18062E370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060031B9 RID: 12729 RVA: 0x00012228 File Offset: 0x00010428
		// (set) Token: 0x060031BA RID: 12730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068A")]
		public static int EvictGuestsCount
		{
			[Token(Token = "0x60031B9")]
			[Address(RVA = "0x62D6F0", Offset = "0x62C0F0", VA = "0x18062D6F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60031BA")]
			[Address(RVA = "0x62DF00", Offset = "0x62C900", VA = "0x18062DF00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060031BB RID: 12731 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031BC RID: 12732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068B")]
		public static Dictionary<int, int> CookingCount
		{
			[Token(Token = "0x60031BB")]
			[Address(RVA = "0x62D5D0", Offset = "0x62BFD0", VA = "0x18062D5D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60031BC")]
			[Address(RVA = "0x62DDA0", Offset = "0x62C7A0", VA = "0x18062DDA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060031BD RID: 12733 RVA: 0x00012240 File Offset: 0x00010440
		// (set) Token: 0x060031BE RID: 12734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068C")]
		public static int StrongBuyAndSellCount
		{
			[Token(Token = "0x60031BD")]
			[Address(RVA = "0x62DA40", Offset = "0x62C440", VA = "0x18062DA40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60031BE")]
			[Address(RVA = "0x62E310", Offset = "0x62CD10", VA = "0x18062E310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060031BF RID: 12735 RVA: 0x00012258 File Offset: 0x00010458
		// (set) Token: 0x060031C0 RID: 12736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068D")]
		public static int RewardSpellTriggerCount
		{
			[Token(Token = "0x60031BF")]
			[Address(RVA = "0x62D9E0", Offset = "0x62C3E0", VA = "0x18062D9E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60031C0")]
			[Address(RVA = "0x62E2B0", Offset = "0x62CCB0", VA = "0x18062E2B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060031C1 RID: 12737 RVA: 0x00012270 File Offset: 0x00010470
		// (set) Token: 0x060031C2 RID: 12738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068E")]
		public static int PunishmentSpellTriggerCount
		{
			[Token(Token = "0x60031C1")]
			[Address(RVA = "0x62D980", Offset = "0x62C380", VA = "0x18062D980")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60031C2")]
			[Address(RVA = "0x62E250", Offset = "0x62CC50", VA = "0x18062E250")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060031C3 RID: 12739 RVA: 0x00012288 File Offset: 0x00010488
		// (set) Token: 0x060031C4 RID: 12740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068F")]
		public static int CurrentPlayerSkin
		{
			[Token(Token = "0x60031C3")]
			[Address(RVA = "0x62D630", Offset = "0x62C030", VA = "0x18062D630")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60031C4")]
			[Address(RVA = "0x62DE20", Offset = "0x62C820", VA = "0x18062DE20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060031C5 RID: 12741 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060031C6 RID: 12742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000690")]
		private static List<int> EffectiveSGuestMappingRules
		{
			[Token(Token = "0x60031C5")]
			[Address(RVA = "0x62D690", Offset = "0x62C090", VA = "0x18062D690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60031C6")]
			[Address(RVA = "0x62DE80", Offset = "0x62C880", VA = "0x18062DE80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C7")]
		[Address(RVA = "0x621F50", Offset = "0x620950", VA = "0x180621F50")]
		public static void ClassifyIngredientByType(RunTimeAlbum.DataSource dataSource, List<KeyValuePair<Ingredient, int>> seaFood, List<KeyValuePair<Ingredient, int>> meat, List<KeyValuePair<Ingredient, int>> veggies, List<KeyValuePair<Ingredient, int>> other, [Optional] Func<List<KeyValuePair<Ingredient, int>>, IEnumerable<KeyValuePair<Ingredient, int>>> filterFunc)
		{
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031C8")]
		[Address(RVA = "0x621340", Offset = "0x61FD40", VA = "0x180621340")]
		private static void ClassifyIngredientByTypeCore(IEnumerable<KeyValuePair<Ingredient, int>> collection, List<KeyValuePair<Ingredient, int>> seaFood, List<KeyValuePair<Ingredient, int>> meat, List<KeyValuePair<Ingredient, int>> veggies, List<KeyValuePair<Ingredient, int>> other, Func<List<KeyValuePair<Ingredient, int>>, IEnumerable<KeyValuePair<Ingredient, int>>> filterFunc)
		{
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031C9")]
		[Address(RVA = "0x625AD0", Offset = "0x6244D0", VA = "0x180625AD0")]
		public static IEnumerable<KeyValuePair<Ingredient, int>> GetIngredientWithRecord()
		{
			return null;
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031CA")]
		[Address(RVA = "0x625A70", Offset = "0x624470", VA = "0x180625A70")]
		public static IEnumerable<KeyValuePair<Sellable, int>> GetFoodWithRecord()
		{
			return null;
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031CB")]
		[Address(RVA = "0x625600", Offset = "0x624000", VA = "0x180625600")]
		public static IEnumerable<KeyValuePair<Sellable, int>> GetBeverageWithRecord()
		{
			return null;
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031CC")]
		[Address(RVA = "0x625A10", Offset = "0x624410", VA = "0x180625A10")]
		public static IEnumerable<KeyValuePair<Cooker, int>> GetCookerWithRecord()
		{
			return null;
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031CD")]
		[Address(RVA = "0x626930", Offset = "0x625330", VA = "0x180626930")]
		public static void Initialize(PlayerSaveFile.RunTimeAlbumSaveDataPartial saveDataPartial, Dictionary<string, PlayerSaveFile.DLCAlbumSaveData> saveDataDLCPartial)
		{
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x000122A0 File Offset: 0x000104A0
		[Token(Token = "0x60031CE")]
		[Address(RVA = "0x623C00", Offset = "0x622600", VA = "0x180623C00")]
		public static PlayerSaveFile.RunTimeAlbumSaveDataPartial GenerateSaveData()
		{
			return default(PlayerSaveFile.RunTimeAlbumSaveDataPartial);
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031CF")]
		[Address(RVA = "0x62C970", Offset = "0x62B370", VA = "0x18062C970")]
		private static void TryRecord(this List<int> list, int value, Action<int> onRecordAction)
		{
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D0")]
		[Address(RVA = "0x62C560", Offset = "0x62AF60", VA = "0x18062C560")]
		public static void TryRecordNormalGuests(int value)
		{
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D1")]
		[Address(RVA = "0x62C6B0", Offset = "0x62B0B0", VA = "0x18062C6B0")]
		public static void TryRecordSpecialGuests(int value)
		{
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D2")]
		[Address(RVA = "0x62BE80", Offset = "0x62A880", VA = "0x18062BE80")]
		public static void TryRecordFoods(int value)
		{
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D3")]
		[Address(RVA = "0x62BBE0", Offset = "0x62A5E0", VA = "0x18062BBE0")]
		public static void TryRecordBeverages(int value)
		{
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D4")]
		[Address(RVA = "0x62C360", Offset = "0x62AD60", VA = "0x18062C360")]
		public static void TryRecordIngredients(int value)
		{
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D5")]
		[Address(RVA = "0x62BD30", Offset = "0x62A730", VA = "0x18062BD30")]
		public static void TryRecordCookers(int value)
		{
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D6")]
		[Address(RVA = "0x62C410", Offset = "0x62AE10", VA = "0x18062C410")]
		public static void TryRecordItems(int value)
		{
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D7")]
		[Address(RVA = "0x62BA90", Offset = "0x62A490", VA = "0x18062BA90")]
		public static void TryRecordBadges(int value)
		{
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031D8")]
		[Address(RVA = "0x62CAF0", Offset = "0x62B4F0", VA = "0x18062CAF0")]
		public static void TrySetSpecialGuestSkin(int id, CharacterSkinSets.SkinSelectionInfo skinSelectionInfo)
		{
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x000122B8 File Offset: 0x000104B8
		[Token(Token = "0x60031D9")]
		[Address(RVA = "0x626690", Offset = "0x625090", VA = "0x180626690")]
		public static bool HasSpecialNPCRecorded(this int id)
		{
			return default(bool);
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031DA")]
		[Address(RVA = "0x626200", Offset = "0x624C00", VA = "0x180626200")]
		public static string[] GetRecordHistoryCollectables()
		{
			return null;
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DB")]
		[Address(RVA = "0x62BFD0", Offset = "0x62A9D0", VA = "0x18062BFD0")]
		public static void TryRecordHistoryCollectables(string collectableData)
		{
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DC")]
		[Address(RVA = "0x62C700", Offset = "0x62B100", VA = "0x18062C700")]
		public static void TryRecordUsedDecoration(int decorationId)
		{
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DD")]
		[Address(RVA = "0x62CA40", Offset = "0x62B440", VA = "0x18062CA40")]
		public static void TryRemoveUsedDecoration(int decorationId)
		{
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DE")]
		[Address(RVA = "0x6209D0", Offset = "0x61F3D0", VA = "0x1806209D0")]
		public static void ChangePlayerSkin(int skinSelectionInfo)
		{
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031DF")]
		[Address(RVA = "0x62B930", Offset = "0x62A330", VA = "0x18062B930")]
		public static void SetPlayerSkinDebugConsole(int skinSelectionInfo)
		{
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E0")]
		[Address(RVA = "0x6262B0", Offset = "0x624CB0", VA = "0x1806262B0")]
		public static void GetRevealedData(this SpecialGuest specialGuestData, out IEnumerable<int> revealedFoodTags, out IEnumerable<int> revealedHateFoodTags, out IEnumerable<int> revealedBevTags, out IEnumerable<int> revealedIzakaya)
		{
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E1")]
		[Address(RVA = "0x62AF00", Offset = "0x629900", VA = "0x18062AF00")]
		public static void RemoveRevealedData(this int specialGuestId, int amount = 1)
		{
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E2")]
		[Address(RVA = "0x629660", Offset = "0x628060", VA = "0x180629660")]
		public static void RecordSpecialGuestFoodTag(int specialGusetId, params int[] foodTags)
		{
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E3")]
		[Address(RVA = "0x629AF0", Offset = "0x6284F0", VA = "0x180629AF0")]
		public static void RecordSpecialGuestHateFoodTag(int specialGusetId, params int[] foodTags)
		{
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E4")]
		[Address(RVA = "0x6291B0", Offset = "0x627BB0", VA = "0x1806291B0")]
		public static void RecordSpecialGuestBevTag(int specialGusetId, params int[] bevTags)
		{
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E5")]
		[Address(RVA = "0x629F80", Offset = "0x628980", VA = "0x180629F80")]
		public static void RecordSpecialGuestIzakaya(int specialGusetId, int izakayaId)
		{
		}

		// Token: 0x060031E6 RID: 12774 RVA: 0x000122D0 File Offset: 0x000104D0
		[Token(Token = "0x60031E6")]
		[Address(RVA = "0x620CC0", Offset = "0x61F6C0", VA = "0x180620CC0")]
		public static bool CheckAllRevealedDataIsUnlocked(int specialGuestId, int checkType)
		{
			return default(bool);
		}

		// Token: 0x060031E7 RID: 12775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E7")]
		[Address(RVA = "0x62B9D0", Offset = "0x62A3D0", VA = "0x18062B9D0")]
		public static void SetPositiveSpellCardNum(int specialGuestId, int value)
		{
		}

		// Token: 0x060031E8 RID: 12776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031E8")]
		[Address(RVA = "0x62B650", Offset = "0x62A050", VA = "0x18062B650")]
		public static void SetNegativeSpellCardNum(int specialGuestId, int value)
		{
		}

		// Token: 0x060031E9 RID: 12777 RVA: 0x000122E8 File Offset: 0x000104E8
		[Token(Token = "0x60031E9")]
		[Address(RVA = "0x626150", Offset = "0x624B50", VA = "0x180626150")]
		public static int GetPositiveSpellCardNum(int specialGuestId)
		{
			return 0;
		}

		// Token: 0x060031EA RID: 12778 RVA: 0x00012300 File Offset: 0x00010500
		[Token(Token = "0x60031EA")]
		[Address(RVA = "0x625DC0", Offset = "0x6247C0", VA = "0x180625DC0")]
		public static int GetNegativeSpellCardNum(int specialGuestId)
		{
			return 0;
		}

		// Token: 0x060031EB RID: 12779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031EB")]
		[Address(RVA = "0x628F40", Offset = "0x627940", VA = "0x180628F40")]
		public static void RecordPositiveSpellCardNum(int specialGusetId)
		{
		}

		// Token: 0x060031EC RID: 12780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031EC")]
		[Address(RVA = "0x628CD0", Offset = "0x6276D0", VA = "0x180628CD0")]
		public static void RecordNegativeSpellCardNum(int specialGusetId)
		{
		}

		// Token: 0x060031ED RID: 12781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031ED")]
		[Address(RVA = "0x62CD60", Offset = "0x62B760", VA = "0x18062CD60")]
		public static void UpdateNegativeSpellCardTotalNum()
		{
		}

		// Token: 0x060031EE RID: 12782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031EE")]
		[Address(RVA = "0x62CF40", Offset = "0x62B940", VA = "0x18062CF40")]
		public static void UpdatePositiveSpellCardTotalNum()
		{
		}

		// Token: 0x060031EF RID: 12783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031EF")]
		[Address(RVA = "0x6230E0", Offset = "0x621AE0", VA = "0x1806230E0")]
		public static void ClearSGuestAlbum()
		{
		}

		// Token: 0x060031F0 RID: 12784 RVA: 0x00012318 File Offset: 0x00010518
		[Token(Token = "0x60031F0")]
		[Address(RVA = "0x626850", Offset = "0x625250", VA = "0x180626850")]
		public static bool IfGuestHaveSpawnHere(int specialGuestId, int izakayaId)
		{
			return default(bool);
		}

		// Token: 0x060031F1 RID: 12785 RVA: 0x00012330 File Offset: 0x00010530
		[Token(Token = "0x60031F1")]
		[Address(RVA = "0x626710", Offset = "0x625110", VA = "0x180626710")]
		public static bool IfGuestHaveSpawnHere(string specialGuestLabel, int izakayaId)
		{
			return default(bool);
		}

		// Token: 0x060031F2 RID: 12786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F2")]
		[Address(RVA = "0x62B3F0", Offset = "0x629DF0", VA = "0x18062B3F0")]
		public static void SetGuestSpawnIzakayaId(int specialGuestId, int izakayaId)
		{
		}

		// Token: 0x060031F3 RID: 12787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60031F3")]
		[Address(RVA = "0x62B4F0", Offset = "0x629EF0", VA = "0x18062B4F0")]
		public static void SetGuestSpawnIzakayaId(string specialGuestLabel, int izakayaId)
		{
		}

		// Token: 0x060031F4 RID: 12788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F4")]
		[Address(RVA = "0x625360", Offset = "0x623D60", VA = "0x180625360")]
		public static IEnumerable<int> GetAllRecordedNormalGuests()
		{
			return null;
		}

		// Token: 0x060031F5 RID: 12789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F5")]
		[Address(RVA = "0x6253F0", Offset = "0x623DF0", VA = "0x1806253F0")]
		public static IEnumerable<int> GetAllRecordedSpecialGuests()
		{
			return null;
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F6")]
		[Address(RVA = "0x624D00", Offset = "0x623700", VA = "0x180624D00")]
		public static List<int> GetAllRecordedFoodIds()
		{
			return null;
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F7")]
		[Address(RVA = "0x6248C0", Offset = "0x6232C0", VA = "0x1806248C0")]
		public static List<int> GetAllRecordedBeverageIds()
		{
			return null;
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F8")]
		[Address(RVA = "0x624F20", Offset = "0x623920", VA = "0x180624F20")]
		public static List<int> GetAllRecordedIngredientIds()
		{
			return null;
		}

		// Token: 0x060031F9 RID: 12793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031F9")]
		[Address(RVA = "0x624AE0", Offset = "0x6234E0", VA = "0x180624AE0")]
		public static List<int> GetAllRecordedCookerIds()
		{
			return null;
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FA")]
		[Address(RVA = "0x625140", Offset = "0x623B40", VA = "0x180625140")]
		public static List<int> GetAllRecordedItemIds()
		{
			return null;
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FB")]
		[Address(RVA = "0x624D90", Offset = "0x623790", VA = "0x180624D90")]
		public static IEnumerable<Sellable> GetAllRecordedFoods()
		{
			return null;
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FC")]
		[Address(RVA = "0x624950", Offset = "0x623350", VA = "0x180624950")]
		public static IEnumerable<Sellable> GetAllRecordedBeverages()
		{
			return null;
		}

		// Token: 0x060031FD RID: 12797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FD")]
		[Address(RVA = "0x624FB0", Offset = "0x6239B0", VA = "0x180624FB0")]
		public static IEnumerable<Ingredient> GetAllRecordedIngredients()
		{
			return null;
		}

		// Token: 0x060031FE RID: 12798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FE")]
		[Address(RVA = "0x624B70", Offset = "0x623570", VA = "0x180624B70")]
		public static IEnumerable<Cooker> GetAllRecordedCookers()
		{
			return null;
		}

		// Token: 0x060031FF RID: 12799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60031FF")]
		[Address(RVA = "0x6251D0", Offset = "0x623BD0", VA = "0x1806251D0")]
		public static IEnumerable<NonTradableObjectBase> GetAllRecordedItems()
		{
			return null;
		}

		// Token: 0x06003200 RID: 12800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003200")]
		[Address(RVA = "0x624730", Offset = "0x623130", VA = "0x180624730")]
		public static IEnumerable<Badge> GetAllRecordedBadges()
		{
			return null;
		}

		// Token: 0x06003201 RID: 12801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003201")]
		[Address(RVA = "0x625470", Offset = "0x623E70", VA = "0x180625470")]
		public static IEnumerable<Decoration> GetAllUsingDecorations()
		{
			return null;
		}

		// Token: 0x06003202 RID: 12802 RVA: 0x00012348 File Offset: 0x00010548
		[Token(Token = "0x6003202")]
		[Address(RVA = "0x623520", Offset = "0x621F20", VA = "0x180623520")]
		public static int CountNormalGuests()
		{
			return 0;
		}

		// Token: 0x06003203 RID: 12803 RVA: 0x00012360 File Offset: 0x00010560
		[Token(Token = "0x6003203")]
		[Address(RVA = "0x6235C0", Offset = "0x621FC0", VA = "0x1806235C0")]
		public static int CountSpecialGuests()
		{
			return 0;
		}

		// Token: 0x06003204 RID: 12804 RVA: 0x00012378 File Offset: 0x00010578
		[Token(Token = "0x6003204")]
		[Address(RVA = "0x623340", Offset = "0x621D40", VA = "0x180623340")]
		public static int CountFoods()
		{
			return 0;
		}

		// Token: 0x06003205 RID: 12805 RVA: 0x00012390 File Offset: 0x00010590
		[Token(Token = "0x6003205")]
		[Address(RVA = "0x623200", Offset = "0x621C00", VA = "0x180623200")]
		public static int CountBeverages()
		{
			return 0;
		}

		// Token: 0x06003206 RID: 12806 RVA: 0x000123A8 File Offset: 0x000105A8
		[Token(Token = "0x6003206")]
		[Address(RVA = "0x6233E0", Offset = "0x621DE0", VA = "0x1806233E0")]
		public static int CountIngredients()
		{
			return 0;
		}

		// Token: 0x06003207 RID: 12807 RVA: 0x000123C0 File Offset: 0x000105C0
		[Token(Token = "0x6003207")]
		[Address(RVA = "0x6232A0", Offset = "0x621CA0", VA = "0x1806232A0")]
		public static int CountCookers()
		{
			return 0;
		}

		// Token: 0x06003208 RID: 12808 RVA: 0x000123D8 File Offset: 0x000105D8
		[Token(Token = "0x6003208")]
		[Address(RVA = "0x623480", Offset = "0x621E80", VA = "0x180623480")]
		public static int CountItems()
		{
			return 0;
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x000123F0 File Offset: 0x000105F0
		[Token(Token = "0x6003209")]
		[Address(RVA = "0x623160", Offset = "0x621B60", VA = "0x180623160")]
		public static int CountBadges()
		{
			return 0;
		}

		// Token: 0x0600320A RID: 12810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600320A")]
		[Address(RVA = "0x626020", Offset = "0x624A20", VA = "0x180626020")]
		public static ClothesProfile.Clothes GetPlayerClothes()
		{
			return null;
		}

		// Token: 0x0600320B RID: 12811 RVA: 0x00012408 File Offset: 0x00010608
		[Token(Token = "0x600320B")]
		[Address(RVA = "0x625E70", Offset = "0x624870", VA = "0x180625E70")]
		public static int GetNightBGMId()
		{
			return 0;
		}

		// Token: 0x0600320C RID: 12812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600320C")]
		[Address(RVA = "0x62B710", Offset = "0x62A110", VA = "0x18062B710")]
		public static void SetNightBGMId(int musicPackageIndex)
		{
		}

		// Token: 0x0600320D RID: 12813 RVA: 0x00012420 File Offset: 0x00010620
		[Token(Token = "0x600320D")]
		[Address(RVA = "0x625EC0", Offset = "0x6248C0", VA = "0x180625EC0")]
		public static int GetNightBGMIndex()
		{
			return 0;
		}

		// Token: 0x0600320E RID: 12814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600320E")]
		[Address(RVA = "0x62B850", Offset = "0x62A250", VA = "0x18062B850")]
		public static void SetNightBGMIndex(int index)
		{
		}

		// Token: 0x0600320F RID: 12815 RVA: 0x00012438 File Offset: 0x00010638
		[Token(Token = "0x600320F")]
		[Address(RVA = "0x628B60", Offset = "0x627560", VA = "0x180628B60")]
		public static CharacterSkinSets.SkinSelectionInfo PlayerSkinSet()
		{
			return default(CharacterSkinSets.SkinSelectionInfo);
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x00012450 File Offset: 0x00010650
		[Token(Token = "0x6003210")]
		[Address(RVA = "0x625660", Offset = "0x624060", VA = "0x180625660")]
		public static int GetCharacterKizuna(int characterId, out int maxExp, out int level)
		{
			return 0;
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x00012468 File Offset: 0x00010668
		[Token(Token = "0x6003211")]
		[Address(RVA = "0x625870", Offset = "0x624270", VA = "0x180625870")]
		public static int GetCharacterKizuna(string characterLabel, out int maxExp, out int level)
		{
			return 0;
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003212")]
		[Address(RVA = "0x62A230", Offset = "0x628C30", VA = "0x18062A230")]
		public static CharacterSpriteSetCompact RefNormalPixel(this int id)
		{
			return null;
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003213")]
		[Address(RVA = "0x62A2A0", Offset = "0x628CA0", VA = "0x18062A2A0")]
		public static CharacterPortrayal RefNormalPortrayal(this int id)
		{
			return null;
		}

		// Token: 0x06003214 RID: 12820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003214")]
		[Address(RVA = "0x62A380", Offset = "0x628D80", VA = "0x18062A380")]
		public static RunTimeAlbum.SpecialGuestRunTimeData RefOrGenerateSpecialRunTimeData(this int guestId)
		{
			return null;
		}

		// Token: 0x06003215 RID: 12821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003215")]
		[Address(RVA = "0x62A310", Offset = "0x628D10", VA = "0x18062A310")]
		public static RunTimeAlbum.SpecialGuestRunTimeData RefOrGenerateSpecialRunTimeData(this string npcLabel)
		{
			return null;
		}

		// Token: 0x06003216 RID: 12822 RVA: 0x00012480 File Offset: 0x00010680
		[Token(Token = "0x6003216")]
		[Address(RVA = "0x62A7D0", Offset = "0x6291D0", VA = "0x18062A7D0")]
		public static int RefSpecialNPCId(this string characterLabel)
		{
			return 0;
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x00012498 File Offset: 0x00010698
		[Token(Token = "0x6003217")]
		[Address(RVA = "0x625D80", Offset = "0x624780", VA = "0x180625D80")]
		public static int GetLevelUpExpAmount(int currentLevel)
		{
			return 0;
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x000124B0 File Offset: 0x000106B0
		[Token(Token = "0x6003218")]
		[Address(RVA = "0x626590", Offset = "0x624F90", VA = "0x180626590")]
		public static bool HasSpecialNPCKizunaExpFull(int characterId)
		{
			return default(bool);
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x000124C8 File Offset: 0x000106C8
		[Token(Token = "0x6003219")]
		[Address(RVA = "0x6264E0", Offset = "0x624EE0", VA = "0x1806264E0")]
		public static bool HasDecorationUsing(int decorationId)
		{
			return default(bool);
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600321A")]
		[Address(RVA = "0x625B30", Offset = "0x624530", VA = "0x180625B30")]
		public static IEnumerable<int> GetLevel5KizunaNPCData()
		{
			return null;
		}

		// Token: 0x0600321B RID: 12827 RVA: 0x000124E0 File Offset: 0x000106E0
		[Token(Token = "0x600321B")]
		[Address(RVA = "0x625F70", Offset = "0x624970", VA = "0x180625F70")]
		public static int GetOrGenerateSpecialNPCKizunaLevel(string characterLabel)
		{
			return 0;
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x000124F8 File Offset: 0x000106F8
		[Token(Token = "0x600321C")]
		[Address(RVA = "0x625F10", Offset = "0x624910", VA = "0x180625F10")]
		public static int GetOrGenerateSpecialNPCKizunaLevel(int characterId)
		{
			return 0;
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600321D")]
		[Address(RVA = "0x61FFD0", Offset = "0x61E9D0", VA = "0x18061FFD0")]
		public static void AlterOrGenerateSpecialNPCKizuna(string characterLabel, int kizunaAmount)
		{
		}

		// Token: 0x0600321E RID: 12830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600321E")]
		[Address(RVA = "0x620050", Offset = "0x61EA50", VA = "0x180620050")]
		public static void AlterOrGenerateSpecialNPCKizuna(int characterId, int kizunaAmount)
		{
		}

		// Token: 0x0600321F RID: 12831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600321F")]
		[Address(RVA = "0x62D120", Offset = "0x62BB20", VA = "0x18062D120")]
		public static void UpgradeOrGenerateSpecialNPCKizuna(string characterLabel)
		{
		}

		// Token: 0x06003220 RID: 12832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003220")]
		[Address(RVA = "0x62AB00", Offset = "0x629500", VA = "0x18062AB00")]
		public static void RefreshAllKizunaLevelUpdateData()
		{
		}

		// Token: 0x06003221 RID: 12833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003221")]
		[Address(RVA = "0x62CC80", Offset = "0x62B680", VA = "0x18062CC80")]
		public static void UpdateAllStatusForSpecialNPC(SpecialGuest specialGuest)
		{
		}

		// Token: 0x06003222 RID: 12834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003222")]
		[Address(RVA = "0x62A800", Offset = "0x629200", VA = "0x18062A800")]
		public static CharacterSpriteSetCompact RefSpecialPixel(this int id, bool useDefaultSkin = false)
		{
			return null;
		}

		// Token: 0x06003223 RID: 12835 RVA: 0x00012510 File Offset: 0x00010710
		[Token(Token = "0x6003223")]
		[Address(RVA = "0x620840", Offset = "0x61F240", VA = "0x180620840")]
		private static int? CalculateIfShouldLoadSpecialSkinForKyouko(int id)
		{
			return null;
		}

		// Token: 0x06003224 RID: 12836 RVA: 0x00012528 File Offset: 0x00010728
		[Token(Token = "0x6003224")]
		[Address(RVA = "0x6208D0", Offset = "0x61F2D0", VA = "0x1806208D0")]
		private static int? CalculateIfShouldLoadSpecialSkinForSelf()
		{
			return null;
		}

		// Token: 0x06003225 RID: 12837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003225")]
		[Address(RVA = "0x62A980", Offset = "0x629380", VA = "0x18062A980")]
		public static CharacterPortrayal RefSpecialPortrayal(this int id, bool useDefaultSkin = false)
		{
			return null;
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003226")]
		[Address(RVA = "0x62A5A0", Offset = "0x628FA0", VA = "0x18062A5A0")]
		public static CharacterSpriteSetFull RefSelfPixel()
		{
			return null;
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003227")]
		[Address(RVA = "0x62A6E0", Offset = "0x6290E0", VA = "0x18062A6E0")]
		public static CharacterPortrayal RefSelfPortrayal()
		{
			return null;
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003228")]
		[Address(RVA = "0x624600", Offset = "0x623000", VA = "0x180624600")]
		public static IEnumerable<Ingredient> GetAlbumIngredientsOrderByDatabase()
		{
			return null;
		}

		// Token: 0x06003229 RID: 12841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003229")]
		[Address(RVA = "0x6244D0", Offset = "0x622ED0", VA = "0x1806244D0")]
		public static IEnumerable<Sellable> GetAlbumFoodsOrderByDatabase()
		{
			return null;
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600322A")]
		[Address(RVA = "0x6243A0", Offset = "0x622DA0", VA = "0x1806243A0")]
		public static IEnumerable<Sellable> GetAlbumBevsOrderByDatabase()
		{
			return null;
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x00012540 File Offset: 0x00010740
		[Token(Token = "0x600322B")]
		[Address(RVA = "0x628720", Offset = "0x627120", VA = "0x180628720")]
		public static bool IsBadgeRecoreded(Badge badge)
		{
			return default(bool);
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x00012558 File Offset: 0x00010758
		[Token(Token = "0x600322C")]
		[Address(RVA = "0x621230", Offset = "0x61FC30", VA = "0x180621230")]
		public static bool CheckSGuestMapping(int originGuest, out int mappingSGuest)
		{
			return default(bool);
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x00012570 File Offset: 0x00010770
		[Token(Token = "0x600322D")]
		[Address(RVA = "0x621070", Offset = "0x61FA70", VA = "0x180621070")]
		public static bool CheckMappingSGuestOrigin(int mappingSGuest, out int originalGuest)
		{
			return default(bool);
		}

		// Token: 0x0600322E RID: 12846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600322E")]
		[Address(RVA = "0x61FE00", Offset = "0x61E800", VA = "0x18061FE00")]
		public static void AddSGuestMapping(int originGuest)
		{
		}

		// Token: 0x0600322F RID: 12847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600322F")]
		[Address(RVA = "0x62B340", Offset = "0x629D40", VA = "0x18062B340")]
		public static void RemoveSGuestMapping(int originGuest)
		{
		}

		// Token: 0x06003230 RID: 12848 RVA: 0x00012588 File Offset: 0x00010788
		[Token(Token = "0x6003230")]
		[Address(RVA = "0x622310", Offset = "0x620D10", VA = "0x180622310")]
		public static UniTask ClearAndDumpPlayerSkinDataAsync(out RunTimeAlbum.RuntimePlayerSkinDataCache cache)
		{
			return default(UniTask);
		}

		// Token: 0x06003231 RID: 12849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003231")]
		[Address(RVA = "0x623A90", Offset = "0x622490", VA = "0x180623A90")]
		public static RunTimeAlbum.RuntimePlayerSkinDataCache CreatePlayerRuntimeSkinDataCache()
		{
			return null;
		}

		// Token: 0x06003232 RID: 12850 RVA: 0x000125A0 File Offset: 0x000107A0
		[Token(Token = "0x6003232")]
		[Address(RVA = "0x628A00", Offset = "0x627400", VA = "0x180628A00")]
		public static UniTask MountAndOverridePlayerSkinRuntimeData(RunTimeAlbum.RuntimePlayerSkinDataCache cache)
		{
			return default(UniTask);
		}

		// Token: 0x06003233 RID: 12851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003233")]
		[Address(RVA = "0x6225B0", Offset = "0x620FB0", VA = "0x1806225B0")]
		public static void ClearAndDumpRunTimeAlbumData(out RunTimeAlbum.RuntimeAlbumCache cache)
		{
		}

		// Token: 0x06003234 RID: 12852 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003234")]
		[Address(RVA = "0x623640", Offset = "0x622040", VA = "0x180623640")]
		private static RunTimeAlbum.RuntimeAlbumCache CreatePlayerRuntimeDataCache()
		{
			return null;
		}

		// Token: 0x06003235 RID: 12853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003235")]
		[Address(RVA = "0x6287D0", Offset = "0x6271D0", VA = "0x1806287D0")]
		public static void MountAndOverridePlayerRuntimeData(RunTimeAlbum.RuntimeAlbumCache cache)
		{
		}

		// Token: 0x04002C5F RID: 11359
		[Token(Token = "0x4002C5F")]
		private const int DEFAULT_IZAKAYA_SKIN = -2;

		// Token: 0x04002C60 RID: 11360
		[Token(Token = "0x4002C60")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int nightBGM;

		// Token: 0x04002C61 RID: 11361
		[Token(Token = "0x4002C61")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static int nightBGMIndex;

		// Token: 0x04002C62 RID: 11362
		[Token(Token = "0x4002C62")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<int> OnNewNormalGuestAdd;

		// Token: 0x04002C63 RID: 11363
		[Token(Token = "0x4002C63")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<int> OnNewSpecialGuestAdd;

		// Token: 0x04002C64 RID: 11364
		[Token(Token = "0x4002C64")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[TupleElementNames(new string[] { "characterId", "tagType", "isHateTag", "tagId" })]
		public static Action<ValueTuple<int, Sellable.SellableType, bool, int>> OnSpecialGuestTagUpdated;

		// Token: 0x04002C65 RID: 11365
		[Token(Token = "0x4002C65")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[TupleElementNames(new string[] { "characterId", "izakayaId" })]
		public static Action<ValueTuple<int, int>> OnSpecialGuestIzakayaUpdated;

		// Token: 0x04002C66 RID: 11366
		[Token(Token = "0x4002C66")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Action<int> OnSpecialGuestInfoUpdated;

		// Token: 0x04002C67 RID: 11367
		[Token(Token = "0x4002C67")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Action OnSpecialGuestKizunaFull;

		// Token: 0x04002C68 RID: 11368
		[Token(Token = "0x4002C68")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[TupleElementNames(new string[] { "characterId", "level" })]
		public static Action<ValueTuple<int, int>> OnSpecialGuestKizunaUpgrade;

		// Token: 0x04002C69 RID: 11369
		[Token(Token = "0x4002C69")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Action<string, bool> OnSpecialGuestKizunaChanged;

		// Token: 0x04002C6A RID: 11370
		[Token(Token = "0x4002C6A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Action<int> OnNewFoodAdd;

		// Token: 0x04002C6B RID: 11371
		[Token(Token = "0x4002C6B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Action<int> OnNewBeverageAdd;

		// Token: 0x04002C6C RID: 11372
		[Token(Token = "0x4002C6C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static Action<int> OnNewIngredientAdd;

		// Token: 0x04002C6D RID: 11373
		[Token(Token = "0x4002C6D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static Action<int> OnNewCookerAdd;

		// Token: 0x04002C6E RID: 11374
		[Token(Token = "0x4002C6E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static Action<int> OnNewItemAdd;

		// Token: 0x04002C6F RID: 11375
		[Token(Token = "0x4002C6F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static Action<int> OnNewBadgeAdd;

		// Token: 0x04002C84 RID: 11396
		[Token(Token = "0x4002C84")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> RecordedSpecialNPCs;

		// Token: 0x04002C85 RID: 11397
		[Token(Token = "0x4002C85")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static int[] s_ExceptItems;

		// Token: 0x02000825 RID: 2085
		[Token(Token = "0x2000825")]
		public enum DataSource
		{
			// Token: 0x04002C87 RID: 11399
			[Token(Token = "0x4002C87")]
			Album,
			// Token: 0x04002C88 RID: 11400
			[Token(Token = "0x4002C88")]
			InStorageOnly
		}

		// Token: 0x02000826 RID: 2086
		[Token(Token = "0x2000826")]
		public class SpecialGuestRunTimeData : IDeepClonable<RunTimeAlbum.SpecialGuestRunTimeData>
		{
			// Token: 0x06003237 RID: 12855 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003237")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			public SpecialGuestRunTimeData()
			{
			}

			// Token: 0x06003238 RID: 12856 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003238")]
			[Address(RVA = "0x6540A0", Offset = "0x652AA0", VA = "0x1806540A0")]
			public SpecialGuestRunTimeData(int currentBondExp, int currentBondLevel, List<int> unlockedExplicits, CharacterSkinSets.SkinSelectionInfo currentSkinSelection, bool doNotShowInNight)
			{
			}

			// Token: 0x06003239 RID: 12857 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003239")]
			[Address(RVA = "0x653EE0", Offset = "0x6528E0", VA = "0x180653EE0", Slot = "4")]
			public RunTimeAlbum.SpecialGuestRunTimeData Clone()
			{
				return null;
			}

			// Token: 0x17000691 RID: 1681
			// (get) Token: 0x0600323A RID: 12858 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600323B RID: 12859 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000691")]
			public List<int> UnlockedExplicits
			{
				[Token(Token = "0x600323A")]
				[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600323B")]
				[Address(RVA = "0x4AD3C0", Offset = "0x4ABDC0", VA = "0x1804AD3C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000692 RID: 1682
			// (get) Token: 0x0600323C RID: 12860 RVA: 0x000125B8 File Offset: 0x000107B8
			// (set) Token: 0x0600323D RID: 12861 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000692")]
			public CharacterSkinSets.SkinSelectionInfo CurrentSkinSelection
			{
				[Token(Token = "0x600323C")]
				[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0")]
				[CompilerGenerated]
				get
				{
					return default(CharacterSkinSets.SkinSelectionInfo);
				}
				[Token(Token = "0x600323D")]
				[Address(RVA = "0x654520", Offset = "0x652F20", VA = "0x180654520")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000693 RID: 1683
			// (get) Token: 0x0600323E RID: 12862 RVA: 0x000125D0 File Offset: 0x000107D0
			// (set) Token: 0x0600323F RID: 12863 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000693")]
			public int CurrentBondExp
			{
				[Token(Token = "0x600323E")]
				[Address(RVA = "0x51B080", Offset = "0x519A80", VA = "0x18051B080")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x600323F")]
				[Address(RVA = "0x654500", Offset = "0x652F00", VA = "0x180654500")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000694 RID: 1684
			// (get) Token: 0x06003240 RID: 12864 RVA: 0x000125E8 File Offset: 0x000107E8
			// (set) Token: 0x06003241 RID: 12865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000694")]
			public int CurrentBondLevel
			{
				[Token(Token = "0x6003240")]
				[Address(RVA = "0x654210", Offset = "0x652C10", VA = "0x180654210")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6003241")]
				[Address(RVA = "0x654510", Offset = "0x652F10", VA = "0x180654510")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000695 RID: 1685
			// (get) Token: 0x06003242 RID: 12866 RVA: 0x00012600 File Offset: 0x00010800
			// (set) Token: 0x06003243 RID: 12867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000695")]
			public bool DoNotShowInNight
			{
				[Token(Token = "0x6003242")]
				[Address(RVA = "0x654220", Offset = "0x652C20", VA = "0x180654220")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6003243")]
				[Address(RVA = "0x654530", Offset = "0x652F30", VA = "0x180654530")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000696 RID: 1686
			// (get) Token: 0x06003244 RID: 12868 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000696")]
			public List<int> IzakayaWhereCanSpawn
			{
				[Token(Token = "0x6003244")]
				[Address(RVA = "0x654230", Offset = "0x652C30", VA = "0x180654230")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000697 RID: 1687
			// (get) Token: 0x06003245 RID: 12869 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000697")]
			public List<int> RevealedFoodTags
			{
				[Token(Token = "0x6003245")]
				[Address(RVA = "0x654350", Offset = "0x652D50", VA = "0x180654350")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000698 RID: 1688
			// (get) Token: 0x06003246 RID: 12870 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000698")]
			public List<int> RevealedHateFoodTags
			{
				[Token(Token = "0x6003246")]
				[Address(RVA = "0x6543E0", Offset = "0x652DE0", VA = "0x1806543E0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000699 RID: 1689
			// (get) Token: 0x06003247 RID: 12871 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000699")]
			public List<int> RevealedBevTags
			{
				[Token(Token = "0x6003247")]
				[Address(RVA = "0x6542C0", Offset = "0x652CC0", VA = "0x1806542C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700069A RID: 1690
			// (get) Token: 0x06003248 RID: 12872 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700069A")]
			public List<int> RevealedIzakaya
			{
				[Token(Token = "0x6003248")]
				[Address(RVA = "0x654470", Offset = "0x652E70", VA = "0x180654470")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700069B RID: 1691
			// (get) Token: 0x06003249 RID: 12873 RVA: 0x00012618 File Offset: 0x00010818
			// (set) Token: 0x0600324A RID: 12874 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700069B")]
			public int PositiveSCNum
			{
				[Token(Token = "0x6003249")]
				[Address(RVA = "0x4D2200", Offset = "0x4D0C00", VA = "0x1804D2200")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x600324A")]
				[Address(RVA = "0x654540", Offset = "0x652F40", VA = "0x180654540")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700069C RID: 1692
			// (get) Token: 0x0600324B RID: 12875 RVA: 0x00012630 File Offset: 0x00010830
			// (set) Token: 0x0600324C RID: 12876 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700069C")]
			public int NegativeSCNum
			{
				[Token(Token = "0x600324B")]
				[Address(RVA = "0x48A760", Offset = "0x489160", VA = "0x18048A760")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x600324C")]
				[Address(RVA = "0x51B140", Offset = "0x519B40", VA = "0x18051B140")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x04002C89 RID: 11401
			[Token(Token = "0x4002C89")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private List<int> izakayaWhereCanSpawn;

			// Token: 0x04002C8A RID: 11402
			[Token(Token = "0x4002C8A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private List<int> revealedBevTags;

			// Token: 0x04002C8B RID: 11403
			[Token(Token = "0x4002C8B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private List<int> revealedFoodTags;

			// Token: 0x04002C8C RID: 11404
			[Token(Token = "0x4002C8C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<int> revealedHateFoodTags;

			// Token: 0x04002C8D RID: 11405
			[Token(Token = "0x4002C8D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<int> revealedIzakaya;
		}

		// Token: 0x02000827 RID: 2087
		[Token(Token = "0x2000827")]
		[JsonObject(MemberSerialization.OptIn)]
		public class RuntimePlayerSkinDataCache
		{
			// Token: 0x1700069D RID: 1693
			// (get) Token: 0x0600324D RID: 12877 RVA: 0x00012648 File Offset: 0x00010848
			[Token(Token = "0x1700069D")]
			public int ClothesId
			{
				[Token(Token = "0x600324D")]
				[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700069E RID: 1694
			// (get) Token: 0x0600324E RID: 12878 RVA: 0x00012660 File Offset: 0x00010860
			[Token(Token = "0x1700069E")]
			public bool UseCurrentSkinAtNight
			{
				[Token(Token = "0x600324E")]
				[Address(RVA = "0x653EC0", Offset = "0x6528C0", VA = "0x180653EC0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700069F RID: 1695
			// (get) Token: 0x0600324F RID: 12879 RVA: 0x00012678 File Offset: 0x00010878
			[Token(Token = "0x1700069F")]
			public bool UseSpecialShopSkinAtNight
			{
				[Token(Token = "0x600324F")]
				[Address(RVA = "0x653ED0", Offset = "0x6528D0", VA = "0x180653ED0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06003250 RID: 12880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003250")]
			[Address(RVA = "0x653E70", Offset = "0x652870", VA = "0x180653E70")]
			public RuntimePlayerSkinDataCache(int clothesId, bool useCurrentSkinAtNight, bool useSpecialShopSkinAtNight)
			{
			}

			// Token: 0x04002C95 RID: 11413
			[Token(Token = "0x4002C95")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[JsonProperty("ClothesId")]
			private int m_ClothesId;

			// Token: 0x04002C96 RID: 11414
			[Token(Token = "0x4002C96")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[JsonProperty("UseCurrentSkinAtNight")]
			private bool m_UseCurrentSkinAtNight;

			// Token: 0x04002C97 RID: 11415
			[Token(Token = "0x4002C97")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[JsonProperty("UseSpecialShopSkinAtNight")]
			private bool m_UseSpecialShopSkinAtNight;
		}

		// Token: 0x02000828 RID: 2088
		[Token(Token = "0x2000828")]
		[JsonObject(MemberSerialization.OptIn)]
		public class RuntimeAlbumCache : IDeepClonable<RunTimeAlbum.RuntimeAlbumCache>
		{
			// Token: 0x170006A0 RID: 1696
			// (get) Token: 0x06003251 RID: 12881 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A0")]
			public IEnumerable<int> CachedFoods
			{
				[Token(Token = "0x6003251")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006A1 RID: 1697
			// (get) Token: 0x06003252 RID: 12882 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A1")]
			public IEnumerable<int> CachedBeverages
			{
				[Token(Token = "0x6003252")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006A2 RID: 1698
			// (get) Token: 0x06003253 RID: 12883 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A2")]
			public IEnumerable<int> CachedIngredients
			{
				[Token(Token = "0x6003253")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006A3 RID: 1699
			// (get) Token: 0x06003254 RID: 12884 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A3")]
			public IEnumerable<int> CachedCookers
			{
				[Token(Token = "0x6003254")]
				[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006A4 RID: 1700
			// (get) Token: 0x06003255 RID: 12885 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A4")]
			public IEnumerable<int> CachedItems
			{
				[Token(Token = "0x6003255")]
				[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006A5 RID: 1701
			// (get) Token: 0x06003256 RID: 12886 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A5")]
			public IEnumerable<int> CachedUsedDecorations
			{
				[Token(Token = "0x6003256")]
				[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006A6 RID: 1702
			// (get) Token: 0x06003257 RID: 12887 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A6")]
			public IEnumerable<int> CachedNormalGuests
			{
				[Token(Token = "0x6003257")]
				[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006A7 RID: 1703
			// (get) Token: 0x06003258 RID: 12888 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A7")]
			public IEnumerable<int> CachedEffectiveSGuestMappingRules
			{
				[Token(Token = "0x6003258")]
				[Address(RVA = "0x440290", Offset = "0x43EC90", VA = "0x180440290")]
				get
				{
					return null;
				}
			}

			// Token: 0x170006A8 RID: 1704
			// (get) Token: 0x06003259 RID: 12889 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006A8")]
			public Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> CachedRecordedSpecialNPCs
			{
				[Token(Token = "0x6003259")]
				[Address(RVA = "0x653E30", Offset = "0x652830", VA = "0x180653E30")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600325A RID: 12890 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600325A")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			public RuntimeAlbumCache()
			{
			}

			// Token: 0x0600325B RID: 12891 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600325B")]
			[Address(RVA = "0x653CD0", Offset = "0x6526D0", VA = "0x180653CD0")]
			[JsonConstructor]
			public RuntimeAlbumCache(int[] foods, int[] beverages, int[] ingredients, int[] cookers, int[] items, int[] usedDecorations, int[] normalGuests, int[] effectiveSGuestMappingRules, Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> recordedSpecialNPCs)
			{
			}

			// Token: 0x0600325C RID: 12892 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600325C")]
			[Address(RVA = "0x653B40", Offset = "0x652540", VA = "0x180653B40", Slot = "4")]
			public RunTimeAlbum.RuntimeAlbumCache Clone()
			{
				return null;
			}

			// Token: 0x04002C98 RID: 11416
			[Token(Token = "0x4002C98")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[JsonProperty("Foods")]
			private readonly int[] m_Foods;

			// Token: 0x04002C99 RID: 11417
			[Token(Token = "0x4002C99")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[JsonProperty("Beverages")]
			private readonly int[] m_Beverages;

			// Token: 0x04002C9A RID: 11418
			[Token(Token = "0x4002C9A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[JsonProperty("Ingredients")]
			private readonly int[] m_Ingredients;

			// Token: 0x04002C9B RID: 11419
			[Token(Token = "0x4002C9B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[JsonProperty("Cookers")]
			private readonly int[] m_Cookers;

			// Token: 0x04002C9C RID: 11420
			[Token(Token = "0x4002C9C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[JsonProperty("Items")]
			private readonly int[] m_Items;

			// Token: 0x04002C9D RID: 11421
			[Token(Token = "0x4002C9D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[JsonProperty("UsedDecorations")]
			private readonly int[] m_UsedDecorations;

			// Token: 0x04002C9E RID: 11422
			[Token(Token = "0x4002C9E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[JsonProperty("NormalGuests")]
			private readonly int[] m_NormalGuests;

			// Token: 0x04002C9F RID: 11423
			[Token(Token = "0x4002C9F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[JsonProperty("EffectiveSGuestMappingRules")]
			private readonly int[] m_EffectiveSGuestMappingRules;

			// Token: 0x04002CA0 RID: 11424
			[Token(Token = "0x4002CA0")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[JsonProperty("RecordedSpecialNPCs")]
			private static Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> m_RecordedSpecialNPCs;
		}
	}
}
