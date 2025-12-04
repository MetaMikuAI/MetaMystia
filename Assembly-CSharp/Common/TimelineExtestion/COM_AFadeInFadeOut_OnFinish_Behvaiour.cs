using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02001016 RID: 4118
	[Token(Token = "0x2001016")]
	public class COM_AFadeInFadeOut_OnFinish_Behvaiour : ExtendedPlayableBehaviour
	{
		// Token: 0x06005F51 RID: 24401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F51")]
		[Address(RVA = "0x8BE060", Offset = "0x8BCA60", VA = "0x1808BE060")]
		public static void NotifyFinish()
		{
		}

		// Token: 0x06005F52 RID: 24402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F52")]
		[Address(RVA = "0x8BE0D0", Offset = "0x8BCAD0", VA = "0x1808BE0D0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F53 RID: 24403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F53")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_AFadeInFadeOut_OnFinish_Behvaiour()
		{
		}

		// Token: 0x04005857 RID: 22615
		[Token(Token = "0x4005857")]
		[FieldOffset(Offset = "0x0")]
		private static Action onFinished;
	}
}
