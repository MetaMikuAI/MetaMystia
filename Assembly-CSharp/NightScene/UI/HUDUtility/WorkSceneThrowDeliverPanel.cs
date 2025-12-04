using System;
using System.Collections.Generic;
using Common.UI;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using Plugins.DEYU;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020006F2 RID: 1778
	[Token(Token = "0x20006F2")]
	[GenerateCleanupMethod]
	public class WorkSceneThrowDeliverPanel : UISubPanel<BaseSustainedPannel>, IExternalPanel
	{
		// Token: 0x06002A25 RID: 10789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A25")]
		[Address(RVA = "0x555710", Offset = "0x554110", VA = "0x180555710", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A26")]
		[Address(RVA = "0x5971A0", Offset = "0x595BA0", VA = "0x1805971A0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A27")]
		[Address(RVA = "0x5972E0", Offset = "0x595CE0", VA = "0x1805972E0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A28")]
		[Address(RVA = "0x5969D0", Offset = "0x5953D0", VA = "0x1805969D0")]
		private void DescribeCurrentOrder(GuestsManager.OrderBase orderBase, Image servedFood, Image servedBev, UIElementCluster normalRequestUI, UIElementCluster specialRequestUI, TextMeshProUGUI guestName, TextMeshProUGUI deskCode, GuestGroupController guestGroupController)
		{
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A29")]
		[Address(RVA = "0x5970F0", Offset = "0x595AF0", VA = "0x1805970F0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2A")]
		[Address(RVA = "0x596890", Offset = "0x595290", VA = "0x180596890", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2B")]
		[Address(RVA = "0x5980E0", Offset = "0x596AE0", VA = "0x1805980E0")]
		public WorkSceneThrowDeliverPanel()
		{
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002A2C")]
		[Address(RVA = "0x596990", Offset = "0x595390", VA = "0x180596990", Slot = "33")]
		private void Common.UI.IExternalPanel.CloseExternPanel()
		{
		}

		// Token: 0x040026A9 RID: 9897
		[Token(Token = "0x40026A9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIElementCluster m_TargetBtn;

		// Token: 0x040026AA RID: 9898
		[Token(Token = "0x40026AA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform m_BtnField;

		// Token: 0x040026AB RID: 9899
		[Token(Token = "0x40026AB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIElementCluster m_Preview;

		// Token: 0x040026AC RID: 9900
		[Token(Token = "0x40026AC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ActionExecutionScheduler m_ActionExecutionScheduler;

		// Token: 0x040026AD RID: 9901
		[Token(Token = "0x40026AD")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Vector2 m_PreviewUIDefaultPosition;

		// Token: 0x040026AE RID: 9902
		[Token(Token = "0x40026AE")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Vector2 m_PreviewUIOffsetPosition;

		// Token: 0x040026AF RID: 9903
		[Token(Token = "0x40026AF")]
		[FieldOffset(Offset = "0xA8")]
		private readonly List<GameObject> m_BtnInstances;

		// Token: 0x040026B0 RID: 9904
		[Token(Token = "0x40026B0")]
		[FieldOffset(Offset = "0xB0")]
		private readonly Dictionary<int, ValueTuple<Vector3, GuestsManager.OrderBase, GuestGroupController>> m_Data;

		// Token: 0x040026B1 RID: 9905
		[Token(Token = "0x40026B1")]
		[FieldOffset(Offset = "0xB8")]
		private readonly Vector3[] m_Points;

		// Token: 0x040026B2 RID: 9906
		[Token(Token = "0x40026B2")]
		[FieldOffset(Offset = "0xC0")]
		private UILogicalGroupT<int> m_Group;

		// Token: 0x040026B3 RID: 9907
		[Token(Token = "0x40026B3")]
		[FieldOffset(Offset = "0xC8")]
		private CanvasGroup m_PreviewCanvasGroup;
	}
}
