using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x0200100A RID: 4106
	[Token(Token = "0x200100A")]
	public class COM_ACharacter_SetVisualActive_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F37 RID: 24375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F37")]
		[Address(RVA = "0x8BC600", Offset = "0x8BB000", VA = "0x1808BC600", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F38 RID: 24376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F38")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ACharacter_SetVisualActive_Behaviour()
		{
		}

		// Token: 0x0400583A RID: 22586
		[Token(Token = "0x400583A")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		// Token: 0x0400583B RID: 22587
		[Token(Token = "0x400583B")]
		[FieldOffset(Offset = "0x18")]
		public bool visualActive;
	}
}
