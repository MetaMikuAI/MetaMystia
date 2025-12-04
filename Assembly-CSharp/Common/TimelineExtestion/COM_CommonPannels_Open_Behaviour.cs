using System;
using Common.UI.NoteBookUtility;
using Common.UI.StorageUtility;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x0200102B RID: 4139
	[Token(Token = "0x200102B")]
	public class COM_CommonPannels_Open_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F7F RID: 24447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F7F")]
		[Address(RVA = "0x8BEF50", Offset = "0x8BD950", VA = "0x1808BEF50", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F80 RID: 24448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F80")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_CommonPannels_Open_Behaviour()
		{
		}

		// Token: 0x04005871 RID: 22641
		[Token(Token = "0x4005871")]
		[FieldOffset(Offset = "0x10")]
		public NoteBookMainPannel.GoToSpecificType NoteBookGotoType;

		// Token: 0x04005872 RID: 22642
		[Token(Token = "0x4005872")]
		[FieldOffset(Offset = "0x14")]
		public COM_CommonPannels_Open_Behaviour.PannelType PannelOpenType;

		// Token: 0x04005873 RID: 22643
		[Token(Token = "0x4005873")]
		[FieldOffset(Offset = "0x18")]
		public StorageMainPannel.GoToSpecificType StorageGotoType;

		// Token: 0x0200102C RID: 4140
		[Token(Token = "0x200102C")]
		public enum PannelType
		{
			// Token: 0x04005875 RID: 22645
			[Token(Token = "0x4005875")]
			NoteBook,
			// Token: 0x04005876 RID: 22646
			[Token(Token = "0x4005876")]
			Storage
		}
	}
}
