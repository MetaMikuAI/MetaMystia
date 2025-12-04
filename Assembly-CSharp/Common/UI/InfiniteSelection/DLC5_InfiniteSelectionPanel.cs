using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI.InfiniteSelection
{
	// Token: 0x02000F6C RID: 3948
	[Token(Token = "0x2000F6C")]
	[GenerateCleanupMethod]
	public class DLC5_InfiniteSelectionPanel : UIPanelParamOpen<DLC5_InfiniteSelectionPanel.OpenContext>
	{
		// Token: 0x06005CC4 RID: 23748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC4")]
		[Address(RVA = "0x8A7760", Offset = "0x8A6160", VA = "0x1808A7760", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005CC5 RID: 23749 RVA: 0x00020340 File Offset: 0x0001E540
		[Token(Token = "0x6005CC5")]
		[Address(RVA = "0x8A76C0", Offset = "0x8A60C0", VA = "0x1808A76C0")]
		private UniTaskVoid EditIngredient(int editIndex)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06005CC6 RID: 23750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC6")]
		[Address(RVA = "0x8A7900", Offset = "0x8A6300", VA = "0x1808A7900", Slot = "32")]
		protected override void OnPanelOpen(DLC5_InfiniteSelectionPanel.OpenContext openParam)
		{
		}

		// Token: 0x06005CC7 RID: 23751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC7")]
		[Address(RVA = "0x8A7E10", Offset = "0x8A6810", VA = "0x1808A7E10")]
		private void UpdateVisual(bool noAnimation)
		{
		}

		// Token: 0x06005CC8 RID: 23752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC8")]
		[Address(RVA = "0x4644B0", Offset = "0x462EB0", VA = "0x1804644B0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005CC9 RID: 23753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CC9")]
		[Address(RVA = "0x8A7EC0", Offset = "0x8A68C0", VA = "0x1808A7EC0")]
		public DLC5_InfiniteSelectionPanel()
		{
		}

		// Token: 0x06005CCD RID: 23757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CCD")]
		[Address(RVA = "0x8A7AF0", Offset = "0x8A64F0", VA = "0x1808A7AF0")]
		[CompilerGenerated]
		internal static IEnumerable<int> <EditIngredient>g__ExceptOptional|8_1(IEnumerable<int> collection, int? value)
		{
			return null;
		}

		// Token: 0x06005CCE RID: 23758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CCE")]
		[Address(RVA = "0x8A7D80", Offset = "0x8A6780", VA = "0x1808A7D80")]
		[CompilerGenerated]
		internal static void <OnPanelOpen>g__InitModule|9_0(DLC5_InfiniteSelectionDrawer drawer, bool active)
		{
		}

		// Token: 0x040055E7 RID: 21991
		[Token(Token = "0x40055E7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private DLC5_InfiniteSelectionDrawer m_Drawer1;

		// Token: 0x040055E8 RID: 21992
		[Token(Token = "0x40055E8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private DLC5_InfiniteSelectionDrawer m_Drawer2;

		// Token: 0x040055E9 RID: 21993
		[Token(Token = "0x40055E9")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private DLC5_InfiniteSelectionDrawer m_Drawer3;

		// Token: 0x040055EA RID: 21994
		[Token(Token = "0x40055EA")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private DLC5_InfiniteIngredientPanel m_SelectionPanel;

		// Token: 0x040055EB RID: 21995
		[Token(Token = "0x40055EB")]
		[FieldOffset(Offset = "0x98")]
		private readonly int[] m_IgnoreCollection;

		// Token: 0x02000F6D RID: 3949
		[Token(Token = "0x2000F6D")]
		public enum ActiveCount
		{
			// Token: 0x040055ED RID: 21997
			[Token(Token = "0x40055ED")]
			I = 1,
			// Token: 0x040055EE RID: 21998
			[Token(Token = "0x40055EE")]
			II,
			// Token: 0x040055EF RID: 21999
			[Token(Token = "0x40055EF")]
			III
		}

		// Token: 0x02000F6E RID: 3950
		[Token(Token = "0x2000F6E")]
		public class OpenContext
		{
			// Token: 0x17000D06 RID: 3334
			// (get) Token: 0x06005CCF RID: 23759 RVA: 0x00020358 File Offset: 0x0001E558
			// (set) Token: 0x06005CD0 RID: 23760 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000D06")]
			public int? Ingredient1
			{
				[Token(Token = "0x6005CCF")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6005CD0")]
				[Address(RVA = "0x8B0040", Offset = "0x8AEA40", VA = "0x1808B0040")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000D07 RID: 3335
			// (get) Token: 0x06005CD1 RID: 23761 RVA: 0x00020370 File Offset: 0x0001E570
			// (set) Token: 0x06005CD2 RID: 23762 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000D07")]
			public int? Ingredient2
			{
				[Token(Token = "0x6005CD1")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6005CD2")]
				[Address(RVA = "0x8B0050", Offset = "0x8AEA50", VA = "0x1808B0050")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000D08 RID: 3336
			// (get) Token: 0x06005CD3 RID: 23763 RVA: 0x00020388 File Offset: 0x0001E588
			// (set) Token: 0x06005CD4 RID: 23764 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000D08")]
			public int? Ingredient3
			{
				[Token(Token = "0x6005CD3")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6005CD4")]
				[Address(RVA = "0x8B0060", Offset = "0x8AEA60", VA = "0x1808B0060")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000D09 RID: 3337
			// (get) Token: 0x06005CD5 RID: 23765 RVA: 0x000203A0 File Offset: 0x0001E5A0
			// (set) Token: 0x06005CD6 RID: 23766 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000D09")]
			public DLC5_InfiniteSelectionPanel.ActiveCount ActiveCount
			{
				[Token(Token = "0x6005CD5")]
				[Address(RVA = "0x44F9E0", Offset = "0x44E3E0", VA = "0x18044F9E0")]
				[CompilerGenerated]
				get
				{
					return (DLC5_InfiniteSelectionPanel.ActiveCount)0;
				}
				[Token(Token = "0x6005CD6")]
				[Address(RVA = "0x450630", Offset = "0x44F030", VA = "0x180450630")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06005CD7 RID: 23767 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005CD7")]
			[Address(RVA = "0x8AFFF0", Offset = "0x8AE9F0", VA = "0x1808AFFF0")]
			public OpenContext(int? ingredient1, int? ingredient2, int? ingredient3, DLC5_InfiniteSelectionPanel.ActiveCount activeCount)
			{
			}
		}
	}
}
