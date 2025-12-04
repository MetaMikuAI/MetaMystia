using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace MusicGame.UI
{
	// Token: 0x02000074 RID: 116
	[Token(Token = "0x2000074")]
	[GenerateCleanupMethod]
	public class MusicSelectorReconfirmPannel : UIPanel
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00002AA8 File Offset: 0x00000CA8
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000046")]
		public MusicSelectorReconfirmPannelOpenContext OpenContext
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x429B60", Offset = "0x428560", VA = "0x180429B60")]
			[CompilerGenerated]
			get
			{
				return default(MusicSelectorReconfirmPannelOpenContext);
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x429B90", Offset = "0x428590", VA = "0x180429B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600026D RID: 621 RVA: 0x00002AC0 File Offset: 0x00000CC0
		// (set) Token: 0x0600026E RID: 622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000047")]
		public PlayMode ExitContext
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x429B20", Offset = "0x428520", VA = "0x180429B20")]
			[CompilerGenerated]
			get
			{
				return PlayMode.Back;
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x429B70", Offset = "0x428570", VA = "0x180429B70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00002AD8 File Offset: 0x00000CD8
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000048")]
		public float MusicalNoteSpeed
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x429B50", Offset = "0x428550", VA = "0x180429B50")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x429B80", Offset = "0x428580", VA = "0x180429B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x17000049")]
		private bool IsEasy
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x429B30", Offset = "0x428530", VA = "0x180429B30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000272 RID: 626 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x1700004A")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x429260", Offset = "0x427C60", VA = "0x180429260", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x4298F0", Offset = "0x4282F0", VA = "0x1804298F0")]
		private void OnSettingButtonClick()
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x429A70", Offset = "0x428470", VA = "0x180429A70")]
		private void UpdateValues()
		{
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x4296F0", Offset = "0x4280F0", VA = "0x1804296F0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x428EE0", Offset = "0x4278E0", VA = "0x180428EE0")]
		public float GetMusicSpeed()
		{
			return 0f;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x429230", Offset = "0x427C30", VA = "0x180429230", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x429000", Offset = "0x427A00", VA = "0x180429000")]
		public float GetNoteSpeedProgress(float progress)
		{
			return 0f;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x428F30", Offset = "0x427930", VA = "0x180428F30")]
		public string GetNoteSpeedDisplay(float progress)
		{
			return null;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x4291A0", Offset = "0x427BA0", VA = "0x1804291A0")]
		public void OnMusicVolumeChanged(float newValue)
		{
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x4290E0", Offset = "0x427AE0", VA = "0x1804290E0")]
		public void OnButtonVolumeChanged(float newValue)
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x429200", Offset = "0x427C00", VA = "0x180429200")]
		public void OnMusicalNoteSpeedChanged(float newValue)
		{
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x4291B0", Offset = "0x427BB0", VA = "0x1804291B0")]
		public void OnMusicalCleanModeChanged(bool enabled)
		{
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x4291C0", Offset = "0x427BC0", VA = "0x1804291C0")]
		private void OnMusicalNoteSpeedChangedVisual(float newValue)
		{
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x4290F0", Offset = "0x427AF0", VA = "0x1804290F0")]
		private void OnMusicVolumeChangedVisual(float newValue)
		{
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x429030", Offset = "0x427A30", VA = "0x180429030")]
		private void OnButtonVolumeChangedVisual(float newValue)
		{
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x428DB0", Offset = "0x4277B0", VA = "0x180428DB0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x408E80", Offset = "0x407880", VA = "0x180408E80")]
		public MusicSelectorReconfirmPannel()
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x429A00", Offset = "0x428400", VA = "0x180429A00")]
		[CompilerGenerated]
		private void <OnPanelInitialize>g__OnConfirm|30_1()
		{
		}

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Header("Control")]
		private UIScrollBar m_MusicalNoteSpeed;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TMP_Text m_MusicalNoteSpeedPercentageText;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIScrollBar m_MusicVolume;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TMP_Text m_MusicVolumePercentageText;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIScrollBar m_ButtonVolume;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TMP_Text m_ButtonVolumePercentageText;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIButtonToggle m_AutoMode;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIButtonToggle m_CleanMode;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0xB0")]
		[Header("Options")]
		[SerializeField]
		private UIButtonSimple m_YesButton;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIButtonSimple m_NoButton;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIButtonSimple m_SettingButton;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Header("Setting")]
		private MusicGameConfigPannel m_MusicGameConfigPannel;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0xD0")]
		[Header("Hide In BossMode")]
		[SerializeField]
		private GameObject[] HideInBossMode;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_IsAutoMode;
	}
}
