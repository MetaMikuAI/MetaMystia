using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000E24 RID: 3620
	[Token(Token = "0x2000E24")]
	[GenerateCleanupMethod]
	public class DaySceneCGDisplayerPannel : UIPanel
	{
		// Token: 0x060054AF RID: 21679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054AF")]
		[Address(RVA = "0x8351C0", Offset = "0x833BC0", VA = "0x1808351C0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060054B0 RID: 21680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B0")]
		[Address(RVA = "0x835400", Offset = "0x833E00", VA = "0x180835400", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060054B1 RID: 21681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B1")]
		[Address(RVA = "0x835CE0", Offset = "0x8346E0", VA = "0x180835CE0")]
		private void OnSwitchMove(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x060054B2 RID: 21682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B2")]
		[Address(RVA = "0x835D40", Offset = "0x834740", VA = "0x180835D40")]
		private void OnSwitchScroll(InputAction.CallbackContext callbackContext)
		{
		}

		// Token: 0x060054B3 RID: 21683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B3")]
		[Address(RVA = "0x835DB0", Offset = "0x8347B0", VA = "0x180835DB0")]
		private void OnSwitch(float dir)
		{
		}

		// Token: 0x060054B4 RID: 21684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B4")]
		[Address(RVA = "0x834670", Offset = "0x833070", VA = "0x180834670")]
		private void GoToNext()
		{
		}

		// Token: 0x060054B5 RID: 21685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B5")]
		[Address(RVA = "0x834700", Offset = "0x833100", VA = "0x180834700")]
		private void GoToPrevious()
		{
		}

		// Token: 0x060054B6 RID: 21686 RVA: 0x0001E4F8 File Offset: 0x0001C6F8
		[Token(Token = "0x60054B6")]
		[Address(RVA = "0x8344C0", Offset = "0x832EC0", VA = "0x1808344C0")]
		private ValueTuple<AssetReference, bool, bool> GetCGAssetReference(RunTimeScheduler.CGPicture.MultiLanguageCGPic multiLanguageCGPic)
		{
			return default(ValueTuple<AssetReference, bool, bool>);
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B7")]
		[Address(RVA = "0x834970", Offset = "0x833370", VA = "0x180834970")]
		private void OnElementEnabled([TupleElementNames(new string[] { "PicName", "PicAsset", "Asset", "IsLegacy", "IsUsed" })] ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>> cgData, UIElementCluster uiElement, UIButtonSimple button)
		{
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B8")]
		[Address(RVA = "0x834740", Offset = "0x833140", VA = "0x180834740")]
		public static void InitVisual(Image x, IList<Sprite> loaded)
		{
		}

		// Token: 0x060054B9 RID: 21689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054B9")]
		[Address(RVA = "0x835020", Offset = "0x833A20", VA = "0x180835020")]
		private void OnElementSelected([TupleElementNames(new string[] { "PicName", "PicAsset", "Asset", "IsLegacy", "IsUsed" })] ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>> cgData, UIElementCluster cluster, UIButtonSimple button)
		{
		}

		// Token: 0x060054BA RID: 21690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BA")]
		[Address(RVA = "0x8364C0", Offset = "0x834EC0", VA = "0x1808364C0")]
		private void UpdateCurrentPage()
		{
		}

		// Token: 0x060054BB RID: 21691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BB")]
		[Address(RVA = "0x8361F0", Offset = "0x834BF0", VA = "0x1808361F0")]
		private void TryReselect()
		{
		}

		// Token: 0x060054BC RID: 21692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BC")]
		[Address(RVA = "0x835E70", Offset = "0x834870", VA = "0x180835E70")]
		private void OpenCGDescriber([TupleElementNames(new string[] { "Asset", "IsLegacy", "IsUsed" })] List<ValueTuple<AssetReference, bool, bool>> picAsset)
		{
		}

		// Token: 0x060054BD RID: 21693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054BD")]
		[Address(RVA = "0x836020", Offset = "0x834A20", VA = "0x180836020")]
		private IList<Sprite> SortSprites(IList<Sprite> sprites)
		{
			return null;
		}

		// Token: 0x060054BE RID: 21694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BE")]
		[Address(RVA = "0x835FE0", Offset = "0x8349E0", VA = "0x180835FE0")]
		private void ReleaseAsset()
		{
		}

		// Token: 0x060054BF RID: 21695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054BF")]
		[Address(RVA = "0x835120", Offset = "0x833B20", VA = "0x180835120", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060054C0 RID: 21696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C0")]
		[Address(RVA = "0x834320", Offset = "0x832D20", VA = "0x180834320", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060054C1 RID: 21697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054C1")]
		[Address(RVA = "0x8367E0", Offset = "0x8351E0", VA = "0x1808367E0")]
		public DaySceneCGDisplayerPannel()
		{
		}

		// Token: 0x04004F9E RID: 20382
		[Token(Token = "0x4004F9E")]
		private const int MAX_PIC_PER_PAGE = 8;

		// Token: 0x04004F9F RID: 20383
		[Token(Token = "0x4004F9F")]
		private const string SPLIT_DATA = "c_Split_Data_c";

		// Token: 0x04004FA0 RID: 20384
		[Token(Token = "0x4004FA0")]
		[FieldOffset(Offset = "0x70")]
		public GameObject CGPictureElement;

		// Token: 0x04004FA1 RID: 20385
		[Token(Token = "0x4004FA1")]
		[FieldOffset(Offset = "0x78")]
		public GridLayoutGroup leftPannel;

		// Token: 0x04004FA2 RID: 20386
		[Token(Token = "0x4004FA2")]
		[FieldOffset(Offset = "0x80")]
		public GridLayoutGroup rightPannel;

		// Token: 0x04004FA3 RID: 20387
		[Token(Token = "0x4004FA3")]
		[FieldOffset(Offset = "0x88")]
		public UIButtonSimple GotoPreviousBtn;

		// Token: 0x04004FA4 RID: 20388
		[Token(Token = "0x4004FA4")]
		[FieldOffset(Offset = "0x90")]
		public UIButtonSimple GotoNextBtn;

		// Token: 0x04004FA5 RID: 20389
		[Token(Token = "0x4004FA5")]
		[FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI currentPageNum;

		// Token: 0x04004FA6 RID: 20390
		[Token(Token = "0x4004FA6")]
		[FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI wholePageNum;

		// Token: 0x04004FA7 RID: 20391
		[Token(Token = "0x4004FA7")]
		[FieldOffset(Offset = "0xA8")]
		public DaySceneCGDisplayerPannel.OpenMode PanelOpenMode;

		// Token: 0x04004FA8 RID: 20392
		[Token(Token = "0x4004FA8")]
		[FieldOffset(Offset = "0xB0")]
		public string FanArtLabel;

		// Token: 0x04004FA9 RID: 20393
		[Token(Token = "0x4004FA9")]
		[FieldOffset(Offset = "0xB8")]
		public DaySceneCGDisplayerSubPannel SubPannel;

		// Token: 0x04004FAA RID: 20394
		[Token(Token = "0x4004FAA")]
		[FieldOffset(Offset = "0xC0")]
		[TupleElementNames(new string[] { "PicName", "PicAsset", "Asset", "IsLegacy", "IsUsed" })]
		private readonly Dictionary<int, ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>> AllCGPictures;

		// Token: 0x04004FAB RID: 20395
		[Token(Token = "0x4004FAB")]
		[FieldOffset(Offset = "0xC8")]
		[TupleElementNames(new string[] { "PicName", "PicAsset", "Asset", "IsLegacy", "IsUsed" })]
		private readonly List<ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>> CGPicturesLeft;

		// Token: 0x04004FAC RID: 20396
		[Token(Token = "0x4004FAC")]
		[FieldOffset(Offset = "0xD0")]
		[TupleElementNames(new string[] { "PicName", "PicAsset", "Asset", "IsLegacy", "IsUsed" })]
		private readonly List<ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>> CGPicturesRight;

		// Token: 0x04004FAD RID: 20397
		[Token(Token = "0x4004FAD")]
		[FieldOffset(Offset = "0xD8")]
		private int currentPage;

		// Token: 0x04004FAE RID: 20398
		[Token(Token = "0x4004FAE")]
		[FieldOffset(Offset = "0xDC")]
		private bool isSelectingLeft;

		// Token: 0x04004FAF RID: 20399
		[Token(Token = "0x4004FAF")]
		[FieldOffset(Offset = "0xE0")]
		[TupleElementNames(new string[] { "PicName", "PicAsset", "Asset", "IsLegacy", "IsUsed" })]
		private StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>, UIElementCluster, UIButtonSimple> m_AlbumPicLeftGroup;

		// Token: 0x04004FB0 RID: 20400
		[Token(Token = "0x4004FB0")]
		[FieldOffset(Offset = "0xE8")]
		[TupleElementNames(new string[] { "PicName", "PicAsset", "Asset", "IsLegacy", "IsUsed" })]
		private StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<string, List<ValueTuple<AssetReference, bool, bool>>>, UIElementCluster, UIButtonSimple> m_AlbumPicRightGroup;

		// Token: 0x04004FB1 RID: 20401
		[Token(Token = "0x4004FB1")]
		[FieldOffset(Offset = "0xF0")]
		private Action releaseHandle;

		// Token: 0x02000E25 RID: 3621
		[Token(Token = "0x2000E25")]
		public enum OpenMode
		{
			// Token: 0x04004FB3 RID: 20403
			[Token(Token = "0x4004FB3")]
			CG,
			// Token: 0x04004FB4 RID: 20404
			[Token(Token = "0x4004FB4")]
			FanArt
		}
	}
}
