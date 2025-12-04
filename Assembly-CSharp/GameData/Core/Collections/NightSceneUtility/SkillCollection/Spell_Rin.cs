using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using NightScene.UI.EventUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A24 RID: 2596
	[Token(Token = "0x2000A24")]
	[CreateAssetMenu(fileName = "Spell_Rin", menuName = "Spells/Rin", order = 35)]
	public class Spell_Rin : SpellBase
	{
		// Token: 0x06003F3D RID: 16189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F3D")]
		[Address(RVA = "0x6C8E40", Offset = "0x6C7840", VA = "0x1806C8E40", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F3E")]
		[Address(RVA = "0x6C8E70", Offset = "0x6C7870", VA = "0x1806C8E70", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F3F")]
		[Address(RVA = "0x6C8EF0", Offset = "0x6C78F0", VA = "0x1806C8EF0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x000173E8 File Offset: 0x000155E8
		[Token(Token = "0x6003F40")]
		[Address(RVA = "0x6C8C10", Offset = "0x6C7610", VA = "0x1806C8C10")]
		private bool GetEffectDisplayer(GuestGroupController x, out GameObject effectDisplayer)
		{
			return default(bool);
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F41")]
		[Address(RVA = "0x6C8F70", Offset = "0x6C7970", VA = "0x1806C8F70")]
		private void RefreshDisplayer(GuestGroupController x)
		{
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F42")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Rin()
		{
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F44")]
		[Address(RVA = "0x6C9360", Offset = "0x6C7D60", VA = "0x1806C9360")]
		[CompilerGenerated]
		private void <OnPositiveBuffExecute>g__UpdateDisplayer|10_1(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x04003766 RID: 14182
		[Token(Token = "0x4003766")]
		private const GuestBuffMarkModule.GuestBuffMark RIN_BUFF_MARK = GuestBuffMarkModule.GuestBuffMark.BuffMark_Rin;

		// Token: 0x04003767 RID: 14183
		[Token(Token = "0x4003767")]
		private const string RIN_EXTRA_ORDER_NUM = "RinExtraOrderNum";

		// Token: 0x04003768 RID: 14184
		[Token(Token = "0x4003768")]
		[FieldOffset(Offset = "0x18")]
		[Header("value")]
		public float negativeMultiper;

		// Token: 0x04003769 RID: 14185
		[Token(Token = "0x4003769")]
		[FieldOffset(Offset = "0x1C")]
		public int negativeDuration;

		// Token: 0x0400376A RID: 14186
		[Token(Token = "0x400376A")]
		[FieldOffset(Offset = "0x20")]
		public int positiveDuration;

		// Token: 0x0400376B RID: 14187
		[Token(Token = "0x400376B")]
		[FieldOffset(Offset = "0x24")]
		public int addOrderNum;

		// Token: 0x0400376C RID: 14188
		[Token(Token = "0x400376C")]
		[FieldOffset(Offset = "0x28")]
		public float addRate;

		// Token: 0x0400376D RID: 14189
		[Token(Token = "0x400376D")]
		[FieldOffset(Offset = "0x30")]
		[Header("vfx")]
		public GameObject extraOrderVFX;
	}
}
