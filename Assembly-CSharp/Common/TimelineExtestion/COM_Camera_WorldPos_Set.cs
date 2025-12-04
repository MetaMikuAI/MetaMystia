using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FCF RID: 4047
	[Token(Token = "0x2000FCF")]
	public class COM_Camera_WorldPos_Set : PlayableAsset
	{
		// Token: 0x06005EB3 RID: 24243 RVA: 0x00020CA0 File Offset: 0x0001EEA0
		[Token(Token = "0x6005EB3")]
		[Address(RVA = "0x8BED10", Offset = "0x8BD710", VA = "0x1808BED10", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EB4 RID: 24244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB4")]
		[Address(RVA = "0x8BEB80", Offset = "0x8BD580", VA = "0x1808BEB80")]
		public COM_Camera_WorldPos_Set()
		{
		}

		// Token: 0x040057B5 RID: 22453
		[Token(Token = "0x40057B5")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 targetCoordinate;

		// Token: 0x040057B6 RID: 22454
		[Token(Token = "0x40057B6")]
		[FieldOffset(Offset = "0x20")]
		public float damping;
	}
}
