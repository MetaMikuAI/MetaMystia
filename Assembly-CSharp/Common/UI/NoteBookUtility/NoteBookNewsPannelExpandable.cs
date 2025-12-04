using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Pool;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000EA0 RID: 3744
	[Token(Token = "0x2000EA0")]
	[GenerateCleanupMethod]
	public class NoteBookNewsPannelExpandable : UISubPanel<NoteBookMainPannel>
	{
		// Token: 0x0600580C RID: 22540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600580C")]
		[Address(RVA = "0x8717D0", Offset = "0x8701D0", VA = "0x1808717D0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x0600580D RID: 22541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600580D")]
		[Address(RVA = "0x8716F0", Offset = "0x8700F0", VA = "0x1808716F0")]
		private void GoToNext()
		{
		}

		// Token: 0x0600580E RID: 22542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600580E")]
		[Address(RVA = "0x870EB0", Offset = "0x86F8B0", VA = "0x180870EB0")]
		private void BackToPrevious()
		{
		}

		// Token: 0x0600580F RID: 22543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600580F")]
		[Address(RVA = "0x871580", Offset = "0x86FF80", VA = "0x180871580")]
		private void ExitGroupAndUpdateCurrent()
		{
		}

		// Token: 0x06005810 RID: 22544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005810")]
		[Address(RVA = "0x871D30", Offset = "0x870730", VA = "0x180871D30", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005811 RID: 22545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005811")]
		[Address(RVA = "0x871760", Offset = "0x870160", VA = "0x180871760", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06005812 RID: 22546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005812")]
		[Address(RVA = "0x871100", Offset = "0x86FB00", VA = "0x180871100")]
		private void ExitGroupAndPrintPage(ReadOnlySpan<RunTimeScheduler.HistoryNewsData> pageData)
		{
		}

		// Token: 0x06005813 RID: 22547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005813")]
		[Address(RVA = "0x871050", Offset = "0x86FA50", VA = "0x180871050")]
		private void CollectInstance([TupleElementNames(new string[] { "Parent", "Instance" })] in ValueTuple<IntractableNewsObject, IntractableNewsObject> value)
		{
		}

		// Token: 0x06005814 RID: 22548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005814")]
		[Address(RVA = "0x871DC0", Offset = "0x8707C0", VA = "0x180871DC0")]
		private void OpenDetailPanel(RunTimeScheduler.HistoryNewsData newsData)
		{
		}

		// Token: 0x06005815 RID: 22549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005815")]
		[Address(RVA = "0x870F20", Offset = "0x86F920", VA = "0x180870F20", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005816 RID: 22550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005816")]
		[Address(RVA = "0x8724A0", Offset = "0x870EA0", VA = "0x1808724A0")]
		public NoteBookNewsPannelExpandable()
		{
		}

		// Token: 0x0600581A RID: 22554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600581A")]
		[Address(RVA = "0x871F00", Offset = "0x870900", VA = "0x180871F00")]
		[CompilerGenerated]
		private void <ExitGroupAndPrintPage>g__PrintToPage|20_0(RectTransform field, ReadOnlySpan<RunTimeScheduler.HistoryNewsData> collection)
		{
		}

		// Token: 0x0400526E RID: 21102
		[Token(Token = "0x400526E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private IntractableNewsObject[] m_AllNewsPrefabs;

		// Token: 0x0400526F RID: 21103
		[Token(Token = "0x400526F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private NoteBookNewsDetailPannel[] m_AllNewsDetailPannels;

		// Token: 0x04005270 RID: 21104
		[Token(Token = "0x4005270")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform m_Field1;

		// Token: 0x04005271 RID: 21105
		[Token(Token = "0x4005271")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform m_Field2;

		// Token: 0x04005272 RID: 21106
		[Token(Token = "0x4005272")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform m_Field3;

		// Token: 0x04005273 RID: 21107
		[Token(Token = "0x4005273")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform m_Field4;

		// Token: 0x04005274 RID: 21108
		[Token(Token = "0x4005274")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIButtonSimple m_GotoPrevBtn;

		// Token: 0x04005275 RID: 21109
		[Token(Token = "0x4005275")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIButtonSimple m_GotoNextBtn;

		// Token: 0x04005276 RID: 21110
		[Token(Token = "0x4005276")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private TextMeshProUGUI m_PageIndex;

		// Token: 0x04005277 RID: 21111
		[Token(Token = "0x4005277")]
		[FieldOffset(Offset = "0xC0")]
		private readonly Dictionary<IntractableNewsObject, ObjectPool<IntractableNewsObject>> m_Pool;

		// Token: 0x04005278 RID: 21112
		[Token(Token = "0x4005278")]
		[FieldOffset(Offset = "0xC8")]
		[TupleElementNames(new string[] { "Parent", "Instance" })]
		private readonly UILogicalGroupT<ValueTuple<IntractableNewsObject, IntractableNewsObject>> m_LogicalGroupT;

		// Token: 0x04005279 RID: 21113
		[Token(Token = "0x4005279")]
		[FieldOffset(Offset = "0xD0")]
		private int m_CurrentPageIndex;

		// Token: 0x0400527A RID: 21114
		[Token(Token = "0x400527A")]
		[FieldOffset(Offset = "0xD4")]
		private int m_TotalPageCountCache;

		// Token: 0x0400527B RID: 21115
		[Token(Token = "0x400527B")]
		[FieldOffset(Offset = "0xD8")]
		private RectTransform m_ActiveField;
	}
}
