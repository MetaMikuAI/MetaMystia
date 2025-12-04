using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FD4 RID: 4052
	[Token(Token = "0x2000FD4")]
	public class COM_LogicBranch_IsSwitchPlatform : PlayableAsset
	{
		// Token: 0x06005EBD RID: 24253 RVA: 0x00020D18 File Offset: 0x0001EF18
		[Token(Token = "0x6005EBD")]
		[Address(RVA = "0x8BFF40", Offset = "0x8BE940", VA = "0x1808BFF40", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EBE RID: 24254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EBE")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_LogicBranch_IsSwitchPlatform()
		{
		}

		// Token: 0x040057BC RID: 22460
		[Token(Token = "0x40057BC")]
		[FieldOffset(Offset = "0x18")]
		public int trueAddFrames;

		// Token: 0x040057BD RID: 22461
		[Token(Token = "0x40057BD")]
		[FieldOffset(Offset = "0x1C")]
		public int falseAddFrames;
	}
}
