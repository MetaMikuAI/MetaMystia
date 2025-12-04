using System;
using System.Runtime.CompilerServices;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using NightScene.UI.HUDUtility;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.GuestManagementUtility
{
	// Token: 0x020006BC RID: 1724
	[Token(Token = "0x20006BC")]
	[GenerateCleanupMethod]
	public class OrderingElement : MonoBehaviour
	{
		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060028C0 RID: 10432 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060028C1 RID: 10433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005B7")]
		public GuestsManager.OrderBase ActiveOrder
		{
			[Token(Token = "0x60028C0")]
			[Address(RVA = "0x48A4C0", Offset = "0x488EC0", VA = "0x18048A4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60028C1")]
			[Address(RVA = "0x4D2590", Offset = "0x4D0F90", VA = "0x1804D2590")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060028C2 RID: 10434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C2")]
		[Address(RVA = "0x54D110", Offset = "0x54BB10", VA = "0x18054D110")]
		private void Update()
		{
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C3")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x060028C4 RID: 10436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C4")]
		[Address(RVA = "0x54C6F0", Offset = "0x54B0F0", VA = "0x18054C6F0")]
		public void Initialize(GuestsManager.OrderBase request, Transform ghostField, int deskCode, Sprite overridePic, Action onOutFinish)
		{
		}

		// Token: 0x060028C5 RID: 10437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C5")]
		[Address(RVA = "0x54CE60", Offset = "0x54B860", VA = "0x18054CE60")]
		public void Out()
		{
		}

		// Token: 0x060028C6 RID: 10438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C6")]
		[Address(RVA = "0x54C680", Offset = "0x54B080", VA = "0x18054C680")]
		public void DestroySelf()
		{
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C7")]
		[Address(RVA = "0x54C410", Offset = "0x54AE10", VA = "0x18054C410")]
		public void ChangeBorderStyle(bool current)
		{
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C8")]
		[Address(RVA = "0x54CED0", Offset = "0x54B8D0", VA = "0x18054CED0")]
		public void SetPartnerHighlight(Sprite visual, Sellable.SellableType sellableType)
		{
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028C9")]
		[Address(RVA = "0x54C500", Offset = "0x54AF00", VA = "0x18054C500", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028CA")]
		[Address(RVA = "0x54D3D0", Offset = "0x54BDD0", VA = "0x18054D3D0")]
		public OrderingElement()
		{
		}

		// Token: 0x04002522 RID: 9506
		[Token(Token = "0x4002522")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int s_Property;

		// Token: 0x04002523 RID: 9507
		[Token(Token = "0x4002523")]
		[FieldOffset(Offset = "0x18")]
		public Transform ghostField;

		// Token: 0x04002524 RID: 9508
		[Token(Token = "0x4002524")]
		[FieldOffset(Offset = "0x20")]
		public Image borderStyleImageForWaiting;

		// Token: 0x04002525 RID: 9509
		[Token(Token = "0x4002525")]
		[FieldOffset(Offset = "0x28")]
		public Image borderStyleImageForCurrent;

		// Token: 0x04002526 RID: 9510
		[Token(Token = "0x4002526")]
		[FieldOffset(Offset = "0x30")]
		public Image normalFoodFinished;

		// Token: 0x04002527 RID: 9511
		[Token(Token = "0x4002527")]
		[FieldOffset(Offset = "0x38")]
		public Image normalBevFinished;

		// Token: 0x04002528 RID: 9512
		[Token(Token = "0x4002528")]
		[FieldOffset(Offset = "0x40")]
		public Image specFoodFinished;

		// Token: 0x04002529 RID: 9513
		[Token(Token = "0x4002529")]
		[FieldOffset(Offset = "0x48")]
		public Image specBevFinished;

		// Token: 0x0400252A RID: 9514
		[Token(Token = "0x400252A")]
		[FieldOffset(Offset = "0x50")]
		public Animator animator;

		// Token: 0x0400252B RID: 9515
		[Token(Token = "0x400252B")]
		[FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI text;

		// Token: 0x0400252C RID: 9516
		[Token(Token = "0x400252C")]
		[FieldOffset(Offset = "0x60")]
		public LayoutElement layoutElement;

		// Token: 0x0400252D RID: 9517
		[Token(Token = "0x400252D")]
		[FieldOffset(Offset = "0x68")]
		public float time;

		// Token: 0x0400252E RID: 9518
		[Token(Token = "0x400252E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private DisplayedOrderElement normalOrderElement_Food;

		// Token: 0x0400252F RID: 9519
		[Token(Token = "0x400252F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private DisplayedOrderElement normalOrderElement_Bev;

		// Token: 0x04002530 RID: 9520
		[Token(Token = "0x4002530")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private DisplayedOrderElement specialOrderElement;

		// Token: 0x04002531 RID: 9521
		[Token(Token = "0x4002531")]
		[FieldOffset(Offset = "0x88")]
		private bool current;

		// Token: 0x04002532 RID: 9522
		[Token(Token = "0x4002532")]
		[FieldOffset(Offset = "0x90")]
		private CanvasGroup normalOrderElement_BevCanvasGroup;

		// Token: 0x04002533 RID: 9523
		[Token(Token = "0x4002533")]
		[FieldOffset(Offset = "0x98")]
		private CanvasGroup normalOrderElement_FoodCanvasGroup;

		// Token: 0x04002534 RID: 9524
		[Token(Token = "0x4002534")]
		[FieldOffset(Offset = "0xA0")]
		private Action onSelfRemoveFinish;

		// Token: 0x04002535 RID: 9525
		[Token(Token = "0x4002535")]
		[FieldOffset(Offset = "0xA8")]
		private Action<Sprite> onSetBevPartnerIndicatorCallback;

		// Token: 0x04002536 RID: 9526
		[Token(Token = "0x4002536")]
		[FieldOffset(Offset = "0xB0")]
		private Action<Sprite> onSetFoodPartnerIndicatorCallback;

		// Token: 0x04002537 RID: 9527
		[Token(Token = "0x4002537")]
		[FieldOffset(Offset = "0xB8")]
		private bool shouldMove;

		// Token: 0x04002538 RID: 9528
		[Token(Token = "0x4002538")]
		[FieldOffset(Offset = "0xC0")]
		private CanvasGroup specialOrderElementCanvasGroup;

		// Token: 0x04002539 RID: 9529
		[Token(Token = "0x4002539")]
		[FieldOffset(Offset = "0xC8")]
		private Vector3 velocity;
	}
}
