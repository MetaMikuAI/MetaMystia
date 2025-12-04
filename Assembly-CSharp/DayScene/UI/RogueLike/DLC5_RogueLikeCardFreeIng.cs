using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000323 RID: 803
	[Token(Token = "0x2000323")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardFreeIng", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardFreeIng", order = 3)]
	public class DLC5_RogueLikeCardFreeIng : RogueLikeCard
	{
		// Token: 0x06001247 RID: 4679 RVA: 0x00007140 File Offset: 0x00005340
		[Token(Token = "0x6001247")]
		[Address(RVA = "0x93E1A0", Offset = "0x93CBA0", VA = "0x18093E1A0")]
		private int GetDataByRarity(RogueLikeCardBase.Rarity rarity)
		{
			return 0;
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001248")]
		[Address(RVA = "0x93E2B0", Offset = "0x93CCB0", VA = "0x18093E2B0", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001249")]
		[Address(RVA = "0x93E200", Offset = "0x93CC00", VA = "0x18093E200", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600124A")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardFreeIng()
		{
		}

		// Token: 0x040010F6 RID: 4342
		[Token(Token = "0x40010F6")]
		[FieldOffset(Offset = "0x38")]
		public RarityDataMappingForDuration[] datas;
	}
}
