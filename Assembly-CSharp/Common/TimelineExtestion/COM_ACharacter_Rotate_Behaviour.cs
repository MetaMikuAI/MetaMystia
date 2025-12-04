using System;
using DayScene.Input;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FFB RID: 4091
	[Token(Token = "0x2000FFB")]
	public class COM_ACharacter_Rotate_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F0F RID: 24335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F0F")]
		[Address(RVA = "0x8BBFF0", Offset = "0x8BA9F0", VA = "0x1808BBFF0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F10 RID: 24336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F10")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ACharacter_Rotate_Behaviour()
		{
		}

		// Token: 0x04005814 RID: 22548
		[Token(Token = "0x4005814")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		// Token: 0x04005815 RID: 22549
		[Token(Token = "0x4005815")]
		[FieldOffset(Offset = "0x18")]
		public DayScenePlayerInputGenerator.CharacterRotation targetRotation;
	}
}
