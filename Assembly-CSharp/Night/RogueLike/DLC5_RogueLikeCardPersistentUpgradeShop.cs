using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentUpgradeShop", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentUpgradeShop", order = 0)]
	public class DLC5_RogueLikeCardPersistentUpgradeShop : RogueLikeCardPersistent
	{
		// Token: 0x06000801 RID: 2049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x82BBC0", Offset = "0x82A5C0", VA = "0x18082BBC0", Slot = "12")]
		public override void AfterInitialize(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x00004050 File Offset: 0x00002250
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x82C290", Offset = "0x82AC90", VA = "0x18082C290", Slot = "7")]
		public override bool CheckExtraConditionToShow(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, RogueLikeManager rogueLikeManager)
		{
			return default(bool);
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x82C350", Offset = "0x82AD50", VA = "0x18082C350", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x82C2F0", Offset = "0x82ACF0", VA = "0x18082C2F0", Slot = "6")]
		public override string GetDescriptionInAlbum(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			return null;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x82BF90", Offset = "0x82A990", VA = "0x18082BF90", Slot = "10")]
		public override void AfterSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentUpgradeShop()
		{
		}
	}
}
