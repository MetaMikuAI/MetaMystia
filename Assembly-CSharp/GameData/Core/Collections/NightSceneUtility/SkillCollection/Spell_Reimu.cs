using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A0A RID: 2570
	[Token(Token = "0x2000A0A")]
	[CreateAssetMenu(fileName = "Spell_Reimu", menuName = "Spells/Reimu", order = 7)]
	public class Spell_Reimu : SpellBase
	{
		// Token: 0x06003EAF RID: 16047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EAF")]
		[Address(RVA = "0x6B4A90", Offset = "0x6B3490", VA = "0x1806B4A90", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003EB0 RID: 16048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB0")]
		[Address(RVA = "0x6B4B50", Offset = "0x6B3550", VA = "0x1806B4B50", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003EB1 RID: 16049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003EB1")]
		[Address(RVA = "0x6B4AC0", Offset = "0x6B34C0", VA = "0x1806B4AC0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003EB2 RID: 16050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003EB2")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Reimu()
		{
		}

		// Token: 0x040036B4 RID: 14004
		[Token(Token = "0x40036B4")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int shieldGivenCount;

		// Token: 0x040036B5 RID: 14005
		[Token(Token = "0x40036B5")]
		[FieldOffset(Offset = "0x1C")]
		public int lockDailyRecipesCount;

		// Token: 0x040036B6 RID: 14006
		[Token(Token = "0x40036B6")]
		[FieldOffset(Offset = "0x20")]
		public int lockDailyRecipesDuration;

		// Token: 0x040036B7 RID: 14007
		[Token(Token = "0x40036B7")]
		[FieldOffset(Offset = "0x28")]
		[Header("Effects")]
		public AudioClip shieldSFX;

		// Token: 0x040036B8 RID: 14008
		[Token(Token = "0x40036B8")]
		[FieldOffset(Offset = "0x30")]
		public GameObject shieldEffectParent;

		// Token: 0x040036B9 RID: 14009
		[Token(Token = "0x40036B9")]
		[FieldOffset(Offset = "0x38")]
		public float shieldEffectEndOffset;

		// Token: 0x040036BA RID: 14010
		[Token(Token = "0x40036BA")]
		[FieldOffset(Offset = "0x40")]
		public AudioClip sphereGenerateSFX;

		// Token: 0x040036BB RID: 14011
		[Token(Token = "0x40036BB")]
		[FieldOffset(Offset = "0x48")]
		public GameObject shieldEffectEndParrent;

		// Token: 0x040036BC RID: 14012
		[Token(Token = "0x40036BC")]
		[FieldOffset(Offset = "0x50")]
		public GameObject magicSphereEffectStart;

		// Token: 0x040036BD RID: 14013
		[Token(Token = "0x40036BD")]
		[FieldOffset(Offset = "0x58")]
		public float magicStartDuration;

		// Token: 0x040036BE RID: 14014
		[Token(Token = "0x40036BE")]
		[FieldOffset(Offset = "0x60")]
		public GameObject magicSphereEffect;

		// Token: 0x040036BF RID: 14015
		[Token(Token = "0x40036BF")]
		[FieldOffset(Offset = "0x68")]
		public GameObject magicSphereEffectDetonate;

		// Token: 0x040036C0 RID: 14016
		[Token(Token = "0x40036C0")]
		[FieldOffset(Offset = "0x70")]
		public AudioClip sphereLaunchSFX;

		// Token: 0x040036C1 RID: 14017
		[Token(Token = "0x40036C1")]
		[FieldOffset(Offset = "0x78")]
		public AudioClip sphereDetonateSFX;

		// Token: 0x040036C2 RID: 14018
		[Token(Token = "0x40036C2")]
		[FieldOffset(Offset = "0x80")]
		public float magicDetonateDuration;

		// Token: 0x040036C3 RID: 14019
		[Token(Token = "0x40036C3")]
		[FieldOffset(Offset = "0x84")]
		public float magicSphereLaunchOffset;

		// Token: 0x040036C4 RID: 14020
		[Token(Token = "0x40036C4")]
		[FieldOffset(Offset = "0x88")]
		public float magicSphereLaunchSpeed;

		// Token: 0x040036C5 RID: 14021
		[Token(Token = "0x40036C5")]
		[FieldOffset(Offset = "0x90")]
		public AudioClip sealSFX;

		// Token: 0x040036C6 RID: 14022
		[Token(Token = "0x40036C6")]
		[FieldOffset(Offset = "0x98")]
		public float sealSFXOffset;

		// Token: 0x040036C7 RID: 14023
		[Token(Token = "0x40036C7")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject sealEffect;

		// Token: 0x040036C8 RID: 14024
		[Token(Token = "0x40036C8")]
		[FieldOffset(Offset = "0xA8")]
		public float sealEffectDuration;

		// Token: 0x040036C9 RID: 14025
		[Token(Token = "0x40036C9")]
		[FieldOffset(Offset = "0xAC")]
		public float magicSphereMaxAnglerSpeed;

		// Token: 0x040036CA RID: 14026
		[Token(Token = "0x40036CA")]
		[FieldOffset(Offset = "0xB0")]
		public float magicSphereMinAnglerSpeed;

		// Token: 0x040036CB RID: 14027
		[Token(Token = "0x40036CB")]
		[FieldOffset(Offset = "0xB4")]
		public float magicHitCameraShakeAmplitude;

		// Token: 0x040036CC RID: 14028
		[Token(Token = "0x40036CC")]
		[FieldOffset(Offset = "0xB8")]
		public float magicEndCameraShakeAmplitude;

		// Token: 0x040036CD RID: 14029
		[Token(Token = "0x40036CD")]
		[FieldOffset(Offset = "0xBC")]
		public float magicEndCameraShakeDuration;

		// Token: 0x040036CE RID: 14030
		[Token(Token = "0x40036CE")]
		[FieldOffset(Offset = "0xC0")]
		public float magicEndCameraShakeFadeDuration;
	}
}
