using System;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000437 RID: 1079
	[Token(Token = "0x2000437")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeWinPanel : UIPanelParam<DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext, DLC5_RogueLikeWinPanel.CloseContext>
	{
		// Token: 0x060017DC RID: 6108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017DC")]
		[Address(RVA = "0x476200", Offset = "0x474C00", VA = "0x180476200", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017DD")]
		[Address(RVA = "0x476400", Offset = "0x474E00", VA = "0x180476400", Slot = "32")]
		protected override void OnPanelOpen(DLC5_RogueLikeWinPanel.RogueConfirmPanelOpenContext openParam)
		{
		}

		// Token: 0x060017DE RID: 6110 RVA: 0x00008DF0 File Offset: 0x00006FF0
		[Token(Token = "0x60017DE")]
		[Address(RVA = "0x4764A0", Offset = "0x474EA0", VA = "0x1804764A0")]
		private UniTask TryClosePanel(DLC5_RogueLikeWinPanel.CloseContext closeContext)
		{
			return default(UniTask);
		}

		// Token: 0x060017DF RID: 6111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017DF")]
		[Address(RVA = "0x4761A0", Offset = "0x474BA0", VA = "0x1804761A0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060017E0 RID: 6112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017E0")]
		[Address(RVA = "0x476630", Offset = "0x475030", VA = "0x180476630")]
		public DLC5_RogueLikeWinPanel()
		{
		}

		// Token: 0x04001672 RID: 5746
		[Token(Token = "0x4001672")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIButtonSimple m_ContinueBtn;

		// Token: 0x04001673 RID: 5747
		[Token(Token = "0x4001673")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIButtonSimple m_SettleBtn;

		// Token: 0x04001674 RID: 5748
		[Token(Token = "0x4001674")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIButtonSimple m_BreakBtn;

		// Token: 0x04001675 RID: 5749
		[Token(Token = "0x4001675")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private DLC5_RogueLikeWinPanel.CloseContext m_FirstSelectBtn;

		// Token: 0x02000438 RID: 1080
		[Token(Token = "0x2000438")]
		public struct RogueConfirmPanelOpenContext
		{
			// Token: 0x060017E4 RID: 6116 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60017E4")]
			[Address(RVA = "0x479230", Offset = "0x477C30", VA = "0x180479230")]
			public RogueConfirmPanelOpenContext(RogueLikeRunTimeData rogueLikeRunTimeData, bool needFadeIn)
			{
			}

			// Token: 0x04001676 RID: 5750
			[Token(Token = "0x4001676")]
			[FieldOffset(Offset = "0x0")]
			public RogueLikeRunTimeData RogueLikeRunTimeData;

			// Token: 0x04001677 RID: 5751
			[Token(Token = "0x4001677")]
			[FieldOffset(Offset = "0x8")]
			public bool NeedFadeIn;
		}

		// Token: 0x02000439 RID: 1081
		[Token(Token = "0x2000439")]
		public enum CloseContext
		{
			// Token: 0x04001679 RID: 5753
			[Token(Token = "0x4001679")]
			Continue,
			// Token: 0x0400167A RID: 5754
			[Token(Token = "0x400167A")]
			Exit,
			// Token: 0x0400167B RID: 5755
			[Token(Token = "0x400167B")]
			Settle
		}
	}
}
