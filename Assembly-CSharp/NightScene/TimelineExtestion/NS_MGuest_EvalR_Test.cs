using System;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000758 RID: 1880
	[Token(Token = "0x2000758")]
	public class NS_MGuest_EvalR_Test : PlayableAsset
	{
		// Token: 0x06002BFA RID: 11258 RVA: 0x0000F918 File Offset: 0x0000DB18
		[Token(Token = "0x6002BFA")]
		[Address(RVA = "0x5E0D70", Offset = "0x5DF770", VA = "0x1805E0D70", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BFB")]
		[Address(RVA = "0x5E0EB0", Offset = "0x5DF8B0", VA = "0x1805E0EB0")]
		public NS_MGuest_EvalR_Test()
		{
		}

		// Token: 0x04002834 RID: 10292
		[Token(Token = "0x4002834")]
		[FieldOffset(Offset = "0x18")]
		public int ticks;

		// Token: 0x04002835 RID: 10293
		[Token(Token = "0x4002835")]
		[FieldOffset(Offset = "0x20")]
		public GuestGroupController.EvaluationResult[] conditions;

		// Token: 0x04002836 RID: 10294
		[Token(Token = "0x4002836")]
		[FieldOffset(Offset = "0x28")]
		public bool oneFailThenFailed;
	}
}
