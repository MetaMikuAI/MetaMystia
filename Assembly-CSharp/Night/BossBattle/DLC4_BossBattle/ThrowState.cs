using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001BC RID: 444
	[Token(Token = "0x20001BC")]
	public class ThrowState : DLC4_FlandreEnemyState
	{
		// Token: 0x06000AC1 RID: 2753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x8CC790", Offset = "0x8CB190", VA = "0x1808CC790")]
		public ThrowState(DLC4_FlandreEnemyCharacterController controller, Action enterCallback, Action exitCallback, bool moveStateWhenEnter)
		{
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00004E00 File Offset: 0x00003000
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x4470A0", Offset = "0x445AA0", VA = "0x1804470A0", Slot = "4")]
		public override DLC4_FlandreEnemyCharacterController.CharacterState GetCharacterState()
		{
			return DLC4_FlandreEnemyCharacterController.CharacterState.Idle;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x8D9F00", Offset = "0x8D8900", VA = "0x1808D9F00", Slot = "5")]
		public override void OnEnterState()
		{
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x8D9FD0", Offset = "0x8D89D0", VA = "0x1808D9FD0")]
		private IEnumerator StartThrowIEnumerator()
		{
			return null;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x8D9A70", Offset = "0x8D8470", VA = "0x1808D9A70", Slot = "7")]
		public override void OnExitState()
		{
		}

		// Token: 0x0400098C RID: 2444
		[Token(Token = "0x400098C")]
		[FieldOffset(Offset = "0x30")]
		private Coroutine throwCoroutine;
	}
}
