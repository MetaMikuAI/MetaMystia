using System;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000928 RID: 2344
	[Token(Token = "0x2000928")]
	[CreateAssetMenu(fileName = "DLC4_FoodEasterEgg_Medicine", menuName = "GameData Profile/Easter Egg Data/Medicine", order = 0)]
	public class MedicineFoodEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06003A71 RID: 14961 RVA: 0x00016230 File Offset: 0x00014430
		[Token(Token = "0x6003A71")]
		[Address(RVA = "0x6873A0", Offset = "0x685DA0", VA = "0x1806873A0", Slot = "4")]
		public override bool CheckEasterEgg(GuestsManager.OrderBase lastOrder, GuestGroupController toEval, GuestGroupController.EvaluationResult oldResult, out GuestGroupController.EvaluationResult finalResult, out string specialDialog)
		{
			return default(bool);
		}

		// Token: 0x06003A72 RID: 14962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A72")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public MedicineFoodEasterEggData()
		{
		}
	}
}
