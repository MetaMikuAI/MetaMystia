using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FE5 RID: 4069
	[Token(Token = "0x2000FE5")]
	public class COM_WorldOverlay_Follow : PlayableAsset
	{
		// Token: 0x06005EDF RID: 24287 RVA: 0x00020EB0 File Offset: 0x0001F0B0
		[Token(Token = "0x6005EDF")]
		[Address(RVA = "0x8C1E10", Offset = "0x8C0810", VA = "0x1808C1E10", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EE0 RID: 24288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE0")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_WorldOverlay_Follow()
		{
		}

		// Token: 0x040057CF RID: 22479
		[Token(Token = "0x40057CF")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x040057D0 RID: 22480
		[Token(Token = "0x40057D0")]
		[FieldOffset(Offset = "0x20")]
		public string targetLabel;
	}
}
