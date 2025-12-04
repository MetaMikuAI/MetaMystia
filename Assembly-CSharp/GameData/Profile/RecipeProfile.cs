using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BB8 RID: 3000
	[Token(Token = "0x2000BB8")]
	[CreateAssetMenu(fileName = "RecipeProfile", menuName = "GameData Profile/CreateRecipeProfile", order = 3)]
	public class RecipeProfile : ScriptableObject
	{
		// Token: 0x060046BB RID: 18107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046BB")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public RecipeProfile()
		{
		}

		// Token: 0x04003F46 RID: 16198
		[Token(Token = "0x4003F46")]
		[FieldOffset(Offset = "0x18")]
		public Recipe[] recipes;
	}
}
