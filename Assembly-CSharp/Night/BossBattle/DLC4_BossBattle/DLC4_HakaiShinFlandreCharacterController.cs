using System;
using System.Collections;
using Common.Audio;
using Il2CppDummyDll;
using NightScene.UI.HUDUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001C0 RID: 448
	[Token(Token = "0x20001C0")]
	[GenerateCleanupMethod]
	public class DLC4_HakaiShinFlandreCharacterController : DLC4_FlandreEnemyCharacterController
	{
		// Token: 0x06000AD7 RID: 2775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x8D8B00", Offset = "0x8D7500", VA = "0x1808D8B00", Slot = "5")]
		public override void Initialize(DLC4_BossBattleManager dlc4BossBattleManager, Action afterAttackingFinishCallback, Action afterCompletelyDeadCallback, DLC4_FlandreEnemyCharacterController.AttackConditionCheck attackConditionCheck)
		{
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x8D9480", Offset = "0x8D7E80", VA = "0x1808D9480", Slot = "6")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x8D9540", Offset = "0x8D7F40", VA = "0x1808D9540")]
		private void Shoot()
		{
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x8D9590", Offset = "0x8D7F90", VA = "0x1808D9590")]
		private void SpawnBullet()
		{
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x8D98A0", Offset = "0x8D82A0", VA = "0x1808D98A0")]
		private IEnumerator StarRain()
		{
			return null;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x8D9450", Offset = "0x8D7E50", VA = "0x1808D9450", Slot = "9")]
		protected override void OnCurrentHPChangeCallback(int hpAfterChange)
		{
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x8D94F0", Offset = "0x8D7EF0", VA = "0x1808D94F0")]
		private void PlayThrowAnimation()
		{
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x8D8CE0", Offset = "0x8D76E0", VA = "0x1808D8CE0", Slot = "8")]
		protected override void OnAttack()
		{
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x8D8910", Offset = "0x8D7310", VA = "0x1808D8910")]
		private void HitAndPlayVfx(int deskCode, DLC4_HakaiShinFlandreCharacterController.QuakeProperty quakeProperty)
		{
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x8D8680", Offset = "0x8D7080", VA = "0x1808D8680", Slot = "11")]
		protected override void Die()
		{
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x8D9920", Offset = "0x8D8320", VA = "0x1808D9920")]
		private IEnumerator WhenHakaiShinDie()
		{
			return null;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x8D97E0", Offset = "0x8D81E0", VA = "0x1808D97E0")]
		private IEnumerator SpawnSpirit(Transform vfx, Vector3 target, FlandreTypeIndex id)
		{
			return null;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x8D8620", Offset = "0x8D7020", VA = "0x1808D8620", Slot = "12")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x40A3C0", Offset = "0x408DC0", VA = "0x18040A3C0")]
		public DLC4_HakaiShinFlandreCharacterController()
		{
		}

		// Token: 0x04000994 RID: 2452
		[Token(Token = "0x4000994")]
		private const string PARAMETER_THROW = "Throw";

		// Token: 0x04000995 RID: 2453
		[Token(Token = "0x4000995")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private DLC4_HakaiShinFlandreCharacterController.QuakeProperty m_SecondTargetDamage;

		// Token: 0x04000996 RID: 2454
		[Token(Token = "0x4000996")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		private DLC4_HakaiShinFlandreCharacterController.QuakeProperty m_ThirdTargetDamage;

		// Token: 0x04000997 RID: 2455
		[Token(Token = "0x4000997")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private DLC4_HakaiShinFlandreCharacterController.QuakeProperty m_FourthTargetDamage;

		// Token: 0x04000998 RID: 2456
		[Token(Token = "0x4000998")]
		[FieldOffset(Offset = "0x15C")]
		[SerializeField]
		private DLC4_HakaiShinFlandreCharacterController.QuakeProperty m_FifthTargetDamage;

		// Token: 0x04000999 RID: 2457
		[Token(Token = "0x4000999")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private float m_ShootInterval;

		// Token: 0x0400099A RID: 2458
		[Token(Token = "0x400099A")]
		[FieldOffset(Offset = "0x16C")]
		[SerializeField]
		private float m_RainInterval;

		// Token: 0x0400099B RID: 2459
		[Token(Token = "0x400099B")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private float m_StarRainNum;

		// Token: 0x0400099C RID: 2460
		[Token(Token = "0x400099C")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private DLC4_FlandreEnemyCharacterController.FlandreBullet m_StarBullet;

		// Token: 0x0400099D RID: 2461
		[Token(Token = "0x400099D")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private FlandreTypeIndex[] m_Doppelgangers_Id;

		// Token: 0x0400099E RID: 2462
		[Token(Token = "0x400099E")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private VFXPrefab m_DoppelgangerVFX;

		// Token: 0x0400099F RID: 2463
		[Token(Token = "0x400099F")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private float m_BatFogWait;

		// Token: 0x040009A0 RID: 2464
		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private VFXPrefab m_SpawnVFX;

		// Token: 0x040009A1 RID: 2465
		[Token(Token = "0x40009A1")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private VFXPrefab m_AttackVFX;

		// Token: 0x040009A2 RID: 2466
		[Token(Token = "0x40009A2")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private Vector2 m_AttackVFXOffset;

		// Token: 0x040009A3 RID: 2467
		[Token(Token = "0x40009A3")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private ParticleSystem m_RainParticleSystem;

		// Token: 0x040009A4 RID: 2468
		[Token(Token = "0x40009A4")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private GlobalAudioManager.DelayAudioClip m_SpawnRainAudioClip;

		// Token: 0x040009A5 RID: 2469
		[Token(Token = "0x40009A5")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		private GlobalAudioManager.DelayAudioClip m_DieSfx;

		// Token: 0x040009A6 RID: 2470
		[Token(Token = "0x40009A6")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		private GlobalAudioManager.DelayAudioClip m_AttackSfx;

		// Token: 0x040009A7 RID: 2471
		[Token(Token = "0x40009A7")]
		[FieldOffset(Offset = "0x228")]
		private bool hasInitialized;

		// Token: 0x040009A8 RID: 2472
		[Token(Token = "0x40009A8")]
		[FieldOffset(Offset = "0x230")]
		private IncomeControllerFlandre.FlandreBossHPContext hpContextInUI;

		// Token: 0x040009A9 RID: 2473
		[Token(Token = "0x40009A9")]
		[FieldOffset(Offset = "0x238")]
		private ThrowState throwManager;

		// Token: 0x040009AA RID: 2474
		[Token(Token = "0x40009AA")]
		[FieldOffset(Offset = "0x240")]
		private float waitToShootTime;

		// Token: 0x020001C1 RID: 449
		[Token(Token = "0x20001C1")]
		[Serializable]
		private struct QuakeProperty
		{
			// Token: 0x040009AB RID: 2475
			[Token(Token = "0x40009AB")]
			[FieldOffset(Offset = "0x0")]
			public int damage;

			// Token: 0x040009AC RID: 2476
			[Token(Token = "0x40009AC")]
			[FieldOffset(Offset = "0x4")]
			public float vfxScale;

			// Token: 0x040009AD RID: 2477
			[Token(Token = "0x40009AD")]
			[FieldOffset(Offset = "0x8")]
			public float vfxWait;
		}
	}
}
