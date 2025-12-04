using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI.Story
{
	// Token: 0x02000F64 RID: 3940
	[Token(Token = "0x2000F64")]
	[GenerateCleanupMethod]
	public class EventToutetsuYuumaTutorialSubPanel : UIPanelParam<ValueTuple<bool, bool>, EventToutetsuYuumaTutorialSubPanel.PannelCloseType>
	{
		// Token: 0x06005CA8 RID: 23720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA8")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005CA9 RID: 23721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA9")]
		[Address(RVA = "0x8AC120", Offset = "0x8AAB20", VA = "0x1808AC120", Slot = "32")]
		protected override void OnPanelOpen(ValueTuple<bool, bool> openParam)
		{
		}

		// Token: 0x06005CAA RID: 23722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CAA")]
		[Address(RVA = "0x574C10", Offset = "0x573610", VA = "0x180574C10", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005CAB RID: 23723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CAB")]
		[Address(RVA = "0x8AC400", Offset = "0x8AAE00", VA = "0x1808AC400")]
		public EventToutetsuYuumaTutorialSubPanel()
		{
		}

		// Token: 0x040055CB RID: 21963
		[Token(Token = "0x40055CB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIButtonSimple m_GoBackBtn;

		// Token: 0x040055CC RID: 21964
		[Token(Token = "0x40055CC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIButtonSimple m_GoNextBtn;

		// Token: 0x040055CD RID: 21965
		[Token(Token = "0x40055CD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TextMeshProUGUI m_GoNextBtnText;

		// Token: 0x02000F65 RID: 3941
		[Token(Token = "0x2000F65")]
		public enum PannelCloseType
		{
			// Token: 0x040055CF RID: 21967
			[Token(Token = "0x40055CF")]
			Back,
			// Token: 0x040055D0 RID: 21968
			[Token(Token = "0x40055D0")]
			Next
		}
	}
}
