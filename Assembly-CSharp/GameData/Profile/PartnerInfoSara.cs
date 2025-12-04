using System;
using System.Text;
using Il2CppDummyDll;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CDD RID: 3293
	[Token(Token = "0x2000CDD")]
	[CreateAssetMenu(fileName = "DLC5_PartnerInfo_Sara", menuName = "GameData Profile/PartnerInfoCollection/DLC5_PartnerInfoSara", order = 5001)]
	public class PartnerInfoSara : PartnerInfo
	{
		// Token: 0x06004C84 RID: 19588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C84")]
		[Address(RVA = "0x79EEB0", Offset = "0x79D8B0", VA = "0x18079EEB0", Slot = "16")]
		protected override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, object[] additionalData)
		{
		}

		// Token: 0x06004C85 RID: 19589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C85")]
		[Address(RVA = "0x79F010", Offset = "0x79DA10", VA = "0x18079F010", Slot = "22")]
		protected override void PostProcessInfo(StringBuilder builder)
		{
		}

		// Token: 0x06004C86 RID: 19590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C86")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public PartnerInfoSara()
		{
		}

		// Token: 0x04004673 RID: 18035
		[Token(Token = "0x4004673")]
		[FieldOffset(Offset = "0x58")]
		public int spawnGuestInterval;
	}
}
