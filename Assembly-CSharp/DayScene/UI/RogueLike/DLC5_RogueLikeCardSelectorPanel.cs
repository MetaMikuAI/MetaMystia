using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using Night.RogueLike;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000376 RID: 886
	[Token(Token = "0x2000376")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeCardSelectorPanel : UIPanelParamOpen<DLC5_RogueLikeCardSelectorPanel.OpenContext>
	{
		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600139B RID: 5019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F6")]
		public RogueLikeRunTimeData RogueLikeRunTimeData
		{
			[Token(Token = "0x600139B")]
			[Address(RVA = "0x4401F0", Offset = "0x43EBF0", VA = "0x1804401F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x000075F0 File Offset: 0x000057F0
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001F7")]
		public int MaxCardNumCanGacha
		{
			[Token(Token = "0x600139C")]
			[Address(RVA = "0x4401E0", Offset = "0x43EBE0", VA = "0x1804401E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600139D")]
			[Address(RVA = "0x440230", Offset = "0x43EC30", VA = "0x180440230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600139E")]
		[Address(RVA = "0x43ED90", Offset = "0x43D790", VA = "0x18043ED90", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600139F")]
		[Address(RVA = "0x43F3A0", Offset = "0x43DDA0", VA = "0x18043F3A0", Slot = "32")]
		protected override void OnPanelOpen(DLC5_RogueLikeCardSelectorPanel.OpenContext openParam)
		{
		}

		// Token: 0x060013A0 RID: 5024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A0")]
		[Address(RVA = "0x43E890", Offset = "0x43D290", VA = "0x18043E890")]
		private void ConfirmChoiceStartForSubmit(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A1")]
		[Address(RVA = "0x43E7F0", Offset = "0x43D1F0", VA = "0x18043E7F0")]
		private void ConfirmChoiceEndForSubmit(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A2")]
		[Address(RVA = "0x43F5E0", Offset = "0x43DFE0", VA = "0x18043F5E0")]
		private void Refresh(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A3")]
		[Address(RVA = "0x43EB90", Offset = "0x43D590", VA = "0x18043EB90")]
		private void Hide(InputAction.CallbackContext _)
		{
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A4")]
		[Address(RVA = "0x43F570", Offset = "0x43DF70", VA = "0x18043F570")]
		private void RefreshCard()
		{
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A5")]
		[Address(RVA = "0x43E950", Offset = "0x43D350", VA = "0x18043E950")]
		private void DequeueAndUpdateCard()
		{
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A6")]
		[Address(RVA = "0x43FBC0", Offset = "0x43E5C0", VA = "0x18043FBC0")]
		private void UpdateCard(TriggerCardCondition thisCardList)
		{
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x43FFB0", Offset = "0x43E9B0", VA = "0x18043FFB0")]
		private void UpdateRefreshPrice()
		{
		}

		// Token: 0x060013A8 RID: 5032 RVA: 0x00007608 File Offset: 0x00005808
		[Token(Token = "0x60013A8")]
		[Address(RVA = "0x43EAE0", Offset = "0x43D4E0", VA = "0x18043EAE0")]
		private int GetRefreshPrice()
		{
			return 0;
		}

		// Token: 0x060013A9 RID: 5033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013A9")]
		[Address(RVA = "0x43F930", Offset = "0x43E330", VA = "0x18043F930")]
		private void TryNextGacha()
		{
		}

		// Token: 0x060013AA RID: 5034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AA")]
		[Address(RVA = "0x43F4F0", Offset = "0x43DEF0", VA = "0x18043F4F0")]
		private IEnumerator PlayStartAnim()
		{
			return null;
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AB")]
		[Address(RVA = "0x43F470", Offset = "0x43DE70", VA = "0x18043F470")]
		private IEnumerator PlayDealAnimations()
		{
			return null;
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013AC")]
		[Address(RVA = "0x43EA70", Offset = "0x43D470", VA = "0x18043EA70")]
		private void FinishSelect()
		{
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AD")]
		[Address(RVA = "0x43F660", Offset = "0x43E060", VA = "0x18043F660")]
		private UIButtonBase TryFindCurrentCursorFocus()
		{
			return null;
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013AE")]
		[Address(RVA = "0x43ED60", Offset = "0x43D760", VA = "0x18043ED60", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013AF")]
		[Address(RVA = "0x43ECB0", Offset = "0x43D6B0", VA = "0x18043ECB0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013B0")]
		[Address(RVA = "0x43FEF0", Offset = "0x43E8F0", VA = "0x18043FEF0")]
		public void UpdateGachaNum()
		{
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013B1")]
		[Address(RVA = "0x43E590", Offset = "0x43CF90", VA = "0x18043E590", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013B2")]
		[Address(RVA = "0x440070", Offset = "0x43EA70", VA = "0x180440070")]
		public DLC5_RogueLikeCardSelectorPanel()
		{
		}

		// Token: 0x040011D7 RID: 4567
		[Token(Token = "0x40011D7")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private CanvasGroup m_ParentCanvas;

		// Token: 0x040011D8 RID: 4568
		[Token(Token = "0x40011D8")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject m_ItemStack;

		// Token: 0x040011D9 RID: 4569
		[Token(Token = "0x40011D9")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RectTransform m_ContainerParent;

		// Token: 0x040011DA RID: 4570
		[Token(Token = "0x40011DA")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Animator m_CardAnimator;

		// Token: 0x040011DB RID: 4571
		[Token(Token = "0x40011DB")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private CanvasGroup m_DescriberParent;

		// Token: 0x040011DC RID: 4572
		[Token(Token = "0x40011DC")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private DLC5_RogueLikeCardSelectorPanel.RarityColorPair[] m_RarityColorPairs;

		// Token: 0x040011DD RID: 4573
		[Token(Token = "0x40011DD")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Color m_CardTitleColor;

		// Token: 0x040011DE RID: 4574
		[Token(Token = "0x40011DE")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Color m_CardDesColor;

		// Token: 0x040011DF RID: 4575
		[Token(Token = "0x40011DF")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Color m_PersistentCardDesColor;

		// Token: 0x040011E0 RID: 4576
		[Token(Token = "0x40011E0")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Sprite m_PersistentCardForeverColor;

		// Token: 0x040011E1 RID: 4577
		[Token(Token = "0x40011E1")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private Sprite m_PersistentCardForeverBack;

		// Token: 0x040011E2 RID: 4578
		[Token(Token = "0x40011E2")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Color m_PersistentCardForeverTitleColor;

		// Token: 0x040011E3 RID: 4579
		[Token(Token = "0x40011E3")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Sprite m_PersistentCardRemainingColor;

		// Token: 0x040011E4 RID: 4580
		[Token(Token = "0x40011E4")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Sprite m_PersistentCardRemainingBack;

		// Token: 0x040011E5 RID: 4581
		[Token(Token = "0x40011E5")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Color m_PersistentCardRemainingTitleColor;

		// Token: 0x040011E6 RID: 4582
		[Token(Token = "0x40011E6")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private UIButtonSimple m_DataViewerBtn;

		// Token: 0x040011E7 RID: 4583
		[Token(Token = "0x40011E7")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private TextMeshProUGUI m_DescriptionText;

		// Token: 0x040011E8 RID: 4584
		[Token(Token = "0x40011E8")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private TextMeshProUGUI m_ExtraText;

		// Token: 0x040011E9 RID: 4585
		[Token(Token = "0x40011E9")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private TextMeshProUGUI m_RefreshText;

		// Token: 0x040011EA RID: 4586
		[Token(Token = "0x40011EA")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private Color m_BaseDescriptionColor;

		// Token: 0x040011EB RID: 4587
		[Token(Token = "0x40011EB")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private Color m_DangerousDescriptionColor;

		// Token: 0x040011EC RID: 4588
		[Token(Token = "0x40011EC")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private Animator m_StartAnim;

		// Token: 0x040011ED RID: 4589
		[Token(Token = "0x40011ED")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private TextMeshProUGUI m_GachaNumText;

		// Token: 0x040011EE RID: 4590
		[Token(Token = "0x40011EE")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private TextMeshProUGUI m_GachaMaxNumText;

		// Token: 0x040011EF RID: 4591
		[Token(Token = "0x40011EF")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private UIButtonSimple m_RefreshButton;

		// Token: 0x040011F0 RID: 4592
		[Token(Token = "0x40011F0")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private DLC5_RogueLikeExtraMenuSubPanel m_ExtraMenuSubPanelForCardSelector;

		// Token: 0x040011F1 RID: 4593
		[Token(Token = "0x40011F1")]
		[FieldOffset(Offset = "0x1B8")]
		private bool isHide;

		// Token: 0x040011F2 RID: 4594
		[Token(Token = "0x40011F2")]
		[FieldOffset(Offset = "0x1C0")]
		private List<GameObject> m_AllInstances;

		// Token: 0x040011F3 RID: 4595
		[Token(Token = "0x40011F3")]
		[FieldOffset(Offset = "0x1C8")]
		private List<UIButtonBase> m_Instance;

		// Token: 0x040011F4 RID: 4596
		[Token(Token = "0x40011F4")]
		[FieldOffset(Offset = "0x1D0")]
		[TupleElementNames(new string[] { "BG", "Back" })]
		private Dictionary<RogueLikeCardBase.Rarity, ValueTuple<Sprite, Sprite>> m_RarityColorDic;

		// Token: 0x040011F5 RID: 4597
		[Token(Token = "0x40011F5")]
		[FieldOffset(Offset = "0x1D8")]
		private UIButtonDoubleClickHold m_CurrentButtonHold;

		// Token: 0x040011F6 RID: 4598
		[Token(Token = "0x40011F6")]
		[FieldOffset(Offset = "0x1E0")]
		private CanvasGroup m_ContainerCanvasGroup;

		// Token: 0x040011F7 RID: 4599
		[Token(Token = "0x40011F7")]
		[FieldOffset(Offset = "0x1E8")]
		private Action m_RefreshCallback;

		// Token: 0x040011F8 RID: 4600
		[Token(Token = "0x40011F8")]
		[FieldOffset(Offset = "0x1F0")]
		private bool m_IsPreparing;

		// Token: 0x040011F9 RID: 4601
		[Token(Token = "0x40011F9")]
		[FieldOffset(Offset = "0x1F1")]
		private bool m_IsDealing;

		// Token: 0x040011FB RID: 4603
		[Token(Token = "0x40011FB")]
		[FieldOffset(Offset = "0x1F8")]
		private bool m_IsSubPanelOpened;

		// Token: 0x040011FC RID: 4604
		[Token(Token = "0x40011FC")]
		[FieldOffset(Offset = "0x200")]
		private Action m_OnSubPanelClosed;

		// Token: 0x040011FD RID: 4605
		[Token(Token = "0x40011FD")]
		[FieldOffset(Offset = "0x208")]
		private List<RogueLikeCardInstance> m_CardLists;

		// Token: 0x02000377 RID: 887
		[Token(Token = "0x2000377")]
		[Serializable]
		public struct RarityColorPair
		{
			// Token: 0x040011FE RID: 4606
			[Token(Token = "0x40011FE")]
			[FieldOffset(Offset = "0x0")]
			public RogueLikeCardBase.Rarity Rarity;

			// Token: 0x040011FF RID: 4607
			[Token(Token = "0x40011FF")]
			[FieldOffset(Offset = "0x8")]
			public Sprite Color;

			// Token: 0x04001200 RID: 4608
			[Token(Token = "0x4001200")]
			[FieldOffset(Offset = "0x10")]
			public Sprite Back;
		}

		// Token: 0x02000378 RID: 888
		[Token(Token = "0x2000378")]
		public struct OpenContext
		{
			// Token: 0x060013B6 RID: 5046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60013B6")]
			[Address(RVA = "0x44F2B0", Offset = "0x44DCB0", VA = "0x18044F2B0")]
			public OpenContext(Queue<TriggerCardCondition> triggerCardConditions, Func<TriggerCardCondition, List<RogueLikeCardInstance>> getCardListsCallback, Action<TriggerCardCondition, RogueLikeCardInstance, List<RogueLikeCardInstance>> afterSelectCardCallback, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikeManager rogueLikeManager, Func<RogueLikeCardBase.CardType, RogueLikeCardBase> getCardPropertyFunc, Action<int> afterRefreshCallback, Func<int> getFundCallback)
			{
			}

			// Token: 0x04001201 RID: 4609
			[Token(Token = "0x4001201")]
			[FieldOffset(Offset = "0x0")]
			public readonly Queue<TriggerCardCondition> TriggerCardConditions;

			// Token: 0x04001202 RID: 4610
			[Token(Token = "0x4001202")]
			[FieldOffset(Offset = "0x8")]
			public readonly Func<TriggerCardCondition, List<RogueLikeCardInstance>> GetCardListsCallback;

			// Token: 0x04001203 RID: 4611
			[Token(Token = "0x4001203")]
			[FieldOffset(Offset = "0x10")]
			public readonly Action<TriggerCardCondition, RogueLikeCardInstance, List<RogueLikeCardInstance>> AfterSelectCardCallback;

			// Token: 0x04001204 RID: 4612
			[Token(Token = "0x4001204")]
			[FieldOffset(Offset = "0x18")]
			public readonly RogueLikeRunTimeData RogueLikeRunTimeData;

			// Token: 0x04001205 RID: 4613
			[Token(Token = "0x4001205")]
			[FieldOffset(Offset = "0x20")]
			public readonly RogueLikeManager RogueLikeManager;

			// Token: 0x04001206 RID: 4614
			[Token(Token = "0x4001206")]
			[FieldOffset(Offset = "0x28")]
			public readonly Func<RogueLikeCardBase.CardType, RogueLikeCardBase> GetCardPropertyFunc;

			// Token: 0x04001207 RID: 4615
			[Token(Token = "0x4001207")]
			[FieldOffset(Offset = "0x30")]
			public readonly Action<int> AfterRefreshCallback;

			// Token: 0x04001208 RID: 4616
			[Token(Token = "0x4001208")]
			[FieldOffset(Offset = "0x38")]
			public readonly Func<int> GetFundCallback;
		}
	}
}
