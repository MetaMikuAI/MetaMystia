using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FBF RID: 4031
	[Token(Token = "0x2000FBF")]
	public class COM_ACharacter_Shake : PlayableAsset
	{
		// Token: 0x06005E93 RID: 24211 RVA: 0x00020B20 File Offset: 0x0001ED20
		[Token(Token = "0x6005E93")]
		[Address(RVA = "0x8BCA30", Offset = "0x8BB430", VA = "0x1808BCA30", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005E94 RID: 24212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E94")]
		[Address(RVA = "0x8BCD40", Offset = "0x8BB740", VA = "0x1808BCD40")]
		public COM_ACharacter_Shake()
		{
		}

		// Token: 0x0400578E RID: 22414
		[Token(Token = "0x400578E")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x0400578F RID: 22415
		[Token(Token = "0x400578F")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 amplitude;

		// Token: 0x04005790 RID: 22416
		[Token(Token = "0x4005790")]
		[FieldOffset(Offset = "0x28")]
		public float timeLength;

		// Token: 0x04005791 RID: 22417
		[Token(Token = "0x4005791")]
		[FieldOffset(Offset = "0x2C")]
		public bool shouldWaitForFinish;
	}
}
