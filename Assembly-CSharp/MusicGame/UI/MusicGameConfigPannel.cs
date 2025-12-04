using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI.EscapeUtility;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace MusicGame.UI
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	[GenerateCleanupMethod]
	public class MusicGameConfigPannel : UISubPanel<MusicSelectorReconfirmPannel>
	{
		// Token: 0x06000214 RID: 532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x426170", Offset = "0x424B70", VA = "0x180426170", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x426290", Offset = "0x424C90", VA = "0x180426290", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x4267A0", Offset = "0x4251A0", VA = "0x1804267A0")]
		private IEnumerator OnUpdatePreview()
		{
			return null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x426100", Offset = "0x424B00", VA = "0x180426100", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x426080", Offset = "0x424A80", VA = "0x180426080")]
		private void OnMusicalNoteSpeedChangedVisual(float newValue)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x425F90", Offset = "0x424990", VA = "0x180425F90")]
		private void OnMusicCalibrationChangedVisual(float newValue)
		{
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x425FD0", Offset = "0x4249D0", VA = "0x180425FD0")]
		private void OnMusicVolumeChangedVisual(float newValue)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x425EE0", Offset = "0x4248E0", VA = "0x180425EE0")]
		private void OnButtonVolumeChangedVisual(float newValue)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x425D10", Offset = "0x424710", VA = "0x180425D10", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x426820", Offset = "0x425220", VA = "0x180426820")]
		public MusicGameConfigPannel()
		{
		}

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		private const float MUSICGAME_QTEFIELD_LENGTH = 686.24f;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIScrollBar m_MusicVolume;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TMP_Text m_MusicVolumePercentageText;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIScrollBar m_ButtonVolume;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TMP_Text m_ButtonVolumePercentageText;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIScrollBar m_MusicCalibration;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TMP_Text m_MusicCalibrationText;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIScrollBar m_MusicalNoteSpeed;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private TMP_Text m_MusicalNoteSpeedPercentageText;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIButtonSimple m_GoBackBtn;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RectTransform m_NoteSimple;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private RectTransform m_NoteField;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject m_BindingSettingParent;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private RectTransform m_BindingField;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private EscBindingPannel.InputBindingData[] m_InputBindingDatas;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private EscBindingPannel.StringArray[] m_Groups;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0xF0")]
		private readonly UILogicalGroupT<string> m_AllChildrenInstances;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0xF8")]
		private readonly List<GameObject> m_AllGameObjectInstances;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x100")]
		[TupleElementNames(new string[] { "Interactable", "UIElements", "GetCurrentKBDBindingCallback" })]
		private readonly Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> m_Instances;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x108")]
		private bool m_CallbackInitialized;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x110")]
		private Coroutine m_OnUpdatePreviewLoop;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x118")]
		private float m_QTESpeedMultiplier;
	}
}
