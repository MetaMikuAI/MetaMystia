using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x020004A9 RID: 1193
	[Token(Token = "0x20004A9")]
	public class DS_NPC_Pos_Reset : PlayableAsset
	{
		// Token: 0x06001B2C RID: 6956 RVA: 0x0000A848 File Offset: 0x00008A48
		[Token(Token = "0x6001B2C")]
		[Address(RVA = "0x499930", Offset = "0x498330", VA = "0x180499930", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06001B2D RID: 6957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B2D")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DS_NPC_Pos_Reset()
		{
		}

		// Token: 0x040018F8 RID: 6392
		[Token(Token = "0x40018F8")]
		[FieldOffset(Offset = "0x18")]
		public string characterLabel;
	}
}
