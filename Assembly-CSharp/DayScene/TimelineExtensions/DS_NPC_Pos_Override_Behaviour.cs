using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200048A RID: 1162
	[Token(Token = "0x200048A")]
	public class DS_NPC_Pos_Override_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06001AD8 RID: 6872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD8")]
		[Address(RVA = "0x499460", Offset = "0x497E60", VA = "0x180499460", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD9")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public DS_NPC_Pos_Override_Behaviour()
		{
		}

		// Token: 0x0400188B RID: 6283
		[Token(Token = "0x400188B")]
		[FieldOffset(Offset = "0x10")]
		public string characterLabel;

		// Token: 0x0400188C RID: 6284
		[Token(Token = "0x400188C")]
		[FieldOffset(Offset = "0x18")]
		public string mapLabel;

		// Token: 0x0400188D RID: 6285
		[Token(Token = "0x400188D")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 position;

		// Token: 0x0400188E RID: 6286
		[Token(Token = "0x400188E")]
		[FieldOffset(Offset = "0x28")]
		public int rotation;
	}
}
