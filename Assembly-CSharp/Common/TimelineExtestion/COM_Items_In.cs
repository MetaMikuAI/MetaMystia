using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FD2 RID: 4050
	[Token(Token = "0x2000FD2")]
	public class COM_Items_In : PlayableAsset
	{
		// Token: 0x06005EB9 RID: 24249 RVA: 0x00020CE8 File Offset: 0x0001EEE8
		[Token(Token = "0x6005EB9")]
		[Address(RVA = "0x8BF5C0", Offset = "0x8BDFC0", VA = "0x1808BF5C0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EBA RID: 24250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EBA")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_Items_In()
		{
		}

		// Token: 0x040057B9 RID: 22457
		[Token(Token = "0x40057B9")]
		[FieldOffset(Offset = "0x18")]
		public Product[] items;

		// Token: 0x040057BA RID: 22458
		[Token(Token = "0x40057BA")]
		[FieldOffset(Offset = "0x20")]
		public bool suppressCallbacks;
	}
}
