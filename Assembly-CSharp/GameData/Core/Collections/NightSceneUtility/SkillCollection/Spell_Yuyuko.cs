using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000AEA RID: 2794
	[Token(Token = "0x2000AEA")]
	[CreateAssetMenu(fileName = "Spell_Yuyuko", menuName = "Spells/Yuyuko", order = 23)]
	public class Spell_Yuyuko : SpellBase
	{
		// Token: 0x06004342 RID: 17218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004342")]
		[Address(RVA = "0x720DF0", Offset = "0x71F7F0", VA = "0x180720DF0", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x000184B0 File Offset: 0x000166B0
		[Token(Token = "0x6004343")]
		[Address(RVA = "0x69BED0", Offset = "0x69A8D0", VA = "0x18069BED0", Slot = "5")]
		protected override bool ShouldCallSpellDeclarationAuto(bool isPositive)
		{
			return default(bool);
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004344")]
		[Address(RVA = "0x720E20", Offset = "0x71F820", VA = "0x180720E20", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004345")]
		[Address(RVA = "0x720EA0", Offset = "0x71F8A0", VA = "0x180720EA0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004346")]
		[Address(RVA = "0x720F30", Offset = "0x71F930", VA = "0x180720F30")]
		public Spell_Yuyuko()
		{
		}

		// Token: 0x04003B59 RID: 15193
		[Token(Token = "0x4003B59")]
		private const int YUYUKO_SPECIAL_POSITIVE_SPELL = 2;

		// Token: 0x04003B5A RID: 15194
		[Token(Token = "0x4003B5A")]
		private const int BIG_TAG = -1;

		// Token: 0x04003B5B RID: 15195
		[Token(Token = "0x4003B5B")]
		private const string YUYUKO_RESURRECTION_BUTTERFLY_NUM = "YuyukoResurrectionButterflyUseNum";

		// Token: 0x04003B5C RID: 15196
		[Token(Token = "0x4003B5C")]
		[FieldOffset(Offset = "0x18")]
		public int maxEvalLevel;

		// Token: 0x04003B5D RID: 15197
		[Token(Token = "0x4003B5D")]
		[FieldOffset(Offset = "0x1C")]
		public int firstEatNum;

		// Token: 0x04003B5E RID: 15198
		[Token(Token = "0x4003B5E")]
		[FieldOffset(Offset = "0x20")]
		public int secondEatNum;

		// Token: 0x04003B5F RID: 15199
		[Token(Token = "0x4003B5F")]
		[FieldOffset(Offset = "0x24")]
		public int thirdEatNum;

		// Token: 0x04003B60 RID: 15200
		[Token(Token = "0x4003B60")]
		[FieldOffset(Offset = "0x28")]
		public int fourthEatNum;

		// Token: 0x04003B61 RID: 15201
		[Token(Token = "0x4003B61")]
		[FieldOffset(Offset = "0x2C")]
		public float extraPayment;

		// Token: 0x04003B62 RID: 15202
		[Token(Token = "0x4003B62")]
		[FieldOffset(Offset = "0x30")]
		[Header("幽幽子·符卡一·食物瞬间消失术")]
		public GameObject cherryRainEffect;

		// Token: 0x04003B63 RID: 15203
		[Token(Token = "0x4003B63")]
		[FieldOffset(Offset = "0x38")]
		public GameObject fanEffect;

		// Token: 0x04003B64 RID: 15204
		[Token(Token = "0x4003B64")]
		[FieldOffset(Offset = "0x40")]
		public float animDuration;

		// Token: 0x04003B65 RID: 15205
		[Token(Token = "0x4003B65")]
		[FieldOffset(Offset = "0x44")]
		public float fanOffsetY;

		// Token: 0x04003B66 RID: 15206
		[Token(Token = "0x4003B66")]
		[FieldOffset(Offset = "0x48")]
		[Header("幽幽子·符卡二·墨染浮樱化醉蝶")]
		public GameObject fanEffect2;

		// Token: 0x04003B67 RID: 15207
		[Token(Token = "0x4003B67")]
		[FieldOffset(Offset = "0x50")]
		public GameObject butterflyEffect;

		// Token: 0x04003B68 RID: 15208
		[Token(Token = "0x4003B68")]
		[FieldOffset(Offset = "0x58")]
		public GameObject butterflyEffect2;

		// Token: 0x04003B69 RID: 15209
		[Token(Token = "0x4003B69")]
		[FieldOffset(Offset = "0x60")]
		public GameObject butterflyEndEffect;

		// Token: 0x04003B6A RID: 15210
		[Token(Token = "0x4003B6A")]
		[FieldOffset(Offset = "0x68")]
		public float animFanDuration;

		// Token: 0x04003B6B RID: 15211
		[Token(Token = "0x4003B6B")]
		[FieldOffset(Offset = "0x6C")]
		public float butterflyFlyTime;

		// Token: 0x04003B6C RID: 15212
		[Token(Token = "0x4003B6C")]
		[FieldOffset(Offset = "0x70")]
		public float butterflyFlyRadius;

		// Token: 0x04003B6D RID: 15213
		[Token(Token = "0x4003B6D")]
		[FieldOffset(Offset = "0x74")]
		public float butterflyEndOffset;

		// Token: 0x04003B6E RID: 15214
		[Token(Token = "0x4003B6E")]
		[FieldOffset(Offset = "0x78")]
		public GameObject butterflyFaceEffectHungry;

		// Token: 0x04003B6F RID: 15215
		[Token(Token = "0x4003B6F")]
		[FieldOffset(Offset = "0x80")]
		public GameObject butterflyFaceEffectHappy;

		// Token: 0x04003B70 RID: 15216
		[Token(Token = "0x4003B70")]
		[FieldOffset(Offset = "0x88")]
		public float butterflyFaceDuration;

		// Token: 0x04003B71 RID: 15217
		[Token(Token = "0x4003B71")]
		[FieldOffset(Offset = "0x8C")]
		public float butterflyFaceOffset;
	}
}
