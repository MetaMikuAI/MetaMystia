using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NightScene.GuestManagementUtility
{
	// Token: 0x02000591 RID: 1425
	[Token(Token = "0x2000591")]
	public struct GuestIcon
	{
		// Token: 0x04001DA0 RID: 7584
		[Token(Token = "0x4001DA0")]
		[FieldOffset(Offset = "0x0")]
		public GuestGroupController GuestGroupController;

		// Token: 0x04001DA1 RID: 7585
		[Token(Token = "0x4001DA1")]
		[FieldOffset(Offset = "0x8")]
		public GameObject[] IconInstances;

		// Token: 0x04001DA2 RID: 7586
		[Token(Token = "0x4001DA2")]
		[FieldOffset(Offset = "0x10")]
		public GuestState GuestState;
	}
}
