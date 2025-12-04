using System;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x0200092D RID: 2349
	[Token(Token = "0x200092D")]
	[CreateAssetMenu(fileName = "DLC4_FoodEasterEgg_Remilia", menuName = "GameData Profile/Easter Egg Data/Remilia", order = 5)]
	public class RemiliaFoodEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06003A7C RID: 14972 RVA: 0x00016290 File Offset: 0x00014490
		[Token(Token = "0x6003A7C")]
		[Address(RVA = "0x689750", Offset = "0x688150", VA = "0x180689750", Slot = "4")]
		public override bool CheckEasterEgg(GuestsManager.OrderBase lastOrder, GuestGroupController toEval, GuestGroupController.EvaluationResult oldResult, out GuestGroupController.EvaluationResult finalResult, out string specialDialog)
		{
			return default(bool);
		}

		// Token: 0x06003A7D RID: 14973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A7D")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public RemiliaFoodEasterEggData()
		{
		}
	}
}
