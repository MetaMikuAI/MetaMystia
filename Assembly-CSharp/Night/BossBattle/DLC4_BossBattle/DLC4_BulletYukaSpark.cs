using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000171 RID: 369
	[Token(Token = "0x2000171")]
	[GenerateCleanupMethod]
	public class DLC4_BulletYukaSpark : DLC4_BulletTeam
	{
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x00004338 File Offset: 0x00002538
		// (set) Token: 0x060008C7 RID: 2247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B5")]
		public float StunDuration
		{
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x8267D0", Offset = "0x8251D0", VA = "0x1808267D0")]
			[CompilerGenerated]
			private get
			{
				return 0f;
			}
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x8267E0", Offset = "0x8251E0", VA = "0x1808267E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x826770", Offset = "0x825170", VA = "0x180826770", Slot = "8")]
		protected override void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x826740", Offset = "0x825140", VA = "0x180826740", Slot = "7")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x822F20", Offset = "0x821920", VA = "0x180822F20")]
		public DLC4_BulletYukaSpark()
		{
		}

		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		[FieldOffset(Offset = "0x88")]
		public Collider2D m_Collider;
	}
}
