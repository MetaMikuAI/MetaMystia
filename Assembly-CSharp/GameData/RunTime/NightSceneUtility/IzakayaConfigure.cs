using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.Singletons;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.RunTime.NightSceneUtility
{
	// Token: 0x020007D9 RID: 2009
	[Token(Token = "0x20007D9")]
	public class IzakayaConfigure : Singleton<IzakayaConfigure>
	{
		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06002F13 RID: 12051 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F14 RID: 12052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000625")]
		public int[] SpecialGuestPoolIdentityData
		{
			[Token(Token = "0x6002F13")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F14")]
			[Address(RVA = "0x3FC090", Offset = "0x3FAA90", VA = "0x1803FC090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06002F15 RID: 12053 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F16 RID: 12054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000626")]
		public Izakaya IzakayaData
		{
			[Token(Token = "0x6002F15")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F16")]
			[Address(RVA = "0x3F2100", Offset = "0x3F0B00", VA = "0x1803F2100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06002F17 RID: 12055 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F18 RID: 12056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000627")]
		public int[] CookerConfigure
		{
			[Token(Token = "0x6002F17")]
			[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F18")]
			[Address(RVA = "0x47DD00", Offset = "0x47C700", VA = "0x18047DD00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06002F19 RID: 12057 RVA: 0x000111F0 File Offset: 0x0000F3F0
		[Token(Token = "0x17000628")]
		public int EmptyRecipeSlotCount
		{
			[Token(Token = "0x6002F19")]
			[Address(RVA = "0x6084B0", Offset = "0x606EB0", VA = "0x1806084B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002F1A RID: 12058 RVA: 0x00011208 File Offset: 0x0000F408
		[Token(Token = "0x17000629")]
		public int EmptyBeverageSlotCount
		{
			[Token(Token = "0x6002F1A")]
			[Address(RVA = "0x608360", Offset = "0x606D60", VA = "0x180608360")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002F1B RID: 12059 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F1C RID: 12060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062A")]
		public List<Recipe> DailyRecipes
		{
			[Token(Token = "0x6002F1B")]
			[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F1C")]
			[Address(RVA = "0x531450", Offset = "0x52FE50", VA = "0x180531450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002F1D RID: 12061 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F1E RID: 12062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062B")]
		public List<Sellable> DailyBeverages
		{
			[Token(Token = "0x6002F1D")]
			[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F1E")]
			[Address(RVA = "0x4AD3C0", Offset = "0x4ABDC0", VA = "0x1804AD3C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06002F1F RID: 12063 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F20 RID: 12064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062C")]
		public List<Recipe> PopNotHateRecipes
		{
			[Token(Token = "0x6002F1F")]
			[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F20")]
			[Address(RVA = "0x51B180", Offset = "0x519B80", VA = "0x18051B180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06002F21 RID: 12065 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F22 RID: 12066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062D")]
		public List<Sellable> PopNotHateBeverages
		{
			[Token(Token = "0x6002F21")]
			[Address(RVA = "0x440290", Offset = "0x43EC90", VA = "0x180440290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F22")]
			[Address(RVA = "0x6086D0", Offset = "0x6070D0", VA = "0x1806086D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x06002F23 RID: 12067 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F24 RID: 12068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062E")]
		public List<Recipe> CheapestRecipes
		{
			[Token(Token = "0x6002F23")]
			[Address(RVA = "0x440270", Offset = "0x43EC70", VA = "0x180440270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F24")]
			[Address(RVA = "0x51B160", Offset = "0x519B60", VA = "0x18051B160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06002F25 RID: 12069 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F26 RID: 12070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700062F")]
		public List<Sellable> CheapestBeverages
		{
			[Token(Token = "0x6002F25")]
			[Address(RVA = "0x477F80", Offset = "0x476980", VA = "0x180477F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F26")]
			[Address(RVA = "0x547AB0", Offset = "0x5464B0", VA = "0x180547AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06002F27 RID: 12071 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F28 RID: 12072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000630")]
		public List<Recipe> TheMostExpensiveRecipes
		{
			[Token(Token = "0x6002F27")]
			[Address(RVA = "0x48B8D0", Offset = "0x48A2D0", VA = "0x18048B8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F28")]
			[Address(RVA = "0x608700", Offset = "0x607100", VA = "0x180608700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06002F29 RID: 12073 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F2A RID: 12074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000631")]
		public List<Sellable> TheMostExpensiveBeverages
		{
			[Token(Token = "0x6002F29")]
			[Address(RVA = "0x440300", Offset = "0x43ED00", VA = "0x180440300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F2A")]
			[Address(RVA = "0x51AAD0", Offset = "0x5194D0", VA = "0x18051AAD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06002F2B RID: 12075 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F2C RID: 12076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000632")]
		private List<Sellable> StoredFoods
		{
			[Token(Token = "0x6002F2B")]
			[Address(RVA = "0x48A940", Offset = "0x489340", VA = "0x18048A940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F2C")]
			[Address(RVA = "0x493610", Offset = "0x492010", VA = "0x180493610")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06002F2D RID: 12077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000633")]
		public IEnumerable<KeyValuePair<Sellable, int>> BatchedStoredFoods
		{
			[Token(Token = "0x6002F2D")]
			[Address(RVA = "0x608070", Offset = "0x606A70", VA = "0x180608070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06002F2E RID: 12078 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F2F RID: 12079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000634")]
		public IEnumerable<NormalGuest>[] NormalGuestPool
		{
			[Token(Token = "0x6002F2E")]
			[Address(RVA = "0x440320", Offset = "0x43ED20", VA = "0x180440320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F2F")]
			[Address(RVA = "0x6086B0", Offset = "0x6070B0", VA = "0x1806086B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06002F30 RID: 12080 RVA: 0x00011220 File Offset: 0x0000F420
		// (set) Token: 0x06002F31 RID: 12081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000635")]
		public Vector2 NormalGuestInterval
		{
			[Token(Token = "0x6002F30")]
			[Address(RVA = "0x608600", Offset = "0x607000", VA = "0x180608600")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002F31")]
			[Address(RVA = "0x4BE660", Offset = "0x4BD060", VA = "0x1804BE660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06002F32 RID: 12082 RVA: 0x00011238 File Offset: 0x0000F438
		// (set) Token: 0x06002F33 RID: 12083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000636")]
		public bool SpawnPasserbyGuest
		{
			[Token(Token = "0x6002F32")]
			[Address(RVA = "0x608690", Offset = "0x607090", VA = "0x180608690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002F33")]
			[Address(RVA = "0x6086E0", Offset = "0x6070E0", VA = "0x1806086E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06002F34 RID: 12084 RVA: 0x00011250 File Offset: 0x0000F450
		// (set) Token: 0x06002F35 RID: 12085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000637")]
		public Vector2 PasserbyGuestSpanInterval
		{
			[Token(Token = "0x6002F34")]
			[Address(RVA = "0x608620", Offset = "0x607020", VA = "0x180608620")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6002F35")]
			[Address(RVA = "0x6086C0", Offset = "0x6070C0", VA = "0x1806086C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06002F36 RID: 12086 RVA: 0x00011268 File Offset: 0x0000F468
		// (set) Token: 0x06002F37 RID: 12087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000638")]
		public Vector2Int BaseRange
		{
			[Token(Token = "0x6002F36")]
			[Address(RVA = "0x608060", Offset = "0x606A60", VA = "0x180608060")]
			[CompilerGenerated]
			get
			{
				return default(Vector2Int);
			}
			[Token(Token = "0x6002F37")]
			[Address(RVA = "0x6086A0", Offset = "0x6070A0", VA = "0x1806086A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06002F38 RID: 12088 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F39 RID: 12089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000639")]
		public GameObject Map
		{
			[Token(Token = "0x6002F38")]
			[Address(RVA = "0x426F70", Offset = "0x425970", VA = "0x180426F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F39")]
			[Address(RVA = "0x52F180", Offset = "0x52DB80", VA = "0x18052F180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06002F3A RID: 12090 RVA: 0x00011280 File Offset: 0x0000F480
		// (set) Token: 0x06002F3B RID: 12091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700063A")]
		public float SpecialGuestGachaInterval
		{
			[Token(Token = "0x6002F3A")]
			[Address(RVA = "0x440550", Offset = "0x43EF50", VA = "0x180440550")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6002F3B")]
			[Address(RVA = "0x6086F0", Offset = "0x6070F0", VA = "0x1806086F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06002F3C RID: 12092 RVA: 0x00011298 File Offset: 0x0000F498
		[Token(Token = "0x1700063B")]
		public bool CanGacha
		{
			[Token(Token = "0x6002F3C")]
			[Address(RVA = "0x6082B0", Offset = "0x606CB0", VA = "0x1806082B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06002F3D RID: 12093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063C")]
		public IEnumerable<int> RemainingGuestPool
		{
			[Token(Token = "0x6002F3D")]
			[Address(RVA = "0x608640", Offset = "0x607040", VA = "0x180608640")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F3E")]
		[Address(RVA = "0x607E20", Offset = "0x606820", VA = "0x180607E20")]
		public void UpdateValue(Vector2Int baseFundRange, Vector2 normalGuestInterval, IEnumerable<Izakaya.NormalGuestGroup> normalGuestsPool, float specialGuestGachaInterval, IEnumerable<Izakaya.SpecialGuestGroup> thisSpecialGuestPool)
		{
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F3F")]
		[Address(RVA = "0x6067D0", Offset = "0x6051D0", VA = "0x1806067D0", Slot = "4")]
		protected override void OnDispose()
		{
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F40")]
		[Address(RVA = "0x605BA0", Offset = "0x6045A0", VA = "0x180605BA0")]
		public void Initialize(Izakaya info, GameObject map)
		{
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F41")]
		[Address(RVA = "0x6063D0", Offset = "0x604DD0", VA = "0x1806063D0")]
		public void LoadLockedMissionRecipes()
		{
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F42")]
		[Address(RVA = "0x604FE0", Offset = "0x6039E0", VA = "0x180604FE0")]
		private void CalculateSpecialGuestPool(string daySceneMapLabel, IEnumerable<Izakaya.SpecialGuestGroup> specialGuestGroups)
		{
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F43")]
		[Address(RVA = "0x48A940", Offset = "0x489340", VA = "0x18048A940")]
		public IEnumerable<Sellable> GetStoredFoods()
		{
			return null;
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x06002F44 RID: 12100 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F45 RID: 12101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700063D")]
		public Action ExtraStoreFoodCallback
		{
			[Token(Token = "0x6002F44")]
			[Address(RVA = "0x428D60", Offset = "0x427760", VA = "0x180428D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F45")]
			[Address(RVA = "0x4D2530", Offset = "0x4D0F30", VA = "0x1804D2530")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06002F46 RID: 12102 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F47 RID: 12103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700063E")]
		public Action ExtraAbandonFoodCallback
		{
			[Token(Token = "0x6002F46")]
			[Address(RVA = "0x48A8D0", Offset = "0x4892D0", VA = "0x18048A8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F47")]
			[Address(RVA = "0x48AC50", Offset = "0x489650", VA = "0x18048AC50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06002F48 RID: 12104 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F49 RID: 12105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700063F")]
		public Action ExtraRemoveStoredFoodCallback
		{
			[Token(Token = "0x6002F48")]
			[Address(RVA = "0x48A680", Offset = "0x489080", VA = "0x18048A680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F49")]
			[Address(RVA = "0x4D24D0", Offset = "0x4D0ED0", VA = "0x1804D24D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F4A")]
		[Address(RVA = "0x607BE0", Offset = "0x6065E0", VA = "0x180607BE0")]
		public void StoreFood(Sellable sellable, int messageSender = -1)
		{
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F4B")]
		[Address(RVA = "0x607AB0", Offset = "0x6064B0", VA = "0x180607AB0")]
		public void RemoveStoredFood(Sellable sellable, int messageSender = -1)
		{
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F4C")]
		[Address(RVA = "0x606B00", Offset = "0x605500", VA = "0x180606B00")]
		public void PreCalculateRecipes()
		{
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F4D")]
		[Address(RVA = "0x606860", Offset = "0x605260", VA = "0x180606860")]
		public void OverrideCookers(int[] newCookers)
		{
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F4E")]
		[Address(RVA = "0x606930", Offset = "0x605330", VA = "0x180606930")]
		public void OverrideRecipes(int[] newRecipes)
		{
		}

		// Token: 0x06002F4F RID: 12111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F4F")]
		[Address(RVA = "0x607400", Offset = "0x605E00", VA = "0x180607400")]
		public void RecordIzakayaMenuSelection(PlayerSaveFile.HistoryIzakayaMenuSelection historyMenuSelection)
		{
		}

		// Token: 0x06002F50 RID: 12112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F50")]
		[Address(RVA = "0x607940", Offset = "0x606340", VA = "0x180607940")]
		public void RegisterToDailyRecipes(int id, bool checkPlayerStorage)
		{
		}

		// Token: 0x06002F51 RID: 12113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F51")]
		[Address(RVA = "0x606640", Offset = "0x605040", VA = "0x180606640")]
		public void LogoffFromDailyRecipes(int id)
		{
		}

		// Token: 0x06002F52 RID: 12114 RVA: 0x000112B0 File Offset: 0x0000F4B0
		[Token(Token = "0x6002F52")]
		[Address(RVA = "0x6062D0", Offset = "0x604CD0", VA = "0x1806062D0")]
		public bool IsDailyRecipeFood(Sellable food)
		{
			return default(bool);
		}

		// Token: 0x06002F53 RID: 12115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F53")]
		[Address(RVA = "0x6077D0", Offset = "0x6061D0", VA = "0x1806077D0")]
		public void RegisterToDailyBeverages(int id, bool checkPlayerStorage)
		{
		}

		// Token: 0x06002F54 RID: 12116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F54")]
		[Address(RVA = "0x606510", Offset = "0x604F10", VA = "0x180606510")]
		public void LogoffFromDailyBeverages(int id)
		{
		}

		// Token: 0x06002F55 RID: 12117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F55")]
		[Address(RVA = "0x6076D0", Offset = "0x6060D0", VA = "0x1806076D0")]
		public void RegisterToCookers(int id, int index, bool checkPlayerHaveCooker)
		{
		}

		// Token: 0x06002F56 RID: 12118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F56")]
		[Address(RVA = "0x6064E0", Offset = "0x604EE0", VA = "0x1806064E0")]
		public void LogOffFromCookers(int index)
		{
		}

		// Token: 0x06002F57 RID: 12119 RVA: 0x000112C8 File Offset: 0x0000F4C8
		[Token(Token = "0x6002F57")]
		[Address(RVA = "0x605840", Offset = "0x604240", VA = "0x180605840")]
		public int Gacha()
		{
			return 0;
		}

		// Token: 0x06002F58 RID: 12120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F58")]
		[Address(RVA = "0x607B60", Offset = "0x606560", VA = "0x180607B60")]
		public void SetThisGuestHasSpawned(int id)
		{
		}

		// Token: 0x06002F59 RID: 12121 RVA: 0x000112E0 File Offset: 0x0000F4E0
		[Token(Token = "0x6002F59")]
		[Address(RVA = "0x6057E0", Offset = "0x6041E0", VA = "0x1806057E0")]
		public bool CheckThisGuestHasSpawnedTonight(int id)
		{
			return default(bool);
		}

		// Token: 0x06002F5A RID: 12122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F5A")]
		[Address(RVA = "0x607FC0", Offset = "0x6069C0", VA = "0x180607FC0")]
		public IzakayaConfigure()
		{
		}

		// Token: 0x04002A89 RID: 10889
		[Token(Token = "0x4002A89")]
		public const int DefaultRecipe = 0;

		// Token: 0x04002A8A RID: 10890
		[Token(Token = "0x4002A8A")]
		public const int DefaultBev = 0;

		// Token: 0x04002A8B RID: 10891
		[Token(Token = "0x4002A8B")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<int, Vector2> specialGuestPool;

		// Token: 0x04002A9F RID: 10911
		[Token(Token = "0x4002A9F")]
		[FieldOffset(Offset = "0xB0")]
		private readonly HashSet<int> m_HasSpawnedSpecialGuestTonight;
	}
}
