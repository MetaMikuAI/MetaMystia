using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B9D RID: 2973
	[Token(Token = "0x2000B9D")]
	[CreateAssetMenu(fileName = "IndexProfile", menuName = "GameData Profile/CreateIndexProfile", order = 2)]
	public class IndexProfile : ScriptableObject
	{
		// Token: 0x06004686 RID: 18054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004686")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public IndexProfile()
		{
		}

		// Token: 0x04003EFB RID: 16123
		[Token(Token = "0x4003EFB")]
		[FieldOffset(Offset = "0x18")]
		public int[] indexes;

		// Token: 0x04003EFC RID: 16124
		[Token(Token = "0x4003EFC")]
		[FieldOffset(Offset = "0x20")]
		public string previewName;
	}
}
