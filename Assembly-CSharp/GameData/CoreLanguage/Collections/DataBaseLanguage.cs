using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using GameData.Profile.SchedulerNodeCollection;
using Il2CppDummyDll;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.CoreLanguage.Collections
{
	// Token: 0x020007D1 RID: 2001
	[Token(Token = "0x20007D1")]
	public static class DataBaseLanguage
	{
		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06002E83 RID: 11907 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E84 RID: 11908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000604")]
		private static Dictionary<int, string> BeverageTags
		{
			[Token(Token = "0x6002E83")]
			[Address(RVA = "0x602900", Offset = "0x601300", VA = "0x180602900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E84")]
			[Address(RVA = "0x602FA0", Offset = "0x6019A0", VA = "0x180602FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E86 RID: 11910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000605")]
		private static Dictionary<int, string> FoodTags
		{
			[Token(Token = "0x6002E85")]
			[Address(RVA = "0x602B00", Offset = "0x601500", VA = "0x180602B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E86")]
			[Address(RVA = "0x6032A0", Offset = "0x601CA0", VA = "0x1806032A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06002E87 RID: 11911 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E88 RID: 11912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000606")]
		private static Dictionary<int, string> FoodTagsDLCMapping
		{
			[Token(Token = "0x6002E87")]
			[Address(RVA = "0x602AC0", Offset = "0x6014C0", VA = "0x180602AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E88")]
			[Address(RVA = "0x603240", Offset = "0x601C40", VA = "0x180603240")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06002E89 RID: 11913 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E8A RID: 11914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000607")]
		private static Dictionary<int, string> FoodPrefixs
		{
			[Token(Token = "0x6002E89")]
			[Address(RVA = "0x602A80", Offset = "0x601480", VA = "0x180602A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E8A")]
			[Address(RVA = "0x6031E0", Offset = "0x601BE0", VA = "0x1806031E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06002E8B RID: 11915 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E8C RID: 11916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000608")]
		private static Dictionary<int, ObjectLanguageBase> Ingredients
		{
			[Token(Token = "0x6002E8B")]
			[Address(RVA = "0x602B80", Offset = "0x601580", VA = "0x180602B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E8C")]
			[Address(RVA = "0x603360", Offset = "0x601D60", VA = "0x180603360")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06002E8D RID: 11917 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E8E RID: 11918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000609")]
		private static Dictionary<int, ObjectLanguageBase> Items
		{
			[Token(Token = "0x6002E8D")]
			[Address(RVA = "0x602BC0", Offset = "0x6015C0", VA = "0x180602BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E8E")]
			[Address(RVA = "0x6033C0", Offset = "0x601DC0", VA = "0x1806033C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06002E8F RID: 11919 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E90 RID: 11920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060A")]
		private static Dictionary<int, ObjectLanguageBase> Badges
		{
			[Token(Token = "0x6002E8F")]
			[Address(RVA = "0x6028C0", Offset = "0x6012C0", VA = "0x1806028C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E90")]
			[Address(RVA = "0x602F40", Offset = "0x601940", VA = "0x180602F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06002E91 RID: 11921 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E92 RID: 11922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060B")]
		private static Dictionary<int, ObjectLanguageBase> Beverages
		{
			[Token(Token = "0x6002E91")]
			[Address(RVA = "0x602940", Offset = "0x601340", VA = "0x180602940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E92")]
			[Address(RVA = "0x603000", Offset = "0x601A00", VA = "0x180603000")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x06002E93 RID: 11923 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E94 RID: 11924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060C")]
		private static Dictionary<int, ObjectLanguageBase> Foods
		{
			[Token(Token = "0x6002E93")]
			[Address(RVA = "0x602B40", Offset = "0x601540", VA = "0x180602B40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E94")]
			[Address(RVA = "0x603300", Offset = "0x601D00", VA = "0x180603300")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x06002E95 RID: 11925 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E96 RID: 11926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060D")]
		private static Dictionary<Cooker.CookerType, ObjectLanguageBase> StandardCookers
		{
			[Token(Token = "0x6002E95")]
			[Address(RVA = "0x602F00", Offset = "0x601900", VA = "0x180602F00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E96")]
			[Address(RVA = "0x6038A0", Offset = "0x6022A0", VA = "0x1806038A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x06002E97 RID: 11927 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E98 RID: 11928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060E")]
		private static Dictionary<string, LanguageBase> Missions
		{
			[Token(Token = "0x6002E97")]
			[Address(RVA = "0x602C80", Offset = "0x601680", VA = "0x180602C80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E98")]
			[Address(RVA = "0x6034E0", Offset = "0x601EE0", VA = "0x1806034E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x06002E99 RID: 11929 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E9A RID: 11930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700060F")]
		private static Dictionary<string, LanguageBase> News
		{
			[Token(Token = "0x6002E99")]
			[Address(RVA = "0x602D00", Offset = "0x601700", VA = "0x180602D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E9A")]
			[Address(RVA = "0x6035A0", Offset = "0x601FA0", VA = "0x1806035A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x06002E9B RID: 11931 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E9C RID: 11932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000610")]
		private static Dictionary<int, ObjectLanguageBase> Cookers
		{
			[Token(Token = "0x6002E9B")]
			[Address(RVA = "0x602A40", Offset = "0x601440", VA = "0x180602A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E9C")]
			[Address(RVA = "0x603180", Offset = "0x601B80", VA = "0x180603180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06002E9D RID: 11933 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E9E RID: 11934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000611")]
		private static Dictionary<int, LanguageBase> Izakayas
		{
			[Token(Token = "0x6002E9D")]
			[Address(RVA = "0x602C00", Offset = "0x601600", VA = "0x180602C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E9E")]
			[Address(RVA = "0x603420", Offset = "0x601E20", VA = "0x180603420")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06002E9F RID: 11935 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EA0 RID: 11936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000612")]
		private static Dictionary<int, LanguageBase> NormalGuest
		{
			[Token(Token = "0x6002E9F")]
			[Address(RVA = "0x602D40", Offset = "0x601740", VA = "0x180602D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EA0")]
			[Address(RVA = "0x603600", Offset = "0x602000", VA = "0x180603600")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06002EA1 RID: 11937 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EA2 RID: 11938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000613")]
		[TupleElementNames(new string[] { "Name", "Desc1", "Desc2", "Desc3" })]
		private static Dictionary<int, ValueTuple<string, string, string, string>> SpecialGuest
		{
			[Token(Token = "0x6002EA1")]
			[Address(RVA = "0x602E80", Offset = "0x601880", VA = "0x180602E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EA2")]
			[Address(RVA = "0x6037E0", Offset = "0x6021E0", VA = "0x1806037E0")]
			[CompilerGenerated]
			[param: TupleElementNames(new string[] { "Name", "Desc1", "Desc2", "Desc3" })]
			set
			{
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06002EA3 RID: 11939 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EA4 RID: 11940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000614")]
		private static Dictionary<int, Dictionary<int, string>> SpecialGuestFoodRequest
		{
			[Token(Token = "0x6002EA3")]
			[Address(RVA = "0x602E40", Offset = "0x601840", VA = "0x180602E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EA4")]
			[Address(RVA = "0x603780", Offset = "0x602180", VA = "0x180603780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06002EA5 RID: 11941 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EA6 RID: 11942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000615")]
		private static Dictionary<int, Dictionary<int, string>> SpecialGuestBevRequest
		{
			[Token(Token = "0x6002EA5")]
			[Address(RVA = "0x602E00", Offset = "0x601800", VA = "0x180602E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EA6")]
			[Address(RVA = "0x603720", Offset = "0x602120", VA = "0x180603720")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EA8 RID: 11944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000616")]
		private static Dictionary<EventManager.BuffType, ObjectLanguageBase> BuffDescription
		{
			[Token(Token = "0x6002EA7")]
			[Address(RVA = "0x602980", Offset = "0x601380", VA = "0x180602980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EA8")]
			[Address(RVA = "0x603060", Offset = "0x601A60", VA = "0x180603060")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06002EA9 RID: 11945 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EAA RID: 11946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000617")]
		private static Dictionary<MissionNode.FinishCondition.ConditionType, string> MissionFinishCondition
		{
			[Token(Token = "0x6002EA9")]
			[Address(RVA = "0x602C40", Offset = "0x601640", VA = "0x180602C40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EAA")]
			[Address(RVA = "0x603480", Offset = "0x601E80", VA = "0x180603480")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06002EAB RID: 11947 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EAC RID: 11948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000618")]
		private static Dictionary<Product.ProductType, string> RewardCondition
		{
			[Token(Token = "0x6002EAB")]
			[Address(RVA = "0x602DC0", Offset = "0x6017C0", VA = "0x180602DC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EAC")]
			[Address(RVA = "0x6036C0", Offset = "0x6020C0", VA = "0x1806036C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06002EAD RID: 11949 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EAE RID: 11950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000619")]
		private static Dictionary<PartnerBase.PartnerType, LanguageBase> PartnerJob
		{
			[Token(Token = "0x6002EAD")]
			[Address(RVA = "0x602D80", Offset = "0x601780", VA = "0x180602D80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EAE")]
			[Address(RVA = "0x603660", Offset = "0x602060", VA = "0x180603660")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06002EAF RID: 11951 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EB0 RID: 11952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061A")]
		private static Dictionary<string, LanguageBase> CGData
		{
			[Token(Token = "0x6002EAF")]
			[Address(RVA = "0x6029C0", Offset = "0x6013C0", VA = "0x1806029C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EB0")]
			[Address(RVA = "0x6030C0", Offset = "0x601AC0", VA = "0x1806030C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06002EB1 RID: 11953 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EB2 RID: 11954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061B")]
		[TupleElementNames(new string[] { "Name", "Original", "Writer" })]
		private static Dictionary<string, ValueTuple<string, string, string>> MusicNameData
		{
			[Token(Token = "0x6002EB1")]
			[Address(RVA = "0x602CC0", Offset = "0x6016C0", VA = "0x180602CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EB2")]
			[Address(RVA = "0x603540", Offset = "0x601F40", VA = "0x180603540")]
			[CompilerGenerated]
			[param: TupleElementNames(new string[] { "Name", "Original", "Writer" })]
			set
			{
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x06002EB3 RID: 11955 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EB4 RID: 11956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061C")]
		private static Dictionary<int, LanguageBase[]> SpellLang
		{
			[Token(Token = "0x6002EB3")]
			[Address(RVA = "0x602EC0", Offset = "0x6018C0", VA = "0x180602EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EB4")]
			[Address(RVA = "0x603840", Offset = "0x602240", VA = "0x180603840")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x06002EB5 RID: 11957 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EB6 RID: 11958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061D")]
		private static Dictionary<Cooker.CookerSeries, Sprite> CookerBGMapping
		{
			[Token(Token = "0x6002EB5")]
			[Address(RVA = "0x602A00", Offset = "0x601400", VA = "0x180602A00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EB6")]
			[Address(RVA = "0x603120", Offset = "0x601B20", VA = "0x180603120")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EB7")]
		[Address(RVA = "0x6013A0", Offset = "0x5FFDA0", VA = "0x1806013A0")]
		public static void Initialize(Dictionary<int, string> beverageTags, Dictionary<int, string> foodTags, Dictionary<int, string> foodTagsDLCMapping, Dictionary<int, string> foodPrefixs, Dictionary<int, ObjectLanguageBase> ingredietns, Dictionary<int, ObjectLanguageBase> items, Dictionary<int, ObjectLanguageBase> badges, Dictionary<int, ObjectLanguageBase> beverages, Dictionary<int, ObjectLanguageBase> foods, Dictionary<int, ObjectLanguageBase> cookers, Dictionary<int, LanguageBase> izakayas, Dictionary<string, LanguageBase> missions, Dictionary<string, LanguageBase> news, Dictionary<Cooker.CookerType, ObjectLanguageBase> standardCookers, Dictionary<int, LanguageBase> normalGuests, [TupleElementNames(new string[] { "Name", "Desc1", "Desc2", "Desc3" })] Dictionary<int, ValueTuple<string, string, string, string>> specialGuests, Dictionary<int, string[]> specialFood, Dictionary<int, string[]> specialBev, Dictionary<EventManager.BuffType, ObjectLanguageBase> buffLang, Dictionary<MissionNode.FinishCondition.ConditionType, string> missionFinishCondition, Dictionary<Product.ProductType, string> rewardCondition, Dictionary<PartnerBase.PartnerType, LanguageBase> partnerJob, Dictionary<string, LanguageBase> cgData, [TupleElementNames(new string[] { "Name", "Original", "Writer" })] Dictionary<string, ValueTuple<string, string, string>> musicNameData, Dictionary<int, LanguageBase[]> spellName, Dictionary<Cooker.CookerSeries, Sprite> cookerBGMapping)
		{
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB8")]
		[Address(RVA = "0x602830", Offset = "0x601230", VA = "0x180602830")]
		public static LanguageBase[] RefSpellLang(this int id)
		{
			return null;
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EB9")]
		[Address(RVA = "0x5FFB60", Offset = "0x5FE560", VA = "0x1805FFB60")]
		public static string GetBeverageTag(this int id)
		{
			return null;
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBA")]
		[Address(RVA = "0x5FFF40", Offset = "0x5FE940", VA = "0x1805FFF40")]
		public static string GetFoodTag(this int id)
		{
			return null;
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBB")]
		[Address(RVA = "0x5FCA80", Offset = "0x5FB480", VA = "0x1805FCA80")]
		public static Dictionary<int, string> GetAllFoodTags()
		{
			return null;
		}

		// Token: 0x06002EBC RID: 11964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBC")]
		[Address(RVA = "0x5FF7C0", Offset = "0x5FE1C0", VA = "0x1805FF7C0")]
		public static int[] GetAllFoodTagsId()
		{
			return null;
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBD")]
		[Address(RVA = "0x5FFED0", Offset = "0x5FE8D0", VA = "0x1805FFED0")]
		public static string GetFoodTagMapping(this int id)
		{
			return null;
		}

		// Token: 0x06002EBE RID: 11966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBE")]
		[Address(RVA = "0x5FF780", Offset = "0x5FE180", VA = "0x1805FF780")]
		public static Dictionary<int, string> GetAllBeverageTags()
		{
			return null;
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EBF")]
		[Address(RVA = "0x5FF710", Offset = "0x5FE110", VA = "0x1805FF710")]
		public static string FoodPrefix(this int id)
		{
			return null;
		}

		// Token: 0x06002EC0 RID: 11968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC0")]
		[Address(RVA = "0x600160", Offset = "0x5FEB60", VA = "0x180600160")]
		public static ObjectLanguageBase GetItemLang(this int id)
		{
			return null;
		}

		// Token: 0x06002EC1 RID: 11969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC1")]
		[Address(RVA = "0x5FFA80", Offset = "0x5FE480", VA = "0x1805FFA80")]
		public static ObjectLanguageBase GetBadgeLang(this int id)
		{
			return null;
		}

		// Token: 0x06002EC2 RID: 11970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC2")]
		[Address(RVA = "0x6000F0", Offset = "0x5FEAF0", VA = "0x1806000F0")]
		public static ObjectLanguageBase GetIngredientLang(this int id)
		{
			return null;
		}

		// Token: 0x06002EC3 RID: 11971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC3")]
		[Address(RVA = "0x5FFAF0", Offset = "0x5FE4F0", VA = "0x1805FFAF0")]
		public static ObjectLanguageBase GetBeverageLang(this int id)
		{
			return null;
		}

		// Token: 0x06002EC4 RID: 11972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC4")]
		[Address(RVA = "0x5FFE60", Offset = "0x5FE860", VA = "0x1805FFE60")]
		public static ObjectLanguageBase GetFoodLang(this int id)
		{
			return null;
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC5")]
		[Address(RVA = "0x5FFFB0", Offset = "0x5FE9B0", VA = "0x1805FFFB0")]
		public static ObjectLanguageBase GetFoodToRecipeLang(this int id)
		{
			return null;
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC6")]
		[Address(RVA = "0x5FFCE0", Offset = "0x5FE6E0", VA = "0x1805FFCE0")]
		public static ObjectLanguageBase GetCookerLang(this int id)
		{
			return null;
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC7")]
		[Address(RVA = "0x6001D0", Offset = "0x5FEBD0", VA = "0x1806001D0")]
		public static LanguageBase GetIzakayaLang(this int id)
		{
			return null;
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC8")]
		[Address(RVA = "0x600780", Offset = "0x5FF180", VA = "0x180600780")]
		public static LanguageBase GetNormalGuestLang(this int id)
		{
			return null;
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EC9")]
		[Address(RVA = "0x601190", Offset = "0x5FFB90", VA = "0x180601190")]
		public static LanguageBase GetSpecialGuestLang(this int id)
		{
			return null;
		}

		// Token: 0x06002ECA RID: 11978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ECA")]
		[Address(RVA = "0x6010C0", Offset = "0x5FFAC0", VA = "0x1806010C0")]
		public static Dictionary<int, string> GetSpecialFoodTagLang(this int id)
		{
			return null;
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ECB")]
		[Address(RVA = "0x600FF0", Offset = "0x5FF9F0", VA = "0x180600FF0")]
		public static Dictionary<int, string> GetSpecialBevTagLang(this int id)
		{
			return null;
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ECC")]
		[Address(RVA = "0x5FF850", Offset = "0x5FE250", VA = "0x1805FF850")]
		public static Dictionary<int, string> GetAllSpecialGuestsNames()
		{
			return null;
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ECD")]
		[Address(RVA = "0x601330", Offset = "0x5FFD30", VA = "0x180601330")]
		public static ObjectLanguageBase GetStdCooker(this Cooker.CookerType id)
		{
			return null;
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ECE")]
		[Address(RVA = "0x6002B0", Offset = "0x5FECB0", VA = "0x1806002B0")]
		public static LanguageBase GetMissionLanguage(this string id)
		{
			return null;
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ECF")]
		[Address(RVA = "0x600670", Offset = "0x5FF070", VA = "0x180600670")]
		public static LanguageBase GetNewsLanguage(this string id)
		{
			return null;
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED0")]
		[Address(RVA = "0x600240", Offset = "0x5FEC40", VA = "0x180600240")]
		public static string GetMissionConditionLang(this MissionNode.FinishCondition.ConditionType finishCondition)
		{
			return null;
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED1")]
		[Address(RVA = "0x600F80", Offset = "0x5FF980", VA = "0x180600F80")]
		public static string GetRewardConditionLang(this Product.ProductType targetReward)
		{
			return null;
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED2")]
		[Address(RVA = "0x6007F0", Offset = "0x5FF1F0", VA = "0x1806007F0")]
		public static LanguageBase GetPartnerJobLang(this PartnerBase.PartnerType partnerType)
		{
			return null;
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED3")]
		[Address(RVA = "0x5FFBD0", Offset = "0x5FE5D0", VA = "0x1805FFBD0")]
		public static LanguageBase GetCGLabelLang(this string id)
		{
			return null;
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED4")]
		[Address(RVA = "0x600530", Offset = "0x5FEF30", VA = "0x180600530")]
		public static string GetMusicKeyLang(this string key)
		{
			return null;
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED5")]
		[Address(RVA = "0x6027B0", Offset = "0x6011B0", VA = "0x1806027B0")]
		public static ObjectLanguageBase RefBuffLang(this EventManager.BuffType buffType)
		{
			return null;
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x00011058 File Offset: 0x0000F258
		[Token(Token = "0x6002ED6")]
		[Address(RVA = "0x6003C0", Offset = "0x5FEDC0", VA = "0x1806003C0")]
		public static ValueTuple<string, string, string> GetMusicGameChapterLang(this string label)
		{
			return default(ValueTuple<string, string, string>);
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED7")]
		[Address(RVA = "0x600AD0", Offset = "0x5FF4D0", VA = "0x180600AD0")]
		public static string GetPrefix(int[] value)
		{
			return null;
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED8")]
		[Address(RVA = "0x6009C0", Offset = "0x5FF3C0", VA = "0x1806009C0")]
		public static string GetPrefix(Ingredient value)
		{
			return null;
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002ED9")]
		[Address(RVA = "0x5FFC40", Offset = "0x5FE640", VA = "0x1805FFC40")]
		public static Sprite GetCookerBG(this Cooker.CookerSeries cookerSeries)
		{
			return null;
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDA")]
		[Address(RVA = "0x5FFD50", Offset = "0x5FE750", VA = "0x1805FFD50")]
		public static string GetEvalText(this int evalLevel)
		{
			return null;
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDB")]
		[Address(RVA = "0x5FFD50", Offset = "0x5FE750", VA = "0x1805FFD50")]
		public static string GetEvalText(this GuestGroupController.EvaluationResult evalLevel)
		{
			return null;
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EDC")]
		[Address(RVA = "0x6028B0", Offset = "0x6012B0", VA = "0x1806028B0")]
		[CompilerGenerated]
		internal static string <GetEvalText>g__GetPhrasesCallback|139_0(string x)
		{
			return null;
		}
	}
}
