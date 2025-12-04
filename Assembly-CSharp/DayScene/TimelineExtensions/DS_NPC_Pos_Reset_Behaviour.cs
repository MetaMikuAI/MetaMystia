using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200048B RID: 1163
	[Token(Token = "0x200048B")]
	public class DS_NPC_Pos_Reset_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06001ADA RID: 6874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADA")]
		[Address(RVA = "0x4998D0", Offset = "0x4982D0", VA = "0x1804998D0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06001ADB RID: 6875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADB")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public DS_NPC_Pos_Reset_Behaviour()
		{
		}

		// Token: 0x0400188F RID: 6287
		[Token(Token = "0x400188F")]
		[FieldOffset(Offset = "0x10")]
		public string characterLabel;
	}
}
