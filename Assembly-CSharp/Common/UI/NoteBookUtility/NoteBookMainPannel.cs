using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000EB7 RID: 3767
	[Token(Token = "0x2000EB7")]
	[GenerateCleanupMethod]
	public class NoteBookMainPannel : MultiLayerUISubPanel<BaseSustainedPannel, NoteBookMainPannel, NoteBookMainPannel.GoToSpecificType>, IExternalPanel
	{
		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x0600589F RID: 22687 RVA: 0x0001F2F0 File Offset: 0x0001D4F0
		// (set) Token: 0x060058A0 RID: 22688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C5B")]
		public bool StandaloneMode
		{
			[Token(Token = "0x600589F")]
			[Address(RVA = "0x853D70", Offset = "0x852770", VA = "0x180853D70")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x60058A0")]
			[Address(RVA = "0x853E20", Offset = "0x852820", VA = "0x180853E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x060058A1 RID: 22689 RVA: 0x0001F308 File Offset: 0x0001D508
		[Token(Token = "0x17000C5C")]
		protected override NoteBookMainPannel.GoToSpecificType DefaultPanelSelection
		{
			[Token(Token = "0x60058A1")]
			[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "34")]
			get
			{
				return NoteBookMainPannel.GoToSpecificType.Profile;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x060058A2 RID: 22690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5D")]
		[TupleElementNames(new string[] { "EnumValue", "GotoPanelButton", "PanelParent" })]
		protected override IEnumerable<ValueTuple<NoteBookMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<NoteBookMainPannel>>> GetData
		{
			[Token(Token = "0x60058A2")]
			[Address(RVA = "0x86CFF0", Offset = "0x86B9F0", VA = "0x18086CFF0", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x060058A3 RID: 22691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C5E")]
		protected override string SwitchKey
		{
			[Token(Token = "0x60058A3")]
			[Address(RVA = "0x85CC40", Offset = "0x85B640", VA = "0x18085CC40", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x060058A4 RID: 22692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058A4")]
		[Address(RVA = "0x86CED0", Offset = "0x86B8D0", VA = "0x18086CED0", Slot = "39")]
		protected override void OnPanelPreOpen()
		{
		}

		// Token: 0x060058A5 RID: 22693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058A5")]
		[Address(RVA = "0x86CDC0", Offset = "0x86B7C0", VA = "0x18086CDC0")]
		public static void Fade(CanvasGroup canvasGroup)
		{
		}

		// Token: 0x060058A6 RID: 22694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058A6")]
		[Address(RVA = "0x86CAE0", Offset = "0x86B4E0", VA = "0x18086CAE0")]
		public static void Blink(CanvasGroup canvasGroup)
		{
		}

		// Token: 0x060058A7 RID: 22695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058A7")]
		[Address(RVA = "0x86CC40", Offset = "0x86B640", VA = "0x18086CC40", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058A8")]
		[Address(RVA = "0x86CFB0", Offset = "0x86B9B0", VA = "0x18086CFB0")]
		public NoteBookMainPannel()
		{
		}

		// Token: 0x060058A9 RID: 22697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058A9")]
		[Address(RVA = "0x86CD80", Offset = "0x86B780", VA = "0x18086CD80", Slot = "41")]
		private void Common.UI.IExternalPanel.CloseExternPanel()
		{
		}

		// Token: 0x0400531C RID: 21276
		[Token(Token = "0x400531C")]
		[FieldOffset(Offset = "0x88")]
		public RectTransform FloatingPannel;

		// Token: 0x0400531D RID: 21277
		[Token(Token = "0x400531D")]
		[FieldOffset(Offset = "0x90")]
		public Image BG;

		// Token: 0x0400531E RID: 21278
		[Token(Token = "0x400531E")]
		[FieldOffset(Offset = "0x98")]
		public NoteBookProfilePannel ProfilePannel;

		// Token: 0x0400531F RID: 21279
		[Token(Token = "0x400531F")]
		[FieldOffset(Offset = "0xA0")]
		public NoteBookRecipePannel RecipePannel;

		// Token: 0x04005320 RID: 21280
		[Token(Token = "0x4005320")]
		[FieldOffset(Offset = "0xA8")]
		public NoteBookMissionPannel MissionPannel;

		// Token: 0x04005321 RID: 21281
		[Token(Token = "0x4005321")]
		[FieldOffset(Offset = "0xB0")]
		public NoteBookNewsPanelSelector NewsPannel;

		// Token: 0x04005322 RID: 21282
		[Token(Token = "0x4005322")]
		[FieldOffset(Offset = "0xB8")]
		public NoteBookAlbumPannel AlbumPannel;

		// Token: 0x04005323 RID: 21283
		[Token(Token = "0x4005323")]
		[FieldOffset(Offset = "0xC0")]
		public UIButtonToggle ProfileBtn;

		// Token: 0x04005324 RID: 21284
		[Token(Token = "0x4005324")]
		[FieldOffset(Offset = "0xC8")]
		public UIButtonToggle RecipeBtn;

		// Token: 0x04005325 RID: 21285
		[Token(Token = "0x4005325")]
		[FieldOffset(Offset = "0xD0")]
		public UIButtonToggle MissionBtn;

		// Token: 0x04005326 RID: 21286
		[Token(Token = "0x4005326")]
		[FieldOffset(Offset = "0xD8")]
		public UIButtonToggle NewsBtn;

		// Token: 0x04005327 RID: 21287
		[Token(Token = "0x4005327")]
		[FieldOffset(Offset = "0xE0")]
		public UIButtonToggle AlbumBtn;

		// Token: 0x04005328 RID: 21288
		[Token(Token = "0x4005328")]
		[FieldOffset(Offset = "0xE8")]
		public Color32 HighlightColor;

		// Token: 0x04005329 RID: 21289
		[Token(Token = "0x4005329")]
		[FieldOffset(Offset = "0xEC")]
		public Color32 NormalColor;

		// Token: 0x02000EB8 RID: 3768
		[Token(Token = "0x2000EB8")]
		public enum GoToSpecificType
		{
			// Token: 0x0400532C RID: 21292
			[Token(Token = "0x400532C")]
			Profile,
			// Token: 0x0400532D RID: 21293
			[Token(Token = "0x400532D")]
			Recipe,
			// Token: 0x0400532E RID: 21294
			[Token(Token = "0x400532E")]
			Mission,
			// Token: 0x0400532F RID: 21295
			[Token(Token = "0x400532F")]
			News,
			// Token: 0x04005330 RID: 21296
			[Token(Token = "0x4005330")]
			Album
		}
	}
}
