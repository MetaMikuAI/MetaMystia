using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000745 RID: 1861
	[Token(Token = "0x2000745")]
	public class NS_MGuest_SetPatient_Behaviuor : NormalPlayableBehaviour
	{
		// Token: 0x06002BD4 RID: 11220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD4")]
		[Address(RVA = "0x5E2310", Offset = "0x5E0D10", VA = "0x1805E2310", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD5")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_MGuest_SetPatient_Behaviuor()
		{
		}

		// Token: 0x0400281F RID: 10271
		[Token(Token = "0x400281F")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		// Token: 0x04002820 RID: 10272
		[Token(Token = "0x4002820")]
		[FieldOffset(Offset = "0x18")]
		public int targetPatient;
	}
}
