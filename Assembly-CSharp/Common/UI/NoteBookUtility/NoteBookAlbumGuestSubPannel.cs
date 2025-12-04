using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000EA4 RID: 3748
	[Token(Token = "0x2000EA4")]
	[GenerateCleanupMethod]
	public class NoteBookAlbumGuestSubPannel : MultiLayerUISubPanel<NoteBookAlbumPannel, NoteBookAlbumGuestSubPannel, NoteBookAlbumGuestSubPannel.GuestAlbumType>
	{
		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06005823 RID: 22563 RVA: 0x0001F020 File Offset: 0x0001D220
		[Token(Token = "0x17000C4C")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6005823")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x06005824 RID: 22564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C4D")]
		[TupleElementNames(new string[] { "EnumValue", "GotoPanelButton", "PanelParent" })]
		protected override IEnumerable<ValueTuple<NoteBookAlbumGuestSubPannel.GuestAlbumType, UIButtonToggle, UISubPanel<NoteBookAlbumGuestSubPannel>>> GetData
		{
			[Token(Token = "0x6005824")]
			[Address(RVA = "0x8677C0", Offset = "0x8661C0", VA = "0x1808677C0", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x06005825 RID: 22565 RVA: 0x0001F038 File Offset: 0x0001D238
		[Token(Token = "0x17000C4E")]
		protected override NoteBookAlbumGuestSubPannel.GuestAlbumType DefaultPanelSelection
		{
			[Token(Token = "0x6005825")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "34")]
			get
			{
				return NoteBookAlbumGuestSubPannel.GuestAlbumType.SpecialGuest;
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x06005826 RID: 22566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C4F")]
		protected override string SwitchKey
		{
			[Token(Token = "0x6005826")]
			[Address(RVA = "0x867840", Offset = "0x866240", VA = "0x180867840", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x06005827 RID: 22567 RVA: 0x0001F050 File Offset: 0x0001D250
		[Token(Token = "0x17000C50")]
		protected override bool UseSingleButtonForSwitch
		{
			[Token(Token = "0x6005827")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "36")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005828 RID: 22568 RVA: 0x0001F068 File Offset: 0x0001D268
		[Token(Token = "0x6005828")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06005829 RID: 22569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005829")]
		[Address(RVA = "0x8676B0", Offset = "0x8660B0", VA = "0x1808676B0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600582A RID: 22570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600582A")]
		[Address(RVA = "0x867780", Offset = "0x866180", VA = "0x180867780")]
		public NoteBookAlbumGuestSubPannel()
		{
		}

		// Token: 0x04005283 RID: 21123
		[Token(Token = "0x4005283")]
		[FieldOffset(Offset = "0x88")]
		public NoteBookAlbumGuestSubSubPannel SubPannel;

		// Token: 0x04005284 RID: 21124
		[Token(Token = "0x4005284")]
		[FieldOffset(Offset = "0x90")]
		public UIButtonToggle GotoNormalGuestBtn;

		// Token: 0x04005285 RID: 21125
		[Token(Token = "0x4005285")]
		[FieldOffset(Offset = "0x98")]
		public UIButtonToggle GotoSpecialGuestBtn;

		// Token: 0x04005286 RID: 21126
		[Token(Token = "0x4005286")]
		[FieldOffset(Offset = "0xA0")]
		public UIButtonToggle GotoParticularGuestBtn;

		// Token: 0x04005287 RID: 21127
		[Token(Token = "0x4005287")]
		[FieldOffset(Offset = "0xA8")]
		public UIButtonToggle GotoPartnerBtn;

		// Token: 0x04005288 RID: 21128
		[Token(Token = "0x4005288")]
		[FieldOffset(Offset = "0xB0")]
		public UIButtonToggle GotoSpellCardBtn;

		// Token: 0x02000EA5 RID: 3749
		[Token(Token = "0x2000EA5")]
		public enum GuestAlbumType
		{
			// Token: 0x0400528A RID: 21130
			[Token(Token = "0x400528A")]
			SpecialGuest,
			// Token: 0x0400528B RID: 21131
			[Token(Token = "0x400528B")]
			NormalGuest,
			// Token: 0x0400528C RID: 21132
			[Token(Token = "0x400528C")]
			ParticularGuest,
			// Token: 0x0400528D RID: 21133
			[Token(Token = "0x400528D")]
			Partner,
			// Token: 0x0400528E RID: 21134
			[Token(Token = "0x400528E")]
			SpellCard
		}
	}
}
