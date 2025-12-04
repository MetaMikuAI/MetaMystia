using System;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000163 RID: 355
	[Token(Token = "0x2000163")]
	[GenerateCleanupMethod]
	public class DLC4_BulletEnemy : DLC4_BulletBase
	{
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x170000A6")]
		public override DLC4_BulletBase.BulletType BulletShooterType
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "4")]
			get
			{
				return DLC4_BulletBase.BulletType.Team;
			}
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000862")]
		[Address(RVA = "0x8239D0", Offset = "0x8223D0", VA = "0x1808239D0")]
		public void Initialize(DLC4_FlandreEnemyCharacterController shooter, DLC4_FlandreEnemyCharacterController.FlandreBullet bullet)
		{
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000863")]
		[Address(RVA = "0x823EB0", Offset = "0x8228B0", VA = "0x180823EB0", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000864")]
		[Address(RVA = "0x823A40", Offset = "0x822440", VA = "0x180823A40", Slot = "8")]
		protected virtual void OnExtraUpdate()
		{
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000865")]
		[Address(RVA = "0x823E10", Offset = "0x822810", VA = "0x180823E10", Slot = "9")]
		protected virtual void OnHit(DLC4_GuardController guard)
		{
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000866")]
		[Address(RVA = "0x823EE0", Offset = "0x8228E0", VA = "0x180823EE0")]
		protected void PlayHitSfx()
		{
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000867")]
		[Address(RVA = "0x823970", Offset = "0x822370", VA = "0x180823970", Slot = "7")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000868")]
		[Address(RVA = "0x822F20", Offset = "0x821920", VA = "0x180822F20")]
		public DLC4_BulletEnemy()
		{
		}

		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x400079B")]
		[FieldOffset(Offset = "0x68")]
		[InspectorSpace(2f)]
		[CanBeNull]
		[SerializeField]
		private AudioClip hitSfx;

		// Token: 0x0400079C RID: 1948
		[Token(Token = "0x400079C")]
		[FieldOffset(Offset = "0x70")]
		protected int CurrentLine;

		// Token: 0x0400079D RID: 1949
		[Token(Token = "0x400079D")]
		[FieldOffset(Offset = "0x78")]
		protected DLC4_FlandreEnemyCharacterController Shooter;
	}
}
