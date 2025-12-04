using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C9F RID: 3231
	[Token(Token = "0x2000C9F")]
	[CreateAssetMenu(fileName = "KyoukoQTERewardData", menuName = "GameData Profile/QTERewardData/Kyouko", order = 2)]
	public class KyoukoQTEBuffReward : QTEBuffReward
	{
		// Token: 0x06004B47 RID: 19271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B47")]
		[Address(RVA = "0x77FED0", Offset = "0x77E8D0", VA = "0x18077FED0", Slot = "11")]
		public override string QTEBuffOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06004B48 RID: 19272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B48")]
		[Address(RVA = "0x77FA10", Offset = "0x77E410", VA = "0x18077FA10", Slot = "5")]
		public override void OnQTESucceeded(int index = -1, bool mustSuccess = false)
		{
		}

		// Token: 0x06004B49 RID: 19273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B49")]
		[Address(RVA = "0x77F520", Offset = "0x77DF20", VA = "0x18077F520", Slot = "4")]
		public override void Initialize(Transform playerCharacter)
		{
		}

		// Token: 0x06004B4A RID: 19274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4A")]
		[Address(RVA = "0x77F8E0", Offset = "0x77E2E0", VA = "0x18077F8E0")]
		private void Kyouko_MoreGuest()
		{
		}

		// Token: 0x06004B4B RID: 19275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4B")]
		[Address(RVA = "0x77F810", Offset = "0x77E210", VA = "0x18077F810")]
		private void Kyouko_InstantFinishEat()
		{
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4C")]
		[Address(RVA = "0x77F590", Offset = "0x77DF90", VA = "0x18077F590")]
		private void Kyouko_FasterCook()
		{
		}

		// Token: 0x06004B4D RID: 19277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4D")]
		[Address(RVA = "0x77F6F0", Offset = "0x77E0F0", VA = "0x18077F6F0")]
		private void Kyouko_Fever()
		{
		}

		// Token: 0x06004B4E RID: 19278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4E")]
		[Address(RVA = "0x77F450", Offset = "0x77DE50", VA = "0x18077F450", Slot = "10")]
		public override void ClearAllBuff()
		{
		}

		// Token: 0x06004B4F RID: 19279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B4F")]
		[Address(RVA = "0x77C800", Offset = "0x77B200", VA = "0x18077C800")]
		public KyoukoQTEBuffReward()
		{
		}

		// Token: 0x04004541 RID: 17729
		[Token(Token = "0x4004541")]
		[FieldOffset(Offset = "0x60")]
		public int extraGuestSpawnDuration;

		// Token: 0x04004542 RID: 17730
		[Token(Token = "0x4004542")]
		[FieldOffset(Offset = "0x64")]
		public int instantFinishEatDuration;

		// Token: 0x04004543 RID: 17731
		[Token(Token = "0x4004543")]
		[FieldOffset(Offset = "0x68")]
		public int fasterCookDuration;

		// Token: 0x04004544 RID: 17732
		[Token(Token = "0x4004544")]
		[FieldOffset(Offset = "0x6C")]
		public int kyoukoFeverDuration;

		// Token: 0x04004545 RID: 17733
		[Token(Token = "0x4004545")]
		[FieldOffset(Offset = "0x70")]
		public float extraGuestSpawnRate;

		// Token: 0x04004546 RID: 17734
		[Token(Token = "0x4004546")]
		[FieldOffset(Offset = "0x74")]
		public float fasterCookRate;

		// Token: 0x04004547 RID: 17735
		[Token(Token = "0x4004547")]
		[FieldOffset(Offset = "0x78")]
		public int lockCookerNum;

		// Token: 0x04004548 RID: 17736
		[Token(Token = "0x4004548")]
		[FieldOffset(Offset = "0x80")]
		public GameObject lockCookerEffect;

		// Token: 0x04004549 RID: 17737
		[Token(Token = "0x4004549")]
		[FieldOffset(Offset = "0x88")]
		private Action kyoukoExtraGuestSpawnEndCallback;

		// Token: 0x0400454A RID: 17738
		[Token(Token = "0x400454A")]
		[FieldOffset(Offset = "0x90")]
		private Action kyoukoFasterCookEndCallback;

		// Token: 0x0400454B RID: 17739
		[Token(Token = "0x400454B")]
		[FieldOffset(Offset = "0x98")]
		private Action kyoukoFeverEndCallback;

		// Token: 0x0400454C RID: 17740
		[Token(Token = "0x400454C")]
		[FieldOffset(Offset = "0xA0")]
		private Action kyoukoInstantFinishEatCallback;
	}
}
