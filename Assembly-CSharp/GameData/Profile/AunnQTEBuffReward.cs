using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C9B RID: 3227
	[Token(Token = "0x2000C9B")]
	[CreateAssetMenu(fileName = "AunnQTERewardData", menuName = "GameData Profile/QTERewardData/Aunn", order = 4)]
	public class AunnQTEBuffReward : QTEBuffReward
	{
		// Token: 0x06004B20 RID: 19232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B20")]
		[Address(RVA = "0x77C750", Offset = "0x77B150", VA = "0x18077C750", Slot = "11")]
		public override string QTEBuffOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06004B21 RID: 19233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B21")]
		[Address(RVA = "0x77C2B0", Offset = "0x77ACB0", VA = "0x18077C2B0", Slot = "5")]
		public override void OnQTESucceeded(int index = -1, bool mustSuccess = false)
		{
		}

		// Token: 0x06004B22 RID: 19234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B22")]
		[Address(RVA = "0x77C240", Offset = "0x77AC40", VA = "0x18077C240", Slot = "4")]
		public override void Initialize(Transform playerCharacter)
		{
		}

		// Token: 0x06004B23 RID: 19235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B23")]
		[Address(RVA = "0x77BFC0", Offset = "0x77A9C0", VA = "0x18077BFC0")]
		private void Aunn_MoreTip()
		{
		}

		// Token: 0x06004B24 RID: 19236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B24")]
		[Address(RVA = "0x77BDE0", Offset = "0x77A7E0", VA = "0x18077BDE0")]
		private void Aunn_GiveTip()
		{
		}

		// Token: 0x06004B25 RID: 19237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B25")]
		[Address(RVA = "0x77C0A0", Offset = "0x77AAA0", VA = "0x18077C0A0")]
		private void Aunn_PatientFreeze()
		{
		}

		// Token: 0x06004B26 RID: 19238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B26")]
		[Address(RVA = "0x77BCD0", Offset = "0x77A6D0", VA = "0x18077BCD0")]
		private void Aunn_Fever()
		{
		}

		// Token: 0x06004B27 RID: 19239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B27")]
		[Address(RVA = "0x77C170", Offset = "0x77AB70", VA = "0x18077C170", Slot = "10")]
		public override void ClearAllBuff()
		{
		}

		// Token: 0x06004B28 RID: 19240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B28")]
		[Address(RVA = "0x77C800", Offset = "0x77B200", VA = "0x18077C800")]
		public AunnQTEBuffReward()
		{
		}

		// Token: 0x04004520 RID: 17696
		[Token(Token = "0x4004520")]
		[FieldOffset(Offset = "0x60")]
		public int extraTipDuration;

		// Token: 0x04004521 RID: 17697
		[Token(Token = "0x4004521")]
		[FieldOffset(Offset = "0x64")]
		public int payTipDuration;

		// Token: 0x04004522 RID: 17698
		[Token(Token = "0x4004522")]
		[FieldOffset(Offset = "0x68")]
		public int patientFreezeDuration;

		// Token: 0x04004523 RID: 17699
		[Token(Token = "0x4004523")]
		[FieldOffset(Offset = "0x6C")]
		public int aunnFeverDuration;

		// Token: 0x04004524 RID: 17700
		[Token(Token = "0x4004524")]
		[FieldOffset(Offset = "0x70")]
		public float extraTipRate;

		// Token: 0x04004525 RID: 17701
		[Token(Token = "0x4004525")]
		[FieldOffset(Offset = "0x74")]
		public int payTipInterval;

		// Token: 0x04004526 RID: 17702
		[Token(Token = "0x4004526")]
		[FieldOffset(Offset = "0x78")]
		public Vector2Int tipRange;

		// Token: 0x04004527 RID: 17703
		[Token(Token = "0x4004527")]
		[FieldOffset(Offset = "0x80")]
		private Action aunnExtraTipEndCallback;

		// Token: 0x04004528 RID: 17704
		[Token(Token = "0x4004528")]
		[FieldOffset(Offset = "0x88")]
		private Action aunnFeverEndCallback;

		// Token: 0x04004529 RID: 17705
		[Token(Token = "0x4004529")]
		[FieldOffset(Offset = "0x90")]
		private Action aunnPatientFreezeEndCallback;

		// Token: 0x0400452A RID: 17706
		[Token(Token = "0x400452A")]
		[FieldOffset(Offset = "0x98")]
		private Action aunnPayTipCallback;
	}
}
