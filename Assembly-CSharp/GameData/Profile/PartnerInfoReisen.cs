using System;
using System.Text;
using Il2CppDummyDll;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CD9 RID: 3289
	[Token(Token = "0x2000CD9")]
	[CreateAssetMenu(fileName = "PartnerInfoReisen", menuName = "GameData Profile/PartnerInfoCollection/PartnerInfoReisen", order = 3)]
	public sealed class PartnerInfoReisen : PartnerInfo
	{
		// Token: 0x06004C73 RID: 19571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C73")]
		[Address(RVA = "0x79EAF0", Offset = "0x79D4F0", VA = "0x18079EAF0", Slot = "16")]
		protected override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, object[] additionalData)
		{
		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C74")]
		[Address(RVA = "0x79EB40", Offset = "0x79D540", VA = "0x18079EB40", Slot = "22")]
		protected override void PostProcessInfo(StringBuilder builder)
		{
		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C75")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public PartnerInfoReisen()
		{
		}

		// Token: 0x04004662 RID: 18018
		[Token(Token = "0x4004662")]
		[FieldOffset(Offset = "0x58")]
		public float extraFeePercentage;
	}
}
