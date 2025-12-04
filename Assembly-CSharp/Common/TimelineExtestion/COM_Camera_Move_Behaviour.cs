using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FF5 RID: 4085
	[Token(Token = "0x2000FF5")]
	public class COM_Camera_Move_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06005F03 RID: 24323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F03")]
		[Address(RVA = "0x8BE240", Offset = "0x8BCC40", VA = "0x1808BE240", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F04 RID: 24324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F04")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_Camera_Move_Behaviour()
		{
		}

		// Token: 0x04005805 RID: 22533
		[Token(Token = "0x4005805")]
		[FieldOffset(Offset = "0x10")]
		public bool shouldWaitForFinish;

		// Token: 0x04005806 RID: 22534
		[Token(Token = "0x4005806")]
		[FieldOffset(Offset = "0x14")]
		public float speedMultiplier;

		// Token: 0x04005807 RID: 22535
		[Token(Token = "0x4005807")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 startPoint;

		// Token: 0x04005808 RID: 22536
		[Token(Token = "0x4005808")]
		[FieldOffset(Offset = "0x20")]
		public Vector2[] wayPoints;
	}
}
