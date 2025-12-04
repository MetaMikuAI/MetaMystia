using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001BE RID: 446
	[Token(Token = "0x20001BE")]
	public class JumpState : DLC4_FlandreEnemyState
	{
		// Token: 0x06000ACC RID: 2764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x8CC790", Offset = "0x8CB190", VA = "0x1808CC790")]
		public JumpState(DLC4_FlandreEnemyCharacterController controller, Action enterCallback, Action exitCallback, bool moveStateWhenEnter)
		{
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x00004E30 File Offset: 0x00003030
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x518720", Offset = "0x517120", VA = "0x180518720", Slot = "4")]
		public override DLC4_FlandreEnemyCharacterController.CharacterState GetCharacterState()
		{
			return DLC4_FlandreEnemyCharacterController.CharacterState.Idle;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x8D9C20", Offset = "0x8D8620", VA = "0x1808D9C20", Slot = "5")]
		public override void OnEnterState()
		{
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x8D9CF0", Offset = "0x8D86F0", VA = "0x1808D9CF0")]
		private IEnumerator StartJumpIEnumerator()
		{
			return null;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x8D9A70", Offset = "0x8D8470", VA = "0x1808D9A70", Slot = "7")]
		public override void OnExitState()
		{
		}

		// Token: 0x04000990 RID: 2448
		[Token(Token = "0x4000990")]
		[FieldOffset(Offset = "0x30")]
		private Coroutine jumpCoroutine;
	}
}
