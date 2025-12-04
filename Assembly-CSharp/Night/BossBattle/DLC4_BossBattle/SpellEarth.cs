using System;
using Common.Audio;
using Il2CppDummyDll;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200017F RID: 383
	[Token(Token = "0x200017F")]
	[Serializable]
	public class SpellEarth : PatchouliSpellBase
	{
		// Token: 0x060008E6 RID: 2278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x82CA50", Offset = "0x82B450", VA = "0x18082CA50", Slot = "4")]
		public override string DescriptionMethodB(string oldText, int currentTime)
		{
			return null;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public SpellEarth()
		{
		}

		// Token: 0x04000837 RID: 2103
		[Token(Token = "0x4000837")]
		[FieldOffset(Offset = "0x30")]
		public float amplitude;

		// Token: 0x04000838 RID: 2104
		[Token(Token = "0x4000838")]
		[FieldOffset(Offset = "0x34")]
		public float shakeDuration;

		// Token: 0x04000839 RID: 2105
		[Token(Token = "0x4000839")]
		[FieldOffset(Offset = "0x38")]
		public float fadeTime;

		// Token: 0x0400083A RID: 2106
		[Token(Token = "0x400083A")]
		[FieldOffset(Offset = "0x40")]
		public GlobalAudioManager.DelayAudioClip earthQuakeSfx;
	}
}
