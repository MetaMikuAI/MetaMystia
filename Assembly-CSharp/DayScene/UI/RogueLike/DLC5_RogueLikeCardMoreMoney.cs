using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000346 RID: 838
	[Token(Token = "0x2000346")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardMoreMoney", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardMoreMoney", order = 2)]
	public class DLC5_RogueLikeCardMoreMoney : RogueLikeCard
	{
		// Token: 0x060012DD RID: 4829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DD")]
		[Address(RVA = "0x9404F0", Offset = "0x93EEF0", VA = "0x1809404F0", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x060012DE RID: 4830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012DE")]
		[Address(RVA = "0x940400", Offset = "0x93EE00", VA = "0x180940400", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x060012DF RID: 4831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012DF")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardMoreMoney()
		{
		}

		// Token: 0x0400115A RID: 4442
		[Token(Token = "0x400115A")]
		[FieldOffset(Offset = "0x38")]
		public RarityDataMappingForMultiplier[] datas;

		// Token: 0x0400115B RID: 4443
		[Token(Token = "0x400115B")]
		[FieldOffset(Offset = "0x40")]
		public int duration;
	}
}
