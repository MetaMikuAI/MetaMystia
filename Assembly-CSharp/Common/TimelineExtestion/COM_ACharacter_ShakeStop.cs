using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FC0 RID: 4032
	[Token(Token = "0x2000FC0")]
	public class COM_ACharacter_ShakeStop : PlayableAsset
	{
		// Token: 0x06005E95 RID: 24213 RVA: 0x00020B38 File Offset: 0x0001ED38
		[Token(Token = "0x6005E95")]
		[Address(RVA = "0x8BC800", Offset = "0x8BB200", VA = "0x1808BC800", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005E96 RID: 24214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E96")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_ACharacter_ShakeStop()
		{
		}

		// Token: 0x04005792 RID: 22418
		[Token(Token = "0x4005792")]
		[FieldOffset(Offset = "0x18")]
		public string label;
	}
}
