using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.CharacterUtility
{
	// Token: 0x02000B5A RID: 2906
	[Token(Token = "0x2000B5A")]
	[CreateAssetMenu(fileName = "SpecialCharacterSkinSets", menuName = "GameData Profile/CreateSpecialCharacterSkinSets", order = 3)]
	public class CharacterSkinSets : ScriptableObject
	{
		// Token: 0x0600452A RID: 17706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600452A")]
		[Address(RVA = "0x733E30", Offset = "0x732830", VA = "0x180733E30")]
		public void Initialize(CharacterSpriteSetCompact defaultSkin, CharacterSpriteSetCompact[] explicits, CharacterSpriteSetCompact[] dlcs)
		{
		}

		// Token: 0x0600452B RID: 17707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452B")]
		[Address(RVA = "0x733C70", Offset = "0x732670", VA = "0x180733C70")]
		public CharacterSpriteSetCompact GetPixel(CharacterSkinSets.SkinSelectionInfo selectionInfo, bool isCompact, int? overrideIndex, bool useDefaultSkin = false)
		{
			return null;
		}

		// Token: 0x0600452C RID: 17708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600452C")]
		[Address(RVA = "0x733B20", Offset = "0x732520", VA = "0x180733B20")]
		public CharacterSpriteSetCompact GetDefaultPixel(bool isCompact)
		{
			return null;
		}

		// Token: 0x0600452D RID: 17709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600452D")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public CharacterSkinSets()
		{
		}

		// Token: 0x04003D5E RID: 15710
		[Token(Token = "0x4003D5E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterSpriteSetCompact defaultSkin;

		// Token: 0x04003D5F RID: 15711
		[Token(Token = "0x4003D5F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CharacterSpriteSetCompact[] explicits;

		// Token: 0x04003D60 RID: 15712
		[Token(Token = "0x4003D60")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharacterSpriteSetCompact[] dlcs;

		// Token: 0x02000B5B RID: 2907
		[Token(Token = "0x2000B5B")]
		[Serializable]
		public enum SelectedType
		{
			// Token: 0x04003D62 RID: 15714
			[Token(Token = "0x4003D62")]
			Default,
			// Token: 0x04003D63 RID: 15715
			[Token(Token = "0x4003D63")]
			Explicit,
			// Token: 0x04003D64 RID: 15716
			[Token(Token = "0x4003D64")]
			DLC
		}

		// Token: 0x02000B5C RID: 2908
		[Token(Token = "0x2000B5C")]
		[Serializable]
		public struct SkinSelectionInfo : IEquatable<CharacterSkinSets.SkinSelectionInfo>
		{
			// Token: 0x0600452E RID: 17710 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600452E")]
			[Address(RVA = "0x41AF60", Offset = "0x419960", VA = "0x18041AF60")]
			public SkinSelectionInfo(CharacterSkinSets.SelectedType selectedType, int index)
			{
			}

			// Token: 0x170009CE RID: 2510
			// (get) Token: 0x0600452F RID: 17711 RVA: 0x00018F00 File Offset: 0x00017100
			[Token(Token = "0x170009CE")]
			public static CharacterSkinSets.SkinSelectionInfo Default
			{
				[Token(Token = "0x600452F")]
				[Address(RVA = "0x741100", Offset = "0x73FB00", VA = "0x180741100")]
				get
				{
					return default(CharacterSkinSets.SkinSelectionInfo);
				}
			}

			// Token: 0x06004530 RID: 17712 RVA: 0x00018F18 File Offset: 0x00017118
			[Token(Token = "0x6004530")]
			[Address(RVA = "0x734DC0", Offset = "0x7337C0", VA = "0x180734DC0", Slot = "4")]
			public bool Equals(CharacterSkinSets.SkinSelectionInfo other)
			{
				return default(bool);
			}

			// Token: 0x06004531 RID: 17713 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004531")]
			[Address(RVA = "0x741060", Offset = "0x73FA60", VA = "0x180741060", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x06004532 RID: 17714 RVA: 0x00018F30 File Offset: 0x00017130
			[Token(Token = "0x6004532")]
			[Address(RVA = "0x740F90", Offset = "0x73F990", VA = "0x180740F90", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x06004533 RID: 17715 RVA: 0x00018F48 File Offset: 0x00017148
			[Token(Token = "0x6004533")]
			[Address(RVA = "0x741020", Offset = "0x73FA20", VA = "0x180741020", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x06004534 RID: 17716 RVA: 0x00018F60 File Offset: 0x00017160
			[Token(Token = "0x6004534")]
			[Address(RVA = "0x741110", Offset = "0x73FB10", VA = "0x180741110")]
			public static bool operator ==(CharacterSkinSets.SkinSelectionInfo left, CharacterSkinSets.SkinSelectionInfo right)
			{
				return default(bool);
			}

			// Token: 0x06004535 RID: 17717 RVA: 0x00018F78 File Offset: 0x00017178
			[Token(Token = "0x6004535")]
			[Address(RVA = "0x741130", Offset = "0x73FB30", VA = "0x180741130")]
			public static bool operator !=(CharacterSkinSets.SkinSelectionInfo left, CharacterSkinSets.SkinSelectionInfo right)
			{
				return default(bool);
			}

			// Token: 0x04003D65 RID: 15717
			[Token(Token = "0x4003D65")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public CharacterSkinSets.SelectedType selectedType;

			// Token: 0x04003D66 RID: 15718
			[Token(Token = "0x4003D66")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public int index;
		}
	}
}
