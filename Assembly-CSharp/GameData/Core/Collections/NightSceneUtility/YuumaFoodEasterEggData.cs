using System;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x0200092E RID: 2350
	[Token(Token = "0x200092E")]
	[CreateAssetMenu(fileName = "DLC1_FoodEasterEgg_Yuuma", menuName = "GameData Profile/Easter Egg Data/Yuuma", order = 6)]
	public class YuumaFoodEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06003A7E RID: 14974 RVA: 0x000162A8 File Offset: 0x000144A8
		[Token(Token = "0x6003A7E")]
		[Address(RVA = "0x69B5B0", Offset = "0x699FB0", VA = "0x18069B5B0", Slot = "4")]
		public override bool CheckEasterEgg(GuestsManager.OrderBase lastOrder, GuestGroupController toEval, GuestGroupController.EvaluationResult oldResult, out GuestGroupController.EvaluationResult finalResult, out string specialDialog)
		{
			return default(bool);
		}

		// Token: 0x06003A7F RID: 14975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A7F")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public YuumaFoodEasterEggData()
		{
		}
	}
}
