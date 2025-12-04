using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x020009E4 RID: 2532
	[Token(Token = "0x20009E4")]
	[CreateAssetMenu(fileName = "Spell_Nitori", menuName = "Spells/Nitori", order = 44)]
	public class Spell_Nitori : SpellBase
	{
		// Token: 0x06003E12 RID: 15890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E12")]
		[Address(RVA = "0x6B3D60", Offset = "0x6B2760", VA = "0x1806B3D60", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003E13 RID: 15891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E13")]
		[Address(RVA = "0x6B3D90", Offset = "0x6B2790", VA = "0x1806B3D90", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003E14 RID: 15892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003E14")]
		[Address(RVA = "0x6B3E20", Offset = "0x6B2820", VA = "0x1806B3E20", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003E15 RID: 15893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E15")]
		[Address(RVA = "0x6B3EA0", Offset = "0x6B28A0", VA = "0x1806B3EA0")]
		public Spell_Nitori()
		{
		}

		// Token: 0x040035F5 RID: 13813
		[Token(Token = "0x40035F5")]
		[FieldOffset(Offset = "0x18")]
		[Header("Value")]
		public int positiveDuration;

		// Token: 0x040035F6 RID: 13814
		[Token(Token = "0x40035F6")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2Int negativeRepellGuestNum;

		// Token: 0x040035F7 RID: 13815
		[Token(Token = "0x40035F7")]
		[FieldOffset(Offset = "0x24")]
		public float waterShakeAmplitude;

		// Token: 0x040035F8 RID: 13816
		[Token(Token = "0x40035F8")]
		[FieldOffset(Offset = "0x28")]
		public float waterShakeDuration;

		// Token: 0x040035F9 RID: 13817
		[Token(Token = "0x40035F9")]
		[FieldOffset(Offset = "0x2C")]
		public float waterShakeEndDuration;

		// Token: 0x040035FA RID: 13818
		[Token(Token = "0x40035FA")]
		[FieldOffset(Offset = "0x30")]
		[Header("Effect")]
		public GameObject nitoriTechArmObject;

		// Token: 0x040035FB RID: 13819
		[Token(Token = "0x40035FB")]
		[FieldOffset(Offset = "0x38")]
		public float armAnimDuration;

		// Token: 0x040035FC RID: 13820
		[Token(Token = "0x40035FC")]
		[FieldOffset(Offset = "0x3C")]
		public Vector2 armOffset;

		// Token: 0x040035FD RID: 13821
		[Token(Token = "0x40035FD")]
		[FieldOffset(Offset = "0x48")]
		public AudioClip rewardSFX;

		// Token: 0x040035FE RID: 13822
		[Token(Token = "0x40035FE")]
		[FieldOffset(Offset = "0x50")]
		public GameObject nitoriRainObject;

		// Token: 0x040035FF RID: 13823
		[Token(Token = "0x40035FF")]
		[FieldOffset(Offset = "0x58")]
		public float stopRainTime;

		// Token: 0x04003600 RID: 13824
		[Token(Token = "0x4003600")]
		[FieldOffset(Offset = "0x5C")]
		public float wholeDuration;

		// Token: 0x04003601 RID: 13825
		[Token(Token = "0x4003601")]
		[FieldOffset(Offset = "0x60")]
		public AudioClip punishmentSFX;
	}
}
