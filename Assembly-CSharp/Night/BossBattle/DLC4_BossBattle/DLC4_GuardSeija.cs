using System;
using System.Collections;
using Common.Audio;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001E7 RID: 487
	[Token(Token = "0x20001E7")]
	[GenerateCleanupMethod]
	public class DLC4_GuardSeija : DLC4_GuardController
	{
		// Token: 0x06000BA3 RID: 2979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x8D53E0", Offset = "0x8D3DE0", VA = "0x1808D53E0")]
		private void SetIgnoreStatus()
		{
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA4")]
		[Address(RVA = "0x8D5250", Offset = "0x8D3C50", VA = "0x1808D5250", Slot = "4")]
		protected override void OnGuardControllerEnable()
		{
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000052F8 File Offset: 0x000034F8
		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x8D4EA0", Offset = "0x8D38A0", VA = "0x1808D4EA0", Slot = "6")]
		protected override bool CouldAttack()
		{
			return default(bool);
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x8D5270", Offset = "0x8D3C70", VA = "0x1808D5270", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x00005310 File Offset: 0x00003510
		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x8D4F00", Offset = "0x8D3900", VA = "0x1808D4F00")]
		public float GetPower()
		{
			return 0f;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x8D50F0", Offset = "0x8D3AF0", VA = "0x1808D50F0", Slot = "7")]
		protected override void NormalAttack()
		{
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x8D5190", Offset = "0x8D3B90", VA = "0x1808D5190")]
		private IEnumerator NormalShootBow()
		{
			return null;
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x8D57C0", Offset = "0x8D41C0", VA = "0x1808D57C0")]
		private void ShootBow()
		{
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x00005328 File Offset: 0x00003528
		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x8D5B20", Offset = "0x8D4520", VA = "0x1808D5B20")]
		private Vector2? TargetEnemyPosition(float bulletSpeed, out DLC4_FlandreEnemyCharacterController enemy)
		{
			return null;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x00005340 File Offset: 0x00003540
		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x8D5030", Offset = "0x8D3A30", VA = "0x1808D5030")]
		private static Vector2 GetTargetEnemyPosition(float bulletSpeed, DLC4_FlandreEnemyCharacterController enemy)
		{
			return default(Vector2);
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x8D5AA0", Offset = "0x8D44A0", VA = "0x1808D5AA0", Slot = "8")]
		protected override IEnumerator SkillAttack()
		{
			return null;
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x8D5730", Offset = "0x8D4130", VA = "0x1808D5730")]
		private IEnumerator SetReverse(DLC4_FlandreEnemyCharacterController enemy)
		{
			return null;
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x8D5210", Offset = "0x8D3C10", VA = "0x1808D5210", Slot = "10")]
		protected override void OnDispose()
		{
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x8D4E20", Offset = "0x8D3820", VA = "0x1808D4E20", Slot = "12")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x8D05E0", Offset = "0x8CEFE0", VA = "0x1808D05E0")]
		public DLC4_GuardSeija()
		{
		}

		// Token: 0x04000A41 RID: 2625
		[Token(Token = "0x4000A41")]
		private const int SHINMYOUMARU_GUARD_ID = 4204;

		// Token: 0x04000A42 RID: 2626
		[Token(Token = "0x4000A42")]
		private const string PUT_ON_ANIM = "PutOn";

		// Token: 0x04000A43 RID: 2627
		[Token(Token = "0x4000A43")]
		private const string TAKE_OFF_ANIM = "TakeOff";

		// Token: 0x04000A44 RID: 2628
		[Token(Token = "0x4000A44")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private float m_SingleMultiplier;

		// Token: 0x04000A45 RID: 2629
		[Token(Token = "0x4000A45")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private DLC4_GuardController.TeamBulletProperty m_SeijaBowBullet;

		// Token: 0x04000A46 RID: 2630
		[Token(Token = "0x4000A46")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private DLC4_GuardController.TeamBulletProperty m_SeijaBowBullet2;

		// Token: 0x04000A47 RID: 2631
		[Token(Token = "0x4000A47")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float m_BulletLaunchHeight;

		// Token: 0x04000A48 RID: 2632
		[Token(Token = "0x4000A48")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private int m_UltimateSkillReverseNum;

		// Token: 0x04000A49 RID: 2633
		[Token(Token = "0x4000A49")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float m_UltimateSkillReverseDuration;

		// Token: 0x04000A4A RID: 2634
		[Token(Token = "0x4000A4A")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private GameObject m_StealthBlanket;

		// Token: 0x04000A4B RID: 2635
		[Token(Token = "0x4000A4B")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Vector2 m_StealthBlanketOffset;

		// Token: 0x04000A4C RID: 2636
		[Token(Token = "0x4000A4C")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private float m_StealthBlanketDuration;

		// Token: 0x04000A4D RID: 2637
		[Token(Token = "0x4000A4D")]
		[FieldOffset(Offset = "0x13C")]
		[SerializeField]
		private float m_StealthBlanketCoolDown;

		// Token: 0x04000A4E RID: 2638
		[Token(Token = "0x4000A4E")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private VFXPrefab m_BoomBalloonVFX;

		// Token: 0x04000A4F RID: 2639
		[Token(Token = "0x4000A4F")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Vector2 m_BalloonSpawnOffset;

		// Token: 0x04000A50 RID: 2640
		[Token(Token = "0x4000A50")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private Vector2 m_BalloonBombOffset;

		// Token: 0x04000A51 RID: 2641
		[Token(Token = "0x4000A51")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private float m_BoomBalloonDelay;

		// Token: 0x04000A52 RID: 2642
		[Token(Token = "0x4000A52")]
		[FieldOffset(Offset = "0x16C")]
		[SerializeField]
		private float m_BoomBalloonFlyTime;

		// Token: 0x04000A53 RID: 2643
		[Token(Token = "0x4000A53")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private float m_BoomBalloonRemaining;

		// Token: 0x04000A54 RID: 2644
		[Token(Token = "0x4000A54")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private GlobalAudioManager.DelayAudioClip m_BlanketSfx;

		// Token: 0x04000A55 RID: 2645
		[Token(Token = "0x4000A55")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private GlobalAudioManager.DelayAudioClip m_BalloonLiftSfx;

		// Token: 0x04000A56 RID: 2646
		[Token(Token = "0x4000A56")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private GlobalAudioManager.DelayAudioClip m_BalloonBoomSfx;

		// Token: 0x04000A57 RID: 2647
		[Token(Token = "0x4000A57")]
		[FieldOffset(Offset = "0x1A8")]
		private Animator blanketAnimator;

		// Token: 0x04000A58 RID: 2648
		[Token(Token = "0x4000A58")]
		[FieldOffset(Offset = "0x1B0")]
		private DLC4_GuardSeija.BlanketStatus currentBlanketStatus;

		// Token: 0x04000A59 RID: 2649
		[Token(Token = "0x4000A59")]
		[FieldOffset(Offset = "0x1B8")]
		private Coroutine normalAttackCoroutine;

		// Token: 0x04000A5A RID: 2650
		[Token(Token = "0x4000A5A")]
		[FieldOffset(Offset = "0x1C0")]
		private GameObject stealthBlanket;

		// Token: 0x04000A5B RID: 2651
		[Token(Token = "0x4000A5B")]
		[FieldOffset(Offset = "0x1C8")]
		private float stealthBlanketRemainingCoolDown;

		// Token: 0x04000A5C RID: 2652
		[Token(Token = "0x4000A5C")]
		[FieldOffset(Offset = "0x1CC")]
		private float stealthBlanketRemainingDuration;

		// Token: 0x020001E8 RID: 488
		[Token(Token = "0x20001E8")]
		private enum BlanketStatus
		{
			// Token: 0x04000A5E RID: 2654
			[Token(Token = "0x4000A5E")]
			Idle,
			// Token: 0x04000A5F RID: 2655
			[Token(Token = "0x4000A5F")]
			Triggered,
			// Token: 0x04000A60 RID: 2656
			[Token(Token = "0x4000A60")]
			CoolDown
		}
	}
}
