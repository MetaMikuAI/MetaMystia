using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FF9 RID: 4089
	[Token(Token = "0x2000FF9")]
	public class COM_Camera_WorldPos_Follow_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F0B RID: 24331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F0B")]
		[Address(RVA = "0x8BEA00", Offset = "0x8BD400", VA = "0x1808BEA00", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F0C RID: 24332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F0C")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_Camera_WorldPos_Follow_Behaviour()
		{
		}

		// Token: 0x04005812 RID: 22546
		[Token(Token = "0x4005812")]
		[FieldOffset(Offset = "0x10")]
		public float damping;

		// Token: 0x04005813 RID: 22547
		[Token(Token = "0x4005813")]
		[FieldOffset(Offset = "0x18")]
		public string label;
	}
}
