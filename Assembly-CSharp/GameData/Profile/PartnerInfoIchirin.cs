using System;
using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CD0 RID: 3280
	[Token(Token = "0x2000CD0")]
	[CreateAssetMenu(fileName = "DLC3_PartnerInfo_Ichirin", menuName = "GameData Profile/PartnerInfoCollection/DLC3_PartnerInfoIchirin", order = 3000)]
	public sealed class PartnerInfoIchirin : PartnerInfo
	{
		// Token: 0x06004C4E RID: 19534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4E")]
		[Address(RVA = "0x79E490", Offset = "0x79CE90", VA = "0x18079E490", Slot = "22")]
		protected override void PostProcessInfo(StringBuilder builder)
		{
		}

		// Token: 0x06004C4F RID: 19535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C4F")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public PartnerInfoIchirin()
		{
		}
	}
}
