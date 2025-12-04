using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.CharacterUtility;
using GameData.Core.Collections.NightSceneUtility;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using UnityEngine;

namespace NightScene.GuestManagementUtility
{
	// Token: 0x020005D6 RID: 1494
	[Token(Token = "0x20005D6")]
	public class SpecialGuestsController : GuestGroupController
	{
		// Token: 0x0600227F RID: 8831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600227F")]
		[Address(RVA = "0x51DA30", Offset = "0x51C430", VA = "0x18051DA30")]
		public SpecialGuestsController(SpecialGuest specialGuests, Vector3? overrideSpawnPosition, Action<AStarInputGeneratorComponent> postprocessCharacterCallback, GuestGroupController.LeaveType leaveType, SpecialGuestsController.GuestSpawnType guestSpawnType)
		{
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002280")]
		[Address(RVA = "0x51DDD0", Offset = "0x51C7D0", VA = "0x18051DDD0")]
		public SpecialGuestsController(SpecialGuest specialGuests, Action<AStarInputGeneratorComponent> postprocessCharacterCallback, GuestGroupController.LeaveType leaveType, SpecialGuestsController.GuestSpawnType guestSpawnType, AStarInputGeneratorComponent[] guestInstances, bool isDominated = false)
		{
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06002281 RID: 8833 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002282 RID: 8834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AC")]
		public Action<SpecialGuestsController, Action> OnPostLeaveSpellCardCallback
		{
			[Token(Token = "0x6002281")]
			[Address(RVA = "0x48A4B0", Offset = "0x488EB0", VA = "0x18048A4B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002282")]
			[Address(RVA = "0x51E280", Offset = "0x51CC80", VA = "0x18051E280")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06002283 RID: 8835 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002284 RID: 8836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AD")]
		public SpecialGuestsController.CanUseSpellCardDelegate CheckCanUseSpellCardCallback
		{
			[Token(Token = "0x6002283")]
			[Address(RVA = "0x51DFC0", Offset = "0x51C9C0", VA = "0x18051DFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002284")]
			[Address(RVA = "0x51E250", Offset = "0x51CC50", VA = "0x18051E250")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06002285 RID: 8837 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002286 RID: 8838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AE")]
		public SpecialGuest SpecialGuest
		{
			[Token(Token = "0x6002285")]
			[Address(RVA = "0x48A9A0", Offset = "0x4893A0", VA = "0x18048A9A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002286")]
			[Address(RVA = "0x51E2C0", Offset = "0x51CCC0", VA = "0x18051E2C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06002287 RID: 8839 RVA: 0x0000CB58 File Offset: 0x0000AD58
		// (set) Token: 0x06002288 RID: 8840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004AF")]
		public SpecialGuestsController.GuestSpawnType GuestControllerSpawnType
		{
			[Token(Token = "0x6002287")]
			[Address(RVA = "0x51E1F0", Offset = "0x51CBF0", VA = "0x18051E1F0")]
			[CompilerGenerated]
			get
			{
				return SpecialGuestsController.GuestSpawnType.Normal;
			}
			[Token(Token = "0x6002288")]
			[Address(RVA = "0x51E270", Offset = "0x51CC70", VA = "0x18051E270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06002289 RID: 8841 RVA: 0x0000CB70 File Offset: 0x0000AD70
		[Token(Token = "0x170004B0")]
		public bool IsHerself
		{
			[Token(Token = "0x6002289")]
			[Address(RVA = "0x51E240", Offset = "0x51CC40", VA = "0x18051E240")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x0600228A RID: 8842 RVA: 0x0000CB88 File Offset: 0x0000AD88
		[Token(Token = "0x170004B1")]
		public bool IsControlled
		{
			[Token(Token = "0x600228A")]
			[Address(RVA = "0x51E230", Offset = "0x51CC30", VA = "0x18051E230")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x0600228B RID: 8843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B2")]
		public override int[] EvaluateLikeFoodTags
		{
			[Token(Token = "0x600228B")]
			[Address(RVA = "0x51E0E0", Offset = "0x51CAE0", VA = "0x18051E0E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B3")]
		public override int[] EvaluateHateFoodTags
		{
			[Token(Token = "0x600228C")]
			[Address(RVA = "0x51DFD0", Offset = "0x51C9D0", VA = "0x18051DFD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x0600228D RID: 8845 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600228E RID: 8846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B4")]
		public Func<int, string, string> OrderFoodTextOverrideCallback
		{
			[Token(Token = "0x600228D")]
			[Address(RVA = "0x45EA30", Offset = "0x45D430", VA = "0x18045EA30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600228E")]
			[Address(RVA = "0x51E2A0", Offset = "0x51CCA0", VA = "0x18051E2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x0600228F RID: 8847 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002290 RID: 8848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170004B5")]
		public Func<int, string, string> OrderBevTextOverrideCallback
		{
			[Token(Token = "0x600228F")]
			[Address(RVA = "0x45F000", Offset = "0x45DA00", VA = "0x18045F000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002290")]
			[Address(RVA = "0x45F190", Offset = "0x45DB90", VA = "0x18045F190")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002291")]
		[Address(RVA = "0x51C260", Offset = "0x51AC60", VA = "0x18051C260", Slot = "6")]
		public override IEnumerable<GuestBase> GetAllGuests()
		{
			return null;
		}

		// Token: 0x06002292 RID: 8850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002292")]
		[Address(RVA = "0x51C960", Offset = "0x51B360", VA = "0x18051C960", Slot = "8")]
		public override string OnGetGuestName()
		{
			return null;
		}

		// Token: 0x06002293 RID: 8851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002293")]
		[Address(RVA = "0x51C9A0", Offset = "0x51B3A0", VA = "0x18051C9A0", Slot = "7")]
		public override string OnRequestIdleDialog(out Transform speaker)
		{
			return null;
		}

		// Token: 0x06002294 RID: 8852 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
		[Token(Token = "0x6002294")]
		[Address(RVA = "0x518720", Offset = "0x517120", VA = "0x180518720", Slot = "10")]
		protected override int GetNoMoneyDialogIndex()
		{
			return 0;
		}

		// Token: 0x06002295 RID: 8853 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		[Token(Token = "0x6002295")]
		[Address(RVA = "0x4470A0", Offset = "0x445AA0", VA = "0x1804470A0", Slot = "11")]
		protected override int GetNoMoneyAngryDialogIndex()
		{
			return 0;
		}

		// Token: 0x06002296 RID: 8854 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		[Token(Token = "0x6002296")]
		[Address(RVA = "0x51C570", Offset = "0x51AF70", VA = "0x18051C570", Slot = "12")]
		protected override int GetRepellDialogIndex()
		{
			return 0;
		}

		// Token: 0x06002297 RID: 8855 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		[Token(Token = "0x6002297")]
		[Address(RVA = "0x51C580", Offset = "0x51AF80", VA = "0x18051C580", Slot = "13")]
		protected override int GetSeenRepellDialogIndex()
		{
			return 0;
		}

		// Token: 0x06002298 RID: 8856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002298")]
		[Address(RVA = "0x51C310", Offset = "0x51AD10", VA = "0x18051C310", Slot = "9")]
		protected override string GetEvaluationDialog(int evalulationIndex, out Transform speaker)
		{
			return null;
		}

		// Token: 0x06002299 RID: 8857 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002299")]
		[Address(RVA = "0x51CDF0", Offset = "0x51B7F0", VA = "0x18051CDF0", Slot = "14")]
		public override GuestsManager.OrderBase PostGenerateOrder(bool isFreeOrder, out string orderGenerationMessage)
		{
			return null;
		}

		// Token: 0x0600229A RID: 8858 RVA: 0x0000CC00 File Offset: 0x0000AE00
		[Token(Token = "0x600229A")]
		[Address(RVA = "0x51C190", Offset = "0x51AB90", VA = "0x18051C190")]
		private bool FillterTags(int tagId, Func<RunTimePlayerData.PopType, int[]> onGetPopSystemDataCallback, int[] popTags)
		{
			return default(bool);
		}

		// Token: 0x0600229B RID: 8859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600229B")]
		[Address(RVA = "0x51C510", Offset = "0x51AF10", VA = "0x18051C510")]
		public string GetOrderFoodText(GuestsManager.SpecialOrder specialOrder)
		{
			return null;
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600229C")]
		[Address(RVA = "0x51C4B0", Offset = "0x51AEB0", VA = "0x18051C4B0")]
		public string GetOrderBevText(GuestsManager.SpecialOrder specialOrder)
		{
			return null;
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600229D")]
		[Address(RVA = "0x51D530", Offset = "0x51BF30", VA = "0x18051D530")]
		public void TriggerPositiveBuff([Optional] Action onFinish, bool realSpawn = true)
		{
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600229E")]
		[Address(RVA = "0x51C590", Offset = "0x51AF90", VA = "0x18051C590")]
		private SpellExecutionContext GetSpellExecutionContext(Action onFinish, bool shouldRecordSpellNum)
		{
			return null;
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B6")]
		private SpellBase GuestSpellBase
		{
			[Token(Token = "0x600229F")]
			[Address(RVA = "0x51E200", Offset = "0x51CC00", VA = "0x18051E200")]
			get
			{
				return null;
			}
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A0")]
		[Address(RVA = "0x51D370", Offset = "0x51BD70", VA = "0x18051D370")]
		public void TriggerNegativeBuff([Optional] Action onFinish, bool realSpawn = true)
		{
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A1")]
		[Address(RVA = "0x51D250", Offset = "0x51BC50", VA = "0x18051D250")]
		public void TriggerLeaveBuff([Optional] Action onFinish)
		{
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A2")]
		[Address(RVA = "0x51D840", Offset = "0x51C240", VA = "0x18051D840")]
		private void TriggerPostLeaveCallback(Action onFinish)
		{
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x0000CC18 File Offset: 0x0000AE18
		[Token(Token = "0x60022A3")]
		[Address(RVA = "0x51C660", Offset = "0x51B060", VA = "0x18051C660")]
		private bool IfCanUseSpellCard(SpecialGuestsController.SpellType spellType, [Optional] Action onFinish)
		{
			return default(bool);
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A4")]
		[Address(RVA = "0x51CB50", Offset = "0x51B550", VA = "0x18051CB50", Slot = "15")]
		public override void PostEvaluation(GuestGroupController.EvaluationResult evaluationType, Action onFinish, bool finishedByPartner, bool obtainedExGoodRatingWithModifiers)
		{
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A5")]
		[Address(RVA = "0x51D880", Offset = "0x51C280", VA = "0x18051D880")]
		private void TryAlterKizunaValue(int amount)
		{
		}

		// Token: 0x04001F28 RID: 7976
		[Token(Token = "0x4001F28")]
		private const int KEINE_ID = 4;

		// Token: 0x04001F29 RID: 7977
		[Token(Token = "0x4001F29")]
		private const int TEWI_HARD_SELL = 16;

		// Token: 0x04001F2A RID: 7978
		[Token(Token = "0x4001F2A")]
		private const int TEWI = 29;

		// Token: 0x04001F2B RID: 7979
		[Token(Token = "0x4001F2B")]
		private const float MEILING_BUFF_EXTRA_KIZUNA = 1.5f;

		// Token: 0x04001F2C RID: 7980
		[Token(Token = "0x4001F2C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private bool ratingBuffer;

		// Token: 0x04001F2D RID: 7981
		[Token(Token = "0x4001F2D")]
		public const int KOISHI_ID = 2006;

		// Token: 0x020005D7 RID: 1495
		// (Invoke) Token: 0x060022A7 RID: 8871
		[Token(Token = "0x20005D7")]
		public delegate bool CanUseSpellCardDelegate(SpecialGuestsController guestGroup);

		// Token: 0x020005D8 RID: 1496
		[Token(Token = "0x20005D8")]
		public enum GuestSpawnType
		{
			// Token: 0x04001F36 RID: 7990
			[Token(Token = "0x4001F36")]
			[InspectorName("普通")]
			Normal,
			// Token: 0x04001F37 RID: 7991
			[Token(Token = "0x4001F37")]
			[InspectorName("挑战模式中，Boss生成的分身幻影")]
			GhostInChallenge,
			// Token: 0x04001F38 RID: 7992
			[Token(Token = "0x4001F38")]
			[InspectorName("阿燐死灰复燃出的怨灵")]
			OrinGhost,
			// Token: 0x04001F39 RID: 7993
			[Token(Token = "0x4001F39")]
			[InspectorName("猯藏变化出的小弟")]
			MamizouBrother,
			// Token: 0x04001F3A RID: 7994
			[Token(Token = "0x4001F3A")]
			[InspectorName("露易兹具现化的影像")]
			LuizePhoto,
			// Token: 0x04001F3B RID: 7995
			[Token(Token = "0x4001F3B")]
			[InspectorName("特殊·实现灵梦塞钱箱功能召唤出的特殊“灵梦”")]
			HakureiMoneyBoxReimu,
			// Token: 0x04001F3C RID: 7996
			[Token(Token = "0x4001F3C")]
			[InspectorName("剧情客人")]
			Manual
		}

		// Token: 0x020005D9 RID: 1497
		[Token(Token = "0x20005D9")]
		private enum SpellType
		{
			// Token: 0x04001F3E RID: 7998
			[Token(Token = "0x4001F3E")]
			Positive,
			// Token: 0x04001F3F RID: 7999
			[Token(Token = "0x4001F3F")]
			Negative,
			// Token: 0x04001F40 RID: 8000
			[Token(Token = "0x4001F40")]
			Leave
		}
	}
}
