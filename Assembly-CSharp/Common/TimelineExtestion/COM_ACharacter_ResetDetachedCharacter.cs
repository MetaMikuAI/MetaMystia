using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FBA RID: 4026
	[Token(Token = "0x2000FBA")]
	public class COM_ACharacter_ResetDetachedCharacter : PlayableAsset
	{
		// Token: 0x06005E89 RID: 24201 RVA: 0x00020AA8 File Offset: 0x0001ECA8
		[Token(Token = "0x6005E89")]
		[Address(RVA = "0x8BBDA0", Offset = "0x8BA7A0", VA = "0x1808BBDA0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005E8A RID: 24202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E8A")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_ACharacter_ResetDetachedCharacter()
		{
		}

		// Token: 0x04005785 RID: 22405
		[Token(Token = "0x4005785")]
		[FieldOffset(Offset = "0x18")]
		public string detachedCharacterLabel;
	}
}
