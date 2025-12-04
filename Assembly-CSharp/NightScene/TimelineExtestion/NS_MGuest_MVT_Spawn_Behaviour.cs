using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000735 RID: 1845
	[Token(Token = "0x2000735")]
	public class NS_MGuest_MVT_Spawn_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06002BAB RID: 11179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAB")]
		[Address(RVA = "0x5E1050", Offset = "0x5DFA50", VA = "0x1805E1050", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06002BAC RID: 11180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BAC")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public NS_MGuest_MVT_Spawn_Behaviour()
		{
		}

		// Token: 0x040027FE RID: 10238
		[Token(Token = "0x40027FE")]
		[FieldOffset(Offset = "0x10")]
		public string label;

		// Token: 0x040027FF RID: 10239
		[Token(Token = "0x40027FF")]
		[FieldOffset(Offset = "0x18")]
		public bool spawnInA;

		// Token: 0x04002800 RID: 10240
		[Token(Token = "0x4002800")]
		[FieldOffset(Offset = "0x1C")]
		public int specialGuestId;
	}
}
