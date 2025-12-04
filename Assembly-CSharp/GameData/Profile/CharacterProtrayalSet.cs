using System;
using GameData.Core.Collections.CharacterUtility;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B76 RID: 2934
	[Token(Token = "0x2000B76")]
	[CreateAssetMenu(fileName = "CharacterProtrayalSet", menuName = "GameData Profile/CreateCharacterProtrayalSet", order = 3)]
	public class CharacterProtrayalSet : ScriptableObject
	{
		// Token: 0x06004622 RID: 17954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004622")]
		[Address(RVA = "0x733940", Offset = "0x732340", VA = "0x180733940")]
		public CharacterPortrayal GetProtrayal(CharacterSkinSets.SkinSelectionInfo selectionInfo, int? overrideIndex, bool useDefaultSkin = false)
		{
			return null;
		}

		// Token: 0x06004623 RID: 17955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004623")]
		[Address(RVA = "0x733830", Offset = "0x732230", VA = "0x180733830")]
		public CharacterPortrayal GetDefaultProtrayal()
		{
			return null;
		}

		// Token: 0x06004624 RID: 17956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004624")]
		[Address(RVA = "0x733910", Offset = "0x732310", VA = "0x180733910")]
		public CharacterPortrayal GetDefaultWorkProtrayal()
		{
			return null;
		}

		// Token: 0x06004625 RID: 17957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004625")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public CharacterProtrayalSet()
		{
		}

		// Token: 0x04003E00 RID: 15872
		[Token(Token = "0x4003E00")]
		[FieldOffset(Offset = "0x18")]
		public CharacterPortrayal defaultPortrayal;

		// Token: 0x04003E01 RID: 15873
		[Token(Token = "0x4003E01")]
		[FieldOffset(Offset = "0x20")]
		public CharacterPortrayal[] explicitPortrayals;

		// Token: 0x04003E02 RID: 15874
		[Token(Token = "0x4003E02")]
		[FieldOffset(Offset = "0x28")]
		public CharacterPortrayal[] dlcPortrayals;
	}
}
