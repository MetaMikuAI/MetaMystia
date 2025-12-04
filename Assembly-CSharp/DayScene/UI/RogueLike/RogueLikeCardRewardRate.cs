using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200038E RID: 910
	[Token(Token = "0x200038E")]
	[JsonObject(MemberSerialization.OptIn)]
	[Serializable]
	public struct RogueLikeCardRewardRate
	{
		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x00007BC0 File Offset: 0x00005DC0
		[Token(Token = "0x1700024C")]
		public RogueLikeCardBase.Rarity Rarity
		{
			[Token(Token = "0x6001432")]
			[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
			get
			{
				return RogueLikeCardBase.Rarity.Green;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[Token(Token = "0x1700024D")]
		public float Rate
		{
			[Token(Token = "0x6001433")]
			[Address(RVA = "0x44FA20", Offset = "0x44E420", VA = "0x18044FA20")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x040012B6 RID: 4790
		[Token(Token = "0x40012B6")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		[JsonProperty("Rarity")]
		private RogueLikeCardBase.Rarity m_Rarity;

		// Token: 0x040012B7 RID: 4791
		[Token(Token = "0x40012B7")]
		[FieldOffset(Offset = "0x4")]
		[Range(0f, 1f)]
		[JsonProperty("Rate")]
		[SerializeField]
		private float m_Rate;
	}
}
