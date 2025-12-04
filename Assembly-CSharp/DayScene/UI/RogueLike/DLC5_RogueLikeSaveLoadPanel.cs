using System;
using System.Collections.Generic;
using Common.UI;
using Common.UI.EscapeUtility;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200040A RID: 1034
	[Token(Token = "0x200040A")]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeSaveLoadPanel : UIPanelParam<DLC5_RogueLikeSaveLoadPanel.OpenContext, Nullable<int>>
	{
		// Token: 0x06001724 RID: 5924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001724")]
		[Address(RVA = "0x4630E0", Offset = "0x461AE0", VA = "0x1804630E0", Slot = "22")]
		protected sealed override void OnPanelInitialize()
		{
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001725")]
		[Address(RVA = "0x463450", Offset = "0x461E50", VA = "0x180463450", Slot = "32")]
		protected sealed override void OnPanelOpen(DLC5_RogueLikeSaveLoadPanel.OpenContext openParam)
		{
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001726")]
		[Address(RVA = "0x463570", Offset = "0x461F70", VA = "0x180463570")]
		private void RefreshSaveList()
		{
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001727")]
		[Address(RVA = "0x462560", Offset = "0x460F60", VA = "0x180462560")]
		private void OnEnabledInternal(KeyValuePair<int, LoadedRogueLikeSaveDataInfo> valuePair, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00008AF0 File Offset: 0x00006CF0
		[Token(Token = "0x6001728")]
		[Address(RVA = "0x464180", Offset = "0x462B80", VA = "0x180464180")]
		private UniTask TryOpenSubConfirmPanel(int? index, string langKey, Vector3? position, bool invalidSaveFile = false)
		{
			return default(UniTask);
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x00008B08 File Offset: 0x00006D08
		[Token(Token = "0x6001729")]
		[Address(RVA = "0x4640B0", Offset = "0x462AB0", VA = "0x1804640B0")]
		private UniTask TryClosePanel(int? index)
		{
			return default(UniTask);
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x00008B20 File Offset: 0x00006D20
		[Token(Token = "0x600172A")]
		[Address(RVA = "0x462330", Offset = "0x460D30", VA = "0x180462330")]
		private UniTask CannotLoadAsync(IReadOnlyList<string> activeArray, IReadOnlyList<string> inSaveArray)
		{
			return default(UniTask);
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00008B38 File Offset: 0x00006D38
		[Token(Token = "0x600172B")]
		[Address(RVA = "0x463F30", Offset = "0x462930", VA = "0x180463F30")]
		private UniTask SetActiveAsync(CanvasGroup canvasGroup)
		{
			return default(UniTask);
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00008B50 File Offset: 0x00006D50
		[Token(Token = "0x600172C")]
		[Address(RVA = "0x464000", Offset = "0x462A00", VA = "0x180464000")]
		private UniTask SetInActiveAsync(CanvasGroup canvasGroup)
		{
			return default(UniTask);
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600172D")]
		[Address(RVA = "0x462430", Offset = "0x460E30", VA = "0x180462430", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600172E")]
		[Address(RVA = "0x464400", Offset = "0x462E00", VA = "0x180464400")]
		public DLC5_RogueLikeSaveLoadPanel()
		{
		}

		// Token: 0x04001580 RID: 5504
		[Token(Token = "0x4001580")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private GridLayoutGroup m_Grid;

		// Token: 0x04001581 RID: 5505
		[Token(Token = "0x4001581")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private UIElementCluster m_Element;

		// Token: 0x04001582 RID: 5506
		[Token(Token = "0x4001582")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_ProgressIndicatorComponent;

		// Token: 0x04001583 RID: 5507
		[Token(Token = "0x4001583")]
		[FieldOffset(Offset = "0x1C0")]
		[SerializeField]
		private EscLoadPannelSubPannel m_ConfirmPanel;

		// Token: 0x04001584 RID: 5508
		[Token(Token = "0x4001584")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private EscLoadPannelSubSubPannel m_ConfirmSubPanel;

		// Token: 0x04001585 RID: 5509
		[Token(Token = "0x4001585")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private DialogBoxPannel m_MessagePanel;

		// Token: 0x04001586 RID: 5510
		[Token(Token = "0x4001586")]
		[FieldOffset(Offset = "0x1D8")]
		[SerializeField]
		private CanvasGroup m_SyncingIndicator;

		// Token: 0x04001587 RID: 5511
		[Token(Token = "0x4001587")]
		[FieldOffset(Offset = "0x1E0")]
		[SerializeField]
		private CanvasGroup m_SyncFailedIndicator;

		// Token: 0x04001588 RID: 5512
		[Token(Token = "0x4001588")]
		[FieldOffset(Offset = "0x1E8")]
		[SerializeField]
		private float m_SyncFailedIndicatorDuration;

		// Token: 0x04001589 RID: 5513
		[Token(Token = "0x4001589")]
		[FieldOffset(Offset = "0x1F0")]
		private StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<int, LoadedRogueLikeSaveDataInfo>, UIElementCluster, UIButtonSimple> m_Group;

		// Token: 0x0400158A RID: 5514
		[Token(Token = "0x400158A")]
		[FieldOffset(Offset = "0x1F8")]
		private readonly List<KeyValuePair<int, LoadedRogueLikeSaveDataInfo>> m_List;

		// Token: 0x0400158B RID: 5515
		[Token(Token = "0x400158B")]
		[FieldOffset(Offset = "0x200")]
		private int m_MaxRounds;

		// Token: 0x0400158C RID: 5516
		[Token(Token = "0x400158C")]
		private const int MAX_SAVE_COUNT = 30;

		// Token: 0x0400158D RID: 5517
		[Token(Token = "0x400158D")]
		[FieldOffset(Offset = "0x208")]
		private Func<UniTask> m_OnLoadCallback;

		// Token: 0x0200040B RID: 1035
		[Token(Token = "0x200040B")]
		public readonly struct OpenContext
		{
			// Token: 0x06001731 RID: 5937 RVA: 0x00008B80 File Offset: 0x00006D80
			[Token(Token = "0x6001731")]
			[Address(RVA = "0x46ABE0", Offset = "0x4695E0", VA = "0x18046ABE0")]
			public static DLC5_RogueLikeSaveLoadPanel.OpenContext CreateSave(int maxRounds, RogueLikeSaveData rogueLikeSaveData, bool activeDeleteButton)
			{
				return default(DLC5_RogueLikeSaveLoadPanel.OpenContext);
			}

			// Token: 0x06001732 RID: 5938 RVA: 0x00008B98 File Offset: 0x00006D98
			[Token(Token = "0x6001732")]
			[Address(RVA = "0x46AAB0", Offset = "0x4694B0", VA = "0x18046AAB0")]
			public static DLC5_RogueLikeSaveLoadPanel.OpenContext CreateLoad(int maxRounds, bool activeDeleteButton)
			{
				return default(DLC5_RogueLikeSaveLoadPanel.OpenContext);
			}

			// Token: 0x06001733 RID: 5939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001733")]
			[Address(RVA = "0x46AF30", Offset = "0x469930", VA = "0x18046AF30")]
			private OpenContext(int maxRounds, string createNewKey, string giveUpKey, string overrideKey, bool appendNull, bool ignoreInvalid, RogueLikeSaveData? saveData, bool activeDeleteButton)
			{
			}

			// Token: 0x0400158E RID: 5518
			[Token(Token = "0x400158E")]
			[FieldOffset(Offset = "0x0")]
			public readonly int MaxRounds;

			// Token: 0x0400158F RID: 5519
			[Token(Token = "0x400158F")]
			[FieldOffset(Offset = "0x8")]
			public readonly string CreateNewKey;

			// Token: 0x04001590 RID: 5520
			[Token(Token = "0x4001590")]
			[FieldOffset(Offset = "0x10")]
			public readonly string GiveUpKey;

			// Token: 0x04001591 RID: 5521
			[Token(Token = "0x4001591")]
			[FieldOffset(Offset = "0x18")]
			public readonly string OverrideKey;

			// Token: 0x04001592 RID: 5522
			[Token(Token = "0x4001592")]
			[FieldOffset(Offset = "0x20")]
			public readonly bool AppendNull;

			// Token: 0x04001593 RID: 5523
			[Token(Token = "0x4001593")]
			[FieldOffset(Offset = "0x21")]
			public readonly bool IgnoreInvalid;

			// Token: 0x04001594 RID: 5524
			[Token(Token = "0x4001594")]
			[FieldOffset(Offset = "0x28")]
			public readonly RogueLikeSaveData? SaveData;

			// Token: 0x04001595 RID: 5525
			[Token(Token = "0x4001595")]
			[FieldOffset(Offset = "0x128")]
			public readonly bool ActiveDeleteButton;
		}
	}
}
