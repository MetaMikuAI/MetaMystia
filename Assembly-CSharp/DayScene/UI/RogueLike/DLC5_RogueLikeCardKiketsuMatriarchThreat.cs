using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200033D RID: 829
	[Token(Token = "0x200033D")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardKiketsuMatriarchThreat", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardKiketsuMatriarchThreat", order = 12)]
	public class DLC5_RogueLikeCardKiketsuMatriarchThreat : RogueLikeCard
	{
		// Token: 0x060012B7 RID: 4791 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B7")]
		[Address(RVA = "0x940150", Offset = "0x93EB50", VA = "0x180940150", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x000072D8 File Offset: 0x000054D8
		[Token(Token = "0x60012B8")]
		[Address(RVA = "0x940080", Offset = "0x93EA80", VA = "0x180940080", Slot = "8")]
		public override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			return default(bool);
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012B9")]
		[Address(RVA = "0x9400B0", Offset = "0x93EAB0", VA = "0x1809400B0", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012BA")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardKiketsuMatriarchThreat()
		{
		}

		// Token: 0x04001148 RID: 4424
		[Token(Token = "0x4001148")]
		[FieldOffset(Offset = "0x38")]
		public RarityDataMappingForDuration[] datas;
	}
}
