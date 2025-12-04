using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameData.Core.MusicUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace Common.UI.QTEUtility
{
	// Token: 0x02000E88 RID: 3720
	[Token(Token = "0x2000E88")]
	[GenerateCleanupMethod]
	public abstract class NoteHeadBase : UIBehaviour
	{
		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x0600571A RID: 22298 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600571B RID: 22299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C27")]
		public RectTransform RectTransform
		{
			[Token(Token = "0x600571A")]
			[Address(RVA = "0x440270", Offset = "0x43EC70", VA = "0x180440270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600571B")]
			[Address(RVA = "0x51B160", Offset = "0x519B60", VA = "0x18051B160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x0600571C RID: 22300 RVA: 0x0001EC00 File Offset: 0x0001CE00
		// (set) Token: 0x0600571D RID: 22301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C28")]
		public IzakayaMusic.SingleNote NoteInfo
		{
			[Token(Token = "0x600571C")]
			[Address(RVA = "0x8565E0", Offset = "0x854FE0", VA = "0x1808565E0")]
			[CompilerGenerated]
			get
			{
				return default(IzakayaMusic.SingleNote);
			}
			[Token(Token = "0x600571D")]
			[Address(RVA = "0x8566B0", Offset = "0x8550B0", VA = "0x1808566B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x0600571E RID: 22302 RVA: 0x0001EC18 File Offset: 0x0001CE18
		// (set) Token: 0x0600571F RID: 22303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C29")]
		public NoteHeadBase.NoteStatus Status
		{
			[Token(Token = "0x600571E")]
			[Address(RVA = "0x51B080", Offset = "0x519A80", VA = "0x18051B080")]
			get
			{
				return NoteHeadBase.NoteStatus.Good;
			}
			[Token(Token = "0x600571F")]
			[Address(RVA = "0x8566D0", Offset = "0x8550D0", VA = "0x1808566D0")]
			set
			{
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x06005720 RID: 22304 RVA: 0x0001EC30 File Offset: 0x0001CE30
		[Token(Token = "0x17000C2A")]
		public IzakayaMusic.SingleNote.NoteType Type
		{
			[Token(Token = "0x6005720")]
			[Address(RVA = "0x856600", Offset = "0x855000", VA = "0x180856600")]
			get
			{
				return IzakayaMusic.SingleNote.NoteType.Single;
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06005721 RID: 22305 RVA: 0x0001EC48 File Offset: 0x0001CE48
		// (set) Token: 0x06005722 RID: 22306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C2B")]
		public bool IsUpdatingPosition
		{
			[Token(Token = "0x6005721")]
			[Address(RVA = "0x4E90C0", Offset = "0x4E7AC0", VA = "0x1804E90C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005722")]
			[Address(RVA = "0x4E9160", Offset = "0x4E7B60", VA = "0x1804E9160")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06005723 RID: 22307 RVA: 0x0001EC60 File Offset: 0x0001CE60
		// (set) Token: 0x06005724 RID: 22308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C2C")]
		public bool UnderEvaluation
		{
			[Token(Token = "0x6005723")]
			[Address(RVA = "0x4E90B0", Offset = "0x4E7AB0", VA = "0x1804E90B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005724")]
			[Address(RVA = "0x4E9150", Offset = "0x4E7B50", VA = "0x1804E9150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06005725 RID: 22309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C2D")]
		public Sprite Visual
		{
			[Token(Token = "0x6005725")]
			[Address(RVA = "0x856620", Offset = "0x855020", VA = "0x180856620")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06005726 RID: 22310 RVA: 0x0001EC78 File Offset: 0x0001CE78
		[Token(Token = "0x17000C2E")]
		protected bool IsFocusingInputEnabled
		{
			[Token(Token = "0x6005726")]
			[Address(RVA = "0x856590", Offset = "0x854F90", VA = "0x180856590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06005727 RID: 22311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005727")]
		[Address(RVA = "0x856360", Offset = "0x854D60", VA = "0x180856360", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06005728 RID: 22312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005728")]
		[Address(RVA = "0x856340", Offset = "0x854D40", VA = "0x180856340", Slot = "8")]
		protected sealed override void OnDestroy()
		{
		}

		// Token: 0x06005729 RID: 22313 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005729")]
		[Address(RVA = "0x856220", Offset = "0x854C20", VA = "0x180856220", Slot = "17")]
		public virtual IEnumerable<Image> InitForVisualOnlyElements()
		{
			return null;
		}

		// Token: 0x0600572A RID: 22314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600572A")]
		[Address(RVA = "0x8563E0", Offset = "0x854DE0", VA = "0x1808563E0")]
		protected void PlayCorrectAudio()
		{
		}

		// Token: 0x0600572B RID: 22315 RVA: 0x0001EC90 File Offset: 0x0001CE90
		[Token(Token = "0x600572B")]
		[Address(RVA = "0x8564E0", Offset = "0x854EE0", VA = "0x1808564E0")]
		protected Vector3 WorldToLocalPoint(Vector3 worldPoint)
		{
			return default(Vector3);
		}

		// Token: 0x0600572C RID: 22316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600572C")]
		[Address(RVA = "0x8561F0", Offset = "0x854BF0", VA = "0x1808561F0")]
		public void EvaluateNote()
		{
		}

		// Token: 0x0600572D RID: 22317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600572D")]
		[Address(RVA = "0x856420", Offset = "0x854E20", VA = "0x180856420")]
		public void ReleaseNote()
		{
		}

		// Token: 0x0600572E RID: 22318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600572E")]
		[Address(RVA = "0x856470", Offset = "0x854E70", VA = "0x180856470")]
		public void RemoveNote()
		{
		}

		// Token: 0x0600572F RID: 22319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600572F")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "18")]
		public virtual void OnNotePositionUpdate()
		{
		}

		// Token: 0x06005730 RID: 22320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005730")]
		[Address(RVA = "0x8562A0", Offset = "0x854CA0", VA = "0x1808562A0")]
		public void Initialize(IzakayaMusic.SingleNote noteInfo, QTEPannelBase controller, ObjectPool<NoteHeadBase> removeObjectHandle)
		{
		}

		// Token: 0x06005731 RID: 22321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005731")]
		[Address(RVA = "0x8561C0", Offset = "0x854BC0", VA = "0x1808561C0")]
		public void Click()
		{
		}

		// Token: 0x06005732 RID: 22322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005732")]
		[Address(RVA = "0x856450", Offset = "0x854E50", VA = "0x180856450")]
		public void Release()
		{
		}

		// Token: 0x06005733 RID: 22323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005733")]
		[Address(RVA = "0x8561E0", Offset = "0x854BE0", VA = "0x1808561E0")]
		protected void EnableUnderEvaluation()
		{
		}

		// Token: 0x06005734 RID: 22324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005734")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "19")]
		protected virtual void OnDemoModeStatusChangeToPostPerfect()
		{
		}

		// Token: 0x06005735 RID: 22325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005735")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "20")]
		protected virtual void OnStatusChangedToPostPerfect()
		{
		}

		// Token: 0x06005736 RID: 22326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005736")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "21")]
		public virtual void OnRemove()
		{
		}

		// Token: 0x06005737 RID: 22327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005737")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "22")]
		protected virtual void OnClick()
		{
		}

		// Token: 0x06005738 RID: 22328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005738")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "23")]
		protected virtual void OnRelease()
		{
		}

		// Token: 0x06005739 RID: 22329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005739")]
		[Address(RVA = "0x856140", Offset = "0x854B40", VA = "0x180856140", Slot = "24")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x0600573A RID: 22330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600573A")]
		[Address(RVA = "0x40B840", Offset = "0x40A240", VA = "0x18040B840")]
		protected NoteHeadBase()
		{
		}

		// Token: 0x040051B9 RID: 20921
		[Token(Token = "0x40051B9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image m_Visual;

		// Token: 0x040051BA RID: 20922
		[Token(Token = "0x40051BA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite m_OverrideAnimationSprite;

		// Token: 0x040051BB RID: 20923
		[Token(Token = "0x40051BB")]
		[FieldOffset(Offset = "0x28")]
		private NoteAnimationControllerBase m_Animation;

		// Token: 0x040051BC RID: 20924
		[Token(Token = "0x40051BC")]
		[FieldOffset(Offset = "0x30")]
		private QTEPannelBase m_Controller;

		// Token: 0x040051BD RID: 20925
		[Token(Token = "0x40051BD")]
		[FieldOffset(Offset = "0x38")]
		private bool m_HasPressed;

		// Token: 0x040051BE RID: 20926
		[Token(Token = "0x40051BE")]
		[FieldOffset(Offset = "0x39")]
		private bool m_HasRemoved;

		// Token: 0x040051BF RID: 20927
		[Token(Token = "0x40051BF")]
		[FieldOffset(Offset = "0x40")]
		private ObjectPool<NoteHeadBase> m_RemoveObjectHandle;

		// Token: 0x040051C0 RID: 20928
		[Token(Token = "0x40051C0")]
		[FieldOffset(Offset = "0x48")]
		private NoteHeadBase.NoteStatus m_Status;

		// Token: 0x02000E89 RID: 3721
		[Token(Token = "0x2000E89")]
		public enum NoteStatus
		{
			// Token: 0x040051C6 RID: 20934
			[Token(Token = "0x40051C6")]
			Good,
			// Token: 0x040051C7 RID: 20935
			[Token(Token = "0x40051C7")]
			Perfect,
			// Token: 0x040051C8 RID: 20936
			[Token(Token = "0x40051C8")]
			Miss,
			// Token: 0x040051C9 RID: 20937
			[Token(Token = "0x40051C9")]
			PostPerfect
		}
	}
}
