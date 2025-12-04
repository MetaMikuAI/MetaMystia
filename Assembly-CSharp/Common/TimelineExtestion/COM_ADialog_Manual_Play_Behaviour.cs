using System;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x0200101A RID: 4122
	[Token(Token = "0x200101A")]
	public class COM_ADialog_Manual_Play_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06005F5C RID: 24412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F5C")]
		[Address(RVA = "0x8BD9A0", Offset = "0x8BC3A0", VA = "0x1808BD9A0")]
		public static void ContinueExtern()
		{
		}

		// Token: 0x06005F5D RID: 24413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F5D")]
		[Address(RVA = "0x8BDA20", Offset = "0x8BC420", VA = "0x1808BDA20", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F5E RID: 24414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F5E")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ADialog_Manual_Play_Behaviour()
		{
		}

		// Token: 0x04005862 RID: 22626
		[Token(Token = "0x4005862")]
		[FieldOffset(Offset = "0x0")]
		private static Action currentContinue;
	}
}
