using System;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000354 RID: 852
	[Token(Token = "0x2000354")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentByakurenBuff", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentByakurenBuff", order = 104)]
	public class DLC5_RogueLikeCardPersistentByakurenBuff : RogueLikeCardPersistent
	{
		// Token: 0x06001319 RID: 4889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001319")]
		[Address(RVA = "0x9405E0", Offset = "0x93EFE0", VA = "0x1809405E0", Slot = "10")]
		public override void AfterSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x000074A0 File Offset: 0x000056A0
		[Token(Token = "0x600131A")]
		[Address(RVA = "0x940910", Offset = "0x93F310", VA = "0x180940910", Slot = "7")]
		public override bool CheckExtraConditionToShow(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, RogueLikeManager rogueLikeManager)
		{
			return default(bool);
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600131B")]
		[Address(RVA = "0x940B50", Offset = "0x93F550", VA = "0x180940B50")]
		private void RemoveMikoBuff(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600131C")]
		[Address(RVA = "0x940610", Offset = "0x93F010", VA = "0x180940610", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131D")]
		[Address(RVA = "0x940A80", Offset = "0x93F480", VA = "0x180940A80", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600131E")]
		[Address(RVA = "0x940F70", Offset = "0x93F970", VA = "0x180940F70")]
		public DLC5_RogueLikeCardPersistentByakurenBuff()
		{
		}

		// Token: 0x0400118B RID: 4491
		[Token(Token = "0x400118B")]
		[FieldOffset(Offset = "0x40")]
		public GuestGroupController.EvaluationResult baseResult;

		// Token: 0x0400118C RID: 4492
		[Token(Token = "0x400118C")]
		[FieldOffset(Offset = "0x44")]
		public GuestGroupController.EvaluationResult maxResult;

		// Token: 0x0400118D RID: 4493
		[Token(Token = "0x400118D")]
		[FieldOffset(Offset = "0x48")]
		public int m_NoAlcoholTag;
	}
}
