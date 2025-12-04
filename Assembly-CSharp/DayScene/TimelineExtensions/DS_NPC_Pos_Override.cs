using System;
using DayScene.Input;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x020004A7 RID: 1191
	[Token(Token = "0x20004A7")]
	public class DS_NPC_Pos_Override : PlayableAsset
	{
		// Token: 0x06001B28 RID: 6952 RVA: 0x0000A818 File Offset: 0x00008A18
		[Token(Token = "0x6001B28")]
		[Address(RVA = "0x4994F0", Offset = "0x497EF0", VA = "0x1804994F0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06001B29 RID: 6953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B29")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DS_NPC_Pos_Override()
		{
		}

		// Token: 0x040018E9 RID: 6377
		[Token(Token = "0x40018E9")]
		[FieldOffset(Offset = "0x18")]
		public string characterLabel;

		// Token: 0x040018EA RID: 6378
		[Token(Token = "0x40018EA")]
		[FieldOffset(Offset = "0x20")]
		public string mapLabel;

		// Token: 0x040018EB RID: 6379
		[Token(Token = "0x40018EB")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 position;

		// Token: 0x040018EC RID: 6380
		[Token(Token = "0x40018EC")]
		[FieldOffset(Offset = "0x30")]
		public DayScenePlayerInputGenerator.CharacterRotation rotation;
	}
}
