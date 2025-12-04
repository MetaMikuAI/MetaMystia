using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000AB7 RID: 2743
	[Token(Token = "0x2000AB7")]
	[CreateAssetMenu(fileName = "Spell_Youmu", menuName = "Spells/Youmu", order = 11)]
	public class Spell_Youmu : SpellBase
	{
		// Token: 0x06004245 RID: 16965 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004245")]
		[Address(RVA = "0x6FE950", Offset = "0x6FD350", VA = "0x1806FE950", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06004246 RID: 16966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004246")]
		[Address(RVA = "0x6FE980", Offset = "0x6FD380", VA = "0x1806FE980", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06004247 RID: 16967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004247")]
		[Address(RVA = "0x6FEA00", Offset = "0x6FD400", VA = "0x1806FEA00", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06004248 RID: 16968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004248")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Youmu()
		{
		}

		// Token: 0x06004249 RID: 16969 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004249")]
		[Address(RVA = "0x6FEBB0", Offset = "0x6FD5B0", VA = "0x1806FEBB0")]
		[CompilerGenerated]
		internal static string <OnPositiveBuffExecute>g__OnGettingCurrentBuffContext|9_0(int currentTime, string buffDescription)
		{
			return null;
		}

		// Token: 0x04003A5B RID: 14939
		[Token(Token = "0x4003A5B")]
		[FieldOffset(Offset = "0x18")]
		[Header("Values")]
		public int postiveDuration;

		// Token: 0x04003A5C RID: 14940
		[Token(Token = "0x4003A5C")]
		[FieldOffset(Offset = "0x1C")]
		public float cuttingboardMultiper;

		// Token: 0x04003A5D RID: 14941
		[Token(Token = "0x4003A5D")]
		[FieldOffset(Offset = "0x20")]
		public int negativeDuration;

		// Token: 0x04003A5E RID: 14942
		[Token(Token = "0x4003A5E")]
		[FieldOffset(Offset = "0x24")]
		public int passionDecreasePertime;

		// Token: 0x04003A5F RID: 14943
		[Token(Token = "0x4003A5F")]
		[FieldOffset(Offset = "0x28")]
		public float passionDecreaseUnitTime;

		// Token: 0x04003A60 RID: 14944
		[Token(Token = "0x4003A60")]
		[FieldOffset(Offset = "0x2C")]
		public float patientEditMultiplier;

		// Token: 0x04003A61 RID: 14945
		[Token(Token = "0x4003A61")]
		[FieldOffset(Offset = "0x30")]
		public GameObject youmuRewardVFX;
	}
}
