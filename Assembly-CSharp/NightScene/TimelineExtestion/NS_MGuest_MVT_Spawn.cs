using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200075A RID: 1882
	[Token(Token = "0x200075A")]
	public class NS_MGuest_MVT_Spawn : PlayableAsset
	{
		// Token: 0x06002BFE RID: 11262 RVA: 0x0000F948 File Offset: 0x0000DB48
		[Token(Token = "0x6002BFE")]
		[Address(RVA = "0x5E10B0", Offset = "0x5DFAB0", VA = "0x1805E10B0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BFF")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_MGuest_MVT_Spawn()
		{
		}

		// Token: 0x04002839 RID: 10297
		[Token(Token = "0x4002839")]
		[FieldOffset(Offset = "0x18")]
		public int specialGuestId;

		// Token: 0x0400283A RID: 10298
		[Token(Token = "0x400283A")]
		[FieldOffset(Offset = "0x20")]
		public string label;

		// Token: 0x0400283B RID: 10299
		[Token(Token = "0x400283B")]
		[FieldOffset(Offset = "0x28")]
		public bool spawnInA;
	}
}
