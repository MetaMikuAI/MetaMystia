using System;
using Common.TimelineExtestion;
using Il2CppDummyDll;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000489 RID: 1161
	[Token(Token = "0x2000489")]
	public class DS_MWorkSessionStart_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06001AD6 RID: 6870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD6")]
		[Address(RVA = "0x498370", Offset = "0x496D70", VA = "0x180498370", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD7")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public DS_MWorkSessionStart_Behaviour()
		{
		}

		// Token: 0x04001887 RID: 6279
		[Token(Token = "0x4001887")]
		[FieldOffset(Offset = "0x10")]
		public DaySceneDirector.IndexCookerPair[] cookerConfigurations;

		// Token: 0x04001888 RID: 6280
		[Token(Token = "0x4001888")]
		[FieldOffset(Offset = "0x18")]
		public int[] dailyBeverages;

		// Token: 0x04001889 RID: 6281
		[Token(Token = "0x4001889")]
		[FieldOffset(Offset = "0x20")]
		public int[] dailyRecipes;

		// Token: 0x0400188A RID: 6282
		[Token(Token = "0x400188A")]
		[FieldOffset(Offset = "0x28")]
		public int izakayaIndex;
	}
}
