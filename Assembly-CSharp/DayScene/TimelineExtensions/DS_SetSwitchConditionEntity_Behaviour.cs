using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000497 RID: 1175
	[Token(Token = "0x2000497")]
	public class DS_SetSwitchConditionEntity_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06001AFE RID: 6910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFE")]
		[Address(RVA = "0x49A5F0", Offset = "0x498FF0", VA = "0x18049A5F0", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AFF")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public DS_SetSwitchConditionEntity_Behaviour()
		{
		}

		// Token: 0x040018AE RID: 6318
		[Token(Token = "0x40018AE")]
		[FieldOffset(Offset = "0x10")]
		public bool on;

		// Token: 0x040018AF RID: 6319
		[Token(Token = "0x40018AF")]
		[FieldOffset(Offset = "0x18")]
		public string visualEntityLabel;
	}
}
