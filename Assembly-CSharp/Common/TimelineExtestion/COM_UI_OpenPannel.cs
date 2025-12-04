using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FE3 RID: 4067
	[Token(Token = "0x2000FE3")]
	public class COM_UI_OpenPannel : PlayableAsset
	{
		// Token: 0x06005EDB RID: 24283 RVA: 0x00020E80 File Offset: 0x0001F080
		[Token(Token = "0x6005EDB")]
		[Address(RVA = "0x8C19C0", Offset = "0x8C03C0", VA = "0x1808C19C0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EDC RID: 24284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EDC")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_UI_OpenPannel()
		{
		}

		// Token: 0x040057CC RID: 22476
		[Token(Token = "0x40057CC")]
		[FieldOffset(Offset = "0x18")]
		public GameObject pannelGameObject;
	}
}
