using System;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000E72 RID: 3698
	[Token(Token = "0x2000E72")]
	[GenerateCleanupMethod]
	public class PannelTestPannel : UIPanel
	{
		// Token: 0x06005673 RID: 22131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005673")]
		[Address(RVA = "0x8572A0", Offset = "0x855CA0", VA = "0x1808572A0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005674 RID: 22132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005674")]
		[Address(RVA = "0x857870", Offset = "0x856270", VA = "0x180857870", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005675 RID: 22133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005675")]
		[Address(RVA = "0x857140", Offset = "0x855B40", VA = "0x180857140")]
		private void OnMultipleChoiceMenuExit(GameObject[] allSelection)
		{
		}

		// Token: 0x06005676 RID: 22134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005676")]
		[Address(RVA = "0x426FB0", Offset = "0x4259B0", VA = "0x180426FB0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005677 RID: 22135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005677")]
		[Address(RVA = "0x408E80", Offset = "0x407880", VA = "0x180408E80")]
		public PannelTestPannel()
		{
		}

		// Token: 0x0400512C RID: 20780
		[Token(Token = "0x400512C")]
		[FieldOffset(Offset = "0x70")]
		public GameObject[] allPannels;

		// Token: 0x0400512D RID: 20781
		[Token(Token = "0x400512D")]
		[FieldOffset(Offset = "0x78")]
		private MultipleChoicePannel.MultipleChoicePannelOpenContext m_MultipleChoicePannelOpenContext;
	}
}
