using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FF0 RID: 4080
	[Token(Token = "0x2000FF0")]
	public class COM_WorldOverlay_Follow_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005EF8 RID: 24312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF8")]
		[Address(RVA = "0x8C1DB0", Offset = "0x8C07B0", VA = "0x1808C1DB0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005EF9 RID: 24313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF9")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_WorldOverlay_Follow_Behaviour()
		{
		}

		// Token: 0x040057F4 RID: 22516
		[Token(Token = "0x40057F4")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		// Token: 0x040057F5 RID: 22517
		[Token(Token = "0x40057F5")]
		[FieldOffset(Offset = "0x18")]
		public string targetLabel;
	}
}
