using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020003AA RID: 938
	[Token(Token = "0x20003AA")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeFailedPanel : UIPanelParamOpen<RogueLikeRunTimeData>
	{
		// Token: 0x060014C9 RID: 5321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014C9")]
		[Address(RVA = "0x442B60", Offset = "0x441560", VA = "0x180442B60", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014CA")]
		[Address(RVA = "0x442C80", Offset = "0x441680", VA = "0x180442C80", Slot = "32")]
		protected override void OnPanelOpen(RogueLikeRunTimeData openParam)
		{
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014CB")]
		[Address(RVA = "0x442B10", Offset = "0x441510", VA = "0x180442B10", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014CC")]
		[Address(RVA = "0x442DA0", Offset = "0x4417A0", VA = "0x180442DA0")]
		public DLC5_RogueLikeFailedPanel()
		{
		}

		// Token: 0x04001368 RID: 4968
		[Token(Token = "0x4001368")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIButtonSimple m_ResultBtn;

		// Token: 0x04001369 RID: 4969
		[Token(Token = "0x4001369")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIButtonSimple m_BreakBtn;
	}
}
