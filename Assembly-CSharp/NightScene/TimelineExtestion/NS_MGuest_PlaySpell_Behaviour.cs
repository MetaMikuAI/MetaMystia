using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000746 RID: 1862
	[Token(Token = "0x2000746")]
	public class NS_MGuest_PlaySpell_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06002BD6 RID: 11222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD6")]
		[Address(RVA = "0x5E20F0", Offset = "0x5E0AF0", VA = "0x1805E20F0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD7")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_MGuest_PlaySpell_Behaviour()
		{
		}

		// Token: 0x04002821 RID: 10273
		[Token(Token = "0x4002821")]
		[FieldOffset(Offset = "0x10")]
		public bool isPositive;

		// Token: 0x04002822 RID: 10274
		[Token(Token = "0x4002822")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x04002823 RID: 10275
		[Token(Token = "0x4002823")]
		[FieldOffset(Offset = "0x20")]
		public bool visualOnly;
	}
}
