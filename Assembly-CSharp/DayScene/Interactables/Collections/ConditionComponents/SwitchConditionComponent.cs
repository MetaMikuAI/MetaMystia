using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x020004CF RID: 1231
	[Token(Token = "0x20004CF")]
	[GenerateCleanupMethod]
	public class SwitchConditionComponent : EntityConditionComponent
	{
		// Token: 0x06001BEA RID: 7146 RVA: 0x0000AC08 File Offset: 0x00008E08
		[Token(Token = "0x6001BEA")]
		[Address(RVA = "0x4A2560", Offset = "0x4A0F60", VA = "0x1804A2560", Slot = "9")]
		protected override bool OnGetAvailability()
		{
			return default(bool);
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BEB")]
		[Address(RVA = "0x4A2500", Offset = "0x4A0F00", VA = "0x1804A2500", Slot = "4")]
		protected override Type GetComponentType()
		{
			return null;
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEC")]
		[Address(RVA = "0x493F40", Offset = "0x492940", VA = "0x180493F40", Slot = "10")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BED")]
		[Address(RVA = "0x4A2570", Offset = "0x4A0F70", VA = "0x1804A2570")]
		public SwitchConditionComponent()
		{
		}

		// Token: 0x04001986 RID: 6534
		[Token(Token = "0x4001986")]
		[FieldOffset(Offset = "0x40")]
		public string label;

		// Token: 0x04001987 RID: 6535
		[Token(Token = "0x4001987")]
		[FieldOffset(Offset = "0x48")]
		public bool onByDefault;
	}
}
