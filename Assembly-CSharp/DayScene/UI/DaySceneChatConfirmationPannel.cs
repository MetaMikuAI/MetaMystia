using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.UI
{
	// Token: 0x02000265 RID: 613
	[Token(Token = "0x2000265")]
	[GenerateCleanupMethod]
	public class DaySceneChatConfirmationPannel : UIPanel
	{
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x00005E98 File Offset: 0x00004098
		// (set) Token: 0x06000E23 RID: 3619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700016D")]
		public bool Result
		{
			[Token(Token = "0x6000E22")]
			[Address(RVA = "0x8FECC0", Offset = "0x8FD6C0", VA = "0x1808FECC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E23")]
			[Address(RVA = "0x8FECD0", Offset = "0x8FD6D0", VA = "0x1808FECD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E24")]
		[Address(RVA = "0x8FEB10", Offset = "0x8FD510", VA = "0x1808FEB10", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E25")]
		[Address(RVA = "0x8FEC70", Offset = "0x8FD670", VA = "0x1808FEC70", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E26")]
		[Address(RVA = "0x8FEB00", Offset = "0x8FD500", VA = "0x1808FEB00")]
		private void ExitWithResult(bool result)
		{
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E27")]
		[Address(RVA = "0x40C160", Offset = "0x40AB60", VA = "0x18040C160", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x408E80", Offset = "0x407880", VA = "0x180408E80")]
		public DaySceneChatConfirmationPannel()
		{
		}

		// Token: 0x04000D1B RID: 3355
		[Token(Token = "0x4000D1B")]
		[FieldOffset(Offset = "0x70")]
		public UIButtonSimple Yes;

		// Token: 0x04000D1C RID: 3356
		[Token(Token = "0x4000D1C")]
		[FieldOffset(Offset = "0x78")]
		public UIButtonSimple No;
	}
}
