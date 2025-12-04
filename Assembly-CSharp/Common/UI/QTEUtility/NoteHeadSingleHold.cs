using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace Common.UI.QTEUtility
{
	// Token: 0x02000E91 RID: 3729
	[Token(Token = "0x2000E91")]
	[GenerateCleanupMethod]
	public class NoteHeadSingleHold : NoteHeadSingle
	{
		// Token: 0x0600576C RID: 22380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600576C")]
		[Address(RVA = "0x857050", Offset = "0x855A50", VA = "0x180857050", Slot = "20")]
		protected override void OnStatusChangedToPostPerfect()
		{
		}

		// Token: 0x0600576D RID: 22381 RVA: 0x0001ECF0 File Offset: 0x0001CEF0
		[Token(Token = "0x600576D")]
		[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "25")]
		protected override bool GoodFix()
		{
			return default(bool);
		}

		// Token: 0x0600576E RID: 22382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600576E")]
		[Address(RVA = "0x857040", Offset = "0x855A40", VA = "0x180857040", Slot = "24")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600576F RID: 22383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600576F")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		public NoteHeadSingleHold()
		{
		}
	}
}
