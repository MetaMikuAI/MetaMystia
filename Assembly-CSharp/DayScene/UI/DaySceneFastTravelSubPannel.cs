using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.UI
{
	// Token: 0x0200029F RID: 671
	[Token(Token = "0x200029F")]
	[GenerateCleanupMethod]
	public class DaySceneFastTravelSubPannel : UIPanelParam<DaySceneFastTravelSubPannel.OpenContext, DaySceneFastTravelSubPannel.PannelCloseData>
	{
		// Token: 0x06000F15 RID: 3861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F15")]
		[Address(RVA = "0x9066C0", Offset = "0x9050C0", VA = "0x1809066C0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F16")]
		[Address(RVA = "0x906820", Offset = "0x905220", VA = "0x180906820", Slot = "32")]
		protected override void OnPanelOpen(DaySceneFastTravelSubPannel.OpenContext openContext)
		{
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F17")]
		[Address(RVA = "0x906640", Offset = "0x905040", VA = "0x180906640", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F18")]
		[Address(RVA = "0x906C00", Offset = "0x905600", VA = "0x180906C00")]
		public DaySceneFastTravelSubPannel()
		{
		}

		// Token: 0x04000DDA RID: 3546
		[Token(Token = "0x4000DDA")]
		[FieldOffset(Offset = "0x88")]
		public UIButtonSimple ConfirmMoveBtn;

		// Token: 0x04000DDB RID: 3547
		[Token(Token = "0x4000DDB")]
		[FieldOffset(Offset = "0x90")]
		public UIButtonSimple ConfirmTeleportBtn;

		// Token: 0x04000DDC RID: 3548
		[Token(Token = "0x4000DDC")]
		[FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI YukariTeleportText;

		// Token: 0x04000DDD RID: 3549
		[Token(Token = "0x4000DDD")]
		[FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI TravelText;

		// Token: 0x020002A0 RID: 672
		[Token(Token = "0x20002A0")]
		public enum PannelCloseData
		{
			// Token: 0x04000DDF RID: 3551
			[Token(Token = "0x4000DDF")]
			ConfirmMove,
			// Token: 0x04000DE0 RID: 3552
			[Token(Token = "0x4000DE0")]
			ConfirmTeleport,
			// Token: 0x04000DE1 RID: 3553
			[Token(Token = "0x4000DE1")]
			None
		}

		// Token: 0x020002A1 RID: 673
		[Token(Token = "0x20002A1")]
		public readonly struct OpenContext
		{
			// Token: 0x06000F1C RID: 3868 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000F1C")]
			[Address(RVA = "0x90B620", Offset = "0x90A020", VA = "0x18090B620")]
			public OpenContext(int? yukariTeleportCost, int travelCost, bool prioritizeYukariButtonSelection)
			{
			}

			// Token: 0x04000DE2 RID: 3554
			[Token(Token = "0x4000DE2")]
			[FieldOffset(Offset = "0x0")]
			public readonly int? YukariTeleportCost;

			// Token: 0x04000DE3 RID: 3555
			[Token(Token = "0x4000DE3")]
			[FieldOffset(Offset = "0x8")]
			public readonly int TravelCost;

			// Token: 0x04000DE4 RID: 3556
			[Token(Token = "0x4000DE4")]
			[FieldOffset(Offset = "0xC")]
			public readonly bool PrioritizeYukariButtonSelection;
		}
	}
}
