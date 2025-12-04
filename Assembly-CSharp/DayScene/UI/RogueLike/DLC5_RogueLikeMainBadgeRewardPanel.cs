using System;
using System.Collections.Generic;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using Plugins.DEYU;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020003AC RID: 940
	[Token(Token = "0x20003AC")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeMainBadgeRewardPanel : UIPanelParamOpen<RogueLikeAchievementRunTimeData>
	{
		// Token: 0x060014D3 RID: 5331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D3")]
		[Address(RVA = "0x443060", Offset = "0x441A60", VA = "0x180443060", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D4")]
		[Address(RVA = "0x4433D0", Offset = "0x441DD0", VA = "0x1804433D0", Slot = "32")]
		protected override void OnPanelOpen(RogueLikeAchievementRunTimeData openParam)
		{
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D5")]
		[Address(RVA = "0x443540", Offset = "0x441F40", VA = "0x180443540")]
		private void SortBadgeList()
		{
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D6")]
		[Address(RVA = "0x443B40", Offset = "0x442540", VA = "0x180443B40")]
		private void UpdateRemainingBadge()
		{
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D7")]
		[Address(RVA = "0x442EE0", Offset = "0x4418E0", VA = "0x180442EE0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014D8")]
		[Address(RVA = "0x443D80", Offset = "0x442780", VA = "0x180443D80")]
		public DLC5_RogueLikeMainBadgeRewardPanel()
		{
		}

		// Token: 0x0400136C RID: 4972
		[Token(Token = "0x400136C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GridLayoutGroup m_BadgeViewerGridContent;

		// Token: 0x0400136D RID: 4973
		[Token(Token = "0x400136D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject m_BadgeElement;

		// Token: 0x0400136E RID: 4974
		[Token(Token = "0x400136E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image m_BadgeImage;

		// Token: 0x0400136F RID: 4975
		[Token(Token = "0x400136F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup m_BadgeDescriberCanvasGroup;

		// Token: 0x04001370 RID: 4976
		[Token(Token = "0x4001370")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TextMeshProUGUI m_BadgeNameText;

		// Token: 0x04001371 RID: 4977
		[Token(Token = "0x4001371")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TextMeshProUGUI m_BadgeDescriptionText;

		// Token: 0x04001372 RID: 4978
		[Token(Token = "0x4001372")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private TextMeshProUGUI m_BadgeCollectRateText;

		// Token: 0x04001373 RID: 4979
		[Token(Token = "0x4001373")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_BadgeScroller;

		// Token: 0x04001374 RID: 4980
		[Token(Token = "0x4001374")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private ActionExecutionScheduler m_ActionExecutionScheduler;

		// Token: 0x04001375 RID: 4981
		[Token(Token = "0x4001375")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIButtonSimple m_ClaimButton;

		// Token: 0x04001376 RID: 4982
		[Token(Token = "0x4001376")]
		[FieldOffset(Offset = "0xC8")]
		private readonly List<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> m_GetBadgeList;

		// Token: 0x04001377 RID: 4983
		[Token(Token = "0x4001377")]
		[FieldOffset(Offset = "0xD0")]
		private readonly List<DLC5_RogueLikeDataProfile.RogueLikeAchievement> m_RemainingBadges;

		// Token: 0x04001378 RID: 4984
		[Token(Token = "0x4001378")]
		[FieldOffset(Offset = "0xD8")]
		private HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> m_RemainingBadgesType;

		// Token: 0x04001379 RID: 4985
		[Token(Token = "0x4001379")]
		[FieldOffset(Offset = "0xE0")]
		private StaticVerticalGridScrollListUILogicalGroupT<DLC5_RogueLikeDataProfile.RogueLikeAchievementType, UIElementCluster, UIButtonSimple> m_AchievementGroup;

		// Token: 0x0400137A RID: 4986
		[Token(Token = "0x400137A")]
		[FieldOffset(Offset = "0xE8")]
		private readonly Color shadowColor;
	}
}
