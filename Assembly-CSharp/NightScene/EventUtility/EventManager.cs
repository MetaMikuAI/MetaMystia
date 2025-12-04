using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Common.CharacterUtility;
using Cysharp.Threading.Tasks;
using DEYU.Singletons;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppDummyDll;
using JetBrains.Annotations;
using NightScene.GuestManagementUtility;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.EventUtility
{
	// Token: 0x020005DE RID: 1502
	[Token(Token = "0x20005DE")]
	[GenerateCleanupMethod]
	public class EventManager : MonoSingleton<EventManager>
	{
		// Token: 0x060022B7 RID: 8887 RVA: 0x0000CC60 File Offset: 0x0000AE60
		[Token(Token = "0x60022B7")]
		[Address(RVA = "0x4F36F0", Offset = "0x4F20F0", VA = "0x1804F36F0")]
		private GuestGroupController.EvaluationResult ConvertIntToEvaluationResult(int evalResult)
		{
			return GuestGroupController.EvaluationResult.Exbad;
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x0000CC78 File Offset: 0x0000AE78
		[Token(Token = "0x60022B8")]
		[Address(RVA = "0x4F8650", Offset = "0x4F7050", VA = "0x1804F8650")]
		public int GetPRDTryTime(string label)
		{
			return 0;
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B9")]
		[Address(RVA = "0x503860", Offset = "0x502260", VA = "0x180503860")]
		public void RecordPRDTryTime(string label, int tryTime)
		{
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x0000CC90 File Offset: 0x0000AE90
		[Token(Token = "0x170004B7")]
		private int MusicIndexFromServedGuest
		{
			[Token(Token = "0x60022BA")]
			[Address(RVA = "0x5152A0", Offset = "0x513CA0", VA = "0x1805152A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x060022BB RID: 8891 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		[Token(Token = "0x170004B8")]
		private int RealTimeCountDown
		{
			[Token(Token = "0x60022BB")]
			[Address(RVA = "0x5159B0", Offset = "0x5143B0", VA = "0x1805159B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060022BC RID: 8892 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		[Token(Token = "0x170004B9")]
		private float PassionSpawnMultiplier
		{
			[Token(Token = "0x60022BC")]
			[Address(RVA = "0x515680", Offset = "0x514080", VA = "0x180515680")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060022BD RID: 8893 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		[Token(Token = "0x170004BA")]
		private int PassionInterval
		{
			[Token(Token = "0x60022BD")]
			[Address(RVA = "0x50F160", Offset = "0x50DB60", VA = "0x18050F160")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		[Token(Token = "0x170004BB")]
		private float BuffSpawnMultiplier
		{
			[Token(Token = "0x60022BE")]
			[Address(RVA = "0x513010", Offset = "0x511A10", VA = "0x180513010")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x0000CD08 File Offset: 0x0000AF08
		[Token(Token = "0x170004BC")]
		private float BuffSpawnMultiplierForNormalGuests
		{
			[Token(Token = "0x60022BF")]
			[Address(RVA = "0x512D50", Offset = "0x511750", VA = "0x180512D50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060022C0 RID: 8896 RVA: 0x0000CD20 File Offset: 0x0000AF20
		[Token(Token = "0x170004BD")]
		private float BuffSpawnMultiplierForSpecialGuests
		{
			[Token(Token = "0x60022C0")]
			[Address(RVA = "0x512EB0", Offset = "0x5118B0", VA = "0x180512EB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x0000CD38 File Offset: 0x0000AF38
		// (set) Token: 0x060022C2 RID: 8898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BE")]
		private float LevelSpawnMultiplier
		{
			[Token(Token = "0x60022C1")]
			[Address(RVA = "0x514D20", Offset = "0x513720", VA = "0x180514D20")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60022C2")]
			[Address(RVA = "0x516F30", Offset = "0x515930", VA = "0x180516F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060022C3 RID: 8899 RVA: 0x0000CD50 File Offset: 0x0000AF50
		// (set) Token: 0x060022C4 RID: 8900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004BF")]
		private float DailyRecipeNumSpawnMultiplier
		{
			[Token(Token = "0x60022C3")]
			[Address(RVA = "0x5138B0", Offset = "0x5122B0", VA = "0x1805138B0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60022C4")]
			[Address(RVA = "0x516ED0", Offset = "0x5158D0", VA = "0x180516ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x0000CD68 File Offset: 0x0000AF68
		[Token(Token = "0x170004C0")]
		private float OrderCycleRateMultiplier
		{
			[Token(Token = "0x60022C5")]
			[Address(RVA = "0x5154C0", Offset = "0x513EC0", VA = "0x1805154C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060022C6 RID: 8902 RVA: 0x0000CD80 File Offset: 0x0000AF80
		[Token(Token = "0x170004C1")]
		private float PatienceDecreaseSpeedMultiplier
		{
			[Token(Token = "0x60022C6")]
			[Address(RVA = "0x5156C0", Offset = "0x5140C0", VA = "0x1805156C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060022C7 RID: 8903 RVA: 0x0000CD98 File Offset: 0x0000AF98
		[Token(Token = "0x170004C2")]
		private float EvalSpeedMultiplier
		{
			[Token(Token = "0x60022C7")]
			[Address(RVA = "0x513410", Offset = "0x511E10", VA = "0x180513410")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060022C8 RID: 8904 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		[Token(Token = "0x170004C3")]
		private float ExtraMoveSpeedMultiplier
		{
			[Token(Token = "0x60022C8")]
			[Address(RVA = "0x514470", Offset = "0x512E70", VA = "0x180514470")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		[Token(Token = "0x170004C4")]
		private float OrderSpeedMultiplier
		{
			[Token(Token = "0x60022C9")]
			[Address(RVA = "0x5135B0", Offset = "0x511FB0", VA = "0x1805135B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x060022CA RID: 8906 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		[Token(Token = "0x170004C5")]
		private float ExtraGenerateFundMultiplier
		{
			[Token(Token = "0x60022CA")]
			[Address(RVA = "0x514050", Offset = "0x512A50", VA = "0x180514050")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C6")]
		private int RegisteredQueuedGuestLeaveBuff
		{
			[Token(Token = "0x60022CB")]
			[Address(RVA = "0x45AA90", Offset = "0x459490", VA = "0x18045AA90")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60022CC")]
			[Address(RVA = "0x516FE0", Offset = "0x5159E0", VA = "0x180516FE0")]
			set
			{
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x0000CE10 File Offset: 0x0000B010
		// (set) Token: 0x060022CE RID: 8910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C7")]
		public int RegisteredDoNotCloseIzakayaStatus
		{
			[Token(Token = "0x60022CD")]
			[Address(RVA = "0x515A10", Offset = "0x514410", VA = "0x180515A10")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60022CE")]
			[Address(RVA = "0x516FD0", Offset = "0x5159D0", VA = "0x180516FD0")]
			set
			{
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x0000CE28 File Offset: 0x0000B028
		[Token(Token = "0x170004C8")]
		private bool CanExecuteSpellQueue
		{
			[Token(Token = "0x60022CF")]
			[Address(RVA = "0x513180", Offset = "0x511B80", VA = "0x180513180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060022D1 RID: 8913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004C9")]
		public Action OnTickUpdate
		{
			[Token(Token = "0x60022D0")]
			[Address(RVA = "0x5154B0", Offset = "0x513EB0", VA = "0x1805154B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60022D1")]
			[Address(RVA = "0x516FA0", Offset = "0x5159A0", VA = "0x180516FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CA")]
		public IEnumerable<int> LockedDailyRecipes
		{
			[Token(Token = "0x60022D2")]
			[Address(RVA = "0x514F80", Offset = "0x513980", VA = "0x180514F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060022D3 RID: 8915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CB")]
		public IEnumerable<int> LockedTrays
		{
			[Token(Token = "0x60022D3")]
			[Address(RVA = "0x515220", Offset = "0x513C20", VA = "0x180515220")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004CC")]
		public List<IEnumerable<int>> ExiledGuestIndexes
		{
			[Token(Token = "0x60022D4")]
			[Address(RVA = "0x5138D0", Offset = "0x5122D0", VA = "0x1805138D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x0000CE40 File Offset: 0x0000B040
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CD")]
		public bool ShouldTimeFlow
		{
			[Token(Token = "0x60022D5")]
			[Address(RVA = "0x5162E0", Offset = "0x514CE0", VA = "0x1805162E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022D6")]
			[Address(RVA = "0x517020", Offset = "0x515A20", VA = "0x180517020")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x060022D7 RID: 8919 RVA: 0x0000CE58 File Offset: 0x0000B058
		// (set) Token: 0x060022D8 RID: 8920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CE")]
		public bool ShouldGuestSpawn
		{
			[Token(Token = "0x60022D7")]
			[Address(RVA = "0x515DC0", Offset = "0x5147C0", VA = "0x180515DC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022D8")]
			[Address(RVA = "0x517000", Offset = "0x515A00", VA = "0x180517000")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x060022D9 RID: 8921 RVA: 0x0000CE70 File Offset: 0x0000B070
		// (set) Token: 0x060022DA RID: 8922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004CF")]
		public bool CanQueueSpell
		{
			[Token(Token = "0x60022D9")]
			[Address(RVA = "0x513220", Offset = "0x511C20", VA = "0x180513220")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022DA")]
			[Address(RVA = "0x516EB0", Offset = "0x5158B0", VA = "0x180516EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060022DB RID: 8923 RVA: 0x0000CE88 File Offset: 0x0000B088
		// (set) Token: 0x060022DC RID: 8924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D0")]
		public bool UseOverridePassionData
		{
			[Token(Token = "0x60022DB")]
			[Address(RVA = "0x5162F0", Offset = "0x514CF0", VA = "0x1805162F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022DC")]
			[Address(RVA = "0x517030", Offset = "0x515A30", VA = "0x180517030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x060022DD RID: 8925 RVA: 0x0000CEA0 File Offset: 0x0000B0A0
		// (set) Token: 0x060022DE RID: 8926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D1")]
		public int OverridePassionIndex
		{
			[Token(Token = "0x60022DD")]
			[Address(RVA = "0x515670", Offset = "0x514070", VA = "0x180515670")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60022DE")]
			[Address(RVA = "0x516FC0", Offset = "0x5159C0", VA = "0x180516FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
		// (set) Token: 0x060022E0 RID: 8928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D2")]
		public int EarnedFund
		{
			[Token(Token = "0x60022DF")]
			[Address(RVA = "0x5138C0", Offset = "0x5122C0", VA = "0x1805138C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60022E0")]
			[Address(RVA = "0x516EE0", Offset = "0x5158E0", VA = "0x180516EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x060022E1 RID: 8929 RVA: 0x0000CED0 File Offset: 0x0000B0D0
		// (set) Token: 0x060022E2 RID: 8930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D3")]
		public bool IsPassionLocked
		{
			[Token(Token = "0x60022E1")]
			[Address(RVA = "0x514C70", Offset = "0x513670", VA = "0x180514C70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022E2")]
			[Address(RVA = "0x516F20", Offset = "0x515920", VA = "0x180516F20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060022E3 RID: 8931 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		[Token(Token = "0x170004D4")]
		public bool NotShowTipFundExpGetMessage
		{
			[Token(Token = "0x60022E3")]
			[Address(RVA = "0x515390", Offset = "0x513D90", VA = "0x180515390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x0000CF00 File Offset: 0x0000B100
		[Token(Token = "0x170004D5")]
		public bool ShouldNotRecordGuestData
		{
			[Token(Token = "0x60022E4")]
			[Address(RVA = "0x515E50", Offset = "0x514850", VA = "0x180515E50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x0000CF18 File Offset: 0x0000B118
		[Token(Token = "0x170004D6")]
		public int CurrentMusicLevel
		{
			[Token(Token = "0x60022E5")]
			[Address(RVA = "0x513570", Offset = "0x511F70", VA = "0x180513570")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x0000CF30 File Offset: 0x0000B130
		// (set) Token: 0x060022E7 RID: 8935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D7")]
		public int LoseComboGuestSetNum
		{
			[Token(Token = "0x60022E6")]
			[Address(RVA = "0x515260", Offset = "0x513C60", VA = "0x180515260")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60022E7")]
			[Address(RVA = "0x516F40", Offset = "0x515940", VA = "0x180516F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x0000CF48 File Offset: 0x0000B148
		// (set) Token: 0x060022E9 RID: 8937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D8")]
		public int LoseComboTimeForPassion
		{
			[Token(Token = "0x60022E8")]
			[Address(RVA = "0x515270", Offset = "0x513C70", VA = "0x180515270")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60022E9")]
			[Address(RVA = "0x516F50", Offset = "0x515950", VA = "0x180516F50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x060022EA RID: 8938 RVA: 0x0000CF60 File Offset: 0x0000B160
		// (set) Token: 0x060022EB RID: 8939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004D9")]
		public int ServedGuestSetNum
		{
			[Token(Token = "0x60022EA")]
			[Address(RVA = "0x515A20", Offset = "0x514420", VA = "0x180515A20")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60022EB")]
			[Address(RVA = "0x516FF0", Offset = "0x5159F0", VA = "0x180516FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x060022EC RID: 8940 RVA: 0x0000CF78 File Offset: 0x0000B178
		// (set) Token: 0x060022ED RID: 8941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004DA")]
		public int TotalCountDown
		{
			[Token(Token = "0x60022EC")]
			[Address(RVA = "0x5159B0", Offset = "0x5143B0", VA = "0x1805159B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60022ED")]
			[Address(RVA = "0x3F8D90", Offset = "0x3F7790", VA = "0x1803F8D90")]
			set
			{
			}
		}

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x060022EE RID: 8942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004DB")]
		public IEnumerable<EventManager.FoodOverrideModifier> OverrideFoodArray
		{
			[Token(Token = "0x60022EE")]
			[Address(RVA = "0x515620", Offset = "0x514020", VA = "0x180515620")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x060022EF RID: 8943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004DC")]
		public int[] LockedTables
		{
			[Token(Token = "0x60022EF")]
			[Address(RVA = "0x5150C0", Offset = "0x513AC0", VA = "0x1805150C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x060022F0 RID: 8944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004DD")]
		public int[] PlayerCannotOpenTables
		{
			[Token(Token = "0x60022F0")]
			[Address(RVA = "0x515820", Offset = "0x514220", VA = "0x180515820")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x060022F1 RID: 8945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004DE")]
		public List<IEnumerable<int>> LockedCookersRaw
		{
			[Token(Token = "0x60022F1")]
			[Address(RVA = "0x514D30", Offset = "0x513730", VA = "0x180514D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x060022F2 RID: 8946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004DF")]
		public Vector3Int[] LockedCookers
		{
			[Token(Token = "0x60022F2")]
			[Address(RVA = "0x514D40", Offset = "0x513740", VA = "0x180514D40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x0000CF90 File Offset: 0x0000B190
		[Token(Token = "0x170004E0")]
		public bool ShouldSpawnBuff
		{
			[Token(Token = "0x60022F3")]
			[Address(RVA = "0x5161D0", Offset = "0x514BD0", VA = "0x1805161D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		[Token(Token = "0x170004E1")]
		public bool ShouldComboAdd
		{
			[Token(Token = "0x60022F4")]
			[Address(RVA = "0x515A30", Offset = "0x514430", VA = "0x180515A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		[Token(Token = "0x170004E2")]
		public bool ShouldGuestInstantEvaluate
		{
			[Token(Token = "0x60022F5")]
			[Address(RVA = "0x515B50", Offset = "0x514550", VA = "0x180515B50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x060022F6 RID: 8950 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		[Token(Token = "0x170004E3")]
		public bool ShouldGuestPatientFreeze
		{
			[Token(Token = "0x60022F6")]
			[Address(RVA = "0x515C60", Offset = "0x514660", VA = "0x180515C60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x060022F7 RID: 8951 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
		[Token(Token = "0x170004E4")]
		public int ExtraBuffTime
		{
			[Token(Token = "0x60022F7")]
			[Address(RVA = "0x513900", Offset = "0x512300", VA = "0x180513900")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060022F8 RID: 8952 RVA: 0x0000D008 File Offset: 0x0000B208
		[Token(Token = "0x170004E5")]
		public bool ShouldPlayerOpenThrowDeliverPanel
		{
			[Token(Token = "0x60022F8")]
			[Address(RVA = "0x515F70", Offset = "0x514970", VA = "0x180515F70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x0000D020 File Offset: 0x0000B220
		[Token(Token = "0x170004E6")]
		public bool ShouldPlayerThrowDeliver
		{
			[Token(Token = "0x60022F9")]
			[Address(RVA = "0x516050", Offset = "0x514A50", VA = "0x180516050")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x060022FA RID: 8954 RVA: 0x0000D038 File Offset: 0x0000B238
		[Token(Token = "0x170004E7")]
		public bool ShouldPartnerThrowDeliver
		{
			[Token(Token = "0x60022FA")]
			[Address(RVA = "0x515EF0", Offset = "0x5148F0", VA = "0x180515EF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x0000D050 File Offset: 0x0000B250
		[Token(Token = "0x170004E8")]
		public bool ShouldSakuyaTeleportDeliver
		{
			[Token(Token = "0x60022FB")]
			[Address(RVA = "0x516100", Offset = "0x514B00", VA = "0x180516100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x060022FC RID: 8956 RVA: 0x0000D068 File Offset: 0x0000B268
		[Token(Token = "0x170004E9")]
		public bool IsFreeCook
		{
			[Token(Token = "0x60022FC")]
			[Address(RVA = "0x514A80", Offset = "0x513480", VA = "0x180514A80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x0000D080 File Offset: 0x0000B280
		[Token(Token = "0x170004EA")]
		public bool IsFreeBevServe
		{
			[Token(Token = "0x60022FD")]
			[Address(RVA = "0x514950", Offset = "0x513350", VA = "0x180514950")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x0000D098 File Offset: 0x0000B298
		[Token(Token = "0x170004EB")]
		public bool IsPlayerFever
		{
			[Token(Token = "0x60022FE")]
			[Address(RVA = "0x514C80", Offset = "0x513680", VA = "0x180514C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		[Token(Token = "0x170004EC")]
		public bool CanGetSparrowQTEReward
		{
			[Token(Token = "0x60022FF")]
			[Address(RVA = "0x5131D0", Offset = "0x511BD0", VA = "0x1805131D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06002300 RID: 8960 RVA: 0x0000D0C8 File Offset: 0x0000B2C8
		[Token(Token = "0x170004ED")]
		public bool CanTriggerSpecialCooker
		{
			[Token(Token = "0x6002300")]
			[Address(RVA = "0x513230", Offset = "0x511C30", VA = "0x180513230")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06002301 RID: 8961 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
		[Token(Token = "0x170004EE")]
		public bool ShouldQueuedGuestLeaveWhenIzakayaClose
		{
			[Token(Token = "0x6002301")]
			[Address(RVA = "0x5160F0", Offset = "0x514AF0", VA = "0x1805160F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06002302 RID: 8962 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
		[Token(Token = "0x170004EF")]
		public bool CanCloseIzakaya
		{
			[Token(Token = "0x6002302")]
			[Address(RVA = "0x513170", Offset = "0x511B70", VA = "0x180513170")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x0000D110 File Offset: 0x0000B310
		[Token(Token = "0x170004F0")]
		public float ExtraFeeRate
		{
			[Token(Token = "0x6002303")]
			[Address(RVA = "0x513C50", Offset = "0x512650", VA = "0x180513C50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06002304 RID: 8964 RVA: 0x0000D128 File Offset: 0x0000B328
		[Token(Token = "0x170004F1")]
		public bool ShouldEvaluateUnderSparrowTune
		{
			[Token(Token = "0x6002304")]
			[Address(RVA = "0x515A80", Offset = "0x514480", VA = "0x180515A80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x0000D140 File Offset: 0x0000B340
		[Token(Token = "0x170004F2")]
		public bool ShouldShowRepellDialog
		{
			[Token(Token = "0x6002305")]
			[Address(RVA = "0x516180", Offset = "0x514B80", VA = "0x180516180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06002306 RID: 8966 RVA: 0x0000D158 File Offset: 0x0000B358
		[Token(Token = "0x170004F3")]
		public bool ShouldShowConvDialog
		{
			[Token(Token = "0x6002306")]
			[Address(RVA = "0x516180", Offset = "0x514B80", VA = "0x180516180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x0000D170 File Offset: 0x0000B370
		[Token(Token = "0x170004F4")]
		public bool HasCreatorBoxCoroutineEnd
		{
			[Token(Token = "0x6002307")]
			[Address(RVA = "0x5148E0", Offset = "0x5132E0", VA = "0x1805148E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06002308 RID: 8968 RVA: 0x0000D188 File Offset: 0x0000B388
		// (set) Token: 0x06002309 RID: 8969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004F5")]
		public int LoseComboTimes
		{
			[Token(Token = "0x6002308")]
			[Address(RVA = "0x515280", Offset = "0x513C80", VA = "0x180515280")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002309")]
			[Address(RVA = "0x516F60", Offset = "0x515960", VA = "0x180516F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600230A RID: 8970 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
		[Token(Token = "0x170004F6")]
		public int ExtraMoodAdd
		{
			[Token(Token = "0x600230A")]
			[Address(RVA = "0x514310", Offset = "0x512D10", VA = "0x180514310")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		[Token(Token = "0x170004F7")]
		public float FreeCookRate
		{
			[Token(Token = "0x600230B")]
			[Address(RVA = "0x514770", Offset = "0x513170", VA = "0x180514770")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x0600230C RID: 8972 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		[Token(Token = "0x170004F8")]
		public float ComboFeeRate
		{
			[Token(Token = "0x600230C")]
			[Address(RVA = "0x513280", Offset = "0x511C80", VA = "0x180513280")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600230D RID: 8973 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		[Token(Token = "0x600230D")]
		[Address(RVA = "0x4F6730", Offset = "0x4F5130", VA = "0x1804F6730")]
		public float GetComboFeeRate(int currentCombo)
		{
			return 0f;
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x0600230E RID: 8974 RVA: 0x0000D200 File Offset: 0x0000B400
		[Token(Token = "0x170004F9")]
		public float ExtraPartnerWage
		{
			[Token(Token = "0x600230E")]
			[Address(RVA = "0x5145D0", Offset = "0x512FD0", VA = "0x1805145D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x0000D218 File Offset: 0x0000B418
		[Token(Token = "0x170004FA")]
		public bool HaveExtraPartnerWage
		{
			[Token(Token = "0x600230F")]
			[Address(RVA = "0x514900", Offset = "0x513300", VA = "0x180514900")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06002310 RID: 8976 RVA: 0x0000D230 File Offset: 0x0000B430
		[Token(Token = "0x170004FB")]
		public float ExtraFundModifier
		{
			[Token(Token = "0x6002310")]
			[Address(RVA = "0x513EC0", Offset = "0x5128C0", VA = "0x180513EC0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06002311 RID: 8977 RVA: 0x0000D248 File Offset: 0x0000B448
		// (set) Token: 0x06002312 RID: 8978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FC")]
		public bool ShouldSkip
		{
			[Token(Token = "0x6002311")]
			[Address(RVA = "0x5161C0", Offset = "0x514BC0", VA = "0x1805161C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002312")]
			[Address(RVA = "0x517010", Offset = "0x515A10", VA = "0x180517010")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x0000D260 File Offset: 0x0000B460
		// (set) Token: 0x06002314 RID: 8980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FD")]
		public bool HasTimeDepeleted
		{
			[Token(Token = "0x6002313")]
			[Address(RVA = "0x5148F0", Offset = "0x5132F0", VA = "0x1805148F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002314")]
			[Address(RVA = "0x516F10", Offset = "0x515910", VA = "0x180516F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06002315 RID: 8981 RVA: 0x0000D278 File Offset: 0x0000B478
		// (set) Token: 0x06002316 RID: 8982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FE")]
		public bool HasBusinessEnd
		{
			[Token(Token = "0x6002315")]
			[Address(RVA = "0x5148D0", Offset = "0x5132D0", VA = "0x1805148D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002316")]
			[Address(RVA = "0x516F00", Offset = "0x515900", VA = "0x180516F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x0000D290 File Offset: 0x0000B490
		// (set) Token: 0x06002318 RID: 8984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004FF")]
		public int CurrentCombo
		{
			[Token(Token = "0x6002317")]
			[Address(RVA = "0x513400", Offset = "0x511E00", VA = "0x180513400")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002318")]
			[Address(RVA = "0x516EC0", Offset = "0x5158C0", VA = "0x180516EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06002319 RID: 8985 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		[Token(Token = "0x17000500")]
		public float CurrentOrderCycleRate
		{
			[Token(Token = "0x6002319")]
			[Address(RVA = "0x5135A0", Offset = "0x511FA0", VA = "0x1805135A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x0600231A RID: 8986 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		[Token(Token = "0x17000501")]
		public float CurrentOrderSpeedRate
		{
			[Token(Token = "0x600231A")]
			[Address(RVA = "0x5135B0", Offset = "0x511FB0", VA = "0x1805135B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x0600231B RID: 8987 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		[Token(Token = "0x17000502")]
		public int CurrentPatienceDecreaseSpeed
		{
			[Token(Token = "0x600231B")]
			[Address(RVA = "0x513710", Offset = "0x512110", VA = "0x180513710")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		[Token(Token = "0x17000503")]
		public float CurrentEvalSpeed
		{
			[Token(Token = "0x600231C")]
			[Address(RVA = "0x513410", Offset = "0x511E10", VA = "0x180513410")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x0600231D RID: 8989 RVA: 0x0000D308 File Offset: 0x0000B508
		[Token(Token = "0x17000504")]
		public bool ShouldGuestSpawnByBuff
		{
			[Token(Token = "0x600231D")]
			[Address(RVA = "0x515D70", Offset = "0x514770", VA = "0x180515D70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x0600231E RID: 8990 RVA: 0x0000D320 File Offset: 0x0000B520
		[Token(Token = "0x17000505")]
		public bool ShouldNormalGuestSpawn
		{
			[Token(Token = "0x600231E")]
			[Address(RVA = "0x515E20", Offset = "0x514820", VA = "0x180515E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x0000D338 File Offset: 0x0000B538
		[Token(Token = "0x17000506")]
		public bool ShouldNormalGuestInstantiateBySpecialBuff
		{
			[Token(Token = "0x600231F")]
			[Address(RVA = "0x515DD0", Offset = "0x5147D0", VA = "0x180515DD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x0000D350 File Offset: 0x0000B550
		[Token(Token = "0x17000507")]
		public bool ShouldSpecialGuestInstantiateBySpecialBuff
		{
			[Token(Token = "0x6002320")]
			[Address(RVA = "0x516240", Offset = "0x514C40", VA = "0x180516240")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06002321 RID: 8993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000508")]
		public List<float> PatienceDecreaseSpeedModifier
		{
			[Token(Token = "0x6002321")]
			[Address(RVA = "0x5156B0", Offset = "0x5140B0", VA = "0x1805156B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x0000D368 File Offset: 0x0000B568
		// (set) Token: 0x06002323 RID: 8995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000509")]
		public int LostFundWhenEnd
		{
			[Token(Token = "0x6002322")]
			[Address(RVA = "0x515290", Offset = "0x513C90", VA = "0x180515290")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002323")]
			[Address(RVA = "0x516F70", Offset = "0x515970", VA = "0x180516F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x0000D380 File Offset: 0x0000B580
		[Token(Token = "0x1700050A")]
		public int ExtraCostIngredients
		{
			[Token(Token = "0x6002324")]
			[Address(RVA = "0x513AE0", Offset = "0x5124E0", VA = "0x180513AE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x0000D398 File Offset: 0x0000B598
		[Token(Token = "0x1700050B")]
		public int ExtraCostBevs
		{
			[Token(Token = "0x6002325")]
			[Address(RVA = "0x513970", Offset = "0x512370", VA = "0x180513970")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06002326 RID: 8998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700050C")]
		public List<int> ExtraCookTags
		{
			[Token(Token = "0x6002326")]
			[Address(RVA = "0x513950", Offset = "0x512350", VA = "0x180513950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		[Token(Token = "0x1700050D")]
		public float ExtraGenerateFundRate
		{
			[Token(Token = "0x6002327")]
			[Address(RVA = "0x514050", Offset = "0x512A50", VA = "0x180514050")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06002328 RID: 9000 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002329 RID: 9001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700050E")]
		public Action<Transform, EventManager.RabbitType> OnRabbitSpawn
		{
			[Token(Token = "0x6002328")]
			[Address(RVA = "0x5154A0", Offset = "0x513EA0", VA = "0x1805154A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002329")]
			[Address(RVA = "0x516F80", Offset = "0x515980", VA = "0x180516F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x0600232A RID: 9002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700050F")]
		public List<EventManager.ExtraPayModifier> ExtraPayModifiers
		{
			[Token(Token = "0x600232A")]
			[Address(RVA = "0x514740", Offset = "0x513140", VA = "0x180514740")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000510")]
		public Dictionary<string, int> ExtraIntCollections
		{
			[Token(Token = "0x600232B")]
			[Address(RVA = "0x5141E0", Offset = "0x512BE0", VA = "0x1805141E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600232C RID: 9004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000511")]
		public Dictionary<string, bool> ExtraBoolCollections
		{
			[Token(Token = "0x600232C")]
			[Address(RVA = "0x5138E0", Offset = "0x5122E0", VA = "0x1805138E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600232D RID: 9005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000512")]
		public Dictionary<string, GameObject> ExtraGameObjectCollections
		{
			[Token(Token = "0x600232D")]
			[Address(RVA = "0x514030", Offset = "0x512A30", VA = "0x180514030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		[Token(Token = "0x600232E")]
		public bool CheckExtraCollectionValueExist<T>(string key, Dictionary<string, T> targetDictionary)
		{
			return default(bool);
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600232F")]
		public T GetExtraCollectionValue<T>(string key, Dictionary<string, T> targetDictionary)
		{
			return null;
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002330")]
		public void SetExtraCollectionValue<T>(string key, T newValue, Dictionary<string, T> targetDictionary)
		{
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002331")]
		public void RemoveExtraCollectionValue<T>(string key, Dictionary<string, T> targetDictionary)
		{
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06002332 RID: 9010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000513")]
		public Dictionary<string, List<int>> ExtraIntListCollections
		{
			[Token(Token = "0x6002332")]
			[Address(RVA = "0x5141F0", Offset = "0x512BF0", VA = "0x1805141F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06002333 RID: 9011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000514")]
		public Dictionary<string, List<string>> ExtraStringListCollections
		{
			[Token(Token = "0x6002333")]
			[Address(RVA = "0x514750", Offset = "0x513150", VA = "0x180514750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06002334 RID: 9012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000515")]
		public Dictionary<string, List<GuestGroupController>> ExtraGuestGroupListCollections
		{
			[Token(Token = "0x6002334")]
			[Address(RVA = "0x5141C0", Offset = "0x512BC0", VA = "0x1805141C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06002335 RID: 9013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000516")]
		public Dictionary<string, List<ValueTuple<GuestGroupController, int>>> ExtraGuestGroupAndIntListCollections
		{
			[Token(Token = "0x6002335")]
			[Address(RVA = "0x5141B0", Offset = "0x512BB0", VA = "0x1805141B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06002336 RID: 9014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000517")]
		public Dictionary<string, List<ValueTuple<int, int>>> ExtraIntAndIntListCollections
		{
			[Token(Token = "0x6002336")]
			[Address(RVA = "0x5141D0", Offset = "0x512BD0", VA = "0x1805141D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06002337 RID: 9015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000518")]
		public Dictionary<string, List<bool>> ExtraBoolListCollections
		{
			[Token(Token = "0x6002337")]
			[Address(RVA = "0x5138F0", Offset = "0x5122F0", VA = "0x1805138F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06002338 RID: 9016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000519")]
		public Dictionary<string, List<GameObject>> ExtraGameObjectListCollections
		{
			[Token(Token = "0x6002338")]
			[Address(RVA = "0x514040", Offset = "0x512A40", VA = "0x180514040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06002339 RID: 9017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051A")]
		public Dictionary<string, List<Coroutine>> ExtraCoroutineListCollections
		{
			[Token(Token = "0x6002339")]
			[Address(RVA = "0x513960", Offset = "0x512360", VA = "0x180513960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600233A RID: 9018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700051B")]
		public Dictionary<string, List<AStarInputGeneratorComponent>> ExtraCharacterListCollections
		{
			[Token(Token = "0x600233A")]
			[Address(RVA = "0x513940", Offset = "0x512340", VA = "0x180513940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x0000D3E0 File Offset: 0x0000B5E0
		[Token(Token = "0x600233B")]
		public int GetExtraCollectionListValueNum<T>(string key, Dictionary<string, List<T>> targetDictionary)
		{
			return 0;
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600233C")]
		public List<T> GetExtraCollectionsList<T>(string key, Dictionary<string, List<T>> targetDictionary)
		{
			return null;
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
		[Token(Token = "0x600233D")]
		public bool CheckExtraCollectionExistInList<T>(string key, T value, Dictionary<string, List<T>> targetDictionary)
		{
			return default(bool);
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233E")]
		public void AddElementToExtraCollectionsList<T>(string key, T value, Dictionary<string, List<T>> targetDictionary)
		{
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600233F")]
		public void RemoveElementFromExtraCollectionsList<T>(string key, T value, Dictionary<string, List<T>> targetDictionary)
		{
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x0000D410 File Offset: 0x0000B610
		[Token(Token = "0x6002340")]
		[Address(RVA = "0x50DC50", Offset = "0x50C650", VA = "0x18050DC50")]
		public float TotalGuestSpawnSpeed(GuestsManager.GuestType guestType)
		{
			return 0f;
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002341")]
		[Address(RVA = "0x4F0270", Offset = "0x4EEC70", VA = "0x1804F0270")]
		public void ARabbitSpawn(Transform rabbit, EventManager.RabbitType rabbitType)
		{
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002342")]
		[Address(RVA = "0x501FC0", Offset = "0x5009C0", VA = "0x180501FC0")]
		public void ModifyTotalTime(int time)
		{
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x0000D428 File Offset: 0x0000B628
		[Token(Token = "0x6002343")]
		[Address(RVA = "0x4F6E00", Offset = "0x4F5800", VA = "0x1804F6E00")]
		private float GetExtraPartnerMoveSpeed(int partnerId, int partnerIndex)
		{
			return 0f;
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x0000D440 File Offset: 0x0000B640
		[Token(Token = "0x6002344")]
		[Address(RVA = "0x4F68A0", Offset = "0x4F52A0", VA = "0x1804F68A0")]
		public float GetExtraPartnerCookSpeed(int partnerId, int partnerIndex)
		{
			return 0f;
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x0000D458 File Offset: 0x0000B658
		[Token(Token = "0x6002345")]
		[Address(RVA = "0x4F7360", Offset = "0x4F5D60", VA = "0x1804F7360")]
		public float GetExtraPartnerWorkSpeed(int partnerId, int partnerIndex)
		{
			return 0f;
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x0000D470 File Offset: 0x0000B670
		[Token(Token = "0x6002346")]
		[Address(RVA = "0x4FB720", Offset = "0x4FA120", VA = "0x1804FB720")]
		public bool IsNotExecutingSpellLoop()
		{
			return default(bool);
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x0000D488 File Offset: 0x0000B688
		[Token(Token = "0x6002347")]
		[Address(RVA = "0x50D6C0", Offset = "0x50C0C0", VA = "0x18050D6C0")]
		public bool TestTimeDepletion(int extraOffset)
		{
			return default(bool);
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		[Token(Token = "0x6002348")]
		[Address(RVA = "0x4F25D0", Offset = "0x4F0FD0", VA = "0x1804F25D0")]
		public bool CheckThisOutputCanBeMade(Recipe recipe, Sellable output)
		{
			return default(bool);
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002349")]
		[Address(RVA = "0x4F14E0", Offset = "0x4EFEE0", VA = "0x1804F14E0")]
		public void AddOutputChecker(EventManager.OutputChecker outputChecker, out Action removeCallback)
		{
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		[Token(Token = "0x600234A")]
		[Address(RVA = "0x4F81C0", Offset = "0x4F6BC0", VA = "0x1804F81C0")]
		public float GetMultiplierOnTargetFoodTagAndCookerCombo(IEnumerable<int> tags, Cooker.CookerType cookerType, bool useExtraCookTimeModifier = true)
		{
			return 0f;
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		[Token(Token = "0x600234B")]
		[Address(RVA = "0x4F82D0", Offset = "0x4F6CD0", VA = "0x1804F82D0")]
		public float GetMultiplierOnTargetFoodTagAndCookerCombo(Sellable sellable, Cooker.CookerType cookerType, float baseCookTime, bool useExtraCookTimeModifier = true)
		{
			return 0f;
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		[Token(Token = "0x600234C")]
		[Address(RVA = "0x4F58E0", Offset = "0x4F42E0", VA = "0x1804F58E0")]
		private float FinalMultiplierOnTargetFoodTagAndCookerCombo(bool useExtraCookTimeModifier, IEnumerable<EventManager.CookTimeModifier> fillteredModifier)
		{
			return 0f;
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x0000D500 File Offset: 0x0000B700
		[Token(Token = "0x600234D")]
		[Address(RVA = "0x4F6310", Offset = "0x4F4D10", VA = "0x1804F6310")]
		public float GetAdditiveContinueProbabilityOnTargetFoodTagAndCookerCombo(Sellable sellable, GuestGroupController guestGroupController)
		{
			return 0f;
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x0000D518 File Offset: 0x0000B718
		[Token(Token = "0x600234E")]
		[Address(RVA = "0x4F83F0", Offset = "0x4F6DF0", VA = "0x1804F83F0")]
		public bool GetOverrideFood(IEnumerable<int> foodTags, out int newFoodId)
		{
			return default(bool);
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x0000D530 File Offset: 0x0000B730
		[Token(Token = "0x600234F")]
		[Address(RVA = "0x4F2470", Offset = "0x4F0E70", VA = "0x1804F2470")]
		public bool CheckTargetGuestHasExiled(int guestId)
		{
			return default(bool);
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x0000D548 File Offset: 0x0000B748
		[Token(Token = "0x6002350")]
		[Address(RVA = "0x4F78C0", Offset = "0x4F62C0", VA = "0x1804F78C0")]
		public int GetFinalEval(Sellable food, Sellable bev, GuestGroupController.EvaluationResult lastEvaluation, GuestGroupController guestGroupController)
		{
			return 0;
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002351")]
		[Address(RVA = "0x503470", Offset = "0x501E70", VA = "0x180503470")]
		public void RandomSelectBuff(int removedNum, out Guid[] getGuids)
		{
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002352")]
		[Address(RVA = "0x507380", Offset = "0x505D80", VA = "0x180507380")]
		public void RemoveRandomBuff(Guid[] getGuids)
		{
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002353")]
		[Address(RVA = "0x5066B0", Offset = "0x5050B0", VA = "0x1805066B0")]
		public void RemoveAllRegisteredTimedBuff(EventManager.BuffType buffType, bool instantSpawnNewBuff = true)
		{
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002354")]
		[Address(RVA = "0x5069D0", Offset = "0x5053D0", VA = "0x1805069D0")]
		public void RemoveAllRegisteredTimedBuff()
		{
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002355")]
		[Address(RVA = "0x5063D0", Offset = "0x504DD0", VA = "0x1805063D0")]
		public void RemoveAllCountedBuff()
		{
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002356")]
		[Address(RVA = "0x507A80", Offset = "0x506480", VA = "0x180507A80")]
		public void ScheduleSpellExecution(Func<Action, IEnumerator> spellHandle)
		{
		}

		// Token: 0x06002357 RID: 9047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002357")]
		[Address(RVA = "0x501F80", Offset = "0x500980", VA = "0x180501F80")]
		public void ModifyTime(int amount)
		{
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002358")]
		[Address(RVA = "0x501F40", Offset = "0x500940", VA = "0x180501F40")]
		public void ModifyTimeAdd(int amount)
		{
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002359")]
		[Address(RVA = "0x4FBD30", Offset = "0x4FA730", VA = "0x1804FBD30")]
		public IEnumerator LerpPosition(Transform source, Func<Vector3> targetPosition, float duration)
		{
			return null;
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235A")]
		[Address(RVA = "0x4FBAB0", Offset = "0x4FA4B0", VA = "0x1804FBAB0")]
		public IEnumerator LerpBezier(Transform source, Func<Vector3> controlPosition, Func<Vector3> targetPosition, float duration, bool forceRotate)
		{
			return null;
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235B")]
		[Address(RVA = "0x4FB9C0", Offset = "0x4FA3C0", VA = "0x1804FB9C0")]
		public IEnumerator LerpBezierCubic(Transform source, Func<Vector3> control1Position, Func<Vector3> control2Position, Func<Vector3> targetPosition, float duration, bool forceRotate)
		{
			return null;
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235C")]
		[Address(RVA = "0x4FBC60", Offset = "0x4FA660", VA = "0x1804FBC60")]
		public IEnumerator LerpParabolic(Transform source, Func<Vector3> targetPosition, float launchHeight, float launchSpeed, bool forceRotate)
		{
			return null;
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235D")]
		[Address(RVA = "0x4FBDF0", Offset = "0x4FA7F0", VA = "0x1804FBDF0")]
		public IEnumerator LerpTimedParabolic(Transform source, Func<Vector3> targetPosition, float launchHeight, float duration, bool forceRotate)
		{
			return null;
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235E")]
		[Address(RVA = "0x4F9BD0", Offset = "0x4F85D0", VA = "0x1804F9BD0")]
		public IEnumerator Homing(Transform source, Func<Vector3> targetPosition, float speed, float miniumAnglarSpeed, float maxinumAngularSpeed, float distanceOffset = 0.5f)
		{
			return null;
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600235F")]
		[Address(RVA = "0x4F9DD0", Offset = "0x4F87D0", VA = "0x1804F9DD0")]
		public IEnumerator Homing(Transform source, Func<Vector3> targetPosition, Func<float> speed, Func<float> miniumAnglarSpeed, Func<float> maxinumAngularSpeed, float distanceOffset = 0.5f)
		{
			return null;
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002360")]
		[Address(RVA = "0x4FBB90", Offset = "0x4FA590", VA = "0x1804FBB90")]
		private IEnumerator LerpInternal(Transform source, Func<Vector3> targetPosition, Func<Vector3, Vector3, float, Vector3> lerpMethod, Func<float, float> progressIncrementMethod, bool forceRotate)
		{
			return null;
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06002361 RID: 9057 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002362 RID: 9058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000011")]
		public event Action<int> OnFundUpdateCallback
		{
			[Token(Token = "0x6002361")]
			[Address(RVA = "0x512550", Offset = "0x510F50", VA = "0x180512550")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002362")]
			[Address(RVA = "0x5166A0", Offset = "0x5150A0", VA = "0x1805166A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06002363 RID: 9059 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002364 RID: 9060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000012")]
		public event Action<int, int> OnPassionUpdateCallback
		{
			[Token(Token = "0x6002363")]
			[Address(RVA = "0x512A50", Offset = "0x511450", VA = "0x180512A50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002364")]
			[Address(RVA = "0x516BA0", Offset = "0x5155A0", VA = "0x180516BA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06002365 RID: 9061 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002366 RID: 9062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000013")]
		public event Action<int> OnPassionIntervalUpdateCallback
		{
			[Token(Token = "0x6002365")]
			[Address(RVA = "0x512990", Offset = "0x511390", VA = "0x180512990")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002366")]
			[Address(RVA = "0x516AE0", Offset = "0x5154E0", VA = "0x180516AE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06002367 RID: 9063 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002368 RID: 9064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000014")]
		public event Action<int> OnMusicIndexUpdateCallback
		{
			[Token(Token = "0x6002367")]
			[Address(RVA = "0x512770", Offset = "0x511170", VA = "0x180512770")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002368")]
			[Address(RVA = "0x5168C0", Offset = "0x5152C0", VA = "0x1805168C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06002369 RID: 9065 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600236A RID: 9066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000015")]
		public event Action<int> OnComboUpdateCallback
		{
			[Token(Token = "0x6002369")]
			[Address(RVA = "0x512270", Offset = "0x510C70", VA = "0x180512270")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600236A")]
			[Address(RVA = "0x5163C0", Offset = "0x514DC0", VA = "0x1805163C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x0600236B RID: 9067 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600236C RID: 9068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000016")]
		public event Action OnLoseAllComboCallback
		{
			[Token(Token = "0x600236B")]
			[Address(RVA = "0x5126C0", Offset = "0x5110C0", VA = "0x1805126C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600236C")]
			[Address(RVA = "0x516810", Offset = "0x515210", VA = "0x180516810")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600236D RID: 9069 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600236E RID: 9070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000017")]
		public event Action<int> OnExpUpdateCallback
		{
			[Token(Token = "0x600236D")]
			[Address(RVA = "0x512330", Offset = "0x510D30", VA = "0x180512330")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600236E")]
			[Address(RVA = "0x516480", Offset = "0x514E80", VA = "0x180516480")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x0600236F RID: 9071 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002370 RID: 9072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000018")]
		public event Action<float> OnTimeUpdateCallback
		{
			[Token(Token = "0x600236F")]
			[Address(RVA = "0x512C80", Offset = "0x511680", VA = "0x180512C80")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002370")]
			[Address(RVA = "0x516DD0", Offset = "0x5157D0", VA = "0x180516DD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x06002371 RID: 9073 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002372 RID: 9074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000019")]
		public event Action OnNGuestInstantiateCallback
		{
			[Token(Token = "0x6002371")]
			[Address(RVA = "0x512830", Offset = "0x511230", VA = "0x180512830")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002372")]
			[Address(RVA = "0x516980", Offset = "0x515380", VA = "0x180516980")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06002373 RID: 9075 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002374 RID: 9076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001A")]
		public event Action OnPasserbyGuestInstantiateCallback
		{
			[Token(Token = "0x6002373")]
			[Address(RVA = "0x5128E0", Offset = "0x5112E0", VA = "0x1805128E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002374")]
			[Address(RVA = "0x516A30", Offset = "0x515430", VA = "0x180516A30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06002375 RID: 9077 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002376 RID: 9078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001B")]
		public event Action<int> OnSGuestInstantiateCallback
		{
			[Token(Token = "0x6002375")]
			[Address(RVA = "0x512B10", Offset = "0x511510", VA = "0x180512B10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002376")]
			[Address(RVA = "0x516C60", Offset = "0x515660", VA = "0x180516C60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x06002377 RID: 9079 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002378 RID: 9080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001C")]
		public event Action OnIGuestInstantiateCallback
		{
			[Token(Token = "0x6002377")]
			[Address(RVA = "0x512610", Offset = "0x511010", VA = "0x180512610")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002378")]
			[Address(RVA = "0x516760", Offset = "0x515160", VA = "0x180516760")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06002379 RID: 9081 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600237A RID: 9082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001D")]
		public event Action<int> OnAccumulatedComboCallback
		{
			[Token(Token = "0x6002379")]
			[Address(RVA = "0x5121B0", Offset = "0x510BB0", VA = "0x1805121B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600237A")]
			[Address(RVA = "0x516300", Offset = "0x514D00", VA = "0x180516300")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x0600237B RID: 9083 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600237C RID: 9084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001E")]
		public event Action OnSkipButtonConfirmedCallback
		{
			[Token(Token = "0x600237B")]
			[Address(RVA = "0x512BD0", Offset = "0x5115D0", VA = "0x180512BD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600237C")]
			[Address(RVA = "0x516D20", Offset = "0x515720", VA = "0x180516D20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400001F RID: 31
		// (add) Token: 0x0600237D RID: 9085 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600237E RID: 9086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400001F")]
		public event Action OnFeverModeStartCallback
		{
			[Token(Token = "0x600237D")]
			[Address(RVA = "0x5124A0", Offset = "0x510EA0", VA = "0x1805124A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600237E")]
			[Address(RVA = "0x5165F0", Offset = "0x514FF0", VA = "0x1805165F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000020 RID: 32
		// (add) Token: 0x0600237F RID: 9087 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002380 RID: 9088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000020")]
		public event Action OnFeverModeEndCallback
		{
			[Token(Token = "0x600237F")]
			[Address(RVA = "0x5123F0", Offset = "0x510DF0", VA = "0x1805123F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002380")]
			[Address(RVA = "0x516540", Offset = "0x514F40", VA = "0x180516540")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06002381 RID: 9089 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002382 RID: 9090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051C")]
		public EventManager.BuffFrozenCheckDelegate BuffFrozenCheckCallback
		{
			[Token(Token = "0x6002381")]
			[Address(RVA = "0x512D40", Offset = "0x511740", VA = "0x180512D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002382")]
			[Address(RVA = "0x516E90", Offset = "0x515890", VA = "0x180516E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06002383 RID: 9091 RVA: 0x0000D560 File Offset: 0x0000B760
		// (set) Token: 0x06002384 RID: 9092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700051D")]
		public bool ForceCouldModifyTime
		{
			[Token(Token = "0x6002383")]
			[Address(RVA = "0x514760", Offset = "0x513160", VA = "0x180514760")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002384")]
			[Address(RVA = "0x516EF0", Offset = "0x5158F0", VA = "0x180516EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002385")]
		[Address(RVA = "0x4F1E30", Offset = "0x4F0830", VA = "0x1804F1E30")]
		public void CallExternOnFundUpdate(int value)
		{
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002386")]
		[Address(RVA = "0x4F1EF0", Offset = "0x4F08F0", VA = "0x1804F1EF0")]
		public void CallExternOnPassionUpdate(int value, int musicLevel)
		{
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002387")]
		[Address(RVA = "0x4F1ED0", Offset = "0x4F08D0", VA = "0x1804F1ED0")]
		public void CallExternOnPassionIntervalUpdate(int value)
		{
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002388")]
		[Address(RVA = "0x4F1E70", Offset = "0x4F0870", VA = "0x1804F1E70")]
		public void CallExternOnMusicIndexUpdate(int value)
		{
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002389")]
		[Address(RVA = "0x4F1DF0", Offset = "0x4F07F0", VA = "0x1804F1DF0")]
		public void CallExternOnComboUpdate(int value)
		{
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238A")]
		[Address(RVA = "0x4F1E10", Offset = "0x4F0810", VA = "0x1804F1E10")]
		public void CallExternOnExpUpdate(int value)
		{
		}

		// Token: 0x0600238B RID: 9099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238B")]
		[Address(RVA = "0x4F1F50", Offset = "0x4F0950", VA = "0x1804F1F50")]
		public void CallExternOnTimeUpdate(float value)
		{
		}

		// Token: 0x0600238C RID: 9100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238C")]
		[Address(RVA = "0x4F1E90", Offset = "0x4F0890", VA = "0x1804F1E90")]
		public void CallExternOnNGuestInstantiate()
		{
		}

		// Token: 0x0600238D RID: 9101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238D")]
		[Address(RVA = "0x4F1EB0", Offset = "0x4F08B0", VA = "0x1804F1EB0")]
		public void CallExternOnPasserbyGuestInstantiate()
		{
		}

		// Token: 0x0600238E RID: 9102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238E")]
		[Address(RVA = "0x4F1F10", Offset = "0x4F0910", VA = "0x1804F1F10")]
		public void CallExternOnSGuestInstantiate(int value)
		{
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600238F")]
		[Address(RVA = "0x4F1E50", Offset = "0x4F0850", VA = "0x1804F1E50")]
		public void CallExternOnIGuestInstantiate()
		{
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002390")]
		[Address(RVA = "0x4F1DD0", Offset = "0x4F07D0", VA = "0x1804F1DD0")]
		public void CallExternAccumulatedCombo(int value)
		{
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002391")]
		[Address(RVA = "0x4F1F30", Offset = "0x4F0930", VA = "0x1804F1F30")]
		public void CallExternOnSkipButtonConfirmed()
		{
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002392")]
		[Address(RVA = "0x4FA3D0", Offset = "0x4F8DD0", VA = "0x1804FA3D0")]
		public Action Initialize()
		{
			return null;
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002393")]
		[Address(RVA = "0x502710", Offset = "0x501110", VA = "0x180502710", Slot = "5")]
		protected sealed override void OnInstanceDestroyed()
		{
		}

		// Token: 0x06002394 RID: 9108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002394")]
		[Address(RVA = "0x4F0290", Offset = "0x4EEC90", VA = "0x1804F0290")]
		public void AbortAndDisableSpellLoop()
		{
		}

		// Token: 0x06002395 RID: 9109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002395")]
		[Address(RVA = "0x50BEF0", Offset = "0x50A8F0", VA = "0x18050BEF0")]
		public void StartGuestSpawningAndTiming(int gameTotalSeconds)
		{
		}

		// Token: 0x06002396 RID: 9110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002396")]
		[Address(RVA = "0x50C000", Offset = "0x50AA00", VA = "0x18050C000")]
		public void StartKyoukoTutorial(Action onChallengeEndCallback, Action onTimelineEndCallback)
		{
		}

		// Token: 0x06002397 RID: 9111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002397")]
		[Address(RVA = "0x50DE60", Offset = "0x50C860", VA = "0x18050DE60")]
		public void TransitCharacter(AStarInputGeneratorComponent guestInstance)
		{
		}

		// Token: 0x06002398 RID: 9112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002398")]
		[Address(RVA = "0x4FA320", Offset = "0x4F8D20", VA = "0x1804FA320")]
		public void InitializeUI(Action<int> fund, Action<int, int> passion, Action<int> combo, Action<int> exp, Action<float> time)
		{
		}

		// Token: 0x06002399 RID: 9113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002399")]
		[Address(RVA = "0x4F9F30", Offset = "0x4F8930", VA = "0x1804F9F30")]
		public void InitializeTracker()
		{
		}

		// Token: 0x0600239A RID: 9114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239A")]
		[Address(RVA = "0x50A920", Offset = "0x509320", VA = "0x18050A920")]
		public void SetMusicPlayMode(bool makePassionAffectMusic)
		{
		}

		// Token: 0x0600239B RID: 9115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600239B")]
		[Address(RVA = "0x4F9EB0", Offset = "0x4F88B0", VA = "0x1804F9EB0")]
		public void InitializeGuestAndTracker(Action onNGuestInstantiate, Action onPasserbyGuestInstantiate, Action<int> onSpecialGuestInstantiate, Action onIGuestInstantiate)
		{
		}

		// Token: 0x0600239C RID: 9116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600239C")]
		[Address(RVA = "0x4F2060", Offset = "0x4F0A60", VA = "0x1804F2060")]
		public IEnumerator CallSpellDeclaration(Sprite portrayal, LanguageBase text, bool isSeija = false)
		{
			return null;
		}

		// Token: 0x0600239D RID: 9117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600239D")]
		[Address(RVA = "0x4F1F70", Offset = "0x4F0970", VA = "0x1804F1F70")]
		public IEnumerator CallSpellDeclaration(SpecialGuest guestData, LanguageBase text, bool isPositiveSpellCard, bool isSeija = false, bool forceAnim = false, [CanBeNull] [Optional] LanguageBase overrideGuestName)
		{
			return null;
		}

		// Token: 0x0600239E RID: 9118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600239E")]
		[Address(RVA = "0x4FAF70", Offset = "0x4F9970", VA = "0x1804FAF70")]
		protected IEnumerator InstantiateTimedC(GameObject parent, Transform transform, Action<GameObject> objectProcessingCallback, float duration)
		{
			return null;
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x0000D578 File Offset: 0x0000B778
		[Token(Token = "0x600239F")]
		[Address(RVA = "0x500980", Offset = "0x4FF380", VA = "0x180500980")]
		public int MathValue(int original, float value, EventManager.MathOperation mathOperation)
		{
			return 0;
		}

		// Token: 0x060023A0 RID: 9120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A0")]
		[Address(RVA = "0x4F34A0", Offset = "0x4F1EA0", VA = "0x1804F34A0")]
		public void ClearSpellQueue()
		{
		}

		// Token: 0x060023A1 RID: 9121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A1")]
		[Address(RVA = "0x4F4AA0", Offset = "0x4F34A0", VA = "0x1804F4AA0")]
		private void ExecuteSpellQueue()
		{
		}

		// Token: 0x060023A2 RID: 9122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A2")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500")]
		private void DeductActiveSpellCount()
		{
		}

		// Token: 0x060023A3 RID: 9123 RVA: 0x0000D590 File Offset: 0x0000B790
		[Token(Token = "0x60023A3")]
		[Address(RVA = "0x502560", Offset = "0x500F60", VA = "0x180502560")]
		private UniTask OnExecutingSpellQueue()
		{
			return default(UniTask);
		}

		// Token: 0x060023A4 RID: 9124 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		[Token(Token = "0x60023A4")]
		[Address(RVA = "0x50E590", Offset = "0x50CF90", VA = "0x18050E590")]
		public bool TryGetBuffTime(EventManager.BuffType buffType, out int[] registeredBuffDuration)
		{
			return default(bool);
		}

		// Token: 0x060023A5 RID: 9125 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
		[Token(Token = "0x60023A5")]
		[Address(RVA = "0x4F2770", Offset = "0x4F1170", VA = "0x1804F2770")]
		public bool CheckTimedBuffExists(EventManager.BuffType buffType)
		{
			return default(bool);
		}

		// Token: 0x060023A6 RID: 9126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023A6")]
		[Address(RVA = "0x4F8750", Offset = "0x4F7150", VA = "0x1804F8750")]
		public IEnumerable<EventManager.ScheduledFunction> GetTimedBuffScheduledFunctions(EventManager.BuffType buffType)
		{
			return null;
		}

		// Token: 0x060023A7 RID: 9127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023A7")]
		[Address(RVA = "0x509FC0", Offset = "0x5089C0", VA = "0x180509FC0")]
		public void SetExtraBuffRemainingTime(EventManager.BuffType buffType, int extraTime)
		{
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
		[Token(Token = "0x60023A8")]
		[Address(RVA = "0x4F2410", Offset = "0x4F0E10", VA = "0x1804F2410")]
		public bool CheckCountedBuffExists(EventManager.BuffType buffType)
		{
			return default(bool);
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		[Token(Token = "0x60023A9")]
		[Address(RVA = "0x50E700", Offset = "0x50D100", VA = "0x18050E700")]
		public int TryGetCountedBuffValue(EventManager.BuffType buffType)
		{
			return 0;
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023AA")]
		[Address(RVA = "0x4F66E0", Offset = "0x4F50E0", VA = "0x1804F66E0")]
		public IEnumerable<EventManager.BuffType> GetAllTimedBuffType()
		{
			return null;
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AB")]
		[Address(RVA = "0x50E550", Offset = "0x50CF50", VA = "0x18050E550")]
		public void TryDeductCountedBuffValue(EventManager.BuffType buffType, bool triggerDeductAction = true)
		{
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AC")]
		[Address(RVA = "0x50E1D0", Offset = "0x50CBD0", VA = "0x18050E1D0")]
		public void TryAlterCountedBuffValue(EventManager.BuffType buffType, float factor, EventManager.MathOperation mathOperation, bool shouldClampPositive = true, bool triggerDeductAction = true, bool forceEnd = false)
		{
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AD")]
		[Address(RVA = "0x503FC0", Offset = "0x5029C0", VA = "0x180503FC0")]
		public void RegisterConsistentBuffInternal(EventManager.BuffType buffType, Func<string, string> getBuffDescriptionCallback, Action onBuffEndCallback, out Action interruptThisBuffCallback, [Optional] Func<string, string> titleOverride)
		{
		}

		// Token: 0x060023AE RID: 9134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AE")]
		[Address(RVA = "0x503930", Offset = "0x502330", VA = "0x180503930")]
		private void RegisterAdditiveTimedBuffInternal(EventManager.BuffType buffType, int totalSeconds, Func<int, string, string> onUpdatingCurrentContextCallback, Action onBuffExitCallback, out Action onInterruptThisBuffCallback, bool overrideTime = false)
		{
		}

		// Token: 0x060023AF RID: 9135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AF")]
		[Address(RVA = "0x505D20", Offset = "0x504720", VA = "0x180505D20")]
		private void RegisterTimedBuffInternal(EventManager.BuffType buffType, int totalSeconds, Func<int, string, string> onUpdatingCurrentContextCallback, Action onBuffExitCallback, out Action onInterruptThisBuffCallback, [Optional] Func<string, string> titleOverride)
		{
		}

		// Token: 0x060023B0 RID: 9136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B0")]
		[Address(RVA = "0x5042A0", Offset = "0x502CA0", VA = "0x1805042A0")]
		private void RegisterCountedBuffInternal(EventManager.BuffType buffType, Func<int, string, string> onGetBuffContext, Action onBuffDeductCallBack, Action onBuffEndCallback, float value, EventManager.MathOperation mathOperation = EventManager.MathOperation.Add, bool allowZero = false, [Optional] Func<string, string> titleOverride)
		{
		}

		// Token: 0x060023B1 RID: 9137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B1")]
		[Address(RVA = "0x505900", Offset = "0x504300", VA = "0x180505900")]
		public void RegisterManualControlledBuff(EventManager.BuffType buffType, Action onBuffEndCallback, out Action<float> onUpdatingBuffCallback, Func<float, string, string> onGettingCurrentBuffContextCallback, Func<float, float> onGettingCurrentBuffProgressCallback, out Action onBuffExitCallback)
		{
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B2")]
		[Address(RVA = "0x50BC20", Offset = "0x50A620", VA = "0x18050BC20")]
		public void StartGuestInstantiateLoop(int gameTotalSeconds, float spawnRateMultiplier = 1f, [Optional] CreatorBoxData? creatorBoxData)
		{
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B3")]
		[Address(RVA = "0x50BBA0", Offset = "0x50A5A0", VA = "0x18050BBA0")]
		public void StartChallengeGuestInstantiateLoop(bool includesSpecialGuest)
		{
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B4")]
		[Address(RVA = "0x50B530", Offset = "0x509F30", VA = "0x18050B530")]
		public void SetTimeDepeleted()
		{
		}

		// Token: 0x060023B5 RID: 9141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B5")]
		[Address(RVA = "0x50C130", Offset = "0x50AB30", VA = "0x18050C130")]
		public void StopGuestInstantiateLoop()
		{
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B6")]
		[Address(RVA = "0x50C0F0", Offset = "0x50AAF0", VA = "0x18050C0F0")]
		public void StopChallengeGuestInstantiateLoop()
		{
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B7")]
		[Address(RVA = "0x502940", Offset = "0x501340", VA = "0x180502940")]
		private IEnumerator OnTiming(int gameTotalSeconds)
		{
			return null;
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023B8")]
		[Address(RVA = "0x50C1B0", Offset = "0x50ABB0", VA = "0x18050C1B0")]
		private void StopInstantiationLoopAndCloseIzakaya()
		{
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023B9")]
		[Address(RVA = "0x5027E0", Offset = "0x5011E0", VA = "0x1805027E0")]
		private IEnumerator OnNormalGuestInstantiate(float spawnRateMultiplier = 1f)
		{
			return null;
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023BA")]
		[Address(RVA = "0x502860", Offset = "0x501260", VA = "0x180502860")]
		private IEnumerator OnPasserbyGuestInstantiate()
		{
			return null;
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023BB")]
		[Address(RVA = "0x5028D0", Offset = "0x5012D0", VA = "0x1805028D0")]
		private IEnumerator OnSpecialGuestInstantiate()
		{
			return null;
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023BC")]
		[Address(RVA = "0x502760", Offset = "0x501160", VA = "0x180502760")]
		private IEnumerator OnInvitedGuestInstantiate(int gameTotalSeconds)
		{
			return null;
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023BD")]
		[Address(RVA = "0x5024D0", Offset = "0x500ED0", VA = "0x1805024D0")]
		private IEnumerator OnCreatorBoxGuestInstantiate(IReadOnlyList<CreatorBoxData.SpecGuestRefreshNode> list)
		{
			return null;
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BE")]
		[Address(RVA = "0x4F6020", Offset = "0x4F4A20", VA = "0x1804F6020")]
		public void FundEdit(float value, EventManager.MathOperation mathOperation = EventManager.MathOperation.Add)
		{
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023BF")]
		[Address(RVA = "0x4F4590", Offset = "0x4F2F90", VA = "0x1804F4590")]
		public void DeductFund(float value)
		{
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C0")]
		[Address(RVA = "0x50D970", Offset = "0x50C370", VA = "0x18050D970")]
		public void TipEdit(int value, EventManager.ServeType serveType, float comboBuff = 0f, float moodBuff = 0f, float extraBuff = 0f)
		{
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C1")]
		[Address(RVA = "0x503040", Offset = "0x501A40", VA = "0x180503040")]
		public void PassionEdit(float value, EventManager.MathOperation mathOperation = EventManager.MathOperation.Add)
		{
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C2")]
		[Address(RVA = "0x502EB0", Offset = "0x5018B0", VA = "0x180502EB0")]
		public void PassionEditInternal(float value, EventManager.MathOperation mathOperation = EventManager.MathOperation.Add)
		{
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C3")]
		[Address(RVA = "0x4F34F0", Offset = "0x4F1EF0", VA = "0x1804F34F0")]
		public void ComboEdit(float value = 1f, EventManager.MathOperation mathOperation = EventManager.MathOperation.Add)
		{
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C4")]
		[Address(RVA = "0x4FDBB0", Offset = "0x4FC5B0", VA = "0x1804FDBB0")]
		public void LoseAllCombo()
		{
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C5")]
		[Address(RVA = "0x4F1CE0", Offset = "0x4F06E0", VA = "0x1804F1CE0")]
		public void AddServedGuest(int guestNum, bool isSpecial)
		{
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C6")]
		[Address(RVA = "0x4F4B50", Offset = "0x4F3550", VA = "0x1804F4B50")]
		public void ExpEdit(float value = 1f, EventManager.MathOperation mathOperation = EventManager.MathOperation.Add)
		{
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C7")]
		[Address(RVA = "0x4F1650", Offset = "0x4F0050", VA = "0x1804F1650")]
		public void AddPassionPerTime(float addPassion, float unitTime, int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023C8")]
		[Address(RVA = "0x50A4D0", Offset = "0x508ED0", VA = "0x18050A4D0")]
		public void SetFreeCook(int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023C9")]
		[Address(RVA = "0x4FCAE0", Offset = "0x4FB4E0", VA = "0x1804FCAE0")]
		public Recipe[] LockDailyRecipes(int amount, int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
			return null;
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CA")]
		[Address(RVA = "0x4FD6F0", Offset = "0x4FC0F0", VA = "0x1804FD6F0")]
		public void LockTargetDailyRecipes(IEnumerable<int> recipeIds, int durationSec, EventManager.BuffType buffType, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd, [Optional] Func<int, string, string> currentBuffContextOverride)
		{
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CB")]
		[Address(RVA = "0x4FD890", Offset = "0x4FC290", VA = "0x1804FD890")]
		public void LockTray(int amount, int atLeastExistAmount, int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CC")]
		[Address(RVA = "0x4F3FF0", Offset = "0x4F29F0", VA = "0x1804F3FF0")]
		public void CookTimeAndOrderRateEditByTag(int targetFoodTags, float cookTimeMultiplier, float additiveContinueProbability, int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd, [Optional] Func<int, string, string> onGettingBuffContext, EventManager.BuffType buffType = EventManager.BuffType.CookTimeOnTargetTag, [Optional] Func<Sellable, float, bool> extraCookTimeCheck, [Optional] Func<Sellable, GuestGroupController, bool> extraOrderRateCheck)
		{
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CD")]
		[Address(RVA = "0x4F37C0", Offset = "0x4F21C0", VA = "0x1804F37C0")]
		public void CookTimeAndOrderRateEditByCookerType(float multiplier, float additiveContinueProbability, int durationSec, out Action onInterruptThisBuffCallback, EventManager.BuffType buffType = EventManager.BuffType.CookTimeOnTargetCooker, [Optional] Action onBuffEnd, [Optional] Func<int, string, string> onGettingBuffContext, [Optional] Func<Sellable, float, bool> extraCookTimeCheck, [Optional] Func<Sellable, GuestGroupController, bool> extraOrderRateCheck, params Cooker.CookerType[] cookerType)
		{
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CE")]
		[Address(RVA = "0x4F0350", Offset = "0x4EED50", VA = "0x1804F0350")]
		public void AddCookTimeModifier(float multiplier, int[] tags, out Action onInterruptThisBuffCallback, [Optional] Func<Sellable, float, bool> extraCookTimeCheck, params Cooker.CookerType[] cookerTypes)
		{
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023CF")]
		[Address(RVA = "0x4F1210", Offset = "0x4EFC10", VA = "0x1804F1210")]
		public void AddOrderRateModifier(float multiplier, int[] tags, out Action onInterruptThisBuffCallback, [Optional] Func<Sellable, GuestGroupController, bool> extraOrderRateCheck, params Cooker.CookerType[] cookerTypes)
		{
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D0")]
		[Address(RVA = "0x501680", Offset = "0x500080", VA = "0x180501680")]
		public void MimaGreatMagicPlus(int duration, float speedMultiplier, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D1")]
		[Address(RVA = "0x50A0C0", Offset = "0x508AC0", VA = "0x18050A0C0")]
		public void SetExtraCookSpeedFunc(Func<float> extraCookSpeedFunc, int durationSec, out Action onInterruptThisBuffCallback, EventManager.BuffType buffType = EventManager.BuffType.CookTimeOnTargetCooker, [Optional] Action onBuffEnd, [Optional] Func<int, string, string> onGettingBuffContext)
		{
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023D2")]
		[Address(RVA = "0x50C7B0", Offset = "0x50B1B0", VA = "0x18050C7B0")]
		public IEnumerable<int> TargetCookersAny(int amount = 1000, bool exceptedLockedController = false)
		{
			return null;
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D3")]
		[Address(RVA = "0x4FC440", Offset = "0x4FAE40", VA = "0x1804FC440")]
		public void LockCookers(IEnumerable<int> targets, int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd, EventManager.BuffType bufftype = EventManager.BuffType.LockCooker)
		{
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D4")]
		[Address(RVA = "0x4FBEC0", Offset = "0x4FA8C0", VA = "0x1804FBEC0")]
		public void LockCookers_Forever(IEnumerable<int> targets, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D5")]
		[Address(RVA = "0x4F5C80", Offset = "0x4F4680", VA = "0x1804F5C80")]
		public void ForcedOverrideFoodProbably(float rate, int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd, int targetFoodId = -1, [Optional] IEnumerable<int> targetTag, EventManager.BuffType buffType = EventManager.BuffType.FoodKiller, [Optional] Func<int, string, string> currentContextCallback)
		{
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D6")]
		[Address(RVA = "0x50A2D0", Offset = "0x508CD0", VA = "0x18050A2D0")]
		public void SetFreeCookRate(float rate, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D7")]
		[Address(RVA = "0x50A230", Offset = "0x508C30", VA = "0x18050A230")]
		public void SetExtraCookTag(int tagId)
		{
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D8")]
		[Address(RVA = "0x506EB0", Offset = "0x5058B0", VA = "0x180506EB0")]
		public void RemoveExtraCookTag(int tagId)
		{
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023D9")]
		[Address(RVA = "0x50FD50", Offset = "0x50E750", VA = "0x18050FD50")]
		public void UnlockInfo(int amount, int targetSpecialGuestId = -1)
		{
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DA")]
		[Address(RVA = "0x50C500", Offset = "0x50AF00", VA = "0x18050C500")]
		public void Stun(int durationSec, Action<float> onBuffProgressUpdate, out Action onEndThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DB")]
		[Address(RVA = "0x50C250", Offset = "0x50AC50", VA = "0x18050C250")]
		public void Stun_Murasa(int durationSec, Action onStunFinishCallback, Action<float> onBuffProgressUpdate, out Action onEndThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DC")]
		[Address(RVA = "0x50AC30", Offset = "0x509630", VA = "0x18050AC30")]
		public void SetMystiaMoveSpeed()
		{
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DD")]
		[Address(RVA = "0x4F2120", Offset = "0x4F0B20", VA = "0x1804F2120")]
		public void ChangeMoveSpeedByBuff(float multiplier, int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd, EventManager.BuffType buffType = EventManager.BuffType.SlowDown, [Optional] Func<int, string, string> onGettingCurrentBuffContext)
		{
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DE")]
		[Address(RVA = "0x50B0A0", Offset = "0x509AA0", VA = "0x18050B0A0")]
		public void SetPartnerExtraWage(float multiplier)
		{
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023DF")]
		[Address(RVA = "0x507260", Offset = "0x505C60", VA = "0x180507260")]
		public void RemovePartnerExtraWage(float multiplier)
		{
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E0")]
		private void AddToDictionary<TKey, TValue>(Dictionary<TKey, List<TValue>> dictionary, TKey key, TValue value)
		{
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E1")]
		private void RemoveFromDictionary<TKey, TValue>(Dictionary<TKey, List<TValue>> dictionary, TKey key, TValue value)
		{
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E2")]
		[Address(RVA = "0x50AEB0", Offset = "0x5098B0", VA = "0x18050AEB0")]
		public void SetPartnerExtraMoveSpeed(float multiplier, bool setById, int partnerId = -1)
		{
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E3")]
		[Address(RVA = "0x507030", Offset = "0x505A30", VA = "0x180507030")]
		public void RemovePartnerExtraMoveSpeed(float multiplier, bool setById, int partnerId = -1)
		{
		}

		// Token: 0x060023E4 RID: 9188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E4")]
		[Address(RVA = "0x50AE30", Offset = "0x509830", VA = "0x18050AE30")]
		public void SetPartnerExtraCookSpeed(float multiplier, bool setById, int partnerId = -1)
		{
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E5")]
		[Address(RVA = "0x506F70", Offset = "0x505970", VA = "0x180506F70")]
		public void RemovePartnerExtraCookSpeed(float multiplier, bool setById, int partnerId = -1)
		{
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E6")]
		[Address(RVA = "0x50B150", Offset = "0x509B50", VA = "0x18050B150")]
		public void SetPartnerExtraWorkSpeed(float multiplier, bool setById, int partnerId = -1)
		{
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023E7")]
		[Address(RVA = "0x5072C0", Offset = "0x505CC0", VA = "0x1805072C0")]
		public void RemovePartnerExtraWorkSpeed(float multiplier, bool setById, int partnerId = -1)
		{
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E8")]
		[Address(RVA = "0x50CC80", Offset = "0x50B680", VA = "0x18050CC80")]
		public IEnumerable<int> TargetTablesAny(int amount = 1000, [Optional] IEnumerable<int> exceptId)
		{
			return null;
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023E9")]
		[Address(RVA = "0x50D250", Offset = "0x50BC50", VA = "0x18050D250")]
		public IEnumerable<int> TargetTablesGuests(int amount = 1000, [Optional] IEnumerable<int> exceptId)
		{
			return null;
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EA")]
		[Address(RVA = "0x507670", Offset = "0x506070", VA = "0x180507670")]
		public void RepellAndPay(IEnumerable<int> targets)
		{
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EB")]
		[Address(RVA = "0x507A70", Offset = "0x506470", VA = "0x180507A70")]
		public void RepellNoPay(IEnumerable<int> targets)
		{
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EC")]
		[Address(RVA = "0x507680", Offset = "0x506080", VA = "0x180507680")]
		private void RepellInternal(IEnumerable<int> targets, bool pay)
		{
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x0000D608 File Offset: 0x0000B808
		[Token(Token = "0x60023ED")]
		[Address(RVA = "0x4F8710", Offset = "0x4F7110", VA = "0x1804F8710")]
		public float GetTargetTableGuestMood(int deskCode)
		{
			return 0f;
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EE")]
		[Address(RVA = "0x4FEFA0", Offset = "0x4FD9A0", VA = "0x1804FEFA0")]
		public void MasterEvaluationEdit(IEnumerable<int> targets, float value, EventManager.MathOperation math)
		{
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023EF")]
		[Address(RVA = "0x4FEB30", Offset = "0x4FD530", VA = "0x1804FEB30")]
		public void MasterEvaluationEdit(IEnumerable<int> targets, float min, float max, EventManager.MathOperation math)
		{
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F0")]
		[Address(RVA = "0x4FD360", Offset = "0x4FBD60", VA = "0x1804FD360")]
		public void LockTables(IEnumerable<int> targets, int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F1")]
		[Address(RVA = "0x4FCFD0", Offset = "0x4FB9D0", VA = "0x1804FCFD0")]
		public void LockTablesForever(EventManager.BuffType buffType, IEnumerable<int> targets, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x060023F2 RID: 9202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F2")]
		[Address(RVA = "0x4F1B10", Offset = "0x4F0510", VA = "0x1804F1B10")]
		public void AddPlayerLockTables(IEnumerable<int> targets, int durationSec, EventManager.BuffType buffType, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x060023F3 RID: 9203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F3")]
		[Address(RVA = "0x50B1D0", Offset = "0x509BD0", VA = "0x18050B1D0")]
		public void SetTableCanNotOpenByPlayer(int deskCode)
		{
		}

		// Token: 0x060023F4 RID: 9204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F4")]
		[Address(RVA = "0x50B270", Offset = "0x509C70", VA = "0x18050B270")]
		public void SetTableCanOpenByPlayer(int deskCode)
		{
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F5")]
		[Address(RVA = "0x50A660", Offset = "0x509060", VA = "0x18050A660")]
		public void SetGuestNotLeaveWhenIzakayaClose(int durationSec, EventManager.BuffType buffType, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F6")]
		[Address(RVA = "0x50A7A0", Offset = "0x5091A0", VA = "0x18050A7A0")]
		public void SetIzakayaCloseStatus(int durationSec, EventManager.BuffType buffType, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F7")]
		[Address(RVA = "0x50A8E0", Offset = "0x5092E0", VA = "0x18050A8E0")]
		public void SetIzakayaContinuingOperations()
		{
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F8")]
		[Address(RVA = "0x50A900", Offset = "0x509300", VA = "0x18050A900")]
		public void SetIzakayaStopOperations()
		{
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023F9")]
		[Address(RVA = "0x5104D0", Offset = "0x50EED0", VA = "0x1805104D0")]
		public void WhenConfirmFastForwardButton()
		{
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FA")]
		[Address(RVA = "0x4F8F20", Offset = "0x4F7920", VA = "0x1804F8F20")]
		public void GuestMoodExtraAddEdit_Forever(int mood, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FB")]
		[Address(RVA = "0x4F90A0", Offset = "0x4F7AA0", VA = "0x1804F90A0")]
		public void GuestMoodExtraAddEdit(int mood, int duration, EventManager.BuffType buffType, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FC")]
		[Address(RVA = "0x4F0E00", Offset = "0x4EF800", VA = "0x1804F0E00")]
		public void AddExtraMoodModifier(int mood)
		{
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FD")]
		[Address(RVA = "0x506F10", Offset = "0x505910", VA = "0x180506F10")]
		public void RemoveExtraMoodModifier(int mood)
		{
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FE")]
		[Address(RVA = "0x4F0EA0", Offset = "0x4EF8A0", VA = "0x1804F0EA0")]
		public void AddExtraPayModifier(EventManager.ExtraPayModifier modifier, out Action interruptAction)
		{
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023FF")]
		[Address(RVA = "0x5029C0", Offset = "0x5013C0", VA = "0x1805029C0")]
		public void OrderCycleRateEdit(float multiplier, int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002400")]
		[Address(RVA = "0x4F1040", Offset = "0x4EFA40", VA = "0x1804F1040")]
		public void AddOrderCycleRateEdit(float multiplier, out Action onInterruptThisBuffCallback)
		{
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002401")]
		[Address(RVA = "0x4F46E0", Offset = "0x4F30E0", VA = "0x1804F46E0")]
		public void EatTimeEdit(float multiplier, int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002402")]
		[Address(RVA = "0x4F9240", Offset = "0x4F7C40", VA = "0x1804F9240")]
		public void GuestPatientEdit_Youmu(float addPassion, float unitTime, float multiplier, int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002403")]
		[Address(RVA = "0x4FB0F0", Offset = "0x4F9AF0", VA = "0x1804FB0F0")]
		public void InternetFamousIzakayaBuffEdit(float spawnRateMultiplier, float fundRateMultiplier, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002404")]
		[Address(RVA = "0x4F0AA0", Offset = "0x4EF4A0", VA = "0x1804F0AA0")]
		public void AddExtraGenerateFundModifier(float fundRateMultiplier, out Action interrupt)
		{
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002405")]
		[Address(RVA = "0x50B760", Offset = "0x50A160", VA = "0x18050B760")]
		public void SpawnRateEdit(float multiplier, int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd, EventManager.BuffType buffType = EventManager.BuffType.NormalGuestSpawnMultiplier, [Optional] Func<int, string, string> onGettingCurrentBuffContext)
		{
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002406")]
		[Address(RVA = "0x5105E0", Offset = "0x50EFE0", VA = "0x1805105E0")]
		public void WriggleSpawnRateEdit(float multiplier, int durationSec, out Action onInterruptThisBuffCallback, Action onBuffEnd)
		{
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002407")]
		[Address(RVA = "0x4F27D0", Offset = "0x4F11D0", VA = "0x1804F27D0")]
		public void ChenSpawnRateEdit(float multiplier, out Action onInterruptThisBuffCallback, Action onBuffEnd)
		{
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002408")]
		[Address(RVA = "0x5022F0", Offset = "0x500CF0", VA = "0x1805022F0")]
		public void MomiziSpawnRateEdit(int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002409")]
		[Address(RVA = "0x4F0BF0", Offset = "0x4EF5F0", VA = "0x1804F0BF0")]
		public void AddExtraGuestSpawnMultiplier(float multiplier, GuestsManager.GuestType guestType, bool addToAll, out Action removeCallback)
		{
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240A")]
		[Address(RVA = "0x4FB760", Offset = "0x4FA160", VA = "0x1804FB760")]
		public void KomachiManipulateDistance(GameObject teleportEffect, GameObject theHandEffect, out Action onInterruptThisBuffCallback, Action onBuffEnd)
		{
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240B")]
		[Address(RVA = "0x504910", Offset = "0x503310", VA = "0x180504910")]
		public void RegisterKisumeBuff(PartnerInfoKisume.KisumeEffect kisumeEffect, PartnerBase partnerBase, out Action onInterruptThisBuffCallback, Action onBuffEnd)
		{
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240C")]
		[Address(RVA = "0x4F8CD0", Offset = "0x4F76D0", VA = "0x1804F8CD0")]
		public void GuestInstantEvaluate(int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240D")]
		[Address(RVA = "0x4F8AC0", Offset = "0x4F74C0", VA = "0x1804F8AC0")]
		public void GuestInstantEvaluate_Yuyuko(out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240E")]
		[Address(RVA = "0x4F8870", Offset = "0x4F7270", VA = "0x1804F8870")]
		public void GuestInstantEvaluate_Koishi(int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600240F")]
		[Address(RVA = "0x4F87D0", Offset = "0x4F71D0", VA = "0x1804F87D0")]
		public void GuestInstantEvaluate_DLC4BossBattle()
		{
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002410")]
		[Address(RVA = "0x4F9980", Offset = "0x4F8380", VA = "0x1804F9980")]
		public void GuestPatientFreeze(int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002411")]
		[Address(RVA = "0x50D720", Offset = "0x50C120", VA = "0x18050D720")]
		public void ThrowDeliver(int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002412")]
		[Address(RVA = "0x502C60", Offset = "0x501660", VA = "0x180502C60")]
		public void PartnerThrowDeliver(int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002413")]
		[Address(RVA = "0x4F5330", Offset = "0x4F3D30", VA = "0x1804F5330")]
		public void Fever(int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002414")]
		[Address(RVA = "0x50B540", Offset = "0x509F40", VA = "0x18050B540")]
		public void SpawnNormalGuests(int amount, int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd, int targetNormalGuestId = -1, bool continueToSpawnAfterDayEnd = false)
		{
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002415")]
		[Address(RVA = "0x50BA10", Offset = "0x50A410", VA = "0x18050BA10")]
		public void SpawnTargetNormalGuests(int amount, int durationSec, int targetNormalGuestId, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002416")]
		[Address(RVA = "0x4FDFB0", Offset = "0x4FC9B0", VA = "0x1804FDFB0")]
		public void MakeGuestsPayTipsKasen(int amountMin, int amountMax, int intervalMin, int intervalMax, int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd, EventManager.BuffType buffType = EventManager.BuffType.Skill_Kasen_Art, [Optional] Func<int, string, string> currentBuffContextOverride, bool alsoGivePartner = false, [Optional] Func<GuestGroupController, bool> checkGuestSatisfy)
		{
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002417")]
		[Address(RVA = "0x4FE5D0", Offset = "0x4FCFD0", VA = "0x1804FE5D0")]
		public void MakeGuestsPayTipsNormal(int amountMin, int amountMax, int interval, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002418")]
		[Address(RVA = "0x4F4630", Offset = "0x4F3030", VA = "0x1804F4630")]
		public IEnumerator DelayToGiveTips(int thisAmountMin, int thisAmountMax, float delayTime, bool alsoGivePartner = false)
		{
			return null;
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002419")]
		[Address(RVA = "0x4FB030", Offset = "0x4F9A30", VA = "0x1804FB030")]
		private IEnumerator InstantiateTimedCoinAndLerpParabolic(Vector2 position, Action<GameObject> objectProcessingCallback, float duration)
		{
			return null;
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600241A")]
		[Address(RVA = "0x4F6660", Offset = "0x4F5060", VA = "0x1804F6660")]
		public IEnumerable<GuestGroupController> GetAllActiveGuestGroups()
		{
			return null;
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241B")]
		[Address(RVA = "0x50FAF0", Offset = "0x50E4F0", VA = "0x18050FAF0")]
		public void UnambitiousGuests(int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241C")]
		[Address(RVA = "0x4F5130", Offset = "0x4F3B30", VA = "0x1804F5130")]
		public void ExtraFund(int durationSec, float extraFundPercentage, out Action onInterruptThisBuffCallback, EventManager.BuffType buffType, [Optional] Action onBuffEnd, [Optional] Func<int, string, string> overrideBuffContext)
		{
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241D")]
		[Address(RVA = "0x4F0950", Offset = "0x4EF350", VA = "0x1804F0950")]
		public void AddExtraFundMultiplier(float extraFundPercentage, out Action removeCallback)
		{
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241E")]
		[Address(RVA = "0x4F4F30", Offset = "0x4F3930", VA = "0x1804F4F30")]
		public void ExtraFee(int durationSec, float extraFeePercentage, out Action onInterruptThisBuffCallback, EventManager.BuffType buffType = EventManager.BuffType.ExtraFeeRate, [Optional] Action onBuffEnd, [Optional] Func<int, string, string> overrideBuffContext)
		{
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600241F")]
		[Address(RVA = "0x4F4D30", Offset = "0x4F3730", VA = "0x1804F4D30")]
		public void ExtraFeeForever(float extraFeePercentage, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd, EventManager.BuffType buffType = EventManager.BuffType.ExtraFeeForever, [Optional] Func<string, string> overrideBuffContext)
		{
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002420")]
		[Address(RVA = "0x50B2D0", Offset = "0x509CD0", VA = "0x18050B2D0")]
		public void SetTargetExtraIngBevCost(int durationSec, int extraIngCost, int extraBevCost, out Action onInterruptThisBuffCallback, EventManager.BuffType buffType, [Optional] Action onBuffEnd, [Optional] Func<int, string, string> onGettingCurrentBuffContext)
		{
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002421")]
		[Address(RVA = "0x501980", Offset = "0x500380", VA = "0x180501980")]
		public void MinEvalLevelSet(int durationSec, int baseEval, IEnumerable<int> tags, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd, EventManager.BuffType buffType = EventManager.BuffType.PhilosopherStone, bool isFood = true, [Optional] Predicate<GuestGroupController> extraGuestCheck, [Optional] Predicate<GuestGroupController.EvaluationResult> extraEvalCheck, bool containsOrNot = true)
		{
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002422")]
		[Address(RVA = "0x501080", Offset = "0x4FFA80", VA = "0x180501080")]
		public void MaxEvalLevelSet(int durationSec, int maxEval, IEnumerable<int> tags, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd, EventManager.BuffType buffType = EventManager.BuffType.Skill_Mokou_Punishment, bool isFood = true, [Optional] Func<int, string, string> overrideDescription, [Optional] Predicate<GuestGroupController> extraGuestCheck, [Optional] Predicate<GuestGroupController.EvaluationResult> extraEvalCheck, bool containsOrNot = true)
		{
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002423")]
		[Address(RVA = "0x5009B0", Offset = "0x4FF3B0", VA = "0x1805009B0")]
		public void MaxEvalLevelSet_Yuyuko(int maxEval, IEnumerable<int> tags, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002424")]
		[Address(RVA = "0x4F02D0", Offset = "0x4EECD0", VA = "0x1804F02D0")]
		public void AddBaseLineEvalModifier(EventManager.EvalModifier modifier)
		{
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002425")]
		[Address(RVA = "0x506E30", Offset = "0x505830", VA = "0x180506E30")]
		public void RemoveBaseLineEvalModifier(EventManager.EvalModifier modifier)
		{
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002426")]
		[Address(RVA = "0x4F06C0", Offset = "0x4EF0C0", VA = "0x1804F06C0")]
		public void AddCountedEvalModifier(EventManager.BuffType buffType, int value, EventManager.CountedEvalModifier.CountedEvalModifierDelegate countedEvalModifierDelegate, Action onBuffEnd, [Optional] Func<int, string, string> currentBuffContextOverride)
		{
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002427")]
		[Address(RVA = "0x50E940", Offset = "0x50D340", VA = "0x18050E940")]
		private void TryRemoveModifierNum(EventManager.CountedEvalModifier modifier)
		{
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002428")]
		[Address(RVA = "0x5031F0", Offset = "0x501BF0", VA = "0x1805031F0")]
		public void RandomEval(int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002429")]
		[Address(RVA = "0x509DC0", Offset = "0x5087C0", VA = "0x180509DC0")]
		public void SetBestEvalRate(float rate, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242A")]
		[Address(RVA = "0x5046B0", Offset = "0x5030B0", VA = "0x1805046B0")]
		public void RegisterCountedBuff(EventManager.BuffType buffType, float value, EventManager.MathOperation mathOperation, Action onBuffDeduct, Action onBuffEnd, [Optional] Func<int, string, string> currentBuffContextOverride, bool allowZero = false, [Optional] Func<string, string> titleOverride)
		{
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242B")]
		[Address(RVA = "0x5061E0", Offset = "0x504BE0", VA = "0x1805061E0")]
		public void RegisterTimedBuff(int duration, EventManager.BuffType buffType, out Action onInterruptThisBuffCallback, Action onBuffEnd, [Optional] Func<int, string, string> currentBuffContextOverride, [Optional] Func<string, string> titleOverride)
		{
		}

		// Token: 0x0600242C RID: 9260 RVA: 0x0000D620 File Offset: 0x0000B820
		[Token(Token = "0x600242C")]
		[Address(RVA = "0x4F56E0", Offset = "0x4F40E0", VA = "0x1804F56E0")]
		private int FinalBuffTime(float oldTime, EventManager.BuffTimeType buffTimeType)
		{
			return 0;
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x0600242D RID: 9261 RVA: 0x0000D638 File Offset: 0x0000B838
		[Token(Token = "0x1700051E")]
		private float ExtraLevelBuffTime
		{
			[Token(Token = "0x600242D")]
			[Address(RVA = "0x514200", Offset = "0x512C00", VA = "0x180514200")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x0000D650 File Offset: 0x0000B850
		[Token(Token = "0x600242E")]
		[Address(RVA = "0x50E790", Offset = "0x50D190", VA = "0x18050E790")]
		public bool TryOverrideTimedBuff(EventManager.BuffType buffType, float duration, Action<int> defaultRegisterBuffAction, EventManager.BuffTimeType buffTimeType, EventManager.BuffRegisterType buffRegisterType = EventManager.BuffRegisterType.Additive, int extraDuration = -1, [Optional] Action<int> haveBuffRegisterBuffAction)
		{
			return default(bool);
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600242F")]
		[Address(RVA = "0x504E00", Offset = "0x503800", VA = "0x180504E00")]
		public void RegisterKyoukoFever(float multiplier, int targetFoodTags, float cookTimeMultiplier, float additiveContinueProbability, int durationSec, int lockNum, GameObject act3Effect, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002430")]
		[Address(RVA = "0x504BB0", Offset = "0x5035B0", VA = "0x180504BB0")]
		public void RegisterKosuzuFever(int mood, Func<float> extraCookSpeedFunc, float eachComboRate, int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002431")]
		[Address(RVA = "0x503CC0", Offset = "0x5026C0", VA = "0x180503CC0")]
		public void RegisterAunnFever(int amountMin, int amountMax, int intervalMin, int intervalMax, float extraTipRate, int durationSec, out Action onInterruptThisBuffCallback, [Optional] Action onBuffEnd)
		{
		}

		// Token: 0x06002432 RID: 9266 RVA: 0x0000D668 File Offset: 0x0000B868
		[Token(Token = "0x6002432")]
		[Address(RVA = "0x508CD0", Offset = "0x5076D0", VA = "0x180508CD0")]
		public EventManager.SelectedValue SelectFromInventory(EventManager.InventoryIOType iOType, int id, int requestedAmount)
		{
			return default(EventManager.SelectedValue);
		}

		// Token: 0x06002433 RID: 9267 RVA: 0x0000D680 File Offset: 0x0000B880
		[Token(Token = "0x6002433")]
		[Address(RVA = "0x509010", Offset = "0x507A10", VA = "0x180509010")]
		public EventManager.SelectedValue SelectFromInventory(EventManager.InventoryIOType iOType, int requestedAmount, EventManager.InventoryPriceSortType sortType, out bool haveSelect, int tag = -900)
		{
			return default(EventManager.SelectedValue);
		}

		// Token: 0x06002434 RID: 9268 RVA: 0x0000D698 File Offset: 0x0000B898
		[Token(Token = "0x6002434")]
		[Address(RVA = "0x507F20", Offset = "0x506920", VA = "0x180507F20")]
		public EventManager.SelectedValue SelectFromInventoryByLevel(EventManager.InventoryIOType iOType, int requestedAmount, EventManager.InventoryPriceSortType sortType, out bool haveSelect, int level = -900)
		{
			return default(EventManager.SelectedValue);
		}

		// Token: 0x06002435 RID: 9269 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		[Token(Token = "0x6002435")]
		[Address(RVA = "0x507DB0", Offset = "0x5067B0", VA = "0x180507DB0")]
		public EventManager.SelectedValue SelectFromDatabase(EventManager.InventoryIOType iOType, int id, int amount)
		{
			return default(EventManager.SelectedValue);
		}

		// Token: 0x06002436 RID: 9270 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
		[Token(Token = "0x6002436")]
		[Address(RVA = "0x4FF290", Offset = "0x4FDC90", VA = "0x1804FF290")]
		private EventManager.SelectedValue MatchObjectsInternal(IEnumerable<Ingredient> ingredientCollection, IEnumerable<Sellable> foodCollection, IEnumerable<Sellable> bevCollection, EventManager.InventoryIOType iOType, int amount, int tag = -900, int excludeTag = -900, int priceMin = -1, int priceMax = -1, bool shouldIgnore = false)
		{
			return default(EventManager.SelectedValue);
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		[Token(Token = "0x6002437")]
		[Address(RVA = "0x507BB0", Offset = "0x5065B0", VA = "0x180507BB0")]
		public EventManager.SelectedValue SelectFromDatabase(EventManager.InventoryIOType iOType, int amount, int tag = -900, int excludeTag = -900, int priceMin = -1, int priceMax = -1, bool shouldIgnore = false)
		{
			return default(EventManager.SelectedValue);
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
		[Token(Token = "0x6002438")]
		[Address(RVA = "0x507E20", Offset = "0x506820", VA = "0x180507E20")]
		public EventManager.SelectedValue SelectFromDiary(EventManager.InventoryIOType iOType, int amount, int tag = -900, int excludeTag = -900, int priceMin = -1, int priceMax = -1)
		{
			return default(EventManager.SelectedValue);
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002439")]
		[Address(RVA = "0x4FB400", Offset = "0x4F9E00", VA = "0x1804FB400")]
		public void InventoryIn(EventManager.SelectedValue selected)
		{
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243A")]
		[Address(RVA = "0x4FB570", Offset = "0x4F9F70", VA = "0x1804FB570")]
		public void InventoryOut(EventManager.SelectedValue selected)
		{
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243B")]
		[Address(RVA = "0x4F29B0", Offset = "0x4F13B0", VA = "0x1804F29B0", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600243C")]
		[Address(RVA = "0x5107D0", Offset = "0x50F1D0", VA = "0x1805107D0")]
		public EventManager()
		{
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		[Token(Token = "0x6002445")]
		[Address(RVA = "0x50F220", Offset = "0x50DC20", VA = "0x18050F220")]
		[CompilerGenerated]
		internal static bool <StartKyoukoTutorial>g__HaveTutorialEnd|490_0()
		{
			return default(bool);
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002449")]
		[Address(RVA = "0x50F180", Offset = "0x50DB80", VA = "0x18050F180")]
		[CompilerGenerated]
		private void <SetMusicPlayMode>g__UpdatePassionInterval|494_3(int currentPassion, int musicLevel)
		{
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244A")]
		[Address(RVA = "0x50E9B0", Offset = "0x50D3B0", VA = "0x18050E9B0")]
		[CompilerGenerated]
		private void <ExecuteSpellQueue>g__Execute|501_0()
		{
		}

		// Token: 0x0600244B RID: 9291 RVA: 0x0000D818 File Offset: 0x0000BA18
		[Token(Token = "0x600244B")]
		[Address(RVA = "0x50F530", Offset = "0x50DF30", VA = "0x18050F530")]
		[CompilerGenerated]
		internal static int <TipEdit>g__GetPercent|533_0(float num)
		{
			return 0;
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244C")]
		[Address(RVA = "0x50EF70", Offset = "0x50D970", VA = "0x18050EF70")]
		[CompilerGenerated]
		internal static string <SetFreeCook>g__OnGettingCurrentBuffContext|541_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244D")]
		[Address(RVA = "0x50EC40", Offset = "0x50D640", VA = "0x18050EC40")]
		[CompilerGenerated]
		internal static string <LockTray>g__OnGettingCurrentBuffContext|544_0(int currentTime, string description)
		{
			return null;
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244E")]
		[Address(RVA = "0x50ED00", Offset = "0x50D700", VA = "0x18050ED00")]
		[CompilerGenerated]
		internal static string <MimaGreatMagicPlus>g__OnGettingCurrentBuffContext|549_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244F")]
		[Address(RVA = "0x3FA8D0", Offset = "0x3F92D0", VA = "0x1803FA8D0")]
		[CompilerGenerated]
		internal static string <ForcedOverrideFoodProbably>g__OnGettingCurrentBuffContext|554_1(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x0000D830 File Offset: 0x0000BA30
		[Token(Token = "0x6002450")]
		[Address(RVA = "0x50F5A0", Offset = "0x50DFA0", VA = "0x18050F5A0")]
		[CompilerGenerated]
		internal static int <UnlockInfo>g__FindCouldUnlock|558_0(int specGuestId)
		{
			return 0;
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002451")]
		[Address(RVA = "0x50F2B0", Offset = "0x50DCB0", VA = "0x18050F2B0")]
		[CompilerGenerated]
		internal static string <Stun>g__OnGettingCurrentBuffContext|559_0(float currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002452")]
		[Address(RVA = "0x50F3C0", Offset = "0x50DDC0", VA = "0x18050F3C0")]
		[CompilerGenerated]
		internal static string <Stun_Murasa>g__OnGettingCurrentBuffContext|560_0(float currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002454")]
		[Address(RVA = "0x50ED90", Offset = "0x50D790", VA = "0x18050ED90")]
		[CompilerGenerated]
		internal static string <MomiziSpawnRateEdit>g__OnGettingCurrentBuffContext|605_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002455")]
		[Address(RVA = "0x50EB20", Offset = "0x50D520", VA = "0x18050EB20")]
		[CompilerGenerated]
		internal static string <GuestInstantEvaluate>g__OnGettingCurrentBuffContext|609_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002456")]
		[Address(RVA = "0x50EB80", Offset = "0x50D580", VA = "0x18050EB80")]
		[CompilerGenerated]
		internal static string <GuestInstantEvaluate_Koishi>g__OnGettingCurrentBuffContext|611_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002457")]
		[Address(RVA = "0x50EBE0", Offset = "0x50D5E0", VA = "0x18050EBE0")]
		[CompilerGenerated]
		internal static string <GuestPatientFreeze>g__OnGettingCurrentBuffContext|613_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002458")]
		[Address(RVA = "0x50F4D0", Offset = "0x50DED0", VA = "0x18050F4D0")]
		[CompilerGenerated]
		internal static string <ThrowDeliver>g__OnGettingCurrentBuffContext|614_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002459")]
		[Address(RVA = "0x50EDF0", Offset = "0x50D7F0", VA = "0x18050EDF0")]
		[CompilerGenerated]
		internal static string <PartnerThrowDeliver>g__OnGettingCurrentBuffContext|615_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245A")]
		[Address(RVA = "0x50EAC0", Offset = "0x50D4C0", VA = "0x18050EAC0")]
		[CompilerGenerated]
		internal static string <Fever>g__OnGettingCurrentBuffContext|616_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245B")]
		[Address(RVA = "0x50ECA0", Offset = "0x50D6A0", VA = "0x18050ECA0")]
		[CompilerGenerated]
		internal static string <MakeGuestsPayTipsKasen>g__OnGettingCurrentBuffContext|619_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245C")]
		[Address(RVA = "0x50F540", Offset = "0x50DF40", VA = "0x18050F540")]
		[CompilerGenerated]
		internal static string <UnambitiousGuests>g__OnGettingCurrentBuffContext|624_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245D")]
		[Address(RVA = "0x50F1C0", Offset = "0x50DBC0", VA = "0x18050F1C0")]
		[CompilerGenerated]
		internal static string <SetTargetExtraIngBevCost>g__OnGettingCurrentBuffContext|629_1(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245E")]
		[Address(RVA = "0x50EE50", Offset = "0x50D850", VA = "0x18050EE50")]
		[CompilerGenerated]
		internal static string <RandomEval>g__OnGettingCurrentBuffContext|637_1(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600245F")]
		[Address(RVA = "0x50EEB0", Offset = "0x50D8B0", VA = "0x18050EEB0")]
		[CompilerGenerated]
		internal static string <RegisterCountedBuff>g__OnGettingCurrentBuffContext|639_0(int currentCount, string buffDescription)
		{
			return null;
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002460")]
		[Address(RVA = "0x50EF10", Offset = "0x50D910", VA = "0x18050EF10")]
		[CompilerGenerated]
		internal static string <RegisterTimedBuff>g__OnGettingCurrentBuffContext|640_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x04001F4D RID: 8013
		[Token(Token = "0x4001F4D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int passion;

		// Token: 0x04001F4E RID: 8014
		[Token(Token = "0x4001F4E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int gainExp;

		// Token: 0x04001F4F RID: 8015
		[Token(Token = "0x4001F4F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int totalCountDown;

		// Token: 0x04001F50 RID: 8016
		[Token(Token = "0x4001F50")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int extraCountDown;

		// Token: 0x04001F51 RID: 8017
		[Token(Token = "0x4001F51")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int passedTimeCount;

		// Token: 0x04001F52 RID: 8018
		[Token(Token = "0x4001F52")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Coroutine onNormalGuestInstantiateLoop;

		// Token: 0x04001F53 RID: 8019
		[Token(Token = "0x4001F53")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Coroutine onPasserbyGuestInstantiateLoop;

		// Token: 0x04001F54 RID: 8020
		[Token(Token = "0x4001F54")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine onSpecialGuestInstantiateLoop;

		// Token: 0x04001F55 RID: 8021
		[Token(Token = "0x4001F55")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine onInvitedGuestInstantiateLoop;

		// Token: 0x04001F56 RID: 8022
		[Token(Token = "0x4001F56")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Coroutine onCreatorBoxGuestInstantiateLoop;

		// Token: 0x04001F57 RID: 8023
		[Token(Token = "0x4001F57")]
		private const int TOTAL_WAIT_FOR_START_SECONDS = 3;

		// Token: 0x04001F58 RID: 8024
		[Token(Token = "0x4001F58")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GuestsManager guestsManager;

		// Token: 0x04001F59 RID: 8025
		[Token(Token = "0x4001F59")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UniTask? spellLoop;

		// Token: 0x04001F5A RID: 8026
		[Token(Token = "0x4001F5A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool shouldNotSpawnBuff;

		// Token: 0x04001F5B RID: 8027
		[Token(Token = "0x4001F5B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GameObject m_SpellDeclareInstance;

		// Token: 0x04001F5C RID: 8028
		[Token(Token = "0x4001F5C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TextMeshProUGUI[] m_SpellDeclareInstanceTMP;

		// Token: 0x04001F5D RID: 8029
		[Token(Token = "0x4001F5D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image[] m_SpellDeclareInstancePortrayalImage;

		// Token: 0x04001F5E RID: 8030
		[Token(Token = "0x4001F5E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Image[] m_SpellDeclareInstanceVFXImage;

		// Token: 0x04001F5F RID: 8031
		[Token(Token = "0x4001F5F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private CancellationTokenSource _breakSpellLoopCancellationToken;

		// Token: 0x04001F60 RID: 8032
		[Token(Token = "0x4001F60")]
		public const int DAILY_TAG_ID = 3;

		// Token: 0x04001F61 RID: 8033
		[Token(Token = "0x4001F61")]
		public const int MEAT_TAG_ID = 0;

		// Token: 0x04001F62 RID: 8034
		[Token(Token = "0x4001F62")]
		public const int FISH_TAG_ID = 1;

		// Token: 0x04001F63 RID: 8035
		[Token(Token = "0x4001F63")]
		public const int VEGGIE_TAG_ID = 2;

		// Token: 0x04001F64 RID: 8036
		[Token(Token = "0x4001F64")]
		public const int MUSHROOM_TAG_ID = 26;

		// Token: 0x04001F65 RID: 8037
		[Token(Token = "0x4001F65")]
		public const int NONALCOHOLIC_TAG_ID = -1;

		// Token: 0x04001F66 RID: 8038
		[Token(Token = "0x4001F66")]
		public const int REIMU_ID = 7;

		// Token: 0x04001F67 RID: 8039
		[Token(Token = "0x4001F67")]
		public const int KYOUKO_ID = 14;

		// Token: 0x04001F68 RID: 8040
		[Token(Token = "0x4001F68")]
		public const int FAILED_ID = -1;

		// Token: 0x04001F69 RID: 8041
		[Token(Token = "0x4001F69")]
		public const int DEFAULT_TAG = -100;

		// Token: 0x04001F6A RID: 8042
		[Token(Token = "0x4001F6A")]
		public const float DELAY_TO_GIVE_TIP = 1.7f;

		// Token: 0x04001F6B RID: 8043
		[Token(Token = "0x4001F6B")]
		public const string BEST_EVAL_SET_PRD_RATE = "BestEvalSetRate";

		// Token: 0x04001F6C RID: 8044
		[Token(Token = "0x4001F6C")]
		public const string FREE_COOK_SET_PRD_RATE = "FreeCookSetRate";

		// Token: 0x04001F6D RID: 8045
		[Token(Token = "0x4001F6D")]
		private const int MAX_COMBO_FEE = 15;

		// Token: 0x04001F6E RID: 8046
		[Token(Token = "0x4001F6E")]
		private const int SERVEDGUESTNUM_REPAIR_LOSECOMBO = 5;

		// Token: 0x04001F6F RID: 8047
		[Token(Token = "0x4001F6F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly EventManager.BuffType[] DoNotShowTipFundExpGetMessageCheck;

		// Token: 0x04001F70 RID: 8048
		[Token(Token = "0x4001F70")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly NightSceneDirector.ChallengeType[] DoNotShowTipFundExpGetMessageCheckChallengeMode;

		// Token: 0x04001F71 RID: 8049
		[Token(Token = "0x4001F71")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly EventManager.BuffType[] ShouldNotRecordGuestDataCheck;

		// Token: 0x04001F72 RID: 8050
		[Token(Token = "0x4001F72")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private readonly EventManager.BuffType[] ShouldGuestInstantEvaluateCheck;

		// Token: 0x04001F73 RID: 8051
		[Token(Token = "0x4001F73")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly NightSceneDirector.ChallengeType[] ShouldGuestInstantEvaluateCheckChallengeMode;

		// Token: 0x04001F74 RID: 8052
		[Token(Token = "0x4001F74")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly EventManager.BuffType[] ShouldGuestNotPatientFreezeCheck;

		// Token: 0x04001F75 RID: 8053
		[Token(Token = "0x4001F75")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly EventManager.BuffType[] ShouldGuestPatientFreezeCheck;

		// Token: 0x04001F76 RID: 8054
		[Token(Token = "0x4001F76")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly EventManager.BuffType[] ShouldPlayerThrowDeliverCheck;

		// Token: 0x04001F77 RID: 8055
		[Token(Token = "0x4001F77")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly EventManager.BuffType[] IsPlayerFeverCheck;

		// Token: 0x04001F78 RID: 8056
		[Token(Token = "0x4001F78")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly EventManager.BuffType[] IsFreeCookCheck;

		// Token: 0x04001F79 RID: 8057
		[Token(Token = "0x4001F79")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly EventManager.BuffType[] ShouldEvaluateUnderSparrowTuneCheck;

		// Token: 0x04001F7A RID: 8058
		[Token(Token = "0x4001F7A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Dictionary<string, int> PrdTryTimeRecord;

		// Token: 0x04001F7D RID: 8061
		[Token(Token = "0x4001F7D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int registeredQueuedGuestLeaveBuff;

		// Token: 0x04001F7E RID: 8062
		[Token(Token = "0x4001F7E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private int registeredDoNotCloseIzakayaStatus;

		// Token: 0x04001F7F RID: 8063
		[Token(Token = "0x4001F7F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly List<float> registeredSpawnRateModifier;

		// Token: 0x04001F80 RID: 8064
		[Token(Token = "0x4001F80")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private readonly List<float> registeredNormalGuestSpawnRateModifier;

		// Token: 0x04001F81 RID: 8065
		[Token(Token = "0x4001F81")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private readonly List<float> registeredSpecialGuestSpawnRateModifier;

		// Token: 0x04001F82 RID: 8066
		[Token(Token = "0x4001F82")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private readonly List<float> registeredOrderCycleRateModifier;

		// Token: 0x04001F83 RID: 8067
		[Token(Token = "0x4001F83")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private readonly List<float> registeredExtraFeeModifier;

		// Token: 0x04001F84 RID: 8068
		[Token(Token = "0x4001F84")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private readonly List<float> registeredEvalSpeedModifier;

		// Token: 0x04001F85 RID: 8069
		[Token(Token = "0x4001F85")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private readonly List<float> registeredExtraMoveSpeedModifier;

		// Token: 0x04001F86 RID: 8070
		[Token(Token = "0x4001F86")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private readonly List<float> registeredOrderSpeedModifier;

		// Token: 0x04001F87 RID: 8071
		[Token(Token = "0x4001F87")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private readonly Dictionary<int, List<float>> registeredPartnerExtraMoveSpeedModifier;

		// Token: 0x04001F88 RID: 8072
		[Token(Token = "0x4001F88")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private readonly Dictionary<int, List<float>> registeredPartnerExtraMoveSpeedModifierByIndex;

		// Token: 0x04001F89 RID: 8073
		[Token(Token = "0x4001F89")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private readonly Dictionary<int, List<float>> registeredPartnerExtraWorkSpeedModifier;

		// Token: 0x04001F8A RID: 8074
		[Token(Token = "0x4001F8A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private readonly Dictionary<int, List<float>> registeredPartnerExtraWorkSpeedModifierByIndex;

		// Token: 0x04001F8B RID: 8075
		[Token(Token = "0x4001F8B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private readonly Dictionary<int, List<float>> registeredPartnerExtraCookSpeedModifier;

		// Token: 0x04001F8C RID: 8076
		[Token(Token = "0x4001F8C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private readonly Dictionary<int, List<float>> registeredPartnerExtraCookSpeedModifierByIndex;

		// Token: 0x04001F8D RID: 8077
		[Token(Token = "0x4001F8D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private readonly List<EventManager.EvalModifier> registeredBaseLineEvalModifier;

		// Token: 0x04001F8E RID: 8078
		[Token(Token = "0x4001F8E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private readonly List<EventManager.CountedEvalModifier> registeredCountedEvalModifier;

		// Token: 0x04001F8F RID: 8079
		[Token(Token = "0x4001F8F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private readonly List<float> registeredBestEvalRateModifier;

		// Token: 0x04001F90 RID: 8080
		[Token(Token = "0x4001F90")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private readonly List<int> registeredExtraMoodAddModifier;

		// Token: 0x04001F91 RID: 8081
		[Token(Token = "0x4001F91")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private readonly List<float> registeredFreeCookRate;

		// Token: 0x04001F92 RID: 8082
		[Token(Token = "0x4001F92")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly Dictionary<EventManager.BuffType, CountedBuffData> registeredCountedBuff;

		// Token: 0x04001F93 RID: 8083
		[Token(Token = "0x4001F93")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private readonly Dictionary<EventManager.BuffType, Dictionary<Guid, EventManager.ScheduledFunction>> registeredTimedBuff;

		// Token: 0x04001F94 RID: 8084
		[Token(Token = "0x4001F94")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private readonly List<IEnumerable<int>> lockedDailyRecipeIndexes;

		// Token: 0x04001F95 RID: 8085
		[Token(Token = "0x4001F95")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private readonly List<EventManager.FoodOverrideModifier> registeredOverrideFoodBuff;

		// Token: 0x04001F96 RID: 8086
		[Token(Token = "0x4001F96")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private readonly List<EventManager.CookTimeModifier> registeredCookTimeModifier;

		// Token: 0x04001F97 RID: 8087
		[Token(Token = "0x4001F97")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private readonly List<EventManager.AdditiveContinueProbabilityModifier> registeredAdditiveContinueProbabilityModifier;

		// Token: 0x04001F98 RID: 8088
		[Token(Token = "0x4001F98")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly List<Func<float>> extraCookTimeModifier;

		// Token: 0x04001F99 RID: 8089
		[Token(Token = "0x4001F99")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private readonly List<IEnumerable<int>> lockedTables;

		// Token: 0x04001F9A RID: 8090
		[Token(Token = "0x4001F9A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly List<IEnumerable<int>> playerCannotOpenTables;

		// Token: 0x04001F9B RID: 8091
		[Token(Token = "0x4001F9B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly List<int> playerCannotOpenTablesList;

		// Token: 0x04001F9C RID: 8092
		[Token(Token = "0x4001F9C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly List<float> extraPartnerWage;

		// Token: 0x04001F9D RID: 8093
		[Token(Token = "0x4001F9D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly List<float> registeredFundIncomeModifier;

		// Token: 0x04001F9E RID: 8094
		[Token(Token = "0x4001F9E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly List<float> registeredExtraIngredientsCostModifier;

		// Token: 0x04001F9F RID: 8095
		[Token(Token = "0x4001F9F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly List<float> registeredExtraBevCostModifier;

		// Token: 0x04001FA0 RID: 8096
		[Token(Token = "0x4001FA0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<int> lockedTrayIndexes;

		// Token: 0x04001FA1 RID: 8097
		[Token(Token = "0x4001FA1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly List<float> registeredExtraGenerateFundModifier;

		// Token: 0x04001FA2 RID: 8098
		[Token(Token = "0x4001FA2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly List<EventManager.OutputChecker> registeredOutputCheckers;

		// Token: 0x04001FA3 RID: 8099
		[Token(Token = "0x4001FA3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly List<IEnumerable<int>> exiledGuestIndexes;

		// Token: 0x04001FA4 RID: 8100
		[Token(Token = "0x4001FA4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly Queue<Func<Action, IEnumerator>> spellExecutionQueue;

		// Token: 0x04001FA5 RID: 8101
		[Token(Token = "0x4001FA5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly List<EventManager.ExtraPayModifier> extraPayModifiers;

		// Token: 0x04001FAE RID: 8110
		[Token(Token = "0x4001FAE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private Func<int> CurrentMusicLevelHandle;

		// Token: 0x04001FD9 RID: 8153
		[Token(Token = "0x4001FD9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		public Func<IList<int>> InvitedGuestDataSourceProvider;

		// Token: 0x04001FDA RID: 8154
		[Token(Token = "0x4001FDA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		public Func<IList<int>> IgnoredGuestDataSourceProvider;

		// Token: 0x04001FDB RID: 8155
		[Token(Token = "0x4001FDB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		public Func<IList<int>> SpecialGuestPoolDataSourceProvider;

		// Token: 0x04001FDC RID: 8156
		[Token(Token = "0x4001FDC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		public Func<int> SpecialGuestIdGenerator;

		// Token: 0x04001FDD RID: 8157
		[Token(Token = "0x4001FDD")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		public Func<bool> SpecialGuestIdCanGachaGetter;

		// Token: 0x04001FDE RID: 8158
		[Token(Token = "0x4001FDE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		public Func<int, bool> CheckThisGuestHasSpawnedTonightHandler;

		// Token: 0x04001FDF RID: 8159
		[Token(Token = "0x4001FDF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		public Action<int> SetTargetGuestHasSpawnedHandle;

		// Token: 0x04001FE0 RID: 8160
		[Token(Token = "0x4001FE0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		public Func<int> GetWholeNightTime;

		// Token: 0x020005DF RID: 1503
		[Token(Token = "0x20005DF")]
		public enum RabbitType
		{
			// Token: 0x04001FE3 RID: 8163
			[Token(Token = "0x4001FE3")]
			RabbitGuest,
			// Token: 0x04001FE4 RID: 8164
			[Token(Token = "0x4001FE4")]
			RabbitDecoration,
			// Token: 0x04001FE5 RID: 8165
			[Token(Token = "0x4001FE5")]
			RabbitEffect
		}

		// Token: 0x020005E0 RID: 1504
		// (Invoke) Token: 0x06002462 RID: 9314
		[Token(Token = "0x20005E0")]
		public delegate bool BuffFrozenCheckDelegate(int currentTime);

		// Token: 0x020005E1 RID: 1505
		[Token(Token = "0x20005E1")]
		public enum BuffType
		{
			// Token: 0x04001FE7 RID: 8167
			[Token(Token = "0x4001FE7")]
			Null,
			// Token: 0x04001FE8 RID: 8168
			[Token(Token = "0x4001FE8")]
			LockDailyRecipe,
			// Token: 0x04001FE9 RID: 8169
			[Token(Token = "0x4001FE9")]
			UnlockInfo,
			// Token: 0x04001FEA RID: 8170
			[Token(Token = "0x4001FEA")]
			Stun,
			// Token: 0x04001FEB RID: 8171
			[Token(Token = "0x4001FEB")]
			CookTimeOnTargetTag,
			// Token: 0x04001FEC RID: 8172
			[Token(Token = "0x4001FEC")]
			FreeCook,
			// Token: 0x04001FED RID: 8173
			[Token(Token = "0x4001FED")]
			LockGuestTable,
			// Token: 0x04001FEE RID: 8174
			[Token(Token = "0x4001FEE")]
			NormalGuestSpawnMultiplier,
			// Token: 0x04001FEF RID: 8175
			[Token(Token = "0x4001FEF")]
			InstantEvaluation,
			// Token: 0x04001FF0 RID: 8176
			[Token(Token = "0x4001FF0")]
			PatientFreeze,
			// Token: 0x04001FF1 RID: 8177
			[Token(Token = "0x4001FF1")]
			ThrowDeliver,
			// Token: 0x04001FF2 RID: 8178
			[Token(Token = "0x4001FF2")]
			SpawnNorm,
			// Token: 0x04001FF3 RID: 8179
			[Token(Token = "0x4001FF3")]
			Fever,
			// Token: 0x04001FF4 RID: 8180
			[Token(Token = "0x4001FF4")]
			Skill_Rumia_Curtain,
			// Token: 0x04001FF5 RID: 8181
			[Token(Token = "0x4001FF5")]
			Skill_Reimu_Shield,
			// Token: 0x04001FF6 RID: 8182
			[Token(Token = "0x4001FF6")]
			Skill_Kasen_Art,
			// Token: 0x04001FF7 RID: 8183
			[Token(Token = "0x4001FF7")]
			Skill_Kasen_Punishment,
			// Token: 0x04001FF8 RID: 8184
			[Token(Token = "0x4001FF8")]
			LockCooker,
			// Token: 0x04001FF9 RID: 8185
			[Token(Token = "0x4001FF9")]
			QuickCook,
			// Token: 0x04001FFA RID: 8186
			[Token(Token = "0x4001FFA")]
			Skill_Chen_Punishment,
			// Token: 0x04001FFB RID: 8187
			[Token(Token = "0x4001FFB")]
			ExtraFeeRate,
			// Token: 0x04001FFC RID: 8188
			[Token(Token = "0x4001FFC")]
			OrderCycleRate,
			// Token: 0x04001FFD RID: 8189
			[Token(Token = "0x4001FFD")]
			AddPasssionPerSec,
			// Token: 0x04001FFE RID: 8190
			[Token(Token = "0x4001FFE")]
			FoodKiller,
			// Token: 0x04001FFF RID: 8191
			[Token(Token = "0x4001FFF")]
			PhilosopherStone,
			// Token: 0x04002000 RID: 8192
			[Token(Token = "0x4002000")]
			Skill_Tewi_Punishment,
			// Token: 0x04002001 RID: 8193
			[Token(Token = "0x4002001")]
			CookTimeOnTargetCooker,
			// Token: 0x04002002 RID: 8194
			[Token(Token = "0x4002002")]
			Skill_Mokou_Reward,
			// Token: 0x04002003 RID: 8195
			[Token(Token = "0x4002003")]
			Skill_Mokou_Punishment,
			// Token: 0x04002004 RID: 8196
			[Token(Token = "0x4002004")]
			Skill_Youmu_Reward,
			// Token: 0x04002005 RID: 8197
			[Token(Token = "0x4002005")]
			Skill_Youmu_Punishment,
			// Token: 0x04002006 RID: 8198
			[Token(Token = "0x4002006")]
			Skill_Wriggle_Reward,
			// Token: 0x04002007 RID: 8199
			[Token(Token = "0x4002007")]
			Tip_Exceptional,
			// Token: 0x04002008 RID: 8200
			[Token(Token = "0x4002008")]
			ExtraFeeForever,
			// Token: 0x04002009 RID: 8201
			[Token(Token = "0x4002009")]
			ExtraMood,
			// Token: 0x0400200A RID: 8202
			[Token(Token = "0x400200A")]
			FreeCookPercentage,
			// Token: 0x0400200B RID: 8203
			[Token(Token = "0x400200B")]
			BestEvalPercentage,
			// Token: 0x0400200C RID: 8204
			[Token(Token = "0x400200C")]
			EatTimeMultiplier,
			// Token: 0x0400200D RID: 8205
			[Token(Token = "0x400200D")]
			ExtraOrder,
			// Token: 0x0400200E RID: 8206
			[Token(Token = "0x400200E")]
			BaseCostSet,
			// Token: 0x0400200F RID: 8207
			[Token(Token = "0x400200F")]
			Skill_Ushio_Punishment,
			// Token: 0x04002010 RID: 8208
			[Token(Token = "0x4002010")]
			Skill_Yuu_Reward,
			// Token: 0x04002011 RID: 8209
			[Token(Token = "0x4002011")]
			Skill_Yuu_Punishment,
			// Token: 0x04002012 RID: 8210
			[Token(Token = "0x4002012")]
			Skill_Yuyuko_Reward,
			// Token: 0x04002013 RID: 8211
			[Token(Token = "0x4002013")]
			Skill_Yuyuko_Punishment,
			// Token: 0x04002014 RID: 8212
			[Token(Token = "0x4002014")]
			Boss_Yuyuko,
			// Token: 0x04002015 RID: 8213
			[Token(Token = "0x4002015")]
			Skill_Momizi_Reward,
			// Token: 0x04002016 RID: 8214
			[Token(Token = "0x4002016")]
			Skill_Momizi_Punishment,
			// Token: 0x04002017 RID: 8215
			[Token(Token = "0x4002017")]
			NoBuffTime,
			// Token: 0x04002018 RID: 8216
			[Token(Token = "0x4002018")]
			PartnerThrowDeliver,
			// Token: 0x04002019 RID: 8217
			[Token(Token = "0x4002019")]
			Totetsu_Dinner,
			// Token: 0x0400201A RID: 8218
			[Token(Token = "0x400201A")]
			Boss_Totetsu,
			// Token: 0x0400201B RID: 8219
			[Token(Token = "0x400201B")]
			Broken_Cookware,
			// Token: 0x0400201C RID: 8220
			[Token(Token = "0x400201C")]
			Broken_Cookware_Forever,
			// Token: 0x0400201D RID: 8221
			[Token(Token = "0x400201D")]
			Skill_Narumi_Reward,
			// Token: 0x0400201E RID: 8222
			[Token(Token = "0x400201E")]
			Partner_Komachi,
			// Token: 0x0400201F RID: 8223
			[Token(Token = "0x400201F")]
			Partner_Kisume,
			// Token: 0x04002020 RID: 8224
			[Token(Token = "0x4002020")]
			Skill_Yamame_Reward,
			// Token: 0x04002021 RID: 8225
			[Token(Token = "0x4002021")]
			SlowDown,
			// Token: 0x04002022 RID: 8226
			[Token(Token = "0x4002022")]
			Skill_Yuugi_Punishment,
			// Token: 0x04002023 RID: 8227
			[Token(Token = "0x4002023")]
			Skill_Yuugi_Punishment_2,
			// Token: 0x04002024 RID: 8228
			[Token(Token = "0x4002024")]
			Skill_Yuugi_Punishment_3,
			// Token: 0x04002025 RID: 8229
			[Token(Token = "0x4002025")]
			Skill_Orin_Reward,
			// Token: 0x04002026 RID: 8230
			[Token(Token = "0x4002026")]
			Skill_Utsuho_Reward,
			// Token: 0x04002027 RID: 8231
			[Token(Token = "0x4002027")]
			Skill_Utsuho_Punishment,
			// Token: 0x04002028 RID: 8232
			[Token(Token = "0x4002028")]
			Satori_Eye,
			// Token: 0x04002029 RID: 8233
			[Token(Token = "0x4002029")]
			Parsee_Shield,
			// Token: 0x0400202A RID: 8234
			[Token(Token = "0x400202A")]
			BOSS_KOISHI_PHASE_1,
			// Token: 0x0400202B RID: 8235
			[Token(Token = "0x400202B")]
			BOSS_KOISHI_PHASE_2,
			// Token: 0x0400202C RID: 8236
			[Token(Token = "0x400202C")]
			BOSS_KOISHI_PHASE_3,
			// Token: 0x0400202D RID: 8237
			[Token(Token = "0x400202D")]
			Unconscious_Object,
			// Token: 0x0400202E RID: 8238
			[Token(Token = "0x400202E")]
			Skill_Koishi_Punishment,
			// Token: 0x0400202F RID: 8239
			[Token(Token = "0x400202F")]
			Skill_Koishi_Reward,
			// Token: 0x04002030 RID: 8240
			[Token(Token = "0x4002030")]
			MoveFaster,
			// Token: 0x04002031 RID: 8241
			[Token(Token = "0x4002031")]
			PartnerBuff_Sakuya_Deportation,
			// Token: 0x04002032 RID: 8242
			[Token(Token = "0x4002032")]
			PartnerBuff_Sakuya_Intimidate,
			// Token: 0x04002033 RID: 8243
			[Token(Token = "0x4002033")]
			PartnerBuff_Sakuya_TheWorld,
			// Token: 0x04002034 RID: 8244
			[Token(Token = "0x4002034")]
			PartnerBuff_Sakuya_Fever,
			// Token: 0x04002035 RID: 8245
			[Token(Token = "0x4002035")]
			Kogasa_Positive,
			// Token: 0x04002036 RID: 8246
			[Token(Token = "0x4002036")]
			Murasa_Positive,
			// Token: 0x04002037 RID: 8247
			[Token(Token = "0x4002037")]
			Murasa_Negative,
			// Token: 0x04002038 RID: 8248
			[Token(Token = "0x4002038")]
			Nue_Positive_3Red,
			// Token: 0x04002039 RID: 8249
			[Token(Token = "0x4002039")]
			Nue_Positive_3Green,
			// Token: 0x0400203A RID: 8250
			[Token(Token = "0x400203A")]
			Nue_Positive_3Blue,
			// Token: 0x0400203B RID: 8251
			[Token(Token = "0x400203B")]
			Nue_Negative_2Red,
			// Token: 0x0400203C RID: 8252
			[Token(Token = "0x400203C")]
			Nue_Negative_2Green,
			// Token: 0x0400203D RID: 8253
			[Token(Token = "0x400203D")]
			Nue_Negative_2Blue,
			// Token: 0x0400203E RID: 8254
			[Token(Token = "0x400203E")]
			Seiga_Positive,
			// Token: 0x0400203F RID: 8255
			[Token(Token = "0x400203F")]
			Seiga_Negative,
			// Token: 0x04002040 RID: 8256
			[Token(Token = "0x4002040")]
			Tojiko_Positive,
			// Token: 0x04002041 RID: 8257
			[Token(Token = "0x4002041")]
			Tojiko_Negative,
			// Token: 0x04002042 RID: 8258
			[Token(Token = "0x4002042")]
			Tojiko_Negative_Stun,
			// Token: 0x04002043 RID: 8259
			[Token(Token = "0x4002043")]
			Futo_Positive,
			// Token: 0x04002044 RID: 8260
			[Token(Token = "0x4002044")]
			Futo_Negative,
			// Token: 0x04002045 RID: 8261
			[Token(Token = "0x4002045")]
			Mamizou_Negative,
			// Token: 0x04002046 RID: 8262
			[Token(Token = "0x4002046")]
			Futo_Burn,
			// Token: 0x04002047 RID: 8263
			[Token(Token = "0x4002047")]
			PartnerBuff_Kyouko_SolicitCustomers,
			// Token: 0x04002048 RID: 8264
			[Token(Token = "0x4002048")]
			PartnerBuff_Kyouko_InstantFinishEat,
			// Token: 0x04002049 RID: 8265
			[Token(Token = "0x4002049")]
			PartnerBuff_Kyouko_Focus,
			// Token: 0x0400204A RID: 8266
			[Token(Token = "0x400204A")]
			PartnerBuff_Kyouko_Fever,
			// Token: 0x0400204B RID: 8267
			[Token(Token = "0x400204B")]
			PartnerBuff_Kosuzu_Dialogues,
			// Token: 0x0400204C RID: 8268
			[Token(Token = "0x400204C")]
			PartnerBuff_Kosuzu_LunaticCook,
			// Token: 0x0400204D RID: 8269
			[Token(Token = "0x400204D")]
			PartnerBuff_Kosuzu_ThrowDeliver,
			// Token: 0x0400204E RID: 8270
			[Token(Token = "0x400204E")]
			PartnerBuff_Kosuzu_Fever,
			// Token: 0x0400204F RID: 8271
			[Token(Token = "0x400204F")]
			PartnerBuff_Aunn_MoreTip,
			// Token: 0x04002050 RID: 8272
			[Token(Token = "0x4002050")]
			PartnerBuff_Aunn_PatientFreeze,
			// Token: 0x04002051 RID: 8273
			[Token(Token = "0x4002051")]
			PartnerBuff_Aunn_GiveTip,
			// Token: 0x04002052 RID: 8274
			[Token(Token = "0x4002052")]
			PartnerBuff_Aunn_Fever,
			// Token: 0x04002053 RID: 8275
			[Token(Token = "0x4002053")]
			Seiga_Compulsion,
			// Token: 0x04002054 RID: 8276
			[Token(Token = "0x4002054")]
			Aya_Forbidden_Throw,
			// Token: 0x04002055 RID: 8277
			[Token(Token = "0x4002055")]
			Medicine_Positive,
			// Token: 0x04002056 RID: 8278
			[Token(Token = "0x4002056")]
			Medicine_Negative,
			// Token: 0x04002057 RID: 8279
			[Token(Token = "0x4002057")]
			Shinmyoumaru_Negative,
			// Token: 0x04002058 RID: 8280
			[Token(Token = "0x4002058")]
			Seija_Reverse_Negative,
			// Token: 0x04002059 RID: 8281
			[Token(Token = "0x4002059")]
			Seija_Reverse_Positive,
			// Token: 0x0400205A RID: 8282
			[Token(Token = "0x400205A")]
			Shinmyoumaru_Positive,
			// Token: 0x0400205B RID: 8283
			[Token(Token = "0x400205B")]
			Kagerou_Positive,
			// Token: 0x0400205C RID: 8284
			[Token(Token = "0x400205C")]
			Kagerou_Negative,
			// Token: 0x0400205D RID: 8285
			[Token(Token = "0x400205D")]
			Remilia_Positive,
			// Token: 0x0400205E RID: 8286
			[Token(Token = "0x400205E")]
			Remilia_Positive_During,
			// Token: 0x0400205F RID: 8287
			[Token(Token = "0x400205F")]
			Remilia_Positive_SpawnGuest,
			// Token: 0x04002060 RID: 8288
			[Token(Token = "0x4002060")]
			Remilia_Negative,
			// Token: 0x04002061 RID: 8289
			[Token(Token = "0x4002061")]
			Aya_Popular_Store,
			// Token: 0x04002062 RID: 8290
			[Token(Token = "0x4002062")]
			Aya_Positive,
			// Token: 0x04002063 RID: 8291
			[Token(Token = "0x4002063")]
			Yuuka_Positive_Flower,
			// Token: 0x04002064 RID: 8292
			[Token(Token = "0x4002064")]
			Yuuka_Positive_Shield,
			// Token: 0x04002065 RID: 8293
			[Token(Token = "0x4002065")]
			Yuuka_Negative,
			// Token: 0x04002066 RID: 8294
			[Token(Token = "0x4002066")]
			Larva_Sleep_Powder,
			// Token: 0x04002067 RID: 8295
			[Token(Token = "0x4002067")]
			Sekibanki_Head_Stampede,
			// Token: 0x04002068 RID: 8296
			[Token(Token = "0x4002068")]
			Yuka_SunPower,
			// Token: 0x04002069 RID: 8297
			[Token(Token = "0x4002069")]
			ShinmyoumaruBossBattle_MagicWallet,
			// Token: 0x0400206A RID: 8298
			[Token(Token = "0x400206A")]
			Patchouli_Spell_Metal,
			// Token: 0x0400206B RID: 8299
			[Token(Token = "0x400206B")]
			Patchouli_Spell_Wood,
			// Token: 0x0400206C RID: 8300
			[Token(Token = "0x400206C")]
			Patchouli_Spell_Water,
			// Token: 0x0400206D RID: 8301
			[Token(Token = "0x400206D")]
			Patchouli_Spell_Sun,
			// Token: 0x0400206E RID: 8302
			[Token(Token = "0x400206E")]
			Patchouli_Spell_Moon,
			// Token: 0x0400206F RID: 8303
			[Token(Token = "0x400206F")]
			Yuuka_Positive_Flower_Blossom,
			// Token: 0x04002070 RID: 8304
			[Token(Token = "0x4002070")]
			Ellen_LoveCandy,
			// Token: 0x04002071 RID: 8305
			[Token(Token = "0x4002071")]
			Ellen_BlackCat,
			// Token: 0x04002072 RID: 8306
			[Token(Token = "0x4002072")]
			Mima_GreatMagic,
			// Token: 0x04002073 RID: 8307
			[Token(Token = "0x4002073")]
			Mima_GreatMagicPlus,
			// Token: 0x04002074 RID: 8308
			[Token(Token = "0x4002074")]
			Mima_Paranoia,
			// Token: 0x04002075 RID: 8309
			[Token(Token = "0x4002075")]
			Luize_GulliverTravelBook,
			// Token: 0x04002076 RID: 8310
			[Token(Token = "0x4002076")]
			Luize_GulliverTravelBook_2,
			// Token: 0x04002077 RID: 8311
			[Token(Token = "0x4002077")]
			Luize_CinderellaBook,
			// Token: 0x04002078 RID: 8312
			[Token(Token = "0x4002078")]
			Luize_CinderellaBook_2,
			// Token: 0x04002079 RID: 8313
			[Token(Token = "0x4002079")]
			Reisen_RabbitFeast,
			// Token: 0x0400207A RID: 8314
			[Token(Token = "0x400207A")]
			Reisen_CrazyBullet,
			// Token: 0x0400207B RID: 8315
			[Token(Token = "0x400207B")]
			Yukari_BuffFrozen,
			// Token: 0x0400207C RID: 8316
			[Token(Token = "0x400207C")]
			Doremy_Dream1,
			// Token: 0x0400207D RID: 8317
			[Token(Token = "0x400207D")]
			Doremy_Dream2,
			// Token: 0x0400207E RID: 8318
			[Token(Token = "0x400207E")]
			Yorihime_KamiOracle,
			// Token: 0x0400207F RID: 8319
			[Token(Token = "0x400207F")]
			Yorihime_KamiPunishment,
			// Token: 0x04002080 RID: 8320
			[Token(Token = "0x4002080")]
			Toyohime_Positive,
			// Token: 0x04002081 RID: 8321
			[Token(Token = "0x4002081")]
			Toyohime_Negative,
			// Token: 0x04002082 RID: 8322
			[Token(Token = "0x4002082")]
			Sara_MakaiSalmon,
			// Token: 0x04002083 RID: 8323
			[Token(Token = "0x4002083")]
			RogueLike_Buff_MoreMoney,
			// Token: 0x04002084 RID: 8324
			[Token(Token = "0x4002084")]
			RogueLike_Buff_FreeBev,
			// Token: 0x04002085 RID: 8325
			[Token(Token = "0x4002085")]
			RogueLike_Buff_InstantHit,
			// Token: 0x04002086 RID: 8326
			[Token(Token = "0x4002086")]
			RogueLike_Buff_DriveGuestFree,
			// Token: 0x04002087 RID: 8327
			[Token(Token = "0x4002087")]
			RogueLike_Buff_Sagume,
			// Token: 0x04002088 RID: 8328
			[Token(Token = "0x4002088")]
			RogueLike_DangerousBuff_Nurgle,
			// Token: 0x04002089 RID: 8329
			[Token(Token = "0x4002089")]
			RogueLike_DangerousBuff_Slaanesh,
			// Token: 0x0400208A RID: 8330
			[Token(Token = "0x400208A")]
			RogueLike_DangerousBuff_Tzeentch,
			// Token: 0x0400208B RID: 8331
			[Token(Token = "0x400208B")]
			RogueLike_DangerousBuff_Khorne,
			// Token: 0x0400208C RID: 8332
			[Token(Token = "0x400208C")]
			RogueLike_DangerousBuff_Khorne_DeBuff,
			// Token: 0x0400208D RID: 8333
			[Token(Token = "0x400208D")]
			DLC5_BOSSBattle_Tan,
			// Token: 0x0400208E RID: 8334
			[Token(Token = "0x400208E")]
			DLC5_BOSSBattle_Tan_2,
			// Token: 0x0400208F RID: 8335
			[Token(Token = "0x400208F")]
			DLC5_BOSSBattle_Chen,
			// Token: 0x04002090 RID: 8336
			[Token(Token = "0x4002090")]
			DLC5_BOSSBattle_Chi,
			// Token: 0x04002091 RID: 8337
			[Token(Token = "0x4002091")]
			DLC5_BOSSBattle_Chi_2,
			// Token: 0x04002092 RID: 8338
			[Token(Token = "0x4002092")]
			DECORATION_FORBID_NORMAL,
			// Token: 0x04002093 RID: 8339
			[Token(Token = "0x4002093")]
			DECORATION_FORBID_SPECIAL,
			// Token: 0x04002094 RID: 8340
			[Token(Token = "0x4002094")]
			DLC5_DEVILSRECITATION,
			// Token: 0x04002095 RID: 8341
			[Token(Token = "0x4002095")]
			RogueLike_2_AddOrderRate,
			// Token: 0x04002096 RID: 8342
			[Token(Token = "0x4002096")]
			RogueLike_2_AddWorkSpeed,
			// Token: 0x04002097 RID: 8343
			[Token(Token = "0x4002097")]
			RogueLike_2_AddTipRate,
			// Token: 0x04002098 RID: 8344
			[Token(Token = "0x4002098")]
			RogueLike_2_ExtraGenerateFund,
			// Token: 0x04002099 RID: 8345
			[Token(Token = "0x4002099")]
			RogueLike_2_AddGuestSpawnSpeed,
			// Token: 0x0400209A RID: 8346
			[Token(Token = "0x400209A")]
			RogueLike_2_ExtraCookSpeed,
			// Token: 0x0400209B RID: 8347
			[Token(Token = "0x400209B")]
			RogueLike_2_Stone,
			// Token: 0x0400209C RID: 8348
			[Token(Token = "0x400209C")]
			RogueLike_2_Critical,
			// Token: 0x0400209D RID: 8349
			[Token(Token = "0x400209D")]
			RogueLike_2_Buff_ComboProtect,
			// Token: 0x0400209E RID: 8350
			[Token(Token = "0x400209E")]
			RogueLike_2_Buff_Chicken,
			// Token: 0x0400209F RID: 8351
			[Token(Token = "0x400209F")]
			RogueLike_2_Buff_Byakuren,
			// Token: 0x040020A0 RID: 8352
			[Token(Token = "0x40020A0")]
			RogueLike_2_Buff_Miko,
			// Token: 0x040020A1 RID: 8353
			[Token(Token = "0x40020A1")]
			RogueLike_2_ChineseCritical,
			// Token: 0x040020A2 RID: 8354
			[Token(Token = "0x40020A2")]
			RogueLike_2_JapaneseCritical,
			// Token: 0x040020A3 RID: 8355
			[Token(Token = "0x40020A3")]
			RogueLike_2_WesternCritical,
			// Token: 0x040020A4 RID: 8356
			[Token(Token = "0x40020A4")]
			RogueLike_2_PopularCritical,
			// Token: 0x040020A5 RID: 8357
			[Token(Token = "0x40020A5")]
			RogueLike_2_Shou,
			// Token: 0x040020A6 RID: 8358
			[Token(Token = "0x40020A6")]
			RogueLike_Echo,
			// Token: 0x040020A7 RID: 8359
			[Token(Token = "0x40020A7")]
			RogueLike_Prismriver,
			// Token: 0x040020A8 RID: 8360
			[Token(Token = "0x40020A8")]
			RogueLike_EmptyCard,
			// Token: 0x040020A9 RID: 8361
			[Token(Token = "0x40020A9")]
			RogueLike_Elite_Youmu,
			// Token: 0x040020AA RID: 8362
			[Token(Token = "0x40020AA")]
			RogueLike_Elite_Yuyuko,
			// Token: 0x040020AB RID: 8363
			[Token(Token = "0x40020AB")]
			RogueLike_Elite_Yuuma,
			// Token: 0x040020AC RID: 8364
			[Token(Token = "0x40020AC")]
			RogueLike_Elite_Koishi,
			// Token: 0x040020AD RID: 8365
			[Token(Token = "0x40020AD")]
			RogueLike_Elite_Mamizou,
			// Token: 0x040020AE RID: 8366
			[Token(Token = "0x40020AE")]
			RogueLike_Elite_Flandre,
			// Token: 0x040020AF RID: 8367
			[Token(Token = "0x40020AF")]
			RogueLike_Elite_Mizuchi
		}

		// Token: 0x020005E2 RID: 1506
		[Token(Token = "0x20005E2")]
		public enum MathOperation
		{
			// Token: 0x040020B1 RID: 8369
			[Token(Token = "0x40020B1")]
			Add,
			// Token: 0x040020B2 RID: 8370
			[Token(Token = "0x40020B2")]
			Multiply,
			// Token: 0x040020B3 RID: 8371
			[Token(Token = "0x40020B3")]
			Set
		}

		// Token: 0x020005E3 RID: 1507
		[Token(Token = "0x20005E3")]
		public enum InventoryIOType
		{
			// Token: 0x040020B5 RID: 8373
			[Token(Token = "0x40020B5")]
			Ingredient,
			// Token: 0x040020B6 RID: 8374
			[Token(Token = "0x40020B6")]
			Beverage,
			// Token: 0x040020B7 RID: 8375
			[Token(Token = "0x40020B7")]
			Food
		}

		// Token: 0x020005E4 RID: 1508
		[Token(Token = "0x20005E4")]
		public enum InventoryPriceSortType
		{
			// Token: 0x040020B9 RID: 8377
			[Token(Token = "0x40020B9")]
			Ascending,
			// Token: 0x040020BA RID: 8378
			[Token(Token = "0x40020BA")]
			Descending,
			// Token: 0x040020BB RID: 8379
			[Token(Token = "0x40020BB")]
			Null
		}

		// Token: 0x020005E5 RID: 1509
		[Token(Token = "0x20005E5")]
		public class ScheduledFunction
		{
			// Token: 0x06002465 RID: 9317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002465")]
			[Address(RVA = "0x51B8F0", Offset = "0x51A2F0", VA = "0x18051B8F0")]
			public ScheduledFunction(int durationSec, Action actionEndCallBack, Action<int> actionUpdateCallBack, EventManager eventManager)
			{
			}

			// Token: 0x06002466 RID: 9318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002466")]
			[Address(RVA = "0x51B8B0", Offset = "0x51A2B0", VA = "0x18051B8B0")]
			public ScheduledFunction(Action actionEndCallBack)
			{
			}

			// Token: 0x1700051F RID: 1311
			// (get) Token: 0x06002467 RID: 9319 RVA: 0x0000D848 File Offset: 0x0000BA48
			// (set) Token: 0x06002468 RID: 9320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700051F")]
			public int RemainTime
			{
				[Token(Token = "0x6002467")]
				[Address(RVA = "0x44F9E0", Offset = "0x44E3E0", VA = "0x18044F9E0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6002468")]
				[Address(RVA = "0x450630", Offset = "0x44F030", VA = "0x180450630")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06002469 RID: 9321 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002469")]
			[Address(RVA = "0x51B770", Offset = "0x51A170", VA = "0x18051B770")]
			public void Interrupt()
			{
			}

			// Token: 0x0600246A RID: 9322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600246A")]
			[Address(RVA = "0x51B780", Offset = "0x51A180", VA = "0x18051B780")]
			private void UpdateTime()
			{
			}

			// Token: 0x0600246B RID: 9323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600246B")]
			[Address(RVA = "0x51B660", Offset = "0x51A060", VA = "0x18051B660")]
			private void FinishAction()
			{
			}

			// Token: 0x040020BC RID: 8380
			[Token(Token = "0x40020BC")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Action actionEndCallBack;

			// Token: 0x040020BD RID: 8381
			[Token(Token = "0x40020BD")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly Action<int> actionUpdateCallBack;

			// Token: 0x040020BE RID: 8382
			[Token(Token = "0x40020BE")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private readonly EventManager eventManager;
		}

		// Token: 0x020005E6 RID: 1510
		[Token(Token = "0x20005E6")]
		private struct AdditiveContinueProbabilityModifier
		{
			// Token: 0x0600246C RID: 9324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600246C")]
			[Address(RVA = "0x5172F0", Offset = "0x515CF0", VA = "0x1805172F0")]
			public AdditiveContinueProbabilityModifier(int tag, Cooker.CookerType cookerType, float modifyValue)
			{
			}

			// Token: 0x0600246D RID: 9325 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600246D")]
			[Address(RVA = "0x5172D0", Offset = "0x515CD0", VA = "0x1805172D0")]
			public AdditiveContinueProbabilityModifier(int tag, Cooker.CookerType cookerType, float modifyValue, Func<Sellable, GuestGroupController, bool> extraCheck)
			{
			}

			// Token: 0x17000520 RID: 1312
			// (get) Token: 0x0600246E RID: 9326 RVA: 0x0000D860 File Offset: 0x0000BA60
			[Token(Token = "0x17000520")]
			public readonly int Tag
			{
				[Token(Token = "0x600246E")]
				[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000521 RID: 1313
			// (get) Token: 0x0600246F RID: 9327 RVA: 0x0000D878 File Offset: 0x0000BA78
			[Token(Token = "0x17000521")]
			public readonly Cooker.CookerType CookerType
			{
				[Token(Token = "0x600246F")]
				[Address(RVA = "0x43B0B0", Offset = "0x439AB0", VA = "0x18043B0B0")]
				[CompilerGenerated]
				get
				{
					return Cooker.CookerType.Empty;
				}
			}

			// Token: 0x17000522 RID: 1314
			// (get) Token: 0x06002470 RID: 9328 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000522")]
			public readonly Func<Sellable, GuestGroupController, bool> ExtraCheck
			{
				[Token(Token = "0x6002470")]
				[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000523 RID: 1315
			// (get) Token: 0x06002471 RID: 9329 RVA: 0x0000D890 File Offset: 0x0000BA90
			[Token(Token = "0x17000523")]
			public readonly float ModifyValue
			{
				[Token(Token = "0x6002471")]
				[Address(RVA = "0x3FAD40", Offset = "0x3F9740", VA = "0x1803FAD40")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
			}
		}

		// Token: 0x020005E7 RID: 1511
		[Token(Token = "0x20005E7")]
		private struct CookTimeModifier
		{
			// Token: 0x06002472 RID: 9330 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002472")]
			[Address(RVA = "0x5172F0", Offset = "0x515CF0", VA = "0x1805172F0")]
			public CookTimeModifier(int tag, Cooker.CookerType cookerType, float modifyValue)
			{
			}

			// Token: 0x06002473 RID: 9331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002473")]
			[Address(RVA = "0x5172D0", Offset = "0x515CD0", VA = "0x1805172D0")]
			public CookTimeModifier(int tag, Cooker.CookerType cookerType, float modifyValue, Func<Sellable, float, bool> extraCheck)
			{
			}

			// Token: 0x17000524 RID: 1316
			// (get) Token: 0x06002474 RID: 9332 RVA: 0x0000D8A8 File Offset: 0x0000BAA8
			[Token(Token = "0x17000524")]
			public readonly int Tag
			{
				[Token(Token = "0x6002474")]
				[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000525 RID: 1317
			// (get) Token: 0x06002475 RID: 9333 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
			[Token(Token = "0x17000525")]
			public readonly Cooker.CookerType CookerType
			{
				[Token(Token = "0x6002475")]
				[Address(RVA = "0x43B0B0", Offset = "0x439AB0", VA = "0x18043B0B0")]
				[CompilerGenerated]
				get
				{
					return Cooker.CookerType.Empty;
				}
			}

			// Token: 0x17000526 RID: 1318
			// (get) Token: 0x06002476 RID: 9334 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000526")]
			public readonly Func<Sellable, float, bool> ExtraCheck
			{
				[Token(Token = "0x6002476")]
				[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000527 RID: 1319
			// (get) Token: 0x06002477 RID: 9335 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
			[Token(Token = "0x17000527")]
			public readonly float ModifyValue
			{
				[Token(Token = "0x6002477")]
				[Address(RVA = "0x3FAD40", Offset = "0x3F9740", VA = "0x1803FAD40")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
			}
		}

		// Token: 0x020005E8 RID: 1512
		[Token(Token = "0x20005E8")]
		public struct SelectedValue
		{
			// Token: 0x06002478 RID: 9336 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002478")]
			[Address(RVA = "0x51BE50", Offset = "0x51A850", VA = "0x18051BE50")]
			public SelectedValue(EventManager.InventoryIOType iOType)
			{
			}

			// Token: 0x06002479 RID: 9337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002479")]
			[Address(RVA = "0x51BEB0", Offset = "0x51A8B0", VA = "0x18051BEB0")]
			public SelectedValue(IEnumerable<int> selectedId, EventManager.InventoryIOType iOType)
			{
			}

			// Token: 0x0600247A RID: 9338 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600247A")]
			[Address(RVA = "0x51BDD0", Offset = "0x51A7D0", VA = "0x18051BDD0")]
			public SelectedValue(int selectedId, int selectedAmount, EventManager.InventoryIOType iOType)
			{
			}

			// Token: 0x17000528 RID: 1320
			// (get) Token: 0x0600247B RID: 9339 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000528")]
			public readonly IEnumerable<int> SelectedId
			{
				[Token(Token = "0x600247B")]
				[Address(RVA = "0x4070A0", Offset = "0x405AA0", VA = "0x1804070A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000529 RID: 1321
			// (get) Token: 0x0600247C RID: 9340 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
			[Token(Token = "0x17000529")]
			public readonly EventManager.InventoryIOType IOType
			{
				[Token(Token = "0x600247C")]
				[Address(RVA = "0x48B8C0", Offset = "0x48A2C0", VA = "0x18048B8C0")]
				[CompilerGenerated]
				get
				{
					return EventManager.InventoryIOType.Ingredient;
				}
			}

			// Token: 0x1700052A RID: 1322
			// (get) Token: 0x0600247D RID: 9341 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700052A")]
			public IEnumerable<ObjectLanguageBase> Text
			{
				[Token(Token = "0x600247D")]
				[Address(RVA = "0x51BEE0", Offset = "0x51A8E0", VA = "0x18051BEE0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600247E RID: 9342 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600247E")]
			[Address(RVA = "0x51BA50", Offset = "0x51A450", VA = "0x18051BA50", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		// Token: 0x020005EA RID: 1514
		[Token(Token = "0x20005EA")]
		public struct EvalModifier
		{
			// Token: 0x06002487 RID: 9351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002487")]
			[Address(RVA = "0x517960", Offset = "0x516360", VA = "0x180517960")]
			public EvalModifier(int tag, int modifyValue, bool containsOrNot = true, EventManager.EvalModifier.ModifierType modifierType = EventManager.EvalModifier.ModifierType.AbsolutedMax, EventManager.EvalModifier.CheckType checkType = EventManager.EvalModifier.CheckType.Food)
			{
			}

			// Token: 0x06002488 RID: 9352 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002488")]
			[Address(RVA = "0x5178F0", Offset = "0x5162F0", VA = "0x1805178F0")]
			public EvalModifier(int tag, int modifyValue, Predicate<GuestGroupController> evalGuestExtraCheck, Predicate<GuestGroupController.EvaluationResult> baseResultExtraCheck, bool containsOrNot = true, EventManager.EvalModifier.ModifierType modifierType = EventManager.EvalModifier.ModifierType.AbsolutedMin, EventManager.EvalModifier.CheckType checkType = EventManager.EvalModifier.CheckType.Food)
			{
			}

			// Token: 0x1700052B RID: 1323
			// (get) Token: 0x06002489 RID: 9353 RVA: 0x0000D908 File Offset: 0x0000BB08
			[Token(Token = "0x1700052B")]
			public readonly int Tag
			{
				[Token(Token = "0x6002489")]
				[Address(RVA = "0x48B8C0", Offset = "0x48A2C0", VA = "0x18048B8C0")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700052C RID: 1324
			// (get) Token: 0x0600248A RID: 9354 RVA: 0x0000D920 File Offset: 0x0000BB20
			[Token(Token = "0x1700052C")]
			public readonly bool ContainsOrNot
			{
				[Token(Token = "0x600248A")]
				[Address(RVA = "0x44F220", Offset = "0x44DC20", VA = "0x18044F220")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700052D RID: 1325
			// (get) Token: 0x0600248B RID: 9355 RVA: 0x0000D938 File Offset: 0x0000BB38
			[Token(Token = "0x1700052D")]
			public readonly int ModifyValue
			{
				[Token(Token = "0x600248B")]
				[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700052E RID: 1326
			// (get) Token: 0x0600248C RID: 9356 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700052E")]
			public readonly Predicate<GuestGroupController> EvalGuestExtraCheck
			{
				[Token(Token = "0x600248C")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x1700052F RID: 1327
			// (get) Token: 0x0600248D RID: 9357 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700052F")]
			public readonly Predicate<GuestGroupController.EvaluationResult> BaseResultExtraCheck
			{
				[Token(Token = "0x600248D")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x040020D1 RID: 8401
			[Token(Token = "0x40020D1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public EventManager.EvalModifier.ModifierType modifierType;

			// Token: 0x040020D2 RID: 8402
			[Token(Token = "0x40020D2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public EventManager.EvalModifier.CheckType checkType;

			// Token: 0x020005EB RID: 1515
			[Token(Token = "0x20005EB")]
			public enum ModifierType
			{
				// Token: 0x040020D9 RID: 8409
				[Token(Token = "0x40020D9")]
				AbsolutedMax,
				// Token: 0x040020DA RID: 8410
				[Token(Token = "0x40020DA")]
				AbsolutedMin,
				// Token: 0x040020DB RID: 8411
				[Token(Token = "0x40020DB")]
				Randomed,
				// Token: 0x040020DC RID: 8412
				[Token(Token = "0x40020DC")]
				Locked
			}

			// Token: 0x020005EC RID: 1516
			[Token(Token = "0x20005EC")]
			public enum CheckType
			{
				// Token: 0x040020DE RID: 8414
				[Token(Token = "0x40020DE")]
				Food,
				// Token: 0x040020DF RID: 8415
				[Token(Token = "0x40020DF")]
				Beverage
			}
		}

		// Token: 0x020005ED RID: 1517
		[Token(Token = "0x20005ED")]
		public class CountedEvalModifier
		{
			// Token: 0x0600248E RID: 9358 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600248E")]
			[Address(RVA = "0x517890", Offset = "0x516290", VA = "0x180517890")]
			public CountedEvalModifier(EventManager.CountedEvalModifier.CountedEvalModifierDelegate evalOverrideWriter, EventManager.BuffType mappingBuffType, int remainingCount = 1)
			{
			}

			// Token: 0x17000530 RID: 1328
			// (get) Token: 0x0600248F RID: 9359 RVA: 0x0000D950 File Offset: 0x0000BB50
			[Token(Token = "0x17000530")]
			public EventManager.BuffType MappingBuffType
			{
				[Token(Token = "0x600248F")]
				[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
				[CompilerGenerated]
				get
				{
					return EventManager.BuffType.Null;
				}
			}

			// Token: 0x17000531 RID: 1329
			// (get) Token: 0x06002490 RID: 9360 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000531")]
			public EventManager.CountedEvalModifier.CountedEvalModifierDelegate EvalOverrideWriter
			{
				[Token(Token = "0x6002490")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000532 RID: 1330
			// (get) Token: 0x06002491 RID: 9361 RVA: 0x0000D968 File Offset: 0x0000BB68
			// (set) Token: 0x06002492 RID: 9362 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000532")]
			public int RemainingCount
			{
				[Token(Token = "0x6002491")]
				[Address(RVA = "0x3F8D30", Offset = "0x3F7730", VA = "0x1803F8D30")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6002492")]
				[Address(RVA = "0x3F8D90", Offset = "0x3F7790", VA = "0x1803F8D90")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x020005EE RID: 1518
			// (Invoke) Token: 0x06002494 RID: 9364
			[Token(Token = "0x20005EE")]
			public delegate bool CountedEvalModifierDelegate(GuestGroupController guestGroup, Sellable food, Sellable bev, GuestGroupController.EvaluationResult oldResult, out GuestGroupController.EvaluationResult overrideEval);
		}

		// Token: 0x020005EF RID: 1519
		[Token(Token = "0x20005EF")]
		public struct FoodOverrideModifier
		{
			// Token: 0x06002497 RID: 9367 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002497")]
			[Address(RVA = "0x517C40", Offset = "0x516640", VA = "0x180517C40")]
			public FoodOverrideModifier(int id, IEnumerable<int> tags, float rate)
			{
			}

			// Token: 0x17000533 RID: 1331
			// (get) Token: 0x06002498 RID: 9368 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002499 RID: 9369 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000533")]
			public IEnumerable<int> Tags
			{
				[Token(Token = "0x6002498")]
				[Address(RVA = "0x4070A0", Offset = "0x405AA0", VA = "0x1804070A0")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6002499")]
				[Address(RVA = "0x3EC190", Offset = "0x3EAB90", VA = "0x1803EC190")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000534 RID: 1332
			// (get) Token: 0x0600249A RID: 9370 RVA: 0x0000D980 File Offset: 0x0000BB80
			// (set) Token: 0x0600249B RID: 9371 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000534")]
			public float Rate
			{
				[Token(Token = "0x600249A")]
				[Address(RVA = "0x517C90", Offset = "0x516690", VA = "0x180517C90")]
				[CompilerGenerated]
				readonly get
				{
					return 0f;
				}
				[Token(Token = "0x600249B")]
				[Address(RVA = "0x517CB0", Offset = "0x5166B0", VA = "0x180517CB0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000535 RID: 1333
			// (get) Token: 0x0600249C RID: 9372 RVA: 0x0000D998 File Offset: 0x0000BB98
			// (set) Token: 0x0600249D RID: 9373 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000535")]
			public int FoodId
			{
				[Token(Token = "0x600249C")]
				[Address(RVA = "0x517C80", Offset = "0x516680", VA = "0x180517C80")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x600249D")]
				[Address(RVA = "0x517CA0", Offset = "0x5166A0", VA = "0x180517CA0")]
				[CompilerGenerated]
				set
				{
				}
			}
		}

		// Token: 0x020005F0 RID: 1520
		[Token(Token = "0x20005F0")]
		public struct OutputChecker
		{
			// Token: 0x17000536 RID: 1334
			// (get) Token: 0x0600249E RID: 9374 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600249F RID: 9375 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000536")]
			public Predicate<ValueTuple<Recipe, Sellable>> OutputCheckFunc
			{
				[Token(Token = "0x600249E")]
				[Address(RVA = "0x4070A0", Offset = "0x405AA0", VA = "0x1804070A0")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x600249F")]
				[Address(RVA = "0x3EC190", Offset = "0x3EAB90", VA = "0x1803EC190")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060024A0 RID: 9376 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60024A0")]
			[Address(RVA = "0x3EC190", Offset = "0x3EAB90", VA = "0x1803EC190")]
			public OutputChecker(Predicate<ValueTuple<Recipe, Sellable>> outputCheckFunc)
			{
			}
		}

		// Token: 0x020005F1 RID: 1521
		[Token(Token = "0x20005F1")]
		public struct ExtraPayModifier : IEquatable<EventManager.ExtraPayModifier>
		{
			// Token: 0x17000537 RID: 1335
			// (get) Token: 0x060024A1 RID: 9377 RVA: 0x0000D9B0 File Offset: 0x0000BBB0
			[Token(Token = "0x17000537")]
			public readonly EventManager.ExtraPayModifier.ModifierType SellableType
			{
				[Token(Token = "0x60024A1")]
				[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
				[CompilerGenerated]
				get
				{
					return EventManager.ExtraPayModifier.ModifierType.Food;
				}
			}

			// Token: 0x17000538 RID: 1336
			// (get) Token: 0x060024A2 RID: 9378 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000538")]
			public readonly Predicate<Sellable> CheckFoodExtraPay
			{
				[Token(Token = "0x60024A2")]
				[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000539 RID: 1337
			// (get) Token: 0x060024A3 RID: 9379 RVA: 0x0000D9C8 File Offset: 0x0000BBC8
			[Token(Token = "0x17000539")]
			public readonly float CriticalRate
			{
				[Token(Token = "0x60024A3")]
				[Address(RVA = "0x3FAD40", Offset = "0x3F9740", VA = "0x1803FAD40")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700053A RID: 1338
			// (get) Token: 0x060024A4 RID: 9380 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
			[Token(Token = "0x1700053A")]
			public readonly float ExtraCriticalDamage
			{
				[Token(Token = "0x60024A4")]
				[Address(RVA = "0x517C30", Offset = "0x516630", VA = "0x180517C30")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060024A5 RID: 9381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60024A5")]
			[Address(RVA = "0x517BF0", Offset = "0x5165F0", VA = "0x180517BF0")]
			public ExtraPayModifier(EventManager.ExtraPayModifier.ModifierType sellableType, Predicate<Sellable> checkFoodExtraPay, float criticalRate, float extraCriticalDamage)
			{
			}

			// Token: 0x060024A6 RID: 9382 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
			[Token(Token = "0x60024A6")]
			[Address(RVA = "0x517AD0", Offset = "0x5164D0", VA = "0x180517AD0", Slot = "4")]
			public bool Equals(EventManager.ExtraPayModifier other)
			{
				return default(bool);
			}

			// Token: 0x060024A7 RID: 9383 RVA: 0x0000DA10 File Offset: 0x0000BC10
			[Token(Token = "0x60024A7")]
			[Address(RVA = "0x5179D0", Offset = "0x5163D0", VA = "0x1805179D0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x060024A8 RID: 9384 RVA: 0x0000DA28 File Offset: 0x0000BC28
			[Token(Token = "0x60024A8")]
			[Address(RVA = "0x517B50", Offset = "0x516550", VA = "0x180517B50", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x020005F2 RID: 1522
			[Token(Token = "0x20005F2")]
			public enum ModifierType
			{
				// Token: 0x040020EC RID: 8428
				[Token(Token = "0x40020EC")]
				Food,
				// Token: 0x040020ED RID: 8429
				[Token(Token = "0x40020ED")]
				Bev,
				// Token: 0x040020EE RID: 8430
				[Token(Token = "0x40020EE")]
				All
			}
		}

		// Token: 0x020005F3 RID: 1523
		[Token(Token = "0x20005F3")]
		public enum ServeType
		{
			// Token: 0x040020F0 RID: 8432
			[Token(Token = "0x40020F0")]
			Player,
			// Token: 0x040020F1 RID: 8433
			[Token(Token = "0x40020F1")]
			Boss
		}

		// Token: 0x020005F4 RID: 1524
		[Token(Token = "0x20005F4")]
		public enum BuffRegisterType
		{
			// Token: 0x040020F3 RID: 8435
			[Token(Token = "0x40020F3")]
			Multiply,
			// Token: 0x040020F4 RID: 8436
			[Token(Token = "0x40020F4")]
			Overlay,
			// Token: 0x040020F5 RID: 8437
			[Token(Token = "0x40020F5")]
			Additive
		}

		// Token: 0x020005F5 RID: 1525
		[Token(Token = "0x20005F5")]
		public enum BuffTimeType
		{
			// Token: 0x040020F7 RID: 8439
			[Token(Token = "0x40020F7")]
			RewardCard,
			// Token: 0x040020F8 RID: 8440
			[Token(Token = "0x40020F8")]
			NegativeCard,
			// Token: 0x040020F9 RID: 8441
			[Token(Token = "0x40020F9")]
			OtherPositiveBuff
		}
	}
}
