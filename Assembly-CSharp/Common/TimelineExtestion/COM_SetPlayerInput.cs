using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FDD RID: 4061
	[Token(Token = "0x2000FDD")]
	public class COM_SetPlayerInput : PlayableAsset
	{
		// Token: 0x06005ECF RID: 24271 RVA: 0x00020DF0 File Offset: 0x0001EFF0
		[Token(Token = "0x6005ECF")]
		[Address(RVA = "0x8C1170", Offset = "0x8BFB70", VA = "0x1808C1170", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005ED0 RID: 24272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED0")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_SetPlayerInput()
		{
		}

		// Token: 0x040057C6 RID: 22470
		[Token(Token = "0x40057C6")]
		[FieldOffset(Offset = "0x18")]
		public bool enabled;
	}
}
