using System;
using System.Text;
using Il2CppDummyDll;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CE0 RID: 3296
	[Token(Token = "0x2000CE0")]
	[CreateAssetMenu(fileName = "DLC4_PartnerInfo_Sekibanki", menuName = "GameData Profile/PartnerInfoCollection/DLC4_PartnerInfoSekibanki", order = 4001)]
	public sealed class PartnerInfoSekibanki : PartnerInfo
	{
		// Token: 0x06004C8E RID: 19598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C8E")]
		[Address(RVA = "0x79F0B0", Offset = "0x79DAB0", VA = "0x18079F0B0", Slot = "14")]
		public override ValueTuple<PartnerInfoBase.CompanionProperty, PartnerBase.PartnerType>[] GetCompanionPartnerType(PartnerBase currentPartner)
		{
			return null;
		}

		// Token: 0x06004C8F RID: 19599 RVA: 0x0001BAF8 File Offset: 0x00019CF8
		[Token(Token = "0x6004C8F")]
		[Address(RVA = "0x79F050", Offset = "0x79DA50", VA = "0x18079F050")]
		private int CouldRestHeadNum(PartnerBase currentPartner)
		{
			return 0;
		}

		// Token: 0x06004C90 RID: 19600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C90")]
		[Address(RVA = "0x79F480", Offset = "0x79DE80", VA = "0x18079F480", Slot = "16")]
		protected override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, object[] additionalData)
		{
		}

		// Token: 0x06004C91 RID: 19601 RVA: 0x0001BB10 File Offset: 0x00019D10
		[Token(Token = "0x6004C91")]
		[Address(RVA = "0x79F3A0", Offset = "0x79DDA0", VA = "0x18079F3A0")]
		private int GetHeadIndex(PartnerBase.PartnerType thisPartnerType, PartnerBase.PartnerType companionPartnerType)
		{
			return 0;
		}

		// Token: 0x06004C92 RID: 19602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C92")]
		[Address(RVA = "0x79F3C0", Offset = "0x79DDC0", VA = "0x18079F3C0", Slot = "19")]
		protected override string GetMoveSpeedText()
		{
			return null;
		}

		// Token: 0x06004C93 RID: 19603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C93")]
		[Address(RVA = "0x79F420", Offset = "0x79DE20", VA = "0x18079F420", Slot = "20")]
		protected override string GetWorkSpeedText()
		{
			return null;
		}

		// Token: 0x06004C94 RID: 19604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C94")]
		[Address(RVA = "0x79F610", Offset = "0x79E010", VA = "0x18079F610", Slot = "22")]
		protected override void PostProcessInfo(StringBuilder builder)
		{
		}

		// Token: 0x06004C95 RID: 19605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C95")]
		[Address(RVA = "0x79F650", Offset = "0x79E050", VA = "0x18079F650")]
		public PartnerInfoSekibanki()
		{
		}

		// Token: 0x0400467B RID: 18043
		[Token(Token = "0x400467B")]
		private const string SEKIBANKI_FLY_HEAD = "SekibankiFlyHead";

		// Token: 0x0400467C RID: 18044
		[Token(Token = "0x400467C")]
		[FieldOffset(Offset = "0x58")]
		public float extraMoveSpeed;

		// Token: 0x0400467D RID: 18045
		[Token(Token = "0x400467D")]
		[FieldOffset(Offset = "0x5C")]
		public float extraWorkSpeed;

		// Token: 0x0400467E RID: 18046
		[Token(Token = "0x400467E")]
		[FieldOffset(Offset = "0x60")]
		public GameObject headLinkVFX;
	}
}
