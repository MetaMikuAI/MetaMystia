using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FE6 RID: 4070
	[Token(Token = "0x2000FE6")]
	public class COM_WorldOverlay_FollowCancel : PlayableAsset
	{
		// Token: 0x06005EE1 RID: 24289 RVA: 0x00020EC8 File Offset: 0x0001F0C8
		[Token(Token = "0x6005EE1")]
		[Address(RVA = "0x8C1CA0", Offset = "0x8C06A0", VA = "0x1808C1CA0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EE2 RID: 24290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE2")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_WorldOverlay_FollowCancel()
		{
		}

		// Token: 0x040057D1 RID: 22481
		[Token(Token = "0x40057D1")]
		[FieldOffset(Offset = "0x18")]
		public string label;
	}
}
