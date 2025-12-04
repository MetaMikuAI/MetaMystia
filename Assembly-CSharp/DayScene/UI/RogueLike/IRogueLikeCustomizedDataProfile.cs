using System;
using System.Collections.Generic;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000441 RID: 1089
	[Token(Token = "0x2000441")]
	public interface IRogueLikeCustomizedDataProfile
	{
		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06001827 RID: 6183
		[Token(Token = "0x170002E3")]
		IReadOnlyList<Product> InitialProducts
		{
			[Token(Token = "0x6001827")]
			get;
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06001828 RID: 6184
		[Token(Token = "0x170002E4")]
		IReadOnlyList<int> InitialRecipePool
		{
			[Token(Token = "0x6001828")]
			get;
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001829 RID: 6185
		[Token(Token = "0x170002E5")]
		IReadOnlyList<int> InitialBevPool
		{
			[Token(Token = "0x6001829")]
			get;
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x0600182A RID: 6186
		[Token(Token = "0x170002E6")]
		IReadOnlyList<Vector2Int> BevLevelLinkToNum
		{
			[Token(Token = "0x600182A")]
			get;
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x0600182B RID: 6187
		[Token(Token = "0x170002E7")]
		IReadOnlyList<DLC5_RogueLikeDataProfile.RogueLikeRoundSetup> RoundSetups
		{
			[Token(Token = "0x600182B")]
			get;
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x0600182C RID: 6188
		[Token(Token = "0x170002E8")]
		IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup> MapSetups
		{
			[Token(Token = "0x600182C")]
			get;
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600182D RID: 6189
		[Token(Token = "0x170002E9")]
		IReadOnlyList<DLC5_RogueLikeDataProfile.CookerPriceSetup> CookerPriceSetups
		{
			[Token(Token = "0x600182D")]
			get;
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x0600182E RID: 6190
		[Token(Token = "0x170002EA")]
		IReadOnlyList<TriggerCardData> GachaTriggerData
		{
			[Token(Token = "0x600182E")]
			get;
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x0600182F RID: 6191
		[Token(Token = "0x170002EB")]
		IReadOnlyList<RogueLikeCardRewardPair> GachaRewardPairData
		{
			[Token(Token = "0x600182F")]
			get;
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001830 RID: 6192
		[Token(Token = "0x170002EC")]
		int RoundDuration
		{
			[Token(Token = "0x6001830")]
			get;
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001831 RID: 6193
		[Token(Token = "0x170002ED")]
		float GlobalProductMultiplier
		{
			[Token(Token = "0x6001831")]
			get;
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001832 RID: 6194
		[Token(Token = "0x170002EE")]
		float Level1RecipePriceMultiplier
		{
			[Token(Token = "0x6001832")]
			get;
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001833 RID: 6195
		[Token(Token = "0x170002EF")]
		float Level2RecipePriceMultiplier
		{
			[Token(Token = "0x6001833")]
			get;
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001834 RID: 6196
		[Token(Token = "0x170002F0")]
		float Level3RecipePriceMultiplier
		{
			[Token(Token = "0x6001834")]
			get;
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001835 RID: 6197
		[Token(Token = "0x170002F1")]
		float Level4RecipePriceMultiplier
		{
			[Token(Token = "0x6001835")]
			get;
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06001836 RID: 6198
		[Token(Token = "0x170002F2")]
		float Level5RecipePriceMultiplier
		{
			[Token(Token = "0x6001836")]
			get;
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06001837 RID: 6199
		[Token(Token = "0x170002F3")]
		int PartnerBasePrice
		{
			[Token(Token = "0x6001837")]
			get;
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06001838 RID: 6200
		[Token(Token = "0x170002F4")]
		int SpecialGuestPrice
		{
			[Token(Token = "0x6001838")]
			get;
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06001839 RID: 6201
		[Token(Token = "0x170002F5")]
		int EliteSpecialGuestPrice
		{
			[Token(Token = "0x6001839")]
			get;
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x0600183A RID: 6202
		[Token(Token = "0x170002F6")]
		int ClothesPrice
		{
			[Token(Token = "0x600183A")]
			get;
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600183B RID: 6203
		[Token(Token = "0x170002F7")]
		int DecorationPrice
		{
			[Token(Token = "0x600183B")]
			get;
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600183C RID: 6204
		[Token(Token = "0x170002F8")]
		int GachaNeedComboNum
		{
			[Token(Token = "0x600183C")]
			get;
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600183D RID: 6205
		[Token(Token = "0x170002F9")]
		int GachaNeedSpellNum
		{
			[Token(Token = "0x600183D")]
			get;
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x0600183E RID: 6206
		[Token(Token = "0x170002FA")]
		int GachaMaxCardNum
		{
			[Token(Token = "0x600183E")]
			get;
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600183F RID: 6207
		[Token(Token = "0x170002FB")]
		int BeginToSpawnDangerousCardRoundIndex
		{
			[Token(Token = "0x600183F")]
			get;
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001840 RID: 6208
		[Token(Token = "0x170002FC")]
		int UnlockAllLevel2SpotRoundIndex
		{
			[Token(Token = "0x6001840")]
			get;
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001841 RID: 6209
		[Token(Token = "0x170002FD")]
		int UnlockAllLevel3SpotRoundIndex
		{
			[Token(Token = "0x6001841")]
			get;
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06001842 RID: 6210
		[Token(Token = "0x170002FE")]
		float LuckyLeafExtraMultiplier
		{
			[Token(Token = "0x6001842")]
			get;
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001843 RID: 6211
		[Token(Token = "0x170002FF")]
		int AyaNewsBeginRoundIndex
		{
			[Token(Token = "0x6001843")]
			get;
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06001844 RID: 6212
		[Token(Token = "0x17000300")]
		int PriceToRefreshAyaNews
		{
			[Token(Token = "0x6001844")]
			get;
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06001845 RID: 6213
		[Token(Token = "0x17000301")]
		int AkyuuWashiPrice
		{
			[Token(Token = "0x6001845")]
			get;
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001846 RID: 6214
		[Token(Token = "0x17000302")]
		int EllenCandyPrice
		{
			[Token(Token = "0x6001846")]
			get;
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001847 RID: 6215
		[Token(Token = "0x17000303")]
		float KourindouDiscount
		{
			[Token(Token = "0x6001847")]
			get;
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001848 RID: 6216
		[Token(Token = "0x17000304")]
		int GachaRecipeInitialNum
		{
			[Token(Token = "0x6001848")]
			get;
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001849 RID: 6217
		[Token(Token = "0x17000305")]
		int GachaBevInitialNum
		{
			[Token(Token = "0x6001849")]
			get;
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600184A RID: 6218
		[Token(Token = "0x17000306")]
		int SelectRecipeInitialNum
		{
			[Token(Token = "0x600184A")]
			get;
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600184B RID: 6219
		[Token(Token = "0x17000307")]
		int BaseGachaNumWhenSettle
		{
			[Token(Token = "0x600184B")]
			get;
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x0600184C RID: 6220
		[Token(Token = "0x17000308")]
		int BaseMoveAction
		{
			[Token(Token = "0x600184C")]
			get;
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600184D RID: 6221
		[Token(Token = "0x17000309")]
		int BaseIngredientNumWhenGetRecipe
		{
			[Token(Token = "0x600184D")]
			get;
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600184E RID: 6222
		[Token(Token = "0x1700030A")]
		int StartFund
		{
			[Token(Token = "0x600184E")]
			get;
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600184F RID: 6223
		[Token(Token = "0x1700030B")]
		IReadOnlyList<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest> SpecialGuestVisitEverywhere
		{
			[Token(Token = "0x600184F")]
			get;
		}
	}
}
