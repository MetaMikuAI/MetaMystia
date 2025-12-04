using System;
using System.Collections;
using System.Text;
using Il2CppDummyDll;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CE6 RID: 3302
	[Token(Token = "0x2000CE6")]
	[CreateAssetMenu(fileName = "DLC3_PartnerInfo_Yoshika", menuName = "GameData Profile/PartnerInfoCollection/DLC3_PartnerInfoYoshika", order = 3002)]
	public sealed class PartnerInfoYoshika : PartnerInfo
	{
		// Token: 0x06004CA7 RID: 19623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA7")]
		[Address(RVA = "0x79FA10", Offset = "0x79E410", VA = "0x18079FA10", Slot = "22")]
		protected override void PostProcessInfo(StringBuilder builder)
		{
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CA8")]
		[Address(RVA = "0x79F850", Offset = "0x79E250", VA = "0x18079F850", Slot = "15")]
		public override void OnInventoryUpdate(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager)
		{
		}

		// Token: 0x06004CA9 RID: 19625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CA9")]
		[Address(RVA = "0x79F780", Offset = "0x79E180", VA = "0x18079F780")]
		private IEnumerator MoveToFoodStorage(PartnerBase thisPartner, EventManager eventManager, PartnerManager partnerManager)
		{
			return null;
		}

		// Token: 0x06004CAA RID: 19626 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CAA")]
		[Address(RVA = "0x79F6B0", Offset = "0x79E0B0", VA = "0x18079F6B0")]
		private IEnumerator Eat(PartnerBase thisPartner, EventManager eventManager, PartnerManager partnerManager)
		{
			return null;
		}

		// Token: 0x06004CAB RID: 19627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CAB")]
		[Address(RVA = "0x79FA50", Offset = "0x79E450", VA = "0x18079FA50")]
		public PartnerInfoYoshika()
		{
		}

		// Token: 0x0400468D RID: 18061
		[Token(Token = "0x400468D")]
		private const string YOSHIKA_EAT_NUM = "YoshikaEatNum";

		// Token: 0x0400468E RID: 18062
		[Token(Token = "0x400468E")]
		[FieldOffset(Offset = "0x58")]
		public int findFoodId;

		// Token: 0x0400468F RID: 18063
		[Token(Token = "0x400468F")]
		[FieldOffset(Offset = "0x5C")]
		public float eachFoodProvideSpeed;

		// Token: 0x04004690 RID: 18064
		[Token(Token = "0x4004690")]
		[FieldOffset(Offset = "0x60")]
		public float eachFoodProvideWorkSpeed;

		// Token: 0x04004691 RID: 18065
		[Token(Token = "0x4004691")]
		[FieldOffset(Offset = "0x64")]
		public int maxNum;

		// Token: 0x04004692 RID: 18066
		[Token(Token = "0x4004692")]
		[FieldOffset(Offset = "0x68")]
		public GameObject powerAscensionEffect;
	}
}
