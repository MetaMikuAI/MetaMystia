using System;
using System.Collections;
using System.Collections.Generic;
using Common.UI.GlobalMap;
using Il2CppDummyDll;
using UnityEngine;

namespace NightScene.UI.Miscellaneous
{
	// Token: 0x020006B5 RID: 1717
	[Token(Token = "0x20006B5")]
	public class DLC5_WorkSceneToyohimePanel : GuideMapPanel<DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext, string>
	{
		// Token: 0x0600288D RID: 10381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288D")]
		[Address(RVA = "0x545EE0", Offset = "0x5448E0", VA = "0x180545EE0", Slot = "34")]
		protected override void OnGuideMapInitialize()
		{
		}

		// Token: 0x0600288E RID: 10382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288E")]
		[Address(RVA = "0x545DB0", Offset = "0x5447B0", VA = "0x180545DB0")]
		public void CloseExternPanel()
		{
		}

		// Token: 0x0600288F RID: 10383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600288F")]
		[Address(RVA = "0x545F80", Offset = "0x544980", VA = "0x180545F80", Slot = "37")]
		protected override void OnGuideMapPanelEndOpen(DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext openContext)
		{
		}

		// Token: 0x06002890 RID: 10384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002890")]
		[Address(RVA = "0x5467C0", Offset = "0x5451C0", VA = "0x1805467C0")]
		private IEnumerator OpenBlockPanel()
		{
			return null;
		}

		// Token: 0x06002891 RID: 10385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002891")]
		[Address(RVA = "0x546070", Offset = "0x544A70", VA = "0x180546070", Slot = "35")]
		protected override void OnGuideMapPanelPreOpen(DLC5_WorkSceneToyohimePanel.ToyohimeMapOpenContext openContext)
		{
		}

		// Token: 0x06002892 RID: 10386 RVA: 0x0000EE38 File Offset: 0x0000D038
		[Token(Token = "0x6002892")]
		[Address(RVA = "0x545E10", Offset = "0x544810", VA = "0x180545E10", Slot = "39")]
		protected override bool GetSpotOpenStatus(IGuideMapSpot guideMapSpot)
		{
			return default(bool);
		}

		// Token: 0x06002893 RID: 10387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002893")]
		[Address(RVA = "0x546470", Offset = "0x544E70", VA = "0x180546470", Slot = "42")]
		protected override void OnGuideMapSpotSelected(IGuideMapSpot guideMapSpot)
		{
		}

		// Token: 0x06002894 RID: 10388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002894")]
		[Address(RVA = "0x546710", Offset = "0x545110", VA = "0x180546710", Slot = "44")]
		protected override void OnGuideMapSpotSubmit(IGuideMapSpot guideMapSpot)
		{
		}

		// Token: 0x06002895 RID: 10389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002895")]
		[Address(RVA = "0x5468A0", Offset = "0x5452A0", VA = "0x1805468A0")]
		public DLC5_WorkSceneToyohimePanel()
		{
		}

		// Token: 0x040024EA RID: 9450
		[Token(Token = "0x40024EA")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private Animator m_Animator;

		// Token: 0x040024EB RID: 9451
		[Token(Token = "0x40024EB")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private CanvasGroup m_SubmitInput;

		// Token: 0x040024EC RID: 9452
		[Token(Token = "0x40024EC")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private CanvasGroup m_HasLinkedInput;

		// Token: 0x040024ED RID: 9453
		[Token(Token = "0x40024ED")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private Vector3 m_InputOffset;

		// Token: 0x040024EE RID: 9454
		[Token(Token = "0x40024EE")]
		[FieldOffset(Offset = "0x17C")]
		[SerializeField]
		private float m_Delay;

		// Token: 0x040024EF RID: 9455
		[Token(Token = "0x40024EF")]
		[FieldOffset(Offset = "0x180")]
		private string m_CurrentSpot;

		// Token: 0x040024F0 RID: 9456
		[Token(Token = "0x40024F0")]
		[FieldOffset(Offset = "0x188")]
		private readonly HashSet<string> m_ActivedSpots;

		// Token: 0x040024F1 RID: 9457
		[Token(Token = "0x40024F1")]
		[FieldOffset(Offset = "0x190")]
		private readonly HashSet<string> m_ShowButDisableSpots;

		// Token: 0x040024F2 RID: 9458
		[Token(Token = "0x40024F2")]
		[FieldOffset(Offset = "0x198")]
		private string m_CurrentSelectedSpot;

		// Token: 0x020006B6 RID: 1718
		[Token(Token = "0x20006B6")]
		public struct ToyohimeMapOpenContext
		{
			// Token: 0x06002897 RID: 10391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002897")]
			[Address(RVA = "0x44F260", Offset = "0x44DC60", VA = "0x18044F260")]
			public ToyohimeMapOpenContext(Predicate<string> checkSpotOpened, Predicate<string> checkSpotLinked, string currentMapLabel)
			{
			}

			// Token: 0x040024F3 RID: 9459
			[Token(Token = "0x40024F3")]
			[FieldOffset(Offset = "0x0")]
			public Predicate<string> CheckSpotOpened;

			// Token: 0x040024F4 RID: 9460
			[Token(Token = "0x40024F4")]
			[FieldOffset(Offset = "0x8")]
			public Predicate<string> CheckSpotLinked;

			// Token: 0x040024F5 RID: 9461
			[Token(Token = "0x40024F5")]
			[FieldOffset(Offset = "0x10")]
			public string CurrentMapLabel;
		}
	}
}
