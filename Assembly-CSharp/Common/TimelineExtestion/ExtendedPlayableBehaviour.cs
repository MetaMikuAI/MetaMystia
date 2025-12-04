using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FEA RID: 4074
	[Token(Token = "0x2000FEA")]
	public abstract class ExtendedPlayableBehaviour : PlayableBehaviour
	{
		// Token: 0x06005EE9 RID: 24297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE9")]
		[Address(RVA = "0x8C7F10", Offset = "0x8C6910", VA = "0x1808C7F10", Slot = "17")]
		public sealed override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		// Token: 0x06005EEA RID: 24298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EEA")]
		[Address(RVA = "0x8C7E80", Offset = "0x8C6880", VA = "0x1808C7E80")]
		protected void Continue()
		{
		}

		// Token: 0x06005EEB RID: 24299
		[Token(Token = "0x6005EEB")]
		protected abstract void OnBehaviourEnter();

		// Token: 0x06005EEC RID: 24300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EEC")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		protected ExtendedPlayableBehaviour()
		{
		}
	}
}
