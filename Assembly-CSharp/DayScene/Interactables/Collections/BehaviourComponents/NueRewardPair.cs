using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200053D RID: 1341
	[Token(Token = "0x200053D")]
	[Serializable]
	public struct NueRewardPair
	{
		// Token: 0x06001DC0 RID: 7616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DC0")]
		[Address(RVA = "0x4B9C80", Offset = "0x4B8680", VA = "0x1804B9C80")]
		public NueRewardPair(int level, float probability)
		{
		}

		// Token: 0x04001B70 RID: 7024
		[Token(Token = "0x4001B70")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public int Level;

		// Token: 0x04001B71 RID: 7025
		[Token(Token = "0x4001B71")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		public float Probability;
	}
}
