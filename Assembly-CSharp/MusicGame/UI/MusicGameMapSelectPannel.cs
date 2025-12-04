using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Profile;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;

namespace MusicGame.UI
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[GenerateCleanupMethod]
	public class MusicGameMapSelectPannel : UISubPanel<MusicGameIntroInfoPannel>
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000121 RID: 289 RVA: 0x000024C0 File Offset: 0x000006C0
		[Token(Token = "0x1700001C")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x415ED0", Offset = "0x4148D0", VA = "0x180415ED0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x4160C0", Offset = "0x414AC0", VA = "0x1804160C0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000124 RID: 292 RVA: 0x000024D8 File Offset: 0x000006D8
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x410410", Offset = "0x40EE10", VA = "0x180410410", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x415E80", Offset = "0x414880", VA = "0x180415E80", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x415320", Offset = "0x413D20", VA = "0x180415320")]
		private void ExitPannel(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x4153C0", Offset = "0x413DC0", VA = "0x1804153C0")]
		private void OnFadeFinish()
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x4167B0", Offset = "0x4151B0", VA = "0x1804167B0")]
		private void RefreshPannel()
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x415430", Offset = "0x413E30", VA = "0x180415430")]
		private void OnMapItemEnable(MusicGameMappingProfile.MusicMapping data, UIElementCluster uiElement, UIButtonSimple button)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x415170", Offset = "0x413B70", VA = "0x180415170", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x416B20", Offset = "0x415520", VA = "0x180416B20")]
		public MusicGameMapSelectPannel()
		{
		}

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI currentMapLabelText;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x80")]
		public UIElementCluster CDComponent;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x88")]
		public RectTransform selectableMapField;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x90")]
		public RectTransform cacheField;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x98")]
		public GameObject recordCoverElement;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0xA0")]
		public AdpScrollListFixedComponent mapCoverFieldScroller;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0xA8")]
		public MusicSelectorPannel selectorPannel;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0xB0")]
		public MusicGameMapSelectPannel.UnlockBadgeCondition[] allUnlockBadgeConditions;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Color cannotSelectColor;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private TextMeshProUGUI unlockText;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0xD0")]
		private readonly Dictionary<UIElementCluster, GameObject> m_DLCIndicator;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0xD8")]
		private string currentMapLabel;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0xE0")]
		private List<MusicGameMappingProfile.MusicMapping> m_MusicMapping;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0xE8")]
		private MusicSelectorPannel m_pannelInstance;

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0xF0")]
		private VirtualScrollListUILogicalGroupT<MusicGameMappingProfile.MusicMapping, UIElementCluster, UIButtonSimple> m_UILogicalGroup;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0xF8")]
		private List<string> m_UnlockedMapLabel;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x100")]
		[TupleElementNames(new string[] { "EasyBadgeId", "HardBadgeId" })]
		public readonly Dictionary<string, ValueTuple<int, int>> BadgeUnlockCondition;

		// Token: 0x0200003E RID: 62
		[Token(Token = "0x200003E")]
		[Serializable]
		public struct UnlockBadgeCondition
		{
			// Token: 0x0400010A RID: 266
			[Token(Token = "0x400010A")]
			[FieldOffset(Offset = "0x0")]
			public string mapLabel;

			// Token: 0x0400010B RID: 267
			[Token(Token = "0x400010B")]
			[FieldOffset(Offset = "0x8")]
			public int easyBadgeId;

			// Token: 0x0400010C RID: 268
			[Token(Token = "0x400010C")]
			[FieldOffset(Offset = "0xC")]
			public int hardBadgeId;
		}
	}
}
