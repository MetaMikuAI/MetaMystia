using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace Common.UI.QTEUtility
{
	// Token: 0x02000E8B RID: 3723
	[Token(Token = "0x2000E8B")]
	[GenerateCleanupMethod]
	public class NoteHeadFinishAnimationController : MonoBehaviour
	{
		// Token: 0x06005743 RID: 22339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005743")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06005744 RID: 22340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005744")]
		[Address(RVA = "0x8567D0", Offset = "0x8551D0", VA = "0x1808567D0")]
		public void Play(NoteHeadFinishAnimationController.RemoveContext onReleaseHandle, Sprite visual, Vector3 worldPosition)
		{
		}

		// Token: 0x06005745 RID: 22341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005745")]
		[Address(RVA = "0x8568C0", Offset = "0x8552C0", VA = "0x1808568C0")]
		public void Play(NoteHeadFinishAnimationController.RemoveContext onReleaseHandle, Vector3 worldPosition)
		{
		}

		// Token: 0x06005746 RID: 22342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005746")]
		[Address(RVA = "0x856990", Offset = "0x855390", VA = "0x180856990")]
		public void Release()
		{
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005747")]
		[Address(RVA = "0x3EE530", Offset = "0x3ECF30", VA = "0x1803EE530", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06005748 RID: 22344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005748")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public NoteHeadFinishAnimationController()
		{
		}

		// Token: 0x040051CE RID: 20942
		[Token(Token = "0x40051CE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator m_Animator;

		// Token: 0x040051CF RID: 20943
		[Token(Token = "0x40051CF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image m_Visual;

		// Token: 0x040051D0 RID: 20944
		[Token(Token = "0x40051D0")]
		[FieldOffset(Offset = "0x28")]
		private NoteHeadFinishAnimationController.RemoveContext m_OnReleaseHandle;

		// Token: 0x02000E8C RID: 3724
		[Token(Token = "0x2000E8C")]
		public readonly struct RemoveContext
		{
			// Token: 0x06005749 RID: 22345 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005749")]
			[Address(RVA = "0x85A450", Offset = "0x858E50", VA = "0x18085A450")]
			public RemoveContext(HashSet<NoteHeadFinishAnimationController> active, ObjectPool<NoteHeadFinishAnimationController> pool)
			{
			}

			// Token: 0x0600574A RID: 22346 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600574A")]
			[Address(RVA = "0x85A490", Offset = "0x858E90", VA = "0x18085A490")]
			public RemoveContext(bool destroyInstance)
			{
			}

			// Token: 0x0600574B RID: 22347 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600574B")]
			[Address(RVA = "0x85A380", Offset = "0x858D80", VA = "0x18085A380")]
			public void Release(NoteHeadFinishAnimationController instance)
			{
			}

			// Token: 0x040051D1 RID: 20945
			[Token(Token = "0x40051D1")]
			[FieldOffset(Offset = "0x0")]
			private readonly HashSet<NoteHeadFinishAnimationController> _active;

			// Token: 0x040051D2 RID: 20946
			[Token(Token = "0x40051D2")]
			[FieldOffset(Offset = "0x8")]
			private readonly ObjectPool<NoteHeadFinishAnimationController> _pool;

			// Token: 0x040051D3 RID: 20947
			[Token(Token = "0x40051D3")]
			[FieldOffset(Offset = "0x10")]
			private readonly bool _destroyInstance;
		}
	}
}
