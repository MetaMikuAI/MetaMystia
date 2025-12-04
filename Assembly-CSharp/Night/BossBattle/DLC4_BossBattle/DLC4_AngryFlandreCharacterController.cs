using System;
using Common.Audio;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001A7 RID: 423
	[Token(Token = "0x20001A7")]
	[GenerateCleanupMethod]
	public class DLC4_AngryFlandreCharacterController : DLC4_FlandreEnemyCharacterController
	{
		// Token: 0x06000A2E RID: 2606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x8CC820", Offset = "0x8CB220", VA = "0x1808CC820", Slot = "8")]
		protected override void OnAttack()
		{
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x8CC810", Offset = "0x8CB210", VA = "0x1808CC810", Slot = "12")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x40A3C0", Offset = "0x408DC0", VA = "0x18040A3C0")]
		public DLC4_AngryFlandreCharacterController()
		{
		}

		// Token: 0x04000926 RID: 2342
		[Token(Token = "0x4000926")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private VFXPrefab m_FireHit;

		// Token: 0x04000927 RID: 2343
		[Token(Token = "0x4000927")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private Vector2 m_Offset;

		// Token: 0x04000928 RID: 2344
		[Token(Token = "0x4000928")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private GlobalAudioManager.DelayAudioClip m_LarventinSfx;

		// Token: 0x04000929 RID: 2345
		[Token(Token = "0x4000929")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private GlobalAudioManager.DelayAudioClip m_FireSfx;
	}
}
