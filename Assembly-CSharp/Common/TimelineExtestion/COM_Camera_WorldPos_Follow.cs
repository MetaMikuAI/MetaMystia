using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FCD RID: 4045
	[Token(Token = "0x2000FCD")]
	public class COM_Camera_WorldPos_Follow : PlayableAsset
	{
		// Token: 0x06005EAF RID: 24239 RVA: 0x00020C70 File Offset: 0x0001EE70
		[Token(Token = "0x6005EAF")]
		[Address(RVA = "0x8BEA60", Offset = "0x8BD460", VA = "0x1808BEA60", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EB0 RID: 24240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EB0")]
		[Address(RVA = "0x8BEB80", Offset = "0x8BD580", VA = "0x1808BEB80")]
		public COM_Camera_WorldPos_Follow()
		{
		}

		// Token: 0x040057B3 RID: 22451
		[Token(Token = "0x40057B3")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x040057B4 RID: 22452
		[Token(Token = "0x40057B4")]
		[FieldOffset(Offset = "0x20")]
		public float damping;
	}
}
