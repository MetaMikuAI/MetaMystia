using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FEE RID: 4078
	[Token(Token = "0x2000FEE")]
	public class COM_WorldOverlay_TriggerAnimation_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06005EF4 RID: 24308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF4")]
		[Address(RVA = "0x8C2610", Offset = "0x8C1010", VA = "0x1808C2610", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005EF5 RID: 24309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EF5")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_WorldOverlay_TriggerAnimation_Behaviour()
		{
		}

		// Token: 0x040057EE RID: 22510
		[Token(Token = "0x40057EE")]
		[FieldOffset(Offset = "0x10")]
		public string animationTriggerlabel;

		// Token: 0x040057EF RID: 22511
		[Token(Token = "0x40057EF")]
		[FieldOffset(Offset = "0x18")]
		public string label;
	}
}
