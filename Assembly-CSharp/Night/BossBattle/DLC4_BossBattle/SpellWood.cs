using System;
using Il2CppDummyDll;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200017C RID: 380
	[Token(Token = "0x200017C")]
	[Serializable]
	public class SpellWood : PatchouliSpellBase
	{
		// Token: 0x060008DD RID: 2269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x82CE50", Offset = "0x82B850", VA = "0x18082CE50", Slot = "4")]
		public override string DescriptionMethodB(string oldText, int currentTime)
		{
			return null;
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x82CF10", Offset = "0x82B910", VA = "0x18082CF10", Slot = "5")]
		public override string DescriptionMethodD(string oldText)
		{
			return null;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public SpellWood()
		{
		}

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		[FieldOffset(Offset = "0x30")]
		public float extraAttackSpeedMultiplier;
	}
}
