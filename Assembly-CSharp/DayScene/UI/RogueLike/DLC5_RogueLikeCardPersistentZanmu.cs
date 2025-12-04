using System;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200036B RID: 875
	[Token(Token = "0x200036B")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentZanmu", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentZanmu", order = 204)]
	public class DLC5_RogueLikeCardPersistentZanmu : RogueLikeCardPersistent
	{
		// Token: 0x0600136E RID: 4974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600136E")]
		[Address(RVA = "0x43D1E0", Offset = "0x43BBE0", VA = "0x18043D1E0", Slot = "10")]
		public override void AfterSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600136F")]
		[Address(RVA = "0x43B580", Offset = "0x439F80", VA = "0x18043B580", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001370")]
		[Address(RVA = "0x43D7F0", Offset = "0x43C1F0", VA = "0x18043D7F0", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001371")]
		[Address(RVA = "0x43D7C0", Offset = "0x43C1C0", VA = "0x18043D7C0", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00007578 File Offset: 0x00005778
		[Token(Token = "0x6001372")]
		[Address(RVA = "0x43D710", Offset = "0x43C110", VA = "0x18043D710", Slot = "7")]
		public override bool CheckExtraConditionToShow(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, RogueLikeManager rogueLikeManager)
		{
			return default(bool);
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001373")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DLC5_RogueLikeCardPersistentZanmu()
		{
		}

		// Token: 0x040011BA RID: 4538
		[Token(Token = "0x40011BA")]
		[FieldOffset(Offset = "0x40")]
		public float multiplier;

		// Token: 0x040011BB RID: 4539
		[Token(Token = "0x40011BB")]
		[FieldOffset(Offset = "0x44")]
		public int addCardNum;

		// Token: 0x040011BC RID: 4540
		[Token(Token = "0x40011BC")]
		[FieldOffset(Offset = "0x48")]
		public int addBevNum;
	}
}
