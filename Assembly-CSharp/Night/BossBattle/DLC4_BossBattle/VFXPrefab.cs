using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000177 RID: 375
	[Token(Token = "0x2000177")]
	[Serializable]
	public struct VFXPrefab
	{
		// Token: 0x040007E2 RID: 2018
		[Token(Token = "0x40007E2")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public BossBattleVFX m_VfxType;

		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public GameObject m_PrefabObject;

		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x40007E4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public float m_Duration;
	}
}
