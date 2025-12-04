using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B87 RID: 2951
	[Token(Token = "0x2000B87")]
	[CreateAssetMenu(fileName = "DialogPackageCollection", menuName = "GameData Profile/Dialog/CreateDialogPackageCollection", order = 3)]
	public class DialogPackageCollection : ScriptableObject
	{
		// Token: 0x06004638 RID: 17976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004638")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DialogPackageCollection()
		{
		}

		// Token: 0x04003E2D RID: 15917
		[Token(Token = "0x4003E2D")]
		[FieldOffset(Offset = "0x18")]
		public DialogPackageCollection.IDPackagePair[] allDialogPackages;

		// Token: 0x02000B88 RID: 2952
		[Token(Token = "0x2000B88")]
		[Serializable]
		public struct IDPackagePair
		{
			// Token: 0x04003E2E RID: 15918
			[Token(Token = "0x4003E2E")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public int id;

			// Token: 0x04003E2F RID: 15919
			[Token(Token = "0x4003E2F")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public DialogPackage dialogPackage;
		}
	}
}
