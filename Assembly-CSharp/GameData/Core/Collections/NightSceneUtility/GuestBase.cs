using System;
using Common.UI;
using GameData.Core.Collections.CharacterUtility;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x020008F1 RID: 2289
	[Token(Token = "0x20008F1")]
	[Serializable]
	public class GuestBase : ITextProvider<LanguageBase>
	{
		// Token: 0x06003922 RID: 14626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003922")]
		[Address(RVA = "0x3F94B0", Offset = "0x3F7EB0", VA = "0x1803F94B0")]
		public GuestBase(int id)
		{
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06003923 RID: 14627 RVA: 0x00015AE0 File Offset: 0x00013CE0
		// (set) Token: 0x06003924 RID: 14628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007ED")]
		public int Id
		{
			[Token(Token = "0x6003923")]
			[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6003924")]
			[Address(RVA = "0x403870", Offset = "0x402270", VA = "0x180403870")]
			set
			{
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06003925 RID: 14629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007EE")]
		public virtual CharacterPortrayal CharacterPortrayal
		{
			[Token(Token = "0x6003925")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06003926 RID: 14630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007EF")]
		public virtual CharacterSpriteSetCompact CharacterPixel
		{
			[Token(Token = "0x6003926")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06003927 RID: 14631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F0")]
		public virtual LanguageBase Text
		{
			[Token(Token = "0x6003927")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06003928 RID: 14632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F1")]
		public Color[] CharacterColorScheme
		{
			[Token(Token = "0x6003928")]
			[Address(RVA = "0x684660", Offset = "0x683060", VA = "0x180684660")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06003929 RID: 14633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007F2")]
		public virtual int[] LikeFoodTag
		{
			[Token(Token = "0x6003929")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600392A RID: 14634 RVA: 0x00015AF8 File Offset: 0x00013CF8
		[Token(Token = "0x600392A")]
		[Address(RVA = "0x684620", Offset = "0x683020", VA = "0x180684620", Slot = "9")]
		public virtual Vector2Int GetFundRange()
		{
			return default(Vector2Int);
		}

		// Token: 0x0600392B RID: 14635 RVA: 0x00015B10 File Offset: 0x00013D10
		[Token(Token = "0x600392B")]
		[Address(RVA = "0x684520", Offset = "0x682F20", VA = "0x180684520")]
		public int GenerateFund()
		{
			return 0;
		}

		// Token: 0x0600392C RID: 14636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600392C")]
		[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "10")]
		protected virtual GuestProfilePair OnGetVisual(int id)
		{
			return null;
		}

		// Token: 0x040030BF RID: 12479
		[Token(Token = "0x40030BF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected int id;
	}
}
