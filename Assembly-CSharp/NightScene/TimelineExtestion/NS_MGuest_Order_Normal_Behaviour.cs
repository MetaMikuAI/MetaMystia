using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200073A RID: 1850
	[Token(Token = "0x200073A")]
	public class NS_MGuest_Order_Normal_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06002BB8 RID: 11192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB8")]
		[Address(RVA = "0x5E15C0", Offset = "0x5DFFC0", VA = "0x1805E15C0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BB9 RID: 11193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB9")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_MGuest_Order_Normal_Behaviour()
		{
		}

		// Token: 0x0400280A RID: 10250
		[Token(Token = "0x400280A")]
		[FieldOffset(Offset = "0x10")]
		public int bevId;

		// Token: 0x0400280B RID: 10251
		[Token(Token = "0x400280B")]
		[FieldOffset(Offset = "0x14")]
		public int foodId;

		// Token: 0x0400280C RID: 10252
		[Token(Token = "0x400280C")]
		[FieldOffset(Offset = "0x18")]
		public string label;
	}
}
