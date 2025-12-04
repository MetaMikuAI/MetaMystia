using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FB7 RID: 4023
	[Token(Token = "0x2000FB7")]
	public class COM_ACharacter_Jump : PlayableAsset
	{
		// Token: 0x06005E83 RID: 24195 RVA: 0x00020A60 File Offset: 0x0001EC60
		[Token(Token = "0x6005E83")]
		[Address(RVA = "0x8BB530", Offset = "0x8B9F30", VA = "0x1808BB530", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005E84 RID: 24196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E84")]
		[Address(RVA = "0x8BB6F0", Offset = "0x8BA0F0", VA = "0x1808BB6F0")]
		public COM_ACharacter_Jump()
		{
		}

		// Token: 0x0400577A RID: 22394
		[Token(Token = "0x400577A")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x0400577B RID: 22395
		[Token(Token = "0x400577B")]
		[FieldOffset(Offset = "0x20")]
		public float startPoint;

		// Token: 0x0400577C RID: 22396
		[Token(Token = "0x400577C")]
		[FieldOffset(Offset = "0x24")]
		public float jumpHeight;

		// Token: 0x0400577D RID: 22397
		[Token(Token = "0x400577D")]
		[FieldOffset(Offset = "0x28")]
		public int jumpCount;

		// Token: 0x0400577E RID: 22398
		[Token(Token = "0x400577E")]
		[FieldOffset(Offset = "0x2C")]
		public float jumpInterval;

		// Token: 0x0400577F RID: 22399
		[Token(Token = "0x400577F")]
		[FieldOffset(Offset = "0x30")]
		public bool shouldWaitForFinish;
	}
}
