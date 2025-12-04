using System;
using Common.Audio;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200017E RID: 382
	[Token(Token = "0x200017E")]
	[Serializable]
	public class SpellFire : PatchouliSpellBase
	{
		// Token: 0x060008E3 RID: 2275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x82CA80", Offset = "0x82B480", VA = "0x18082CA80", Slot = "4")]
		public override string DescriptionMethodB(string a, int _)
		{
			return null;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x82CAB0", Offset = "0x82B4B0", VA = "0x18082CAB0", Slot = "5")]
		public override string DescriptionMethodD(string oldText)
		{
			return null;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public SpellFire()
		{
		}

		// Token: 0x0400082D RID: 2093
		[Token(Token = "0x400082D")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float damagePercentage;

		// Token: 0x0400082E RID: 2094
		[Token(Token = "0x400082E")]
		[FieldOffset(Offset = "0x34")]
		public float amplitude;

		// Token: 0x0400082F RID: 2095
		[Token(Token = "0x400082F")]
		[FieldOffset(Offset = "0x38")]
		public float shakeDuration;

		// Token: 0x04000830 RID: 2096
		[Token(Token = "0x4000830")]
		[FieldOffset(Offset = "0x3C")]
		public float fadeTime;

		// Token: 0x04000831 RID: 2097
		[Token(Token = "0x4000831")]
		[FieldOffset(Offset = "0x40")]
		public int fireballNum;

		// Token: 0x04000832 RID: 2098
		[Token(Token = "0x4000832")]
		[FieldOffset(Offset = "0x48")]
		public VFXPrefab fireBallVfx;

		// Token: 0x04000833 RID: 2099
		[Token(Token = "0x4000833")]
		[FieldOffset(Offset = "0x60")]
		public VFXPrefab fireBombVFX;

		// Token: 0x04000834 RID: 2100
		[Token(Token = "0x4000834")]
		[FieldOffset(Offset = "0x78")]
		public float wholeDuration;

		// Token: 0x04000835 RID: 2101
		[Token(Token = "0x4000835")]
		[FieldOffset(Offset = "0x7C")]
		public float fireBallInterval;

		// Token: 0x04000836 RID: 2102
		[Token(Token = "0x4000836")]
		[FieldOffset(Offset = "0x80")]
		public GlobalAudioManager.DelayAudioClip fireBallSfx;
	}
}
