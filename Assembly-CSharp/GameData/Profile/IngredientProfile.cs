using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B9E RID: 2974
	[Token(Token = "0x2000B9E")]
	[CreateAssetMenu(fileName = "IngredientProfile", menuName = "GameData Profile/CreateIngredientProfile", order = 4)]
	public class IngredientProfile : ScriptableObject
	{
		// Token: 0x06004687 RID: 18055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004687")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public IngredientProfile()
		{
		}

		// Token: 0x04003EFD RID: 16125
		[Token(Token = "0x4003EFD")]
		[FieldOffset(Offset = "0x18")]
		public Ingredient[] ingredients;

		// Token: 0x04003EFE RID: 16126
		[Token(Token = "0x4003EFE")]
		[FieldOffset(Offset = "0x20")]
		public int[] prefixes;
	}
}
