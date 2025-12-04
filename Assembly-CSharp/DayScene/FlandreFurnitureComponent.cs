using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene
{
	// Token: 0x02000228 RID: 552
	[Token(Token = "0x2000228")]
	[GenerateCleanupMethod]
	public class FlandreFurnitureComponent : MonoBehaviour
	{
		// Token: 0x06000D13 RID: 3347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D13")]
		[Address(RVA = "0x8EB190", Offset = "0x8E9B90", VA = "0x1808EB190")]
		private void Awake()
		{
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D14")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D15")]
		[Address(RVA = "0x8EB3C0", Offset = "0x8E9DC0", VA = "0x1808EB3C0")]
		public void ExitEditorMode()
		{
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D16")]
		[Address(RVA = "0x8EB2A0", Offset = "0x8E9CA0", VA = "0x1808EB2A0")]
		public void EnterEditorMode()
		{
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D17")]
		[Address(RVA = "0x6DE240", Offset = "0x6DCC40", VA = "0x1806DE240", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D18")]
		[Address(RVA = "0x8EB5A0", Offset = "0x8E9FA0", VA = "0x1808EB5A0")]
		public FlandreFurnitureComponent()
		{
		}

		// Token: 0x04000B99 RID: 2969
		[Token(Token = "0x4000B99")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color EditorColor;

		// Token: 0x04000B9A RID: 2970
		[Token(Token = "0x4000B9A")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color NormalColor;

		// Token: 0x04000B9B RID: 2971
		[Token(Token = "0x4000B9B")]
		[FieldOffset(Offset = "0x18")]
		public SpriteRenderer OutlineRenderer;

		// Token: 0x04000B9C RID: 2972
		[Token(Token = "0x4000B9C")]
		[FieldOffset(Offset = "0x20")]
		public Vector2Int pointArea;

		// Token: 0x04000B9D RID: 2973
		[Token(Token = "0x4000B9D")]
		[FieldOffset(Offset = "0x28")]
		private List<SpriteRenderer> allSpriteRenderers;
	}
}
