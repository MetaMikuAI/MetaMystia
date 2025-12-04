using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000733 RID: 1843
	[Token(Token = "0x2000733")]
	public class NS_Set_DoTimeFlow_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06002BA7 RID: 11175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA7")]
		[Address(RVA = "0x5E32B0", Offset = "0x5E1CB0", VA = "0x1805E32B0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA8")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_Set_DoTimeFlow_Behaviour()
		{
		}

		// Token: 0x040027FC RID: 10236
		[Token(Token = "0x40027FC")]
		[FieldOffset(Offset = "0x10")]
		public bool shouldFlow;
	}
}
