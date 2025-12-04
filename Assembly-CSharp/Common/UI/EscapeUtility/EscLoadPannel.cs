using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection.Async;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.RunTime.Common;
using GameData.Utils;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.EscapeUtility
{
	// Token: 0x02000F47 RID: 3911
	[Token(Token = "0x2000F47")]
	[GenerateCleanupMethod]
	public class EscLoadPannel : AsyncUISubPanel<EscMainPannel>
	{
		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06005C10 RID: 23568 RVA: 0x00020148 File Offset: 0x0001E348
		[Token(Token = "0x17000CF6")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6005C10")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005C11 RID: 23569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C11")]
		[Address(RVA = "0x886520", Offset = "0x884F20", VA = "0x180886520", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005C12 RID: 23570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C12")]
		[Address(RVA = "0x8869D0", Offset = "0x8853D0", VA = "0x1808869D0")]
		private void OnSecondaryInput(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x06005C13 RID: 23571 RVA: 0x00020160 File Offset: 0x0001E360
		[Token(Token = "0x6005C13")]
		[Address(RVA = "0x885AD0", Offset = "0x8844D0", VA = "0x180885AD0", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06005C14 RID: 23572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C14")]
		[Address(RVA = "0x885890", Offset = "0x884290", VA = "0x180885890")]
		public static void AlertSaveFileHasChanged()
		{
		}

		// Token: 0x06005C15 RID: 23573 RVA: 0x00020178 File Offset: 0x0001E378
		[Token(Token = "0x6005C15")]
		[Address(RVA = "0x886940", Offset = "0x885340", VA = "0x180886940", Slot = "33")]
		protected override UniTaskVoid OnPanelOpenAsync()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06005C16 RID: 23574 RVA: 0x00020190 File Offset: 0x0001E390
		[Token(Token = "0x6005C16")]
		[Address(RVA = "0x886A40", Offset = "0x885440", VA = "0x180886A40")]
		private UniTask RefreshPanel(bool clearInternalCache)
		{
			return default(UniTask);
		}

		// Token: 0x06005C17 RID: 23575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C17")]
		[Address(RVA = "0x8864C0", Offset = "0x884EC0", VA = "0x1808864C0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06005C18 RID: 23576 RVA: 0x000201A8 File Offset: 0x0001E3A8
		[Token(Token = "0x6005C18")]
		[Address(RVA = "0x886B10", Offset = "0x885510", VA = "0x180886B10")]
		private UniTask RefreshSaveElementsAsync(bool clearInternalCache)
		{
			return default(UniTask);
		}

		// Token: 0x06005C19 RID: 23577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C19")]
		[Address(RVA = "0x885AF0", Offset = "0x8844F0", VA = "0x180885AF0")]
		public static void InitializeSaveElementVisual(UIElementCluster uiElement, KeyValuePair<int, LoadedSaveDataInfo> data, bool isTestFlight)
		{
		}

		// Token: 0x06005C1A RID: 23578 RVA: 0x000201C0 File Offset: 0x0001E3C0
		[Token(Token = "0x6005C1A")]
		[Address(RVA = "0x886360", Offset = "0x884D60", VA = "0x180886360")]
		private UniTaskVoid OnElementPressed(KeyValuePair<int, PlayerSaveFile> operatingSave, Vector3 elementPosition)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06005C1B RID: 23579 RVA: 0x000201D8 File Offset: 0x0001E3D8
		[Token(Token = "0x6005C1B")]
		[Address(RVA = "0x8858D0", Offset = "0x8842D0", VA = "0x1808858D0")]
		private UniTask CannotLoadAsync(IReadOnlyList<string> activeArray, IReadOnlyList<string> inSaveArray)
		{
			return default(UniTask);
		}

		// Token: 0x06005C1C RID: 23580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1C")]
		[Address(RVA = "0x8859D0", Offset = "0x8843D0", VA = "0x1808859D0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005C1D RID: 23581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C1D")]
		[Address(RVA = "0x886FD0", Offset = "0x8859D0", VA = "0x180886FD0")]
		public EscLoadPannel()
		{
		}

		// Token: 0x04005546 RID: 21830
		[Token(Token = "0x4005546")]
		[FieldOffset(Offset = "0x0")]
		private static bool m_FirstOpen;

		// Token: 0x04005547 RID: 21831
		[Token(Token = "0x4005547")]
		[FieldOffset(Offset = "0x78")]
		public GameObject SaveParent;

		// Token: 0x04005548 RID: 21832
		[Token(Token = "0x4005548")]
		[FieldOffset(Offset = "0x80")]
		public GridLayoutGroup ElementField;

		// Token: 0x04005549 RID: 21833
		[Token(Token = "0x4005549")]
		[FieldOffset(Offset = "0x88")]
		public AdpProgressIndicatorComponent Scroller;

		// Token: 0x0400554A RID: 21834
		[Token(Token = "0x400554A")]
		[FieldOffset(Offset = "0x90")]
		public GameObject NullIndicator;

		// Token: 0x0400554B RID: 21835
		[Token(Token = "0x400554B")]
		[FieldOffset(Offset = "0x98")]
		public EscLoadPannelSubPannel SubPannel;

		// Token: 0x0400554C RID: 21836
		[Token(Token = "0x400554C")]
		[FieldOffset(Offset = "0xA0")]
		public UIButtonSimple RefreshButton;

		// Token: 0x0400554D RID: 21837
		[Token(Token = "0x400554D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private DialogBoxPannel m_MessagePanel;

		// Token: 0x0400554E RID: 21838
		[Token(Token = "0x400554E")]
		[FieldOffset(Offset = "0xB0")]
		private readonly List<KeyValuePair<int, LoadedSaveDataInfo>> m_Data;

		// Token: 0x0400554F RID: 21839
		[Token(Token = "0x400554F")]
		[FieldOffset(Offset = "0xB8")]
		private StaticVerticalGridScrollListUILogicalGroupT<KeyValuePair<int, LoadedSaveDataInfo>, UIElementCluster, UIButtonSimple> m_Group;

		// Token: 0x04005550 RID: 21840
		[Token(Token = "0x4005550")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_ShouldInstantClose;
	}
}
