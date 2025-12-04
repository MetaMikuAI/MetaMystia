using System;
using Common.DialogUtility;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BD2 RID: 3026
	[Token(Token = "0x2000BD2")]
	[CreateAssetMenu(fileName = "DialogPackage", menuName = "GameData Profile/Dialog/DialogPackage", order = 3)]
	public class DialogPackage : ScriptableObject
	{
		// Token: 0x060046D7 RID: 18135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D7")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DialogPackage()
		{
		}

		// Token: 0x04003FFD RID: 16381
		[Token(Token = "0x4003FFD")]
		[FieldOffset(Offset = "0x18")]
		public MultiLanguageTextMesh.MultiLanguageAssetReference dialogContext;

		// Token: 0x04003FFE RID: 16382
		[Token(Token = "0x4003FFE")]
		[FieldOffset(Offset = "0x20")]
		public DialogMeta[] dialogMeta;
	}
}
