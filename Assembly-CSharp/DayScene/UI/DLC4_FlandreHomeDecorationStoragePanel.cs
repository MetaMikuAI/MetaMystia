using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x02000312 RID: 786
	[Token(Token = "0x2000312")]
	[GenerateCleanupMethod]
	public class DLC4_FlandreHomeDecorationStoragePanel : UISubPanel<DLC4_FlandreHomeDecorationStorageTabPanel>
	{
		// Token: 0x060011E7 RID: 4583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011E7")]
		[Address(RVA = "0x93C0E0", Offset = "0x93AAE0", VA = "0x18093C0E0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00006F78 File Offset: 0x00005178
		[Token(Token = "0x60011E8")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011E9")]
		[Address(RVA = "0x93C3B0", Offset = "0x93ADB0", VA = "0x18093C3B0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EA")]
		[Address(RVA = "0x93C000", Offset = "0x93AA00", VA = "0x18093C000", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EB")]
		[Address(RVA = "0x93CDF0", Offset = "0x93B7F0", VA = "0x18093CDF0")]
		private void RefreshPanel(bool shouldRefreshPageNum)
		{
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EC")]
		[Address(RVA = "0x93C960", Offset = "0x93B360", VA = "0x18093C960")]
		private void RefreshPage(bool goToFirstElement)
		{
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011ED")]
		[Address(RVA = "0x93C520", Offset = "0x93AF20", VA = "0x18093C520")]
		private void ProcessFurnitureElement(UIButtonSimple button, FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture)
		{
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EE")]
		[Address(RVA = "0x93C450", Offset = "0x93AE50", VA = "0x18093C450")]
		private void OnSecondaryInput(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011EF")]
		[Address(RVA = "0x93BFB0", Offset = "0x93A9B0", VA = "0x18093BFB0")]
		private void GoToNext(bool goToFirst)
		{
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F0")]
		[Address(RVA = "0x93BE30", Offset = "0x93A830", VA = "0x18093BE30")]
		private void BackToPrevious(bool goToFirst)
		{
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F1")]
		[Address(RVA = "0x93BE70", Offset = "0x93A870", VA = "0x18093BE70", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011F2")]
		[Address(RVA = "0x93D3A0", Offset = "0x93BDA0", VA = "0x18093D3A0")]
		public DLC4_FlandreHomeDecorationStoragePanel()
		{
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x00006F90 File Offset: 0x00005190
		[Token(Token = "0x60011F5")]
		[Address(RVA = "0x93D320", Offset = "0x93BD20", VA = "0x18093D320")]
		[CompilerGenerated]
		private bool <RefreshPanel>g__CheckCondition|19_0(FlandreHomeFurnitureProfile.FlandreHomeFurniture furniture)
		{
			return default(bool);
		}

		// Token: 0x040010A4 RID: 4260
		[Token(Token = "0x40010A4")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject furnitureElement;

		// Token: 0x040010A5 RID: 4261
		[Token(Token = "0x40010A5")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private HorizontalLayoutGroup furnitureContent;

		// Token: 0x040010A6 RID: 4262
		[Token(Token = "0x40010A6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIButtonSimple m_GotoPrevious;

		// Token: 0x040010A7 RID: 4263
		[Token(Token = "0x40010A7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIButtonSimple m_GotoNext;

		// Token: 0x040010A8 RID: 4264
		[Token(Token = "0x40010A8")]
		[FieldOffset(Offset = "0x98")]
		private readonly List<GameObject> allInstances;

		// Token: 0x040010A9 RID: 4265
		[Token(Token = "0x40010A9")]
		[FieldOffset(Offset = "0xA0")]
		private readonly Dictionary<int, List<FlandreHomeFurnitureProfile.FlandreHomeFurniture>> furnitureDic;

		// Token: 0x040010AA RID: 4266
		[Token(Token = "0x40010AA")]
		[FieldOffset(Offset = "0xA8")]
		private int contentWidth;

		// Token: 0x040010AB RID: 4267
		[Token(Token = "0x40010AB")]
		[FieldOffset(Offset = "0xB0")]
		private List<int> currentFurnitureList;

		// Token: 0x040010AC RID: 4268
		[Token(Token = "0x40010AC")]
		[FieldOffset(Offset = "0xB8")]
		private List<FlandreHomeFurnitureProfile.FlandreHomeFurniture> currentPageFurniture;

		// Token: 0x040010AD RID: 4269
		[Token(Token = "0x40010AD")]
		[FieldOffset(Offset = "0xC0")]
		private int currentPageIndex;

		// Token: 0x040010AE RID: 4270
		[Token(Token = "0x40010AE")]
		[FieldOffset(Offset = "0xC4")]
		private DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType currentType;

		// Token: 0x040010AF RID: 4271
		[Token(Token = "0x40010AF")]
		[FieldOffset(Offset = "0xC8")]
		private UILogicalGroupT<int> m_LogicalGroup;

		// Token: 0x040010B0 RID: 4272
		[Token(Token = "0x40010B0")]
		[FieldOffset(Offset = "0xD0")]
		private int maxPage;

		// Token: 0x040010B1 RID: 4273
		[Token(Token = "0x40010B1")]
		[FieldOffset(Offset = "0xD8")]
		private CanvasGroup nextArrowButton;

		// Token: 0x040010B2 RID: 4274
		[Token(Token = "0x40010B2")]
		[FieldOffset(Offset = "0xE0")]
		private CanvasGroup previousArrowButton;
	}
}
