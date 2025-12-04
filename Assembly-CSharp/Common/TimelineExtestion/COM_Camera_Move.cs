using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FCA RID: 4042
	[Token(Token = "0x2000FCA")]
	public class COM_Camera_Move : PlayableAsset
	{
		// Token: 0x06005EA9 RID: 24233 RVA: 0x00020C28 File Offset: 0x0001EE28
		[Token(Token = "0x6005EA9")]
		[Address(RVA = "0x8BE3A0", Offset = "0x8BCDA0", VA = "0x1808BE3A0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EAA RID: 24234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EAA")]
		[Address(RVA = "0x8BBA60", Offset = "0x8BA460", VA = "0x1808BBA60")]
		public COM_Camera_Move()
		{
		}

		// Token: 0x040057A8 RID: 22440
		[Token(Token = "0x40057A8")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 startPoint;

		// Token: 0x040057A9 RID: 22441
		[Token(Token = "0x40057A9")]
		[FieldOffset(Offset = "0x20")]
		public Vector2[] wayPoints;

		// Token: 0x040057AA RID: 22442
		[Token(Token = "0x40057AA")]
		[FieldOffset(Offset = "0x28")]
		public float speedMultiplier;

		// Token: 0x040057AB RID: 22443
		[Token(Token = "0x40057AB")]
		[FieldOffset(Offset = "0x2C")]
		public bool shouldWaitForFinish;
	}
}
