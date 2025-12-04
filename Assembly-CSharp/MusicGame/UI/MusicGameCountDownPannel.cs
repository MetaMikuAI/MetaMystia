using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace MusicGame.UI
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[GenerateCleanupMethod]
	public class MusicGameCountDownPannel : UIPanel
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000149 RID: 329 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x1700001D")]
		public int MaxCountDown
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x3EBDA0", Offset = "0x3EA7A0", VA = "0x1803EBDA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600014A RID: 330 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x1700001E")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x410270", Offset = "0x40EC70", VA = "0x180410270", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x4101F0", Offset = "0x40EBF0", VA = "0x1804101F0")]
		private IEnumerator CountDownLoop()
		{
			return null;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x4101C0", Offset = "0x40EBC0", VA = "0x1804101C0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x408E80", Offset = "0x407880", VA = "0x180408E80")]
		public MusicGameCountDownPannel()
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x4102F0", Offset = "0x40ECF0", VA = "0x1804102F0")]
		[CompilerGenerated]
		private void <CountDownLoop>g__UpdateCurrent|7_0(ref MusicGameCountDownPannel.<>c__DisplayClass7_0 A_1)
		{
		}

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int TotalCountDown;

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TextMeshProUGUI CountDown;
	}
}
