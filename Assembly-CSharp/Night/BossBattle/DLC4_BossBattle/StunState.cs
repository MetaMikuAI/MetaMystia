using System;
using Il2CppDummyDll;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001B9 RID: 441
	[Token(Token = "0x20001B9")]
	public class StunState : DLC4_FlandreEnemyState
	{
		// Token: 0x06000AB3 RID: 2739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x8CC790", Offset = "0x8CB190", VA = "0x1808CC790")]
		public StunState(DLC4_FlandreEnemyCharacterController controller, Action enterCallback, Action exitCallback, bool moveStateWhenEnter)
		{
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00004DB8 File Offset: 0x00002FB8
		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x8D9E70", Offset = "0x8D8870", VA = "0x1808D9E70", Slot = "4")]
		public override DLC4_FlandreEnemyCharacterController.CharacterState GetCharacterState()
		{
			return DLC4_FlandreEnemyCharacterController.CharacterState.Idle;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x8D9E80", Offset = "0x8D8880", VA = "0x1808D9E80", Slot = "6")]
		public override void OnUpdate()
		{
		}
	}
}
