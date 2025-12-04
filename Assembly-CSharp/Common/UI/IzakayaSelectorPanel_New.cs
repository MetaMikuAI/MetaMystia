using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI.GlobalMap;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.LogicalCollection;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI
{
	// Token: 0x02000E3D RID: 3645
	[Token(Token = "0x2000E3D")]
	[GenerateCleanupMethod]
	public sealed class IzakayaSelectorPanel_New : GuideMapPanel<IzakayaSelectorPanel_New.OpenContext, int>
	{
		// Token: 0x06005526 RID: 21798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005526")]
		[Address(RVA = "0x839770", Offset = "0x838170", VA = "0x180839770", Slot = "34")]
		protected override void OnGuideMapInitialize()
		{
		}

		// Token: 0x06005527 RID: 21799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005527")]
		[Address(RVA = "0x83A3D0", Offset = "0x838DD0", VA = "0x18083A3D0", Slot = "46")]
		protected override void OnSecondarySwitchUpdate()
		{
		}

		// Token: 0x06005528 RID: 21800 RVA: 0x0001E5A0 File Offset: 0x0001C7A0
		[Token(Token = "0x6005528")]
		[Address(RVA = "0x83A4B0", Offset = "0x838EB0", VA = "0x18083A4B0")]
		private UniTask OpenDescriptionMenu()
		{
			return default(UniTask);
		}

		// Token: 0x06005529 RID: 21801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005529")]
		[Address(RVA = "0x83A220", Offset = "0x838C20", VA = "0x18083A220", Slot = "35")]
		protected override void OnGuideMapPanelPreOpen(IzakayaSelectorPanel_New.OpenContext openContext)
		{
		}

		// Token: 0x0600552A RID: 21802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600552A")]
		[Address(RVA = "0x83A130", Offset = "0x838B30", VA = "0x18083A130", Slot = "36")]
		protected override void OnGuideMapPanelPostOpen(IzakayaSelectorPanel_New.OpenContext openContext)
		{
		}

		// Token: 0x0600552B RID: 21803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600552B")]
		[Address(RVA = "0x839F80", Offset = "0x838980", VA = "0x180839F80", Slot = "37")]
		protected override void OnGuideMapPanelEndOpen(IzakayaSelectorPanel_New.OpenContext openContext)
		{
		}

		// Token: 0x0600552C RID: 21804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600552C")]
		[Address(RVA = "0x839710", Offset = "0x838110", VA = "0x180839710", Slot = "45")]
		protected override void OnGuideMapClose(int closeContext)
		{
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x0001E5B8 File Offset: 0x0001C7B8
		[Token(Token = "0x600552D")]
		[Address(RVA = "0x839140", Offset = "0x837B40", VA = "0x180839140", Slot = "39")]
		protected override bool GetSpotOpenStatus(IGuideMapSpot guideMapSpot)
		{
			return default(bool);
		}

		// Token: 0x0600552E RID: 21806 RVA: 0x0001E5D0 File Offset: 0x0001C7D0
		[Token(Token = "0x600552E")]
		[Address(RVA = "0x839520", Offset = "0x837F20", VA = "0x180839520", Slot = "43")]
		protected override bool IsGuideMapSpotCanBeSelected(IGuideMapSpot guideMapSpot)
		{
			return default(bool);
		}

		// Token: 0x0600552F RID: 21807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600552F")]
		[Address(RVA = "0x83A320", Offset = "0x838D20", VA = "0x18083A320", Slot = "42")]
		protected override void OnGuideMapSpotSelected(IGuideMapSpot guideMapSpot)
		{
		}

		// Token: 0x06005530 RID: 21808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005530")]
		[Address(RVA = "0x83B490", Offset = "0x839E90", VA = "0x18083B490")]
		private void UpdateCurrentIzakaya()
		{
		}

		// Token: 0x06005531 RID: 21809 RVA: 0x0001E5E8 File Offset: 0x0001C7E8
		[Token(Token = "0x6005531")]
		[Address(RVA = "0x838DB0", Offset = "0x8377B0", VA = "0x180838DB0")]
		private int CalculateIzakayaId(out IzakayaSelectorPanel_New.GuideMapSpotRuntimeData runtimeData)
		{
			return 0;
		}

		// Token: 0x06005532 RID: 21810 RVA: 0x0001E600 File Offset: 0x0001C800
		[Token(Token = "0x6005532")]
		[Address(RVA = "0x83A910", Offset = "0x839310", VA = "0x18083A910")]
		private bool TryChangeIzakayaLevel(ref IzakayaLevel izakayaLevel, bool add)
		{
			return default(bool);
		}

		// Token: 0x06005533 RID: 21811 RVA: 0x0001E618 File Offset: 0x0001C818
		[Token(Token = "0x6005533")]
		[Address(RVA = "0x83A870", Offset = "0x839270", VA = "0x18083A870")]
		private bool TryChangeIzakayaLevel(ref IzakayaLevel izakayaLevel, IzakayaLevel targetLevel)
		{
			return default(bool);
		}

		// Token: 0x06005534 RID: 21812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005534")]
		[Address(RVA = "0x83B5C0", Offset = "0x839FC0", VA = "0x18083B5C0")]
		private void UpdateToggleStatus(IzakayaLevel targetLevel)
		{
		}

		// Token: 0x06005535 RID: 21813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005535")]
		[Address(RVA = "0x83A660", Offset = "0x839060", VA = "0x18083A660", Slot = "38")]
		protected override void PostInitializeGuideMapSpot(IGuideMapSpot guideMapSpot)
		{
		}

		// Token: 0x06005536 RID: 21814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005536")]
		[Address(RVA = "0x83A7F0", Offset = "0x8391F0", VA = "0x18083A7F0")]
		private void PrintPartnerData()
		{
		}

		// Token: 0x06005537 RID: 21815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005537")]
		[Address(RVA = "0x839530", Offset = "0x837F30", VA = "0x180839530")]
		private void LoadSelectionToIzakayaConfig()
		{
		}

		// Token: 0x06005538 RID: 21816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005538")]
		[Address(RVA = "0x838F30", Offset = "0x837930", VA = "0x180838F30", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005539 RID: 21817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005539")]
		[Address(RVA = "0x83B630", Offset = "0x83A030", VA = "0x18083B630")]
		public IzakayaSelectorPanel_New()
		{
		}

		// Token: 0x06005546 RID: 21830 RVA: 0x0001E630 File Offset: 0x0001C830
		[Token(Token = "0x6005546")]
		[CompilerGenerated]
		internal static bool <GetSpotOpenStatus>g__Match|29_0<T>(IEnumerable<T> collection, Func<T, bool> handler, out T? matched) where T : struct
		{
			return default(bool);
		}

		// Token: 0x0400500B RID: 20491
		[Token(Token = "0x400500B")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private UIButtonHold m_GotoIzakayaBtn;

		// Token: 0x0400500C RID: 20492
		[Token(Token = "0x400500C")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private UIButtonSimple m_GotoPartnerBtn;

		// Token: 0x0400500D RID: 20493
		[Token(Token = "0x400500D")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private UIButtonSimple m_NoteBookBtn;

		// Token: 0x0400500E RID: 20494
		[Token(Token = "0x400500E")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private UIButtonSimple m_StorageBtn;

		// Token: 0x0400500F RID: 20495
		[Token(Token = "0x400500F")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private UIButtonToggle m_Level1Toggle;

		// Token: 0x04005010 RID: 20496
		[Token(Token = "0x4005010")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private UIButtonToggle m_Level2Toggle;

		// Token: 0x04005011 RID: 20497
		[Token(Token = "0x4005011")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private UIButtonToggle m_Level3Toggle;

		// Token: 0x04005012 RID: 20498
		[Token(Token = "0x4005012")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private GameObject m_LockIndicator;

		// Token: 0x04005013 RID: 20499
		[Token(Token = "0x4005013")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private GuideMapSpotIzakayaExtension m_GuideMapSpotExtension;

		// Token: 0x04005014 RID: 20500
		[Token(Token = "0x4005014")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private SelectedPartnerDescriber m_SelectedPartnerDescriber;

		// Token: 0x04005015 RID: 20501
		[Token(Token = "0x4005015")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private GameObject m_DefaultPartner;

		// Token: 0x04005016 RID: 20502
		[Token(Token = "0x4005016")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private SelectedIzakayaDescriber m_SelectedIzakayaDescriber;

		// Token: 0x04005017 RID: 20503
		[Token(Token = "0x4005017")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private CanvasGroup m_MainPanel;

		// Token: 0x04005018 RID: 20504
		[Token(Token = "0x4005018")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private UIButtonSimple m_ExpandButton;

		// Token: 0x04005019 RID: 20505
		[Token(Token = "0x4005019")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private IzakayaDetailPanel m_DetailPanel;

		// Token: 0x0400501A RID: 20506
		[Token(Token = "0x400501A")]
		[FieldOffset(Offset = "0x1D8")]
		private readonly Dictionary<IGuideMapSpot, IzakayaSelectorPanel_New.GuideMapSpotRuntimeData> m_SpotToExtensions;

		// Token: 0x0400501B RID: 20507
		[Token(Token = "0x400501B")]
		[FieldOffset(Offset = "0x1E0")]
		private readonly List<GameObject> m_LockedSelectionCache;

		// Token: 0x0400501C RID: 20508
		[Token(Token = "0x400501C")]
		[FieldOffset(Offset = "0x1E8")]
		private IzakayaLevel m_CurrentSelectedIzakayaLevel;

		// Token: 0x0400501D RID: 20509
		[Token(Token = "0x400501D")]
		[FieldOffset(Offset = "0x1F0")]
		private IGuideMapSpot m_CurrentSelectedSpot;

		// Token: 0x0400501E RID: 20510
		[Token(Token = "0x400501E")]
		[FieldOffset(Offset = "0x1F8")]
		private HashSet<string> m_AllAvailableMaps;

		// Token: 0x0400501F RID: 20511
		[Token(Token = "0x400501F")]
		[FieldOffset(Offset = "0x200")]
		private Izakaya m_CurrentSelectedIzakayaData;

		// Token: 0x04005020 RID: 20512
		[Token(Token = "0x4005020")]
		[FieldOffset(Offset = "0x208")]
		private bool m_IsDetailPanelOpened;

		// Token: 0x02000E3E RID: 3646
		[Token(Token = "0x2000E3E")]
		private class GuideMapSpotRuntimeData
		{
			// Token: 0x17000BFB RID: 3067
			// (get) Token: 0x06005547 RID: 21831 RVA: 0x0001E648 File Offset: 0x0001C848
			// (set) Token: 0x06005548 RID: 21832 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000BFB")]
			public IzakayaLevel IzakayaLevel
			{
				[Token(Token = "0x6005547")]
				[Address(RVA = "0x403830", Offset = "0x402230", VA = "0x180403830")]
				[CompilerGenerated]
				get
				{
					return IzakayaLevel.Null;
				}
				[Token(Token = "0x6005548")]
				[Address(RVA = "0x403860", Offset = "0x402260", VA = "0x180403860")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06005549 RID: 21833 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005549")]
			[Address(RVA = "0x46BA70", Offset = "0x46A470", VA = "0x18046BA70")]
			public GuideMapSpotRuntimeData(GuideMapSpotIzakayaExtension extension)
			{
			}

			// Token: 0x04005021 RID: 20513
			[Token(Token = "0x4005021")]
			[FieldOffset(Offset = "0x10")]
			public readonly GuideMapSpotIzakayaExtension Extension;

			// Token: 0x04005023 RID: 20515
			[Token(Token = "0x4005023")]
			[FieldOffset(Offset = "0x1C")]
			public int? Level1IzakayaId;

			// Token: 0x04005024 RID: 20516
			[Token(Token = "0x4005024")]
			[FieldOffset(Offset = "0x24")]
			public int? Level2IzakayaId;

			// Token: 0x04005025 RID: 20517
			[Token(Token = "0x4005025")]
			[FieldOffset(Offset = "0x2C")]
			public int? Level3IzakayaId;
		}

		// Token: 0x02000E3F RID: 3647
		[Token(Token = "0x2000E3F")]
		public readonly struct OpenContext
		{
			// Token: 0x17000BFC RID: 3068
			// (get) Token: 0x0600554A RID: 21834 RVA: 0x0001E660 File Offset: 0x0001C860
			[Token(Token = "0x17000BFC")]
			public bool IsIzakayaLocked
			{
				[Token(Token = "0x600554A")]
				[Address(RVA = "0x83D5B0", Offset = "0x83BFB0", VA = "0x18083D5B0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600554B RID: 21835 RVA: 0x0001E678 File Offset: 0x0001C878
			[Token(Token = "0x600554B")]
			[Address(RVA = "0x83D100", Offset = "0x83BB00", VA = "0x18083D100")]
			public int TryMapIzakayaId(int sourceId)
			{
				return 0;
			}

			// Token: 0x0600554C RID: 21836 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600554C")]
			[Address(RVA = "0x83D1F0", Offset = "0x83BBF0", VA = "0x18083D1F0")]
			public OpenContext([TupleElementNames(new string[] { "CharacterId", "CharacterJob" })] ValueTuple<int, PartnerBase.PartnerType>[] partnerSelection, SchedulerNode.Trigger.IzakayaLockType izakayaLockType, SchedulerNode.Trigger.IzakayaMapping[] izakayaMappings)
			{
			}

			// Token: 0x04005026 RID: 20518
			[Token(Token = "0x4005026")]
			[FieldOffset(Offset = "0x0")]
			[TupleElementNames(new string[] { "CharacterId", "CharacterJob" })]
			public readonly ValueTuple<int, PartnerBase.PartnerType>[] PartnerSelection;

			// Token: 0x04005027 RID: 20519
			[Token(Token = "0x4005027")]
			[FieldOffset(Offset = "0x8")]
			public readonly Func<int, bool> IsIzakayaAvailableHandler;

			// Token: 0x04005028 RID: 20520
			[Token(Token = "0x4005028")]
			[FieldOffset(Offset = "0x10")]
			private readonly SchedulerNode.Trigger.IzakayaLockType m_IzakayaLockType;

			// Token: 0x04005029 RID: 20521
			[Token(Token = "0x4005029")]
			[FieldOffset(Offset = "0x18")]
			private readonly IReadOnlyDictionary<int, int> m_IzakayaMappings;
		}
	}
}
