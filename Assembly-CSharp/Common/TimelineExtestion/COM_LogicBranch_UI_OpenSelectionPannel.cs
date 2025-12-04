using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FD6 RID: 4054
	[Token(Token = "0x2000FD6")]
	public class COM_LogicBranch_UI_OpenSelectionPannel : PlayableAsset
	{
		// Token: 0x06005EC1 RID: 24257 RVA: 0x00020D48 File Offset: 0x0001EF48
		[Token(Token = "0x6005EC1")]
		[Address(RVA = "0x8C0820", Offset = "0x8BF220", VA = "0x1808C0820", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EC2 RID: 24258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC2")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_LogicBranch_UI_OpenSelectionPannel()
		{
		}

		// Token: 0x040057BF RID: 22463
		[Token(Token = "0x40057BF")]
		[FieldOffset(Offset = "0x18")]
		public GameObject pannelGameObject;

		// Token: 0x040057C0 RID: 22464
		[Token(Token = "0x40057C0")]
		[FieldOffset(Offset = "0x20")]
		public int acceptAddFrames;

		// Token: 0x040057C1 RID: 22465
		[Token(Token = "0x40057C1")]
		[FieldOffset(Offset = "0x24")]
		public int refuseAddFrames;
	}
}
