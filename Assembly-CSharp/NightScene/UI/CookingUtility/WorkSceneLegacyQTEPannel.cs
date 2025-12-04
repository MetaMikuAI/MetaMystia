using System;
using System.Collections.Generic;
using Common.UI.QTEUtility;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace NightScene.UI.CookingUtility
{
	// Token: 0x02000722 RID: 1826
	[Token(Token = "0x2000722")]
	[GenerateCleanupMethod]
	public class WorkSceneLegacyQTEPannel : QTEPannelBase
	{
		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06002B39 RID: 11065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005EA")]
		protected override RectTransform ActiveNoteField
		{
			[Token(Token = "0x6002B39")]
			[Address(RVA = "0x5141E0", Offset = "0x512BE0", VA = "0x1805141E0", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06002B3A RID: 11066 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		[Token(Token = "0x170005EB")]
		protected override bool WorkMode
		{
			[Token(Token = "0x6002B3A")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3B")]
		[Address(RVA = "0x592250", Offset = "0x590C50", VA = "0x180592250", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3C")]
		[Address(RVA = "0x5922A0", Offset = "0x590CA0", VA = "0x1805922A0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3D")]
		[Address(RVA = "0x592050", Offset = "0x590A50", VA = "0x180592050", Slot = "35")]
		protected override void OnNoteEvaluated(NoteHeadBase noteHeadBase)
		{
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B3E")]
		[Address(RVA = "0x5921E0", Offset = "0x590BE0", VA = "0x1805921E0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06002B3F RID: 11071 RVA: 0x0000F5B8 File Offset: 0x0000D7B8
		[Token(Token = "0x6002B3F")]
		[Address(RVA = "0x591E30", Offset = "0x590830", VA = "0x180591E30", Slot = "34")]
		protected override int GetNoteCount()
		{
			return 0;
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B40")]
		[Address(RVA = "0x591D50", Offset = "0x590750", VA = "0x180591D50", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B41")]
		[Address(RVA = "0x592CC0", Offset = "0x5916C0", VA = "0x180592CC0")]
		public WorkSceneLegacyQTEPannel()
		{
		}

		// Token: 0x040027A1 RID: 10145
		[Token(Token = "0x40027A1")]
		[FieldOffset(Offset = "0x2B8")]
		[SerializeField]
		private RectTransform m_NoteField;

		// Token: 0x040027A2 RID: 10146
		[Token(Token = "0x40027A2")]
		[FieldOffset(Offset = "0x2C0")]
		[SerializeField]
		private RectTransform m_FinishedNoteField;

		// Token: 0x040027A3 RID: 10147
		[Token(Token = "0x40027A3")]
		[FieldOffset(Offset = "0x2C8")]
		[SerializeField]
		private RectTransform m_Module;

		// Token: 0x040027A4 RID: 10148
		[Token(Token = "0x40027A4")]
		[FieldOffset(Offset = "0x2D0")]
		[SerializeField]
		private RectTransform m_Scanner;

		// Token: 0x040027A5 RID: 10149
		[Token(Token = "0x40027A5")]
		[FieldOffset(Offset = "0x2D8")]
		private readonly Dictionary<NoteHeadBase, GameObject> m_FinishedNoteInstances;

		// Token: 0x040027A6 RID: 10150
		[Token(Token = "0x40027A6")]
		[FieldOffset(Offset = "0x2E0")]
		private float m_InitialModuleWidth;

		// Token: 0x040027A7 RID: 10151
		[Token(Token = "0x40027A7")]
		[FieldOffset(Offset = "0x2E8")]
		private Coroutine m_UpdateNoteCoroutine;

		// Token: 0x040027A8 RID: 10152
		[Token(Token = "0x40027A8")]
		[FieldOffset(Offset = "0x2F0")]
		private Coroutine m_UpdateScannerCoroutine;
	}
}
