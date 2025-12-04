using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000E2E RID: 3630
	[Token(Token = "0x2000E2E")]
	[GenerateCleanupMethod]
	public class DaySceneCGDisplayerSubPannel : UISubPanel<DaySceneCGDisplayerPannel>
	{
		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x060054D9 RID: 21721 RVA: 0x0001E528 File Offset: 0x0001C728
		// (set) Token: 0x060054DA RID: 21722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BF7")]
		public DaySceneCGDisplayerPannel.OpenMode PanelOpenMode
		{
			[Token(Token = "0x60054D9")]
			[Address(RVA = "0x4404B0", Offset = "0x43EEB0", VA = "0x1804404B0")]
			[CompilerGenerated]
			private get
			{
				return DaySceneCGDisplayerPannel.OpenMode.CG;
			}
			[Token(Token = "0x60054DA")]
			[Address(RVA = "0x656A50", Offset = "0x655450", VA = "0x180656A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x060054DB RID: 21723 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060054DC RID: 21724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BF8")]
		[TupleElementNames(new string[] { "Sprite", "IsLegacy", "IsUnused" })]
		public ValueTuple<Sprite, bool, bool>[] Picture
		{
			[Token(Token = "0x60054DB")]
			[Address(RVA = "0x48A8D0", Offset = "0x4892D0", VA = "0x18048A8D0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60054DC")]
			[Address(RVA = "0x48AC50", Offset = "0x489650", VA = "0x18048AC50")]
			[CompilerGenerated]
			[param: TupleElementNames(new string[] { "Sprite", "IsLegacy", "IsUnused" })]
			set
			{
			}
		}

		// Token: 0x060054DD RID: 21725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DD")]
		[Address(RVA = "0x836BA0", Offset = "0x8355A0", VA = "0x180836BA0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060054DE RID: 21726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DE")]
		[Address(RVA = "0x837090", Offset = "0x835A90", VA = "0x180837090")]
		private void UpdateInputHelper(bool showLegacyIndicator, bool showUnusedIndicator)
		{
		}

		// Token: 0x060054DF RID: 21727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054DF")]
		[Address(RVA = "0x836AD0", Offset = "0x8354D0", VA = "0x180836AD0")]
		private void OnHide(InputAction.CallbackContext _)
		{
		}

		// Token: 0x060054E0 RID: 21728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E0")]
		[Address(RVA = "0x837460", Offset = "0x835E60", VA = "0x180837460")]
		private void UpdateTips()
		{
		}

		// Token: 0x060054E1 RID: 21729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E1")]
		[Address(RVA = "0x8369D0", Offset = "0x8353D0", VA = "0x1808369D0")]
		private void GoToNext()
		{
		}

		// Token: 0x060054E2 RID: 21730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E2")]
		[Address(RVA = "0x836A50", Offset = "0x835450", VA = "0x180836A50")]
		private void GoToPrevious()
		{
		}

		// Token: 0x060054E3 RID: 21731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E3")]
		[Address(RVA = "0x8372C0", Offset = "0x835CC0", VA = "0x1808372C0")]
		private void UpdatePic([TupleElementNames(new string[] { "Sprite", "IsLegacy", "IsUnused" })] ValueTuple<Sprite, bool, bool> data)
		{
		}

		// Token: 0x060054E4 RID: 21732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E4")]
		[Address(RVA = "0x836EF0", Offset = "0x8358F0", VA = "0x180836EF0")]
		private void OnSwitchMove(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E5")]
		[Address(RVA = "0x836F50", Offset = "0x835950", VA = "0x180836F50")]
		private void OnSwitchScroll(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x060054E6 RID: 21734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E6")]
		[Address(RVA = "0x836FC0", Offset = "0x8359C0", VA = "0x180836FC0")]
		private void OnSwitch(float dir)
		{
		}

		// Token: 0x060054E7 RID: 21735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E7")]
		[Address(RVA = "0x836E70", Offset = "0x835870", VA = "0x180836E70", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060054E8 RID: 21736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E8")]
		[Address(RVA = "0x836900", Offset = "0x835300", VA = "0x180836900", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060054E9 RID: 21737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054E9")]
		[Address(RVA = "0x837520", Offset = "0x835F20", VA = "0x180837520")]
		public DaySceneCGDisplayerSubPannel()
		{
		}

		// Token: 0x04004FC8 RID: 20424
		[Token(Token = "0x4004FC8")]
		private const string LEGACY_TITLE = "CG_LEGACY";

		// Token: 0x04004FC9 RID: 20425
		[Token(Token = "0x4004FC9")]
		private const string UNUSED_TITLE = "CG_NOTINUSE";

		// Token: 0x04004FCA RID: 20426
		[Token(Token = "0x4004FCA")]
		[FieldOffset(Offset = "0x78")]
		public Image Visual;

		// Token: 0x04004FCB RID: 20427
		[Token(Token = "0x4004FCB")]
		[FieldOffset(Offset = "0x80")]
		public UIButtonSimple GotoPreviousBtn;

		// Token: 0x04004FCC RID: 20428
		[Token(Token = "0x4004FCC")]
		[FieldOffset(Offset = "0x88")]
		public UIButtonSimple GotoNextBtn;

		// Token: 0x04004FCD RID: 20429
		[Token(Token = "0x4004FCD")]
		[FieldOffset(Offset = "0x90")]
		public CanvasGroup Tips;

		// Token: 0x04004FCE RID: 20430
		[Token(Token = "0x4004FCE")]
		[FieldOffset(Offset = "0x98")]
		public CanvasGroup LegacyIndicator;

		// Token: 0x04004FCF RID: 20431
		[Token(Token = "0x4004FCF")]
		[FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI IndicatorText;

		// Token: 0x04004FD0 RID: 20432
		[Token(Token = "0x4004FD0")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject[] hideWhenOnly;

		// Token: 0x04004FD1 RID: 20433
		[Token(Token = "0x4004FD1")]
		[FieldOffset(Offset = "0xB0")]
		private int m_CurrentPicture;

		// Token: 0x04004FD2 RID: 20434
		[Token(Token = "0x4004FD2")]
		[FieldOffset(Offset = "0xB4")]
		private bool m_DoHideUI;
	}
}
