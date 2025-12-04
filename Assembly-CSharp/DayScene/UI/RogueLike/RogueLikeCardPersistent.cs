using System;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000396 RID: 918
	[Token(Token = "0x2000396")]
	[Serializable]
	public class RogueLikeCardPersistent : RogueLikeCardBase
	{
		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x00007CC8 File Offset: 0x00005EC8
		[Token(Token = "0x17000257")]
		public sealed override RogueLikeCardBase.CardForm GetCardForm
		{
			[Token(Token = "0x600144C")]
			[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "4")]
			get
			{
				return RogueLikeCardBase.CardForm.InGame;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x00007CE0 File Offset: 0x00005EE0
		[Token(Token = "0x17000258")]
		public RogueLikeCardPersistent.InSettledCardForm GetInSettledCardForm
		{
			[Token(Token = "0x600144D")]
			[Address(RVA = "0x44F9E0", Offset = "0x44E3E0", VA = "0x18044F9E0")]
			get
			{
				return RogueLikeCardPersistent.InSettledCardForm.Forever;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x00007CF8 File Offset: 0x00005EF8
		[Token(Token = "0x17000259")]
		public int BuffDurationWave
		{
			[Token(Token = "0x600144E")]
			[Address(RVA = "0x44F9C0", Offset = "0x44E3C0", VA = "0x18044F9C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x0600144F RID: 5199 RVA: 0x00007D10 File Offset: 0x00005F10
		[Token(Token = "0x1700025A")]
		public bool IsNoLimit
		{
			[Token(Token = "0x600144F")]
			[Address(RVA = "0x44FA00", Offset = "0x44E400", VA = "0x18044FA00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x00007D28 File Offset: 0x00005F28
		[Token(Token = "0x1700025B")]
		public int MaxNum
		{
			[Token(Token = "0x6001450")]
			[Address(RVA = "0x44FA10", Offset = "0x44E410", VA = "0x18044FA10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x00007D40 File Offset: 0x00005F40
		[Token(Token = "0x1700025C")]
		public bool HasMinimum
		{
			[Token(Token = "0x6001451")]
			[Address(RVA = "0x44F9F0", Offset = "0x44E3F0", VA = "0x18044F9F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06001452 RID: 5202 RVA: 0x00007D58 File Offset: 0x00005F58
		[Token(Token = "0x1700025D")]
		public RogueLikeCardBase.Rarity CardRarity
		{
			[Token(Token = "0x6001452")]
			[Address(RVA = "0x440570", Offset = "0x43EF70", VA = "0x180440570")]
			get
			{
				return RogueLikeCardBase.Rarity.Green;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x00007D70 File Offset: 0x00005F70
		[Token(Token = "0x1700025E")]
		public bool AlwaysShowBuff
		{
			[Token(Token = "0x6001453")]
			[Address(RVA = "0x44F9B0", Offset = "0x44E3B0", VA = "0x18044F9B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001454")]
		[Address(RVA = "0x3FA8D0", Offset = "0x3F92D0", VA = "0x1803FA8D0", Slot = "5")]
		public virtual string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, int num)
		{
			return null;
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001455")]
		[Address(RVA = "0x44F8B0", Offset = "0x44E2B0", VA = "0x18044F8B0", Slot = "6")]
		public virtual string GetDescriptionInAlbum(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			return null;
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00007D88 File Offset: 0x00005F88
		[Token(Token = "0x6001456")]
		[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "7")]
		public virtual bool CheckExtraConditionToShow(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance persistentCardInstance, RogueLikeManager rogueLikeManager)
		{
			return default(bool);
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00007DA0 File Offset: 0x00005FA0
		[Token(Token = "0x6001457")]
		[Address(RVA = "0x44F4B0", Offset = "0x44DEB0", VA = "0x18044F4B0")]
		public bool CheckCouldShow(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			return default(bool);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001458")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "8")]
		public virtual void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001459")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "9")]
		public virtual void CardEffectAfterLoadAndSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145A")]
		[Address(RVA = "0x44F410", Offset = "0x44DE10", VA = "0x18044F410", Slot = "10")]
		public virtual void AfterSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145B")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "11")]
		public virtual void RemoveCard(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600145C")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "12")]
		public virtual void AfterInitialize(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00007DB8 File Offset: 0x00005FB8
		[Token(Token = "0x600145D")]
		[Address(RVA = "0x44F700", Offset = "0x44E100", VA = "0x18044F700")]
		protected bool CheckExistSameCard(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			return default(bool);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145E")]
		[Address(RVA = "0x44F430", Offset = "0x44DE30", VA = "0x18044F430")]
		protected string BaseBuffDescription(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			return null;
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600145F")]
		[Address(RVA = "0x44F430", Offset = "0x44DE30", VA = "0x18044F430", Slot = "13")]
		public virtual string OverrideBuffDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001460")]
		[Address(RVA = "0x44F870", Offset = "0x44E270", VA = "0x18044F870", Slot = "14")]
		[CanBeNull]
		public virtual string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001461")]
		[Address(RVA = "0x44F820", Offset = "0x44E220", VA = "0x18044F820")]
		protected string FormatString(string data)
		{
			return null;
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001462")]
		[Address(RVA = "0x3FA890", Offset = "0x3F9290", VA = "0x1803FA890")]
		protected string FormatStringFromIntValue(int data)
		{
			return null;
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001463")]
		[Address(RVA = "0x44F7B0", Offset = "0x44E1B0", VA = "0x18044F7B0")]
		protected string FormatStringFromFloatValue(float data)
		{
			return null;
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001464")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public RogueLikeCardPersistent()
		{
		}

		// Token: 0x04001312 RID: 4882
		[Token(Token = "0x4001312")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("结算卡牌类型")]
		[SerializeField]
		private RogueLikeCardPersistent.InSettledCardForm m_CardForm;

		// Token: 0x04001313 RID: 4883
		[Token(Token = "0x4001313")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("一晚只刷一张")]
		[SerializeField]
		private bool m_Unique;

		// Token: 0x04001314 RID: 4884
		[Token(Token = "0x4001314")]
		[FieldOffset(Offset = "0x2D")]
		[Tooltip("必定在晚上出现")]
		[SerializeField]
		private bool m_HasMinimum;

		// Token: 0x04001315 RID: 4885
		[Token(Token = "0x4001315")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("可持续波次，单局卡牌应输入1")]
		[SerializeField]
		private int m_BuffDurationWave;

		// Token: 0x04001316 RID: 4886
		[Token(Token = "0x4001316")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Tooltip("最多可持有的数量，为0则无上限")]
		private int m_MaxNum;

		// Token: 0x04001317 RID: 4887
		[Token(Token = "0x4001317")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RogueLikeCardBase.Rarity m_Rarity;

		// Token: 0x04001318 RID: 4888
		[Token(Token = "0x4001318")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool m_AlwaysShowBuff;

		// Token: 0x02000397 RID: 919
		[Token(Token = "0x2000397")]
		public enum InSettledCardForm
		{
			// Token: 0x0400131A RID: 4890
			[Token(Token = "0x400131A")]
			Forever,
			// Token: 0x0400131B RID: 4891
			[Token(Token = "0x400131B")]
			Remaining
		}
	}
}
