using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000493 RID: 1171
	[Token(Token = "0x2000493")]
	public class DS_GiveResource_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06001AF5 RID: 6901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF5")]
		[Address(RVA = "0x497940", Offset = "0x496340", VA = "0x180497940", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06001AF6 RID: 6902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AF6")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public DS_GiveResource_Behaviour()
		{
		}

		// Token: 0x040018A2 RID: 6306
		[Token(Token = "0x40018A2")]
		[FieldOffset(Offset = "0x10")]
		public int resourceCode;
	}
}
