using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000764 RID: 1892
	[Token(Token = "0x2000764")]
	public class NS_Override_Passion : PlayableAsset
	{
		// Token: 0x06002C12 RID: 11282 RVA: 0x0000FA38 File Offset: 0x0000DC38
		[Token(Token = "0x6002C12")]
		[Address(RVA = "0x5E27C0", Offset = "0x5E11C0", VA = "0x1805E27C0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C13")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_Override_Passion()
		{
		}

		// Token: 0x04002853 RID: 10323
		[Token(Token = "0x4002853")]
		[FieldOffset(Offset = "0x18")]
		public int newPassion;
	}
}
