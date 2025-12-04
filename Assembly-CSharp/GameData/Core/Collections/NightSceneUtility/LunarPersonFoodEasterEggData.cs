using System;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000926 RID: 2342
	[Token(Token = "0x2000926")]
	[CreateAssetMenu(fileName = "DLC5_FoodEasterEgg_LunarPerson", menuName = "GameData Profile/Easter Egg Data/Lunar Person", order = 9)]
	public class LunarPersonFoodEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06003A6C RID: 14956 RVA: 0x00016200 File Offset: 0x00014400
		[Token(Token = "0x6003A6C")]
		[Address(RVA = "0x686ED0", Offset = "0x6858D0", VA = "0x180686ED0", Slot = "4")]
		public override bool CheckEasterEgg(GuestsManager.OrderBase lastOrder, GuestGroupController toEval, GuestGroupController.EvaluationResult oldResult, out GuestGroupController.EvaluationResult finalResult, out string specialDialog)
		{
			return default(bool);
		}

		// Token: 0x06003A6D RID: 14957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A6D")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public LunarPersonFoodEasterEggData()
		{
		}
	}
}
