using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppDummyDll;
using Plugins.DEYU;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020002D7 RID: 727
	[Token(Token = "0x20002D7")]
	[GenerateCleanupMethod]
	public class DaySceneShopPannel : UIPanel
	{
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600106D RID: 4205 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600106E RID: 4206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000194")]
		public TrackedMerchant MerchantData
		{
			[Token(Token = "0x600106D")]
			[Address(RVA = "0x48A9A0", Offset = "0x4893A0", VA = "0x18048A9A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x600106E")]
			[Address(RVA = "0x51E2C0", Offset = "0x51CCC0", VA = "0x18051E2C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600106F")]
		[Address(RVA = "0x92A0A0", Offset = "0x928AA0", VA = "0x18092A0A0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001070")]
		[Address(RVA = "0x92AB00", Offset = "0x929500", VA = "0x18092AB00")]
		private void OnSelectAllPressed(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001071")]
		[Address(RVA = "0x92ABB0", Offset = "0x9295B0", VA = "0x18092ABB0")]
		private void OnSelectAllReleased(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001072")]
		[Address(RVA = "0x92B420", Offset = "0x929E20", VA = "0x18092B420")]
		private IEnumerator SelectAllCoroutine()
		{
			return null;
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001073")]
		[Address(RVA = "0x92A340", Offset = "0x928D40", VA = "0x18092A340", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001074")]
		[Address(RVA = "0x929FE0", Offset = "0x9289E0", VA = "0x180929FE0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001075")]
		[Address(RVA = "0x92AC30", Offset = "0x929630", VA = "0x18092AC30")]
		private void OnShelfElementEnabled(Product productData, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001076")]
		[Address(RVA = "0x92AEA0", Offset = "0x9298A0", VA = "0x18092AEA0")]
		private void OnShelfElementSelected(Product productData, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001077")]
		[Address(RVA = "0x929B00", Offset = "0x928500", VA = "0x180929B00")]
		private void OnCartElementEnabled(Product productData, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001078")]
		[Address(RVA = "0x929DD0", Offset = "0x9287D0", VA = "0x180929DD0")]
		private void OnCartElementSelected(Product productData, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001079")]
		[Address(RVA = "0x92B740", Offset = "0x92A140", VA = "0x18092B740")]
		private void UpdateShelfAndCart()
		{
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600107A")]
		[Address(RVA = "0x9287E0", Offset = "0x9271E0", VA = "0x1809287E0")]
		private void BuyAll()
		{
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600107B")]
		[Address(RVA = "0x928F80", Offset = "0x927980", VA = "0x180928F80")]
		private void CancelAllBuy()
		{
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600107C")]
		[Address(RVA = "0x92AC10", Offset = "0x929610", VA = "0x18092AC10")]
		private void OnSelectAll()
		{
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600107D")]
		[Address(RVA = "0x595130", Offset = "0x593B30", VA = "0x180595130")]
		private void OnBuyAll(InputAction.CallbackContext _)
		{
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600107E")]
		[Address(RVA = "0x92B1F0", Offset = "0x929BF0", VA = "0x18092B1F0")]
		private void ProcessPerCartVisualColum(RectTransform field, Product data)
		{
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600107F")]
		[Address(RVA = "0x92B150", Offset = "0x929B50", VA = "0x18092B150")]
		private void PreferShelfReselection()
		{
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001080")]
		[Address(RVA = "0x92B0B0", Offset = "0x929AB0", VA = "0x18092B0B0")]
		private void PreferCartReselection()
		{
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x000068A0 File Offset: 0x00004AA0
		[Token(Token = "0x6001081")]
		[Address(RVA = "0x928E10", Offset = "0x927810", VA = "0x180928E10")]
		private int CalculateCurrentPrice(int trueValue)
		{
			return 0;
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x000068B8 File Offset: 0x00004AB8
		[Token(Token = "0x6001082")]
		[Address(RVA = "0x929940", Offset = "0x928340", VA = "0x180929940")]
		public int GetPrice(Product productData)
		{
			return 0;
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001083")]
		[Address(RVA = "0x929610", Offset = "0x928010", VA = "0x180929610")]
		private void Describe(Product productData)
		{
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001084")]
		[Address(RVA = "0x928BC0", Offset = "0x9275C0", VA = "0x180928BC0")]
		private void Buy(int amount)
		{
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001085")]
		[Address(RVA = "0x9292B0", Offset = "0x927CB0", VA = "0x1809292B0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001086")]
		[Address(RVA = "0x92BDE0", Offset = "0x92A7E0", VA = "0x18092BDE0")]
		public DaySceneShopPannel()
		{
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600108A")]
		[Address(RVA = "0x92B660", Offset = "0x92A060", VA = "0x18092B660")]
		[CompilerGenerated]
		internal static void <ProcessPerCartVisualColum>g__ProcessPerColumnObject|57_0(UIElementCluster uIElementCluster, Product inputData)
		{
		}

		// Token: 0x04000F1A RID: 3866
		[Token(Token = "0x4000F1A")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform customSpacingRect;

		// Token: 0x04000F1B RID: 3867
		[Token(Token = "0x4000F1B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActionExecutionScheduler m_ActionExecutionScheduler;

		// Token: 0x04000F1C RID: 3868
		[Token(Token = "0x4000F1C")]
		[FieldOffset(Offset = "0x80")]
		public AdpProgressIndicatorComponent shelfScroller;

		// Token: 0x04000F1D RID: 3869
		[Token(Token = "0x4000F1D")]
		[FieldOffset(Offset = "0x88")]
		public AdpProgressIndicatorComponent cartScroller;

		// Token: 0x04000F1E RID: 3870
		[Token(Token = "0x4000F1E")]
		[FieldOffset(Offset = "0x90")]
		public GameObject shelfObject;

		// Token: 0x04000F1F RID: 3871
		[Token(Token = "0x4000F1F")]
		[FieldOffset(Offset = "0x98")]
		public GameObject cartObject;

		// Token: 0x04000F20 RID: 3872
		[Token(Token = "0x4000F20")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject cartVisualObject;

		// Token: 0x04000F21 RID: 3873
		[Token(Token = "0x4000F21")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject cartVisualColumnObject;

		// Token: 0x04000F22 RID: 3874
		[Token(Token = "0x4000F22")]
		[FieldOffset(Offset = "0xB0")]
		public DescriberSwitcher describerSwitcher;

		// Token: 0x04000F23 RID: 3875
		[Token(Token = "0x4000F23")]
		[FieldOffset(Offset = "0xB8")]
		public GridLayoutGroup shelfField;

		// Token: 0x04000F24 RID: 3876
		[Token(Token = "0x4000F24")]
		[FieldOffset(Offset = "0xC0")]
		public GridLayoutGroup cartField;

		// Token: 0x04000F25 RID: 3877
		[Token(Token = "0x4000F25")]
		[FieldOffset(Offset = "0xC8")]
		public RectTransform cartVisualField;

		// Token: 0x04000F26 RID: 3878
		[Token(Token = "0x4000F26")]
		[FieldOffset(Offset = "0xD0")]
		public SellableDescriber describer;

		// Token: 0x04000F27 RID: 3879
		[Token(Token = "0x4000F27")]
		[FieldOffset(Offset = "0xD8")]
		public CanvasGroup describerPanel;

		// Token: 0x04000F28 RID: 3880
		[Token(Token = "0x4000F28")]
		[FieldOffset(Offset = "0xE0")]
		public TextMeshProUGUI fund;

		// Token: 0x04000F29 RID: 3881
		[Token(Token = "0x4000F29")]
		[FieldOffset(Offset = "0xE8")]
		public TextMeshProUGUI price;

		// Token: 0x04000F2A RID: 3882
		[Token(Token = "0x4000F2A")]
		[FieldOffset(Offset = "0xF0")]
		public TextMeshProUGUI left;

		// Token: 0x04000F2B RID: 3883
		[Token(Token = "0x4000F2B")]
		[FieldOffset(Offset = "0xF8")]
		public TextMeshProUGUI amount;

		// Token: 0x04000F2C RID: 3884
		[Token(Token = "0x4000F2C")]
		[FieldOffset(Offset = "0x100")]
		public TextMeshProUGUI title;

		// Token: 0x04000F2D RID: 3885
		[Token(Token = "0x4000F2D")]
		[FieldOffset(Offset = "0x108")]
		public TextMeshProUGUI totalPrice;

		// Token: 0x04000F2E RID: 3886
		[Token(Token = "0x4000F2E")]
		[FieldOffset(Offset = "0x110")]
		public UIButtonSimple confirmButton;

		// Token: 0x04000F2F RID: 3887
		[Token(Token = "0x4000F2F")]
		[FieldOffset(Offset = "0x118")]
		public Color sufficientColor;

		// Token: 0x04000F30 RID: 3888
		[Token(Token = "0x4000F30")]
		[FieldOffset(Offset = "0x128")]
		public Color inSufficientColor;

		// Token: 0x04000F31 RID: 3889
		[Token(Token = "0x4000F31")]
		[FieldOffset(Offset = "0x138")]
		public AudioClip OnBuyAudio;

		// Token: 0x04000F32 RID: 3890
		[Token(Token = "0x4000F32")]
		[FieldOffset(Offset = "0x140")]
		private readonly List<Product> allCartProductList;

		// Token: 0x04000F33 RID: 3891
		[Token(Token = "0x4000F33")]
		[FieldOffset(Offset = "0x148")]
		private readonly List<GameObject> allInCartColumnInstances;

		// Token: 0x04000F34 RID: 3892
		[Token(Token = "0x4000F34")]
		[FieldOffset(Offset = "0x150")]
		private readonly Dictionary<int, List<GameObject>> allInCartInstances;

		// Token: 0x04000F35 RID: 3893
		[Token(Token = "0x4000F35")]
		[FieldOffset(Offset = "0x158")]
		private readonly Dictionary<Product.ProductKey, Product> allProducts;

		// Token: 0x04000F36 RID: 3894
		[Token(Token = "0x4000F36")]
		[FieldOffset(Offset = "0x160")]
		private readonly List<Product> allShelfProductList;

		// Token: 0x04000F37 RID: 3895
		[Token(Token = "0x4000F37")]
		[FieldOffset(Offset = "0x168")]
		private readonly Dictionary<Product.ProductKey, Product> inCartProducts;

		// Token: 0x04000F38 RID: 3896
		[Token(Token = "0x4000F38")]
		[FieldOffset(Offset = "0x170")]
		private Action buyAll;

		// Token: 0x04000F39 RID: 3897
		[Token(Token = "0x4000F39")]
		[FieldOffset(Offset = "0x178")]
		private bool buyAllEnabled;

		// Token: 0x04000F3A RID: 3898
		[Token(Token = "0x4000F3A")]
		[FieldOffset(Offset = "0x179")]
		private bool isFundSufficient;

		// Token: 0x04000F3B RID: 3899
		[Token(Token = "0x4000F3B")]
		[FieldOffset(Offset = "0x180")]
		private StaticVerticalGridScrollListUILogicalGroupT<Product, UIElementCluster, UIButtonSimple> m_CartGroup;

		// Token: 0x04000F3C RID: 3900
		[Token(Token = "0x4000F3C")]
		[FieldOffset(Offset = "0x188")]
		private Coroutine m_SelectAllCoroutine;

		// Token: 0x04000F3D RID: 3901
		[Token(Token = "0x4000F3D")]
		[FieldOffset(Offset = "0x190")]
		private StaticVerticalGridScrollListUILogicalGroupT<Product, UIElementCluster, UIButtonSimple> m_ShelfGroup;

		// Token: 0x04000F3E RID: 3902
		[Token(Token = "0x4000F3E")]
		[FieldOffset(Offset = "0x198")]
		private float m_ShouldRunBuyAllFucntionOffset;

		// Token: 0x04000F3F RID: 3903
		[Token(Token = "0x4000F3F")]
		[FieldOffset(Offset = "0x1A0")]
		private Action selectAll;
	}
}
