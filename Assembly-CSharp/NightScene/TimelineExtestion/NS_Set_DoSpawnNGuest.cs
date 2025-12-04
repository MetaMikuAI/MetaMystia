using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200076B RID: 1899
	[Token(Token = "0x200076B")]
	public class NS_Set_DoSpawnNGuest : PlayableAsset
	{
		// Token: 0x06002C20 RID: 11296 RVA: 0x0000FAE0 File Offset: 0x0000DCE0
		[Token(Token = "0x6002C20")]
		[Address(RVA = "0x5E3060", Offset = "0x5E1A60", VA = "0x1805E3060", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C21")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_Set_DoSpawnNGuest()
		{
		}

		// Token: 0x04002856 RID: 10326
		[Token(Token = "0x4002856")]
		[FieldOffset(Offset = "0x18")]
		public bool shouldSpawn;
	}
}
