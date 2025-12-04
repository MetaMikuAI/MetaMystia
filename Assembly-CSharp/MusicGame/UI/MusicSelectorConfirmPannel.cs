using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace MusicGame.UI
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[GenerateCleanupMethod]
	public class MusicSelectorConfirmPannel : UISubPanel<MusicSelectorPannel>
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00002970 File Offset: 0x00000B70
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700003C")]
		public MusicSelectorConfirmPannelOpenContext OpenContext
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x426F70", Offset = "0x425970", VA = "0x180426F70")]
			[CompilerGenerated]
			get
			{
				return default(MusicSelectorConfirmPannelOpenContext);
			}
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x426F90", Offset = "0x425990", VA = "0x180426F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00002988 File Offset: 0x00000B88
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700003D")]
		public DifficultyMode DifficultyMode
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x409E30", Offset = "0x408830", VA = "0x180409E30")]
			[CompilerGenerated]
			get
			{
				return DifficultyMode.Easy;
			}
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x409E60", Offset = "0x408860", VA = "0x180409E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000229 RID: 553 RVA: 0x000029A0 File Offset: 0x00000BA0
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700003E")]
		public PlayMode PlayMode
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x409E40", Offset = "0x408840", VA = "0x180409E40")]
			[CompilerGenerated]
			get
			{
				return PlayMode.Back;
			}
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x409E70", Offset = "0x408870", VA = "0x180409E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600022B RID: 555 RVA: 0x000029B8 File Offset: 0x00000BB8
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700003F")]
		public float MusicalNoteSpeed
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x426F60", Offset = "0x425960", VA = "0x180426F60")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600022C")]
			[Address(RVA = "0x426F80", Offset = "0x425980", VA = "0x180426F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600022D RID: 557 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x17000040")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x426B30", Offset = "0x425530", VA = "0x180426B30", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x426B80", Offset = "0x425580", VA = "0x180426B80", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x426D30", Offset = "0x425730", VA = "0x180426D30")]
		public void SetRankButton(string mapLabel, Action<string, bool> openRankCallback)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x426A00", Offset = "0x425400", VA = "0x180426A00")]
		private void Confirm(DifficultyMode difficultyMode)
		{
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x426CA0", Offset = "0x4256A0", VA = "0x180426CA0")]
		private void OnReconfirmPannelClose(MusicSelectorReconfirmPannel pannel)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x426970", Offset = "0x425370", VA = "0x180426970", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x426F20", Offset = "0x425920", VA = "0x180426F20")]
		public MusicSelectorConfirmPannel()
		{
		}

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIButtonSimple m_EasyModeStartButton;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIButtonSimple m_HardModeStartButton;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIButtonSimple m_EasyModeRankButton;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIButtonSimple m_HardModeRankButton;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private MusicSelectorReconfirmPannel m_MusicSelectorReconfirmPannelPrefab;
	}
}
