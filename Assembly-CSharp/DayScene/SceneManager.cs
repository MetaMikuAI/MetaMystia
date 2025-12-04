using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cinemachine;
using Cysharp.Threading.Tasks;
using DayScene.Input;
using DEYU.AdpUISystem.Managers;
using DEYU.Singletons;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace DayScene
{
	// Token: 0x02000231 RID: 561
	[Token(Token = "0x2000231")]
	[GenerateCleanupMethod]
	public class SceneManager : MonoSingleton<SceneManager>
	{
		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000D3A RID: 3386 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000D3B RID: 3387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700015D")]
		public DayScenePlayerInputGenerator Character
		{
			[Token(Token = "0x6000D3A")]
			[Address(RVA = "0x477F80", Offset = "0x476980", VA = "0x180477F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D3B")]
			[Address(RVA = "0x547AB0", Offset = "0x5464B0", VA = "0x180547AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000D3C RID: 3388 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000D3D RID: 3389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700015E")]
		public string CurrentActiveMapLabel
		{
			[Token(Token = "0x6000D3C")]
			[Address(RVA = "0x48B8D0", Offset = "0x48A2D0", VA = "0x18048B8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D3D")]
			[Address(RVA = "0x608700", Offset = "0x607100", VA = "0x180608700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000D3E RID: 3390 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000D3F RID: 3391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700015F")]
		public string TargetMapLabel
		{
			[Token(Token = "0x6000D3E")]
			[Address(RVA = "0x440300", Offset = "0x43ED00", VA = "0x180440300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D3F")]
			[Address(RVA = "0x51AAD0", Offset = "0x5194D0", VA = "0x18051AAD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000D40 RID: 3392 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000D41 RID: 3393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000160")]
		public Collider2D PlayerCollider
		{
			[Token(Token = "0x6000D40")]
			[Address(RVA = "0x48A940", Offset = "0x489340", VA = "0x18048A940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D41")]
			[Address(RVA = "0x493610", Offset = "0x492010", VA = "0x180493610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000D43 RID: 3395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000161")]
		public DaySceneMap CurrentActiveMap
		{
			[Token(Token = "0x6000D42")]
			[Address(RVA = "0x440320", Offset = "0x43ED20", VA = "0x180440320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D43")]
			[Address(RVA = "0x6086B0", Offset = "0x6070B0", VA = "0x1806086B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000162 RID: 354
		// (set) Token: 0x06000D44 RID: 3396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000162")]
		public bool EnableMap
		{
			[Token(Token = "0x6000D44")]
			[Address(RVA = "0x8F11E0", Offset = "0x8EFBE0", VA = "0x1808F11E0")]
			set
			{
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000D45 RID: 3397 RVA: 0x000059A0 File Offset: 0x00003BA0
		// (set) Token: 0x06000D46 RID: 3398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000163")]
		public bool IsMapSwapping
		{
			[Token(Token = "0x6000D45")]
			[Address(RVA = "0x8F11D0", Offset = "0x8EFBD0", VA = "0x1808F11D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D46")]
			[Address(RVA = "0x8F1280", Offset = "0x8EFC80", VA = "0x1808F1280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D47")]
		[Address(RVA = "0x8EE300", Offset = "0x8ECD00", VA = "0x1808EE300", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D48")]
		[Address(RVA = "0x8F0040", Offset = "0x8EEA40", VA = "0x1808F0040")]
		private void OnFirstEnterDaySceneFinish()
		{
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x8F0290", Offset = "0x8EEC90", VA = "0x1808F0290")]
		private void RefreshCurrentMapNPCs()
		{
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0x8EEDF0", Offset = "0x8ED7F0", VA = "0x1808EEDF0")]
		public void Chat(string characterLabel, bool isPostChat, [Optional] Action<Action> onWillExecuteDayEndEventCallback, [Optional] Action onChatFinished, bool shouldTriggerEvent = true, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.PreserveVisual)
		{
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0x8EF860", Offset = "0x8EE260", VA = "0x1808EF860")]
		private void NormalChat(NPC npcData, [Optional] Action onChatFinished, bool shouldTriggerEvent = true, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.PreserveVisual)
		{
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x8F02C0", Offset = "0x8EECC0", VA = "0x1808F02C0")]
		private void SpecialChat(NPC npcData, bool isPostChat, Action<Action> onWillExecuteDayEndEventCallback, [Optional] Action onChatFinished, bool shouldTriggerEvent = true, AdpUIPanelManager.PanelVisualMode previousPanelVisualMode = AdpUIPanelManager.PanelVisualMode.PreserveVisual)
		{
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x8F0B20", Offset = "0x8EF520", VA = "0x1808F0B20")]
		public void TryOpenRelatedData(string characterLabel)
		{
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x8EF510", Offset = "0x8EDF10", VA = "0x1808EF510")]
		public void ExecuteScheduled(Func<IEnumerator> targetAction)
		{
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D4F")]
		[Address(RVA = "0x8EF480", Offset = "0x8EDE80", VA = "0x1808EF480")]
		private void ExecuteScheduledActions()
		{
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x8EFF40", Offset = "0x8EE940", VA = "0x1808EFF40")]
		private void OnDayOver()
		{
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x8EF730", Offset = "0x8EE130", VA = "0x1808EF730")]
		private IEnumerator InvokeDayOverEvents()
		{
			return null;
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x000059B8 File Offset: 0x00003BB8
		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x8EF660", Offset = "0x8EE060", VA = "0x1808EF660")]
		private UniTask InvokeDayOverEventsAsync()
		{
			return default(UniTask);
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x8EF0F0", Offset = "0x8EDAF0", VA = "0x1808EF0F0")]
		public void Dispose()
		{
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x8F0930", Offset = "0x8EF330", VA = "0x1808F0930")]
		public void SwapMap(string targetMapLabel, string targetMarkerName, int travelCount, bool shouldFadeIn = true, bool shouldFadeOut = true, bool triggerEnterMapEvent = true, [Optional] Action onSwapFinish)
		{
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x000059D0 File Offset: 0x00003BD0
		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x8F07F0", Offset = "0x8EF1F0", VA = "0x1808F07F0")]
		public UniTask SwapMapAsync(string targetMapLabel, string targetMarkerName, int travelCount, bool shouldFadeIn, bool shouldFadeOut, bool triggerEnterMapEvent, Action onSwapFinish)
		{
			return default(UniTask);
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000164")]
		public AssetReference RoguelikeDataProfileAsset
		{
			[Token(Token = "0x6000D56")]
			[Address(RVA = "0x4402C0", Offset = "0x43ECC0", VA = "0x1804402C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000D57 RID: 3415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000165")]
		public AssetReference RoguelikeDataUnchangeableProfileAsset
		{
			[Token(Token = "0x6000D57")]
			[Address(RVA = "0x45A7E0", Offset = "0x4591E0", VA = "0x18045A7E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D58")]
		[Address(RVA = "0x8EEF00", Offset = "0x8ED900", VA = "0x1808EEF00", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D59")]
		[Address(RVA = "0x8F10E0", Offset = "0x8EFAE0", VA = "0x1808F10E0")]
		public SceneManager()
		{
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D5A")]
		[Address(RVA = "0x8F0D20", Offset = "0x8EF720", VA = "0x1808F0D20")]
		[CompilerGenerated]
		private void <OnFirstEnterDaySceneFinish>g__OnActionFinish|40_0()
		{
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D5B")]
		[Address(RVA = "0x8F0FE0", Offset = "0x8EF9E0", VA = "0x1808F0FE0")]
		[CompilerGenerated]
		private void <OnFirstEnterDaySceneFinish>g__TryTriggerEnterHomeEvent|40_1()
		{
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D5C")]
		[Address(RVA = "0x8F0EA0", Offset = "0x8EF8A0", VA = "0x1808F0EA0")]
		[CompilerGenerated]
		private void <OnFirstEnterDaySceneFinish>g__TryShowNoteBook|40_2()
		{
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D5D")]
		[Address(RVA = "0x8F0CA0", Offset = "0x8EF6A0", VA = "0x1808F0CA0")]
		[CompilerGenerated]
		private IEnumerator <ExecuteScheduledActions>g__ExecuteScheduledActions|47_0()
		{
			return null;
		}

		// Token: 0x04000BC1 RID: 3009
		[Token(Token = "0x4000BC1")]
		public const int TRAVEL_ACTION_COST = 1;

		// Token: 0x04000BC2 RID: 3010
		[Token(Token = "0x4000BC2")]
		public const string KOURINDO_KEY = "Rinnosuke";

		// Token: 0x04000BC3 RID: 3011
		[Token(Token = "0x4000BC3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[CleanupIgnore]
		public static Action<Action> onDaySceneReady;

		// Token: 0x04000BC4 RID: 3012
		[Token(Token = "0x4000BC4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string defaultMap;

		// Token: 0x04000BC5 RID: 3013
		[Token(Token = "0x4000BC5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CinemachineVirtualCamera virtualCamera;

		// Token: 0x04000BC6 RID: 3014
		[Token(Token = "0x4000BC6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DialogPackage onDayOverDialog;

		// Token: 0x04000BC7 RID: 3015
		[Token(Token = "0x4000BC7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform characterTransform;

		// Token: 0x04000BC8 RID: 3016
		[Token(Token = "0x4000BC8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RectTransform ActivePannelRoot;

		// Token: 0x04000BC9 RID: 3017
		[Token(Token = "0x4000BC9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Queue<AssetReference> releaseQueue;

		// Token: 0x04000BCA RID: 3018
		[Token(Token = "0x4000BCA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly Queue<Func<IEnumerator>> scheduledActions;

		// Token: 0x04000BCB RID: 3019
		[Token(Token = "0x4000BCB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isExecutingScheduledActions;

		// Token: 0x04000BCC RID: 3020
		[Token(Token = "0x4000BCC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool m_RequireLoadDependencies;

		// Token: 0x04000BD2 RID: 3026
		[Token(Token = "0x4000BD2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_HasTriggerOnEnterDaySceneEvent;

		// Token: 0x04000BD4 RID: 3028
		[Token(Token = "0x4000BD4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Header("Roguelike Data")]
		private AssetReference roguelikeDataProfileAsset;

		// Token: 0x04000BD5 RID: 3029
		[Token(Token = "0x4000BD5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AssetReference roguelikeDataUnchangeableProfileAsset;

		// Token: 0x04000BD6 RID: 3030
		[Token(Token = "0x4000BD6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Header("DLC5 SpecialGuest Controlled")]
		[SerializeField]
		private int m_MasterId;

		// Token: 0x04000BD7 RID: 3031
		[Token(Token = "0x4000BD7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private Vector2Int m_DisappearDayRange;

		// Token: 0x04000BD8 RID: 3032
		[Token(Token = "0x4000BD8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string m_DisappearNewsLabel;

		// Token: 0x04000BD9 RID: 3033
		[Token(Token = "0x4000BD9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string m_AppearNewsLabel;

		// Token: 0x04000BDA RID: 3034
		[Token(Token = "0x4000BDA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string[] m_DisappearReason;

		// Token: 0x04000BDB RID: 3035
		[Token(Token = "0x4000BDB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private string[] m_MapExclusions;
	}
}
