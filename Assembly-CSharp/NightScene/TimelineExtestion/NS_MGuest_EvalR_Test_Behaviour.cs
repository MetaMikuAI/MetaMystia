using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.TimelineExtestion;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000741 RID: 1857
	[Token(Token = "0x2000741")]
	public class NS_MGuest_EvalR_Test_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06002BCA RID: 11210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005F2")]
		public static List<GuestGroupController.EvaluationResult> Results
		{
			[Token(Token = "0x6002BCA")]
			[Address(RVA = "0x5E0D20", Offset = "0x5DF720", VA = "0x1805E0D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BCB")]
		[Address(RVA = "0x5E0B40", Offset = "0x5DF540", VA = "0x1805E0B40", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BCC")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_MGuest_EvalR_Test_Behaviour()
		{
		}

		// Token: 0x04002819 RID: 10265
		[Token(Token = "0x4002819")]
		[FieldOffset(Offset = "0x10")]
		public GuestGroupController.EvaluationResult[] conditions;

		// Token: 0x0400281A RID: 10266
		[Token(Token = "0x400281A")]
		[FieldOffset(Offset = "0x18")]
		public bool oneFailThenFailed;

		// Token: 0x0400281B RID: 10267
		[Token(Token = "0x400281B")]
		[FieldOffset(Offset = "0x1C")]
		public int ticks;
	}
}
