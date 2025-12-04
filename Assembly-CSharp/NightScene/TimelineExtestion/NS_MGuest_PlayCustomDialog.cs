using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200075E RID: 1886
	[Token(Token = "0x200075E")]
	public class NS_MGuest_PlayCustomDialog : PlayableAsset
	{
		// Token: 0x06002C06 RID: 11270 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		[Token(Token = "0x6002C06")]
		[Address(RVA = "0x5E1D30", Offset = "0x5E0730", VA = "0x1805E1D30", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C07")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public NS_MGuest_PlayCustomDialog()
		{
		}

		// Token: 0x04002846 RID: 10310
		[Token(Token = "0x4002846")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x04002847 RID: 10311
		[Token(Token = "0x4002847")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		// Token: 0x04002848 RID: 10312
		[Token(Token = "0x4002848")]
		[FieldOffset(Offset = "0x28")]
		public float displayDuration;

		// Token: 0x04002849 RID: 10313
		[Token(Token = "0x4002849")]
		[FieldOffset(Offset = "0x2C")]
		public bool shouldWaitForFinish;
	}
}
