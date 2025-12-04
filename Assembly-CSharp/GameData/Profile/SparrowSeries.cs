using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C87 RID: 3207
	[Token(Token = "0x2000C87")]
	[CreateAssetMenu(fileName = "SparrowSeries", menuName = "GameData Profile/Cooker Asset/SparrowSeries", order = 3)]
	public class SparrowSeries : CookerAssetBase
	{
		// Token: 0x06004AF0 RID: 19184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004AF0")]
		[Address(RVA = "0x783900", Offset = "0x782300", VA = "0x180783900", Slot = "10")]
		public override Sellable OnFinishCook(Sellable finishedFood, float qteScore, bool couldReturnIngredients)
		{
			return null;
		}

		// Token: 0x06004AF1 RID: 19185 RVA: 0x0001B300 File Offset: 0x00019500
		[Token(Token = "0x6004AF1")]
		[Address(RVA = "0x783860", Offset = "0x782260", VA = "0x180783860", Slot = "11")]
		public override int OnEvaluate(int evaluationResult, GuestGroupController guestGroupController, Sellable serveFood)
		{
			return 0;
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x0001B318 File Offset: 0x00019518
		[Token(Token = "0x6004AF2")]
		[Address(RVA = "0x7839B0", Offset = "0x7823B0", VA = "0x1807839B0", Slot = "13")]
		public override bool ShouldShowThisCookerBG(Sellable outputFood)
		{
			return default(bool);
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004AF3")]
		[Address(RVA = "0x77CD90", Offset = "0x77B790", VA = "0x18077CD90")]
		public SparrowSeries()
		{
		}

		// Token: 0x040044FC RID: 17660
		[Token(Token = "0x40044FC")]
		private const int SPARROW_SERIES_TAG_ID = -30;
	}
}
