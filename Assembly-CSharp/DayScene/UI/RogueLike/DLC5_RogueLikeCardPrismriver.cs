using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200034E RID: 846
	[Token(Token = "0x200034E")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPrismriver", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardPrismriver", order = 1005)]
	public class DLC5_RogueLikeCardPrismriver : RogueLikeCard
	{
		// Token: 0x060012F8 RID: 4856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F8")]
		[Address(RVA = "0x9412A0", Offset = "0x93FCA0", VA = "0x1809412A0", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x00007428 File Offset: 0x00005628
		[Token(Token = "0x60012F9")]
		[Address(RVA = "0x941120", Offset = "0x93FB20", VA = "0x180941120")]
		private int GetDataByRarity(RogueLikeCardBase.Rarity rarity)
		{
			return 0;
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012FA")]
		[Address(RVA = "0x941180", Offset = "0x93FB80", VA = "0x180941180", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012FB")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPrismriver()
		{
		}

		// Token: 0x04001172 RID: 4466
		[Token(Token = "0x4001172")]
		[FieldOffset(Offset = "0x38")]
		public RarityDataMappingForDuration[] datas;

		// Token: 0x04001173 RID: 4467
		[Token(Token = "0x4001173")]
		[FieldOffset(Offset = "0x40")]
		public GuestGroupController.EvaluationResult baseResult;

		// Token: 0x04001174 RID: 4468
		[Token(Token = "0x4001174")]
		[FieldOffset(Offset = "0x44")]
		public int addCombo;
	}
}
