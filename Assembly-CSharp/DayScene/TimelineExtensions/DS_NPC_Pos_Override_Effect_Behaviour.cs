using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200048E RID: 1166
	[Token(Token = "0x200048E")]
	public class DS_NPC_Pos_Override_Effect_Behaviour : DS_NPC_Pos_Effect_Behaviour
	{
		// Token: 0x06001AE9 RID: 6889 RVA: 0x0000A710 File Offset: 0x00008910
		[Token(Token = "0x6001AE9")]
		[Address(RVA = "0x4996E0", Offset = "0x4980E0", VA = "0x1804996E0", Slot = "23")]
		protected override bool TryGetCharacterPosition(out Vector2 position)
		{
			return default(bool);
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AEA")]
		[Address(RVA = "0x499670", Offset = "0x498070", VA = "0x180499670", Slot = "24")]
		protected override void Execute(string characterLabel, bool timeContinue)
		{
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AEB")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public DS_NPC_Pos_Override_Effect_Behaviour()
		{
		}

		// Token: 0x0400189B RID: 6299
		[Token(Token = "0x400189B")]
		[FieldOffset(Offset = "0x40")]
		public string mapLabel;

		// Token: 0x0400189C RID: 6300
		[Token(Token = "0x400189C")]
		[FieldOffset(Offset = "0x48")]
		public Vector2 position;

		// Token: 0x0400189D RID: 6301
		[Token(Token = "0x400189D")]
		[FieldOffset(Offset = "0x50")]
		public int rotation;
	}
}
