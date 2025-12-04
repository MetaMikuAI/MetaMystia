using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace MusicGame.UI
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	[GenerateCleanupMethod]
	public class MusicResultPannel : UISubPanel<MusicSelectorPannel>
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x17000032")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x000028E0 File Offset: 0x00000AE0
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000033")]
		public MusicResultPannel.MusicFinalScoreOpenContext? OpenContext
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x419D10", Offset = "0x418710", VA = "0x180419D10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x419D70", Offset = "0x418770", VA = "0x180419D70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000034")]
		public Func<int, int> GetScoreLevelCallback
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x419D00", Offset = "0x418700", VA = "0x180419D00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x419D50", Offset = "0x418750", VA = "0x180419D50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000028F8 File Offset: 0x00000AF8
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000035")]
		public MusicSelectorPannel.PannelCloseMode CloseMode
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x419CF0", Offset = "0x4186F0", VA = "0x180419CF0")]
			[CompilerGenerated]
			get
			{
				return MusicSelectorPannel.PannelCloseMode.Default;
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x419D40", Offset = "0x418740", VA = "0x180419D40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x419410", Offset = "0x417E10", VA = "0x180419410", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x419BD0", Offset = "0x4185D0", VA = "0x180419BD0")]
		private IEnumerator TypeCoroutine()
		{
			return null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x419290", Offset = "0x417C90", VA = "0x180419290", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x419310", Offset = "0x417D10", VA = "0x180419310", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x419B20", Offset = "0x418520", VA = "0x180419B20")]
		private void Restart()
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x4191F0", Offset = "0x417BF0", VA = "0x1804191F0")]
		private void OnClose()
		{
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x419050", Offset = "0x417A50", VA = "0x180419050", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x419CB0", Offset = "0x4186B0", VA = "0x180419CB0")]
		public MusicResultPannel()
		{
		}

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		private const float DIGIT_TYPE_SPEED = 1f;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		private const string ZERO_STRING = "0";

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI musicNameText;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI musicLevelText;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI scoreText;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI perfectText;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI goodText;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI badText;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0xA8")]
		public TextMeshProUGUI keyMode;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0xB0")]
		public Image characterImage;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0xB8")]
		public UIButtonSimple confirmButton;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0xC0")]
		public UIButtonSimple restartButton;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0xC8")]
		public GameObject newHighScoreEffect;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0xD0")]
		public GameObject skipIndicator;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0xD8")]
		public UIElementCluster CDComponent;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0xE0")]
		[Header("[Result Rank]")]
		public Image rankVisual;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0xE8")]
		public TMP_Text rankDialogText;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0xF0")]
		public SerializableKeyValuePair<string, Sprite>[] ranks;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0xF8")]
		private Coroutine m_AnimatedPortrayalCoroutine;

		// Token: 0x0200005E RID: 94
		[Token(Token = "0x200005E")]
		public readonly struct MusicFinalScoreOpenContext
		{
			// Token: 0x06000202 RID: 514 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x425CB0", Offset = "0x4246B0", VA = "0x180425CB0")]
			public MusicFinalScoreOpenContext(string musicLabel, bool isEasyMode, int score, int lastHighScore, int perfect, int good, int bad)
			{
			}

			// Token: 0x040001D0 RID: 464
			[Token(Token = "0x40001D0")]
			[FieldOffset(Offset = "0x0")]
			public readonly string MusicLabel;

			// Token: 0x040001D1 RID: 465
			[Token(Token = "0x40001D1")]
			[FieldOffset(Offset = "0x8")]
			public readonly bool IsEasyMode;

			// Token: 0x040001D2 RID: 466
			[Token(Token = "0x40001D2")]
			[FieldOffset(Offset = "0xC")]
			public readonly int Score;

			// Token: 0x040001D3 RID: 467
			[Token(Token = "0x40001D3")]
			[FieldOffset(Offset = "0x10")]
			public readonly int LastHighScore;

			// Token: 0x040001D4 RID: 468
			[Token(Token = "0x40001D4")]
			[FieldOffset(Offset = "0x14")]
			public readonly int Perfect;

			// Token: 0x040001D5 RID: 469
			[Token(Token = "0x40001D5")]
			[FieldOffset(Offset = "0x18")]
			public readonly int Good;

			// Token: 0x040001D6 RID: 470
			[Token(Token = "0x40001D6")]
			[FieldOffset(Offset = "0x1C")]
			public readonly int Bad;
		}
	}
}
