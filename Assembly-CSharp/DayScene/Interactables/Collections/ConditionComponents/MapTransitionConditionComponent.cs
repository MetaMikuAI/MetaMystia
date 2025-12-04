using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x020004C3 RID: 1219
	[Token(Token = "0x20004C3")]
	[GenerateCleanupMethod]
	public sealed class MapTransitionConditionComponent : EntityConditionComponent
	{
		// Token: 0x06001BBD RID: 7101 RVA: 0x0000AA88 File Offset: 0x00008C88
		[Token(Token = "0x6001BBD")]
		[Address(RVA = "0x4A1370", Offset = "0x49FD70", VA = "0x1804A1370", Slot = "9")]
		protected override bool OnGetAvailability()
		{
			return default(bool);
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BBE")]
		[Address(RVA = "0x4A1310", Offset = "0x49FD10", VA = "0x1804A1310", Slot = "4")]
		protected override Type GetComponentType()
		{
			return null;
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBF")]
		[Address(RVA = "0x493F40", Offset = "0x492940", VA = "0x180493F40", Slot = "10")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC0")]
		[Address(RVA = "0x4A13A0", Offset = "0x49FDA0", VA = "0x1804A13A0")]
		public MapTransitionConditionComponent()
		{
		}

		// Token: 0x0400196C RID: 6508
		[Token(Token = "0x400196C")]
		[FieldOffset(Offset = "0x40")]
		public MapTransitionData transitionData;
	}
}
