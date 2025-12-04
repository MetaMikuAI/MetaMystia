using System;
using System.Collections;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001E0 RID: 480
	[Token(Token = "0x20001E0")]
	[GenerateCleanupMethod]
	public class DLC4_GuardMedicine : DLC4_GuardController
	{
		// Token: 0x06000B8F RID: 2959 RVA: 0x00005268 File Offset: 0x00003468
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x8D4230", Offset = "0x8D2C30", VA = "0x1808D4230", Slot = "6")]
		protected override bool CouldAttack()
		{
			return default(bool);
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x8D4440", Offset = "0x8D2E40", VA = "0x1808D4440", Slot = "7")]
		protected override void NormalAttack()
		{
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x8D4980", Offset = "0x8D3380", VA = "0x1808D4980", Slot = "8")]
		protected override IEnumerator SkillAttack()
		{
			return null;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x00005280 File Offset: 0x00003480
		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x8D4A00", Offset = "0x8D3400", VA = "0x1808D4A00")]
		private Vector2 TargetEnemyPosition(Func<bool> extraAttackCheck, Vector2 targetEnemyPosition, float bulletSpeed)
		{
			return default(Vector2);
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B93")]
		[Address(RVA = "0x8D4740", Offset = "0x8D3140", VA = "0x1808D4740", Slot = "9")]
		protected override void OnLoseExtraEffect()
		{
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x8D4200", Offset = "0x8D2C00", VA = "0x1808D4200", Slot = "12")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x8D05E0", Offset = "0x8CEFE0", VA = "0x1808D05E0")]
		public DLC4_GuardMedicine()
		{
		}

		// Token: 0x04000A26 RID: 2598
		[Token(Token = "0x4000A26")]
		private const string PRD_MEDICINE_POISON_LV1 = "PRD_MEDICINE_POISON_LV1";

		// Token: 0x04000A27 RID: 2599
		[Token(Token = "0x4000A27")]
		private const string PRD_MEDICINE_POISON_LV2 = "PRD_MEDICINE_POISON_LV2";

		// Token: 0x04000A28 RID: 2600
		[Token(Token = "0x4000A28")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private DLC4_GuardMedicine.MedicineBullet m_Level1Bullet;

		// Token: 0x04000A29 RID: 2601
		[Token(Token = "0x4000A29")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private DLC4_GuardMedicine.MedicineBullet m_Level2Bullet;

		// Token: 0x04000A2A RID: 2602
		[Token(Token = "0x4000A2A")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private DLC4_GuardController.TeamBulletProperty m_UltimateSkillBullet;

		// Token: 0x04000A2B RID: 2603
		[Token(Token = "0x4000A2B")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private DLC4_GuardMedicine.MedicinePoolBullet m_UltimateSkillAcidPool;

		// Token: 0x04000A2C RID: 2604
		[Token(Token = "0x4000A2C")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private DLC4_GuardMedicine.MedicineAcidPoolProperty m_DieEffect;

		// Token: 0x04000A2D RID: 2605
		[Token(Token = "0x4000A2D")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private VFXPrefab m_DieVFX;

		// Token: 0x04000A2E RID: 2606
		[Token(Token = "0x4000A2E")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private float m_LaunchHeight;

		// Token: 0x04000A2F RID: 2607
		[Token(Token = "0x4000A2F")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private AudioClip m_DieSfx;

		// Token: 0x020001E1 RID: 481
		[Token(Token = "0x20001E1")]
		[Serializable]
		private struct MedicineBullet
		{
			// Token: 0x04000A30 RID: 2608
			[Token(Token = "0x4000A30")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public DLC4_GuardController.TeamBulletProperty m_BaseBulletProperty;

			// Token: 0x04000A31 RID: 2609
			[Token(Token = "0x4000A31")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public DLC4_GuardMedicine.MedicineBulletProperty m_MedicineBulletProperty;
		}

		// Token: 0x020001E2 RID: 482
		[Token(Token = "0x20001E2")]
		[Serializable]
		public struct MedicinePoolBullet
		{
			// Token: 0x04000A32 RID: 2610
			[Token(Token = "0x4000A32")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public DLC4_GuardController.TeamBulletProperty m_BaseBulletProperty;

			// Token: 0x04000A33 RID: 2611
			[Token(Token = "0x4000A33")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public DLC4_GuardMedicine.MedicineAcidPoolProperty m_MedicineAcidPoolProperty;
		}

		// Token: 0x020001E3 RID: 483
		[Token(Token = "0x20001E3")]
		[Serializable]
		public struct MedicineBulletProperty
		{
			// Token: 0x04000A34 RID: 2612
			[Token(Token = "0x4000A34")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			[Range(0f, 1f)]
			public float m_PoisonRate;

			// Token: 0x04000A35 RID: 2613
			[Token(Token = "0x4000A35")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public int m_PoisonDamage;

			// Token: 0x04000A36 RID: 2614
			[Token(Token = "0x4000A36")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public int m_PoisonDuration;
		}

		// Token: 0x020001E4 RID: 484
		[Token(Token = "0x20001E4")]
		[Serializable]
		public struct MedicineAcidPoolProperty
		{
			// Token: 0x04000A37 RID: 2615
			[Token(Token = "0x4000A37")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public int m_PoisonDamage;

			// Token: 0x04000A38 RID: 2616
			[Token(Token = "0x4000A38")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public int m_PoisonDuration;

			// Token: 0x04000A39 RID: 2617
			[Token(Token = "0x4000A39")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public int m_PoolDuration;

			// Token: 0x04000A3A RID: 2618
			[Token(Token = "0x4000A3A")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			public float m_PoolRadius;

			// Token: 0x04000A3B RID: 2619
			[Token(Token = "0x4000A3B")]
			[FieldOffset(Offset = "0x10")]
			[Range(0f, 1f)]
			[SerializeField]
			public float m_PoolFrozenMultiplier;
		}
	}
}
