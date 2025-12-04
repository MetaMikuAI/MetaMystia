using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x020009D4 RID: 2516
	[Token(Token = "0x20009D4")]
	[CreateAssetMenu(fileName = "DLC3_Spell_Murasa", menuName = "Spells/DLC3/Murasa", order = 1)]
	public class Spell_Murasa : SpellBase
	{
		// Token: 0x06003DC7 RID: 15815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC7")]
		[Address(RVA = "0x6B3A00", Offset = "0x6B2400", VA = "0x1806B3A00", Slot = "6")]
		protected override string OnGettingSpellOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06003DC8 RID: 15816 RVA: 0x00016EF0 File Offset: 0x000150F0
		[Token(Token = "0x6003DC8")]
		[Address(RVA = "0x6B3930", Offset = "0x6B2330", VA = "0x1806B3930")]
		private float GetProgress(float progress)
		{
			return 0f;
		}

		// Token: 0x06003DC9 RID: 15817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DC9")]
		[Address(RVA = "0x6B3A30", Offset = "0x6B2430", VA = "0x1806B3A30", Slot = "10")]
		protected override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003DCA RID: 15818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DCA")]
		[Address(RVA = "0x6B3AB0", Offset = "0x6B24B0", VA = "0x1806B3AB0", Slot = "8")]
		protected override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			return null;
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DCB")]
		[Address(RVA = "0x6B3B90", Offset = "0x6B2590", VA = "0x1806B3B90")]
		public Spell_Murasa()
		{
		}

		// Token: 0x040035A5 RID: 13733
		[Token(Token = "0x40035A5")]
		[FieldOffset(Offset = "0x18")]
		public float positiveDuration;

		// Token: 0x040035A6 RID: 13734
		[Token(Token = "0x40035A6")]
		[FieldOffset(Offset = "0x1C")]
		public float stunDuration;

		// Token: 0x040035A7 RID: 13735
		[Token(Token = "0x40035A7")]
		[FieldOffset(Offset = "0x20")]
		public float reverseDuration;

		// Token: 0x040035A8 RID: 13736
		[Token(Token = "0x40035A8")]
		[FieldOffset(Offset = "0x28")]
		public GameObject shipAnchorEffect;

		// Token: 0x040035A9 RID: 13737
		[Token(Token = "0x40035A9")]
		[FieldOffset(Offset = "0x30")]
		public GameObject vertexGameObject;

		// Token: 0x040035AA RID: 13738
		[Token(Token = "0x40035AA")]
		[FieldOffset(Offset = "0x38")]
		public GameObject dizzyEffect;

		// Token: 0x040035AB RID: 13739
		[Token(Token = "0x40035AB")]
		[FieldOffset(Offset = "0x40")]
		public float maxSpeed;

		// Token: 0x040035AC RID: 13740
		[Token(Token = "0x40035AC")]
		[FieldOffset(Offset = "0x48")]
		public Vector3[] bezierPoint;

		// Token: 0x040035AD RID: 13741
		[Token(Token = "0x40035AD")]
		[FieldOffset(Offset = "0x50")]
		[Header("SFX")]
		public SpellBase.DelayAudioClip anchorSFX;

		// Token: 0x040035AE RID: 13742
		[Token(Token = "0x40035AE")]
		[FieldOffset(Offset = "0x60")]
		public SpellBase.DelayAudioClip vertexSFX;

		// Token: 0x040035AF RID: 13743
		[Token(Token = "0x40035AF")]
		[FieldOffset(Offset = "0x70")]
		public SpellBase.DelayAudioClip rotateSFX;
	}
}
