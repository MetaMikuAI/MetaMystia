using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.UI;
using Common.UI.InfiniteSelection;
using Cysharp.Threading.Tasks;
using DayScene.UI.RogueLike;
using DEYU.AdpUISystem.Managers;
using DEYU.GraphicsCollection;
using DEYU.Singletons;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace DayScene.UI
{
	// Token: 0x02000241 RID: 577
	[Token(Token = "0x2000241")]
	[GenerateCleanupMethod]
	public class UIManager : MonoSingleton<UIManager>
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700016B")]
		public DaySceneSustainedPannel SustainedPannel
		{
			[Token(Token = "0x6000D9B")]
			[Address(RVA = "0x4D2230", Offset = "0x4D0C30", VA = "0x1804D2230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D9C")]
			[Address(RVA = "0x4D2740", Offset = "0x4D1140", VA = "0x1804D2740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x00005B50 File Offset: 0x00003D50
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700016C")]
		public int CurrentActions
		{
			[Token(Token = "0x6000D9D")]
			[Address(RVA = "0x48A690", Offset = "0x489090", VA = "0x18048A690")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000D9E")]
			[Address(RVA = "0x48AB00", Offset = "0x489500", VA = "0x18048AB00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x8FC140", Offset = "0x8FAB40", VA = "0x1808FC140")]
		public void Initialize()
		{
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00005B68 File Offset: 0x00003D68
		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x8FC670", Offset = "0x8FB070", VA = "0x1808FC670")]
		public UniTask LoadDependencies()
		{
			return default(UniTask);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x8FC810", Offset = "0x8FB210", VA = "0x1808FC810", Slot = "5")]
		protected override void OnInstanceDestroyed()
		{
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x8FB840", Offset = "0x8FA240", VA = "0x1808FB840")]
		public void Dispose()
		{
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x8FE710", Offset = "0x8FD110", VA = "0x1808FE710")]
		public void UpdateFocusIndicator(Vector3? worldCoordinate)
		{
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0x8FD230", Offset = "0x8FBC30", VA = "0x1808FD230")]
		public void OpenChatConfirmationModule(Action<bool> onFinish)
		{
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00005B80 File Offset: 0x00003D80
		[Token(Token = "0x6000DA5")]
		[Address(RVA = "0x8FCFE0", Offset = "0x8FB9E0", VA = "0x1808FCFE0")]
		private UniTaskVoid OpenChatConfirmationModuleAsyncInternal(Action<bool> onFinish)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0x8FD150", Offset = "0x8FBB50", VA = "0x1808FD150")]
		public void OpenChatConfirmationModule(Action<bool> onFinish, AdpUIPanelManager.PanelVisualMode pannelVisualMode)
		{
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00005B98 File Offset: 0x00003D98
		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x8FCF10", Offset = "0x8FB910", VA = "0x1808FCF10")]
		private UniTaskVoid OpenChatConfirmationModuleAsyncInternal(Action<bool> onFinish, AdpUIPanelManager.PanelVisualMode pannelVisualMode)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x8FD0A0", Offset = "0x8FBAA0", VA = "0x1808FD0A0")]
		public UniTask<bool> OpenChatConfirmationModuleAsync()
		{
			return default(UniTask<bool>);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00005BC8 File Offset: 0x00003DC8
		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x8FD4D0", Offset = "0x8FBED0", VA = "0x1808FD4D0")]
		public UniTask OpenEventSelectionModuleAsync(Dictionary<string, Action> options, bool useCustomTitle)
		{
			return default(UniTask);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x8FD500", Offset = "0x8FBF00", VA = "0x1808FD500")]
		public void OpenEventSelectionModule(Dictionary<string, Action> options, Action onFinish)
		{
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00005BE0 File Offset: 0x00003DE0
		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0x8FD3B0", Offset = "0x8FBDB0", VA = "0x1808FD3B0")]
		private UniTask OpenEventSelectionModuleAsyncInternal(Dictionary<string, Action> options, bool useCustomTitle, Action onFinish)
		{
			return default(UniTask);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00005BF8 File Offset: 0x00003DF8
		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0x8FD8D0", Offset = "0x8FC2D0", VA = "0x1808FD8D0")]
		public UniTask OpenPartnerSelectionModuleAsync(DaySceneIzakayaSelectorPartnerSubPannel.OpenContext dataSource)
		{
			return default(UniTask);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0x8FD5F0", Offset = "0x8FBFF0", VA = "0x1808FD5F0")]
		public UniTask<int> OpenIzakayaSelectionModuleAsync(SchedulerNode.Trigger.IzakayaLockType izakayaLockType, SchedulerNode.Trigger.IzakayaMapping[] overrideIzakayaData)
		{
			return default(UniTask<int>);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0x8FC010", Offset = "0x8FAA10", VA = "0x1808FC010")]
		public string GetTimeCode(int remainedActions)
		{
			return null;
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0x8FE810", Offset = "0x8FD210", VA = "0x1808FE810")]
		private void UpdateTime(int passAmount)
		{
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DB0")]
		[Address(RVA = "0x8FE5F0", Offset = "0x8FCFF0", VA = "0x1808FE5F0")]
		private void SetTime(int setAmount)
		{
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DB1")]
		[Address(RVA = "0x8FE6C0", Offset = "0x8FD0C0", VA = "0x1808FE6C0")]
		public void UpdateCurrentMapTitle(string placeKey)
		{
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x8FCBB0", Offset = "0x8FB5B0", VA = "0x1808FCBB0")]
		public void OpenAfterChatMenu(string specialCharacterLabel, Action onExitCallback, Action<Action> onWillExecuteDayEndEventCallback, bool shouldTriggerEvent = true, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00005C28 File Offset: 0x00003E28
		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x8FC860", Offset = "0x8FB260", VA = "0x1808FC860")]
		private UniTaskVoid OpenAfterChatMenuAsyncInternal(string specialCharacterLabel, Action onExitCallback, Action<Action> onWillExecuteDayEndEventCallback, bool shouldTriggerEvent = true, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x8FCCD0", Offset = "0x8FB6D0", VA = "0x1808FCCD0")]
		public void OpenAfterChatMenu(string normalCharacterLabel, TrackedMerchant trackedMerchant, DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback[] configurationCallback, Action onExitCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00005C40 File Offset: 0x00003E40
		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0x8FC970", Offset = "0x8FB370", VA = "0x1808FC970")]
		private UniTaskVoid OpenAfterChatMenuAsyncInternal(string normalCharacterLabel, TrackedMerchant trackedMerchant, DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback[] configurationCallback, Action onExitCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0x8FCE00", Offset = "0x8FB800", VA = "0x1808FCE00")]
		public void OpenAfterChatMenu(DaySceneChatSelectionPannel.GetSelectionConfigurationCallback[] configurationCallbacks, string endButtonTitleKey, DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback endButtonAction, Action onExitCallback, int indexToSelct = -1, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00005C58 File Offset: 0x00003E58
		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0x8FCA90", Offset = "0x8FB490", VA = "0x1808FCA90")]
		private UniTaskVoid OpenAfterChatMenuAsyncInternal(DaySceneChatSelectionPannel.GetSelectionConfigurationCallback[] configurationCallbacks, string endButtonTitleKey, DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback endButtonAction, Action onExitCallback, int indexToSelct = -1, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DB8")]
		[Address(RVA = "0x8FE100", Offset = "0x8FCB00", VA = "0x1808FE100")]
		public void OpenShopPannel(TrackedMerchant merchantData, Action onFinishCallback)
		{
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00005C70 File Offset: 0x00003E70
		[Token(Token = "0x6000DB9")]
		[Address(RVA = "0x8FE030", Offset = "0x8FCA30", VA = "0x1808FE030")]
		private UniTaskVoid OpenShopPannelAsyncInternal(TrackedMerchant merchantData, Action onFinishCallback)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DBA")]
		[Address(RVA = "0x8FD7F0", Offset = "0x8FC1F0", VA = "0x1808FD7F0")]
		public void OpenKourindouPannel(TrackedMerchant merchantData, Action onFinishCallback)
		{
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00005C88 File Offset: 0x00003E88
		[Token(Token = "0x6000DBB")]
		[Address(RVA = "0x8FD720", Offset = "0x8FC120", VA = "0x1808FD720")]
		private UniTaskVoid OpenKourindouPannelAsyncInternal(TrackedMerchant merchantData, Action onFinishCallback)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DBC")]
		[Address(RVA = "0x8FE480", Offset = "0x8FCE80", VA = "0x1808FE480")]
		private void SetCurrentTime(float progress)
		{
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00005CA0 File Offset: 0x00003EA0
		[Token(Token = "0x6000DBD")]
		[Address(RVA = "0x8FE1E0", Offset = "0x8FCBE0", VA = "0x1808FE1E0")]
		private TimeSpan RoundTime(TimeSpan timeSpan)
		{
			return default(TimeSpan);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DBE")]
		[Address(RVA = "0x8FBE70", Offset = "0x8FA870", VA = "0x1808FBE70")]
		public void GetMapTransitionTimePreview(int actionCost, out TimeSpan currentTime, out TimeSpan targetTime, out TimeSpan costTime)
		{
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DBF")]
		[Address(RVA = "0x8FE2F0", Offset = "0x8FCCF0", VA = "0x1808FE2F0")]
		public void SetCinematicTransitionEffect(bool shouldOn)
		{
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DC0")]
		[Address(RVA = "0x8FBB80", Offset = "0x8FA580", VA = "0x1808FBB80")]
		public string GetActionTimeContext(int actions)
		{
			return null;
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC1")]
		[Address(RVA = "0x8FE350", Offset = "0x8FCD50", VA = "0x1808FE350")]
		public void SetCinemativeTransitionContext(string placeKey, bool doCostTime)
		{
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC2")]
		[Address(RVA = "0x8FB350", Offset = "0x8F9D50", VA = "0x1808FB350")]
		public static void AfterRogueLike()
		{
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00005CB8 File Offset: 0x00003EB8
		[Token(Token = "0x6000DC3")]
		[Address(RVA = "0x8FD300", Offset = "0x8FBD00", VA = "0x1808FD300")]
		public static UniTask OpenCreatorsBoxPanelAsync()
		{
			return default(UniTask);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00005CD0 File Offset: 0x00003ED0
		[Token(Token = "0x6000DC4")]
		[Address(RVA = "0x8FD540", Offset = "0x8FBF40", VA = "0x1808FD540")]
		public static UniTask OpenInfiniteIngredientsPanelAsync(DLC5_InfiniteSelectionPanel.ActiveCount activeCount)
		{
			return default(UniTask);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC5")]
		[Address(RVA = "0x8FDC40", Offset = "0x8FC640", VA = "0x1808FDC40")]
		public static void OpenRogueLikeMainPanel()
		{
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00005CE8 File Offset: 0x00003EE8
		[Token(Token = "0x6000DC6")]
		[Address(RVA = "0x8FDBA0", Offset = "0x8FC5A0", VA = "0x1808FDBA0")]
		private static UniTask OpenRogueLikeMainPanelAsync()
		{
			return default(UniTask);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00005D00 File Offset: 0x00003F00
		[Token(Token = "0x6000DC7")]
		[Address(RVA = "0x8FB2B0", Offset = "0x8F9CB0", VA = "0x1808FB2B0")]
		private static UniTask AfterRogueLikeAsync()
		{
			return default(UniTask);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00005D18 File Offset: 0x00003F18
		[Token(Token = "0x6000DC8")]
		[Address(RVA = "0x8FB460", Offset = "0x8F9E60", VA = "0x1808FB460")]
		private static UniTask ChallengeLoop([Optional] Action onStartChallengeCallback, bool isStart = false)
		{
			return default(UniTask);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DC9")]
		[Address(RVA = "0x8FC6B0", Offset = "0x8FB0B0", VA = "0x1808FC6B0")]
		private static void MoveToRogueLike(string mapName, UnlockedIzakayaInfo izakayaLevel)
		{
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00005D30 File Offset: 0x00003F30
		[Token(Token = "0x6000DCA")]
		[Address(RVA = "0x8FD9C0", Offset = "0x8FC3C0", VA = "0x1808FD9C0")]
		private static UniTask<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext> OpenRogueLikeChallengeSpotSelectionPanel(RogueLikeRunTimeData runTimeData, bool isStart = false)
		{
			return default(UniTask<DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00005D48 File Offset: 0x00003F48
		[Token(Token = "0x6000DCB")]
		[Address(RVA = "0x8FDAE0", Offset = "0x8FC4E0", VA = "0x1808FDAE0")]
		private static UniTask OpenRogueLikeFailedPanelAsync(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			return default(UniTask);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00005D60 File Offset: 0x00003F60
		[Token(Token = "0x6000DCC")]
		[Address(RVA = "0x8FDF20", Offset = "0x8FC920", VA = "0x1808FDF20")]
		private static UniTask<DLC5_RogueLikeWinPanel.CloseContext> OpenRogueLikeWinPanelAsync(RogueLikeRunTimeData rogueLikeRunTimeData, bool needFadeInExit)
		{
			return default(UniTask<DLC5_RogueLikeWinPanel.CloseContext>);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00005D78 File Offset: 0x00003F78
		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x8FDE10", Offset = "0x8FC810", VA = "0x1808FDE10")]
		private static UniTask<DLC5_RogueLikeWinPanel.CloseContext> OpenRogueLikeRoundPassPanelAsync(RogueLikeRunTimeData rogueLikeRunTimeData, bool needFadeInExit)
		{
			return default(UniTask<DLC5_RogueLikeWinPanel.CloseContext>);
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00005D90 File Offset: 0x00003F90
		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x8FDD50", Offset = "0x8FC750", VA = "0x1808FDD50")]
		public static UniTask OpenRogueLikeResultPanelAsync(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			return default(UniTask);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00005DA8 File Offset: 0x00003FA8
		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x8FBAD0", Offset = "0x8FA4D0", VA = "0x1808FBAD0")]
		public static UniTask FadeInAndLeavePanelForRogueLike(Action onFadeFinish)
		{
			return default(UniTask);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0x8FB550", Offset = "0x8F9F50", VA = "0x1808FB550", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x8FE970", Offset = "0x8FD370", VA = "0x1808FE970")]
		public UIManager()
		{
		}

		// Token: 0x04000C2B RID: 3115
		[Token(Token = "0x4000C2B")]
		private const float clockTransitionDuration = 0.5f;

		// Token: 0x04000C2C RID: 3116
		[Token(Token = "0x4000C2C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator cinematicEffectController;

		// Token: 0x04000C2D RID: 3117
		[Token(Token = "0x4000C2D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ClockController actionIndicator;

		// Token: 0x04000C2E RID: 3118
		[Token(Token = "0x4000C2E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI currentTime;

		// Token: 0x04000C2F RID: 3119
		[Token(Token = "0x4000C2F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TextMeshProUGUI currentDate;

		// Token: 0x04000C30 RID: 3120
		[Token(Token = "0x4000C30")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshProUGUI travelTimeIndicator;

		// Token: 0x04000C31 RID: 3121
		[Token(Token = "0x4000C31")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ColorGradingLerpController colorGradingLerpController;

		// Token: 0x04000C32 RID: 3122
		[Token(Token = "0x4000C32")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CanvasGroup clockCanvas;

		// Token: 0x04000C33 RID: 3123
		[Token(Token = "0x4000C33")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RectTransform effectRoot;

		// Token: 0x04000C34 RID: 3124
		[Token(Token = "0x4000C34")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RectTransform buttonEffectRoot;

		// Token: 0x04000C35 RID: 3125
		[Token(Token = "0x4000C35")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Pannels")]
		public DaySceneSustainedPannel DaySceneSustainedPannel;

		// Token: 0x04000C36 RID: 3126
		[Token(Token = "0x4000C36")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AssetReferenceT<GameObject> DaySceneIzakayaSelectorPannel;

		// Token: 0x04000C37 RID: 3127
		[Token(Token = "0x4000C37")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AssetReferenceT<GameObject> DayScenePartnerSelectorPannel;

		// Token: 0x04000C38 RID: 3128
		[Token(Token = "0x4000C38")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AssetReferenceT<GameObject> DaySceneShopPannel;

		// Token: 0x04000C39 RID: 3129
		[Token(Token = "0x4000C39")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AssetReferenceT<GameObject> DaySceneKourindoShopPannel;

		// Token: 0x04000C3A RID: 3130
		[Token(Token = "0x4000C3A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AssetReferenceT<GameObject> DaySceneChatSelectionPannel;

		// Token: 0x04000C3B RID: 3131
		[Token(Token = "0x4000C3B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AssetReferenceT<GameObject> DaySceneChatConfirmationPannel;

		// Token: 0x04000C3C RID: 3132
		[Token(Token = "0x4000C3C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AssetReferenceT<GameObject> DaySceneEventSelectionPannel;

		// Token: 0x04000C3D RID: 3133
		[Token(Token = "0x4000C3D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AssetReferenceT<GameObject> DLC3_MusicGameStartPannel;

		// Token: 0x04000C3E RID: 3134
		[Token(Token = "0x4000C3E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Header("Elements")]
		public GameObject focusingIndicator;

		// Token: 0x04000C3F RID: 3135
		[Token(Token = "0x4000C3F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Vector3 focusingIndicatorOffset;

		// Token: 0x04000C40 RID: 3136
		[Token(Token = "0x4000C40")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public TextMeshProUGUI currentMapName;

		// Token: 0x04000C41 RID: 3137
		[Token(Token = "0x4000C41")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Sprite EventSprite;

		// Token: 0x04000C42 RID: 3138
		[Token(Token = "0x4000C42")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Sprite MissionSprite;

		// Token: 0x04000C43 RID: 3139
		[Token(Token = "0x4000C43")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Sprite MerchantSprite;

		// Token: 0x04000C44 RID: 3140
		[Token(Token = "0x4000C44")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Sprite CanDeliverSprite;

		// Token: 0x04000C45 RID: 3141
		[Token(Token = "0x4000C45")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Sprite KyoukouTutorialSprite;

		// Token: 0x04000C46 RID: 3142
		[Token(Token = "0x4000C46")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Sprite KyoukouNewTutorialSprite;

		// Token: 0x04000C47 RID: 3143
		[Token(Token = "0x4000C47")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float lastProgress;

		// Token: 0x04000C48 RID: 3144
		[Token(Token = "0x4000C48")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Action<float> onSettingDayLightIlluminationCallback;

		// Token: 0x04000C49 RID: 3145
		[Token(Token = "0x4000C49")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private long startTime;

		// Token: 0x04000C4A RID: 3146
		[Token(Token = "0x4000C4A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private long endTime;

		// Token: 0x04000C4B RID: 3147
		[Token(Token = "0x4000C4B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private int totalActions;

		// Token: 0x04000C4E RID: 3150
		[Token(Token = "0x4000C4E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[Header("DLC5 Rogue Like")]
		[SerializeField]
		private AssetReferenceT<GameObject> m_DLC5RogueLikeMainPanel;

		// Token: 0x04000C4F RID: 3151
		[Token(Token = "0x4000C4F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private DLC5_RogueLikeLoadProgressPanel m_Dlc5RoguelikeLoadProgressPanel;

		// Token: 0x04000C50 RID: 3152
		[Token(Token = "0x4000C50")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private AssetReferenceT<GameObject> m_DLC5RogueLikeSpotSelectionPanel;

		// Token: 0x04000C51 RID: 3153
		[Token(Token = "0x4000C51")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		private AssetReferenceT<GameObject> m_DLC5RogueLikeFailedPanel;

		// Token: 0x04000C52 RID: 3154
		[Token(Token = "0x4000C52")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private AssetReferenceT<GameObject> m_DLC5RogueLikeRoundPassPanel;

		// Token: 0x04000C53 RID: 3155
		[Token(Token = "0x4000C53")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		private AssetReferenceT<GameObject> m_DLC5RogueLikeWinPanel;

		// Token: 0x04000C54 RID: 3156
		[Token(Token = "0x4000C54")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[SerializeField]
		private AssetReferenceT<GameObject> m_DLC5RogueLikeSaveLoadPanel;

		// Token: 0x04000C55 RID: 3157
		[Token(Token = "0x4000C55")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		[SerializeField]
		private AssetReferenceT<GameObject> m_DLC5RogueLikeResultPanel;

		// Token: 0x04000C56 RID: 3158
		[Token(Token = "0x4000C56")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[SerializeField]
		private AssetReferenceT<GameObject> m_DLC5CreatorsBoxPanel;

		// Token: 0x04000C57 RID: 3159
		[Token(Token = "0x4000C57")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		[SerializeField]
		private AssetReferenceT<GameObject> m_InfiniteIngredientsPanel;

		// Token: 0x04000C58 RID: 3160
		[Token(Token = "0x4000C58")]
		public const int LUCKY_LEAF_ID = 52;

		// Token: 0x04000C59 RID: 3161
		[Token(Token = "0x4000C59")]
		public const int COUPONS_ID = 2;
	}
}
