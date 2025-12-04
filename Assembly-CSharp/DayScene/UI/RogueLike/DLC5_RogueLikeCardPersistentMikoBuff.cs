using System;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200035C RID: 860
	[Token(Token = "0x200035C")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentMikoBuff", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentMikoBuff", order = 103)]
	public class DLC5_RogueLikeCardPersistentMikoBuff : RogueLikeCardPersistent
	{
		// Token: 0x0600133A RID: 4922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600133A")]
		[Address(RVA = "0x43B650", Offset = "0x43A050", VA = "0x18043B650", Slot = "10")]
		public override void AfterSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x000074E8 File Offset: 0x000056E8
		[Token(Token = "0x600133B")]
		[Address(RVA = "0x43B980", Offset = "0x43A380", VA = "0x18043B980", Slot = "7")]
		public override bool CheckExtraConditionToShow(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, RogueLikeManager rogueLikeManager)
		{
			return default(bool);
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600133C")]
		[Address(RVA = "0x43BB80", Offset = "0x43A580", VA = "0x18043BB80")]
		private void RemoveByakurenBuff(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600133D")]
		[Address(RVA = "0x43B690", Offset = "0x43A090", VA = "0x18043B690", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600133E")]
		[Address(RVA = "0x43BAB0", Offset = "0x43A4B0", VA = "0x18043BAB0", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600133F")]
		[Address(RVA = "0x43BFA0", Offset = "0x43A9A0", VA = "0x18043BFA0")]
		public DLC5_RogueLikeCardPersistentMikoBuff()
		{
		}

		// Token: 0x0400119E RID: 4510
		[Token(Token = "0x400119E")]
		[FieldOffset(Offset = "0x40")]
		public GuestGroupController.EvaluationResult baseResult;

		// Token: 0x0400119F RID: 4511
		[Token(Token = "0x400119F")]
		[FieldOffset(Offset = "0x44")]
		public GuestGroupController.EvaluationResult maxResult;

		// Token: 0x040011A0 RID: 4512
		[Token(Token = "0x40011A0")]
		[FieldOffset(Offset = "0x48")]
		public int m_PremiumTag;

		// Token: 0x040011A1 RID: 4513
		[Token(Token = "0x40011A1")]
		private const string ROGUELIKE_MIKO_BUFF = "RogueLike_Miko_Buff";
	}
}
