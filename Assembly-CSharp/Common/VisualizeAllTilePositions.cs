using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Common
{
	// Token: 0x02000D80 RID: 3456
	[Token(Token = "0x2000D80")]
	[GenerateCleanupMethod]
	[ExecuteAlways]
	public class VisualizeAllTilePositions : MonoBehaviour
	{
		// Token: 0x060050FD RID: 20733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FD")]
		[Address(RVA = "0x7F9380", Offset = "0x7F7D80", VA = "0x1807F9380")]
		private void OnEnable()
		{
		}

		// Token: 0x060050FE RID: 20734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FE")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x060050FF RID: 20735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60050FF")]
		[Address(RVA = "0x7F9380", Offset = "0x7F7D80", VA = "0x1807F9380")]
		private void OnValidate()
		{
		}

		// Token: 0x06005100 RID: 20736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005100")]
		[Address(RVA = "0x7F9390", Offset = "0x7F7D90", VA = "0x1807F9390")]
		private void UpdateAllTilePositions()
		{
		}

		// Token: 0x06005101 RID: 20737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005101")]
		[Address(RVA = "0x5315C0", Offset = "0x52FFC0", VA = "0x1805315C0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06005102 RID: 20738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005102")]
		[Address(RVA = "0x7F9660", Offset = "0x7F8060", VA = "0x1807F9660")]
		public VisualizeAllTilePositions()
		{
		}

		// Token: 0x04004BFD RID: 19453
		[Token(Token = "0x4004BFD")]
		[FieldOffset(Offset = "0x18")]
		public Tilemap tilemap;

		// Token: 0x04004BFE RID: 19454
		[Token(Token = "0x4004BFE")]
		[FieldOffset(Offset = "0x20")]
		private readonly Vector2 offset;

		// Token: 0x04004BFF RID: 19455
		[Token(Token = "0x4004BFF")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<Vector2> allTilePositions;

		// Token: 0x04004C00 RID: 19456
		[Token(Token = "0x4004C00")]
		[FieldOffset(Offset = "0x30")]
		private GUIStyle style;
	}
}
