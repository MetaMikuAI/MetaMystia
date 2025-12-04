using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FEB RID: 4075
	[Token(Token = "0x2000FEB")]
	public abstract class NormalPlayableBehaviour : PlayableBehaviour
	{
		// Token: 0x06005EED RID: 24301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EED")]
		[Address(RVA = "0x8C8AC0", Offset = "0x8C74C0", VA = "0x1808C8AC0", Slot = "17")]
		public sealed override void OnBehaviourPlay(Playable playable, FrameData info)
		{
		}

		// Token: 0x06005EEE RID: 24302
		[Token(Token = "0x6005EEE")]
		protected abstract void OnBehaviourEnter();

		// Token: 0x06005EEF RID: 24303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EEF")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		protected NormalPlayableBehaviour()
		{
		}
	}
}
