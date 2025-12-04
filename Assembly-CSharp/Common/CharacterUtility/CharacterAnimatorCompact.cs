using System;
using GameData.Core.Collections.CharacterUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.CharacterUtility
{
	// Token: 0x02001036 RID: 4150
	[Token(Token = "0x2001036")]
	[GenerateCleanupMethod]
	public class CharacterAnimatorCompact : CharacterAnimator
	{
		// Token: 0x06005FB6 RID: 24502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB6")]
		[Address(RVA = "0x8C28D0", Offset = "0x8C12D0", VA = "0x1808C28D0")]
		public void Initialize(CharacterSpriteSetCompact characterSprites, SpriteRenderer pfxRenderer, SpriteRenderer mainRenderer, SpriteRenderer faceRenderer, SpriteRenderer aoRenderer, AudioClip[] stepSFX, Transform backTrimPartent, Transform frontTrimParent)
		{
		}

		// Token: 0x06005FB7 RID: 24503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB7")]
		[Address(RVA = "0x8C2820", Offset = "0x8C1220", VA = "0x1808C2820", Slot = "5")]
		public override void AnimatorSetStep(int step)
		{
		}

		// Token: 0x06005FB8 RID: 24504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FB8")]
		[Address(RVA = "0x8C27A0", Offset = "0x8C11A0", VA = "0x1808C27A0", Slot = "6")]
		protected override void AnimatorSetOrientation(int orientation)
		{
		}

		// Token: 0x06005FB9 RID: 24505 RVA: 0x000210C0 File Offset: 0x0001F2C0
		[Token(Token = "0x6005FB9")]
		[Address(RVA = "0x8C2970", Offset = "0x8C1370", VA = "0x1808C2970", Slot = "7")]
		protected override bool SetSprite(int spriteCode, int faceCode)
		{
			return default(bool);
		}

		// Token: 0x06005FBA RID: 24506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBA")]
		[Address(RVA = "0x8C28A0", Offset = "0x8C12A0", VA = "0x1808C28A0", Slot = "4")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005FBB RID: 24507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005FBB")]
		[Address(RVA = "0x8C29D0", Offset = "0x8C13D0", VA = "0x1808C29D0")]
		public CharacterAnimatorCompact()
		{
		}

		// Token: 0x040058B5 RID: 22709
		[Token(Token = "0x40058B5")]
		[FieldOffset(Offset = "0xE8")]
		private SpriteRenderer mainRenderer;
	}
}
