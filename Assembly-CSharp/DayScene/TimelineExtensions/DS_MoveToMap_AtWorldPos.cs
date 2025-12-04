using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x020004A4 RID: 1188
	[Token(Token = "0x20004A4")]
	public class DS_MoveToMap_AtWorldPos : PlayableAsset
	{
		// Token: 0x06001B22 RID: 6946 RVA: 0x0000A7D0 File Offset: 0x000089D0
		[Token(Token = "0x6001B22")]
		[Address(RVA = "0x498A20", Offset = "0x497420", VA = "0x180498A20", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B23")]
		[Address(RVA = "0x498870", Offset = "0x497270", VA = "0x180498870")]
		public DS_MoveToMap_AtWorldPos()
		{
		}

		// Token: 0x040018DF RID: 6367
		[Token(Token = "0x40018DF")]
		[FieldOffset(Offset = "0x18")]
		public string targetMapLabel;

		// Token: 0x040018E0 RID: 6368
		[Token(Token = "0x40018E0")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 targetPosition;

		// Token: 0x040018E1 RID: 6369
		[Token(Token = "0x40018E1")]
		[FieldOffset(Offset = "0x28")]
		public bool shouldCostAction;

		// Token: 0x040018E2 RID: 6370
		[Token(Token = "0x40018E2")]
		[FieldOffset(Offset = "0x29")]
		public bool shouldFadeInFadeOut;

		// Token: 0x040018E3 RID: 6371
		[Token(Token = "0x40018E3")]
		[FieldOffset(Offset = "0x2A")]
		public bool triggerEnterMapEvent;
	}
}
