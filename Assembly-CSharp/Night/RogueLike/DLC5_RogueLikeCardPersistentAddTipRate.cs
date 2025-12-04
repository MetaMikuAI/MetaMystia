using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;
using UnityEngine.Serialization;

namespace Night.RogueLike
{
	// Token: 0x02000136 RID: 310
	[Token(Token = "0x2000136")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentAddTipRate", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentAddTipRate", order = 3)]
	public class DLC5_RogueLikeCardPersistentAddTipRate : RogueLikeCardPersistent
	{
		// Token: 0x0600078E RID: 1934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x828410", Offset = "0x826E10", VA = "0x180828410", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x8282F0", Offset = "0x826CF0", VA = "0x1808282F0", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x6DEC40", Offset = "0x6DD640", VA = "0x1806DEC40", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentAddTipRate()
		{
		}

		// Token: 0x04000703 RID: 1795
		[Token(Token = "0x4000703")]
		[FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("extraMoveSpeed")]
		public float extraTipRate;
	}
}
