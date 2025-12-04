using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.CharacterUtility;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using UnityEngine;

namespace NightScene.GuestManagementUtility
{
	// Token: 0x020005CD RID: 1485
	[Token(Token = "0x20005CD")]
	public class NormalGuestsController : GuestGroupController
	{
		// Token: 0x06002248 RID: 8776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002248")]
		[Address(RVA = "0x519EF0", Offset = "0x5188F0", VA = "0x180519EF0")]
		public NormalGuestsController(IEnumerable<NormalGuest> normalGuests, Vector3? overrideSpawnPosition, Action<AStarInputGeneratorComponent> postprocessCharacterCallback, GuestGroupController.LeaveType walkToLeave)
		{
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A9")]
		public NormalGuest[] NormalGuestsGroups
		{
			[Token(Token = "0x6002249")]
			[Address(RVA = "0x48A620", Offset = "0x489020", VA = "0x18048A620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x0600224A RID: 8778 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AA")]
		public override int[] EvaluateLikeFoodTags
		{
			[Token(Token = "0x600224A")]
			[Address(RVA = "0x51A580", Offset = "0x518F80", VA = "0x18051A580", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x0600224B RID: 8779 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AB")]
		public override int[] EvaluateHateFoodTags
		{
			[Token(Token = "0x600224B")]
			[Address(RVA = "0x51A460", Offset = "0x518E60", VA = "0x18051A460", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600224C RID: 8780 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600224C")]
		[Address(RVA = "0x48A620", Offset = "0x489020", VA = "0x18048A620", Slot = "6")]
		public override IEnumerable<GuestBase> GetAllGuests()
		{
			return null;
		}

		// Token: 0x0600224D RID: 8781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600224D")]
		[Address(RVA = "0x518730", Offset = "0x517130", VA = "0x180518730", Slot = "8")]
		public override string OnGetGuestName()
		{
			return null;
		}

		// Token: 0x0600224E RID: 8782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600224E")]
		[Address(RVA = "0x518940", Offset = "0x517340", VA = "0x180518940", Slot = "7")]
		public override string OnRequestIdleDialog(out Transform speaker)
		{
			return null;
		}

		// Token: 0x0600224F RID: 8783 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		[Token(Token = "0x600224F")]
		[Address(RVA = "0x518710", Offset = "0x517110", VA = "0x180518710", Slot = "10")]
		protected override int GetNoMoneyDialogIndex()
		{
			return 0;
		}

		// Token: 0x06002250 RID: 8784 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		[Token(Token = "0x6002250")]
		[Address(RVA = "0x5186B0", Offset = "0x5170B0", VA = "0x1805186B0", Slot = "11")]
		protected override int GetNoMoneyAngryDialogIndex()
		{
			return 0;
		}

		// Token: 0x06002251 RID: 8785 RVA: 0x0000CA08 File Offset: 0x0000AC08
		[Token(Token = "0x6002251")]
		[Address(RVA = "0x4470A0", Offset = "0x445AA0", VA = "0x1804470A0", Slot = "12")]
		protected override int GetRepellDialogIndex()
		{
			return 0;
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x0000CA20 File Offset: 0x0000AC20
		[Token(Token = "0x6002252")]
		[Address(RVA = "0x518720", Offset = "0x517120", VA = "0x180518720", Slot = "13")]
		protected override int GetSeenRepellDialogIndex()
		{
			return 0;
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002253")]
		[Address(RVA = "0x5185B0", Offset = "0x516FB0", VA = "0x1805185B0", Slot = "9")]
		protected override string GetEvaluationDialog(int evalulationIndex, out Transform speaker)
		{
			return null;
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002254")]
		[Address(RVA = "0x5193F0", Offset = "0x517DF0", VA = "0x1805193F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002255")]
		[Address(RVA = "0x518B40", Offset = "0x517540", VA = "0x180518B40", Slot = "14")]
		public override GuestsManager.OrderBase PostGenerateOrder(bool isFreeOrder, out string orderGenerationMessage)
		{
			return null;
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002256")]
		[Address(RVA = "0x518A20", Offset = "0x517420", VA = "0x180518A20", Slot = "15")]
		public override void PostEvaluation(GuestGroupController.EvaluationResult evaluationType, Action onFinish, bool finishedByPartner, bool _)
		{
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002257")]
		[Address(RVA = "0x519CC0", Offset = "0x5186C0", VA = "0x180519CC0")]
		[CompilerGenerated]
		internal static List<Recipe> <PostGenerateOrder>g__RemoveSoldOutRecipe|17_2(IEnumerable<Recipe> originList)
		{
			return null;
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002258")]
		[Address(RVA = "0x519B80", Offset = "0x518580", VA = "0x180519B80")]
		[CompilerGenerated]
		internal static List<Sellable> <PostGenerateOrder>g__RemoveSoldOutBev|17_3(List<Sellable> originList)
		{
			return null;
		}
	}
}
