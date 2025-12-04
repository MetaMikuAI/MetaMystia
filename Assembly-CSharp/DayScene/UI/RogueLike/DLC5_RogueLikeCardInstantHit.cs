using System;
using System.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000331 RID: 817
	[Token(Token = "0x2000331")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardInstantHit", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardInstantHit", order = 7)]
	public class DLC5_RogueLikeCardInstantHit : RogueLikeCard
	{
		// Token: 0x0600127E RID: 4734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600127E")]
		[Address(RVA = "0x93F810", Offset = "0x93E210", VA = "0x18093F810", Slot = "5")]
		public override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00007200 File Offset: 0x00005400
		[Token(Token = "0x600127F")]
		[Address(RVA = "0x93F6C0", Offset = "0x93E0C0", VA = "0x18093F6C0", Slot = "8")]
		public override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			return default(bool);
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001280")]
		[Address(RVA = "0x93F720", Offset = "0x93E120", VA = "0x18093F720", Slot = "7")]
		public override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001281")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardInstantHit()
		{
		}

		// Token: 0x0400111D RID: 4381
		[Token(Token = "0x400111D")]
		[FieldOffset(Offset = "0x38")]
		public RarityDataMappingForInstantHit[] datas;
	}
}
