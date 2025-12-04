using System;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene.UI
{
	// Token: 0x0200028F RID: 655
	[Token(Token = "0x200028F")]
	[GenerateCleanupMethod]
	public class DaySceneClosetSubPannel : UISubPanel<DaySceneClosetPannel>
	{
		// Token: 0x06000ECF RID: 3791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x903260", Offset = "0x901C60", VA = "0x180903260", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x00006120 File Offset: 0x00004320
		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0x9031D0", Offset = "0x901BD0", VA = "0x1809031D0")]
		private UniTaskVoid ChangeToSkin()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED1")]
		[Address(RVA = "0x903510", Offset = "0x901F10", VA = "0x180903510", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0x9035C0", Offset = "0x901FC0", VA = "0x1809035C0")]
		private void UpdateVisual()
		{
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0x56C470", Offset = "0x56AE70", VA = "0x18056C470", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0x903910", Offset = "0x902310", VA = "0x180903910")]
		public DaySceneClosetSubPannel()
		{
		}

		// Token: 0x04000D98 RID: 3480
		[Token(Token = "0x4000D98")]
		[FieldOffset(Offset = "0x78")]
		public GameObject SubmitText;

		// Token: 0x04000D99 RID: 3481
		[Token(Token = "0x4000D99")]
		[FieldOffset(Offset = "0x80")]
		public GameObject Check;

		// Token: 0x04000D9A RID: 3482
		[Token(Token = "0x4000D9A")]
		[FieldOffset(Offset = "0x88")]
		public UIButtonSimple ChangeClothesBtn;

		// Token: 0x04000D9B RID: 3483
		[Token(Token = "0x4000D9B")]
		[FieldOffset(Offset = "0x90")]
		public UIButtonToggle UseAtNightSubmitBtn;

		// Token: 0x04000D9C RID: 3484
		[Token(Token = "0x4000D9C")]
		[FieldOffset(Offset = "0x98")]
		public UIButtonToggle UseIzakayaSkinSubmitBtn;

		// Token: 0x04000D9D RID: 3485
		[Token(Token = "0x4000D9D")]
		[FieldOffset(Offset = "0xA0")]
		public GameObject UseAtNightSubmitBtnGameObject;

		// Token: 0x04000D9E RID: 3486
		[Token(Token = "0x4000D9E")]
		[FieldOffset(Offset = "0xA8")]
		public GameObject UseIzakayaSkinSubmitBtnGameObject;
	}
}
