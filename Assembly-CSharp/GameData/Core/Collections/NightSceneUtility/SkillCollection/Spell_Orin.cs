using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x020009F8 RID: 2552
	[Token(Token = "0x20009F8")]
	[CreateAssetMenu(fileName = "DLC2_Spell_Orin", menuName = "Spells/DLC2/DLC2_Spell_Orin", order = 4)]
	public class Spell_Orin : SpellBase
	{
		// Token: 0x06003E5F RID: 15967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E5F")]
		[Address(RVA = "0x6B4550", Offset = "0x6B2F50", VA = "0x1806B4550", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E60")]
		[Address(RVA = "0x6B4580", Offset = "0x6B2F80", VA = "0x1806B4580", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E61")]
		[Address(RVA = "0x6B4610", Offset = "0x6B3010", VA = "0x1806B4610", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E62")]
		[Address(RVA = "0x6B4760", Offset = "0x6B3160", VA = "0x1806B4760")]
		public Spell_Orin()
		{
		}

		// Token: 0x04003659 RID: 13913
		[Token(Token = "0x4003659")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int postiveDuration;

		// Token: 0x0400365A RID: 13914
		[Token(Token = "0x400365A")]
		[FieldOffset(Offset = "0x1C")]
		public int targetTagId;

		// Token: 0x0400365B RID: 13915
		[Token(Token = "0x400365B")]
		[FieldOffset(Offset = "0x20")]
		public int baseEval;

		// Token: 0x0400365C RID: 13916
		[Token(Token = "0x400365C")]
		[FieldOffset(Offset = "0x24")]
		public int ghostGuestId;

		// Token: 0x0400365D RID: 13917
		[Token(Token = "0x400365D")]
		[FieldOffset(Offset = "0x28")]
		public Material spiritCharacter;

		// Token: 0x0400365E RID: 13918
		[Token(Token = "0x400365E")]
		[FieldOffset(Offset = "0x30")]
		public Material spiritCharacterEyes;

		// Token: 0x0400365F RID: 13919
		[Token(Token = "0x400365F")]
		[FieldOffset(Offset = "0x38")]
		public Color spiritEyeColor;

		// Token: 0x04003660 RID: 13920
		[Token(Token = "0x4003660")]
		[FieldOffset(Offset = "0x48")]
		[Header("Effect")]
		public GameObject fogEffect;

		// Token: 0x04003661 RID: 13921
		[Token(Token = "0x4003661")]
		[FieldOffset(Offset = "0x50")]
		public GameObject catEffect;

		// Token: 0x04003662 RID: 13922
		[Token(Token = "0x4003662")]
		[FieldOffset(Offset = "0x58")]
		[Header("SFX")]
		public AudioClip rewardSFX;

		// Token: 0x04003663 RID: 13923
		[Token(Token = "0x4003663")]
		[FieldOffset(Offset = "0x60")]
		public AudioClip punishmentSFX;
	}
}
