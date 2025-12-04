using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000EB4 RID: 3764
	[Token(Token = "0x2000EB4")]
	[GenerateCleanupMethod]
	public class NoteBookAlbumPannel : MultiLayerUISubPanel<NoteBookMainPannel, NoteBookAlbumPannel, NoteBookAlbumPannel.AlbumType>
	{
		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x06005891 RID: 22673 RVA: 0x0001F290 File Offset: 0x0001D490
		[Token(Token = "0x17000C55")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6005891")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x06005892 RID: 22674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C56")]
		[TupleElementNames(new string[] { "EnumValue", "GotoPanelButton", "PanelParent" })]
		protected override IEnumerable<ValueTuple<NoteBookAlbumPannel.AlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumPannel>>> GetData
		{
			[Token(Token = "0x6005892")]
			[Address(RVA = "0x86CA60", Offset = "0x86B460", VA = "0x18086CA60", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x06005893 RID: 22675 RVA: 0x0001F2A8 File Offset: 0x0001D4A8
		[Token(Token = "0x17000C57")]
		protected override NoteBookAlbumPannel.AlbumType DefaultPanelSelection
		{
			[Token(Token = "0x6005893")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "34")]
			get
			{
				return NoteBookAlbumPannel.AlbumType.Guest;
			}
		}

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x06005894 RID: 22676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C58")]
		protected override string SwitchKey
		{
			[Token(Token = "0x6005894")]
			[Address(RVA = "0x45F020", Offset = "0x45DA20", VA = "0x18045F020", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005895")]
		[Address(RVA = "0x86C930", Offset = "0x86B330", VA = "0x18086C930", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005896")]
		[Address(RVA = "0x86CA20", Offset = "0x86B420", VA = "0x18086CA20")]
		public NoteBookAlbumPannel()
		{
		}

		// Token: 0x04005309 RID: 21257
		[Token(Token = "0x4005309")]
		[FieldOffset(Offset = "0x88")]
		public NoteBookAlbumGuestSubPannel GuestSubPanelParent;

		// Token: 0x0400530A RID: 21258
		[Token(Token = "0x400530A")]
		[FieldOffset(Offset = "0x90")]
		public NoteBookAlbumItemSubPannel ItemSubPanelParent;

		// Token: 0x0400530B RID: 21259
		[Token(Token = "0x400530B")]
		[FieldOffset(Offset = "0x98")]
		public UIButtonToggle GotoGuestBtn;

		// Token: 0x0400530C RID: 21260
		[Token(Token = "0x400530C")]
		[FieldOffset(Offset = "0xA0")]
		public UIButtonToggle GotoFoodBtn;

		// Token: 0x0400530D RID: 21261
		[Token(Token = "0x400530D")]
		[FieldOffset(Offset = "0xA8")]
		public UIButtonToggle GotoBeverageBtn;

		// Token: 0x0400530E RID: 21262
		[Token(Token = "0x400530E")]
		[FieldOffset(Offset = "0xB0")]
		public UIButtonToggle GotoIngredientBtn;

		// Token: 0x0400530F RID: 21263
		[Token(Token = "0x400530F")]
		[FieldOffset(Offset = "0xB8")]
		public UIButtonToggle GotoKitchenwareBtn;

		// Token: 0x04005310 RID: 21264
		[Token(Token = "0x4005310")]
		[FieldOffset(Offset = "0xC0")]
		public UIButtonToggle GotoItemBtn;

		// Token: 0x02000EB5 RID: 3765
		[Token(Token = "0x2000EB5")]
		public enum AlbumType
		{
			// Token: 0x04005312 RID: 21266
			[Token(Token = "0x4005312")]
			Guest,
			// Token: 0x04005313 RID: 21267
			[Token(Token = "0x4005313")]
			Food,
			// Token: 0x04005314 RID: 21268
			[Token(Token = "0x4005314")]
			Beverage,
			// Token: 0x04005315 RID: 21269
			[Token(Token = "0x4005315")]
			Ingredient,
			// Token: 0x04005316 RID: 21270
			[Token(Token = "0x4005316")]
			Kitchenware,
			// Token: 0x04005317 RID: 21271
			[Token(Token = "0x4005317")]
			Item
		}
	}
}
