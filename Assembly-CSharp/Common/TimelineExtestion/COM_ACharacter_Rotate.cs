using System;
using DayScene.Input;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FBB RID: 4027
	[Token(Token = "0x2000FBB")]
	public class COM_ACharacter_Rotate : PlayableAsset
	{
		// Token: 0x06005E8B RID: 24203 RVA: 0x00020AC0 File Offset: 0x0001ECC0
		[Token(Token = "0x6005E8B")]
		[Address(RVA = "0x8BC050", Offset = "0x8BAA50", VA = "0x1808BC050", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005E8C RID: 24204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E8C")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_ACharacter_Rotate()
		{
		}

		// Token: 0x04005786 RID: 22406
		[Token(Token = "0x4005786")]
		[FieldOffset(Offset = "0x18")]
		public string label;

		// Token: 0x04005787 RID: 22407
		[Token(Token = "0x4005787")]
		[FieldOffset(Offset = "0x20")]
		public DayScenePlayerInputGenerator.CharacterRotation targetRotation;
	}
}
