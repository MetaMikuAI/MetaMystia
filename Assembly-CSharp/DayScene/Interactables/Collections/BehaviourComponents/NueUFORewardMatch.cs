using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200053C RID: 1340
	[Token(Token = "0x200053C")]
	[Serializable]
	public struct NueUFORewardMatch
	{
		// Token: 0x04001B6C RID: 7020
		[Token(Token = "0x4001B6C")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public NueUFONeedType needType;

		// Token: 0x04001B6D RID: 7021
		[Token(Token = "0x4001B6D")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		public NueUFORewardType RewardType;

		// Token: 0x04001B6E RID: 7022
		[Token(Token = "0x4001B6E")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public NueRewardPair[] nueRewardPairs;

		// Token: 0x04001B6F RID: 7023
		[Token(Token = "0x4001B6F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public int nueRewardCount;
	}
}
