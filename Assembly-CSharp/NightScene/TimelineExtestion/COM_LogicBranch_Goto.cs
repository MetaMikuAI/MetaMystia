using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000730 RID: 1840
	[Token(Token = "0x2000730")]
	public class COM_LogicBranch_Goto : PlayableAsset
	{
		// Token: 0x06002BA1 RID: 11169 RVA: 0x0000F840 File Offset: 0x0000DA40
		[Token(Token = "0x6002BA1")]
		[Address(RVA = "0x5DFB70", Offset = "0x5DE570", VA = "0x1805DFB70", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002BA2 RID: 11170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA2")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_LogicBranch_Goto()
		{
		}

		// Token: 0x040027F7 RID: 10231
		[Token(Token = "0x40027F7")]
		[FieldOffset(Offset = "0x18")]
		public int ticks;
	}
}
