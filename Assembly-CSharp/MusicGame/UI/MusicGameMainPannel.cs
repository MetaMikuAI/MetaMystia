using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI.QTEUtility;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace MusicGame.UI
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[GenerateCleanupMethod]
	public class MusicGameMainPannel : UISubPanel<MusicSelectorPannel>
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000184 RID: 388 RVA: 0x000026A0 File Offset: 0x000008A0
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000025")]
		public MusicGameMainPannelOpenContext PannelOpenContext
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x4150E0", Offset = "0x413AE0", VA = "0x1804150E0")]
			[CompilerGenerated]
			private get
			{
				return default(MusicGameMainPannelOpenContext);
			}
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x415140", Offset = "0x413B40", VA = "0x180415140")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000187 RID: 391 RVA: 0x000026B8 File Offset: 0x000008B8
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000026")]
		public MusicResultPannel.MusicFinalScoreOpenContext? PannelCloseContext
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x4150B0", Offset = "0x413AB0", VA = "0x1804150B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x415110", Offset = "0x413B10", VA = "0x180415110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000188 RID: 392 RVA: 0x000026D0 File Offset: 0x000008D0
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000027")]
		public MusicSelectorPannel.PannelCloseMode CloseMode
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x4150A0", Offset = "0x413AA0", VA = "0x1804150A0")]
			[CompilerGenerated]
			get
			{
				return MusicSelectorPannel.PannelCloseMode.Default;
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x415100", Offset = "0x413B00", VA = "0x180415100")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600018A RID: 394 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x17000028")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x413200", Offset = "0x411C00", VA = "0x180413200", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x414530", Offset = "0x412F30", VA = "0x180414530")]
		private void Pause()
		{
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x412F80", Offset = "0x411980", VA = "0x180412F80", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x414380", Offset = "0x412D80", VA = "0x180414380")]
		private void OnPausePannelClose()
		{
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x413340", Offset = "0x411D40", VA = "0x180413340", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x412E50", Offset = "0x411850", VA = "0x180412E50")]
		private AssetReference GetCGAssetReference(RunTimeScheduler.CGPicture.MultiLanguageCGPic multiLanguageCGPic)
		{
			return null;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x414690", Offset = "0x413090", VA = "0x180414690")]
		private void SpawnDancingCharacter()
		{
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x412A50", Offset = "0x411450", VA = "0x180412A50")]
		private void CheckScoreProgress(float currentScoreProgress)
		{
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x412530", Offset = "0x410F30", VA = "0x180412530")]
		private void AddDancingCharacter()
		{
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x414D20", Offset = "0x413720", VA = "0x180414D20")]
		private void TryChangeCharacterStatus()
		{
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x412D90", Offset = "0x411790", VA = "0x180412D90")]
		public void ClearExsitedCharacter()
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x412750", Offset = "0x411150", VA = "0x180412750")]
		public void CheckCurrentCombo(int currentCombo)
		{
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x412AD0", Offset = "0x4114D0", VA = "0x180412AD0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x414EF0", Offset = "0x4138F0", VA = "0x180414EF0")]
		public MusicGameMainPannel()
		{
		}

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image PlayerPortrayal;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image CG;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private QTEPannel MusicGameQTEPannel;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private QTEPannel MusicGameQTEPannelCleanMode;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private MusicGameCountDownPannel CountDownPannel;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private MusicGamePausePannel PausePannel;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform QTEPannelField;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIButtonSimple PauseButton;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float cgPicDuration;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private string[] cgExceptionLabel;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float transitDuration;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private float m_NormalModePortrayalY;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_CleanModePortrayalY;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private RectTransform m_PlayerPortrayalFrame;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject[] m_ElementToHideOnCleanMode;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0xE8")]
		[Header("跳舞小人")]
		public GameObject mystiaCharacterElement;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0xF0")]
		public GameObject dancingCharacterElement;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0xF8")]
		public RectTransform characterAnimtionField;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x100")]
		[Header("助威小人")]
		public Transform cheerGuestTransform;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x108")]
		public int targetCombo;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x110")]
		public GameObject BottomRightComboAnim;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x118")]
		public GameObject TopLeftComboAnim;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x120")]
		public GameObject TopRightComboAnim;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private CheerGuestSpawnMode[] cheerGuestImage;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x130")]
		private readonly List<MusicGameMainDancingCharacterElement> dancingCharacters;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x138")]
		private readonly HashSet<AsyncOperationHandle<Sprite>> m_LoadedHandle;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x140")]
		private readonly HashSet<AsyncOperationHandle> m_LoadedHandleCG;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x148")]
		private int accumulatedCombo;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x150")]
		private List<Sprite> CGPictures;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x158")]
		private List<ValueTuple<int, Sprite>> cheeringGuests;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x160")]
		private float currentScoreProgress;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x164")]
		private bool firstElementFloated;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x168")]
		private int haveSpawnedGuestNum;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x16C")]
		private int lastCornerId;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x170")]
		private Coroutine m_AnimatedPortrayalCoroutine;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x178")]
		private Action m_PauseQTETimerCallback;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x180")]
		private Coroutine m_PlayCGCoroutine;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x188")]
		private QTEPannel m_QTEPannel;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x190")]
		private Action m_ResumeQTETimerCallback;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x198")]
		private int targetScoreProgress;
	}
}
