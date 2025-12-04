using System;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FC5 RID: 4037
	[Token(Token = "0x2000FC5")]
	public class COM_ADialog_Manual_Init : PlayableAsset
	{
		// Token: 0x06005E9F RID: 24223 RVA: 0x00020BB0 File Offset: 0x0001EDB0
		[Token(Token = "0x6005E9F")]
		[Address(RVA = "0x8BD860", Offset = "0x8BC260", VA = "0x1808BD860", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EA0 RID: 24224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EA0")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_ADialog_Manual_Init()
		{
		}

		// Token: 0x040057A1 RID: 22433
		[Token(Token = "0x40057A1")]
		[FieldOffset(Offset = "0x18")]
		public DialogPackage dialogPackage;

		// Token: 0x040057A2 RID: 22434
		[Token(Token = "0x40057A2")]
		[FieldOffset(Offset = "0x20")]
		public bool shouldHaveBlackBackgroundInDefault;

		// Token: 0x040057A3 RID: 22435
		[Token(Token = "0x40057A3")]
		[FieldOffset(Offset = "0x21")]
		public bool PreservePreviousPannelVisual;
	}
}
