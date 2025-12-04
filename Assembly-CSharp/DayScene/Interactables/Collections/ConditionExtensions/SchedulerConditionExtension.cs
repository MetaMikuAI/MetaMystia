using System;
using DayScene.Interactables.Collections.ConditionComponents;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.Interactables.Collections.ConditionExtensions
{
	// Token: 0x020004BE RID: 1214
	[Token(Token = "0x20004BE")]
	[GenerateCleanupMethod]
	public class SchedulerConditionExtension : EntityConditionExtension
	{
		// Token: 0x06001B9B RID: 7067 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		[Token(Token = "0x6001B9B")]
		[Address(RVA = "0x4A1E20", Offset = "0x4A0820", VA = "0x1804A1E20", Slot = "4")]
		public override bool OnGetExtensionAvailability()
		{
			return default(bool);
		}

		// Token: 0x06001B9C RID: 7068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B9C")]
		[Address(RVA = "0x4A1EB0", Offset = "0x4A08B0", VA = "0x1804A1EB0", Slot = "5")]
		public override Type OnGetExtensionType()
		{
			return null;
		}

		// Token: 0x06001B9D RID: 7069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B9D")]
		[Address(RVA = "0x3EA340", Offset = "0x3E8D40", VA = "0x1803EA340", Slot = "6")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001B9E RID: 7070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B9E")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public SchedulerConditionExtension()
		{
		}

		// Token: 0x0400195E RID: 6494
		[Token(Token = "0x400195E")]
		[FieldOffset(Offset = "0x18")]
		public SchedulerConditionComponent.SchedulerData[] conditions;
	}
}
