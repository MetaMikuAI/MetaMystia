using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BA0 RID: 2976
	[Token(Token = "0x2000BA0")]
	[CreateAssetMenu(fileName = "IzakayaProfile", menuName = "GameData Profile/CreateIzakayaProfile", order = 3)]
	public class IzakayaProfile : ScriptableObject
	{
		// Token: 0x06004689 RID: 18057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004689")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public IzakayaProfile()
		{
		}

		// Token: 0x04003F03 RID: 16131
		[Token(Token = "0x4003F03")]
		[FieldOffset(Offset = "0x18")]
		public Izakaya[] izakayas;
	}
}
