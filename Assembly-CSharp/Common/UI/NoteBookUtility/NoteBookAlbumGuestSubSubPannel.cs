using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using Plugins.DEYU;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000EA7 RID: 3751
	[Token(Token = "0x2000EA7")]
	[GenerateCleanupMethod]
	public class NoteBookAlbumGuestSubSubPannel : UISubPanel<NoteBookAlbumGuestSubPannel>
	{
		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06005833 RID: 22579 RVA: 0x0001F0B0 File Offset: 0x0001D2B0
		[Token(Token = "0x17000C53")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6005833")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005834 RID: 22580 RVA: 0x0001F0C8 File Offset: 0x0001D2C8
		[Token(Token = "0x6005834")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06005835 RID: 22581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005835")]
		[Address(RVA = "0x867C80", Offset = "0x866680", VA = "0x180867C80", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005836 RID: 22582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005836")]
		[Address(RVA = "0x867BF0", Offset = "0x8665F0", VA = "0x180867BF0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06005837 RID: 22583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005837")]
		[Address(RVA = "0x867F90", Offset = "0x866990", VA = "0x180867F90", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005838")]
		[Address(RVA = "0x869800", Offset = "0x868200", VA = "0x180869800")]
		private void SetParamValue(Func<GuestBase, bool> checkRecordedCallback, CanvasGroup currentDescribePanel, Action<GuestBase> describeDataCallback)
		{
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005839")]
		private T GetDescriberPanel<T>(GameObject parent) where T : LanguageBaseDescriber
		{
			return null;
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583A")]
		private void OnElementEnabled<TValue>(TValue guestData, UIElementCluster cluster, UIButtonSimple button) where TValue : GuestBase
		{
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583B")]
		private void OnElementSelected<TValue>(TValue guestData, UIElementCluster cluster, UIButtonSimple button) where TValue : GuestBase
		{
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583C")]
		[Address(RVA = "0x867850", Offset = "0x866250", VA = "0x180867850", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600583D RID: 22589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600583D")]
		[Address(RVA = "0x8698A0", Offset = "0x8682A0", VA = "0x1808698A0")]
		public NoteBookAlbumGuestSubSubPannel()
		{
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600583E")]
		[CompilerGenerated]
		private StaticVerticalGridScrollListUILogicalGroupT<TGuest, UIElementCluster, UIButtonSimple> <OnPanelInitialize>g__CreateGroup|43_0<TGuest>(GridLayoutGroup field, List<TGuest> guest) where TGuest : GuestBase
		{
			return null;
		}

		// Token: 0x04005293 RID: 21139
		[Token(Token = "0x4005293")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActionExecutionScheduler m_ActionExecutionScheduler;

		// Token: 0x04005294 RID: 21140
		[Token(Token = "0x4005294")]
		[FieldOffset(Offset = "0x80")]
		public AdpProgressIndicatorComponent Scroller;

		// Token: 0x04005295 RID: 21141
		[Token(Token = "0x4005295")]
		[FieldOffset(Offset = "0x88")]
		public GameObject NormalGuestDetailParent;

		// Token: 0x04005296 RID: 21142
		[Token(Token = "0x4005296")]
		[FieldOffset(Offset = "0x90")]
		public GameObject SpecialGuestDetailParent;

		// Token: 0x04005297 RID: 21143
		[Token(Token = "0x4005297")]
		[FieldOffset(Offset = "0x98")]
		public GameObject SpecialGuestDetailCompactParent;

		// Token: 0x04005298 RID: 21144
		[Token(Token = "0x4005298")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject SpellCardDetailParent;

		// Token: 0x04005299 RID: 21145
		[Token(Token = "0x4005299")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject SpellCardDetailCompactParent;

		// Token: 0x0400529A RID: 21146
		[Token(Token = "0x400529A")]
		[FieldOffset(Offset = "0xB0")]
		public GameObject PartnerDetailParent;

		// Token: 0x0400529B RID: 21147
		[Token(Token = "0x400529B")]
		[FieldOffset(Offset = "0xB8")]
		public GameObject GuestParent;

		// Token: 0x0400529C RID: 21148
		[Token(Token = "0x400529C")]
		[FieldOffset(Offset = "0xC0")]
		public Color nullGuestParentNameColor;

		// Token: 0x0400529D RID: 21149
		[Token(Token = "0x400529D")]
		[FieldOffset(Offset = "0xD0")]
		public Color nullGuestParentAvatarMaskColor;

		// Token: 0x0400529E RID: 21150
		[Token(Token = "0x400529E")]
		[FieldOffset(Offset = "0xE0")]
		public CanvasGroup NullPannel;

		// Token: 0x0400529F RID: 21151
		[Token(Token = "0x400529F")]
		[FieldOffset(Offset = "0xE8")]
		public CanvasGroup DescriberPannel;

		// Token: 0x040052A0 RID: 21152
		[Token(Token = "0x40052A0")]
		[FieldOffset(Offset = "0xF0")]
		public GridLayoutGroup NGuestField;

		// Token: 0x040052A1 RID: 21153
		[Token(Token = "0x40052A1")]
		[FieldOffset(Offset = "0xF8")]
		public GridLayoutGroup SGuestField;

		// Token: 0x040052A2 RID: 21154
		[Token(Token = "0x40052A2")]
		[FieldOffset(Offset = "0x100")]
		public GridLayoutGroup SpellField;

		// Token: 0x040052A3 RID: 21155
		[Token(Token = "0x40052A3")]
		[FieldOffset(Offset = "0x108")]
		public GridLayoutGroup PartnerField;

		// Token: 0x040052A4 RID: 21156
		[Token(Token = "0x40052A4")]
		[FieldOffset(Offset = "0x110")]
		public GridLayoutGroup ParticularGuestGuestField;

		// Token: 0x040052A5 RID: 21157
		[Token(Token = "0x40052A5")]
		[FieldOffset(Offset = "0x118")]
		private readonly Dictionary<GameObject, CanvasGroup> m_AllDescriberPannel;

		// Token: 0x040052A6 RID: 21158
		[Token(Token = "0x40052A6")]
		[FieldOffset(Offset = "0x120")]
		private readonly List<NormalGuest> m_NormalGuests;

		// Token: 0x040052A7 RID: 21159
		[Token(Token = "0x40052A7")]
		[FieldOffset(Offset = "0x128")]
		private readonly List<SpecialGuest> m_ParticularSpecialGuests;

		// Token: 0x040052A8 RID: 21160
		[Token(Token = "0x40052A8")]
		[FieldOffset(Offset = "0x130")]
		private readonly List<SpecialGuest> m_Partners;

		// Token: 0x040052A9 RID: 21161
		[Token(Token = "0x40052A9")]
		[FieldOffset(Offset = "0x138")]
		private readonly List<SpecialGuest> m_SpecialGuests;

		// Token: 0x040052AA RID: 21162
		[Token(Token = "0x40052AA")]
		[FieldOffset(Offset = "0x140")]
		private readonly List<SpecialGuest> m_Spell;

		// Token: 0x040052AB RID: 21163
		[Token(Token = "0x40052AB")]
		[FieldOffset(Offset = "0x148")]
		private Func<GuestBase, bool> checkRecordedCallback;

		// Token: 0x040052AC RID: 21164
		[Token(Token = "0x40052AC")]
		[FieldOffset(Offset = "0x150")]
		private CanvasGroup currentDescribePanel;

		// Token: 0x040052AD RID: 21165
		[Token(Token = "0x40052AD")]
		[FieldOffset(Offset = "0x158")]
		private Action<GuestBase> describeDataCallback;

		// Token: 0x040052AE RID: 21166
		[Token(Token = "0x40052AE")]
		[FieldOffset(Offset = "0x160")]
		private IStaticGridScrollListUILogicalGroup m_Current;

		// Token: 0x040052AF RID: 21167
		[Token(Token = "0x40052AF")]
		[FieldOffset(Offset = "0x168")]
		private CanvasGroup m_NGuestFieldGroup;

		// Token: 0x040052B0 RID: 21168
		[Token(Token = "0x40052B0")]
		[FieldOffset(Offset = "0x170")]
		private StaticVerticalGridScrollListUILogicalGroupT<NormalGuest, UIElementCluster, UIButtonSimple> m_NormalGuestGroup;

		// Token: 0x040052B1 RID: 21169
		[Token(Token = "0x40052B1")]
		[FieldOffset(Offset = "0x178")]
		private Action m_OnSwitchButtonSubmit;

		// Token: 0x040052B2 RID: 21170
		[Token(Token = "0x40052B2")]
		[FieldOffset(Offset = "0x180")]
		private CancellationTokenSource m_PanelToken;

		// Token: 0x040052B3 RID: 21171
		[Token(Token = "0x40052B3")]
		[FieldOffset(Offset = "0x188")]
		private CanvasGroup m_ParticularFieldGroup;

		// Token: 0x040052B4 RID: 21172
		[Token(Token = "0x40052B4")]
		[FieldOffset(Offset = "0x190")]
		private StaticVerticalGridScrollListUILogicalGroupT<SpecialGuest, UIElementCluster, UIButtonSimple> m_ParticularGuestGroup;

		// Token: 0x040052B5 RID: 21173
		[Token(Token = "0x40052B5")]
		[FieldOffset(Offset = "0x198")]
		private CanvasGroup m_PartnerFieldGroup;

		// Token: 0x040052B6 RID: 21174
		[Token(Token = "0x40052B6")]
		[FieldOffset(Offset = "0x1A0")]
		private StaticVerticalGridScrollListUILogicalGroupT<SpecialGuest, UIElementCluster, UIButtonSimple> m_PartnerGroup;

		// Token: 0x040052B7 RID: 21175
		[Token(Token = "0x40052B7")]
		[FieldOffset(Offset = "0x1A8")]
		private CanvasGroup m_SGuestFieldGroup;

		// Token: 0x040052B8 RID: 21176
		[Token(Token = "0x40052B8")]
		[FieldOffset(Offset = "0x1B0")]
		private StaticVerticalGridScrollListUILogicalGroupT<SpecialGuest, UIElementCluster, UIButtonSimple> m_SpecialGuestGroup;

		// Token: 0x040052B9 RID: 21177
		[Token(Token = "0x40052B9")]
		[FieldOffset(Offset = "0x1B8")]
		private StaticVerticalGridScrollListUILogicalGroupT<SpecialGuest, UIElementCluster, UIButtonSimple> m_SpellCardGroup;

		// Token: 0x040052BA RID: 21178
		[Token(Token = "0x40052BA")]
		[FieldOffset(Offset = "0x1C0")]
		private CanvasGroup m_SpellFieldGroup;
	}
}
