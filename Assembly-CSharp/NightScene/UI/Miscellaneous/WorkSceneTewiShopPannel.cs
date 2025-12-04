using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.Miscellaneous
{
	// Token: 0x020006B8 RID: 1720
	[Token(Token = "0x20006B8")]
	[GenerateCleanupMethod]
	public class WorkSceneTewiShopPannel : UIPanel
	{
		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x0600289E RID: 10398 RVA: 0x0000EE68 File Offset: 0x0000D068
		[Token(Token = "0x170005B3")]
		private int Price
		{
			[Token(Token = "0x600289E")]
			[Address(RVA = "0x55C110", Offset = "0x55AB10", VA = "0x18055C110")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x0600289F RID: 10399 RVA: 0x0000EE80 File Offset: 0x0000D080
		// (set) Token: 0x060028A0 RID: 10400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B4")]
		public bool IsCheating
		{
			[Token(Token = "0x600289F")]
			[Address(RVA = "0x55C0E0", Offset = "0x55AAE0", VA = "0x18055C0E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028A0")]
			[Address(RVA = "0x55C2E0", Offset = "0x55ACE0", VA = "0x18055C2E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060028A1 RID: 10401 RVA: 0x0000EE98 File Offset: 0x0000D098
		// (set) Token: 0x060028A2 RID: 10402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B5")]
		public bool HaveBought
		{
			[Token(Token = "0x60028A1")]
			[Address(RVA = "0x55C0D0", Offset = "0x55AAD0", VA = "0x18055C0D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60028A2")]
			[Address(RVA = "0x55C2D0", Offset = "0x55ACD0", VA = "0x18055C2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060028A3 RID: 10403 RVA: 0x0000EEB0 File Offset: 0x0000D0B0
		// (set) Token: 0x060028A4 RID: 10404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B6")]
		public WorkSceneTewiShopPannel.PannelOpenContext? OpenContext
		{
			[Token(Token = "0x60028A3")]
			[Address(RVA = "0x55C0F0", Offset = "0x55AAF0", VA = "0x18055C0F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60028A4")]
			[Address(RVA = "0x55C2F0", Offset = "0x55ACF0", VA = "0x18055C2F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A5")]
		[Address(RVA = "0x55B4D0", Offset = "0x559ED0", VA = "0x18055B4D0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A6")]
		[Address(RVA = "0x55B5A0", Offset = "0x559FA0", VA = "0x18055B5A0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x0000EEC8 File Offset: 0x0000D0C8
		[Token(Token = "0x60028A7")]
		[Address(RVA = "0x55B430", Offset = "0x559E30", VA = "0x18055B430")]
		private long GetPlayerFund()
		{
			return 0L;
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A8")]
		[Address(RVA = "0x55B370", Offset = "0x559D70", VA = "0x18055B370")]
		private void DeductPlayerFund(int price)
		{
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028A9")]
		[Address(RVA = "0x55B100", Offset = "0x559B00", VA = "0x18055B100", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028AA")]
		[Address(RVA = "0x55C040", Offset = "0x55AA40", VA = "0x18055C040")]
		public WorkSceneTewiShopPannel()
		{
		}

		// Token: 0x040024F9 RID: 9465
		[Token(Token = "0x40024F9")]
		[FieldOffset(Offset = "0x70")]
		public UIButtonSimple item1;

		// Token: 0x040024FA RID: 9466
		[Token(Token = "0x40024FA")]
		[FieldOffset(Offset = "0x78")]
		public UIButtonSimple item2;

		// Token: 0x040024FB RID: 9467
		[Token(Token = "0x40024FB")]
		[FieldOffset(Offset = "0x80")]
		public UIButtonSimple item3;

		// Token: 0x040024FC RID: 9468
		[Token(Token = "0x40024FC")]
		[FieldOffset(Offset = "0x88")]
		public Image image1;

		// Token: 0x040024FD RID: 9469
		[Token(Token = "0x40024FD")]
		[FieldOffset(Offset = "0x90")]
		public Image image2;

		// Token: 0x040024FE RID: 9470
		[Token(Token = "0x40024FE")]
		[FieldOffset(Offset = "0x98")]
		public Image image3;

		// Token: 0x040024FF RID: 9471
		[Token(Token = "0x40024FF")]
		[FieldOffset(Offset = "0xA0")]
		public SellableDescriber describer;

		// Token: 0x04002500 RID: 9472
		[Token(Token = "0x4002500")]
		[FieldOffset(Offset = "0xA8")]
		public DescriberSwitcher describerSwitcher;

		// Token: 0x04002501 RID: 9473
		[Token(Token = "0x4002501")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject indicator1;

		// Token: 0x04002502 RID: 9474
		[Token(Token = "0x4002502")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject indicator2;

		// Token: 0x04002503 RID: 9475
		[Token(Token = "0x4002503")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject indicator3;

		// Token: 0x04002504 RID: 9476
		[Token(Token = "0x4002504")]
		[FieldOffset(Offset = "0xC8")]
		public TextMeshProUGUI price1;

		// Token: 0x04002505 RID: 9477
		[Token(Token = "0x4002505")]
		[FieldOffset(Offset = "0xD0")]
		public TextMeshProUGUI price2;

		// Token: 0x04002506 RID: 9478
		[Token(Token = "0x4002506")]
		[FieldOffset(Offset = "0xD8")]
		public TextMeshProUGUI price3;

		// Token: 0x04002507 RID: 9479
		[Token(Token = "0x4002507")]
		[FieldOffset(Offset = "0xE0")]
		public TextMeshProUGUI count1A;

		// Token: 0x04002508 RID: 9480
		[Token(Token = "0x4002508")]
		[FieldOffset(Offset = "0xE8")]
		public TextMeshProUGUI count2A;

		// Token: 0x04002509 RID: 9481
		[Token(Token = "0x4002509")]
		[FieldOffset(Offset = "0xF0")]
		public TextMeshProUGUI count3A;

		// Token: 0x0400250A RID: 9482
		[Token(Token = "0x400250A")]
		[FieldOffset(Offset = "0xF8")]
		public TextMeshProUGUI count1B;

		// Token: 0x0400250B RID: 9483
		[Token(Token = "0x400250B")]
		[FieldOffset(Offset = "0x100")]
		public TextMeshProUGUI count2B;

		// Token: 0x0400250C RID: 9484
		[Token(Token = "0x400250C")]
		[FieldOffset(Offset = "0x108")]
		public TextMeshProUGUI count3B;

		// Token: 0x0400250D RID: 9485
		[Token(Token = "0x400250D")]
		[FieldOffset(Offset = "0x110")]
		public TextMeshProUGUI inStorage;

		// Token: 0x0400250E RID: 9486
		[Token(Token = "0x400250E")]
		[FieldOffset(Offset = "0x118")]
		public UIButtonHold buy;

		// Token: 0x0400250F RID: 9487
		[Token(Token = "0x400250F")]
		[FieldOffset(Offset = "0x120")]
		public UIButtonHold cancel;

		// Token: 0x04002510 RID: 9488
		[Token(Token = "0x4002510")]
		[FieldOffset(Offset = "0x128")]
		public TextMeshProUGUI priceRemains;

		// Token: 0x04002511 RID: 9489
		[Token(Token = "0x4002511")]
		[FieldOffset(Offset = "0x130")]
		public TextMeshProUGUI priceTotal;

		// Token: 0x04002512 RID: 9490
		[Token(Token = "0x4002512")]
		[FieldOffset(Offset = "0x138")]
		public AudioClip OnBuyAudio;

		// Token: 0x04002513 RID: 9491
		[Token(Token = "0x4002513")]
		[FieldOffset(Offset = "0x140")]
		private readonly HashSet<Product> cart;

		// Token: 0x04002514 RID: 9492
		[Token(Token = "0x4002514")]
		[FieldOffset(Offset = "0x148")]
		private int priceMultiplier;

		// Token: 0x020006B9 RID: 1721
		[Token(Token = "0x20006B9")]
		public readonly struct PannelOpenContext
		{
			// Token: 0x060028AC RID: 10412 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60028AC")]
			[Address(RVA = "0x54D650", Offset = "0x54C050", VA = "0x18054D650")]
			public PannelOpenContext(Product[] merchandices, int priceMultiplier)
			{
			}

			// Token: 0x04002518 RID: 9496
			[Token(Token = "0x4002518")]
			[FieldOffset(Offset = "0x0")]
			public readonly Product[] Merchandices;

			// Token: 0x04002519 RID: 9497
			[Token(Token = "0x4002519")]
			[FieldOffset(Offset = "0x8")]
			public readonly int PriceMultiplier;
		}
	}
}
