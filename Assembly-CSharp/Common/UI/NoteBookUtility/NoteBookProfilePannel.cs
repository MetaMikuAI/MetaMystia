using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000EC9 RID: 3785
	[Token(Token = "0x2000EC9")]
	[GenerateCleanupMethod]
	public class NoteBookProfilePannel : UISubPanel<NoteBookMainPannel>
	{
		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06005937 RID: 22839 RVA: 0x0001F578 File Offset: 0x0001D778
		[Token(Token = "0x17000C65")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6005937")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (set) Token: 0x06005938 RID: 22840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C66")]
		public NoteBookProfilePannel.ProfileType CurrentPage
		{
			[Token(Token = "0x6005938")]
			[Address(RVA = "0x88EEC0", Offset = "0x88D8C0", VA = "0x18088EEC0")]
			set
			{
			}
		}

		// Token: 0x06005939 RID: 22841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005939")]
		[Address(RVA = "0x88E750", Offset = "0x88D150", VA = "0x18088E750", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x0600593A RID: 22842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593A")]
		[Address(RVA = "0x88E8F0", Offset = "0x88D2F0", VA = "0x18088E8F0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x0600593B RID: 22843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593B")]
		[Address(RVA = "0x88ECF0", Offset = "0x88D6F0", VA = "0x18088ECF0")]
		private void UpdateCurrent(NoteBookProfilePannel.ProfileType profileType)
		{
		}

		// Token: 0x0600593C RID: 22844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593C")]
		[Address(RVA = "0x88E6E0", Offset = "0x88D0E0", VA = "0x18088E6E0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x0600593D RID: 22845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593D")]
		[Address(RVA = "0x88EC20", Offset = "0x88D620", VA = "0x18088EC20")]
		private void SecondarySwitchStarted(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x0600593E RID: 22846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593E")]
		[Address(RVA = "0x88EBD0", Offset = "0x88D5D0", VA = "0x18088EBD0")]
		private void PageTurning(bool turnLeft = false)
		{
		}

		// Token: 0x0600593F RID: 22847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600593F")]
		[Address(RVA = "0x88E5B0", Offset = "0x88CFB0", VA = "0x18088E5B0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005940 RID: 22848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005940")]
		[Address(RVA = "0x88EE70", Offset = "0x88D870", VA = "0x18088EE70")]
		public NoteBookProfilePannel()
		{
		}

		// Token: 0x040053B1 RID: 21425
		[Token(Token = "0x40053B1")]
		private const string FINAL_MISSION = "Main_5_BambooForest_020-Mission";

		// Token: 0x040053B2 RID: 21426
		[Token(Token = "0x40053B2")]
		[FieldOffset(Offset = "0x78")]
		[Header("Public Value")]
		public UIButtonBase GotoPreviousBtn;

		// Token: 0x040053B3 RID: 21427
		[Token(Token = "0x40053B3")]
		[FieldOffset(Offset = "0x80")]
		public UIButtonBase GotoNextBtn;

		// Token: 0x040053B4 RID: 21428
		[Token(Token = "0x40053B4")]
		[FieldOffset(Offset = "0x88")]
		public TextMeshProUGUI currentPage;

		// Token: 0x040053B5 RID: 21429
		[Token(Token = "0x40053B5")]
		[FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI wholePage;

		// Token: 0x040053B6 RID: 21430
		[Token(Token = "0x40053B6")]
		[FieldOffset(Offset = "0x98")]
		[Header("Mystia Picture")]
		public Image mystiaPic;

		// Token: 0x040053B7 RID: 21431
		[Token(Token = "0x40053B7")]
		[FieldOffset(Offset = "0xA0")]
		public RectTransform defaultPosition;

		// Token: 0x040053B8 RID: 21432
		[Token(Token = "0x40053B8")]
		[FieldOffset(Offset = "0xA8")]
		public RectTransform titles;

		// Token: 0x040053B9 RID: 21433
		[Token(Token = "0x40053B9")]
		[FieldOffset(Offset = "0xB0")]
		public AdpScrollListAdaptiveComponent ScrollList;

		// Token: 0x040053BA RID: 21434
		[Token(Token = "0x40053BA")]
		[FieldOffset(Offset = "0xB8")]
		public Sprite defaultPic;

		// Token: 0x040053BB RID: 21435
		[Token(Token = "0x40053BB")]
		[FieldOffset(Offset = "0xC0")]
		public GameObject title5;

		// Token: 0x040053BC RID: 21436
		[Token(Token = "0x40053BC")]
		[FieldOffset(Offset = "0xC8")]
		[Header("Profile Sub Pages")]
		public UIPanelExtern[] SubPanelCollection;

		// Token: 0x040053BD RID: 21437
		[Token(Token = "0x40053BD")]
		[FieldOffset(Offset = "0xD0")]
		private UIPanelExtern m_ActiveSubPannel;

		// Token: 0x040053BE RID: 21438
		[Token(Token = "0x40053BE")]
		[FieldOffset(Offset = "0xD8")]
		private Coroutine m_AnimatedPortrayalCoroutine;

		// Token: 0x040053BF RID: 21439
		[Token(Token = "0x40053BF")]
		[FieldOffset(Offset = "0xE0")]
		private NoteBookProfilePannel.ProfileType m_Current;

		// Token: 0x02000ECA RID: 3786
		[Token(Token = "0x2000ECA")]
		public enum ProfileType : short
		{
			// Token: 0x040053C1 RID: 21441
			[Token(Token = "0x40053C1")]
			Status,
			// Token: 0x040053C2 RID: 21442
			[Token(Token = "0x40053C2")]
			Izakaya,
			// Token: 0x040053C3 RID: 21443
			[Token(Token = "0x40053C3")]
			AchievementBadge,
			// Token: 0x040053C4 RID: 21444
			[Token(Token = "0x40053C4")]
			Null
		}
	}
}
