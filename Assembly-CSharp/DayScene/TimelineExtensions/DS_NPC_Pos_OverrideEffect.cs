using System;
using DayScene.Input;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x020004A8 RID: 1192
	[Token(Token = "0x20004A8")]
	public class DS_NPC_Pos_OverrideEffect : PlayableAsset
	{
		// Token: 0x06001B2A RID: 6954 RVA: 0x0000A830 File Offset: 0x00008A30
		[Token(Token = "0x6001B2A")]
		[Address(RVA = "0x4991F0", Offset = "0x497BF0", VA = "0x1804991F0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06001B2B RID: 6955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B2B")]
		[Address(RVA = "0x499450", Offset = "0x497E50", VA = "0x180499450")]
		public DS_NPC_Pos_OverrideEffect()
		{
		}

		// Token: 0x040018ED RID: 6381
		[Token(Token = "0x40018ED")]
		[FieldOffset(Offset = "0x18")]
		public string characterLabel;

		// Token: 0x040018EE RID: 6382
		[Token(Token = "0x40018EE")]
		[FieldOffset(Offset = "0x20")]
		public string mapLabel;

		// Token: 0x040018EF RID: 6383
		[Token(Token = "0x40018EF")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 position;

		// Token: 0x040018F0 RID: 6384
		[Token(Token = "0x40018F0")]
		[FieldOffset(Offset = "0x30")]
		public DayScenePlayerInputGenerator.CharacterRotation rotation;

		// Token: 0x040018F1 RID: 6385
		[Token(Token = "0x40018F1")]
		[FieldOffset(Offset = "0x34")]
		[Header("[Effect]")]
		public float characterSetDelay;

		// Token: 0x040018F2 RID: 6386
		[Token(Token = "0x40018F2")]
		[FieldOffset(Offset = "0x38")]
		public bool shouldWaitForFinish;

		// Token: 0x040018F3 RID: 6387
		[Token(Token = "0x40018F3")]
		[FieldOffset(Offset = "0x40")]
		public string effectLabel;

		// Token: 0x040018F4 RID: 6388
		[Token(Token = "0x40018F4")]
		[FieldOffset(Offset = "0x48")]
		public GameObject effectPrefab;

		// Token: 0x040018F5 RID: 6389
		[Token(Token = "0x40018F5")]
		[FieldOffset(Offset = "0x50")]
		public Vector2 effectPositionOffset;

		// Token: 0x040018F6 RID: 6390
		[Token(Token = "0x40018F6")]
		[FieldOffset(Offset = "0x58")]
		public float effectDestroyDelay;

		// Token: 0x040018F7 RID: 6391
		[Token(Token = "0x40018F7")]
		[FieldOffset(Offset = "0x5C")]
		public float effectTransitionDuration;
	}
}
