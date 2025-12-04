using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BAF RID: 2991
	[Token(Token = "0x2000BAF")]
	[CreateAssetMenu(fileName = "NormalGuestPixelProfile", menuName = "GameData Profile/NormalGuestPixelProfile", order = 3)]
	public class NormalGuestPixelProfile : ScriptableObject
	{
		// Token: 0x060046A6 RID: 18086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A6")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public NormalGuestPixelProfile()
		{
		}

		// Token: 0x04003F33 RID: 16179
		[Token(Token = "0x4003F33")]
		[FieldOffset(Offset = "0x18")]
		public Color unifiedBGColor;

		// Token: 0x04003F34 RID: 16180
		[Token(Token = "0x4003F34")]
		[FieldOffset(Offset = "0x28")]
		public Color unifiedTextColor;

		// Token: 0x04003F35 RID: 16181
		[Token(Token = "0x4003F35")]
		[FieldOffset(Offset = "0x38")]
		public NormalGuestPixelPair[] normalGuestPixelPairs;
	}
}
