using System;
using System.Collections;
using DayScene.UI.RogueLike;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x02000120 RID: 288
	[Token(Token = "0x2000120")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardCulturalWindRequiem", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardCulturalWindRequiem", order = 9)]
	public class DLC5_RogueLikeCardCulturalWindRequiem : RogueLikeCard
	{
		// Token: 0x06000726 RID: 1830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x6DE870", Offset = "0x6DD270", VA = "0x1806DE870", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x6DE780", Offset = "0x6DD180", VA = "0x1806DE780", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardCulturalWindRequiem()
		{
		}

		// Token: 0x040006D2 RID: 1746
		[Token(Token = "0x40006D2")]
		[FieldOffset(Offset = "0x38")]
		public RarityDataMappingForDuration[] datas;

		// Token: 0x040006D3 RID: 1747
		[Token(Token = "0x40006D3")]
		private const int PERFECT_EVAL = 4;
	}
}
