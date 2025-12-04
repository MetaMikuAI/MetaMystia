using System;
using System.Collections;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001F7 RID: 503
	[Token(Token = "0x20001F7")]
	[GenerateCleanupMethod]
	public class DLC4_GuardYousei : DLC4_GuardController
	{
		// Token: 0x06000BEF RID: 3055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x8D6690", Offset = "0x8D5090", VA = "0x1808D6690", Slot = "7")]
		protected override void NormalAttack()
		{
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x8D6710", Offset = "0x8D5110", VA = "0x1808D6710", Slot = "5")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x8D6760", Offset = "0x8D5160", VA = "0x1808D6760", Slot = "8")]
		protected override IEnumerator SkillAttack()
		{
			return null;
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x8D2FF0", Offset = "0x8D19F0", VA = "0x1808D2FF0", Slot = "12")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x8D05E0", Offset = "0x8CEFE0", VA = "0x1808D05E0")]
		public DLC4_GuardYousei()
		{
		}

		// Token: 0x04000A9C RID: 2716
		[Token(Token = "0x4000A9C")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_RecoverHealthPerSec;

		// Token: 0x04000A9D RID: 2717
		[Token(Token = "0x4000A9D")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private DLC4_GuardController.TeamBulletProperty m_BaseBulletProperty;
	}
}
