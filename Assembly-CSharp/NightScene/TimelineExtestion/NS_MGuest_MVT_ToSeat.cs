using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200075B RID: 1883
	[Token(Token = "0x200075B")]
	public class NS_MGuest_MVT_ToSeat : PlayableAsset
	{
		// Token: 0x06002C00 RID: 11264 RVA: 0x0000F960 File Offset: 0x0000DB60
		[Token(Token = "0x6002C00")]
		[Address(RVA = "0x5E1460", Offset = "0x5DFE60", VA = "0x1805E1460", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C01")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_MGuest_MVT_ToSeat()
		{
		}

		// Token: 0x0400283C RID: 10300
		[Token(Token = "0x400283C")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x0400283D RID: 10301
		[Token(Token = "0x400283D")]
		[FieldOffset(Offset = "0x20")]
		public int mood;

		// Token: 0x0400283E RID: 10302
		[Token(Token = "0x400283E")]
		[FieldOffset(Offset = "0x24")]
		public int deskCode;

		// Token: 0x0400283F RID: 10303
		[Token(Token = "0x400283F")]
		[FieldOffset(Offset = "0x28")]
		public bool shouldWaitForFinish;
	}
}
