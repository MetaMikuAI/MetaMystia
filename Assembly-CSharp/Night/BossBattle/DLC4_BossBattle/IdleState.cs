using System;
using Il2CppDummyDll;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001B5 RID: 437
	[Token(Token = "0x20001B5")]
	public class IdleState : DLC4_FlandreEnemyState
	{
		// Token: 0x06000AA2 RID: 2722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x8CC790", Offset = "0x8CB190", VA = "0x1808CC790")]
		public IdleState(DLC4_FlandreEnemyCharacterController controller, Action enterCallback, Action exitCallback, bool moveStateWhenEnter)
		{
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00004D58 File Offset: 0x00002F58
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "4")]
		public override DLC4_FlandreEnemyCharacterController.CharacterState GetCharacterState()
		{
			return DLC4_FlandreEnemyCharacterController.CharacterState.Idle;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "6")]
		public override void OnUpdate()
		{
		}
	}
}
