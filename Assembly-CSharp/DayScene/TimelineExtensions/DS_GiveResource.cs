using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200049E RID: 1182
	[Token(Token = "0x200049E")]
	public class DS_GiveResource : PlayableAsset
	{
		// Token: 0x06001B18 RID: 6936 RVA: 0x0000A758 File Offset: 0x00008958
		[Token(Token = "0x6001B18")]
		[Address(RVA = "0x4979A0", Offset = "0x4963A0", VA = "0x1804979A0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B19")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DS_GiveResource()
		{
		}

		// Token: 0x040018CF RID: 6351
		[Token(Token = "0x40018CF")]
		[FieldOffset(Offset = "0x18")]
		public int resourceCode;
	}
}
