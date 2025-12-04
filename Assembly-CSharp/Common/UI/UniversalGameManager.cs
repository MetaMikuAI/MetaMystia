using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.DialogUtility;
using Common.UI.EscapeUtility;
using Common.UI.Filter;
using Common.UI.NoteBookUtility;
using Common.UI.StorageUtility;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Managers;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AssetHandleUtility;
using DEYU.SceneComposer;
using DEYU.Singletons;
using DEYU.UniversalUISystem;
using GameData.Profile;
using GamePlatform.Core;
using Il2CppDummyDll;
using JetBrains.Annotations;
using PrepNightScene.UI;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.InputSystem;

namespace Common.UI
{
	// Token: 0x02000DBD RID: 3517
	[Token(Token = "0x2000DBD")]
	public class UniversalGameManager : MonoSingletonPersistant<UniversalGameManager>
	{
		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06005274 RID: 21108 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005275 RID: 21109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BD5")]
		public static string PlayerInputMode
		{
			[Token(Token = "0x6005274")]
			[Address(RVA = "0x8189D0", Offset = "0x8173D0", VA = "0x1808189D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005275")]
			[Address(RVA = "0x818E50", Offset = "0x817850", VA = "0x180818E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06005276 RID: 21110 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005277 RID: 21111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BD6")]
		public static DialogPackage RewindDialogPackage
		{
			[Token(Token = "0x6005276")]
			[Address(RVA = "0x818A20", Offset = "0x817420", VA = "0x180818A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005277")]
			[Address(RVA = "0x818EC0", Offset = "0x8178C0", VA = "0x180818EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06005278 RID: 21112 RVA: 0x0001DC88 File Offset: 0x0001BE88
		// (set) Token: 0x06005279 RID: 21113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BD7")]
		public static bool IsInputEnabled
		{
			[Token(Token = "0x6005278")]
			[Address(RVA = "0x818690", Offset = "0x817090", VA = "0x180818690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005279")]
			[Address(RVA = "0x818D90", Offset = "0x817790", VA = "0x180818D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x0600527A RID: 21114 RVA: 0x0001DCA0 File Offset: 0x0001BEA0
		[Token(Token = "0x17000BD8")]
		public static MemoryMode PlatformMemoryMode
		{
			[Token(Token = "0x600527A")]
			[Address(RVA = "0x8188E0", Offset = "0x8172E0", VA = "0x1808188E0")]
			get
			{
				return MemoryMode.Normal;
			}
		}

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x0600527B RID: 21115 RVA: 0x0001DCB8 File Offset: 0x0001BEB8
		[Token(Token = "0x17000BD9")]
		public static AssetLifetime PlatformAssetLifetime
		{
			[Token(Token = "0x600527B")]
			[Address(RVA = "0x818850", Offset = "0x817250", VA = "0x180818850")]
			get
			{
				return AssetLifetime.Temp;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x0600527C RID: 21116 RVA: 0x0001DCD0 File Offset: 0x0001BED0
		[Token(Token = "0x17000BDA")]
		public static AdpPanelLifetime PlatformPanelLifetime
		{
			[Token(Token = "0x600527C")]
			[Address(RVA = "0x818940", Offset = "0x817340", VA = "0x180818940")]
			get
			{
				return AdpPanelLifetime.Buffered;
			}
		}

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x0600527D RID: 21117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BDB")]
		public static GameObject LevelUpEffect
		{
			[Token(Token = "0x600527D")]
			[Address(RVA = "0x818750", Offset = "0x817150", VA = "0x180818750")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x0600527E RID: 21118 RVA: 0x0001DCE8 File Offset: 0x0001BEE8
		// (set) Token: 0x0600527F RID: 21119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BDC")]
		public static bool IsSwitchScene
		{
			[Token(Token = "0x600527E")]
			[Address(RVA = "0x8186F0", Offset = "0x8170F0", VA = "0x1808186F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600527F")]
			[Address(RVA = "0x818DF0", Offset = "0x8177F0", VA = "0x180818DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06005280 RID: 21120 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005281 RID: 21121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002C")]
		public static event Action OnWillLoadSceneCallback
		{
			[Token(Token = "0x6005280")]
			[Address(RVA = "0x818590", Offset = "0x816F90", VA = "0x180818590")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005281")]
			[Address(RVA = "0x818C90", Offset = "0x817690", VA = "0x180818C90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06005282 RID: 21122 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005283 RID: 21123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002D")]
		public static event Action<Vector2> OnPointerPositionUpdate
		{
			[Token(Token = "0x6005282")]
			[Address(RVA = "0x818480", Offset = "0x816E80", VA = "0x180818480")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005283")]
			[Address(RVA = "0x818B80", Offset = "0x817580", VA = "0x180818B80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400002E RID: 46
		// (add) Token: 0x06005284 RID: 21124 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005285 RID: 21125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400002E")]
		public static event Action<bool> OnPlayerInputAvailabilityUpdate
		{
			[Token(Token = "0x6005284")]
			[Address(RVA = "0x818370", Offset = "0x816D70", VA = "0x180818370")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005285")]
			[Address(RVA = "0x818A70", Offset = "0x817470", VA = "0x180818A70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005286")]
		[Address(RVA = "0x817350", Offset = "0x815D50", VA = "0x180817350")]
		public static void SetAndPushCurrentScenePanelRoot(MonoBehaviour owner, RectTransform panelRoot)
		{
		}

		// Token: 0x06005287 RID: 21127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005287")]
		[Address(RVA = "0x813E90", Offset = "0x812890", VA = "0x180813E90")]
		public static EscMainPannel GetEscapePanelParent()
		{
			return null;
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005288")]
		[Address(RVA = "0x814020", Offset = "0x812A20", VA = "0x180814020")]
		public static NoteBookMainPannel GetNotebookPanelParent()
		{
			return null;
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005289")]
		[Address(RVA = "0x8140D0", Offset = "0x812AD0", VA = "0x1808140D0")]
		public static StorageMainPannel GetStoragePanelParent()
		{
			return null;
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528A")]
		[Address(RVA = "0x813EE0", Offset = "0x8128E0", VA = "0x180813EE0")]
		private IzakayaConfigPannel GetIzakayaConfigPanelParent()
		{
			return null;
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528B")]
		[Address(RVA = "0x813F80", Offset = "0x812980", VA = "0x180813F80")]
		private MultipleChoicePannel GetMultipleChoicePanelParent()
		{
			return null;
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600528C")]
		[Address(RVA = "0x813FD0", Offset = "0x8129D0", VA = "0x180813FD0")]
		private MultipleGetProductsPanel GetMultipleGetProductsPanelParent()
		{
			return null;
		}

		// Token: 0x0600528D RID: 21133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528D")]
		[Address(RVA = "0x816870", Offset = "0x815270", VA = "0x180816870")]
		public static void OpenNotebookPanelStandalone([Optional] Action onPanelCloseCallback)
		{
		}

		// Token: 0x0600528E RID: 21134 RVA: 0x0001DD00 File Offset: 0x0001BF00
		[Token(Token = "0x600528E")]
		[Address(RVA = "0x8167B0", Offset = "0x8151B0", VA = "0x1808167B0")]
		private static UniTask OpenNotebookPanelStandaloneAsync(Action onPanelCloseCallback)
		{
			return default(UniTask);
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600528F")]
		[Address(RVA = "0x816A80", Offset = "0x815480", VA = "0x180816A80")]
		public static void OpenStoragePanelStandalone([Optional] Action onPanelCloseCallback)
		{
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x0001DD18 File Offset: 0x0001BF18
		[Token(Token = "0x6005290")]
		[Address(RVA = "0x8169C0", Offset = "0x8153C0", VA = "0x1808169C0")]
		private static UniTask OpenStoragePanelStandaloneAsync(Action onPanelCloseCallback)
		{
			return default(UniTask);
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005291")]
		public T PrepareBufferedPanelWithRecord<T>(T panelParent, [Optional] Action<T> preInitializeCallback, [Optional] string bufferPanelLabel) where T : UIPanelBaseImpl
		{
			return null;
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005292")]
		public T PreBufferPanelWithRecord<T>(T panelParent, [Optional] string bufferPanelLabel) where T : UIPanelBaseImpl
		{
			return null;
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005293")]
		[Address(RVA = "0x813800", Offset = "0x812200", VA = "0x180813800")]
		public static void Dispose()
		{
		}

		// Token: 0x06005294 RID: 21140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005294")]
		[Address(RVA = "0x817A10", Offset = "0x816410", VA = "0x180817A10")]
		public static void StopCameraShake()
		{
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005295")]
		[Address(RVA = "0x817C50", Offset = "0x816650", VA = "0x180817C50")]
		public static void UpdatePlayerInputAvailability(bool targetInputAvailability)
		{
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005296")]
		[Address(RVA = "0x816E50", Offset = "0x815850", VA = "0x180816E50")]
		public static void ReMigrateCommonPanels(Transform panelRoot, bool escapePanelOnly = false)
		{
		}

		// Token: 0x06005297 RID: 21143 RVA: 0x0001DD30 File Offset: 0x0001BF30
		[Token(Token = "0x6005297")]
		[Address(RVA = "0x816DB0", Offset = "0x8157B0", VA = "0x180816DB0")]
		public static UniTask PreLoadCommonPanelParent()
		{
			return default(UniTask);
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005298")]
		[Address(RVA = "0x816BD0", Offset = "0x8155D0", VA = "0x180816BD0")]
		public static GameObject PlayLevelUpEffect()
		{
			return null;
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005299")]
		[Address(RVA = "0x814510", Offset = "0x812F10", VA = "0x180814510", Slot = "6")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529A")]
		[Address(RVA = "0x812FE0", Offset = "0x8119E0", VA = "0x180812FE0")]
		private void AdpUIPanelManager_OnInputModeChangedCallback(AdpUIPanelManager.RequestedInputMode mode)
		{
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529B")]
		[Address(RVA = "0x8133B0", Offset = "0x811DB0", VA = "0x1808133B0")]
		private static void CallOnPointerPositionUpdate(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529C")]
		[Address(RVA = "0x814070", Offset = "0x812A70", VA = "0x180814070")]
		private static AssetReference GetScene(Scene scene)
		{
			return null;
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x0001DD48 File Offset: 0x0001BF48
		[Token(Token = "0x600529D")]
		[Address(RVA = "0x814120", Offset = "0x812B20", VA = "0x180814120")]
		public static bool IsMainScene(AssetReference sceneReference)
		{
			return default(bool);
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600529E")]
		[Address(RVA = "0x813F30", Offset = "0x812930", VA = "0x180813F30")]
		public static AssetReference GetMainScene()
		{
			return null;
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600529F")]
		[Address(RVA = "0x816D40", Offset = "0x815740", VA = "0x180816D40")]
		public static void PlayTutorialOpenAudio()
		{
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A0")]
		[Address(RVA = "0x814170", Offset = "0x812B70", VA = "0x180814170")]
		public static void LoadScene(Scene scene, [Optional] Action onFadeFinishCallback)
		{
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A1")]
		[Address(RVA = "0x8180D0", Offset = "0x816AD0", VA = "0x1808180D0")]
		private static void WaitUntilAllPannelClosed(Action onFinish)
		{
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x0001DD60 File Offset: 0x0001BF60
		[Token(Token = "0x60052A2")]
		[Address(RVA = "0x8138D0", Offset = "0x8122D0", VA = "0x1808138D0")]
		public static UniTask FadeInAsync()
		{
			return default(UniTask);
		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x0001DD78 File Offset: 0x0001BF78
		[Token(Token = "0x60052A3")]
		[Address(RVA = "0x813BB0", Offset = "0x8125B0", VA = "0x180813BB0")]
		public static UniTask FadeOutAsync()
		{
			return default(UniTask);
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x0001DD90 File Offset: 0x0001BF90
		[Token(Token = "0x60052A4")]
		[Address(RVA = "0x815E50", Offset = "0x814850", VA = "0x180815E50")]
		public static UniTask OpenIzakayaConfigMenuAsync([Optional] IPostExtraChecker iPostExtraChecker)
		{
			return default(UniTask);
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A5")]
		[Address(RVA = "0x813960", Offset = "0x812360", VA = "0x180813960")]
		public static void FadeIn([Optional] Action onFinishCallback)
		{
		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A6")]
		[Address(RVA = "0x813C40", Offset = "0x812640", VA = "0x180813C40")]
		public static void FadeOut([Optional] Action onFinishCallback)
		{
		}

		// Token: 0x060052A7 RID: 21159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A7")]
		[Address(RVA = "0x815990", Offset = "0x814390", VA = "0x180815990")]
		public static void OpenDialogMenu(DialogPackage dialogPackage, Action onFinishCallback, [Optional] Action<Dictionary<int, string>> overrideReplaceTextCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x0001DDA8 File Offset: 0x0001BFA8
		[Token(Token = "0x60052A8")]
		[Address(RVA = "0x815410", Offset = "0x813E10", VA = "0x180815410")]
		private static UniTaskVoid OpenDialogMenuAsyncInternal(DialogPackage dialogPackage, Action onFinishCallback, [Optional] Action<Dictionary<int, string>> overrideReplaceTextCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052A9")]
		[Address(RVA = "0x815860", Offset = "0x814260", VA = "0x180815860")]
		public static void OpenDialogMenuWithExitCode(DialogPackage dialogPackage, Action<int> onFinishCallback, [Optional] Action<Dictionary<int, string>> overrideReplaceTextCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x0001DDC0 File Offset: 0x0001BFC0
		[Token(Token = "0x60052AA")]
		[Address(RVA = "0x8156B0", Offset = "0x8140B0", VA = "0x1808156B0")]
		private static UniTaskVoid OpenDialogMenuWithExitCodeAsyncInternal(DialogPackage dialogPackage, Action<int> onFinishCallback, [Optional] Action<Dictionary<int, string>> overrideReplaceTextCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060052AB RID: 21163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052AB")]
		[Address(RVA = "0x816160", Offset = "0x814B60", VA = "0x180816160")]
		public static void OpenManualDialogMenu(DialogPackage dialogPackage, Action onCanContinueCallback, Action<Action> canPlayFirstLineCallback, Action<Action> canExitCallback, Action loadFinishCallback, bool shouldHaveBlackBackground, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
		}

		// Token: 0x060052AC RID: 21164 RVA: 0x0001DDD8 File Offset: 0x0001BFD8
		[Token(Token = "0x60052AC")]
		[Address(RVA = "0x815AC0", Offset = "0x8144C0", VA = "0x180815AC0")]
		public static UniTask OpenGeneralErrorPanelAsync(string title, string message)
		{
			return default(UniTask);
		}

		// Token: 0x060052AD RID: 21165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052AD")]
		public static void OpenMultipleChoiceMenu<T>(MultipleChoicePannel.MultipleChoicePannelOpenContext openContext, Action<T[]> onFinishCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
		}

		// Token: 0x060052AE RID: 21166 RVA: 0x0001DDF0 File Offset: 0x0001BFF0
		[Token(Token = "0x60052AE")]
		private static UniTaskVoid OpenMultipleChoiceMenuAsyncInternal<T>(MultipleChoicePannel.MultipleChoicePannelOpenContext openContext, Action<T[]> onFinishCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060052AF RID: 21167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052AF")]
		public static void OpenMultipleChoiceMenu<T>(MultipleChoicePannel.MultipleChoicePannelOpenContext openContext, Action<bool, T[]> onFinishCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x0001DE08 File Offset: 0x0001C008
		[Token(Token = "0x60052B0")]
		private static UniTaskVoid OpenMultipleChoiceMenuAsyncInternal<T>(MultipleChoicePannel.MultipleChoicePannelOpenContext openContext, Action<bool, T[]> onFinishCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052B1")]
		[Address(RVA = "0x8152C0", Offset = "0x813CC0", VA = "0x1808152C0")]
		public static void OpenBindingSubPannel(EscBindingPannel.InputBindingData actionGroupToRebind, EscBindingPannel.StringArray[] groups, [TupleElementNames(new string[] { "Interactable", "UIElements", "GetCurrentKBDBindingCallback" })] Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> instances, EscBindingPannel.InputBindingData[] inputBindingDatas, [Optional] Action onPannelCloseCallback)
		{
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x0001DE20 File Offset: 0x0001C020
		[Token(Token = "0x60052B2")]
		[Address(RVA = "0x8151B0", Offset = "0x813BB0", VA = "0x1808151B0")]
		private static UniTaskVoid OpenBindingSubPannelAsyncInternal(EscBindingPannel.InputBindingData actionGroupToRebind, EscBindingPannel.StringArray[] groups, [TupleElementNames(new string[] { "Interactable", "UIElements", "GetCurrentKBDBindingCallback" })] Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> instances, EscBindingPannel.InputBindingData[] inputBindingDatas, [Optional] Action onPannelCloseCallback)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x0001DE38 File Offset: 0x0001C038
		[Token(Token = "0x60052B3")]
		public static UniTask OpenFilterPanel<T>([NotNull] IReadOnlyList<FilterConfigFactory<T>> filterConfigFactories, [NotNull] List<IFilterConfig> historyFilterConfigList)
		{
			return default(UniTask);
		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052B4")]
		[Address(RVA = "0x815F20", Offset = "0x814920", VA = "0x180815F20")]
		public static void OpenIzakayaConfigMenu([Optional] Action onPannelCloseCallback, [Optional] IPostExtraChecker iPostExtraChecker)
		{
		}

		// Token: 0x060052B5 RID: 21173 RVA: 0x0001DE50 File Offset: 0x0001C050
		[Token(Token = "0x60052B5")]
		[Address(RVA = "0x815C80", Offset = "0x814680", VA = "0x180815C80")]
		private static UniTask OpenIzakayaConfigMenuAsyncInternal([Optional] Action onPannelCloseCallback, [Optional] IPostExtraChecker iPostExtraChecker)
		{
			return default(UniTask);
		}

		// Token: 0x060052B6 RID: 21174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052B6")]
		[Address(RVA = "0x8166D0", Offset = "0x8150D0", VA = "0x1808166D0")]
		public static void OpenMultipleGetProductsPanel(MultipleGetProductsPanel.MultipleGetProductsOpenContext multipleGetProductsOpenContext, [Optional] Action onPannelCloseCallback)
		{
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x0001DE68 File Offset: 0x0001C068
		[Token(Token = "0x60052B7")]
		[Address(RVA = "0x816480", Offset = "0x814E80", VA = "0x180816480")]
		public static UniTask OpenMultipleGetProductsPanelAsync(MultipleGetProductsPanel.MultipleGetProductsOpenContext multipleGetProductsOpenContext, [Optional] Action onPannelCloseCallback)
		{
			return default(UniTask);
		}

		// Token: 0x060052B8 RID: 21176 RVA: 0x0001DE80 File Offset: 0x0001C080
		[Token(Token = "0x60052B8")]
		[Address(RVA = "0x817290", Offset = "0x815C90", VA = "0x180817290")]
		public static UniTask RunWithLoadingIndicatorPanel(Func<UniTask> taskToRun)
		{
			return default(UniTask);
		}

		// Token: 0x060052B9 RID: 21177 RVA: 0x0001DE98 File Offset: 0x0001C098
		[Token(Token = "0x60052B9")]
		public static UniTask<T> RunWithLoadingIndicatorPanel<T>(Func<UniTask<T>> taskToRun)
		{
			return default(UniTask<T>);
		}

		// Token: 0x060052BA RID: 21178 RVA: 0x0001DEB0 File Offset: 0x0001C0B0
		[Token(Token = "0x60052BA")]
		[Address(RVA = "0x817110", Offset = "0x815B10", VA = "0x180817110")]
		public static UniTask RunWithLoadingIndicatorPanel(UniTask taskToRun)
		{
			return default(UniTask);
		}

		// Token: 0x060052BB RID: 21179 RVA: 0x0001DEC8 File Offset: 0x0001C0C8
		[Token(Token = "0x60052BB")]
		public static UniTask<T> RunWithLoadingIndicatorPanel<T>(UniTask<T> taskToRun)
		{
			return default(UniTask<T>);
		}

		// Token: 0x060052BC RID: 21180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052BC")]
		[Address(RVA = "0x817890", Offset = "0x816290", VA = "0x180817890")]
		public static IDisposable ShowLoadingIndicator()
		{
			return null;
		}

		// Token: 0x060052BD RID: 21181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052BD")]
		[Address(RVA = "0x815610", Offset = "0x814010", VA = "0x180815610")]
		public static IEnumerator OpenDialogMenuCoroutine(DialogPackage dialogPackage, [Optional] Action<Dictionary<int, string>> overrideReplaceTextCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			return null;
		}

		// Token: 0x060052BE RID: 21182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052BE")]
		[Address(RVA = "0x8157A0", Offset = "0x8141A0", VA = "0x1808157A0")]
		public static IEnumerator OpenDialogMenuWithExitCodeCoroutine(DialogPackage dialogPackage, Action<int> getExitCodeCallback, [Optional] Action<Dictionary<int, string>> overrideReplaceTextCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			return null;
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x0001DEE0 File Offset: 0x0001C0E0
		[Token(Token = "0x60052BF")]
		[Address(RVA = "0x815500", Offset = "0x813F00", VA = "0x180815500")]
		public static UniTask OpenDialogMenuAsync(DialogPackage dialogPackage, [Optional] Action<Dictionary<int, string>> overrideReplaceTextCallback, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.HideVisual)
		{
			return default(UniTask);
		}

		// Token: 0x060052C0 RID: 21184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C0")]
		[Address(RVA = "0x815C40", Offset = "0x814640", VA = "0x180815C40")]
		public static void OpenInputBlockerMenu()
		{
		}

		// Token: 0x060052C1 RID: 21185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C1")]
		[Address(RVA = "0x8137C0", Offset = "0x8121C0", VA = "0x1808137C0")]
		public static void CloseInputBlockerMenu()
		{
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C2")]
		[Address(RVA = "0x817660", Offset = "0x816060", VA = "0x180817660")]
		public static void SetCameraShake(float amplitude, float duration)
		{
		}

		// Token: 0x060052C3 RID: 21187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C3")]
		[Address(RVA = "0x8174D0", Offset = "0x815ED0", VA = "0x1808174D0")]
		public static void SetCameraShake(float amplitude, float duration, float fadeTime)
		{
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C4")]
		[Address(RVA = "0x8173B0", Offset = "0x815DB0", VA = "0x1808173B0")]
		public static IEnumerator SetCameraShakeC(float amplitude, float duration, float fadeTime)
		{
			return null;
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C5")]
		[Address(RVA = "0x817440", Offset = "0x815E40", VA = "0x180817440")]
		public static IEnumerator SetCameraShakeCorotine(float amplitude, float duration, float fadeTime)
		{
			return null;
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x0001DEF8 File Offset: 0x0001C0F8
		[Token(Token = "0x60052C6")]
		public static UniTask<T> LoadAndPreparePanelScoped<T>(AssetReference assetReference, bool forceTempPanel = false) where T : UIPanelBaseImpl
		{
			return default(UniTask<T>);
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C7")]
		public T PrepareOrGetTempPanelInstance<T>(T panelPrefab, [Optional] string bufferPanelLabel) where T : UIPanelBaseImpl
		{
			return null;
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60052C8")]
		private T PrepareOrGetTempPanelInstanceImpl<T>(T panelPrefab, AdpPanelLifetime lifetime, [Optional] string bufferPanelLabel) where T : UIPanelBaseImpl
		{
			return null;
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x0001DF10 File Offset: 0x0001C110
		[Token(Token = "0x60052C9")]
		public static UniTask<IGameObjectAssetHandle<T>> LoadPanelScoped<T>(AssetReference assetReference) where T : UIPanelBaseImpl
		{
			return default(UniTask<IGameObjectAssetHandle<T>>);
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CA")]
		[Address(RVA = "0x817AE0", Offset = "0x8164E0", VA = "0x180817AE0")]
		private void TryCleanThenAddBufferedPanelPrefab(UIPanelBaseImpl panelPrefab)
		{
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CB")]
		[Address(RVA = "0x813440", Offset = "0x811E40", VA = "0x180813440")]
		public void ClearAllBufferedPanelOfGroup(string bufferPanelLabel)
		{
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CC")]
		[Address(RVA = "0x817E00", Offset = "0x816800", VA = "0x180817E00")]
		public static void WaitDelayFrame(Action onFinishCallback)
		{
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CD")]
		[Address(RVA = "0x817F60", Offset = "0x816960", VA = "0x180817F60")]
		public static void WaitDelay(float delaySecond, Action onFinishCallback)
		{
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052CE")]
		[Address(RVA = "0x8177E0", Offset = "0x8161E0", VA = "0x1808177E0")]
		public static void SetCameraShake(float amplitude)
		{
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x0001DF28 File Offset: 0x0001C128
		[Token(Token = "0x60052CF")]
		[Address(RVA = "0x817080", Offset = "0x815A80", VA = "0x180817080")]
		public static UniversalGameManager.IsolatedPanelTransformHandle RunUnderIsolatedParent()
		{
			return default(UniversalGameManager.IsolatedPanelTransformHandle);
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052D0")]
		[Address(RVA = "0x818280", Offset = "0x816C80", VA = "0x180818280")]
		public UniversalGameManager()
		{
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x0001DF40 File Offset: 0x0001C140
		[Token(Token = "0x60052D2")]
		[CompilerGenerated]
		internal static UniTask<IAssetHandle<T>> <PreLoadCommonPanelParent>g__PreLoadPass|102_0<T>(Func<UniversalGameManager, AssetReference> getAssetReferenceCallback) where T : global::UnityEngine.Object
		{
			return default(UniTask<IAssetHandle<T>>);
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x0001DF58 File Offset: 0x0001C158
		[Token(Token = "0x60052D3")]
		[CompilerGenerated]
		internal static UniTask<IGameObjectAssetHandle<T>> <PreLoadCommonPanelParent>g__PreLoadPanelPass|102_1<T>(Func<UniversalGameManager, AssetReference> getAssetReferenceCallback) where T : UIPanelBaseImpl
		{
			return default(UniTask<IGameObjectAssetHandle<T>>);
		}

		// Token: 0x04004D52 RID: 19794
		[Token(Token = "0x4004D52")]
		public const float TRANSITION_DURATION = 1f;

		// Token: 0x04004D53 RID: 19795
		[Token(Token = "0x4004D53")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AdpBuiltinInputBlockerPanel s_LoadingIndicatorPanel;

		// Token: 0x04004D54 RID: 19796
		[Token(Token = "0x4004D54")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static EscMainPannel s_EscMainPannel;

		// Token: 0x04004D55 RID: 19797
		[Token(Token = "0x4004D55")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static NoteBookMainPannel s_NoteBookMainPannel;

		// Token: 0x04004D56 RID: 19798
		[Token(Token = "0x4004D56")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static StorageMainPannel s_StorageMainPannel;

		// Token: 0x04004D57 RID: 19799
		[Token(Token = "0x4004D57")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DialogPannel s_DialogPannel;

		// Token: 0x04004D58 RID: 19800
		[Token(Token = "0x4004D58")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static EscBindingSubPannel s_EscBindingSubPannel;

		// Token: 0x04004D59 RID: 19801
		[Token(Token = "0x4004D59")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static FlattenedFilterPanel s_FlattenedFilterPanel;

		// Token: 0x04004D5A RID: 19802
		[Token(Token = "0x4004D5A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static MultipleChoicePannel s_MultipleChoicePannel;

		// Token: 0x04004D5B RID: 19803
		[Token(Token = "0x4004D5B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static IzakayaConfigPannel s_IzakayaConfigPannel;

		// Token: 0x04004D5C RID: 19804
		[Token(Token = "0x4004D5C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static MultipleGetProductsPanel s_MultipleGetProductsPanel;

		// Token: 0x04004D5D RID: 19805
		[Token(Token = "0x4004D5D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static GenericErrorPanel s_GeneralErrorPanel;

		// Token: 0x04004D5E RID: 19806
		[Token(Token = "0x4004D5E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static GameObject s_LevelUpEffect;

		// Token: 0x04004D5F RID: 19807
		[Token(Token = "0x4004D5F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static bool m_IsCommonPannelLoaded;

		// Token: 0x04004D60 RID: 19808
		[Token(Token = "0x4004D60")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private static bool? m_HasFadeIn;

		// Token: 0x04004D61 RID: 19809
		[Token(Token = "0x4004D61")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private static readonly int s_Amplitude;

		// Token: 0x04004D62 RID: 19810
		[Token(Token = "0x4004D62")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static bool s_IsDialogPanelOpened;

		// Token: 0x04004D63 RID: 19811
		[Token(Token = "0x4004D63")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private static bool s_IsLoadingIndicatorPanelShown;

		// Token: 0x04004D64 RID: 19812
		[Token(Token = "0x4004D64")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioClip m_TutorialSFX;

		// Token: 0x04004D65 RID: 19813
		[Token(Token = "0x4004D65")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AssetReference m_EscapePannelAsset;

		// Token: 0x04004D66 RID: 19814
		[Token(Token = "0x4004D66")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AssetReference m_NotebookPannelAsset;

		// Token: 0x04004D67 RID: 19815
		[Token(Token = "0x4004D67")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AssetReference m_StoragePannelAsset;

		// Token: 0x04004D68 RID: 19816
		[Token(Token = "0x4004D68")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AssetReference m_DialogPannelAsset;

		// Token: 0x04004D69 RID: 19817
		[Token(Token = "0x4004D69")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AssetReference m_MultipleChoicePannelAsset;

		// Token: 0x04004D6A RID: 19818
		[Token(Token = "0x4004D6A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AssetReference m_IzakayaConfigPannelAsset;

		// Token: 0x04004D6B RID: 19819
		[Token(Token = "0x4004D6B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AssetReference m_BindingPannelAsset;

		// Token: 0x04004D6C RID: 19820
		[Token(Token = "0x4004D6C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AssetReference m_FilterPanelAsset;

		// Token: 0x04004D6D RID: 19821
		[Token(Token = "0x4004D6D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private AssetReference m_RewindDialogPackage;

		// Token: 0x04004D6E RID: 19822
		[Token(Token = "0x4004D6E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AssetReference m_LevelUpEffect;

		// Token: 0x04004D6F RID: 19823
		[Token(Token = "0x4004D6F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AssetReference m_LoadingIndicatorPanelAsset;

		// Token: 0x04004D70 RID: 19824
		[Token(Token = "0x4004D70")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AssetReference m_MultipleGetProductsPanelAsset;

		// Token: 0x04004D71 RID: 19825
		[Token(Token = "0x4004D71")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AssetReference m_GeneralErrorPanelAsset;

		// Token: 0x04004D72 RID: 19826
		[Token(Token = "0x4004D72")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AssetReference m_DayScene;

		// Token: 0x04004D73 RID: 19827
		[Token(Token = "0x4004D73")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AssetReference m_MainScene;

		// Token: 0x04004D74 RID: 19828
		[Token(Token = "0x4004D74")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AssetReference m_LoadScene;

		// Token: 0x04004D75 RID: 19829
		[Token(Token = "0x4004D75")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AssetReference m_IzakayaPrepScene;

		// Token: 0x04004D76 RID: 19830
		[Token(Token = "0x4004D76")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AssetReference m_WorkScene;

		// Token: 0x04004D77 RID: 19831
		[Token(Token = "0x4004D77")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AssetReference m_ResultScene;

		// Token: 0x04004D78 RID: 19832
		[Token(Token = "0x4004D78")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AssetReference m_StaffScene;

		// Token: 0x04004D79 RID: 19833
		[Token(Token = "0x4004D79")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AssetReference m_EmptyScene;

		// Token: 0x04004D7A RID: 19834
		[Token(Token = "0x4004D7A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private AudioClip m_DefaultOnSelectAudio;

		// Token: 0x04004D7B RID: 19835
		[Token(Token = "0x4004D7B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private AudioClip m_DefaultOnSubmitAudio;

		// Token: 0x04004D7C RID: 19836
		[Token(Token = "0x4004D7C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private AudioClip m_DefaultOnCancelAudio;

		// Token: 0x04004D7D RID: 19837
		[Token(Token = "0x4004D7D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private AudioClip m_DefaultOnPanelOpenAudio;

		// Token: 0x04004D7E RID: 19838
		[Token(Token = "0x4004D7E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private AudioClip m_DefaultOnPanelCloseAudio;

		// Token: 0x04004D7F RID: 19839
		[Token(Token = "0x4004D7F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private TransitingModuleBase m_TransitionModule;

		// Token: 0x04004D80 RID: 19840
		[Token(Token = "0x4004D80")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Material m_ShakeMaterial;

		// Token: 0x04004D81 RID: 19841
		[Token(Token = "0x4004D81")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RectTransform m_IsolatedPanelTransform;

		// Token: 0x04004D82 RID: 19842
		[Token(Token = "0x4004D82")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly HashSet<UIPanelBaseImpl> m_BufferedPanelPrefabs;

		// Token: 0x04004D83 RID: 19843
		[Token(Token = "0x4004D83")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private readonly Dictionary<string, HashSet<UIPanelBaseImpl>> m_BufferedPanelPrefabGroups;

		// Token: 0x04004D84 RID: 19844
		[Token(Token = "0x4004D84")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private AssetReference[] m_AllScenes;

		// Token: 0x04004D85 RID: 19845
		[Token(Token = "0x4004D85")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Coroutine m_ShakeCoroutine;

		// Token: 0x02000DBE RID: 3518
		[Token(Token = "0x2000DBE")]
		private class LoadingIndicatorDisposableHandle : IDisposable
		{
			// Token: 0x060052D4 RID: 21204 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60052D4")]
			[Address(RVA = "0x46BA70", Offset = "0x46A470", VA = "0x18046BA70")]
			public LoadingIndicatorDisposableHandle(AdpBuiltinInputBlockerPanel openedPanel)
			{
			}

			// Token: 0x060052D5 RID: 21205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60052D5")]
			[Address(RVA = "0x7FF230", Offset = "0x7FDC30", VA = "0x1807FF230", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x04004D8D RID: 19853
			[Token(Token = "0x4004D8D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly AdpBuiltinInputBlockerPanel m_OpenedPanel;
		}

		// Token: 0x02000DBF RID: 3519
		[Token(Token = "0x2000DBF")]
		private class InvalidIDisposable : IDisposable
		{
			// Token: 0x060052D6 RID: 21206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60052D6")]
			[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x060052D7 RID: 21207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60052D7")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			public InvalidIDisposable()
			{
			}
		}

		// Token: 0x02000DC0 RID: 3520
		[Token(Token = "0x2000DC0")]
		public struct IsolatedPanelTransformHandle : IDisposable
		{
			// Token: 0x060052D8 RID: 21208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60052D8")]
			[Address(RVA = "0x7FE090", Offset = "0x7FCA90", VA = "0x1807FE090", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
