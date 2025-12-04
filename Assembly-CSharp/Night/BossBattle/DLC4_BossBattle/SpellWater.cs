using System;
using Il2CppDummyDll;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200017D RID: 381
	[Token(Token = "0x200017D")]
	[Serializable]
	public class SpellWater : PatchouliSpellBase
	{
		// Token: 0x060008E0 RID: 2272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x82CCD0", Offset = "0x82B6D0", VA = "0x18082CCD0", Slot = "4")]
		public override string DescriptionMethodB(string oldText, int currentTime)
		{
			return null;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x82CD90", Offset = "0x82B790", VA = "0x18082CD90", Slot = "5")]
		public override string DescriptionMethodD(string oldText)
		{
			return null;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public SpellWater()
		{
		}

		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		[FieldOffset(Offset = "0x30")]
		public float extraCoolDownMultiplier;
	}
}
