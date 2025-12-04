using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000494 RID: 1172
	[Token(Token = "0x2000494")]
	public class DS_SetSelectedMapLabel_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06001AF7 RID: 6903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF7")]
		[Address(RVA = "0x49A490", Offset = "0x498E90", VA = "0x18049A490", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF8")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public DS_SetSelectedMapLabel_Behaviour()
		{
		}

		// Token: 0x040018A3 RID: 6307
		[Token(Token = "0x40018A3")]
		[FieldOffset(Offset = "0x10")]
		public string mapLabel;
	}
}
