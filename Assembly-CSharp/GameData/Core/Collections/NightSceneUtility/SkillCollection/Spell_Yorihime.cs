using System;
using System.Collections;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000AB2 RID: 2738
	[Token(Token = "0x2000AB2")]
	[CreateAssetMenu(fileName = "DLC5_Spell_Yorihime", menuName = "Spells/DLC5/Yorihime", order = 5)]
	public class Spell_Yorihime : SpellBase
	{
		// Token: 0x0600422A RID: 16938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422A")]
		[Address(RVA = "0x6FE810", Offset = "0x6FD210", VA = "0x1806FE810", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422B")]
		[Address(RVA = "0x6FE8C0", Offset = "0x6FD2C0", VA = "0x1806FE8C0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x00018018 File Offset: 0x00016218
		[Token(Token = "0x600422C")]
		[Address(RVA = "0x6FE760", Offset = "0x6FD160", VA = "0x1806FE760")]
		private bool KamiOracle(GuestGroupController guestGroup, Sellable food, Sellable bev, GuestGroupController.EvaluationResult oldResult, out GuestGroupController.EvaluationResult overrideEval)
		{
			return default(bool);
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600422D")]
		[Address(RVA = "0x6FE840", Offset = "0x6FD240", VA = "0x1806FE840", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x0600422E RID: 16942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600422E")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public Spell_Yorihime()
		{
		}

		// Token: 0x04003A37 RID: 14903
		[Token(Token = "0x4003A37")]
		[FieldOffset(Offset = "0x18")]
		public int addNum;

		// Token: 0x04003A38 RID: 14904
		[Token(Token = "0x4003A38")]
		[FieldOffset(Offset = "0x1C")]
		public int addNumWhenGetLegend;

		// Token: 0x04003A39 RID: 14905
		[Token(Token = "0x4003A39")]
		[FieldOffset(Offset = "0x20")]
		public int negativeDuration;

		// Token: 0x04003A3A RID: 14906
		[Token(Token = "0x4003A3A")]
		[FieldOffset(Offset = "0x28")]
		[Header("VFX")]
		public GameObject lightVfx;

		// Token: 0x04003A3B RID: 14907
		[Token(Token = "0x4003A3B")]
		[FieldOffset(Offset = "0x30")]
		public GameObject energyVfx;

		// Token: 0x04003A3C RID: 14908
		[Token(Token = "0x4003A3C")]
		[FieldOffset(Offset = "0x38")]
		public GameObject ringVfx;

		// Token: 0x04003A3D RID: 14909
		[Token(Token = "0x4003A3D")]
		[FieldOffset(Offset = "0x40")]
		public Vector2 energyOffset;

		// Token: 0x04003A3E RID: 14910
		[Token(Token = "0x4003A3E")]
		[FieldOffset(Offset = "0x48")]
		public Vector2 ringOffset;

		// Token: 0x04003A3F RID: 14911
		[Token(Token = "0x4003A3F")]
		[FieldOffset(Offset = "0x50")]
		public float ringDelay;

		// Token: 0x04003A40 RID: 14912
		[Token(Token = "0x4003A40")]
		[FieldOffset(Offset = "0x58")]
		public GameObject punishmentVfx;

		// Token: 0x04003A41 RID: 14913
		[Token(Token = "0x4003A41")]
		[FieldOffset(Offset = "0x60")]
		public GameObject punishmentVfxCNT;

		// Token: 0x04003A42 RID: 14914
		[Token(Token = "0x4003A42")]
		[FieldOffset(Offset = "0x68")]
		public GameObject punishmentVfxEN;

		// Token: 0x04003A43 RID: 14915
		[Token(Token = "0x4003A43")]
		[FieldOffset(Offset = "0x70")]
		public GameObject punishmentVfxJP;

		// Token: 0x04003A44 RID: 14916
		[Token(Token = "0x4003A44")]
		[FieldOffset(Offset = "0x78")]
		public GameObject punishmentVfxKR;

		// Token: 0x04003A45 RID: 14917
		[Token(Token = "0x4003A45")]
		[FieldOffset(Offset = "0x80")]
		public float shakeDelay;

		// Token: 0x04003A46 RID: 14918
		[Token(Token = "0x4003A46")]
		[FieldOffset(Offset = "0x84")]
		public float wholeDuration;

		// Token: 0x04003A47 RID: 14919
		[Token(Token = "0x4003A47")]
		[FieldOffset(Offset = "0x88")]
		[Header("SFX")]
		public SpellBase.DelayAudioClip positiveSfx;

		// Token: 0x04003A48 RID: 14920
		[Token(Token = "0x4003A48")]
		[FieldOffset(Offset = "0x98")]
		public SpellBase.DelayAudioClip negativeSfx;

		// Token: 0x04003A49 RID: 14921
		[Token(Token = "0x4003A49")]
		private const int LEGEND_ID = 5;
	}
}
