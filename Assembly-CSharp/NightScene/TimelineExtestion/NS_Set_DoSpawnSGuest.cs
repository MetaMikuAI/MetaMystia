using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200076C RID: 1900
	[Token(Token = "0x200076C")]
	public class NS_Set_DoSpawnSGuest : PlayableAsset
	{
		// Token: 0x06002C22 RID: 11298 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		[Token(Token = "0x6002C22")]
		[Address(RVA = "0x5E31B0", Offset = "0x5E1BB0", VA = "0x1805E31B0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C23")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_Set_DoSpawnSGuest()
		{
		}

		// Token: 0x04002857 RID: 10327
		[Token(Token = "0x4002857")]
		[FieldOffset(Offset = "0x18")]
		public bool shouldSpawn;
	}
}
