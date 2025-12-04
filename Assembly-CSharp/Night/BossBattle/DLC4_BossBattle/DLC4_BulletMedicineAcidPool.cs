using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200016B RID: 363
	[Token(Token = "0x200016B")]
	[GenerateCleanupMethod]
	public class DLC4_BulletMedicineAcidPool : DLC4_BulletTeam
	{
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00004278 File Offset: 0x00002478
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000AB")]
		private float PoolDuration
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x4E32A0", Offset = "0x4E1CA0", VA = "0x1804E32A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x4E32C0", Offset = "0x4E1CC0", VA = "0x1804E32C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x00004290 File Offset: 0x00002490
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000AC")]
		private float PoolFrozenMultiplier
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x825510", Offset = "0x823F10", VA = "0x180825510")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000898")]
			[Address(RVA = "0x825520", Offset = "0x823F20", VA = "0x180825520")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x000042A8 File Offset: 0x000024A8
		// (set) Token: 0x0600089A RID: 2202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000AD")]
		private int PoisonDamage
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0x48B8E0", Offset = "0x48A2E0", VA = "0x18048B8E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600089A")]
			[Address(RVA = "0x656A90", Offset = "0x655490", VA = "0x180656A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x000042C0 File Offset: 0x000024C0
		// (set) Token: 0x0600089C RID: 2204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000AE")]
		private int PoisonDuration
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x409E40", Offset = "0x408840", VA = "0x180409E40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x409E70", Offset = "0x408870", VA = "0x180409E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600089D")]
		[Address(RVA = "0x825370", Offset = "0x823D70", VA = "0x180825370")]
		private void Update()
		{
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600089E")]
		[Address(RVA = "0x824E40", Offset = "0x823840", VA = "0x180824E40")]
		public void OnBulletEnable(float poolDuration, int poisonDamage, int poisonDuration, float frozenMultiplier)
		{
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x824D80", Offset = "0x823780", VA = "0x180824D80")]
		private IEnumerator ClearPool()
		{
			return null;
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x825020", Offset = "0x823A20", VA = "0x180825020", Slot = "8")]
		protected override void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x825200", Offset = "0x823C00", VA = "0x180825200")]
		private void RemoveHitEnemyFromAcidList(DLC4_FlandreEnemyCharacterController enemy)
		{
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x8251C0", Offset = "0x823BC0", VA = "0x1808251C0")]
		private void PoisonEnemy(DLC4_FlandreEnemyCharacterController enemy)
		{
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x824E00", Offset = "0x823800", VA = "0x180824E00")]
		private void Frozen(DLC4_FlandreEnemyCharacterController enemy)
		{
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x824F00", Offset = "0x823900", VA = "0x180824F00", Slot = "6")]
		protected override void OnDispose()
		{
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x824D30", Offset = "0x823730", VA = "0x180824D30", Slot = "7")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x825480", Offset = "0x823E80", VA = "0x180825480")]
		public DLC4_BulletMedicineAcidPool()
		{
		}

		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		[FieldOffset(Offset = "0x88")]
		private bool exist;

		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		[FieldOffset(Offset = "0x90")]
		private List<DLC4_FlandreEnemyCharacterController> flandreInAcidPool;

		// Token: 0x040007B4 RID: 1972
		[Token(Token = "0x40007B4")]
		[FieldOffset(Offset = "0x98")]
		private Coroutine lerpCoroutine;
	}
}
