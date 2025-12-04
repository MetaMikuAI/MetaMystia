using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000499 RID: 1177
	[Token(Token = "0x2000499")]
	public class DS_HakureiFestival_SpecialEffectSet_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06001B02 RID: 6914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B02")]
		[Address(RVA = "0x497AA0", Offset = "0x4964A0", VA = "0x180497AA0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B03")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public DS_HakureiFestival_SpecialEffectSet_Behaviour()
		{
		}

		// Token: 0x040018B1 RID: 6321
		[Token(Token = "0x40018B1")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		// Token: 0x040018B2 RID: 6322
		[Token(Token = "0x40018B2")]
		[FieldOffset(Offset = "0x18")]
		public bool open;

		// Token: 0x040018B3 RID: 6323
		[Token(Token = "0x40018B3")]
		[FieldOffset(Offset = "0x1C")]
		public float transitionDuration;

		// Token: 0x040018B4 RID: 6324
		[Token(Token = "0x40018B4")]
		[FieldOffset(Offset = "0x20")]
		public HakureiFestivalMap.ViewLabel viewLabel;

		// Token: 0x040018B5 RID: 6325
		[Token(Token = "0x40018B5")]
		[FieldOffset(Offset = "0x24")]
		public Vector2 worldPosition;
	}
}
