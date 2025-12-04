using System;
using Common.UI.GlobalMap;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000422 RID: 1058
	[Token(Token = "0x2000422")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeSpotSelectionPanelEliteTipPanel : UIPanelParamOpen<IGuideMapSpot>
	{
		// Token: 0x06001770 RID: 6000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001770")]
		[Address(RVA = "0x464520", Offset = "0x462F20", VA = "0x180464520", Slot = "32")]
		protected override void OnPanelOpen(IGuideMapSpot openParam)
		{
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001771")]
		[Address(RVA = "0x4644B0", Offset = "0x462EB0", VA = "0x1804644B0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001772")]
		[Address(RVA = "0x464960", Offset = "0x463360", VA = "0x180464960")]
		public DLC5_RogueLikeSpotSelectionPanelEliteTipPanel()
		{
		}

		// Token: 0x040015F1 RID: 5617
		[Token(Token = "0x40015F1")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform m_MaskRect;

		// Token: 0x040015F2 RID: 5618
		[Token(Token = "0x40015F2")]
		[FieldOffset(Offset = "0x80")]
		public RectTransform m_TextRect;

		// Token: 0x040015F3 RID: 5619
		[Token(Token = "0x40015F3")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI m_Text;

		// Token: 0x040015F4 RID: 5620
		[Token(Token = "0x40015F4")]
		[FieldOffset(Offset = "0x90")]
		public Animator m_StartAnim;

		// Token: 0x040015F5 RID: 5621
		[Token(Token = "0x40015F5")]
		private const string DLC5_ROGUELIKE_SPECIAL_ELITE_ACTIVE = "DLC5_ROGUELIKE_SPECIAL_ELITE_ACTIVE";
	}
}
