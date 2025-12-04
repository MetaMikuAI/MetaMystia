using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000519 RID: 1305
	[Token(Token = "0x2000519")]
	[Serializable]
	public struct NarumiJizoDollRewardPair
	{
		// Token: 0x06001D3C RID: 7484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D3C")]
		[Address(RVA = "0x4B2260", Offset = "0x4B0C60", VA = "0x1804B2260")]
		public NarumiJizoDollRewardPair(NarumiJizoDollRewardType type, int level, float probability)
		{
		}

		// Token: 0x04001ADE RID: 6878
		[Token(Token = "0x4001ADE")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public NarumiJizoDollRewardType RewardType;

		// Token: 0x04001ADF RID: 6879
		[Token(Token = "0x4001ADF")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		public int Level;

		// Token: 0x04001AE0 RID: 6880
		[Token(Token = "0x4001AE0")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public float Probability;
	}
}
