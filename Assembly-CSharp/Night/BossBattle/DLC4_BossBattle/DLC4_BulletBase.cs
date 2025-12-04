using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000160 RID: 352
	[Token(Token = "0x2000160")]
	[GenerateCleanupMethod]
	public abstract class DLC4_BulletBase : MonoBehaviour
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x1700009F")]
		public BulletTypeIndex BulletIndex
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x403830", Offset = "0x402230", VA = "0x180403830")]
			get
			{
				return BulletTypeIndex.None;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000A0")]
		private protected DLC4_BossBattleManager Dlc4BossBattleManager
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x477F80", Offset = "0x476980", VA = "0x180477F80")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x547AB0", Offset = "0x5464B0", VA = "0x180547AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600084D RID: 2125
		[Token(Token = "0x170000A1")]
		public abstract DLC4_BulletBase.BulletType BulletShooterType
		{
			[Token(Token = "0x600084D")]
			get;
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x000041A0 File Offset: 0x000023A0
		// (set) Token: 0x0600084F RID: 2127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000A2")]
		protected float Speed
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x4402F0", Offset = "0x43ECF0", VA = "0x1804402F0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x823960", Offset = "0x822360", VA = "0x180823960")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x000041B8 File Offset: 0x000023B8
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000A3")]
		protected int DamagePower
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x440560", Offset = "0x43EF60", VA = "0x180440560")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x823950", Offset = "0x822350", VA = "0x180823950")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000852")]
		[Address(RVA = "0x823580", Offset = "0x821F80", VA = "0x180823580")]
		private void FixedUpdate()
		{
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000853")]
		[Address(RVA = "0x783370", Offset = "0x781D70", VA = "0x180783370")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000854")]
		[Address(RVA = "0x8235A0", Offset = "0x821FA0", VA = "0x1808235A0")]
		protected void Initialize(int damage, float speed, float duration, DLC4_BossBattleManager dlc4BossBattleManager)
		{
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000855")]
		[Address(RVA = "0x8238C0", Offset = "0x8222C0", VA = "0x1808238C0")]
		private IEnumerator RecycleIdentityAfterTime(float tickTime)
		{
			return null;
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000856")]
		[Address(RVA = "0x8237C0", Offset = "0x8221C0", VA = "0x1808237C0", Slot = "5")]
		protected virtual void OnUpdate()
		{
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000857")]
		[Address(RVA = "0x823480", Offset = "0x821E80", VA = "0x180823480")]
		public void Dispose()
		{
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000858")]
		[Address(RVA = "0x823670", Offset = "0x822070", VA = "0x180823670", Slot = "6")]
		protected virtual void OnDispose()
		{
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000859")]
		[Address(RVA = "0x823440", Offset = "0x821E40", VA = "0x180823440", Slot = "7")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600085A")]
		[Address(RVA = "0x822F20", Offset = "0x821920", VA = "0x180822F20")]
		protected DLC4_BulletBase()
		{
		}

		// Token: 0x0400078B RID: 1931
		[Token(Token = "0x400078B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BulletTypeIndex m_BulletIndex;

		// Token: 0x0400078C RID: 1932
		[Token(Token = "0x400078C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected VFXPrefab m_HitVFX;

		// Token: 0x0400078D RID: 1933
		[Token(Token = "0x400078D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Vector2 m_HitVFXOffset;

		// Token: 0x0400078E RID: 1934
		[Token(Token = "0x400078E")]
		[FieldOffset(Offset = "0x40")]
		protected bool HasDisposed;

		// Token: 0x0400078F RID: 1935
		[Token(Token = "0x400078F")]
		[FieldOffset(Offset = "0x44")]
		private Vector3 lastFrameTargetPosition;

		// Token: 0x04000790 RID: 1936
		[Token(Token = "0x4000790")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine recycleCoroutine;

		// Token: 0x02000161 RID: 353
		[Token(Token = "0x2000161")]
		public enum BulletType
		{
			// Token: 0x04000795 RID: 1941
			[Token(Token = "0x4000795")]
			Team,
			// Token: 0x04000796 RID: 1942
			[Token(Token = "0x4000796")]
			Enemy
		}
	}
}
