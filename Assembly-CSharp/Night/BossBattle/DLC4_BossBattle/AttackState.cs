using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001B7 RID: 439
	[Token(Token = "0x20001B7")]
	public class AttackState : DLC4_FlandreEnemyState
	{
		// Token: 0x06000AA8 RID: 2728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x8CC790", Offset = "0x8CB190", VA = "0x1808CC790")]
		public AttackState(DLC4_FlandreEnemyCharacterController controller, Action enterCallback, Action exitCallback, bool moveStateWhenEnter)
		{
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00004D88 File Offset: 0x00002F88
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x7B2C90", Offset = "0x7B1690", VA = "0x1807B2C90", Slot = "4")]
		public override DLC4_FlandreEnemyCharacterController.CharacterState GetCharacterState()
		{
			return DLC4_FlandreEnemyCharacterController.CharacterState.Idle;
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x8CC5D0", Offset = "0x8CAFD0", VA = "0x1808CC5D0", Slot = "5")]
		public override void OnEnterState()
		{
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x8CC710", Offset = "0x8CB110", VA = "0x1808CC710")]
		private IEnumerator StartAttackIEnumerator()
		{
			return null;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x8CC6B0", Offset = "0x8CB0B0", VA = "0x1808CC6B0", Slot = "7")]
		public override void OnExitState()
		{
		}

		// Token: 0x04000984 RID: 2436
		[Token(Token = "0x4000984")]
		[FieldOffset(Offset = "0x30")]
		private Coroutine attackCoroutine;
	}
}
