using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B7A RID: 2938
	[Token(Token = "0x2000B7A")]
	[CreateAssetMenu(fileName = "CommonPhraseProfile", menuName = "GameData Profile/CommonPhraseProfile", order = 3)]
	public class CommonPhraseProfile : ScriptableObject
	{
		// Token: 0x0600462F RID: 17967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600462F")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public CommonPhraseProfile()
		{
		}

		// Token: 0x04003E10 RID: 15888
		[Token(Token = "0x4003E10")]
		[FieldOffset(Offset = "0x18")]
		public string[] commonPhraseEnum;

		// Token: 0x04003E11 RID: 15889
		[Token(Token = "0x4003E11")]
		[FieldOffset(Offset = "0x20")]
		public TextAsset tsvBackup;
	}
}
