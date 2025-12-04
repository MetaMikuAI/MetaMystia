using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200032B RID: 811
	[Token(Token = "0x200032B")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardGetIng", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardGetIng", order = 0)]
	public class DLC5_RogueLikeCardGetIng : DLC5_RogueLikeCardGiveItem
	{
		// Token: 0x06001265 RID: 4709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001265")]
		[Address(RVA = "0x93E800", Offset = "0x93D200", VA = "0x18093E800", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001266")]
		[Address(RVA = "0x93E680", Offset = "0x93D080", VA = "0x18093E680", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001267")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardGetIng()
		{
		}
	}
}
