using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Core.Collections.CharacterUtility
{
	// Token: 0x02000B61 RID: 2913
	[Token(Token = "0x2000B61")]
	public static class CharacterSpriteSetHelper
	{
		// Token: 0x06004554 RID: 17748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004554")]
		[Address(RVA = "0x734B30", Offset = "0x733530", VA = "0x180734B30")]
		public static void Assign(this CharacterSpriteSetCompact characterSpriteSet, Image mainImage, Image eyesImage, int mainIndex, int eyesIndex)
		{
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004555")]
		[Address(RVA = "0x7348A0", Offset = "0x7332A0", VA = "0x1807348A0")]
		public static void Assign(this CharacterSpriteSetFull characterSpriteSet, Image backImage, Image baseImage, Image dressImage, Image hairImage, Image eyesImage, int mainIndex, int eyesIndex)
		{
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004556")]
		[Address(RVA = "0x7347A0", Offset = "0x7331A0", VA = "0x1807347A0")]
		public static void AssignTrimFront(this CharacterSpriteSetCompact characterSpriteSet, Image trimFrontImage, int frontIndex)
		{
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004557")]
		[Address(RVA = "0x7344A0", Offset = "0x732EA0", VA = "0x1807344A0")]
		public static void AssignTrimBack(this CharacterSpriteSetCompact characterSpriteSet, Image trimBackImage, int backIndex)
		{
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004558")]
		[Address(RVA = "0x734A70", Offset = "0x733470", VA = "0x180734A70")]
		public static void Assign(this CharacterSpriteSetCompact characterSpriteSet, SpriteRenderer mainImage, SpriteRenderer eyesImage, int mainIndex, int eyesIndex)
		{
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004559")]
		[Address(RVA = "0x734BF0", Offset = "0x7335F0", VA = "0x180734BF0")]
		public static void Assign(this CharacterSpriteSetFull characterSpriteSet, SpriteRenderer backImage, SpriteRenderer baseImage, SpriteRenderer dressImage, SpriteRenderer hairImage, SpriteRenderer eyesImage, int mainIndex, int eyesIndex)
		{
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600455A")]
		[Address(RVA = "0x7346A0", Offset = "0x7330A0", VA = "0x1807346A0")]
		public static void AssignTrimFront(this CharacterSpriteSetCompact characterSpriteSet, SpriteRenderer trimFrontImage, int frontIndex)
		{
		}

		// Token: 0x0600455B RID: 17755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600455B")]
		[Address(RVA = "0x7345A0", Offset = "0x732FA0", VA = "0x1807345A0")]
		public static void AssignTrimBack(this CharacterSpriteSetCompact characterSpriteSet, SpriteRenderer trimBackImage, int backIndex)
		{
		}
	}
}
