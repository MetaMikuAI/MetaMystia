using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001D8 RID: 472
	[Token(Token = "0x20001D8")]
	public class GuardBuff
	{
		// Token: 0x06000B6A RID: 2922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x8D9BA0", Offset = "0x8D85A0", VA = "0x1808D9BA0")]
		public GuardBuff(GuardBuff.GuardBuffType bufftype, float duration, Action onBuffEnd, Action<GameObject> onBuffEffectEnd, GameObject controlledEffect)
		{
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000B6B RID: 2923 RVA: 0x00005190 File Offset: 0x00003390
		[Token(Token = "0x1700012E")]
		public GuardBuff.GuardBuffType Bufftype
		{
			[Token(Token = "0x6000B6B")]
			[Address(RVA = "0x44F9E0", Offset = "0x44E3E0", VA = "0x18044F9E0")]
			[CompilerGenerated]
			get
			{
				return GuardBuff.GuardBuffType.Shinmyoumaru_YuuSha;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x000051A8 File Offset: 0x000033A8
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012F")]
		public float RemainingDuration
		{
			[Token(Token = "0x6000B6C")]
			[Address(RVA = "0x689190", Offset = "0x687B90", VA = "0x180689190")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0x6FC850", Offset = "0x6FB250", VA = "0x1806FC850")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x8D9B40", Offset = "0x8D8540", VA = "0x1808D9B40")]
		public void OnBuffEnd()
		{
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x8D9B80", Offset = "0x8D8580", VA = "0x1808D9B80")]
		public void PlayOnBuffEndEffect()
		{
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x3F2100", Offset = "0x3F0B00", VA = "0x1803F2100")]
		public void SetNewBuffEndAction(Action newOnBuffEnd)
		{
		}

		// Token: 0x04000A05 RID: 2565
		[Token(Token = "0x4000A05")]
		[FieldOffset(Offset = "0x10")]
		private readonly GameObject controlledEffect;

		// Token: 0x04000A06 RID: 2566
		[Token(Token = "0x4000A06")]
		[FieldOffset(Offset = "0x18")]
		private readonly Action<GameObject> onBuffEffectEnd;

		// Token: 0x04000A07 RID: 2567
		[Token(Token = "0x4000A07")]
		[FieldOffset(Offset = "0x20")]
		private Action onBuffEnd;

		// Token: 0x020001D9 RID: 473
		[Token(Token = "0x20001D9")]
		public enum GuardBuffType
		{
			// Token: 0x04000A0B RID: 2571
			[Token(Token = "0x4000A0B")]
			Shinmyoumaru_YuuSha,
			// Token: 0x04000A0C RID: 2572
			[Token(Token = "0x4000A0C")]
			Kagerou_PowerUp
		}
	}
}
