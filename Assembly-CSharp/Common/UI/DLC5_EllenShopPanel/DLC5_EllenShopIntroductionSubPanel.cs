using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI.NoteBookUtility;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Common.UI.DLC5_EllenShopPanel
{
	// Token: 0x02000F71 RID: 3953
	[Token(Token = "0x2000F71")]
	public class DLC5_EllenShopIntroductionSubPanel : UIPanelParamOpen<DLC5_EllenShopPanel.ProductCondition>
	{
		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x06005CDD RID: 23773 RVA: 0x000203D0 File Offset: 0x0001E5D0
		// (set) Token: 0x06005CDE RID: 23774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D0A")]
		public bool CloseContext
		{
			[Token(Token = "0x6005CDD")]
			[Address(RVA = "0x8A5590", Offset = "0x8A3F90", VA = "0x1808A5590")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005CDE")]
			[Address(RVA = "0x8A55A0", Offset = "0x8A3FA0", VA = "0x1808A55A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005CDF RID: 23775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CDF")]
		[Address(RVA = "0x8A4020", Offset = "0x8A2A20", VA = "0x1808A4020", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005CE0 RID: 23776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE0")]
		[Address(RVA = "0x8A4070", Offset = "0x8A2A70", VA = "0x1808A4070", Slot = "32")]
		protected override void OnPanelOpen(DLC5_EllenShopPanel.ProductCondition openParam)
		{
		}

		// Token: 0x06005CE1 RID: 23777 RVA: 0x000203E8 File Offset: 0x0001E5E8
		[Token(Token = "0x6005CE1")]
		[Address(RVA = "0x8A3F60", Offset = "0x8A2960", VA = "0x1808A3F60")]
		private bool CheckStatus(KeyValuePair<DLC5_EllenShopPanel.Currency, ValueTuple<long, List<int>>> staticData)
		{
			return default(bool);
		}

		// Token: 0x06005CE2 RID: 23778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE2")]
		[Address(RVA = "0x8A44F0", Offset = "0x8A2EF0", VA = "0x1808A44F0")]
		private void ProcessConditionObject(UIElementCluster cluster, KeyValuePair<DLC5_EllenShopPanel.Currency, ValueTuple<long, List<int>>> data)
		{
		}

		// Token: 0x06005CE3 RID: 23779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE3")]
		[Address(RVA = "0x8A4EB0", Offset = "0x8A38B0", VA = "0x1808A4EB0")]
		private void RefreshFund()
		{
		}

		// Token: 0x06005CE4 RID: 23780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE4")]
		[Address(RVA = "0x8A3FE0", Offset = "0x8A29E0", VA = "0x1808A3FE0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06005CE5 RID: 23781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CE5")]
		[Address(RVA = "0x8A54A0", Offset = "0x8A3EA0", VA = "0x1808A54A0")]
		public DLC5_EllenShopIntroductionSubPanel()
		{
		}

		// Token: 0x06005CE7 RID: 23783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CE7")]
		[Address(RVA = "0x8A5400", Offset = "0x8A3E00", VA = "0x1808A5400")]
		[CompilerGenerated]
		internal static string <ProcessConditionObject>g__GetFormated|25_0(long current, int total)
		{
			return null;
		}

		// Token: 0x040055FC RID: 22012
		[Token(Token = "0x40055FC")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private TextMeshProUGUI m_Fund;

		// Token: 0x040055FD RID: 22013
		[Token(Token = "0x40055FD")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TextMeshProUGUI m_Cost;

		// Token: 0x040055FE RID: 22014
		[Token(Token = "0x40055FE")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private TextMeshProUGUI m_Remaining;

		// Token: 0x040055FF RID: 22015
		[Token(Token = "0x40055FF")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIButtonHold m_ButtonHold;

		// Token: 0x04005600 RID: 22016
		[Token(Token = "0x4005600")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject m_ConditionObject;

		// Token: 0x04005601 RID: 22017
		[Token(Token = "0x4005601")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Transform m_ConditionTransform;

		// Token: 0x04005602 RID: 22018
		[Token(Token = "0x4005602")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private SubmissionPanel m_SubPanelReference;

		// Token: 0x04005603 RID: 22019
		[Token(Token = "0x4005603")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private RectTransform m_MoveTarget;

		// Token: 0x04005604 RID: 22020
		[Token(Token = "0x4005604")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private RectTransform m_MoveTransform;

		// Token: 0x04005605 RID: 22021
		[Token(Token = "0x4005605")]
		[FieldOffset(Offset = "0xE0")]
		public Color32 trackingMissionColor;

		// Token: 0x04005606 RID: 22022
		[Token(Token = "0x4005606")]
		[FieldOffset(Offset = "0xE4")]
		public Color32 fulFilledMissionColor;

		// Token: 0x04005607 RID: 22023
		[Token(Token = "0x4005607")]
		[FieldOffset(Offset = "0xE8")]
		private Dictionary<DLC5_EllenShopPanel.Currency, ValueTuple<long, List<int>>> currentProduct;

		// Token: 0x04005608 RID: 22024
		[Token(Token = "0x4005608")]
		[FieldOffset(Offset = "0xF0")]
		private int cost;

		// Token: 0x04005609 RID: 22025
		[Token(Token = "0x4005609")]
		[FieldOffset(Offset = "0xF4")]
		private bool affordable;

		// Token: 0x0400560A RID: 22026
		[Token(Token = "0x400560A")]
		[FieldOffset(Offset = "0xF8")]
		private Vector2 startPosition;

		// Token: 0x0400560C RID: 22028
		[Token(Token = "0x400560C")]
		[FieldOffset(Offset = "0x108")]
		private readonly List<GameObject> m_AllConditionInstances;

		// Token: 0x0400560D RID: 22029
		[Token(Token = "0x400560D")]
		[FieldOffset(Offset = "0x110")]
		private readonly List<UIButtonSimple> m_AllButtonInstances;

		// Token: 0x0400560E RID: 22030
		[Token(Token = "0x400560E")]
		[FieldOffset(Offset = "0x118")]
		private Action returnSubmitItemWhenCloseCallback;
	}
}
