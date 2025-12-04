using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x02000138 RID: 312
	[Token(Token = "0x2000138")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentAddWorkSpeed", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentAddWorkSpeed", order = 2)]
	public class DLC5_RogueLikeCardPersistentAddWorkSpeed : RogueLikeCardPersistent
	{
		// Token: 0x06000794 RID: 1940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x828670", Offset = "0x827070", VA = "0x180828670", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x8284A0", Offset = "0x826EA0", VA = "0x1808284A0", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x6DEC40", Offset = "0x6DD640", VA = "0x1806DEC40", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentAddWorkSpeed()
		{
		}

		// Token: 0x04000706 RID: 1798
		[Token(Token = "0x4000706")]
		[FieldOffset(Offset = "0x40")]
		public float extraMoveSpeed;
	}
}
