using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FD3 RID: 4051
	[Token(Token = "0x2000FD3")]
	public class COM_Items_Out : PlayableAsset
	{
		// Token: 0x06005EBB RID: 24251 RVA: 0x00020D00 File Offset: 0x0001EF00
		[Token(Token = "0x6005EBB")]
		[Address(RVA = "0x8BF730", Offset = "0x8BE130", VA = "0x1808BF730", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EBC RID: 24252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EBC")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_Items_Out()
		{
		}

		// Token: 0x040057BB RID: 22459
		[Token(Token = "0x40057BB")]
		[FieldOffset(Offset = "0x18")]
		public Product[] items;
	}
}
