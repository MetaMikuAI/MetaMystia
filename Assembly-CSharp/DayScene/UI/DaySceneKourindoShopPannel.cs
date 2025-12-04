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
using GameData;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020002BE RID: 702
	[Token(Token = "0x20002BE")]
	[GenerateCleanupMethod]
	public class DaySceneKourindoShopPannel : UIPanel
	{
		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000FB8 RID: 4024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000181")]
		public TrackedMerchant MerchantData
		{
			[Token(Token = "0x6000FB7")]
			[Address(RVA = "0x45ED40", Offset = "0x45D740", VA = "0x18045ED40")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000FB8")]
			[Address(RVA = "0x45F140", Offset = "0x45DB40", VA = "0x18045F140")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000182")]
		private IEnumerable<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> DailyKourindouProducts
		{
			[Token(Token = "0x6000FB9")]
			[Address(RVA = "0x926460", Offset = "0x924E60", VA = "0x180926460")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000FBA RID: 4026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000183")]
		private IEnumerable<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> StaticCookerKourindouProducts
		{
			[Token(Token = "0x6000FBA")]
			[Address(RVA = "0x926580", Offset = "0x924F80", VA = "0x180926580")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000FBB RID: 4027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000184")]
		private IEnumerable<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> StaticOtherKourindouProducts
		{
			[Token(Token = "0x6000FBB")]
			[Address(RVA = "0x9267C0", Offset = "0x9251C0", VA = "0x1809267C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000FBC RID: 4028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000185")]
		private IEnumerable<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> DailyKourindouProductsInCart
		{
			[Token(Token = "0x6000FBC")]
			[Address(RVA = "0x926340", Offset = "0x924D40", VA = "0x180926340")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000FBD RID: 4029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000186")]
		private IEnumerable<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> StaticKourindouProductsInCart
		{
			[Token(Token = "0x6000FBD")]
			[Address(RVA = "0x9266A0", Offset = "0x9250A0", VA = "0x1809266A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0x921F80", Offset = "0x920980", VA = "0x180921F80", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FBF")]
		[Address(RVA = "0x9235D0", Offset = "0x921FD0", VA = "0x1809235D0")]
		private void OnSelectAllPressed(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC0")]
		[Address(RVA = "0x923680", Offset = "0x922080", VA = "0x180923680")]
		private void OnSelectAllReleased(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC1")]
		[Address(RVA = "0x924D00", Offset = "0x923700", VA = "0x180924D00")]
		private IEnumerator SelectAllCoroutine()
		{
			return null;
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC2")]
		[Address(RVA = "0x9236E0", Offset = "0x9220E0", VA = "0x1809236E0")]
		private void OnSelectAll()
		{
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0x921890", Offset = "0x920290", VA = "0x180921890")]
		private void OnBuyAll(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x924D80", Offset = "0x923780", VA = "0x180924D80")]
		private void TabSwitchHandler(InputAction.CallbackContext switchAction)
		{
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x9217E0", Offset = "0x9201E0", VA = "0x1809217E0")]
		private void GoToSpecific(DaySceneKourindoShopPannel.KourindouMerchandiseType kourindouMerchandiseType)
		{
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC6")]
		[Address(RVA = "0x925D80", Offset = "0x924780", VA = "0x180925D80")]
		private void UpdateShelfElements()
		{
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC7")]
		[Address(RVA = "0x925570", Offset = "0x923F70", VA = "0x180925570")]
		private void UpdateCartElements()
		{
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC8")]
		[Address(RVA = "0x921790", Offset = "0x920190", VA = "0x180921790")]
		private void GoToPrevious()
		{
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FC9")]
		[Address(RVA = "0x921740", Offset = "0x920140", VA = "0x180921740")]
		private void GoToNext()
		{
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCA")]
		[Address(RVA = "0x922840", Offset = "0x921240", VA = "0x180922840", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCB")]
		[Address(RVA = "0x924370", Offset = "0x922D70", VA = "0x180924370")]
		private void ResetSelection(DaySceneKourindoShopPannel.ReselectType reselectType = DaySceneKourindoShopPannel.ReselectType.Default)
		{
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCC")]
		[Address(RVA = "0x923700", Offset = "0x922100", VA = "0x180923700")]
		private void OnShelfElementEnabled(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey shelfProductData, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCD")]
		[Address(RVA = "0x923A50", Offset = "0x922450", VA = "0x180923A50")]
		private void OnShelfElementSelected(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey shelfProductData, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCE")]
		[Address(RVA = "0x9218F0", Offset = "0x9202F0", VA = "0x1809218F0")]
		private void OnCartElementEnabled(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey cartProductData, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x921CF0", Offset = "0x9206F0", VA = "0x180921CF0")]
		private void OnCartElementSelected(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey cartProductData, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x920240", Offset = "0x91EC40", VA = "0x180920240")]
		private void AddToCart(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey productData, bool shouldAddAll, bool immediatelyRefresh = true)
		{
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x924820", Offset = "0x923220", VA = "0x180924820")]
		private void ReturnToShelf(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey productData, bool shouldRemoveAll, bool immediatelyRefresh = true)
		{
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x920720", Offset = "0x91F120", VA = "0x180920720")]
		private void BuyAll()
		{
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD3")]
		[Address(RVA = "0x924530", Offset = "0x922F30", VA = "0x180924530")]
		private void ReturnAll()
		{
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD4")]
		[Address(RVA = "0x923C50", Offset = "0x922650", VA = "0x180923C50")]
		private void Pay(int amount)
		{
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00006510 File Offset: 0x00004710
		[Token(Token = "0x6000FD5")]
		[Address(RVA = "0x9216E0", Offset = "0x9200E0", VA = "0x1809216E0")]
		private int GetPrice(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey kourindouProductData)
		{
			return 0;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00006528 File Offset: 0x00004728
		[Token(Token = "0x6000FD6")]
		[Address(RVA = "0x9216D0", Offset = "0x9200D0", VA = "0x1809216D0")]
		private int GetCurrencyFund(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency currency)
		{
			return 0;
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD7")]
		[Address(RVA = "0x921EF0", Offset = "0x9208F0", VA = "0x180921EF0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD8")]
		[Address(RVA = "0x920F40", Offset = "0x91F940", VA = "0x180920F40")]
		private void Describe(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey kourindoStaticMerchandise)
		{
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0x920AF0", Offset = "0x91F4F0", VA = "0x180920AF0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0x926150", Offset = "0x924B50", VA = "0x180926150")]
		public DaySceneKourindoShopPannel()
		{
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000FE1")]
		[Address(RVA = "0x924E30", Offset = "0x923830", VA = "0x180924E30")]
		[CompilerGenerated]
		internal static void <Describe>g__ProcessCurrency|95_3(UIElementCluster cluster, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency currencyData)
		{
		}

		// Token: 0x04000E6F RID: 3695
		[Token(Token = "0x4000E6F")]
		private const int NORMAL_PRODUCTS = 0;

		// Token: 0x04000E70 RID: 3696
		[Token(Token = "0x4000E70")]
		private const int COOKER_PRODUCTS = 1;

		// Token: 0x04000E71 RID: 3697
		[Token(Token = "0x4000E71")]
		private const int OTHER_PRODUCTS = 2;

		// Token: 0x04000E72 RID: 3698
		[Token(Token = "0x4000E72")]
		public const int COUPONS_ID = 2;

		// Token: 0x04000E73 RID: 3699
		[Token(Token = "0x4000E73")]
		private const string QIZHE = "(30%OFF!)  ";

		// Token: 0x04000E74 RID: 3700
		[Token(Token = "0x4000E74")]
		[FieldOffset(Offset = "0x70")]
		public RectTransform customSpacingRect;

		// Token: 0x04000E75 RID: 3701
		[Token(Token = "0x4000E75")]
		[FieldOffset(Offset = "0x78")]
		public DescriberSwitcher describerSwitcher;

		// Token: 0x04000E76 RID: 3702
		[Token(Token = "0x4000E76")]
		[FieldOffset(Offset = "0x80")]
		[Header("老霖立绘相关")]
		public Image rinnosukeImage;

		// Token: 0x04000E77 RID: 3703
		[Token(Token = "0x4000E77")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI talkingDialoge;

		// Token: 0x04000E78 RID: 3704
		[Token(Token = "0x4000E78")]
		[FieldOffset(Offset = "0x90")]
		public Sprite[] diffImages;

		// Token: 0x04000E79 RID: 3705
		[Token(Token = "0x4000E79")]
		[FieldOffset(Offset = "0x98")]
		public MultiLanguageTextMesh.MultiLanguageTextAsset sellDialogeTXT;

		// Token: 0x04000E7A RID: 3706
		[Token(Token = "0x4000E7A")]
		[FieldOffset(Offset = "0xA0")]
		public MultiLanguageTextMesh.MultiLanguageTextAsset soldOutDialogeTXT;

		// Token: 0x04000E7B RID: 3707
		[Token(Token = "0x4000E7B")]
		[FieldOffset(Offset = "0xA8")]
		public MultiLanguageTextMesh.MultiLanguageTextAsset allSoldOutDialogeTXT;

		// Token: 0x04000E7C RID: 3708
		[Token(Token = "0x4000E7C")]
		[FieldOffset(Offset = "0xB0")]
		public Sprite soldOutFace;

		// Token: 0x04000E7D RID: 3709
		[Token(Token = "0x4000E7D")]
		[FieldOffset(Offset = "0xB8")]
		public AudioClip OnBuyAudio;

		// Token: 0x04000E7E RID: 3710
		[Token(Token = "0x4000E7E")]
		[FieldOffset(Offset = "0xC0")]
		[Header("Prefab Element")]
		public GameObject shelfObject;

		// Token: 0x04000E7F RID: 3711
		[Token(Token = "0x4000E7F")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject cartObject;

		// Token: 0x04000E80 RID: 3712
		[Token(Token = "0x4000E80")]
		[FieldOffset(Offset = "0xD0")]
		public GridLayoutGroup shelfField;

		// Token: 0x04000E81 RID: 3713
		[Token(Token = "0x4000E81")]
		[FieldOffset(Offset = "0xD8")]
		public GridLayoutGroup cartField;

		// Token: 0x04000E82 RID: 3714
		[Token(Token = "0x4000E82")]
		[FieldOffset(Offset = "0xE0")]
		public Image[] Tab;

		// Token: 0x04000E83 RID: 3715
		[Token(Token = "0x4000E83")]
		[FieldOffset(Offset = "0xE8")]
		public UIButtonSimple[] TabBtns;

		// Token: 0x04000E84 RID: 3716
		[Token(Token = "0x4000E84")]
		[FieldOffset(Offset = "0xF0")]
		public SellableDescriber describer;

		// Token: 0x04000E85 RID: 3717
		[Token(Token = "0x4000E85")]
		[FieldOffset(Offset = "0xF8")]
		public LayoutGroup describePannel;

		// Token: 0x04000E86 RID: 3718
		[Token(Token = "0x4000E86")]
		[FieldOffset(Offset = "0x100")]
		public TextMeshProUGUI price;

		// Token: 0x04000E87 RID: 3719
		[Token(Token = "0x4000E87")]
		[FieldOffset(Offset = "0x108")]
		public TextMeshProUGUI left;

		// Token: 0x04000E88 RID: 3720
		[Token(Token = "0x4000E88")]
		[FieldOffset(Offset = "0x110")]
		public TextMeshProUGUI amount;

		// Token: 0x04000E89 RID: 3721
		[Token(Token = "0x4000E89")]
		[FieldOffset(Offset = "0x118")]
		public TextMeshProUGUI title;

		// Token: 0x04000E8A RID: 3722
		[Token(Token = "0x4000E8A")]
		[FieldOffset(Offset = "0x120")]
		public CanvasGroup amountCanvas;

		// Token: 0x04000E8B RID: 3723
		[Token(Token = "0x4000E8B")]
		[FieldOffset(Offset = "0x128")]
		public UIButtonSimple confirmButton;

		// Token: 0x04000E8C RID: 3724
		[Token(Token = "0x4000E8C")]
		[FieldOffset(Offset = "0x130")]
		public RectTransform currencyPannel;

		// Token: 0x04000E8D RID: 3725
		[Token(Token = "0x4000E8D")]
		[FieldOffset(Offset = "0x138")]
		public CanvasGroup describeCurrencyCanvasGroup;

		// Token: 0x04000E8E RID: 3726
		[Token(Token = "0x4000E8E")]
		[FieldOffset(Offset = "0x140")]
		public GameObject currencyElement;

		// Token: 0x04000E8F RID: 3727
		[Token(Token = "0x4000E8F")]
		[FieldOffset(Offset = "0x148")]
		public AdpProgressIndicatorComponent scrollerLeft;

		// Token: 0x04000E90 RID: 3728
		[Token(Token = "0x4000E90")]
		[FieldOffset(Offset = "0x150")]
		public AdpProgressIndicatorComponent scrollerRight;

		// Token: 0x04000E91 RID: 3729
		[Token(Token = "0x4000E91")]
		[FieldOffset(Offset = "0x158")]
		public Color sufficientColor;

		// Token: 0x04000E92 RID: 3730
		[Token(Token = "0x4000E92")]
		[FieldOffset(Offset = "0x168")]
		public Color inSufficientColor;

		// Token: 0x04000E93 RID: 3731
		[Token(Token = "0x4000E93")]
		[FieldOffset(Offset = "0x178")]
		private readonly List<GameObject> allCartPanelCurrencyInstances;

		// Token: 0x04000E94 RID: 3732
		[Token(Token = "0x4000E94")]
		[FieldOffset(Offset = "0x180")]
		private readonly List<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> allCartProductList;

		// Token: 0x04000E95 RID: 3733
		[Token(Token = "0x4000E95")]
		[FieldOffset(Offset = "0x188")]
		private readonly List<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> allKourindouProducts;

		// Token: 0x04000E96 RID: 3734
		[Token(Token = "0x4000E96")]
		[FieldOffset(Offset = "0x190")]
		private readonly List<GameObject> allShelfPanelCurrencyInstances;

		// Token: 0x04000E97 RID: 3735
		[Token(Token = "0x4000E97")]
		[FieldOffset(Offset = "0x198")]
		private readonly List<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey> allShelfProductList;

		// Token: 0x04000E98 RID: 3736
		[Token(Token = "0x4000E98")]
		[FieldOffset(Offset = "0x1A0")]
		private readonly Dictionary<KeyValuePair<KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency.CurrencyType, int>, int> currencyDic;

		// Token: 0x04000E99 RID: 3737
		[Token(Token = "0x4000E99")]
		[FieldOffset(Offset = "0x1A8")]
		private DaySceneKourindoShopPannel.ProductKeyEqualityComparer _comparer;

		// Token: 0x04000E9A RID: 3738
		[Token(Token = "0x4000E9A")]
		[FieldOffset(Offset = "0x1B0")]
		private Action buyAll;

		// Token: 0x04000E9B RID: 3739
		[Token(Token = "0x4000E9B")]
		[FieldOffset(Offset = "0x1B8")]
		private CanvasGroup describerCanvasGroup;

		// Token: 0x04000E9C RID: 3740
		[Token(Token = "0x4000E9C")]
		[FieldOffset(Offset = "0x1C0")]
		private string[] dialogeText;

		// Token: 0x04000E9D RID: 3741
		[Token(Token = "0x4000E9D")]
		[FieldOffset(Offset = "0x1C8")]
		private string[] soldOutText;

		// Token: 0x04000E9E RID: 3742
		[Token(Token = "0x4000E9E")]
		[FieldOffset(Offset = "0x1D0")]
		private string[] allSoldOutText;

		// Token: 0x04000E9F RID: 3743
		[Token(Token = "0x4000E9F")]
		[FieldOffset(Offset = "0x1D8")]
		private bool m_Affordable;

		// Token: 0x04000EA0 RID: 3744
		[Token(Token = "0x4000EA0")]
		[FieldOffset(Offset = "0x1E0")]
		private StaticVerticalGridScrollListUILogicalGroupT<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, UIElementCluster, UIButtonSimple> m_CartGroup;

		// Token: 0x04000EA1 RID: 3745
		[Token(Token = "0x4000EA1")]
		[FieldOffset(Offset = "0x1E8")]
		private Coroutine m_SelectAllCoroutine;

		// Token: 0x04000EA2 RID: 3746
		[Token(Token = "0x4000EA2")]
		[FieldOffset(Offset = "0x1F0")]
		private StaticVerticalGridScrollListUILogicalGroupT<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey, UIElementCluster, UIButtonSimple> m_ShelfGroup;

		// Token: 0x04000EA3 RID: 3747
		[Token(Token = "0x4000EA3")]
		[FieldOffset(Offset = "0x1F8")]
		private float m_ShouldRunBuyAllFucntionOffset;

		// Token: 0x04000EA4 RID: 3748
		[Token(Token = "0x4000EA4")]
		[FieldOffset(Offset = "0x200")]
		private Action selectAll;

		// Token: 0x04000EA5 RID: 3749
		[Token(Token = "0x4000EA5")]
		[FieldOffset(Offset = "0x208")]
		private DaySceneKourindoShopPannel.KourindouMerchandiseType tabType;

		// Token: 0x020002BF RID: 703
		[Token(Token = "0x20002BF")]
		public struct KourindouStaticMerchandiseKey
		{
			// Token: 0x17000187 RID: 391
			// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00006540 File Offset: 0x00004740
			[Token(Token = "0x17000187")]
			public readonly int UnitFundPrice
			{
				[Token(Token = "0x6000FE2")]
				[Address(RVA = "0x4D1E80", Offset = "0x4D0880", VA = "0x1804D1E80")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000188 RID: 392
			// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000188")]
			public string Label
			{
				[Token(Token = "0x6000FE3")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000189 RID: 393
			// (get) Token: 0x06000FE4 RID: 4068 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000189")]
			public string ProductLabel
			{
				[Token(Token = "0x6000FE4")]
				[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700018A RID: 394
			// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700018A")]
			public KourindoStaticMerchandiseProfile.KourindoStaticMerchandise.Currency[] ProductCurrency
			{
				[Token(Token = "0x6000FE5")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700018B RID: 395
			// (get) Token: 0x06000FE6 RID: 4070 RVA: 0x00006558 File Offset: 0x00004758
			[Token(Token = "0x1700018B")]
			public Product ProvideProduct
			{
				[Token(Token = "0x6000FE6")]
				[Address(RVA = "0x92D4F0", Offset = "0x92BEF0", VA = "0x18092D4F0")]
				get
				{
					return default(Product);
				}
			}

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x00006570 File Offset: 0x00004770
			// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700018C")]
			public int RemainingNum
			{
				[Token(Token = "0x6000FE7")]
				[Address(RVA = "0x79D9A0", Offset = "0x79C3A0", VA = "0x18079D9A0")]
				[CompilerGenerated]
				readonly get
				{
					return 0;
				}
				[Token(Token = "0x6000FE8")]
				[Address(RVA = "0x8EDC80", Offset = "0x8EC680", VA = "0x1808EDC80")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700018D RID: 397
			// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x00006588 File Offset: 0x00004788
			[Token(Token = "0x1700018D")]
			public bool IsAvailable
			{
				[Token(Token = "0x6000FE9")]
				[Address(RVA = "0x92D4E0", Offset = "0x92BEE0", VA = "0x18092D4E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000FEA RID: 4074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000FEA")]
			[Address(RVA = "0x92D280", Offset = "0x92BC80", VA = "0x18092D280")]
			public KourindouStaticMerchandiseKey(Product.ProductType productType, int id, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise kourindouProduct)
			{
			}

			// Token: 0x06000FEB RID: 4075 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000FEB")]
			[Address(RVA = "0x92D020", Offset = "0x92BA20", VA = "0x18092D020")]
			public KourindouStaticMerchandiseKey(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise kourindouProduct)
			{
			}

			// Token: 0x06000FEC RID: 4076 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000FEC")]
			[Address(RVA = "0x92D000", Offset = "0x92BA00", VA = "0x18092D000")]
			public void SetNewProduct(Product product)
			{
			}

			// Token: 0x04000EA7 RID: 3751
			[Token(Token = "0x4000EA7")]
			[FieldOffset(Offset = "0x0")]
			public DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey.MerchandiseType KourindouMerchandiseType;

			// Token: 0x04000EA8 RID: 3752
			[Token(Token = "0x4000EA8")]
			[FieldOffset(Offset = "0x4")]
			public Product.ProductType ProductType;

			// Token: 0x04000EA9 RID: 3753
			[Token(Token = "0x4000EA9")]
			[FieldOffset(Offset = "0x8")]
			public int Id;

			// Token: 0x04000EAA RID: 3754
			[Token(Token = "0x4000EAA")]
			[FieldOffset(Offset = "0x10")]
			private KourindoStaticMerchandiseProfile.KourindoStaticMerchandise KourindouProduct;

			// Token: 0x020002C0 RID: 704
			[Token(Token = "0x20002C0")]
			public enum MerchandiseType
			{
				// Token: 0x04000EAE RID: 3758
				[Token(Token = "0x4000EAE")]
				Static,
				// Token: 0x04000EAF RID: 3759
				[Token(Token = "0x4000EAF")]
				Daily
			}
		}

		// Token: 0x020002C2 RID: 706
		[Token(Token = "0x20002C2")]
		private class ProductKeyEqualityComparer : IEqualityComparer<DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey>
		{
			// Token: 0x06000FF3 RID: 4083 RVA: 0x00006600 File Offset: 0x00004800
			[Token(Token = "0x6000FF3")]
			[Address(RVA = "0x92D510", Offset = "0x92BF10", VA = "0x18092D510", Slot = "4")]
			public bool Equals(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey x, DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey y)
			{
				return default(bool);
			}

			// Token: 0x06000FF4 RID: 4084 RVA: 0x00006618 File Offset: 0x00004818
			[Token(Token = "0x6000FF4")]
			[Address(RVA = "0x92D570", Offset = "0x92BF70", VA = "0x18092D570", Slot = "5")]
			public int GetHashCode(DaySceneKourindoShopPannel.KourindouStaticMerchandiseKey obj)
			{
				return 0;
			}

			// Token: 0x06000FF5 RID: 4085 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000FF5")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			public ProductKeyEqualityComparer()
			{
			}
		}

		// Token: 0x020002C3 RID: 707
		[Token(Token = "0x20002C3")]
		private enum KourindouMerchandiseType
		{
			// Token: 0x04000EB6 RID: 3766
			[Token(Token = "0x4000EB6")]
			Daily,
			// Token: 0x04000EB7 RID: 3767
			[Token(Token = "0x4000EB7")]
			Cooker,
			// Token: 0x04000EB8 RID: 3768
			[Token(Token = "0x4000EB8")]
			Other,
			// Token: 0x04000EB9 RID: 3769
			[Token(Token = "0x4000EB9")]
			None
		}

		// Token: 0x020002C4 RID: 708
		[Token(Token = "0x20002C4")]
		private enum ReselectType
		{
			// Token: 0x04000EBB RID: 3771
			[Token(Token = "0x4000EBB")]
			Default,
			// Token: 0x04000EBC RID: 3772
			[Token(Token = "0x4000EBC")]
			PreferShelf,
			// Token: 0x04000EBD RID: 3773
			[Token(Token = "0x4000EBD")]
			PreferCart
		}
	}
}
