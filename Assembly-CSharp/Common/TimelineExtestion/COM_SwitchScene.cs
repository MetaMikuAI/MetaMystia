using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FE0 RID: 4064
	[Token(Token = "0x2000FE0")]
	public class COM_SwitchScene : PlayableAsset
	{
		// Token: 0x06005ED5 RID: 24277 RVA: 0x00020E38 File Offset: 0x0001F038
		[Token(Token = "0x6005ED5")]
		[Address(RVA = "0x8C15B0", Offset = "0x8BFFB0", VA = "0x1808C15B0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005ED6 RID: 24278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED6")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_SwitchScene()
		{
		}

		// Token: 0x040057CA RID: 22474
		[Token(Token = "0x40057CA")]
		[FieldOffset(Offset = "0x18")]
		public GameObject sceneReference;

		// Token: 0x040057CB RID: 22475
		[Token(Token = "0x40057CB")]
		[FieldOffset(Offset = "0x20")]
		public string label;
	}
}
