using System;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000E3B RID: 3643
	[Token(Token = "0x2000E3B")]
	[GenerateCleanupMethod]
	public class IzakayaDetailPanel : UIPanelParamOpen<Izakaya>
	{
		// Token: 0x06005522 RID: 21794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005522")]
		[Address(RVA = "0x838C40", Offset = "0x837640", VA = "0x180838C40", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005523")]
		[Address(RVA = "0x838D20", Offset = "0x837720", VA = "0x180838D20", Slot = "32")]
		protected override void OnPanelOpen(Izakaya openParam)
		{
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005524")]
		[Address(RVA = "0x4101C0", Offset = "0x40EBC0", VA = "0x1804101C0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005525")]
		[Address(RVA = "0x838D70", Offset = "0x837770", VA = "0x180838D70")]
		public IzakayaDetailPanel()
		{
		}

		// Token: 0x04005005 RID: 20485
		[Token(Token = "0x4005005")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private DetailedIzakayaDescriber m_Describer;
	}
}
