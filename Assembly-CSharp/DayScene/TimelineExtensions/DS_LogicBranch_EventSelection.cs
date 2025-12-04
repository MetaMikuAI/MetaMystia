using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x020004A1 RID: 1185
	[Token(Token = "0x20004A1")]
	public class DS_LogicBranch_EventSelection : PlayableAsset
	{
		// Token: 0x06001B1E RID: 6942 RVA: 0x0000A7A0 File Offset: 0x000089A0
		[Token(Token = "0x6001B1E")]
		[Address(RVA = "0x498260", Offset = "0x496C60", VA = "0x180498260", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B1F")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DS_LogicBranch_EventSelection()
		{
		}

		// Token: 0x040018D7 RID: 6359
		[Token(Token = "0x40018D7")]
		[FieldOffset(Offset = "0x18")]
		public DS_LogicBranch_EventSelection.EventOption[] eventOptions;

		// Token: 0x020004A2 RID: 1186
		[Token(Token = "0x20004A2")]
		[Serializable]
		public struct EventOption
		{
			// Token: 0x040018D8 RID: 6360
			[Token(Token = "0x40018D8")]
			[FieldOffset(Offset = "0x0")]
			public string Title;

			// Token: 0x040018D9 RID: 6361
			[Token(Token = "0x40018D9")]
			[FieldOffset(Offset = "0x8")]
			public int AddFrames;
		}
	}
}
