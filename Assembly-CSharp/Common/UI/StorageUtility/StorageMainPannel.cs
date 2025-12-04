using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using Plugins.DEYU;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.StorageUtility
{
	// Token: 0x02000E77 RID: 3703
	[Token(Token = "0x2000E77")]
	[GenerateCleanupMethod]
	public class StorageMainPannel : MultiLayerUISubPanel<BaseSustainedPannel, StorageMainPannel, StorageMainPannel.GoToSpecificType>, IExternalPanel
	{
		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06005696 RID: 22166 RVA: 0x0001E990 File Offset: 0x0001CB90
		// (set) Token: 0x06005697 RID: 22167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C1E")]
		public bool StandaloneMode
		{
			[Token(Token = "0x6005696")]
			[Address(RVA = "0x55B080", Offset = "0x559A80", VA = "0x18055B080")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x6005697")]
			[Address(RVA = "0x55B0A0", Offset = "0x559AA0", VA = "0x18055B0A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06005698 RID: 22168 RVA: 0x0001E9A8 File Offset: 0x0001CBA8
		[Token(Token = "0x17000C1F")]
		protected override StorageMainPannel.GoToSpecificType DefaultPanelSelection
		{
			[Token(Token = "0x6005698")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "34")]
			get
			{
				return StorageMainPannel.GoToSpecificType.Ingredients;
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06005699 RID: 22169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C20")]
		[TupleElementNames(new string[] { "EnumValue", "GotoPanelButton", "PanelParent" })]
		protected override IEnumerable<ValueTuple<StorageMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<StorageMainPannel>>> GetData
		{
			[Token(Token = "0x6005699")]
			[Address(RVA = "0x85CBC0", Offset = "0x85B5C0", VA = "0x18085CBC0", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x0600569A RID: 22170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C21")]
		protected override string SwitchKey
		{
			[Token(Token = "0x600569A")]
			[Address(RVA = "0x85CC40", Offset = "0x85B640", VA = "0x18085CC40", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600569B RID: 22171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600569B")]
		[Address(RVA = "0x85CB30", Offset = "0x85B530", VA = "0x18085CB30", Slot = "37")]
		protected override void OnPostPanelInitialize()
		{
		}

		// Token: 0x0600569C RID: 22172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600569C")]
		[Address(RVA = "0x85CA50", Offset = "0x85B450", VA = "0x18085CA50", Slot = "39")]
		protected override void OnPanelPreOpen()
		{
		}

		// Token: 0x0600569D RID: 22173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600569D")]
		[Address(RVA = "0x85C8A0", Offset = "0x85B2A0", VA = "0x18085C8A0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600569E RID: 22174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600569E")]
		[Address(RVA = "0x85CB80", Offset = "0x85B580", VA = "0x18085CB80")]
		public StorageMainPannel()
		{
		}

		// Token: 0x0600569F RID: 22175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600569F")]
		[Address(RVA = "0x85CA10", Offset = "0x85B410", VA = "0x18085CA10", Slot = "41")]
		private void Common.UI.IExternalPanel.CloseExternPanel()
		{
		}

		// Token: 0x04005136 RID: 20790
		[Token(Token = "0x4005136")]
		[FieldOffset(Offset = "0x88")]
		public ActionExecutionScheduler ActionExecutionScheduler;

		// Token: 0x04005137 RID: 20791
		[Token(Token = "0x4005137")]
		[FieldOffset(Offset = "0x90")]
		public CanvasGroup DescriberCanvasGroup;

		// Token: 0x04005138 RID: 20792
		[Token(Token = "0x4005138")]
		[FieldOffset(Offset = "0x98")]
		public SellableDescriber Describer;

		// Token: 0x04005139 RID: 20793
		[Token(Token = "0x4005139")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject ObjectStackParent;

		// Token: 0x0400513A RID: 20794
		[Token(Token = "0x400513A")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject PinInputHelper;

		// Token: 0x0400513B RID: 20795
		[Token(Token = "0x400513B")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject PinInputHelper2;

		// Token: 0x0400513C RID: 20796
		[Token(Token = "0x400513C")]
		[FieldOffset(Offset = "0xB8")]
		public RectTransform FloatingPannel;

		// Token: 0x0400513D RID: 20797
		[Token(Token = "0x400513D")]
		[FieldOffset(Offset = "0xC0")]
		public Image BG;

		// Token: 0x0400513E RID: 20798
		[Token(Token = "0x400513E")]
		[FieldOffset(Offset = "0xC8")]
		public StorageOtherPannel OtherPannel;

		// Token: 0x0400513F RID: 20799
		[Token(Token = "0x400513F")]
		[FieldOffset(Offset = "0xD0")]
		public UIButtonToggle IngredientsBtn;

		// Token: 0x04005140 RID: 20800
		[Token(Token = "0x4005140")]
		[FieldOffset(Offset = "0xD8")]
		public UIButtonToggle FoodsBtn;

		// Token: 0x04005141 RID: 20801
		[Token(Token = "0x4005141")]
		[FieldOffset(Offset = "0xE0")]
		public UIButtonToggle BeveragesBtn;

		// Token: 0x04005142 RID: 20802
		[Token(Token = "0x4005142")]
		[FieldOffset(Offset = "0xE8")]
		public UIButtonToggle KitchenwareBtn;

		// Token: 0x04005143 RID: 20803
		[Token(Token = "0x4005143")]
		[FieldOffset(Offset = "0xF0")]
		public UIButtonToggle ItemBtn;

		// Token: 0x02000E78 RID: 3704
		[Token(Token = "0x2000E78")]
		public enum GoToSpecificType
		{
			// Token: 0x04005146 RID: 20806
			[Token(Token = "0x4005146")]
			Ingredients,
			// Token: 0x04005147 RID: 20807
			[Token(Token = "0x4005147")]
			Foods,
			// Token: 0x04005148 RID: 20808
			[Token(Token = "0x4005148")]
			Beverages,
			// Token: 0x04005149 RID: 20809
			[Token(Token = "0x4005149")]
			Kitchenware,
			// Token: 0x0400514A RID: 20810
			[Token(Token = "0x400514A")]
			Item
		}
	}
}
