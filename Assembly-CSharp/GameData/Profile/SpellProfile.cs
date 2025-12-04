using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CA4 RID: 3236
	[Token(Token = "0x2000CA4")]
	[CreateAssetMenu(fileName = "SpellProfile", menuName = "GameData Profile/SpellProfile", order = 3)]
	public class SpellProfile : ScriptableObject
	{
		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06004B7E RID: 19326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AD3")]
		public IEnumerable<SpellIdPair> Spells
		{
			[Token(Token = "0x6004B7E")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004B7F RID: 19327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B7F")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public SpellProfile()
		{
		}

		// Token: 0x04004568 RID: 17768
		[Token(Token = "0x4004568")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpellIdPair[] spells;

		// Token: 0x04004569 RID: 17769
		[Token(Token = "0x4004569")]
		[FieldOffset(Offset = "0x20")]
		public string previewName;

		// Token: 0x0400456A RID: 17770
		[Token(Token = "0x400456A")]
		[FieldOffset(Offset = "0x28")]
		public TextAsset languageRaw;
	}
}
