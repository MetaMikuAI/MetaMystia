using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData;
using GameData.Core;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using Plugins.DEYU;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000EBC RID: 3772
	[Token(Token = "0x2000EBC")]
	[GenerateCleanupMethod]
	public class NoteBookMissionPannel : UISubPanel<NoteBookMainPannel>
	{
		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x060058B8 RID: 22712 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060058B9 RID: 22713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C61")]
		public string CharacterFillter
		{
			[Token(Token = "0x60058B8")]
			[Address(RVA = "0x48A8B0", Offset = "0x4892B0", VA = "0x18048A8B0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60058B9")]
			[Address(RVA = "0x55B0B0", Offset = "0x559AB0", VA = "0x18055B0B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (set) Token: 0x060058BA RID: 22714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C62")]
		public RunTimeScheduler.TrackedMissionData FirstToFocusMissionData
		{
			[Token(Token = "0x60058BA")]
			[Address(RVA = "0x4D23E0", Offset = "0x4D0DE0", VA = "0x1804D23E0")]
			set
			{
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x060058BB RID: 22715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C63")]
		private string FontName
		{
			[Token(Token = "0x60058BB")]
			[Address(RVA = "0x870AC0", Offset = "0x86F4C0", VA = "0x180870AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060058BC RID: 22716 RVA: 0x0001F350 File Offset: 0x0001D550
		[Token(Token = "0x17000C64")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x60058BC")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058BD")]
		[Address(RVA = "0x86EBE0", Offset = "0x86D5E0", VA = "0x18086EBE0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058BE")]
		[Address(RVA = "0x86EB00", Offset = "0x86D500", VA = "0x18086EB00", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058BF")]
		[Address(RVA = "0x86F8A0", Offset = "0x86E2A0", VA = "0x18086F8A0")]
		private void SwitchMode(RunTimeScheduler.MissionDataFillterType mode)
		{
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C0")]
		[Address(RVA = "0x86F190", Offset = "0x86DB90", VA = "0x18086F190", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060058C1 RID: 22721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C1")]
		[Address(RVA = "0x86F280", Offset = "0x86DC80", VA = "0x18086F280")]
		private void RefreshMissionElements(bool preserveOrder)
		{
		}

		// Token: 0x060058C2 RID: 22722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C2")]
		[Address(RVA = "0x8707F0", Offset = "0x86F1F0", VA = "0x1808707F0")]
		private void UpdateRightPanel(bool hasAnyMissionData)
		{
		}

		// Token: 0x060058C3 RID: 22723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C3")]
		[Address(RVA = "0x8702D0", Offset = "0x86ECD0", VA = "0x1808702D0")]
		private void UpdateMissionItemVisual([TupleElementNames(new string[] { "Key", "Value", "Count" })] ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int> missionData, UIElementCluster cluster)
		{
		}

		// Token: 0x060058C4 RID: 22724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C4")]
		[Address(RVA = "0x86F810", Offset = "0x86E210", VA = "0x18086F810")]
		private void RegNullInput(bool doReg)
		{
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C5")]
		[Address(RVA = "0x86EAC0", Offset = "0x86D4C0", VA = "0x18086EAC0")]
		private void OnCancelInvoked(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058C6")]
		[Address(RVA = "0x86E880", Offset = "0x86D280", VA = "0x18086E880")]
		private string FormatKeyData(string original)
		{
			return null;
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C7")]
		[Address(RVA = "0x86D370", Offset = "0x86BD70", VA = "0x18086D370")]
		private void DescribeMission(RunTimeScheduler.TrackedMissionData trackedMission, UIButtonSimple left, RunTimeScheduler.MissionStatus missionStatus, Action refreshMissionVisualHandle)
		{
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C8")]
		[Address(RVA = "0x86D070", Offset = "0x86BA70", VA = "0x18086D070", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60058C9")]
		[Address(RVA = "0x870850", Offset = "0x86F250", VA = "0x180870850")]
		public NoteBookMissionPannel()
		{
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60058D6")]
		[CompilerGenerated]
		internal static string <DescribeMission>g__GetFormated|56_22<T>(int current, int total) where T : NonTradableObjectBase
		{
			return null;
		}

		// Token: 0x04005338 RID: 21304
		[Token(Token = "0x4005338")]
		private const int START_LOOP_COUNT = 11;

		// Token: 0x04005339 RID: 21305
		[Token(Token = "0x4005339")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActionExecutionScheduler m_ActionExecutionScheduler;

		// Token: 0x0400533A RID: 21306
		[Token(Token = "0x400533A")]
		[FieldOffset(Offset = "0x80")]
		public GameObject missionObject;

		// Token: 0x0400533B RID: 21307
		[Token(Token = "0x400533B")]
		[FieldOffset(Offset = "0x88")]
		public GameObject conditionObject;

		// Token: 0x0400533C RID: 21308
		[Token(Token = "0x400533C")]
		[FieldOffset(Offset = "0x90")]
		public VerticalLayoutGroup MissionObjectField;

		// Token: 0x0400533D RID: 21309
		[Token(Token = "0x400533D")]
		[FieldOffset(Offset = "0x98")]
		public SubmissionPanel subPannelReference;

		// Token: 0x0400533E RID: 21310
		[Token(Token = "0x400533E")]
		[FieldOffset(Offset = "0xA0")]
		public CanvasGroup detailPannel;

		// Token: 0x0400533F RID: 21311
		[Token(Token = "0x400533F")]
		[FieldOffset(Offset = "0xA8")]
		public CanvasGroup nullPannel;

		// Token: 0x04005340 RID: 21312
		[Token(Token = "0x4005340")]
		[FieldOffset(Offset = "0xB0")]
		public CanvasGroup selected;

		// Token: 0x04005341 RID: 21313
		[Token(Token = "0x4005341")]
		[FieldOffset(Offset = "0xB8")]
		public CanvasGroup subSelected;

		// Token: 0x04005342 RID: 21314
		[Token(Token = "0x4005342")]
		[FieldOffset(Offset = "0xC0")]
		public UIButtonToggle[] fillters;

		// Token: 0x04005343 RID: 21315
		[Token(Token = "0x4005343")]
		[FieldOffset(Offset = "0xC8")]
		public RectTransform CacheTransform;

		// Token: 0x04005344 RID: 21316
		[Token(Token = "0x4005344")]
		[FieldOffset(Offset = "0xD0")]
		public AdpProgressIndicatorComponent progressIndicator;

		// Token: 0x04005345 RID: 21317
		[Token(Token = "0x4005345")]
		[FieldOffset(Offset = "0xD8")]
		public TextMeshProUGUI title;

		// Token: 0x04005346 RID: 21318
		[Token(Token = "0x4005346")]
		[FieldOffset(Offset = "0xE0")]
		public TextMeshProUGUI missionSenderData;

		// Token: 0x04005347 RID: 21319
		[Token(Token = "0x4005347")]
		[FieldOffset(Offset = "0xE8")]
		public TextMeshProUGUI missionReceiverAndTimeData;

		// Token: 0x04005348 RID: 21320
		[Token(Token = "0x4005348")]
		[FieldOffset(Offset = "0xF0")]
		public TextMeshProUGUI description;

		// Token: 0x04005349 RID: 21321
		[Token(Token = "0x4005349")]
		[FieldOffset(Offset = "0xF8")]
		public GameObject condition;

		// Token: 0x0400534A RID: 21322
		[Token(Token = "0x400534A")]
		[FieldOffset(Offset = "0x100")]
		public RectTransform conditionField;

		// Token: 0x0400534B RID: 21323
		[Token(Token = "0x400534B")]
		[FieldOffset(Offset = "0x108")]
		public GameObject reward;

		// Token: 0x0400534C RID: 21324
		[Token(Token = "0x400534C")]
		[FieldOffset(Offset = "0x110")]
		public GameObject rewardTitle;

		// Token: 0x0400534D RID: 21325
		[Token(Token = "0x400534D")]
		[FieldOffset(Offset = "0x118")]
		public RectTransform rewardField;

		// Token: 0x0400534E RID: 21326
		[Token(Token = "0x400534E")]
		[FieldOffset(Offset = "0x120")]
		public MultiLanguageTextMesh.MultiLanguageString fontName;

		// Token: 0x0400534F RID: 21327
		[Token(Token = "0x400534F")]
		[FieldOffset(Offset = "0x128")]
		public Color32 trackingMissionColor;

		// Token: 0x04005350 RID: 21328
		[Token(Token = "0x4005350")]
		[FieldOffset(Offset = "0x12C")]
		public Color32 fulFilledMissionColor;

		// Token: 0x04005351 RID: 21329
		[Token(Token = "0x4005351")]
		[FieldOffset(Offset = "0x130")]
		public Color32 finishedMissionColor;

		// Token: 0x04005352 RID: 21330
		[Token(Token = "0x4005352")]
		[FieldOffset(Offset = "0x138")]
		[TupleElementNames(new string[] { "Key", "Value", "Count" })]
		private readonly List<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>> m_CurrentAllMissionData;

		// Token: 0x04005353 RID: 21331
		[Token(Token = "0x4005353")]
		[FieldOffset(Offset = "0x140")]
		[TupleElementNames(new string[] { "Key", "Value", "Count" })]
		private readonly List<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>> m_LastAllMissionData;

		// Token: 0x04005354 RID: 21332
		[Token(Token = "0x4005354")]
		[FieldOffset(Offset = "0x148")]
		private List<UIButtonSimple> m_AllConditionButton;

		// Token: 0x04005355 RID: 21333
		[Token(Token = "0x4005355")]
		[FieldOffset(Offset = "0x150")]
		private List<GameObject> m_AllConditionInstances;

		// Token: 0x04005356 RID: 21334
		[Token(Token = "0x4005356")]
		[FieldOffset(Offset = "0x158")]
		private List<GameObject> m_AllMissionInstances;

		// Token: 0x04005357 RID: 21335
		[Token(Token = "0x4005357")]
		[FieldOffset(Offset = "0x160")]
		private List<GameObject> m_AllRewardInstances;

		// Token: 0x04005358 RID: 21336
		[Token(Token = "0x4005358")]
		[FieldOffset(Offset = "0x168")]
		private RunTimeScheduler.TrackedMissionData m_FirstToFocusMissionData;

		// Token: 0x04005359 RID: 21337
		[Token(Token = "0x4005359")]
		[FieldOffset(Offset = "0x170")]
		private RunTimeScheduler.TrackedMissionData m_LastTrackingMissionData;

		// Token: 0x0400535A RID: 21338
		[Token(Token = "0x400535A")]
		[FieldOffset(Offset = "0x178")]
		private RunTimeScheduler.MissionDataFillterType? m_MissionDataFilterType;

		// Token: 0x0400535B RID: 21339
		[Token(Token = "0x400535B")]
		[FieldOffset(Offset = "0x180")]
		[TupleElementNames(new string[] { "Key", "Value", "Count" })]
		private StaticVirtualScrollListUILogicalGroupT<ValueTuple<RunTimeScheduler.TrackedMissionData, RunTimeScheduler.MissionStatus, int>, UIElementCluster, UIButtonSimple> m_MissionGroup;
	}
}
