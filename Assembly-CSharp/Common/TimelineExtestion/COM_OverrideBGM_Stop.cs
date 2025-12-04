using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FD9 RID: 4057
	[Token(Token = "0x2000FD9")]
	public class COM_OverrideBGM_Stop : PlayableAsset
	{
		// Token: 0x06005EC7 RID: 24263 RVA: 0x00020D90 File Offset: 0x0001EF90
		[Token(Token = "0x6005EC7")]
		[Address(RVA = "0x8C0C90", Offset = "0x8BF690", VA = "0x1808C0C90", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EC8 RID: 24264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC8")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_OverrideBGM_Stop()
		{
		}
	}
}
