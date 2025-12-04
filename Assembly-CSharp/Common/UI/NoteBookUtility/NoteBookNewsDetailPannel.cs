using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.PanelCollection;
using GameData.CoreLanguage;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000E9B RID: 3739
	[Token(Token = "0x2000E9B")]
	[GenerateCleanupMethod]
	[TupleElementNames(new string[] { "languageData", "date" })]
	public class NoteBookNewsDetailPannel : UIPanelParamOpen<ValueTuple<LanguageBase, GameDate>>
	{
		// Token: 0x060057F2 RID: 22514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F2")]
		[Address(RVA = "0x870AF0", Offset = "0x86F4F0", VA = "0x180870AF0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060057F3 RID: 22515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F3")]
		[Address(RVA = "0x870B40", Offset = "0x86F540", VA = "0x180870B40", Slot = "32")]
		protected override void OnPanelOpen([TupleElementNames(new string[] { "languageData", "date" })] ValueTuple<LanguageBase, GameDate> openParam)
		{
		}

		// Token: 0x060057F4 RID: 22516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F4")]
		[Address(RVA = "0x40AC00", Offset = "0x409600", VA = "0x18040AC00", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060057F5 RID: 22517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F5")]
		[Address(RVA = "0x870C20", Offset = "0x86F620", VA = "0x180870C20")]
		public NoteBookNewsDetailPannel()
		{
		}

		// Token: 0x0400525C RID: 21084
		[Token(Token = "0x400525C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshProUGUI m_Title;

		// Token: 0x0400525D RID: 21085
		[Token(Token = "0x400525D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TextMeshProUGUI m_Content;

		// Token: 0x0400525E RID: 21086
		[Token(Token = "0x400525E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TextMeshProUGUI m_Date;
	}
}
