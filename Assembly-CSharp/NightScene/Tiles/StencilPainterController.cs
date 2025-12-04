using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace NightScene.Tiles
{
	// Token: 0x02000678 RID: 1656
	[Token(Token = "0x2000678")]
	[GenerateCleanupMethod]
	public class StencilPainterController : MonoBehaviour
	{
		// Token: 0x060026E6 RID: 9958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E6")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E7")]
		[Address(RVA = "0x531CF0", Offset = "0x5306F0", VA = "0x180531CF0")]
		public void Show(Vector3 coordinate, Sprite visual)
		{
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026E8")]
		[Address(RVA = "0x531B20", Offset = "0x530520", VA = "0x180531B20")]
		public void Hide(Action onHideFinish)
		{
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026E9")]
		[Address(RVA = "0x531C70", Offset = "0x530670", VA = "0x180531C70")]
		private IEnumerator OnShowingStencilPainter()
		{
			return null;
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026EA")]
		[Address(RVA = "0x531BE0", Offset = "0x5305E0", VA = "0x180531BE0")]
		private IEnumerator OnHidingStencilPainter(Action onHideFinish)
		{
			return null;
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026EB")]
		[Address(RVA = "0x3EE530", Offset = "0x3ECF30", VA = "0x1803EE530", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026EC")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public StencilPainterController()
		{
		}

		// Token: 0x04002377 RID: 9079
		[Token(Token = "0x4002377")]
		[FieldOffset(Offset = "0x18")]
		public List<SpriteRenderer> worker;

		// Token: 0x04002378 RID: 9080
		[Token(Token = "0x4002378")]
		[FieldOffset(Offset = "0x20")]
		private Coroutine onRefreshingStencilPainter;
	}
}
