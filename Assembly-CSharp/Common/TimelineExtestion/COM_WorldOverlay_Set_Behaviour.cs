using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FEC RID: 4076
	[Token(Token = "0x2000FEC")]
	public class COM_WorldOverlay_Set_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005EF0 RID: 24304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF0")]
		[Address(RVA = "0x8C21E0", Offset = "0x8C0BE0", VA = "0x1808C21E0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005EF1 RID: 24305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF1")]
		[Address(RVA = "0x8C22D0", Offset = "0x8C0CD0", VA = "0x1808C22D0")]
		public COM_WorldOverlay_Set_Behaviour()
		{
		}

		// Token: 0x040057E4 RID: 22500
		[Token(Token = "0x40057E4")]
		[FieldOffset(Offset = "0x10")]
		public string characterLabel;

		// Token: 0x040057E5 RID: 22501
		[Token(Token = "0x40057E5")]
		[FieldOffset(Offset = "0x18")]
		public bool characterMode;

		// Token: 0x040057E6 RID: 22502
		[Token(Token = "0x40057E6")]
		[FieldOffset(Offset = "0x20")]
		public string label;

		// Token: 0x040057E7 RID: 22503
		[Token(Token = "0x40057E7")]
		[FieldOffset(Offset = "0x28")]
		public GameObject spriteGameObject;

		// Token: 0x040057E8 RID: 22504
		[Token(Token = "0x40057E8")]
		[FieldOffset(Offset = "0x30")]
		public float transitionDuration;

		// Token: 0x040057E9 RID: 22505
		[Token(Token = "0x40057E9")]
		[FieldOffset(Offset = "0x34")]
		public bool tutorialMode;

		// Token: 0x040057EA RID: 22506
		[Token(Token = "0x40057EA")]
		[FieldOffset(Offset = "0x35")]
		public bool uiMode;

		// Token: 0x040057EB RID: 22507
		[Token(Token = "0x40057EB")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 worldPosition;
	}
}
