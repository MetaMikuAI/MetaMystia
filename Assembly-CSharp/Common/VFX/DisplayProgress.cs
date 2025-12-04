using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.VFX
{
	// Token: 0x02000DA6 RID: 3494
	[Token(Token = "0x2000DA6")]
	[GenerateCleanupMethod]
	[ExecuteAlways]
	public class DisplayProgress : MonoBehaviour
	{
		// Token: 0x060051FA RID: 20986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FA")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x060051FB RID: 20987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FB")]
		[Address(RVA = "0x7FCF90", Offset = "0x7FB990", VA = "0x1807FCF90")]
		public void SetProgress(float progress)
		{
		}

		// Token: 0x060051FC RID: 20988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FC")]
		[Address(RVA = "0x3EE530", Offset = "0x3ECF30", VA = "0x1803EE530", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060051FD RID: 20989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051FD")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public DisplayProgress()
		{
		}

		// Token: 0x04004D16 RID: 19734
		[Token(Token = "0x4004D16")]
		[FieldOffset(Offset = "0x18")]
		public SpriteRenderer spriteRenderer;

		// Token: 0x04004D17 RID: 19735
		[Token(Token = "0x4004D17")]
		[FieldOffset(Offset = "0x20")]
		public Sprite[] sequences;
	}
}
