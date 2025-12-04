using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x020004A5 RID: 1189
	[Token(Token = "0x20004A5")]
	public class DS_MWorkSessionStart : PlayableAsset
	{
		// Token: 0x06001B24 RID: 6948 RVA: 0x0000A7E8 File Offset: 0x000089E8
		[Token(Token = "0x6001B24")]
		[Address(RVA = "0x498460", Offset = "0x496E60", VA = "0x180498460", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B25")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DS_MWorkSessionStart()
		{
		}

		// Token: 0x040018E4 RID: 6372
		[Token(Token = "0x40018E4")]
		[FieldOffset(Offset = "0x18")]
		public int izakayaIndex;

		// Token: 0x040018E5 RID: 6373
		[Token(Token = "0x40018E5")]
		[FieldOffset(Offset = "0x20")]
		public int[] dailyRecipes;

		// Token: 0x040018E6 RID: 6374
		[Token(Token = "0x40018E6")]
		[FieldOffset(Offset = "0x28")]
		public int[] dailyBeverages;

		// Token: 0x040018E7 RID: 6375
		[Token(Token = "0x40018E7")]
		[FieldOffset(Offset = "0x30")]
		public DaySceneDirector.IndexCookerPair[] cookerConfigurations;
	}
}
