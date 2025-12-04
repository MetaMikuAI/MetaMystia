using System;
using System.Collections.Generic;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000ECC RID: 3788
	[Token(Token = "0x2000ECC")]
	[GenerateCleanupMethod]
	public class NoteBookProfileIzakayaSubPannel : UIPanelExtern
	{
		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x0600594E RID: 22862 RVA: 0x0001F5C0 File Offset: 0x0001D7C0
		[Token(Token = "0x17000C68")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x600594E")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600594F RID: 22863 RVA: 0x0001F5D8 File Offset: 0x0001D7D8
		[Token(Token = "0x600594F")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06005950 RID: 22864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005950")]
		[Address(RVA = "0x88DDF0", Offset = "0x88C7F0", VA = "0x18088DDF0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005951 RID: 22865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005951")]
		[Address(RVA = "0x88DD90", Offset = "0x88C790", VA = "0x18088DD90", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06005952 RID: 22866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005952")]
		[Address(RVA = "0x88DF70", Offset = "0x88C970", VA = "0x18088DF70", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005953 RID: 22867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005953")]
		[Address(RVA = "0x88D0D0", Offset = "0x88BAD0", VA = "0x18088D0D0")]
		private void OnIzakayaElementEnabled(string mapInfo, UIElementCluster izakaya, UIButtonSimple uiButtonSimple)
		{
		}

		// Token: 0x06005954 RID: 22868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005954")]
		[Address(RVA = "0x88DC90", Offset = "0x88C690", VA = "0x18088DC90")]
		private void OnIzakayaElementSelected(string mapInfo, UIElementCluster uiElementCluster, UIButtonSimple uiButtonSimple)
		{
		}

		// Token: 0x06005955 RID: 22869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005955")]
		[Address(RVA = "0x88E190", Offset = "0x88CB90", VA = "0x18088E190")]
		private void UpdateIzakayaElements()
		{
		}

		// Token: 0x06005956 RID: 22870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005956")]
		[Address(RVA = "0x88CFF0", Offset = "0x88B9F0", VA = "0x18088CFF0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005957 RID: 22871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005957")]
		[Address(RVA = "0x88E5A0", Offset = "0x88CFA0", VA = "0x18088E5A0")]
		public NoteBookProfileIzakayaSubPannel()
		{
		}

		// Token: 0x040053CA RID: 21450
		[Token(Token = "0x40053CA")]
		[FieldOffset(Offset = "0x70")]
		[Header("Profile Values Page2")]
		public int perIzakayaNum;

		// Token: 0x040053CB RID: 21451
		[Token(Token = "0x40053CB")]
		[FieldOffset(Offset = "0x78")]
		public GameObject izakayaElement;

		// Token: 0x040053CC RID: 21452
		[Token(Token = "0x40053CC")]
		[FieldOffset(Offset = "0x80")]
		public VerticalLayoutGroup izakayaContent;

		// Token: 0x040053CD RID: 21453
		[Token(Token = "0x40053CD")]
		[FieldOffset(Offset = "0x88")]
		public Color unlockedIzakayaTextColor;

		// Token: 0x040053CE RID: 21454
		[Token(Token = "0x40053CE")]
		[FieldOffset(Offset = "0x98")]
		public Color lockedIzakayaTextColor;

		// Token: 0x040053CF RID: 21455
		[Token(Token = "0x40053CF")]
		[FieldOffset(Offset = "0xA8")]
		public Sprite unlockedIzakayaPic;

		// Token: 0x040053D0 RID: 21456
		[Token(Token = "0x40053D0")]
		[FieldOffset(Offset = "0xB0")]
		public Sprite lockedIzakayaPic;

		// Token: 0x040053D1 RID: 21457
		[Token(Token = "0x40053D1")]
		[FieldOffset(Offset = "0xB8")]
		public RectTransform viewport;

		// Token: 0x040053D2 RID: 21458
		[Token(Token = "0x40053D2")]
		[FieldOffset(Offset = "0xC0")]
		public CanvasGroup selected;

		// Token: 0x040053D3 RID: 21459
		[Token(Token = "0x40053D3")]
		[FieldOffset(Offset = "0xC8")]
		public AdpProgressIndicatorComponent progressIndicator;

		// Token: 0x040053D4 RID: 21460
		[Token(Token = "0x40053D4")]
		[FieldOffset(Offset = "0xD0")]
		private StaticVirtualScrollListUILogicalGroupT<string, UIElementCluster, UIButtonSimple> m_AllIzakayaGroup;

		// Token: 0x040053D5 RID: 21461
		[Token(Token = "0x40053D5")]
		[FieldOffset(Offset = "0xD8")]
		private Vector3 m_ViewportWorldCenter;

		// Token: 0x040053D6 RID: 21462
		[Token(Token = "0x40053D6")]
		[FieldOffset(Offset = "0xE8")]
		private IEnumerable<int> unlockedIzakayas;
	}
}
