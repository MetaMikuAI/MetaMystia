using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A65 RID: 2661
	[Token(Token = "0x2000A65")]
	[CreateAssetMenu(fileName = "Spell_Tenshi", menuName = "Spells/Tenshi", order = 9)]
	public class Spell_Tenshi : SpellBase
	{
		// Token: 0x060040A6 RID: 16550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040A6")]
		[Address(RVA = "0x6CC3F0", Offset = "0x6CADF0", VA = "0x1806CC3F0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040A7")]
		[Address(RVA = "0x6CC420", Offset = "0x6CAE20", VA = "0x1806CC420", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60040A8")]
		[Address(RVA = "0x6CC4B0", Offset = "0x6CAEB0", VA = "0x1806CC4B0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x060040A9 RID: 16553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60040A9")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Tenshi()
		{
		}

		// Token: 0x040038C0 RID: 14528
		[Token(Token = "0x40038C0")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public float overrideGuestMood;

		// Token: 0x040038C1 RID: 14529
		[Token(Token = "0x40038C1")]
		[FieldOffset(Offset = "0x1C")]
		public int smashTableCount;

		// Token: 0x040038C2 RID: 14530
		[Token(Token = "0x40038C2")]
		[FieldOffset(Offset = "0x20")]
		public int lockTableDuration;

		// Token: 0x040038C3 RID: 14531
		[Token(Token = "0x40038C3")]
		[FieldOffset(Offset = "0x28")]
		[Header("Effect")]
		public GameObject rockEffect;

		// Token: 0x040038C4 RID: 14532
		[Token(Token = "0x40038C4")]
		[FieldOffset(Offset = "0x30")]
		public AudioClip rockFallSFX;

		// Token: 0x040038C5 RID: 14533
		[Token(Token = "0x40038C5")]
		[FieldOffset(Offset = "0x38")]
		public float fadeDuration;

		// Token: 0x040038C6 RID: 14534
		[Token(Token = "0x40038C6")]
		[FieldOffset(Offset = "0x3C")]
		public float rockImpactOffset;

		// Token: 0x040038C7 RID: 14535
		[Token(Token = "0x40038C7")]
		[FieldOffset(Offset = "0x40")]
		public AudioClip rockImpactSFX;

		// Token: 0x040038C8 RID: 14536
		[Token(Token = "0x40038C8")]
		[FieldOffset(Offset = "0x48")]
		public float rockCameraShakeOffset;

		// Token: 0x040038C9 RID: 14537
		[Token(Token = "0x40038C9")]
		[FieldOffset(Offset = "0x4C")]
		public float rockCameraShakeAmplitude;

		// Token: 0x040038CA RID: 14538
		[Token(Token = "0x40038CA")]
		[FieldOffset(Offset = "0x50")]
		public float rockCameraShakeDuration;

		// Token: 0x040038CB RID: 14539
		[Token(Token = "0x40038CB")]
		[FieldOffset(Offset = "0x54")]
		public float rockCameraShakeFadeDuration;

		// Token: 0x040038CC RID: 14540
		[Token(Token = "0x40038CC")]
		[FieldOffset(Offset = "0x58")]
		public GameObject passionEffect;

		// Token: 0x040038CD RID: 14541
		[Token(Token = "0x40038CD")]
		[FieldOffset(Offset = "0x60")]
		public AudioClip passionSFX;

		// Token: 0x040038CE RID: 14542
		[Token(Token = "0x40038CE")]
		[FieldOffset(Offset = "0x68")]
		public float passionCameraShakeAmplitude;

		// Token: 0x040038CF RID: 14543
		[Token(Token = "0x40038CF")]
		[FieldOffset(Offset = "0x6C")]
		public float passionCameraShakeDuration;

		// Token: 0x040038D0 RID: 14544
		[Token(Token = "0x40038D0")]
		[FieldOffset(Offset = "0x70")]
		public float passionCameraShakeFadeDuration;

		// Token: 0x040038D1 RID: 14545
		[Token(Token = "0x40038D1")]
		[FieldOffset(Offset = "0x74")]
		public float passionDuration;

		// Token: 0x040038D2 RID: 14546
		[Token(Token = "0x40038D2")]
		[FieldOffset(Offset = "0x78")]
		public AudioClip passionHappySFX;

		// Token: 0x040038D3 RID: 14547
		[Token(Token = "0x40038D3")]
		[FieldOffset(Offset = "0x80")]
		public GameObject passionHappyEffect;

		// Token: 0x040038D4 RID: 14548
		[Token(Token = "0x40038D4")]
		[FieldOffset(Offset = "0x88")]
		public float passionHappyDuration;
	}
}
