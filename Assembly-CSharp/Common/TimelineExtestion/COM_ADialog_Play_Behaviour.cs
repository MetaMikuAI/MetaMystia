using System;
using GameData.Profile;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02001017 RID: 4119
	[Token(Token = "0x2001017")]
	public class COM_ADialog_Play_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06005F54 RID: 24404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F54")]
		[Address(RVA = "0x8BDBE0", Offset = "0x8BC5E0", VA = "0x1808BDBE0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F55 RID: 24405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F55")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ADialog_Play_Behaviour()
		{
		}

		// Token: 0x04005858 RID: 22616
		[Token(Token = "0x4005858")]
		[FieldOffset(Offset = "0x10")]
		public DialogPackage dialogPackage;

		// Token: 0x04005859 RID: 22617
		[Token(Token = "0x4005859")]
		[FieldOffset(Offset = "0x18")]
		public bool PreservePreviousPannelVisual;
	}
}
