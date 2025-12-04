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
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x0200028B RID: 651
	[Token(Token = "0x200028B")]
	[GenerateCleanupMethod]
	public class DaySceneClosetPannel : UIPanel
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000EAF RID: 3759 RVA: 0x00006108 File Offset: 0x00004308
		// (set) Token: 0x06000EB0 RID: 3760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000173")]
		public int CurrentSelectedClothesIndex
		{
			[Token(Token = "0x6000EAF")]
			[Address(RVA = "0x48B8E0", Offset = "0x48A2E0", VA = "0x18048B8E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000EB0")]
			[Address(RVA = "0x656A90", Offset = "0x655490", VA = "0x180656A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x9030F0", Offset = "0x901AF0", VA = "0x1809030F0")]
		public void UpdateVisual()
		{
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x833B50", Offset = "0x832550", VA = "0x180833B50", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EB3")]
		[Address(RVA = "0x902D30", Offset = "0x901730", VA = "0x180902D30", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EB4")]
		[Address(RVA = "0x9020F0", Offset = "0x900AF0", VA = "0x1809020F0")]
		private void OnElementEnabled(ClothesProfile.Clothes clothesData, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EB5")]
		[Address(RVA = "0x902670", Offset = "0x901070", VA = "0x180902670")]
		private void OnElementSelected(ClothesProfile.Clothes clothesData, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EB6")]
		[Address(RVA = "0x903040", Offset = "0x901A40", VA = "0x180903040")]
		private void ShowConfigPannel()
		{
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EB7")]
		[Address(RVA = "0x902CD0", Offset = "0x9016D0", VA = "0x180902CD0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EB8")]
		[Address(RVA = "0x902020", Offset = "0x900A20", VA = "0x180902020", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000EB9")]
		[Address(RVA = "0x903140", Offset = "0x901B40", VA = "0x180903140")]
		public DaySceneClosetPannel()
		{
		}

		// Token: 0x04000D88 RID: 3464
		[Token(Token = "0x4000D88")]
		[FieldOffset(Offset = "0x70")]
		public GameObject clothesElement;

		// Token: 0x04000D89 RID: 3465
		[Token(Token = "0x4000D89")]
		[FieldOffset(Offset = "0x78")]
		public UIElementCluster clothesDescrierCluster;

		// Token: 0x04000D8A RID: 3466
		[Token(Token = "0x4000D8A")]
		[FieldOffset(Offset = "0x80")]
		public GridLayoutGroup clothesPannel;

		// Token: 0x04000D8B RID: 3467
		[Token(Token = "0x4000D8B")]
		[FieldOffset(Offset = "0x88")]
		public AdpProgressIndicatorComponent scroller;

		// Token: 0x04000D8C RID: 3468
		[Token(Token = "0x4000D8C")]
		[FieldOffset(Offset = "0x90")]
		public DaySceneClosetSubPannel SubPannel;

		// Token: 0x04000D8D RID: 3469
		[Token(Token = "0x4000D8D")]
		[FieldOffset(Offset = "0x98")]
		private readonly List<ClothesProfile.Clothes> m_ClothesList;

		// Token: 0x04000D8E RID: 3470
		[Token(Token = "0x4000D8E")]
		[FieldOffset(Offset = "0xA0")]
		private StaticVerticalGridScrollListUILogicalGroupT<ClothesProfile.Clothes, UIElementCluster, UIButtonSimple> m_ClothesGroup;
	}
}
