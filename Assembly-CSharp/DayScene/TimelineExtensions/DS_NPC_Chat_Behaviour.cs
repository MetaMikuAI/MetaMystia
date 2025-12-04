using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000498 RID: 1176
	[Token(Token = "0x2000498")]
	public class DS_NPC_Chat_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06001B00 RID: 6912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B00")]
		[Address(RVA = "0x498BB0", Offset = "0x4975B0", VA = "0x180498BB0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B01")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public DS_NPC_Chat_Behaviour()
		{
		}

		// Token: 0x040018B0 RID: 6320
		[Token(Token = "0x40018B0")]
		[FieldOffset(Offset = "0x10")]
		public string characterLabel;
	}
}
