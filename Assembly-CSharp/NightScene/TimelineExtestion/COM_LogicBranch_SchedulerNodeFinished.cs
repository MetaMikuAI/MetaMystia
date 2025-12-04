using System;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000731 RID: 1841
	[Token(Token = "0x2000731")]
	public class COM_LogicBranch_SchedulerNodeFinished : PlayableAsset
	{
		// Token: 0x06002BA3 RID: 11171 RVA: 0x0000F858 File Offset: 0x0000DA58
		[Token(Token = "0x6002BA3")]
		[Address(RVA = "0x5DFEB0", Offset = "0x5DE8B0", VA = "0x1805DFEB0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BA4")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_LogicBranch_SchedulerNodeFinished()
		{
		}

		// Token: 0x040027F8 RID: 10232
		[Token(Token = "0x40027F8")]
		[FieldOffset(Offset = "0x18")]
		public string nodeLabel;

		// Token: 0x040027F9 RID: 10233
		[Token(Token = "0x40027F9")]
		[FieldOffset(Offset = "0x20")]
		public SchedulerNode.NodeType nodeType;

		// Token: 0x040027FA RID: 10234
		[Token(Token = "0x40027FA")]
		[FieldOffset(Offset = "0x24")]
		public int trueAddFrames;

		// Token: 0x040027FB RID: 10235
		[Token(Token = "0x40027FB")]
		[FieldOffset(Offset = "0x28")]
		public int falseAddFrames;
	}
}
