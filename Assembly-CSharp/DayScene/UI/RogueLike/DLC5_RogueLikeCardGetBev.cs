using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000326 RID: 806
	[Token(Token = "0x2000326")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardGetBev", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardGetBev", order = 1)]
	public class DLC5_RogueLikeCardGetBev : DLC5_RogueLikeCardGiveItem
	{
		// Token: 0x06001254 RID: 4692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001254")]
		[Address(RVA = "0x93E590", Offset = "0x93CF90", VA = "0x18093E590", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001255")]
		[Address(RVA = "0x93E3A0", Offset = "0x93CDA0", VA = "0x18093E3A0", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001256")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardGetBev()
		{
		}
	}
}
