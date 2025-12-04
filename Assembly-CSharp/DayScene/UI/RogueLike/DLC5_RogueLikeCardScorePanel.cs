using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000372 RID: 882
	[Token(Token = "0x2000372")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeCardScorePanel : UIPanelParamOpen<List<DLC5_RogueLikeCardScorePanel.CardScorePair>>
	{
		// Token: 0x0600138D RID: 5005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600138D")]
		[Address(RVA = "0x43DAC0", Offset = "0x43C4C0", VA = "0x18043DAC0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600138E")]
		[Address(RVA = "0x43DB80", Offset = "0x43C580", VA = "0x18043DB80", Slot = "32")]
		protected override void OnPanelOpen(List<DLC5_RogueLikeCardScorePanel.CardScorePair> openParam)
		{
		}

		// Token: 0x0600138F RID: 5007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600138F")]
		[Address(RVA = "0x43D9C0", Offset = "0x43C3C0", VA = "0x18043D9C0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001390")]
		[Address(RVA = "0x43E4B0", Offset = "0x43CEB0", VA = "0x18043E4B0")]
		public DLC5_RogueLikeCardScorePanel()
		{
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001391")]
		[Address(RVA = "0x43E320", Offset = "0x43CD20", VA = "0x18043E320")]
		[CompilerGenerated]
		internal static void <OnPanelOpen>g__OnElementEnabled|10_2(UIElementCluster cluster, ValueTuple<DLC5_RogueLikeCardScorePanel.CardScorePair, bool> cardScorePairProperty)
		{
		}

		// Token: 0x040011C7 RID: 4551
		[Token(Token = "0x40011C7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIButtonSimple m_ContinueButton;

		// Token: 0x040011C8 RID: 4552
		[Token(Token = "0x40011C8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshProUGUI m_ScoreValueText;

		// Token: 0x040011C9 RID: 4553
		[Token(Token = "0x40011C9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject m_ScoreTypeSucceedElement;

		// Token: 0x040011CA RID: 4554
		[Token(Token = "0x40011CA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform m_ScoreTypeSucceedParent;

		// Token: 0x040011CB RID: 4555
		[Token(Token = "0x40011CB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject m_ScoreTypeFailedElement;

		// Token: 0x040011CC RID: 4556
		[Token(Token = "0x40011CC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform m_ScoreTypeFailedParent;

		// Token: 0x040011CD RID: 4557
		[Token(Token = "0x40011CD")]
		[FieldOffset(Offset = "0xA8")]
		private readonly List<GameObject> m_SucceedInstance;

		// Token: 0x040011CE RID: 4558
		[Token(Token = "0x40011CE")]
		[FieldOffset(Offset = "0xB0")]
		private readonly List<GameObject> m_FailedInstance;

		// Token: 0x02000373 RID: 883
		[Token(Token = "0x2000373")]
		public struct CardScorePair
		{
			// Token: 0x06001392 RID: 5010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001392")]
			[Address(RVA = "0x43AF00", Offset = "0x439900", VA = "0x18043AF00")]
			public CardScorePair(string label, int score, bool succeed)
			{
			}

			// Token: 0x040011CF RID: 4559
			[Token(Token = "0x40011CF")]
			[FieldOffset(Offset = "0x0")]
			public string Label;

			// Token: 0x040011D0 RID: 4560
			[Token(Token = "0x40011D0")]
			[FieldOffset(Offset = "0x8")]
			public int Score;

			// Token: 0x040011D1 RID: 4561
			[Token(Token = "0x40011D1")]
			[FieldOffset(Offset = "0xC")]
			public bool Succeed;
		}
	}
}
