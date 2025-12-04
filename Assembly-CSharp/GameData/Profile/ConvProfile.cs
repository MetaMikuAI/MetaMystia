using System;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B7B RID: 2939
	[Token(Token = "0x2000B7B")]
	[CreateAssetMenu(fileName = "ConvProfile", menuName = "GameData Profile/CreateConvProfile", order = 3)]
	public class ConvProfile : ScriptableObject
	{
		// Token: 0x06004630 RID: 17968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004630")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public ConvProfile()
		{
		}

		// Token: 0x04003E12 RID: 15890
		[Token(Token = "0x4003E12")]
		[FieldOffset(Offset = "0x18")]
		public WeightedConversationGroup[] conversations;

		// Token: 0x04003E13 RID: 15891
		[Token(Token = "0x4003E13")]
		[FieldOffset(Offset = "0x20")]
		public string convLanguageFile;
	}
}
