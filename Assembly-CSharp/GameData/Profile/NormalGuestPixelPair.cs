using System;
using GameData.Core.Collections.CharacterUtility;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BB0 RID: 2992
	[Token(Token = "0x2000BB0")]
	[Serializable]
	public struct NormalGuestPixelPair
	{
		// Token: 0x04003F36 RID: 16182
		[Token(Token = "0x4003F36")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public int id;

		// Token: 0x04003F37 RID: 16183
		[Token(Token = "0x4003F37")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public CharacterSpriteSetCompact[] skinSelections;
	}
}
