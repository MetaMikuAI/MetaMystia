using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200074F RID: 1871
	[Token(Token = "0x200074F")]
	public class NS_Override_Passion_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06002BE8 RID: 11240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE8")]
		[Address(RVA = "0x5E2760", Offset = "0x5E1160", VA = "0x1805E2760", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE9")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_Override_Passion_Behaviour()
		{
		}

		// Token: 0x0400282D RID: 10285
		[Token(Token = "0x400282D")]
		[FieldOffset(Offset = "0x10")]
		public int newPassion;
	}
}
