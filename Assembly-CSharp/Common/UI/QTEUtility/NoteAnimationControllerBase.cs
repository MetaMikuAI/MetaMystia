using System;
using System.Runtime.CompilerServices;
using GameData.Core.MusicUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI.QTEUtility
{
	// Token: 0x02000E87 RID: 3719
	[Token(Token = "0x2000E87")]
	[GenerateCleanupMethod]
	public abstract class NoteAnimationControllerBase : MonoBehaviour
	{
		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06005710 RID: 22288 RVA: 0x0001EBD0 File Offset: 0x0001CDD0
		// (set) Token: 0x06005711 RID: 22289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C25")]
		public IzakayaMusic.SingleNote NoteData
		{
			[Token(Token = "0x6005710")]
			[Address(RVA = "0x473F70", Offset = "0x472970", VA = "0x180473F70")]
			[CompilerGenerated]
			protected get
			{
				return default(IzakayaMusic.SingleNote);
			}
			[Token(Token = "0x6005711")]
			[Address(RVA = "0x856120", Offset = "0x854B20", VA = "0x180856120")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06005712 RID: 22290 RVA: 0x0001EBE8 File Offset: 0x0001CDE8
		// (set) Token: 0x06005713 RID: 22291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C26")]
		public bool IsEasyMode
		{
			[Token(Token = "0x6005712")]
			[Address(RVA = "0x44FC20", Offset = "0x44E620", VA = "0x18044FC20")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x6005713")]
			[Address(RVA = "0x856110", Offset = "0x854B10", VA = "0x180856110")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005714 RID: 22292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005714")]
		[Address(RVA = "0x783370", Offset = "0x781D70", VA = "0x180783370")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005715 RID: 22293
		[Token(Token = "0x6005715")]
		public abstract void OnNoteChangeToMiss();

		// Token: 0x06005716 RID: 22294
		[Token(Token = "0x6005716")]
		public abstract void OnNoteChangeToGood();

		// Token: 0x06005717 RID: 22295
		[Token(Token = "0x6005717")]
		public abstract void OnNoteChangeToPerfect();

		// Token: 0x06005718 RID: 22296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005718")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "7")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06005719 RID: 22297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005719")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		protected NoteAnimationControllerBase()
		{
		}
	}
}
