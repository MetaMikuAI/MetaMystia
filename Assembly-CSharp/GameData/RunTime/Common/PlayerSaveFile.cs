using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Story;
using UnityEngine;

namespace GameData.RunTime.Common
{
	// Token: 0x0200080C RID: 2060
	[Token(Token = "0x200080C")]
	[Serializable]
	public struct PlayerSaveFile : IDeepClonable<PlayerSaveFile>
	{
		// Token: 0x060030BB RID: 12475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60030BB")]
		[Address(RVA = "0x60AFF0", Offset = "0x6099F0", VA = "0x18060AFF0")]
		public PlayerSaveFile(string fileVersion, DateTime saveTime, PlayerSaveFile.RunTimePlayerSaveDataPartial playerPartial, PlayerSaveFile.RunTimeStorageSaveDataPartial storagePartial, PlayerSaveFile.RunTimeAlbumSaveDataPartial albumPartial, PlayerSaveFile.RunTimeDaySceneSaveDataPartial dayScenePartial, PlayerSaveFile.RunTimeSchedulerSaveDataPartial schedulerPartial, Dictionary<string, PlayerSaveFile.RunTimeStorageSaveDataPartial> notLoadedRunTimeStorageSaveDataPartial, Dictionary<string, PlayerSaveFile.DLCAlbumSaveData> notLoadedDLCAlbumSaveData, Dictionary<string, PlayerSaveFile.DLCDaySceneSaveData> notLoadedDLCDaySceneSaveData, Dictionary<string, PlayerSaveFile.DLCSchedulerSaveData> notLoadedDLCSchedulerSaveData, bool bypassDLCMapping)
		{
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60030BC")]
		[Address(RVA = "0x60AC20", Offset = "0x609620", VA = "0x18060AC20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x00011C70 File Offset: 0x0000FE70
		[Token(Token = "0x60030BD")]
		[Address(RVA = "0x60A7D0", Offset = "0x6091D0", VA = "0x18060A7D0", Slot = "4")]
		public PlayerSaveFile Clone()
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x04002B61 RID: 11105
		[Token(Token = "0x4002B61")]
		public const string CORE_DATA_DLC_KEY = "CORE";

		// Token: 0x04002B62 RID: 11106
		[Token(Token = "0x4002B62")]
		public const string DLC1_DATA_DLC_KEY = "DLC1";

		// Token: 0x04002B63 RID: 11107
		[Token(Token = "0x4002B63")]
		public const string DLC2_DATA_DLC_KEY = "DLC2";

		// Token: 0x04002B64 RID: 11108
		[Token(Token = "0x4002B64")]
		public const string DLC3_DATA_DLC_KEY = "DLC3";

		// Token: 0x04002B65 RID: 11109
		[Token(Token = "0x4002B65")]
		public const string DLCMUSIC_DATA_DLC_KEY = "DLCMUSIC";

		// Token: 0x04002B66 RID: 11110
		[Token(Token = "0x4002B66")]
		public const string DLC4_DATA_DLC_KEY = "DLC4";

		// Token: 0x04002B67 RID: 11111
		[Token(Token = "0x4002B67")]
		public const string DLC5_DATA_DLC_KEY = "DLC5";

		// Token: 0x04002B68 RID: 11112
		[Token(Token = "0x4002B68")]
		public const string UNDEF_DATA_DLC_KEY = "UNDEFINED";

		// Token: 0x04002B69 RID: 11113
		[Token(Token = "0x4002B69")]
		public const string DEFAULT_KEY = "DEFAULT";

		// Token: 0x04002B6A RID: 11114
		[Token(Token = "0x4002B6A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly PlayerSaveFile.CustomDLCKeyComparer DLCKeyComparer;

		// Token: 0x04002B6B RID: 11115
		[Token(Token = "0x4002B6B")]
		[FieldOffset(Offset = "0x0")]
		public string fileVersion;

		// Token: 0x04002B6C RID: 11116
		[Token(Token = "0x4002B6C")]
		[FieldOffset(Offset = "0x8")]
		[JsonConverter(typeof(IsoDateTimeConverter))]
		public DateTime realSaveTimeCode;

		// Token: 0x04002B6D RID: 11117
		[Token(Token = "0x4002B6D")]
		[FieldOffset(Offset = "0x10")]
		public PlayerSaveFile.RunTimeStorageSaveDataPartial storagePartial;

		// Token: 0x04002B6E RID: 11118
		[Token(Token = "0x4002B6E")]
		[FieldOffset(Offset = "0x68")]
		public List<string> allActivatedDLC;

		// Token: 0x04002B6F RID: 11119
		[Token(Token = "0x4002B6F")]
		[FieldOffset(Offset = "0x70")]
		public Dictionary<string, PlayerSaveFile.RunTimeStorageSaveDataPartial> storagePartialDLC;

		// Token: 0x04002B70 RID: 11120
		[Token(Token = "0x4002B70")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, PlayerSaveFile.DLCAlbumSaveData> albumPartialDLC;

		// Token: 0x04002B71 RID: 11121
		[Token(Token = "0x4002B71")]
		[FieldOffset(Offset = "0x80")]
		public Dictionary<string, PlayerSaveFile.DLCDaySceneSaveData> dayScenePartialDLC;

		// Token: 0x04002B72 RID: 11122
		[Token(Token = "0x4002B72")]
		[FieldOffset(Offset = "0x88")]
		public Dictionary<string, PlayerSaveFile.DLCSchedulerSaveData> schedulerPartialDLC;

		// Token: 0x04002B73 RID: 11123
		[Token(Token = "0x4002B73")]
		[FieldOffset(Offset = "0x90")]
		public PlayerSaveFile.RunTimeAlbumSaveDataPartial albumPartial;

		// Token: 0x04002B74 RID: 11124
		[Token(Token = "0x4002B74")]
		[FieldOffset(Offset = "0x130")]
		public PlayerSaveFile.RunTimeDaySceneSaveDataPartial dayScenePartial;

		// Token: 0x04002B75 RID: 11125
		[Token(Token = "0x4002B75")]
		[FieldOffset(Offset = "0x188")]
		public PlayerSaveFile.RunTimePlayerSaveDataPartial playerPartial;

		// Token: 0x04002B76 RID: 11126
		[Token(Token = "0x4002B76")]
		[FieldOffset(Offset = "0x278")]
		public PlayerSaveFile.RunTimeSchedulerSaveDataPartial schedulerPartial;

		// Token: 0x0200080D RID: 2061
		[Token(Token = "0x200080D")]
		public enum DefaultProp
		{
			// Token: 0x04002B78 RID: 11128
			[Token(Token = "0x4002B78")]
			Ingredients_SeaFood,
			// Token: 0x04002B79 RID: 11129
			[Token(Token = "0x4002B79")]
			Recipes,
			// Token: 0x04002B7A RID: 11130
			[Token(Token = "0x4002B7A")]
			Beverages,
			// Token: 0x04002B7B RID: 11131
			[Token(Token = "0x4002B7B")]
			Cookers,
			// Token: 0x04002B7C RID: 11132
			[Token(Token = "0x4002B7C")]
			Ingredients_Meat,
			// Token: 0x04002B7D RID: 11133
			[Token(Token = "0x4002B7D")]
			Ingredients_Vegetable,
			// Token: 0x04002B7E RID: 11134
			[Token(Token = "0x4002B7E")]
			Ingredients_Other
		}

		// Token: 0x0200080E RID: 2062
		[Token(Token = "0x200080E")]
		public interface IExtractable<T>
		{
			// Token: 0x060030BF RID: 12479
			[Token(Token = "0x60030BF")]
			void ExtractValid(out T valid, out T invalid);
		}

		// Token: 0x0200080F RID: 2063
		[Token(Token = "0x200080F")]
		public class CustomDLCKeyComparer : IComparer<string>
		{
			// Token: 0x060030C0 RID: 12480 RVA: 0x00011C88 File Offset: 0x0000FE88
			[Token(Token = "0x60030C0")]
			[Address(RVA = "0x5FD210", Offset = "0x5FBC10", VA = "0x1805FD210", Slot = "4")]
			public int Compare(string x, string y)
			{
				return 0;
			}

			// Token: 0x060030C1 RID: 12481 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030C1")]
			[Address(RVA = "0x5FD290", Offset = "0x5FBC90", VA = "0x1805FD290")]
			public CustomDLCKeyComparer()
			{
			}

			// Token: 0x04002B7F RID: 11135
			[Token(Token = "0x4002B7F")]
			[FieldOffset(Offset = "0x10")]
			private readonly string[] m_OrdererdDLCKey;
		}

		// Token: 0x02000810 RID: 2064
		[Token(Token = "0x2000810")]
		public struct DLCAlbumSaveData : IDeepClonable<PlayerSaveFile.DLCAlbumSaveData>, PlayerSaveFile.IExtractable<PlayerSaveFile.DLCAlbumSaveData>
		{
			// Token: 0x060030C2 RID: 12482 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030C2")]
			[Address(RVA = "0x5FE160", Offset = "0x5FCB60", VA = "0x1805FE160")]
			public DLCAlbumSaveData(List<int> nGuests, List<int> foods, List<int> bevs, List<int> ings, List<int> cookers, List<int> items, List<int> badges, Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> specialSkinSelection, List<int> usedDecorations, int playerSkinSelection)
			{
			}

			// Token: 0x060030C3 RID: 12483 RVA: 0x00011CA0 File Offset: 0x0000FEA0
			[Token(Token = "0x60030C3")]
			[Address(RVA = "0x5FDD70", Offset = "0x5FC770", VA = "0x1805FDD70")]
			public static PlayerSaveFile.DLCAlbumSaveData Merge(PlayerSaveFile.DLCAlbumSaveData current, PlayerSaveFile.DLCAlbumSaveData next)
			{
				return default(PlayerSaveFile.DLCAlbumSaveData);
			}

			// Token: 0x060030C4 RID: 12484 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030C4")]
			[Address(RVA = "0x5FD720", Offset = "0x5FC120", VA = "0x1805FD720")]
			private static void EnusreFieldNotNull(ref PlayerSaveFile.DLCAlbumSaveData data)
			{
			}

			// Token: 0x060030C5 RID: 12485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030C5")]
			[Address(RVA = "0x5FD7F0", Offset = "0x5FC1F0", VA = "0x1805FD7F0", Slot = "5")]
			public void ExtractValid(out PlayerSaveFile.DLCAlbumSaveData valid, out PlayerSaveFile.DLCAlbumSaveData invalid)
			{
			}

			// Token: 0x060030C6 RID: 12486 RVA: 0x00011CB8 File Offset: 0x0000FEB8
			[Token(Token = "0x60030C6")]
			[Address(RVA = "0x5FD670", Offset = "0x5FC070", VA = "0x1805FD670", Slot = "4")]
			public PlayerSaveFile.DLCAlbumSaveData Clone()
			{
				return default(PlayerSaveFile.DLCAlbumSaveData);
			}

			// Token: 0x04002B80 RID: 11136
			[Token(Token = "0x4002B80")]
			[FieldOffset(Offset = "0x0")]
			public List<int> nGuests;

			// Token: 0x04002B81 RID: 11137
			[Token(Token = "0x4002B81")]
			[FieldOffset(Offset = "0x8")]
			public List<int> foods;

			// Token: 0x04002B82 RID: 11138
			[Token(Token = "0x4002B82")]
			[FieldOffset(Offset = "0x10")]
			public List<int> bevs;

			// Token: 0x04002B83 RID: 11139
			[Token(Token = "0x4002B83")]
			[FieldOffset(Offset = "0x18")]
			public List<int> ings;

			// Token: 0x04002B84 RID: 11140
			[Token(Token = "0x4002B84")]
			[FieldOffset(Offset = "0x20")]
			public List<int> cookers;

			// Token: 0x04002B85 RID: 11141
			[Token(Token = "0x4002B85")]
			[FieldOffset(Offset = "0x28")]
			public List<int> items;

			// Token: 0x04002B86 RID: 11142
			[Token(Token = "0x4002B86")]
			[FieldOffset(Offset = "0x30")]
			public List<int> badges;

			// Token: 0x04002B87 RID: 11143
			[Token(Token = "0x4002B87")]
			[FieldOffset(Offset = "0x38")]
			public Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> specialSkinSelection;

			// Token: 0x04002B88 RID: 11144
			[Token(Token = "0x4002B88")]
			[FieldOffset(Offset = "0x40")]
			public List<int> usedDecorations;

			// Token: 0x04002B89 RID: 11145
			[Token(Token = "0x4002B89")]
			[FieldOffset(Offset = "0x48")]
			public int playerSkinSelection;
		}

		// Token: 0x02000812 RID: 2066
		[Token(Token = "0x2000812")]
		public struct DLCDaySceneSaveData : IDeepClonable<PlayerSaveFile.DLCDaySceneSaveData>, PlayerSaveFile.IExtractable<PlayerSaveFile.DLCDaySceneSaveData>
		{
			// Token: 0x060030CA RID: 12490 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030CA")]
			[Address(RVA = "0x5FF240", Offset = "0x5FDC40", VA = "0x1805FF240")]
			public DLCDaySceneSaveData(TrackedCollectable[] alltrackedCollectables, TrackedMerchant[] alltrackedMerchants, Dictionary<string, Dictionary<string, TrackedNPC>> allTrackedNPCs, Dictionary<string, bool> daySceneMapStatusData, ValueTuple<string, int>[] kourindouStaticMerchandiseNum, Dictionary<int, ValueTuple<int, List<Vector2Int>>> flandreHomeFurnitureData)
			{
			}

			// Token: 0x060030CB RID: 12491 RVA: 0x00011CD0 File Offset: 0x0000FED0
			[Token(Token = "0x60030CB")]
			[Address(RVA = "0x5FEE80", Offset = "0x5FD880", VA = "0x1805FEE80")]
			public static PlayerSaveFile.DLCDaySceneSaveData Merge(PlayerSaveFile.DLCDaySceneSaveData current, PlayerSaveFile.DLCDaySceneSaveData next)
			{
				return default(PlayerSaveFile.DLCDaySceneSaveData);
			}

			// Token: 0x060030CC RID: 12492 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030CC")]
			[Address(RVA = "0x5FE360", Offset = "0x5FCD60", VA = "0x1805FE360")]
			private static void EnsureFieldNotNull(ref PlayerSaveFile.DLCDaySceneSaveData data)
			{
			}

			// Token: 0x060030CD RID: 12493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030CD")]
			[Address(RVA = "0x5FE410", Offset = "0x5FCE10", VA = "0x1805FE410", Slot = "5")]
			public void ExtractValid(out PlayerSaveFile.DLCDaySceneSaveData valid, out PlayerSaveFile.DLCDaySceneSaveData invalid)
			{
			}

			// Token: 0x060030CE RID: 12494 RVA: 0x00011CE8 File Offset: 0x0000FEE8
			[Token(Token = "0x60030CE")]
			[Address(RVA = "0x5FE300", Offset = "0x5FCD00", VA = "0x1805FE300", Slot = "4")]
			public PlayerSaveFile.DLCDaySceneSaveData Clone()
			{
				return default(PlayerSaveFile.DLCDaySceneSaveData);
			}

			// Token: 0x04002B8C RID: 11148
			[Token(Token = "0x4002B8C")]
			[FieldOffset(Offset = "0x0")]
			public TrackedCollectable[] alltrackedCollectables;

			// Token: 0x04002B8D RID: 11149
			[Token(Token = "0x4002B8D")]
			[FieldOffset(Offset = "0x8")]
			public TrackedMerchant[] alltrackedMerchants;

			// Token: 0x04002B8E RID: 11150
			[Token(Token = "0x4002B8E")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, Dictionary<string, TrackedNPC>> allTrackedNPCs;

			// Token: 0x04002B8F RID: 11151
			[Token(Token = "0x4002B8F")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, bool> daySceneMapStatusData;

			// Token: 0x04002B90 RID: 11152
			[Token(Token = "0x4002B90")]
			[FieldOffset(Offset = "0x20")]
			public ValueTuple<string, int>[] kourindouStaticMerchandiseNum;

			// Token: 0x04002B91 RID: 11153
			[Token(Token = "0x4002B91")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<int, ValueTuple<int, List<Vector2Int>>> flandreHomeFurnitureData;
		}

		// Token: 0x02000814 RID: 2068
		[Token(Token = "0x2000814")]
		public struct DLCSchedulerSaveData : IDeepClonable<PlayerSaveFile.DLCSchedulerSaveData>
		{
			// Token: 0x060030D6 RID: 12502 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030D6")]
			[Address(RVA = "0x5FF400", Offset = "0x5FDE00", VA = "0x1805FF400")]
			public DLCSchedulerSaveData(int dlcSaveDate, Dictionary<int, List<string>> scheduledEvents, Dictionary<int, List<string>> scheduledNews, Dictionary<int, List<KeyValuePair<string, RunTimeScheduler.HistoryNewsData.ReplaceContent[]>>> scheduledNewsReplaceContents, Dictionary<int, List<RunTimeScheduler.TrackedMissionData>> allTrackingMissions, string[] finishedEvents, string[] finishedMissions)
			{
			}

			// Token: 0x060030D7 RID: 12503 RVA: 0x00011D60 File Offset: 0x0000FF60
			[Token(Token = "0x60030D7")]
			[Address(RVA = "0x5FF380", Offset = "0x5FDD80", VA = "0x1805FF380", Slot = "4")]
			public PlayerSaveFile.DLCSchedulerSaveData Clone()
			{
				return default(PlayerSaveFile.DLCSchedulerSaveData);
			}

			// Token: 0x04002B98 RID: 11160
			[Token(Token = "0x4002B98")]
			[FieldOffset(Offset = "0x0")]
			public int dlcSaveDate;

			// Token: 0x04002B99 RID: 11161
			[Token(Token = "0x4002B99")]
			[FieldOffset(Offset = "0x8")]
			public Dictionary<int, List<string>> scheduledEvents;

			// Token: 0x04002B9A RID: 11162
			[Token(Token = "0x4002B9A")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<int, List<string>> scheduledNews;

			// Token: 0x04002B9B RID: 11163
			[Token(Token = "0x4002B9B")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<int, List<KeyValuePair<string, RunTimeScheduler.HistoryNewsData.ReplaceContent[]>>> scheduledNewsReplaceContents;

			// Token: 0x04002B9C RID: 11164
			[Token(Token = "0x4002B9C")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<int, List<RunTimeScheduler.TrackedMissionData>> allTrackingMissions;

			// Token: 0x04002B9D RID: 11165
			[Token(Token = "0x4002B9D")]
			[FieldOffset(Offset = "0x28")]
			public string[] finishedEvents;

			// Token: 0x04002B9E RID: 11166
			[Token(Token = "0x4002B9E")]
			[FieldOffset(Offset = "0x30")]
			public string[] finishedMissions;
		}

		// Token: 0x02000815 RID: 2069
		[Token(Token = "0x2000815")]
		public struct HistoryIzakayaMenuSelection : IDeepClonable<PlayerSaveFile.HistoryIzakayaMenuSelection>
		{
			// Token: 0x060030D8 RID: 12504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030D8")]
			[Address(RVA = "0x604F30", Offset = "0x603930", VA = "0x180604F30")]
			public HistoryIzakayaMenuSelection(List<int> recipeList, List<int> beverageList, List<int> cookerList)
			{
			}

			// Token: 0x060030D9 RID: 12505 RVA: 0x00011D78 File Offset: 0x0000FF78
			[Token(Token = "0x60030D9")]
			[Address(RVA = "0x604EF0", Offset = "0x6038F0", VA = "0x180604EF0", Slot = "4")]
			public PlayerSaveFile.HistoryIzakayaMenuSelection Clone()
			{
				return default(PlayerSaveFile.HistoryIzakayaMenuSelection);
			}

			// Token: 0x04002B9F RID: 11167
			[Token(Token = "0x4002B9F")]
			[FieldOffset(Offset = "0x0")]
			public List<int> recipeList;

			// Token: 0x04002BA0 RID: 11168
			[Token(Token = "0x4002BA0")]
			[FieldOffset(Offset = "0x8")]
			public List<int> beverageList;

			// Token: 0x04002BA1 RID: 11169
			[Token(Token = "0x4002BA1")]
			[FieldOffset(Offset = "0x10")]
			public List<int> cookerList;
		}

		// Token: 0x02000816 RID: 2070
		[Token(Token = "0x2000816")]
		public struct RunTimeAlbumSaveDataPartial : IDeepClonable<PlayerSaveFile.RunTimeAlbumSaveDataPartial>
		{
			// Token: 0x060030DA RID: 12506 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030DA")]
			[Address(RVA = "0x60D600", Offset = "0x60C000", VA = "0x18060D600")]
			public RunTimeAlbumSaveDataPartial(List<int> nGuests, List<int> foods, List<int> bevs, List<int> ings, List<int> cookers, List<int> items, List<int> badges, int playerSkinSelectionData, int nightBGM, int nightBGMIndex, Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> specialSkinSelection, List<string> historyCollectables, List<int> usedDecorations, bool useCurrentSkinAtNight, bool useSpecialShopSkinAtNight, Dictionary<int, int> ingCollectCount, Dictionary<int, int> unsatisfiedTagCount, int evictGuestsCount, Dictionary<int, int> cookingCount, int strongBuyAndSellCount, int rewardSpellTriggerCount, int punishmentSpellTriggerCount, List<int> effectiveSGuestsMappingRules)
			{
			}

			// Token: 0x060030DB RID: 12507 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030DB")]
			[Address(RVA = "0x60D940", Offset = "0x60C340", VA = "0x18060D940")]
			public RunTimeAlbumSaveDataPartial(PlayerSaveFile.DLCAlbumSaveData defaultDLCSaveData, List<string> historyCollectables, bool useCurrentSkinAtNight, bool useSpecialShopSkinAtNight, Dictionary<int, int> ingCollectCount, Dictionary<int, int> unsatisfiedTagCount, int evictGuestsCount, Dictionary<int, int> cookingCount, int strongBuyAndSellCount, int rewardSpellTriggerCount, int punishmentSpellTriggerCount, int nightBGM, int nightBGMIndex, List<int> effectiveSGuestsMappingRules)
			{
			}

			// Token: 0x060030DC RID: 12508 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030DC")]
			[Address(RVA = "0x60BC10", Offset = "0x60A610", VA = "0x18060BC10")]
			public static void Classify(in PlayerSaveFile.RunTimeAlbumSaveDataPartial albumPartial, ref PlayerSaveFile.RunTimeAlbumSaveDataPartial albumPartialSaveData, ref Dictionary<string, PlayerSaveFile.DLCAlbumSaveData> albumPartialDLCSaveData)
			{
			}

			// Token: 0x060030DD RID: 12509 RVA: 0x00011D90 File Offset: 0x0000FF90
			[Token(Token = "0x60030DD")]
			[Address(RVA = "0x60D3D0", Offset = "0x60BDD0", VA = "0x18060D3D0", Slot = "4")]
			public PlayerSaveFile.RunTimeAlbumSaveDataPartial Clone()
			{
				return default(PlayerSaveFile.RunTimeAlbumSaveDataPartial);
			}

			// Token: 0x04002BA2 RID: 11170
			[Token(Token = "0x4002BA2")]
			[FieldOffset(Offset = "0x0")]
			public List<int> nGuests;

			// Token: 0x04002BA3 RID: 11171
			[Token(Token = "0x4002BA3")]
			[FieldOffset(Offset = "0x8")]
			public List<int> foods;

			// Token: 0x04002BA4 RID: 11172
			[Token(Token = "0x4002BA4")]
			[FieldOffset(Offset = "0x10")]
			public List<int> bevs;

			// Token: 0x04002BA5 RID: 11173
			[Token(Token = "0x4002BA5")]
			[FieldOffset(Offset = "0x18")]
			public List<int> ings;

			// Token: 0x04002BA6 RID: 11174
			[Token(Token = "0x4002BA6")]
			[FieldOffset(Offset = "0x20")]
			public List<int> cookers;

			// Token: 0x04002BA7 RID: 11175
			[Token(Token = "0x4002BA7")]
			[FieldOffset(Offset = "0x28")]
			public List<int> items;

			// Token: 0x04002BA8 RID: 11176
			[Token(Token = "0x4002BA8")]
			[FieldOffset(Offset = "0x30")]
			public List<int> badges;

			// Token: 0x04002BA9 RID: 11177
			[Token(Token = "0x4002BA9")]
			[FieldOffset(Offset = "0x38")]
			public int playerSkinSelectionData;

			// Token: 0x04002BAA RID: 11178
			[Token(Token = "0x4002BAA")]
			[FieldOffset(Offset = "0x3C")]
			public int nightBGM;

			// Token: 0x04002BAB RID: 11179
			[Token(Token = "0x4002BAB")]
			[FieldOffset(Offset = "0x40")]
			public int nightBGMIndex;

			// Token: 0x04002BAC RID: 11180
			[Token(Token = "0x4002BAC")]
			[FieldOffset(Offset = "0x48")]
			public Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> specialSkinSelection;

			// Token: 0x04002BAD RID: 11181
			[Token(Token = "0x4002BAD")]
			[FieldOffset(Offset = "0x50")]
			public List<string> historyCollectables;

			// Token: 0x04002BAE RID: 11182
			[Token(Token = "0x4002BAE")]
			[FieldOffset(Offset = "0x58")]
			public List<int> usedDecorations;

			// Token: 0x04002BAF RID: 11183
			[Token(Token = "0x4002BAF")]
			[FieldOffset(Offset = "0x60")]
			public bool useCurrentSkinAtNight;

			// Token: 0x04002BB0 RID: 11184
			[Token(Token = "0x4002BB0")]
			[FieldOffset(Offset = "0x61")]
			public bool useSpecialShopSkinAtNight;

			// Token: 0x04002BB1 RID: 11185
			[Token(Token = "0x4002BB1")]
			[FieldOffset(Offset = "0x68")]
			public Dictionary<int, int> ingCollectCount;

			// Token: 0x04002BB2 RID: 11186
			[Token(Token = "0x4002BB2")]
			[FieldOffset(Offset = "0x70")]
			public Dictionary<int, int> unsatisfiedTagCount;

			// Token: 0x04002BB3 RID: 11187
			[Token(Token = "0x4002BB3")]
			[FieldOffset(Offset = "0x78")]
			public int evictGuestsCount;

			// Token: 0x04002BB4 RID: 11188
			[Token(Token = "0x4002BB4")]
			[FieldOffset(Offset = "0x80")]
			public Dictionary<int, int> cookingCount;

			// Token: 0x04002BB5 RID: 11189
			[Token(Token = "0x4002BB5")]
			[FieldOffset(Offset = "0x88")]
			public int strongBuyAndSellCount;

			// Token: 0x04002BB6 RID: 11190
			[Token(Token = "0x4002BB6")]
			[FieldOffset(Offset = "0x8C")]
			public int rewardSpellTriggerCount;

			// Token: 0x04002BB7 RID: 11191
			[Token(Token = "0x4002BB7")]
			[FieldOffset(Offset = "0x90")]
			public int punishmentSpellTriggerCount;

			// Token: 0x04002BB8 RID: 11192
			[Token(Token = "0x4002BB8")]
			[FieldOffset(Offset = "0x98")]
			public List<int> effectiveSGuestsMappingRules;
		}

		// Token: 0x02000818 RID: 2072
		[Token(Token = "0x2000818")]
		public struct RunTimeDaySceneSaveDataPartial : IDeepClonable<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>
		{
			// Token: 0x060030EA RID: 12522 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030EA")]
			[Address(RVA = "0x60F370", Offset = "0x60DD70", VA = "0x18060F370")]
			public RunTimeDaySceneSaveDataPartial(TrackedCollectable[] alltrackedCollectables, TrackedMerchant[] alltrackedMerchants, Dictionary<string, Dictionary<string, TrackedNPC>> allTrackedNPCs, Dictionary<string, bool> daySceneMapStatusData, TrackedInteractable[] trackedInteractables, Dictionary<string, bool> trackedSwitch, ValueTuple<string, int>[] kourindouStaticMerchandiseNum, Dictionary<string, int> trackedCount, [TupleElementNames(new string[] { "EasySpeed", "HardSpeed" })] Dictionary<string, ValueTuple<float, float>> musicgameMusicalsNoteSpeed, Dictionary<int, ValueTuple<int, List<Vector2Int>>> flandreHomeFurnitureData)
			{
			}

			// Token: 0x060030EB RID: 12523 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030EB")]
			[Address(RVA = "0x60F280", Offset = "0x60DC80", VA = "0x18060F280")]
			public RunTimeDaySceneSaveDataPartial(PlayerSaveFile.DLCDaySceneSaveData defaultDLCDaySaveData, TrackedInteractable[] trackedInteractables, Dictionary<string, bool> trackedSwitch, Dictionary<string, int> trackedCount, [TupleElementNames(new string[] { "EasySpeed", "HardSpeed" })] Dictionary<string, ValueTuple<float, float>> musicgameMusicalsNoteSpeed)
			{
			}

			// Token: 0x060030EC RID: 12524 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030EC")]
			[Address(RVA = "0x60DAD0", Offset = "0x60C4D0", VA = "0x18060DAD0")]
			public static void Classify(in PlayerSaveFile.RunTimeDaySceneSaveDataPartial dayScenePartial, ref PlayerSaveFile.RunTimeDaySceneSaveDataPartial dayScenePartialSaveData, ref Dictionary<string, PlayerSaveFile.DLCDaySceneSaveData> dayScenePartialDLCSaveData)
			{
			}

			// Token: 0x060030ED RID: 12525 RVA: 0x00011DC0 File Offset: 0x0000FFC0
			[Token(Token = "0x60030ED")]
			[Address(RVA = "0x60F1C0", Offset = "0x60DBC0", VA = "0x18060F1C0", Slot = "4")]
			public PlayerSaveFile.RunTimeDaySceneSaveDataPartial Clone()
			{
				return default(PlayerSaveFile.RunTimeDaySceneSaveDataPartial);
			}

			// Token: 0x04002BC4 RID: 11204
			[Token(Token = "0x4002BC4")]
			[FieldOffset(Offset = "0x0")]
			public TrackedCollectable[] alltrackedCollectables;

			// Token: 0x04002BC5 RID: 11205
			[Token(Token = "0x4002BC5")]
			[FieldOffset(Offset = "0x8")]
			public TrackedMerchant[] alltrackedMerchants;

			// Token: 0x04002BC6 RID: 11206
			[Token(Token = "0x4002BC6")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<string, Dictionary<string, TrackedNPC>> allTrackedNPCs;

			// Token: 0x04002BC7 RID: 11207
			[Token(Token = "0x4002BC7")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, bool> daySceneMapStatusData;

			// Token: 0x04002BC8 RID: 11208
			[Token(Token = "0x4002BC8")]
			[FieldOffset(Offset = "0x20")]
			public TrackedInteractable[] trackedInteradctables;

			// Token: 0x04002BC9 RID: 11209
			[Token(Token = "0x4002BC9")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<string, bool> trackedSwitch;

			// Token: 0x04002BCA RID: 11210
			[Token(Token = "0x4002BCA")]
			[FieldOffset(Offset = "0x30")]
			public string[] kourindoStaticMerchandise;

			// Token: 0x04002BCB RID: 11211
			[Token(Token = "0x4002BCB")]
			[FieldOffset(Offset = "0x38")]
			public ValueTuple<string, int>[] kourindouStaticMerchandiseNum;

			// Token: 0x04002BCC RID: 11212
			[Token(Token = "0x4002BCC")]
			[FieldOffset(Offset = "0x40")]
			public Dictionary<string, int> trackedCount;

			// Token: 0x04002BCD RID: 11213
			[Token(Token = "0x4002BCD")]
			[FieldOffset(Offset = "0x48")]
			[TupleElementNames(new string[] { "EasySpeed", "HardSpeed" })]
			public Dictionary<string, ValueTuple<float, float>> musicgameMusicalsNoteSpeed;

			// Token: 0x04002BCE RID: 11214
			[Token(Token = "0x4002BCE")]
			[FieldOffset(Offset = "0x50")]
			public Dictionary<int, ValueTuple<int, List<Vector2Int>>> flandreHomeFurnitureData;
		}

		// Token: 0x0200081A RID: 2074
		[Token(Token = "0x200081A")]
		public struct RunTimePlayerSaveDataPartial : IDeepClonable<PlayerSaveFile.RunTimePlayerSaveDataPartial>
		{
			// Token: 0x060030F7 RID: 12535 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60030F7")]
			[Address(RVA = "0x616810", Offset = "0x615210", VA = "0x180616810", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x060030F8 RID: 12536 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030F8")]
			[Address(RVA = "0x6168F0", Offset = "0x6152F0", VA = "0x1806168F0")]
			public RunTimePlayerSaveDataPartial(GameDate gameDate, long fund, int exp, int level, bool canPerform, bool canOpenNoteAndStorage, bool shouldSpawnSpecialGuests, bool shouldShowSpecialGuestsInDay, bool shouldHaveLevel5KizunaEvent, bool shouldSpawnTewi, int currentLevelCap, int bufferedExp, bool enableMultiPartner, int maxPartnerCount, ValueTuple<int, PartnerBase.PartnerType>[] historyPartnerSelection, List<int> popLikeFoodTags, List<int> popLikeBevTags, List<int> popHateFoodTags, List<int> popHateBevTags, bool rewindMode, Dictionary<string, bool> collabStatus, Dictionary<string, int> prdTryTimeRecord, long hakureiMoneyBoxDonateNum, Dictionary<PlayerSaveFile.DefaultProp, List<int>> defaultPropSelection, Dictionary<int, List<PlayerSaveFile.HistoryIzakayaMenuSelection>> userIzakayaPresets, List<string> haveChattedSGuestLabel, Dictionary<string, List<string>> musicChapterStatus, List<int> lockedRecipeList, string lockingEventName, List<string> lockedEvents, List<string> tryToUnLockEvents, List<ControlledSpecialGuest> controlledSpecialGuests, bool useCreatorBoxData, CreatorBoxData? selectedCreatorBoxData, CreatorBoxData?[] selectedCreatorBoxDataPresets, List<int?> infiniteIngredients, HashSet<string> dlcLock)
			{
			}

			// Token: 0x060030F9 RID: 12537 RVA: 0x00011DF0 File Offset: 0x0000FFF0
			[Token(Token = "0x60030F9")]
			[Address(RVA = "0x616440", Offset = "0x614E40", VA = "0x180616440", Slot = "4")]
			public PlayerSaveFile.RunTimePlayerSaveDataPartial Clone()
			{
				return default(PlayerSaveFile.RunTimePlayerSaveDataPartial);
			}

			// Token: 0x04002BD7 RID: 11223
			[Token(Token = "0x4002BD7")]
			[FieldOffset(Offset = "0x0")]
			public GameDate gameDate;

			// Token: 0x04002BD8 RID: 11224
			[Token(Token = "0x4002BD8")]
			[FieldOffset(Offset = "0x8")]
			public long fund;

			// Token: 0x04002BD9 RID: 11225
			[Token(Token = "0x4002BD9")]
			[FieldOffset(Offset = "0x10")]
			public int exp;

			// Token: 0x04002BDA RID: 11226
			[Token(Token = "0x4002BDA")]
			[FieldOffset(Offset = "0x14")]
			public int level;

			// Token: 0x04002BDB RID: 11227
			[Token(Token = "0x4002BDB")]
			[FieldOffset(Offset = "0x18")]
			public bool canPerform;

			// Token: 0x04002BDC RID: 11228
			[Token(Token = "0x4002BDC")]
			[FieldOffset(Offset = "0x19")]
			public bool canOpenNoteStorageEscape;

			// Token: 0x04002BDD RID: 11229
			[Token(Token = "0x4002BDD")]
			[FieldOffset(Offset = "0x1A")]
			public bool shouldSpawnSpecialGuests;

			// Token: 0x04002BDE RID: 11230
			[Token(Token = "0x4002BDE")]
			[FieldOffset(Offset = "0x1B")]
			public bool shouldShowSpecialGuestsInDay;

			// Token: 0x04002BDF RID: 11231
			[Token(Token = "0x4002BDF")]
			[FieldOffset(Offset = "0x1C")]
			public bool shouldHaveLevel5KizunaEvent;

			// Token: 0x04002BE0 RID: 11232
			[Token(Token = "0x4002BE0")]
			[FieldOffset(Offset = "0x1D")]
			public bool shouldSpawnTewi;

			// Token: 0x04002BE1 RID: 11233
			[Token(Token = "0x4002BE1")]
			[FieldOffset(Offset = "0x20")]
			public int currentLevelCap;

			// Token: 0x04002BE2 RID: 11234
			[Token(Token = "0x4002BE2")]
			[FieldOffset(Offset = "0x24")]
			public int bufferedExp;

			// Token: 0x04002BE3 RID: 11235
			[Token(Token = "0x4002BE3")]
			[FieldOffset(Offset = "0x28")]
			public bool enableMultiPartner;

			// Token: 0x04002BE4 RID: 11236
			[Token(Token = "0x4002BE4")]
			[FieldOffset(Offset = "0x2C")]
			public int maxPartnerCount;

			// Token: 0x04002BE5 RID: 11237
			[Token(Token = "0x4002BE5")]
			[FieldOffset(Offset = "0x30")]
			public ValueTuple<int, PartnerBase.PartnerType>[] historyPartnerSelection;

			// Token: 0x04002BE6 RID: 11238
			[Token(Token = "0x4002BE6")]
			[FieldOffset(Offset = "0x38")]
			public Dictionary<int, List<PlayerSaveFile.HistoryIzakayaMenuSelection>> userIzakayaPresets;

			// Token: 0x04002BE7 RID: 11239
			[Token(Token = "0x4002BE7")]
			[FieldOffset(Offset = "0x40")]
			public Dictionary<string, bool> collabStatus;

			// Token: 0x04002BE8 RID: 11240
			[Token(Token = "0x4002BE8")]
			[FieldOffset(Offset = "0x48")]
			public List<int> popLikeFoodTags;

			// Token: 0x04002BE9 RID: 11241
			[Token(Token = "0x4002BE9")]
			[FieldOffset(Offset = "0x50")]
			public List<int> popLikeBevTags;

			// Token: 0x04002BEA RID: 11242
			[Token(Token = "0x4002BEA")]
			[FieldOffset(Offset = "0x58")]
			public List<int> popHateFoodTags;

			// Token: 0x04002BEB RID: 11243
			[Token(Token = "0x4002BEB")]
			[FieldOffset(Offset = "0x60")]
			public List<int> popHateBevTags;

			// Token: 0x04002BEC RID: 11244
			[Token(Token = "0x4002BEC")]
			[FieldOffset(Offset = "0x68")]
			public bool rewindMode;

			// Token: 0x04002BED RID: 11245
			[Token(Token = "0x4002BED")]
			[FieldOffset(Offset = "0x70")]
			public Dictionary<string, int> prdTryTimeRecord;

			// Token: 0x04002BEE RID: 11246
			[Token(Token = "0x4002BEE")]
			[FieldOffset(Offset = "0x78")]
			public long hakureiMoneyBoxDonateNum;

			// Token: 0x04002BEF RID: 11247
			[Token(Token = "0x4002BEF")]
			[FieldOffset(Offset = "0x80")]
			public Dictionary<PlayerSaveFile.DefaultProp, List<int>> defaultPropSelection;

			// Token: 0x04002BF0 RID: 11248
			[Token(Token = "0x4002BF0")]
			[FieldOffset(Offset = "0x88")]
			public Dictionary<string, List<string>> musicChapterStatus;

			// Token: 0x04002BF1 RID: 11249
			[Token(Token = "0x4002BF1")]
			[FieldOffset(Offset = "0x90")]
			public List<string> haveChattedSGuestLabel;

			// Token: 0x04002BF2 RID: 11250
			[Token(Token = "0x4002BF2")]
			[FieldOffset(Offset = "0x98")]
			public List<int> lockedRecipeList;

			// Token: 0x04002BF3 RID: 11251
			[Token(Token = "0x4002BF3")]
			[FieldOffset(Offset = "0xA0")]
			public string lockingEventName;

			// Token: 0x04002BF4 RID: 11252
			[Token(Token = "0x4002BF4")]
			[FieldOffset(Offset = "0xA8")]
			public List<string> lockedEvents;

			// Token: 0x04002BF5 RID: 11253
			[Token(Token = "0x4002BF5")]
			[FieldOffset(Offset = "0xB0")]
			public List<string> tryToUnLockEvents;

			// Token: 0x04002BF6 RID: 11254
			[Token(Token = "0x4002BF6")]
			[FieldOffset(Offset = "0xB8")]
			public List<ControlledSpecialGuest> controlledSpecialGuests;

			// Token: 0x04002BF7 RID: 11255
			[Token(Token = "0x4002BF7")]
			[FieldOffset(Offset = "0xC0")]
			public bool useCreatorBoxData;

			// Token: 0x04002BF8 RID: 11256
			[Token(Token = "0x4002BF8")]
			[FieldOffset(Offset = "0xC8")]
			public CreatorBoxData? selectedCreatorBoxData;

			// Token: 0x04002BF9 RID: 11257
			[Token(Token = "0x4002BF9")]
			[FieldOffset(Offset = "0xD8")]
			public CreatorBoxData?[] selectedCreatorBoxDataPresets;

			// Token: 0x04002BFA RID: 11258
			[Token(Token = "0x4002BFA")]
			[FieldOffset(Offset = "0xE0")]
			public List<int?> infiniteIngredients;

			// Token: 0x04002BFB RID: 11259
			[Token(Token = "0x4002BFB")]
			[FieldOffset(Offset = "0xE8")]
			public HashSet<string> dlcLock;
		}

		// Token: 0x0200081B RID: 2075
		[Token(Token = "0x200081B")]
		public struct RunTimeSchedulerSaveDataPartial : IDeepClonable<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>
		{
			// Token: 0x060030FA RID: 12538 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030FA")]
			[Address(RVA = "0x63A8C0", Offset = "0x6392C0", VA = "0x18063A8C0")]
			public RunTimeSchedulerSaveDataPartial(string lastMission, Dictionary<int, List<string>> scheduledEvents, Dictionary<int, List<string>> scheduledNews, Dictionary<int, List<KeyValuePair<string, RunTimeScheduler.HistoryNewsData.ReplaceContent[]>>> scheduledNewsReplaceContents, Dictionary<int, List<RunTimeScheduler.TrackedMissionData>> allTrackingMissions, string[] finishedEvents, string[] finishedMissions, List<KeyValuePair<KeyValuePair<SchedulerNode.Reward.ObjectType, int>, float>> registeredObjectPriceModifierMem, RunTimeScheduler.HistoryNewsData[] newsDataArray)
			{
			}

			// Token: 0x060030FB RID: 12539 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030FB")]
			[Address(RVA = "0x63AA90", Offset = "0x639490", VA = "0x18063AA90")]
			public RunTimeSchedulerSaveDataPartial(PlayerSaveFile.DLCSchedulerSaveData defaultDLCSchedulerSaveData, string lastMission, List<KeyValuePair<KeyValuePair<SchedulerNode.Reward.ObjectType, int>, float>> registeredObjectPriceModifierMem, RunTimeScheduler.HistoryNewsData[] newsDataArray)
			{
			}

			// Token: 0x060030FC RID: 12540 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60030FC")]
			[Address(RVA = "0x639800", Offset = "0x638200", VA = "0x180639800")]
			public static void Classify(in PlayerSaveFile.RunTimePlayerSaveDataPartial playerPartial, in PlayerSaveFile.RunTimeSchedulerSaveDataPartial schedulerPartial, ref PlayerSaveFile.RunTimeSchedulerSaveDataPartial schedulerPartialSaveData, ref Dictionary<string, PlayerSaveFile.DLCSchedulerSaveData> schedulerPartialDLCSaveData)
			{
			}

			// Token: 0x060030FD RID: 12541 RVA: 0x00011E08 File Offset: 0x00010008
			[Token(Token = "0x60030FD")]
			[Address(RVA = "0x63A810", Offset = "0x639210", VA = "0x18063A810", Slot = "4")]
			public PlayerSaveFile.RunTimeSchedulerSaveDataPartial Clone()
			{
				return default(PlayerSaveFile.RunTimeSchedulerSaveDataPartial);
			}

			// Token: 0x04002BFC RID: 11260
			[Token(Token = "0x4002BFC")]
			[FieldOffset(Offset = "0x0")]
			public string lastMission;

			// Token: 0x04002BFD RID: 11261
			[Token(Token = "0x4002BFD")]
			[FieldOffset(Offset = "0x8")]
			public Dictionary<int, List<string>> scheduledEvents;

			// Token: 0x04002BFE RID: 11262
			[Token(Token = "0x4002BFE")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<int, List<string>> scheduledNews;

			// Token: 0x04002BFF RID: 11263
			[Token(Token = "0x4002BFF")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<int, List<KeyValuePair<string, RunTimeScheduler.HistoryNewsData.ReplaceContent[]>>> scheduledNewsReplaceContents;

			// Token: 0x04002C00 RID: 11264
			[Token(Token = "0x4002C00")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<int, List<RunTimeScheduler.TrackedMissionData>> allTrackingMissions;

			// Token: 0x04002C01 RID: 11265
			[Token(Token = "0x4002C01")]
			[FieldOffset(Offset = "0x28")]
			public string[] finishedEvents;

			// Token: 0x04002C02 RID: 11266
			[Token(Token = "0x4002C02")]
			[FieldOffset(Offset = "0x30")]
			public string[] finishedMissions;

			// Token: 0x04002C03 RID: 11267
			[Token(Token = "0x4002C03")]
			[FieldOffset(Offset = "0x38")]
			public Tuple<RunTimeScheduler.HistoryNewsData[], RunTimeScheduler.HistoryNewsData[]>[] newsData;

			// Token: 0x04002C04 RID: 11268
			[Token(Token = "0x4002C04")]
			[FieldOffset(Offset = "0x40")]
			public RunTimeScheduler.HistoryNewsData[] newsDataArray;

			// Token: 0x04002C05 RID: 11269
			[Token(Token = "0x4002C05")]
			[FieldOffset(Offset = "0x48")]
			public List<KeyValuePair<KeyValuePair<SchedulerNode.Reward.ObjectType, int>, float>> registeredObjectPriceModifierMem;

			// Token: 0x04002C06 RID: 11270
			[Token(Token = "0x4002C06")]
			public const string CACHED_YUYUKO_TUTORIAL_FINISHED_MARK = "CACHED_YUYUKO_TUTORIAL_FINISHED_MARK";
		}

		// Token: 0x0200081E RID: 2078
		[Token(Token = "0x200081E")]
		[Serializable]
		public struct RunTimeStorageSaveDataPartial : IDeepClonable<PlayerSaveFile.RunTimeStorageSaveDataPartial>, PlayerSaveFile.IExtractable<PlayerSaveFile.RunTimeStorageSaveDataPartial>
		{
			// Token: 0x06003108 RID: 12552 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003108")]
			[Address(RVA = "0x653970", Offset = "0x652370", VA = "0x180653970")]
			public RunTimeStorageSaveDataPartial(Dictionary<int, int> foods, Dictionary<int, int> beverages, Dictionary<int, int> ingredients, Dictionary<int, int> cookers, Dictionary<int, int> items, Dictionary<int, int> badges, List<int> trophies, List<int> itemsShouldDeleteTomorrow, List<int> recipes, List<int> izakayas, List<int> unlockedPartners)
			{
			}

			// Token: 0x06003109 RID: 12553 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003109")]
			[Address(RVA = "0x652B80", Offset = "0x651580", VA = "0x180652B80", Slot = "5")]
			public void ExtractValid(out PlayerSaveFile.RunTimeStorageSaveDataPartial valid, out PlayerSaveFile.RunTimeStorageSaveDataPartial invalid)
			{
			}

			// Token: 0x0600310A RID: 12554 RVA: 0x00011E38 File Offset: 0x00010038
			[Token(Token = "0x600310A")]
			[Address(RVA = "0x653200", Offset = "0x651C00", VA = "0x180653200")]
			public static PlayerSaveFile.RunTimeStorageSaveDataPartial Merge(PlayerSaveFile.RunTimeStorageSaveDataPartial current, PlayerSaveFile.RunTimeStorageSaveDataPartial next)
			{
				return default(PlayerSaveFile.RunTimeStorageSaveDataPartial);
			}

			// Token: 0x0600310B RID: 12555 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600310B")]
			[Address(RVA = "0x652AA0", Offset = "0x6514A0", VA = "0x180652AA0")]
			private static void EnusreFieldNotNull(ref PlayerSaveFile.RunTimeStorageSaveDataPartial data)
			{
			}

			// Token: 0x0600310C RID: 12556 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600310C")]
			[Address(RVA = "0x651150", Offset = "0x64FB50", VA = "0x180651150")]
			public static void Classify(in PlayerSaveFile.RunTimeStorageSaveDataPartial storagePartial, ref PlayerSaveFile.RunTimeStorageSaveDataPartial storagePartialSaveData, ref Dictionary<string, PlayerSaveFile.RunTimeStorageSaveDataPartial> storagePartialDLCSaveData)
			{
			}

			// Token: 0x0600310D RID: 12557 RVA: 0x00011E50 File Offset: 0x00010050
			[Token(Token = "0x600310D")]
			[Address(RVA = "0x6529D0", Offset = "0x6513D0", VA = "0x1806529D0", Slot = "4")]
			public PlayerSaveFile.RunTimeStorageSaveDataPartial Clone()
			{
				return default(PlayerSaveFile.RunTimeStorageSaveDataPartial);
			}

			// Token: 0x04002C0F RID: 11279
			[Token(Token = "0x4002C0F")]
			[FieldOffset(Offset = "0x0")]
			public Dictionary<int, int> foods;

			// Token: 0x04002C10 RID: 11280
			[Token(Token = "0x4002C10")]
			[FieldOffset(Offset = "0x8")]
			public Dictionary<int, int> beverages;

			// Token: 0x04002C11 RID: 11281
			[Token(Token = "0x4002C11")]
			[FieldOffset(Offset = "0x10")]
			public Dictionary<int, int> ingredients;

			// Token: 0x04002C12 RID: 11282
			[Token(Token = "0x4002C12")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<int, int> cookers;

			// Token: 0x04002C13 RID: 11283
			[Token(Token = "0x4002C13")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<int, int> items;

			// Token: 0x04002C14 RID: 11284
			[Token(Token = "0x4002C14")]
			[FieldOffset(Offset = "0x28")]
			public Dictionary<int, int> badges;

			// Token: 0x04002C15 RID: 11285
			[Token(Token = "0x4002C15")]
			[FieldOffset(Offset = "0x30")]
			public List<int> trophies;

			// Token: 0x04002C16 RID: 11286
			[Token(Token = "0x4002C16")]
			[FieldOffset(Offset = "0x38")]
			public List<int> itemsShouldDeleteTomorrow;

			// Token: 0x04002C17 RID: 11287
			[Token(Token = "0x4002C17")]
			[FieldOffset(Offset = "0x40")]
			public List<int> recipes;

			// Token: 0x04002C18 RID: 11288
			[Token(Token = "0x4002C18")]
			[FieldOffset(Offset = "0x48")]
			public List<int> izakayas;

			// Token: 0x04002C19 RID: 11289
			[Token(Token = "0x4002C19")]
			[FieldOffset(Offset = "0x50")]
			public List<int> unlockedPartners;
		}
	}
}
