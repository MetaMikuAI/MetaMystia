using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000755 RID: 1877
	[Token(Token = "0x2000755")]
	public class NS_LogicBranch_ChatConfirmation : PlayableAsset
	{
		// Token: 0x06002BF4 RID: 11252 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
		[Token(Token = "0x6002BF4")]
		[Address(RVA = "0x5E05B0", Offset = "0x5DEFB0", VA = "0x1805E05B0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002BF5 RID: 11253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BF5")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_LogicBranch_ChatConfirmation()
		{
		}

		// Token: 0x04002831 RID: 10289
		[Token(Token = "0x4002831")]
		[FieldOffset(Offset = "0x18")]
		public int acceptAddFrames;

		// Token: 0x04002832 RID: 10290
		[Token(Token = "0x4002832")]
		[FieldOffset(Offset = "0x1C")]
		public int refuseAddFrames;
	}
}
