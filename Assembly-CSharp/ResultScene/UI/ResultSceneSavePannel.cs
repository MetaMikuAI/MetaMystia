using System;
using System.Collections.Generic;
using Common.UI;
using Common.UI.EscapeUtility;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection.Async;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Utils;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace ResultScene.UI
{
	// Token: 0x020000A3 RID: 163
	[Token(Token = "0x20000A3")]
	[GenerateCleanupMethod]
	public class ResultSceneSavePannel : AsyncUIPanel
	{
		// Token: 0x06000367 RID: 871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x42A110", Offset = "0x428B10", VA = "0x18042A110")]
		private void OpenConfirmPanel(string panelTitle, Action onYes)
		{
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x429D40", Offset = "0x428740", VA = "0x180429D40", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x42A080", Offset = "0x428A80", VA = "0x18042A080", Slot = "32")]
		protected override UniTaskVoid OnPanelOpenAsync()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x429CB0", Offset = "0x4286B0", VA = "0x180429CB0")]
		private UniTaskVoid CreateNewSave()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x42A290", Offset = "0x428C90", VA = "0x18042A290")]
		private UniTaskVoid OverrideSave(int index)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x42A330", Offset = "0x428D30", VA = "0x18042A330")]
		private UniTask SavePlayerDataCoreAsync(int writeIndex)
		{
			return default(UniTask);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x42A440", Offset = "0x428E40", VA = "0x18042A440")]
		private UniTask SavePlayerDataImpl(int writeIndex)
		{
			return default(UniTask);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x42A510", Offset = "0x428F10", VA = "0x18042A510")]
		private UniTask SetActiveAsync(CanvasGroup canvasGroup)
		{
			return default(UniTask);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x42A5E0", Offset = "0x428FE0", VA = "0x18042A5E0")]
		private UniTask SetInActiveAsync(CanvasGroup canvasGroup)
		{
			return default(UniTask);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x429BB0", Offset = "0x4285B0", VA = "0x180429BB0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x42AD10", Offset = "0x429710", VA = "0x18042AD10")]
		public ResultSceneSavePannel()
		{
		}

		// Token: 0x04000373 RID: 883
		[Token(Token = "0x4000373")]
		[FieldOffset(Offset = "0x70")]
		private bool m_BlockSubPanelCommand;

		// Token: 0x04000374 RID: 884
		[Token(Token = "0x4000374")]
		public const int MAX_SAVE_COUNT = 15;

		// Token: 0x04000375 RID: 885
		[Token(Token = "0x4000375")]
		[FieldOffset(Offset = "0x78")]
		public GameObject SaveParent;

		// Token: 0x04000376 RID: 886
		[Token(Token = "0x4000376")]
		[FieldOffset(Offset = "0x80")]
		public GridLayoutGroup ElementField;

		// Token: 0x04000377 RID: 887
		[Token(Token = "0x4000377")]
		[FieldOffset(Offset = "0x88")]
		public AdpProgressIndicatorComponent Scroller;

		// Token: 0x04000378 RID: 888
		[Token(Token = "0x4000378")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private CanvasGroup m_SyncingIndicator;

		// Token: 0x04000379 RID: 889
		[Token(Token = "0x4000379")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CanvasGroup m_SyncFailedIndicator;

		// Token: 0x0400037A RID: 890
		[Token(Token = "0x400037A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float m_SyncFailedIndicatorDuration;

		// Token: 0x0400037B RID: 891
		[Token(Token = "0x400037B")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GenericErrorPanel m_GenericErrorPanel;

		// Token: 0x0400037C RID: 892
		[Token(Token = "0x400037C")]
		[FieldOffset(Offset = "0xB0")]
		public EscLoadPannelSubSubPannel SubPannel;

		// Token: 0x0400037D RID: 893
		[Token(Token = "0x400037D")]
		[FieldOffset(Offset = "0xB8")]
		private readonly List<KeyValuePair<int, LoadedSaveDataInfo>> m_Data;

		// Token: 0x0400037E RID: 894
		[Token(Token = "0x400037E")]
		[FieldOffset(Offset = "0xC0")]
		public StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<int, LoadedSaveDataInfo>, UIElementCluster, UIButtonSimple> m_Group;
	}
}
