using System;
using Common.UI.QTEUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI.Story
{
	// Token: 0x02000F5C RID: 3932
	[Token(Token = "0x2000F5C")]
	[GenerateCleanupMethod]
	public class EventQTETutorialNotePannel : EventQTETutorialSubPannel
	{
		// Token: 0x06005C80 RID: 23680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C80")]
		[Address(RVA = "0x8AAE70", Offset = "0x8A9870", VA = "0x1808AAE70")]
		public void PlaySFX()
		{
		}

		// Token: 0x06005C81 RID: 23681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C81")]
		[Address(RVA = "0x8AAFF0", Offset = "0x8A99F0", VA = "0x1808AAFF0")]
		public void ToggleBtnVisual(EventQTETutorialNotePannel.ToggleType on)
		{
		}

		// Token: 0x06005C82 RID: 23682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C82")]
		[Address(RVA = "0x8AAED0", Offset = "0x8A98D0", VA = "0x1808AAED0")]
		public void PlaySingleNoteSucceedAnimation()
		{
		}

		// Token: 0x06005C83 RID: 23683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C83")]
		[Address(RVA = "0x8AAD50", Offset = "0x8A9750", VA = "0x1808AAD50")]
		public void PlayCatchNoteSucceedAnimation()
		{
		}

		// Token: 0x06005C84 RID: 23684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C84")]
		[Address(RVA = "0x417230", Offset = "0x415C30", VA = "0x180417230", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005C85 RID: 23685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005C85")]
		[Address(RVA = "0x8AB120", Offset = "0x8A9B20", VA = "0x1808AB120")]
		public EventQTETutorialNotePannel()
		{
		}

		// Token: 0x040055AE RID: 21934
		[Token(Token = "0x40055AE")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject m_InputHelperField;

		// Token: 0x040055AF RID: 21935
		[Token(Token = "0x40055AF")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Sprite m_InputHighlightVisual;

		// Token: 0x040055B0 RID: 21936
		[Token(Token = "0x40055B0")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioClip m_PerfectSFX;

		// Token: 0x040055B1 RID: 21937
		[Token(Token = "0x40055B1")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Sprite m_SingleNoteVisual;

		// Token: 0x040055B2 RID: 21938
		[Token(Token = "0x40055B2")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Sprite m_CatchNoteVisual;

		// Token: 0x040055B3 RID: 21939
		[Token(Token = "0x40055B3")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private NoteHeadFinishAnimationController m_NoteSucceedAnimation;

		// Token: 0x040055B4 RID: 21940
		[Token(Token = "0x40055B4")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private RectTransform m_NoteAnimationField;

		// Token: 0x040055B5 RID: 21941
		[Token(Token = "0x40055B5")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RectTransform m_NoteAnimationReferencePosition;

		// Token: 0x02000F5D RID: 3933
		[Token(Token = "0x2000F5D")]
		public enum ToggleType
		{
			// Token: 0x040055B7 RID: 21943
			[Token(Token = "0x40055B7")]
			ON,
			// Token: 0x040055B8 RID: 21944
			[Token(Token = "0x40055B8")]
			OFF
		}
	}
}
