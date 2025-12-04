using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FC8 RID: 4040
	[Token(Token = "0x2000FC8")]
	public class COM_AFadeInFadeOut : PlayableAsset
	{
		// Token: 0x06005EA5 RID: 24229 RVA: 0x00020BF8 File Offset: 0x0001EDF8
		[Token(Token = "0x6005EA5")]
		[Address(RVA = "0x8BDF40", Offset = "0x8BC940", VA = "0x1808BDF40", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EA6 RID: 24230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EA6")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_AFadeInFadeOut()
		{
		}

		// Token: 0x040057A6 RID: 22438
		[Token(Token = "0x40057A6")]
		[FieldOffset(Offset = "0x18")]
		public COM_AFadeInFadeOut_Behaviour.Type transitionType;

		// Token: 0x040057A7 RID: 22439
		[Token(Token = "0x40057A7")]
		[FieldOffset(Offset = "0x1C")]
		public bool notWait;
	}
}
