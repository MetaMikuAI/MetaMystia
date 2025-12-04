using System;
using GameData.Profile;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02001018 RID: 4120
	[Token(Token = "0x2001018")]
	public class COM_ADialog_Manual_Init_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06005F56 RID: 24406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F56")]
		[Address(RVA = "0x8BD5A0", Offset = "0x8BBFA0", VA = "0x1808BD5A0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F57 RID: 24407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F57")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ADialog_Manual_Init_Behaviour()
		{
		}

		// Token: 0x0400585A RID: 22618
		[Token(Token = "0x400585A")]
		[FieldOffset(Offset = "0x0")]
		public static Action startPlay;

		// Token: 0x0400585B RID: 22619
		[Token(Token = "0x400585B")]
		[FieldOffset(Offset = "0x8")]
		public static Action exit;

		// Token: 0x0400585C RID: 22620
		[Token(Token = "0x400585C")]
		[FieldOffset(Offset = "0x10")]
		public DialogPackage dialogPackage;

		// Token: 0x0400585D RID: 22621
		[Token(Token = "0x400585D")]
		[FieldOffset(Offset = "0x18")]
		public bool PreservePreviousPannelVisual;

		// Token: 0x0400585E RID: 22622
		[Token(Token = "0x400585E")]
		[FieldOffset(Offset = "0x19")]
		public bool shouldHaveBlackBackgroundInDefault;
	}
}
