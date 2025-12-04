using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FBE RID: 4030
	[Token(Token = "0x2000FBE")]
	public class COM_ACharacter_SetVisualActive : PlayableAsset
	{
		// Token: 0x06005E91 RID: 24209 RVA: 0x00020B08 File Offset: 0x0001ED08
		[Token(Token = "0x6005E91")]
		[Address(RVA = "0x8BC660", Offset = "0x8BB060", VA = "0x1808BC660", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005E92 RID: 24210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E92")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_ACharacter_SetVisualActive()
		{
		}

		// Token: 0x0400578C RID: 22412
		[Token(Token = "0x400578C")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x0400578D RID: 22413
		[Token(Token = "0x400578D")]
		[FieldOffset(Offset = "0x20")]
		public bool visualActive;
	}
}
