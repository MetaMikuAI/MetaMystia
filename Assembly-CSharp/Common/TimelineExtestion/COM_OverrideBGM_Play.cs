using System;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FD8 RID: 4056
	[Token(Token = "0x2000FD8")]
	public class COM_OverrideBGM_Play : PlayableAsset
	{
		// Token: 0x06005EC5 RID: 24261 RVA: 0x00020D78 File Offset: 0x0001EF78
		[Token(Token = "0x6005EC5")]
		[Address(RVA = "0x8C0B30", Offset = "0x8BF530", VA = "0x1808C0B30", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EC6 RID: 24262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EC6")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_OverrideBGM_Play()
		{
		}

		// Token: 0x040057C3 RID: 22467
		[Token(Token = "0x40057C3")]
		[FieldOffset(Offset = "0x18")]
		public LoopedBGMPackage musicPackage;
	}
}
