using System;
using System.Collections.Generic;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020003A0 RID: 928
	[Token(Token = "0x20003A0")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeEliteIntroductionPanel : UISubPanelParamOpen<DLC5_RogueLikeSpotSelectionPanel_New, DLC5_RogueLikeEliteIntroductionPanel.OpenContext>
	{
		// Token: 0x06001495 RID: 5269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001495")]
		[Address(RVA = "0x4406A0", Offset = "0x43F0A0", VA = "0x1804406A0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001496")]
		[Address(RVA = "0x4406F0", Offset = "0x43F0F0", VA = "0x1804406F0", Slot = "32")]
		protected override void OnPanelOpen(DLC5_RogueLikeEliteIntroductionPanel.OpenContext openParam)
		{
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001497")]
		[Address(RVA = "0x4405D0", Offset = "0x43EFD0", VA = "0x1804405D0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001498")]
		[Address(RVA = "0x440E00", Offset = "0x43F800", VA = "0x180440E00")]
		public DLC5_RogueLikeEliteIntroductionPanel()
		{
		}

		// Token: 0x0400133A RID: 4922
		[Token(Token = "0x400133A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TextMeshProUGUI m_EliteTitleName;

		// Token: 0x0400133B RID: 4923
		[Token(Token = "0x400133B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TextMeshProUGUI m_EliteDes;

		// Token: 0x0400133C RID: 4924
		[Token(Token = "0x400133C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject m_EliteReward;

		// Token: 0x0400133D RID: 4925
		[Token(Token = "0x400133D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform m_EliteRewardRectTransform;

		// Token: 0x0400133E RID: 4926
		[Token(Token = "0x400133E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIElementCluster m_Cluster;

		// Token: 0x0400133F RID: 4927
		[Token(Token = "0x400133F")]
		[FieldOffset(Offset = "0xB8")]
		private readonly List<GameObject> m_RewardInstance;

		// Token: 0x020003A1 RID: 929
		[Token(Token = "0x20003A1")]
		public struct OpenContext
		{
			// Token: 0x06001499 RID: 5273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001499")]
			[Address(RVA = "0x44F260", Offset = "0x44DC60", VA = "0x18044F260")]
			public OpenContext(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel)
			{
			}

			// Token: 0x04001340 RID: 4928
			[Token(Token = "0x4001340")]
			[FieldOffset(Offset = "0x0")]
			public RogueLikeRunTimeData RogueLikeRunTimeData;

			// Token: 0x04001341 RID: 4929
			[Token(Token = "0x4001341")]
			[FieldOffset(Offset = "0x8")]
			public RogueLikeRunTimeData.EliteChallengeCache EliteChallengeCache;

			// Token: 0x04001342 RID: 4930
			[Token(Token = "0x4001342")]
			[FieldOffset(Offset = "0x10")]
			public string MapLabel;
		}
	}
}
