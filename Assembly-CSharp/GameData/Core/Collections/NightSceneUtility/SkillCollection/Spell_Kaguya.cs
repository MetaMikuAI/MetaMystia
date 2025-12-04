using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000978 RID: 2424
	[Token(Token = "0x2000978")]
	[CreateAssetMenu(fileName = "Spell_Kaguya", menuName = "Spells/Kaguya", order = 25)]
	public class Spell_Kaguya : SpellBase
	{
		// Token: 0x06003BDB RID: 15323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BDB")]
		[Address(RVA = "0x69DC90", Offset = "0x69C690", VA = "0x18069DC90", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BDC")]
		[Address(RVA = "0x69DCC0", Offset = "0x69C6C0", VA = "0x18069DCC0", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003BDD RID: 15325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BDD")]
		[Address(RVA = "0x69DD40", Offset = "0x69C740", VA = "0x18069DD40", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003BDE RID: 15326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BDE")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Kaguya()
		{
		}

		// Token: 0x04003357 RID: 13143
		[Token(Token = "0x4003357")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		[Header("一晚上=现实时间240s，填入内容为现实时间")]
		public int addTimeModify;

		// Token: 0x04003358 RID: 13144
		[Token(Token = "0x4003358")]
		[FieldOffset(Offset = "0x1C")]
		public int reduceTimeModify;

		// Token: 0x04003359 RID: 13145
		[Token(Token = "0x4003359")]
		[FieldOffset(Offset = "0x20")]
		[Header("Effect")]
		public AudioClip positiveSFX;

		// Token: 0x0400335A RID: 13146
		[Token(Token = "0x400335A")]
		[FieldOffset(Offset = "0x28")]
		public GameObject positiveEffect;

		// Token: 0x0400335B RID: 13147
		[Token(Token = "0x400335B")]
		[FieldOffset(Offset = "0x30")]
		public float positiveEffectDuration;

		// Token: 0x0400335C RID: 13148
		[Token(Token = "0x400335C")]
		[FieldOffset(Offset = "0x38")]
		public AudioClip negativeSFX;

		// Token: 0x0400335D RID: 13149
		[Token(Token = "0x400335D")]
		[FieldOffset(Offset = "0x40")]
		public GameObject negativeEffect;

		// Token: 0x0400335E RID: 13150
		[Token(Token = "0x400335E")]
		[FieldOffset(Offset = "0x48")]
		public float negativeEffectDuration;

		// Token: 0x0400335F RID: 13151
		[Token(Token = "0x400335F")]
		[FieldOffset(Offset = "0x50")]
		public AudioClip cancelSFX;

		// Token: 0x04003360 RID: 13152
		[Token(Token = "0x4003360")]
		[FieldOffset(Offset = "0x58")]
		public float cancelSFXOffset;

		// Token: 0x04003361 RID: 13153
		[Token(Token = "0x4003361")]
		[FieldOffset(Offset = "0x5C")]
		public float cancelNegativeSFXOffset;
	}
}
