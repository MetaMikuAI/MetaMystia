using System;
using System.Collections;
using DayScene.UI.RogueLike;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace Night.BossBattle.DLC5_RogueLikeCard
{
	// Token: 0x02000158 RID: 344
	[Token(Token = "0x2000158")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardExpensiveBev", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardExpensiveBev", order = 26)]
	public class DLC5_RogueLikeCardExpensiveBev : RogueLikeCard
	{
		// Token: 0x06000825 RID: 2085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x827940", Offset = "0x826340", VA = "0x180827940", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000040E0 File Offset: 0x000022E0
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x827750", Offset = "0x826150", VA = "0x180827750", Slot = "8")]
		public override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			return default(bool);
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x827870", Offset = "0x826270", VA = "0x180827870", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardExpensiveBev()
		{
		}

		// Token: 0x04000774 RID: 1908
		[Token(Token = "0x4000774")]
		[FieldOffset(Offset = "0x38")]
		public DLC5_RogueLikeCardCheapBev.BevPropertySet[] BevPropertySets;
	}
}
