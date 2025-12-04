using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FDE RID: 4062
	[Token(Token = "0x2000FDE")]
	public class COM_SetPlayerPref : PlayableAsset
	{
		// Token: 0x06005ED1 RID: 24273 RVA: 0x00020E08 File Offset: 0x0001F008
		[Token(Token = "0x6005ED1")]
		[Address(RVA = "0x8C12C0", Offset = "0x8BFCC0", VA = "0x1808C12C0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005ED2 RID: 24274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED2")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_SetPlayerPref()
		{
		}

		// Token: 0x040057C7 RID: 22471
		[Token(Token = "0x40057C7")]
		[FieldOffset(Offset = "0x18")]
		public string playerPrefLabel;
	}
}
