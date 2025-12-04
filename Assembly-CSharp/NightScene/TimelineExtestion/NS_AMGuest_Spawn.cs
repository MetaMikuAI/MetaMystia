using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x02000752 RID: 1874
	[Token(Token = "0x2000752")]
	public class NS_AMGuest_Spawn : PlayableAsset
	{
		// Token: 0x06002BEE RID: 11246 RVA: 0x0000F888 File Offset: 0x0000DA88
		[Token(Token = "0x6002BEE")]
		[Address(RVA = "0x5E00C0", Offset = "0x5DEAC0", VA = "0x1805E00C0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002BEF")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_AMGuest_Spawn()
		{
		}

		// Token: 0x04002830 RID: 10288
		[Token(Token = "0x4002830")]
		[FieldOffset(Offset = "0x18")]
		public int specialGuestId;
	}
}
