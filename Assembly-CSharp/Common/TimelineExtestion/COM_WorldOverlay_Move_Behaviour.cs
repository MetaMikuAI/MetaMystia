using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FEF RID: 4079
	[Token(Token = "0x2000FEF")]
	public class COM_WorldOverlay_Move_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06005EF6 RID: 24310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF6")]
		[Address(RVA = "0x8C1F40", Offset = "0x8C0940", VA = "0x1808C1F40", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005EF7 RID: 24311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF7")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_WorldOverlay_Move_Behaviour()
		{
		}

		// Token: 0x040057F0 RID: 22512
		[Token(Token = "0x40057F0")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		// Token: 0x040057F1 RID: 22513
		[Token(Token = "0x40057F1")]
		[FieldOffset(Offset = "0x18")]
		public bool shouldWaitForFinish;

		// Token: 0x040057F2 RID: 22514
		[Token(Token = "0x40057F2")]
		[FieldOffset(Offset = "0x1C")]
		public float speedMultiplier;

		// Token: 0x040057F3 RID: 22515
		[Token(Token = "0x40057F3")]
		[FieldOffset(Offset = "0x20")]
		public Vector2[] wayPoints;
	}
}
