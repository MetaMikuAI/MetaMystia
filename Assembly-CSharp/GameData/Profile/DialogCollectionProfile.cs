using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B85 RID: 2949
	[Token(Token = "0x2000B85")]
	[CreateAssetMenu(fileName = "DialogProfile", menuName = "GameData Profile/Dialog/Profile", order = 3)]
	public class DialogCollectionProfile : ScriptableObject
	{
		// Token: 0x06004637 RID: 17975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004637")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DialogCollectionProfile()
		{
		}

		// Token: 0x04003E2A RID: 15914
		[Token(Token = "0x4003E2A")]
		[FieldOffset(Offset = "0x18")]
		public DialogCollectionProfile.IDTextPair[] allContents;

		// Token: 0x02000B86 RID: 2950
		[Token(Token = "0x2000B86")]
		[Serializable]
		public struct IDTextPair
		{
			// Token: 0x04003E2B RID: 15915
			[Token(Token = "0x4003E2B")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public string id;

			// Token: 0x04003E2C RID: 15916
			[Token(Token = "0x4003E2C")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public DialogPackage dialogePack;
		}
	}
}
