using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000765 RID: 1893
	[Token(Token = "0x2000765")]
	public class NS_Override_Recipe : PlayableAsset
	{
		// Token: 0x06002C14 RID: 11284 RVA: 0x0000FA50 File Offset: 0x0000DC50
		[Token(Token = "0x6002C14")]
		[Address(RVA = "0x5E2910", Offset = "0x5E1310", VA = "0x1805E2910", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C15")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_Override_Recipe()
		{
		}

		// Token: 0x04002854 RID: 10324
		[Token(Token = "0x4002854")]
		[FieldOffset(Offset = "0x18")]
		public int[] recipeArray;
	}
}
