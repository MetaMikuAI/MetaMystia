using System;
using System.Collections;
using System.Collections.Generic;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000399 RID: 921
	[Token(Token = "0x2000399")]
	public class RogueLikeCard : RogueLikeCardBase
	{
		// Token: 0x1700025F RID: 607
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x00007E18 File Offset: 0x00006018
		[Token(Token = "0x1700025F")]
		public sealed override RogueLikeCardBase.CardForm GetCardForm
		{
			[Token(Token = "0x600146A")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "4")]
			get
			{
				return RogueLikeCardBase.CardForm.InGame;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x0600146B RID: 5227 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000260")]
		public RogueLikeCardBase.Rarity[] ContainsRarity
		{
			[Token(Token = "0x600146B")]
			[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x00007E30 File Offset: 0x00006030
		[Token(Token = "0x17000261")]
		public bool OnlyShowOncePerWave
		{
			[Token(Token = "0x600146C")]
			[Address(RVA = "0x44FC20", Offset = "0x44E620", VA = "0x18044FC20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x00007E48 File Offset: 0x00006048
		[Token(Token = "0x17000262")]
		public bool InstantTrigger
		{
			[Token(Token = "0x600146D")]
			[Address(RVA = "0x44FC10", Offset = "0x44E610", VA = "0x18044FC10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x00007E60 File Offset: 0x00006060
		[Token(Token = "0x17000263")]
		public bool TriggerAfterSettle
		{
			[Token(Token = "0x600146E")]
			[Address(RVA = "0x44FC30", Offset = "0x44E630", VA = "0x18044FC30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600146F")]
		protected T GetRarityDataMapping<T>(T[] allProvidedData, RogueLikeCardBase.Rarity rarity) where T : RarityDataMapping
		{
			return null;
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001470")]
		[Address(RVA = "0x44FB80", Offset = "0x44E580", VA = "0x18044FB80", Slot = "5")]
		public virtual IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001471")]
		[Address(RVA = "0x44FAE0", Offset = "0x44E4E0", VA = "0x18044FAE0", Slot = "6")]
		public virtual void ModifyStorageAfterSettle(RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager, out List<Product> products)
		{
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001472")]
		[Address(RVA = "0x3FA8D0", Offset = "0x3F92D0", VA = "0x1803FA8D0", Slot = "7")]
		public virtual string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			return null;
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00007E78 File Offset: 0x00006078
		[Token(Token = "0x6001473")]
		[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "8")]
		public virtual bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			return default(bool);
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00007E90 File Offset: 0x00006090
		[Token(Token = "0x6001474")]
		[Address(RVA = "0x44FA30", Offset = "0x44E430", VA = "0x18044FA30")]
		protected bool CheckExistSameCard(RogueLikeManager rogueLikeManager)
		{
			return default(bool);
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001475")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public RogueLikeCard()
		{
		}

		// Token: 0x0400131E RID: 4894
		[Token(Token = "0x400131E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RogueLikeCardBase.Rarity[] m_ContainsRarity;

		// Token: 0x0400131F RID: 4895
		[Token(Token = "0x400131F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_OnlyShowOncePerWave;

		// Token: 0x04001320 RID: 4896
		[Token(Token = "0x4001320")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool m_InstantTrigger;

		// Token: 0x04001321 RID: 4897
		[Token(Token = "0x4001321")]
		[FieldOffset(Offset = "0x32")]
		[SerializeField]
		private bool m_TriggerAfterSettle;
	}
}
