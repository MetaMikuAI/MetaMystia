using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200016E RID: 366
	[Token(Token = "0x200016E")]
	[GenerateCleanupMethod]
	public class DLC4_BulletSeijaBow : DLC4_BulletTeamLinear
	{
		// Token: 0x060008B5 RID: 2229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x825810", Offset = "0x824210", VA = "0x180825810")]
		public void OnBulletEnable(DLC4_GuardSeija seijaParent)
		{
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x825800", Offset = "0x824200", VA = "0x180825800", Slot = "7")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x822F20", Offset = "0x821920", VA = "0x180822F20")]
		public DLC4_BulletSeijaBow()
		{
		}

		// Token: 0x040007BD RID: 1981
		[Token(Token = "0x40007BD")]
		[FieldOffset(Offset = "0x98")]
		private bool canPenetration;

		// Token: 0x040007BE RID: 1982
		[Token(Token = "0x40007BE")]
		[FieldOffset(Offset = "0x9C")]
		private float currentPower;
	}
}
