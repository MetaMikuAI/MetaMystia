using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI;
using Common.UI.GlobalMap;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections;
using Il2CppDummyDll;
using PrepNightScene.UI;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000423 RID: 1059
	[Token(Token = "0x2000423")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeSpotSelectionPanel_New : GuideMapPanel<DLC5_RogueLikeSpotSelectionPanel_New.OpenContext, DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext>
	{
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x00008C40 File Offset: 0x00006E40
		// (set) Token: 0x06001775 RID: 6005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B6")]
		public bool HasPurchasePanelInitialize
		{
			[Token(Token = "0x6001774")]
			[Address(RVA = "0x468DC0", Offset = "0x4677C0", VA = "0x180468DC0")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x6001775")]
			[Address(RVA = "0x468DD0", Offset = "0x4677D0", VA = "0x180468DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x00008C58 File Offset: 0x00006E58
		[Token(Token = "0x6001776")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001777")]
		[Address(RVA = "0x465700", Offset = "0x464100", VA = "0x180465700", Slot = "34")]
		protected override void OnGuideMapInitialize()
		{
		}

		// Token: 0x06001778 RID: 6008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001778")]
		[Address(RVA = "0x466A00", Offset = "0x465400", VA = "0x180466A00", Slot = "46")]
		protected override void OnSecondarySwitchUpdate()
		{
		}

		// Token: 0x06001779 RID: 6009 RVA: 0x00008C70 File Offset: 0x00006E70
		[Token(Token = "0x6001779")]
		[Address(RVA = "0x466AE0", Offset = "0x4654E0", VA = "0x180466AE0")]
		private UniTask OpenDescriptionMenu()
		{
			return default(UniTask);
		}

		// Token: 0x0600177A RID: 6010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177A")]
		[Address(RVA = "0x466290", Offset = "0x464C90", VA = "0x180466290", Slot = "35")]
		protected override void OnGuideMapPanelPreOpen(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext openContext)
		{
		}

		// Token: 0x0600177B RID: 6011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177B")]
		[Address(RVA = "0x468560", Offset = "0x466F60", VA = "0x180468560")]
		private void UpdateNeighbourDistance(string currentSpot)
		{
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177C")]
		[Address(RVA = "0x464F00", Offset = "0x463900", VA = "0x180464F00")]
		private void ClosePanelByExtraSub(DLC5_RogueLikeExtraMenuSubPanel.CloseContext exitMode)
		{
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177D")]
		[Address(RVA = "0x467570", Offset = "0x465F70", VA = "0x180467570")]
		private void TryClosePanel()
		{
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00008C88 File Offset: 0x00006E88
		[Token(Token = "0x600177E")]
		[Address(RVA = "0x468AE0", Offset = "0x4674E0", VA = "0x180468AE0")]
		private UniTask WaitForClothesAndPartnerSetting(Action onFinish)
		{
			return default(UniTask);
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600177F")]
		[Address(RVA = "0x466140", Offset = "0x464B40", VA = "0x180466140", Slot = "37")]
		protected override void OnGuideMapPanelEndOpen(DLC5_RogueLikeSpotSelectionPanel_New.OpenContext openContext)
		{
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001780")]
		[Address(RVA = "0x467270", Offset = "0x465C70", VA = "0x180467270")]
		private void TryCheckElite()
		{
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001781")]
		[Address(RVA = "0x466BA0", Offset = "0x4655A0", VA = "0x180466BA0")]
		private void OpenPurchasePanel()
		{
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00008CA0 File Offset: 0x00006EA0
		[Token(Token = "0x6001782")]
		[Address(RVA = "0x464FF0", Offset = "0x4639F0", VA = "0x180464FF0")]
		private UnlockedIzakayaInfo GetLevel(IGuideMapSpot guideMapSpot)
		{
			return (UnlockedIzakayaInfo)0;
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00008CB8 File Offset: 0x00006EB8
		[Token(Token = "0x6001783")]
		[Address(RVA = "0x4651C0", Offset = "0x463BC0", VA = "0x1804651C0", Slot = "39")]
		protected override bool GetSpotOpenStatus(IGuideMapSpot guideMapSpot)
		{
			return default(bool);
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00008CD0 File Offset: 0x00006ED0
		[Token(Token = "0x6001784")]
		[Address(RVA = "0x4655B0", Offset = "0x463FB0", VA = "0x1804655B0", Slot = "40")]
		protected override bool GetSpotShouldShowPath(IGuideMapSpot guideMapSpot1, IGuideMapSpot guideMapSpot2)
		{
			return default(bool);
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001785")]
		[Address(RVA = "0x4667F0", Offset = "0x4651F0", VA = "0x1804667F0", Slot = "44")]
		protected override void OnGuideMapSpotSubmit(IGuideMapSpot guideMapSpot)
		{
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x00008CE8 File Offset: 0x00006EE8
		[Token(Token = "0x6001786")]
		[Address(RVA = "0x4656F0", Offset = "0x4640F0", VA = "0x1804656F0", Slot = "43")]
		protected override bool IsGuideMapSpotCanBeSelected(IGuideMapSpot guideMapSpot)
		{
			return default(bool);
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001787")]
		[Address(RVA = "0x466360", Offset = "0x464D60", VA = "0x180466360", Slot = "42")]
		protected override void OnGuideMapSpotSelected(IGuideMapSpot guideMapSpot)
		{
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001788")]
		[Address(RVA = "0x468020", Offset = "0x466A20", VA = "0x180468020")]
		private void UpdateCurrentIzakaya()
		{
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002B7")]
		private IEnumerable<IGuideMapSpot> GetNeighbourSpots
		{
			[Token(Token = "0x6001789")]
			[Address(RVA = "0x468D00", Offset = "0x467700", VA = "0x180468D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00008D00 File Offset: 0x00006F00
		[Token(Token = "0x600178A")]
		[Address(RVA = "0x467150", Offset = "0x465B50", VA = "0x180467150")]
		private bool TryChangeIzakayaLevel(ref UnlockedIzakayaInfo izakayaLevel, bool add)
		{
			return default(bool);
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00008D18 File Offset: 0x00006F18
		[Token(Token = "0x600178B")]
		[Address(RVA = "0x467190", Offset = "0x465B90", VA = "0x180467190")]
		private bool TryChangeIzakayaLevel(ref UnlockedIzakayaInfo izakayaLevel, UnlockedIzakayaInfo targetLevel)
		{
			return default(bool);
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600178C")]
		[Address(RVA = "0x468A70", Offset = "0x467470", VA = "0x180468A70")]
		private void UpdateToggleStatus(UnlockedIzakayaInfo targetLevel)
		{
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00008D30 File Offset: 0x00006F30
		[Token(Token = "0x600178D")]
		[Address(RVA = "0x465650", Offset = "0x464050", VA = "0x180465650", Slot = "41")]
		protected override bool? IsFirstToSelectSpot(IGuideMapSpot guideMapSpot)
		{
			return null;
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600178E")]
		[Address(RVA = "0x467030", Offset = "0x465A30", VA = "0x180467030", Slot = "38")]
		protected override void PostInitializeGuideMapSpot(IGuideMapSpot guideMapSpot)
		{
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600178F")]
		[Address(RVA = "0x464C70", Offset = "0x463670", VA = "0x180464C70", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001790")]
		[Address(RVA = "0x468BC0", Offset = "0x4675C0", VA = "0x180468BC0")]
		public DLC5_RogueLikeSpotSelectionPanel_New()
		{
		}

		// Token: 0x040015F6 RID: 5622
		[Token(Token = "0x40015F6")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private UIButtonHold m_GotoIzakayaBtn;

		// Token: 0x040015F7 RID: 5623
		[Token(Token = "0x40015F7")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private UIButtonSimple m_DataViewerBtn;

		// Token: 0x040015F8 RID: 5624
		[Token(Token = "0x40015F8")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private UIButtonToggle m_Level1Toggle;

		// Token: 0x040015F9 RID: 5625
		[Token(Token = "0x40015F9")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private UIButtonToggle m_Level2Toggle;

		// Token: 0x040015FA RID: 5626
		[Token(Token = "0x40015FA")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private UIButtonToggle m_Level3Toggle;

		// Token: 0x040015FB RID: 5627
		[Token(Token = "0x40015FB")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private GuideMapSpotIzakayaExtension m_GuideMapSpotExtension;

		// Token: 0x040015FC RID: 5628
		[Token(Token = "0x40015FC")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private DLC5_RogueLikeMapDescriber m_SelectedIzakayaDescriber;

		// Token: 0x040015FD RID: 5629
		[Token(Token = "0x40015FD")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private CanvasGroup m_MainPanel;

		// Token: 0x040015FE RID: 5630
		[Token(Token = "0x40015FE")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private UIButtonSimple m_ExpandButton;

		// Token: 0x040015FF RID: 5631
		[Token(Token = "0x40015FF")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private UIButtonSimple m_GotoShopButton;

		// Token: 0x04001600 RID: 5632
		[Token(Token = "0x4001600")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private RogueLikeDetailPanel m_DetailPanel;

		// Token: 0x04001601 RID: 5633
		[Token(Token = "0x4001601")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private DLC5_RogueLikePurchasePanel m_PurchasePanel;

		// Token: 0x04001602 RID: 5634
		[Token(Token = "0x4001602")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private RemindSubPanel m_RemindPanel;

		// Token: 0x04001603 RID: 5635
		[Token(Token = "0x4001603")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private CanvasGroup m_GotoIzakayaButtonLayer;

		// Token: 0x04001604 RID: 5636
		[Token(Token = "0x4001604")]
		[FieldOffset(Offset = "0x1F0")]
		[SerializeField]
		private TextMeshProUGUI m_WholeCollectRateTitleText;

		// Token: 0x04001605 RID: 5637
		[Token(Token = "0x4001605")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		private TextMeshProUGUI m_MoveActionText;

		// Token: 0x04001606 RID: 5638
		[Token(Token = "0x4001606")]
		[FieldOffset(Offset = "0x200")]
		[SerializeField]
		private DLC5_RogueLikeExtraMenuSubPanel m_ExtraMenuSubPanelForMap;

		// Token: 0x04001607 RID: 5639
		[Token(Token = "0x4001607")]
		[FieldOffset(Offset = "0x208")]
		[SerializeField]
		private Image m_MystiaIcon;

		// Token: 0x04001608 RID: 5640
		[Token(Token = "0x4001608")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		private Vector2 m_MystiaIconOffset;

		// Token: 0x04001609 RID: 5641
		[Token(Token = "0x4001609")]
		[FieldOffset(Offset = "0x218")]
		[SerializeField]
		private DLC5_RogueLikeEliteIntroductionPanel m_EliteIntroductionPanel;

		// Token: 0x0400160A RID: 5642
		[Token(Token = "0x400160A")]
		[FieldOffset(Offset = "0x220")]
		[SerializeField]
		private DLC5_RogueLikeSpotSelectionPanelEliteTipPanel m_EliteTipPanel;

		// Token: 0x0400160B RID: 5643
		[Token(Token = "0x400160B")]
		[FieldOffset(Offset = "0x228")]
		private DLC5_RogueLikePurchasePanel instance;

		// Token: 0x0400160C RID: 5644
		[Token(Token = "0x400160C")]
		[FieldOffset(Offset = "0x230")]
		private bool isNeighbour;

		// Token: 0x0400160D RID: 5645
		[Token(Token = "0x400160D")]
		[FieldOffset(Offset = "0x231")]
		private bool doNotShowRemindMessage;

		// Token: 0x0400160E RID: 5646
		[Token(Token = "0x400160E")]
		[FieldOffset(Offset = "0x232")]
		private bool secondMenuIsOpend;

		// Token: 0x04001610 RID: 5648
		[Token(Token = "0x4001610")]
		[FieldOffset(Offset = "0x238")]
		private readonly Dictionary<IGuideMapSpot, DLC5_RogueLikeSpotSelectionPanel_New.GuideMapSpotRuntimeData> m_SpotToExtensions;

		// Token: 0x04001611 RID: 5649
		[Token(Token = "0x4001611")]
		[FieldOffset(Offset = "0x240")]
		private UnlockedIzakayaInfo m_CurrentSelectedIzakayaLevel;

		// Token: 0x04001612 RID: 5650
		[Token(Token = "0x4001612")]
		[FieldOffset(Offset = "0x248")]
		private IGuideMapSpot m_CurrentSelectedSpot;

		// Token: 0x04001613 RID: 5651
		[Token(Token = "0x4001613")]
		[FieldOffset(Offset = "0x250")]
		private readonly HashSet<IGuideMapSpot> m_CurrentNeighbours;

		// Token: 0x04001614 RID: 5652
		[Token(Token = "0x4001614")]
		[FieldOffset(Offset = "0x258")]
		private RogueLikeRunTimeData.DLCAreaCollectRate CurrentDlcAreaCollectRate;

		// Token: 0x04001615 RID: 5653
		[Token(Token = "0x4001615")]
		[FieldOffset(Offset = "0x280")]
		private readonly HashSet<UIPanelBaseImpl> deletePanelWhenExit;

		// Token: 0x04001616 RID: 5654
		[Token(Token = "0x4001616")]
		[FieldOffset(Offset = "0x288")]
		private bool m_HasConfirmed;

		// Token: 0x02000424 RID: 1060
		[Token(Token = "0x2000424")]
		public readonly struct OpenContext
		{
			// Token: 0x0600179D RID: 6045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600179D")]
			[Address(RVA = "0x479090", Offset = "0x477A90", VA = "0x180479090")]
			public OpenContext(IReadOnlyDictionary<string, UnlockedIzakayaInfo> unlockedIzakayaInfos, string currentSpot, bool unlockAllLevel2Spot, bool unlockAllLevel3Spot, Func<string, UnlockedIzakayaInfo, ValueTuple<DLC5_RogueLikeDataProfile.MapSetup, Izakaya>> getIzakayaHandler, RogueLikeRunTimeData rogueLikeRunTimeData, bool isStart)
			{
			}

			// Token: 0x04001617 RID: 5655
			[Token(Token = "0x4001617")]
			[FieldOffset(Offset = "0x0")]
			public readonly IReadOnlyDictionary<string, UnlockedIzakayaInfo> UnlockedIzakayaInfos;

			// Token: 0x04001618 RID: 5656
			[Token(Token = "0x4001618")]
			[FieldOffset(Offset = "0x8")]
			public readonly string CurrentSpot;

			// Token: 0x04001619 RID: 5657
			[Token(Token = "0x4001619")]
			[FieldOffset(Offset = "0x10")]
			public readonly bool UnlockAllLevel2Spot;

			// Token: 0x0400161A RID: 5658
			[Token(Token = "0x400161A")]
			[FieldOffset(Offset = "0x11")]
			public readonly bool UnlockAllLevel3Spot;

			// Token: 0x0400161B RID: 5659
			[Token(Token = "0x400161B")]
			[FieldOffset(Offset = "0x18")]
			public readonly Func<string, UnlockedIzakayaInfo, ValueTuple<DLC5_RogueLikeDataProfile.MapSetup, Izakaya>> GetIzakayaHandler;

			// Token: 0x0400161C RID: 5660
			[Token(Token = "0x400161C")]
			[FieldOffset(Offset = "0x20")]
			public readonly RogueLikeRunTimeData RogueLikeRunTimeData;

			// Token: 0x0400161D RID: 5661
			[Token(Token = "0x400161D")]
			[FieldOffset(Offset = "0x28")]
			public readonly bool IsStart;
		}

		// Token: 0x02000425 RID: 1061
		[Token(Token = "0x2000425")]
		public readonly struct RogueMapCloseContext
		{
			// Token: 0x0600179E RID: 6046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600179E")]
			[Address(RVA = "0x48B8F0", Offset = "0x48A2F0", VA = "0x18048B8F0")]
			public RogueMapCloseContext(DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext.ExitMode panelExitMode, string spotName, UnlockedIzakayaInfo spotLevel)
			{
			}

			// Token: 0x0400161E RID: 5662
			[Token(Token = "0x400161E")]
			[FieldOffset(Offset = "0x0")]
			public readonly DLC5_RogueLikeSpotSelectionPanel_New.RogueMapCloseContext.ExitMode PanelExitMode;

			// Token: 0x0400161F RID: 5663
			[Token(Token = "0x400161F")]
			[FieldOffset(Offset = "0x8")]
			public readonly string SpotName;

			// Token: 0x04001620 RID: 5664
			[Token(Token = "0x4001620")]
			[FieldOffset(Offset = "0x10")]
			public readonly UnlockedIzakayaInfo SpotLevel;

			// Token: 0x02000426 RID: 1062
			[Token(Token = "0x2000426")]
			public enum ExitMode
			{
				// Token: 0x04001622 RID: 5666
				[Token(Token = "0x4001622")]
				GotoWork,
				// Token: 0x04001623 RID: 5667
				[Token(Token = "0x4001623")]
				ExitRogue,
				// Token: 0x04001624 RID: 5668
				[Token(Token = "0x4001624")]
				BackToMenu
			}
		}

		// Token: 0x02000427 RID: 1063
		[Token(Token = "0x2000427")]
		private class GuideMapSpotRuntimeData
		{
			// Token: 0x170002B8 RID: 696
			// (get) Token: 0x0600179F RID: 6047 RVA: 0x00008D60 File Offset: 0x00006F60
			// (set) Token: 0x060017A0 RID: 6048 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170002B8")]
			public UnlockedIzakayaInfo IzakayaLevel
			{
				[Token(Token = "0x600179F")]
				[Address(RVA = "0x403830", Offset = "0x402230", VA = "0x180403830")]
				[CompilerGenerated]
				get
				{
					return (UnlockedIzakayaInfo)0;
				}
				[Token(Token = "0x60017A0")]
				[Address(RVA = "0x403860", Offset = "0x402260", VA = "0x180403860")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060017A1 RID: 6049 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60017A1")]
			[Address(RVA = "0x46BA70", Offset = "0x46A470", VA = "0x18046BA70")]
			public GuideMapSpotRuntimeData(GuideMapSpotIzakayaExtension extension)
			{
			}

			// Token: 0x04001625 RID: 5669
			[Token(Token = "0x4001625")]
			[FieldOffset(Offset = "0x10")]
			public readonly GuideMapSpotIzakayaExtension Extension;

			// Token: 0x04001627 RID: 5671
			[Token(Token = "0x4001627")]
			[FieldOffset(Offset = "0x1C")]
			public int? Level1IzakayaId;

			// Token: 0x04001628 RID: 5672
			[Token(Token = "0x4001628")]
			[FieldOffset(Offset = "0x24")]
			public int? Level2IzakayaId;

			// Token: 0x04001629 RID: 5673
			[Token(Token = "0x4001629")]
			[FieldOffset(Offset = "0x2C")]
			public int? Level3IzakayaId;
		}
	}
}
