using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FB4 RID: 4020
	[Token(Token = "0x2000FB4")]
	public class COM_ACharacter_Delete : PlayableAsset
	{
		// Token: 0x06005E7D RID: 24189 RVA: 0x00020A18 File Offset: 0x0001EC18
		[Token(Token = "0x6005E7D")]
		[Address(RVA = "0x8BAE60", Offset = "0x8B9860", VA = "0x1808BAE60", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005E7E RID: 24190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E7E")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_ACharacter_Delete()
		{
		}

		// Token: 0x04005773 RID: 22387
		[Token(Token = "0x4005773")]
		[FieldOffset(Offset = "0x18")]
		public string label;
	}
}
