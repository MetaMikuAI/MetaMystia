using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02001003 RID: 4099
	[Token(Token = "0x2001003")]
	public class COM_ACharacter_Move_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F28 RID: 24360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F28")]
		[Address(RVA = "0x8BB710", Offset = "0x8BA110", VA = "0x1808BB710", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F29 RID: 24361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F29")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ACharacter_Move_Behaviour()
		{
		}

		// Token: 0x04005822 RID: 22562
		[Token(Token = "0x4005822")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		// Token: 0x04005823 RID: 22563
		[Token(Token = "0x4005823")]
		[FieldOffset(Offset = "0x18")]
		public bool shouldWaitForFinish;

		// Token: 0x04005824 RID: 22564
		[Token(Token = "0x4005824")]
		[FieldOffset(Offset = "0x1C")]
		public float speedMultiplier;

		// Token: 0x04005825 RID: 22565
		[Token(Token = "0x4005825")]
		[FieldOffset(Offset = "0x20")]
		public Vector2[] wayPoints;

		// Token: 0x04005826 RID: 22566
		[Token(Token = "0x4005826")]
		[FieldOffset(Offset = "0x28")]
		public bool noAnimation;
	}
}
