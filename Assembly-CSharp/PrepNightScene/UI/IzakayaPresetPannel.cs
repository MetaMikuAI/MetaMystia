using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace PrepNightScene.UI
{
	// Token: 0x020000D7 RID: 215
	[Token(Token = "0x20000D7")]
	[GenerateCleanupMethod]
	public class IzakayaPresetPannel : UISubPanel<IzakayaConfigSubPannel>
	{
		// Token: 0x0600047F RID: 1151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x56D680", Offset = "0x56C080", VA = "0x18056D680", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x56D520", Offset = "0x56BF20", VA = "0x18056D520")]
		private void OnMove(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x56DCD0", Offset = "0x56C6D0", VA = "0x18056DCD0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x56D620", Offset = "0x56C020", VA = "0x18056D620", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x56EF40", Offset = "0x56D940", VA = "0x18056EF40")]
		private void UpdateVisual()
		{
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x56DF10", Offset = "0x56C910", VA = "0x18056DF10")]
		private void OpenSubMenu(int index, PlayerSaveFile.HistoryIzakayaMenuSelection data)
		{
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x56DD90", Offset = "0x56C790", VA = "0x18056DD90")]
		private void OnSubMenuExit(int index, PlayerSaveFile.HistoryIzakayaMenuSelection data, IzakayaPresetSubPannel.PannelCloseContext closeType)
		{
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x56CF70", Offset = "0x56B970", VA = "0x18056CF70")]
		private void AddNewPreset()
		{
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x56D2C0", Offset = "0x56BCC0", VA = "0x18056D2C0")]
		private void CleanDetail()
		{
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x56E070", Offset = "0x56CA70", VA = "0x18056E070")]
		private void PrintDetail(PlayerSaveFile.HistoryIzakayaMenuSelection data)
		{
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x56E650", Offset = "0x56D050", VA = "0x18056E650")]
		private void ProcessDetail(UIElementCluster component, Cooker cooker)
		{
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x56E700", Offset = "0x56D100", VA = "0x18056E700")]
		private void ProcessDetail(UIElementCluster component, [TupleElementNames(new string[] { "Visual", "Num" })] ValueTuple<Sprite, int> property)
		{
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x56D340", Offset = "0x56BD40", VA = "0x18056D340", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x56F0D0", Offset = "0x56DAD0", VA = "0x18056F0D0")]
		public IzakayaPresetPannel()
		{
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x56EED0", Offset = "0x56D8D0", VA = "0x18056EED0")]
		[CompilerGenerated]
		private void <OnPanelInitialize>g__ToggleToLevel|19_4(int level)
		{
		}

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x78")]
		public AdpProgressIndicatorComponent Scroller;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x80")]
		public GridLayoutGroup Content;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x88")]
		public RectTransform RecipeField;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform BeverageField;

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x98")]
		public RectTransform CookerField;

		// Token: 0x0400049B RID: 1179
		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject ListObjectParent;

		// Token: 0x0400049C RID: 1180
		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject ObjectParent;

		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject ObjectStackParent;

		// Token: 0x0400049E RID: 1182
		[Token(Token = "0x400049E")]
		[FieldOffset(Offset = "0xB8")]
		public UIButtonToggle IzakayaLevel1Btn;

		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0xC0")]
		public UIButtonToggle IzakayaLevel2Btn;

		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0xC8")]
		public UIButtonToggle IzakayaLevel3Btn;

		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0xD0")]
		public IzakayaPresetSubPannel SubPannel;

		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0xD8")]
		private readonly List<GameObject> m_AllBeverageInstances;

		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0xE0")]
		private readonly List<GameObject> m_AllCookerInstances;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0xE8")]
		private readonly List<GameObject> m_AllRecipeInstances;

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0xF0")]
		private readonly List<PlayerSaveFile.HistoryIzakayaMenuSelection?> m_Data;

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0xF8")]
		private UIButtonToggle[] m_AllToggles;

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0x100")]
		private int m_CurrentPreviewingIzakayaLevel;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0x108")]
		private StaticVerticalGridScrollListUILogicalGroupT<PlayerSaveFile.HistoryIzakayaMenuSelection?, UIElementCluster, UIButtonSimple> m_GridControl;
	}
}
