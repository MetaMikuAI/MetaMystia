using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02001028 RID: 4136
	[Token(Token = "0x2001028")]
	public class COM_SpecialNPC_IncreaseKizuna_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F79 RID: 24441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F79")]
		[Address(RVA = "0x8C13D0", Offset = "0x8BFDD0", VA = "0x1808C13D0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F7A RID: 24442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7A")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_SpecialNPC_IncreaseKizuna_Behaviour()
		{
		}

		// Token: 0x0400586D RID: 22637
		[Token(Token = "0x400586D")]
		[FieldOffset(Offset = "0x10")]
		public int kizunaAmount;

		// Token: 0x0400586E RID: 22638
		[Token(Token = "0x400586E")]
		[FieldOffset(Offset = "0x18")]
		public string targetCharacterLabel;
	}
}
