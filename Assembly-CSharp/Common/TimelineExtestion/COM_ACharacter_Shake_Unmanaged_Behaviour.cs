using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02001008 RID: 4104
	[Token(Token = "0x2001008")]
	public class COM_ACharacter_Shake_Unmanaged_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F33 RID: 24371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F33")]
		[Address(RVA = "0x8BCBA0", Offset = "0x8BB5A0", VA = "0x1808BCBA0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F34 RID: 24372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F34")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ACharacter_Shake_Unmanaged_Behaviour()
		{
		}

		// Token: 0x04005837 RID: 22583
		[Token(Token = "0x4005837")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		// Token: 0x04005838 RID: 22584
		[Token(Token = "0x4005838")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 amplitude;
	}
}
