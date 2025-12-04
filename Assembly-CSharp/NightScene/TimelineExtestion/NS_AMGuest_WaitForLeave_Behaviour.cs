using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000737 RID: 1847
	[Token(Token = "0x2000737")]
	public class NS_AMGuest_WaitForLeave_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06002BAF RID: 11183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAF")]
		[Address(RVA = "0x5E0270", Offset = "0x5DEC70", VA = "0x1805E0270")]
		public static void TryContinue()
		{
		}

		// Token: 0x06002BB0 RID: 11184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB0")]
		[Address(RVA = "0x5E01C0", Offset = "0x5DEBC0", VA = "0x1805E01C0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BB1 RID: 11185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BB1")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_AMGuest_WaitForLeave_Behaviour()
		{
		}

		// Token: 0x04002802 RID: 10242
		[Token(Token = "0x4002802")]
		[FieldOffset(Offset = "0x0")]
		private static Action continueHandle;
	}
}
