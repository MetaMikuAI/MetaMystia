using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FD7 RID: 4055
	[Token(Token = "0x2000FD7")]
	public class COM_OverrideBGM_PauseOrResume : PlayableAsset
	{
		// Token: 0x06005EC3 RID: 24259 RVA: 0x00020D60 File Offset: 0x0001EF60
		[Token(Token = "0x6005EC3")]
		[Address(RVA = "0x8C09D0", Offset = "0x8BF3D0", VA = "0x1808C09D0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EC4 RID: 24260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC4")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_OverrideBGM_PauseOrResume()
		{
		}

		// Token: 0x040057C2 RID: 22466
		[Token(Token = "0x40057C2")]
		[FieldOffset(Offset = "0x18")]
		public bool shouldResume;
	}
}
