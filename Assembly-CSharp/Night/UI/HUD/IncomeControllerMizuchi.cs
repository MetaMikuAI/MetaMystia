using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppDummyDll;
using NightScene.UI;
using NightScene.UI.HUDUtility;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Night.UI.HUD
{
	// Token: 0x0200010A RID: 266
	[Token(Token = "0x200010A")]
	[GenerateCleanupMethod]
	public class IncomeControllerMizuchi : IncomeControllerBase
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600064C RID: 1612 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x0600064D RID: 1613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000002")]
		public event Action OnMoonEyeActivedCallback
		{
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x6EB6D0", Offset = "0x6EA0D0", VA = "0x1806EB6D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x6EB780", Offset = "0x6EA180", VA = "0x1806EB780")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600064F RID: 1615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000070")]
		public Action OnMoonEyeActivedChangeCallback
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x440500", Offset = "0x43EF00", VA = "0x180440500")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x48AAA0", Offset = "0x4894A0", VA = "0x18048AAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00003840 File Offset: 0x00001A40
		// (set) Token: 0x06000651 RID: 1617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000071")]
		public int MaxValue
		{
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x477F90", Offset = "0x476990", VA = "0x180477F90")]
			[CompilerGenerated]
			private get
			{
				return 0;
			}
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x4D2480", Offset = "0x4D0E80", VA = "0x1804D2480")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x6EB3D0", Offset = "0x6E9DD0", VA = "0x1806EB3D0")]
		public void UpdateInteractable(bool isEnabled)
		{
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x6EA4A0", Offset = "0x6E8EA0", VA = "0x1806EA4A0", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x6EA0F0", Offset = "0x6E8AF0", VA = "0x1806EA0F0")]
		public void AfterInitialized(string title, Sprite pic, bool isTanBuffActive, out CanvasGroup tanBuffCanvasGroup)
		{
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x6EAD50", Offset = "0x6E9750", VA = "0x1806EAD50")]
		public void SetTargetNum(int targetNum)
		{
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x6EAE40", Offset = "0x6E9840", VA = "0x1806EAE40")]
		public void SetTargetProgress(float targetValue)
		{
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x6EADB0", Offset = "0x6E97B0", VA = "0x1806EADB0")]
		public void SetTargetProgressImmediate(float targetValue)
		{
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x6EB3F0", Offset = "0x6E9DF0", VA = "0x1806EB3F0")]
		private void UpdateMoonEyeEnergyCharging()
		{
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x6EA2C0", Offset = "0x6E8CC0", VA = "0x1806EA2C0")]
		private void CallMoonEye()
		{
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x6EB030", Offset = "0x6E9A30", VA = "0x1806EB030")]
		private void TryUpdateData()
		{
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x6EAA50", Offset = "0x6E9450", VA = "0x1806EAA50")]
		private IEnumerator OnUpdateFund()
		{
			return null;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x549440", Offset = "0x547E40", VA = "0x180549440")]
		public void UpdateRemainingNum(int currentNum)
		{
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x6EAC40", Offset = "0x6E9640", VA = "0x1806EAC40")]
		public void SetTargetCatchProgress(int targetValue)
		{
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x6EAAD0", Offset = "0x6E94D0", VA = "0x1806EAAD0")]
		public void SetTargetCatchProgressImmediate(int targetValue)
		{
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x6EAF20", Offset = "0x6E9920", VA = "0x1806EAF20")]
		private void SetTargetTime(float progress)
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x6EB0F0", Offset = "0x6E9AF0", VA = "0x1806EB0F0")]
		private void TryUpdateTimeData()
		{
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x6EB480", Offset = "0x6E9E80", VA = "0x1806EB480")]
		private void UpdateVisual()
		{
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x6EA9D0", Offset = "0x6E93D0", VA = "0x1806EA9D0")]
		private IEnumerator OnUpdateCatchNumProgress()
		{
			return null;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x6EA310", Offset = "0x6E8D10", VA = "0x1806EA310", Slot = "5")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public IncomeControllerMizuchi()
		{
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x6EB240", Offset = "0x6E9C40", VA = "0x1806EB240")]
		[CompilerGenerated]
		private void <Initialize>g__SetTime|37_0(float progress)
		{
		}

		// Token: 0x04000644 RID: 1604
		[Token(Token = "0x4000644")]
		private const int TIME_CHANGE_AMOUNT = 5;

		// Token: 0x04000645 RID: 1605
		[Token(Token = "0x4000645")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIButtonHold m_MoonEyeButtonHold;

		// Token: 0x04000646 RID: 1606
		[Token(Token = "0x4000646")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image m_MoonEyeEnergyImage;

		// Token: 0x04000647 RID: 1607
		[Token(Token = "0x4000647")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image m_MoonEyeEnergyShiningImage;

		// Token: 0x04000648 RID: 1608
		[Token(Token = "0x4000648")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI m_Target;

		// Token: 0x04000649 RID: 1609
		[Token(Token = "0x4000649")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI m_Current;

		// Token: 0x0400064A RID: 1610
		[Token(Token = "0x400064A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TextMeshProUGUI m_Title;

		// Token: 0x0400064B RID: 1611
		[Token(Token = "0x400064B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image m_Pic;

		// Token: 0x0400064C RID: 1612
		[Token(Token = "0x400064C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI m_Remaining;

		// Token: 0x0400064D RID: 1613
		[Token(Token = "0x400064D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup m_CanvasGroup;

		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup m_MoonEyeCanvasGroup;

		// Token: 0x0400064F RID: 1615
		[Token(Token = "0x400064F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup m_TanBuffLockIngredientsCanvasGroup;

		// Token: 0x04000650 RID: 1616
		[Token(Token = "0x4000650")]
		[FieldOffset(Offset = "0x70")]
		public Image progressBar1;

		// Token: 0x04000651 RID: 1617
		[Token(Token = "0x4000651")]
		[FieldOffset(Offset = "0x78")]
		public Image progressBar2;

		// Token: 0x04000652 RID: 1618
		[Token(Token = "0x4000652")]
		[FieldOffset(Offset = "0x80")]
		public Image timeBar;

		// Token: 0x04000653 RID: 1619
		[Token(Token = "0x4000653")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI progressLiteral;

		// Token: 0x04000657 RID: 1623
		[Token(Token = "0x4000657")]
		[FieldOffset(Offset = "0xA4")]
		private int currentProgress;

		// Token: 0x04000658 RID: 1624
		[Token(Token = "0x4000658")]
		[FieldOffset(Offset = "0xA8")]
		private int targetProgress;

		// Token: 0x04000659 RID: 1625
		[Token(Token = "0x4000659")]
		[FieldOffset(Offset = "0xB0")]
		private Coroutine onUpdatingData;

		// Token: 0x0400065A RID: 1626
		[Token(Token = "0x400065A")]
		[FieldOffset(Offset = "0xB8")]
		private Coroutine onUpdatingCatchProgressData;

		// Token: 0x0400065B RID: 1627
		[Token(Token = "0x400065B")]
		[FieldOffset(Offset = "0xC0")]
		private int currentCatchNumProgress;

		// Token: 0x0400065C RID: 1628
		[Token(Token = "0x400065C")]
		[FieldOffset(Offset = "0xC4")]
		private int targetCatchNumProgress;

		// Token: 0x0400065D RID: 1629
		[Token(Token = "0x400065D")]
		[FieldOffset(Offset = "0xC8")]
		private int maxValue;

		// Token: 0x0400065E RID: 1630
		[Token(Token = "0x400065E")]
		[FieldOffset(Offset = "0xD0")]
		private WorkSceneSustainedPannel m_SustainedPannel;

		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x400065F")]
		[FieldOffset(Offset = "0xD8")]
		private CanvasGroup m_SustainedCanvasGroup;

		// Token: 0x04000660 RID: 1632
		[Token(Token = "0x4000660")]
		private const int CHANGE_AMOUNT = 5;
	}
}
