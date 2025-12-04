using System;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FC7 RID: 4039
	[Token(Token = "0x2000FC7")]
	public class COM_ADialog_Play : PlayableAsset
	{
		// Token: 0x06005EA3 RID: 24227 RVA: 0x00020BE0 File Offset: 0x0001EDE0
		[Token(Token = "0x6005EA3")]
		[Address(RVA = "0x8BDCB0", Offset = "0x8BC6B0", VA = "0x1808BDCB0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EA4 RID: 24228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EA4")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_ADialog_Play()
		{
		}

		// Token: 0x040057A4 RID: 22436
		[Token(Token = "0x40057A4")]
		[FieldOffset(Offset = "0x18")]
		public DialogPackage dialogPackage;

		// Token: 0x040057A5 RID: 22437
		[Token(Token = "0x40057A5")]
		[FieldOffset(Offset = "0x20")]
		public bool PreservePreviousPannelVisual;
	}
}
