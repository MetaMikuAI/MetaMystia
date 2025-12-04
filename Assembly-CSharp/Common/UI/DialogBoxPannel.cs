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
	// Token: 0x02000E4A RID: 3658
	[Token(Token = "0x2000E4A")]
	[GenerateCleanupMethod]
	public class DialogBoxPannel : UIPanel
	{
		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x0600557B RID: 21883 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600557C RID: 21884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BFE")]
		public string Context
		{
			[Token(Token = "0x600557B")]
			[Address(RVA = "0x4402B0", Offset = "0x43ECB0", VA = "0x1804402B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x600557C")]
			[Address(RVA = "0x4D2670", Offset = "0x4D1070", VA = "0x1804D2670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x0600557D RID: 21885 RVA: 0x0001E720 File Offset: 0x0001C920
		[Token(Token = "0x17000BFF")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x600557D")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600557E RID: 21886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557E")]
		[Address(RVA = "0x84EC90", Offset = "0x84D690", VA = "0x18084EC90", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x0600557F RID: 21887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600557F")]
		[Address(RVA = "0x84ED40", Offset = "0x84D740", VA = "0x18084ED40", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005580 RID: 21888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005580")]
		[Address(RVA = "0x84EE30", Offset = "0x84D830", VA = "0x18084EE30")]
		private void SelectDelayed()
		{
		}

		// Token: 0x06005581 RID: 21889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005581")]
		[Address(RVA = "0x84EC70", Offset = "0x84D670", VA = "0x18084EC70", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005582")]
		[Address(RVA = "0x40FE80", Offset = "0x40E880", VA = "0x18040FE80", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005583")]
		[Address(RVA = "0x408E80", Offset = "0x407880", VA = "0x180408E80")]
		public DialogBoxPannel()
		{
		}

		// Token: 0x04005050 RID: 20560
		[Token(Token = "0x4005050")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TMP_Text m_Content;

		// Token: 0x04005051 RID: 20561
		[Token(Token = "0x4005051")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIButtonSimple m_ComfirmButton;
	}
}
