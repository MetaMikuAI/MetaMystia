using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using GameData.RunTime.Common;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI
{
	// Token: 0x02000266 RID: 614
	[Token(Token = "0x2000266")]
	[GenerateCleanupMethod]
	public class DaySceneChatSelectionPannel : UIPanel
	{
		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000E2B RID: 3627 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000E2C RID: 3628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700016E")]
		[CleanupIgnore]
		public DaySceneChatSelectionPannel.BaseOpenContext OpenContext
		{
			[Token(Token = "0x6000E2B")]
			[Address(RVA = "0x440500", Offset = "0x43EF00", VA = "0x180440500")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000E2C")]
			[Address(RVA = "0x48AAA0", Offset = "0x4894A0", VA = "0x18048AAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E2D")]
		[Address(RVA = "0x833B50", Offset = "0x832550", VA = "0x180833B50", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E2E")]
		[Address(RVA = "0x9000B0", Offset = "0x8FEAB0", VA = "0x1809000B0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2F")]
		[Address(RVA = "0x8FF5B0", Offset = "0x8FDFB0", VA = "0x1808FF5B0")]
		private IEnumerable<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback> GetConfigurationSet(string currentCharacterLabel, DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] prependSelections, DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] appendSelections, bool shouldTriggerEvent, Action<Action> onWillExecuteDayEndEventCallback)
		{
			return null;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E30")]
		[Address(RVA = "0x8FECE0", Offset = "0x8FD6E0", VA = "0x1808FECE0")]
		private void Chat(string characterLabel, bool shouldTriggerEvent)
		{
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E31")]
		[Address(RVA = "0x8FFD90", Offset = "0x8FE790", VA = "0x1808FFD90")]
		private void Invite(string characterLabel, int currentKizunaLevel, Action<Action> onWillExecuteDayEndEventCallback)
		{
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E32")]
		[Address(RVA = "0x8FF3C0", Offset = "0x8FDDC0", VA = "0x1808FF3C0")]
		private IEnumerable<int> FillterCollection(IEnumerable<int> hateTagCollection, IEnumerable<SpecialGuest.WeightedTag> likeTagCollection, [TupleElementNames(new string[] { "Id", "Tags", "product" })] IEnumerable<ValueTuple<int, int[], IEnumerable<int>>> allProductTags)
		{
			return null;
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E33")]
		[Address(RVA = "0x901B40", Offset = "0x900540", VA = "0x180901B40")]
		private IEnumerable<int> SelectFromData(IEnumerable<int> data, Func<int, int> getLevelCallback)
		{
			return null;
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E34")]
		[Address(RVA = "0x9014D0", Offset = "0x8FFED0", VA = "0x1809014D0")]
		private void RequestIngredient(string characterLabel, int currentKizunaLevel, Action<Action> onWillExecuteDayEndEventCallback)
		{
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E35")]
		[Address(RVA = "0x900F90", Offset = "0x8FF990", VA = "0x180900F90")]
		private void RequestBeverages(string characterLabel, int currentKizunaLevel, Action<Action> onWillExecuteDayEndEventCallback)
		{
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E36")]
		[Address(RVA = "0x8FEFA0", Offset = "0x8FD9A0", VA = "0x1808FEFA0")]
		private void Commision(string characterLabel, string commisionLabel, Action<Action> onWillExecuteDayEndEventCallback)
		{
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00005EB0 File Offset: 0x000040B0
		[Token(Token = "0x6000E37")]
		[Address(RVA = "0x8FFC50", Offset = "0x8FE650", VA = "0x1808FFC50")]
		public static bool InviteSpecGuest(SpecialGuest specialGuest, int kizunaLevel, out DialogPackage selectedDialogue)
		{
			return default(bool);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x8FF170", Offset = "0x8FDB70", VA = "0x1808FF170")]
		public static void CommitSpecGuest(SpecialGuest specialGuest, string commisionLabel)
		{
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E39")]
		[Address(RVA = "0x900050", Offset = "0x8FEA50", VA = "0x180900050", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x900F10", Offset = "0x8FF910", VA = "0x180900F10")]
		public void RefreshPannel()
		{
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E3B")]
		private void OpenInternal<TInteractData, TGetSelectionConfigurationCallback>(TGetSelectionConfigurationCallback[] selections, TInteractData interactData, [TupleElementNames(new string[] { "availability", "Title", "OnInteract" })] Func<TInteractData, TGetSelectionConfigurationCallback, ValueTuple<bool, string, Action>> getConfigCallback, Action endButtonAction, int indexToSelect = -1) where TInteractData : DaySceneChatSelectionPannel.BaseInteractData where TGetSelectionConfigurationCallback : Delegate
		{
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x8FEF00", Offset = "0x8FD900", VA = "0x1808FEF00", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0x901F50", Offset = "0x900950", VA = "0x180901F50")]
		public DaySceneChatSelectionPannel()
		{
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x00005EC8 File Offset: 0x000040C8
		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0x901C60", Offset = "0x900660", VA = "0x180901C60")]
		[CompilerGenerated]
		internal static ValueTuple<bool, string, Action> <OnPanelOpen>g__GetGeneralConfigCallback|16_3(DaySceneChatSelectionPannel.BaseInteractData interactData, DaySceneChatSelectionPannel.GetSelectionConfigurationCallback getSelectionConfigCallback)
		{
			return default(ValueTuple<bool, string, Action>);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000E3F")]
		[Address(RVA = "0x901E70", Offset = "0x900870", VA = "0x180901E70")]
		[CompilerGenerated]
		private void <OnPanelOpen>g__NormalEndButtonConfig|16_5(DaySceneChatSelectionPannel.NormalNPCInteractData normalInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00005EE0 File Offset: 0x000040E0
		[Token(Token = "0x6000E40")]
		[Address(RVA = "0x901D10", Offset = "0x900710", VA = "0x180901D10")]
		[CompilerGenerated]
		internal static ValueTuple<bool, string, Action> <OnPanelOpen>g__GetNormalConfigCallback|16_6(DaySceneChatSelectionPannel.NormalNPCInteractData normalInteractData, DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback getSelectionConfigCallback)
		{
			return default(ValueTuple<bool, string, Action>);
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00005EF8 File Offset: 0x000040F8
		[Token(Token = "0x6000E41")]
		[Address(RVA = "0x901DC0", Offset = "0x9007C0", VA = "0x180901DC0")]
		[CompilerGenerated]
		internal static ValueTuple<bool, string, Action> <OnPanelOpen>g__GetSpecialConfigCallback|16_8(DaySceneChatSelectionPannel.SpecialNPCInteractData specialInteractData, DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback getSelectionConfigCallback)
		{
			return default(ValueTuple<bool, string, Action>);
		}

		// Token: 0x04000D1E RID: 3358
		[Token(Token = "0x4000D1E")]
		private const int ACTION_CONSUMPTION = 1;

		// Token: 0x04000D1F RID: 3359
		[Token(Token = "0x4000D1F")]
		private const int SOFT_DRINK_TAG_ID = -1;

		// Token: 0x04000D20 RID: 3360
		[Token(Token = "0x4000D20")]
		private const int CHAT_KIZUNA_GENERATION_AMOUNT = 1;

		// Token: 0x04000D21 RID: 3361
		[Token(Token = "0x4000D21")]
		[FieldOffset(Offset = "0x70")]
		public GameObject chatSelectionParent;

		// Token: 0x04000D22 RID: 3362
		[Token(Token = "0x4000D22")]
		[FieldOffset(Offset = "0x78")]
		public RectTransform selectionField;

		// Token: 0x04000D23 RID: 3363
		[Token(Token = "0x4000D23")]
		[FieldOffset(Offset = "0x80")]
		public AdpScrollListFixedComponent scroller;

		// Token: 0x04000D24 RID: 3364
		[Token(Token = "0x4000D24")]
		[FieldOffset(Offset = "0x88")]
		private readonly List<GameObject> allChatSelectionElements;

		// Token: 0x04000D25 RID: 3365
		[Token(Token = "0x4000D25")]
		[FieldOffset(Offset = "0x90")]
		private readonly UILogicalGroup m_SelectionGroup;

		// Token: 0x02000267 RID: 615
		// (Invoke) Token: 0x06000E43 RID: 3651
		[Token(Token = "0x2000267")]
		public delegate void GetNormalNPCSelectionConfigurationCallback(DaySceneChatSelectionPannel.NormalNPCInteractData normalNPCInteractData, out string title, out bool availability, out Action onInteract);

		// Token: 0x02000268 RID: 616
		// (Invoke) Token: 0x06000E47 RID: 3655
		[Token(Token = "0x2000268")]
		public delegate void GetSelectionConfigurationCallback(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract);

		// Token: 0x02000269 RID: 617
		// (Invoke) Token: 0x06000E4B RID: 3659
		[Token(Token = "0x2000269")]
		public delegate void GetSpecialNPCSelectionConfigurationCallback(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract);

		// Token: 0x0200026A RID: 618
		[Token(Token = "0x200026A")]
		public class SpecialNPCInteractData : DaySceneChatSelectionPannel.NormalNPCInteractData
		{
			// Token: 0x06000E4E RID: 3662 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E4E")]
			[Address(RVA = "0x90B690", Offset = "0x90A090", VA = "0x18090B690")]
			public SpecialNPCInteractData(string characterLabel, int npcKizunaLevel, TrackedMerchant merchantData, StatusTracker statusTracker, Func<string, string> getPhraseCallback, Action closePannelCallback, Action refreshSelectionCallback)
			{
			}

			// Token: 0x04000D27 RID: 3367
			[Token(Token = "0x4000D27")]
			[FieldOffset(Offset = "0x38")]
			public readonly int npcKizunaLevel;

			// Token: 0x04000D28 RID: 3368
			[Token(Token = "0x4000D28")]
			[FieldOffset(Offset = "0x40")]
			public readonly StatusTracker statusTracker;
		}

		// Token: 0x0200026B RID: 619
		[Token(Token = "0x200026B")]
		public class NormalNPCInteractData : DaySceneChatSelectionPannel.BaseInteractData
		{
			// Token: 0x06000E4F RID: 3663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E4F")]
			[Address(RVA = "0x90B590", Offset = "0x909F90", VA = "0x18090B590")]
			public NormalNPCInteractData(string characterLabel, TrackedMerchant merchantData, Func<string, string> getPhraseCallback, Action closePannelCallback, Action refreshSelectionCallback)
			{
			}

			// Token: 0x04000D29 RID: 3369
			[Token(Token = "0x4000D29")]
			[FieldOffset(Offset = "0x28")]
			public readonly string characterLabel;

			// Token: 0x04000D2A RID: 3370
			[Token(Token = "0x4000D2A")]
			[FieldOffset(Offset = "0x30")]
			public readonly TrackedMerchant merchantData;
		}

		// Token: 0x0200026C RID: 620
		[Token(Token = "0x200026C")]
		public class BaseInteractData
		{
			// Token: 0x06000E50 RID: 3664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E50")]
			[Address(RVA = "0x8FEA90", Offset = "0x8FD490", VA = "0x1808FEA90")]
			public BaseInteractData(Func<string, string> getPhraseCallback, Action closePannelCallback, Action refreshSelectionCallback)
			{
			}

			// Token: 0x04000D2B RID: 3371
			[Token(Token = "0x4000D2B")]
			[FieldOffset(Offset = "0x10")]
			public readonly Action closeChatSelectionPannelCallback;

			// Token: 0x04000D2C RID: 3372
			[Token(Token = "0x4000D2C")]
			[FieldOffset(Offset = "0x18")]
			public readonly Func<string, string> getPhraseCallback;

			// Token: 0x04000D2D RID: 3373
			[Token(Token = "0x4000D2D")]
			[FieldOffset(Offset = "0x20")]
			public Action refreshSelectionCallback;
		}

		// Token: 0x0200026D RID: 621
		[Token(Token = "0x200026D")]
		public abstract class BaseOpenContext
		{
			// Token: 0x1700016F RID: 367
			// (get) Token: 0x06000E51 RID: 3665
			[Token(Token = "0x1700016F")]
			public abstract DaySceneChatSelectionPannel.BaseOpenContext.OpenContextType ContextType
			{
				[Token(Token = "0x6000E51")]
				get;
			}

			// Token: 0x06000E52 RID: 3666 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E52")]
			[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
			protected BaseOpenContext()
			{
			}

			// Token: 0x0200026E RID: 622
			[Token(Token = "0x200026E")]
			public enum OpenContextType
			{
				// Token: 0x04000D2F RID: 3375
				[Token(Token = "0x4000D2F")]
				General,
				// Token: 0x04000D30 RID: 3376
				[Token(Token = "0x4000D30")]
				Normal,
				// Token: 0x04000D31 RID: 3377
				[Token(Token = "0x4000D31")]
				Special
			}
		}

		// Token: 0x0200026F RID: 623
		[Token(Token = "0x200026F")]
		public class SpecialGuestOpenContext : DaySceneChatSelectionPannel.BaseOpenContext
		{
			// Token: 0x06000E53 RID: 3667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E53")]
			[Address(RVA = "0x90B630", Offset = "0x90A030", VA = "0x18090B630")]
			public SpecialGuestOpenContext(string characterLabel, bool shouldTriggerEvent, Action<Action> onWillExecuteDayEndEventCallback)
			{
			}

			// Token: 0x17000170 RID: 368
			// (get) Token: 0x06000E54 RID: 3668 RVA: 0x00005F10 File Offset: 0x00004110
			[Token(Token = "0x17000170")]
			public override DaySceneChatSelectionPannel.BaseOpenContext.OpenContextType ContextType
			{
				[Token(Token = "0x6000E54")]
				[Address(RVA = "0x7B2C90", Offset = "0x7B1690", VA = "0x1807B2C90", Slot = "4")]
				get
				{
					return DaySceneChatSelectionPannel.BaseOpenContext.OpenContextType.General;
				}
			}

			// Token: 0x04000D32 RID: 3378
			[Token(Token = "0x4000D32")]
			[FieldOffset(Offset = "0x10")]
			public readonly string CharacterLabel;

			// Token: 0x04000D33 RID: 3379
			[Token(Token = "0x4000D33")]
			[FieldOffset(Offset = "0x18")]
			public readonly Action<Action> OnWillExecuteDayEndEventCallback;

			// Token: 0x04000D34 RID: 3380
			[Token(Token = "0x4000D34")]
			[FieldOffset(Offset = "0x20")]
			public readonly bool ShouldTriggerEvent;
		}

		// Token: 0x02000270 RID: 624
		[Token(Token = "0x2000270")]
		public class NormalGuestOpenContext : DaySceneChatSelectionPannel.BaseOpenContext
		{
			// Token: 0x06000E55 RID: 3669 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E55")]
			[Address(RVA = "0x90B520", Offset = "0x909F20", VA = "0x18090B520")]
			public NormalGuestOpenContext(DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback[] selections, string characterLabel, TrackedMerchant merchantData)
			{
			}

			// Token: 0x17000171 RID: 369
			// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00005F28 File Offset: 0x00004128
			[Token(Token = "0x17000171")]
			public override DaySceneChatSelectionPannel.BaseOpenContext.OpenContextType ContextType
			{
				[Token(Token = "0x6000E56")]
				[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "4")]
				get
				{
					return DaySceneChatSelectionPannel.BaseOpenContext.OpenContextType.General;
				}
			}

			// Token: 0x04000D35 RID: 3381
			[Token(Token = "0x4000D35")]
			[FieldOffset(Offset = "0x10")]
			public readonly string CharacterLabel;

			// Token: 0x04000D36 RID: 3382
			[Token(Token = "0x4000D36")]
			[FieldOffset(Offset = "0x18")]
			public readonly TrackedMerchant MerchantData;

			// Token: 0x04000D37 RID: 3383
			[Token(Token = "0x4000D37")]
			[FieldOffset(Offset = "0x20")]
			public readonly DaySceneChatSelectionPannel.GetNormalNPCSelectionConfigurationCallback[] Selections;
		}

		// Token: 0x02000271 RID: 625
		[Token(Token = "0x2000271")]
		public class GeneralOpenContext : DaySceneChatSelectionPannel.BaseOpenContext
		{
			// Token: 0x06000E57 RID: 3671 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000E57")]
			[Address(RVA = "0x90B100", Offset = "0x909B00", VA = "0x18090B100")]
			public GeneralOpenContext(DaySceneChatSelectionPannel.GetSelectionConfigurationCallback[] selections, string endButtonTitleKey, int indexToSelect, DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback onEndButtonSubmitCallback)
			{
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00005F40 File Offset: 0x00004140
			[Token(Token = "0x17000172")]
			public override DaySceneChatSelectionPannel.BaseOpenContext.OpenContextType ContextType
			{
				[Token(Token = "0x6000E58")]
				[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "4")]
				get
				{
					return DaySceneChatSelectionPannel.BaseOpenContext.OpenContextType.General;
				}
			}

			// Token: 0x04000D38 RID: 3384
			[Token(Token = "0x4000D38")]
			[FieldOffset(Offset = "0x10")]
			public readonly string EndButtonTitleKey;

			// Token: 0x04000D39 RID: 3385
			[Token(Token = "0x4000D39")]
			[FieldOffset(Offset = "0x18")]
			public readonly int IndexToSelect;

			// Token: 0x04000D3A RID: 3386
			[Token(Token = "0x4000D3A")]
			[FieldOffset(Offset = "0x20")]
			public readonly DaySceneChatSelectionPannel.GeneralOpenContext.EndButtonCallback OnEndButtonSubmitCallback;

			// Token: 0x04000D3B RID: 3387
			[Token(Token = "0x4000D3B")]
			[FieldOffset(Offset = "0x28")]
			public readonly DaySceneChatSelectionPannel.GetSelectionConfigurationCallback[] Selections;

			// Token: 0x02000272 RID: 626
			// (Invoke) Token: 0x06000E5A RID: 3674
			[Token(Token = "0x2000272")]
			public delegate void EndButtonCallback(Action closePannelCallback);
		}
	}
}
