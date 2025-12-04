using System;
using Common.UI.Extensions;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200044E RID: 1102
	[Token(Token = "0x200044E")]
	[GenerateCleanupMethod]
	public class RogueLikeDetailPanel : UIPanelParamOpen<DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext>
	{
		// Token: 0x060018E7 RID: 6375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E7")]
		[Address(RVA = "0x47D010", Offset = "0x47BA10", VA = "0x18047D010", Slot = "22")]
		protected sealed override void OnPanelInitialize()
		{
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E8")]
		[Address(RVA = "0x47D1B0", Offset = "0x47BBB0", VA = "0x18047D1B0", Slot = "32")]
		protected override void OnPanelOpen(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext openParam)
		{
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018E9")]
		[Address(RVA = "0x47CFC0", Offset = "0x47B9C0", VA = "0x18047CFC0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018EA")]
		[Address(RVA = "0x47D3F0", Offset = "0x47BDF0", VA = "0x18047D3F0")]
		public RogueLikeDetailPanel()
		{
		}

		// Token: 0x04001703 RID: 5891
		[Token(Token = "0x4001703")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private DLC5_RogueLikeMapDescriberExtended m_DescriberExtended;

		// Token: 0x04001704 RID: 5892
		[Token(Token = "0x4001704")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private ScrollRectComponent m_ScrollRectComponent;
	}
}
