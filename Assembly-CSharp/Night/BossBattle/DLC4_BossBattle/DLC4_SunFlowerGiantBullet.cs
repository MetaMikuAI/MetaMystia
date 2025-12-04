using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000172 RID: 370
	[Token(Token = "0x2000172")]
	[GenerateCleanupMethod]
	public class DLC4_SunFlowerGiantBullet : DLC4_BulletTeamLinear
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060008CC RID: 2252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B6")]
		public Action<Vector2> OnHitEnemy
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x440500", Offset = "0x43EF00", VA = "0x180440500")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x48AAA0", Offset = "0x4894A0", VA = "0x18048AAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x8267F0", Offset = "0x8251F0", VA = "0x1808267F0", Slot = "9")]
		protected override void AfterHitEnemy(DLC4_FlandreEnemyCharacterController enemy)
		{
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x8243D0", Offset = "0x822DD0", VA = "0x1808243D0", Slot = "7")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x822F20", Offset = "0x821920", VA = "0x180822F20")]
		public DLC4_SunFlowerGiantBullet()
		{
		}
	}
}
