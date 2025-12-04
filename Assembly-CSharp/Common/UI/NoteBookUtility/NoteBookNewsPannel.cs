using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000E9D RID: 3741
	[Token(Token = "0x2000E9D")]
	[GenerateCleanupMethod]
	public class NoteBookNewsPannel : UISubPanel<NoteBookMainPannel>
	{
		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x060057FA RID: 22522 RVA: 0x0001F008 File Offset: 0x0001D208
		[Token(Token = "0x17000C4B")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x60057FA")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060057FB RID: 22523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FB")]
		[Address(RVA = "0x872730", Offset = "0x871130", VA = "0x180872730", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060057FC RID: 22524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FC")]
		[Address(RVA = "0x872930", Offset = "0x871330", VA = "0x180872930", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060057FD RID: 22525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FD")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060057FE RID: 22526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FE")]
		[Address(RVA = "0x872A60", Offset = "0x871460", VA = "0x180872A60")]
		private void OnSecondaryInput(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x060057FF RID: 22527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057FF")]
		[Address(RVA = "0x872990", Offset = "0x871390", VA = "0x180872990")]
		private void OnScrollInput(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x06005800 RID: 22528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005800")]
		[Address(RVA = "0x8726C0", Offset = "0x8710C0", VA = "0x1808726C0")]
		private void GoToNext()
		{
		}

		// Token: 0x06005801 RID: 22529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005801")]
		[Address(RVA = "0x8725A0", Offset = "0x870FA0", VA = "0x1808725A0")]
		private void BackToPrevious()
		{
		}

		// Token: 0x06005802 RID: 22530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005802")]
		[Address(RVA = "0x873080", Offset = "0x871A80", VA = "0x180873080")]
		private void UpdateCurrent()
		{
		}

		// Token: 0x06005803 RID: 22531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005803")]
		[Address(RVA = "0x872AF0", Offset = "0x8714F0", VA = "0x180872AF0")]
		private void PrintPage(ReadOnlySpan<RunTimeScheduler.HistoryNewsData> pageData)
		{
		}

		// Token: 0x06005804 RID: 22532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005804")]
		[Address(RVA = "0x8725C0", Offset = "0x870FC0", VA = "0x1808725C0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005805 RID: 22533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005805")]
		[Address(RVA = "0x873200", Offset = "0x871C00", VA = "0x180873200")]
		public NoteBookNewsPannel()
		{
		}

		// Token: 0x06005806 RID: 22534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005806")]
		[Address(RVA = "0x872D40", Offset = "0x871740", VA = "0x180872D40")]
		[CompilerGenerated]
		private void <PrintPage>g__PrintToPage|20_0(RectTransform field, ReadOnlySpan<RunTimeScheduler.HistoryNewsData> collection)
		{
		}

		// Token: 0x04005262 RID: 21090
		[Token(Token = "0x4005262")]
		[FieldOffset(Offset = "0x78")]
		public GameObject[] allNewPannelInstances;

		// Token: 0x04005263 RID: 21091
		[Token(Token = "0x4005263")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform leftPannelA;

		// Token: 0x04005264 RID: 21092
		[Token(Token = "0x4005264")]
		[FieldOffset(Offset = "0x88")]
		public RectTransform rightPannelA;

		// Token: 0x04005265 RID: 21093
		[Token(Token = "0x4005265")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform leftPannelB;

		// Token: 0x04005266 RID: 21094
		[Token(Token = "0x4005266")]
		[FieldOffset(Offset = "0x98")]
		public RectTransform rightPannelB;

		// Token: 0x04005267 RID: 21095
		[Token(Token = "0x4005267")]
		[FieldOffset(Offset = "0xA0")]
		public UIButtonSimple gotoPrevious;

		// Token: 0x04005268 RID: 21096
		[Token(Token = "0x4005268")]
		[FieldOffset(Offset = "0xA8")]
		public UIButtonSimple gotoNext;

		// Token: 0x04005269 RID: 21097
		[Token(Token = "0x4005269")]
		[FieldOffset(Offset = "0xB0")]
		public TextMeshProUGUI PageIndex;

		// Token: 0x0400526A RID: 21098
		[Token(Token = "0x400526A")]
		[FieldOffset(Offset = "0xB8")]
		private readonly HashSet<GameObject> m_AllInstances;

		// Token: 0x0400526B RID: 21099
		[Token(Token = "0x400526B")]
		[FieldOffset(Offset = "0xC0")]
		private int m_CurrentPageIndex;
	}
}
