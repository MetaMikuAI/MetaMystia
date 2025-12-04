using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200073B RID: 1851
	[Token(Token = "0x200073B")]
	public class NS_MGuest_Order_Special_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06002BBB RID: 11195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BBB")]
		[Address(RVA = "0x5E18E0", Offset = "0x5E02E0", VA = "0x1805E18E0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BBC RID: 11196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BBC")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_MGuest_Order_Special_Behaviour()
		{
		}

		// Token: 0x0400280D RID: 10253
		[Token(Token = "0x400280D")]
		[FieldOffset(Offset = "0x10")]
		public int bevTag;

		// Token: 0x0400280E RID: 10254
		[Token(Token = "0x400280E")]
		[FieldOffset(Offset = "0x14")]
		public int foodTag;

		// Token: 0x0400280F RID: 10255
		[Token(Token = "0x400280F")]
		[FieldOffset(Offset = "0x18")]
		public string label;
	}
}
