using System;
using GameData.Core.Collections.CharacterUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.CharacterUtility
{
	// Token: 0x02001037 RID: 4151
	[Token(Token = "0x2001037")]
	[GenerateCleanupMethod]
	public class CharacterAnimatorLayered : CharacterAnimator
	{
		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x06005FBC RID: 24508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D34")]
		private new CharacterSpriteSetFull characterSpriteSet
		{
			[Token(Token = "0x6005FBC")]
			[Address(RVA = "0x8C2DE0", Offset = "0x8C17E0", VA = "0x1808C2DE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005FBD RID: 24509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBD")]
		[Address(RVA = "0x8C2C40", Offset = "0x8C1640", VA = "0x1808C2C40")]
		public void Initialize(CharacterSpriteSetFull characterSpriteSet, SpriteRenderer pfxRenderer, SpriteRenderer baseRenderer, SpriteRenderer faceRenderer, SpriteRenderer hairRenderer, SpriteRenderer dressRenderer, SpriteRenderer backRenderer, SpriteRenderer aoRenderer, AudioClip[] stepSFX, Transform backTrimPartent, Transform frontTrimParent)
		{
		}

		// Token: 0x06005FBE RID: 24510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBE")]
		[Address(RVA = "0x8C2AF0", Offset = "0x8C14F0", VA = "0x1808C2AF0", Slot = "5")]
		public override void AnimatorSetStep(int step)
		{
		}

		// Token: 0x06005FBF RID: 24511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBF")]
		[Address(RVA = "0x8C29E0", Offset = "0x8C13E0", VA = "0x1808C29E0", Slot = "6")]
		protected override void AnimatorSetOrientation(int orientation)
		{
		}

		// Token: 0x06005FC0 RID: 24512 RVA: 0x000210D8 File Offset: 0x0001F2D8
		[Token(Token = "0x6005FC0")]
		[Address(RVA = "0x8C2D30", Offset = "0x8C1730", VA = "0x1808C2D30", Slot = "7")]
		protected override bool SetSprite(int spriteCode, int faceCode)
		{
			return default(bool);
		}

		// Token: 0x06005FC1 RID: 24513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC1")]
		[Address(RVA = "0x8C2BC0", Offset = "0x8C15C0", VA = "0x1808C2BC0", Slot = "4")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005FC2 RID: 24514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FC2")]
		[Address(RVA = "0x8C29D0", Offset = "0x8C13D0", VA = "0x1808C29D0")]
		public CharacterAnimatorLayered()
		{
		}

		// Token: 0x040058B6 RID: 22710
		[Token(Token = "0x40058B6")]
		[FieldOffset(Offset = "0xE8")]
		private SpriteRenderer baseRenderer;

		// Token: 0x040058B7 RID: 22711
		[Token(Token = "0x40058B7")]
		[FieldOffset(Offset = "0xF0")]
		private SpriteRenderer hairRenderer;

		// Token: 0x040058B8 RID: 22712
		[Token(Token = "0x40058B8")]
		[FieldOffset(Offset = "0xF8")]
		private SpriteRenderer dressRenderer;

		// Token: 0x040058B9 RID: 22713
		[Token(Token = "0x40058B9")]
		[FieldOffset(Offset = "0x100")]
		private SpriteRenderer backRenderer;
	}
}
