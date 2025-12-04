using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02001006 RID: 4102
	[Token(Token = "0x2001006")]
	public class COM_ACharacter_RotationZ_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F2F RID: 24367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F2F")]
		[Address(RVA = "0x8BC170", Offset = "0x8BAB70", VA = "0x1808BC170", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F30 RID: 24368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F30")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ACharacter_RotationZ_Behaviour()
		{
		}

		// Token: 0x04005830 RID: 22576
		[Token(Token = "0x4005830")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		// Token: 0x04005831 RID: 22577
		[Token(Token = "0x4005831")]
		[FieldOffset(Offset = "0x18")]
		public float targetValue;

		// Token: 0x04005832 RID: 22578
		[Token(Token = "0x4005832")]
		[FieldOffset(Offset = "0x1C")]
		public bool continuousRotationZ;
	}
}
