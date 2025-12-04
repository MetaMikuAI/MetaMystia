using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x0200100D RID: 4109
	[Token(Token = "0x200100D")]
	public class COM_AFadeInFadeOut_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F3D RID: 24381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3D")]
		[Address(RVA = "0x8BDDD0", Offset = "0x8BC7D0", VA = "0x1808BDDD0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F3E RID: 24382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3E")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_AFadeInFadeOut_Behaviour()
		{
		}

		// Token: 0x06005F3F RID: 24383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F3F")]
		[Address(RVA = "0x8BDEF0", Offset = "0x8BC8F0", VA = "0x1808BDEF0")]
		[CompilerGenerated]
		private void <OnBehaviourEnter>g__OnFinish|3_0()
		{
		}

		// Token: 0x04005841 RID: 22593
		[Token(Token = "0x4005841")]
		[FieldOffset(Offset = "0x10")]
		public bool notWait;

		// Token: 0x04005842 RID: 22594
		[Token(Token = "0x4005842")]
		[FieldOffset(Offset = "0x14")]
		public COM_AFadeInFadeOut_Behaviour.Type transitionType;

		// Token: 0x0200100E RID: 4110
		[Token(Token = "0x200100E")]
		public enum Type
		{
			// Token: 0x04005844 RID: 22596
			[Token(Token = "0x4005844")]
			FadeIn,
			// Token: 0x04005845 RID: 22597
			[Token(Token = "0x4005845")]
			FadeOut
		}
	}
}
