using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x0200100C RID: 4108
	[Token(Token = "0x200100C")]
	public class COM_ACharacter_ResetDetachedCharacter_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F3B RID: 24379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3B")]
		[Address(RVA = "0x8BBCE0", Offset = "0x8BA6E0", VA = "0x1808BBCE0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F3C RID: 24380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3C")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ACharacter_ResetDetachedCharacter_Behaviour()
		{
		}

		// Token: 0x04005840 RID: 22592
		[Token(Token = "0x4005840")]
		[FieldOffset(Offset = "0x10")]
		public string detachedCharacterLabel;
	}
}
