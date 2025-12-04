using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FF2 RID: 4082
	[Token(Token = "0x2000FF2")]
	public class COM_SwitchScene_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005EFC RID: 24316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EFC")]
		[Address(RVA = "0x8C1550", Offset = "0x8BFF50", VA = "0x1808C1550", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005EFD RID: 24317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EFD")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_SwitchScene_Behaviour()
		{
		}

		// Token: 0x040057F7 RID: 22519
		[Token(Token = "0x40057F7")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		// Token: 0x040057F8 RID: 22520
		[Token(Token = "0x40057F8")]
		[FieldOffset(Offset = "0x18")]
		public GameObject sceneReference;
	}
}
