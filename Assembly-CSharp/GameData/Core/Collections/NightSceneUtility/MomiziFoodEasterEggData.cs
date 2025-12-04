using System;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000929 RID: 2345
	[Token(Token = "0x2000929")]
	[CreateAssetMenu(fileName = "DLC1_FoodEasterEgg_Momizi", menuName = "GameData Profile/Easter Egg Data/Momizi", order = 6)]
	public class MomiziFoodEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06003A73 RID: 14963 RVA: 0x00016248 File Offset: 0x00014448
		[Token(Token = "0x6003A73")]
		[Address(RVA = "0x687480", Offset = "0x685E80", VA = "0x180687480", Slot = "4")]
		public override bool CheckEasterEgg(GuestsManager.OrderBase lastOrder, GuestGroupController toEval, GuestGroupController.EvaluationResult oldResult, out GuestGroupController.EvaluationResult finalResult, out string specialDialog)
		{
			return default(bool);
		}

		// Token: 0x06003A74 RID: 14964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A74")]
		[Address(RVA = "0x687660", Offset = "0x686060", VA = "0x180687660")]
		public MomiziFoodEasterEggData()
		{
		}

		// Token: 0x04003197 RID: 12695
		[Token(Token = "0x4003197")]
		[FieldOffset(Offset = "0x20")]
		public int chocolateId;
	}
}
