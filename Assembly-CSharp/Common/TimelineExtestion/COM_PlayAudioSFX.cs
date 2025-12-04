using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FDA RID: 4058
	[Token(Token = "0x2000FDA")]
	public class COM_PlayAudioSFX : PlayableAsset
	{
		// Token: 0x06005EC9 RID: 24265 RVA: 0x00020DA8 File Offset: 0x0001EFA8
		[Token(Token = "0x6005EC9")]
		[Address(RVA = "0x8C0DA0", Offset = "0x8BF7A0", VA = "0x1808C0DA0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005ECA RID: 24266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ECA")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_PlayAudioSFX()
		{
		}

		// Token: 0x040057C4 RID: 22468
		[Token(Token = "0x40057C4")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip audioClip;
	}
}
