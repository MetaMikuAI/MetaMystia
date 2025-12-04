using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200076D RID: 1901
	[Token(Token = "0x200076D")]
	public class NS_Set_DoTimeFlow : PlayableAsset
	{
		// Token: 0x06002C24 RID: 11300 RVA: 0x0000FB10 File Offset: 0x0000DD10
		[Token(Token = "0x6002C24")]
		[Address(RVA = "0x5E3300", Offset = "0x5E1D00", VA = "0x1805E3300", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C25")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_Set_DoTimeFlow()
		{
		}

		// Token: 0x04002858 RID: 10328
		[Token(Token = "0x4002858")]
		[FieldOffset(Offset = "0x18")]
		public bool shouldFlow;
	}
}
