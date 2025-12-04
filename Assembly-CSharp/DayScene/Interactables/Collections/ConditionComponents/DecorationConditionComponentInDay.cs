using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x020004C6 RID: 1222
	[Token(Token = "0x20004C6")]
	[GenerateCleanupMethod]
	public class DecorationConditionComponentInDay : EntityConditionComponent
	{
		// Token: 0x06001BC9 RID: 7113 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		[Token(Token = "0x6001BC9")]
		[Address(RVA = "0x49CAD0", Offset = "0x49B4D0", VA = "0x18049CAD0", Slot = "9")]
		protected override bool OnGetAvailability()
		{
			return default(bool);
		}

		// Token: 0x06001BCA RID: 7114 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		[Token(Token = "0x6001BCA")]
		[Address(RVA = "0x49CB80", Offset = "0x49B580", VA = "0x18049CB80")]
		private bool Used()
		{
			return default(bool);
		}

		// Token: 0x06001BCB RID: 7115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCB")]
		[Address(RVA = "0x49CA70", Offset = "0x49B470", VA = "0x18049CA70", Slot = "4")]
		protected override Type GetComponentType()
		{
			return null;
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x493F40", Offset = "0x492940", VA = "0x180493F40", Slot = "10")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCD")]
		[Address(RVA = "0x49CC20", Offset = "0x49B620", VA = "0x18049CC20")]
		public DecorationConditionComponentInDay()
		{
		}

		// Token: 0x0400196F RID: 6511
		[Token(Token = "0x400196F")]
		[FieldOffset(Offset = "0x40")]
		public int[] decorationId;

		// Token: 0x04001970 RID: 6512
		[Token(Token = "0x4001970")]
		[FieldOffset(Offset = "0x48")]
		public bool inverse;
	}
}
