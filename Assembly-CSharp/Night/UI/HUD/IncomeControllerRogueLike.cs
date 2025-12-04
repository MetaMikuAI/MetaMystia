using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DayScene.UI.RogueLike;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using NightScene.UI.HUDUtility;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Night.UI.HUD
{
	// Token: 0x0200010E RID: 270
	[Token(Token = "0x200010E")]
	public class IncomeControllerRogueLike : IncomeController
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x00003888 File Offset: 0x00001A88
		// (set) Token: 0x0600067C RID: 1660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000076")]
		public bool SetPoolCanNotActive
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x409E30", Offset = "0x408830", VA = "0x180409E30")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x409E60", Offset = "0x408860", VA = "0x180409E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000077")]
		public int TargetRequirement
		{
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x6EC9D0", Offset = "0x6EB3D0", VA = "0x1806EC9D0")]
			set
			{
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x6EB960", Offset = "0x6EA360", VA = "0x1806EB960", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x6EC100", Offset = "0x6EAB00", VA = "0x1806EC100")]
		public void SetPoolActiveInst()
		{
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x6EC0F0", Offset = "0x6EAAF0", VA = "0x1806EC0F0")]
		public void SetInPoolActiveInst()
		{
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x6EC120", Offset = "0x6EAB20", VA = "0x1806EC120")]
		public void SetPoolButton(Action onPoolButtonPressed)
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x6EBFC0", Offset = "0x6EA9C0", VA = "0x1806EBFC0")]
		public void SetFinalTarget(TriggerCardCondition triggerCardCondition, int target, bool hasNextLevel)
		{
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x6EBE70", Offset = "0x6EA870", VA = "0x1806EBE70")]
		public void SetFinalTargetAndRefresh(TriggerCardCondition triggerCardCondition, int target, bool hasNextLevel, int current)
		{
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x6EC4F0", Offset = "0x6EAEF0", VA = "0x1806EC4F0")]
		public void UpdateTriggerStatus(TriggerCardCondition triggerCardCondition, int value)
		{
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x6EBD50", Offset = "0x6EA750", VA = "0x1806EBD50", Slot = "6")]
		protected override void OnFundUpdate()
		{
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x6EC3A0", Offset = "0x6EADA0", VA = "0x1806EC3A0")]
		public void UpdateRoundNum(int currentNum, int maxNum)
		{
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x6EC320", Offset = "0x6EAD20", VA = "0x1806EC320")]
		public void Settle()
		{
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x6EC2D0", Offset = "0x6EACD0", VA = "0x1806EC2D0")]
		public void SetRogueFund(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x6EB830", Offset = "0x6EA230", VA = "0x1806EB830")]
		public GameObject ActiveRogueBossDescrption(RogueLikeRunTimeData.EliteChallengeBase challengeBase)
		{
			return null;
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x6EB950", Offset = "0x6EA350", VA = "0x1806EB950")]
		public void HideBossDescription()
		{
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public IncomeControllerRogueLike()
		{
		}

		// Token: 0x04000669 RID: 1641
		[Token(Token = "0x4000669")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI m_TargetIncomeValue;

		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image m_Progress;

		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image m_CompletionMark;

		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private IncomeControllerRogueLike.TriggerTitle[] m_TriggerTitleMapping;

		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color m_TriggerFinishColor;

		// Token: 0x0400066E RID: 1646
		[Token(Token = "0x400066E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TextMeshProUGUI m_RoundWave;

		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400066F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public UIButtonSimple m_PoolButton;

		// Token: 0x04000670 RID: 1648
		[Token(Token = "0x4000670")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup m_PoolCanvasGroup;

		// Token: 0x04000671 RID: 1649
		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup m_FinalFundCanvasGroup;

		// Token: 0x04000672 RID: 1650
		[Token(Token = "0x4000672")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup m_WorkFundCanvasGroup;

		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x4000673")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshProUGUI m_FinalFund;

		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private CanvasGroup m_BossDesCanvasGroup;

		// Token: 0x04000675 RID: 1653
		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0x90")]
		private int m_TargetRequirement;

		// Token: 0x04000676 RID: 1654
		[Token(Token = "0x4000676")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<TriggerCardCondition, IncomeControllerRogueLike.TriggerTitle> m_TriggerTitlesDic;

		// Token: 0x04000677 RID: 1655
		[Token(Token = "0x4000677")]
		[FieldOffset(Offset = "0xA0")]
		[TupleElementNames(new string[] { "Target", "LastTarget", "HasNextLevel" })]
		private Dictionary<TriggerCardCondition, ValueTuple<int, int, bool>> m_TriggerFinalTarget;

		// Token: 0x0200010F RID: 271
		[Token(Token = "0x200010F")]
		[Serializable]
		public struct TriggerTitle
		{
			// Token: 0x04000679 RID: 1657
			[Token(Token = "0x4000679")]
			[FieldOffset(Offset = "0x0")]
			public TriggerCardCondition TriggerCondition;

			// Token: 0x0400067A RID: 1658
			[Token(Token = "0x400067A")]
			[FieldOffset(Offset = "0x8")]
			public UIElementCluster UIElementCluster;
		}
	}
}
