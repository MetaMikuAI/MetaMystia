using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200016F RID: 367
	[Token(Token = "0x200016F")]
	[GenerateCleanupMethod]
	public class DLC4_BulletMagicWallet : DLC4_BulletTeam
	{
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00004308 File Offset: 0x00002508
		// (set) Token: 0x060008B9 RID: 2233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B2")]
		public DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty MagicWalletProperty
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x824CE0", Offset = "0x8236E0", VA = "0x180824CE0")]
			[CompilerGenerated]
			private get
			{
				return default(DLC4_GuardShinmyoumaru.ShinmyoumaruBulletProperty);
			}
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x824D00", Offset = "0x823700", VA = "0x180824D00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x824AB0", Offset = "0x8234B0", VA = "0x180824AB0")]
		public void OnBulletEnable()
		{
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x824A20", Offset = "0x823420", VA = "0x180824A20")]
		private IEnumerator FollowEnemy()
		{
			return null;
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x8245B0", Offset = "0x822FB0", VA = "0x1808245B0")]
		public void Attack()
		{
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x824AA0", Offset = "0x8234A0", VA = "0x180824AA0")]
		public void Miss()
		{
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x8249D0", Offset = "0x8233D0", VA = "0x1808249D0", Slot = "7")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x822F20", Offset = "0x821920", VA = "0x180822F20")]
		public DLC4_BulletMagicWallet()
		{
		}

		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x40007BF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Vector2 m_Offset;

		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x40007C0")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private VFXPrefab m_SpawnVFX;

		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x40007C1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private VFXPrefab m_DisappearVFX;

		// Token: 0x040007C2 RID: 1986
		[Token(Token = "0x40007C2")]
		[FieldOffset(Offset = "0xC0")]
		private Coroutine followCoroutine;

		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x40007C3")]
		[FieldOffset(Offset = "0xC8")]
		private DLC4_FlandreEnemyCharacterController TargetEnemy;
	}
}
