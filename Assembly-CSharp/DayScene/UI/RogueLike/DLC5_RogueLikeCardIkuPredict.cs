using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200032D RID: 813
	[Token(Token = "0x200032D")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardIkuPredict", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardIkuPredict", order = 24)]
	public class DLC5_RogueLikeCardIkuPredict : RogueLikeCard
	{
		// Token: 0x0600126F RID: 4719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600126F")]
		[Address(RVA = "0x93F5D0", Offset = "0x93DFD0", VA = "0x18093F5D0", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001270")]
		[Address(RVA = "0x93F500", Offset = "0x93DF00", VA = "0x18093F500", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001271")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardIkuPredict()
		{
		}

		// Token: 0x04001110 RID: 4368
		[Token(Token = "0x4001110")]
		[FieldOffset(Offset = "0x38")]
		public RarityDataMappingForDuration[] datas;

		// Token: 0x04001111 RID: 4369
		[Token(Token = "0x4001111")]
		[FieldOffset(Offset = "0x40")]
		public int checkNum;
	}
}
