using System;
using System.Collections;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000D12 RID: 3346
	[Token(Token = "0x2000D12")]
	public class PartnerWaitressBehaviour : PartnerBase
	{
		// Token: 0x06004DD3 RID: 19923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD3")]
		[Address(RVA = "0x7B5D60", Offset = "0x7B4760", VA = "0x1807B5D60")]
		public PartnerWaitressBehaviour(PartnerWaitressBehaviour.WaitressType waitressType)
		{
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06004DD4 RID: 19924 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004DD5 RID: 19925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B46")]
		private GuestsManager.NormalOrder FocusingOrder
		{
			[Token(Token = "0x6004DD4")]
			[Address(RVA = "0x7B5DC0", Offset = "0x7B47C0", VA = "0x1807B5DC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DD5")]
			[Address(RVA = "0x3F2100", Offset = "0x3F0B00", VA = "0x1803F2100")]
			set
			{
			}
		}

		// Token: 0x06004DD6 RID: 19926 RVA: 0x0001C350 File Offset: 0x0001A550
		[Token(Token = "0x6004DD6")]
		[Address(RVA = "0x7B2E90", Offset = "0x7B1890", VA = "0x1807B2E90", Slot = "8")]
		public override PartnerBase.PartnerType GetPartnerType()
		{
			return PartnerBase.PartnerType.Cook;
		}

		// Token: 0x06004DD7 RID: 19927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DD7")]
		[Address(RVA = "0x7B32F0", Offset = "0x7B1CF0", VA = "0x1807B32F0", Slot = "4")]
		protected override void OnInitialize()
		{
		}

		// Token: 0x06004DD8 RID: 19928 RVA: 0x0001C368 File Offset: 0x0001A568
		[Token(Token = "0x6004DD8")]
		[Address(RVA = "0x7B50E0", Offset = "0x7B3AE0", VA = "0x1807B50E0")]
		private bool TryFetchOrder()
		{
			return default(bool);
		}

		// Token: 0x06004DD9 RID: 19929 RVA: 0x0001C380 File Offset: 0x0001A580
		[Token(Token = "0x6004DD9")]
		[Address(RVA = "0x7B51F0", Offset = "0x7B3BF0", VA = "0x1807B51F0")]
		private bool TryFetchSameOrder()
		{
			return default(bool);
		}

		// Token: 0x06004DDA RID: 19930 RVA: 0x0001C398 File Offset: 0x0001A598
		[Token(Token = "0x6004DDA")]
		[Address(RVA = "0x7B4F80", Offset = "0x7B3980", VA = "0x1807B4F80")]
		private bool TryAcceptOrder(GuestsManager.OrderBase targetOrder)
		{
			return default(bool);
		}

		// Token: 0x06004DDB RID: 19931 RVA: 0x0001C3B0 File Offset: 0x0001A5B0
		[Token(Token = "0x6004DDB")]
		[Address(RVA = "0x7B4E20", Offset = "0x7B3820", VA = "0x1807B4E20")]
		private bool TryAcceptOrderForBuffer(GuestsManager.OrderBase targetOrder)
		{
			return default(bool);
		}

		// Token: 0x06004DDC RID: 19932 RVA: 0x0001C3C8 File Offset: 0x0001A5C8
		[Token(Token = "0x6004DDC")]
		[Address(RVA = "0x7B2F60", Offset = "0x7B1960", VA = "0x1807B2F60")]
		private bool HasInventorySufficientForTargetOrder(GuestsManager.OrderBase baseTargetOrder)
		{
			return default(bool);
		}

		// Token: 0x06004DDD RID: 19933 RVA: 0x0001C3E0 File Offset: 0x0001A5E0
		[Token(Token = "0x6004DDD")]
		[Address(RVA = "0x7B2EA0", Offset = "0x7B18A0", VA = "0x1807B2EA0")]
		private bool HasBufferSufficientForTargetOrder(GuestsManager.OrderBase baseTargetOrder)
		{
			return default(bool);
		}

		// Token: 0x06004DDE RID: 19934 RVA: 0x0001C3F8 File Offset: 0x0001A5F8
		[Token(Token = "0x6004DDE")]
		[Address(RVA = "0x7B3B80", Offset = "0x7B2580", VA = "0x1807B3B80")]
		private bool OnWaitressMoveOrExtractReceiveSystemChangeInternal(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, object additionalInformation, bool bypassInventoryCheck)
		{
			return default(bool);
		}

		// Token: 0x06004DDF RID: 19935 RVA: 0x0001C410 File Offset: 0x0001A610
		[Token(Token = "0x6004DDF")]
		[Address(RVA = "0x7B3D40", Offset = "0x7B2740", VA = "0x1807B3D40")]
		private bool OnWaitressMoveOrExtractReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, object additionalInformation)
		{
			return default(bool);
		}

		// Token: 0x06004DE0 RID: 19936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE0")]
		[Address(RVA = "0x7B4C60", Offset = "0x7B3660", VA = "0x1807B4C60", Slot = "7")]
		protected override void ResetStatus()
		{
		}

		// Token: 0x06004DE1 RID: 19937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE1")]
		[Address(RVA = "0x7B3810", Offset = "0x7B2210", VA = "0x1807B3810", Slot = "5")]
		protected override void OnPlayIdleState()
		{
		}

		// Token: 0x06004DE2 RID: 19938 RVA: 0x0001C428 File Offset: 0x0001A628
		[Token(Token = "0x6004DE2")]
		[Address(RVA = "0x7B39D0", Offset = "0x7B23D0", VA = "0x1807B39D0")]
		public bool OnWaitressIdleReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, object additionalInformation)
		{
			return default(bool);
		}

		// Token: 0x06004DE3 RID: 19939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE3")]
		[Address(RVA = "0x7B46F0", Offset = "0x7B30F0", VA = "0x1807B46F0")]
		private void PlayMoveToExtractFromInventoryState()
		{
		}

		// Token: 0x06004DE4 RID: 19940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE4")]
		[Address(RVA = "0x7B3D60", Offset = "0x7B2760", VA = "0x1807B3D60")]
		private void OnWaitressMoveToExtractInterrupt()
		{
		}

		// Token: 0x06004DE5 RID: 19941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE5")]
		[Address(RVA = "0x7B4000", Offset = "0x7B2A00", VA = "0x1807B4000")]
		private void PlayExtractFromInventoryState()
		{
		}

		// Token: 0x06004DE6 RID: 19942 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DE6")]
		[Address(RVA = "0x7B2D80", Offset = "0x7B1780", VA = "0x1807B2D80")]
		private IEnumerator EmployeeExtractFromInventoryCoroutine()
		{
			return null;
		}

		// Token: 0x06004DE7 RID: 19943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE7")]
		[Address(RVA = "0x7B38A0", Offset = "0x7B22A0", VA = "0x1807B38A0")]
		private void OnWaitressExtractFromInventoryStateInterrupt()
		{
		}

		// Token: 0x06004DE8 RID: 19944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE8")]
		[Address(RVA = "0x7B4D50", Offset = "0x7B3750", VA = "0x1807B4D50")]
		private void StartDeliver()
		{
		}

		// Token: 0x06004DE9 RID: 19945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DE9")]
		[Address(RVA = "0x7B4390", Offset = "0x7B2D90", VA = "0x1807B4390")]
		private void PlayMoveToDeliverState()
		{
		}

		// Token: 0x06004DEA RID: 19946 RVA: 0x0001C440 File Offset: 0x0001A640
		[Token(Token = "0x6004DEA")]
		[Address(RVA = "0x7B37F0", Offset = "0x7B21F0", VA = "0x1807B37F0")]
		private bool OnMoveToDeliverReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, object additionalInformation)
		{
			return default(bool);
		}

		// Token: 0x06004DEB RID: 19947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DEB")]
		[Address(RVA = "0x7B36E0", Offset = "0x7B20E0", VA = "0x1807B36E0")]
		private void OnMoveToDeliverInterrupt()
		{
		}

		// Token: 0x06004DEC RID: 19948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DEC")]
		[Address(RVA = "0x7B41A0", Offset = "0x7B2BA0", VA = "0x1807B41A0")]
		private void PlayInterruptDeliverAndFetchSameOrderState()
		{
		}

		// Token: 0x06004DED RID: 19949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DED")]
		[Address(RVA = "0x7B3E60", Offset = "0x7B2860", VA = "0x1807B3E60")]
		private void PlayDeliverState()
		{
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DEE")]
		[Address(RVA = "0x7B3190", Offset = "0x7B1B90", VA = "0x1807B3190")]
		private void OnDeliverInterrupt()
		{
		}

		// Token: 0x06004DEF RID: 19951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DEF")]
		[Address(RVA = "0x7B2D00", Offset = "0x7B1700", VA = "0x1807B2D00")]
		private IEnumerator EmployeeDeliver()
		{
			return null;
		}

		// Token: 0x06004DF0 RID: 19952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF0")]
		[Address(RVA = "0x7B4AB0", Offset = "0x7B34B0", VA = "0x1807B4AB0")]
		private void PlayThrowDeliverState(bool isSpecial)
		{
		}

		// Token: 0x06004DF1 RID: 19953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DF1")]
		[Address(RVA = "0x7B2E00", Offset = "0x7B1800", VA = "0x1807B2E00")]
		private IEnumerator ExecuteThrowDeliver(bool isSpecial)
		{
			return null;
		}

		// Token: 0x04004762 RID: 18274
		[Token(Token = "0x4004762")]
		[FieldOffset(Offset = "0xA0")]
		private Func<GuestsManager.OrderBase, bool> checkOrderCompletionCallback;

		// Token: 0x04004763 RID: 18275
		[Token(Token = "0x4004763")]
		[FieldOffset(Offset = "0xA8")]
		private Action<GuestTableDisplayer> executeServeCallback;

		// Token: 0x04004764 RID: 18276
		[Token(Token = "0x4004764")]
		[FieldOffset(Offset = "0xB0")]
		private Sellable.SellableType focusingSellable;

		// Token: 0x04004765 RID: 18277
		[Token(Token = "0x4004765")]
		[FieldOffset(Offset = "0xB8")]
		private Func<Vector3Int> getInventoryPositionCallback;

		// Token: 0x04004766 RID: 18278
		[Token(Token = "0x4004766")]
		[FieldOffset(Offset = "0xC0")]
		private Action getRequestedFromInventoryCallback;

		// Token: 0x04004767 RID: 18279
		[Token(Token = "0x4004767")]
		[FieldOffset(Offset = "0xC8")]
		private PartnerBase.InventoryType inventoryType;

		// Token: 0x04004768 RID: 18280
		[Token(Token = "0x4004768")]
		[FieldOffset(Offset = "0xC9")]
		public PartnerWaitressBehaviour.WaitressType waitressType;

		// Token: 0x04004769 RID: 18281
		[Token(Token = "0x4004769")]
		[FieldOffset(Offset = "0xD0")]
		private Coroutine workingCorouinte;

		// Token: 0x02000D13 RID: 3347
		[Token(Token = "0x2000D13")]
		public enum WaitressType : byte
		{
			// Token: 0x0400476B RID: 18283
			[Token(Token = "0x400476B")]
			Waitress = 1,
			// Token: 0x0400476C RID: 18284
			[Token(Token = "0x400476C")]
			Barmaid
		}

		// Token: 0x02000D14 RID: 3348
		[Token(Token = "0x2000D14")]
		private enum DeliverType : byte
		{
			// Token: 0x0400476E RID: 18286
			[Token(Token = "0x400476E")]
			Default,
			// Token: 0x0400476F RID: 18287
			[Token(Token = "0x400476F")]
			ThrowDeliver
		}
	}
}
