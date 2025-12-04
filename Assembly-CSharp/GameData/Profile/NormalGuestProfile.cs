using System;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BB1 RID: 2993
	[Token(Token = "0x2000BB1")]
	[CreateAssetMenu(fileName = "NormalGuestProfile", menuName = "GameData Profile/CreateNormalGuestProfile", order = 3)]
	public class NormalGuestProfile : ScriptableObject
	{
		// Token: 0x060046A7 RID: 18087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046A7")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public NormalGuestProfile()
		{
		}

		// Token: 0x04003F38 RID: 16184
		[Token(Token = "0x4003F38")]
		[FieldOffset(Offset = "0x18")]
		public NormalGuest[] normalGuests;
	}
}
