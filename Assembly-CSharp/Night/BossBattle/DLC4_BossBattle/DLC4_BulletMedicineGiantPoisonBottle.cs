using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200016D RID: 365
	[Token(Token = "0x200016D")]
	[GenerateCleanupMethod]
	public class DLC4_BulletMedicineGiantPoisonBottle : DLC4_BulletTeamParabolic
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x000042F0 File Offset: 0x000024F0
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B1")]
		public DLC4_GuardMedicine.MedicinePoolBullet AcidPoolBulletProperty
		{
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x8257A0", Offset = "0x8241A0", VA = "0x1808257A0")]
			[CompilerGenerated]
			private get
			{
				return default(DLC4_GuardMedicine.MedicinePoolBullet);
			}
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x8257D0", Offset = "0x8241D0", VA = "0x1808257D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060008B0 RID: 2224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "8")]
		protected override void OnHit(DLC4_FlandreEnemyCharacterController enemy)
		{
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x825530", Offset = "0x823F30", VA = "0x180825530", Slot = "6")]
		protected override void OnDispose()
		{
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x8243D0", Offset = "0x822DD0", VA = "0x1808243D0", Slot = "7")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x822F20", Offset = "0x821920", VA = "0x180822F20")]
		public DLC4_BulletMedicineGiantPoisonBottle()
		{
		}
	}
}
