using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FB8 RID: 4024
	[Token(Token = "0x2000FB8")]
	public class COM_ACharacter_Move : PlayableAsset
	{
		// Token: 0x06005E85 RID: 24197 RVA: 0x00020A78 File Offset: 0x0001EC78
		[Token(Token = "0x6005E85")]
		[Address(RVA = "0x8BB8D0", Offset = "0x8BA2D0", VA = "0x1808BB8D0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005E86 RID: 24198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E86")]
		[Address(RVA = "0x8BBA60", Offset = "0x8BA460", VA = "0x1808BBA60")]
		public COM_ACharacter_Move()
		{
		}

		// Token: 0x04005780 RID: 22400
		[Token(Token = "0x4005780")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x04005781 RID: 22401
		[Token(Token = "0x4005781")]
		[FieldOffset(Offset = "0x20")]
		public Vector2[] wayPoints;

		// Token: 0x04005782 RID: 22402
		[Token(Token = "0x4005782")]
		[FieldOffset(Offset = "0x28")]
		public float speedMultiplier;

		// Token: 0x04005783 RID: 22403
		[Token(Token = "0x4005783")]
		[FieldOffset(Offset = "0x2C")]
		public bool shouldWaitForFinish;

		// Token: 0x04005784 RID: 22404
		[Token(Token = "0x4005784")]
		[FieldOffset(Offset = "0x2D")]
		public bool noAnimation;
	}
}
