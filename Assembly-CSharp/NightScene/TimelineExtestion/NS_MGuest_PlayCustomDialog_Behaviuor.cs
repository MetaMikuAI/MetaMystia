using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000747 RID: 1863
	[Token(Token = "0x2000747")]
	public class NS_MGuest_PlayCustomDialog_Behaviuor : ExtendedPlayableBehaviour
	{
		// Token: 0x06002BD8 RID: 11224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD8")]
		[Address(RVA = "0x5E1C00", Offset = "0x5E0600", VA = "0x1805E1C00", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BD9")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_MGuest_PlayCustomDialog_Behaviuor()
		{
		}

		// Token: 0x04002824 RID: 10276
		[Token(Token = "0x4002824")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		// Token: 0x04002825 RID: 10277
		[Token(Token = "0x4002825")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x04002826 RID: 10278
		[Token(Token = "0x4002826")]
		[FieldOffset(Offset = "0x20")]
		public float duration;

		// Token: 0x04002827 RID: 10279
		[Token(Token = "0x4002827")]
		[FieldOffset(Offset = "0x24")]
		public bool shouldWaitForFinish;
	}
}
