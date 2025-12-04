using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x0200100B RID: 4107
	[Token(Token = "0x200100B")]
	public class COM_ACharacter_DetachAndOverridePosition_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F39 RID: 24377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F39")]
		[Address(RVA = "0x8BAF70", Offset = "0x8B9970", VA = "0x1808BAF70", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F3A RID: 24378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3A")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ACharacter_DetachAndOverridePosition_Behaviour()
		{
		}

		// Token: 0x0400583C RID: 22588
		[Token(Token = "0x400583C")]
		[FieldOffset(Offset = "0x10")]
		public string baseLabel;

		// Token: 0x0400583D RID: 22589
		[Token(Token = "0x400583D")]
		[FieldOffset(Offset = "0x18")]
		public string detachCharacterLabel;

		// Token: 0x0400583E RID: 22590
		[Token(Token = "0x400583E")]
		[FieldOffset(Offset = "0x20")]
		public int detachIndex;

		// Token: 0x0400583F RID: 22591
		[Token(Token = "0x400583F")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 overridePosition;
	}
}
