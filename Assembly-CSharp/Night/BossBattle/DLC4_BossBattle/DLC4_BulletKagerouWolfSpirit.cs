using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	[GenerateCleanupMethod]
	public class DLC4_BulletKagerouWolfSpirit : DLC4_BulletTeamParabolic
	{
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x00004248 File Offset: 0x00002448
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000AA")]
		public float ExplodeRange
		{
			[Token(Token = "0x600088C")]
			[Address(RVA = "0x440550", Offset = "0x43EF50", VA = "0x180440550")]
			[CompilerGenerated]
			private get
			{
				return 0f;
			}
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x6086F0", Offset = "0x6070F0", VA = "0x1806086F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "8")]
		protected override void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600088F")]
		[Address(RVA = "0x824400", Offset = "0x822E00", VA = "0x180824400", Slot = "6")]
		protected override void OnDispose()
		{
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x8243D0", Offset = "0x822DD0", VA = "0x1808243D0", Slot = "7")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x822F20", Offset = "0x821920", VA = "0x180822F20")]
		public DLC4_BulletKagerouWolfSpirit()
		{
		}
	}
}
