using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FF7 RID: 4087
	[Token(Token = "0x2000FF7")]
	public class COM_Camera_WorldPos_Set_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06005F07 RID: 24327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F07")]
		[Address(RVA = "0x8BECA0", Offset = "0x8BD6A0", VA = "0x1808BECA0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F08 RID: 24328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F08")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_Camera_WorldPos_Set_Behaviour()
		{
		}

		// Token: 0x0400580E RID: 22542
		[Token(Token = "0x400580E")]
		[FieldOffset(Offset = "0x10")]
		public float damping;

		// Token: 0x0400580F RID: 22543
		[Token(Token = "0x400580F")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 targetCoordinate;
	}
}
