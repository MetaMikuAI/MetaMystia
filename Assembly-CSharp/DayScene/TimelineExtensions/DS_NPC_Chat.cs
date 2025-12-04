using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x020004A6 RID: 1190
	[Token(Token = "0x20004A6")]
	public class DS_NPC_Chat : PlayableAsset
	{
		// Token: 0x06001B26 RID: 6950 RVA: 0x0000A800 File Offset: 0x00008A00
		[Token(Token = "0x6001B26")]
		[Address(RVA = "0x498C90", Offset = "0x497690", VA = "0x180498C90", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06001B27 RID: 6951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B27")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DS_NPC_Chat()
		{
		}

		// Token: 0x040018E8 RID: 6376
		[Token(Token = "0x40018E8")]
		[FieldOffset(Offset = "0x18")]
		public string characterLabel;
	}
}
