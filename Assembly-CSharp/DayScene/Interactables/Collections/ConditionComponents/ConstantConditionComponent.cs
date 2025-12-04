using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x020004C5 RID: 1221
	[Token(Token = "0x20004C5")]
	[GenerateCleanupMethod]
	public class ConstantConditionComponent : EntityConditionComponent
	{
		// Token: 0x06001BC5 RID: 7109 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		[Token(Token = "0x6001BC5")]
		[Address(RVA = "0x494130", Offset = "0x492B30", VA = "0x180494130", Slot = "9")]
		protected override bool OnGetAvailability()
		{
			return default(bool);
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BC6")]
		[Address(RVA = "0x4940D0", Offset = "0x492AD0", VA = "0x1804940D0", Slot = "4")]
		protected override Type GetComponentType()
		{
			return null;
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC7")]
		[Address(RVA = "0x494090", Offset = "0x492A90", VA = "0x180494090", Slot = "10")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001BC8 RID: 7112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC8")]
		[Address(RVA = "0x494140", Offset = "0x492B40", VA = "0x180494140")]
		public ConstantConditionComponent()
		{
		}

		// Token: 0x0400196E RID: 6510
		[Token(Token = "0x400196E")]
		[FieldOffset(Offset = "0x40")]
		public bool available;
	}
}
