using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200074E RID: 1870
	[Token(Token = "0x200074E")]
	public class NS_Override_Recipe_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06002BE6 RID: 11238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE6")]
		[Address(RVA = "0x5E28C0", Offset = "0x5E12C0", VA = "0x1805E28C0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BE7")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_Override_Recipe_Behaviour()
		{
		}

		// Token: 0x0400282C RID: 10284
		[Token(Token = "0x400282C")]
		[FieldOffset(Offset = "0x10")]
		public int[] recipeArray;
	}
}
