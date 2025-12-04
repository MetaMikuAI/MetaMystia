using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FBC RID: 4028
	[Token(Token = "0x2000FBC")]
	public class COM_ACharacter_RotateZ : PlayableAsset
	{
		// Token: 0x06005E8D RID: 24205 RVA: 0x00020AD8 File Offset: 0x0001ECD8
		[Token(Token = "0x6005E8D")]
		[Address(RVA = "0x8BBEB0", Offset = "0x8BA8B0", VA = "0x1808BBEB0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005E8E RID: 24206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E8E")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_ACharacter_RotateZ()
		{
		}

		// Token: 0x04005788 RID: 22408
		[Token(Token = "0x4005788")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x04005789 RID: 22409
		[Token(Token = "0x4005789")]
		[FieldOffset(Offset = "0x20")]
		public float targetValue;

		// Token: 0x0400578A RID: 22410
		[Token(Token = "0x400578A")]
		[FieldOffset(Offset = "0x24")]
		public bool continuousRotationZ;
	}
}
