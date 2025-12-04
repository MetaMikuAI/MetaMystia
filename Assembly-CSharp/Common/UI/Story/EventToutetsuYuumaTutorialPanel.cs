using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace Common.UI.Story
{
	// Token: 0x02000F62 RID: 3938
	[Token(Token = "0x2000F62")]
	[GenerateCleanupMethod]
	public class EventToutetsuYuumaTutorialPanel : UIPanelParamOpen<EventToutetsuYuumaTutorialPanel.YuumaTutorialPhase>
	{
		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x06005C99 RID: 23705 RVA: 0x00020310 File Offset: 0x0001E510
		// (set) Token: 0x06005C9A RID: 23706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D04")]
		private EventToutetsuYuumaTutorialPanel.YuumaTutorialPhase CurrentYuumaTutorialPhase
		{
			[Token(Token = "0x6005C99")]
			[Address(RVA = "0x477F00", Offset = "0x476900", VA = "0x180477F00")]
			[CompilerGenerated]
			get
			{
				return EventToutetsuYuumaTutorialPanel.YuumaTutorialPhase.First;
			}
			[Token(Token = "0x6005C9A")]
			[Address(RVA = "0x4D2350", Offset = "0x4D0D50", VA = "0x1804D2350")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005C9B RID: 23707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C9B")]
		[Address(RVA = "0x8ABB60", Offset = "0x8AA560", VA = "0x1808ABB60", Slot = "32")]
		protected override void OnPanelOpen(EventToutetsuYuumaTutorialPanel.YuumaTutorialPhase yuumaTutorialPhase)
		{
		}

		// Token: 0x06005C9C RID: 23708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C9C")]
		[Address(RVA = "0x8AC030", Offset = "0x8AAA30", VA = "0x1808AC030")]
		private void OpenPanel(ValueTuple<bool, bool> isLastPage, EventToutetsuYuumaTutorialSubPanel pannelPrefab, Action<EventToutetsuYuumaTutorialSubPanel.PannelCloseType> onPannelClose)
		{
		}

		// Token: 0x06005C9D RID: 23709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C9D")]
		[Address(RVA = "0x8ABCD0", Offset = "0x8AA6D0", VA = "0x1808ABCD0")]
		private void OpenPanelA()
		{
		}

		// Token: 0x06005C9E RID: 23710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C9E")]
		[Address(RVA = "0x8ABDA0", Offset = "0x8AA7A0", VA = "0x1808ABDA0")]
		private void OpenPanelB()
		{
		}

		// Token: 0x06005C9F RID: 23711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C9F")]
		[Address(RVA = "0x8ABE70", Offset = "0x8AA870", VA = "0x1808ABE70")]
		private void OpenPanelC()
		{
		}

		// Token: 0x06005CA0 RID: 23712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA0")]
		[Address(RVA = "0x8ABF50", Offset = "0x8AA950", VA = "0x1808ABF50")]
		private void OpenPanelD()
		{
		}

		// Token: 0x06005CA1 RID: 23713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA1")]
		[Address(RVA = "0x8AB3C0", Offset = "0x8A9DC0", VA = "0x1808AB3C0")]
		private void OnPanelClose(EventToutetsuYuumaTutorialSubPanel.PannelCloseType closeInfo, Action prev, Action next)
		{
		}

		// Token: 0x06005CA2 RID: 23714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA2")]
		[Address(RVA = "0x8AB7E0", Offset = "0x8AA1E0", VA = "0x1808AB7E0")]
		private void OnPanelAClose(EventToutetsuYuumaTutorialSubPanel.PannelCloseType closeInfo)
		{
		}

		// Token: 0x06005CA3 RID: 23715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA3")]
		[Address(RVA = "0x8AB880", Offset = "0x8AA280", VA = "0x1808AB880")]
		private void OnPanelBClose(EventToutetsuYuumaTutorialSubPanel.PannelCloseType closeInfo)
		{
		}

		// Token: 0x06005CA4 RID: 23716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA4")]
		[Address(RVA = "0x8AB960", Offset = "0x8AA360", VA = "0x1808AB960")]
		private void OnPanelCClose(EventToutetsuYuumaTutorialSubPanel.PannelCloseType closeInfo)
		{
		}

		// Token: 0x06005CA5 RID: 23717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA5")]
		[Address(RVA = "0x8ABA70", Offset = "0x8AA470", VA = "0x1808ABA70")]
		private void OnPanelDClose(EventToutetsuYuumaTutorialSubPanel.PannelCloseType closeInfo)
		{
		}

		// Token: 0x06005CA6 RID: 23718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA6")]
		[Address(RVA = "0x4644B0", Offset = "0x462EB0", VA = "0x1804644B0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005CA7 RID: 23719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CA7")]
		[Address(RVA = "0x8AC0E0", Offset = "0x8AAAE0", VA = "0x1808AC0E0")]
		public EventToutetsuYuumaTutorialPanel()
		{
		}

		// Token: 0x040055C2 RID: 21954
		[Token(Token = "0x40055C2")]
		[FieldOffset(Offset = "0x78")]
		public EventToutetsuYuumaTutorialSubPanel pageA;

		// Token: 0x040055C3 RID: 21955
		[Token(Token = "0x40055C3")]
		[FieldOffset(Offset = "0x80")]
		public EventToutetsuYuumaTutorialSubPanel pageB;

		// Token: 0x040055C4 RID: 21956
		[Token(Token = "0x40055C4")]
		[FieldOffset(Offset = "0x88")]
		public EventToutetsuYuumaTutorialSubPanel pageC;

		// Token: 0x040055C5 RID: 21957
		[Token(Token = "0x40055C5")]
		[FieldOffset(Offset = "0x90")]
		public EventToutetsuYuumaTutorialSubPanel pageD;

		// Token: 0x02000F63 RID: 3939
		[Token(Token = "0x2000F63")]
		public enum YuumaTutorialPhase
		{
			// Token: 0x040055C8 RID: 21960
			[Token(Token = "0x40055C8")]
			First,
			// Token: 0x040055C9 RID: 21961
			[Token(Token = "0x40055C9")]
			Second,
			// Token: 0x040055CA RID: 21962
			[Token(Token = "0x40055CA")]
			ReMemory
		}
	}
}
