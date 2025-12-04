using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000E6A RID: 3690
	[Token(Token = "0x2000E6A")]
	[GenerateCleanupMethod]
	public class UISelectionPanel : UIPanelParamClose<bool>
	{
		// Token: 0x06005635 RID: 22069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005635")]
		[Address(RVA = "0x867290", Offset = "0x865C90", VA = "0x180867290", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005636 RID: 22070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005636")]
		[Address(RVA = "0x867390", Offset = "0x865D90", VA = "0x180867390", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005637 RID: 22071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005637")]
		[Address(RVA = "0x442B10", Offset = "0x441510", VA = "0x180442B10", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005638 RID: 22072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005638")]
		[Address(RVA = "0x867450", Offset = "0x865E50", VA = "0x180867450")]
		public UISelectionPanel()
		{
		}

		// Token: 0x040050FF RID: 20735
		[Token(Token = "0x40050FF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIButtonSimple m_ConfirmButton;

		// Token: 0x04005100 RID: 20736
		[Token(Token = "0x4005100")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIButtonSimple m_RefuseButton;

		// Token: 0x04005101 RID: 20737
		[Token(Token = "0x4005101")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool defaultSelectConfirm;
	}
}
