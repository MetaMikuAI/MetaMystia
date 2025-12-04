using System;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BCD RID: 3021
	[Token(Token = "0x2000BCD")]
	[CreateAssetMenu(fileName = "SpecialGuestProfile", menuName = "GameData Profile/CreateSpecialGuestProfile", order = 3)]
	public class SpecialGuestProfile : ScriptableObject
	{
		// Token: 0x060046D3 RID: 18131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046D3")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public SpecialGuestProfile()
		{
		}

		// Token: 0x04003FF3 RID: 16371
		[Token(Token = "0x4003FF3")]
		[FieldOffset(Offset = "0x18")]
		public SpecialGuest[] specialGuests;

		// Token: 0x04003FF4 RID: 16372
		[Token(Token = "0x4003FF4")]
		[FieldOffset(Offset = "0x20")]
		public MappedSpecialGuest[] mappedSpecialGuests;
	}
}
