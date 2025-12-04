using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.CreatorsBox
{
	// Token: 0x02000F8F RID: 3983
	[Token(Token = "0x2000F8F")]
	[GenerateCleanupMethod]
	public class DLC5_PresetSelectionPanel : UIPanelParam<DLC5_PresetSelectionPanel.OpenContext, Nullable<int>>
	{
		// Token: 0x06005DA8 RID: 23976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA8")]
		[Address(RVA = "0x8A8080", Offset = "0x8A6A80", VA = "0x1808A8080", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005DA9 RID: 23977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DA9")]
		[Address(RVA = "0x8A8240", Offset = "0x8A6C40", VA = "0x1808A8240", Slot = "32")]
		protected override void OnPanelOpen(DLC5_PresetSelectionPanel.OpenContext openParam)
		{
		}

		// Token: 0x06005DAA RID: 23978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005DAA")]
		[Address(RVA = "0x8A8030", Offset = "0x8A6A30", VA = "0x1808A8030")]
		private static UIButtonHold First(UIButtonHold a, UIButtonHold b, UIButtonHold c)
		{
			return null;
		}

		// Token: 0x06005DAB RID: 23979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DAB")]
		[Address(RVA = "0x8A7F60", Offset = "0x8A6960", VA = "0x1808A7F60", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005DAC RID: 23980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DAC")]
		[Address(RVA = "0x8A8720", Offset = "0x8A7120", VA = "0x1808A8720")]
		public DLC5_PresetSelectionPanel()
		{
		}

		// Token: 0x06005DB1 RID: 23985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DB1")]
		[Address(RVA = "0x8A8540", Offset = "0x8A6F40", VA = "0x1808A8540")]
		[CompilerGenerated]
		private void <OnPanelOpen>g__UpdateButtonStatus|10_0(Selectable button, int index, ref DLC5_PresetSelectionPanel.<>c__DisplayClass10_0 A_3)
		{
		}

		// Token: 0x040056C9 RID: 22217
		[Token(Token = "0x40056C9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIButtonHold m_Preset1;

		// Token: 0x040056CA RID: 22218
		[Token(Token = "0x40056CA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIButtonHold m_Preset2;

		// Token: 0x040056CB RID: 22219
		[Token(Token = "0x40056CB")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIButtonHold m_Preset3;

		// Token: 0x040056CC RID: 22220
		[Token(Token = "0x40056CC")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TextMeshProUGUI m_Title;

		// Token: 0x040056CD RID: 22221
		[Token(Token = "0x40056CD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Sprite m_AvailableSprite;

		// Token: 0x040056CE RID: 22222
		[Token(Token = "0x40056CE")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Sprite m_UnavailableSprite;

		// Token: 0x040056CF RID: 22223
		[Token(Token = "0x40056CF")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Sprite m_AvailableSprite_Selected;

		// Token: 0x040056D0 RID: 22224
		[Token(Token = "0x40056D0")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Sprite m_UnavailableSprite_Selected;

		// Token: 0x02000F90 RID: 3984
		[Token(Token = "0x2000F90")]
		public readonly struct OpenContext
		{
			// Token: 0x06005DB2 RID: 23986 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005DB2")]
			[Address(RVA = "0x51BEB0", Offset = "0x51A8B0", VA = "0x18051BEB0")]
			public OpenContext(CreatorBoxData?[] presets, DLC5_PresetSelectionPanel.OpenContext.Mode openMode)
			{
			}

			// Token: 0x040056D1 RID: 22225
			[Token(Token = "0x40056D1")]
			[FieldOffset(Offset = "0x0")]
			public readonly CreatorBoxData?[] Presets;

			// Token: 0x040056D2 RID: 22226
			[Token(Token = "0x40056D2")]
			[FieldOffset(Offset = "0x8")]
			public readonly DLC5_PresetSelectionPanel.OpenContext.Mode OpenMode;

			// Token: 0x02000F91 RID: 3985
			[Token(Token = "0x2000F91")]
			public enum Mode
			{
				// Token: 0x040056D4 RID: 22228
				[Token(Token = "0x40056D4")]
				Read,
				// Token: 0x040056D5 RID: 22229
				[Token(Token = "0x40056D5")]
				Write
			}
		}
	}
}
