using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI
{
	// Token: 0x02000E1F RID: 3615
	[Token(Token = "0x2000E1F")]
	[GenerateCleanupMethod]
	public class ClockController : MonoBehaviour
	{
		// Token: 0x17000BF1 RID: 3057
		// (set) Token: 0x06005485 RID: 21637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BF1")]
		[CleanupIgnore]
		private Sprite Needle
		{
			[Token(Token = "0x6005485")]
			[Address(RVA = "0x833430", Offset = "0x831E30", VA = "0x180833430")]
			set
			{
			}
		}

		// Token: 0x06005486 RID: 21638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005486")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005487 RID: 21639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005487")]
		[Address(RVA = "0x832EB0", Offset = "0x8318B0", VA = "0x180832EB0")]
		public void Initialize(byte startClock, byte finishClock)
		{
		}

		// Token: 0x06005488 RID: 21640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005488")]
		[Address(RVA = "0x832FB0", Offset = "0x8319B0", VA = "0x180832FB0")]
		private void SetNeedle(byte clockCode)
		{
		}

		// Token: 0x06005489 RID: 21641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005489")]
		[Address(RVA = "0x8331D0", Offset = "0x831BD0", VA = "0x1808331D0")]
		public void SetProgress(float progress)
		{
		}

		// Token: 0x0600548A RID: 21642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600548A")]
		[Address(RVA = "0x832D90", Offset = "0x831790", VA = "0x180832D90", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x0600548B RID: 21643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600548B")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public ClockController()
		{
		}

		// Token: 0x04004F7A RID: 20346
		[Token(Token = "0x4004F7A")]
		[FieldOffset(Offset = "0x18")]
		public Sprite xii;

		// Token: 0x04004F7B RID: 20347
		[Token(Token = "0x4004F7B")]
		[FieldOffset(Offset = "0x20")]
		public Sprite i;

		// Token: 0x04004F7C RID: 20348
		[Token(Token = "0x4004F7C")]
		[FieldOffset(Offset = "0x28")]
		public Sprite ii;

		// Token: 0x04004F7D RID: 20349
		[Token(Token = "0x4004F7D")]
		[FieldOffset(Offset = "0x30")]
		public Sprite iii;

		// Token: 0x04004F7E RID: 20350
		[Token(Token = "0x4004F7E")]
		[FieldOffset(Offset = "0x38")]
		public Sprite iv;

		// Token: 0x04004F7F RID: 20351
		[Token(Token = "0x4004F7F")]
		[FieldOffset(Offset = "0x40")]
		public Sprite v;

		// Token: 0x04004F80 RID: 20352
		[Token(Token = "0x4004F80")]
		[FieldOffset(Offset = "0x48")]
		public Sprite vi;

		// Token: 0x04004F81 RID: 20353
		[Token(Token = "0x4004F81")]
		[FieldOffset(Offset = "0x50")]
		public Sprite vii;

		// Token: 0x04004F82 RID: 20354
		[Token(Token = "0x4004F82")]
		[FieldOffset(Offset = "0x58")]
		public Sprite viii;

		// Token: 0x04004F83 RID: 20355
		[Token(Token = "0x4004F83")]
		[FieldOffset(Offset = "0x60")]
		public Sprite ix;

		// Token: 0x04004F84 RID: 20356
		[Token(Token = "0x4004F84")]
		[FieldOffset(Offset = "0x68")]
		public Sprite x;

		// Token: 0x04004F85 RID: 20357
		[Token(Token = "0x4004F85")]
		[FieldOffset(Offset = "0x70")]
		public Sprite xi;

		// Token: 0x04004F86 RID: 20358
		[Token(Token = "0x4004F86")]
		[FieldOffset(Offset = "0x78")]
		public Image timeInterval;

		// Token: 0x04004F87 RID: 20359
		[Token(Token = "0x4004F87")]
		[FieldOffset(Offset = "0x80")]
		public Image minuteInterval;

		// Token: 0x04004F88 RID: 20360
		[Token(Token = "0x4004F88")]
		[FieldOffset(Offset = "0x88")]
		public Image needle;

		// Token: 0x04004F89 RID: 20361
		[Token(Token = "0x4004F89")]
		[FieldOffset(Offset = "0x90")]
		public AudioClip timeSFX;

		// Token: 0x04004F8A RID: 20362
		[Token(Token = "0x4004F8A")]
		[FieldOffset(Offset = "0x98")]
		private byte currentClock;

		// Token: 0x04004F8B RID: 20363
		[Token(Token = "0x4004F8B")]
		[FieldOffset(Offset = "0x99")]
		private byte startClock;

		// Token: 0x04004F8C RID: 20364
		[Token(Token = "0x4004F8C")]
		[FieldOffset(Offset = "0x9A")]
		private byte finishClock;
	}
}
