using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x020004C7 RID: 1223
	[Token(Token = "0x20004C7")]
	[GenerateCleanupMethod]
	public class DLCConditionComponent : EntityConditionComponent
	{
		// Token: 0x06001BCE RID: 7118 RVA: 0x0000AB00 File Offset: 0x00008D00
		[Token(Token = "0x6001BCE")]
		[Address(RVA = "0x4977F0", Offset = "0x4961F0", VA = "0x1804977F0", Slot = "9")]
		protected override bool OnGetAvailability()
		{
			return default(bool);
		}

		// Token: 0x06001BCF RID: 7119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCF")]
		[Address(RVA = "0x497790", Offset = "0x496190", VA = "0x180497790", Slot = "4")]
		protected override Type GetComponentType()
		{
			return null;
		}

		// Token: 0x06001BD0 RID: 7120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD0")]
		[Address(RVA = "0x493F40", Offset = "0x492940", VA = "0x180493F40", Slot = "10")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001BD1 RID: 7121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD1")]
		[Address(RVA = "0x4978B0", Offset = "0x4962B0", VA = "0x1804978B0")]
		public DLCConditionComponent()
		{
		}

		// Token: 0x04001971 RID: 6513
		[Token(Token = "0x4001971")]
		[FieldOffset(Offset = "0x40")]
		public string dlcKey;
	}
}
