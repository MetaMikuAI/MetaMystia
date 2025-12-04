using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FE9 RID: 4073
	[Token(Token = "0x2000FE9")]
	public class COM_WorldOverlay_TriggerAnimation : PlayableAsset
	{
		// Token: 0x06005EE7 RID: 24295 RVA: 0x00020F10 File Offset: 0x0001F110
		[Token(Token = "0x6005EE7")]
		[Address(RVA = "0x8C2670", Offset = "0x8C1070", VA = "0x1808C2670", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EE8 RID: 24296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE8")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_WorldOverlay_TriggerAnimation()
		{
		}

		// Token: 0x040057E2 RID: 22498
		[Token(Token = "0x40057E2")]
		[FieldOffset(Offset = "0x18")]
		public string animationTriggerlabel;

		// Token: 0x040057E3 RID: 22499
		[Token(Token = "0x40057E3")]
		[FieldOffset(Offset = "0x20")]
		public string label;
	}
}
