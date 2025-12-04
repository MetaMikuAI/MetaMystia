using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200076A RID: 1898
	[Token(Token = "0x200076A")]
	public class NS_Set_CanOpenTrash : PlayableAsset
	{
		// Token: 0x06002C1E RID: 11294 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
		[Token(Token = "0x6002C1E")]
		[Address(RVA = "0x5E2F10", Offset = "0x5E1910", VA = "0x1805E2F10", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C1F")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_Set_CanOpenTrash()
		{
		}

		// Token: 0x04002855 RID: 10325
		[Token(Token = "0x4002855")]
		[FieldOffset(Offset = "0x18")]
		public bool canOpenTrash;
	}
}
