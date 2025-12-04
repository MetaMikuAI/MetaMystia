using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000761 RID: 1889
	[Token(Token = "0x2000761")]
	public class NS_MGuest_SetPatient : PlayableAsset
	{
		// Token: 0x06002C0C RID: 11276 RVA: 0x0000F9F0 File Offset: 0x0000DBF0
		[Token(Token = "0x6002C0C")]
		[Address(RVA = "0x5E2370", Offset = "0x5E0D70", VA = "0x1805E2370", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002C0D RID: 11277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C0D")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_MGuest_SetPatient()
		{
		}

		// Token: 0x04002850 RID: 10320
		[Token(Token = "0x4002850")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x04002851 RID: 10321
		[Token(Token = "0x4002851")]
		[FieldOffset(Offset = "0x20")]
		public int targetPatient;
	}
}
