using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CD8 RID: 3288
	[Token(Token = "0x2000CD8")]
	[CreateAssetMenu(fileName = "PartnerInfoProfile", menuName = "GameData Profile/PartnerInfoCollection/Profile", order = 1)]
	public class PartnerInfoProfile : ScriptableObject
	{
		// Token: 0x06004C72 RID: 19570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C72")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public PartnerInfoProfile()
		{
		}

		// Token: 0x04004661 RID: 18017
		[Token(Token = "0x4004661")]
		[FieldOffset(Offset = "0x18")]
		public PartnerInfoBase[] partnerInfoCollection;
	}
}
