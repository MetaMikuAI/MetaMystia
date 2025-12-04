using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000927 RID: 2343
	[Token(Token = "0x2000927")]
	[CreateAssetMenu(fileName = "FoodEasterEgg_Marisa", menuName = "GameData Profile/Easter Egg Data/Marisa", order = 10)]
	public class MarisaFoodEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06003A6E RID: 14958 RVA: 0x00016218 File Offset: 0x00014418
		[Token(Token = "0x6003A6E")]
		[Address(RVA = "0x6870C0", Offset = "0x685AC0", VA = "0x1806870C0", Slot = "4")]
		public override bool CheckEasterEgg(GuestsManager.OrderBase lastOrder, GuestGroupController toEval, GuestGroupController.EvaluationResult oldResult, out GuestGroupController.EvaluationResult finalResult, out string specialDialog)
		{
			return default(bool);
		}

		// Token: 0x06003A6F RID: 14959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A6F")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public MarisaFoodEasterEggData()
		{
		}

		// Token: 0x06003A70 RID: 14960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003A70")]
		[Address(RVA = "0x687280", Offset = "0x685C80", VA = "0x180687280")]
		[CompilerGenerated]
		internal static void <CheckEasterEgg>g__ResetFace|0_0(GuestGroupController guest)
		{
		}
	}
}
