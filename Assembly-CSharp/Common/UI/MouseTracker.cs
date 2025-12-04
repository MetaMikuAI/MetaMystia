using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000DB4 RID: 3508
	[Token(Token = "0x2000DB4")]
	[GenerateCleanupMethod]
	public class MouseTracker : MonoBehaviour
	{
		// Token: 0x0600524E RID: 21070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600524E")]
		[Address(RVA = "0x7FF9B0", Offset = "0x7FE3B0", VA = "0x1807FF9B0")]
		private void Start()
		{
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600524F")]
		[Address(RVA = "0x7FF380", Offset = "0x7FDD80", VA = "0x1807FF380")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005250")]
		[Address(RVA = "0x7FF750", Offset = "0x7FE150", VA = "0x1807FF750")]
		private void OnPointActionOnPerformed(Vector2 mouseScreenPosition)
		{
		}

		// Token: 0x06005251 RID: 21073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005251")]
		[Address(RVA = "0x7FF5B0", Offset = "0x7FDFB0", VA = "0x1807FF5B0")]
		private void OnMouseInputStateChange(bool isMouse)
		{
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005252")]
		[Address(RVA = "0x7FF880", Offset = "0x7FE280", VA = "0x1807FF880")]
		private void SetVisualAlpha(float alpha)
		{
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005253")]
		[Address(RVA = "0x3E85F0", Offset = "0x3E6FF0", VA = "0x1803E85F0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06005254 RID: 21076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005254")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public MouseTracker()
		{
		}

		// Token: 0x04004D34 RID: 19764
		[Token(Token = "0x4004D34")]
		[FieldOffset(Offset = "0x18")]
		public Image visual;

		// Token: 0x04004D35 RID: 19765
		[Token(Token = "0x4004D35")]
		[FieldOffset(Offset = "0x20")]
		private Canvas m_DependentCanvas;

		// Token: 0x04004D36 RID: 19766
		[Token(Token = "0x4004D36")]
		[FieldOffset(Offset = "0x28")]
		private Camera m_MainCamera;
	}
}
