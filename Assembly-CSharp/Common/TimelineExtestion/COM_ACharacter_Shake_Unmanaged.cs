using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FC1 RID: 4033
	[Token(Token = "0x2000FC1")]
	public class COM_ACharacter_Shake_Unmanaged : PlayableAsset
	{
		// Token: 0x06005E97 RID: 24215 RVA: 0x00020B50 File Offset: 0x0001ED50
		[Token(Token = "0x6005E97")]
		[Address(RVA = "0x8BCC10", Offset = "0x8BB610", VA = "0x1808BCC10", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005E98 RID: 24216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E98")]
		[Address(RVA = "0x8BCD40", Offset = "0x8BB740", VA = "0x1808BCD40")]
		public COM_ACharacter_Shake_Unmanaged()
		{
		}

		// Token: 0x04005793 RID: 22419
		[Token(Token = "0x4005793")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x04005794 RID: 22420
		[Token(Token = "0x4005794")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 amplitude;
	}
}
