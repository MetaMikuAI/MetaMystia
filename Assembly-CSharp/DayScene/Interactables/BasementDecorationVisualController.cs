using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.Interactables
{
	// Token: 0x020004B3 RID: 1203
	[Token(Token = "0x20004B3")]
	[RequireComponent(typeof(SpriteRenderer))]
	public class BasementDecorationVisualController : MonoBehaviour
	{
		// Token: 0x06001B5F RID: 7007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B5F")]
		[Address(RVA = "0x491F40", Offset = "0x490940", VA = "0x180491F40")]
		private void Awake()
		{
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B60")]
		[Address(RVA = "0x4920B0", Offset = "0x490AB0", VA = "0x1804920B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B61")]
		[Address(RVA = "0x4921D0", Offset = "0x490BD0", VA = "0x1804921D0")]
		private void Refresh()
		{
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B62")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public BasementDecorationVisualController()
		{
		}

		// Token: 0x04001928 RID: 6440
		[Token(Token = "0x4001928")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _itemId;

		// Token: 0x04001929 RID: 6441
		[Token(Token = "0x4001929")]
		[FieldOffset(Offset = "0x20")]
		private SpriteRenderer _renderer;
	}
}
