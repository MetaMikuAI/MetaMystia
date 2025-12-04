using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FB5 RID: 4021
	[Token(Token = "0x2000FB5")]
	public class COM_ACharacter_DetachAndOverridePosition : PlayableAsset
	{
		// Token: 0x06005E7F RID: 24191 RVA: 0x00020A30 File Offset: 0x0001EC30
		[Token(Token = "0x6005E7F")]
		[Address(RVA = "0x8BB0E0", Offset = "0x8B9AE0", VA = "0x1808BB0E0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005E80 RID: 24192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E80")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_ACharacter_DetachAndOverridePosition()
		{
		}

		// Token: 0x04005774 RID: 22388
		[Token(Token = "0x4005774")]
		[FieldOffset(Offset = "0x18")]
		public string baseLabel;

		// Token: 0x04005775 RID: 22389
		[Token(Token = "0x4005775")]
		[FieldOffset(Offset = "0x20")]
		public int detachIndex;

		// Token: 0x04005776 RID: 22390
		[Token(Token = "0x4005776")]
		[FieldOffset(Offset = "0x28")]
		public string detachCharacterLabel;

		// Token: 0x04005777 RID: 22391
		[Token(Token = "0x4005777")]
		[FieldOffset(Offset = "0x30")]
		public Vector2 overridePosition;
	}
}
