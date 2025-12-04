using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200049F RID: 1183
	[Token(Token = "0x200049F")]
	public class DS_HakureiFestival_SpecialEffectSet : PlayableAsset
	{
		// Token: 0x06001B1A RID: 6938 RVA: 0x0000A770 File Offset: 0x00008970
		[Token(Token = "0x6001B1A")]
		[Address(RVA = "0x497C80", Offset = "0x496680", VA = "0x180497C80", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B1B")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DS_HakureiFestival_SpecialEffectSet()
		{
		}

		// Token: 0x040018D0 RID: 6352
		[Token(Token = "0x40018D0")]
		[FieldOffset(Offset = "0x18")]
		public HakureiFestivalMap.ViewLabel viewLabel;

		// Token: 0x040018D1 RID: 6353
		[Token(Token = "0x40018D1")]
		[FieldOffset(Offset = "0x1C")]
		public bool open;

		// Token: 0x040018D2 RID: 6354
		[Token(Token = "0x40018D2")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 worldPosition;

		// Token: 0x040018D3 RID: 6355
		[Token(Token = "0x40018D3")]
		[FieldOffset(Offset = "0x28")]
		public string label;

		// Token: 0x040018D4 RID: 6356
		[Token(Token = "0x40018D4")]
		[FieldOffset(Offset = "0x30")]
		public float transitionDuration;
	}
}
