using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020003A7 RID: 935
	[Token(Token = "0x20003A7")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeExtraMenuSubPanel : UIPanelParamOpen<DLC5_RogueLikeExtraMenuSubPanel.OpenContext>
	{
		// Token: 0x060014B2 RID: 5298 RVA: 0x00007F80 File Offset: 0x00006180
		[Token(Token = "0x60014B2")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B3")]
		[Address(RVA = "0x442A30", Offset = "0x441430", VA = "0x180442A30")]
		private void WaitFrameToClose()
		{
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B4")]
		[Address(RVA = "0x441A50", Offset = "0x440450", VA = "0x180441A50", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B5")]
		[Address(RVA = "0x441970", Offset = "0x440370", VA = "0x180441970")]
		private void Exit()
		{
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B6")]
		[Address(RVA = "0x4419E0", Offset = "0x4403E0", VA = "0x1804419E0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B7")]
		[Address(RVA = "0x442000", Offset = "0x440A00", VA = "0x180442000", Slot = "32")]
		protected override void OnPanelOpen(DLC5_RogueLikeExtraMenuSubPanel.OpenContext openContext)
		{
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B8")]
		[Address(RVA = "0x4420E0", Offset = "0x440AE0", VA = "0x1804420E0")]
		private void TryClosePanel(InputAction.CallbackContext _)
		{
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014B9")]
		[Address(RVA = "0x441890", Offset = "0x440290", VA = "0x180441890", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014BA")]
		[Address(RVA = "0x442AD0", Offset = "0x4414D0", VA = "0x180442AD0")]
		public DLC5_RogueLikeExtraMenuSubPanel()
		{
		}

		// Token: 0x04001357 RID: 4951
		[Token(Token = "0x4001357")]
		[FieldOffset(Offset = "0x80")]
		public UIButtonSimple NoteBookBtn;

		// Token: 0x04001358 RID: 4952
		[Token(Token = "0x4001358")]
		[FieldOffset(Offset = "0x88")]
		public UIButtonSimple StorageBtn;

		// Token: 0x04001359 RID: 4953
		[Token(Token = "0x4001359")]
		[FieldOffset(Offset = "0x90")]
		public UIButtonSimple CardBtn;

		// Token: 0x0400135A RID: 4954
		[Token(Token = "0x400135A")]
		[FieldOffset(Offset = "0x98")]
		public UIButtonSimple TutorialBtn;

		// Token: 0x0400135B RID: 4955
		[Token(Token = "0x400135B")]
		[FieldOffset(Offset = "0xA0")]
		public UIButtonSimple SettingBtn;

		// Token: 0x0400135C RID: 4956
		[Token(Token = "0x400135C")]
		[FieldOffset(Offset = "0xA8")]
		public UIButtonSimple ExitBtn;

		// Token: 0x0400135D RID: 4957
		[Token(Token = "0x400135D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private DLC5_RogueLikeWinPanel m_ConfirmPanel;

		// Token: 0x0400135E RID: 4958
		[Token(Token = "0x400135E")]
		[FieldOffset(Offset = "0xB8")]
		public Animator m_StartAnim;

		// Token: 0x0400135F RID: 4959
		[Token(Token = "0x400135F")]
		[FieldOffset(Offset = "0xC0")]
		private UILogicalGroup m_LogicalGroup;

		// Token: 0x04001360 RID: 4960
		[Token(Token = "0x4001360")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_IsOpening;

		// Token: 0x04001361 RID: 4961
		[Token(Token = "0x4001361")]
		[FieldOffset(Offset = "0xC9")]
		private bool m_IsClosing;

		// Token: 0x020003A8 RID: 936
		[Token(Token = "0x20003A8")]
		public readonly struct OpenContext
		{
			// Token: 0x060014C8 RID: 5320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60014C8")]
			[Address(RVA = "0x40C360", Offset = "0x40AD60", VA = "0x18040C360")]
			public OpenContext(RogueLikeRunTimeData rogueLikeRunTimeData, Action<DLC5_RogueLikeExtraMenuSubPanel.CloseContext> closeParentCallback)
			{
			}

			// Token: 0x04001362 RID: 4962
			[Token(Token = "0x4001362")]
			[FieldOffset(Offset = "0x0")]
			public readonly RogueLikeRunTimeData RogueLikeRunTimeData;

			// Token: 0x04001363 RID: 4963
			[Token(Token = "0x4001363")]
			[FieldOffset(Offset = "0x8")]
			public readonly Action<DLC5_RogueLikeExtraMenuSubPanel.CloseContext> CloseParentCallback;
		}

		// Token: 0x020003A9 RID: 937
		[Token(Token = "0x20003A9")]
		public enum CloseContext
		{
			// Token: 0x04001365 RID: 4965
			[Token(Token = "0x4001365")]
			Norm,
			// Token: 0x04001366 RID: 4966
			[Token(Token = "0x4001366")]
			ExitRogueMode,
			// Token: 0x04001367 RID: 4967
			[Token(Token = "0x4001367")]
			BackToMenu
		}
	}
}
