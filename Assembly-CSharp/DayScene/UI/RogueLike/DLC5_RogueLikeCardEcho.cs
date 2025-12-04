using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200031B RID: 795
	[Token(Token = "0x200031B")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardEcho", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardEcho", order = 1004)]
	public class DLC5_RogueLikeCardEcho : RogueLikeCard
	{
		// Token: 0x06001222 RID: 4642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001222")]
		[Address(RVA = "0x93DC80", Offset = "0x93C680", VA = "0x18093DC80", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x000070B0 File Offset: 0x000052B0
		[Token(Token = "0x6001223")]
		[Address(RVA = "0x93DB00", Offset = "0x93C500", VA = "0x18093DB00")]
		private int GetDataByRarity(RogueLikeCardBase.Rarity rarity)
		{
			return 0;
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001224")]
		[Address(RVA = "0x93DB60", Offset = "0x93C560", VA = "0x18093DB60", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001225")]
		[Address(RVA = "0x93DD70", Offset = "0x93C770", VA = "0x18093DD70")]
		public DLC5_RogueLikeCardEcho()
		{
		}

		// Token: 0x040010DC RID: 4316
		[Token(Token = "0x40010DC")]
		[FieldOffset(Offset = "0x38")]
		public RarityDataMappingForDuration[] datas;

		// Token: 0x040010DD RID: 4317
		[Token(Token = "0x40010DD")]
		[FieldOffset(Offset = "0x40")]
		public GuestGroupController.EvaluationResult baseResult;

		// Token: 0x040010DE RID: 4318
		[Token(Token = "0x40010DE")]
		[FieldOffset(Offset = "0x44")]
		public int giveNum;
	}
}
