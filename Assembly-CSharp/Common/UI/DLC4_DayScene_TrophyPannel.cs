using System;
using System.Collections.Generic;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000E37 RID: 3639
	[Token(Token = "0x2000E37")]
	[GenerateCleanupMethod]
	public class DLC4_DayScene_TrophyPannel : UIPanel
	{
		// Token: 0x0600550D RID: 21773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600550D")]
		[Address(RVA = "0x833B50", Offset = "0x832550", VA = "0x180833B50", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x0600550E RID: 21774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600550E")]
		[Address(RVA = "0x833B80", Offset = "0x832580", VA = "0x180833B80", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x0600550F RID: 21775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600550F")]
		[Address(RVA = "0x833830", Offset = "0x832230", VA = "0x180833830")]
		private void OnElementEnabled(TrophiesProfile.Trophy trophyInfo, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x06005510 RID: 21776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005510")]
		[Address(RVA = "0x833920", Offset = "0x832320", VA = "0x180833920")]
		private void OnElementSelected(TrophiesProfile.Trophy trophyInfo, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x06005511 RID: 21777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005511")]
		[Address(RVA = "0x833AF0", Offset = "0x8324F0", VA = "0x180833AF0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06005512 RID: 21778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005512")]
		[Address(RVA = "0x833720", Offset = "0x832120", VA = "0x180833720", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005513 RID: 21779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005513")]
		[Address(RVA = "0x834280", Offset = "0x832C80", VA = "0x180834280")]
		public DLC4_DayScene_TrophyPannel()
		{
		}

		// Token: 0x04004FEA RID: 20458
		[Token(Token = "0x4004FEA")]
		private const string HIDE_TROPHY_TIP = "DLC4_FISHINGTROPHY_NOTGET";

		// Token: 0x04004FEB RID: 20459
		[Token(Token = "0x4004FEB")]
		[FieldOffset(Offset = "0x70")]
		public GameObject itemElement;

		// Token: 0x04004FEC RID: 20460
		[Token(Token = "0x4004FEC")]
		[FieldOffset(Offset = "0x78")]
		public ObjectLanguageBaseDescriber itemDescrier;

		// Token: 0x04004FED RID: 20461
		[Token(Token = "0x4004FED")]
		[FieldOffset(Offset = "0x80")]
		public GridLayoutGroup itemPannel;

		// Token: 0x04004FEE RID: 20462
		[Token(Token = "0x4004FEE")]
		[FieldOffset(Offset = "0x88")]
		public AdpProgressIndicatorComponent scroller;

		// Token: 0x04004FEF RID: 20463
		[Token(Token = "0x4004FEF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject m_VisualObject;

		// Token: 0x04004FF0 RID: 20464
		[Token(Token = "0x4004FF0")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TextMeshProUGUI m_DescriptionTitle;

		// Token: 0x04004FF1 RID: 20465
		[Token(Token = "0x4004FF1")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TextMeshProUGUI m_DescriptionDetail;

		// Token: 0x04004FF2 RID: 20466
		[Token(Token = "0x4004FF2")]
		[FieldOffset(Offset = "0xA8")]
		private readonly List<TrophiesProfile.Trophy> m_TrophyList;

		// Token: 0x04004FF3 RID: 20467
		[Token(Token = "0x4004FF3")]
		[FieldOffset(Offset = "0xB0")]
		private StaticVerticalGridScrollListUILogicalGroupT<TrophiesProfile.Trophy, UIElementCluster, UIButtonSimple> m_TrophyGroup;

		// Token: 0x04004FF4 RID: 20468
		[Token(Token = "0x4004FF4")]
		[FieldOffset(Offset = "0xB8")]
		private HashSet<int> myTrophies;

		// Token: 0x04004FF5 RID: 20469
		[Token(Token = "0x4004FF5")]
		[FieldOffset(Offset = "0xC0")]
		private readonly Color shadowColor;
	}
}
