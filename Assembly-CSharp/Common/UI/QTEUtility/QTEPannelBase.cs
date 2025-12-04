using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using GameData.Core.MusicUtility;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace Common.UI.QTEUtility
{
	// Token: 0x02000E96 RID: 3734
	[Token(Token = "0x2000E96")]
	[GenerateCleanupMethod]
	public abstract class QTEPannelBase : UIPanel
	{
		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x0600578E RID: 22414 RVA: 0x0001EDF8 File Offset: 0x0001CFF8
		// (set) Token: 0x0600578F RID: 22415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C37")]
		public QTEPannel.PannelOpenContext? OpenContext
		{
			[Token(Token = "0x600578E")]
			[Address(RVA = "0x877F30", Offset = "0x876930", VA = "0x180877F30")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600578F")]
			[Address(RVA = "0x878890", Offset = "0x877290", VA = "0x180878890")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06005790 RID: 22416 RVA: 0x0001EE10 File Offset: 0x0001D010
		[Token(Token = "0x17000C38")]
		public bool IsDemoMode
		{
			[Token(Token = "0x6005790")]
			[Address(RVA = "0x877E70", Offset = "0x876870", VA = "0x180877E70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x06005791 RID: 22417 RVA: 0x0001EE28 File Offset: 0x0001D028
		[Token(Token = "0x17000C39")]
		protected long CurrentTime
		{
			[Token(Token = "0x6005791")]
			[Address(RVA = "0x877D90", Offset = "0x876790", VA = "0x180877D90")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x06005792 RID: 22418 RVA: 0x0001EE40 File Offset: 0x0001D040
		[Token(Token = "0x17000C3A")]
		protected virtual bool WorkMode
		{
			[Token(Token = "0x6005792")]
			[Address(RVA = "0x877F80", Offset = "0x876980", VA = "0x180877F80", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x06005793 RID: 22419
		[Token(Token = "0x17000C3B")]
		protected abstract RectTransform ActiveNoteField
		{
			[Token(Token = "0x6005793")]
			get;
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06005794 RID: 22420 RVA: 0x0001EE58 File Offset: 0x0001D058
		// (set) Token: 0x06005795 RID: 22421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C3C")]
		private protected long NoteStartUpdateOffsetMiliseconds
		{
			[Token(Token = "0x6005794")]
			[Address(RVA = "0x877F20", Offset = "0x876920", VA = "0x180877F20")]
			[CompilerGenerated]
			protected get
			{
				return 0L;
			}
			[Token(Token = "0x6005795")]
			[Address(RVA = "0x878880", Offset = "0x877280", VA = "0x180878880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x06005796 RID: 22422 RVA: 0x0001EE70 File Offset: 0x0001D070
		[Token(Token = "0x17000C3D")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6005796")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06005798 RID: 22424 RVA: 0x0001EE88 File Offset: 0x0001D088
		// (set) Token: 0x06005797 RID: 22423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C3E")]
		public Matrix4x4 WorldToLocalMatrix
		{
			[Token(Token = "0x6005798")]
			[Address(RVA = "0x878030", Offset = "0x876A30", VA = "0x180878030")]
			[CompilerGenerated]
			get
			{
				return default(Matrix4x4);
			}
			[Token(Token = "0x6005797")]
			[Address(RVA = "0x8788F0", Offset = "0x8772F0", VA = "0x1808788F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06005799 RID: 22425 RVA: 0x0001EEA0 File Offset: 0x0001D0A0
		// (set) Token: 0x0600579A RID: 22426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C3F")]
		public int CurrentComboValue
		{
			[Token(Token = "0x6005799")]
			[Address(RVA = "0x515290", Offset = "0x513C90", VA = "0x180515290")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600579A")]
			[Address(RVA = "0x516F70", Offset = "0x515970", VA = "0x180516F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x0600579B RID: 22427 RVA: 0x0001EEB8 File Offset: 0x0001D0B8
		// (set) Token: 0x0600579C RID: 22428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C40")]
		public int CurrentPerfectValue
		{
			[Token(Token = "0x600579B")]
			[Address(RVA = "0x877D80", Offset = "0x876780", VA = "0x180877D80")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600579C")]
			[Address(RVA = "0x878490", Offset = "0x876E90", VA = "0x180878490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x0600579D RID: 22429 RVA: 0x0001EED0 File Offset: 0x0001D0D0
		// (set) Token: 0x0600579E RID: 22430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C41")]
		public int CurrentGoodValue
		{
			[Token(Token = "0x600579D")]
			[Address(RVA = "0x877BD0", Offset = "0x8765D0", VA = "0x180877BD0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600579E")]
			[Address(RVA = "0x878250", Offset = "0x876C50", VA = "0x180878250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x0600579F RID: 22431 RVA: 0x0001EEE8 File Offset: 0x0001D0E8
		// (set) Token: 0x060057A0 RID: 22432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C42")]
		public int CurrentMissValue
		{
			[Token(Token = "0x600579F")]
			[Address(RVA = "0x877D70", Offset = "0x876770", VA = "0x180877D70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60057A0")]
			[Address(RVA = "0x878370", Offset = "0x876D70", VA = "0x180878370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x060057A2 RID: 22434 RVA: 0x0001EF00 File Offset: 0x0001D100
		// (set) Token: 0x060057A1 RID: 22433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C43")]
		private int CurrentCombo
		{
			[Token(Token = "0x60057A2")]
			[Address(RVA = "0x515290", Offset = "0x513C90", VA = "0x180515290")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60057A1")]
			[Address(RVA = "0x878060", Offset = "0x876A60", VA = "0x180878060")]
			set
			{
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x060057A4 RID: 22436 RVA: 0x0001EF18 File Offset: 0x0001D118
		// (set) Token: 0x060057A3 RID: 22435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C44")]
		private int CurrentPerfect
		{
			[Token(Token = "0x60057A4")]
			[Address(RVA = "0x877D80", Offset = "0x876780", VA = "0x180877D80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60057A3")]
			[Address(RVA = "0x8784A0", Offset = "0x876EA0", VA = "0x1808784A0")]
			set
			{
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x060057A6 RID: 22438 RVA: 0x0001EF30 File Offset: 0x0001D130
		// (set) Token: 0x060057A5 RID: 22437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C45")]
		private int CurrentGood
		{
			[Token(Token = "0x60057A6")]
			[Address(RVA = "0x877BD0", Offset = "0x8765D0", VA = "0x180877BD0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60057A5")]
			[Address(RVA = "0x878260", Offset = "0x876C60", VA = "0x180878260")]
			set
			{
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x060057A8 RID: 22440 RVA: 0x0001EF48 File Offset: 0x0001D148
		// (set) Token: 0x060057A7 RID: 22439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C46")]
		private int CurrentMiss
		{
			[Token(Token = "0x60057A8")]
			[Address(RVA = "0x877D70", Offset = "0x876770", VA = "0x180877D70")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60057A7")]
			[Address(RVA = "0x878380", Offset = "0x876D80", VA = "0x180878380")]
			set
			{
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x060057A9 RID: 22441 RVA: 0x0001EF60 File Offset: 0x0001D160
		[Token(Token = "0x17000C47")]
		public IzakayaMusic.SingleNote.NotePosition CurrentInput
		{
			[Token(Token = "0x60057A9")]
			[Address(RVA = "0x877BE0", Offset = "0x8765E0", VA = "0x180877BE0")]
			get
			{
				return IzakayaMusic.SingleNote.NotePosition.None;
			}
		}

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x060057AA RID: 22442 RVA: 0x0001EF78 File Offset: 0x0001D178
		// (set) Token: 0x060057AB RID: 22443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C48")]
		public float FinalScore
		{
			[Token(Token = "0x60057AA")]
			[Address(RVA = "0x877E60", Offset = "0x876860", VA = "0x180877E60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60057AB")]
			[Address(RVA = "0x8785B0", Offset = "0x876FB0", VA = "0x1808785B0")]
			protected set
			{
			}
		}

		// Token: 0x060057AC RID: 22444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057AC")]
		[Address(RVA = "0x8738C0", Offset = "0x8722C0", VA = "0x1808738C0")]
		public void AnimatorPlay(Animator animator)
		{
		}

		// Token: 0x060057AD RID: 22445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057AD")]
		[Address(RVA = "0x555710", Offset = "0x554110", VA = "0x180555710", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x060057AE RID: 22446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057AE")]
		[Address(RVA = "0x875B10", Offset = "0x874510", VA = "0x180875B10", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x060057AF RID: 22447 RVA: 0x0001EF90 File Offset: 0x0001D190
		[Token(Token = "0x60057AF")]
		[Address(RVA = "0x874330", Offset = "0x872D30", VA = "0x180874330")]
		protected static double InverseLerp(long a, long b, long value)
		{
			return 0.0;
		}

		// Token: 0x060057B0 RID: 22448 RVA: 0x0001EFA8 File Offset: 0x0001D1A8
		[Token(Token = "0x60057B0")]
		[Address(RVA = "0x8743E0", Offset = "0x872DE0", VA = "0x1808743E0")]
		protected static float Lerp(double a, double b, double t)
		{
			return 0f;
		}

		// Token: 0x060057B1 RID: 22449 RVA: 0x0001EFC0 File Offset: 0x0001D1C0
		[Token(Token = "0x60057B1")]
		[Address(RVA = "0x873A00", Offset = "0x872400", VA = "0x180873A00")]
		private static double Clamp01(double value)
		{
			return 0.0;
		}

		// Token: 0x060057B2 RID: 22450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B2")]
		[Address(RVA = "0x874980", Offset = "0x873380", VA = "0x180874980", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060057B3 RID: 22451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B3")]
		[Address(RVA = "0x8763E0", Offset = "0x874DE0", VA = "0x1808763E0")]
		private void TryPlayNoteL(InputAction.CallbackContext _)
		{
		}

		// Token: 0x060057B4 RID: 22452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B4")]
		[Address(RVA = "0x8767B0", Offset = "0x8751B0", VA = "0x1808767B0")]
		private void TryReleaseNoteL(InputAction.CallbackContext _)
		{
		}

		// Token: 0x060057B5 RID: 22453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B5")]
		[Address(RVA = "0x8764A0", Offset = "0x874EA0", VA = "0x1808764A0")]
		private void TryPlayNoteR(InputAction.CallbackContext _)
		{
		}

		// Token: 0x060057B6 RID: 22454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B6")]
		[Address(RVA = "0x876890", Offset = "0x875290", VA = "0x180876890")]
		private void TryReleaseNoteR(InputAction.CallbackContext _)
		{
		}

		// Token: 0x060057B7 RID: 22455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B7")]
		[Address(RVA = "0x876190", Offset = "0x874B90", VA = "0x180876190")]
		private void TryClickCurrentNote(IzakayaMusic.SingleNote.NotePosition notePosition)
		{
		}

		// Token: 0x060057B8 RID: 22456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B8")]
		[Address(RVA = "0x876560", Offset = "0x874F60", VA = "0x180876560")]
		private void TryReleaseCurrentNote(IzakayaMusic.SingleNote.NotePosition notePosition)
		{
		}

		// Token: 0x060057B9 RID: 22457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057B9")]
		[Address(RVA = "0x875680", Offset = "0x874080", VA = "0x180875680", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060057BA RID: 22458 RVA: 0x0001EFD8 File Offset: 0x0001D1D8
		[Token(Token = "0x60057BA")]
		[Address(RVA = "0x873960", Offset = "0x872360", VA = "0x180873960")]
		public static ValueTuple<float, float> CalculateScore(int allNotesLength)
		{
			return default(ValueTuple<float, float>);
		}

		// Token: 0x060057BB RID: 22459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BB")]
		[Address(RVA = "0x877780", Offset = "0x876180", VA = "0x180877780")]
		public static void UpdateScore(NoteHeadBase.NoteStatus noteStatus, float perNoteScore, float comboScore, ref int currentMiss, ref int currentCombo, ref float currentScore)
		{
		}

		// Token: 0x060057BC RID: 22460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BC")]
		[Address(RVA = "0x874480", Offset = "0x872E80", VA = "0x180874480", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060057BD RID: 22461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BD")]
		[Address(RVA = "0x875BA0", Offset = "0x8745A0", VA = "0x180875BA0")]
		public void PlayCorrectAudio(bool isPerfect, IzakayaMusic.SingleNote.NotePosition notePosition)
		{
		}

		// Token: 0x060057BE RID: 22462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057BE")]
		[Address(RVA = "0x875F20", Offset = "0x874920", VA = "0x180875F20")]
		public void ReleaseNote(NoteHeadBase noteHeadBase)
		{
		}

		// Token: 0x060057BF RID: 22463
		[Token(Token = "0x60057BF")]
		protected abstract int GetNoteCount();

		// Token: 0x060057C0 RID: 22464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C0")]
		[Address(RVA = "0x8775A0", Offset = "0x875FA0", VA = "0x1808775A0")]
		private void UpdateProgress()
		{
		}

		// Token: 0x060057C1 RID: 22465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C1")]
		[Address(RVA = "0x875DD0", Offset = "0x8747D0", VA = "0x180875DD0")]
		protected void PlayNoteSucceedAnimation(NoteHeadBase noteHeadBase)
		{
		}

		// Token: 0x060057C2 RID: 22466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C2")]
		[Address(RVA = "0x875C80", Offset = "0x874680", VA = "0x180875C80")]
		protected void PlayNoteFailedAnimation(NoteHeadBase noteHeadBase)
		{
		}

		// Token: 0x060057C3 RID: 22467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C3")]
		[Address(RVA = "0x873DD0", Offset = "0x8727D0", VA = "0x180873DD0")]
		public void EvaluateAndReleaseNote(NoteHeadBase noteHeadBase)
		{
		}

		// Token: 0x060057C4 RID: 22468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C4")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "35")]
		protected virtual void OnNoteEvaluated(NoteHeadBase noteHeadBase)
		{
		}

		// Token: 0x060057C5 RID: 22469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C5")]
		[Address(RVA = "0x8742B0", Offset = "0x872CB0", VA = "0x1808742B0")]
		protected void GetFocusingNote(long currentTime)
		{
		}

		// Token: 0x060057C6 RID: 22470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C6")]
		[Address(RVA = "0x877080", Offset = "0x875A80", VA = "0x180877080")]
		protected void UpdateFocusingNote(long currentTime)
		{
		}

		// Token: 0x060057C7 RID: 22471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C7")]
		[Address(RVA = "0x873A20", Offset = "0x872420", VA = "0x180873A20", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060057C8 RID: 22472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057C8")]
		[Address(RVA = "0x877840", Offset = "0x876240", VA = "0x180877840")]
		protected QTEPannelBase()
		{
		}

		// Token: 0x060057CA RID: 22474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CA")]
		[CompilerGenerated]
		private T <OnPanelInitialize>g__CreateNoteAnimationInstance|114_0<T>(T parent) where T : Component
		{
			return null;
		}

		// Token: 0x060057CB RID: 22475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057CB")]
		[CompilerGenerated]
		internal static void <OnPanelInitialize>g__DestroyInstance|114_1<T>(T instance) where T : Component
		{
		}

		// Token: 0x060057CC RID: 22476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CC")]
		[Address(RVA = "0x876CA0", Offset = "0x8756A0", VA = "0x180876CA0")]
		[CompilerGenerated]
		private NoteHeadFinishAnimationController <OnPanelInitialize>g__CreateSucceedAnimationInstance|114_2()
		{
			return null;
		}

		// Token: 0x060057CD RID: 22477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057CD")]
		[Address(RVA = "0x876B60", Offset = "0x875560", VA = "0x180876B60")]
		[CompilerGenerated]
		private NoteHeadFinishAnimationController <OnPanelInitialize>g__CreateFailedAnimationInstance|114_3()
		{
			return null;
		}

		// Token: 0x060057CE RID: 22478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057CE")]
		[Address(RVA = "0x876D80", Offset = "0x875780", VA = "0x180876D80")]
		[CompilerGenerated]
		internal static void <OnPanelInitialize>g__EnableAnimation|114_4(NoteHeadFinishAnimationController animator)
		{
		}

		// Token: 0x060057CF RID: 22479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057CF")]
		[Address(RVA = "0x876CE0", Offset = "0x8756E0", VA = "0x180876CE0")]
		[CompilerGenerated]
		internal static void <OnPanelInitialize>g__DisableAnimation|114_5(NoteHeadFinishAnimationController animator)
		{
		}

		// Token: 0x060057D0 RID: 22480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D0")]
		[CompilerGenerated]
		private T <OnPanelInitialize>g__CreateNoteInstance|114_6<T>(T parent) where T : Component
		{
			return null;
		}

		// Token: 0x060057D1 RID: 22481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D1")]
		[Address(RVA = "0x876C60", Offset = "0x875660", VA = "0x180876C60")]
		[CompilerGenerated]
		private NoteHeadBase <OnPanelInitialize>g__CreateSingleClickNoteInstance|114_7()
		{
			return null;
		}

		// Token: 0x060057D2 RID: 22482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D2")]
		[Address(RVA = "0x876BA0", Offset = "0x8755A0", VA = "0x180876BA0")]
		[CompilerGenerated]
		private NoteHeadBase <OnPanelInitialize>g__CreateHoldClickNoteInstance|114_8()
		{
			return null;
		}

		// Token: 0x060057D3 RID: 22483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D3")]
		[Address(RVA = "0x876C20", Offset = "0x875620", VA = "0x180876C20")]
		[CompilerGenerated]
		private NoteHeadBase <OnPanelInitialize>g__CreateHoldStartNoteInstance|114_9()
		{
			return null;
		}

		// Token: 0x060057D4 RID: 22484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60057D4")]
		[Address(RVA = "0x876BE0", Offset = "0x8755E0", VA = "0x180876BE0")]
		[CompilerGenerated]
		private NoteHeadBase <OnPanelInitialize>g__CreateHoldEndNoteInstance|114_10()
		{
			return null;
		}

		// Token: 0x060057D5 RID: 22485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057D5")]
		[Address(RVA = "0x876DD0", Offset = "0x8757D0", VA = "0x180876DD0")]
		[CompilerGenerated]
		private void <OnPanelInitialize>g__EnableNoteHead|114_11(NoteHeadBase noteHeadBase)
		{
		}

		// Token: 0x060057D6 RID: 22486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057D6")]
		[Address(RVA = "0x876D30", Offset = "0x875730", VA = "0x180876D30")]
		[CompilerGenerated]
		internal static void <OnPanelInitialize>g__DisableNoteHead|114_12(NoteHeadBase noteHeadBase)
		{
		}

		// Token: 0x060057D7 RID: 22487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057D7")]
		[CompilerGenerated]
		internal static void <OnPanelInitialize>g__Preload|114_13<T>(ObjectPool<T> objectPool) where T : class
		{
		}

		// Token: 0x060057D9 RID: 22489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057D9")]
		[Address(RVA = "0x876970", Offset = "0x875370", VA = "0x180876970")]
		[CompilerGenerated]
		private void <GetFocusingNote>g__GetCore|133_0(IzakayaMusic.SingleNote.NotePosition channelId, ref QTEPannelBase.<>c__DisplayClass133_0 A_2)
		{
		}

		// Token: 0x060057DA RID: 22490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057DA")]
		[Address(RVA = "0x876EF0", Offset = "0x8758F0", VA = "0x180876EF0")]
		[CompilerGenerated]
		private void <UpdateFocusingNote>g__UpdateNoteStatus|135_0(NoteHeadBase focusingNote, ref QTEPannelBase.<>c__DisplayClass135_0 A_2)
		{
		}

		// Token: 0x04005209 RID: 21001
		[Token(Token = "0x4005209")]
		public const int FULL_SCORE_VALUE = 10000;

		// Token: 0x0400520A RID: 21002
		[Token(Token = "0x400520A")]
		private const int COMBO_DEDUCT_VALUE = 1000;

		// Token: 0x0400520B RID: 21003
		[Token(Token = "0x400520B")]
		private const int PRELOAD_COUNT = 10;

		// Token: 0x0400520C RID: 21004
		[Token(Token = "0x400520C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int Shine;

		// Token: 0x0400520D RID: 21005
		[Token(Token = "0x400520D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Tooltip("音符提前多少秒开始出现在视野中")]
		protected float m_NoteStartUpdateOffset;

		// Token: 0x0400520E RID: 21006
		[Token(Token = "0x400520E")]
		[FieldOffset(Offset = "0x78")]
		[Tooltip("一个音符将玩家输入记录为Good的提前时间（基于打击时间）")]
		[SerializeField]
		protected long m_MidiNotePreGoodLength;

		// Token: 0x0400520F RID: 21007
		[Token(Token = "0x400520F")]
		[FieldOffset(Offset = "0x80")]
		[Tooltip("一个音符将玩家输入记录为Perfect的提前时间（基于打击时间）")]
		[SerializeField]
		protected long m_MidiNotePrePerfectLength;

		// Token: 0x04005210 RID: 21008
		[Token(Token = "0x4005210")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Tooltip("一个音符在超过打击时间后依然将玩家输入记录为Perfect的时长")]
		protected long m_MidiNotePostPerfectLength;

		// Token: 0x04005211 RID: 21009
		[Token(Token = "0x4005211")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Tooltip("所有音符结束后延迟多久关闭模组")]
		protected float m_CloseOffset;

		// Token: 0x04005212 RID: 21010
		[Token(Token = "0x4005212")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		protected NoteHeadBase m_SingleClickNoteParent;

		// Token: 0x04005213 RID: 21011
		[Token(Token = "0x4005213")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		protected NoteHeadBase m_SingleHoldNoteParent;

		// Token: 0x04005214 RID: 21012
		[Token(Token = "0x4005214")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		protected NoteHeadBase m_HoldNoteStartParent;

		// Token: 0x04005215 RID: 21013
		[Token(Token = "0x4005215")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		protected NoteHeadBase m_HoldNoteEndParent;

		// Token: 0x04005216 RID: 21014
		[Token(Token = "0x4005216")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		protected TextMeshProUGUI m_ScoreText;

		// Token: 0x04005217 RID: 21015
		[Token(Token = "0x4005217")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		protected TextMeshProUGUI m_ScoreText2;

		// Token: 0x04005218 RID: 21016
		[Token(Token = "0x4005218")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		protected TextMeshProUGUI m_ProgressText;

		// Token: 0x04005219 RID: 21017
		[Token(Token = "0x4005219")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		protected Image m_ProgressBar;

		// Token: 0x0400521A RID: 21018
		[Token(Token = "0x400521A")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		protected NoteHeadFinishAnimationController m_NoteSucceedAnimation;

		// Token: 0x0400521B RID: 21019
		[Token(Token = "0x400521B")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		protected NoteHeadFinishAnimationController m_NoteFailedAnimation;

		// Token: 0x0400521C RID: 21020
		[Token(Token = "0x400521C")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		protected RectTransform m_NoteAnimationField;

		// Token: 0x0400521D RID: 21021
		[Token(Token = "0x400521D")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private AudioClip m_PerfectSingleSFX;

		// Token: 0x0400521E RID: 21022
		[Token(Token = "0x400521E")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private AudioClip m_GoodSingleSFX;

		// Token: 0x0400521F RID: 21023
		[Token(Token = "0x400521F")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private AudioClip m_MissSingleSFX;

		// Token: 0x04005220 RID: 21024
		[Token(Token = "0x4005220")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private AudioClip m_PerfectLeftSFX;

		// Token: 0x04005221 RID: 21025
		[Token(Token = "0x4005221")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private AudioClip m_GoodLeftSFX;

		// Token: 0x04005222 RID: 21026
		[Token(Token = "0x4005222")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private AudioClip m_PerfectRightSFX;

		// Token: 0x04005223 RID: 21027
		[Token(Token = "0x4005223")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private AudioClip m_GoodRightSFX;

		// Token: 0x04005224 RID: 21028
		[Token(Token = "0x4005224")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Animator perfectAnimator;

		// Token: 0x04005225 RID: 21029
		[Token(Token = "0x4005225")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Animator goodAnimator;

		// Token: 0x04005226 RID: 21030
		[Token(Token = "0x4005226")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private Animator missAnimator;

		// Token: 0x04005227 RID: 21031
		[Token(Token = "0x4005227")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Animator comboAnimator;

		// Token: 0x04005228 RID: 21032
		[Token(Token = "0x4005228")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private Animator scoreAnimator;

		// Token: 0x04005229 RID: 21033
		[Token(Token = "0x4005229")]
		[FieldOffset(Offset = "0x150")]
		public AdpUISystemUtils.UnityEvent_String OnComboUpdateCallback;

		// Token: 0x0400522A RID: 21034
		[Token(Token = "0x400522A")]
		[FieldOffset(Offset = "0x158")]
		public AdpUISystemUtils.UnityEvent_String OnPerfectNumberUpdateCallback;

		// Token: 0x0400522B RID: 21035
		[Token(Token = "0x400522B")]
		[FieldOffset(Offset = "0x160")]
		public AdpUISystemUtils.UnityEvent_String OnGoodNumberUpdateCallback;

		// Token: 0x0400522C RID: 21036
		[Token(Token = "0x400522C")]
		[FieldOffset(Offset = "0x168")]
		public AdpUISystemUtils.UnityEvent_String OnMissNumberUpdateCallback;

		// Token: 0x0400522D RID: 21037
		[Token(Token = "0x400522D")]
		[FieldOffset(Offset = "0x170")]
		private readonly HashSet<NoteHeadFinishAnimationController> m_ActiveAnimations;

		// Token: 0x0400522E RID: 21038
		[Token(Token = "0x400522E")]
		[FieldOffset(Offset = "0x178")]
		private readonly List<IzakayaMusic.SingleNote.NotePosition> m_CurrentInputCollection;

		// Token: 0x0400522F RID: 21039
		[Token(Token = "0x400522F")]
		[FieldOffset(Offset = "0x180")]
		protected readonly Dictionary<IzakayaMusic.SingleNote.NotePosition, List<NoteHeadBase>> m_FocusingNotes;

		// Token: 0x04005230 RID: 21040
		[Token(Token = "0x4005230")]
		[FieldOffset(Offset = "0x188")]
		protected readonly Dictionary<IzakayaMusic.SingleNote.NotePosition, Queue<NoteHeadBase>> m_UpdatingNotes;

		// Token: 0x04005231 RID: 21041
		[Token(Token = "0x4005231")]
		[FieldOffset(Offset = "0x190")]
		private float m_ComboScore;

		// Token: 0x04005232 RID: 21042
		[Token(Token = "0x4005232")]
		[FieldOffset(Offset = "0x194")]
		private float m_FinalScore;

		// Token: 0x04005233 RID: 21043
		[Token(Token = "0x4005233")]
		[FieldOffset(Offset = "0x198")]
		protected ObjectPool<NoteHeadBase> m_HoldNoteEndPool;

		// Token: 0x04005234 RID: 21044
		[Token(Token = "0x4005234")]
		[FieldOffset(Offset = "0x1A0")]
		protected ObjectPool<NoteHeadBase> m_HoldNoteStartPool;

		// Token: 0x04005235 RID: 21045
		[Token(Token = "0x4005235")]
		[FieldOffset(Offset = "0x1A8")]
		private int m_LastMidiNoteCount;

		// Token: 0x04005236 RID: 21046
		[Token(Token = "0x4005236")]
		[FieldOffset(Offset = "0x1B0")]
		protected ObjectPool<NoteHeadFinishAnimationController> m_NoteFailedAnimationPool;

		// Token: 0x04005237 RID: 21047
		[Token(Token = "0x4005237")]
		[FieldOffset(Offset = "0x1B8")]
		protected ObjectPool<NoteHeadFinishAnimationController> m_NoteSucceedAnimationPool;

		// Token: 0x04005238 RID: 21048
		[Token(Token = "0x4005238")]
		[FieldOffset(Offset = "0x1C0")]
		private float m_PerNoteScore;

		// Token: 0x04005239 RID: 21049
		[Token(Token = "0x4005239")]
		[FieldOffset(Offset = "0x1C8")]
		protected ObjectPool<NoteHeadBase> m_SingleClickNotePool;

		// Token: 0x0400523A RID: 21050
		[Token(Token = "0x400523A")]
		[FieldOffset(Offset = "0x1D0")]
		protected ObjectPool<NoteHeadBase> m_SingleHoldNotePool;

		// Token: 0x0400523B RID: 21051
		[Token(Token = "0x400523B")]
		[FieldOffset(Offset = "0x1D8")]
		private int m_TotalMidiNoteCount;

		// Token: 0x0400523C RID: 21052
		[Token(Token = "0x400523C")]
		[FieldOffset(Offset = "0x1DC")]
		private int m_WorkSceneMidiNoteCount;

		// Token: 0x0400523D RID: 21053
		[Token(Token = "0x400523D")]
		[FieldOffset(Offset = "0x1E0")]
		private int m_WorkSceneSucceededMidiNoteCount;

		// Token: 0x04005245 RID: 21061
		[Token(Token = "0x4005245")]
		[FieldOffset(Offset = "0x2B0")]
		private readonly Queue<NoteHeadBase> _queue;
	}
}
