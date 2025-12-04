using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using NightScene;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020003BE RID: 958
	[Token(Token = "0x20003BE")]
	public class DLC5_RogueLikeNewGamePanel : UISubPanel<DLC5_RogueLikeMainPanel>
	{
		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x00008118 File Offset: 0x00006318
		// (set) Token: 0x0600152B RID: 5419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700027B")]
		public NightSceneDirector.Difficulty Difficulty
		{
			[Token(Token = "0x600152A")]
			[Address(RVA = "0x43AEF0", Offset = "0x4398F0", VA = "0x18043AEF0")]
			[CompilerGenerated]
			get
			{
				return NightSceneDirector.Difficulty.None;
			}
			[Token(Token = "0x600152B")]
			[Address(RVA = "0x448380", Offset = "0x446D80", VA = "0x180448380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x00008130 File Offset: 0x00006330
		// (set) Token: 0x0600152D RID: 5421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700027C")]
		public DLC5_RogueLikeNewGamePanel.CloseContext PanelCloseContext
		{
			[Token(Token = "0x600152C")]
			[Address(RVA = "0x409CD0", Offset = "0x4086D0", VA = "0x180409CD0")]
			[CompilerGenerated]
			get
			{
				return DLC5_RogueLikeNewGamePanel.CloseContext.Back;
			}
			[Token(Token = "0x600152D")]
			[Address(RVA = "0x409D10", Offset = "0x408710", VA = "0x180409D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x00008148 File Offset: 0x00006348
		// (set) Token: 0x0600152F RID: 5423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700027D")]
		public bool IsFirstOpen
		{
			[Token(Token = "0x600152E")]
			[Address(RVA = "0x448370", Offset = "0x446D70", VA = "0x180448370")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x600152F")]
			[Address(RVA = "0x448390", Offset = "0x446D90", VA = "0x180448390")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001530")]
		[Address(RVA = "0x447250", Offset = "0x445C50", VA = "0x180447250", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001531")]
		[Address(RVA = "0x4470B0", Offset = "0x445AB0", VA = "0x1804470B0")]
		private void BackToPrevious()
		{
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001532")]
		[Address(RVA = "0x447180", Offset = "0x445B80", VA = "0x180447180")]
		private void GoToNext()
		{
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001533")]
		[Address(RVA = "0x448030", Offset = "0x446A30", VA = "0x180448030")]
		private void UpdateVisual()
		{
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001534")]
		[Address(RVA = "0x4478A0", Offset = "0x4462A0", VA = "0x1804478A0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001535")]
		[Address(RVA = "0x448330", Offset = "0x446D30", VA = "0x180448330")]
		public DLC5_RogueLikeNewGamePanel()
		{
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600153B")]
		[Address(RVA = "0x447DF0", Offset = "0x4467F0", VA = "0x180447DF0")]
		[CompilerGenerated]
		private void <OnPanelInitialize>g__OverrideDifficultyMoveAction|24_5(MoveDirection moveDirection)
		{
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600153C")]
		[Address(RVA = "0x448020", Offset = "0x446A20", VA = "0x180448020")]
		[CompilerGenerated]
		private void <OnPanelInitialize>g__ToggleToLevel|24_6(NightSceneDirector.Difficulty difficulty)
		{
		}

		// Token: 0x040013DE RID: 5086
		[Token(Token = "0x40013DE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TextMeshProUGUI m_CurrentDifficultyTargetText;

		// Token: 0x040013DF RID: 5087
		[Token(Token = "0x40013DF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshProUGUI m_CurrentIndexText;

		// Token: 0x040013E0 RID: 5088
		[Token(Token = "0x40013E0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIButtonHold m_StartBtn;

		// Token: 0x040013E1 RID: 5089
		[Token(Token = "0x40013E1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIButtonSimple m_PerviousBtn;

		// Token: 0x040013E2 RID: 5090
		[Token(Token = "0x40013E2")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIButtonSimple m_NextBtn;

		// Token: 0x040013E3 RID: 5091
		[Token(Token = "0x40013E3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIButtonToggle EasyBtn;

		// Token: 0x040013E4 RID: 5092
		[Token(Token = "0x40013E4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIButtonToggle NormalBtn;

		// Token: 0x040013E5 RID: 5093
		[Token(Token = "0x40013E5")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIButtonToggle HardBtn;

		// Token: 0x040013E6 RID: 5094
		[Token(Token = "0x40013E6")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIButtonToggle LunaticBtn;

		// Token: 0x040013EA RID: 5098
		[Token(Token = "0x40013EA")]
		[FieldOffset(Offset = "0xD0")]
		private UIButtonToggle[] m_AllToggles;

		// Token: 0x040013EB RID: 5099
		[Token(Token = "0x40013EB")]
		[FieldOffset(Offset = "0xD8")]
		private int m_CurrentViewRoundIndex;

		// Token: 0x020003BF RID: 959
		[Token(Token = "0x20003BF")]
		public enum CloseContext
		{
			// Token: 0x040013ED RID: 5101
			[Token(Token = "0x40013ED")]
			Back,
			// Token: 0x040013EE RID: 5102
			[Token(Token = "0x40013EE")]
			Start
		}
	}
}
