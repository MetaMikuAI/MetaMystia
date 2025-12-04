using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FFE RID: 4094
	[Token(Token = "0x2000FFE")]
	public class COM_LogicBranch_UI_OpenSelectionPannel_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06005F15 RID: 24341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F15")]
		[Address(RVA = "0x8C0360", Offset = "0x8BED60", VA = "0x1808C0360", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F16 RID: 24342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005F16")]
		[Address(RVA = "0x8C02E0", Offset = "0x8BECE0", VA = "0x1808C02E0")]
		private IEnumerator ExecuteDelayed(Action action)
		{
			return null;
		}

		// Token: 0x06005F17 RID: 24343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F17")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_LogicBranch_UI_OpenSelectionPannel_Behaviour()
		{
		}

		// Token: 0x06005F1A RID: 24346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F1A")]
		[Address(RVA = "0x8C07D0", Offset = "0x8BF1D0", VA = "0x1808C07D0")]
		[CompilerGenerated]
		private void <OnBehaviourEnter>g__End|3_1()
		{
		}

		// Token: 0x04005818 RID: 22552
		[Token(Token = "0x4005818")]
		[FieldOffset(Offset = "0x10")]
		public GameObject pannelGameObject;

		// Token: 0x04005819 RID: 22553
		[Token(Token = "0x4005819")]
		[FieldOffset(Offset = "0x18")]
		public int acceptAddFrames;

		// Token: 0x0400581A RID: 22554
		[Token(Token = "0x400581A")]
		[FieldOffset(Offset = "0x1C")]
		public int refuseAddFrames;
	}
}
