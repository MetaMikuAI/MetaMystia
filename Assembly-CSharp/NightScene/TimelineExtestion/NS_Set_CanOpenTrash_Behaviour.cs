using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000750 RID: 1872
	[Token(Token = "0x2000750")]
	public class NS_Set_CanOpenTrash_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06002BEA RID: 11242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BEA")]
		[Address(RVA = "0x5E2EC0", Offset = "0x5E18C0", VA = "0x1805E2EC0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BEB")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_Set_CanOpenTrash_Behaviour()
		{
		}

		// Token: 0x0400282E RID: 10286
		[Token(Token = "0x400282E")]
		[FieldOffset(Offset = "0x10")]
		public bool canOpenTrash;
	}
}
