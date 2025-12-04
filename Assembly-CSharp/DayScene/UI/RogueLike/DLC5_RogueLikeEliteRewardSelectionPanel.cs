using System;
using System.Collections.Generic;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020003A4 RID: 932
	[Token(Token = "0x20003A4")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeEliteRewardSelectionPanel : UIPanelParam<RogueLikeRunTimeData, RogueLikeRunTimeData.EliteChallengeBase.EliteReward>
	{
		// Token: 0x060014A4 RID: 5284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A4")]
		[Address(RVA = "0x440F80", Offset = "0x43F980", VA = "0x180440F80", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A5")]
		[Address(RVA = "0x441120", Offset = "0x43FB20", VA = "0x180441120", Slot = "32")]
		protected override void OnPanelOpen(RogueLikeRunTimeData openParam)
		{
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A6")]
		[Address(RVA = "0x440EA0", Offset = "0x43F8A0", VA = "0x180440EA0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014A7")]
		[Address(RVA = "0x4417F0", Offset = "0x4401F0", VA = "0x1804417F0")]
		public DLC5_RogueLikeEliteRewardSelectionPanel()
		{
		}

		// Token: 0x04001348 RID: 4936
		[Token(Token = "0x4001348")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TextMeshProUGUI m_EliteTitleName;

		// Token: 0x04001349 RID: 4937
		[Token(Token = "0x4001349")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject m_EliteReward;

		// Token: 0x0400134A RID: 4938
		[Token(Token = "0x400134A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform m_EliteRewardRectTransform;

		// Token: 0x0400134B RID: 4939
		[Token(Token = "0x400134B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIButtonSimple m_PoolButton;

		// Token: 0x0400134C RID: 4940
		[Token(Token = "0x400134C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private DLC5_RogueLikeExtraMenuSubPanel m_ExtraMenuSubPanelForRewardSelector;

		// Token: 0x0400134D RID: 4941
		[Token(Token = "0x400134D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private int m_ExtraMenuSubPanelForRewardSelectorOffset;

		// Token: 0x0400134E RID: 4942
		[Token(Token = "0x400134E")]
		[FieldOffset(Offset = "0xB8")]
		private readonly List<GameObject> m_RewardInstance;

		// Token: 0x0400134F RID: 4943
		[Token(Token = "0x400134F")]
		[FieldOffset(Offset = "0xC0")]
		private UILogicalGroupT<RogueLikeRunTimeData.EliteChallengeBase.EliteRewardType> m_UILogicalGroup;
	}
}
