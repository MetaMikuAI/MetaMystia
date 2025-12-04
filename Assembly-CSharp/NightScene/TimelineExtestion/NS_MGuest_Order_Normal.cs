using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200075C RID: 1884
	[Token(Token = "0x200075C")]
	public class NS_MGuest_Order_Normal : PlayableAsset
	{
		// Token: 0x06002C02 RID: 11266 RVA: 0x0000F978 File Offset: 0x0000DB78
		[Token(Token = "0x6002C02")]
		[Address(RVA = "0x5E17A0", Offset = "0x5E01A0", VA = "0x1805E17A0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C03")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_MGuest_Order_Normal()
		{
		}

		// Token: 0x04002840 RID: 10304
		[Token(Token = "0x4002840")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x04002841 RID: 10305
		[Token(Token = "0x4002841")]
		[FieldOffset(Offset = "0x20")]
		public int foodId;

		// Token: 0x04002842 RID: 10306
		[Token(Token = "0x4002842")]
		[FieldOffset(Offset = "0x24")]
		public int bevId;
	}
}
