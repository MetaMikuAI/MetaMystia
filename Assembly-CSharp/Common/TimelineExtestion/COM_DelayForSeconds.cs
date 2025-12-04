using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FD0 RID: 4048
	[Token(Token = "0x2000FD0")]
	public class COM_DelayForSeconds : PlayableAsset
	{
		// Token: 0x06005EB5 RID: 24245 RVA: 0x00020CB8 File Offset: 0x0001EEB8
		[Token(Token = "0x6005EB5")]
		[Address(RVA = "0x8BF300", Offset = "0x8BDD00", VA = "0x1808BF300", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EB6 RID: 24246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB6")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_DelayForSeconds()
		{
		}

		// Token: 0x040057B7 RID: 22455
		[Token(Token = "0x40057B7")]
		[FieldOffset(Offset = "0x18")]
		public float delayDuration;
	}
}
