using System;
using DayScene.Input;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FC3 RID: 4035
	[Token(Token = "0x2000FC3")]
	public class COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc : PlayableAsset
	{
		// Token: 0x06005E9B RID: 24219 RVA: 0x00020B80 File Offset: 0x0001ED80
		[Token(Token = "0x6005E9B")]
		[Address(RVA = "0x8BD1C0", Offset = "0x8BBBC0", VA = "0x1808BD1C0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005E9C RID: 24220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E9C")]
		[Address(RVA = "0x8BD2F0", Offset = "0x8BBCF0", VA = "0x1808BD2F0")]
		public COM_ACharacter_SpawnOrSetWorldPosOppositeToNpc()
		{
		}

		// Token: 0x0400579B RID: 22427
		[Token(Token = "0x400579B")]
		[FieldOffset(Offset = "0x18")]
		public SceneDirector.Identity characterType;

		// Token: 0x0400579C RID: 22428
		[Token(Token = "0x400579C")]
		[FieldOffset(Offset = "0x1C")]
		public int characterId;

		// Token: 0x0400579D RID: 22429
		[Token(Token = "0x400579D")]
		[FieldOffset(Offset = "0x20")]
		public string targetCharacterStringKey;

		// Token: 0x0400579E RID: 22430
		[Token(Token = "0x400579E")]
		[FieldOffset(Offset = "0x28")]
		public DayScenePlayerInputGenerator.CharacterRotation targetCharacterOverrideRotation;

		// Token: 0x0400579F RID: 22431
		[Token(Token = "0x400579F")]
		[FieldOffset(Offset = "0x2C")]
		public float distance;

		// Token: 0x040057A0 RID: 22432
		[Token(Token = "0x40057A0")]
		[FieldOffset(Offset = "0x30")]
		public string identifierLabel;
	}
}
