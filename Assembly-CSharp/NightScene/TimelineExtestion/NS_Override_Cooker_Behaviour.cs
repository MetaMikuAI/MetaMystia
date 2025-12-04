using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200074D RID: 1869
	[Token(Token = "0x200074D")]
	public class NS_Override_Cooker_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06002BE4 RID: 11236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE4")]
		[Address(RVA = "0x5E2600", Offset = "0x5E1000", VA = "0x1805E2600", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE5")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_Override_Cooker_Behaviour()
		{
		}

		// Token: 0x0400282B RID: 10283
		[Token(Token = "0x400282B")]
		[FieldOffset(Offset = "0x10")]
		public int[] cookerArray;
	}
}
