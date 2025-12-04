using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BCC RID: 3020
	[Token(Token = "0x2000BCC")]
	[CreateAssetMenu(fileName = "DialogProfile", menuName = "GameData Profile/CreateSellableProfile", order = 3)]
	public class SellableProfile : ScriptableObject
	{
		// Token: 0x060046D2 RID: 18130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D2")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public SellableProfile()
		{
		}

		// Token: 0x04003FF0 RID: 16368
		[Token(Token = "0x4003FF0")]
		[FieldOffset(Offset = "0x18")]
		public Sellable[] sellables;

		// Token: 0x04003FF1 RID: 16369
		[Token(Token = "0x4003FF1")]
		[FieldOffset(Offset = "0x20")]
		public string tagProfileName;

		// Token: 0x04003FF2 RID: 16370
		[Token(Token = "0x4003FF2")]
		[FieldOffset(Offset = "0x28")]
		public string langFileName;
	}
}
