using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace Common.UI.EscapeUtility
{
	// Token: 0x02000F45 RID: 3909
	[Token(Token = "0x2000F45")]
	[GenerateCleanupMethod]
	public class EscEscPannel : UISubPanel<EscMainPannel>
	{
		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06005C06 RID: 23558 RVA: 0x00020118 File Offset: 0x0001E318
		// (set) Token: 0x06005C07 RID: 23559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CF5")]
		public EscEscPannel.CloseContext CloseData
		{
			[Token(Token = "0x6005C06")]
			[Address(RVA = "0x440460", Offset = "0x43EE60", VA = "0x180440460")]
			[CompilerGenerated]
			get
			{
				return EscEscPannel.CloseContext.BackToMainMenu;
			}
			[Token(Token = "0x6005C07")]
			[Address(RVA = "0x655DE0", Offset = "0x6547E0", VA = "0x180655DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005C08 RID: 23560 RVA: 0x00020130 File Offset: 0x0001E330
		[Token(Token = "0x6005C08")]
		[Address(RVA = "0x885590", Offset = "0x883F90", VA = "0x180885590", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06005C09 RID: 23561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C09")]
		[Address(RVA = "0x8855B0", Offset = "0x883FB0", VA = "0x1808855B0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005C0A RID: 23562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0A")]
		[Address(RVA = "0x885710", Offset = "0x884110", VA = "0x180885710")]
		private void OnSubmit(EscEscPannel.CloseContext closeContext)
		{
		}

		// Token: 0x06005C0B RID: 23563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0B")]
		[Address(RVA = "0x8856D0", Offset = "0x8840D0", VA = "0x1808856D0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005C0C RID: 23564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0C")]
		[Address(RVA = "0x442B10", Offset = "0x441510", VA = "0x180442B10", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005C0D RID: 23565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C0D")]
		[Address(RVA = "0x885850", Offset = "0x884250", VA = "0x180885850")]
		public EscEscPannel()
		{
		}

		// Token: 0x0400553E RID: 21822
		[Token(Token = "0x400553E")]
		[FieldOffset(Offset = "0x78")]
		public UIButtonHold BackToMainMenuBtn;

		// Token: 0x0400553F RID: 21823
		[Token(Token = "0x400553F")]
		[FieldOffset(Offset = "0x80")]
		public UIButtonHold CloseGameBtn;

		// Token: 0x04005540 RID: 21824
		[Token(Token = "0x4005540")]
		[FieldOffset(Offset = "0x88")]
		private bool m_ShouldInstantClose;

		// Token: 0x02000F46 RID: 3910
		[Token(Token = "0x2000F46")]
		public enum CloseContext
		{
			// Token: 0x04005543 RID: 21827
			[Token(Token = "0x4005543")]
			BackToMainMenu,
			// Token: 0x04005544 RID: 21828
			[Token(Token = "0x4005544")]
			CloseGame,
			// Token: 0x04005545 RID: 21829
			[Token(Token = "0x4005545")]
			None
		}
	}
}
