using System;
using System.Collections;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x020009A4 RID: 2468
	[Token(Token = "0x20009A4")]
	[CreateAssetMenu(fileName = "DLC3_Spell_Mamizou", menuName = "Spells/DLC3/Mamizou", order = 6)]
	public class Spell_Mamizou : SpellBase
	{
		// Token: 0x06003CE1 RID: 15585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE1")]
		[Address(RVA = "0x6B2190", Offset = "0x6B0B90", VA = "0x1806B2190", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE2")]
		[Address(RVA = "0x6B21C0", Offset = "0x6B0BC0", VA = "0x1806B21C0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003CE3 RID: 15587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003CE3")]
		[Address(RVA = "0x6B2250", Offset = "0x6B0C50", VA = "0x1806B2250", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003CE4 RID: 15588 RVA: 0x00016BC0 File Offset: 0x00014DC0
		[Token(Token = "0x6003CE4")]
		[Address(RVA = "0x6B22E0", Offset = "0x6B0CE0", VA = "0x1806B22E0")]
		private bool SetSpellCondition(SpecialGuestsController specialGuestsController)
		{
			return default(bool);
		}

		// Token: 0x06003CE5 RID: 15589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003CE5")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Mamizou()
		{
		}

		// Token: 0x04003477 RID: 13431
		[Token(Token = "0x4003477")]
		private const string MAMIZOU_SPELLCARD = "MamizouSpellCard";

		// Token: 0x04003478 RID: 13432
		[Token(Token = "0x4003478")]
		[FieldOffset(Offset = "0x18")]
		public int negativeDuration;

		// Token: 0x04003479 RID: 13433
		[Token(Token = "0x4003479")]
		[FieldOffset(Offset = "0x20")]
		public GameObject smokeEffect;

		// Token: 0x0400347A RID: 13434
		[Token(Token = "0x400347A")]
		[FieldOffset(Offset = "0x28")]
		public GameObject magicEffect;

		// Token: 0x0400347B RID: 13435
		[Token(Token = "0x400347B")]
		[FieldOffset(Offset = "0x30")]
		public GameObject leafStormEffect;

		// Token: 0x0400347C RID: 13436
		[Token(Token = "0x400347C")]
		[FieldOffset(Offset = "0x38")]
		public float leafDuration;

		// Token: 0x0400347D RID: 13437
		[Token(Token = "0x400347D")]
		[FieldOffset(Offset = "0x40")]
		[Header("SFX")]
		public AudioClip magicSFX;

		// Token: 0x0400347E RID: 13438
		[Token(Token = "0x400347E")]
		[FieldOffset(Offset = "0x48")]
		public SpellBase.DelayAudioClip leafSFX;

		// Token: 0x0400347F RID: 13439
		[Token(Token = "0x400347F")]
		[FieldOffset(Offset = "0x58")]
		public AudioClip smokeSFX;
	}
}
