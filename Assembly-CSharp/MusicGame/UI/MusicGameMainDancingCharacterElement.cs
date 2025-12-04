using System;
using System.Collections.Generic;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityEngine;

namespace MusicGame.UI
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	public class MusicGameMainDancingCharacterElement : MonoBehaviour
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000021")]
		public UIElementCluster UIElementCluster
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		public Animator BaseAnimator
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x411CC0", Offset = "0x4106C0", VA = "0x180411CC0")]
		public void SwapSprite(string args)
		{
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x4117F0", Offset = "0x4101F0", VA = "0x1804117F0")]
		public bool IsFish()
		{
			return default(bool);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x411830", Offset = "0x410230", VA = "0x180411830")]
		public bool IsHead()
		{
			return default(bool);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x411870", Offset = "0x410270", VA = "0x180411870")]
		public bool IsHina()
		{
			return default(bool);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x4118B0", Offset = "0x4102B0", VA = "0x1804118B0")]
		public bool IsMystia()
		{
			return default(bool);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x410B70", Offset = "0x40F570", VA = "0x180410B70")]
		public void InitializeForMystia()
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x410BB0", Offset = "0x40F5B0", VA = "0x180410BB0")]
		public void Initialize(string label)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x4119F0", Offset = "0x4103F0", VA = "0x1804119F0")]
		public void StartFirstJump(float currentScoreProgress)
		{
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x411B40", Offset = "0x410540", VA = "0x180411B40")]
		public void StartJump(float currentScoreProgress)
		{
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x4118F0", Offset = "0x4102F0", VA = "0x1804118F0")]
		private void SetCachedSprites(IEnumerable<Sprite> mainSprites, IEnumerable<Sprite> eyeSprites)
		{
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x411E40", Offset = "0x410840", VA = "0x180411E40")]
		public MusicGameMainDancingCharacterElement()
		{
		}

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIElementCluster m_UIElementCluster;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_HinaAnimator;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator m_BaseAnimator;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x30")]
		private string guestId;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x38")]
		private readonly List<Sprite> cachaedMainSprites;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x40")]
		private readonly List<Sprite> cachaedEyeSprites;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x48")]
		private bool initialized;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x49")]
		private bool actived;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		private const string SEKIBANKI = "Sekibanki";

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		private const string SEKIBANKI_HEAD = "Sekibanki_OnlyHead";

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		private const string WAKASAGIHIME = "Wakasagihime";

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		private const string HINA = "Hina";

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		private const string MYSTIA = "Mystia";

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x50")]
		private readonly string[] m_AvailableActions;
	}
}
