using System;
using System.Collections.Generic;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000921 RID: 2337
	[Token(Token = "0x2000921")]
	public abstract class GuestFoodEasterEggData : ScriptableObject
	{
		// Token: 0x06003A5F RID: 14943 RVA: 0x000161A0 File Offset: 0x000143A0
		[Token(Token = "0x6003A5F")]
		[Address(RVA = "0x6846F0", Offset = "0x6830F0", VA = "0x1806846F0", Slot = "4")]
		public virtual bool CheckEasterEgg(GuestsManager.OrderBase lastOrder, GuestGroupController toEval, GuestGroupController.EvaluationResult oldResult, out GuestGroupController.EvaluationResult finalResult, out string specialDialog)
		{
			return default(bool);
		}

		// Token: 0x06003A60 RID: 14944 RVA: 0x000161B8 File Offset: 0x000143B8
		[Token(Token = "0x6003A60")]
		[Address(RVA = "0x684740", Offset = "0x683140", VA = "0x180684740", Slot = "5")]
		public virtual bool TryGetEasterEggIdleDialog(IEnumerable<PartnerBase> partners, out IEnumerable<string> idleDialog)
		{
			return default(bool);
		}

		// Token: 0x06003A61 RID: 14945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A61")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		protected GuestFoodEasterEggData()
		{
		}

		// Token: 0x04003190 RID: 12688
		[Token(Token = "0x4003190")]
		[FieldOffset(Offset = "0x18")]
		public int foodId;
	}
}
