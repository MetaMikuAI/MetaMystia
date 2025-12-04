using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FED RID: 4077
	[Token(Token = "0x2000FED")]
	public class COM_WorldOverlay_Delete_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005EF2 RID: 24306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF2")]
		[Address(RVA = "0x8C1AD0", Offset = "0x8C04D0", VA = "0x1808C1AD0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005EF3 RID: 24307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF3")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_WorldOverlay_Delete_Behaviour()
		{
		}

		// Token: 0x040057EC RID: 22508
		[Token(Token = "0x40057EC")]
		[FieldOffset(Offset = "0x10")]
		public float duration;

		// Token: 0x040057ED RID: 22509
		[Token(Token = "0x40057ED")]
		[FieldOffset(Offset = "0x18")]
		public string label;
	}
}
