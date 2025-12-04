using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000337 RID: 823
	[Token(Token = "0x2000337")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardJyoonFan", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardJyoonFan", order = 5)]
	public class DLC5_RogueLikeCardJyoonFan : RogueLikeCard
	{
		// Token: 0x0600129C RID: 4764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129C")]
		[Address(RVA = "0x93FBE0", Offset = "0x93E5E0", VA = "0x18093FBE0", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600129D")]
		[Address(RVA = "0x93FB30", Offset = "0x93E530", VA = "0x18093FB30", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600129E")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardJyoonFan()
		{
		}

		// Token: 0x04001134 RID: 4404
		[Token(Token = "0x4001134")]
		[FieldOffset(Offset = "0x38")]
		public RarityDataMappingForMultiplier[] datas;
	}
}
