using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200015C RID: 348
	[Token(Token = "0x200015C")]
	[GenerateCleanupMethod]
	public class DLC4_BulletAyaTornado : DLC4_BulletTeamLinear
	{
		// Token: 0x06000834 RID: 2100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x822860", Offset = "0x821260", VA = "0x180822860")]
		public void OnBulletEnable()
		{
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x822B40", Offset = "0x821540", VA = "0x180822B40", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x822A10", Offset = "0x821410", VA = "0x180822A10", Slot = "8")]
		protected override void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x822EA0", Offset = "0x8218A0", VA = "0x180822EA0")]
		private IEnumerator WaitAndChangeSpeed()
		{
			return null;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x822650", Offset = "0x821050", VA = "0x180822650")]
		private void AfterHit()
		{
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x8227E0", Offset = "0x8211E0", VA = "0x1808227E0", Slot = "7")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x822F20", Offset = "0x821920", VA = "0x180822F20")]
		public DLC4_BulletAyaTornado()
		{
		}

		// Token: 0x0400077E RID: 1918
		[Token(Token = "0x400077E")]
		[FieldOffset(Offset = "0x98")]
		private bool arrived;

		// Token: 0x0400077F RID: 1919
		[Token(Token = "0x400077F")]
		[FieldOffset(Offset = "0xA0")]
		private Action onWindDispose;

		// Token: 0x04000780 RID: 1920
		[Token(Token = "0x4000780")]
		[FieldOffset(Offset = "0xA8")]
		private ParticleSystem particleSystem;

		// Token: 0x04000781 RID: 1921
		[Token(Token = "0x4000781")]
		[FieldOffset(Offset = "0xB0")]
		private Coroutine waitCoroutine;

		// Token: 0x04000782 RID: 1922
		[Token(Token = "0x4000782")]
		[FieldOffset(Offset = "0xB8")]
		private HashSet<DLC4_FlandreEnemyCharacterController> windHitEnemy;
	}
}
