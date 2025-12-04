using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000744 RID: 1860
	[Token(Token = "0x2000744")]
	public class NS_MGuest_MVT_Leave_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06002BD2 RID: 11218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD2")]
		[Address(RVA = "0x5E0EC0", Offset = "0x5DF8C0", VA = "0x1805E0EC0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BD3 RID: 11219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD3")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_MGuest_MVT_Leave_Behaviour()
		{
		}

		// Token: 0x0400281D RID: 10269
		[Token(Token = "0x400281D")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		// Token: 0x0400281E RID: 10270
		[Token(Token = "0x400281E")]
		[FieldOffset(Offset = "0x18")]
		public bool shouldLeaveInstantly;
	}
}
