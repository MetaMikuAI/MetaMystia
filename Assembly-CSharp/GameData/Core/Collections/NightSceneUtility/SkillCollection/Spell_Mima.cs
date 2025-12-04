using System;
using System.Collections;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x020009C3 RID: 2499
	[Token(Token = "0x20009C3")]
	[CreateAssetMenu(fileName = "DLC5_Spell_Mima", menuName = "Spells/DLC5/Mima", order = 1)]
	public class Spell_Mima : SpellBase
	{
		// Token: 0x06003D6B RID: 15723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D6B")]
		[Address(RVA = "0x6B32C0", Offset = "0x6B1CC0", VA = "0x1806B32C0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D6C")]
		[Address(RVA = "0x6B3370", Offset = "0x6B1D70", VA = "0x1806B3370", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6D")]
		[Address(RVA = "0x6B3270", Offset = "0x6B1C70", VA = "0x1806B3270")]
		private void MimaMagicEnergyGet(SpecialGuestsController specialGuestsController)
		{
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6E")]
		[Address(RVA = "0x6B2EA0", Offset = "0x6B18A0", VA = "0x1806B2EA0")]
		private void AddEnergyForMagic(int addEnergy)
		{
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6F")]
		[Address(RVA = "0x6B3100", Offset = "0x6B1B00", VA = "0x1806B3100")]
		private void CheckGreatMagicEnergy()
		{
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D70")]
		[Address(RVA = "0x6B31F0", Offset = "0x6B1BF0", VA = "0x1806B31F0")]
		private IEnumerator MimaGreatMagic()
		{
			return null;
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D71")]
		[Address(RVA = "0x6B32F0", Offset = "0x6B1CF0", VA = "0x1806B32F0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003D72 RID: 15730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D72")]
		[Address(RVA = "0x6B33F0", Offset = "0x6B1DF0", VA = "0x1806B33F0")]
		public Spell_Mima()
		{
		}

		// Token: 0x04003548 RID: 13640
		[Token(Token = "0x4003548")]
		[FieldOffset(Offset = "0x18")]
		public int greatMagicNeedEnergy;

		// Token: 0x04003549 RID: 13641
		[Token(Token = "0x4003549")]
		[FieldOffset(Offset = "0x1C")]
		public int mimaGreatMagicGetEnergy;

		// Token: 0x0400354A RID: 13642
		[Token(Token = "0x400354A")]
		[FieldOffset(Offset = "0x20")]
		public int otherGuestGreatMagicGetEnergy;

		// Token: 0x0400354B RID: 13643
		[Token(Token = "0x400354B")]
		[FieldOffset(Offset = "0x24")]
		public int greatMagicPlusDuration;

		// Token: 0x0400354C RID: 13644
		[Token(Token = "0x400354C")]
		[FieldOffset(Offset = "0x28")]
		public int negativeDuration;

		// Token: 0x0400354D RID: 13645
		[Token(Token = "0x400354D")]
		[FieldOffset(Offset = "0x30")]
		[Header("Vfx")]
		public GameObject magicVfx;

		// Token: 0x0400354E RID: 13646
		[Token(Token = "0x400354E")]
		[FieldOffset(Offset = "0x38")]
		public GameObject shieldEffectEndParrent;

		// Token: 0x0400354F RID: 13647
		[Token(Token = "0x400354F")]
		[FieldOffset(Offset = "0x40")]
		public float shieldEffectEndOffset;

		// Token: 0x04003550 RID: 13648
		[Token(Token = "0x4003550")]
		[FieldOffset(Offset = "0x44")]
		public float magicShiningTime;

		// Token: 0x04003551 RID: 13649
		[Token(Token = "0x4003551")]
		[FieldOffset(Offset = "0x48")]
		public GameObject greatMagicVfx;

		// Token: 0x04003552 RID: 13650
		[Token(Token = "0x4003552")]
		[FieldOffset(Offset = "0x50")]
		public GameObject ghostVfx;

		// Token: 0x04003553 RID: 13651
		[Token(Token = "0x4003553")]
		[FieldOffset(Offset = "0x58")]
		public Vector3 ghostVfxOffset;

		// Token: 0x04003554 RID: 13652
		[Token(Token = "0x4003554")]
		[FieldOffset(Offset = "0x68")]
		public GameObject shadowVfx;

		// Token: 0x04003555 RID: 13653
		[Token(Token = "0x4003555")]
		[FieldOffset(Offset = "0x70")]
		public Vector3 shadowVfxOffset;

		// Token: 0x04003556 RID: 13654
		[Token(Token = "0x4003556")]
		[FieldOffset(Offset = "0x7C")]
		public float shadowDelay;

		// Token: 0x04003557 RID: 13655
		[Token(Token = "0x4003557")]
		[FieldOffset(Offset = "0x80")]
		public float ghostDelay;

		// Token: 0x04003558 RID: 13656
		[Token(Token = "0x4003558")]
		[FieldOffset(Offset = "0x88")]
		[Header("SFX")]
		public SpellBase.DelayAudioClip shadowSfx;

		// Token: 0x04003559 RID: 13657
		[Token(Token = "0x4003559")]
		[FieldOffset(Offset = "0x98")]
		public SpellBase.DelayAudioClip ghostSfx;

		// Token: 0x0400355A RID: 13658
		[Token(Token = "0x400355A")]
		[FieldOffset(Offset = "0xA8")]
		public AudioClip magicSpawnSfx;

		// Token: 0x0400355B RID: 13659
		[Token(Token = "0x400355B")]
		[FieldOffset(Offset = "0xB0")]
		public SpellBase.DelayAudioClip magicEnergySfx;

		// Token: 0x0400355C RID: 13660
		[Token(Token = "0x400355C")]
		[FieldOffset(Offset = "0xC0")]
		public SpellBase.DelayAudioClip magicBurstSfx;

		// Token: 0x0400355D RID: 13661
		[Token(Token = "0x400355D")]
		private const string MIMA_MAGIC_OBJECT = "Mima_Magic_Object";

		// Token: 0x0400355E RID: 13662
		[Token(Token = "0x400355E")]
		private const int MIMA_ID = 5004;

		// Token: 0x0400355F RID: 13663
		[Token(Token = "0x400355F")]
		private const int MARISA_ID = 10;

		// Token: 0x04003560 RID: 13664
		[Token(Token = "0x4003560")]
		private const int REIMU_ID = 7;
	}
}
