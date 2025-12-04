using System;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.QTEUtility
{
	// Token: 0x02000E83 RID: 3715
	[Token(Token = "0x2000E83")]
	[GenerateCleanupMethod]
	public class NoteAnimationControllerAdvanced : NoteAnimationControllerBase
	{
		// Token: 0x060056FF RID: 22271 RVA: 0x0001EBB8 File Offset: 0x0001CDB8
		[Token(Token = "0x60056FF")]
		[Address(RVA = "0x8553D0", Offset = "0x853DD0", VA = "0x1808553D0")]
		private Color32 GetColor(Color32 bothSideColor, Color32 leftColor, Color32 rightColor)
		{
			return default(Color32);
		}

		// Token: 0x06005700 RID: 22272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005700")]
		[Address(RVA = "0x855420", Offset = "0x853E20", VA = "0x180855420", Slot = "5")]
		public override void OnNoteChangeToGood()
		{
		}

		// Token: 0x06005701 RID: 22273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005701")]
		[Address(RVA = "0x855540", Offset = "0x853F40", VA = "0x180855540", Slot = "4")]
		public override void OnNoteChangeToMiss()
		{
		}

		// Token: 0x06005702 RID: 22274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005702")]
		[Address(RVA = "0x855AC0", Offset = "0x8544C0", VA = "0x180855AC0", Slot = "6")]
		public override void OnNoteChangeToPerfect()
		{
		}

		// Token: 0x06005703 RID: 22275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005703")]
		[Address(RVA = "0x855360", Offset = "0x853D60", VA = "0x180855360", Slot = "7")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005704 RID: 22276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005704")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public NoteAnimationControllerAdvanced()
		{
		}

		// Token: 0x04005199 RID: 20889
		[Token(Token = "0x4005199")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string s_SharedGoodOutlineColorHEX;

		// Token: 0x0400519A RID: 20890
		[Token(Token = "0x400519A")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string s_SharedPerfectOutlineColorHEX;

		// Token: 0x0400519B RID: 20891
		[Token(Token = "0x400519B")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string s_PerfectColorHEX;

		// Token: 0x0400519C RID: 20892
		[Token(Token = "0x400519C")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string s_PerfectColorInlineHEX;

		// Token: 0x0400519D RID: 20893
		[Token(Token = "0x400519D")]
		[FieldOffset(Offset = "0x20")]
		private static readonly string s_PerfectColorLeftHEX;

		// Token: 0x0400519E RID: 20894
		[Token(Token = "0x400519E")]
		[FieldOffset(Offset = "0x28")]
		private static readonly string s_PerfectColorInlineLeftHEX;

		// Token: 0x0400519F RID: 20895
		[Token(Token = "0x400519F")]
		[FieldOffset(Offset = "0x30")]
		private static readonly string s_PerfectColorRightHEX;

		// Token: 0x040051A0 RID: 20896
		[Token(Token = "0x40051A0")]
		[FieldOffset(Offset = "0x38")]
		private static readonly string s_PerfectColorInlineRightHEX;

		// Token: 0x040051A1 RID: 20897
		[Token(Token = "0x40051A1")]
		[FieldOffset(Offset = "0x40")]
		private static readonly string s_CatchColorHEX;

		// Token: 0x040051A2 RID: 20898
		[Token(Token = "0x40051A2")]
		[FieldOffset(Offset = "0x48")]
		private static readonly Color32 SHARED_GOOD_OUTLINE_COLOR;

		// Token: 0x040051A3 RID: 20899
		[Token(Token = "0x40051A3")]
		[FieldOffset(Offset = "0x4C")]
		private static readonly Color32 SHARED_PERFECT_OUTLINE_COLOR;

		// Token: 0x040051A4 RID: 20900
		[Token(Token = "0x40051A4")]
		[FieldOffset(Offset = "0x50")]
		private static readonly Color32 PERFECT_COLOR;

		// Token: 0x040051A5 RID: 20901
		[Token(Token = "0x40051A5")]
		[FieldOffset(Offset = "0x54")]
		private static readonly Color32 PERFECT_COLOR_INLINE;

		// Token: 0x040051A6 RID: 20902
		[Token(Token = "0x40051A6")]
		[FieldOffset(Offset = "0x58")]
		private static readonly Color32 PERFECT_COLOR_LEFT;

		// Token: 0x040051A7 RID: 20903
		[Token(Token = "0x40051A7")]
		[FieldOffset(Offset = "0x5C")]
		private static readonly Color32 PERFECT_COLOR_INLINE_LEFT;

		// Token: 0x040051A8 RID: 20904
		[Token(Token = "0x40051A8")]
		[FieldOffset(Offset = "0x60")]
		private static readonly Color32 PERFECT_COLOR_RIGHT;

		// Token: 0x040051A9 RID: 20905
		[Token(Token = "0x40051A9")]
		[FieldOffset(Offset = "0x64")]
		private static readonly Color32 PERFECT_COLOR_INLINE_RIGHT;

		// Token: 0x040051AA RID: 20906
		[Token(Token = "0x40051AA")]
		[FieldOffset(Offset = "0x68")]
		private static readonly Color32 CATCH_COLOR;

		// Token: 0x040051AB RID: 20907
		[Token(Token = "0x40051AB")]
		[FieldOffset(Offset = "0x38")]
		public Image[] NoteImage;

		// Token: 0x040051AC RID: 20908
		[Token(Token = "0x40051AC")]
		[FieldOffset(Offset = "0x40")]
		public Image[] OutlineImage;

		// Token: 0x040051AD RID: 20909
		[Token(Token = "0x40051AD")]
		[FieldOffset(Offset = "0x48")]
		public Image[] InlineImage;

		// Token: 0x040051AE RID: 20910
		[Token(Token = "0x40051AE")]
		[FieldOffset(Offset = "0x50")]
		public Image DirectionIndicatorLeft;

		// Token: 0x040051AF RID: 20911
		[Token(Token = "0x40051AF")]
		[FieldOffset(Offset = "0x58")]
		public Image DirectionIndicatorRight;
	}
}
