using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.UI
{
	// Token: 0x02000315 RID: 789
	[Token(Token = "0x2000315")]
	[GenerateCleanupMethod]
	public class DLC4_FlandreHomeDecorationStorageTabPanel : MultiLayerUISubPanel<DLC4_FlandreHomeDecorationEditorPanel, DLC4_FlandreHomeDecorationStorageTabPanel, DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType>
	{
		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C8")]
		public DLC4_FlandreHomeDecorationEditorPanel EditorParentPanel
		{
			[Token(Token = "0x60011FF")]
			[Address(RVA = "0x93D8B0", Offset = "0x93C2B0", VA = "0x18093D8B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06001200 RID: 4608 RVA: 0x00006FC0 File Offset: 0x000051C0
		[Token(Token = "0x170001C9")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6001200")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CA")]
		[TupleElementNames(new string[] { "EnumValue", "GotoPanelButton", "PanelParent" })]
		protected override IEnumerable<ValueTuple<DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType, UIButtonToggle, UISubPanel<DLC4_FlandreHomeDecorationStorageTabPanel>>> GetData
		{
			[Token(Token = "0x6001201")]
			[Address(RVA = "0x93D8F0", Offset = "0x93C2F0", VA = "0x18093D8F0", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x00006FD8 File Offset: 0x000051D8
		[Token(Token = "0x170001CB")]
		protected override DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType DefaultPanelSelection
		{
			[Token(Token = "0x6001202")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "34")]
			get
			{
				return DLC4_FlandreHomeDecorationStorageTabPanel.AlbumType.All;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CC")]
		protected override string SwitchKey
		{
			[Token(Token = "0x6001203")]
			[Address(RVA = "0x85CC40", Offset = "0x85B640", VA = "0x18085CC40", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001204")]
		[Address(RVA = "0x93D730", Offset = "0x93C130", VA = "0x18093D730", Slot = "37")]
		protected override void OnPostPanelInitialize()
		{
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001205")]
		[Address(RVA = "0x93D6D0", Offset = "0x93C0D0", VA = "0x18093D6D0")]
		public void GoToDefaultPanel()
		{
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001206")]
		[Address(RVA = "0x93D5A0", Offset = "0x93BFA0", VA = "0x18093D5A0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001207")]
		[Address(RVA = "0x93D870", Offset = "0x93C270", VA = "0x18093D870")]
		public DLC4_FlandreHomeDecorationStorageTabPanel()
		{
		}

		// Token: 0x040010B7 RID: 4279
		[Token(Token = "0x40010B7")]
		[FieldOffset(Offset = "0x88")]
		public DLC4_FlandreHomeDecorationStoragePanel storageParent;

		// Token: 0x040010B8 RID: 4280
		[Token(Token = "0x40010B8")]
		[FieldOffset(Offset = "0x90")]
		public DLC4_FlandreHomeDecorationShopPanel shopParent;

		// Token: 0x040010B9 RID: 4281
		[Token(Token = "0x40010B9")]
		[FieldOffset(Offset = "0x98")]
		public UIButtonToggle GotoAllBtn;

		// Token: 0x040010BA RID: 4282
		[Token(Token = "0x40010BA")]
		[FieldOffset(Offset = "0xA0")]
		public UIButtonToggle GotoCarpetBtn;

		// Token: 0x040010BB RID: 4283
		[Token(Token = "0x40010BB")]
		[FieldOffset(Offset = "0xA8")]
		public UIButtonToggle GotoCabinetBtn;

		// Token: 0x040010BC RID: 4284
		[Token(Token = "0x40010BC")]
		[FieldOffset(Offset = "0xB0")]
		public UIButtonToggle GotoTableBtn;

		// Token: 0x040010BD RID: 4285
		[Token(Token = "0x40010BD")]
		[FieldOffset(Offset = "0xB8")]
		public UIButtonToggle GotoChairBtn;

		// Token: 0x040010BE RID: 4286
		[Token(Token = "0x40010BE")]
		[FieldOffset(Offset = "0xC0")]
		public UIButtonToggle GotoBedBtn;

		// Token: 0x040010BF RID: 4287
		[Token(Token = "0x40010BF")]
		[FieldOffset(Offset = "0xC8")]
		public UIButtonToggle GotoObjectBtn;

		// Token: 0x040010C0 RID: 4288
		[Token(Token = "0x40010C0")]
		[FieldOffset(Offset = "0xD0")]
		public UIButtonToggle GotoPaintBtn;

		// Token: 0x040010C1 RID: 4289
		[Token(Token = "0x40010C1")]
		[FieldOffset(Offset = "0xD8")]
		public UIButtonToggle GotoShopBtn;

		// Token: 0x02000316 RID: 790
		[Token(Token = "0x2000316")]
		public enum AlbumType
		{
			// Token: 0x040010C3 RID: 4291
			[Token(Token = "0x40010C3")]
			All,
			// Token: 0x040010C4 RID: 4292
			[Token(Token = "0x40010C4")]
			Carpet,
			// Token: 0x040010C5 RID: 4293
			[Token(Token = "0x40010C5")]
			Cabinet,
			// Token: 0x040010C6 RID: 4294
			[Token(Token = "0x40010C6")]
			Table,
			// Token: 0x040010C7 RID: 4295
			[Token(Token = "0x40010C7")]
			Chair,
			// Token: 0x040010C8 RID: 4296
			[Token(Token = "0x40010C8")]
			Bed,
			// Token: 0x040010C9 RID: 4297
			[Token(Token = "0x40010C9")]
			Object,
			// Token: 0x040010CA RID: 4298
			[Token(Token = "0x40010CA")]
			Paint,
			// Token: 0x040010CB RID: 4299
			[Token(Token = "0x40010CB")]
			Shop
		}
	}
}
