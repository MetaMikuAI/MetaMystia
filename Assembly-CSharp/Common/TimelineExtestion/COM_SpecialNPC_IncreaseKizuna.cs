using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FDF RID: 4063
	[Token(Token = "0x2000FDF")]
	public class COM_SpecialNPC_IncreaseKizuna : PlayableAsset
	{
		// Token: 0x06005ED3 RID: 24275 RVA: 0x00020E20 File Offset: 0x0001F020
		[Token(Token = "0x6005ED3")]
		[Address(RVA = "0x8C1430", Offset = "0x8BFE30", VA = "0x1808C1430", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005ED4 RID: 24276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ED4")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_SpecialNPC_IncreaseKizuna()
		{
		}

		// Token: 0x040057C8 RID: 22472
		[Token(Token = "0x40057C8")]
		[FieldOffset(Offset = "0x18")]
		public string targetCharacterLabel;

		// Token: 0x040057C9 RID: 22473
		[Token(Token = "0x40057C9")]
		[FieldOffset(Offset = "0x20")]
		public int kizunaAmount;
	}
}
