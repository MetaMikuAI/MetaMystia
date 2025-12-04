using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.UI;
using Common.UI.QTEUtility;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Managers;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using NightScene.GuestManagementUtility;
using NightScene.UI.CookingUtility;
using NightScene.UI.GuestManagementUtility;
using NightScene.UI.HUDUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace NightScene.UI
{
	// Token: 0x020006A4 RID: 1700
	[Token(Token = "0x20006A4")]
	[GenerateCleanupMethod]
	public class WorkSceneSustainedPannel : ExtendedSustainedPannel
	{
		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06002828 RID: 10280 RVA: 0x0000ED18 File Offset: 0x0000CF18
		// (set) Token: 0x06002829 RID: 10281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A3")]
		public bool KickBtnHold
		{
			[Token(Token = "0x6002828")]
			[Address(RVA = "0x55B080", Offset = "0x559A80", VA = "0x18055B080")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002829")]
			[Address(RVA = "0x55B0A0", Offset = "0x559AA0", VA = "0x18055B0A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x0600282A RID: 10282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A4")]
		public RectTransform BufferRectTransform
		{
			[Token(Token = "0x600282A")]
			[Address(RVA = "0x48A610", Offset = "0x489010", VA = "0x18048A610")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x0600282B RID: 10283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A5")]
		public override string HoldActionMap
		{
			[Token(Token = "0x600282B")]
			[Address(RVA = "0x55AFB0", Offset = "0x5599B0", VA = "0x18055AFB0", Slot = "39")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x0600282C RID: 10284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005A6")]
		public override string HoldActionName
		{
			[Token(Token = "0x600282C")]
			[Address(RVA = "0x55AFE0", Offset = "0x5599E0", VA = "0x18055AFE0", Slot = "40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x0000ED30 File Offset: 0x0000CF30
		[Token(Token = "0x170005A7")]
		public override AdpUIPanelManager.RequestedInputMode RequestedInputMode
		{
			[Token(Token = "0x600282D")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "17")]
			get
			{
				return AdpUIPanelManager.RequestedInputMode.Player;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x0600282E RID: 10286 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600282F RID: 10287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A8")]
		public Action<InputAction.CallbackContext> OnSecondarySwitchHoldStartHandle
		{
			[Token(Token = "0x600282E")]
			[Address(RVA = "0x48A780", Offset = "0x489180", VA = "0x18048A780")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x600282F")]
			[Address(RVA = "0x48ABA0", Offset = "0x4895A0", VA = "0x18048ABA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06002830 RID: 10288 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002831 RID: 10289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005A9")]
		public Action<InputAction.CallbackContext> OnSecondarySwitchHoldEndHandle
		{
			[Token(Token = "0x6002830")]
			[Address(RVA = "0x48A8B0", Offset = "0x4892B0", VA = "0x18048A8B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6002831")]
			[Address(RVA = "0x55B0B0", Offset = "0x559AB0", VA = "0x18055B0B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06002832 RID: 10290 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002833 RID: 10291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AA")]
		public Action<InputAction.CallbackContext> OnTertiarySwitchHandle
		{
			[Token(Token = "0x6002832")]
			[Address(RVA = "0x48A620", Offset = "0x489020", VA = "0x18048A620")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6002833")]
			[Address(RVA = "0x55B0D0", Offset = "0x559AD0", VA = "0x18055B0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06002834 RID: 10292 RVA: 0x0000ED48 File Offset: 0x0000CF48
		[Token(Token = "0x170005AB")]
		public bool IsTrayOpened
		{
			[Token(Token = "0x6002834")]
			[Address(RVA = "0x55AFF0", Offset = "0x5599F0", VA = "0x18055AFF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x0000ED60 File Offset: 0x0000CF60
		// (set) Token: 0x06002836 RID: 10294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005AC")]
		public bool ShouldReopenThrowDeliverPanel
		{
			[Token(Token = "0x6002835")]
			[Address(RVA = "0x55B090", Offset = "0x559A90", VA = "0x18055B090")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002836")]
			[Address(RVA = "0x55B0F0", Offset = "0x559AF0", VA = "0x18055B0F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002837")]
		[Address(RVA = "0x5590E0", Offset = "0x557AE0", VA = "0x1805590E0", Slot = "34")]
		protected override void OnPannelPostInitialize()
		{
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002838")]
		[Address(RVA = "0x5596C0", Offset = "0x5580C0", VA = "0x1805596C0", Slot = "38")]
		protected override void OnPannelPostOpen()
		{
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002839")]
		[Address(RVA = "0x55AAE0", Offset = "0x5594E0", VA = "0x18055AAE0")]
		public void SetKickButtonAvailability(Action onSubmitCallback)
		{
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283A")]
		[Address(RVA = "0x55A5D0", Offset = "0x558FD0", VA = "0x18055A5D0")]
		public void OpenThrowDeliverPanel()
		{
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283B")]
		[Address(RVA = "0x558FE0", Offset = "0x5579E0", VA = "0x180558FE0", Slot = "41")]
		public override void OnFastForwardSubmit()
		{
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283C")]
		[Address(RVA = "0x559B00", Offset = "0x558500", VA = "0x180559B00")]
		public void OpenDailyPanelParameterless()
		{
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283D")]
		[Address(RVA = "0x559B30", Offset = "0x558530", VA = "0x180559B30")]
		public void OpenDailyPannel([Optional] Action onPannelCloseCallback)
		{
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283E")]
		[Address(RVA = "0x559890", Offset = "0x558290", VA = "0x180559890")]
		public void OpenCookingSelectionPannel(CookController cookController, float setIngredientFieldAlpha, float setRecipeFieldAlpha)
		{
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283F")]
		[Address(RVA = "0x559FD0", Offset = "0x5589D0", VA = "0x180559FD0")]
		public void OpenQTEPanelManual(float qteMultiplier, Action<float> onPanelClose)
		{
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002840")]
		[Address(RVA = "0x559C30", Offset = "0x558630", VA = "0x180559C30")]
		public void OpenEmptyDeskPannel(CookController cookController)
		{
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002841")]
		[Address(RVA = "0x55A380", Offset = "0x558D80", VA = "0x18055A380")]
		public void OpenStoragePannel(Sellable.SellableType sellableType, float setFoodAlpha, float setBevAlpha)
		{
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002842")]
		[Address(RVA = "0x5596F0", Offset = "0x5580F0", VA = "0x1805596F0")]
		public void OpenBinPannel()
		{
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002843")]
		[Address(RVA = "0x55A060", Offset = "0x558A60", VA = "0x18055A060")]
		public void OpenServePanel(bool isThrowDeliverMode, GuestsManager.OrderBase order, Action onOrderEvaluate, Action<int> onRecoverPatient, bool isGuestManualControlled, Action<Sprite> onFoodDelieverStatusUpdated, Action<Sprite> onBevDelieverStatusUpdated, GuestGroupController currentGuestController)
		{
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002844")]
		[Address(RVA = "0x55A8A0", Offset = "0x5592A0", VA = "0x18055A8A0")]
		public WorkSceneTrayPannel OpenTrayPanel(WorkSceneTrayPannel.PannelOpenContext OpenContext)
		{
			return null;
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002845")]
		[Address(RVA = "0x558E10", Offset = "0x557810", VA = "0x180558E10")]
		public void CloseTrayPanel()
		{
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002846")]
		[Address(RVA = "0x558F60", Offset = "0x557960", VA = "0x180558F60", Slot = "30")]
		protected override void OnCurrentPanelLayerChanged(IEnumerable<UIPanelBaseImpl> currentLayer)
		{
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002847")]
		[Address(RVA = "0x55AD10", Offset = "0x559710", VA = "0x18055AD10")]
		private void TryExecuteHold(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002848")]
		[Address(RVA = "0x55AD70", Offset = "0x559770", VA = "0x18055AD70")]
		private void TryReleaseHold(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002849")]
		[Address(RVA = "0x55ACB0", Offset = "0x5596B0", VA = "0x18055ACB0")]
		private void TryExecuteHoldKickButton(InputAction.CallbackContext _)
		{
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284A")]
		[Address(RVA = "0x55AD40", Offset = "0x559740", VA = "0x18055AD40")]
		private void TryReleaseHoldKickButton(InputAction.CallbackContext _)
		{
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284B")]
		protected override void OnPanelWillOpen<T>(T panelParent)
		{
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284C")]
		[Address(RVA = "0x5590A0", Offset = "0x557AA0", VA = "0x1805590A0", Slot = "37")]
		protected override void OnPanelClosed()
		{
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x0000ED78 File Offset: 0x0000CF78
		[Token(Token = "0x600284D")]
		[Address(RVA = "0x559E00", Offset = "0x558800", VA = "0x180559E00")]
		private UniTaskVoid OpenQTEPanelForCook(float qteMultiplier, CookController cookController)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x0000ED90 File Offset: 0x0000CF90
		[Token(Token = "0x600284E")]
		[Address(RVA = "0x559EC0", Offset = "0x5588C0", VA = "0x180559EC0")]
		private UniTask<float> OpenQTEPanelInternalAsync(float qteMultiplier)
		{
			return default(UniTask<float>);
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600284F")]
		[Address(RVA = "0x55A750", Offset = "0x559150", VA = "0x18055A750")]
		public void OpenTrayPanelVisualOnly(AdpUIPanelManager.RequestedInputMode requestedInputMode)
		{
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002850")]
		[Address(RVA = "0x558FC0", Offset = "0x5579C0", VA = "0x180558FC0", Slot = "32")]
		protected override void OnExitExtern()
		{
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002851")]
		[Address(RVA = "0x558C30", Offset = "0x557630", VA = "0x180558C30", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002852")]
		[Address(RVA = "0x55AF00", Offset = "0x559900", VA = "0x18055AF00")]
		public WorkSceneSustainedPannel()
		{
		}

		// Token: 0x04002496 RID: 9366
		[Token(Token = "0x4002496")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public UIButtonSimple DailyBtn;

		// Token: 0x04002497 RID: 9367
		[Token(Token = "0x4002497")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public UIButtonHold KickBtn;

		// Token: 0x04002498 RID: 9368
		[Token(Token = "0x4002498")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public CanvasGroup KickBtnGroup;

		// Token: 0x0400249A RID: 9370
		[Token(Token = "0x400249A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public WorkSceneTrayPannel WorkSceneTrayPannel;

		// Token: 0x0400249B RID: 9371
		[Token(Token = "0x400249B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public WorkSceneDailyDisplayerPannel WorkSceneDailyDisplayerPannel;

		// Token: 0x0400249C RID: 9372
		[Token(Token = "0x400249C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public WorkSceneCookingSelectionPannel WorkSceneCookingSelectionPannel;

		// Token: 0x0400249D RID: 9373
		[Token(Token = "0x400249D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public WorkSceneEmptyDeskPannel WorkSceneEmptyDeskPannel;

		// Token: 0x0400249E RID: 9374
		[Token(Token = "0x400249E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public WorkSceneBinPannel WorkSceneBinPannel;

		// Token: 0x0400249F RID: 9375
		[Token(Token = "0x400249F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public WorkSceneServePannel WorkSceneServePannel;

		// Token: 0x040024A0 RID: 9376
		[Token(Token = "0x40024A0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public QTEPannel WorkSceneQTEPannel;

		// Token: 0x040024A1 RID: 9377
		[Token(Token = "0x40024A1")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public WorkSceneLegacyQTEPannel WorkSceneLegacyQTEPannel;

		// Token: 0x040024A2 RID: 9378
		[Token(Token = "0x40024A2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public WorkSceneStoragePannel WorkSceneStoragePannel;

		// Token: 0x040024A3 RID: 9379
		[Token(Token = "0x40024A3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public WorkSceneThrowDeliverPanel WorkSceneThrowDeliverPanel;

		// Token: 0x040024A4 RID: 9380
		[Token(Token = "0x40024A4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private Image m_GotoDailyDisplayerBlocker;

		// Token: 0x040024A5 RID: 9381
		[Token(Token = "0x40024A5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private RectTransform m_BufferRectTransform;

		// Token: 0x040024A6 RID: 9382
		[Token(Token = "0x40024A6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private readonly global::UnityEngine.Object m_KickBtnTweenKey;

		// Token: 0x040024A7 RID: 9383
		[Token(Token = "0x40024A7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private CanvasGroup[] KickBtnGroupArray;

		// Token: 0x040024A8 RID: 9384
		[Token(Token = "0x40024A8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool m_IfKickBtnActived;

		// Token: 0x040024A9 RID: 9385
		[Token(Token = "0x40024A9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private WorkSceneTrayPannel m_WorkSceneTrayPannelInstance;

		// Token: 0x040024AE RID: 9390
		[Token(Token = "0x40024AE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private string m_LastCloseTrayStackTrace;
	}
}
