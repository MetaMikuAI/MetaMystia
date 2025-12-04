using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000182 RID: 386
	[Token(Token = "0x2000182")]
	public class PatchouliSpellBase
	{
		// Token: 0x060008EA RID: 2282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x82C980", Offset = "0x82B380", VA = "0x18082C980", Slot = "4")]
		public virtual string DescriptionMethodB(string oldText, int currentTime)
		{
			return null;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x82C9E0", Offset = "0x82B3E0", VA = "0x18082C9E0", Slot = "5")]
		public virtual string DescriptionMethodD(string oldText)
		{
			return null;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public PatchouliSpellBase()
		{
		}

		// Token: 0x0400083B RID: 2107
		[Token(Token = "0x400083B")]
		[FieldOffset(Offset = "0x10")]
		public int duration;

		// Token: 0x0400083C RID: 2108
		[Token(Token = "0x400083C")]
		[FieldOffset(Offset = "0x18")]
		public GameObject endVfx;

		// Token: 0x0400083D RID: 2109
		[Token(Token = "0x400083D")]
		[FieldOffset(Offset = "0x20")]
		public PatchouliMagicSpellCardIndex index;

		// Token: 0x0400083E RID: 2110
		[Token(Token = "0x400083E")]
		[FieldOffset(Offset = "0x28")]
		public GameObject vfx;
	}
}
