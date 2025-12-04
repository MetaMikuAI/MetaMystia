using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A42 RID: 2626
	[Token(Token = "0x2000A42")]
	[CreateAssetMenu(fileName = "DLC3_Spell_Seiga", menuName = "Spells/DLC3/Seiga", order = 4)]
	public class Spell_Seiga : SpellBase
	{
		// Token: 0x06003FD4 RID: 16340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD4")]
		[Address(RVA = "0x6CA350", Offset = "0x6C8D50", VA = "0x1806CA350", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003FD5 RID: 16341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD5")]
		[Address(RVA = "0x6CA380", Offset = "0x6C8D80", VA = "0x1806CA380", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003FD6 RID: 16342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003FD6")]
		[Address(RVA = "0x6CA410", Offset = "0x6C8E10", VA = "0x1806CA410", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FD7")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Seiga()
		{
		}

		// Token: 0x040037E0 RID: 14304
		[Token(Token = "0x40037E0")]
		[FieldOffset(Offset = "0x18")]
		public int positiveDuration;

		// Token: 0x040037E1 RID: 14305
		[Token(Token = "0x40037E1")]
		[FieldOffset(Offset = "0x1C")]
		public int negativeDuration;

		// Token: 0x040037E2 RID: 14306
		[Token(Token = "0x40037E2")]
		[FieldOffset(Offset = "0x20")]
		public float extraNegativeSpellcardRate;

		// Token: 0x040037E3 RID: 14307
		[Token(Token = "0x40037E3")]
		[FieldOffset(Offset = "0x28")]
		public GameObject DoorEffect;

		// Token: 0x040037E4 RID: 14308
		[Token(Token = "0x40037E4")]
		[FieldOffset(Offset = "0x30")]
		public GameObject magicEffect;

		// Token: 0x040037E5 RID: 14309
		[Token(Token = "0x40037E5")]
		[FieldOffset(Offset = "0x38")]
		public GameObject demonFaceEffect;

		// Token: 0x040037E6 RID: 14310
		[Token(Token = "0x40037E6")]
		[FieldOffset(Offset = "0x40")]
		[Header("SFX")]
		public SpellBase.DelayAudioClip doorOpenSFX;

		// Token: 0x040037E7 RID: 14311
		[Token(Token = "0x40037E7")]
		[FieldOffset(Offset = "0x50")]
		public SpellBase.DelayAudioClip magicSFX;

		// Token: 0x040037E8 RID: 14312
		[Token(Token = "0x40037E8")]
		[FieldOffset(Offset = "0x60")]
		public AudioClip blackMagicSFX;

		// Token: 0x040037E9 RID: 14313
		[Token(Token = "0x40037E9")]
		[FieldOffset(Offset = "0x68")]
		public AudioClip demonSFX;
	}
}
