using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI.Filter;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core;
using GameData.Core.Collections;
using Il2CppDummyDll;
using Plugins.DEYU;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000EAF RID: 3759
	[Token(Token = "0x2000EAF")]
	[GenerateCleanupMethod]
	public class NoteBookAlbumItemSubPannel : UISubPanel<NoteBookAlbumPannel>
	{
		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x0600586B RID: 22635 RVA: 0x0001F230 File Offset: 0x0001D430
		[Token(Token = "0x17000C54")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x600586B")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600586C RID: 22636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600586C")]
		[Address(RVA = "0x869F50", Offset = "0x868950", VA = "0x180869F50", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x0600586D RID: 22637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600586D")]
		[Address(RVA = "0x869EA0", Offset = "0x8688A0", VA = "0x180869EA0", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x0600586E RID: 22638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600586E")]
		[Address(RVA = "0x86A8E0", Offset = "0x8692E0", VA = "0x18086A8E0")]
		private void ResetFilter()
		{
		}

		// Token: 0x0600586F RID: 22639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600586F")]
		[Address(RVA = "0x869E50", Offset = "0x868850", VA = "0x180869E50", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06005870 RID: 22640 RVA: 0x0001F248 File Offset: 0x0001D448
		[Token(Token = "0x6005870")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06005871 RID: 22641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005871")]
		[Address(RVA = "0x86A230", Offset = "0x868C30", VA = "0x18086A230", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005872 RID: 22642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005872")]
		[Address(RVA = "0x4E0B20", Offset = "0x4DF520", VA = "0x1804E0B20")]
		private void SetParamValue(Action<NonTradableObjectBase> describeDataCallback)
		{
		}

		// Token: 0x06005873 RID: 22643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005873")]
		private void OnElementEnabled<T>(T objectBase, UIElementCluster cluster, UIButtonSimple button) where T : NonTradableObjectBase
		{
		}

		// Token: 0x06005874 RID: 22644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005874")]
		private void OnElementSelected<T>(T objectBase, UIElementCluster cluster, UIButtonSimple button) where T : NonTradableObjectBase
		{
		}

		// Token: 0x06005875 RID: 22645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005875")]
		[Address(RVA = "0x869AA0", Offset = "0x8684A0", VA = "0x180869AA0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005876 RID: 22646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005876")]
		[Address(RVA = "0x86C610", Offset = "0x86B010", VA = "0x18086C610")]
		public NoteBookAlbumItemSubPannel()
		{
		}

		// Token: 0x06005878 RID: 22648 RVA: 0x0001F260 File Offset: 0x0001D460
		[Token(Token = "0x6005878")]
		[Address(RVA = "0x86AAA0", Offset = "0x8694A0", VA = "0x18086AAA0")]
		[CompilerGenerated]
		private UniTask <OnPanelInitialize>g__OpenFilterPanel|38_1()
		{
			return default(UniTask);
		}

		// Token: 0x040052DC RID: 21212
		[Token(Token = "0x40052DC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActionExecutionScheduler m_ActionExecutionScheduler;

		// Token: 0x040052DD RID: 21213
		[Token(Token = "0x40052DD")]
		[FieldOffset(Offset = "0x80")]
		public GameObject ItemParent;

		// Token: 0x040052DE RID: 21214
		[Token(Token = "0x40052DE")]
		[FieldOffset(Offset = "0x88")]
		public SellableDescriber ItemDescriber;

		// Token: 0x040052DF RID: 21215
		[Token(Token = "0x40052DF")]
		[FieldOffset(Offset = "0x90")]
		public AdpProgressIndicatorComponent Scroller;

		// Token: 0x040052E0 RID: 21216
		[Token(Token = "0x40052E0")]
		[FieldOffset(Offset = "0x98")]
		public CanvasGroup DescriberPannel;

		// Token: 0x040052E1 RID: 21217
		[Token(Token = "0x40052E1")]
		[FieldOffset(Offset = "0xA0")]
		public CanvasGroup NullPannel;

		// Token: 0x040052E2 RID: 21218
		[Token(Token = "0x40052E2")]
		[FieldOffset(Offset = "0xA8")]
		public UIButtonSimple FilterBtn;

		// Token: 0x040052E3 RID: 21219
		[Token(Token = "0x40052E3")]
		[FieldOffset(Offset = "0xB0")]
		public GridLayoutGroup FoodField;

		// Token: 0x040052E4 RID: 21220
		[Token(Token = "0x40052E4")]
		[FieldOffset(Offset = "0xB8")]
		public GridLayoutGroup BevField;

		// Token: 0x040052E5 RID: 21221
		[Token(Token = "0x40052E5")]
		[FieldOffset(Offset = "0xC0")]
		public GridLayoutGroup IngField;

		// Token: 0x040052E6 RID: 21222
		[Token(Token = "0x40052E6")]
		[FieldOffset(Offset = "0xC8")]
		public GridLayoutGroup CookerField;

		// Token: 0x040052E7 RID: 21223
		[Token(Token = "0x40052E7")]
		[FieldOffset(Offset = "0xD0")]
		public GridLayoutGroup ItemField;

		// Token: 0x040052E8 RID: 21224
		[Token(Token = "0x40052E8")]
		[FieldOffset(Offset = "0xD8")]
		public TextMeshProUGUI priceText;

		// Token: 0x040052E9 RID: 21225
		[Token(Token = "0x40052E9")]
		[FieldOffset(Offset = "0xE0")]
		private readonly List<Sellable> m_Bevs;

		// Token: 0x040052EA RID: 21226
		[Token(Token = "0x40052EA")]
		[FieldOffset(Offset = "0xE8")]
		private readonly List<IFilterConfig> m_BevsFilterQueue;

		// Token: 0x040052EB RID: 21227
		[Token(Token = "0x40052EB")]
		[FieldOffset(Offset = "0xF0")]
		private readonly List<Cooker> m_Cookers;

		// Token: 0x040052EC RID: 21228
		[Token(Token = "0x40052EC")]
		[FieldOffset(Offset = "0xF8")]
		private readonly List<IFilterConfig> m_CookersFilterQueue;

		// Token: 0x040052ED RID: 21229
		[Token(Token = "0x40052ED")]
		[FieldOffset(Offset = "0x100")]
		private readonly List<Sellable> m_Foods;

		// Token: 0x040052EE RID: 21230
		[Token(Token = "0x40052EE")]
		[FieldOffset(Offset = "0x108")]
		private readonly List<IFilterConfig> m_FoodsFilterQueue;

		// Token: 0x040052EF RID: 21231
		[Token(Token = "0x40052EF")]
		[FieldOffset(Offset = "0x110")]
		private readonly List<Ingredient> m_Ings;

		// Token: 0x040052F0 RID: 21232
		[Token(Token = "0x40052F0")]
		[FieldOffset(Offset = "0x118")]
		private readonly List<IFilterConfig> m_IngsFilterQueue;

		// Token: 0x040052F1 RID: 21233
		[Token(Token = "0x40052F1")]
		[FieldOffset(Offset = "0x120")]
		private readonly List<NonTradableObjectBase> m_Items;

		// Token: 0x040052F2 RID: 21234
		[Token(Token = "0x40052F2")]
		[FieldOffset(Offset = "0x128")]
		private readonly List<IFilterConfig> m_ItemsFilterQueue;

		// Token: 0x040052F3 RID: 21235
		[Token(Token = "0x40052F3")]
		[FieldOffset(Offset = "0x130")]
		private Action<NonTradableObjectBase> describeDataCallback;

		// Token: 0x040052F4 RID: 21236
		[Token(Token = "0x40052F4")]
		[FieldOffset(Offset = "0x138")]
		private StaticVerticalGridScrollListUILogicalGroupT<Sellable, UIElementCluster, UIButtonSimple> m_BeverageGroup;

		// Token: 0x040052F5 RID: 21237
		[Token(Token = "0x40052F5")]
		[FieldOffset(Offset = "0x140")]
		private CanvasGroup m_BevFieldCanvasGroup;

		// Token: 0x040052F6 RID: 21238
		[Token(Token = "0x40052F6")]
		[FieldOffset(Offset = "0x148")]
		private CanvasGroup m_CookerFieldCanvasGroup;

		// Token: 0x040052F7 RID: 21239
		[Token(Token = "0x40052F7")]
		[FieldOffset(Offset = "0x150")]
		private Action m_ExitCurrentGroupCallback;

		// Token: 0x040052F8 RID: 21240
		[Token(Token = "0x40052F8")]
		[FieldOffset(Offset = "0x158")]
		private CanvasGroup m_FoodFieldCanvasGroup;

		// Token: 0x040052F9 RID: 21241
		[Token(Token = "0x40052F9")]
		[FieldOffset(Offset = "0x160")]
		private StaticVerticalGridScrollListUILogicalGroupT<Sellable, UIElementCluster, UIButtonSimple> m_FoodGroup;

		// Token: 0x040052FA RID: 21242
		[Token(Token = "0x40052FA")]
		[FieldOffset(Offset = "0x168")]
		private CanvasGroup m_IngFieldCanvasGroup;

		// Token: 0x040052FB RID: 21243
		[Token(Token = "0x40052FB")]
		[FieldOffset(Offset = "0x170")]
		private StaticVerticalGridScrollListUILogicalGroupT<Ingredient, UIElementCluster, UIButtonSimple> m_IngredientGroup;

		// Token: 0x040052FC RID: 21244
		[Token(Token = "0x40052FC")]
		[FieldOffset(Offset = "0x178")]
		private CanvasGroup m_ItemFieldCanvasGroup;

		// Token: 0x040052FD RID: 21245
		[Token(Token = "0x40052FD")]
		[FieldOffset(Offset = "0x180")]
		private StaticVerticalGridScrollListUILogicalGroupT<NonTradableObjectBase, UIElementCluster, UIButtonSimple> m_ItemGroup;

		// Token: 0x040052FE RID: 21246
		[Token(Token = "0x40052FE")]
		[FieldOffset(Offset = "0x188")]
		private StaticVerticalGridScrollListUILogicalGroupT<Cooker, UIElementCluster, UIButtonSimple> m_KitchenwareGroup;

		// Token: 0x040052FF RID: 21247
		[Token(Token = "0x40052FF")]
		[FieldOffset(Offset = "0x190")]
		private Action m_UpdateObjectCallback;
	}
}
