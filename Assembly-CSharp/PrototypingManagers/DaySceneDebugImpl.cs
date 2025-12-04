using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common;
using DayScene.Input;
using DayScene.UI;
using DEYU.UnityWebDebugBridge;
using Il2CppDummyDll;
using UnityEngine;

namespace PrototypingManagers
{
	// Token: 0x020000F1 RID: 241
	[Token(Token = "0x20000F1")]
	[WebDebugHeader("白天")]
	public static class DaySceneDebugImpl
	{
		// Token: 0x0600051E RID: 1310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x6E4B50", Offset = "0x6E3550", VA = "0x1806E4B50")]
		public static void RegisterMethod()
		{
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x6E68C0", Offset = "0x6E52C0", VA = "0x1806E68C0")]
		public static void UnRegisterMethod()
		{
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x6E4760", Offset = "0x6E3160", VA = "0x1806E4760")]
		[WebDebug("移动角色位置")]
		public static void MoveCharacter([DataSource("GetAllCharacterMapping", null)] string characterLabel, [DataSource("GetAllMapMapping", null)] string mapLabel, Vector2 position, DayScenePlayerInputGenerator.CharacterRotation rotation)
		{
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x6E4D50", Offset = "0x6E3750", VA = "0x1806E4D50")]
		[WebDebug("重置角色位置")]
		public static void ReturnCharacter([DataSource("GetAllCharacterMapping", null)] string characterLabel)
		{
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x6E1A50", Offset = "0x6E0450", VA = "0x1806E1A50")]
		[WebDebug("增加羁绊等级经验值")]
		public static void AddKizunaLevelExp([DataSource("GetAllSpecialCharacterMapping", null)] string characterLabel, int levelExp)
		{
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x6E6BB0", Offset = "0x6E55B0", VA = "0x1806E6BB0")]
		[WebDebug("提升羁绊等级")]
		public static void UpgradeKizunaLevel([DataSource("GetAllSpecialCharacterMapping", null)] string characterLabel)
		{
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x6E4EA0", Offset = "0x6E38A0", VA = "0x1806E4EA0")]
		[WebDebug("设置物体可见性")]
		public static void SetEntityActive(string entityName, bool active)
		{
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x6E4D60", Offset = "0x6E3760", VA = "0x1806E4D60")]
		[WebDebug("计划事件")]
		public static void ScheduleEvent([DataSource("GetAllEventMapping", null)] string eventLabel)
		{
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x6E4DB0", Offset = "0x6E37B0", VA = "0x1806E4DB0")]
		[WebDebug("计划新闻")]
		public static void ScheduleNews([DataSource("GetAllNewsMapping", null)] string newsLabel)
		{
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x6E6260", Offset = "0x6E4C60", VA = "0x1806E6260")]
		[WebDebug("开始任务")]
		public static void StartMission([DataSource("GetAllMissionMapping", null)] string missionLabel)
		{
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x6E1F30", Offset = "0x6E0930", VA = "0x1806E1F30")]
		[WebDebug("完成事件或任务")]
		public static void FinishNode([DataSource("GetAllEventAndMissionMapping", null)] string nodeLabel)
		{
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x6E6C10", Offset = "0x6E5610", VA = "0x1806E6C10")]
		[WebDebug("消耗时间")]
		public static void WarpHours(int hour)
		{
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x6E6C00", Offset = "0x6E5600", VA = "0x1806E6C00")]
		[WebDebug("消耗动作")]
		public static void WarpActions(int count)
		{
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x6E22B0", Offset = "0x6E0CB0", VA = "0x1806E22B0")]
		[WebDebug("获得所有衣服")]
		public static void GetAllClothes()
		{
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x6E3270", Offset = "0x6E1C70", VA = "0x1806E3270")]
		[WebDebug("获得所有CD唱片")]
		public static void GetAllRecords()
		{
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x6E4140", Offset = "0x6E2B40", VA = "0x1806E4140")]
		[WebDebug("进入制作人员名单场景 - Core")]
		public static void GotoStaffSceneCore()
		{
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x6E4640", Offset = "0x6E3040", VA = "0x1806E4640")]
		[WebDebug("进入制作人员名单场景 - Core True")]
		public static void GotoStaffSceneTrue()
		{
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x6E4150", Offset = "0x6E2B50", VA = "0x1806E4150")]
		[WebDebug("进入制作人员名单场景 - DLC1")]
		public static void GotoStaffSceneDLC1()
		{
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x6E4160", Offset = "0x6E2B60", VA = "0x1806E4160")]
		[WebDebug("进入制作人员名单场景 - DLC2")]
		public static void GotoStaffSceneDLC2()
		{
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x6E4170", Offset = "0x6E2B70", VA = "0x1806E4170")]
		[WebDebug("进入制作人员名单场景 - DLC3")]
		public static void GotoStaffSceneDLC3()
		{
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x6E4180", Offset = "0x6E2B80", VA = "0x1806E4180")]
		[WebDebug("进入制作人员名单场景 - DLC4")]
		public static void GotoStaffSceneDLC4()
		{
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x6E4190", Offset = "0x6E2B90", VA = "0x1806E4190")]
		[WebDebug("进入制作人员名单场景 - DLC5")]
		public static void GotoStaffSceneDLC5()
		{
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x6E41A0", Offset = "0x6E2BA0", VA = "0x1806E41A0")]
		private static void GotoStaffSceneImpl(SceneDirector.StaffScenePlayBackIndicator scenePlayBackIndicator)
		{
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x6E4650", Offset = "0x6E3050", VA = "0x1806E4650")]
		[WebDebug("博丽神社钱箱塞钱")]
		public static void HakureiMoneyBoxDonate(int money)
		{
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x6E28D0", Offset = "0x6E12D0", VA = "0x1806E28D0")]
		[WebDebug("获得全部钓鱼佬战利品")]
		public static void GetAllFishingTrophy()
		{
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x6E4FD0", Offset = "0x6E39D0", VA = "0x1806E4FD0")]
		[WebDebug("设置玩家碰撞状态")]
		public static void SetPlayerColliderActive(bool active)
		{
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x6E3EB0", Offset = "0x6E28B0", VA = "0x1806E3EB0")]
		[WebDebug("获得测试素材")]
		public static void GetTestResources()
		{
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x6E3670", Offset = "0x6E2070", VA = "0x1806E3670")]
		[WebDebug("获得最大素材")]
		public static void GetMaxResources()
		{
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x6E36D0", Offset = "0x6E20D0", VA = "0x1806E36D0")]
		[WebDebug("获得随机素材")]
		public static void GetRandomResources()
		{
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x6E3680", Offset = "0x6E2080", VA = "0x1806E3680")]
		[WebDebug("获得金钱")]
		public static void GetMoney(int money)
		{
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x6E2080", Offset = "0x6E0A80", VA = "0x1806E2080")]
		[WebDebug("获得所有徽章")]
		public static void GetAllBadges()
		{
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x6E3590", Offset = "0x6E1F90", VA = "0x1806E3590")]
		[WebDebug("获得并使用所有装饰品")]
		public static void GetAndUseAllDecorations()
		{
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x6E1AB0", Offset = "0x6E04B0", VA = "0x1806E1AB0")]
		[WebDebug("获得灵梦的保护符卡")]
		public static void AddReimuPossitiveSpellToWorkScene()
		{
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x6E3E60", Offset = "0x6E2860", VA = "0x1806E3E60")]
		[WebDebug("获得银色青蛙硬币")]
		public static void GetSilverFrogCoin(int count)
		{
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x6E5030", Offset = "0x6E3A30", VA = "0x1806E5030")]
		[WebDebug("设置玩家输入状态")]
		public static void SetPlayerInputActive(bool active)
		{
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x6E6AD0", Offset = "0x6E54D0", VA = "0x1806E6AD0")]
		[WebDebug("解锁稀客和地图")]
		public static void UnlockSpecialGuestsAndMaps()
		{
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x6E50A0", Offset = "0x6E3AA0", VA = "0x1806E50A0")]
		[WebDebug("开始所有任务")]
		public static void StartAllMissions()
		{
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x6E4BE0", Offset = "0x6E35E0", VA = "0x1806E4BE0")]
		[WebDebug("采集点冷却时间清零")]
		public static void ResetCollectableCoolDown()
		{
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x6E3120", Offset = "0x6E1B20", VA = "0x1806E3120")]
		[WebDebug("获得所有伙伴")]
		public static void GetAllPartners()
		{
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x6E1CD0", Offset = "0x6E06D0", VA = "0x1806E1CD0")]
		[WebDebug("完成所有事件和任务")]
		public static void FinishAllEventsAndMissions()
		{
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x6E4A90", Offset = "0x6E3490", VA = "0x1806E4A90")]
		[WebDebug("刷新采集点")]
		public static void RefreshCollectable()
		{
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x6E4AF0", Offset = "0x6E34F0", VA = "0x1806E4AF0")]
		[WebDebug("刷新NPC")]
		public static void RefreshNPC()
		{
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x6E3F40", Offset = "0x6E2940", VA = "0x1806E3F40")]
		[WebDebug("移动到香霖堂")]
		public static void GotoKourindou()
		{
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x6E1AF0", Offset = "0x6E04F0", VA = "0x1806E1AF0")]
		[WebDebug("香霖堂补货")]
		public static void AddToKourindoStaticMerchandise()
		{
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x6E1F80", Offset = "0x6E0980", VA = "0x1806E1F80")]
		[WebDebug("全羁绊满级")]
		public static void FullUpgradeAllKizunaLevel()
		{
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x6E46A0", Offset = "0x6E30A0", VA = "0x1806E46A0")]
		[WebDebug("邀请奸商因幡帝做客")]
		public static void InviteProfiteerTewi()
		{
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x6E6950", Offset = "0x6E5350", VA = "0x1806E6950")]
		[WebDebug("解锁全地区音游包")]
		public static void UnlockAllMusicChapters()
		{
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x6E47A0", Offset = "0x6E31A0", VA = "0x1806E47A0")]
		[WebDebug("快进到明天")]
		public static void NextDay()
		{
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x6E4E00", Offset = "0x6E3800", VA = "0x1806E4E00")]
		[WebDebug("设置天数")]
		public static void SetDays(int day)
		{
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x6E1960", Offset = "0x6E0360", VA = "0x1806E1960")]
		[WebDebug("增加天数")]
		public static void AddDays(int day)
		{
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x6E1CB0", Offset = "0x6E06B0", VA = "0x1806E1CB0")]
		[WebDebug("清空食材")]
		public static void ClearAllIngredients()
		{
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x6E1CA0", Offset = "0x6E06A0", VA = "0x1806E1CA0")]
		[WebDebug("清空酒水")]
		public static void ClearAllBeverages()
		{
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x6E1CC0", Offset = "0x6E06C0", VA = "0x1806E1CC0")]
		[WebDebug("清空小道具")]
		public static void ClearAllItems()
		{
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x6E1A00", Offset = "0x6E0400", VA = "0x1806E1A00")]
		[WebDebug("添加经验值")]
		public static void AddExp(int exp)
		{
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x6E4F40", Offset = "0x6E3940", VA = "0x1806E4F40")]
		[WebDebug("设置自由伙伴模式开启状态")]
		public static void SetMultiPartnerModeActive(bool active)
		{
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x6E4EB0", Offset = "0x6E38B0", VA = "0x1806E4EB0")]
		[WebDebug("设置伙伴数量")]
		public static void SetMaxPartnerCount(int count)
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x6E54A0", Offset = "0x6E3EA0", VA = "0x1806E54A0")]
		[WebDebug("进入白玉楼挑战I")]
		public static void StartHakugyokurouChallengeLv1()
		{
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x6E5500", Offset = "0x6E3F00", VA = "0x1806E5500")]
		[WebDebug("进入白玉楼挑战II")]
		public static void StartHakugyokurouChallengeLv2()
		{
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x6E5440", Offset = "0x6E3E40", VA = "0x1806E5440")]
		[WebDebug("进入白玉楼决战")]
		public static void StartHakugyokurouChallengeFinal()
		{
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x6E62B0", Offset = "0x6E4CB0", VA = "0x1806E62B0")]
		[WebDebug("进入怪诞料理大赛")]
		public static void StartWeirdCookingChallenge()
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x6E5C20", Offset = "0x6E4620", VA = "0x1806E5C20")]
		[WebDebug("进入博丽大祭音乐挑战赛")]
		public static void StartHakureiFestivalMusicChallenge()
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x6E5560", Offset = "0x6E3F60", VA = "0x1806E5560")]
		[WebDebug("进入博丽大祭料理挑战赛")]
		public static void StartHakureiFestivalCookingChallenge()
		{
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x6E6310", Offset = "0x6E4D10", VA = "0x1806E6310")]
		[WebDebug("传送到指定地图")]
		public static void Transmit([DataSource("GetAllMapMapping", null)] string mapLabel)
		{
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x6E20A0", Offset = "0x6E0AA0", VA = "0x1806E20A0")]
		private static Dictionary<string, object> GetAllCharacterMapping()
		{
			return null;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x6E4790", Offset = "0x6E3190", VA = "0x1806E4790")]
		[WebDebug("开启RogueLike")]
		public static void MoveToRogueLike()
		{
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x6E47F0", Offset = "0x6E31F0", VA = "0x1806E47F0")]
		[WebDebug("开启造物者的盒子")]
		public static void OpenCreatorsBoxPanel()
		{
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x6E4A00", Offset = "0x6E3400", VA = "0x1806E4A00")]
		[WebDebug("开启恒久之盒(已解锁1个)")]
		public static void OpenInfiniteSelectorPanel1()
		{
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x6E4A30", Offset = "0x6E3430", VA = "0x1806E4A30")]
		[WebDebug("开启恒久之盒(已解锁2个)")]
		public static void OpenInfiniteSelectorPanel2()
		{
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x6E4A60", Offset = "0x6E3460", VA = "0x1806E4A60")]
		[WebDebug("开启恒久之盒(已解锁3个)")]
		public static void OpenInfiniteSelectorPanel3()
		{
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x6E3290", Offset = "0x6E1C90", VA = "0x1806E3290")]
		private static Dictionary<string, object> GetAllSpecialCharacterMapping()
		{
			return null;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x6E2A00", Offset = "0x6E1400", VA = "0x1806E2A00")]
		private static Dictionary<string, object> GetAllMapMapping()
		{
			return null;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x6E25D0", Offset = "0x6E0FD0", VA = "0x1806E25D0")]
		private static Dictionary<string, object> GetAllEventMapping()
		{
			return null;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x6E2C10", Offset = "0x6E1610", VA = "0x1806E2C10")]
		private static Dictionary<string, object> GetAllMissionMapping()
		{
			return null;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x6E22D0", Offset = "0x6E0CD0", VA = "0x1806E22D0")]
		private static Dictionary<string, object> GetAllEventAndMissionMapping()
		{
			return null;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x6E2F10", Offset = "0x6E1910", VA = "0x1806E2F10")]
		private static Dictionary<string, object> GetAllNewsMapping()
		{
			return null;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x6E3740", Offset = "0x6E2140", VA = "0x1806E3740")]
		private static void GetResources(bool max = false)
		{
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x6E67A0", Offset = "0x6E51A0", VA = "0x1806E67A0")]
		[CompilerGenerated]
		internal static void <StartHakureiFestivalMusicChallenge>g__AfterSelect|62_2(int[] selectedId)
		{
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x6E6680", Offset = "0x6E5080", VA = "0x1806E6680")]
		[CompilerGenerated]
		internal static void <StartHakureiFestivalCookingChallenge>g__AfterSelect|63_2(int[] selectedId)
		{
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x6E6490", Offset = "0x6E4E90", VA = "0x1806E6490")]
		[CompilerGenerated]
		internal static void <OpenCreatorsBoxPanel>g__OpenOrClose|67_0(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x6E6380", Offset = "0x6E4D80", VA = "0x1806E6380")]
		[CompilerGenerated]
		internal static void <OpenCreatorsBoxPanel>g__Edit|67_1(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x494410", Offset = "0x492E10", VA = "0x180494410")]
		[CompilerGenerated]
		internal static void <OpenCreatorsBoxPanel>g__Call|67_2(Action action)
		{
		}

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		private const int GIVE_AMOUNT_MAX = 50;

		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		private const int GIVE_AMOUNT_MIN = 20;
	}
}
