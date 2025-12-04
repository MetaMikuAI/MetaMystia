using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000173 RID: 371
	[Token(Token = "0x2000173")]
	[GenerateCleanupMethod]
	public class DLC4_SunFlowerSmallBullet : DLC4_BulletTeamLinear
	{
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B7")]
		public DLC4_FlandreEnemyCharacterController IgnoreEnemy
		{
			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x440500", Offset = "0x43EF00", VA = "0x180440500")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x48AAA0", Offset = "0x4894A0", VA = "0x18048AAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x826870", Offset = "0x825270", VA = "0x180826870", Slot = "8")]
		protected override void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x8243D0", Offset = "0x822DD0", VA = "0x1808243D0", Slot = "7")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x822F20", Offset = "0x821920", VA = "0x180822F20")]
		public DLC4_SunFlowerSmallBullet()
		{
		}
	}
}
