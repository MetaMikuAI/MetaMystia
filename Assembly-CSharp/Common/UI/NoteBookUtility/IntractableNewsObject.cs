using System;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x02000E9A RID: 3738
	[Token(Token = "0x2000E9A")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(UIButtonSimple), typeof(CanvasGroup))]
	public class IntractableNewsObject : MonoBehaviour
	{
		// Token: 0x060057E8 RID: 22504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E8")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x060057E9 RID: 22505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E9")]
		[Address(RVA = "0x867490", Offset = "0x865E90", VA = "0x180867490")]
		private void Awake()
		{
		}

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x060057EA RID: 22506 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060057EB RID: 22507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C49")]
		public CanvasGroup CanvasGroupComponent
		{
			[Token(Token = "0x60057EA")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057EB")]
			[Address(RVA = "0x3FC090", Offset = "0x3FAA90", VA = "0x1803FC090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x060057EC RID: 22508 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060057ED RID: 22509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C4A")]
		public UIButtonSimple UIButtonSimpleComponent
		{
			[Token(Token = "0x60057EC")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60057ED")]
			[Address(RVA = "0x3F2100", Offset = "0x3F0B00", VA = "0x1803F2100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060057EE RID: 22510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057EE")]
		[Address(RVA = "0x867590", Offset = "0x865F90", VA = "0x180867590")]
		public void SetValue(in RunTimeScheduler.HistoryNewsData newsData, Action onSubmit)
		{
		}

		// Token: 0x060057EF RID: 22511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057EF")]
		[Address(RVA = "0x3EEA30", Offset = "0x3ED430", VA = "0x1803EEA30", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x060057F0 RID: 22512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F0")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public IntractableNewsObject()
		{
		}

		// Token: 0x04005258 RID: 21080
		[Token(Token = "0x4005258")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI m_Title;

		// Token: 0x04005259 RID: 21081
		[Token(Token = "0x4005259")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI m_Content;

		// Token: 0x0400525A RID: 21082
		[Token(Token = "0x400525A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI m_Date;

		// Token: 0x0400525B RID: 21083
		[Token(Token = "0x400525B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Action m_OnSubmit;
	}
}
