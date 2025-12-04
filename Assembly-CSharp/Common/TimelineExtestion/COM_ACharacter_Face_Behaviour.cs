using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x0200100F RID: 4111
	[Token(Token = "0x200100F")]
	public class COM_ACharacter_Face_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F40 RID: 24384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F40")]
		[Address(RVA = "0x8BB260", Offset = "0x8B9C60", VA = "0x1808BB260", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F41 RID: 24385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F41")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ACharacter_Face_Behaviour()
		{
		}

		// Token: 0x04005846 RID: 22598
		[Token(Token = "0x4005846")]
		[FieldOffset(Offset = "0x10")]
		public COM_ACharacter_Face_Behaviour.FaceID faceID;

		// Token: 0x04005847 RID: 22599
		[Token(Token = "0x4005847")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x02001010 RID: 4112
		[Token(Token = "0x2001010")]
		public enum FaceID : byte
		{
			// Token: 0x04005849 RID: 22601
			[Token(Token = "0x4005849")]
			I,
			// Token: 0x0400584A RID: 22602
			[Token(Token = "0x400584A")]
			II,
			// Token: 0x0400584B RID: 22603
			[Token(Token = "0x400584B")]
			III,
			// Token: 0x0400584C RID: 22604
			[Token(Token = "0x400584C")]
			IV
		}
	}
}
