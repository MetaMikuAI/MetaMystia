using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x0200102F RID: 4143
	[Token(Token = "0x200102F")]
	public class COM_Kaguya_Mokou_Spec_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F86 RID: 24454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F86")]
		[Address(RVA = "0x8BFA40", Offset = "0x8BE440", VA = "0x1808BFA40", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F87 RID: 24455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F87")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_Kaguya_Mokou_Spec_Behaviour()
		{
		}

		// Token: 0x06005F89 RID: 24457 RVA: 0x00020FE8 File Offset: 0x0001F1E8
		[Token(Token = "0x6005F89")]
		[Address(RVA = "0x8BFDF0", Offset = "0x8BE7F0", VA = "0x1808BFDF0")]
		[CompilerGenerated]
		private int <OnBehaviourEnter>g__KaguyaWin|8_0()
		{
			return 0;
		}

		// Token: 0x06005F8A RID: 24458 RVA: 0x00021000 File Offset: 0x0001F200
		[Token(Token = "0x6005F8A")]
		[Address(RVA = "0x8BFE50", Offset = "0x8BE850", VA = "0x1808BFE50")]
		[CompilerGenerated]
		private int <OnBehaviourEnter>g__MokouWin|8_1()
		{
			return 0;
		}

		// Token: 0x06005F8B RID: 24459 RVA: 0x00021018 File Offset: 0x0001F218
		[Token(Token = "0x6005F8B")]
		[Address(RVA = "0x8BFD90", Offset = "0x8BE790", VA = "0x1808BFD90")]
		[CompilerGenerated]
		private int <OnBehaviourEnter>g__Equal|8_2()
		{
			return 0;
		}

		// Token: 0x04005879 RID: 22649
		[Token(Token = "0x4005879")]
		[FieldOffset(Offset = "0x10")]
		public int equalTicks;

		// Token: 0x0400587A RID: 22650
		[Token(Token = "0x400587A")]
		[FieldOffset(Offset = "0x14")]
		public int firstItemTicks;

		// Token: 0x0400587B RID: 22651
		[Token(Token = "0x400587B")]
		[FieldOffset(Offset = "0x18")]
		public string missionLabel;

		// Token: 0x0400587C RID: 22652
		[Token(Token = "0x400587C")]
		[FieldOffset(Offset = "0x20")]
		public string recordedEqualLabel;

		// Token: 0x0400587D RID: 22653
		[Token(Token = "0x400587D")]
		[FieldOffset(Offset = "0x28")]
		public string recordedKaguyaWinLabel;

		// Token: 0x0400587E RID: 22654
		[Token(Token = "0x400587E")]
		[FieldOffset(Offset = "0x30")]
		public string recordedMokouWinLabel;

		// Token: 0x0400587F RID: 22655
		[Token(Token = "0x400587F")]
		[FieldOffset(Offset = "0x38")]
		public int secondItemTicks;

		// Token: 0x04005880 RID: 22656
		[Token(Token = "0x4005880")]
		[FieldOffset(Offset = "0x3C")]
		public bool setAchievements;
	}
}
