using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CFA RID: 3322
	[Token(Token = "0x2000CFA")]
	public class PartnerBossBehaviour : PartnerBase
	{
		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06004D21 RID: 19745 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004D22 RID: 19746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B32")]
		private CookController TargetCooker
		{
			[Token(Token = "0x6004D21")]
			[Address(RVA = "0x4D1EE0", Offset = "0x4D08E0", VA = "0x1804D1EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D22")]
			[Address(RVA = "0x4D2630", Offset = "0x4D1030", VA = "0x1804D2630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06004D23 RID: 19747 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004D24 RID: 19748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B33")]
		private GuestsManager.OrderBase FocusingOrder
		{
			[Token(Token = "0x6004D23")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D24")]
			[Address(RVA = "0x3F2100", Offset = "0x3F0B00", VA = "0x1803F2100")]
			set
			{
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06004D25 RID: 19749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B34")]
		private IEnumerable<CookController> AllAvailableCookerCanUseByPartner
		{
			[Token(Token = "0x6004D25")]
			[Address(RVA = "0x798ED0", Offset = "0x7978D0", VA = "0x180798ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004D26 RID: 19750 RVA: 0x0001BD98 File Offset: 0x00019F98
		[Token(Token = "0x6004D26")]
		[Address(RVA = "0x793FF0", Offset = "0x7929F0", VA = "0x180793FF0", Slot = "8")]
		public override PartnerBase.PartnerType GetPartnerType()
		{
			return PartnerBase.PartnerType.Cook;
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D27")]
		[Address(RVA = "0x793780", Offset = "0x792180", VA = "0x180793780")]
		private string DrawOnGUI()
		{
			return null;
		}

		// Token: 0x06004D28 RID: 19752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D28")]
		[Address(RVA = "0x7946B0", Offset = "0x7930B0", VA = "0x1807946B0", Slot = "4")]
		protected override void OnInitialize()
		{
		}

		// Token: 0x06004D29 RID: 19753 RVA: 0x0001BDB0 File Offset: 0x00019FB0
		[Token(Token = "0x6004D29")]
		[Address(RVA = "0x797050", Offset = "0x795A50", VA = "0x180797050")]
		private bool TryAcceptOrder(GuestsManager.OrderBase targetOrder)
		{
			return default(bool);
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D2A")]
		[Address(RVA = "0x796EC0", Offset = "0x7958C0", VA = "0x180796EC0", Slot = "7")]
		protected override void ResetStatus()
		{
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D2B")]
		[Address(RVA = "0x7946A0", Offset = "0x7930A0", VA = "0x1807946A0", Slot = "6")]
		public override void OnDestroy()
		{
		}

		// Token: 0x06004D2C RID: 19756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D2C")]
		[Address(RVA = "0x795900", Offset = "0x794300", VA = "0x180795900", Slot = "5")]
		protected override void OnPlayIdleState()
		{
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x0001BDC8 File Offset: 0x00019FC8
		[Token(Token = "0x6004D2D")]
		[Address(RVA = "0x7940E0", Offset = "0x792AE0", VA = "0x1807940E0")]
		public bool OnCookIdleReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, object additionalInformation)
		{
			return default(bool);
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D2E")]
		[Address(RVA = "0x7962E0", Offset = "0x794CE0", VA = "0x1807962E0")]
		private void PlayMoveToCookerState()
		{
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x0001BDE0 File Offset: 0x00019FE0
		[Token(Token = "0x6004D2F")]
		[Address(RVA = "0x7954E0", Offset = "0x793EE0", VA = "0x1807954E0")]
		private bool OnMoveToCookerReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, object additionalInformation)
		{
			return default(bool);
		}

		// Token: 0x06004D30 RID: 19760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D30")]
		[Address(RVA = "0x795800", Offset = "0x794200", VA = "0x180795800")]
		private void OnMoveToCookerStateInterrupt()
		{
		}

		// Token: 0x06004D31 RID: 19761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D31")]
		[Address(RVA = "0x795ED0", Offset = "0x7948D0", VA = "0x180795ED0")]
		private void PlayCookState()
		{
		}

		// Token: 0x06004D32 RID: 19762 RVA: 0x0001BDF8 File Offset: 0x00019FF8
		[Token(Token = "0x6004D32")]
		[Address(RVA = "0x794330", Offset = "0x792D30", VA = "0x180794330")]
		private bool OnCookingReceiveSystemChange(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, object additionalInformation)
		{
			return default(bool);
		}

		// Token: 0x06004D33 RID: 19763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D33")]
		[Address(RVA = "0x794500", Offset = "0x792F00", VA = "0x180794500")]
		private void OnCookingStateInterrupt()
		{
		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D34")]
		[Address(RVA = "0x793DF0", Offset = "0x7927F0", VA = "0x180793DF0")]
		private IEnumerator EmployeeCookingCoroutine()
		{
			return null;
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06004D35 RID: 19765 RVA: 0x0001BE10 File Offset: 0x0001A010
		[Token(Token = "0x17000B35")]
		private bool WaitressOrBarmaid
		{
			[Token(Token = "0x6004D35")]
			[Address(RVA = "0x799010", Offset = "0x797A10", VA = "0x180799010")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x0001BE28 File Offset: 0x0001A028
		[Token(Token = "0x6004D36")]
		[Address(RVA = "0x794000", Offset = "0x792A00", VA = "0x180794000")]
		private Vector3Int GetTargetPosition(PartnerBase.InventoryType inventoryType)
		{
			return default(Vector3Int);
		}

		// Token: 0x06004D37 RID: 19767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D37")]
		[Address(RVA = "0x796910", Offset = "0x795310", VA = "0x180796910")]
		private void PlayMoveToExtractFromInventoryState()
		{
		}

		// Token: 0x06004D38 RID: 19768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D38")]
		[Address(RVA = "0x7961E0", Offset = "0x794BE0", VA = "0x1807961E0")]
		private void PlayExtractFromInventoryState()
		{
		}

		// Token: 0x06004D39 RID: 19769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D39")]
		[Address(RVA = "0x793EF0", Offset = "0x7928F0", VA = "0x180793EF0")]
		private IEnumerator EmployeeExtractFromInventoryCoroutine()
		{
			return null;
		}

		// Token: 0x06004D3A RID: 19770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D3A")]
		[Address(RVA = "0x796640", Offset = "0x795040", VA = "0x180796640")]
		private void PlayMoveToDeliverState()
		{
		}

		// Token: 0x06004D3B RID: 19771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D3B")]
		[Address(RVA = "0x796080", Offset = "0x794A80", VA = "0x180796080")]
		private void PlayDeliverState()
		{
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D3C")]
		[Address(RVA = "0x793E70", Offset = "0x792870", VA = "0x180793E70")]
		private IEnumerator EmployeeDeliver()
		{
			return null;
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D3D")]
		[Address(RVA = "0x796D70", Offset = "0x795770", VA = "0x180796D70")]
		private void PlayThrowDeliverState()
		{
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D3E")]
		[Address(RVA = "0x793F70", Offset = "0x792970", VA = "0x180793F70")]
		private IEnumerator ExecuteThrowDeliver()
		{
			return null;
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D3F")]
		[Address(RVA = "0x796C00", Offset = "0x795600", VA = "0x180796C00", Slot = "9")]
		protected override void PlayReturnToInventoryState(Action onFinish)
		{
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x0001BE40 File Offset: 0x0001A040
		[Token(Token = "0x6004D40")]
		[Address(RVA = "0x795990", Offset = "0x794390", VA = "0x180795990")]
		private bool OnPlayerOccupyADesk(PartnerManager.OrderChangeContext orderChangeContext, GuestsManager.OrderBase targetOrder, object additionalInformation)
		{
			return default(bool);
		}

		// Token: 0x06004D41 RID: 19777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D41")]
		[Address(RVA = "0x795AD0", Offset = "0x7944D0", VA = "0x180795AD0")]
		private void OnPlayerOccupyCauseInterruptAndReset()
		{
		}

		// Token: 0x06004D42 RID: 19778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D42")]
		[Address(RVA = "0x795D30", Offset = "0x794730", VA = "0x180795D30")]
		private void OnPlayerOccupyCauseInterruptAndReturnToFoodStorage()
		{
		}

		// Token: 0x06004D43 RID: 19779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D43")]
		[Address(RVA = "0x795B90", Offset = "0x794590", VA = "0x180795B90")]
		private void OnPlayerOccupyCauseInterruptAndReturnToBeverageShelf()
		{
		}

		// Token: 0x06004D44 RID: 19780 RVA: 0x0001BE58 File Offset: 0x0001A058
		[Token(Token = "0x6004D44")]
		[Address(RVA = "0x798080", Offset = "0x796A80", VA = "0x180798080")]
		private PartnerManager.GetCookerInfo TryGetCooker(GuestsManager.NormalOrder focusingOrder, out CookController cookController, out Recipe targetRecipe)
		{
			return PartnerManager.GetCookerInfo.AllCookerBusy;
		}

		// Token: 0x06004D45 RID: 19781 RVA: 0x0001BE70 File Offset: 0x0001A070
		[Token(Token = "0x6004D45")]
		[Address(RVA = "0x797CD0", Offset = "0x7966D0", VA = "0x180797CD0")]
		private PartnerManager.GetCookerInfo TryGetCooker(GuestsManager.SpecialOrder focusingOrder, out CookController cookController, out Recipe targetRecipe, int[] specGuestLikeTag, int[] specGuestHateTag, int bevScore, bool haveBevSatisfy, PartnerBossInfo.EvalCondition evalCondition, out PartnerBossInfo.EvalCondition finalCondition, int maxPrice)
		{
			return PartnerManager.GetCookerInfo.AllCookerBusy;
		}

		// Token: 0x06004D46 RID: 19782 RVA: 0x0001BE88 File Offset: 0x0001A088
		[Token(Token = "0x6004D46")]
		[Address(RVA = "0x793490", Offset = "0x791E90", VA = "0x180793490")]
		private bool CheckFoodCanSatisfyGuest(Sellable food, int[] specGuestLikeTag, int[] specGuestHateTag, int bevScore, int requestedFoodId, bool haveBevSatisfy, bool canCook, PartnerBossInfo.EvalCondition? targetCondition, int remainMoney)
		{
			return default(bool);
		}

		// Token: 0x06004D47 RID: 19783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D47")]
		[Address(RVA = "0x798E20", Offset = "0x797820", VA = "0x180798E20")]
		public PartnerBossBehaviour()
		{
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D4A")]
		[Address(RVA = "0x798330", Offset = "0x796D30", VA = "0x180798330")]
		[CompilerGenerated]
		internal static string <DrawOnGUI>g__CheckNull|27_0(Sellable sellable)
		{
			return null;
		}

		// Token: 0x06004D4B RID: 19787 RVA: 0x0001BEB8 File Offset: 0x0001A0B8
		[Token(Token = "0x6004D4B")]
		[Address(RVA = "0x798B10", Offset = "0x797510", VA = "0x180798B10")]
		[CompilerGenerated]
		private bool <OnInitialize>g__HaveMatchedCookerOrTag|28_7(Recipe recipe)
		{
			return default(bool);
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D52")]
		[Address(RVA = "0x7983F0", Offset = "0x796DF0", VA = "0x1807983F0")]
		[CompilerGenerated]
		internal static IEnumerator <ExecuteThrowDeliver>g__Schedule|55_5(Coroutine coroutine, Action onFinish)
		{
			return null;
		}

		// Token: 0x06004D53 RID: 19795 RVA: 0x0001BF18 File Offset: 0x0001A118
		[Token(Token = "0x6004D53")]
		[Address(RVA = "0x798200", Offset = "0x796C00", VA = "0x180798200")]
		[CompilerGenerated]
		internal static bool <CheckFoodCanSatisfyGuest>g__IsEffective|63_0(int num, int target, PartnerBossInfo.EvalCondition? evalCondition, ref PartnerBossBehaviour.<>c__DisplayClass63_0 A_3)
		{
			return default(bool);
		}

		// Token: 0x06004D54 RID: 19796 RVA: 0x0001BF30 File Offset: 0x0001A130
		[Token(Token = "0x6004D54")]
		[Address(RVA = "0x798190", Offset = "0x796B90", VA = "0x180798190")]
		[CompilerGenerated]
		internal static int <CheckFoodCanSatisfyGuest>g__GetTargetScore|63_1(PartnerBossInfo.EvalCondition? evalCondition)
		{
			return 0;
		}

		// Token: 0x06004D55 RID: 19797 RVA: 0x0001BF48 File Offset: 0x0001A148
		[Token(Token = "0x6004D55")]
		[Address(RVA = "0x798130", Offset = "0x796B30", VA = "0x180798130")]
		[CompilerGenerated]
		internal static bool <CheckFoodCanSatisfyGuest>g__CouldBeyond|63_2(ref PartnerBossBehaviour.<>c__DisplayClass63_0 A_0)
		{
			return default(bool);
		}

		// Token: 0x040046FA RID: 18170
		[Token(Token = "0x40046FA")]
		private const int NORMAL_EVAL_TARGET_SCORE = 2;

		// Token: 0x040046FB RID: 18171
		[Token(Token = "0x40046FB")]
		private const int GOOD_EVAL_TARGET_SCORE = 3;

		// Token: 0x040046FC RID: 18172
		[Token(Token = "0x40046FC")]
		private const int EXGOOD_EVAL_TARGET_SCORE = 4;

		// Token: 0x040046FD RID: 18173
		[Token(Token = "0x40046FD")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector3 EXTRA_COOKER_MOVEMENT_OFFSET;

		// Token: 0x040046FE RID: 18174
		[Token(Token = "0x40046FE")]
		[FieldOffset(Offset = "0xA0")]
		private List<Sellable> BevList;

		// Token: 0x040046FF RID: 18175
		[Token(Token = "0x40046FF")]
		[FieldOffset(Offset = "0xA8")]
		private PartnerBossInfo.EvalCondition currentCondition;

		// Token: 0x04004700 RID: 18176
		[Token(Token = "0x4004700")]
		[FieldOffset(Offset = "0xAC")]
		private PartnerBossBehaviour.CurrentWorkingMode currentWorkingMode;

		// Token: 0x04004701 RID: 18177
		[Token(Token = "0x4004701")]
		[FieldOffset(Offset = "0xB0")]
		private List<PartnerBossInfo.EvalCondition> evalConditions;

		// Token: 0x04004702 RID: 18178
		[Token(Token = "0x4004702")]
		[FieldOffset(Offset = "0xB8")]
		private bool haveInitialize;

		// Token: 0x04004703 RID: 18179
		[Token(Token = "0x4004703")]
		[FieldOffset(Offset = "0xC0")]
		private int[] partnerCanUseCookerId;

		// Token: 0x04004704 RID: 18180
		[Token(Token = "0x4004704")]
		[FieldOffset(Offset = "0xC8")]
		private new PartnerBossInfo PartnerData;

		// Token: 0x04004705 RID: 18181
		[Token(Token = "0x4004705")]
		[FieldOffset(Offset = "0xD0")]
		private List<Sellable> privatePartnerStorage;

		// Token: 0x04004706 RID: 18182
		[Token(Token = "0x4004706")]
		[FieldOffset(Offset = "0xD8")]
		private List<Recipe> RecipeList;

		// Token: 0x04004707 RID: 18183
		[Token(Token = "0x4004707")]
		[FieldOffset(Offset = "0xE0")]
		private Recipe selectedRecipe;

		// Token: 0x04004708 RID: 18184
		[Token(Token = "0x4004708")]
		[FieldOffset(Offset = "0xE8")]
		private Sellable targetBev;

		// Token: 0x04004709 RID: 18185
		[Token(Token = "0x4004709")]
		[FieldOffset(Offset = "0xF0")]
		private Sellable targetFood;

		// Token: 0x0400470A RID: 18186
		[Token(Token = "0x400470A")]
		[FieldOffset(Offset = "0xF8")]
		private Coroutine workingCorotine;

		// Token: 0x0400470C RID: 18188
		[Token(Token = "0x400470C")]
		[FieldOffset(Offset = "0x108")]
		private Action<PartnerBossBehaviour.CurrentWorkingMode> getRequestedFromInventoryCallback;

		// Token: 0x0400470D RID: 18189
		[Token(Token = "0x400470D")]
		[FieldOffset(Offset = "0x110")]
		private Action<GuestTableDisplayer> executeServeCallback;

		// Token: 0x0400470E RID: 18190
		[Token(Token = "0x400470E")]
		[FieldOffset(Offset = "0x118")]
		private Func<Vector3Int> getInventoryPositionCallback;

		// Token: 0x02000CFB RID: 3323
		[Token(Token = "0x2000CFB")]
		private enum CurrentWorkingMode
		{
			// Token: 0x04004710 RID: 18192
			[Token(Token = "0x4004710")]
			Cook,
			// Token: 0x04004711 RID: 18193
			[Token(Token = "0x4004711")]
			TryGetFood,
			// Token: 0x04004712 RID: 18194
			[Token(Token = "0x4004712")]
			TryGetBev,
			// Token: 0x04004713 RID: 18195
			[Token(Token = "0x4004713")]
			Waitress,
			// Token: 0x04004714 RID: 18196
			[Token(Token = "0x4004714")]
			BackAndTurnBev,
			// Token: 0x04004715 RID: 18197
			[Token(Token = "0x4004715")]
			BackAndTurnFood,
			// Token: 0x04004716 RID: 18198
			[Token(Token = "0x4004716")]
			Idle
		}
	}
}
