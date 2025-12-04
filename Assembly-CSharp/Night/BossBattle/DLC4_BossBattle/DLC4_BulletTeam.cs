using System;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000164 RID: 356
	[Token(Token = "0x2000164")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(Collider2D))]
	public abstract class DLC4_BulletTeam : DLC4_BulletBase
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x170000A7")]
		public override DLC4_BulletBase.BulletType BulletShooterType
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "4")]
			get
			{
				return DLC4_BulletBase.BulletType.Team;
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x8263E0", Offset = "0x824DE0", VA = "0x1808263E0")]
		private void OnTriggerEnter2D(Collider2D col)
		{
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x825EA0", Offset = "0x8248A0", VA = "0x180825EA0")]
		public void Initialize(DLC4_GuardController shooter, DLC4_GuardController.TeamBulletProperty bullet)
		{
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x826710", Offset = "0x825110", VA = "0x180826710")]
		protected void StunEnemy(DLC4_FlandreEnemyCharacterController enemy, float duration, out Action interruptCallback)
		{
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x825E20", Offset = "0x824820", VA = "0x180825E20")]
		protected void DecelerationEnemy(DLC4_FlandreEnemyCharacterController enemy, float multiplier, float duration, bool checkCanBeFrozen, BulletTypeIndex bulletId)
		{
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x825DA0", Offset = "0x8247A0", VA = "0x180825DA0")]
		protected void DecelerationEnemyEnvironment(DLC4_FlandreEnemyCharacterController enemy, float multiplier, float duration, bool checkCanBeFrozen)
		{
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x8266E0", Offset = "0x8250E0", VA = "0x1808266E0")]
		protected void PoisonEnemy(DLC4_FlandreEnemyCharacterController enemy, int damage, float duration, BulletTypeIndex bulletId)
		{
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x8261F0", Offset = "0x824BF0", VA = "0x1808261F0", Slot = "8")]
		protected virtual void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x825D00", Offset = "0x824700", VA = "0x180825D00", Slot = "9")]
		protected virtual void AfterHitEnemy(DLC4_FlandreEnemyCharacterController enemy)
		{
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x826040", Offset = "0x824A40", VA = "0x180826040", Slot = "6")]
		protected override void OnDispose()
		{
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x826630", Offset = "0x825030", VA = "0x180826630")]
		protected void PlaySpawnSFX()
		{
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x8264C0", Offset = "0x824EC0", VA = "0x1808264C0")]
		protected void PlayHitSFX()
		{
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x825D20", Offset = "0x824720", VA = "0x180825D20", Slot = "7")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x822F20", Offset = "0x821920", VA = "0x180822F20")]
		protected DLC4_BulletTeam()
		{
		}

		// Token: 0x0400079E RID: 1950
		[Token(Token = "0x400079E")]
		protected const int ENEMY_LAYER = 9;

		// Token: 0x0400079F RID: 1951
		[Token(Token = "0x400079F")]
		[FieldOffset(Offset = "0x68")]
		[Header("音效")]
		[SerializeField]
		private AudioClip spawnSfx;

		// Token: 0x040007A0 RID: 1952
		[Token(Token = "0x40007A0")]
		[FieldOffset(Offset = "0x70")]
		[InspectorSpace(2f)]
		[CanBeNull]
		[SerializeField]
		private AudioClip hitSfx;

		// Token: 0x040007A1 RID: 1953
		[Token(Token = "0x40007A1")]
		[FieldOffset(Offset = "0x78")]
		protected Collider2D collider;

		// Token: 0x040007A2 RID: 1954
		[Token(Token = "0x40007A2")]
		[FieldOffset(Offset = "0x80")]
		protected DLC4_GuardController Shooter;
	}
}
