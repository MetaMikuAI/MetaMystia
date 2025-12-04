using System;
using System.Collections.Generic;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI
{
	// Token: 0x0200029C RID: 668
	[Token(Token = "0x200029C")]
	[GenerateCleanupMethod]
	public class DaySceneEventSelectionPannel : UIPanelParamOpen<DaySceneEventSelectionPannelOpenContext>
	{
		// Token: 0x06000F09 RID: 3849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F09")]
		[Address(RVA = "0x906150", Offset = "0x904B50", VA = "0x180906150", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F0A")]
		[Address(RVA = "0x906170", Offset = "0x904B70", VA = "0x180906170", Slot = "32")]
		protected override void OnPanelOpen(DaySceneEventSelectionPannelOpenContext openContext)
		{
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F0B")]
		[Address(RVA = "0x906390", Offset = "0x904D90", VA = "0x180906390")]
		private void UIButtonSimpleHandler(UIButtonSimple button, KeyValuePair<string, Action> data)
		{
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F0C")]
		[Address(RVA = "0x851740", Offset = "0x850140", VA = "0x180851740", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F0D")]
		[Address(RVA = "0x9065A0", Offset = "0x904FA0", VA = "0x1809065A0")]
		public DaySceneEventSelectionPannel()
		{
		}

		// Token: 0x04000DD2 RID: 3538
		[Token(Token = "0x4000DD2")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject m_SelectionPrefab;

		// Token: 0x04000DD3 RID: 3539
		[Token(Token = "0x4000DD3")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform m_Container;

		// Token: 0x04000DD4 RID: 3540
		[Token(Token = "0x4000DD4")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AdpScrollListFixedComponent m_Scroll;

		// Token: 0x04000DD5 RID: 3541
		[Token(Token = "0x4000DD5")]
		[FieldOffset(Offset = "0x98")]
		private List<GameObject> m_SelectionInstances;

		// Token: 0x04000DD6 RID: 3542
		[Token(Token = "0x4000DD6")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_UseCustomTitle;
	}
}
