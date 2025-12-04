using System;
using System.Collections.Generic;
using DEYU.UnityWebDebugBridge;
using Il2CppDummyDll;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;

namespace PrototypingManagers
{
	// Token: 0x02000108 RID: 264
	[Token(Token = "0x2000108")]
	[WebDebugHeader("夜间")]
	public static class NightSceneDebugImpl
	{
		// Token: 0x060005F7 RID: 1527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x6F2D90", Offset = "0x6F1790", VA = "0x1806F2D90")]
		public static void RegisterMethod()
		{
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x6F43B0", Offset = "0x6F2DB0", VA = "0x1806F43B0")]
		public static void UnRegisterMethod()
		{
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x6F3650", Offset = "0x6F2050", VA = "0x1806F3650")]
		[WebDebug("设置营业收入")]
		public static void SetWorkIncome(int value, EventManager.MathOperation mathOperation)
		{
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x6F3590", Offset = "0x6F1F90", VA = "0x1806F3590")]
		[WebDebug("设置Combo")]
		public static void SetWorkCombo(int value, EventManager.MathOperation mathOperation)
		{
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x6F2A90", Offset = "0x6F1490", VA = "0x1806F2A90")]
		[WebDebug("修改营业时间")]
		public static void ModifyWorkTime(int time)
		{
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x6F3B50", Offset = "0x6F2550", VA = "0x1806F3B50")]
		[WebDebug("补充酒水")]
		public static void SupplementaryBeverages()
		{
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x6F3F10", Offset = "0x6F2910", VA = "0x1806F3F10")]
		[WebDebug("补充食材")]
		public static void SupplementaryIngredients()
		{
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x6F3D30", Offset = "0x6F2730", VA = "0x1806F3D30")]
		[WebDebug("补充料理")]
		public static void SupplementaryFoods()
		{
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x6F4300", Offset = "0x6F2D00", VA = "0x1806F4300")]
		[WebDebug("触发QTEBuff: 随机")]
		public static void TriggerRandomQTEBuff(bool mustTrigger)
		{
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x6F4360", Offset = "0x6F2D60", VA = "0x1806F4360")]
		[WebDebug("触发QTEBuff: 投掷上菜")]
		public static void TriggerThrowServingQTEBuff()
		{
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x6F4230", Offset = "0x6F2C30", VA = "0x1806F4230")]
		[WebDebug("触发QTEBuff: 耐心不减")]
		public static void TriggerPatientQTEBuff()
		{
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x6F4160", Offset = "0x6F2B60", VA = "0x1806F4160")]
		[WebDebug("触发QTEBuff: 立即完食")]
		public static void TriggerFinishEatingImmediatelyQTEBuff()
		{
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x6F34A0", Offset = "0x6F1EA0", VA = "0x1806F34A0")]
		[WebDebug("设置气氛等级覆写状态")]
		public static void SetPassionLevelOverrideActive(bool active)
		{
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x6F2660", Offset = "0x6F1060", VA = "0x1806F2660")]
		[WebDebug("提升气氛等级")]
		public static void IncreasePassionLevel()
		{
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x6F1830", Offset = "0x6F0230", VA = "0x1806F1830")]
		[WebDebug("降低气氛等级")]
		public static void DecreasePassionLevel()
		{
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x6F1650", Offset = "0x6F0050", VA = "0x1806F1650")]
		[WebDebug("清空稀客图鉴数据")]
		public static void ClearSpecialGuestAlbum()
		{
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x6F3780", Offset = "0x6F2180", VA = "0x1806F3780")]
		[WebDebug("生成普客")]
		public static void SpawnNormalGuest()
		{
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x6F38F0", Offset = "0x6F22F0", VA = "0x1806F38F0")]
		[WebDebug("生成稀客")]
		public static void SpawnSpecialGuest()
		{
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x6F36B0", Offset = "0x6F20B0", VA = "0x1806F36B0")]
		[WebDebug("生成指定的普客")]
		public static void SpawnNormalGuest([DataSource("GetAllNormalGuestsMapping", null)] int normalGuestId)
		{
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x6F39C0", Offset = "0x6F23C0", VA = "0x1806F39C0")]
		[WebDebug("生成指定的稀客")]
		public static void SpawnSpecialGuest([DataSource("GetAllSpecialGuestsMapping", null)] int specialGuestId)
		{
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x6F3090", Offset = "0x6F1A90", VA = "0x1806F3090")]
		[WebDebug("所有上座客人付款离开")]
		public static void RepellGuestAndPay()
		{
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x6F3110", Offset = "0x6F1B10", VA = "0x1806F3110")]
		[WebDebug("指定桌号的客人付款离开")]
		public static void RepellGuestAndPay(int deskCode)
		{
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x6F3010", Offset = "0x6F1A10", VA = "0x1806F3010")]
		[WebDebug("指定桌号的客人按心情付款离开")]
		public static void RepellGuestAndPayByMoodValue(int deskCode)
		{
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x6F4280", Offset = "0x6F2C80", VA = "0x1806F4280")]
		[WebDebug("指定桌号的客人触发奖励符卡")]
		public static void TriggerPositiveBuff(int deskCode)
		{
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x6F41B0", Offset = "0x6F2BB0", VA = "0x1806F41B0")]
		[WebDebug("指定桌号的客人触发惩罚符卡")]
		public static void TriggerNegativeBuff(int deskCode)
		{
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x6F2C40", Offset = "0x6F1640", VA = "0x1806F2C40")]
		[WebDebug("排队中的客人耐心耗尽")]
		public static void PatientDeplete(int index)
		{
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x6F2F60", Offset = "0x6F1960", VA = "0x1806F2F60")]
		[WebDebug("移除所有计时Buff")]
		public static void RemoveAllRegisteredTimedBuff()
		{
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x6F2E20", Offset = "0x6F1820", VA = "0x1806F2E20")]
		[WebDebug("注册永久粉评作弊功能")]
		public static void RegisteredCheatedBuff()
		{
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x6F2EB0", Offset = "0x6F18B0", VA = "0x1806F2EB0")]
		[WebDebug("永续热火朝天")]
		public static void RegisteredEternityFever()
		{
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x6F2190", Offset = "0x6F0B90", VA = "0x1806F2190")]
		private static SpecialGuestsController GetSpecialGuestsController(int deskCode)
		{
			return null;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x6F1D50", Offset = "0x6F0750", VA = "0x1806F1D50")]
		private static Dictionary<string, object> GetAllNormalGuestsMapping()
		{
			return null;
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x6F1F70", Offset = "0x6F0970", VA = "0x1806F1F70")]
		private static Dictionary<string, object> GetAllSpecialGuestsMapping()
		{
			return null;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x6F1B50", Offset = "0x6F0550", VA = "0x1806F1B50")]
		private static Dictionary<string, object> GetAllFoodsMapping()
		{
			return null;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x6F14D0", Offset = "0x6EFED0", VA = "0x1806F14D0")]
		[WebDebug("获得营业小费")]
		private static void AddWorkTip(int value, EventManager.ServeType serveType)
		{
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x6F3530", Offset = "0x6F1F30", VA = "0x1806F3530")]
		[WebDebug("设置气氛值")]
		private static void SetPassionValue(float value, EventManager.MathOperation mathOperation)
		{
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x6F3280", Offset = "0x6F1C80", VA = "0x1806F3280")]
		[WebDebug("设置连击值")]
		private static void SetComboValue(float value, EventManager.MathOperation mathOperation)
		{
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x6F31C0", Offset = "0x6F1BC0", VA = "0x1806F31C0")]
		[WebDebug("重置连击")]
		private static void ResetCombo()
		{
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x6F35F0", Offset = "0x6F1FF0", VA = "0x1806F35F0")]
		[WebDebug("设置营业经验")]
		private static void SetWorkExp(float value, EventManager.MathOperation mathOperation)
		{
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x6F1430", Offset = "0x6EFE30", VA = "0x1806F1430")]
		[WebDebug("Buff: 持续提升气氛")]
		private static void AddPassionPerTime(float value, float timeInterval, int durationSeconds)
		{
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x6F3350", Offset = "0x6F1D50", VA = "0x1806F3350")]
		[WebDebug("Buff: 制作料理无消耗")]
		private static void SetFreeCook(int durationSeconds)
		{
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x6F26E0", Offset = "0x6F10E0", VA = "0x1806F26E0")]
		[WebDebug("Buff: 锁定当日菜单")]
		private static void LockDailyRecipes(int amount, int durationSeconds)
		{
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x6F1770", Offset = "0x6F0170", VA = "0x1806F1770")]
		[WebDebug("Buff: 料理时间修改(基于Tag)")]
		private static void CookTimeAndOrderRateEditByTag(int foodTag, float cookTimeMultiplier, float additiveContinueProbability, int durationSeconds)
		{
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x6F1690", Offset = "0x6F0090", VA = "0x1806F1690")]
		[WebDebug("Buff: 料理时间修改(基于厨具)")]
		private static void CookTimeAndOrderRateEditByCookerType(float multiplier, float additiveContinueProbability, int durationSeconds)
		{
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x6F1AB0", Offset = "0x6F04B0", VA = "0x1806F1AB0")]
		[WebDebug("Buff: 强制覆写食物")]
		private static void ForcedOverrideFoodProbably(float rate, int durationSeconds, [DataSource("GetAllFoodsMapping", null)] int foodId)
		{
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x6F32E0", Offset = "0x6F1CE0", VA = "0x1806F32E0")]
		[WebDebug("Buff: 制作料理概率无消耗")]
		private static void SetFreeCookRate(float rate)
		{
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x6F44B0", Offset = "0x6F2EB0", VA = "0x1806F44B0")]
		[WebDebug("解锁稀客信息")]
		private static void UnlockInfo(int amount, [DataSource("GetAllSpecialGuestsMapping", null)] int specialGuestId)
		{
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x6F3AE0", Offset = "0x6F24E0", VA = "0x1806F3AE0")]
		[WebDebug("Buff: 玩家眩晕")]
		private static void Stun(int durationSeconds)
		{
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x6F1550", Offset = "0x6EFF50", VA = "0x1806F1550")]
		[WebDebug("Buff: 修改移动速度")]
		private static void ChangeMoveSpeedByBuff(float multiplier, int durationSeconds)
		{
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x6F3440", Offset = "0x6F1E40", VA = "0x1806F3440")]
		[WebDebug("设置伙伴额外收费并无视铃仙")]
		private static void SetPartnerExtraWage(float multiplier)
		{
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x6F2FB0", Offset = "0x6F19B0", VA = "0x1806F2FB0")]
		[WebDebug("移除伙伴额外收费")]
		private static void RemovePartnerExtraWage(float multiplier)
		{
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x6F33C0", Offset = "0x6F1DC0", VA = "0x1806F33C0")]
		[WebDebug("Buff: 闭店时客人不离开")]
		private static void SetGuestNotLeaveWhenIzakayaClose(int durationSeconds, EventManager.BuffType buffType)
		{
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x6F24B0", Offset = "0x6F0EB0", VA = "0x1806F24B0")]
		[WebDebug("Buff: 客人用餐结束获得额外满意度")]
		private static void GuestMoodExtraAddEdit(int mood, int durationSeconds, EventManager.BuffType buffType)
		{
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x6F2B50", Offset = "0x6F1550", VA = "0x1806F2B50")]
		[WebDebug("Buff: 修改客人续单率")]
		private static void OrderCycleRateEdit(float multiplier, int durationSeconds)
		{
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x6F18B0", Offset = "0x6F02B0", VA = "0x1806F18B0")]
		[WebDebug("Buff: 修改客人用餐时间")]
		private static void EatTimeEdit(float multiplier, int durationSeconds)
		{
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x6F2540", Offset = "0x6F0F40", VA = "0x1806F2540")]
		[WebDebug("Buff: 修改客人心情降低速度")]
		private static void GuestPatientEdit_Youmu(float value, float timeInterval, float multiplier, int durationSeconds)
		{
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x6F3860", Offset = "0x6F2260", VA = "0x1806F3860")]
		[WebDebug("Buff: 修改客人刷新率")]
		private static void SpawnRateEdit(float multiplier, int durationSeconds)
		{
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x6F4510", Offset = "0x6F2F10", VA = "0x1806F4510")]
		[WebDebug("Buff: 修改客人刷新率(莉格露奖励符卡)")]
		private static void WriggleSpawnRateEdit(float multiplier, int durationSeconds)
		{
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x6F15E0", Offset = "0x6EFFE0", VA = "0x1806F15E0")]
		[WebDebug("Buff: 修改客人刷新率(橙惩罚符卡)")]
		private static void ChenSpawnRateEdit(float multiplier)
		{
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x6F2AE0", Offset = "0x6F14E0", VA = "0x1806F2AE0")]
		[WebDebug("Buff: 修改客人刷新率(椛椛惩罚符卡)")]
		private static void MomiziSpawnRateEdit(int durationSeconds)
		{
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x6F2440", Offset = "0x6F0E40", VA = "0x1806F2440")]
		[WebDebug("Buff: 立即完食")]
		private static void GuestInstantEvaluate(int durationSeconds)
		{
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x6F23E0", Offset = "0x6F0DE0", VA = "0x1806F23E0")]
		[WebDebug("Buff: 立即完食(幽幽子)")]
		private static void GuestInstantEvaluate_Yuyuko()
		{
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x6F25F0", Offset = "0x6F0FF0", VA = "0x1806F25F0")]
		[WebDebug("Buff: 耐心不减")]
		private static void GuestPatientFreeze(int durationSeconds)
		{
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x6F40F0", Offset = "0x6F2AF0", VA = "0x1806F40F0")]
		[WebDebug("Buff: 投掷上菜")]
		private static void ThrowDeliver(int durationSeconds)
		{
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x6F2BD0", Offset = "0x6F15D0", VA = "0x1806F2BD0")]
		[WebDebug("Buff: 投掷上菜(伙伴)")]
		private static void PartnerThrowDeliver(int durationSeconds)
		{
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x6F1A40", Offset = "0x6F0440", VA = "0x1806F1A40")]
		[WebDebug("Buff: 热火朝天")]
		private static void Fever(int durationSeconds)
		{
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x6F37D0", Offset = "0x6F21D0", VA = "0x1806F37D0")]
		[WebDebug("Buff: 指定时间内生成普客")]
		private static void SpawnNormalGuests(int amount, int durationSeconds)
		{
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x6F3A50", Offset = "0x6F2450", VA = "0x1806F3A50")]
		[WebDebug("Buff: 指定时间内生成目标普客")]
		private static void SpawnTargetNormalGuests(int amount, int durationSeconds, [DataSource("GetAllNormalGuestsMapping", null)] int normalGuestId)
		{
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x6F2830", Offset = "0x6F1230", VA = "0x1806F2830")]
		[WebDebug("Buff: 客人支付小费")]
		private static void MakeGuestsPayTipsNormal(int minAmount, int maxAmount, int timeInterval)
		{
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x6F2760", Offset = "0x6F1160", VA = "0x1806F2760")]
		[WebDebug("Buff: 客人支付小费(华扇)")]
		private static void MakeGuestsPayTipsKasen(int minAmount, int maxAmount, int minTimeInterval, int maxTimeInterval, int durationSeconds)
		{
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x6F4440", Offset = "0x6F2E40", VA = "0x1806F4440")]
		[WebDebug("Buff: 客人只点便宜料理和绿茶")]
		private static void UnambitiousGuests(int durationSeconds)
		{
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x6F19B0", Offset = "0x6F03B0", VA = "0x1806F19B0")]
		[WebDebug("Buff: 额外小费(计时)")]
		private static void ExtraFee(int durationSeconds, float extraFeePercentage)
		{
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x6F1930", Offset = "0x6F0330", VA = "0x1806F1930")]
		[WebDebug("Buff: 额外小费(永久)")]
		private static void ExtraFeeForever(float extraFeePercentage)
		{
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x6F29E0", Offset = "0x6F13E0", VA = "0x1806F29E0")]
		[WebDebug("Buff: 最低评价限制")]
		private static void MinEvalLevelSet(int durationSeconds, int baseEval)
		{
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x6F2930", Offset = "0x6F1330", VA = "0x1806F2930")]
		[WebDebug("Buff: 最高评价限制")]
		private static void MaxEvalLevelSet(int durationSeconds, int maxEval)
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x6F28C0", Offset = "0x6F12C0", VA = "0x1806F28C0")]
		[WebDebug("Buff: 幽幽子惩罚")]
		private static void MaxEvalLevelSet_Yuyuko(int maxEval)
		{
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x6F2D20", Offset = "0x6F1720", VA = "0x1806F2D20")]
		[WebDebug("Buff: 评价全随机")]
		private static void RandomEval(int durationSeconds)
		{
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x6F3210", Offset = "0x6F1C10", VA = "0x1806F3210")]
		[WebDebug("Buff: 评价概率提高到粉")]
		private static void SetBestEvalRate(float rate)
		{
		}

		// Token: 0x0400063B RID: 1595
		[Token(Token = "0x400063B")]
		private const int GIVE_AMOUNT_MIN = 20;

		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x400063C")]
		private const int GIVE_AMOUNT_MAX = 50;
	}
}
