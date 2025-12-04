using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000320 RID: 800
	[Token(Token = "0x2000320")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardFreeBev", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardFreeBev", order = 4)]
	public class DLC5_RogueLikeCardFreeBev : RogueLikeCard
	{
		// Token: 0x0600123A RID: 4666 RVA: 0x00007110 File Offset: 0x00005310
		[Token(Token = "0x600123A")]
		[Address(RVA = "0x93DFA0", Offset = "0x93C9A0", VA = "0x18093DFA0")]
		private int GetDataByRarity(RogueLikeCardBase.Rarity rarity)
		{
			return 0;
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600123B")]
		[Address(RVA = "0x93E0B0", Offset = "0x93CAB0", VA = "0x18093E0B0", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600123C")]
		[Address(RVA = "0x93E000", Offset = "0x93CA00", VA = "0x18093E000", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600123D")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardFreeBev()
		{
		}

		// Token: 0x040010ED RID: 4333
		[Token(Token = "0x40010ED")]
		[FieldOffset(Offset = "0x38")]
		public RarityDataMappingForDuration[] datas;
	}
}
