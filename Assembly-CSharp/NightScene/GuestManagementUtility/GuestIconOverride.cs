using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NightScene.GuestManagementUtility
{
	// Token: 0x02000592 RID: 1426
	[Token(Token = "0x2000592")]
	public struct GuestIconOverride
	{
		// Token: 0x0600209A RID: 8346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600209A")]
		[Address(RVA = "0x4D3BE0", Offset = "0x4D25E0", VA = "0x1804D3BE0")]
		public GuestIconOverride(GuestGroupController guestGroupController, GameObject[] iconInstances, GuestState guestState, float lifeSpan)
		{
		}

		// Token: 0x04001DA3 RID: 7587
		[Token(Token = "0x4001DA3")]
		[FieldOffset(Offset = "0x0")]
		public GuestGroupController GuestGroupController;

		// Token: 0x04001DA4 RID: 7588
		[Token(Token = "0x4001DA4")]
		[FieldOffset(Offset = "0x8")]
		public GameObject[] IconInstances;

		// Token: 0x04001DA5 RID: 7589
		[Token(Token = "0x4001DA5")]
		[FieldOffset(Offset = "0x10")]
		public GuestState GuestState;

		// Token: 0x04001DA6 RID: 7590
		[Token(Token = "0x4001DA6")]
		[FieldOffset(Offset = "0x14")]
		public float LifeSpan;

		// Token: 0x04001DA7 RID: 7591
		[Token(Token = "0x4001DA7")]
		[FieldOffset(Offset = "0x18")]
		public bool AudioPlayed;
	}
}
