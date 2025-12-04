using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200050C RID: 1292
	[Token(Token = "0x200050C")]
	[Serializable]
	public struct MoriyaShrineRewardPair
	{
		// Token: 0x06001CF0 RID: 7408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CF0")]
		[Address(RVA = "0x4B2260", Offset = "0x4B0C60", VA = "0x1804B2260")]
		public MoriyaShrineRewardPair(MoriyaShrineRewardType type, int rewardCount, float probability)
		{
		}

		// Token: 0x04001AAA RID: 6826
		[Token(Token = "0x4001AAA")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public MoriyaShrineRewardType RewardType;

		// Token: 0x04001AAB RID: 6827
		[Token(Token = "0x4001AAB")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		public int RewardCount;

		// Token: 0x04001AAC RID: 6828
		[Token(Token = "0x4001AAC")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public float Probability;
	}
}
