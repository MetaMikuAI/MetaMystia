using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001CA RID: 458
	[Token(Token = "0x20001CA")]
	public class DLC4_GuardAya : DLC4_GuardController
	{
		// Token: 0x06000B06 RID: 2822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x8D03F0", Offset = "0x8CEDF0", VA = "0x1808D03F0", Slot = "7")]
		protected override void NormalAttack()
		{
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B07")]
		[Address(RVA = "0x8D0560", Offset = "0x8CEF60", VA = "0x1808D0560", Slot = "8")]
		protected override IEnumerator SkillAttack()
		{
			return null;
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B08")]
		[Address(RVA = "0x8D05E0", Offset = "0x8CEFE0", VA = "0x1808D05E0")]
		public DLC4_GuardAya()
		{
		}

		// Token: 0x040009C7 RID: 2503
		[Token(Token = "0x40009C7")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private DLC4_GuardAya.AyaBullet m_Level1Bullet;

		// Token: 0x040009C8 RID: 2504
		[Token(Token = "0x40009C8")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private DLC4_GuardAya.AyaBullet m_Level2Bullet;

		// Token: 0x040009C9 RID: 2505
		[Token(Token = "0x40009C9")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private DLC4_GuardController.TeamBulletProperty m_UltimateSkillBullet;

		// Token: 0x020001CB RID: 459
		[Token(Token = "0x20001CB")]
		[Serializable]
		private struct AyaBullet
		{
			// Token: 0x040009CA RID: 2506
			[Token(Token = "0x40009CA")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public DLC4_GuardController.TeamBulletProperty m_BaseBulletProperty;

			// Token: 0x040009CB RID: 2507
			[Token(Token = "0x40009CB")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public DLC4_GuardAya.AyaBulletProperty m_AyaBulletProperty;
		}

		// Token: 0x020001CC RID: 460
		[Token(Token = "0x20001CC")]
		[Serializable]
		public struct AyaBulletProperty
		{
			// Token: 0x040009CC RID: 2508
			[Token(Token = "0x40009CC")]
			[FieldOffset(Offset = "0x0")]
			[Range(0f, 1f)]
			[FormerlySerializedAs("m_FrozenRate")]
			[SerializeField]
			public float m_FrozenMultiplier;

			// Token: 0x040009CD RID: 2509
			[Token(Token = "0x40009CD")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public int m_FrozenDuration;

			// Token: 0x040009CE RID: 2510
			[Token(Token = "0x40009CE")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public float m_Radius;
		}
	}
}
