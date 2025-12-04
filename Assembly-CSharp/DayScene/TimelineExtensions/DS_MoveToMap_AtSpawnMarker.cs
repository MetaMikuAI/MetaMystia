using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x020004A3 RID: 1187
	[Token(Token = "0x20004A3")]
	public class DS_MoveToMap_AtSpawnMarker : PlayableAsset
	{
		// Token: 0x06001B20 RID: 6944 RVA: 0x0000A7B8 File Offset: 0x000089B8
		[Token(Token = "0x6001B20")]
		[Address(RVA = "0x4986E0", Offset = "0x4970E0", VA = "0x1804986E0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B21")]
		[Address(RVA = "0x498870", Offset = "0x497270", VA = "0x180498870")]
		public DS_MoveToMap_AtSpawnMarker()
		{
		}

		// Token: 0x040018DA RID: 6362
		[Token(Token = "0x40018DA")]
		[FieldOffset(Offset = "0x18")]
		public string targetMapLabel;

		// Token: 0x040018DB RID: 6363
		[Token(Token = "0x40018DB")]
		[FieldOffset(Offset = "0x20")]
		public string targetMarkerName;

		// Token: 0x040018DC RID: 6364
		[Token(Token = "0x40018DC")]
		[FieldOffset(Offset = "0x28")]
		public bool shouldCostAction;

		// Token: 0x040018DD RID: 6365
		[Token(Token = "0x40018DD")]
		[FieldOffset(Offset = "0x29")]
		public bool shouldFadeInFadeOut;

		// Token: 0x040018DE RID: 6366
		[Token(Token = "0x40018DE")]
		[FieldOffset(Offset = "0x2A")]
		public bool triggerEnterMapEvent;
	}
}
