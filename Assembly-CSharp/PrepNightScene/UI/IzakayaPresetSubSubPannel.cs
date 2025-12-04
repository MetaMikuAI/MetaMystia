using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace PrepNightScene.UI
{
	// Token: 0x020000E0 RID: 224
	[Token(Token = "0x20000E0")]
	[GenerateCleanupMethod]
	public class IzakayaPresetSubSubPannel : UIPanel
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00003468 File Offset: 0x00001668
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006B")]
		public IzakayaPresetSubSubPannel.PannelCloseContext CloseContext
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x4404D0", Offset = "0x43EED0", VA = "0x1804404D0")]
			[CompilerGenerated]
			get
			{
				return IzakayaPresetSubSubPannel.PannelCloseContext.Yes;
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x56F810", Offset = "0x56E210", VA = "0x18056F810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00003480 File Offset: 0x00001680
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006C")]
		public bool ShouldSelectNoByDefault
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x56F800", Offset = "0x56E200", VA = "0x18056F800")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x56F820", Offset = "0x56E220", VA = "0x18056F820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x56F680", Offset = "0x56E080", VA = "0x18056F680", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x56F7E0", Offset = "0x56E1E0", VA = "0x18056F7E0")]
		private void OnYes()
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x56F790", Offset = "0x56E190", VA = "0x18056F790", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x40C160", Offset = "0x40AB60", VA = "0x18040C160", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x408E80", Offset = "0x407880", VA = "0x180408E80")]
		public IzakayaPresetSubSubPannel()
		{
		}

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[FieldOffset(Offset = "0x70")]
		public UIButtonSimple YesBtn;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[FieldOffset(Offset = "0x78")]
		public UIButtonSimple NoBtn;

		// Token: 0x020000E1 RID: 225
		[Token(Token = "0x20000E1")]
		public enum PannelCloseContext
		{
			// Token: 0x040004CB RID: 1227
			[Token(Token = "0x40004CB")]
			Yes,
			// Token: 0x040004CC RID: 1228
			[Token(Token = "0x40004CC")]
			No
		}
	}
}
