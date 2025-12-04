using System;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000516 RID: 1302
	[Token(Token = "0x2000516")]
	[GenerateCleanupMethod]
	public class ThreeFairiesBehaviourComponent : MultipleInteractionsBehaviourComponent
	{
		// Token: 0x06001D26 RID: 7462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D26")]
		[Address(RVA = "0x4BE790", Offset = "0x4BD190", VA = "0x1804BE790", Slot = "14")]
		protected override void Start()
		{
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D27")]
		[Address(RVA = "0x4BE740", Offset = "0x4BD140", VA = "0x1804BE740", Slot = "15")]
		protected override void Interact()
		{
		}

		// Token: 0x06001D28 RID: 7464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D28")]
		[Address(RVA = "0x4BE6B0", Offset = "0x4BD0B0", VA = "0x1804BE6B0", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D29")]
		[Address(RVA = "0x4B15E0", Offset = "0x4AFFE0", VA = "0x1804B15E0")]
		public ThreeFairiesBehaviourComponent()
		{
		}

		// Token: 0x04001AD7 RID: 6871
		[Token(Token = "0x4001AD7")]
		private const string THREE_FAIRIES_ID = "ThreeFairies";

		// Token: 0x04001AD8 RID: 6872
		[Token(Token = "0x4001AD8")]
		private const int DIALOG_MAXINDEX = 1;

		// Token: 0x04001AD9 RID: 6873
		[Token(Token = "0x4001AD9")]
		[FieldOffset(Offset = "0x38")]
		public DialogPackage firstConversation;

		// Token: 0x04001ADA RID: 6874
		[Token(Token = "0x4001ADA")]
		[FieldOffset(Offset = "0x40")]
		public DialogPackage normalConversation;
	}
}
