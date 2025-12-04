using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x02000146 RID: 326
	[Token(Token = "0x2000146")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentSetGuestSpawn", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentSetGuestSpawn", order = 14)]
	public class DLC5_RogueLikeCardPersistentSetGuestSpawn : RogueLikeCardPersistent
	{
		// Token: 0x060007DA RID: 2010 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x82ACA0", Offset = "0x8296A0", VA = "0x18082ACA0", Slot = "7")]
		public override bool CheckExtraConditionToShow(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, RogueLikeManager rogueLikeManager)
		{
			return default(bool);
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x82A980", Offset = "0x829380", VA = "0x18082A980", Slot = "12")]
		public override void AfterInitialize(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance)
		{
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x82AEA0", Offset = "0x8298A0", VA = "0x18082AEA0", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x82AD00", Offset = "0x829700", VA = "0x18082AD00", Slot = "6")]
		public override string GetDescriptionInAlbum(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			return null;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x82ABE0", Offset = "0x8295E0", VA = "0x18082ABE0", Slot = "9")]
		public override void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x82B210", Offset = "0x829C10", VA = "0x18082B210", Slot = "11")]
		public override void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x82AD60", Offset = "0x829760", VA = "0x18082AD60", Slot = "13")]
		public override string OverrideBuffDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentSetGuestSpawn()
		{
		}
	}
}
