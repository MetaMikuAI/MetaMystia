using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BCE RID: 3022
	[Token(Token = "0x2000BCE")]
	[CreateAssetMenu(fileName = "SpriteProfile", menuName = "GameData Profile/CreateSpriteProfile", order = 2)]
	public class SpriteProfile : ScriptableObject
	{
		// Token: 0x060046D4 RID: 18132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D4")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public SpriteProfile()
		{
		}

		// Token: 0x04003FF5 RID: 16373
		[Token(Token = "0x4003FF5")]
		[FieldOffset(Offset = "0x18")]
		public Sprite[] pictures;
	}
}
