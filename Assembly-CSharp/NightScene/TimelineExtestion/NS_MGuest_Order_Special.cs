using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200075D RID: 1885
	[Token(Token = "0x200075D")]
	public class NS_MGuest_Order_Special : PlayableAsset
	{
		// Token: 0x06002C04 RID: 11268 RVA: 0x0000F990 File Offset: 0x0000DB90
		[Token(Token = "0x6002C04")]
		[Address(RVA = "0x5E1AC0", Offset = "0x5E04C0", VA = "0x1805E1AC0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C05")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_MGuest_Order_Special()
		{
		}

		// Token: 0x04002843 RID: 10307
		[Token(Token = "0x4002843")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x04002844 RID: 10308
		[Token(Token = "0x4002844")]
		[FieldOffset(Offset = "0x20")]
		public int foodTag;

		// Token: 0x04002845 RID: 10309
		[Token(Token = "0x4002845")]
		[FieldOffset(Offset = "0x24")]
		public int bevTag;
	}
}
