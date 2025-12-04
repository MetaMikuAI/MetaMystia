using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000751 RID: 1873
	[Token(Token = "0x2000751")]
	public class NS_Set_DoSpawnSGuest_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06002BEC RID: 11244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BEC")]
		[Address(RVA = "0x5E3160", Offset = "0x5E1B60", VA = "0x1805E3160", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BED")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_Set_DoSpawnSGuest_Behaviour()
		{
		}

		// Token: 0x0400282F RID: 10287
		[Token(Token = "0x400282F")]
		[FieldOffset(Offset = "0x10")]
		public bool shouldSpawn;
	}
}
