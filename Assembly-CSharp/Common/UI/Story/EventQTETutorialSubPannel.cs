using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI.Story
{
	// Token: 0x02000F60 RID: 3936
	[Token(Token = "0x2000F60")]
	[GenerateCleanupMethod]
	public class EventQTETutorialSubPannel : UIPanelParamClose<EventQTETutorialSubPannel.PannelCloseType>
	{
		// Token: 0x06005C93 RID: 23699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C93")]
		[Address(RVA = "0x8AB660", Offset = "0x8AA060", VA = "0x1808AB660", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005C94 RID: 23700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C94")]
		[Address(RVA = "0x410110", Offset = "0x40EB10", VA = "0x180410110", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005C95 RID: 23701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C95")]
		[Address(RVA = "0x442B10", Offset = "0x441510", VA = "0x180442B10", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005C96 RID: 23702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C96")]
		[Address(RVA = "0x8AB120", Offset = "0x8A9B20", VA = "0x1808AB120")]
		public EventQTETutorialSubPannel()
		{
		}

		// Token: 0x040055BD RID: 21949
		[Token(Token = "0x40055BD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIButtonSimple m_GoBackBtn;

		// Token: 0x040055BE RID: 21950
		[Token(Token = "0x40055BE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIButtonSimple m_GoNextBtn;

		// Token: 0x02000F61 RID: 3937
		[Token(Token = "0x2000F61")]
		public enum PannelCloseType
		{
			// Token: 0x040055C0 RID: 21952
			[Token(Token = "0x40055C0")]
			Back,
			// Token: 0x040055C1 RID: 21953
			[Token(Token = "0x40055C1")]
			Next
		}
	}
}
