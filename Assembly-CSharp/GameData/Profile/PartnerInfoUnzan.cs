using System;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CE5 RID: 3301
	[Token(Token = "0x2000CE5")]
	[CreateAssetMenu(fileName = "DLC3_PartnerInfo_Unzan", menuName = "GameData Profile/PartnerInfoCollection/DLC3_PartnerInfoUnzan", order = 3001)]
	public sealed class PartnerInfoUnzan : PartnerInfo
	{
		// Token: 0x06004CA5 RID: 19621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA5")]
		[Address(RVA = "0x79F670", Offset = "0x79E070", VA = "0x18079F670", Slot = "22")]
		protected override void PostProcessInfo(StringBuilder builder)
		{
		}

		// Token: 0x06004CA6 RID: 19622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA6")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public PartnerInfoUnzan()
		{
		}
	}
}
