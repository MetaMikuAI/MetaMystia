using System;
using System.Runtime.CompilerServices;
using Common.TimelineExtestion;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000496 RID: 1174
	[Token(Token = "0x2000496")]
	public class DS_MoveToMap_AtWorldPos_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06001AFB RID: 6907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFB")]
		[Address(RVA = "0x498880", Offset = "0x497280", VA = "0x180498880", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFC")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public DS_MoveToMap_AtWorldPos_Behaviour()
		{
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFD")]
		[Address(RVA = "0x498980", Offset = "0x497380", VA = "0x180498980")]
		[CompilerGenerated]
		private void <OnBehaviourEnter>g__OnBeforeContinue|5_0()
		{
		}

		// Token: 0x040018A9 RID: 6313
		[Token(Token = "0x40018A9")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 position;

		// Token: 0x040018AA RID: 6314
		[Token(Token = "0x40018AA")]
		[FieldOffset(Offset = "0x18")]
		public bool shouldCostAction;

		// Token: 0x040018AB RID: 6315
		[Token(Token = "0x40018AB")]
		[FieldOffset(Offset = "0x19")]
		public bool shouldFadeInFadeOut;

		// Token: 0x040018AC RID: 6316
		[Token(Token = "0x40018AC")]
		[FieldOffset(Offset = "0x20")]
		public string targetMapLabel;

		// Token: 0x040018AD RID: 6317
		[Token(Token = "0x40018AD")]
		[FieldOffset(Offset = "0x28")]
		public bool triggerEnterMapEvent;
	}
}
