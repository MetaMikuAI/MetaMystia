using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FBD RID: 4029
	[Token(Token = "0x2000FBD")]
	public class COM_ACharacter_SetClothes : PlayableAsset
	{
		// Token: 0x06005E8F RID: 24207 RVA: 0x00020AF0 File Offset: 0x0001ECF0
		[Token(Token = "0x6005E8F")]
		[Address(RVA = "0x8BC500", Offset = "0x8BAF00", VA = "0x1808BC500", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005E90 RID: 24208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E90")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_ACharacter_SetClothes()
		{
		}

		// Token: 0x0400578B RID: 22411
		[Token(Token = "0x400578B")]
		[FieldOffset(Offset = "0x18")]
		public int clothesId;
	}
}
