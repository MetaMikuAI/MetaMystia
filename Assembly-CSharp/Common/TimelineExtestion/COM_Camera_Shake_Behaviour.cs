using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FF8 RID: 4088
	[Token(Token = "0x2000FF8")]
	public class COM_Camera_Shake_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F09 RID: 24329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F09")]
		[Address(RVA = "0x8BE870", Offset = "0x8BD270", VA = "0x1808BE870", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F0A RID: 24330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F0A")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_Camera_Shake_Behaviour()
		{
		}

		// Token: 0x04005810 RID: 22544
		[Token(Token = "0x4005810")]
		[FieldOffset(Offset = "0x10")]
		public float amplitude;

		// Token: 0x04005811 RID: 22545
		[Token(Token = "0x4005811")]
		[FieldOffset(Offset = "0x14")]
		public float duration;
	}
}
