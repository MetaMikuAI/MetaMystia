using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace NightScene.Tiles
{
	// Token: 0x0200067F RID: 1663
	[Token(Token = "0x200067F")]
	[GenerateCleanupMethod]
	public class IzakayaMap : MonoBehaviour
	{
		// Token: 0x06002702 RID: 9986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002702")]
		[Address(RVA = "0x531530", Offset = "0x52FF30", VA = "0x180531530", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06002703 RID: 9987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002703")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public IzakayaMap()
		{
		}

		// Token: 0x040023A7 RID: 9127
		[Token(Token = "0x40023A7")]
		[FieldOffset(Offset = "0x18")]
		public Grid referenceGrid;

		// Token: 0x040023A8 RID: 9128
		[Token(Token = "0x40023A8")]
		[FieldOffset(Offset = "0x20")]
		public Tilemap additionalCollision;

		// Token: 0x040023A9 RID: 9129
		[Token(Token = "0x40023A9")]
		[FieldOffset(Offset = "0x28")]
		public Tilemap interactable;

		// Token: 0x040023AA RID: 9130
		[Token(Token = "0x40023AA")]
		[FieldOffset(Offset = "0x30")]
		public Tilemap height;

		// Token: 0x040023AB RID: 9131
		[Token(Token = "0x40023AB")]
		[FieldOffset(Offset = "0x38")]
		public Tilemap decoration;

		// Token: 0x040023AC RID: 9132
		[Token(Token = "0x40023AC")]
		[FieldOffset(Offset = "0x40")]
		public Tilemap space;

		// Token: 0x040023AD RID: 9133
		[Token(Token = "0x40023AD")]
		[FieldOffset(Offset = "0x48")]
		public Tilemap rayCollider;
	}
}
