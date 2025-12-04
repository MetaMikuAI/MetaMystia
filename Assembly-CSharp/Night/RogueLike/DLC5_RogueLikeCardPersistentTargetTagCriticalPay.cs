using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x0200014D RID: 333
	[Token(Token = "0x200014D")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentTargetTagCriticalPay", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentTargetTagCriticalPay", order = 31)]
	public class DLC5_RogueLikeCardPersistentTargetTagCriticalPay : RogueLikeCardPersistent
	{
		// Token: 0x060007F9 RID: 2041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x82BB00", Offset = "0x82A500", VA = "0x18082BB00", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x82B870", Offset = "0x82A270", VA = "0x18082B870", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x82BA60", Offset = "0x82A460", VA = "0x18082BA60", Slot = "13")]
		public override string OverrideBuffDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x82BA40", Offset = "0x82A440", VA = "0x18082BA40", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentTargetTagCriticalPay()
		{
		}

		// Token: 0x0400074A RID: 1866
		[Token(Token = "0x400074A")]
		[FieldOffset(Offset = "0x40")]
		public int targetTag;

		// Token: 0x0400074B RID: 1867
		[Token(Token = "0x400074B")]
		[FieldOffset(Offset = "0x44")]
		public EventManager.BuffType BuffType;

		// Token: 0x0400074C RID: 1868
		[Token(Token = "0x400074C")]
		[FieldOffset(Offset = "0x48")]
		public float extraCrticalDamage;
	}
}
