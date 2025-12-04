using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000166 RID: 358
	[Token(Token = "0x2000166")]
	[GenerateCleanupMethod]
	public class DLC4_BulletTeamParabolic : DLC4_BulletTeam
	{
		// Token: 0x0600087A RID: 2170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x825BE0", Offset = "0x8245E0", VA = "0x180825BE0")]
		public void OnParabolicBulletEnable(float launchHeight, Vector2 targetPosition, int? availableLine, bool modifyAngle = false, float extraDamageMultiplier = 1f)
		{
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x825A70", Offset = "0x824470", VA = "0x180825A70")]
		private IEnumerator LerpParabolic(bool rotate)
		{
			return null;
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x825B40", Offset = "0x824540", VA = "0x180825B40", Slot = "8")]
		protected override void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x825B00", Offset = "0x824500", VA = "0x180825B00", Slot = "6")]
		protected override void OnDispose()
		{
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x8243D0", Offset = "0x822DD0", VA = "0x1808243D0", Slot = "7")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x822F20", Offset = "0x821920", VA = "0x180822F20")]
		public DLC4_BulletTeamParabolic()
		{
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x825CD0", Offset = "0x8246D0", VA = "0x180825CD0")]
		[CompilerGenerated]
		private Vector3 <LerpParabolic>g__TargetPosition|6_0()
		{
			return default(Vector3);
		}

		// Token: 0x040007A4 RID: 1956
		[Token(Token = "0x40007A4")]
		[FieldOffset(Offset = "0x88")]
		protected int? AvailableLine;

		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		[FieldOffset(Offset = "0x90")]
		private float launchHeight;

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x98")]
		private Coroutine lerpCoroutine;

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		[FieldOffset(Offset = "0xA0")]
		protected Vector2 TargetEnemyPosition;
	}
}
