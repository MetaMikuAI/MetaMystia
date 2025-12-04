using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000FE8 RID: 4072
	[Token(Token = "0x2000FE8")]
	public class COM_WorldOverlay_Set : PlayableAsset
	{
		// Token: 0x06005EE5 RID: 24293 RVA: 0x00020EF8 File Offset: 0x0001F0F8
		[Token(Token = "0x6005EE5")]
		[Address(RVA = "0x8C22E0", Offset = "0x8C0CE0", VA = "0x1808C22E0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005EE6 RID: 24294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005EE6")]
		[Address(RVA = "0x8C2600", Offset = "0x8C1000", VA = "0x1808C2600")]
		public COM_WorldOverlay_Set()
		{
		}

		// Token: 0x040057D6 RID: 22486
		[Token(Token = "0x40057D6")]
		[FieldOffset(Offset = "0x18")]
		public GameObject spriteGameObject;

		// Token: 0x040057D7 RID: 22487
		[Token(Token = "0x40057D7")]
		[FieldOffset(Offset = "0x20")]
		public GameObject spriteGameObjectEN;

		// Token: 0x040057D8 RID: 22488
		[Token(Token = "0x40057D8")]
		[FieldOffset(Offset = "0x28")]
		public GameObject spriteGameObjectJP;

		// Token: 0x040057D9 RID: 22489
		[Token(Token = "0x40057D9")]
		[FieldOffset(Offset = "0x30")]
		public GameObject spriteGameObjectKO;

		// Token: 0x040057DA RID: 22490
		[Token(Token = "0x40057DA")]
		[FieldOffset(Offset = "0x38")]
		public GameObject spriteGameObjectCNT;

		// Token: 0x040057DB RID: 22491
		[Token(Token = "0x40057DB")]
		[FieldOffset(Offset = "0x40")]
		public bool characterMode;

		// Token: 0x040057DC RID: 22492
		[Token(Token = "0x40057DC")]
		[FieldOffset(Offset = "0x48")]
		public string characterLabel;

		// Token: 0x040057DD RID: 22493
		[Token(Token = "0x40057DD")]
		[FieldOffset(Offset = "0x50")]
		public Vector2 worldPosition;

		// Token: 0x040057DE RID: 22494
		[Token(Token = "0x40057DE")]
		[FieldOffset(Offset = "0x58")]
		public string label;

		// Token: 0x040057DF RID: 22495
		[Token(Token = "0x40057DF")]
		[FieldOffset(Offset = "0x60")]
		public float transitionDuration;

		// Token: 0x040057E0 RID: 22496
		[Token(Token = "0x40057E0")]
		[FieldOffset(Offset = "0x64")]
		public bool uiMode;

		// Token: 0x040057E1 RID: 22497
		[Token(Token = "0x40057E1")]
		[FieldOffset(Offset = "0x65")]
		public bool tutorialMode;
	}
}
