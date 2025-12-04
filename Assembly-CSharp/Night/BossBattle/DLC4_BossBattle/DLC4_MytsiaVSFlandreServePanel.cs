using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000212 RID: 530
	[Token(Token = "0x2000212")]
	[GenerateCleanupMethod]
	public class DLC4_MytsiaVSFlandreServePanel : UIPanelExtern
	{
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x00005790 File Offset: 0x00003990
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000156")]
		public DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext OpenContext
		{
			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x8E8AF0", Offset = "0x8E74F0", VA = "0x1808E8AF0")]
			[CompilerGenerated]
			private get
			{
				return default(DLC4_MytsiaVSFlandreServePanel.SpecialOrderOpenContext);
			}
			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x8E8B00", Offset = "0x8E7500", VA = "0x1808E8B00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x000057A8 File Offset: 0x000039A8
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000157")]
		private int CurrentSelectedLetter
		{
			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x4404F0", Offset = "0x43EEF0", VA = "0x1804404F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x656A80", Offset = "0x655480", VA = "0x180656A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0x8E8610", Offset = "0x8E7010", VA = "0x1808E8610", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x8E8200", Offset = "0x8E6C00", VA = "0x1808E8200")]
		private void Hide(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x8E86E0", Offset = "0x8E70E0", VA = "0x1808E86E0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x8E8880", Offset = "0x8E7280", VA = "0x1808E8880")]
		private void Refresh()
		{
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0x8E8230", Offset = "0x8E6C30", VA = "0x1808E8230")]
		private void OnElementEnabled(UIElementCluster cluster, GuestGuardMapping guard)
		{
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0x8E8560", Offset = "0x8E6F60", VA = "0x1808E8560", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x8E8120", Offset = "0x8E6B20", VA = "0x1808E8120", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x8E8A00", Offset = "0x8E7400", VA = "0x1808E8A00")]
		public DLC4_MytsiaVSFlandreServePanel()
		{
		}

		// Token: 0x04000B3B RID: 2875
		[Token(Token = "0x4000B3B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TextMeshProUGUI m_ManualText;

		// Token: 0x04000B3C RID: 2876
		[Token(Token = "0x4000B3C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TextMeshProUGUI m_HPText;

		// Token: 0x04000B3D RID: 2877
		[Token(Token = "0x4000B3D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshProUGUI m_NameText;

		// Token: 0x04000B3E RID: 2878
		[Token(Token = "0x4000B3E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject m_CardElement;

		// Token: 0x04000B3F RID: 2879
		[Token(Token = "0x4000B3F")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform m_CardParent;

		// Token: 0x04000B40 RID: 2880
		[Token(Token = "0x4000B40")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup m_ParentCanvasGroup;

		// Token: 0x04000B41 RID: 2881
		[Token(Token = "0x4000B41")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIElementCluster m_DescribeCharacterCluster;

		// Token: 0x04000B42 RID: 2882
		[Token(Token = "0x4000B42")]
		[FieldOffset(Offset = "0xA8")]
		private bool isHide;

		// Token: 0x04000B43 RID: 2883
		[Token(Token = "0x4000B43")]
		[FieldOffset(Offset = "0xB0")]
		private List<GameObject> m_AllInstances;

		// Token: 0x04000B44 RID: 2884
		[Token(Token = "0x4000B44")]
		[FieldOffset(Offset = "0xB8")]
		private UILogicalGroupT<GuestGuardMapping> m_LetterGroup;

		// Token: 0x02000213 RID: 531
		[Token(Token = "0x2000213")]
		public struct SpecialOrderOpenContext
		{
			// Token: 0x06000CA7 RID: 3239 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000CA7")]
			[Address(RVA = "0x40C360", Offset = "0x40AD60", VA = "0x18040C360")]
			public SpecialOrderOpenContext(List<GuestGuardMapping> activeGuestIds, Action<int> onFinishPuttingCardCallback)
			{
			}

			// Token: 0x04000B47 RID: 2887
			[Token(Token = "0x4000B47")]
			[FieldOffset(Offset = "0x0")]
			public readonly List<GuestGuardMapping> ActiveGuestIds;

			// Token: 0x04000B48 RID: 2888
			[Token(Token = "0x4000B48")]
			[FieldOffset(Offset = "0x8")]
			public readonly Action<int> OnFinishPuttingCardCallback;
		}
	}
}
