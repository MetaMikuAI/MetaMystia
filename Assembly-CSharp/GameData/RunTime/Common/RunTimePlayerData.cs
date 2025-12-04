using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Story;

namespace GameData.RunTime.Common
{
	// Token: 0x02000833 RID: 2099
	[Token(Token = "0x2000833")]
	public static class RunTimePlayerData
	{
		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060032B6 RID: 12982 RVA: 0x000129C0 File Offset: 0x00010BC0
		// (set) Token: 0x060032B7 RID: 12983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B1")]
		private static GameDate Date
		{
			[Token(Token = "0x60032B6")]
			[Address(RVA = "0x636F60", Offset = "0x635960", VA = "0x180636F60")]
			[CompilerGenerated]
			get
			{
				return default(GameDate);
			}
			[Token(Token = "0x60032B7")]
			[Address(RVA = "0x6388D0", Offset = "0x6372D0", VA = "0x1806388D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060032B8 RID: 12984 RVA: 0x000129D8 File Offset: 0x00010BD8
		// (set) Token: 0x060032B9 RID: 12985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B2")]
		private static long Fund
		{
			[Token(Token = "0x60032B8")]
			[Address(RVA = "0x637050", Offset = "0x635A50", VA = "0x180637050")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60032B9")]
			[Address(RVA = "0x6389F0", Offset = "0x6373F0", VA = "0x1806389F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060032BA RID: 12986 RVA: 0x000129F0 File Offset: 0x00010BF0
		// (set) Token: 0x060032BB RID: 12987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B3")]
		private static int Exp
		{
			[Token(Token = "0x60032BA")]
			[Address(RVA = "0x637000", Offset = "0x635A00", VA = "0x180637000")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60032BB")]
			[Address(RVA = "0x638990", Offset = "0x637390", VA = "0x180638990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060032BC RID: 12988 RVA: 0x00012A08 File Offset: 0x00010C08
		// (set) Token: 0x060032BD RID: 12989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B4")]
		private static int BufferedExp
		{
			[Token(Token = "0x60032BC")]
			[Address(RVA = "0x636C10", Offset = "0x635610", VA = "0x180636C10")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60032BD")]
			[Address(RVA = "0x638520", Offset = "0x636F20", VA = "0x180638520")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060032BE RID: 12990 RVA: 0x00012A20 File Offset: 0x00010C20
		// (set) Token: 0x060032BF RID: 12991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B5")]
		private static int Level
		{
			[Token(Token = "0x60032BE")]
			[Address(RVA = "0x637A20", Offset = "0x636420", VA = "0x180637A20")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60032BF")]
			[Address(RVA = "0x638C30", Offset = "0x637630", VA = "0x180638C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060032C0 RID: 12992 RVA: 0x00012A38 File Offset: 0x00010C38
		// (set) Token: 0x060032C1 RID: 12993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B6")]
		public static bool CanPerform
		{
			[Token(Token = "0x60032C0")]
			[Address(RVA = "0x636CB0", Offset = "0x6356B0", VA = "0x180636CB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60032C1")]
			[Address(RVA = "0x638690", Offset = "0x637090", VA = "0x180638690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060032C2 RID: 12994 RVA: 0x00012A50 File Offset: 0x00010C50
		// (set) Token: 0x060032C3 RID: 12995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B7")]
		public static bool ShouldSpawnSpecialGuests
		{
			[Token(Token = "0x60032C2")]
			[Address(RVA = "0x6382F0", Offset = "0x636CF0", VA = "0x1806382F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60032C3")]
			[Address(RVA = "0x6395F0", Offset = "0x637FF0", VA = "0x1806395F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060032C4 RID: 12996 RVA: 0x00012A68 File Offset: 0x00010C68
		// (set) Token: 0x060032C5 RID: 12997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B8")]
		public static bool ShouldShowSpecialGuestsInDay
		{
			[Token(Token = "0x60032C4")]
			[Address(RVA = "0x6382A0", Offset = "0x636CA0", VA = "0x1806382A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60032C5")]
			[Address(RVA = "0x639590", Offset = "0x637F90", VA = "0x180639590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060032C6 RID: 12998 RVA: 0x00012A80 File Offset: 0x00010C80
		// (set) Token: 0x060032C7 RID: 12999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006B9")]
		public static bool ShouldHaveLevel5KizunaEvent
		{
			[Token(Token = "0x60032C6")]
			[Address(RVA = "0x638250", Offset = "0x636C50", VA = "0x180638250")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60032C7")]
			[Address(RVA = "0x639530", Offset = "0x637F30", VA = "0x180639530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060032C8 RID: 13000 RVA: 0x00012A98 File Offset: 0x00010C98
		// (set) Token: 0x060032C9 RID: 13001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006BA")]
		public static bool CanOpenNoteStorageEscape
		{
			[Token(Token = "0x60032C8")]
			[Address(RVA = "0x636C60", Offset = "0x635660", VA = "0x180636C60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60032C9")]
			[Address(RVA = "0x638580", Offset = "0x636F80", VA = "0x180638580")]
			set
			{
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060032CA RID: 13002 RVA: 0x00012AB0 File Offset: 0x00010CB0
		// (set) Token: 0x060032CB RID: 13003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006BB")]
		public static bool ShouldSpawnTewi
		{
			[Token(Token = "0x60032CA")]
			[Address(RVA = "0x638340", Offset = "0x636D40", VA = "0x180638340")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60032CB")]
			[Address(RVA = "0x639650", Offset = "0x638050", VA = "0x180639650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060032CC RID: 13004 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032CD RID: 13005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006BC")]
		public static string LockingEventName
		{
			[Token(Token = "0x60032CC")]
			[Address(RVA = "0x637B20", Offset = "0x636520", VA = "0x180637B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032CD")]
			[Address(RVA = "0x638D80", Offset = "0x637780", VA = "0x180638D80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060032CE RID: 13006 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032CF RID: 13007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006BD")]
		public static List<string> LockedEvents
		{
			[Token(Token = "0x60032CE")]
			[Address(RVA = "0x637A70", Offset = "0x636470", VA = "0x180637A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032CF")]
			[Address(RVA = "0x638C90", Offset = "0x637690", VA = "0x180638C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060032D0 RID: 13008 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032D1 RID: 13009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006BE")]
		public static List<string> TryToUnLockEvents
		{
			[Token(Token = "0x60032D0")]
			[Address(RVA = "0x638390", Offset = "0x636D90", VA = "0x180638390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032D1")]
			[Address(RVA = "0x6396B0", Offset = "0x6380B0", VA = "0x1806396B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060032D2 RID: 13010 RVA: 0x00012AC8 File Offset: 0x00010CC8
		// (set) Token: 0x060032D3 RID: 13011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006BF")]
		public static int CurrentLevelCap
		{
			[Token(Token = "0x60032D2")]
			[Address(RVA = "0x636EB0", Offset = "0x6358B0", VA = "0x180636EB0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60032D3")]
			[Address(RVA = "0x6387F0", Offset = "0x6371F0", VA = "0x1806387F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060032D4 RID: 13012 RVA: 0x00012AE0 File Offset: 0x00010CE0
		// (set) Token: 0x060032D5 RID: 13013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C0")]
		public static bool EnableMultiPartner
		{
			[Token(Token = "0x60032D4")]
			[Address(RVA = "0x636FB0", Offset = "0x6359B0", VA = "0x180636FB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60032D5")]
			[Address(RVA = "0x638930", Offset = "0x637330", VA = "0x180638930")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060032D6 RID: 13014 RVA: 0x00012AF8 File Offset: 0x00010CF8
		// (set) Token: 0x060032D7 RID: 13015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C1")]
		public static int MaxPartnerCount
		{
			[Token(Token = "0x60032D6")]
			[Address(RVA = "0x637B70", Offset = "0x636570", VA = "0x180637B70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60032D7")]
			[Address(RVA = "0x638DF0", Offset = "0x6377F0", VA = "0x180638DF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060032D8 RID: 13016 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032D9 RID: 13017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C2")]
		public static ValueTuple<int, PartnerBase.PartnerType>[] HistoryPartnerSelection
		{
			[Token(Token = "0x60032D8")]
			[Address(RVA = "0x637700", Offset = "0x636100", VA = "0x180637700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032D9")]
			[Address(RVA = "0x638B30", Offset = "0x637530", VA = "0x180638B30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060032DA RID: 13018 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032DB RID: 13019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C3")]
		private static List<int> PopLikeFoodTags
		{
			[Token(Token = "0x60032DA")]
			[Address(RVA = "0x638070", Offset = "0x636A70", VA = "0x180638070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032DB")]
			[Address(RVA = "0x6392D0", Offset = "0x637CD0", VA = "0x1806392D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060032DC RID: 13020 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032DD RID: 13021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C4")]
		private static List<int> PopLikeBevTags
		{
			[Token(Token = "0x60032DC")]
			[Address(RVA = "0x638010", Offset = "0x636A10", VA = "0x180638010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032DD")]
			[Address(RVA = "0x639250", Offset = "0x637C50", VA = "0x180639250")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060032DE RID: 13022 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032DF RID: 13023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C5")]
		private static List<int> PopHateFoodTags
		{
			[Token(Token = "0x60032DE")]
			[Address(RVA = "0x637FB0", Offset = "0x6369B0", VA = "0x180637FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032DF")]
			[Address(RVA = "0x6391D0", Offset = "0x637BD0", VA = "0x1806391D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x060032E0 RID: 13024 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032E1 RID: 13025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C6")]
		private static List<int> PopHateBevTags
		{
			[Token(Token = "0x60032E0")]
			[Address(RVA = "0x637F50", Offset = "0x636950", VA = "0x180637F50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032E1")]
			[Address(RVA = "0x639150", Offset = "0x637B50", VA = "0x180639150")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x060032E2 RID: 13026 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032E3 RID: 13027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C7")]
		public static List<string> ActiveDLCLabel
		{
			[Token(Token = "0x60032E2")]
			[Address(RVA = "0x636BB0", Offset = "0x6355B0", VA = "0x180636BB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032E3")]
			[Address(RVA = "0x6384A0", Offset = "0x636EA0", VA = "0x1806384A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060032E4 RID: 13028 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032E5 RID: 13029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C8")]
		private static Dictionary<string, bool> CollabStatus
		{
			[Token(Token = "0x60032E4")]
			[Address(RVA = "0x636DF0", Offset = "0x6357F0", VA = "0x180636DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032E5")]
			[Address(RVA = "0x6386F0", Offset = "0x6370F0", VA = "0x1806386F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060032E6 RID: 13030 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032E7 RID: 13031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C9")]
		private static Dictionary<string, int> PrdTryTimeRecord
		{
			[Token(Token = "0x60032E6")]
			[Address(RVA = "0x6380D0", Offset = "0x636AD0", VA = "0x1806380D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032E7")]
			[Address(RVA = "0x639350", Offset = "0x637D50", VA = "0x180639350")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060032E8 RID: 13032 RVA: 0x00012B10 File Offset: 0x00010D10
		// (set) Token: 0x060032E9 RID: 13033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CA")]
		private static long HakureiMoneyBoxDonateNum
		{
			[Token(Token = "0x60032E8")]
			[Address(RVA = "0x637130", Offset = "0x635B30", VA = "0x180637130")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x60032E9")]
			[Address(RVA = "0x638A50", Offset = "0x637450", VA = "0x180638A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060032EA RID: 13034 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032EB RID: 13035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CB")]
		public static Dictionary<PlayerSaveFile.DefaultProp, List<int>> PinnedObjects
		{
			[Token(Token = "0x60032EA")]
			[Address(RVA = "0x637EF0", Offset = "0x6368F0", VA = "0x180637EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032EB")]
			[Address(RVA = "0x6390D0", Offset = "0x637AD0", VA = "0x1806390D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060032EC RID: 13036 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032ED RID: 13037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CC")]
		public static Dictionary<int, List<PlayerSaveFile.HistoryIzakayaMenuSelection>> UserIzakayaPresets
		{
			[Token(Token = "0x60032EC")]
			[Address(RVA = "0x638440", Offset = "0x636E40", VA = "0x180638440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032ED")]
			[Address(RVA = "0x639780", Offset = "0x638180", VA = "0x180639780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060032EE RID: 13038 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032EF RID: 13039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CD")]
		private static List<ControlledSpecialGuest> ControlledSpecialGuests
		{
			[Token(Token = "0x60032EE")]
			[Address(RVA = "0x636E50", Offset = "0x635850", VA = "0x180636E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032EF")]
			[Address(RVA = "0x638770", Offset = "0x637170", VA = "0x180638770")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060032F0 RID: 13040 RVA: 0x00012B28 File Offset: 0x00010D28
		// (set) Token: 0x060032F1 RID: 13041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CE")]
		public static bool UseCreatorBoxData
		{
			[Token(Token = "0x60032F0")]
			[Address(RVA = "0x6383E0", Offset = "0x636DE0", VA = "0x1806383E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60032F1")]
			[Address(RVA = "0x639720", Offset = "0x638120", VA = "0x180639720")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060032F2 RID: 13042 RVA: 0x00012B40 File Offset: 0x00010D40
		// (set) Token: 0x060032F3 RID: 13043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006CF")]
		public static CreatorBoxData? SelectedCreatorBoxData
		{
			[Token(Token = "0x60032F2")]
			[Address(RVA = "0x6381F0", Offset = "0x636BF0", VA = "0x1806381F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032F3")]
			[Address(RVA = "0x6394B0", Offset = "0x637EB0", VA = "0x1806394B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060032F4 RID: 13044 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032F5 RID: 13045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D0")]
		public static CreatorBoxData?[] SelectedCreatorBoxDataPresets
		{
			[Token(Token = "0x60032F4")]
			[Address(RVA = "0x638190", Offset = "0x636B90", VA = "0x180638190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032F5")]
			[Address(RVA = "0x639430", Offset = "0x637E30", VA = "0x180639430")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060032F6 RID: 13046 RVA: 0x00012B58 File Offset: 0x00010D58
		// (set) Token: 0x060032F7 RID: 13047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D1")]
		public static bool RewindMode
		{
			[Token(Token = "0x60032F6")]
			[Address(RVA = "0x638130", Offset = "0x636B30", VA = "0x180638130")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60032F7")]
			[Address(RVA = "0x6393D0", Offset = "0x637DD0", VA = "0x1806393D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060032F8 RID: 13048 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032F9 RID: 13049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D2")]
		public static List<int?> InfiniteIngredients
		{
			[Token(Token = "0x60032F8")]
			[Address(RVA = "0x637760", Offset = "0x636160", VA = "0x180637760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032F9")]
			[Address(RVA = "0x638BB0", Offset = "0x6375B0", VA = "0x180638BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060032FA RID: 13050 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032FB RID: 13051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D3")]
		public static HashSet<string> DLCLock
		{
			[Token(Token = "0x60032FA")]
			[Address(RVA = "0x636F00", Offset = "0x635900", VA = "0x180636F00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032FB")]
			[Address(RVA = "0x638850", Offset = "0x637250", VA = "0x180638850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060032FC RID: 13052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D4")]
		[TupleElementNames(new string[] { "EasyHighScore", "HardHighScore" })]
		private static Dictionary<string, ValueTuple<int, int>> MusicScoreData
		{
			[Token(Token = "0x60032FC")]
			[Address(RVA = "0x637C20", Offset = "0x636620", VA = "0x180637C20")]
			get
			{
				return null;
			}
		}

		// Token: 0x060032FD RID: 13053 RVA: 0x00012B70 File Offset: 0x00010D70
		[Token(Token = "0x60032FD")]
		[Address(RVA = "0x6356C0", Offset = "0x6340C0", VA = "0x1806356C0")]
		public static UniTask SetMusicScoreData()
		{
			return default(UniTask);
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060032FE RID: 13054 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060032FF RID: 13055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D5")]
		private static Dictionary<string, List<string>> MusicChapterStatus
		{
			[Token(Token = "0x60032FE")]
			[Address(RVA = "0x637BC0", Offset = "0x6365C0", VA = "0x180637BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60032FF")]
			[Address(RVA = "0x638E50", Offset = "0x637850", VA = "0x180638E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x06003300 RID: 13056 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003301 RID: 13057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D6")]
		private static List<string> HaveChattedSGuestLabel
		{
			[Token(Token = "0x6003300")]
			[Address(RVA = "0x6376A0", Offset = "0x6360A0", VA = "0x1806376A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003301")]
			[Address(RVA = "0x638AB0", Offset = "0x6374B0", VA = "0x180638AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x06003302 RID: 13058 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003303 RID: 13059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D7")]
		private static List<int> LockedRecipeList
		{
			[Token(Token = "0x6003302")]
			[Address(RVA = "0x637AC0", Offset = "0x6364C0", VA = "0x180637AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003303")]
			[Address(RVA = "0x638D00", Offset = "0x637700", VA = "0x180638D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x06003304 RID: 13060 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003305 RID: 13061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D8")]
		public static Dictionary<string, PlayerSaveFile.RunTimeStorageSaveDataPartial> NotLoadedRunTimeStorageSaveDataPartial
		{
			[Token(Token = "0x6003304")]
			[Address(RVA = "0x637E90", Offset = "0x636890", VA = "0x180637E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003305")]
			[Address(RVA = "0x639050", Offset = "0x637A50", VA = "0x180639050")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06003306 RID: 13062 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003307 RID: 13063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006D9")]
		public static Dictionary<string, PlayerSaveFile.DLCAlbumSaveData> NotLoadedDLCAlbumSaveData
		{
			[Token(Token = "0x6003306")]
			[Address(RVA = "0x637D70", Offset = "0x636770", VA = "0x180637D70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003307")]
			[Address(RVA = "0x638ED0", Offset = "0x6378D0", VA = "0x180638ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06003308 RID: 13064 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003309 RID: 13065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006DA")]
		public static Dictionary<string, PlayerSaveFile.DLCDaySceneSaveData> NotLoadedDLCDaySceneSaveData
		{
			[Token(Token = "0x6003308")]
			[Address(RVA = "0x637DD0", Offset = "0x6367D0", VA = "0x180637DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003309")]
			[Address(RVA = "0x638F50", Offset = "0x637950", VA = "0x180638F50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x0600330A RID: 13066 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600330B RID: 13067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006DB")]
		public static Dictionary<string, PlayerSaveFile.DLCSchedulerSaveData> NotLoadedDLCSchedulerSaveData
		{
			[Token(Token = "0x600330A")]
			[Address(RVA = "0x637E30", Offset = "0x636830", VA = "0x180637E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600330B")]
			[Address(RVA = "0x638FD0", Offset = "0x6379D0", VA = "0x180638FD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x0600330C RID: 13068 RVA: 0x00012B88 File Offset: 0x00010D88
		[Token(Token = "0x170006DC")]
		public static DataBaseCore.LevelProperties LevelProfile
		{
			[Token(Token = "0x600330C")]
			[Address(RVA = "0x637920", Offset = "0x636320", VA = "0x180637920")]
			get
			{
				return default(DataBaseCore.LevelProperties);
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x0600330D RID: 13069 RVA: 0x00012BA0 File Offset: 0x00010DA0
		[Token(Token = "0x170006DD")]
		public static DataBaseCore.LevelProperties NextLevelProfile
		{
			[Token(Token = "0x600330D")]
			[Address(RVA = "0x637C70", Offset = "0x636670", VA = "0x180637C70")]
			get
			{
				return default(DataBaseCore.LevelProperties);
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x0600330E RID: 13070 RVA: 0x00012BB8 File Offset: 0x00010DB8
		[Token(Token = "0x170006DE")]
		public static DataBaseCore.LevelProperties LastLevelProfile
		{
			[Token(Token = "0x600330E")]
			[Address(RVA = "0x6377C0", Offset = "0x6361C0", VA = "0x1806377C0")]
			get
			{
				return default(DataBaseCore.LevelProperties);
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x0600330F RID: 13071 RVA: 0x00012BD0 File Offset: 0x00010DD0
		[Token(Token = "0x170006DF")]
		public static bool HasNextLevel
		{
			[Token(Token = "0x600330F")]
			[Address(RVA = "0x637610", Offset = "0x636010", VA = "0x180637610")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06003310 RID: 13072 RVA: 0x00012BE8 File Offset: 0x00010DE8
		[Token(Token = "0x170006E0")]
		public static bool HasDLC1
		{
			[Token(Token = "0x6003310")]
			[Address(RVA = "0x637190", Offset = "0x635B90", VA = "0x180637190")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06003311 RID: 13073 RVA: 0x00012C00 File Offset: 0x00010E00
		[Token(Token = "0x170006E1")]
		public static bool HasDLC2
		{
			[Token(Token = "0x6003311")]
			[Address(RVA = "0x637250", Offset = "0x635C50", VA = "0x180637250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06003312 RID: 13074 RVA: 0x00012C18 File Offset: 0x00010E18
		[Token(Token = "0x170006E2")]
		public static bool HasDLC3
		{
			[Token(Token = "0x6003312")]
			[Address(RVA = "0x637310", Offset = "0x635D10", VA = "0x180637310")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06003313 RID: 13075 RVA: 0x00012C30 File Offset: 0x00010E30
		[Token(Token = "0x170006E3")]
		public static bool HasDLC4
		{
			[Token(Token = "0x6003313")]
			[Address(RVA = "0x6373D0", Offset = "0x635DD0", VA = "0x1806373D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06003314 RID: 13076 RVA: 0x00012C48 File Offset: 0x00010E48
		[Token(Token = "0x170006E4")]
		public static bool HasDLC5
		{
			[Token(Token = "0x6003314")]
			[Address(RVA = "0x637490", Offset = "0x635E90", VA = "0x180637490")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06003315 RID: 13077 RVA: 0x00012C60 File Offset: 0x00010E60
		[Token(Token = "0x170006E5")]
		public static bool HasDLCMusic
		{
			[Token(Token = "0x6003315")]
			[Address(RVA = "0x637550", Offset = "0x635F50", VA = "0x180637550")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06003316 RID: 13078 RVA: 0x00012C78 File Offset: 0x00010E78
		[Token(Token = "0x170006E6")]
		public static long GetHakureiMoneyBoxDonateNum
		{
			[Token(Token = "0x6003316")]
			[Address(RVA = "0x6370A0", Offset = "0x635AA0", VA = "0x1806370A0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x00012C90 File Offset: 0x00010E90
		[Token(Token = "0x6003317")]
		[Address(RVA = "0x6303B0", Offset = "0x62EDB0", VA = "0x1806303B0")]
		public static PlayerSaveFile.RunTimePlayerSaveDataPartial GenerateSaveData()
		{
			return default(PlayerSaveFile.RunTimePlayerSaveDataPartial);
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003318")]
		[Address(RVA = "0x632080", Offset = "0x630A80", VA = "0x180632080")]
		public static void Initialize(PlayerSaveFile.RunTimePlayerSaveDataPartial saveDataPartial)
		{
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003319")]
		[Address(RVA = "0x634900", Offset = "0x633300", VA = "0x180634900")]
		public static void ModifyPopularSystem(RunTimePlayerData.PopType popType, RunTimePlayerData.TagType tagType, bool add, int tagId)
		{
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331A")]
		[Address(RVA = "0x62FBB0", Offset = "0x62E5B0", VA = "0x18062FBB0")]
		public static void CleanPopularSystem(RunTimePlayerData.PopType popType, RunTimePlayerData.TagType tagType)
		{
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x00012CA8 File Offset: 0x00010EA8
		[Token(Token = "0x600331B")]
		[Address(RVA = "0x62F6D0", Offset = "0x62E0D0", VA = "0x18062F6D0")]
		public static bool CheckCollabData(string collabLabel)
		{
			return default(bool);
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331C")]
		[Address(RVA = "0x6362E0", Offset = "0x634CE0", VA = "0x1806362E0")]
		public static void ValidateAllCollabs()
		{
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331D")]
		[Address(RVA = "0x6365C0", Offset = "0x634FC0", VA = "0x1806365C0")]
		public static void WriteCollabData(string collabLabel, bool openCollab)
		{
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600331E")]
		[Address(RVA = "0x62F340", Offset = "0x62DD40", VA = "0x18062F340")]
		private static void ApplyRule(CollabPackage.CollabRule collabRule, bool enabled)
		{
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x00012CC0 File Offset: 0x00010EC0
		[Token(Token = "0x600331F")]
		[Address(RVA = "0x6318C0", Offset = "0x6302C0", VA = "0x1806318C0")]
		private static bool GetOrGenerateCollabData(string collabLabel)
		{
			return default(bool);
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x00012CD8 File Offset: 0x00010ED8
		[Token(Token = "0x6003320")]
		[Address(RVA = "0x631A10", Offset = "0x630410", VA = "0x180631A10")]
		public static int GetPRDTryTime(string label, int defaultTryTime = 0)
		{
			return 0;
		}

		// Token: 0x06003321 RID: 13089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003321")]
		[Address(RVA = "0x6352B0", Offset = "0x633CB0", VA = "0x1806352B0")]
		public static void RecordPRDTryTime(string label, int tryTime)
		{
		}

		// Token: 0x06003322 RID: 13090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003322")]
		[Address(RVA = "0x62EAE0", Offset = "0x62D4E0", VA = "0x18062EAE0")]
		public static void AddHakureiMoneyBoxDonateNum(int num)
		{
		}

		// Token: 0x06003323 RID: 13091 RVA: 0x00012CF0 File Offset: 0x00010EF0
		[Token(Token = "0x6003323")]
		[Address(RVA = "0x62FA00", Offset = "0x62E400", VA = "0x18062FA00")]
		public static bool CheckPinned(PlayerSaveFile.DefaultProp pinnedType, int pinnedID)
		{
			return default(bool);
		}

		// Token: 0x06003324 RID: 13092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003324")]
		[Address(RVA = "0x635750", Offset = "0x634150", VA = "0x180635750")]
		public static void SetPinned(PlayerSaveFile.DefaultProp pinnedType, int pinnedId, bool doSet)
		{
		}

		// Token: 0x06003325 RID: 13093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003325")]
		[Address(RVA = "0x631DE0", Offset = "0x6307E0", VA = "0x180631DE0")]
		private static List<PlayerSaveFile.HistoryIzakayaMenuSelection> GetUserIzakayaConfigInternal(int izakayaLevel)
		{
			return null;
		}

		// Token: 0x06003326 RID: 13094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003326")]
		[Address(RVA = "0x631F80", Offset = "0x630980", VA = "0x180631F80")]
		public static IEnumerable<PlayerSaveFile.HistoryIzakayaMenuSelection> GetUserIzakayaConfig(int izakayaLevel)
		{
			return null;
		}

		// Token: 0x06003327 RID: 13095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003327")]
		[Address(RVA = "0x62F230", Offset = "0x62DC30", VA = "0x18062F230")]
		public static void AddUserIzakayaConfig(int izakayaLevel, PlayerSaveFile.HistoryIzakayaMenuSelection newElement)
		{
		}

		// Token: 0x06003328 RID: 13096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003328")]
		[Address(RVA = "0x630030", Offset = "0x62EA30", VA = "0x180630030")]
		public static void DeleteUserIzakayaConfig(int izakayaLevel, int index)
		{
		}

		// Token: 0x06003329 RID: 13097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003329")]
		[Address(RVA = "0x635C60", Offset = "0x634660", VA = "0x180635C60")]
		public static void StickyUserIzakayaConfig(int izakayaLevel, int index)
		{
		}

		// Token: 0x0600332A RID: 13098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600332A")]
		[Address(RVA = "0x6310C0", Offset = "0x62FAC0", VA = "0x1806310C0")]
		public static IEnumerable<string> GetAllUnlockedMusicMapLabel()
		{
			return null;
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332B")]
		[Address(RVA = "0x62EC20", Offset = "0x62D620", VA = "0x18062EC20")]
		public static void AddUnlockedMusicMap(bool notify, params string[] mapLabel)
		{
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332C")]
		[Address(RVA = "0x62EBD0", Offset = "0x62D5D0", VA = "0x18062EBD0")]
		public static void AddUnlockedMusicMap(params string[] mapLabel)
		{
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x00012D08 File Offset: 0x00010F08
		[Token(Token = "0x600332D")]
		[Address(RVA = "0x62F720", Offset = "0x62E120", VA = "0x18062F720")]
		public static bool CheckCoreAllMusicChapterFinished()
		{
			return default(bool);
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x00012D20 File Offset: 0x00010F20
		[Token(Token = "0x600332E")]
		[Address(RVA = "0x6300B0", Offset = "0x62EAB0", VA = "0x1806300B0")]
		public static bool EnsureMusicScoreInitialized(string musicLabel)
		{
			return default(bool);
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x00012D38 File Offset: 0x00010F38
		[Token(Token = "0x600332F")]
		[Address(RVA = "0x635140", Offset = "0x633B40", VA = "0x180635140")]
		public static bool RecordMusicScore(string musicLabel, int score, bool easyMode)
		{
			return default(bool);
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x00012D50 File Offset: 0x00010F50
		[Token(Token = "0x6003330")]
		[Address(RVA = "0x635480", Offset = "0x633E80", VA = "0x180635480")]
		public static UniTask SaveMusicScoreData()
		{
			return default(UniTask);
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003331")]
		[Address(RVA = "0x62F460", Offset = "0x62DE60", VA = "0x18062F460")]
		public static void CheckAndUnlockNewMusicMapLabel(string mapLabel)
		{
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x00012D68 File Offset: 0x00010F68
		[Token(Token = "0x6003332")]
		[Address(RVA = "0x6315F0", Offset = "0x62FFF0", VA = "0x1806315F0")]
		public static ValueTuple<int, int> GetMusicScore(string musicLabel, bool bypassCompletionCheck)
		{
			return default(ValueTuple<int, int>);
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00012D80 File Offset: 0x00010F80
		[Token(Token = "0x6003333")]
		[Address(RVA = "0x631840", Offset = "0x630240", VA = "0x180631840")]
		public static int GetMusicScore(string musicLabel, bool isEasy, bool bypassCompletionCheck)
		{
			return 0;
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003334")]
		[Address(RVA = "0x634FD0", Offset = "0x6339D0", VA = "0x180634FD0")]
		public static void RecordChattedSGuestLabel(this string specialGuestLabel)
		{
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x00012D98 File Offset: 0x00010F98
		[Token(Token = "0x6003335")]
		[Address(RVA = "0x631FD0", Offset = "0x6309D0", VA = "0x180631FD0")]
		public static bool HaveRecordedChattedSGuest(string specialGuestLabel)
		{
			return default(bool);
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003336")]
		[Address(RVA = "0x631560", Offset = "0x62FF60", VA = "0x180631560")]
		public static List<int> GetLockedRecipesList()
		{
			return null;
		}

		// Token: 0x06003337 RID: 13111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003337")]
		[Address(RVA = "0x634730", Offset = "0x633130", VA = "0x180634730")]
		public static void ModifyLockedRecipesList(bool isAdded, params int[] recipeId)
		{
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x00012DB0 File Offset: 0x00010FB0
		[Token(Token = "0x6003338")]
		[Address(RVA = "0x62FB00", Offset = "0x62E500", VA = "0x18062FB00")]
		public static bool CheckRecipeIsLocked(int recipeId)
		{
			return default(bool);
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003339")]
		[Address(RVA = "0x631CE0", Offset = "0x6306E0", VA = "0x180631CE0")]
		public static int[] GetPopFoodTags(RunTimePlayerData.PopType popType)
		{
			return null;
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600333A")]
		[Address(RVA = "0x631BE0", Offset = "0x6305E0", VA = "0x180631BE0")]
		public static int[] GetPopBevTags(RunTimePlayerData.PopType popType)
		{
			return null;
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600333B")]
		[Address(RVA = "0x635510", Offset = "0x633F10", VA = "0x180635510")]
		public static void SetCanPerform(bool canPerform)
		{
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600333C")]
		[Address(RVA = "0x635B40", Offset = "0x634540", VA = "0x180635B40")]
		public static void SetShouldSpawnSpecialGuests(bool canPerform)
		{
		}

		// Token: 0x0600333D RID: 13117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600333D")]
		[Address(RVA = "0x6359F0", Offset = "0x6343F0", VA = "0x1806359F0")]
		public static void SetShouldHaveLevel5Kizuna(bool canPerform)
		{
		}

		// Token: 0x0600333E RID: 13118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600333E")]
		[Address(RVA = "0x635A80", Offset = "0x634480", VA = "0x180635A80")]
		public static void SetShouldShowSpecialGuestsInDay(bool canPerform)
		{
		}

		// Token: 0x0600333F RID: 13119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600333F")]
		[Address(RVA = "0x635BD0", Offset = "0x6345D0", VA = "0x180635BD0")]
		public static void SetShouldSpawnTewi(bool canPerform)
		{
		}

		// Token: 0x06003340 RID: 13120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003340")]
		[Address(RVA = "0x62E8B0", Offset = "0x62D2B0", VA = "0x18062E8B0")]
		public static void AddFund(int amount, bool suppressCallbacks = false)
		{
		}

		// Token: 0x06003341 RID: 13121 RVA: 0x00012DC8 File Offset: 0x00010FC8
		[Token(Token = "0x6003341")]
		[Address(RVA = "0x631200", Offset = "0x62FC00", VA = "0x180631200")]
		public static int GetCurrentLevelExp()
		{
			return 0;
		}

		// Token: 0x06003342 RID: 13122 RVA: 0x00012DE0 File Offset: 0x00010FE0
		[Token(Token = "0x6003342")]
		[Address(RVA = "0x631400", Offset = "0x62FE00", VA = "0x180631400")]
		private static int GetLevelUpExp()
		{
			return 0;
		}

		// Token: 0x06003343 RID: 13123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003343")]
		[Address(RVA = "0x62E640", Offset = "0x62D040", VA = "0x18062E640")]
		public static void AddExp(int amount)
		{
		}

		// Token: 0x06003344 RID: 13124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003344")]
		[Address(RVA = "0x62E530", Offset = "0x62CF30", VA = "0x18062E530")]
		public static void AddDay(int amount = 1)
		{
		}

		// Token: 0x06003345 RID: 13125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003345")]
		[Address(RVA = "0x634E50", Offset = "0x633850", VA = "0x180634E50")]
		public static void OverrideDay(int amount)
		{
		}

		// Token: 0x06003346 RID: 13126 RVA: 0x00012DF8 File Offset: 0x00010FF8
		[Token(Token = "0x6003346")]
		[Address(RVA = "0x631260", Offset = "0x62FC60", VA = "0x180631260")]
		public static GameDate GetDay()
		{
			return default(GameDate);
		}

		// Token: 0x06003347 RID: 13127 RVA: 0x00012E10 File Offset: 0x00011010
		[Token(Token = "0x6003347")]
		[Address(RVA = "0x631370", Offset = "0x62FD70", VA = "0x180631370")]
		public static long GetFund()
		{
			return 0L;
		}

		// Token: 0x06003348 RID: 13128 RVA: 0x00012E28 File Offset: 0x00011028
		[Token(Token = "0x6003348")]
		[Address(RVA = "0x6312E0", Offset = "0x62FCE0", VA = "0x1806312E0")]
		public static int GetExp()
		{
			return 0;
		}

		// Token: 0x06003349 RID: 13129 RVA: 0x00012E40 File Offset: 0x00011040
		[Token(Token = "0x6003349")]
		[Address(RVA = "0x6314D0", Offset = "0x62FED0", VA = "0x1806314D0")]
		public static int GetLevel()
		{
			return 0;
		}

		// Token: 0x0600334A RID: 13130 RVA: 0x00012E58 File Offset: 0x00011058
		[Token(Token = "0x600334A")]
		[Address(RVA = "0x634F40", Offset = "0x633940", VA = "0x180634F40")]
		public static int OverrideLevel(int newLevel)
		{
			return 0;
		}

		// Token: 0x0600334B RID: 13131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600334B")]
		[Address(RVA = "0x631170", Offset = "0x62FB70", VA = "0x180631170")]
		public static IEnumerable<ControlledSpecialGuest> GetControlledSpecialGuests()
		{
			return null;
		}

		// Token: 0x0600334C RID: 13132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334C")]
		[Address(RVA = "0x6355A0", Offset = "0x633FA0", VA = "0x1806355A0")]
		public static void SetControlledSpecialGuests(IEnumerable<ControlledSpecialGuest> controlledSpecialGuests)
		{
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334D")]
		[Address(RVA = "0x62FD80", Offset = "0x62E780", VA = "0x18062FD80")]
		public static void ClearAndDumpPlayerRuntimeData()
		{
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x0600334E RID: 13134 RVA: 0x00012E70 File Offset: 0x00011070
		[Token(Token = "0x170006E7")]
		public static bool CheckCreatorBoxActive
		{
			[Token(Token = "0x600334E")]
			[Address(RVA = "0x636D00", Offset = "0x635700", VA = "0x180636D00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600334F")]
		[Address(RVA = "0x634A80", Offset = "0x633480", VA = "0x180634A80")]
		public static void MountAndOverridePlayerRuntimeData(RunTimeStorage.RuntimePlayerDataCache cache)
		{
		}

		// Token: 0x06003351 RID: 13137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003351")]
		[Address(RVA = "0x635EB0", Offset = "0x6348B0", VA = "0x180635EB0")]
		[CompilerGenerated]
		internal static void <AddExp>g__LevelUp|244_0()
		{
		}

		// Token: 0x04002CE0 RID: 11488
		[Token(Token = "0x4002CE0")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] coreMaps;

		// Token: 0x04002CE1 RID: 11489
		[Token(Token = "0x4002CE1")]
		[FieldOffset(Offset = "0x8")]
		private static bool canOpenNoteStorageEscape;

		// Token: 0x04002CE2 RID: 11490
		[Token(Token = "0x4002CE2")]
		[FieldOffset(Offset = "0x10")]
		public static Action<bool> OnNoteStorageEscapeOpenStausChangeCallback;

		// Token: 0x04002CE3 RID: 11491
		[Token(Token = "0x4002CE3")]
		[FieldOffset(Offset = "0x18")]
		public static Action<int> OnLevelUpCallback;

		// Token: 0x04002CE4 RID: 11492
		[Token(Token = "0x4002CE4")]
		[FieldOffset(Offset = "0x20")]
		public static Action<int> OnFundChangeCallback;

		// Token: 0x04002CE5 RID: 11493
		[Token(Token = "0x4002CE5")]
		[FieldOffset(Offset = "0x28")]
		[TupleElementNames(new string[] { "EasyHighScore", "HardHighScore" })]
		private static Dictionary<string, ValueTuple<int, int>> musicScoreData;

		// Token: 0x02000834 RID: 2100
		[Token(Token = "0x2000834")]
		public enum PopType
		{
			// Token: 0x04002D10 RID: 11536
			[Token(Token = "0x4002D10")]
			Like,
			// Token: 0x04002D11 RID: 11537
			[Token(Token = "0x4002D11")]
			Hate
		}

		// Token: 0x02000835 RID: 2101
		[Token(Token = "0x2000835")]
		public enum TagType
		{
			// Token: 0x04002D13 RID: 11539
			[Token(Token = "0x4002D13")]
			Food,
			// Token: 0x04002D14 RID: 11540
			[Token(Token = "0x4002D14")]
			Beverage
		}
	}
}
