using System;
using System.Collections;
using Il2CppDummyDll;
using NightScene.UI.Miscellaneous;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000A7D RID: 2685
	[Token(Token = "0x2000A7D")]
	[CreateAssetMenu(fileName = "DLC5_Spell_Toyohime", menuName = "Spells/DLC5/Toyohime ", order = 7)]
	public class Spell_Toyohime : SpellBase
	{
		// Token: 0x0600411A RID: 16666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411A")]
		[Address(RVA = "0x6FCFF0", Offset = "0x6FB9F0", VA = "0x1806FCFF0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x0600411B RID: 16667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411B")]
		[Address(RVA = "0x6FD0A0", Offset = "0x6FBAA0", VA = "0x1806FD0A0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x0600411C RID: 16668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600411C")]
		[Address(RVA = "0x6FD020", Offset = "0x6FBA20", VA = "0x1806FD020", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x0600411D RID: 16669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600411D")]
		[Address(RVA = "0x6FD1D0", Offset = "0x6FBBD0", VA = "0x1806FD1D0")]
		public Spell_Toyohime()
		{
		}

		// Token: 0x0400393D RID: 14653
		[Token(Token = "0x400393D")]
		[FieldOffset(Offset = "0x18")]
		public int exiledGuestNum;

		// Token: 0x0400393E RID: 14654
		[Token(Token = "0x400393E")]
		[FieldOffset(Offset = "0x1C")]
		public float positiveExtraRate;

		// Token: 0x0400393F RID: 14655
		[Token(Token = "0x400393F")]
		private const int YORIHIME_ID = 5002;

		// Token: 0x04003940 RID: 14656
		[Token(Token = "0x4003940")]
		private const int TOYOHIME_ID = 5001;

		// Token: 0x04003941 RID: 14657
		[Token(Token = "0x4003941")]
		private const int MIZUCHI_ID = 5013;

		// Token: 0x04003942 RID: 14658
		[Token(Token = "0x4003942")]
		private const int KAGUYA_ID = 25;

		// Token: 0x04003943 RID: 14659
		[Token(Token = "0x4003943")]
		[FieldOffset(Offset = "0x20")]
		public DLC5_WorkSceneToyohimePanel mapSelectPanel;

		// Token: 0x04003944 RID: 14660
		[Token(Token = "0x4003944")]
		[FieldOffset(Offset = "0x28")]
		public GameObject moonVfx;

		// Token: 0x04003945 RID: 14661
		[Token(Token = "0x4003945")]
		[FieldOffset(Offset = "0x30")]
		public float moonDelay;

		// Token: 0x04003946 RID: 14662
		[Token(Token = "0x4003946")]
		[FieldOffset(Offset = "0x38")]
		public GameObject lockVfx;

		// Token: 0x04003947 RID: 14663
		[Token(Token = "0x4003947")]
		[FieldOffset(Offset = "0x40")]
		public float lockDelay;

		// Token: 0x04003948 RID: 14664
		[Token(Token = "0x4003948")]
		[FieldOffset(Offset = "0x48")]
		[Header("Sfx")]
		public SpellBase.DelayAudioClip negativeSfx_Moon;

		// Token: 0x04003949 RID: 14665
		[Token(Token = "0x4003949")]
		[FieldOffset(Offset = "0x58")]
		public SpellBase.DelayAudioClip negativeSfx_Peach;

		// Token: 0x0400394A RID: 14666
		[Token(Token = "0x400394A")]
		[FieldOffset(Offset = "0x68")]
		public AudioClip positiveSfx;

		// Token: 0x0400394B RID: 14667
		[Token(Token = "0x400394B")]
		private const string TOYOHIME_MAP_LABEL = "ToyohimeMapLabel";
	}
}
