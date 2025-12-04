using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Common.Audio;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x020001FC RID: 508
	[Token(Token = "0x20001FC")]
	[GenerateCleanupMethod]
	public class DLC4_GuardYukaSunFlower : DLC4_GuardController
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700014A")]
		public DLC4_GuardYuka YukaParent
		{
			[Token(Token = "0x6000C14")]
			[Address(RVA = "0x419D00", Offset = "0x418700", VA = "0x180419D00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000C15")]
			[Address(RVA = "0x419D50", Offset = "0x418750", VA = "0x180419D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x000055B0 File Offset: 0x000037B0
		[Token(Token = "0x1700014B")]
		private DLC4_GuardController.TeamBulletProperty BigBullet
		{
			[Token(Token = "0x6000C16")]
			[Address(RVA = "0x8D7810", Offset = "0x8D6210", VA = "0x1808D7810")]
			get
			{
				return default(DLC4_GuardController.TeamBulletProperty);
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x000055C8 File Offset: 0x000037C8
		[Token(Token = "0x1700014C")]
		private DLC4_GuardController.TeamBulletProperty SmallBullet
		{
			[Token(Token = "0x6000C17")]
			[Address(RVA = "0x8D7850", Offset = "0x8D6250", VA = "0x1808D7850")]
			get
			{
				return default(DLC4_GuardController.TeamBulletProperty);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x000055E0 File Offset: 0x000037E0
		[Token(Token = "0x1700014D")]
		protected override Vector2 SpawnPoint
		{
			[Token(Token = "0x6000C18")]
			[Address(RVA = "0x8D7890", Offset = "0x8D6290", VA = "0x1808D7890", Slot = "11")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x8D6E90", Offset = "0x8D5890", VA = "0x1808D6E90", Slot = "4")]
		protected override void OnGuardControllerEnable()
		{
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x8D72C0", Offset = "0x8D5CC0", VA = "0x1808D72C0")]
		private IEnumerator SpawnP()
		{
			return null;
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x000055F8 File Offset: 0x000037F8
		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x8D6840", Offset = "0x8D5240", VA = "0x1808D6840", Slot = "6")]
		protected override bool CouldAttack()
		{
			return default(bool);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x8D6AC0", Offset = "0x8D54C0", VA = "0x1808D6AC0", Slot = "7")]
		protected override void NormalAttack()
		{
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x8D6FD0", Offset = "0x8D59D0", VA = "0x1808D6FD0")]
		private void SmallBulletAttack(Vector2 parentPosition)
		{
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x8D69D0", Offset = "0x8D53D0", VA = "0x1808D69D0")]
		public void Disappear()
		{
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x8D6F70", Offset = "0x8D5970", VA = "0x1808D6F70", Slot = "8")]
		protected override IEnumerator SkillAttack()
		{
			return null;
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x8D67C0", Offset = "0x8D51C0", VA = "0x1808D67C0", Slot = "12")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x8D7550", Offset = "0x8D5F50", VA = "0x1808D7550")]
		public DLC4_GuardYukaSunFlower()
		{
		}

		// Token: 0x04000ABD RID: 2749
		[Token(Token = "0x4000ABD")]
		[FieldOffset(Offset = "0xE0")]
		public Animator sunflowerAnimator;

		// Token: 0x04000ABE RID: 2750
		[Token(Token = "0x4000ABE")]
		[FieldOffset(Offset = "0xE8")]
		public AudioClip m_SunflowerSpawn;

		// Token: 0x04000ABF RID: 2751
		[Token(Token = "0x4000ABF")]
		[FieldOffset(Offset = "0xF0")]
		public GlobalAudioManager.DelayAudioClip m_SunflowerSunSpawn;

		// Token: 0x04000AC0 RID: 2752
		[Token(Token = "0x4000AC0")]
		[FieldOffset(Offset = "0x100")]
		public GlobalAudioManager.DelayAudioClip m_SunflowerPPointSpawn;

		// Token: 0x04000AC1 RID: 2753
		[Token(Token = "0x4000AC1")]
		[FieldOffset(Offset = "0x110")]
		public readonly Vector2[] AttackDirection;

		// Token: 0x04000AC2 RID: 2754
		[Token(Token = "0x4000AC2")]
		[FieldOffset(Offset = "0x118")]
		private bool hasSpawned;

		// Token: 0x04000AC3 RID: 2755
		[Token(Token = "0x4000AC3")]
		[FieldOffset(Offset = "0x120")]
		private Coroutine spawnCorotine;
	}
}
