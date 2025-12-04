using System;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x020004E3 RID: 1251
	[Token(Token = "0x20004E3")]
	[GenerateCleanupMethod]
	public class CollabBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06001C4E RID: 7246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4E")]
		[Address(RVA = "0x4939D0", Offset = "0x4923D0", VA = "0x1804939D0", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4F")]
		[Address(RVA = "0x493970", Offset = "0x492370", VA = "0x180493970", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C50")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public CollabBehaviourComponent()
		{
		}

		// Token: 0x040019D6 RID: 6614
		[Token(Token = "0x40019D6")]
		[FieldOffset(Offset = "0x18")]
		public DialogPackage welcomeDialog;

		// Token: 0x040019D7 RID: 6615
		[Token(Token = "0x40019D7")]
		[FieldOffset(Offset = "0x20")]
		public DialogPackage closeCollabConfirmDialog;

		// Token: 0x040019D8 RID: 6616
		[Token(Token = "0x40019D8")]
		[FieldOffset(Offset = "0x28")]
		public DialogPackage collabClosedDialog;

		// Token: 0x040019D9 RID: 6617
		[Token(Token = "0x40019D9")]
		[FieldOffset(Offset = "0x30")]
		public DialogPackage pannelCloseDialog;
	}
}
