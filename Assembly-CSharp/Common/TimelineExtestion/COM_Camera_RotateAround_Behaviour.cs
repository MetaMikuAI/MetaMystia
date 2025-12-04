using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FF6 RID: 4086
	[Token(Token = "0x2000FF6")]
	public class COM_Camera_RotateAround_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06005F05 RID: 24325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F05")]
		[Address(RVA = "0x8BE510", Offset = "0x8BCF10", VA = "0x1808BE510", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F06 RID: 24326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F06")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_Camera_RotateAround_Behaviour()
		{
		}

		// Token: 0x04005809 RID: 22537
		[Token(Token = "0x4005809")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 startPoint;

		// Token: 0x0400580A RID: 22538
		[Token(Token = "0x400580A")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 pivot;

		// Token: 0x0400580B RID: 22539
		[Token(Token = "0x400580B")]
		[FieldOffset(Offset = "0x20")]
		public float angle;

		// Token: 0x0400580C RID: 22540
		[Token(Token = "0x400580C")]
		[FieldOffset(Offset = "0x24")]
		public float speedMultiplier;

		// Token: 0x0400580D RID: 22541
		[Token(Token = "0x400580D")]
		[FieldOffset(Offset = "0x28")]
		public bool shouldWaitForFinish;
	}
}
