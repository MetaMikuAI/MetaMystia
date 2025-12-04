using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000E4F RID: 3663
	[Token(Token = "0x2000E4F")]
	[GenerateCleanupMethod]
	[TupleElementNames(new string[] { "title", "message" })]
	public class GenericErrorPanel : UIPanelParamOpen<ValueTuple<string, string>>
	{
		// Token: 0x060055A9 RID: 21929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055A9")]
		[Address(RVA = "0x8516B0", Offset = "0x8500B0", VA = "0x1808516B0")]
		public void AppendText(string newText)
		{
		}

		// Token: 0x060055AA RID: 21930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AA")]
		[Address(RVA = "0x851A20", Offset = "0x850420", VA = "0x180851A20")]
		public void SetText(string text)
		{
		}

		// Token: 0x060055AB RID: 21931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AB")]
		[Address(RVA = "0x8517C0", Offset = "0x8501C0", VA = "0x1808517C0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060055AC RID: 21932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AC")]
		[Address(RVA = "0x8518C0", Offset = "0x8502C0", VA = "0x1808518C0", Slot = "32")]
		protected override void OnPanelOpen([TupleElementNames(new string[] { "title", "message" })] ValueTuple<string, string> openParam)
		{
		}

		// Token: 0x060055AD RID: 21933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AD")]
		[Address(RVA = "0x851740", Offset = "0x850140", VA = "0x180851740", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060055AE RID: 21934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60055AE")]
		[Address(RVA = "0x851AE0", Offset = "0x8504E0", VA = "0x180851AE0")]
		public GenericErrorPanel()
		{
		}

		// Token: 0x04005070 RID: 20592
		[Token(Token = "0x4005070")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshProUGUI m_ErrorMessageTitle;

		// Token: 0x04005071 RID: 20593
		[Token(Token = "0x4005071")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TextMeshProUGUI m_ErrorMessageField;

		// Token: 0x04005072 RID: 20594
		[Token(Token = "0x4005072")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIButtonSimple m_ErrorMessageFieldButton;

		// Token: 0x04005073 RID: 20595
		[Token(Token = "0x4005073")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIButtonSimple m_QuitButton;
	}
}
