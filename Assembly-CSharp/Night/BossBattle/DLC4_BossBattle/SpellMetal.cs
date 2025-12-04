using System;
using Il2CppDummyDll;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200017B RID: 379
	[Token(Token = "0x200017B")]
	[Serializable]
	public class SpellMetal : PatchouliSpellBase
	{
		// Token: 0x060008DA RID: 2266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x82CB30", Offset = "0x82B530", VA = "0x18082CB30", Slot = "4")]
		public override string DescriptionMethodB(string oldText, int currentTime)
		{
			return null;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x82CC00", Offset = "0x82B600", VA = "0x18082CC00", Slot = "5")]
		public override string DescriptionMethodD(string oldText)
		{
			return null;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public SpellMetal()
		{
		}

		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x4000829")]
		[FieldOffset(Offset = "0x30")]
		public int pGetPerSec;

		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		[FieldOffset(Offset = "0x34")]
		public int basePLine;
	}
}
