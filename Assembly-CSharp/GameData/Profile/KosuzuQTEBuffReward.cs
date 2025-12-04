using System;
using System.Runtime.CompilerServices;
using Common.VFX;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C9D RID: 3229
	[Token(Token = "0x2000C9D")]
	[CreateAssetMenu(fileName = "KosuzuQTERewardData", menuName = "GameData Profile/QTERewardData/Kosuzu", order = 3)]
	public class KosuzuQTEBuffReward : QTEBuffReward
	{
		// Token: 0x06004B30 RID: 19248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004B30")]
		[Address(RVA = "0x77EFD0", Offset = "0x77D9D0", VA = "0x18077EFD0", Slot = "11")]
		public override string QTEBuffOwnerIdentifier()
		{
			return null;
		}

		// Token: 0x06004B31 RID: 19249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B31")]
		[Address(RVA = "0x77EB00", Offset = "0x77D500", VA = "0x18077EB00", Slot = "5")]
		public override void OnQTESucceeded(int index = -1, bool mustSuccess = false)
		{
		}

		// Token: 0x06004B32 RID: 19250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B32")]
		[Address(RVA = "0x77E2F0", Offset = "0x77CCF0", VA = "0x18077E2F0", Slot = "4")]
		public override void Initialize(Transform playerCharacter)
		{
		}

		// Token: 0x06004B33 RID: 19251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B33")]
		[Address(RVA = "0x77F330", Offset = "0x77DD30", VA = "0x18077F330")]
		private void UpdateLegacyThrowDeliverVisual()
		{
		}

		// Token: 0x06004B34 RID: 19252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B34")]
		[Address(RVA = "0x77F110", Offset = "0x77DB10", VA = "0x18077F110", Slot = "7")]
		public override void TryExecuteThrowDeliver()
		{
		}

		// Token: 0x06004B35 RID: 19253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B35")]
		[Address(RVA = "0x77E8C0", Offset = "0x77D2C0", VA = "0x18077E8C0", Slot = "8")]
		public override void OnFocusingDeskChanged(int deskCode)
		{
		}

		// Token: 0x06004B36 RID: 19254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B36")]
		[Address(RVA = "0x77E430", Offset = "0x77CE30", VA = "0x18077E430")]
		private void Kosuzu_Dialogues()
		{
		}

		// Token: 0x06004B37 RID: 19255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B37")]
		[Address(RVA = "0x77E650", Offset = "0x77D050", VA = "0x18077E650")]
		private void Kosuzu_LunaticCook()
		{
		}

		// Token: 0x06004B38 RID: 19256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B38")]
		[Address(RVA = "0x77F000", Offset = "0x77DA00", VA = "0x18077F000", Slot = "9")]
		public override void ToggleThrowDeliverIndicator(bool on)
		{
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B39")]
		[Address(RVA = "0x77E7B0", Offset = "0x77D1B0", VA = "0x18077E7B0")]
		private void Kosuzu_ThrowDeliver()
		{
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B3A")]
		[Address(RVA = "0x77E510", Offset = "0x77CF10", VA = "0x18077E510")]
		private void Kosuzu_Fever()
		{
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B3B")]
		[Address(RVA = "0x77E220", Offset = "0x77CC20", VA = "0x18077E220", Slot = "10")]
		public override void ClearAllBuff()
		{
		}

		// Token: 0x06004B3C RID: 19260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B3C")]
		[Address(RVA = "0x77C800", Offset = "0x77B200", VA = "0x18077C800")]
		public KosuzuQTEBuffReward()
		{
		}

		// Token: 0x06004B3F RID: 19263 RVA: 0x0001B348 File Offset: 0x00019548
		[Token(Token = "0x6004B3F")]
		[Address(RVA = "0x77F1F0", Offset = "0x77DBF0", VA = "0x18077F1F0")]
		[CompilerGenerated]
		private float <Kosuzu_LunaticCook>g__ExtraCookSpeed|24_0()
		{
			return 0f;
		}

		// Token: 0x06004B43 RID: 19267 RVA: 0x0001B360 File Offset: 0x00019560
		[Token(Token = "0x6004B43")]
		[Address(RVA = "0x77F1F0", Offset = "0x77DBF0", VA = "0x18077F1F0")]
		[CompilerGenerated]
		private float <Kosuzu_Fever>g__ExtraCookSpeed|27_0()
		{
			return 0f;
		}

		// Token: 0x0400452D RID: 17709
		[Token(Token = "0x400452D")]
		private const float THROW_DELIVER_INDICATOR_TRANSITION_POSITION_DURATION = 0.1f;

		// Token: 0x0400452E RID: 17710
		[Token(Token = "0x400452E")]
		private const int MAX_COMBO = 60;

		// Token: 0x0400452F RID: 17711
		[Token(Token = "0x400452F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int s_On;

		// Token: 0x04004530 RID: 17712
		[Token(Token = "0x4004530")]
		[FieldOffset(Offset = "0x60")]
		public int dialoguesBuffDuration;

		// Token: 0x04004531 RID: 17713
		[Token(Token = "0x4004531")]
		[FieldOffset(Offset = "0x64")]
		public int lunaticCookBuffDuration;

		// Token: 0x04004532 RID: 17714
		[Token(Token = "0x4004532")]
		[FieldOffset(Offset = "0x68")]
		public int throwDeliverBuffDuration;

		// Token: 0x04004533 RID: 17715
		[Token(Token = "0x4004533")]
		[FieldOffset(Offset = "0x6C")]
		public int kosuzuFeverDuration;

		// Token: 0x04004534 RID: 17716
		[Token(Token = "0x4004534")]
		[FieldOffset(Offset = "0x70")]
		public int extraMoodGet;

		// Token: 0x04004535 RID: 17717
		[Token(Token = "0x4004535")]
		[FieldOffset(Offset = "0x74")]
		public float eachComboAddSpeed;

		// Token: 0x04004536 RID: 17718
		[Token(Token = "0x4004536")]
		[FieldOffset(Offset = "0x78")]
		public GameObject throwDeliverParent;

		// Token: 0x04004537 RID: 17719
		[Token(Token = "0x4004537")]
		[FieldOffset(Offset = "0x80")]
		private Action kosuzuDialoguesEndCallback;

		// Token: 0x04004538 RID: 17720
		[Token(Token = "0x4004538")]
		[FieldOffset(Offset = "0x88")]
		private Action kosuzuFeverEndCallback;

		// Token: 0x04004539 RID: 17721
		[Token(Token = "0x4004539")]
		[FieldOffset(Offset = "0x90")]
		private Action kosuzuLunaticCookEndCallback;

		// Token: 0x0400453A RID: 17722
		[Token(Token = "0x400453A")]
		[FieldOffset(Offset = "0x98")]
		private Action kosuzuThrowDeliverEndCallback;

		// Token: 0x0400453B RID: 17723
		[Token(Token = "0x400453B")]
		[FieldOffset(Offset = "0xA0")]
		private int m_CurrentFocusedDeskCode;

		// Token: 0x0400453C RID: 17724
		[Token(Token = "0x400453C")]
		[FieldOffset(Offset = "0xA4")]
		private bool m_InternalThrowDeliverStatus;

		// Token: 0x0400453D RID: 17725
		[Token(Token = "0x400453D")]
		[FieldOffset(Offset = "0xA8")]
		private DisplayBeizer throwDeliverIndicator;
	}
}
