using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI.QTEUtility;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace MusicGame.UI
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	[GenerateCleanupMethod]
	public class DLC3_MusicGameMainPannel : UISubPanel<DLC3_MusicGameStartPannel>
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x1700004C")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00002B80 File Offset: 0x00000D80
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004D")]
		public DLC3_MusicGameMainPannelOpenContext PannelOpenContext
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x425490", Offset = "0x423E90", VA = "0x180425490")]
			[CompilerGenerated]
			private get
			{
				return default(DLC3_MusicGameMainPannelOpenContext);
			}
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x425550", Offset = "0x423F50", VA = "0x180425550")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00002B98 File Offset: 0x00000D98
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004E")]
		public DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext? PannelCloseContext
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x425470", Offset = "0x423E70", VA = "0x180425470")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x425530", Offset = "0x423F30", VA = "0x180425530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600028E RID: 654 RVA: 0x00002BB0 File Offset: 0x00000DB0
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004F")]
		public MusicSelectorPannel.PannelCloseMode CloseMode
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x425460", Offset = "0x423E60", VA = "0x180425460")]
			[CompilerGenerated]
			get
			{
				return MusicSelectorPannel.PannelCloseMode.Default;
			}
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x425520", Offset = "0x423F20", VA = "0x180425520")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x422DA0", Offset = "0x4217A0", VA = "0x180422DA0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x4239E0", Offset = "0x4223E0", VA = "0x1804239E0")]
		private void Pause()
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x422C30", Offset = "0x421630", VA = "0x180422C30", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x423850", Offset = "0x422250", VA = "0x180423850")]
		private void OnPausePannelClose(MusicGamePausePannel musicGamePausePannel)
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x4240D0", Offset = "0x422AD0", VA = "0x1804240D0")]
		private void SetPlayerRockImage(DLC3_MusicGameMainPannel.RockStatus rockStatus)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x423F50", Offset = "0x422950", VA = "0x180423F50")]
		private void SetBossRockImage(DLC3_MusicGameMainPannel.RockStatus rockStatus)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x4231E0", Offset = "0x421BE0", VA = "0x1804231E0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x4239C0", Offset = "0x4223C0", VA = "0x1804239C0")]
		private void OnPlayerNoteProcess(int combo)
		{
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x422500", Offset = "0x420F00", VA = "0x180422500")]
		private void OnBossNoteProcess(long startTime)
		{
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x424250", Offset = "0x422C50", VA = "0x180424250")]
		private void SpawnDancingCharacter()
		{
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x422010", Offset = "0x420A10", VA = "0x180422010")]
		private void CheckScoreProgress(float currentScoreProgress)
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x422460", Offset = "0x420E60", VA = "0x180422460")]
		private string GetDancingRange()
		{
			return null;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x421F30", Offset = "0x420930", VA = "0x180421F30")]
		private void AddDancingCharacter()
		{
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x424930", Offset = "0x423330", VA = "0x180424930")]
		private void TryChangeCharacterStatus()
		{
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x423DB0", Offset = "0x4227B0", VA = "0x180423DB0")]
		protected void PlayNoteSucceedAnimation(bool isPlayer)
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x423C10", Offset = "0x422610", VA = "0x180423C10")]
		protected void PlayNoteFailedAnimation(bool isPlayer)
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x422160", Offset = "0x420B60", VA = "0x180422160", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x424D80", Offset = "0x423780", VA = "0x180424D80")]
		public DLC3_MusicGameMainPannel()
		{
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A2")]
		[CompilerGenerated]
		private T <OnPanelInitialize>g__CreateNoteAnimationInstance|64_0<T>(T parent) where T : Component
		{
			return null;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A3")]
		[CompilerGenerated]
		internal static void <OnPanelInitialize>g__DestroyInstance|64_1<T>(T instance) where T : Component
		{
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x424C00", Offset = "0x423600", VA = "0x180424C00")]
		[CompilerGenerated]
		private NoteHeadFinishAnimationController <OnPanelInitialize>g__CreateSucceedAnimationInstance|64_2()
		{
			return null;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x424BC0", Offset = "0x4235C0", VA = "0x180424BC0")]
		[CompilerGenerated]
		private NoteHeadFinishAnimationController <OnPanelInitialize>g__CreateFailedAnimationInstance|64_3()
		{
			return null;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x424C90", Offset = "0x423690", VA = "0x180424C90")]
		[CompilerGenerated]
		internal static void <OnPanelInitialize>g__EnableAnimation|64_4(NoteHeadFinishAnimationController animator)
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x424C40", Offset = "0x423640", VA = "0x180424C40")]
		[CompilerGenerated]
		internal static void <OnPanelInitialize>g__DisableAnimation|64_5(NoteHeadFinishAnimationController animator)
		{
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x424A50", Offset = "0x423450", VA = "0x180424A50")]
		[CompilerGenerated]
		internal static void <OnBossNoteProcess>g__SetLight|72_4(Image image, float target)
		{
		}

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image PlayerPortrayal;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private QTEPannel MusicGameQTEPannel;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private MusicGameCountDownPannel CountDownPannel;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private MusicGamePausePannel PausePannel;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform QTEPannelField;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIButtonSimple PauseButton;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float m_NormalModePortrayalY;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RectTransform m_PlayerPortrayalFrame;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0xB8")]
		[Header("跳舞小人")]
		public GameObject mystiaCharacterElement;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject dancingCharacterElement;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0xC8")]
		public RectTransform characterAnimtionField;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0xD0")]
		public UIElementCluster cluster;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0xD8")]
		[Header("演奏演出")]
		public Image playerRockImage;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0xE0")]
		public Image bossRockImage;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0xE8")]
		public NoteHeadFinishAnimationController AnimatorSucceed;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0xF0")]
		public NoteHeadFinishAnimationController AnimatorFail;

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0xF8")]
		public Vector3 offset;

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x108")]
		public RectTransform AnimationField;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x110")]
		public Image playerLight;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x118")]
		public Image bossLight;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x120")]
		public float frameTime;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x128")]
		private readonly List<MusicGameMainDancingCharacterElement> dancingCharacters;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x130")]
		private readonly HashSet<NoteHeadFinishAnimationController> m_ActiveAnimations;

		// Token: 0x0400026E RID: 622
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x138")]
		private readonly string[] m_AvailableActions;

		// Token: 0x0400026F RID: 623
		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x140")]
		private int bossGetCombo;

		// Token: 0x04000270 RID: 624
		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x144")]
		private float bossGetScore;

		// Token: 0x04000271 RID: 625
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x148")]
		private float comboScore;

		// Token: 0x04000272 RID: 626
		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x14C")]
		private int currentGetCombo;

		// Token: 0x04000273 RID: 627
		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x150")]
		private int currentNote;

		// Token: 0x04000274 RID: 628
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x154")]
		private float currentScoreProgress;

		// Token: 0x04000275 RID: 629
		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x158")]
		private bool firstElementFloated;

		// Token: 0x04000276 RID: 630
		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x15C")]
		private int haveSpawnedGuestNum;

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x160")]
		private Coroutine m_AnimatedPortrayalCoroutine;

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x168")]
		private bool m_hasStarted;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x170")]
		protected ObjectPool<NoteHeadFinishAnimationController> m_NoteFailedAnimationPool;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x178")]
		protected ObjectPool<NoteHeadFinishAnimationController> m_NoteSucceedAnimationPool;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x180")]
		private Action m_PauseQTETimerCallback;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x188")]
		private Coroutine m_PlayCGCoroutine;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x190")]
		private QTEPannel m_QTEPannel;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x198")]
		private Action m_ResumeQTETimerCallback;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x1A0")]
		private int maxGetCombo;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x1A8")]
		private List<int> missedNotes;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x1B0")]
		private HashSet<long> noteHashSetBoss;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x1B8")]
		private HashSet<long> noteHashSetPlayer;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x1C0")]
		private DLC3_MusicGameMainPannel.NoteStatus noteStatus;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x1C4")]
		private float perNoteScore;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x1C8")]
		private DLC3_MusicGameMainPannel.RockStatus playerStatus;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x1CC")]
		private DLC3_MusicGameMainPannel.RockStatus bossStatus;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x1D0")]
		private Coroutine rockCorotine;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x1D8")]
		private int targetScoreProgress;

		// Token: 0x02000077 RID: 119
		[Token(Token = "0x2000077")]
		private enum RockStatus
		{
			// Token: 0x0400028D RID: 653
			[Token(Token = "0x400028D")]
			Wait,
			// Token: 0x0400028E RID: 654
			[Token(Token = "0x400028E")]
			Rock,
			// Token: 0x0400028F RID: 655
			[Token(Token = "0x400028F")]
			Rock2,
			// Token: 0x04000290 RID: 656
			[Token(Token = "0x4000290")]
			Fail
		}

		// Token: 0x02000078 RID: 120
		[Token(Token = "0x2000078")]
		private enum NoteStatus
		{
			// Token: 0x04000292 RID: 658
			[Token(Token = "0x4000292")]
			Up,
			// Token: 0x04000293 RID: 659
			[Token(Token = "0x4000293")]
			Down
		}
	}
}
