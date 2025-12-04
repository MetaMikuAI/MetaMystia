using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x020004C2 RID: 1218
	[Token(Token = "0x20004C2")]
	[GenerateCleanupMethod]
	public class CollectableConditionComponent : EntityConditionComponent
	{
		// Token: 0x06001BB9 RID: 7097 RVA: 0x0000AA70 File Offset: 0x00008C70
		[Token(Token = "0x6001BB9")]
		[Address(RVA = "0x493FF0", Offset = "0x4929F0", VA = "0x180493FF0", Slot = "9")]
		protected sealed override bool OnGetAvailability()
		{
			return default(bool);
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBA")]
		[Address(RVA = "0x493F90", Offset = "0x492990", VA = "0x180493F90", Slot = "4")]
		protected override Type GetComponentType()
		{
			return null;
		}

		// Token: 0x06001BBB RID: 7099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBB")]
		[Address(RVA = "0x493F40", Offset = "0x492940", VA = "0x180493F40", Slot = "10")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001BBC RID: 7100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBC")]
		[Address(RVA = "0x494000", Offset = "0x492A00", VA = "0x180494000")]
		public CollectableConditionComponent()
		{
		}

		// Token: 0x0400196B RID: 6507
		[Token(Token = "0x400196B")]
		[FieldOffset(Offset = "0x40")]
		public string collectableKey;
	}
}
