using System;
using System.Collections;
using System.Runtime.CompilerServices;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000D0C RID: 3340
	[Token(Token = "0x2000D0C")]
	public class PartnerCookBehaviour : PartnerBase
	{
		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06004DA1 RID: 19873 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004DA2 RID: 19874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B42")]
		private CookController TargetCooker
		{
			[Token(Token = "0x6004DA1")]
			[Address(RVA = "0x48A8D0", Offset = "0x4892D0", VA = "0x18048A8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DA2")]
			[Address(RVA = "0x48AC50", Offset = "0x489650", VA = "0x18048AC50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06004DA3 RID: 19875 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004DA4 RID: 19876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B43")]
		private GuestsManager.NormalOrder FocusingOrder
		{
			[Token(Token = "0x6004DA3")]
			[Address(RVA = "0x79CB80", Offset = "0x79B580", VA = "0x18079CB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004DA4")]
			[Address(RVA = "0x3F2100", Offset = "0x3F0B00", VA = "0x1803F2100")]
			set
			{
			}
		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x0001C188 File Offset: 0x0001A388
		[Token(Token = "0x6004DA5")]
		[Address(RVA = "0x79C680", Offset = "0x79B080", VA = "0x18079C680")]
		private bool TryAcceptOrder(GuestsManager.OrderBase targetOrder)
		{
			return default(bool);
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x0001C1A0 File Offset: 0x0001A3A0
		[Token(Token = "0x6004DA6")]
		[Address(RVA = "0x79ADC0", Offset = "0x7997C0", VA = "0x18079ADC0")]
		private bool HasInventorySufficientForTargetFood(Recipe recipe)
		{
			return default(bool);
		}

		// Token: 0x06004DA7 RID: 19879 RVA: 0x0001C1B8 File Offset: 0x0001A3B8
		[Token(Token = "0x6004DA7")]
		[Address(RVA = "0x79A100", Offset = "0x798B00", VA = "0x18079A100")]
		private bool CheckIfNeedToCookForTargetOrder(GuestsManager.OrderBase targetOrderBase)
		{
			return default(bool);
		}

		// Token: 0x06004DA8 RID: 19880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA8")]
		[Address(RVA = "0x79C400", Offset = "0x79AE00", VA = "0x18079C400", Slot = "7")]
		protected override void ResetStatus()
		{
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x0001C1D0 File Offset: 0x0001A3D0
		[Token(Token = "0x6004DA9")]
		[Address(RVA = "0x79C8E0", Offset = "0x79B2E0", VA = "0x18079C8E0")]
		private PartnerManager.GetCookerInfo TryGetCooker(GuestsManager.NormalOrder focusingOrder, out CookController cookController, out Recipe targetRecipe)
		{
			return PartnerManager.GetCookerInfo.AllCookerBusy;
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x0001C1E8 File Offset: 0x0001A3E8
		[Token(Token = "0x6004DAA")]
		[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0", Slot = "8")]
		public override PartnerBase.PartnerType GetPartnerType()
		{
			return PartnerBase.PartnerType.Cook;
		}

		// Token: 0x06004DAB RID: 19883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DAB")]
		[Address(RVA = "0x7946A0", Offset = "0x7930A0", VA = "0x1807946A0", Slot = "6")]
		public override void OnDestroy()
		{
		}

		// Token: 0x06004DAC RID: 19884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DAC")]
		[Address(RVA = "0x79BD90", Offset = "0x79A790", VA = "0x18079BD90", Slot = "5")]
		protected override void OnPlayIdleState()
		{
		}

		// Token: 0x06004DAD RID: 19885 RVA: 0x0001C200 File Offset: 0x0001A400
		[Token(Token = "0x6004DAD")]
		[Address(RVA = "0x79AF50", Offset = "0x799950", VA = "0x18079AF50")]
		public bool OnCookIdleReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, object additionalInformation)
		{
			return default(bool);
		}

		// Token: 0x06004DAE RID: 19886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DAE")]
		[Address(RVA = "0x79BFD0", Offset = "0x79A9D0", VA = "0x18079BFD0")]
		private void PlayMoveToCookerState()
		{
		}

		// Token: 0x06004DAF RID: 19887 RVA: 0x0001C218 File Offset: 0x0001A418
		[Token(Token = "0x6004DAF")]
		[Address(RVA = "0x79B9C0", Offset = "0x79A3C0", VA = "0x18079B9C0")]
		private bool OnMoveToCookerReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, object additionalInformation)
		{
			return default(bool);
		}

		// Token: 0x06004DB0 RID: 19888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB0")]
		[Address(RVA = "0x79BC40", Offset = "0x79A640", VA = "0x18079BC40")]
		private void OnMoveToCookerStateInterrupt()
		{
		}

		// Token: 0x06004DB1 RID: 19889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB1")]
		[Address(RVA = "0x79BE20", Offset = "0x79A820", VA = "0x18079BE20")]
		private void PlayCookState()
		{
		}

		// Token: 0x06004DB2 RID: 19890 RVA: 0x0001C230 File Offset: 0x0001A430
		[Token(Token = "0x6004DB2")]
		[Address(RVA = "0x79B200", Offset = "0x799C00", VA = "0x18079B200")]
		private bool OnCookingReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, object additionalInformation)
		{
			return default(bool);
		}

		// Token: 0x06004DB3 RID: 19891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB3")]
		[Address(RVA = "0x79B750", Offset = "0x79A150", VA = "0x18079B750")]
		private void OnCookingStateInterrupt()
		{
		}

		// Token: 0x06004DB4 RID: 19892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DB4")]
		[Address(RVA = "0x79AD50", Offset = "0x799750", VA = "0x18079AD50")]
		private IEnumerator EmployeeCookingCoroutine()
		{
			return null;
		}

		// Token: 0x06004DB5 RID: 19893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DB5")]
		[Address(RVA = "0x79CB30", Offset = "0x79B530", VA = "0x18079CB30")]
		public PartnerCookBehaviour()
		{
		}

		// Token: 0x0400474D RID: 18253
		[Token(Token = "0x400474D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector3 EXTRA_COOKER_MOVEMENT_OFFSET;

		// Token: 0x0400474E RID: 18254
		[Token(Token = "0x400474E")]
		[FieldOffset(Offset = "0xA0")]
		private Coroutine cookingCoroutine;

		// Token: 0x0400474F RID: 18255
		[Token(Token = "0x400474F")]
		[FieldOffset(Offset = "0xA8")]
		private Recipe selectedRecipe;

		// Token: 0x04004750 RID: 18256
		[Token(Token = "0x4004750")]
		[FieldOffset(Offset = "0xB0")]
		private bool shouldReturnIngredients;

		// Token: 0x04004751 RID: 18257
		[Token(Token = "0x4004751")]
		[FieldOffset(Offset = "0xB8")]
		private Action whenIngredientsReturn;
	}
}
