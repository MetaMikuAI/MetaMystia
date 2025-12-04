using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000734 RID: 1844
	[Token(Token = "0x2000734")]
	public class NS_Set_DoSpawnNGuest_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06002BA9 RID: 11177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA9")]
		[Address(RVA = "0x5E3010", Offset = "0x5E1A10", VA = "0x1805E3010", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAA")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_Set_DoSpawnNGuest_Behaviour()
		{
		}

		// Token: 0x040027FD RID: 10237
		[Token(Token = "0x40027FD")]
		[FieldOffset(Offset = "0x10")]
		public bool shouldSpawn;
	}
}
