using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.QTEUtility
{
	// Token: 0x02000E8E RID: 3726
	[Token(Token = "0x2000E8E")]
	[GenerateCleanupMethod]
	public class NoteHeadHoldStart : NoteHeadBase
	{
		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x06005752 RID: 22354 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005753 RID: 22355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C32")]
		public NoteHeadHoldEnd EndNote
		{
			[Token(Token = "0x6005752")]
			[Address(RVA = "0x45A7E0", Offset = "0x4591E0", VA = "0x18045A7E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005753")]
			[Address(RVA = "0x45ABC0", Offset = "0x4595C0", VA = "0x18045ABC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005754 RID: 22356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005754")]
		[Address(RVA = "0x856C70", Offset = "0x855670", VA = "0x180856C70", Slot = "22")]
		protected override void OnClick()
		{
		}

		// Token: 0x06005755 RID: 22357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005755")]
		[Address(RVA = "0x8561C0", Offset = "0x854BC0", VA = "0x1808561C0", Slot = "19")]
		protected override void OnDemoModeStatusChangeToPostPerfect()
		{
		}

		// Token: 0x06005756 RID: 22358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005756")]
		[Address(RVA = "0x856FB0", Offset = "0x8559B0", VA = "0x180856FB0", Slot = "21")]
		public override void OnRemove()
		{
		}

		// Token: 0x06005757 RID: 22359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005757")]
		[Address(RVA = "0x856F00", Offset = "0x855900", VA = "0x180856F00", Slot = "23")]
		protected override void OnRelease()
		{
		}

		// Token: 0x06005758 RID: 22360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005758")]
		[Address(RVA = "0x856B60", Offset = "0x855560", VA = "0x180856B60")]
		public void Evaluate([Optional] NoteHeadBase.NoteStatus? overrideValue)
		{
		}

		// Token: 0x06005759 RID: 22361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005759")]
		[Address(RVA = "0x856BF0", Offset = "0x8555F0", VA = "0x180856BF0", Slot = "17")]
		public override IEnumerable<Image> InitForVisualOnlyElements()
		{
			return null;
		}

		// Token: 0x0600575A RID: 22362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575A")]
		[Address(RVA = "0x856CC0", Offset = "0x8556C0", VA = "0x180856CC0", Slot = "18")]
		public override void OnNotePositionUpdate()
		{
		}

		// Token: 0x0600575B RID: 22363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575B")]
		[Address(RVA = "0x856B10", Offset = "0x855510", VA = "0x180856B10", Slot = "24")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600575C RID: 22364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600575C")]
		[Address(RVA = "0x856FE0", Offset = "0x8559E0", VA = "0x180856FE0")]
		public NoteHeadHoldStart()
		{
		}

		// Token: 0x040051D5 RID: 20949
		[Token(Token = "0x40051D5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public RectTransform NoteHeadHoldLerp;

		// Token: 0x040051D6 RID: 20950
		[Token(Token = "0x40051D6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Vector3[] m_CornerBuffer;

		// Token: 0x040051D7 RID: 20951
		[Token(Token = "0x40051D7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private NoteHeadBase.NoteStatus m_OnClickStatus;
	}
}
