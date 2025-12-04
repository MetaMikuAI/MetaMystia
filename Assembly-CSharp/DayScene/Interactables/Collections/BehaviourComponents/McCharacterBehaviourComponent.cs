using System;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200050A RID: 1290
	[Token(Token = "0x200050A")]
	[GenerateCleanupMethod]
	public class McCharacterBehaviourComponent : MultipleInteractionsBehaviourComponent
	{
		// Token: 0x06001CEA RID: 7402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEA")]
		[Address(RVA = "0x4B13F0", Offset = "0x4AFDF0", VA = "0x1804B13F0", Slot = "14")]
		protected override void Start()
		{
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEB")]
		[Address(RVA = "0x4B13A0", Offset = "0x4AFDA0", VA = "0x1804B13A0", Slot = "15")]
		protected override void Interact()
		{
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CEC")]
		[Address(RVA = "0x4B1300", Offset = "0x4AFD00", VA = "0x1804B1300", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CED")]
		[Address(RVA = "0x4B15E0", Offset = "0x4AFFE0", VA = "0x1804B15E0")]
		public McCharacterBehaviourComponent()
		{
		}

		// Token: 0x04001A9F RID: 6815
		[Token(Token = "0x4001A9F")]
		private const string MC_ID = "MC_NEW";

		// Token: 0x04001AA0 RID: 6816
		[Token(Token = "0x4001AA0")]
		private const int DIALOG_MAXINDEX = 1;

		// Token: 0x04001AA1 RID: 6817
		[Token(Token = "0x4001AA1")]
		[FieldOffset(Offset = "0x38")]
		public DialogPackage firstConversation;

		// Token: 0x04001AA2 RID: 6818
		[Token(Token = "0x4001AA2")]
		[FieldOffset(Offset = "0x40")]
		public DialogPackage normalConversation;

		// Token: 0x04001AA3 RID: 6819
		[Token(Token = "0x4001AA3")]
		[FieldOffset(Offset = "0x48")]
		public DialogPackage errorConversation;
	}
}
