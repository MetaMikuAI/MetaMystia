using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FE7 RID: 4071
	[Token(Token = "0x2000FE7")]
	public class COM_WorldOverlay_Move : PlayableAsset
	{
		// Token: 0x06005EE3 RID: 24291 RVA: 0x00020EE0 File Offset: 0x0001F0E0
		[Token(Token = "0x6005EE3")]
		[Address(RVA = "0x8C2070", Offset = "0x8C0A70", VA = "0x1808C2070", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EE4 RID: 24292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE4")]
		[Address(RVA = "0x8BBA60", Offset = "0x8BA460", VA = "0x1808BBA60")]
		public COM_WorldOverlay_Move()
		{
		}

		// Token: 0x040057D2 RID: 22482
		[Token(Token = "0x40057D2")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x040057D3 RID: 22483
		[Token(Token = "0x40057D3")]
		[FieldOffset(Offset = "0x20")]
		public Vector2[] wayPoints;

		// Token: 0x040057D4 RID: 22484
		[Token(Token = "0x40057D4")]
		[FieldOffset(Offset = "0x28")]
		public float speedMultiplier;

		// Token: 0x040057D5 RID: 22485
		[Token(Token = "0x40057D5")]
		[FieldOffset(Offset = "0x2C")]
		public bool shouldWaitForFinish;
	}
}
