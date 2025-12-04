using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.CharacterUtility
{
	// Token: 0x02000B62 RID: 2914
	[Token(Token = "0x2000B62")]
	public class CharacterSpriteSetFull : CharacterSpriteSetCompact
	{
		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x0600455C RID: 17756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EB")]
		public override Sprite[] HairSprite
		{
			[Token(Token = "0x600455C")]
			[Address(RVA = "0x4402C0", Offset = "0x43ECC0", VA = "0x1804402C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x0600455D RID: 17757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EC")]
		public override Sprite[] BackSprite
		{
			[Token(Token = "0x600455D")]
			[Address(RVA = "0x45A7E0", Offset = "0x4591E0", VA = "0x18045A7E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x0600455E RID: 17758 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600455F RID: 17759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009ED")]
		private static Sprite[] CharacterBaseSprite
		{
			[Token(Token = "0x600455E")]
			[Address(RVA = "0x734400", Offset = "0x732E00", VA = "0x180734400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600455F")]
			[Address(RVA = "0x734440", Offset = "0x732E40", VA = "0x180734440")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06004560 RID: 17760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009EE")]
		public static IReadOnlyList<Sprite> BaseSprite
		{
			[Token(Token = "0x6004560")]
			[Address(RVA = "0x7343C0", Offset = "0x732DC0", VA = "0x1807343C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004561 RID: 17761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004561")]
		[Address(RVA = "0x734360", Offset = "0x732D60", VA = "0x180734360")]
		public static void SetBase(Sprite[] baseSprite)
		{
		}

		// Token: 0x06004562 RID: 17762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004562")]
		[Address(RVA = "0x7341E0", Offset = "0x732BE0", VA = "0x1807341E0")]
		public void Initialize(Sprite[] mainSprite, bool doNotUseEyeSprite, Sprite[] eyeSprite, Sprite[] hairSprite, Sprite[] backSprite, bool hasPrebakedShadow, float animSpeedMultiplier, float extraYOffset, bool isHina, float rotatePerTime, bool shouldHaveStepVFX, float moveSpeedMultiplier, CharacterSpriteSetCompact.RemovableTrimProperty[] removableTrimCompact, Sprite[] trimSpritesDisplayFront, Sprite[] trimSpritesDisplayBack, float trimSpriteFrameSpeed, float trimBackSpriteFrameSpeed)
		{
		}

		// Token: 0x06004563 RID: 17763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004563")]
		[Address(RVA = "0x733FD0", Offset = "0x7329D0", VA = "0x180733FD0")]
		public CharacterSpriteSetFull()
		{
		}

		// Token: 0x04003D85 RID: 15749
		[Token(Token = "0x4003D85")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Sprite[] hairSprite;

		// Token: 0x04003D86 RID: 15750
		[Token(Token = "0x4003D86")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Sprite[] backSprite;
	}
}
