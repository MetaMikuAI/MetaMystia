using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000ABA RID: 2746
	[Token(Token = "0x2000ABA")]
	[CreateAssetMenu(fileName = "DLC5_Spell_Yukari", menuName = "Spells/DLC5/Yukari", order = 7)]
	public class Spell_Yukari : SpellBase
	{
		// Token: 0x06004257 RID: 16983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004257")]
		[Address(RVA = "0x6FEC10", Offset = "0x6FD610", VA = "0x1806FEC10", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004258")]
		[Address(RVA = "0x6FECC0", Offset = "0x6FD6C0", VA = "0x1806FECC0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004259")]
		[Address(RVA = "0x6FEC40", Offset = "0x6FD640", VA = "0x1806FEC40", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600425A")]
		[Address(RVA = "0x6FED50", Offset = "0x6FD750", VA = "0x1806FED50")]
		public Spell_Yukari()
		{
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x000180D8 File Offset: 0x000162D8
		[Token(Token = "0x600425B")]
		[Address(RVA = "0x6FED40", Offset = "0x6FD740", VA = "0x1806FED40")]
		[CompilerGenerated]
		private bool <OnPositiveBuffExecute>g__CheckFrozenCheckCallback|9_0(int currentTime)
		{
			return default(bool);
		}

		// Token: 0x04003A68 RID: 14952
		[Token(Token = "0x4003A68")]
		[FieldOffset(Offset = "0x18")]
		public int checkTime;

		// Token: 0x04003A69 RID: 14953
		[Token(Token = "0x4003A69")]
		[FieldOffset(Offset = "0x1C")]
		public int maxCouldAdd;

		// Token: 0x04003A6A RID: 14954
		[Token(Token = "0x4003A6A")]
		[FieldOffset(Offset = "0x20")]
		public int kimaNum;

		// Token: 0x04003A6B RID: 14955
		[Token(Token = "0x4003A6B")]
		[FieldOffset(Offset = "0x24")]
		public int kimaDuration;

		// Token: 0x04003A6C RID: 14956
		[Token(Token = "0x4003A6C")]
		[FieldOffset(Offset = "0x28")]
		public int kimaChangePositionInterval;

		// Token: 0x04003A6D RID: 14957
		[Token(Token = "0x4003A6D")]
		[FieldOffset(Offset = "0x30")]
		public GameObject kimaObject;

		// Token: 0x04003A6E RID: 14958
		[Token(Token = "0x4003A6E")]
		[FieldOffset(Offset = "0x38")]
		public GameObject frozenVfx;

		// Token: 0x04003A6F RID: 14959
		[Token(Token = "0x4003A6F")]
		private const string YUKARI_BUFF_TIME_SET = "Yukari_Buff_Time_Set";

		// Token: 0x04003A70 RID: 14960
		[Token(Token = "0x4003A70")]
		[FieldOffset(Offset = "0x40")]
		private string YUKARI_KIMA_SPAWN;
	}
}
