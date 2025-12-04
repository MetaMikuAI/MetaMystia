using System;
using System.Text;
using Il2CppDummyDll;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CD4 RID: 3284
	[Token(Token = "0x2000CD4")]
	[CreateAssetMenu(fileName = "DLC4_PartnerInfo_Larva", menuName = "GameData Profile/PartnerInfoCollection/DLC4_PartnerInfoLarva", order = 4000)]
	public sealed class PartnerInfoLarva : PartnerInfo
	{
		// Token: 0x06004C5A RID: 19546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5A")]
		[Address(RVA = "0x79E890", Offset = "0x79D290", VA = "0x18079E890", Slot = "16")]
		protected override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, object[] additionalData)
		{
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5B")]
		[Address(RVA = "0x79E690", Offset = "0x79D090", VA = "0x18079E690")]
		private void OnGuestSpawn(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x06004C5C RID: 19548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C5C")]
		[Address(RVA = "0x79EA20", Offset = "0x79D420", VA = "0x18079EA20")]
		private int[] UnderSleepingTags(int[] originalTags, GuestGroupController guestGroupController)
		{
			return null;
		}

		// Token: 0x06004C5D RID: 19549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5D")]
		[Address(RVA = "0x79E620", Offset = "0x79D020", VA = "0x18079E620")]
		private void LarvaSleepingOrderResult(GuestGroupController guestGroupController)
		{
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5E")]
		[Address(RVA = "0x79E9E0", Offset = "0x79D3E0", VA = "0x18079E9E0", Slot = "22")]
		protected override void PostProcessInfo(StringBuilder builder)
		{
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5F")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public PartnerInfoLarva()
		{
		}

		// Token: 0x0400464E RID: 17998
		[Token(Token = "0x400464E")]
		private const int EXPENSIVE_TAG = -3;

		// Token: 0x0400464F RID: 17999
		[Token(Token = "0x400464F")]
		[FieldOffset(Offset = "0x58")]
		public int spellDuration;

		// Token: 0x04004650 RID: 18000
		[Token(Token = "0x4004650")]
		[FieldOffset(Offset = "0x5C")]
		public int spellInterval;
	}
}
