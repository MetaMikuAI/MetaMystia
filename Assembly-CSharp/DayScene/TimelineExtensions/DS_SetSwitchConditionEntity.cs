using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x020004AD RID: 1197
	[Token(Token = "0x20004AD")]
	public class DS_SetSwitchConditionEntity : PlayableAsset
	{
		// Token: 0x06001B34 RID: 6964 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		[Token(Token = "0x6001B34")]
		[Address(RVA = "0x49A600", Offset = "0x499000", VA = "0x18049A600", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B35")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DS_SetSwitchConditionEntity()
		{
		}

		// Token: 0x04001909 RID: 6409
		[Token(Token = "0x4001909")]
		[FieldOffset(Offset = "0x18")]
		public string visualEntityLabel;

		// Token: 0x0400190A RID: 6410
		[Token(Token = "0x400190A")]
		[FieldOffset(Offset = "0x20")]
		public bool on;
	}
}
