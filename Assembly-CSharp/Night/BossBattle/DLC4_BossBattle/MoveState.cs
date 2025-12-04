using System;
using Il2CppDummyDll;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001B6 RID: 438
	[Token(Token = "0x20001B6")]
	public class MoveState : DLC4_FlandreEnemyState
	{
		// Token: 0x06000AA5 RID: 2725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x8CC790", Offset = "0x8CB190", VA = "0x1808CC790")]
		public MoveState(DLC4_FlandreEnemyCharacterController controller, Action enterCallback, Action exitCallback, bool moveStateWhenEnter)
		{
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "4")]
		public override DLC4_FlandreEnemyCharacterController.CharacterState GetCharacterState()
		{
			return DLC4_FlandreEnemyCharacterController.CharacterState.Idle;
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x8D9D70", Offset = "0x8D8770", VA = "0x1808D9D70", Slot = "6")]
		public override void OnUpdate()
		{
		}
	}
}
