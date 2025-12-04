using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Common.UI;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using Plugins.DEYU;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.GuestManagementUtility
{
	// Token: 0x020006C3 RID: 1731
	[Token(Token = "0x20006C3")]
	[GenerateCleanupMethod]
	public class WorkSceneServePannel : UIPanelExtern, IExternalPanel
	{
		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060028E5 RID: 10469 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		[Token(Token = "0x170005BA")]
		private bool isThrowDeliverMode
		{
			[Token(Token = "0x60028E5")]
			[Address(RVA = "0x558880", Offset = "0x557280", VA = "0x180558880")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060028E6 RID: 10470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BB")]
		private GuestsManager.OrderBase operatingOrder
		{
			[Token(Token = "0x60028E6")]
			[Address(RVA = "0x558B50", Offset = "0x557550", VA = "0x180558B50")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x060028E7 RID: 10471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BC")]
		private Action onOrderEvaluate
		{
			[Token(Token = "0x60028E7")]
			[Address(RVA = "0x558A30", Offset = "0x557430", VA = "0x180558A30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x060028E8 RID: 10472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BD")]
		private Action<int> onRecoverPatient
		{
			[Token(Token = "0x60028E8")]
			[Address(RVA = "0x558AC0", Offset = "0x5574C0", VA = "0x180558AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x060028E9 RID: 10473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BE")]
		private Action<Sprite> onFoodDelieverStatusUpdated
		{
			[Token(Token = "0x60028E9")]
			[Address(RVA = "0x5589A0", Offset = "0x5573A0", VA = "0x1805589A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x060028EA RID: 10474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005BF")]
		private Action<Sprite> onBevDelieverStatusUpdated
		{
			[Token(Token = "0x60028EA")]
			[Address(RVA = "0x558910", Offset = "0x557310", VA = "0x180558910")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x060028EB RID: 10475 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		[Token(Token = "0x170005C0")]
		private bool isGuestManualControlled
		{
			[Token(Token = "0x60028EB")]
			[Address(RVA = "0x5587F0", Offset = "0x5571F0", VA = "0x1805587F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x060028EC RID: 10476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005C1")]
		private GuestGroupController currentGuestController
		{
			[Token(Token = "0x60028EC")]
			[Address(RVA = "0x558760", Offset = "0x557160", VA = "0x180558760")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x060028ED RID: 10477 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		// (set) Token: 0x060028EE RID: 10478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005C2")]
		public WorkSceneServePannel.PannelOpenContext? OpenContext
		{
			[Token(Token = "0x60028ED")]
			[Address(RVA = "0x558720", Offset = "0x557120", VA = "0x180558720")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60028EE")]
			[Address(RVA = "0x558BE0", Offset = "0x5575E0", VA = "0x180558BE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028EF")]
		[Address(RVA = "0x555710", Offset = "0x554110", VA = "0x180555710", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F0")]
		[Address(RVA = "0x556790", Offset = "0x555190", VA = "0x180556790", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060028F1 RID: 10481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F1")]
		[Address(RVA = "0x556810", Offset = "0x555210", VA = "0x180556810", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060028F2 RID: 10482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F2")]
		[Address(RVA = "0x556520", Offset = "0x554F20", VA = "0x180556520", Slot = "32")]
		protected override void OnExitExtern()
		{
		}

		// Token: 0x060028F3 RID: 10483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F3")]
		[Address(RVA = "0x556560", Offset = "0x554F60", VA = "0x180556560", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060028F4 RID: 10484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60028F4")]
		[Address(RVA = "0x557AC0", Offset = "0x5564C0", VA = "0x180557AC0")]
		private IEnumerator OnThrowDelivering()
		{
			return null;
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F5")]
		[Address(RVA = "0x5562A0", Offset = "0x554CA0", VA = "0x1805562A0")]
		private void InvokeOrderUpdate()
		{
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F6")]
		[Address(RVA = "0x5561D0", Offset = "0x554BD0", VA = "0x1805561D0")]
		private void FinishOrderStatus(bool isGuestManualControlled, GuestsManager.OrderBase operatingOrder, Sellable willServeFood, Sellable willServeBev, Action onOrderEvaluate, Action<int> onRecoverPatient)
		{
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F7")]
		[Address(RVA = "0x558310", Offset = "0x556D10", VA = "0x180558310")]
		private void SetServedVisualOnUI(UIButtonSimple served, Image servedOutline, Sellable toServe, bool canCancel)
		{
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F8")]
		[Address(RVA = "0x557C00", Offset = "0x556600", VA = "0x180557C00")]
		private void ResetServedVisualOnUI(UIButtonSimple served, Image servedOutline)
		{
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F9")]
		[Address(RVA = "0x557C70", Offset = "0x556670", VA = "0x180557C70")]
		private void Send(Sellable toSend)
		{
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FA")]
		[Address(RVA = "0x555910", Offset = "0x554310", VA = "0x180555910")]
		private void Cancel(Sellable toCancel)
		{
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FB")]
		[Address(RVA = "0x558690", Offset = "0x557090", VA = "0x180558690")]
		private void UpdateFoodVisualOnDesk()
		{
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FC")]
		[Address(RVA = "0x558600", Offset = "0x557000", VA = "0x180558600")]
		private void UpdateBevVisualOnDesk()
		{
		}

		// Token: 0x060028FD RID: 10493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FD")]
		[Address(RVA = "0x557B40", Offset = "0x556540", VA = "0x180557B40")]
		private void RefreshPannel()
		{
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FE")]
		[Address(RVA = "0x556030", Offset = "0x554A30", VA = "0x180556030", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028FF")]
		[Address(RVA = "0x410B60", Offset = "0x40F560", VA = "0x180410B60")]
		public WorkSceneServePannel()
		{
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002900")]
		[Address(RVA = "0x5561C0", Offset = "0x554BC0", VA = "0x1805561C0", Slot = "33")]
		private void Common.UI.IExternalPanel.CloseExternPanel()
		{
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002901")]
		[Address(RVA = "0x558580", Offset = "0x556F80", VA = "0x180558580")]
		[CompilerGenerated]
		private void <OnExitExtern>g__ReturnPass|42_0(ref Sellable sellable)
		{
		}

		// Token: 0x0400255D RID: 9565
		[Token(Token = "0x400255D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActionExecutionScheduler m_Scheduler;

		// Token: 0x0400255E RID: 9566
		[Token(Token = "0x400255E")]
		[FieldOffset(Offset = "0x78")]
		public CanvasGroup describerPannel;

		// Token: 0x0400255F RID: 9567
		[Token(Token = "0x400255F")]
		[FieldOffset(Offset = "0x80")]
		public CanvasGroup describerSubPannel;

		// Token: 0x04002560 RID: 9568
		[Token(Token = "0x4002560")]
		[FieldOffset(Offset = "0x88")]
		public GameObject normalRequest;

		// Token: 0x04002561 RID: 9569
		[Token(Token = "0x4002561")]
		[FieldOffset(Offset = "0x90")]
		public GameObject specialRequest;

		// Token: 0x04002562 RID: 9570
		[Token(Token = "0x4002562")]
		[FieldOffset(Offset = "0x98")]
		public AudioClip onClose;

		// Token: 0x04002563 RID: 9571
		[Token(Token = "0x4002563")]
		[FieldOffset(Offset = "0xA0")]
		public AudioClip onOpen;

		// Token: 0x04002564 RID: 9572
		[Token(Token = "0x4002564")]
		[FieldOffset(Offset = "0xA8")]
		public UIButtonSimple servBev;

		// Token: 0x04002565 RID: 9573
		[Token(Token = "0x4002565")]
		[FieldOffset(Offset = "0xB0")]
		public Image servBevOutline;

		// Token: 0x04002566 RID: 9574
		[Token(Token = "0x4002566")]
		[FieldOffset(Offset = "0xB8")]
		public SellableDescriber describer;

		// Token: 0x04002567 RID: 9575
		[Token(Token = "0x4002567")]
		[FieldOffset(Offset = "0xC0")]
		public UIButtonSimple servFood;

		// Token: 0x04002568 RID: 9576
		[Token(Token = "0x4002568")]
		[FieldOffset(Offset = "0xC8")]
		public Image servFoodOutline;

		// Token: 0x04002569 RID: 9577
		[Token(Token = "0x4002569")]
		[FieldOffset(Offset = "0xD0")]
		public TextMeshProUGUI guestName;

		// Token: 0x0400256A RID: 9578
		[Token(Token = "0x400256A")]
		[FieldOffset(Offset = "0xD8")]
		public Color onServedColor;

		// Token: 0x0400256B RID: 9579
		[Token(Token = "0x400256B")]
		[FieldOffset(Offset = "0xE8")]
		public TextMeshProUGUI deskCodeText;

		// Token: 0x0400256C RID: 9580
		[Token(Token = "0x400256C")]
		[FieldOffset(Offset = "0xF0")]
		private WorkSceneTrayPannel m_CurrentTray;

		// Token: 0x0400256D RID: 9581
		[Token(Token = "0x400256D")]
		[FieldOffset(Offset = "0xF8")]
		private CanvasGroup m_DescriberCanvasGroup;

		// Token: 0x0400256E RID: 9582
		[Token(Token = "0x400256E")]
		[FieldOffset(Offset = "0x100")]
		private Sellable willServeBeverage;

		// Token: 0x0400256F RID: 9583
		[Token(Token = "0x400256F")]
		[FieldOffset(Offset = "0x108")]
		private Sellable willServeFood;

		// Token: 0x020006C4 RID: 1732
		[Token(Token = "0x20006C4")]
		public struct PannelOpenContext
		{
			// Token: 0x06002902 RID: 10498 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002902")]
			[Address(RVA = "0x54D5C0", Offset = "0x54BFC0", VA = "0x18054D5C0")]
			public PannelOpenContext(bool isThrowDeliverMode, GuestsManager.OrderBase operatingOrder, Action onOrderEvaluate, Action<int> onRecoverPatient, bool isGuestManualControlled, Action<Sprite> onFoodDelieverStatusUpdated, Action<Sprite> onBevDelieverStatusUpdated, GuestGroupController currentGuestController)
			{
			}

			// Token: 0x04002571 RID: 9585
			[Token(Token = "0x4002571")]
			[FieldOffset(Offset = "0x0")]
			public readonly bool isThrowDeliverMode;

			// Token: 0x04002572 RID: 9586
			[Token(Token = "0x4002572")]
			[FieldOffset(Offset = "0x8")]
			public readonly GuestsManager.OrderBase operatingOrder;

			// Token: 0x04002573 RID: 9587
			[Token(Token = "0x4002573")]
			[FieldOffset(Offset = "0x10")]
			public readonly Action onOrderEvaluate;

			// Token: 0x04002574 RID: 9588
			[Token(Token = "0x4002574")]
			[FieldOffset(Offset = "0x18")]
			public readonly Action<int> onRecoverPatient;

			// Token: 0x04002575 RID: 9589
			[Token(Token = "0x4002575")]
			[FieldOffset(Offset = "0x20")]
			public readonly bool isGuestManualControlled;

			// Token: 0x04002576 RID: 9590
			[Token(Token = "0x4002576")]
			[FieldOffset(Offset = "0x28")]
			public readonly Action<Sprite> onFoodDelieverStatusUpdated;

			// Token: 0x04002577 RID: 9591
			[Token(Token = "0x4002577")]
			[FieldOffset(Offset = "0x30")]
			public readonly Action<Sprite> onBevDelieverStatusUpdated;

			// Token: 0x04002578 RID: 9592
			[Token(Token = "0x4002578")]
			[FieldOffset(Offset = "0x38")]
			public readonly GuestGroupController currentGuestController;
		}
	}
}
