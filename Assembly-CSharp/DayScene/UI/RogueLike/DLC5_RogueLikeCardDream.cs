using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000318 RID: 792
	[Token(Token = "0x2000318")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardDream", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardDream", order = 1003)]
	public class DLC5_RogueLikeCardDream : RogueLikeCard
	{
		// Token: 0x06001211 RID: 4625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001211")]
		[Address(RVA = "0x93DA10", Offset = "0x93C410", VA = "0x18093DA10", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00007020 File Offset: 0x00005220
		[Token(Token = "0x6001212")]
		[Address(RVA = "0x93D970", Offset = "0x93C370", VA = "0x18093D970", Slot = "8")]
		public override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			return default(bool);
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001213")]
		[Address(RVA = "0x93D990", Offset = "0x93C390", VA = "0x18093D990", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001214")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardDream()
		{
		}

		// Token: 0x040010D0 RID: 4304
		[Token(Token = "0x40010D0")]
		[FieldOffset(Offset = "0x38")]
		public float proportion;
	}
}
