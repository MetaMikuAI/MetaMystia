using System;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections
{
	// Token: 0x020008CD RID: 2253
	[Token(Token = "0x20008CD")]
	[Serializable]
	public class Decoration : Item
	{
		// Token: 0x06003813 RID: 14355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003813")]
		[Address(RVA = "0x684260", Offset = "0x682C60", VA = "0x180684260")]
		public Decoration(int id, Sprite overrideSprite, DecorationBase specialBuff, Decoration.DecorationType decorationType, int[] conflictDecorationId)
		{
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06003814 RID: 14356 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003815 RID: 14357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700077D")]
		public Sprite OverrideSprite
		{
			[Token(Token = "0x6003814")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003815")]
			[Address(RVA = "0x3FC090", Offset = "0x3FAA90", VA = "0x1803FC090")]
			set
			{
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06003816 RID: 14358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077E")]
		public DecorationBase SpecialBuff
		{
			[Token(Token = "0x6003816")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06003817 RID: 14359 RVA: 0x00015258 File Offset: 0x00013458
		[Token(Token = "0x1700077F")]
		public Decoration.DecorationType DecorationSettingType
		{
			[Token(Token = "0x6003817")]
			[Address(RVA = "0x44F9E0", Offset = "0x44E3E0", VA = "0x18044F9E0")]
			get
			{
				return Decoration.DecorationType.Outdoor;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06003818 RID: 14360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000780")]
		public int[] ConflictDecorationId
		{
			[Token(Token = "0x6003818")]
			[Address(RVA = "0x6842D0", Offset = "0x682CD0", VA = "0x1806842D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04002FF6 RID: 12278
		[Token(Token = "0x4002FF6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite overrideSprite;

		// Token: 0x04002FF7 RID: 12279
		[Token(Token = "0x4002FF7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DecorationBase specialBuff;

		// Token: 0x04002FF8 RID: 12280
		[Token(Token = "0x4002FF8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Decoration.DecorationType decorationType;

		// Token: 0x04002FF9 RID: 12281
		[Token(Token = "0x4002FF9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int[] conflictDecorationId;

		// Token: 0x020008CE RID: 2254
		[Token(Token = "0x20008CE")]
		public enum DecorationType
		{
			// Token: 0x04002FFB RID: 12283
			[Token(Token = "0x4002FFB")]
			Outdoor,
			// Token: 0x04002FFC RID: 12284
			[Token(Token = "0x4002FFC")]
			Household,
			// Token: 0x04002FFD RID: 12285
			[Token(Token = "0x4002FFD")]
			FishingRod
		}
	}
}
