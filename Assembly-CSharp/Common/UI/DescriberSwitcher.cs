using System;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Common.UI
{
	// Token: 0x02000DE3 RID: 3555
	[Token(Token = "0x2000DE3")]
	[GenerateCleanupMethod]
	public class DescriberSwitcher : MonoBehaviour
	{
		// Token: 0x06005347 RID: 21319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005347")]
		[Address(RVA = "0x7FB220", Offset = "0x7F9C20", VA = "0x1807FB220")]
		private void Awake()
		{
		}

		// Token: 0x06005348 RID: 21320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005348")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005349 RID: 21321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005349")]
		[Address(RVA = "0x7FB560", Offset = "0x7F9F60", VA = "0x1807FB560")]
		public void SwitchMode(InputAction.CallbackContext _)
		{
		}

		// Token: 0x0600534A RID: 21322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600534A")]
		[Address(RVA = "0x7FB5F0", Offset = "0x7F9FF0", VA = "0x1807FB5F0")]
		private void UpdateDescriberMode(DescriberSwitcher.DescriberMode mode)
		{
		}

		// Token: 0x0600534B RID: 21323 RVA: 0x0001E0C0 File Offset: 0x0001C2C0
		[Token(Token = "0x600534B")]
		[Address(RVA = "0x7FB1A0", Offset = "0x7F9BA0", VA = "0x1807FB1A0")]
		private bool AllowTags()
		{
			return default(bool);
		}

		// Token: 0x0600534C RID: 21324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600534C")]
		[Address(RVA = "0x7FB600", Offset = "0x7FA000", VA = "0x1807FB600")]
		private void UpdateModeVisual()
		{
		}

		// Token: 0x0600534D RID: 21325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600534D")]
		[Address(RVA = "0x7FB4F0", Offset = "0x7F9EF0", VA = "0x1807FB4F0", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x0600534E RID: 21326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600534E")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public DescriberSwitcher()
		{
		}

		// Token: 0x04004E44 RID: 20036
		[Token(Token = "0x4004E44")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SellableDescriber m_Describer;

		// Token: 0x04004E45 RID: 20037
		[Token(Token = "0x4004E45")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform m_DescriptionParentField;

		// Token: 0x04004E46 RID: 20038
		[Token(Token = "0x4004E46")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform m_TagParentField;

		// Token: 0x04004E47 RID: 20039
		[Token(Token = "0x4004E47")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIButtonSimple m_SwitchButton;

		// Token: 0x04004E48 RID: 20040
		[Token(Token = "0x4004E48")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI m_ButtonText;

		// Token: 0x04004E49 RID: 20041
		[Token(Token = "0x4004E49")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DescriberSwitcher.SwitcherMode m_DefaultMode;

		// Token: 0x04004E4A RID: 20042
		[Token(Token = "0x4004E4A")]
		[FieldOffset(Offset = "0x44")]
		private DescriberSwitcher.DescriberMode m_CurrentDescriberMode;

		// Token: 0x04004E4B RID: 20043
		[Token(Token = "0x4004E4B")]
		[FieldOffset(Offset = "0x48")]
		private DescriberSwitcher.SwitcherMode m_CurrentSwitcherMode;

		// Token: 0x04004E4C RID: 20044
		[Token(Token = "0x4004E4C")]
		[FieldOffset(Offset = "0x4C")]
		private bool? m_LastMode;

		// Token: 0x02000DE4 RID: 3556
		[Token(Token = "0x2000DE4")]
		private enum SwitcherMode
		{
			// Token: 0x04004E4E RID: 20046
			[Token(Token = "0x4004E4E")]
			Description,
			// Token: 0x04004E4F RID: 20047
			[Token(Token = "0x4004E4F")]
			Tag
		}

		// Token: 0x02000DE5 RID: 3557
		[Token(Token = "0x2000DE5")]
		private enum DescriberMode
		{
			// Token: 0x04004E51 RID: 20049
			[Token(Token = "0x4004E51")]
			ObjectLanguageBase,
			// Token: 0x04004E52 RID: 20050
			[Token(Token = "0x4004E52")]
			LanguageBase,
			// Token: 0x04004E53 RID: 20051
			[Token(Token = "0x4004E53")]
			Null,
			// Token: 0x04004E54 RID: 20052
			[Token(Token = "0x4004E54")]
			Sellable,
			// Token: 0x04004E55 RID: 20053
			[Token(Token = "0x4004E55")]
			Ingredient
		}
	}
}
