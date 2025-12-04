using System;
using GameData.Profile;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02001023 RID: 4131
	[Token(Token = "0x2001023")]
	public class COM_OverrideBGM_Play_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F6F RID: 24431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F6F")]
		[Address(RVA = "0x8C0AD0", Offset = "0x8BF4D0", VA = "0x1808C0AD0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F70 RID: 24432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F70")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_OverrideBGM_Play_Behaviour()
		{
		}

		// Token: 0x04005868 RID: 22632
		[Token(Token = "0x4005868")]
		[FieldOffset(Offset = "0x10")]
		public LoopedBGMPackage musicPackage;
	}
}
