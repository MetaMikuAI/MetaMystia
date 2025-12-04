using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FC2 RID: 4034
	[Token(Token = "0x2000FC2")]
	public class COM_ACharacter_SpawnOrSetWorldPos : PlayableAsset
	{
		// Token: 0x06005E99 RID: 24217 RVA: 0x00020B68 File Offset: 0x0001ED68
		[Token(Token = "0x6005E99")]
		[Address(RVA = "0x8BD310", Offset = "0x8BBD10", VA = "0x1808BD310", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005E9A RID: 24218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E9A")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_ACharacter_SpawnOrSetWorldPos()
		{
		}

		// Token: 0x04005795 RID: 22421
		[Token(Token = "0x4005795")]
		[FieldOffset(Offset = "0x18")]
		public SceneDirector.Identity characterType;

		// Token: 0x04005796 RID: 22422
		[Token(Token = "0x4005796")]
		[FieldOffset(Offset = "0x1C")]
		public int characterId;

		// Token: 0x04005797 RID: 22423
		[Token(Token = "0x4005797")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 startPosition;

		// Token: 0x04005798 RID: 22424
		[Token(Token = "0x4005798")]
		[FieldOffset(Offset = "0x28")]
		public string identifierLabel;

		// Token: 0x04005799 RID: 22425
		[Token(Token = "0x4005799")]
		[FieldOffset(Offset = "0x30")]
		public bool usePosition;

		// Token: 0x0400579A RID: 22426
		[Token(Token = "0x400579A")]
		[FieldOffset(Offset = "0x38")]
		public string positionLabel;
	}
}
