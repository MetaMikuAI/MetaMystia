using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x0200013A RID: 314
	[Token(Token = "0x200013A")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentCriticalPay", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentCriticalPay", order = 30)]
	public class DLC5_RogueLikeCardPersistentCriticalPay : RogueLikeCardPersistent
	{
		// Token: 0x0600079B RID: 1947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x828A00", Offset = "0x827400", VA = "0x180828A00", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x828700", Offset = "0x827100", VA = "0x180828700", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x828960", Offset = "0x827360", VA = "0x180828960", Slot = "13")]
		public override string OverrideBuffDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x6DEC40", Offset = "0x6DD640", VA = "0x1806DEC40", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentCriticalPay()
		{
		}

		// Token: 0x0400070A RID: 1802
		[Token(Token = "0x400070A")]
		[FieldOffset(Offset = "0x40")]
		public float criticalRate;

		// Token: 0x0400070B RID: 1803
		[Token(Token = "0x400070B")]
		[FieldOffset(Offset = "0x44")]
		public float extraCrticalDamage;
	}
}
