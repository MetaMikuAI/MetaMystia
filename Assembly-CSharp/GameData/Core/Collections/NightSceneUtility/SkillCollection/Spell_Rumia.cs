using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A2E RID: 2606
	[Token(Token = "0x2000A2E")]
	[CreateAssetMenu(fileName = "Spell_Rumia", menuName = "Spells/Rumia", order = 1)]
	public class Spell_Rumia : SpellBase
	{
		// Token: 0x06003F6F RID: 16239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6F")]
		[Address(RVA = "0x6C95F0", Offset = "0x6C7FF0", VA = "0x1806C95F0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F70")]
		[Address(RVA = "0x6C9620", Offset = "0x6C8020", VA = "0x1806C9620", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F71")]
		[Address(RVA = "0x6C96A0", Offset = "0x6C80A0", VA = "0x1806C96A0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F72")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Rumia()
		{
		}

		// Token: 0x04003784 RID: 14212
		[Token(Token = "0x4003784")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int getMeatTypeIngredientAmount;

		// Token: 0x04003785 RID: 14213
		[Token(Token = "0x4003785")]
		[FieldOffset(Offset = "0x1C")]
		public int curtainDuration;

		// Token: 0x04003786 RID: 14214
		[Token(Token = "0x4003786")]
		[FieldOffset(Offset = "0x20")]
		[Header("Effects")]
		public GameObject effectParent;

		// Token: 0x04003787 RID: 14215
		[Token(Token = "0x4003787")]
		[FieldOffset(Offset = "0x28")]
		public float effectDuration;

		// Token: 0x04003788 RID: 14216
		[Token(Token = "0x4003788")]
		[FieldOffset(Offset = "0x30")]
		public AudioClip effectSFX;

		// Token: 0x04003789 RID: 14217
		[Token(Token = "0x4003789")]
		[FieldOffset(Offset = "0x38")]
		public GameObject curtainParent;

		// Token: 0x0400378A RID: 14218
		[Token(Token = "0x400378A")]
		[FieldOffset(Offset = "0x40")]
		public float curtainFadeDuration;

		// Token: 0x0400378B RID: 14219
		[Token(Token = "0x400378B")]
		[FieldOffset(Offset = "0x48")]
		public AudioClip curtainSFX;
	}
}
