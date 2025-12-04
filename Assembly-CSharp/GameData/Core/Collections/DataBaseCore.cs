using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections
{
	// Token: 0x020008B6 RID: 2230
	[Token(Token = "0x20008B6")]
	public static class DataBaseCore
	{
		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060036D2 RID: 14034 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036D3 RID: 14035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700072A")]
		private static Dictionary<string, GameObject> DLCMarker
		{
			[Token(Token = "0x60036D2")]
			[Address(RVA = "0x6644D0", Offset = "0x662ED0", VA = "0x1806644D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036D3")]
			[Address(RVA = "0x664C30", Offset = "0x663630", VA = "0x180664C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060036D4 RID: 14036 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036D5 RID: 14037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700072B")]
		private static Dictionary<int, Ingredient> Ingredients
		{
			[Token(Token = "0x60036D4")]
			[Address(RVA = "0x664610", Offset = "0x663010", VA = "0x180664610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036D5")]
			[Address(RVA = "0x664E10", Offset = "0x663810", VA = "0x180664E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060036D6 RID: 14038 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036D7 RID: 14039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700072C")]
		private static Dictionary<int, Sellable> Beverages
		{
			[Token(Token = "0x60036D6")]
			[Address(RVA = "0x664350", Offset = "0x662D50", VA = "0x180664350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036D7")]
			[Address(RVA = "0x6649F0", Offset = "0x6633F0", VA = "0x1806649F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x060036D8 RID: 14040 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036D9 RID: 14041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700072D")]
		private static Dictionary<int, Sellable> Foods
		{
			[Token(Token = "0x60036D8")]
			[Address(RVA = "0x664590", Offset = "0x662F90", VA = "0x180664590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036D9")]
			[Address(RVA = "0x664D50", Offset = "0x663750", VA = "0x180664D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x060036DA RID: 14042 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036DB RID: 14043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700072E")]
		private static Dictionary<int, Recipe> Recipes
		{
			[Token(Token = "0x60036DA")]
			[Address(RVA = "0x664790", Offset = "0x663190", VA = "0x180664790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036DB")]
			[Address(RVA = "0x665050", Offset = "0x663A50", VA = "0x180665050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060036DC RID: 14044 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036DD RID: 14045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700072F")]
		private static Dictionary<int, Cooker> Cookers
		{
			[Token(Token = "0x60036DC")]
			[Address(RVA = "0x664490", Offset = "0x662E90", VA = "0x180664490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036DD")]
			[Address(RVA = "0x664BD0", Offset = "0x6635D0", VA = "0x180664BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060036DE RID: 14046 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036DF RID: 14047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000730")]
		private static Dictionary<int, Izakaya> Izakayas
		{
			[Token(Token = "0x60036DE")]
			[Address(RVA = "0x664710", Offset = "0x663110", VA = "0x180664710")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036DF")]
			[Address(RVA = "0x664F90", Offset = "0x663990", VA = "0x180664F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060036E0 RID: 14048 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036E1 RID: 14049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000731")]
		private static Dictionary<int, Item> Items
		{
			[Token(Token = "0x60036E0")]
			[Address(RVA = "0x664690", Offset = "0x663090", VA = "0x180664690")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036E1")]
			[Address(RVA = "0x664ED0", Offset = "0x6638D0", VA = "0x180664ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060036E2 RID: 14050 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036E3 RID: 14051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000732")]
		private static Dictionary<int, Badge> Badges
		{
			[Token(Token = "0x60036E2")]
			[Address(RVA = "0x6642D0", Offset = "0x662CD0", VA = "0x1806642D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036E3")]
			[Address(RVA = "0x664930", Offset = "0x663330", VA = "0x180664930")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060036E4 RID: 14052 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036E5 RID: 14053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000733")]
		private static Dictionary<int, ClothesProfile.Clothes> Clothes
		{
			[Token(Token = "0x60036E4")]
			[Address(RVA = "0x6643D0", Offset = "0x662DD0", VA = "0x1806643D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036E5")]
			[Address(RVA = "0x664AB0", Offset = "0x6634B0", VA = "0x180664AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060036E6 RID: 14054 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036E7 RID: 14055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000734")]
		private static Dictionary<int, Decoration> Decorations
		{
			[Token(Token = "0x60036E6")]
			[Address(RVA = "0x664510", Offset = "0x662F10", VA = "0x180664510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036E7")]
			[Address(RVA = "0x664C90", Offset = "0x663690", VA = "0x180664C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060036E8 RID: 14056 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036E9 RID: 14057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000735")]
		private static Dictionary<int, Record> RecordId
		{
			[Token(Token = "0x60036E8")]
			[Address(RVA = "0x6647D0", Offset = "0x6631D0", VA = "0x1806647D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036E9")]
			[Address(RVA = "0x6650B0", Offset = "0x663AB0", VA = "0x1806650B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060036EA RID: 14058 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036EB RID: 14059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000736")]
		private static Dictionary<int, TrophiesProfile.Trophy> Trophies
		{
			[Token(Token = "0x60036EA")]
			[Address(RVA = "0x664850", Offset = "0x663250", VA = "0x180664850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036EB")]
			[Address(RVA = "0x665170", Offset = "0x663B70", VA = "0x180665170")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060036EC RID: 14060 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036ED RID: 14061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000737")]
		private static Dictionary<int, int[]> TagRules
		{
			[Token(Token = "0x60036EC")]
			[Address(RVA = "0x664810", Offset = "0x663210", VA = "0x180664810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036ED")]
			[Address(RVA = "0x665110", Offset = "0x663B10", VA = "0x180665110")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x060036EE RID: 14062 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036EF RID: 14063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000738")]
		private static Dictionary<int, DataBaseCore.LevelProperties> CharacterLevelProfile
		{
			[Token(Token = "0x60036EE")]
			[Address(RVA = "0x664390", Offset = "0x662D90", VA = "0x180664390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036EF")]
			[Address(RVA = "0x664A50", Offset = "0x663450", VA = "0x180664A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060036F0 RID: 14064 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036F1 RID: 14065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000739")]
		private static Dictionary<string, CollabPackage> CollabPackages
		{
			[Token(Token = "0x60036F0")]
			[Address(RVA = "0x664410", Offset = "0x662E10", VA = "0x180664410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036F1")]
			[Address(RVA = "0x664B10", Offset = "0x663510", VA = "0x180664B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060036F2 RID: 14066 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036F3 RID: 14067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700073A")]
		private static Dictionary<int, string> IngredientsMapping
		{
			[Token(Token = "0x60036F2")]
			[Address(RVA = "0x6645D0", Offset = "0x662FD0", VA = "0x1806645D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036F3")]
			[Address(RVA = "0x664DB0", Offset = "0x6637B0", VA = "0x180664DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060036F4 RID: 14068 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036F5 RID: 14069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700073B")]
		private static Dictionary<int, string> BeveragesMapping
		{
			[Token(Token = "0x60036F4")]
			[Address(RVA = "0x664310", Offset = "0x662D10", VA = "0x180664310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036F5")]
			[Address(RVA = "0x664990", Offset = "0x663390", VA = "0x180664990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060036F6 RID: 14070 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036F7 RID: 14071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700073C")]
		private static Dictionary<int, string> FoodsMapping
		{
			[Token(Token = "0x60036F6")]
			[Address(RVA = "0x664550", Offset = "0x662F50", VA = "0x180664550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036F7")]
			[Address(RVA = "0x664CF0", Offset = "0x6636F0", VA = "0x180664CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060036F8 RID: 14072 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036F9 RID: 14073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700073D")]
		private static Dictionary<int, string> RecipesMapping
		{
			[Token(Token = "0x60036F8")]
			[Address(RVA = "0x664750", Offset = "0x663150", VA = "0x180664750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036F9")]
			[Address(RVA = "0x664FF0", Offset = "0x6639F0", VA = "0x180664FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060036FA RID: 14074 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036FB RID: 14075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700073E")]
		private static Dictionary<int, string> CookersMapping
		{
			[Token(Token = "0x60036FA")]
			[Address(RVA = "0x664450", Offset = "0x662E50", VA = "0x180664450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036FB")]
			[Address(RVA = "0x664B70", Offset = "0x663570", VA = "0x180664B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060036FC RID: 14076 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036FD RID: 14077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700073F")]
		private static Dictionary<int, string> IzakayasMapping
		{
			[Token(Token = "0x60036FC")]
			[Address(RVA = "0x6646D0", Offset = "0x6630D0", VA = "0x1806646D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036FD")]
			[Address(RVA = "0x664F30", Offset = "0x663930", VA = "0x180664F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060036FE RID: 14078 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060036FF RID: 14079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000740")]
		private static Dictionary<int, string> ItemsMapping
		{
			[Token(Token = "0x60036FE")]
			[Address(RVA = "0x664650", Offset = "0x663050", VA = "0x180664650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036FF")]
			[Address(RVA = "0x664E70", Offset = "0x663870", VA = "0x180664E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06003700 RID: 14080 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003701 RID: 14081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000741")]
		private static Dictionary<int, string> BadgesMapping
		{
			[Token(Token = "0x6003700")]
			[Address(RVA = "0x664290", Offset = "0x662C90", VA = "0x180664290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003701")]
			[Address(RVA = "0x6648D0", Offset = "0x6632D0", VA = "0x1806648D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06003702 RID: 14082 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003703 RID: 14083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000742")]
		private static Dictionary<int, string> TrophyMapping
		{
			[Token(Token = "0x6003702")]
			[Address(RVA = "0x664890", Offset = "0x663290", VA = "0x180664890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003703")]
			[Address(RVA = "0x6651D0", Offset = "0x663BD0", VA = "0x1806651D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003704")]
		[Address(RVA = "0x65FEA0", Offset = "0x65E8A0", VA = "0x18065FEA0")]
		public static string GetIngredientsDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003705")]
		[Address(RVA = "0x65FC40", Offset = "0x65E640", VA = "0x18065FC40")]
		public static string GetBeveragesDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003706")]
		[Address(RVA = "0x65FDB0", Offset = "0x65E7B0", VA = "0x18065FDB0")]
		public static string GetFoodsDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003707")]
		[Address(RVA = "0x6605F0", Offset = "0x65EFF0", VA = "0x1806605F0")]
		public static string GetRecipesDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003708")]
		[Address(RVA = "0x65FD30", Offset = "0x65E730", VA = "0x18065FD30")]
		public static string GetCookersDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003709")]
		[Address(RVA = "0x660130", Offset = "0x65EB30", VA = "0x180660130")]
		public static string GetIzakayasDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600370A")]
		[Address(RVA = "0x6600B0", Offset = "0x65EAB0", VA = "0x1806600B0")]
		public static string GetItemsDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600370B")]
		[Address(RVA = "0x65FBC0", Offset = "0x65E5C0", VA = "0x18065FBC0")]
		public static string GetBadgesDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600370C")]
		[Address(RVA = "0x660670", Offset = "0x65F070", VA = "0x180660670")]
		public static string GetTrophyDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370D")]
		[Address(RVA = "0x660760", Offset = "0x65F160", VA = "0x180660760")]
		public static void InitializeDLCMarker(Dictionary<string, GameObject> dlcMarker)
		{
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370E")]
		[Address(RVA = "0x6607C0", Offset = "0x65F1C0", VA = "0x1806607C0")]
		public static void Initialize(Dictionary<string, DataBaseCore.DataBaseCoreData> coreData, Dictionary<int, DataBaseCore.LevelProperties> levelProfileData, Dictionary<string, CollabPackage> collabPackages, Dictionary<int, ClothesProfile.Clothes> clothes, Dictionary<int, Decoration> decorations, Dictionary<int, Record> records)
		{
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600370F")]
		[Address(RVA = "0x65F370", Offset = "0x65DD70", VA = "0x18065F370")]
		public static IEnumerable<int> GetAllIngredients()
		{
			return null;
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003710")]
		[Address(RVA = "0x65F180", Offset = "0x65DB80", VA = "0x18065F180")]
		public static IEnumerable<int> GetAllEffectiveIngredients()
		{
			return null;
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003711")]
		[Address(RVA = "0x65EE80", Offset = "0x65D880", VA = "0x18065EE80")]
		public static IEnumerable<int> GetAllEffectiveAndNotIgnoredIngredients()
		{
			return null;
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003712")]
		[Address(RVA = "0x65F000", Offset = "0x65DA00", VA = "0x18065F000")]
		public static IEnumerable<int> GetAllEffectiveAndNotMissionIngredients()
		{
			return null;
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003713")]
		[Address(RVA = "0x65F300", Offset = "0x65DD00", VA = "0x18065F300")]
		public static IEnumerable<int> GetAllFoods()
		{
			return null;
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003714")]
		[Address(RVA = "0x65EB10", Offset = "0x65D510", VA = "0x18065EB10")]
		public static IEnumerable<int> GetAllBeverages()
		{
			return null;
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003715")]
		[Address(RVA = "0x65F830", Offset = "0x65E230", VA = "0x18065F830")]
		public static IEnumerable<int> GetAllRecipes()
		{
			return null;
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003716")]
		[Address(RVA = "0x65F640", Offset = "0x65E040", VA = "0x18065F640")]
		public static IEnumerable<Recipe> GetAllRecipeValues()
		{
			return null;
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003717")]
		[Address(RVA = "0x65F6B0", Offset = "0x65E0B0", VA = "0x18065F6B0")]
		public static IEnumerable<int> GetAllRecipesExceptDLCs()
		{
			return null;
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003718")]
		[Address(RVA = "0x65ECD0", Offset = "0x65D6D0", VA = "0x18065ECD0")]
		public static IEnumerable<int> GetAllCookers()
		{
			return null;
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003719")]
		[Address(RVA = "0x65F560", Offset = "0x65DF60", VA = "0x18065F560")]
		public static IEnumerable<int> GetAllItems()
		{
			return null;
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371A")]
		[Address(RVA = "0x65F3E0", Offset = "0x65DDE0", VA = "0x18065F3E0")]
		public static IEnumerable<int> GetAllItemsExceptDefaultClothes()
		{
			return null;
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371B")]
		[Address(RVA = "0x65EAA0", Offset = "0x65D4A0", VA = "0x18065EAA0")]
		public static IEnumerable<int> GetAllBadges()
		{
			return null;
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371C")]
		[Address(RVA = "0x65F5D0", Offset = "0x65DFD0", VA = "0x18065F5D0")]
		public static IEnumerable<int> GetAllIzakayas()
		{
			return null;
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371D")]
		[Address(RVA = "0x65EB80", Offset = "0x65D580", VA = "0x18065EB80")]
		public static IEnumerable<int> GetAllClothes()
		{
			return null;
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371E")]
		[Address(RVA = "0x65EDA0", Offset = "0x65D7A0", VA = "0x18065EDA0")]
		public static IEnumerable<int> GetAllDecorations()
		{
			return null;
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600371F")]
		[Address(RVA = "0x65F8A0", Offset = "0x65E2A0", VA = "0x18065F8A0")]
		public static IEnumerable<int> GetAllRecords()
		{
			return null;
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003720")]
		[Address(RVA = "0x65F980", Offset = "0x65E380", VA = "0x18065F980")]
		public static IEnumerable<int> GetAllTrophies()
		{
			return null;
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003721")]
		[Address(RVA = "0x65ED60", Offset = "0x65D760", VA = "0x18065ED60")]
		public static IEnumerable<KeyValuePair<string, GameObject>> GetAllDLCMarker()
		{
			return null;
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003722")]
		[Address(RVA = "0x663210", Offset = "0x661C10", VA = "0x180663210")]
		public static GameObject RefDLCMarker(this string dlcLabel)
		{
			return null;
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003723")]
		[Address(RVA = "0x6601B0", Offset = "0x65EBB0", VA = "0x1806601B0")]
		public static Dictionary<int, int> GetIzakayasMusicPackageRecordCount()
		{
			return null;
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003724")]
		[Address(RVA = "0x65E5B0", Offset = "0x65CFB0", VA = "0x18065E5B0")]
		public static Ingredient AsNewIngredient(this int ingredientID)
		{
			return null;
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003725")]
		[Address(RVA = "0x65E530", Offset = "0x65CF30", VA = "0x18065E530")]
		public static Sellable AsNewFood(this int foodId)
		{
			return null;
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003726")]
		[Address(RVA = "0x65E4B0", Offset = "0x65CEB0", VA = "0x18065E4B0")]
		public static Sellable AsNewBeverage(this int beverageId)
		{
			return null;
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003727")]
		[Address(RVA = "0x6633D0", Offset = "0x661DD0", VA = "0x1806633D0")]
		public static Ingredient RefIngredient(this int ingredientID)
		{
			return null;
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003728")]
		[Address(RVA = "0x663360", Offset = "0x661D60", VA = "0x180663360")]
		public static Sellable RefFood(this int foodId)
		{
			return null;
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003729")]
		[Address(RVA = "0x663040", Offset = "0x661A40", VA = "0x180663040")]
		public static Sellable RefBeverage(this int beverageId)
		{
			return null;
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372A")]
		[Address(RVA = "0x663520", Offset = "0x661F20", VA = "0x180663520")]
		public static Recipe RefRecipe(this int recipeId)
		{
			return null;
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372B")]
		[Address(RVA = "0x662D00", Offset = "0x661700", VA = "0x180662D00")]
		public static IEnumerable<Recipe> MatchRecipe(this int foodId)
		{
			return null;
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372C")]
		[Address(RVA = "0x662AF0", Offset = "0x6614F0", VA = "0x180662AF0")]
		public static Recipe MatchFirstRecipe(this int foodId)
		{
			return null;
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372D")]
		[Address(RVA = "0x6631A0", Offset = "0x661BA0", VA = "0x1806631A0")]
		public static Cooker RefCooker(this int cookerId)
		{
			return null;
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372E")]
		[Address(RVA = "0x6634B0", Offset = "0x661EB0", VA = "0x1806634B0")]
		public static Izakaya RefIzakaya(this int izakayaId)
		{
			return null;
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600372F")]
		[Address(RVA = "0x663440", Offset = "0x661E40", VA = "0x180663440")]
		public static Item RefItem(this int itemId)
		{
			return null;
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003730")]
		[Address(RVA = "0x662FD0", Offset = "0x6619D0", VA = "0x180662FD0")]
		public static Badge RefBadge(this int badgeId)
		{
			return null;
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003731")]
		[Address(RVA = "0x663120", Offset = "0x661B20", VA = "0x180663120")]
		public static CollabPackage RefCollab(this string collabLabel)
		{
			return null;
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003732")]
		[Address(RVA = "0x65EC60", Offset = "0x65D660", VA = "0x18065EC60")]
		public static IEnumerable<CollabPackage> GetAllCollabs()
		{
			return null;
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003733")]
		[Address(RVA = "0x6630B0", Offset = "0x661AB0", VA = "0x1806630B0")]
		public static ClothesProfile.Clothes RefClothes(this int clothesId)
		{
			return null;
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003734")]
		[Address(RVA = "0x6632F0", Offset = "0x661CF0", VA = "0x1806632F0")]
		public static Decoration RefDecorations(this int decorationId)
		{
			return null;
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003735")]
		[Address(RVA = "0x663590", Offset = "0x661F90", VA = "0x180663590")]
		public static Record RefRecords(this int recordId)
		{
			return null;
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003736")]
		[Address(RVA = "0x663600", Offset = "0x662000", VA = "0x180663600")]
		public static TrophiesProfile.Trophy RefTrophies(this int trophyId)
		{
			return null;
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x00014C40 File Offset: 0x00012E40
		[Token(Token = "0x6003737")]
		[Address(RVA = "0x662850", Offset = "0x661250", VA = "0x180662850")]
		public static bool IsClothes(this int clothesId)
		{
			return default(bool);
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x00014C58 File Offset: 0x00012E58
		[Token(Token = "0x6003738")]
		[Address(RVA = "0x6628C0", Offset = "0x6612C0", VA = "0x1806628C0")]
		public static bool IsDecoration(this int decorationId)
		{
			return default(bool);
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x00014C70 File Offset: 0x00012E70
		[Token(Token = "0x6003739")]
		[Address(RVA = "0x662930", Offset = "0x661330", VA = "0x180662930")]
		public static bool IsRecord(this int recordId)
		{
			return default(bool);
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x00014C88 File Offset: 0x00012E88
		[Token(Token = "0x600373A")]
		[Address(RVA = "0x6629A0", Offset = "0x6613A0", VA = "0x1806629A0")]
		public static bool IsTrophy(this int trophyId)
		{
			return default(bool);
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x00014CA0 File Offset: 0x00012EA0
		[Token(Token = "0x600373B")]
		[Address(RVA = "0x664120", Offset = "0x662B20", VA = "0x180664120")]
		public static bool TryMatchRecipe(Sellable foodData, out IEnumerable<Recipe> matchedRecipes)
		{
			return default(bool);
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600373C")]
		[Address(RVA = "0x65FF20", Offset = "0x65E920", VA = "0x18065FF20")]
		public static IEnumerable<Ingredient> GetIngredients()
		{
			return null;
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600373D")]
		[Address(RVA = "0x65FE30", Offset = "0x65E830", VA = "0x18065FE30")]
		public static IEnumerable<Sellable> GetFoods()
		{
			return null;
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600373E")]
		[Address(RVA = "0x65FCC0", Offset = "0x65E6C0", VA = "0x18065FCC0")]
		public static IEnumerable<Sellable> GetBevs()
		{
			return null;
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600373F")]
		[Address(RVA = "0x65E8E0", Offset = "0x65D2E0", VA = "0x18065E8E0")]
		public static Recipe[] FindUnObtainedRecipes(Recipe[] obtained, IEnumerable<Cooker.CookerType> cookerType)
		{
			return null;
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003740")]
		[Address(RVA = "0x663670", Offset = "0x662070", VA = "0x180663670")]
		public static int[] SolveTagPriority(IEnumerable<int> rawTags, Dictionary<int, int[]> tagRules, out int[] weakTags)
		{
			return null;
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003741")]
		[Address(RVA = "0x663FE0", Offset = "0x6629E0", VA = "0x180663FE0")]
		public static int[] SolveTagPriority(IEnumerable<int> rawTags, out int[] weakTags)
		{
			return null;
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x00014CB8 File Offset: 0x00012EB8
		[Token(Token = "0x6003742")]
		[Address(RVA = "0x6604F0", Offset = "0x65EEF0", VA = "0x1806604F0")]
		public static DataBaseCore.LevelProperties GetLevelProfile(int level)
		{
			return default(DataBaseCore.LevelProperties);
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x00014CD0 File Offset: 0x00012ED0
		[Token(Token = "0x6003743")]
		[Address(RVA = "0x65E710", Offset = "0x65D110", VA = "0x18065E710")]
		public static bool CheckHasNextLevel(int level)
		{
			return default(bool);
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x00014CE8 File Offset: 0x00012EE8
		[Token(Token = "0x6003744")]
		[Address(RVA = "0x6606F0", Offset = "0x65F0F0", VA = "0x1806606F0")]
		public static bool IngredientsExists(int id)
		{
			return default(bool);
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x00014D00 File Offset: 0x00012F00
		[Token(Token = "0x6003745")]
		[Address(RVA = "0x65E6A0", Offset = "0x65D0A0", VA = "0x18065E6A0")]
		public static bool BeveragesExists(int id)
		{
			return default(bool);
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x00014D18 File Offset: 0x00012F18
		[Token(Token = "0x6003746")]
		[Address(RVA = "0x65EA30", Offset = "0x65D430", VA = "0x18065EA30")]
		public static bool FoodsExists(int id)
		{
			return default(bool);
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x00014D30 File Offset: 0x00012F30
		[Token(Token = "0x6003747")]
		[Address(RVA = "0x662EF0", Offset = "0x6618F0", VA = "0x180662EF0")]
		public static bool RecipesExists(int id)
		{
			return default(bool);
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x00014D48 File Offset: 0x00012F48
		[Token(Token = "0x6003748")]
		[Address(RVA = "0x65E800", Offset = "0x65D200", VA = "0x18065E800")]
		public static bool CookersExists(int id)
		{
			return default(bool);
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x00014D60 File Offset: 0x00012F60
		[Token(Token = "0x6003749")]
		[Address(RVA = "0x662A80", Offset = "0x661480", VA = "0x180662A80")]
		public static bool IzakayasExists(int id)
		{
			return default(bool);
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x00014D78 File Offset: 0x00012F78
		[Token(Token = "0x600374A")]
		[Address(RVA = "0x662A10", Offset = "0x661410", VA = "0x180662A10")]
		public static bool ItemsExists(int id)
		{
			return default(bool);
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x00014D90 File Offset: 0x00012F90
		[Token(Token = "0x600374B")]
		[Address(RVA = "0x65E630", Offset = "0x65D030", VA = "0x18065E630")]
		public static bool BadgesExists(int id)
		{
			return default(bool);
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x00014DA8 File Offset: 0x00012FA8
		[Token(Token = "0x600374C")]
		[Address(RVA = "0x65E790", Offset = "0x65D190", VA = "0x18065E790")]
		public static bool ClothesExists(int id)
		{
			return default(bool);
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x00014DC0 File Offset: 0x00012FC0
		[Token(Token = "0x600374D")]
		[Address(RVA = "0x65E870", Offset = "0x65D270", VA = "0x18065E870")]
		public static bool DecorationsExists(int id)
		{
			return default(bool);
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x00014DD8 File Offset: 0x00012FD8
		[Token(Token = "0x600374E")]
		[Address(RVA = "0x662F60", Offset = "0x661960", VA = "0x180662F60")]
		public static bool RecordIdExists(int id)
		{
			return default(bool);
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x00014DF0 File Offset: 0x00012FF0
		[Token(Token = "0x600374F")]
		[Address(RVA = "0x6640B0", Offset = "0x662AB0", VA = "0x1806640B0")]
		public static bool TrophyIdExists(int id)
		{
			return default(bool);
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x00014E08 File Offset: 0x00013008
		[Token(Token = "0x6003750")]
		[Address(RVA = "0x664040", Offset = "0x662A40", VA = "0x180664040")]
		public static bool TagRulesExists(int id)
		{
			return default(bool);
		}

		// Token: 0x020008B7 RID: 2231
		[Token(Token = "0x20008B7")]
		public class DataBaseCoreData
		{
			// Token: 0x06003751 RID: 14161 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003751")]
			[Address(RVA = "0x65E380", Offset = "0x65CD80", VA = "0x18065E380")]
			public DataBaseCoreData(Dictionary<int, Ingredient> ingredients, Dictionary<int, Sellable> beverages, Dictionary<int, Sellable> foods, Dictionary<int, Recipe> recipes, Dictionary<int, Cooker> cookers, Dictionary<int, Izakaya> izakayas, Dictionary<int, Item> items, Dictionary<int, Badge> badges, Dictionary<int, ClothesProfile.Clothes> clothes, Dictionary<int, Decoration> decorationId, Dictionary<int, Record> recordId, Dictionary<int, TrophiesProfile.Trophy> trophyId, List<int[]> tagRules)
			{
			}

			// Token: 0x17000743 RID: 1859
			// (get) Token: 0x06003752 RID: 14162 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003753 RID: 14163 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000743")]
			internal Dictionary<int, Ingredient> Ingredients
			{
				[Token(Token = "0x6003752")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003753")]
				[Address(RVA = "0x4A6ED0", Offset = "0x4A58D0", VA = "0x1804A6ED0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000744 RID: 1860
			// (get) Token: 0x06003754 RID: 14164 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003755 RID: 14165 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000744")]
			internal Dictionary<int, Sellable> Beverages
			{
				[Token(Token = "0x6003754")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003755")]
				[Address(RVA = "0x3FC090", Offset = "0x3FAA90", VA = "0x1803FC090")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000745 RID: 1861
			// (get) Token: 0x06003756 RID: 14166 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003757 RID: 14167 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000745")]
			internal Dictionary<int, Sellable> Foods
			{
				[Token(Token = "0x6003756")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003757")]
				[Address(RVA = "0x3F2100", Offset = "0x3F0B00", VA = "0x1803F2100")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000746 RID: 1862
			// (get) Token: 0x06003758 RID: 14168 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003759 RID: 14169 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000746")]
			internal Dictionary<int, Recipe> Recipes
			{
				[Token(Token = "0x6003758")]
				[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003759")]
				[Address(RVA = "0x47DD00", Offset = "0x47C700", VA = "0x18047DD00")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000747 RID: 1863
			// (get) Token: 0x0600375A RID: 14170 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600375B RID: 14171 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000747")]
			internal Dictionary<int, Cooker> Cookers
			{
				[Token(Token = "0x600375A")]
				[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600375B")]
				[Address(RVA = "0x531450", Offset = "0x52FE50", VA = "0x180531450")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000748 RID: 1864
			// (get) Token: 0x0600375C RID: 14172 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600375D RID: 14173 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000748")]
			internal Dictionary<int, Izakaya> Izakayas
			{
				[Token(Token = "0x600375C")]
				[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600375D")]
				[Address(RVA = "0x4AD3C0", Offset = "0x4ABDC0", VA = "0x1804AD3C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000749 RID: 1865
			// (get) Token: 0x0600375E RID: 14174 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600375F RID: 14175 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000749")]
			internal Dictionary<int, Item> Items
			{
				[Token(Token = "0x600375E")]
				[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600375F")]
				[Address(RVA = "0x51B180", Offset = "0x519B80", VA = "0x18051B180")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700074A RID: 1866
			// (get) Token: 0x06003760 RID: 14176 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003761 RID: 14177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700074A")]
			internal Dictionary<int, Badge> Badges
			{
				[Token(Token = "0x6003760")]
				[Address(RVA = "0x440290", Offset = "0x43EC90", VA = "0x180440290")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003761")]
				[Address(RVA = "0x6086D0", Offset = "0x6070D0", VA = "0x1806086D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700074B RID: 1867
			// (get) Token: 0x06003762 RID: 14178 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003763 RID: 14179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700074B")]
			internal Dictionary<int, TrophiesProfile.Trophy> Trophies
			{
				[Token(Token = "0x6003762")]
				[Address(RVA = "0x440270", Offset = "0x43EC70", VA = "0x180440270")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003763")]
				[Address(RVA = "0x51B160", Offset = "0x519B60", VA = "0x18051B160")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700074C RID: 1868
			// (get) Token: 0x06003764 RID: 14180 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003765 RID: 14181 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700074C")]
			internal Dictionary<int, ClothesProfile.Clothes> Clothes
			{
				[Token(Token = "0x6003764")]
				[Address(RVA = "0x477F80", Offset = "0x476980", VA = "0x180477F80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003765")]
				[Address(RVA = "0x547AB0", Offset = "0x5464B0", VA = "0x180547AB0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700074D RID: 1869
			// (get) Token: 0x06003766 RID: 14182 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003767 RID: 14183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700074D")]
			internal Dictionary<int, Decoration> DecorationId
			{
				[Token(Token = "0x6003766")]
				[Address(RVA = "0x48B8D0", Offset = "0x48A2D0", VA = "0x18048B8D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003767")]
				[Address(RVA = "0x608700", Offset = "0x607100", VA = "0x180608700")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700074E RID: 1870
			// (get) Token: 0x06003768 RID: 14184 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003769 RID: 14185 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700074E")]
			internal Dictionary<int, Record> RecordId
			{
				[Token(Token = "0x6003768")]
				[Address(RVA = "0x440300", Offset = "0x43ED00", VA = "0x180440300")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003769")]
				[Address(RVA = "0x51AAD0", Offset = "0x5194D0", VA = "0x18051AAD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700074F RID: 1871
			// (get) Token: 0x0600376A RID: 14186 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600376B RID: 14187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700074F")]
			internal List<int[]> TagRules
			{
				[Token(Token = "0x600376A")]
				[Address(RVA = "0x48A940", Offset = "0x489340", VA = "0x18048A940")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600376B")]
				[Address(RVA = "0x493610", Offset = "0x492010", VA = "0x180493610")]
				[CompilerGenerated]
				set
				{
				}
			}
		}

		// Token: 0x020008B8 RID: 2232
		[Token(Token = "0x20008B8")]
		[Serializable]
		public struct LevelProperties
		{
			// Token: 0x17000750 RID: 1872
			// (get) Token: 0x0600376C RID: 14188 RVA: 0x00014E20 File Offset: 0x00013020
			[Token(Token = "0x17000750")]
			public int LevelUpExp
			{
				[Token(Token = "0x600376C")]
				[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000751 RID: 1873
			// (get) Token: 0x0600376D RID: 14189 RVA: 0x00014E38 File Offset: 0x00013038
			[Token(Token = "0x17000751")]
			public int BasePassion
			{
				[Token(Token = "0x600376D")]
				[Address(RVA = "0x685B20", Offset = "0x684520", VA = "0x180685B20")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000752 RID: 1874
			// (get) Token: 0x0600376E RID: 14190 RVA: 0x00014E50 File Offset: 0x00013050
			[Token(Token = "0x17000752")]
			public float TipRate
			{
				[Token(Token = "0x600376E")]
				[Address(RVA = "0x686A00", Offset = "0x685400", VA = "0x180686A00")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000753 RID: 1875
			// (get) Token: 0x0600376F RID: 14191 RVA: 0x00014E68 File Offset: 0x00013068
			[Token(Token = "0x17000753")]
			public int MaxDailyRecipe
			{
				[Token(Token = "0x600376F")]
				[Address(RVA = "0x6864B0", Offset = "0x684EB0", VA = "0x1806864B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000754 RID: 1876
			// (get) Token: 0x06003770 RID: 14192 RVA: 0x00014E80 File Offset: 0x00013080
			[Token(Token = "0x17000754")]
			public int MaxDailyBev
			{
				[Token(Token = "0x6003770")]
				[Address(RVA = "0x6863A0", Offset = "0x684DA0", VA = "0x1806863A0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000755 RID: 1877
			// (get) Token: 0x06003771 RID: 14193 RVA: 0x00014E98 File Offset: 0x00013098
			[Token(Token = "0x17000755")]
			public int DailyCookCount
			{
				[Token(Token = "0x6003771")]
				[Address(RVA = "0x685D40", Offset = "0x684740", VA = "0x180685D40")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000756 RID: 1878
			// (get) Token: 0x06003772 RID: 14194 RVA: 0x00014EB0 File Offset: 0x000130B0
			[Token(Token = "0x17000756")]
			public float CookSpeedMultiplier
			{
				[Token(Token = "0x6003772")]
				[Address(RVA = "0x685C30", Offset = "0x684630", VA = "0x180685C30")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000757 RID: 1879
			// (get) Token: 0x06003773 RID: 14195 RVA: 0x00014EC8 File Offset: 0x000130C8
			[Token(Token = "0x17000757")]
			public float MoveSpeedMultiplier
			{
				[Token(Token = "0x6003773")]
				[Address(RVA = "0x6866D0", Offset = "0x6850D0", VA = "0x1806866D0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000758 RID: 1880
			// (get) Token: 0x06003774 RID: 14196 RVA: 0x00014EE0 File Offset: 0x000130E0
			[Token(Token = "0x17000758")]
			public float QteBuffProb
			{
				[Token(Token = "0x6003774")]
				[Address(RVA = "0x6868F0", Offset = "0x6852F0", VA = "0x1806868F0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000759 RID: 1881
			// (get) Token: 0x06003775 RID: 14197 RVA: 0x00014EF8 File Offset: 0x000130F8
			[Token(Token = "0x17000759")]
			public float QteBuffDurationMultiplier
			{
				[Token(Token = "0x6003775")]
				[Address(RVA = "0x6867E0", Offset = "0x6851E0", VA = "0x1806867E0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700075A RID: 1882
			// (get) Token: 0x06003776 RID: 14198 RVA: 0x00014F10 File Offset: 0x00013110
			[Token(Token = "0x1700075A")]
			public float DoubleCollectProb
			{
				[Token(Token = "0x6003776")]
				[Address(RVA = "0x685E50", Offset = "0x684850", VA = "0x180685E50")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700075B RID: 1883
			// (get) Token: 0x06003777 RID: 14199 RVA: 0x00014F28 File Offset: 0x00013128
			[Token(Token = "0x1700075B")]
			public float MerchantPriceMultiplier
			{
				[Token(Token = "0x6003777")]
				[Address(RVA = "0x6865C0", Offset = "0x684FC0", VA = "0x1806865C0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700075C RID: 1884
			// (get) Token: 0x06003778 RID: 14200 RVA: 0x00014F40 File Offset: 0x00013140
			[Token(Token = "0x1700075C")]
			public int TrayMaxNum
			{
				[Token(Token = "0x6003778")]
				[Address(RVA = "0x686B10", Offset = "0x685510", VA = "0x180686B10")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700075D RID: 1885
			// (get) Token: 0x06003779 RID: 14201 RVA: 0x00014F58 File Offset: 0x00013158
			[Token(Token = "0x1700075D")]
			public int ExtraGuestBaseMood
			{
				[Token(Token = "0x6003779")]
				[Address(RVA = "0x685F60", Offset = "0x684960", VA = "0x180685F60")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700075E RID: 1886
			// (get) Token: 0x0600377A RID: 14202 RVA: 0x00014F70 File Offset: 0x00013170
			[Token(Token = "0x1700075E")]
			public float ExtraGuestPatient
			{
				[Token(Token = "0x600377A")]
				[Address(RVA = "0x686070", Offset = "0x684A70", VA = "0x180686070")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700075F RID: 1887
			// (get) Token: 0x0600377B RID: 14203 RVA: 0x00014F88 File Offset: 0x00013188
			[Token(Token = "0x1700075F")]
			public float ExtraGuestSpawnRate
			{
				[Token(Token = "0x600377B")]
				[Address(RVA = "0x686180", Offset = "0x684B80", VA = "0x180686180")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000760 RID: 1888
			// (get) Token: 0x0600377C RID: 14204 RVA: 0x00014FA0 File Offset: 0x000131A0
			[Token(Token = "0x17000760")]
			public float ExtraPositiveBuffTime
			{
				[Token(Token = "0x600377C")]
				[Address(RVA = "0x686290", Offset = "0x684C90", VA = "0x180686290")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000761 RID: 1889
			// (get) Token: 0x0600377D RID: 14205 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000761")]
			public DataBaseCore.LevelProperties.levelUnlockRecipe[] UnlockedRecipes
			{
				[Token(Token = "0x600377D")]
				[Address(RVA = "0x4402C0", Offset = "0x43ECC0", VA = "0x1804402C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000762 RID: 1890
			// (get) Token: 0x0600377E RID: 14206 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000762")]
			public DataBaseCore.LevelProperties.DiffPropertyInt StartPassion
			{
				[Token(Token = "0x600377E")]
				[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000763 RID: 1891
			// (get) Token: 0x0600377F RID: 14207 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000763")]
			public DataBaseCore.LevelProperties.DiffPropertyFloat StartTipRate
			{
				[Token(Token = "0x600377F")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000764 RID: 1892
			// (get) Token: 0x06003780 RID: 14208 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000764")]
			public DataBaseCore.LevelProperties.DiffPropertyInt MaxRecipes
			{
				[Token(Token = "0x6003780")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000765 RID: 1893
			// (get) Token: 0x06003781 RID: 14209 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000765")]
			public DataBaseCore.LevelProperties.DiffPropertyInt MaxBeverages
			{
				[Token(Token = "0x6003781")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000766 RID: 1894
			// (get) Token: 0x06003782 RID: 14210 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000766")]
			public DataBaseCore.LevelProperties.DiffPropertyInt DayCookCount
			{
				[Token(Token = "0x6003782")]
				[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000767 RID: 1895
			// (get) Token: 0x06003783 RID: 14211 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000767")]
			public DataBaseCore.LevelProperties.DiffPropertyFloat CookSpdMultiplier
			{
				[Token(Token = "0x6003783")]
				[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000768 RID: 1896
			// (get) Token: 0x06003784 RID: 14212 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000768")]
			public DataBaseCore.LevelProperties.DiffPropertyFloat MoveSpdMultiplier
			{
				[Token(Token = "0x6003784")]
				[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000769 RID: 1897
			// (get) Token: 0x06003785 RID: 14213 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000769")]
			public DataBaseCore.LevelProperties.DiffPropertyFloat QteBuffTriggerProb
			{
				[Token(Token = "0x6003785")]
				[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700076A RID: 1898
			// (get) Token: 0x06003786 RID: 14214 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700076A")]
			public DataBaseCore.LevelProperties.DiffPropertyFloat QteBuffLengthMultiplier
			{
				[Token(Token = "0x6003786")]
				[Address(RVA = "0x440290", Offset = "0x43EC90", VA = "0x180440290")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700076B RID: 1899
			// (get) Token: 0x06003787 RID: 14215 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700076B")]
			public DataBaseCore.LevelProperties.DiffPropertyFloat DoubleCollectionProb
			{
				[Token(Token = "0x6003787")]
				[Address(RVA = "0x440270", Offset = "0x43EC70", VA = "0x180440270")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700076C RID: 1900
			// (get) Token: 0x06003788 RID: 14216 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700076C")]
			public DataBaseCore.LevelProperties.DiffPropertyFloat ShopPriceMultiplier
			{
				[Token(Token = "0x6003788")]
				[Address(RVA = "0x477F80", Offset = "0x476980", VA = "0x180477F80")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700076D RID: 1901
			// (get) Token: 0x06003789 RID: 14217 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700076D")]
			public DataBaseCore.LevelProperties.DiffPropertyInt MaxTray
			{
				[Token(Token = "0x6003789")]
				[Address(RVA = "0x48B8D0", Offset = "0x48A2D0", VA = "0x18048B8D0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700076E RID: 1902
			// (get) Token: 0x0600378A RID: 14218 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700076E")]
			public DataBaseCore.LevelProperties.DiffPropertyFloat AdditiveGuestPatient
			{
				[Token(Token = "0x600378A")]
				[Address(RVA = "0x440300", Offset = "0x43ED00", VA = "0x180440300")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700076F RID: 1903
			// (get) Token: 0x0600378B RID: 14219 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700076F")]
			public DataBaseCore.LevelProperties.DiffPropertyFloat AdditiveGuestSpawnRate
			{
				[Token(Token = "0x600378B")]
				[Address(RVA = "0x48A940", Offset = "0x489340", VA = "0x18048A940")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000770 RID: 1904
			// (get) Token: 0x0600378C RID: 14220 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000770")]
			public DataBaseCore.LevelProperties.DiffPropertyInt AdditiveGuestBaseMood
			{
				[Token(Token = "0x600378C")]
				[Address(RVA = "0x440320", Offset = "0x43ED20", VA = "0x180440320")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000771 RID: 1905
			// (get) Token: 0x0600378D RID: 14221 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000771")]
			public DataBaseCore.LevelProperties.DiffPropertyFloat AdditivePositiveBuffTime
			{
				[Token(Token = "0x600378D")]
				[Address(RVA = "0x4402B0", Offset = "0x43ECB0", VA = "0x1804402B0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000772 RID: 1906
			// (get) Token: 0x0600378E RID: 14222 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600378F RID: 14223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000772")]
			[TupleElementNames(new string[] { "level", "properties" })]
			public LinkedListNode<ValueTuple<int, DataBaseCore.LevelProperties>> PropertyLinkedList
			{
				[Token(Token = "0x600378E")]
				[Address(RVA = "0x45A7E0", Offset = "0x4591E0", VA = "0x18045A7E0")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x600378F")]
				[Address(RVA = "0x45ABC0", Offset = "0x4595C0", VA = "0x18045ABC0")]
				[CompilerGenerated]
				[param: TupleElementNames(new string[] { "level", "properties" })]
				set
				{
				}
			}

			// Token: 0x06003790 RID: 14224 RVA: 0x00014FB8 File Offset: 0x000131B8
			[Token(Token = "0x6003790")]
			[Address(RVA = "0x685860", Offset = "0x684260", VA = "0x180685860")]
			private int GetValueInt(Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyInt> getValueCallback)
			{
				return 0;
			}

			// Token: 0x06003791 RID: 14225 RVA: 0x00014FD0 File Offset: 0x000131D0
			[Token(Token = "0x6003791")]
			[Address(RVA = "0x6855A0", Offset = "0x683FA0", VA = "0x1806855A0")]
			private float GetValueFloat(Func<DataBaseCore.LevelProperties, DataBaseCore.LevelProperties.DiffPropertyFloat> getValueCallback)
			{
				return 0f;
			}

			// Token: 0x04002F76 RID: 12150
			[Token(Token = "0x4002F76")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public int levelUpExp;

			// Token: 0x04002F77 RID: 12151
			[Token(Token = "0x4002F77")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public DataBaseCore.LevelProperties.DiffPropertyInt startPassion;

			// Token: 0x04002F78 RID: 12152
			[Token(Token = "0x4002F78")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public DataBaseCore.LevelProperties.DiffPropertyFloat startTipRate;

			// Token: 0x04002F79 RID: 12153
			[Token(Token = "0x4002F79")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public DataBaseCore.LevelProperties.DiffPropertyInt maxRecipes;

			// Token: 0x04002F7A RID: 12154
			[Token(Token = "0x4002F7A")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			public DataBaseCore.LevelProperties.DiffPropertyInt maxBeverages;

			// Token: 0x04002F7B RID: 12155
			[Token(Token = "0x4002F7B")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			public DataBaseCore.LevelProperties.DiffPropertyInt dayCookCount;

			// Token: 0x04002F7C RID: 12156
			[Token(Token = "0x4002F7C")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			public DataBaseCore.LevelProperties.DiffPropertyFloat cookSpdMultiplier;

			// Token: 0x04002F7D RID: 12157
			[Token(Token = "0x4002F7D")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			public DataBaseCore.LevelProperties.DiffPropertyFloat moveSpdMultiplier;

			// Token: 0x04002F7E RID: 12158
			[Token(Token = "0x4002F7E")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			public DataBaseCore.LevelProperties.DiffPropertyFloat qteBuffTriggerProb;

			// Token: 0x04002F7F RID: 12159
			[Token(Token = "0x4002F7F")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			public DataBaseCore.LevelProperties.DiffPropertyFloat qteBuffLengthMultiplier;

			// Token: 0x04002F80 RID: 12160
			[Token(Token = "0x4002F80")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			public DataBaseCore.LevelProperties.DiffPropertyFloat doubleCollectionProb;

			// Token: 0x04002F81 RID: 12161
			[Token(Token = "0x4002F81")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			public DataBaseCore.LevelProperties.DiffPropertyFloat shopPriceMultiplier;

			// Token: 0x04002F82 RID: 12162
			[Token(Token = "0x4002F82")]
			[FieldOffset(Offset = "0x60")]
			[SerializeField]
			public DataBaseCore.LevelProperties.DiffPropertyInt maxTray;

			// Token: 0x04002F83 RID: 12163
			[Token(Token = "0x4002F83")]
			[FieldOffset(Offset = "0x68")]
			[SerializeField]
			public DataBaseCore.LevelProperties.DiffPropertyFloat additiveGuestPatient;

			// Token: 0x04002F84 RID: 12164
			[Token(Token = "0x4002F84")]
			[FieldOffset(Offset = "0x70")]
			[SerializeField]
			public DataBaseCore.LevelProperties.DiffPropertyFloat additiveGuestSpawnRate;

			// Token: 0x04002F85 RID: 12165
			[Token(Token = "0x4002F85")]
			[FieldOffset(Offset = "0x78")]
			[SerializeField]
			public DataBaseCore.LevelProperties.DiffPropertyInt additiveGuestBaseMood;

			// Token: 0x04002F86 RID: 12166
			[Token(Token = "0x4002F86")]
			[FieldOffset(Offset = "0x80")]
			[SerializeField]
			public DataBaseCore.LevelProperties.DiffPropertyFloat additivePositiveBuffTime;

			// Token: 0x04002F87 RID: 12167
			[Token(Token = "0x4002F87")]
			[FieldOffset(Offset = "0x88")]
			[SerializeField]
			public DataBaseCore.LevelProperties.levelUnlockRecipe[] unlockedRecipes;

			// Token: 0x020008B9 RID: 2233
			[Token(Token = "0x20008B9")]
			[Serializable]
			public class DiffPropertyInt
			{
				// Token: 0x06003792 RID: 14226 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6003792")]
				[Address(RVA = "0x6843D0", Offset = "0x682DD0", VA = "0x1806843D0")]
				public DiffPropertyInt(int value, bool hasDiff)
				{
				}

				// Token: 0x06003793 RID: 14227 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003793")]
				[Address(RVA = "0x684410", Offset = "0x682E10", VA = "0x180684410")]
				public static implicit operator DataBaseCore.LevelProperties.DiffPropertyInt(int left)
				{
					return null;
				}

				// Token: 0x04002F89 RID: 12169
				[Token(Token = "0x4002F89")]
				[FieldOffset(Offset = "0x10")]
				[SerializeField]
				public int value;

				// Token: 0x04002F8A RID: 12170
				[Token(Token = "0x4002F8A")]
				[FieldOffset(Offset = "0x14")]
				[SerializeField]
				public bool hasDiff;
			}

			// Token: 0x020008BA RID: 2234
			[Token(Token = "0x20008BA")]
			[Serializable]
			public class DiffPropertyFloat
			{
				// Token: 0x06003794 RID: 14228 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6003794")]
				[Address(RVA = "0x684320", Offset = "0x682D20", VA = "0x180684320")]
				public DiffPropertyFloat(float value, bool hasDiff)
				{
				}

				// Token: 0x06003795 RID: 14229 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6003795")]
				[Address(RVA = "0x684360", Offset = "0x682D60", VA = "0x180684360")]
				public static implicit operator DataBaseCore.LevelProperties.DiffPropertyFloat(float left)
				{
					return null;
				}

				// Token: 0x04002F8B RID: 12171
				[Token(Token = "0x4002F8B")]
				[FieldOffset(Offset = "0x10")]
				[SerializeField]
				public float value;

				// Token: 0x04002F8C RID: 12172
				[Token(Token = "0x4002F8C")]
				[FieldOffset(Offset = "0x14")]
				[SerializeField]
				public bool hasDiff;
			}

			// Token: 0x020008BB RID: 2235
			[Token(Token = "0x20008BB")]
			[Serializable]
			public struct levelUnlockRecipe
			{
				// Token: 0x04002F8D RID: 12173
				[Token(Token = "0x4002F8D")]
				[FieldOffset(Offset = "0x0")]
				[SerializeField]
				public int recipe;

				// Token: 0x04002F8E RID: 12174
				[Token(Token = "0x4002F8E")]
				[FieldOffset(Offset = "0x8")]
				[SerializeField]
				public string frontMap;
			}
		}
	}
}
