using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using GameData.Core.MusicUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI.QTEUtility
{
	// Token: 0x02000E92 RID: 3730
	[Token(Token = "0x2000E92")]
	[GenerateCleanupMethod]
	public class QTEPannel : QTEPannelBase
	{
		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06005771 RID: 22385 RVA: 0x0001ED08 File Offset: 0x0001CF08
		// (set) Token: 0x06005770 RID: 22384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C35")]
		public bool IsBreak
		{
			[Token(Token = "0x6005771")]
			[Address(RVA = "0x85A2B0", Offset = "0x858CB0", VA = "0x18085A2B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005770")]
			[Address(RVA = "0x85A370", Offset = "0x858D70", VA = "0x18085A370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06005772 RID: 22386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C36")]
		protected override RectTransform ActiveNoteField
		{
			[Token(Token = "0x6005772")]
			[Address(RVA = "0x5141C0", Offset = "0x512BC0", VA = "0x1805141C0", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400003D RID: 61
		// (add) Token: 0x06005773 RID: 22387 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005774 RID: 22388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400003D")]
		public event Action OnAllNotesFinishCallback
		{
			[Token(Token = "0x6005773")]
			[Address(RVA = "0x85A200", Offset = "0x858C00", VA = "0x18085A200")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6005774")]
			[Address(RVA = "0x85A2C0", Offset = "0x858CC0", VA = "0x18085A2C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06005775 RID: 22389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005775")]
		[Address(RVA = "0x857F00", Offset = "0x856900", VA = "0x180857F00")]
		public void BreakAndClose()
		{
		}

		// Token: 0x06005776 RID: 22390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005776")]
		[Address(RVA = "0x8590D0", Offset = "0x857AD0", VA = "0x1808590D0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06005777 RID: 22391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005777")]
		[Address(RVA = "0x859E80", Offset = "0x858880", VA = "0x180859E80")]
		private void ResetProgress()
		{
		}

		// Token: 0x06005778 RID: 22392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005778")]
		[Address(RVA = "0x859110", Offset = "0x857B10", VA = "0x180859110", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06005779 RID: 22393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005779")]
		[Address(RVA = "0x859010", Offset = "0x857A10", VA = "0x180859010", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x0600577A RID: 22394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600577A")]
		[Address(RVA = "0x8580C0", Offset = "0x856AC0", VA = "0x1808580C0")]
		private Queue<NoteHeadBase> GetAllVisualNotesQueue()
		{
			return null;
		}

		// Token: 0x0600577B RID: 22395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600577B")]
		[Address(RVA = "0x859FA0", Offset = "0x8589A0", VA = "0x180859FA0")]
		private void Update()
		{
		}

		// Token: 0x0600577C RID: 22396 RVA: 0x0001ED20 File Offset: 0x0001CF20
		[Token(Token = "0x600577C")]
		[Address(RVA = "0x859EF0", Offset = "0x8588F0", VA = "0x180859EF0")]
		private UniTaskVoid RunNoteUpdate(CancellationToken token)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x0600577D RID: 22397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600577D")]
		[Address(RVA = "0x858A30", Offset = "0x857430", VA = "0x180858A30")]
		private void MoveSleepingNotesToUpdatingNotes(long noteStartUpdateTime, Queue<IzakayaMusic.SingleNote> willSpawnNotes)
		{
		}

		// Token: 0x0600577E RID: 22398 RVA: 0x0001ED38 File Offset: 0x0001CF38
		[Token(Token = "0x600577E")]
		[Address(RVA = "0x858720", Offset = "0x857120", VA = "0x180858720", Slot = "34")]
		protected override int GetNoteCount()
		{
			return 0;
		}

		// Token: 0x0600577F RID: 22399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600577F")]
		[Address(RVA = "0x857F80", Offset = "0x856980", VA = "0x180857F80", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005780 RID: 22400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005780")]
		[Address(RVA = "0x85A0A0", Offset = "0x858AA0", VA = "0x18085A0A0")]
		public QTEPannel()
		{
		}

		// Token: 0x040051DE RID: 20958
		[Token(Token = "0x40051DE")]
		private const float NOTE_VERTICAL_OFFSET = 12f;

		// Token: 0x040051DF RID: 20959
		[Token(Token = "0x40051DF")]
		[FieldOffset(Offset = "0x2B8")]
		[SerializeField]
		private RectTransform m_NoteFieldUp;

		// Token: 0x040051E0 RID: 20960
		[Token(Token = "0x40051E0")]
		[FieldOffset(Offset = "0x2C0")]
		[SerializeField]
		private RectTransform m_NoteFieldDown;

		// Token: 0x040051E1 RID: 20961
		[Token(Token = "0x40051E1")]
		[FieldOffset(Offset = "0x2C8")]
		[SerializeField]
		private GameObject m_AutoIndicator;

		// Token: 0x040051E2 RID: 20962
		[Token(Token = "0x40051E2")]
		[FieldOffset(Offset = "0x2D0")]
		private readonly Queue<long> m_Beats;

		// Token: 0x040051E3 RID: 20963
		[Token(Token = "0x40051E3")]
		[FieldOffset(Offset = "0x2D8")]
		private readonly Queue<IzakayaMusic.SingleNote> m_SleepingNotes;

		// Token: 0x040051E4 RID: 20964
		[Token(Token = "0x40051E4")]
		[FieldOffset(Offset = "0x2E0")]
		private RectTransform m_ActiveNoteTransform;

		// Token: 0x040051E5 RID: 20965
		[Token(Token = "0x40051E5")]
		[FieldOffset(Offset = "0x2E8")]
		private bool m_NoteBeatCalledThisFrame;

		// Token: 0x040051E6 RID: 20966
		[Token(Token = "0x40051E6")]
		[FieldOffset(Offset = "0x2EC")]
		private float m_NoteFieldWidth;

		// Token: 0x040051E7 RID: 20967
		[Token(Token = "0x40051E7")]
		[FieldOffset(Offset = "0x2F0")]
		private Action m_OnNoteBeatCallback;

		// Token: 0x040051E8 RID: 20968
		[Token(Token = "0x40051E8")]
		[FieldOffset(Offset = "0x2F8")]
		private CancellationTokenSource _tokenSource;

		// Token: 0x040051EA RID: 20970
		[Token(Token = "0x40051EA")]
		[FieldOffset(Offset = "0x301")]
		private bool _shouldRunExtraUpdate;

		// Token: 0x040051EC RID: 20972
		[Token(Token = "0x40051EC")]
		[FieldOffset(Offset = "0x310")]
		private readonly Queue<NoteHeadBase> _collection;

		// Token: 0x02000E93 RID: 3731
		[Token(Token = "0x2000E93")]
		public readonly struct PannelOpenContext
		{
			// Token: 0x06005781 RID: 22401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005781")]
			[Address(RVA = "0x873570", Offset = "0x871F70", VA = "0x180873570")]
			public PannelOpenContext(IzakayaMusic.SingleNote[] noteToProcess, Func<long> getCurrentTimeCallback, bool workMode, long[] noteBeat, Action onNoteBeat, Action<int> onComboUpdateInParent, Action<float> onScoreUpdate, float musicalNoteSpeed, bool autoPlayMode, float midiBarLengthMultiplier, long startQTEMilliseconds, long endQTEMilliseconds, long musicSwitchLengthMilliseconds, Action<long> onSingleNoteProcess)
			{
			}

			// Token: 0x06005782 RID: 22402 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6005782")]
			[Address(RVA = "0x8732A0", Offset = "0x871CA0", VA = "0x1808732A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			// Token: 0x040051ED RID: 20973
			[Token(Token = "0x40051ED")]
			[FieldOffset(Offset = "0x0")]
			public readonly IzakayaMusic.SingleNote[] NoteToProcess;

			// Token: 0x040051EE RID: 20974
			[Token(Token = "0x40051EE")]
			[FieldOffset(Offset = "0x8")]
			public readonly Func<long> GetCurrentTimeCallback;

			// Token: 0x040051EF RID: 20975
			[Token(Token = "0x40051EF")]
			[FieldOffset(Offset = "0x10")]
			public readonly bool WorkMode;

			// Token: 0x040051F0 RID: 20976
			[Token(Token = "0x40051F0")]
			[FieldOffset(Offset = "0x18")]
			public readonly long[] NoteBeat;

			// Token: 0x040051F1 RID: 20977
			[Token(Token = "0x40051F1")]
			[FieldOffset(Offset = "0x20")]
			public readonly Action OnNoteBeat;

			// Token: 0x040051F2 RID: 20978
			[Token(Token = "0x40051F2")]
			[FieldOffset(Offset = "0x28")]
			public readonly Action<int> OnComboUpdateInParent;

			// Token: 0x040051F3 RID: 20979
			[Token(Token = "0x40051F3")]
			[FieldOffset(Offset = "0x30")]
			public readonly Action<float> OnScoreUpdate;

			// Token: 0x040051F4 RID: 20980
			[Token(Token = "0x40051F4")]
			[FieldOffset(Offset = "0x38")]
			public readonly float MusicalNoteSpeed;

			// Token: 0x040051F5 RID: 20981
			[Token(Token = "0x40051F5")]
			[FieldOffset(Offset = "0x3C")]
			public readonly bool AutoPlayMode;

			// Token: 0x040051F6 RID: 20982
			[Token(Token = "0x40051F6")]
			[FieldOffset(Offset = "0x40")]
			public readonly float MidiBarLengthMultiplier;

			// Token: 0x040051F7 RID: 20983
			[Token(Token = "0x40051F7")]
			[FieldOffset(Offset = "0x48")]
			public readonly long StartQTEMilliseconds;

			// Token: 0x040051F8 RID: 20984
			[Token(Token = "0x40051F8")]
			[FieldOffset(Offset = "0x50")]
			public readonly long EndQTEMilliseconds;

			// Token: 0x040051F9 RID: 20985
			[Token(Token = "0x40051F9")]
			[FieldOffset(Offset = "0x58")]
			public readonly long MusicSwitchLengthMilliseconds;

			// Token: 0x040051FA RID: 20986
			[Token(Token = "0x40051FA")]
			[FieldOffset(Offset = "0x60")]
			public readonly Action<long> OnSingleNoteProcess;
		}
	}
}
