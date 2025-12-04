using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000AA2 RID: 2722
	[Token(Token = "0x2000AA2")]
	[CreateAssetMenu(fileName = "Spell_Wriggle", menuName = "Spells/Wriggle", order = 0)]
	public class Spell_Wriggle : SpellBase
	{
		// Token: 0x060041DB RID: 16859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DB")]
		[Address(RVA = "0x6FE4E0", Offset = "0x6FCEE0", VA = "0x1806FE4E0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x060041DC RID: 16860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DC")]
		[Address(RVA = "0x6FE510", Offset = "0x6FCF10", VA = "0x1806FE510", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x060041DD RID: 16861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041DD")]
		[Address(RVA = "0x6FE5A0", Offset = "0x6FCFA0", VA = "0x1806FE5A0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x060041DE RID: 16862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041DE")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Wriggle()
		{
		}

		// Token: 0x040039F1 RID: 14833
		[Token(Token = "0x40039F1")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public float spawnGuestModifyFactor;

		// Token: 0x040039F2 RID: 14834
		[Token(Token = "0x40039F2")]
		[FieldOffset(Offset = "0x1C")]
		public int spawnGuestModifyDuration;

		// Token: 0x040039F3 RID: 14835
		[Token(Token = "0x40039F3")]
		[FieldOffset(Offset = "0x20")]
		public int extraSpawnGuestModifyDurationInYuukaSpellBuff;

		// Token: 0x040039F4 RID: 14836
		[Token(Token = "0x40039F4")]
		[FieldOffset(Offset = "0x28")]
		[Header("Effects")]
		public GameObject firefliesParent;

		// Token: 0x040039F5 RID: 14837
		[Token(Token = "0x40039F5")]
		[FieldOffset(Offset = "0x30")]
		public float fireFliesWarmDownDuration;

		// Token: 0x040039F6 RID: 14838
		[Token(Token = "0x40039F6")]
		[FieldOffset(Offset = "0x38")]
		public AudioClip firefliesSFX;

		// Token: 0x040039F7 RID: 14839
		[Token(Token = "0x40039F7")]
		[FieldOffset(Offset = "0x40")]
		public GameObject fliesParent;

		// Token: 0x040039F8 RID: 14840
		[Token(Token = "0x40039F8")]
		[FieldOffset(Offset = "0x48")]
		public AudioClip fliesSFX;

		// Token: 0x040039F9 RID: 14841
		[Token(Token = "0x40039F9")]
		[FieldOffset(Offset = "0x50")]
		public GameObject deskDarkEffectParent;

		// Token: 0x040039FA RID: 14842
		[Token(Token = "0x40039FA")]
		[FieldOffset(Offset = "0x58")]
		public float deskDarkEffectDuration;

		// Token: 0x040039FB RID: 14843
		[Token(Token = "0x40039FB")]
		[FieldOffset(Offset = "0x5C")]
		public float deskDarkEffectWarmDownDuration;

		// Token: 0x040039FC RID: 14844
		[Token(Token = "0x40039FC")]
		[FieldOffset(Offset = "0x60")]
		public float fliesDuration;

		// Token: 0x040039FD RID: 14845
		[Token(Token = "0x40039FD")]
		[FieldOffset(Offset = "0x64")]
		public float onGuestStartToRunOffset;

		// Token: 0x040039FE RID: 14846
		[Token(Token = "0x40039FE")]
		[FieldOffset(Offset = "0x68")]
		public float onDeskEffectStartToRunOffset;

		// Token: 0x040039FF RID: 14847
		[Token(Token = "0x40039FF")]
		[FieldOffset(Offset = "0x6C")]
		public float fliesShakeAmplitude;

		// Token: 0x04003A00 RID: 14848
		[Token(Token = "0x4003A00")]
		[FieldOffset(Offset = "0x70")]
		public float fliesShakeDuration;

		// Token: 0x04003A01 RID: 14849
		[Token(Token = "0x4003A01")]
		[FieldOffset(Offset = "0x74")]
		public float fliesShakeEndDuration;
	}
}
