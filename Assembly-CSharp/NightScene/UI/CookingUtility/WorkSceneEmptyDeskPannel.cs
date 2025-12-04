using System;
using System.Runtime.CompilerServices;
using Common.UI;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using Plugins.DEYU;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.CookingUtility
{
	// Token: 0x0200071D RID: 1821
	[Token(Token = "0x200071D")]
	[GenerateCleanupMethod]
	public class WorkSceneEmptyDeskPannel : UIPanelExtern, IExternalPanel
	{
		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06002B1A RID: 11034 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002B1B RID: 11035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E9")]
		public CookController ControllerParent
		{
			[Token(Token = "0x6002B1A")]
			[Address(RVA = "0x48B890", Offset = "0x48A290", VA = "0x18048B890")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6002B1B")]
			[Address(RVA = "0x4D2550", Offset = "0x4D0F50", VA = "0x1804D2550")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B1C")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "32")]
		protected override void OnExitExtern()
		{
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B1D")]
		[Address(RVA = "0x590D10", Offset = "0x58F710", VA = "0x180590D10", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B1E")]
		[Address(RVA = "0x555710", Offset = "0x554110", VA = "0x180555710", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B1F")]
		[Address(RVA = "0x590E80", Offset = "0x58F880", VA = "0x180590E80", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B20")]
		[Address(RVA = "0x590CB0", Offset = "0x58F6B0", VA = "0x180590CB0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B21")]
		[Address(RVA = "0x591BE0", Offset = "0x5905E0", VA = "0x180591BE0")]
		private void UpdatePannelElement()
		{
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B22")]
		[Address(RVA = "0x591160", Offset = "0x58FB60", VA = "0x180591160")]
		private void RefreshTrayContent()
		{
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B23")]
		[Address(RVA = "0x591190", Offset = "0x58FB90", VA = "0x180591190")]
		private void ResetOnDesk()
		{
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B24")]
		[Address(RVA = "0x591210", Offset = "0x58FC10", VA = "0x180591210")]
		private void SetOnDesk()
		{
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B25")]
		[Address(RVA = "0x590AE0", Offset = "0x58F4E0", VA = "0x180590AE0")]
		private void Grab()
		{
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B26")]
		[Address(RVA = "0x591690", Offset = "0x590090", VA = "0x180591690")]
		private void Store(Sellable toDeliver)
		{
		}

		// Token: 0x06002B27 RID: 11047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B27")]
		[Address(RVA = "0x410330", Offset = "0x40ED30", VA = "0x180410330", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06002B28 RID: 11048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B28")]
		[Address(RVA = "0x410B60", Offset = "0x40F560", VA = "0x180410B60")]
		public WorkSceneEmptyDeskPannel()
		{
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B29")]
		[Address(RVA = "0x5561C0", Offset = "0x554BC0", VA = "0x1805561C0", Slot = "33")]
		private void Common.UI.IExternalPanel.CloseExternPanel()
		{
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B2B")]
		[Address(RVA = "0x5918F0", Offset = "0x5902F0", VA = "0x1805918F0")]
		[CompilerGenerated]
		private void <OnPanelOpen>g__OnTrayElementSelect|15_0(Sellable data)
		{
		}

		// Token: 0x06002B2C RID: 11052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B2C")]
		[Address(RVA = "0x5918C0", Offset = "0x5902C0", VA = "0x1805918C0")]
		[CompilerGenerated]
		private void <OnPanelOpen>g__OnInvalidTrayElementSubmit|15_1()
		{
		}

		// Token: 0x06002B2D RID: 11053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B2D")]
		[Address(RVA = "0x591A10", Offset = "0x590410", VA = "0x180591A10")]
		[CompilerGenerated]
		private void <OnPanelOpen>g__OnTrayElementSubmit|15_2(Sellable data)
		{
		}

		// Token: 0x0400278F RID: 10127
		[Token(Token = "0x400278F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActionExecutionScheduler m_Scheduler;

		// Token: 0x04002790 RID: 10128
		[Token(Token = "0x4002790")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIButtonSimple m_OnDeskButton;

		// Token: 0x04002791 RID: 10129
		[Token(Token = "0x4002791")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image m_OnDeskVisual;

		// Token: 0x04002792 RID: 10130
		[Token(Token = "0x4002792")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image m_OnDeskVisualOutline;

		// Token: 0x04002793 RID: 10131
		[Token(Token = "0x4002793")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup m_DescriberPannel;

		// Token: 0x04002794 RID: 10132
		[Token(Token = "0x4002794")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup m_DescriberSubPannel;

		// Token: 0x04002795 RID: 10133
		[Token(Token = "0x4002795")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SellableDescriber m_Describer;

		// Token: 0x04002796 RID: 10134
		[Token(Token = "0x4002796")]
		[FieldOffset(Offset = "0xA8")]
		private WorkSceneTrayPannel m_CurrentTray;
	}
}
