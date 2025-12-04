using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B84 RID: 2948
	[Token(Token = "0x2000B84")]
	[CreateAssetMenu(fileName = "DecorationProfile", menuName = "GameData Profile/CreateDecorationProfile", order = 2)]
	public class DecorationProfile : ScriptableObject
	{
		// Token: 0x06004636 RID: 17974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004636")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public DecorationProfile()
		{
		}

		// Token: 0x04003E27 RID: 15911
		[Token(Token = "0x4003E27")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Decoration[] decorations;

		// Token: 0x04003E28 RID: 15912
		[Token(Token = "0x4003E28")]
		[FieldOffset(Offset = "0x20")]
		public TextAsset previews;

		// Token: 0x04003E29 RID: 15913
		[Token(Token = "0x4003E29")]
		[FieldOffset(Offset = "0x28")]
		public TextAsset tsvBackup;
	}
}
