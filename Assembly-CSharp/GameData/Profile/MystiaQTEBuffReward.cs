using System;
using Common.VFX;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000CA0 RID: 3232
	[Token(Token = "0x2000CA0")]
	[CreateAssetMenu(fileName = "MystiaQTERewardData", menuName = "GameData Profile/QTERewardData/Mystia", order = 0)]
	public class MystiaQTEBuffReward : QTEBuffReward
	{
		// Token: 0x06004B57 RID: 19287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B57")]
		[Address(RVA = "0x7813D0", Offset = "0x77FDD0", VA = "0x1807813D0", Slot = "11")]
		public override string QTEBuffOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06004B58 RID: 19288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B58")]
		[Address(RVA = "0x780A40", Offset = "0x77F440", VA = "0x180780A40", Slot = "5")]
		public override void OnQTESucceeded(int index = -1, bool mustSuccess = false)
		{
		}

		// Token: 0x06004B59 RID: 19289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B59")]
		[Address(RVA = "0x7806B0", Offset = "0x77F0B0", VA = "0x1807806B0", Slot = "4")]
		public override void Initialize(Transform playerCharacter)
		{
		}

		// Token: 0x06004B5A RID: 19290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5A")]
		[Address(RVA = "0x77F110", Offset = "0x77DB10", VA = "0x18077F110", Slot = "7")]
		public override void TryExecuteThrowDeliver()
		{
		}

		// Token: 0x06004B5B RID: 19291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5B")]
		[Address(RVA = "0x780800", Offset = "0x77F200", VA = "0x180780800", Slot = "8")]
		public override void OnFocusingDeskChanged(int deskCode)
		{
		}

		// Token: 0x06004B5C RID: 19292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5C")]
		[Address(RVA = "0x7810D0", Offset = "0x77FAD0", VA = "0x1807810D0")]
		private void Player_InstantEvaluation()
		{
		}

		// Token: 0x06004B5D RID: 19293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5D")]
		[Address(RVA = "0x7811D0", Offset = "0x77FBD0", VA = "0x1807811D0")]
		private void Player_PatientFreeze()
		{
		}

		// Token: 0x06004B5E RID: 19294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5E")]
		[Address(RVA = "0x781400", Offset = "0x77FE00", VA = "0x180781400", Slot = "9")]
		public override void ToggleThrowDeliverIndicator(bool on)
		{
		}

		// Token: 0x06004B5F RID: 19295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B5F")]
		[Address(RVA = "0x781550", Offset = "0x77FF50", VA = "0x180781550")]
		private void UpdateLegacyThrowDeliverVisual()
		{
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B60")]
		[Address(RVA = "0x7812D0", Offset = "0x77FCD0", VA = "0x1807812D0")]
		private void Player_ThrowDeliver()
		{
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B61")]
		[Address(RVA = "0x780FD0", Offset = "0x77F9D0", VA = "0x180780FD0")]
		private void Player_Fever()
		{
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B62")]
		[Address(RVA = "0x780EE0", Offset = "0x77F8E0", VA = "0x180780EE0")]
		public void Player_Fever_Infinite()
		{
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B63")]
		[Address(RVA = "0x7805F0", Offset = "0x77EFF0", VA = "0x1807805F0", Slot = "10")]
		public override void ClearAllBuff()
		{
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B64")]
		[Address(RVA = "0x77C800", Offset = "0x77B200", VA = "0x18077C800")]
		public MystiaQTEBuffReward()
		{
		}

		// Token: 0x0400454D RID: 17741
		[Token(Token = "0x400454D")]
		private const float THROW_DELIVER_INDICATOR_TRANSITION_POSITION_DURATION = 0.1f;

		// Token: 0x0400454E RID: 17742
		[Token(Token = "0x400454E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int s_On;

		// Token: 0x0400454F RID: 17743
		[Token(Token = "0x400454F")]
		[FieldOffset(Offset = "0x60")]
		public int GuestInstantEvaluateDuration;

		// Token: 0x04004550 RID: 17744
		[Token(Token = "0x4004550")]
		[FieldOffset(Offset = "0x64")]
		public int GuestPatientFreezeDuration;

		// Token: 0x04004551 RID: 17745
		[Token(Token = "0x4004551")]
		[FieldOffset(Offset = "0x68")]
		public int PlayerThrowDeliverDuration;

		// Token: 0x04004552 RID: 17746
		[Token(Token = "0x4004552")]
		[FieldOffset(Offset = "0x6C")]
		public int PlayerFeverDuration;

		// Token: 0x04004553 RID: 17747
		[Token(Token = "0x4004553")]
		[FieldOffset(Offset = "0x70")]
		public GameObject throwDeliverParent;

		// Token: 0x04004554 RID: 17748
		[Token(Token = "0x4004554")]
		[FieldOffset(Offset = "0x78")]
		private Action feverEndCallback;

		// Token: 0x04004555 RID: 17749
		[Token(Token = "0x4004555")]
		[FieldOffset(Offset = "0x80")]
		private Action instantEvaluateEndCallback;

		// Token: 0x04004556 RID: 17750
		[Token(Token = "0x4004556")]
		[FieldOffset(Offset = "0x88")]
		private int m_CurrentFocusedDeskCode;

		// Token: 0x04004557 RID: 17751
		[Token(Token = "0x4004557")]
		[FieldOffset(Offset = "0x8C")]
		private bool m_InternalThrowDeliverStatus;

		// Token: 0x04004558 RID: 17752
		[Token(Token = "0x4004558")]
		[FieldOffset(Offset = "0x90")]
		private Action patientFreezeEndCallback;

		// Token: 0x04004559 RID: 17753
		[Token(Token = "0x4004559")]
		[FieldOffset(Offset = "0x98")]
		private Action throwDeliverEndCallback;

		// Token: 0x0400455A RID: 17754
		[Token(Token = "0x400455A")]
		[FieldOffset(Offset = "0xA0")]
		private DisplayBeizer throwDeliverIndicator;
	}
}
