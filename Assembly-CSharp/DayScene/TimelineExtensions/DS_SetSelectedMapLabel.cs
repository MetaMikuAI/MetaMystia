using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x020004AC RID: 1196
	[Token(Token = "0x20004AC")]
	public class DS_SetSelectedMapLabel : PlayableAsset
	{
		// Token: 0x06001B32 RID: 6962 RVA: 0x0000A890 File Offset: 0x00008A90
		[Token(Token = "0x6001B32")]
		[Address(RVA = "0x49A4E0", Offset = "0x498EE0", VA = "0x18049A4E0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B33")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DS_SetSelectedMapLabel()
		{
		}

		// Token: 0x04001908 RID: 6408
		[Token(Token = "0x4001908")]
		[FieldOffset(Offset = "0x18")]
		public string mapLabel;
	}
}
