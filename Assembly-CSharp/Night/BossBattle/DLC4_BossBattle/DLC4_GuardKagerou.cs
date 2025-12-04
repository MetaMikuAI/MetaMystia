using System;
using System.Collections;
using Common.Audio;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001DC RID: 476
	[Token(Token = "0x20001DC")]
	[GenerateCleanupMethod]
	public class DLC4_GuardKagerou : DLC4_GuardController
	{
		// Token: 0x06000B78 RID: 2936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x8D3A70", Offset = "0x8D2470", VA = "0x1808D3A70", Slot = "4")]
		protected override void OnGuardControllerEnable()
		{
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x000051C0 File Offset: 0x000033C0
		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x8D3000", Offset = "0x8D1A00", VA = "0x1808D3000")]
		private GuestGroupController.EvaluationResult Eat(GuestGroupController.EvaluationResult result, GuestGroupController thisGuest, bool oldComboProtect, out string message, out bool comboProtect)
		{
			return GuestGroupController.EvaluationResult.Exbad;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x8D3330", Offset = "0x8D1D30", VA = "0x1808D3330", Slot = "7")]
		protected override void NormalAttack()
		{
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x8D3B50", Offset = "0x8D2550", VA = "0x1808D3B50", Slot = "8")]
		protected override IEnumerator SkillAttack()
		{
			return null;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x000051D8 File Offset: 0x000033D8
		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x8D3BD0", Offset = "0x8D25D0", VA = "0x1808D3BD0")]
		private Vector2 TargetEnemyPosition(Vector2 targetEnemyPosition, float bulletSpeed, out DLC4_FlandreEnemyCharacterController targetEnemy)
		{
			return default(Vector2);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x8D2FF0", Offset = "0x8D19F0", VA = "0x1808D2FF0", Slot = "12")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x8D05E0", Offset = "0x8CEFE0", VA = "0x1808D05E0")]
		public DLC4_GuardKagerou()
		{
		}

		// Token: 0x04000A0F RID: 2575
		[Token(Token = "0x4000A0F")]
		private const int MEAT_TAG = 0;

		// Token: 0x04000A10 RID: 2576
		[Token(Token = "0x4000A10")]
		private const string PRD_KAGEROU_REPULSE = "PRD_KAGEROU_REPULSE";

		// Token: 0x04000A11 RID: 2577
		[Token(Token = "0x4000A11")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_Damage;

		// Token: 0x04000A12 RID: 2578
		[Token(Token = "0x4000A12")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_RepulseRate;

		// Token: 0x04000A13 RID: 2579
		[Token(Token = "0x4000A13")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private float m_RepulseDistance;

		// Token: 0x04000A14 RID: 2580
		[Token(Token = "0x4000A14")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private int m_PowerUpDuration;

		// Token: 0x04000A15 RID: 2581
		[Token(Token = "0x4000A15")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private float m_PowerUpAttackMultiplier;

		// Token: 0x04000A16 RID: 2582
		[Token(Token = "0x4000A16")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private DLC4_GuardController.TeamBulletProperty m_UltimateSkillBullet;

		// Token: 0x04000A17 RID: 2583
		[Token(Token = "0x4000A17")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private float m_UltimateSkillBulletExplodeRange;

		// Token: 0x04000A18 RID: 2584
		[Token(Token = "0x4000A18")]
		[FieldOffset(Offset = "0x114")]
		[SerializeField]
		private float m_UltimateSkillBulletLaunchHeight;

		// Token: 0x04000A19 RID: 2585
		[Token(Token = "0x4000A19")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private VFXPrefab m_WolfClaw;

		// Token: 0x04000A1A RID: 2586
		[Token(Token = "0x4000A1A")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private VFXPrefab m_WolfClawPowerUp;

		// Token: 0x04000A1B RID: 2587
		[Token(Token = "0x4000A1B")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private VFXPrefab m_WolfDance;

		// Token: 0x04000A1C RID: 2588
		[Token(Token = "0x4000A1C")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private VFXPrefab m_BeastarVFX;

		// Token: 0x04000A1D RID: 2589
		[Token(Token = "0x4000A1D")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private Vector2 m_BeastarBuffUIDisplayOffset;

		// Token: 0x04000A1E RID: 2590
		[Token(Token = "0x4000A1E")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private GlobalAudioManager.DelayAudioClip m_WolfClawSfx;

		// Token: 0x04000A1F RID: 2591
		[Token(Token = "0x4000A1F")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private GlobalAudioManager.DelayAudioClip m_WolfDanceSfx;
	}
}
