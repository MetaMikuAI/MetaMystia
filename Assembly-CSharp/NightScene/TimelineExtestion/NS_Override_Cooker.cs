using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000763 RID: 1891
	[Token(Token = "0x2000763")]
	public class NS_Override_Cooker : PlayableAsset
	{
		// Token: 0x06002C10 RID: 11280 RVA: 0x0000FA20 File Offset: 0x0000DC20
		[Token(Token = "0x6002C10")]
		[Address(RVA = "0x5E2650", Offset = "0x5E1050", VA = "0x1805E2650", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C11")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_Override_Cooker()
		{
		}

		// Token: 0x04002852 RID: 10322
		[Token(Token = "0x4002852")]
		[FieldOffset(Offset = "0x18")]
		public int[] cookerArray;
	}
}
