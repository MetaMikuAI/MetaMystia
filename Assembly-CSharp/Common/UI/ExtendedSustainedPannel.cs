using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Managers;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Common.UI
{
	// Token: 0x02000E4B RID: 3659
	[Token(Token = "0x2000E4B")]
	[GenerateCleanupMethod]
	public abstract class ExtendedSustainedPannel : GeneralSustainedPannel
	{
		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06005584 RID: 21892
		[Token(Token = "0x17000C00")]
		public abstract string HoldActionMap
		{
			[Token(Token = "0x6005584")]
			get;
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06005585 RID: 21893
		[Token(Token = "0x17000C01")]
		public abstract string HoldActionName
		{
			[Token(Token = "0x6005585")]
			get;
		}

		// Token: 0x06005586 RID: 21894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005586")]
		[Address(RVA = "0x850390", Offset = "0x84ED90", VA = "0x180850390")]
		public void SetFastForwardButtonAvailability(bool enabled)
		{
		}

		// Token: 0x06005587 RID: 21895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005587")]
		[Address(RVA = "0x8503F0", Offset = "0x84EDF0", VA = "0x1808503F0")]
		private void SetOverrideFastForwardButtonAvailability(bool disable)
		{
		}

		// Token: 0x06005588 RID: 21896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005588")]
		[Address(RVA = "0x850450", Offset = "0x84EE50", VA = "0x180850450")]
		protected void SetSpecialEventsFastForawrdBtnEnableState(bool enabled)
		{
		}

		// Token: 0x06005589 RID: 21897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005589")]
		[Address(RVA = "0x850550", Offset = "0x84EF50", VA = "0x180850550")]
		private void UpdateFastForwardBtn()
		{
		}

		// Token: 0x0600558A RID: 21898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558A")]
		[Address(RVA = "0x84FC60", Offset = "0x84E660", VA = "0x18084FC60", Slot = "34")]
		protected override void OnPannelPostInitialize()
		{
		}

		// Token: 0x0600558B RID: 21899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558B")]
		[Address(RVA = "0x84FBB0", Offset = "0x84E5B0", VA = "0x18084FBB0")]
		private void OnInputModeChangedCallback(AdpUIPanelManager.RequestedInputMode state)
		{
		}

		// Token: 0x0600558C RID: 21900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558C")]
		[Address(RVA = "0x850320", Offset = "0x84ED20", VA = "0x180850320")]
		private void OnTriggerEnterStateChanged(bool state)
		{
		}

		// Token: 0x0600558D RID: 21901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558D")]
		[Address(RVA = "0x8502C0", Offset = "0x84ECC0", VA = "0x1808502C0")]
		private void OnSubmit()
		{
		}

		// Token: 0x0600558E RID: 21902
		[Token(Token = "0x600558E")]
		public abstract void OnFastForwardSubmit();

		// Token: 0x0600558F RID: 21903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600558F")]
		[Address(RVA = "0x8504A0", Offset = "0x84EEA0", VA = "0x1808504A0")]
		private void TryExecuteHold(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005590")]
		[Address(RVA = "0x850520", Offset = "0x84EF20", VA = "0x180850520")]
		private void TryReleaseHold(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06005591 RID: 21905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005591")]
		[Address(RVA = "0x8500B0", Offset = "0x84EAB0", VA = "0x1808500B0", Slot = "35")]
		protected override void OnPrePanelDestroyed()
		{
		}

		// Token: 0x06005592 RID: 21906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005592")]
		[Address(RVA = "0x84FA70", Offset = "0x84E470", VA = "0x18084FA70", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005593 RID: 21907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005593")]
		[Address(RVA = "0x8505B0", Offset = "0x84EFB0", VA = "0x1808505B0")]
		protected ExtendedSustainedPannel()
		{
		}

		// Token: 0x04005053 RID: 20563
		[Token(Token = "0x4005053")]
		[FieldOffset(Offset = "0xA8")]
		public CanvasGroup FastForwardBtnGroup;

		// Token: 0x04005054 RID: 20564
		[Token(Token = "0x4005054")]
		[FieldOffset(Offset = "0xB0")]
		public UIButtonHold FastForwardBtn;

		// Token: 0x04005055 RID: 20565
		[Token(Token = "0x4005055")]
		[FieldOffset(Offset = "0xB8")]
		public CanvasGroup[] PlayerInputOnlyElements;

		// Token: 0x04005056 RID: 20566
		[Token(Token = "0x4005056")]
		[FieldOffset(Offset = "0xC0")]
		private readonly CanvasGroup[] m_FastForwardBtnGroupArray;

		// Token: 0x04005057 RID: 20567
		[Token(Token = "0x4005057")]
		[FieldOffset(Offset = "0xC8")]
		private readonly global::UnityEngine.Object m_FastForwardGroupTweenKey;

		// Token: 0x04005058 RID: 20568
		[Token(Token = "0x4005058")]
		[FieldOffset(Offset = "0xD0")]
		private readonly global::UnityEngine.Object m_PlayerInputOnlyElementsTweenKey;

		// Token: 0x04005059 RID: 20569
		[Token(Token = "0x4005059")]
		[FieldOffset(Offset = "0xD8")]
		private bool m_FastForwardBtnEnableState;

		// Token: 0x0400505A RID: 20570
		[Token(Token = "0x400505A")]
		[FieldOffset(Offset = "0xD9")]
		private bool m_FastForwardBtnInteractableAreaInteractableState;

		// Token: 0x0400505B RID: 20571
		[Token(Token = "0x400505B")]
		[FieldOffset(Offset = "0xDA")]
		private bool m_FastForwardBtnPlayerInputModeInteractableState;

		// Token: 0x0400505C RID: 20572
		[Token(Token = "0x400505C")]
		[FieldOffset(Offset = "0xDB")]
		private bool m_OverrideFastForwardBtnEnableState;

		// Token: 0x0400505D RID: 20573
		[Token(Token = "0x400505D")]
		[FieldOffset(Offset = "0xDC")]
		private bool m_SpecialEventsFastForwardBtnEnableState;
	}
}
