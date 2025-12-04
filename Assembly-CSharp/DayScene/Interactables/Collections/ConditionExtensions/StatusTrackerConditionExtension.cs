using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.Interactables.Collections.ConditionExtensions
{
	// Token: 0x020004BF RID: 1215
	[Token(Token = "0x20004BF")]
	[GenerateCleanupMethod]
	public class StatusTrackerConditionExtension : EntityConditionExtension
	{
		// Token: 0x06001B9F RID: 7071 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		[Token(Token = "0x6001B9F")]
		[Address(RVA = "0x4A1F10", Offset = "0x4A0910", VA = "0x1804A1F10", Slot = "4")]
		public override bool OnGetExtensionAvailability()
		{
			return default(bool);
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BA0")]
		[Address(RVA = "0x4A1F70", Offset = "0x4A0970", VA = "0x1804A1F70", Slot = "5")]
		public override Type OnGetExtensionType()
		{
			return null;
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA1")]
		[Address(RVA = "0x3EA340", Offset = "0x3E8D40", VA = "0x1803EA340", Slot = "6")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA2")]
		[Address(RVA = "0x4A1FD0", Offset = "0x4A09D0", VA = "0x1804A1FD0")]
		public StatusTrackerConditionExtension()
		{
		}

		// Token: 0x0400195F RID: 6495
		[Token(Token = "0x400195F")]
		[FieldOffset(Offset = "0x18")]
		public string statusTrackerLabel;

		// Token: 0x04001960 RID: 6496
		[Token(Token = "0x4001960")]
		[FieldOffset(Offset = "0x20")]
		public int maxInteractNum;
	}
}
