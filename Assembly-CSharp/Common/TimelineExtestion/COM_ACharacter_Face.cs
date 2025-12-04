using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FB6 RID: 4022
	[Token(Token = "0x2000FB6")]
	public class COM_ACharacter_Face : PlayableAsset
	{
		// Token: 0x06005E81 RID: 24193 RVA: 0x00020A48 File Offset: 0x0001EC48
		[Token(Token = "0x6005E81")]
		[Address(RVA = "0x8BB2C0", Offset = "0x8B9CC0", VA = "0x1808BB2C0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005E82 RID: 24194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E82")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_ACharacter_Face()
		{
		}

		// Token: 0x04005778 RID: 22392
		[Token(Token = "0x4005778")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x04005779 RID: 22393
		[Token(Token = "0x4005779")]
		[FieldOffset(Offset = "0x20")]
		public COM_ACharacter_Face_Behaviour.FaceID faceID;
	}
}
