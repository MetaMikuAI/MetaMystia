using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000759 RID: 1881
	[Token(Token = "0x2000759")]
	public class NS_MGuest_MVT_Leave : PlayableAsset
	{
		// Token: 0x06002BFC RID: 11260 RVA: 0x0000F930 File Offset: 0x0000DB30
		[Token(Token = "0x6002BFC")]
		[Address(RVA = "0x5E0F20", Offset = "0x5DF920", VA = "0x1805E0F20", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BFD")]
		[Address(RVA = "0x5E1040", Offset = "0x5DFA40", VA = "0x1805E1040")]
		public NS_MGuest_MVT_Leave()
		{
		}

		// Token: 0x04002837 RID: 10295
		[Token(Token = "0x4002837")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x04002838 RID: 10296
		[Token(Token = "0x4002838")]
		[FieldOffset(Offset = "0x20")]
		public bool shouldLeaveInstantly;
	}
}
