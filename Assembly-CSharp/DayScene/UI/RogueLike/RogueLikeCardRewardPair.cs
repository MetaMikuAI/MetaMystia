using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200038D RID: 909
	[Token(Token = "0x200038D")]
	[JsonObject(MemberSerialization.OptIn)]
	[Serializable]
	public struct RogueLikeCardRewardPair
	{
		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06001430 RID: 5168 RVA: 0x00007BA8 File Offset: 0x00005DA8
		[Token(Token = "0x1700024A")]
		public int WholeCardNum
		{
			[Token(Token = "0x6001430")]
			[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06001431 RID: 5169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700024B")]
		public RogueLikeCardRewardRate[] CardRewardRates
		{
			[Token(Token = "0x6001431")]
			[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x040012B4 RID: 4788
		[Token(Token = "0x40012B4")]
		[FieldOffset(Offset = "0x0")]
		[JsonProperty("WholeCardNum")]
		[SerializeField]
		private int m_WholeCardNum;

		// Token: 0x040012B5 RID: 4789
		[Token(Token = "0x40012B5")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		[JsonProperty("CardRewardRates")]
		private RogueLikeCardRewardRate[] m_CardRewardRates;
	}
}
