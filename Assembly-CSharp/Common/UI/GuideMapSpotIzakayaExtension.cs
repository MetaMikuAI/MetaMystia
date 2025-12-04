using System;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000E3A RID: 3642
	[Token(Token = "0x2000E3A")]
	[RequireComponent(typeof(CanvasGroup))]
	[GenerateCleanupMethod]
	public class GuideMapSpotIzakayaExtension : MonoBehaviour
	{
		// Token: 0x0600551A RID: 21786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600551A")]
		[Address(RVA = "0x8386C0", Offset = "0x8370C0", VA = "0x1808386C0")]
		private void Awake()
		{
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600551B")]
		[Address(RVA = "0x8389E0", Offset = "0x8373E0", VA = "0x1808389E0")]
		public void Setup(IzakayaLevel maxLevel, UIButtonSimple uiButtonSimple, bool enableLockedIndicator)
		{
		}

		// Token: 0x0600551C RID: 21788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600551C")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600551D RID: 21789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600551D")]
		[Address(RVA = "0x838810", Offset = "0x837210", VA = "0x180838810")]
		public void SetPointStatus(bool isActived)
		{
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600551E")]
		[Address(RVA = "0x838760", Offset = "0x837160", VA = "0x180838760", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x0600551F RID: 21791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600551F")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public GuideMapSpotIzakayaExtension()
		{
		}

		// Token: 0x04004FFB RID: 20475
		[Token(Token = "0x4004FFB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image m_IzakayaSpotVisualSelected;

		// Token: 0x04004FFC RID: 20476
		[Token(Token = "0x4004FFC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image m_Level1FG;

		// Token: 0x04004FFD RID: 20477
		[Token(Token = "0x4004FFD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image m_Level2FG;

		// Token: 0x04004FFE RID: 20478
		[Token(Token = "0x4004FFE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image m_Level3FG;

		// Token: 0x04004FFF RID: 20479
		[Token(Token = "0x4004FFF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image m_Level1FG_Selected;

		// Token: 0x04005000 RID: 20480
		[Token(Token = "0x4005000")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image m_Level2FG_Selected;

		// Token: 0x04005001 RID: 20481
		[Token(Token = "0x4005001")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image m_Level3FG_Selected;

		// Token: 0x04005002 RID: 20482
		[Token(Token = "0x4005002")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image m_LockedIndicator;

		// Token: 0x04005003 RID: 20483
		[Token(Token = "0x4005003")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image m_SelfPointImage;

		// Token: 0x04005004 RID: 20484
		[Token(Token = "0x4005004")]
		[FieldOffset(Offset = "0x60")]
		private CanvasGroup m_CanvasGroup;
	}
}
