using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x020004AA RID: 1194
	[Token(Token = "0x20004AA")]
	public class DS_NPC_Pos_ResetEffect : PlayableAsset
	{
		// Token: 0x06001B2E RID: 6958 RVA: 0x0000A860 File Offset: 0x00008A60
		[Token(Token = "0x6001B2E")]
		[Address(RVA = "0x499700", Offset = "0x498100", VA = "0x180499700", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06001B2F RID: 6959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B2F")]
		[Address(RVA = "0x4998C0", Offset = "0x4982C0", VA = "0x1804998C0")]
		public DS_NPC_Pos_ResetEffect()
		{
		}

		// Token: 0x040018F9 RID: 6393
		[Token(Token = "0x40018F9")]
		[FieldOffset(Offset = "0x18")]
		public string characterLabel;

		// Token: 0x040018FA RID: 6394
		[Token(Token = "0x40018FA")]
		[FieldOffset(Offset = "0x20")]
		[Header("[Effect]")]
		public float characterResetDelay;

		// Token: 0x040018FB RID: 6395
		[Token(Token = "0x40018FB")]
		[FieldOffset(Offset = "0x24")]
		public bool shouldWaitForFinish;

		// Token: 0x040018FC RID: 6396
		[Token(Token = "0x40018FC")]
		[FieldOffset(Offset = "0x28")]
		public string effectLabel;

		// Token: 0x040018FD RID: 6397
		[Token(Token = "0x40018FD")]
		[FieldOffset(Offset = "0x30")]
		public GameObject effectPrefab;

		// Token: 0x040018FE RID: 6398
		[Token(Token = "0x40018FE")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 effectPositionOffset;

		// Token: 0x040018FF RID: 6399
		[Token(Token = "0x40018FF")]
		[FieldOffset(Offset = "0x40")]
		public float effectDestroyDelay;

		// Token: 0x04001900 RID: 6400
		[Token(Token = "0x4001900")]
		[FieldOffset(Offset = "0x44")]
		public float effectTransitionDuration;
	}
}
