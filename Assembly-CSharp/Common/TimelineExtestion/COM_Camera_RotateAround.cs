using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FCB RID: 4043
	[Token(Token = "0x2000FCB")]
	public class COM_Camera_RotateAround : PlayableAsset
	{
		// Token: 0x06005EAB RID: 24235 RVA: 0x00020C40 File Offset: 0x0001EE40
		[Token(Token = "0x6005EAB")]
		[Address(RVA = "0x8BE6D0", Offset = "0x8BD0D0", VA = "0x1808BE6D0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EAC RID: 24236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EAC")]
		[Address(RVA = "0x8BE860", Offset = "0x8BD260", VA = "0x1808BE860")]
		public COM_Camera_RotateAround()
		{
		}

		// Token: 0x040057AC RID: 22444
		[Token(Token = "0x40057AC")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 startPoint;

		// Token: 0x040057AD RID: 22445
		[Token(Token = "0x40057AD")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 pivot;

		// Token: 0x040057AE RID: 22446
		[Token(Token = "0x40057AE")]
		[FieldOffset(Offset = "0x28")]
		public float angle;

		// Token: 0x040057AF RID: 22447
		[Token(Token = "0x40057AF")]
		[FieldOffset(Offset = "0x2C")]
		public float speedMultiplier;

		// Token: 0x040057B0 RID: 22448
		[Token(Token = "0x40057B0")]
		[FieldOffset(Offset = "0x30")]
		public bool shouldWaitForFinish;
	}
}
