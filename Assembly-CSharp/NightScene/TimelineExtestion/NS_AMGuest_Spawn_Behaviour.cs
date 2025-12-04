using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000736 RID: 1846
	[Token(Token = "0x2000736")]
	public class NS_AMGuest_Spawn_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06002BAD RID: 11181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAD")]
		[Address(RVA = "0x5E0010", Offset = "0x5DEA10", VA = "0x1805E0010", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BAE RID: 11182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAE")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_AMGuest_Spawn_Behaviour()
		{
		}

		// Token: 0x04002801 RID: 10241
		[Token(Token = "0x4002801")]
		[FieldOffset(Offset = "0x10")]
		public int specialGuestId;
	}
}
