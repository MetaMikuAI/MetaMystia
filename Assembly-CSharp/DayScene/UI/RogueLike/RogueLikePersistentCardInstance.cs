using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000391 RID: 913
	[Token(Token = "0x2000391")]
	[Serializable]
	public class RogueLikePersistentCardInstance : RogueLikeCardInstance
	{
		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06001437 RID: 5175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024F")]
		public IReadOnlyList<int> ExtraIdProperty
		{
			[Token(Token = "0x6001437")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06001438 RID: 5176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000250")]
		public IReadOnlyList<string> ExtraStringProperty
		{
			[Token(Token = "0x6001438")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06001439 RID: 5177 RVA: 0x00007C08 File Offset: 0x00005E08
		// (set) Token: 0x0600143A RID: 5178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000251")]
		public int RemainingWave
		{
			[Token(Token = "0x6001439")]
			[Address(RVA = "0x44F9E0", Offset = "0x44E3E0", VA = "0x18044F9E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600143A")]
			[Address(RVA = "0x450630", Offset = "0x44F030", VA = "0x180450630")]
			set
			{
			}
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600143B")]
		[Address(RVA = "0x450530", Offset = "0x44EF30", VA = "0x180450530")]
		public RogueLikePersistentCardInstance(RogueLikeCardBase.CardType cardType, RogueLikeCardBase.Rarity rarity, int remainingWave)
		{
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600143C")]
		[Address(RVA = "0x44FDE0", Offset = "0x44E7E0", VA = "0x18044FDE0")]
		public void ClearData()
		{
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600143D")]
		[Address(RVA = "0x450000", Offset = "0x44EA00", VA = "0x180450000")]
		public RogueLikeCardPersistent GetCardProperty(RogueLikeRunTimeData rogueLikeRunTimeData)
		{
			return null;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600143E")]
		[Address(RVA = "0x450490", Offset = "0x44EE90", VA = "0x180450490")]
		public string OverrideBuffDescription(RogueLikeRunTimeData rogueLikeRunTimeData, int cardNum)
		{
			return null;
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600143F")]
		[Address(RVA = "0x44FD40", Offset = "0x44E740", VA = "0x18044FD40")]
		public string BuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, int cardNum)
		{
			return null;
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001440")]
		[Address(RVA = "0x44FC40", Offset = "0x44E640", VA = "0x18044FC40")]
		public void AddToExtraIdProperty(int id)
		{
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001441")]
		[Address(RVA = "0x44FCE0", Offset = "0x44E6E0", VA = "0x18044FCE0")]
		public void AddToExtraStringProperty(string label)
		{
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00007C20 File Offset: 0x00005E20
		[Token(Token = "0x6001442")]
		[Address(RVA = "0x44FF00", Offset = "0x44E900", VA = "0x18044FF00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00007C38 File Offset: 0x00005E38
		[Token(Token = "0x6001443")]
		[Address(RVA = "0x44FE60", Offset = "0x44E860", VA = "0x18044FE60")]
		public bool Equal(RogueLikePersistentCardInstance rogueLikePersistentCardInstance)
		{
			return default(bool);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00007C50 File Offset: 0x00005E50
		[Token(Token = "0x6001444")]
		[Address(RVA = "0x450060", Offset = "0x44EA60", VA = "0x180450060", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040012BA RID: 4794
		[Token(Token = "0x40012BA")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("ExtraIdProperty")]
		[SerializeField]
		private List<int> m_ExtraIdProperty;

		// Token: 0x040012BB RID: 4795
		[Token(Token = "0x40012BB")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("ExtraStringProperty")]
		[SerializeField]
		private List<string> m_ExtraStringProperty;

		// Token: 0x040012BC RID: 4796
		[Token(Token = "0x40012BC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[JsonProperty("RemainingWave")]
		private int m_RemainingWave;
	}
}
