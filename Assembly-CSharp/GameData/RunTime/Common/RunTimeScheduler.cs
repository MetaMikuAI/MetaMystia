using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using GameData.CoreLanguage;
using GameData.Profile;
using GameData.Profile.SchedulerNodeCollection;
using Il2CppDummyDll;
using Newtonsoft.Json;
using NightScene;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.RunTime.Common
{
	// Token: 0x0200083C RID: 2108
	[Token(Token = "0x200083C")]
	public static class RunTimeScheduler
	{
		// Token: 0x14000027 RID: 39
		// (add) Token: 0x06003365 RID: 13157 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003366 RID: 13158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000027")]
		public static event Action OnSchedulerUpdate
		{
			[Token(Token = "0x6003365")]
			[Address(RVA = "0x6508C0", Offset = "0x64F2C0", VA = "0x1806508C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003366")]
			[Address(RVA = "0x650E90", Offset = "0x64F890", VA = "0x180650E90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000028 RID: 40
		// (add) Token: 0x06003367 RID: 13159 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06003368 RID: 13160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000028")]
		public static event Action OnEnterDaySceneCallback
		{
			[Token(Token = "0x6003367")]
			[Address(RVA = "0x6506B0", Offset = "0x64F0B0", VA = "0x1806506B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003368")]
			[Address(RVA = "0x650C80", Offset = "0x64F680", VA = "0x180650C80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000029 RID: 41
		// (add) Token: 0x06003369 RID: 13161 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600336A RID: 13162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000029")]
		public static event Action OnBeforeIzakayaConfigurationCallback
		{
			[Token(Token = "0x6003369")]
			[Address(RVA = "0x6505B0", Offset = "0x64EFB0", VA = "0x1806505B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600336A")]
			[Address(RVA = "0x650B80", Offset = "0x64F580", VA = "0x180650B80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002A RID: 42
		// (add) Token: 0x0600336B RID: 13163 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600336C RID: 13164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002A")]
		public static event Action OnWorkEndCallback
		{
			[Token(Token = "0x600336B")]
			[Address(RVA = "0x6509C0", Offset = "0x64F3C0", VA = "0x1806509C0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600336C")]
			[Address(RVA = "0x650F90", Offset = "0x64F990", VA = "0x180650F90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x0600336D RID: 13165 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600336E RID: 13166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002B")]
		public static event Action<string> OnRefreshRandomSpawnNpc
		{
			[Token(Token = "0x600336D")]
			[Address(RVA = "0x6507B0", Offset = "0x64F1B0", VA = "0x1806507B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600336E")]
			[Address(RVA = "0x650D80", Offset = "0x64F780", VA = "0x180650D80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600336F")]
		[Address(RVA = "0x64B270", Offset = "0x649C70", VA = "0x18064B270")]
		public static void ResetQueueExecutingStates()
		{
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x00012F48 File Offset: 0x00011148
		[Token(Token = "0x6003370")]
		[Address(RVA = "0x647BC0", Offset = "0x6465C0", VA = "0x180647BC0")]
		public static bool IsChallenge()
		{
			return default(bool);
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06003371 RID: 13169 RVA: 0x00012F60 File Offset: 0x00011160
		// (set) Token: 0x06003372 RID: 13170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E8")]
		public static RunTimeScheduler.GamePhase CurrentGamePhase
		{
			[Token(Token = "0x6003371")]
			[Address(RVA = "0x650AC0", Offset = "0x64F4C0", VA = "0x180650AC0")]
			[CompilerGenerated]
			get
			{
				return RunTimeScheduler.GamePhase.Day;
			}
			[Token(Token = "0x6003372")]
			[Address(RVA = "0x651090", Offset = "0x64FA90", VA = "0x180651090")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06003373 RID: 13171 RVA: 0x00012F78 File Offset: 0x00011178
		// (set) Token: 0x06003374 RID: 13172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006E9")]
		public static float GlobalFundMultiplier
		{
			[Token(Token = "0x6003373")]
			[Address(RVA = "0x650B20", Offset = "0x64F520", VA = "0x180650B20")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6003374")]
			[Address(RVA = "0x6510F0", Offset = "0x64FAF0", VA = "0x1806510F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003375")]
		[Address(RVA = "0x6467D0", Offset = "0x6451D0", VA = "0x1806467D0")]
		public static void Initialize(PlayerSaveFile.RunTimeSchedulerSaveDataPartial saveDataPartial, Dictionary<string, PlayerSaveFile.DLCSchedulerSaveData> schedulerPartialDLC, int currentDate)
		{
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x00012F90 File Offset: 0x00011190
		[Token(Token = "0x6003376")]
		[Address(RVA = "0x641D20", Offset = "0x640720", VA = "0x180641D20")]
		public static PlayerSaveFile.RunTimeSchedulerSaveDataPartial GenerateSaveData()
		{
			return default(PlayerSaveFile.RunTimeSchedulerSaveDataPartial);
		}

		// Token: 0x06003377 RID: 13175 RVA: 0x00012FA8 File Offset: 0x000111A8
		[Token(Token = "0x6003377")]
		[Address(RVA = "0x640670", Offset = "0x63F070", VA = "0x180640670")]
		public static int FindMissionTriggerTime(RunTimeScheduler.TrackedMissionData trackedMission)
		{
			return 0;
		}

		// Token: 0x06003378 RID: 13176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003378")]
		[Address(RVA = "0x63AD70", Offset = "0x639770", VA = "0x18063AD70")]
		public static EventNode[] AllScheduledEventToday()
		{
			return null;
		}

		// Token: 0x06003379 RID: 13177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003379")]
		[Address(RVA = "0x64DD30", Offset = "0x64C730", VA = "0x18064DD30")]
		public static void TryGetOverrideIzakayaData(out SchedulerNode.Trigger.IzakayaLockType izakayaLockType, out SchedulerNode.Trigger.IzakayaMapping[] izakayaMappings)
		{
		}

		// Token: 0x0600337A RID: 13178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337A")]
		[Address(RVA = "0x643CF0", Offset = "0x6426F0", VA = "0x180643CF0")]
		public static MissionNode[] GetTodayTimeLimitMissions()
		{
			return null;
		}

		// Token: 0x0600337B RID: 13179 RVA: 0x00012FC0 File Offset: 0x000111C0
		[Token(Token = "0x600337B")]
		[Address(RVA = "0x646230", Offset = "0x644C30", VA = "0x180646230")]
		public static bool HaveTrackedEventOrMissionTonight()
		{
			return default(bool);
		}

		// Token: 0x0600337C RID: 13180 RVA: 0x00012FD8 File Offset: 0x000111D8
		[Token(Token = "0x600337C")]
		[Address(RVA = "0x645AC0", Offset = "0x6444C0", VA = "0x180645AC0")]
		public static bool HaveTrackedEventOrMissionTonight(out Action finishAutoCompleteEvents)
		{
			return default(bool);
		}

		// Token: 0x0600337D RID: 13181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600337D")]
		[Address(RVA = "0x647C60", Offset = "0x646660", VA = "0x180647C60")]
		private static void LogProcessingFinishedEvent(SchedulerNode node)
		{
		}

		// Token: 0x0600337E RID: 13182 RVA: 0x00012FF0 File Offset: 0x000111F0
		[Token(Token = "0x600337E")]
		[Address(RVA = "0x642D50", Offset = "0x641750", VA = "0x180642D50")]
		public static bool GetMissionData(string missionLabel, out RunTimeScheduler.TrackedMissionData trackedMissionData)
		{
			return default(bool);
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600337F")]
		[Address(RVA = "0x643490", Offset = "0x641E90", VA = "0x180643490")]
		public static string GetScheduledEventData()
		{
			return null;
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003380")]
		[Address(RVA = "0x644000", Offset = "0x642A00", VA = "0x180644000")]
		public static string GetTrackedMissionData()
		{
			return null;
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x00013008 File Offset: 0x00011208
		[Token(Token = "0x6003381")]
		[Address(RVA = "0x6455A0", Offset = "0x643FA0", VA = "0x1806455A0")]
		public static bool HaveEventScheduled(this string eventLabel)
		{
			return default(bool);
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x00013020 File Offset: 0x00011220
		[Token(Token = "0x6003382")]
		[Address(RVA = "0x645990", Offset = "0x644390", VA = "0x180645990")]
		public static bool HaveNewsScheduled(this string eventLabel)
		{
			return default(bool);
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x00013038 File Offset: 0x00011238
		[Token(Token = "0x6003383")]
		[Address(RVA = "0x645880", Offset = "0x644280", VA = "0x180645880")]
		public static bool HaveNewsFinished(this string eventLabel)
		{
			return default(bool);
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x00013050 File Offset: 0x00011250
		[Token(Token = "0x6003384")]
		[Address(RVA = "0x645750", Offset = "0x644150", VA = "0x180645750")]
		public static bool HaveMissionStarted(this string missionLabel)
		{
			return default(bool);
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x00013068 File Offset: 0x00011268
		[Token(Token = "0x6003385")]
		[Address(RVA = "0x6456D0", Offset = "0x6440D0", VA = "0x1806456D0")]
		public static bool HaveMissionFinished(this string missionLabel)
		{
			return default(bool);
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003386")]
		[Address(RVA = "0x642020", Offset = "0x640A20", VA = "0x180642020")]
		public static IEnumerable<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>> GetAllMissionData(RunTimeScheduler.MissionDataFillterType missionData = RunTimeScheduler.MissionDataFillterType.All)
		{
			return null;
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x00013080 File Offset: 0x00011280
		[Token(Token = "0x6003387")]
		[Address(RVA = "0x649270", Offset = "0x647C70", VA = "0x180649270")]
		public static ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int> ParseActiveMissionData(RunTimeScheduler.TrackedMissionData trackedMissionData)
		{
			return default(ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>);
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003388")]
		[Address(RVA = "0x641F90", Offset = "0x640990", VA = "0x180641F90")]
		public static List<string> GetAllFinished()
		{
			return null;
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003389")]
		[Address(RVA = "0x641F40", Offset = "0x640940", VA = "0x180641F40")]
		public static List<string> GetAllFinishedEvents()
		{
			return null;
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x00013098 File Offset: 0x00011298
		[Token(Token = "0x600338A")]
		[Address(RVA = "0x64AF00", Offset = "0x649900", VA = "0x18064AF00")]
		public static float RefObjectPriceModifier(this KeyValuePair<SchedulerNode.Reward.ObjectType, int> key)
		{
			return 0f;
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x000130B0 File Offset: 0x000112B0
		[Token(Token = "0x600338B")]
		[Address(RVA = "0x645520", Offset = "0x643F20", VA = "0x180645520")]
		public static bool HaveEventFinished(this string eventLabel)
		{
			return default(bool);
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x000130C8 File Offset: 0x000112C8
		[Token(Token = "0x600338C")]
		[Address(RVA = "0x643170", Offset = "0x641B70", VA = "0x180643170")]
		public static ReadOnlySpan<RunTimeScheduler.HistoryNewsData> GetPageData(int pageIndex)
		{
			return default(ReadOnlySpan<RunTimeScheduler.HistoryNewsData>);
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x000130E0 File Offset: 0x000112E0
		[Token(Token = "0x600338D")]
		[Address(RVA = "0x643000", Offset = "0x641A00", VA = "0x180643000")]
		public static int GetPageCount()
		{
			return 0;
		}

		// Token: 0x0600338E RID: 13198 RVA: 0x000130F8 File Offset: 0x000112F8
		[Token(Token = "0x600338E")]
		[Address(RVA = "0x63C3E0", Offset = "0x63ADE0", VA = "0x18063C3E0")]
		public static bool CheckCharacterInteractMission(string characterLabel)
		{
			return default(bool);
		}

		// Token: 0x0600338F RID: 13199 RVA: 0x00013110 File Offset: 0x00011310
		[Token(Token = "0x600338F")]
		[Address(RVA = "0x63C300", Offset = "0x63AD00", VA = "0x18063C300")]
		public static bool CheckCharacterInteractEvent(string characterLabel)
		{
			return default(bool);
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x00013128 File Offset: 0x00011328
		[Token(Token = "0x6003390")]
		[Address(RVA = "0x645080", Offset = "0x643A80", VA = "0x180645080")]
		public static bool HasEvent(string characterKey)
		{
			return default(bool);
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003391")]
		[Address(RVA = "0x642850", Offset = "0x641250", VA = "0x180642850")]
		public static string[] GetAvailableInteractMissionForCharacter(string characterLabel)
		{
			return null;
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003392")]
		[Address(RVA = "0x64DC00", Offset = "0x64C600", VA = "0x18064DC00")]
		private static List<string> TryGetEventListAtDay(int absoluteStartDay)
		{
			return null;
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003393")]
		[Address(RVA = "0x644330", Offset = "0x642D30", VA = "0x180644330")]
		public static List<RunTimeScheduler.CGPicture> GetUnlockedCG()
		{
			return null;
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x00013140 File Offset: 0x00011340
		[Token(Token = "0x6003394")]
		[Address(RVA = "0x63B520", Offset = "0x639F20", VA = "0x18063B520")]
		private static bool CanContinue(string nodeLabel)
		{
			return default(bool);
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x00013158 File Offset: 0x00011358
		[Token(Token = "0x6003395")]
		[Address(RVA = "0x642980", Offset = "0x641380", VA = "0x180642980")]
		[Obsolete]
		public static bool GetCharacterInteractMissionConditionData(string characterLabel, out string chatMissionLang)
		{
			return default(bool);
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x00013170 File Offset: 0x00011370
		[Token(Token = "0x6003396")]
		[Address(RVA = "0x645130", Offset = "0x643B30", VA = "0x180645130")]
		public static bool HasMission(string characterKey)
		{
			return default(bool);
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x00013188 File Offset: 0x00011388
		[Token(Token = "0x6003397")]
		[Address(RVA = "0x645380", Offset = "0x643D80", VA = "0x180645380")]
		public static bool HasRelatedMission(string characterKey, out RunTimeScheduler.TrackedMissionData trackedMissionData)
		{
			return default(bool);
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x000131A0 File Offset: 0x000113A0
		[Token(Token = "0x6003398")]
		[Address(RVA = "0x63DF40", Offset = "0x63C940", VA = "0x18063DF40")]
		public static bool ContainsSpecialNPCServeInWorkMission(int specialNpcId, out int foodId)
		{
			return default(bool);
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003399")]
		[Address(RVA = "0x640850", Offset = "0x63F250", VA = "0x180640850")]
		public static IEnumerable<RunTimeScheduler.TrackedMissionData> FindTrackingMission(string missionKey)
		{
			return null;
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x000131B8 File Offset: 0x000113B8
		[Token(Token = "0x600339A")]
		[Address(RVA = "0x648C80", Offset = "0x647680", VA = "0x180648C80")]
		public static bool OnEnterDaySceneMap(string mapLabel, Action onFinish)
		{
			return default(bool);
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339B")]
		[Address(RVA = "0x648DD0", Offset = "0x6477D0", VA = "0x180648DD0")]
		public static void OnEnterDayScene(Action onFinish, out bool hasEventTriggered)
		{
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339C")]
		[Address(RVA = "0x648470", Offset = "0x646E70", VA = "0x180648470")]
		public static void OnBeforeIzakayaConfiguration(Action onFinish)
		{
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339D")]
		[Address(RVA = "0x6485B0", Offset = "0x646FB0", VA = "0x1806485B0")]
		public static void OnBeforeWorkStart(Action onFinish)
		{
		}

		// Token: 0x0600339E RID: 13214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339E")]
		[Address(RVA = "0x648330", Offset = "0x646D30", VA = "0x180648330")]
		public static void OnBeforeChallengeStart(Action onFinish)
		{
		}

		// Token: 0x0600339F RID: 13215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600339F")]
		[Address(RVA = "0x6488C0", Offset = "0x6472C0", VA = "0x1806488C0")]
		public static void OnChallengeFailed(Action onFinish)
		{
		}

		// Token: 0x060033A0 RID: 13216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A0")]
		[Address(RVA = "0x648A00", Offset = "0x647400", VA = "0x180648A00")]
		public static void OnChallengeSucceed(Action onFinish)
		{
		}

		// Token: 0x060033A1 RID: 13217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A1")]
		[Address(RVA = "0x649080", Offset = "0x647A80", VA = "0x180649080")]
		public static void OnPlayerLevelUp(Action onFinish)
		{
		}

		// Token: 0x060033A2 RID: 13218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A2")]
		[Address(RVA = "0x649130", Offset = "0x647B30", VA = "0x180649130")]
		public static void OnWorkEnd(Action onFinish)
		{
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A3")]
		[Address(RVA = "0x6486F0", Offset = "0x6470F0", VA = "0x1806486F0")]
		public static void OnChallengeEnd(NightSceneDirector.ChallengeType challengeType, Action onFinish)
		{
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A4")]
		[Address(RVA = "0x648F30", Offset = "0x647930", VA = "0x180648F30")]
		public static void OnEnterTriggerArea(string triggerId, Action onFinish)
		{
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A5")]
		[Address(RVA = "0x648B40", Offset = "0x647540", VA = "0x180648B40")]
		public static void OnDayEnd(Action onFinish)
		{
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A6")]
		[Address(RVA = "0x647F60", Offset = "0x646960", VA = "0x180647F60")]
		public static void OnAfterDayEnd(Action onFinish)
		{
		}

		// Token: 0x060033A7 RID: 13223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A7")]
		[Address(RVA = "0x6480A0", Offset = "0x646AA0", VA = "0x1806480A0")]
		public static void OnAfterIzakayaSelectionOpen()
		{
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033A8")]
		[Address(RVA = "0x648230", Offset = "0x646C30", VA = "0x180648230")]
		public static void OnAnyKizunaExpFull(string characterLabel, Action onFinish)
		{
		}

		// Token: 0x060033A9 RID: 13225 RVA: 0x000131D0 File Offset: 0x000113D0
		[Token(Token = "0x60033A9")]
		[Address(RVA = "0x648830", Offset = "0x647230", VA = "0x180648830")]
		public static UniTask OnChallengeFailedAsync()
		{
			return default(UniTask);
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x000131E8 File Offset: 0x000113E8
		[Token(Token = "0x60033AA")]
		[Address(RVA = "0x648970", Offset = "0x647370", VA = "0x180648970")]
		public static UniTask OnChallengeSucceedAsync()
		{
			return default(UniTask);
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x00013200 File Offset: 0x00011400
		[Token(Token = "0x60033AB")]
		[Address(RVA = "0x648AB0", Offset = "0x6474B0", VA = "0x180648AB0")]
		public static UniTask OnDayEndAsync()
		{
			return default(UniTask);
		}

		// Token: 0x060033AC RID: 13228 RVA: 0x00013218 File Offset: 0x00011418
		[Token(Token = "0x60033AC")]
		[Address(RVA = "0x647ED0", Offset = "0x6468D0", VA = "0x180647ED0")]
		public static UniTask OnAfterDayEndAsync()
		{
			return default(UniTask);
		}

		// Token: 0x060033AD RID: 13229 RVA: 0x00013230 File Offset: 0x00011430
		[Token(Token = "0x60033AD")]
		[Address(RVA = "0x6401D0", Offset = "0x63EBD0", VA = "0x1806401D0")]
		private static bool ExecuteTriggerInternal(Func<SchedulerNode.Trigger, bool> fillter, Action onFinish, RunTimeScheduler.EventExecutionValidationMethod validationMethod, RunTimeScheduler.TimeValidationMethod timeValidationMethod)
		{
			return default(bool);
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x00013248 File Offset: 0x00011448
		[Token(Token = "0x60033AE")]
		[Address(RVA = "0x64E2C0", Offset = "0x64CCC0", VA = "0x18064E2C0")]
		public static bool TryTriggerCharacterInteractEvent(string characterLabel, Action onFinish)
		{
			return default(bool);
		}

		// Token: 0x060033AF RID: 13231 RVA: 0x00013260 File Offset: 0x00011460
		[Token(Token = "0x60033AF")]
		[Address(RVA = "0x640340", Offset = "0x63ED40", VA = "0x180640340")]
		private static bool FillterCharacterInteractCondition(SchedulerNode.ScheduledEvent x, string characterLabel)
		{
			return default(bool);
		}

		// Token: 0x060033B0 RID: 13232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B0")]
		[Address(RVA = "0x4A63B0", Offset = "0x4A4DB0", VA = "0x1804A63B0")]
		private static void StandardPostAction(Queue<ValueTuple<MissionNode.FinishCondition, Action>> _, Action action)
		{
		}

		// Token: 0x060033B1 RID: 13233 RVA: 0x00013278 File Offset: 0x00011478
		[Token(Token = "0x60033B1")]
		[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0")]
		private static bool StandardShouldBlockEvent(MissionNode.FinishCondition finishedCondition)
		{
			return default(bool);
		}

		// Token: 0x060033B2 RID: 13234 RVA: 0x00013290 File Offset: 0x00011490
		[Token(Token = "0x60033B2")]
		[Address(RVA = "0x64F060", Offset = "0x64DA60", VA = "0x18064F060")]
		public static bool TryTriggerSpecialCharacterInteractMission(string characterLabel, string missionLabel, Action onFinished)
		{
			return default(bool);
		}

		// Token: 0x060033B3 RID: 13235 RVA: 0x000132A8 File Offset: 0x000114A8
		[Token(Token = "0x60033B3")]
		[Address(RVA = "0x6492F0", Offset = "0x647CF0", VA = "0x1806492F0")]
		private static bool PreProcessInteractFinishConditionData(ValueTuple<MissionNode.FinishCondition, bool> condition)
		{
			return default(bool);
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x000132C0 File Offset: 0x000114C0
		[Token(Token = "0x60033B4")]
		[Address(RVA = "0x63BF30", Offset = "0x63A930", VA = "0x18063BF30")]
		private static bool CharacterInteractShouldBlockEvent(MissionNode.FinishCondition finishedCondition)
		{
			return default(bool);
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x000132D8 File Offset: 0x000114D8
		[Token(Token = "0x60033B5")]
		[Address(RVA = "0x64EA10", Offset = "0x64D410", VA = "0x18064EA10")]
		public static bool TryTriggerNormalCharacterInteractMission(string characterLabel, Action onFinished)
		{
			return default(bool);
		}

		// Token: 0x060033B6 RID: 13238 RVA: 0x000132F0 File Offset: 0x000114F0
		[Token(Token = "0x60033B6")]
		[Address(RVA = "0x64E510", Offset = "0x64CF10", VA = "0x18064E510")]
		private static bool TryTriggerFakeMission(string missionConditionId)
		{
			return default(bool);
		}

		// Token: 0x060033B7 RID: 13239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B7")]
		[Address(RVA = "0x63FE90", Offset = "0x63E890", VA = "0x18063FE90")]
		private static void ExecuteTimedMissionCheckpoint(RunTimeScheduler.TrackedMissionData trackingMissionData, Action<bool> onFinish)
		{
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x00013308 File Offset: 0x00011508
		[Token(Token = "0x60033B8")]
		[Address(RVA = "0x63FAB0", Offset = "0x63E4B0", VA = "0x18063FAB0")]
		private static bool ExecuteTimedMissionCheckpointInternal(Func<MissionNode, bool> fillter, Func<bool> onFinish, RunTimeScheduler.EventExecutionValidationMethod validationMethod)
		{
			return default(bool);
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033B9")]
		[Address(RVA = "0x64DA60", Offset = "0x64C460", VA = "0x18064DA60")]
		private static void TryFinishAllCompleteSpecifiedFollowingEventsConditionEvent()
		{
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033BA")]
		[Address(RVA = "0x63BD90", Offset = "0x63A790", VA = "0x18063BD90")]
		private static void CharacterInteractPostAction(Queue<ValueTuple<MissionNode.FinishCondition, Action>> finishedConditions, Action action)
		{
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x00013320 File Offset: 0x00011520
		[Token(Token = "0x60033BB")]
		[Address(RVA = "0x63BCD0", Offset = "0x63A6D0", VA = "0x18063BCD0")]
		private static UniTask CharacterInteractPostActionAsync(Queue<ValueTuple<MissionNode.FinishCondition, Action>> finishedConditions)
		{
			return default(UniTask);
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x00013338 File Offset: 0x00011538
		[Token(Token = "0x60033BC")]
		[Address(RVA = "0x64E170", Offset = "0x64CB70", VA = "0x18064E170")]
		public static bool TryTriggerCharacterDeliverMission(string characterLabel, Action onFinished)
		{
			return default(bool);
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x00013350 File Offset: 0x00011550
		[Token(Token = "0x60033BD")]
		[Address(RVA = "0x6404E0", Offset = "0x63EEE0", VA = "0x1806404E0")]
		private static bool FillterCharacterInteractMissionCondition(MissionNode.FinishCondition x, string characterLabel)
		{
			return default(bool);
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x00013368 File Offset: 0x00011568
		[Token(Token = "0x60033BE")]
		[Address(RVA = "0x64E790", Offset = "0x64D190", VA = "0x18064E790")]
		public static bool TryTriggerInteractableEntitiyActivateMission(string interactableLabel)
		{
			return default(bool);
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x00013380 File Offset: 0x00011580
		[Token(Token = "0x60033BF")]
		[Address(RVA = "0x64EDA0", Offset = "0x64D7A0", VA = "0x18064EDA0")]
		public static bool TryTriggerServeMission(string characterLabel, int foodId)
		{
			return default(bool);
		}

		// Token: 0x060033C0 RID: 13248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C0")]
		[Address(RVA = "0x64EBF0", Offset = "0x64D5F0", VA = "0x18064EBF0")]
		public static void TryTriggerSellInWorkCondition(int foodId)
		{
		}

		// Token: 0x060033C1 RID: 13249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C1")]
		[Address(RVA = "0x64FD90", Offset = "0x64E790", VA = "0x18064FD90")]
		private static void WriteMissionData(Func<MissionNode.FinishCondition, bool> fillter, Action<List<int>> dataCallback)
		{
		}

		// Token: 0x060033C2 RID: 13250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C2")]
		[Address(RVA = "0x64CCD0", Offset = "0x64B6D0", VA = "0x18064CCD0")]
		public static void StartMissionExtern(this string missionLabel)
		{
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C3")]
		[Address(RVA = "0x64B2D0", Offset = "0x649CD0", VA = "0x18064B2D0")]
		public static void ScheduleEventExtern(this string eventLabel)
		{
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C4")]
		[Address(RVA = "0x64BDF0", Offset = "0x64A7F0", VA = "0x18064BDF0")]
		public static void ScheduleNewsExtern(this string eventLabel)
		{
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C5")]
		[Address(RVA = "0x6412F0", Offset = "0x63FCF0", VA = "0x1806412F0")]
		public static void FinishNodeExtern(this string nodeLabel)
		{
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C6")]
		[Address(RVA = "0x64AFE0", Offset = "0x6499E0", VA = "0x18064AFE0")]
		private static void RemoveMissionFromList(RunTimeScheduler.TrackedMissionData trackedMissionData)
		{
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C7")]
		[Address(RVA = "0x64B1E0", Offset = "0x649BE0", VA = "0x18064B1E0")]
		public static void RemoveMissionFromList(string trackedMissionLabel)
		{
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C8")]
		[Address(RVA = "0x63E7C0", Offset = "0x63D1C0", VA = "0x18063E7C0")]
		public static void DisposeChallengeRelatedEvents()
		{
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033C9")]
		[Address(RVA = "0x64BED0", Offset = "0x64A8D0", VA = "0x18064BED0")]
		public static void ScheduleNews(string newsLabel, SchedulerNode.Day targetDate, params RunTimeScheduler.HistoryNewsData.ReplaceContent[] replaceContents)
		{
		}

		// Token: 0x060033CA RID: 13258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033CA")]
		[Address(RVA = "0x64CD20", Offset = "0x64B720", VA = "0x18064CD20")]
		private static void StartMission(string missionLabel)
		{
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033CB")]
		[Address(RVA = "0x63B700", Offset = "0x63A100", VA = "0x18063B700")]
		public static void CancelChallengeEvents()
		{
		}

		// Token: 0x060033CC RID: 13260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033CC")]
		[Address(RVA = "0x641EE0", Offset = "0x6408E0", VA = "0x180641EE0")]
		private static RunTimeScheduler.TrackedMissionData GenerateTrackingData(string missionLabel)
		{
			return null;
		}

		// Token: 0x060033CD RID: 13261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033CD")]
		[Address(RVA = "0x63EAE0", Offset = "0x63D4E0", VA = "0x18063EAE0")]
		private static void DisposeMissionRuntimeData(string missionLabel)
		{
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033CE")]
		[Address(RVA = "0x64B320", Offset = "0x649D20", VA = "0x18064B320")]
		private static void ScheduleEvent(string eventLabel)
		{
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033CF")]
		[Address(RVA = "0x63E2D0", Offset = "0x63CCD0", VA = "0x18063E2D0")]
		private static void DismissEvent(string eventLabel)
		{
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D0")]
		[Address(RVA = "0x63E5F0", Offset = "0x63CFF0", VA = "0x18063E5F0")]
		private static void DismissNews(string newsLabel)
		{
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D1")]
		[Address(RVA = "0x63AF50", Offset = "0x639950", VA = "0x18063AF50")]
		private static void ApplyNews()
		{
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x00013398 File Offset: 0x00011598
		[Token(Token = "0x60033D2")]
		[Address(RVA = "0x64D930", Offset = "0x64C330", VA = "0x18064D930")]
		private static bool TryExtractScheduledNewsReplaceContents(List<KeyValuePair<string, RunTimeScheduler.HistoryNewsData.ReplaceContent[]>> newsReplaceContents, string newsLabel, out RunTimeScheduler.HistoryNewsData.ReplaceContent[] outValue)
		{
			return default(bool);
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D3")]
		[Address(RVA = "0x63EFE0", Offset = "0x63D9E0", VA = "0x18063EFE0")]
		private static void ExecuteEvent(SchedulerNode.Event eventData, Action onFinish)
		{
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D4")]
		[Address(RVA = "0x6417E0", Offset = "0x6401E0", VA = "0x1806417E0")]
		private static void FinishSchedulerNode(SchedulerNode node)
		{
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D5")]
		[Address(RVA = "0x641440", Offset = "0x63FE40", VA = "0x180641440")]
		private static void FinishSchedulerNodePost(SchedulerNode node)
		{
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D6")]
		[Address(RVA = "0x63B8A0", Offset = "0x63A2A0", VA = "0x18063B8A0")]
		private static void CancelEvent(string eventId)
		{
		}

		// Token: 0x060033D7 RID: 13271 RVA: 0x000133B0 File Offset: 0x000115B0
		[Token(Token = "0x60033D7")]
		[Address(RVA = "0x63E2B0", Offset = "0x63CCB0", VA = "0x18063E2B0")]
		private static bool DefaultOnFinish(Action action)
		{
			return default(bool);
		}

		// Token: 0x060033D8 RID: 13272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033D8")]
		[Address(RVA = "0x6419F0", Offset = "0x6403F0", VA = "0x1806419F0")]
		private static void ForceCompleteMission(string missionLabel)
		{
		}

		// Token: 0x060033D9 RID: 13273 RVA: 0x000133C8 File Offset: 0x000115C8
		[Token(Token = "0x60033D9")]
		[Address(RVA = "0x63D270", Offset = "0x63BC70", VA = "0x18063D270")]
		private static bool CompleteMissionCondition(string currentInteractCharacterLabel, RunTimeScheduler.TrackedMissionData trackedData, Func<MissionNode.FinishCondition, bool> fillter, Func<MissionNode.FinishCondition, bool> shouldFinishedConditionBlockEventCallback, Func<ValueTuple<MissionNode.FinishCondition, bool>, bool> preProcessFinishConditionDataCallback, [TupleElementNames(new string[] { "finishConditionData", "cancelConditionFinishStateCallback" })] Action<Queue<ValueTuple<MissionNode.FinishCondition, Action>>, Action> postActionFinishCallback, Action onFinishCallback)
		{
			return default(bool);
		}

		// Token: 0x060033DA RID: 13274 RVA: 0x000133E0 File Offset: 0x000115E0
		[Token(Token = "0x60033DA")]
		[Address(RVA = "0x63CFE0", Offset = "0x63B9E0", VA = "0x18063CFE0")]
		private static bool CompleteMissionCondition(string currentInteractCharacterLabel, string missionLabel, Func<MissionNode.FinishCondition, bool> fillter, Func<MissionNode.FinishCondition, bool> shouldFinishedConditionBlockEventCallback, Func<ValueTuple<MissionNode.FinishCondition, bool>, bool> preProcessFinishConditionDataCallback, [TupleElementNames(new string[] { "finishConditionData", "cancelConditionFinishStateCallback" })] Action<Queue<ValueTuple<MissionNode.FinishCondition, Action>>, Action> postActionFinishCallback, Action onFinishCallback)
		{
			return default(bool);
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x000133F8 File Offset: 0x000115F8
		[Token(Token = "0x60033DB")]
		[Address(RVA = "0x63C510", Offset = "0x63AF10", VA = "0x18063C510")]
		private static bool CompleteMissionCondition(string currentInteractCharacterLabel, Func<MissionNode.FinishCondition, bool> fillter, Func<MissionNode.FinishCondition, bool> shouldFinishedConditionBlockEventCallback, Func<ValueTuple<MissionNode.FinishCondition, bool>, bool> preProcessFinishConditionDataCallback, [TupleElementNames(new string[] { "finishConditionData", "cancelConditionFinishStateCallback" })] Action<Queue<ValueTuple<MissionNode.FinishCondition, Action>>, Action> postActionFinishCallback, Action onFinishCallback)
		{
			return default(bool);
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033DC")]
		[Address(RVA = "0x640510", Offset = "0x63EF10", VA = "0x180640510")]
		private static RunTimeScheduler.TrackedMissionData[] FillterMissionByConditions(Func<MissionNode.FinishCondition, bool> fillter, Func<ValueTuple<MissionNode.FinishCondition, bool>, bool> preProcessFinishConditionDataCallback)
		{
			return null;
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033DD")]
		[Address(RVA = "0x63F060", Offset = "0x63DA60", VA = "0x18063F060")]
		private static void ExecuteQueue()
		{
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033DE")]
		[Address(RVA = "0x63F850", Offset = "0x63E250", VA = "0x18063F850")]
		private static void ExecuteTargetFinishedMission(RunTimeScheduler.TrackedMissionData trackedData, Action onFinish)
		{
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x00013410 File Offset: 0x00011610
		[Token(Token = "0x60033DF")]
		[Address(RVA = "0x63EB90", Offset = "0x63D590", VA = "0x18063EB90")]
		private static bool ExecuteAllFinishedMission(string externalCurrentInteractCharacterLabel, bool alwaysBlockEvent, Action<Action> postActionFinishCallback, Action externalOnFinish)
		{
			return default(bool);
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x00013428 File Offset: 0x00011628
		[Token(Token = "0x60033E0")]
		[Address(RVA = "0x63F2A0", Offset = "0x63DCA0", VA = "0x18063F2A0")]
		private static bool ExecuteScheduledEventInternal(Func<SchedulerNode.ScheduledEvent, bool> externalFillter, Func<bool> externalOnFinish, int externalDay, RunTimeScheduler.EventExecutionValidationMethod validationMethod = RunTimeScheduler.EventExecutionValidationMethod.Any)
		{
			return default(bool);
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E1")]
		[Address(RVA = "0x64D6D0", Offset = "0x64C0D0", VA = "0x18064D6D0")]
		private static void TryAddFinishedEvent(EventNode node)
		{
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E2")]
		[Address(RVA = "0x6433F0", Offset = "0x641DF0", VA = "0x1806433F0")]
		public static void GetReward(this SchedulerNode.Reward reward)
		{
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E3")]
		[Address(RVA = "0x649330", Offset = "0x647D30", VA = "0x180649330")]
		private static void ProcessReward(SchedulerNode.Reward reward)
		{
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E4")]
		[Address(RVA = "0x63ABE0", Offset = "0x6395E0", VA = "0x18063ABE0")]
		public static void AddReimuPositiveSpellToWorkScene()
		{
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E5")]
		[Address(RVA = "0x6408D0", Offset = "0x63F2D0", VA = "0x1806408D0")]
		private static void FinishMission(RunTimeScheduler.TrackedMissionData trackedMissionData)
		{
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x00013440 File Offset: 0x00011640
		[Token(Token = "0x60033E6")]
		[Address(RVA = "0x63BF90", Offset = "0x63A990", VA = "0x18063BF90")]
		public static bool CheckAndApplyNewDailyNewsData()
		{
			return default(bool);
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E7")]
		[Address(RVA = "0x64C2C0", Offset = "0x64ACC0", VA = "0x18064C2C0")]
		public static void SetAllTimeOutEvent()
		{
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E8")]
		[Address(RVA = "0x64C6E0", Offset = "0x64B0E0", VA = "0x18064C6E0")]
		public static void SetAllTimeOutEvent(params string[] eventLabel)
		{
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033E9")]
		[Address(RVA = "0x64CBD0", Offset = "0x64B5D0", VA = "0x18064CBD0")]
		public static void SetFinishedEvents(this string eventLabels)
		{
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033EA")]
		[Address(RVA = "0x64CC50", Offset = "0x64B650", VA = "0x18064CC50")]
		public static void SetFinishedMissions(this string missionLabels)
		{
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x00013458 File Offset: 0x00011658
		[Token(Token = "0x60033EC")]
		[Address(RVA = "0x64FBF0", Offset = "0x64E5F0", VA = "0x18064FBF0")]
		[CompilerGenerated]
		internal static bool <HaveTrackedEventOrMissionTonight>g__CheckTriggerType|55_0(SchedulerNode.Trigger.TriggerType triggerType)
		{
			return default(bool);
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x00013470 File Offset: 0x00011670
		[Token(Token = "0x60033ED")]
		[Address(RVA = "0x64FBF0", Offset = "0x64E5F0", VA = "0x18064FBF0")]
		[CompilerGenerated]
		internal static bool <HaveTrackedEventOrMissionTonight>g__CheckTriggerType|56_0(SchedulerNode.Trigger.TriggerType triggerType)
		{
			return default(bool);
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EE")]
		[Address(RVA = "0x64F520", Offset = "0x64DF20", VA = "0x18064F520")]
		[CompilerGenerated]
		internal static IEnumerable<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>> <GetAllMissionData>g__GetFinishedMissions|66_0()
		{
			return null;
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60033EF")]
		[Address(RVA = "0x64F760", Offset = "0x64E160", VA = "0x18064F760")]
		[CompilerGenerated]
		internal static IEnumerable<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>> <GetAllMissionData>g__GetTrackingMissions|66_1()
		{
			return null;
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x00013488 File Offset: 0x00011688
		[Token(Token = "0x60033F0")]
		[Address(RVA = "0x64F950", Offset = "0x64E350", VA = "0x18064F950")]
		[CompilerGenerated]
		internal static bool <HasEvent>g__HasEventInDay|76_0(string characterKey, int day)
		{
			return default(bool);
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x000134A0 File Offset: 0x000116A0
		[Token(Token = "0x60033F1")]
		[Address(RVA = "0x64FC90", Offset = "0x64E690", VA = "0x18064FC90")]
		[CompilerGenerated]
		internal static bool <OnEnterDayScene>g__FillterEnterDaySceneCondition|87_0(SchedulerNode.Trigger trigger)
		{
			return default(bool);
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x000134B8 File Offset: 0x000116B8
		[Token(Token = "0x60033F2")]
		[Address(RVA = "0x64FC40", Offset = "0x64E640", VA = "0x18064FC40")]
		[CompilerGenerated]
		internal static bool <OnBeforeIzakayaConfiguration>g__FillterCondition|88_0(SchedulerNode.Trigger trigger)
		{
			return default(bool);
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x000134D0 File Offset: 0x000116D0
		[Token(Token = "0x60033F3")]
		[Address(RVA = "0x64FC50", Offset = "0x64E650", VA = "0x18064FC50")]
		[CompilerGenerated]
		internal static bool <OnBeforeWorkStart>g__FillterOnBeforeWorkStartCondition|89_0(SchedulerNode.Trigger trigger)
		{
			return default(bool);
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x000134E8 File Offset: 0x000116E8
		[Token(Token = "0x60033F4")]
		[Address(RVA = "0x64FC30", Offset = "0x64E630", VA = "0x18064FC30")]
		[CompilerGenerated]
		internal static bool <OnBeforeChallengeStart>g__FillterOnBeforeChallengeStartCondition|90_0(SchedulerNode.Trigger trigger)
		{
			return default(bool);
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x00013500 File Offset: 0x00011700
		[Token(Token = "0x60033F5")]
		[Address(RVA = "0x64FC60", Offset = "0x64E660", VA = "0x18064FC60")]
		[CompilerGenerated]
		internal static bool <OnChallengeFailed>g__FillterOnPhaseChageCondition|91_0(SchedulerNode.Trigger trigger)
		{
			return default(bool);
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x00013518 File Offset: 0x00011718
		[Token(Token = "0x60033F6")]
		[Address(RVA = "0x64FC70", Offset = "0x64E670", VA = "0x18064FC70")]
		[CompilerGenerated]
		internal static bool <OnChallengeSucceed>g__FillterOnPhaseChageCondition|92_0(SchedulerNode.Trigger trigger)
		{
			return default(bool);
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x00013530 File Offset: 0x00011730
		[Token(Token = "0x60033F7")]
		[Address(RVA = "0x64FD10", Offset = "0x64E710", VA = "0x18064FD10")]
		[CompilerGenerated]
		internal static bool <OnPlayerLevelUp>g__FillterOnLevelUpCondition|93_0(SchedulerNode.Trigger trigger)
		{
			return default(bool);
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x00013548 File Offset: 0x00011748
		[Token(Token = "0x60033F8")]
		[Address(RVA = "0x64FD80", Offset = "0x64E780", VA = "0x18064FD80")]
		[CompilerGenerated]
		internal static bool <OnWorkEnd>g__FillterOnWorkEndCondition|94_0(SchedulerNode.Trigger trigger)
		{
			return default(bool);
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x00013560 File Offset: 0x00011760
		[Token(Token = "0x60033F9")]
		[Address(RVA = "0x64FC80", Offset = "0x64E680", VA = "0x18064FC80")]
		[CompilerGenerated]
		internal static bool <OnDayEnd>g__FillterOnDayEndCondition|97_0(SchedulerNode.Trigger trigger)
		{
			return default(bool);
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x00013578 File Offset: 0x00011778
		[Token(Token = "0x60033FA")]
		[Address(RVA = "0x64FC10", Offset = "0x64E610", VA = "0x18064FC10")]
		[CompilerGenerated]
		internal static bool <OnAfterDayEnd>g__FillterOnDayEndCondition|98_0(SchedulerNode.Trigger trigger)
		{
			return default(bool);
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x00013590 File Offset: 0x00011790
		[Token(Token = "0x60033FB")]
		[Address(RVA = "0x64FC20", Offset = "0x64E620", VA = "0x18064FC20")]
		[CompilerGenerated]
		internal static bool <OnAfterIzakayaSelectionOpen>g__FillterOnDayEndCondition|99_0(SchedulerNode.Trigger trigger)
		{
			return default(bool);
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FC")]
		[Address(RVA = "0x64F350", Offset = "0x64DD50", VA = "0x18064F350")]
		[CompilerGenerated]
		internal static void <ExecuteQueue>g__ExecuteNext|153_0()
		{
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60033FD")]
		[Address(RVA = "0x64F250", Offset = "0x64DC50", VA = "0x18064F250")]
		[CompilerGenerated]
		internal static void <AddReimuPositiveSpellToWorkScene>g__ReimuProtection|160_0(Action onFinish)
		{
		}

		// Token: 0x04002D26 RID: 11558
		[Token(Token = "0x4002D26")]
		public const string NON_EXISTENT_CHARACTER = "Null_Character";

		// Token: 0x04002D27 RID: 11559
		[Token(Token = "0x4002D27")]
		public const int MAX_FINISHED_MISSION_RECORD_COUNT = 100;

		// Token: 0x04002D28 RID: 11560
		[Token(Token = "0x4002D28")]
		public const int MAX_FINISHED_EVENT_RECORD_COUNT = 20;

		// Token: 0x04002D29 RID: 11561
		[Token(Token = "0x4002D29")]
		public const int MAX_NEW_HISTORY_RECORD_COUNT = 100;

		// Token: 0x04002D2A RID: 11562
		[Token(Token = "0x4002D2A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<string> OnMissionStart;

		// Token: 0x04002D2B RID: 11563
		[Token(Token = "0x4002D2B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<string> OnMissionFinish;

		// Token: 0x04002D31 RID: 11569
		[Token(Token = "0x4002D31")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly Dictionary<int, List<string>> scheduledEvents;

		// Token: 0x04002D32 RID: 11570
		[Token(Token = "0x4002D32")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly Dictionary<int, List<string>> scheduledNews;

		// Token: 0x04002D33 RID: 11571
		[Token(Token = "0x4002D33")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly Dictionary<int, List<KeyValuePair<string, RunTimeScheduler.HistoryNewsData.ReplaceContent[]>>> scheduledNewsReplaceContents;

		// Token: 0x04002D34 RID: 11572
		[Token(Token = "0x4002D34")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly Dictionary<int, List<RunTimeScheduler.TrackedMissionData>> trackingMissions;

		// Token: 0x04002D35 RID: 11573
		[Token(Token = "0x4002D35")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly HashSet<RunTimeScheduler.TrackedMissionData> trackingMissionBuffer;

		// Token: 0x04002D36 RID: 11574
		[Token(Token = "0x4002D36")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly List<string> finishedEvents;

		// Token: 0x04002D37 RID: 11575
		[Token(Token = "0x4002D37")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly List<string> finishedMissions;

		// Token: 0x04002D38 RID: 11576
		[Token(Token = "0x4002D38")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static readonly Dictionary<KeyValuePair<SchedulerNode.Reward.ObjectType, int>, float> registeredObjectPriceModifier;

		// Token: 0x04002D39 RID: 11577
		[Token(Token = "0x4002D39")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static readonly List<RunTimeScheduler.HistoryNewsData> newsData;

		// Token: 0x04002D3A RID: 11578
		[Token(Token = "0x4002D3A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static string lastMissionName;

		// Token: 0x04002D3B RID: 11579
		[Token(Token = "0x4002D3B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static RunTimeScheduler.HistoryNewsData[] bufferedDailyNewsData;

		// Token: 0x04002D3C RID: 11580
		[Token(Token = "0x4002D3C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static readonly Queue<Action<Action>> executionHandles;

		// Token: 0x04002D3D RID: 11581
		[Token(Token = "0x4002D3D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static bool isExecuting;

		// Token: 0x0200083D RID: 2109
		[Token(Token = "0x200083D")]
		public enum MissionStatus
		{
			// Token: 0x04002D41 RID: 11585
			[Token(Token = "0x4002D41")]
			Tracking,
			// Token: 0x04002D42 RID: 11586
			[Token(Token = "0x4002D42")]
			Fulfilled,
			// Token: 0x04002D43 RID: 11587
			[Token(Token = "0x4002D43")]
			Finished
		}

		// Token: 0x0200083E RID: 2110
		[Token(Token = "0x200083E")]
		public enum GamePhase
		{
			// Token: 0x04002D45 RID: 11589
			[Token(Token = "0x4002D45")]
			[InspectorName("白天场景")]
			Day,
			// Token: 0x04002D46 RID: 11590
			[Token(Token = "0x4002D46")]
			[InspectorName("白天场景，但是可用行动点数耗尽，开启白天时间结束对话之前")]
			DayTimeEnd,
			// Token: 0x04002D47 RID: 11591
			[Token(Token = "0x4002D47")]
			[InspectorName("白天场景，进入店面准备场景之前")]
			DayToPreperation,
			// Token: 0x04002D48 RID: 11592
			[Token(Token = "0x4002D48")]
			[InspectorName("店面准备场景，开启店面准备界面之前")]
			Preperation,
			// Token: 0x04002D49 RID: 11593
			[Token(Token = "0x4002D49")]
			[InspectorName("店面准备场景，关闭店面准备界面之后")]
			PreperationToWork,
			// Token: 0x04002D4A RID: 11594
			[Token(Token = "0x4002D4A")]
			[InspectorName("工作场景，在工作开始前事件触发之前")]
			BeforeWorkStart,
			// Token: 0x04002D4B RID: 11595
			[Token(Token = "0x4002D4B")]
			[InspectorName("工作场景")]
			Work,
			// Token: 0x04002D4C RID: 11596
			[Token(Token = "0x4002D4C")]
			[InspectorName("工作场景，在工作结束前事件触发之前")]
			WorkEnd,
			// Token: 0x04002D4D RID: 11597
			[Token(Token = "0x4002D4D")]
			[InspectorName("工作场景，进入结算场景之前")]
			WorkToResult,
			// Token: 0x04002D4E RID: 11598
			[Token(Token = "0x4002D4E")]
			[InspectorName("结算场景，开启结算界面之前")]
			Result,
			// Token: 0x04002D4F RID: 11599
			[Token(Token = "0x4002D4F")]
			[InspectorName("结算场景，进入白天场景之前")]
			ResultToDay,
			// Token: 0x04002D50 RID: 11600
			[Token(Token = "0x4002D50")]
			[InspectorName("工作场景，在挑战开始前之前")]
			BeforeChallengeStart,
			// Token: 0x04002D51 RID: 11601
			[Token(Token = "0x4002D51")]
			[InspectorName("工作场景，挑战时")]
			Challenge,
			// Token: 0x04002D52 RID: 11602
			[Token(Token = "0x4002D52")]
			[InspectorName("工作场景，挑战结束前")]
			BeforeChallengeEnd,
			// Token: 0x04002D53 RID: 11603
			[Token(Token = "0x4002D53")]
			[InspectorName("工作场景，未使用")]
			YuyukoStageChange,
			// Token: 0x04002D54 RID: 11604
			[Token(Token = "0x4002D54")]
			[InspectorName("工作场景，响子的稀客教程")]
			KyoukoTutorial,
			// Token: 0x04002D55 RID: 11605
			[Token(Token = "0x4002D55")]
			[InspectorName("工作场景，响子的稀客教程结束时")]
			KyoukoTutorialEnd
		}

		// Token: 0x0200083F RID: 2111
		[Token(Token = "0x200083F")]
		public enum MissionDataFillterType
		{
			// Token: 0x04002D57 RID: 11607
			[Token(Token = "0x4002D57")]
			Tracking,
			// Token: 0x04002D58 RID: 11608
			[Token(Token = "0x4002D58")]
			Main,
			// Token: 0x04002D59 RID: 11609
			[Token(Token = "0x4002D59")]
			Side,
			// Token: 0x04002D5A RID: 11610
			[Token(Token = "0x4002D5A")]
			Kisuna,
			// Token: 0x04002D5B RID: 11611
			[Token(Token = "0x4002D5B")]
			All
		}

		// Token: 0x02000840 RID: 2112
		[Token(Token = "0x2000840")]
		public enum EventExecutionValidationMethod
		{
			// Token: 0x04002D5D RID: 11613
			[Token(Token = "0x4002D5D")]
			Any,
			// Token: 0x04002D5E RID: 11614
			[Token(Token = "0x4002D5E")]
			TimelineOnly
		}

		// Token: 0x02000841 RID: 2113
		[Token(Token = "0x2000841")]
		private enum TimeValidationMethod
		{
			// Token: 0x04002D60 RID: 11616
			[Token(Token = "0x4002D60")]
			UnTimed,
			// Token: 0x04002D61 RID: 11617
			[Token(Token = "0x4002D61")]
			Today,
			// Token: 0x04002D62 RID: 11618
			[Token(Token = "0x4002D62")]
			Both
		}

		// Token: 0x02000842 RID: 2114
		[Token(Token = "0x2000842")]
		[Serializable]
		public class TrackedMissionData : IDeepClonable<RunTimeScheduler.TrackedMissionData>
		{
			// Token: 0x060033FE RID: 13310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60033FE")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			public TrackedMissionData()
			{
			}

			// Token: 0x060033FF RID: 13311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60033FF")]
			[Address(RVA = "0x6742A0", Offset = "0x672CA0", VA = "0x1806742A0")]
			public TrackedMissionData(string missionLabel)
			{
			}

			// Token: 0x06003400 RID: 13312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003400")]
			[Address(RVA = "0x674160", Offset = "0x672B60", VA = "0x180674160")]
			public TrackedMissionData(MissionNode missionNode)
			{
			}

			// Token: 0x170006EA RID: 1770
			// (get) Token: 0x06003401 RID: 13313 RVA: 0x000135A8 File Offset: 0x000117A8
			[Token(Token = "0x170006EA")]
			[JsonIgnore]
			public bool HasFulfilled
			{
				[Token(Token = "0x6003401")]
				[Address(RVA = "0x674370", Offset = "0x672D70", VA = "0x180674370")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06003402 RID: 13314 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003402")]
			[Address(RVA = "0x673380", Offset = "0x671D80", VA = "0x180673380")]
			public MissionNode GetMissionReference()
			{
				return null;
			}

			// Token: 0x06003403 RID: 13315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003403")]
			[Address(RVA = "0x673390", Offset = "0x671D90", VA = "0x180673390")]
			private void InitializeConditionFinishData(int missionConditionCount)
			{
			}

			// Token: 0x06003404 RID: 13316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003404")]
			[Address(RVA = "0x6735C0", Offset = "0x671FC0", VA = "0x1806735C0")]
			public void UpdateFinishStates()
			{
			}

			// Token: 0x06003405 RID: 13317 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003405")]
			[Address(RVA = "0x6732A0", Offset = "0x671CA0", VA = "0x1806732A0", Slot = "4")]
			public RunTimeScheduler.TrackedMissionData Clone()
			{
				return null;
			}

			// Token: 0x06003406 RID: 13318 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003406")]
			[Address(RVA = "0x6734C0", Offset = "0x671EC0", VA = "0x1806734C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x04002D63 RID: 11619
			[Token(Token = "0x4002D63")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string missionLabel;

			// Token: 0x04002D64 RID: 11620
			[Token(Token = "0x4002D64")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<bool> conditionFinishStates;

			// Token: 0x04002D65 RID: 11621
			[Token(Token = "0x4002D65")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<int>[] conditionData;
		}

		// Token: 0x02000845 RID: 2117
		[Token(Token = "0x2000845")]
		[Serializable]
		public struct HistoryNewsData
		{
			// Token: 0x06003411 RID: 13329 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003411")]
			[Address(RVA = "0x6655F0", Offset = "0x663FF0", VA = "0x1806655F0")]
			public HistoryNewsData(int newsVisualType, GameDate newsDate, string newsLabel, [Optional] RunTimeScheduler.HistoryNewsData.ReplaceContent[] replaceContents)
			{
			}

			// Token: 0x06003412 RID: 13330 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003412")]
			[Address(RVA = "0x665230", Offset = "0x663C30", VA = "0x180665230")]
			public LanguageBase GetNewsLanguage()
			{
				return null;
			}

			// Token: 0x06003413 RID: 13331 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003413")]
			[Address(RVA = "0x6654F0", Offset = "0x663EF0", VA = "0x1806654F0")]
			private static string GetReplaceText(in RunTimeScheduler.HistoryNewsData.ReplaceContent replaceContent)
			{
				return null;
			}

			// Token: 0x04002D6C RID: 11628
			[Token(Token = "0x4002D6C")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int newsVisualType;

			// Token: 0x04002D6D RID: 11629
			[Token(Token = "0x4002D6D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string newsLabel;

			// Token: 0x04002D6E RID: 11630
			[Token(Token = "0x4002D6E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameDate newsDate;

			// Token: 0x04002D6F RID: 11631
			[Token(Token = "0x4002D6F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RunTimeScheduler.HistoryNewsData.ReplaceContent[] replaceContents;

			// Token: 0x02000846 RID: 2118
			[Token(Token = "0x2000846")]
			public enum PlaceholderType : byte
			{
				// Token: 0x04002D71 RID: 11633
				[Token(Token = "0x4002D71")]
				CommonPhrasesLangKey,
				// Token: 0x04002D72 RID: 11634
				[Token(Token = "0x4002D72")]
				SpecialGuestId
			}

			// Token: 0x02000847 RID: 2119
			[Token(Token = "0x2000847")]
			public struct ReplaceContent
			{
				// Token: 0x06003414 RID: 13332 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6003414")]
				[Address(RVA = "0x479230", Offset = "0x477C30", VA = "0x180479230")]
				public ReplaceContent(string text, RunTimeScheduler.HistoryNewsData.PlaceholderType type)
				{
				}

				// Token: 0x04002D73 RID: 11635
				[Token(Token = "0x4002D73")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[JsonProperty]
				[SerializeField]
				public string Text;

				// Token: 0x04002D74 RID: 11636
				[Token(Token = "0x4002D74")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[JsonProperty]
				[SerializeField]
				public RunTimeScheduler.HistoryNewsData.PlaceholderType Type;
			}
		}

		// Token: 0x02000848 RID: 2120
		[Token(Token = "0x2000848")]
		[Serializable]
		public struct CGPicture
		{
			// Token: 0x04002D75 RID: 11637
			[Token(Token = "0x4002D75")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string CGLabel;

			// Token: 0x04002D76 RID: 11638
			[Token(Token = "0x4002D76")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			public List<RunTimeScheduler.CGPicture.MultiLanguageCGPic> differentialPics;

			// Token: 0x02000849 RID: 2121
			[Token(Token = "0x2000849")]
			[Serializable]
			public class MultiLanguageCGPic
			{
				// Token: 0x170006EB RID: 1771
				// (get) Token: 0x06003415 RID: 13333 RVA: 0x00013650 File Offset: 0x00011850
				[Token(Token = "0x170006EB")]
				public bool Legacy
				{
					[Token(Token = "0x6003415")]
					[Address(RVA = "0x531230", Offset = "0x52FC30", VA = "0x180531230")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x170006EC RID: 1772
				// (get) Token: 0x06003416 RID: 13334 RVA: 0x00013668 File Offset: 0x00011868
				[Token(Token = "0x170006EC")]
				public bool Unused
				{
					[Token(Token = "0x6003416")]
					[Address(RVA = "0x6658D0", Offset = "0x6642D0", VA = "0x1806658D0")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x06003417 RID: 13335 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6003417")]
				[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
				public MultiLanguageCGPic()
				{
				}

				// Token: 0x04002D77 RID: 11639
				[Token(Token = "0x4002D77")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public AssetReference cnCGReference;

				// Token: 0x04002D78 RID: 11640
				[Token(Token = "0x4002D78")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public AssetReference enCGReference;

				// Token: 0x04002D79 RID: 11641
				[Token(Token = "0x4002D79")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public AssetReference jpCGReference;

				// Token: 0x04002D7A RID: 11642
				[Token(Token = "0x4002D7A")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public AssetReference koCGReference;

				// Token: 0x04002D7B RID: 11643
				[Token(Token = "0x4002D7B")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public AssetReference cntCGReference;

				// Token: 0x04002D7C RID: 11644
				[Token(Token = "0x4002D7C")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				[SerializeField]
				private bool m_Legacy;

				// Token: 0x04002D7D RID: 11645
				[Token(Token = "0x4002D7D")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x39")]
				[SerializeField]
				private bool m_Unused;
			}
		}
	}
}
