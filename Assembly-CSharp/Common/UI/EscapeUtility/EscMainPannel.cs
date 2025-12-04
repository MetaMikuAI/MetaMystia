using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine.InputSystem;

namespace Common.UI.EscapeUtility
{
	// Token: 0x02000F55 RID: 3925
	[Token(Token = "0x2000F55")]
	[GenerateCleanupMethod]
	public class EscMainPannel : MultiLayerUISubPanel<BaseSustainedPannel, EscMainPannel, EscMainPannel.GoToSpecificType>, IExternalPanel
	{
		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x06005C53 RID: 23635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CFB")]
		[TupleElementNames(new string[] { "EnumValue", "GotoPanelButton", "PanelParent" })]
		protected override IEnumerable<ValueTuple<EscMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<EscMainPannel>>> GetData
		{
			[Token(Token = "0x6005C53")]
			[Address(RVA = "0x8AA790", Offset = "0x8A9190", VA = "0x1808AA790", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x06005C54 RID: 23636 RVA: 0x00020280 File Offset: 0x0001E480
		[Token(Token = "0x17000CFC")]
		protected override EscMainPannel.GoToSpecificType DefaultPanelSelection
		{
			[Token(Token = "0x6005C54")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "34")]
			get
			{
				return EscMainPannel.GoToSpecificType.Load;
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x06005C55 RID: 23637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000CFD")]
		protected override string SwitchKey
		{
			[Token(Token = "0x6005C55")]
			[Address(RVA = "0x85CC40", Offset = "0x85B640", VA = "0x18085CC40", Slot = "35")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x06005C56 RID: 23638 RVA: 0x00020298 File Offset: 0x0001E498
		// (set) Token: 0x06005C57 RID: 23639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CFE")]
		public bool ShouldInstantClose
		{
			[Token(Token = "0x6005C56")]
			[Address(RVA = "0x448370", Offset = "0x446D70", VA = "0x180448370")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005C57")]
			[Address(RVA = "0x448390", Offset = "0x446D90", VA = "0x180448390")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x06005C58 RID: 23640 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005C59 RID: 23641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CFF")]
		public Action AfterEscPanelCloseByLoadOrExitCallback
		{
			[Token(Token = "0x6005C58")]
			[Address(RVA = "0x48A7A0", Offset = "0x4891A0", VA = "0x18048A7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005C59")]
			[Address(RVA = "0x4D2570", Offset = "0x4D0F70", VA = "0x1804D2570")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005C5A RID: 23642 RVA: 0x000202B0 File Offset: 0x0001E4B0
		[Token(Token = "0x6005C5A")]
		[Address(RVA = "0x8AA210", Offset = "0x8A8C10", VA = "0x1808AA210", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06005C5B RID: 23643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C5B")]
		[Address(RVA = "0x8AA3E0", Offset = "0x8A8DE0", VA = "0x1808AA3E0", Slot = "37")]
		protected override void OnPostPanelInitialize()
		{
		}

		// Token: 0x06005C5C RID: 23644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C5C")]
		[Address(RVA = "0x8AA540", Offset = "0x8A8F40", VA = "0x1808AA540")]
		private void OpenEsc(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06005C5D RID: 23645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C5D")]
		[Address(RVA = "0x8AA540", Offset = "0x8A8F40", VA = "0x1808AA540")]
		private void OpenEsc()
		{
		}

		// Token: 0x06005C5E RID: 23646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C5E")]
		[Address(RVA = "0x8AA230", Offset = "0x8A8C30", VA = "0x1808AA230")]
		private void OnEscClosed(EscEscPannel pannelInstance)
		{
		}

		// Token: 0x06005C5F RID: 23647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C5F")]
		[Address(RVA = "0x8AA0C0", Offset = "0x8A8AC0", VA = "0x1808AA0C0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005C60 RID: 23648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C60")]
		[Address(RVA = "0x8AA750", Offset = "0x8A9150", VA = "0x1808AA750")]
		public EscMainPannel()
		{
		}

		// Token: 0x06005C61 RID: 23649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C61")]
		[Address(RVA = "0x8AA1D0", Offset = "0x8A8BD0", VA = "0x1808AA1D0", Slot = "41")]
		private void Common.UI.IExternalPanel.CloseExternPanel()
		{
		}

		// Token: 0x04005592 RID: 21906
		[Token(Token = "0x4005592")]
		[FieldOffset(Offset = "0x88")]
		public EscLoadPannel LoadPannel;

		// Token: 0x04005593 RID: 21907
		[Token(Token = "0x4005593")]
		[FieldOffset(Offset = "0x90")]
		public EscConfigPannel ConfigPannel;

		// Token: 0x04005594 RID: 21908
		[Token(Token = "0x4005594")]
		[FieldOffset(Offset = "0x98")]
		public EscBindingPannel BindingPannel;

		// Token: 0x04005595 RID: 21909
		[Token(Token = "0x4005595")]
		[FieldOffset(Offset = "0xA0")]
		public EscEscPannel EscPannel;

		// Token: 0x04005596 RID: 21910
		[Token(Token = "0x4005596")]
		[FieldOffset(Offset = "0xA8")]
		public UIButtonToggle LoadBtn;

		// Token: 0x04005597 RID: 21911
		[Token(Token = "0x4005597")]
		[FieldOffset(Offset = "0xB0")]
		public UIButtonToggle ConfigBtn;

		// Token: 0x04005598 RID: 21912
		[Token(Token = "0x4005598")]
		[FieldOffset(Offset = "0xB8")]
		public UIButtonToggle BindingBtn;

		// Token: 0x04005599 RID: 21913
		[Token(Token = "0x4005599")]
		[FieldOffset(Offset = "0xC0")]
		public UIButtonSimple ExitGameBtn;

		// Token: 0x02000F56 RID: 3926
		[Token(Token = "0x2000F56")]
		public enum GoToSpecificType
		{
			// Token: 0x0400559D RID: 21917
			[Token(Token = "0x400559D")]
			Load,
			// Token: 0x0400559E RID: 21918
			[Token(Token = "0x400559E")]
			Config,
			// Token: 0x0400559F RID: 21919
			[Token(Token = "0x400559F")]
			Binding
		}
	}
}
