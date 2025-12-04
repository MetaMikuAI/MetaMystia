using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace PrepNightScene.UI
{
	// Token: 0x020000DD RID: 221
	[Token(Token = "0x20000DD")]
	[GenerateCleanupMethod]
	public class IzakayaPresetSubPannel : UIPanelParamOpen<bool>
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00003450 File Offset: 0x00001650
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006A")]
		public IzakayaPresetSubPannel.PannelCloseContext CloseContext
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x477F90", Offset = "0x476990", VA = "0x180477F90")]
			[CompilerGenerated]
			get
			{
				return IzakayaPresetSubPannel.PannelCloseContext.UsePreset;
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x4D2480", Offset = "0x4D0E80", VA = "0x1804D2480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x56F3B0", Offset = "0x56DDB0", VA = "0x18056F3B0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x56F630", Offset = "0x56E030", VA = "0x18056F630")]
		private void UsePresetBtnPressed()
		{
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x56F390", Offset = "0x56DD90", VA = "0x18056F390")]
		private void DeletePresetBtnPressed()
		{
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x56F5E0", Offset = "0x56DFE0", VA = "0x18056F5E0")]
		private void SetFirstBtnPressed()
		{
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x56F240", Offset = "0x56DC40", VA = "0x18056F240")]
		private void ConfirmChoice(bool startWithFalse, IzakayaPresetSubPannel.PannelCloseContext pannelCloseContext)
		{
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x56F590", Offset = "0x56DF90", VA = "0x18056F590", Slot = "32")]
		protected override void OnPanelOpen(bool canUseSticky)
		{
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x426970", Offset = "0x425370", VA = "0x180426970", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x56F640", Offset = "0x56E040", VA = "0x18056F640")]
		public IzakayaPresetSubPannel()
		{
		}

		// Token: 0x040004B9 RID: 1209
		[Token(Token = "0x40004B9")]
		[FieldOffset(Offset = "0x78")]
		public UIButtonSimple UsePresetBtn;

		// Token: 0x040004BA RID: 1210
		[Token(Token = "0x40004BA")]
		[FieldOffset(Offset = "0x80")]
		public UIButtonSimple DeletePresetBtn;

		// Token: 0x040004BB RID: 1211
		[Token(Token = "0x40004BB")]
		[FieldOffset(Offset = "0x88")]
		public UIButtonSimple SetFirstBtn;

		// Token: 0x040004BC RID: 1212
		[Token(Token = "0x40004BC")]
		[FieldOffset(Offset = "0x90")]
		public UIButtonSimple BackBtn;

		// Token: 0x040004BD RID: 1213
		[Token(Token = "0x40004BD")]
		[FieldOffset(Offset = "0x98")]
		public IzakayaPresetSubSubPannel SubPannel;

		// Token: 0x020000DE RID: 222
		[Token(Token = "0x20000DE")]
		public enum PannelCloseContext
		{
			// Token: 0x040004C0 RID: 1216
			[Token(Token = "0x40004C0")]
			UsePreset,
			// Token: 0x040004C1 RID: 1217
			[Token(Token = "0x40004C1")]
			DeletePreset,
			// Token: 0x040004C2 RID: 1218
			[Token(Token = "0x40004C2")]
			SetFirstPreset,
			// Token: 0x040004C3 RID: 1219
			[Token(Token = "0x40004C3")]
			None
		}
	}
}
