using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001BA RID: 442
	[Token(Token = "0x20001BA")]
	public class DieState : DLC4_FlandreEnemyState
	{
		// Token: 0x06000AB6 RID: 2742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x8CC790", Offset = "0x8CB190", VA = "0x1808CC790")]
		public DieState(DLC4_FlandreEnemyCharacterController controller, Action enterCallback, Action exitCallback, bool moveStateWhenEnter)
		{
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x518710", Offset = "0x517110", VA = "0x180518710", Slot = "4")]
		public override DLC4_FlandreEnemyCharacterController.CharacterState GetCharacterState()
		{
			return DLC4_FlandreEnemyCharacterController.CharacterState.Idle;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x8D99A0", Offset = "0x8D83A0", VA = "0x1808D99A0", Slot = "5")]
		public override void OnEnterState()
		{
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x8D9AC0", Offset = "0x8D84C0", VA = "0x1808D9AC0")]
		private IEnumerator StartDieIEnumerator()
		{
			return null;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x8D9A70", Offset = "0x8D8470", VA = "0x1808D9A70", Slot = "7")]
		public override void OnExitState()
		{
		}

		// Token: 0x04000988 RID: 2440
		[Token(Token = "0x4000988")]
		[FieldOffset(Offset = "0x30")]
		private Coroutine dieCoroutine;
	}
}
