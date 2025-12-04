using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	[GenerateCleanupMethod]
	public class DLC4_BulletTeamLinear : DLC4_BulletTeam
	{
		// Token: 0x06000877 RID: 2167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x825890", Offset = "0x824290", VA = "0x180825890", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x825800", Offset = "0x824200", VA = "0x180825800", Slot = "7")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x822F20", Offset = "0x821920", VA = "0x180822F20")]
		public DLC4_BulletTeamLinear()
		{
		}

		// Token: 0x040007A3 RID: 1955
		[Token(Token = "0x40007A3")]
		[FieldOffset(Offset = "0x88")]
		public Vector2? OverrideMoveDirection;
	}
}
