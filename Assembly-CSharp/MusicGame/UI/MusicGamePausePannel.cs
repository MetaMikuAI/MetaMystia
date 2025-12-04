using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace MusicGame.UI
{
	// Token: 0x02000057 RID: 87
	[Token(Token = "0x2000057")]
	[GenerateCleanupMethod]
	public class MusicGamePausePannel : UIPanel
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x00002808 File Offset: 0x00000A08
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002D")]
		public MusicGamePausePannel.MusicAbortMode AbortMode
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x4171F0", Offset = "0x415BF0", VA = "0x1804171F0")]
			[CompilerGenerated]
			get
			{
				return MusicGamePausePannel.MusicAbortMode.Continue;
			}
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x417210", Offset = "0x415C10", VA = "0x180417210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00002820 File Offset: 0x00000A20
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002E")]
		public bool EnableRestartAndExit
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x417200", Offset = "0x415C00", VA = "0x180417200")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x417220", Offset = "0x415C20", VA = "0x180417220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x416C20", Offset = "0x415620", VA = "0x180416C20", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x416E50", Offset = "0x415850", VA = "0x180416E50", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x416C10", Offset = "0x415610", VA = "0x180416C10", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x416DC0", Offset = "0x4157C0", VA = "0x180416DC0", Slot = "28")]
		protected override void OnPanelOpenCloseFadeFinish(FadeType fadeType)
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x40FE80", Offset = "0x40E880", VA = "0x18040FE80", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x4171E0", Offset = "0x415BE0", VA = "0x1804171E0")]
		public MusicGamePausePannel()
		{
		}

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x70")]
		public UIButtonSimple ContinueBtn;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x78")]
		public UIButtonSimple BackBtn;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x80")]
		public UIButtonSimple RestartBtn;

		// Token: 0x02000058 RID: 88
		[Token(Token = "0x2000058")]
		public enum MusicAbortMode
		{
			// Token: 0x040001A2 RID: 418
			[Token(Token = "0x40001A2")]
			Continue,
			// Token: 0x040001A3 RID: 419
			[Token(Token = "0x40001A3")]
			Back,
			// Token: 0x040001A4 RID: 420
			[Token(Token = "0x40001A4")]
			Restart
		}
	}
}
