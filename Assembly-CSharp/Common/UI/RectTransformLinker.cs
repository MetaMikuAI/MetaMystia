using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Common.UI
{
	// Token: 0x02000DB7 RID: 3511
	[Token(Token = "0x2000DB7")]
	[GenerateCleanupMethod]
	[ExecuteAlways]
	public class RectTransformLinker : UIBehaviour
	{
		// Token: 0x0600525C RID: 21084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525C")]
		[Address(RVA = "0x8005A0", Offset = "0x7FEFA0", VA = "0x1808005A0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600525D RID: 21085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525D")]
		[Address(RVA = "0x3E8C60", Offset = "0x3E7660", VA = "0x1803E8C60", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600525E RID: 21086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525E")]
		[Address(RVA = "0x8005C0", Offset = "0x7FEFC0", VA = "0x1808005C0", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x0600525F RID: 21087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525F")]
		[Address(RVA = "0x800290", Offset = "0x7FEC90", VA = "0x180800290")]
		private void Apply()
		{
		}

		// Token: 0x06005260 RID: 21088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005260")]
		[Address(RVA = "0x3E85F0", Offset = "0x3E6FF0", VA = "0x1803E85F0", Slot = "17")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005261")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public RectTransformLinker()
		{
		}

		// Token: 0x04004D38 RID: 19768
		[Token(Token = "0x4004D38")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform m_TargetRectTransform;

		// Token: 0x04004D39 RID: 19769
		[Token(Token = "0x4004D39")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectOffset m_Padding;

		// Token: 0x04004D3A RID: 19770
		[Token(Token = "0x4004D3A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform m_MaximumRectTransform;

		// Token: 0x04004D3B RID: 19771
		[Token(Token = "0x4004D3B")]
		[FieldOffset(Offset = "0x30")]
		private bool m_ApplyRequested;
	}
}
