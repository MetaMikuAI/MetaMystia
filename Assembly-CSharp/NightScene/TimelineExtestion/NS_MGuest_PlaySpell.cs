using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000760 RID: 1888
	[Token(Token = "0x2000760")]
	public class NS_MGuest_PlaySpell : PlayableAsset
	{
		// Token: 0x06002C0A RID: 11274 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
		[Token(Token = "0x6002C0A")]
		[Address(RVA = "0x5E21D0", Offset = "0x5E0BD0", VA = "0x1805E21D0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0B")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_MGuest_PlaySpell()
		{
		}

		// Token: 0x0400284D RID: 10317
		[Token(Token = "0x400284D")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x0400284E RID: 10318
		[Token(Token = "0x400284E")]
		[FieldOffset(Offset = "0x20")]
		public bool isPositive;

		// Token: 0x0400284F RID: 10319
		[Token(Token = "0x400284F")]
		[FieldOffset(Offset = "0x21")]
		public bool visualOnly;
	}
}
