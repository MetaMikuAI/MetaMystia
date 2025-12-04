using System;
using System.Collections.Generic;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.CreatorsBox
{
	// Token: 0x02000F93 RID: 3987
	[Token(Token = "0x2000F93")]
	[GenerateCleanupMethod]
	public class DLC5_SpecialGuestSelectionPanel : UIPanelParam<DLC5_SpecialGuestSelectionPanel.OpenContext, SpecialGuest>
	{
		// Token: 0x06005DB3 RID: 23987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB3")]
		[Address(RVA = "0x8A88E0", Offset = "0x8A72E0", VA = "0x1808A88E0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005DB4 RID: 23988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB4")]
		[Address(RVA = "0x8A8BD0", Offset = "0x8A75D0", VA = "0x1808A8BD0", Slot = "32")]
		protected override void OnPanelOpen(DLC5_SpecialGuestSelectionPanel.OpenContext openParam)
		{
		}

		// Token: 0x06005DB5 RID: 23989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB5")]
		[Address(RVA = "0x8A8850", Offset = "0x8A7250", VA = "0x1808A8850", Slot = "33")]
		protected override void OnPanelClose(SpecialGuest closeParam)
		{
		}

		// Token: 0x06005DB6 RID: 23990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB6")]
		[Address(RVA = "0x8A8760", Offset = "0x8A7160", VA = "0x1808A8760", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005DB7 RID: 23991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB7")]
		[Address(RVA = "0x8A95D0", Offset = "0x8A7FD0", VA = "0x1808A95D0")]
		public DLC5_SpecialGuestSelectionPanel()
		{
		}

		// Token: 0x040056D9 RID: 22233
		[Token(Token = "0x40056D9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GridLayoutGroup m_Grid;

		// Token: 0x040056DA RID: 22234
		[Token(Token = "0x40056DA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIElementCluster m_Prefab;

		// Token: 0x040056DB RID: 22235
		[Token(Token = "0x40056DB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_ProgressIndicator;

		// Token: 0x040056DC RID: 22236
		[Token(Token = "0x40056DC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private CanvasGroup m_NullPanel;

		// Token: 0x040056DD RID: 22237
		[Token(Token = "0x40056DD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private CanvasGroup m_DescriberPanel;

		// Token: 0x040056DE RID: 22238
		[Token(Token = "0x40056DE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Sprite m_Fallback;

		// Token: 0x040056DF RID: 22239
		[Token(Token = "0x40056DF")]
		[FieldOffset(Offset = "0xB8")]
		private readonly List<SpecialGuest> m_SpecialGuests;

		// Token: 0x040056E0 RID: 22240
		[Token(Token = "0x40056E0")]
		[FieldOffset(Offset = "0xC0")]
		private StaticVerticalGridScrollListUILogicalGroupT<SpecialGuest, UIElementCluster, UIButtonSimple> m_SpecialGuestGroup;

		// Token: 0x02000F94 RID: 3988
		[Token(Token = "0x2000F94")]
		public struct OpenContext
		{
			// Token: 0x06005DBB RID: 23995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DBB")]
			[Address(RVA = "0x40C360", Offset = "0x40AD60", VA = "0x18040C360")]
			public OpenContext(IReadOnlyList<SpecialGuest> selections, SpecialGuest defaultSelection)
			{
			}

			// Token: 0x040056E1 RID: 22241
			[Token(Token = "0x40056E1")]
			[FieldOffset(Offset = "0x0")]
			public readonly IReadOnlyList<SpecialGuest> Selections;

			// Token: 0x040056E2 RID: 22242
			[Token(Token = "0x40056E2")]
			[FieldOffset(Offset = "0x8")]
			public readonly SpecialGuest DefaultSelection;
		}
	}
}
