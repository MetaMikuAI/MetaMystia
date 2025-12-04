using System;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000922 RID: 2338
	[Token(Token = "0x2000922")]
	[CreateAssetMenu(fileName = "Koishi Easter Egg", menuName = "GameData Profile/Easter Egg Data/Koishi", order = 0)]
	public class KoishiFoodEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06003A62 RID: 14946 RVA: 0x000161D0 File Offset: 0x000143D0
		[Token(Token = "0x6003A62")]
		[Address(RVA = "0x685350", Offset = "0x683D50", VA = "0x180685350", Slot = "4")]
		public override bool CheckEasterEgg(GuestsManager.OrderBase lastOrder, GuestGroupController toEval, GuestGroupController.EvaluationResult oldResult, out GuestGroupController.EvaluationResult finalResult, out string specialDialog)
		{
			return default(bool);
		}

		// Token: 0x06003A63 RID: 14947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A63")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public KoishiFoodEasterEggData()
		{
		}
	}
}
