using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FD1 RID: 4049
	[Token(Token = "0x2000FD1")]
	public class COM_FinishEvent : PlayableAsset
	{
		// Token: 0x06005EB7 RID: 24247 RVA: 0x00020CD0 File Offset: 0x0001EED0
		[Token(Token = "0x6005EB7")]
		[Address(RVA = "0x8BF450", Offset = "0x8BDE50", VA = "0x1808BF450", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EB8 RID: 24248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB8")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_FinishEvent()
		{
		}

		// Token: 0x040057B8 RID: 22456
		[Token(Token = "0x40057B8")]
		[FieldOffset(Offset = "0x18")]
		public string eventName;
	}
}
