using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FCC RID: 4044
	[Token(Token = "0x2000FCC")]
	public class COM_Camera_Shake : PlayableAsset
	{
		// Token: 0x06005EAD RID: 24237 RVA: 0x00020C58 File Offset: 0x0001EE58
		[Token(Token = "0x6005EAD")]
		[Address(RVA = "0x8BE8E0", Offset = "0x8BD2E0", VA = "0x1808BE8E0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EAE RID: 24238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EAE")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_Camera_Shake()
		{
		}

		// Token: 0x040057B1 RID: 22449
		[Token(Token = "0x40057B1")]
		[FieldOffset(Offset = "0x18")]
		public float amplitude;

		// Token: 0x040057B2 RID: 22450
		[Token(Token = "0x40057B2")]
		[FieldOffset(Offset = "0x1C")]
		public float _duration;
	}
}
