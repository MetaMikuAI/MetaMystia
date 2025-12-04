using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x0200012A RID: 298
	[Token(Token = "0x200012A")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentAddMoveAction", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentAddMoveAction", order = 5)]
	public class DLC5_RogueLikeCardPersistentAddMoveAction : RogueLikeCardPersistent
	{
		// Token: 0x0600074E RID: 1870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x6DF3A0", Offset = "0x6DDDA0", VA = "0x1806DF3A0", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x6DF330", Offset = "0x6DDD30", VA = "0x1806DF330", Slot = "9")]
		public override void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x6DF460", Offset = "0x6DDE60", VA = "0x1806DF460", Slot = "11")]
		public override void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x6DF360", Offset = "0x6DDD60", VA = "0x1806DF360", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentAddMoveAction()
		{
		}

		// Token: 0x040006E5 RID: 1765
		[Token(Token = "0x40006E5")]
		[FieldOffset(Offset = "0x0")]
		public static int MOVE_ACTION_FACTOR;

		// Token: 0x040006E6 RID: 1766
		[Token(Token = "0x40006E6")]
		[FieldOffset(Offset = "0x40")]
		public int addMoveActionNum;
	}
}
