using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000390 RID: 912
	[Token(Token = "0x2000390")]
	[JsonObject(MemberSerialization.OptIn)]
	[Serializable]
	public class RogueLikeCardInstance
	{
		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06001435 RID: 5173 RVA: 0x00007BF0 File Offset: 0x00005DF0
		[Token(Token = "0x1700024E")]
		public RogueLikeCardBase.CardType CardType
		{
			[Token(Token = "0x6001435")]
			[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
			get
			{
				return RogueLikeCardBase.CardType.获得食材;
			}
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001436")]
		[Address(RVA = "0x44F3D0", Offset = "0x44DDD0", VA = "0x18044F3D0")]
		public RogueLikeCardInstance(RogueLikeCardBase.CardType cardType, RogueLikeCardBase.Rarity rarity)
		{
		}

		// Token: 0x040012B8 RID: 4792
		[Token(Token = "0x40012B8")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("CardTypeId")]
		private int m_CardTypeId;

		// Token: 0x040012B9 RID: 4793
		[Token(Token = "0x40012B9")]
		[FieldOffset(Offset = "0x14")]
		[JsonProperty("Rarity")]
		public RogueLikeCardBase.Rarity m_Rarity;
	}
}
