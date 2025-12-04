using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.DialogUtility
{
	// Token: 0x02000D97 RID: 3479
	[Token(Token = "0x2000D97")]
	[Serializable]
	public struct SpeakerIdentity
	{
		// Token: 0x060051BB RID: 20923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60051BB")]
		[Address(RVA = "0x783A10", Offset = "0x782410", VA = "0x180783A10")]
		public SpeakerIdentity(SpeakerIdentity.Identity speakerType, int speakerId, int speakerPortrayalVariationId)
		{
		}

		// Token: 0x060051BC RID: 20924 RVA: 0x0001DAF0 File Offset: 0x0001BCF0
		[Token(Token = "0x60051BC")]
		[Address(RVA = "0x800650", Offset = "0x7FF050", VA = "0x180800650")]
		public static implicit operator ValueTuple<SpeakerIdentity.Identity, int>(SpeakerIdentity speakerIdentity)
		{
			return default(ValueTuple<SpeakerIdentity.Identity, int>);
		}

		// Token: 0x04004CAF RID: 19631
		[Token(Token = "0x4004CAF")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public SpeakerIdentity.Identity speakerType;

		// Token: 0x04004CB0 RID: 19632
		[Token(Token = "0x4004CB0")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		public int speakerId;

		// Token: 0x04004CB1 RID: 19633
		[Token(Token = "0x4004CB1")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public int speakerPortrayalVariationId;

		// Token: 0x02000D98 RID: 3480
		[Token(Token = "0x2000D98")]
		public enum Identity
		{
			// Token: 0x04004CB3 RID: 19635
			[Token(Token = "0x4004CB3")]
			Self,
			// Token: 0x04004CB4 RID: 19636
			[Token(Token = "0x4004CB4")]
			Special,
			// Token: 0x04004CB5 RID: 19637
			[Token(Token = "0x4004CB5")]
			Normal,
			// Token: 0x04004CB6 RID: 19638
			[Token(Token = "0x4004CB6")]
			Unknown
		}
	}
}
