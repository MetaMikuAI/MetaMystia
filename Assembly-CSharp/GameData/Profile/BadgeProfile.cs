using System;
using GameData.Core.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B71 RID: 2929
	[Token(Token = "0x2000B71")]
	[CreateAssetMenu(fileName = "BadgeProfile", menuName = "GameData Profile/CreateBadgeProfile", order = 50)]
	public class BadgeProfile : ScriptableObject
	{
		// Token: 0x0600461A RID: 17946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600461A")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public BadgeProfile()
		{
		}

		// Token: 0x04003DF3 RID: 15859
		[Token(Token = "0x4003DF3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Badge[] badges;

		// Token: 0x04003DF4 RID: 15860
		[Token(Token = "0x4003DF4")]
		[FieldOffset(Offset = "0x20")]
		public string previewName;
	}
}
