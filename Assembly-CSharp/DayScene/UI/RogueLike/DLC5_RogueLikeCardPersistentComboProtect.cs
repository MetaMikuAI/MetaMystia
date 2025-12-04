using System;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000357 RID: 855
	[Token(Token = "0x2000357")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentComboProtect", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentComboProtect", order = 104)]
	public class DLC5_RogueLikeCardPersistentComboProtect : RogueLikeCardPersistent
	{
		// Token: 0x06001328 RID: 4904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001328")]
		[Address(RVA = "0x43B0C0", Offset = "0x439AC0", VA = "0x18043B0C0", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001329")]
		[Address(RVA = "0x43B220", Offset = "0x439C20", VA = "0x18043B220", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600132A")]
		[Address(RVA = "0x43B160", Offset = "0x439B60", VA = "0x18043B160", Slot = "13")]
		public override string OverrideBuffDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600132B")]
		[Address(RVA = "0x43B140", Offset = "0x439B40", VA = "0x18043B140", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600132C")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DLC5_RogueLikeCardPersistentComboProtect()
		{
		}

		// Token: 0x04001194 RID: 4500
		[Token(Token = "0x4001194")]
		[FieldOffset(Offset = "0x40")]
		public int comboProtectNum;

		// Token: 0x04001195 RID: 4501
		[Token(Token = "0x4001195")]
		[FieldOffset(Offset = "0x44")]
		public int extraComboNum;
	}
}
