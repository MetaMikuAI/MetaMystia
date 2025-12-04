using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000969 RID: 2409
	[Token(Token = "0x2000969")]
	[CreateAssetMenu(fileName = "DLC3_Spell_Futo", menuName = "Spells/DLC3/Futo", order = 3)]
	public class Spell_Futo : SpellBase
	{
		// Token: 0x06003B92 RID: 15250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B92")]
		[Address(RVA = "0x69D070", Offset = "0x69BA70", VA = "0x18069D070", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003B93 RID: 15251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B93")]
		[Address(RVA = "0x69D0A0", Offset = "0x69BAA0", VA = "0x18069D0A0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003B94 RID: 15252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B94")]
		[Address(RVA = "0x69D130", Offset = "0x69BB30", VA = "0x18069D130", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B95")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Futo()
		{
		}

		// Token: 0x04003309 RID: 13065
		[Token(Token = "0x4003309")]
		[FieldOffset(Offset = "0x18")]
		public int positiveDuration;

		// Token: 0x0400330A RID: 13066
		[Token(Token = "0x400330A")]
		[FieldOffset(Offset = "0x1C")]
		public float launchSpeed;

		// Token: 0x0400330B RID: 13067
		[Token(Token = "0x400330B")]
		[FieldOffset(Offset = "0x20")]
		public float launchHeight;

		// Token: 0x0400330C RID: 13068
		[Token(Token = "0x400330C")]
		[FieldOffset(Offset = "0x24")]
		public int leaveTrayNum;

		// Token: 0x0400330D RID: 13069
		[Token(Token = "0x400330D")]
		[FieldOffset(Offset = "0x28")]
		public int negativeDuration;

		// Token: 0x0400330E RID: 13070
		[Token(Token = "0x400330E")]
		[FieldOffset(Offset = "0x30")]
		public GameObject plateGameObject;

		// Token: 0x0400330F RID: 13071
		[Token(Token = "0x400330F")]
		[FieldOffset(Offset = "0x38")]
		public GameObject futoShip;

		// Token: 0x04003310 RID: 13072
		[Token(Token = "0x4003310")]
		[FieldOffset(Offset = "0x40")]
		public GameObject futoFire;

		// Token: 0x04003311 RID: 13073
		[Token(Token = "0x4003311")]
		[FieldOffset(Offset = "0x48")]
		public GameObject futoExplosion;

		// Token: 0x04003312 RID: 13074
		[Token(Token = "0x4003312")]
		[FieldOffset(Offset = "0x50")]
		public GameObject burntTray;

		// Token: 0x04003313 RID: 13075
		[Token(Token = "0x4003313")]
		[FieldOffset(Offset = "0x58")]
		[Header("SFX")]
		public SpellBase.DelayAudioClip boatSFX;

		// Token: 0x04003314 RID: 13076
		[Token(Token = "0x4003314")]
		[FieldOffset(Offset = "0x68")]
		public AudioClip itemSFX;

		// Token: 0x04003315 RID: 13077
		[Token(Token = "0x4003315")]
		[FieldOffset(Offset = "0x70")]
		public AudioClip fireSFX;

		// Token: 0x04003316 RID: 13078
		[Token(Token = "0x4003316")]
		[FieldOffset(Offset = "0x78")]
		public AudioClip plateExplosionSFX;
	}
}
