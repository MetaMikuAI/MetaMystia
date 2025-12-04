using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x0200101E RID: 4126
	[Token(Token = "0x200101E")]
	public class COM_Items_In_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F65 RID: 24421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F65")]
		[Address(RVA = "0x8BF560", Offset = "0x8BDF60", VA = "0x1808BF560", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F66 RID: 24422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F66")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_Items_In_Behaviour()
		{
		}

		// Token: 0x04005865 RID: 22629
		[Token(Token = "0x4005865")]
		[FieldOffset(Offset = "0x10")]
		public Product[] items;

		// Token: 0x04005866 RID: 22630
		[Token(Token = "0x4005866")]
		[FieldOffset(Offset = "0x18")]
		public bool suppressCallbacks;
	}
}
