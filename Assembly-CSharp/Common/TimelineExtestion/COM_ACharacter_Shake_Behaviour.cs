using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02001007 RID: 4103
	[Token(Token = "0x2001007")]
	public class COM_ACharacter_Shake_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06005F31 RID: 24369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F31")]
		[Address(RVA = "0x8BC910", Offset = "0x8BB310", VA = "0x1808BC910", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F32 RID: 24370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F32")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ACharacter_Shake_Behaviour()
		{
		}

		// Token: 0x04005833 RID: 22579
		[Token(Token = "0x4005833")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		// Token: 0x04005834 RID: 22580
		[Token(Token = "0x4005834")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 amplitude;

		// Token: 0x04005835 RID: 22581
		[Token(Token = "0x4005835")]
		[FieldOffset(Offset = "0x20")]
		public float duration;

		// Token: 0x04005836 RID: 22582
		[Token(Token = "0x4005836")]
		[FieldOffset(Offset = "0x24")]
		public bool shouldWaitForFinish;
	}
}
