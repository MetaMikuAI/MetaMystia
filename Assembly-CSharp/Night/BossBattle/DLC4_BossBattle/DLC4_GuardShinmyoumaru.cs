using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Common.Audio;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Serialization;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001F0 RID: 496
	[Token(Token = "0x20001F0")]
	[GenerateCleanupMethod]
	public class DLC4_GuardShinmyoumaru : DLC4_GuardController
	{
		// Token: 0x06000BD6 RID: 3030 RVA: 0x00005430 File Offset: 0x00003630
		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x8D6090", Offset = "0x8D4A90", VA = "0x1808D6090", Slot = "6")]
		protected override bool CouldAttack()
		{
			return default(bool);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x8D60E0", Offset = "0x8D4AE0", VA = "0x1808D60E0", Slot = "7")]
		protected override void NormalAttack()
		{
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x8D65F0", Offset = "0x8D4FF0", VA = "0x1808D65F0", Slot = "8")]
		protected override IEnumerator SkillAttack()
		{
			return null;
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x8D63B0", Offset = "0x8D4DB0", VA = "0x1808D63B0")]
		private void SetTargetGuardYuuSha(DLC4_GuardController guard, float duration)
		{
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x8D6060", Offset = "0x8D4A60", VA = "0x1808D6060", Slot = "12")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x8D05E0", Offset = "0x8CEFE0", VA = "0x1808D05E0")]
		public DLC4_GuardShinmyoumaru()
		{
		}

		// Token: 0x04000A7B RID: 2683
		[Token(Token = "0x4000A7B")]
		private const int AURABURSTING_TAG = 35;

		// Token: 0x04000A7C RID: 2684
		[Token(Token = "0x4000A7C")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private DLC4_GuardShinmyoumaru.ShinmyoumaruBullet m_Level1Bullet;

		// Token: 0x04000A7D RID: 2685
		[Token(Token = "0x4000A7D")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private DLC4_GuardShinmyoumaru.ShinmyoumaruBullet m_Level2Bullet;

		// Token: 0x04000A7E RID: 2686
		[Token(Token = "0x4000A7E")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private int m_UltimateSkillDurationForSelf;

		// Token: 0x04000A7F RID: 2687
		[Token(Token = "0x4000A7F")]
		[FieldOffset(Offset = "0x144")]
		[SerializeField]
		private float m_AttackSpeedMultiplier;

		// Token: 0x04000A80 RID: 2688
		[Token(Token = "0x4000A80")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private float m_YuushaBuffBaseTimeForTeammate;

		// Token: 0x04000A81 RID: 2689
		[Token(Token = "0x4000A81")]
		[FieldOffset(Offset = "0x14C")]
		[SerializeField]
		private int m_YuushaBuffAtLeastCostP;

		// Token: 0x04000A82 RID: 2690
		[Token(Token = "0x4000A82")]
		[FieldOffset(Offset = "0x150")]
		[Range(0f, 1f)]
		[SerializeField]
		private float m_YuushaBuffAtLeastCostPPercentage;

		// Token: 0x04000A83 RID: 2691
		[Token(Token = "0x4000A83")]
		[FieldOffset(Offset = "0x154")]
		[SerializeField]
		private int m_YuushaBuffCostPPerSec;

		// Token: 0x04000A84 RID: 2692
		[Token(Token = "0x4000A84")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private VFXPrefab m_YuushaBuffUIDisplay;

		// Token: 0x04000A85 RID: 2693
		[Token(Token = "0x4000A85")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private Vector2 m_YuushaBuffUIDisplayOffset;

		// Token: 0x04000A86 RID: 2694
		[Token(Token = "0x4000A86")]
		[FieldOffset(Offset = "0x178")]
		[FormerlySerializedAs("m_YuushaGlory")]
		[SerializeField]
		private VFXPrefab m_YuushaNoChikara;

		// Token: 0x04000A87 RID: 2695
		[Token(Token = "0x4000A87")]
		[FieldOffset(Offset = "0x190")]
		[FormerlySerializedAs("m_YuushaGloryOffset")]
		[SerializeField]
		private Vector2 m_YuushaNoChikaraOffset;

		// Token: 0x04000A88 RID: 2696
		[Token(Token = "0x4000A88")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[FormerlySerializedAs("m_YuushaGloryWaitToEnable")]
		private float m_YuushaNoChikaraWaitToEnable;

		// Token: 0x04000A89 RID: 2697
		[Token(Token = "0x4000A89")]
		[FieldOffset(Offset = "0x1A0")]
		[Header("Sfx")]
		[SerializeField]
		private AudioClip m_YuushaNoChikaraSfx;

		// Token: 0x04000A8A RID: 2698
		[Token(Token = "0x4000A8A")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private GlobalAudioManager.DelayAudioClip m_YuushaNoChikaraWalletSfx;

		// Token: 0x04000A8B RID: 2699
		[Token(Token = "0x4000A8B")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private GlobalAudioManager.DelayAudioClip m_YuushaNoChikaraWalletBoomSfx;

		// Token: 0x020001F1 RID: 497
		[Token(Token = "0x20001F1")]
		[Serializable]
		private struct ShinmyoumaruBullet
		{
			// Token: 0x04000A8C RID: 2700
			[Token(Token = "0x4000A8C")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public DLC4_GuardController.TeamBulletProperty m_BaseBulletProperty;

			// Token: 0x04000A8D RID: 2701
			[Token(Token = "0x4000A8D")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty m_ShinmyoumaruBulletProperty;
		}

		// Token: 0x020001F2 RID: 498
		[Token(Token = "0x20001F2")]
		[Serializable]
		public struct ShinmyoumaruBulletProperty
		{
			// Token: 0x1700013C RID: 316
			// (get) Token: 0x06000BDE RID: 3038 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06000BDF RID: 3039 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700013C")]
			public DLC4_FlandreEnemyCharacterController TargetEnemy
			{
				[Token(Token = "0x6000BDE")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				[CompilerGenerated]
				readonly get
				{
					return null;
				}
				[Token(Token = "0x6000BDF")]
				[Address(RVA = "0x4A6ED0", Offset = "0x4A58D0", VA = "0x1804A6ED0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x04000A8E RID: 2702
			[Token(Token = "0x4000A8E")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public float m_StunDuration;

			// Token: 0x04000A8F RID: 2703
			[Token(Token = "0x4000A8F")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public bool m_CanGetP;

			// Token: 0x04000A90 RID: 2704
			[Token(Token = "0x4000A90")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public int m_PGetNum;
		}
	}
}
