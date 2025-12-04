using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x0200101F RID: 4127
	[Token(Token = "0x200101F")]
	public class COM_Items_Out_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F67 RID: 24423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F67")]
		[Address(RVA = "0x8BF6E0", Offset = "0x8BE0E0", VA = "0x1808BF6E0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F68 RID: 24424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F68")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_Items_Out_Behaviour()
		{
		}

		// Token: 0x04005867 RID: 22631
		[Token(Token = "0x4005867")]
		[FieldOffset(Offset = "0x10")]
		public Product[] items;
	}
}
