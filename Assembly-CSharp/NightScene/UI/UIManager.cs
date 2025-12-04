using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.UI;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.Managers;
using DEYU.Singletons;
using Il2CppDummyDll;
using Night.UI.HUD.Ordering;
using NightScene.EventUtility;
using NightScene.UI.EventUtility;
using NightScene.UI.HUDUtility;
using PrepNightScene.UI;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

namespace NightScene.UI
{
	// Token: 0x02000695 RID: 1685
	[Token(Token = "0x2000695")]
	[GenerateCleanupMethod]
	public class UIManager : MonoSingleton<UIManager>
	{
		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060027C3 RID: 10179 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027C4 RID: 10180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000595")]
		public WorkSceneSustainedPannel SustainedPannel
		{
			[Token(Token = "0x60027C3")]
			[Address(RVA = "0x48A610", Offset = "0x489010", VA = "0x18048A610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027C4")]
			[Address(RVA = "0x4D2450", Offset = "0x4D0E50", VA = "0x1804D2450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060027C5 RID: 10181 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027C6 RID: 10182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000596")]
		public Action OnSwitchingInputToPlayerCallback
		{
			[Token(Token = "0x60027C5")]
			[Address(RVA = "0x4D1E30", Offset = "0x4D0830", VA = "0x1804D1E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027C6")]
			[Address(RVA = "0x4D2430", Offset = "0x4D0E30", VA = "0x1804D2430")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060027C7 RID: 10183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000597")]
		public Transform UiAnimationBack
		{
			[Token(Token = "0x60027C7")]
			[Address(RVA = "0x48A940", Offset = "0x489340", VA = "0x18048A940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060027C8 RID: 10184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000598")]
		public Transform UiAnimationMiddle
		{
			[Token(Token = "0x60027C8")]
			[Address(RVA = "0x440320", Offset = "0x43ED20", VA = "0x180440320")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060027C9 RID: 10185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000599")]
		public Transform UiAnimationFront
		{
			[Token(Token = "0x60027C9")]
			[Address(RVA = "0x4402B0", Offset = "0x43ECB0", VA = "0x1804402B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059A")]
		public Transform UiAnimationTop
		{
			[Token(Token = "0x60027CA")]
			[Address(RVA = "0x4402C0", Offset = "0x43ECC0", VA = "0x1804402C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060027CB RID: 10187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059B")]
		public Transform IncomeUI
		{
			[Token(Token = "0x60027CB")]
			[Address(RVA = "0x45A7E0", Offset = "0x4591E0", VA = "0x18045A7E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060027CD RID: 10189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700059C")]
		public IncomeControllerBase IncomeController
		{
			[Token(Token = "0x60027CC")]
			[Address(RVA = "0x48A8F0", Offset = "0x4892F0", VA = "0x18048A8F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60027CD")]
			[Address(RVA = "0x4D23E0", Offset = "0x4D0DE0", VA = "0x1804D23E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700059D")]
		public Transform TraySpecialEffectTransform
		{
			[Token(Token = "0x60027CE")]
			[Address(RVA = "0x426F70", Offset = "0x425970", VA = "0x180426F70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060027CF RID: 10191 RVA: 0x0000EBF8 File Offset: 0x0000CDF8
		// (set) Token: 0x060027D0 RID: 10192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700059E")]
		public Vector2 IncomeBoxPosition
		{
			[Token(Token = "0x60027CF")]
			[Address(RVA = "0x545690", Offset = "0x544090", VA = "0x180545690")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x60027D0")]
			[Address(RVA = "0x5456B0", Offset = "0x5440B0", VA = "0x1805456B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027D1")]
		[Address(RVA = "0x543F00", Offset = "0x542900", VA = "0x180543F00")]
		public Action Initialize(NightSceneDirector.ChallengeType challengeType)
		{
			return null;
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D2")]
		[Address(RVA = "0x5436C0", Offset = "0x5420C0", VA = "0x1805436C0")]
		private void AdpUIPanelManager_OnInputModeChangedCallback(AdpUIPanelManager.RequestedInputMode _)
		{
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D3")]
		[Address(RVA = "0x5436C0", Offset = "0x5420C0", VA = "0x1805436C0")]
		private void UniversalGameManager_OnPlayerInputAvailabilityUpdate(bool _)
		{
		}

		// Token: 0x060027D4 RID: 10196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D4")]
		[Address(RVA = "0x5454C0", Offset = "0x543EC0", VA = "0x1805454C0")]
		private void UpdateCurrentStatus()
		{
		}

		// Token: 0x060027D5 RID: 10197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D5")]
		[Address(RVA = "0x543DA0", Offset = "0x5427A0", VA = "0x180543DA0")]
		public void InitializePlayerPortrayal()
		{
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D6")]
		[Address(RVA = "0x545350", Offset = "0x543D50", VA = "0x180545350")]
		public void SetPortrayal(Sprite image, Vector2 offset)
		{
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D7")]
		[Address(RVA = "0x544B40", Offset = "0x543540", VA = "0x180544B40")]
		public void OpenChatConfirmationModule(Action<bool> onFinish)
		{
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x0000EC10 File Offset: 0x0000CE10
		[Token(Token = "0x60027D8")]
		[Address(RVA = "0x544A80", Offset = "0x543480", VA = "0x180544A80")]
		private UniTaskVoid OpenChatConfirmationModuleAsyncInternal(Action<bool> onFinish)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D9")]
		[Address(RVA = "0x544CF0", Offset = "0x5436F0", VA = "0x180544CF0")]
		public void OpenEventSelectionModule(Dictionary<string, Action> options, Action onFinish)
		{
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x0000EC28 File Offset: 0x0000CE28
		[Token(Token = "0x60027DA")]
		[Address(RVA = "0x544C10", Offset = "0x543610", VA = "0x180544C10")]
		private UniTaskVoid OpenEventSelectionModuleAsyncInternal(Dictionary<string, Action> options, Action onFinish)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060027DB RID: 10203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DB")]
		[Address(RVA = "0x5439D0", Offset = "0x5423D0", VA = "0x1805439D0")]
		private void Dispose()
		{
		}

		// Token: 0x060027DC RID: 10204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DC")]
		[Address(RVA = "0x545100", Offset = "0x543B00", VA = "0x180545100")]
		public void SetKickButton(int? kickIndex)
		{
		}

		// Token: 0x060027DD RID: 10205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DD")]
		[Address(RVA = "0x5448C0", Offset = "0x5432C0", VA = "0x1805448C0")]
		private void OnConfirmKick()
		{
		}

		// Token: 0x060027DE RID: 10206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DE")]
		[Address(RVA = "0x544DE0", Offset = "0x5437E0", VA = "0x180544DE0")]
		public void PlayOnOpenAudio()
		{
		}

		// Token: 0x060027DF RID: 10207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027DF")]
		[Address(RVA = "0x5451C0", Offset = "0x543BC0", VA = "0x1805451C0")]
		public void SetPortrayalActive(bool active, bool doNotFade = true)
		{
		}

		// Token: 0x060027E0 RID: 10208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027E0")]
		[Address(RVA = "0x543CF0", Offset = "0x5426F0", VA = "0x180543CF0")]
		public IEnumerator ExecuteThrowDeliver(Sprite sprite, Vector3 target, Vector3 start)
		{
			return null;
		}

		// Token: 0x060027E1 RID: 10209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E1")]
		[Address(RVA = "0x5453F0", Offset = "0x543DF0", VA = "0x1805453F0")]
		public void ToggleIzakayaConfigureModule(Action onConfigFinishCallback, [Optional] IPostExtraChecker iPostExtraChecker)
		{
		}

		// Token: 0x060027E2 RID: 10210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E2")]
		[Address(RVA = "0x544E30", Offset = "0x543830", VA = "0x180544E30")]
		public void RegisterConsistentBuffRecord(EventManager.BuffType buffType, Guid guid, Func<string, string> getBuffDescriptionCallback, out Action onBuffFinish, [Optional] Func<string, string> titleOverride)
		{
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E3")]
		[Address(RVA = "0x545030", Offset = "0x543A30", VA = "0x180545030")]
		public void RegisterTimedBuffRecord(EventManager.BuffType buffType, Guid guid, out Action<string, float> onBuffUpdate, out Action onBuffFinish, [Optional] Func<string, string> titleOverride)
		{
		}

		// Token: 0x060027E4 RID: 10212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E4")]
		[Address(RVA = "0x544F60", Offset = "0x543960", VA = "0x180544F60")]
		public void RegisterCountedBuffRecord(EventManager.BuffType buffType, Guid guid, out Action<string, int> onBuffUpdate, out Action onBuffFinish, [Optional] Func<string, string> titleOverride)
		{
		}

		// Token: 0x060027E5 RID: 10213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E5")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500")]
		private void SetExp(int amount)
		{
		}

		// Token: 0x060027E6 RID: 10214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E6")]
		[Address(RVA = "0x5434B0", Offset = "0x541EB0", VA = "0x1805434B0")]
		public void AddIncomeControllerUI(GameObject incomeControllerUI)
		{
		}

		// Token: 0x060027E7 RID: 10215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E7")]
		[Address(RVA = "0x544A30", Offset = "0x543430", VA = "0x180544A30", Slot = "5")]
		protected override void OnInstanceDestroyed()
		{
		}

		// Token: 0x060027E8 RID: 10216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E8")]
		[Address(RVA = "0x5436D0", Offset = "0x5420D0", VA = "0x1805436D0", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027E9")]
		[Address(RVA = "0x545600", Offset = "0x544000", VA = "0x180545600")]
		public UIManager()
		{
		}

		// Token: 0x04002426 RID: 9254
		[Token(Token = "0x4002426")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Title")]
		public TextMeshProUGUI izakayaTitle;

		// Token: 0x04002427 RID: 9255
		[Token(Token = "0x4002427")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshProUGUI izakayaDescription;

		// Token: 0x04002428 RID: 9256
		[Token(Token = "0x4002428")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Audio")]
		public AudioClip onOpen;

		// Token: 0x04002429 RID: 9257
		[Token(Token = "0x4002429")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip spellStart;

		// Token: 0x0400242A RID: 9258
		[Token(Token = "0x400242A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Buff")]
		public BuffModule buffModule;

		// Token: 0x0400242B RID: 9259
		[Token(Token = "0x400242B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GuestBuffMarkModule guestBuffMarkModule;

		// Token: 0x0400242C RID: 9260
		[Token(Token = "0x400242C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Character Transform")]
		public Transform characterField;

		// Token: 0x0400242D RID: 9261
		[Token(Token = "0x400242D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject throwDeliverParent;

		// Token: 0x0400242E RID: 9262
		[Token(Token = "0x400242E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform sceneEffectField;

		// Token: 0x0400242F RID: 9263
		[Token(Token = "0x400242F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Pannels Transform")]
		public RectTransform UIPannelRoot;

		// Token: 0x04002430 RID: 9264
		[Token(Token = "0x4002430")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform deskCodeField;

		// Token: 0x04002431 RID: 9265
		[Token(Token = "0x4002431")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform m_UiAnimationBack;

		// Token: 0x04002432 RID: 9266
		[Token(Token = "0x4002432")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform m_UiAnimationMiddle;

		// Token: 0x04002433 RID: 9267
		[Token(Token = "0x4002433")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform m_UiAnimationFront;

		// Token: 0x04002434 RID: 9268
		[Token(Token = "0x4002434")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Transform m_UiAnimationTop;

		// Token: 0x04002435 RID: 9269
		[Token(Token = "0x4002435")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform m_IncomeUI;

		// Token: 0x04002436 RID: 9270
		[Token(Token = "0x4002436")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup[] m_PlayerInputOnlyVisualElements;

		// Token: 0x04002437 RID: 9271
		[Token(Token = "0x4002437")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Transform m_TraySpecialEffectTransform;

		// Token: 0x04002438 RID: 9272
		[Token(Token = "0x4002438")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Header("Pannels")]
		public WorkSceneSustainedPannel WorkSceneSustainedPannel;

		// Token: 0x04002439 RID: 9273
		[Token(Token = "0x4002439")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AssetReferenceT<GameObject> DaySceneChatConfirmationPannel;

		// Token: 0x0400243A RID: 9274
		[Token(Token = "0x400243A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AssetReferenceT<GameObject> DaySceneEventSelectionPannel;

		// Token: 0x0400243B RID: 9275
		[Token(Token = "0x400243B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Header("Scene Objects")]
		public GameObject cookerParent;

		// Token: 0x0400243C RID: 9276
		[Token(Token = "0x400243C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public GameObject guestTable;

		// Token: 0x0400243D RID: 9277
		[Token(Token = "0x400243D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public RectTransform incomeBox;

		// Token: 0x0400243E RID: 9278
		[Token(Token = "0x400243E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Header("Character Pannels")]
		public Transform dialogField;

		// Token: 0x0400243F RID: 9279
		[Token(Token = "0x400243F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Header("Spell Declaration")]
		public GameObject spellDeclareTextParent;

		// Token: 0x04002440 RID: 9280
		[Token(Token = "0x4002440")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float spellDclareDuration;

		// Token: 0x04002441 RID: 9281
		[Token(Token = "0x4002441")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Header("Event Special Effects")]
		public AudioClip[] tipFinishSFX;

		// Token: 0x04002442 RID: 9282
		[Token(Token = "0x4002442")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Header("SubController")]
		public ClockController clockController;

		// Token: 0x04002443 RID: 9283
		[Token(Token = "0x4002443")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public PassionController passionController;

		// Token: 0x04002444 RID: 9284
		[Token(Token = "0x4002444")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public ComboController comboController;

		// Token: 0x04002445 RID: 9285
		[Token(Token = "0x4002445")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public GameObject defaultIncomeController;

		// Token: 0x04002446 RID: 9286
		[Token(Token = "0x4002446")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private OrderController m_OrderController;

		// Token: 0x04002447 RID: 9287
		[Token(Token = "0x4002447")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public PartnerStateModuleUI partnerStateController;

		// Token: 0x04002448 RID: 9288
		[Token(Token = "0x4002448")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public TipAndMoneyDisplayerController tipAndMoneyDisplayerController;

		// Token: 0x04002449 RID: 9289
		[Token(Token = "0x4002449")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[Header("UI Switching")]
		public Image characterPortrayal;

		// Token: 0x0400244A RID: 9290
		[Token(Token = "0x400244A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private readonly global::UnityEngine.Object m_PlayerInputOnlyElementsTweenKey;

		// Token: 0x0400244B RID: 9291
		[Token(Token = "0x400244B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector2 defaultAnchoredPosition;

		// Token: 0x0400244C RID: 9292
		[Token(Token = "0x400244C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private int? kickIndex;

		// Token: 0x0400244D RID: 9293
		[Token(Token = "0x400244D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Coroutine portrayalCoroutine;
	}
}
