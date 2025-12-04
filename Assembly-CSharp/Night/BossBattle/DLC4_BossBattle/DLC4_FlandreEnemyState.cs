using System;
using Il2CppDummyDll;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001B4 RID: 436
	[Token(Token = "0x20001B4")]
	public abstract class DLC4_FlandreEnemyState
	{
		// Token: 0x06000A9C RID: 2716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x8CC790", Offset = "0x8CB190", VA = "0x1808CC790")]
		protected DLC4_FlandreEnemyState(DLC4_FlandreEnemyCharacterController controller, Action enterCallback, Action exitCallback, bool moveStateWhenEnter)
		{
		}

		// Token: 0x06000A9D RID: 2717
		[Token(Token = "0x6000A9D")]
		public abstract DLC4_FlandreEnemyCharacterController.CharacterState GetCharacterState();

		// Token: 0x06000A9E RID: 2718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x8D00A0", Offset = "0x8CEAA0", VA = "0x1808D00A0", Slot = "5")]
		public virtual void OnEnterState()
		{
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "6")]
		public virtual void OnUpdate()
		{
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x3FABC0", Offset = "0x3F95C0", VA = "0x1803FABC0", Slot = "7")]
		public virtual void OnExitState()
		{
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x8D00E0", Offset = "0x8CEAE0", VA = "0x1808D00E0")]
		protected void TryMove()
		{
		}

		// Token: 0x04000980 RID: 2432
		[Token(Token = "0x4000980")]
		[FieldOffset(Offset = "0x10")]
		protected DLC4_FlandreEnemyCharacterController controller;

		// Token: 0x04000981 RID: 2433
		[Token(Token = "0x4000981")]
		[FieldOffset(Offset = "0x18")]
		private readonly Action enterCallback;

		// Token: 0x04000982 RID: 2434
		[Token(Token = "0x4000982")]
		[FieldOffset(Offset = "0x20")]
		private readonly Action exitCallback;

		// Token: 0x04000983 RID: 2435
		[Token(Token = "0x4000983")]
		[FieldOffset(Offset = "0x28")]
		private readonly bool moveStateWhenEnter;
	}
}
