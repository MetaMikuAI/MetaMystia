using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FE4 RID: 4068
	[Token(Token = "0x2000FE4")]
	public class COM_WorldOverlay_Delete : PlayableAsset
	{
		// Token: 0x06005EDD RID: 24285 RVA: 0x00020E98 File Offset: 0x0001F098
		[Token(Token = "0x6005EDD")]
		[Address(RVA = "0x8C1B30", Offset = "0x8C0530", VA = "0x1808C1B30", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EDE RID: 24286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EDE")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_WorldOverlay_Delete()
		{
		}

		// Token: 0x040057CD RID: 22477
		[Token(Token = "0x40057CD")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x040057CE RID: 22478
		[Token(Token = "0x40057CE")]
		[FieldOffset(Offset = "0x20")]
		public float transitionDuration;
	}
}
