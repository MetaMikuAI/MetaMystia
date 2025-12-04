using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Common.UI.GlobalMap
{
	// Token: 0x02000F9E RID: 3998
	[Token(Token = "0x2000F9E")]
	[GenerateCleanupMethod]
	public abstract class GuideMapPanel<TOpenContext, TCloseContext> : UIPanelParam<TOpenContext, TCloseContext>
	{
		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06005DFC RID: 24060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D1D")]
		protected RectTransform GuideMapRectTransform
		{
			[Token(Token = "0x6005DFC")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06005DFD RID: 24061 RVA: 0x00020820 File Offset: 0x0001EA20
		// (set) Token: 0x06005DFE RID: 24062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D1E")]
		private protected bool IsFolded
		{
			[Token(Token = "0x6005DFD")]
			[CompilerGenerated]
			protected get
			{
				return default(bool);
			}
			[Token(Token = "0x6005DFE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005DFF")]
		protected sealed override void OnPanelInitialize()
		{
		}

		// Token: 0x06005E00 RID: 24064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E00")]
		private void OnPointerDown(PointerEventData.InputButton inputButton, Vector2 pressPosition)
		{
		}

		// Token: 0x06005E01 RID: 24065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E01")]
		private void OnPointerDrag(PointerEventData.InputButton inputButton, Vector2 pressPosition, Vector2 currentPosition)
		{
		}

		// Token: 0x06005E02 RID: 24066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E02")]
		protected void ToggleFolding(bool? newValue)
		{
		}

		// Token: 0x06005E03 RID: 24067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E03")]
		private void UpdateFolding(bool isFolded)
		{
		}

		// Token: 0x06005E04 RID: 24068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E04")]
		protected void ToggleBackground(GuideMapPanel<TOpenContext, TCloseContext>.BackgroundFoldingMode backgroundFoldingMode)
		{
		}

		// Token: 0x06005E05 RID: 24069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E05")]
		protected sealed override void OnPanelOpen(TOpenContext openContext)
		{
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E06")]
		protected sealed override void OnPanelClose(TCloseContext closeContext)
		{
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E07")]
		protected sealed override void OnPanelDestroyed()
		{
		}

		// Token: 0x06005E08 RID: 24072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E08")]
		protected virtual void OnGuideMapInitialize()
		{
		}

		// Token: 0x06005E09 RID: 24073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E09")]
		protected virtual void OnGuideMapPanelPreOpen(TOpenContext openContext)
		{
		}

		// Token: 0x06005E0A RID: 24074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E0A")]
		protected virtual void OnGuideMapPanelPostOpen(TOpenContext openContext)
		{
		}

		// Token: 0x06005E0B RID: 24075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E0B")]
		protected virtual void OnGuideMapPanelEndOpen(TOpenContext openContext)
		{
		}

		// Token: 0x06005E0C RID: 24076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E0C")]
		protected virtual void PostInitializeGuideMapSpot(IGuideMapSpot guideMapSpot)
		{
		}

		// Token: 0x06005E0D RID: 24077 RVA: 0x00020838 File Offset: 0x0001EA38
		[Token(Token = "0x6005E0D")]
		protected virtual bool GetSpotOpenStatus(IGuideMapSpot guideMapSpot)
		{
			return default(bool);
		}

		// Token: 0x06005E0E RID: 24078 RVA: 0x00020850 File Offset: 0x0001EA50
		[Token(Token = "0x6005E0E")]
		protected virtual bool GetSpotShouldShowPath(IGuideMapSpot guideMapSpot1, IGuideMapSpot guideMapSpot2)
		{
			return default(bool);
		}

		// Token: 0x06005E0F RID: 24079 RVA: 0x00020868 File Offset: 0x0001EA68
		[Token(Token = "0x6005E0F")]
		protected virtual bool? IsFirstToSelectSpot(IGuideMapSpot guideMapSpot)
		{
			return null;
		}

		// Token: 0x06005E10 RID: 24080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E10")]
		protected virtual void OnGuideMapSpotSelected(IGuideMapSpot guideMapSpot)
		{
		}

		// Token: 0x06005E11 RID: 24081 RVA: 0x00020880 File Offset: 0x0001EA80
		[Token(Token = "0x6005E11")]
		protected virtual bool IsGuideMapSpotCanBeSelected(IGuideMapSpot guideMapSpot)
		{
			return default(bool);
		}

		// Token: 0x06005E12 RID: 24082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E12")]
		protected virtual void OnGuideMapSpotSubmit(IGuideMapSpot guideMapSpot)
		{
		}

		// Token: 0x06005E13 RID: 24083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E13")]
		protected virtual void OnGuideMapClose(TCloseContext closeContext)
		{
		}

		// Token: 0x06005E14 RID: 24084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E14")]
		protected virtual void OnSecondarySwitchUpdate()
		{
		}

		// Token: 0x06005E15 RID: 24085 RVA: 0x00020898 File Offset: 0x0001EA98
		[Token(Token = "0x6005E15")]
		protected int GetTravelCount(IGuideMapSpot from, IGuideMapSpot to)
		{
			return 0;
		}

		// Token: 0x06005E16 RID: 24086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E16")]
		protected IReadOnlyList<IGuideMapSpot> GetSpotList()
		{
			return null;
		}

		// Token: 0x06005E17 RID: 24087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005E17")]
		protected IReadOnlyDictionary<GuideMapSpot, int> GetNeighbourDistance(IGuideMapSpot guideMapSpot)
		{
			return null;
		}

		// Token: 0x06005E18 RID: 24088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E18")]
		public void UpdateSelectionSpots()
		{
		}

		// Token: 0x06005E19 RID: 24089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E19")]
		private void FocusToGuideMapSpot(IGuideMapSpot guideMapSpot)
		{
		}

		// Token: 0x06005E1A RID: 24090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E1A")]
		private void Update()
		{
		}

		// Token: 0x06005E1B RID: 24091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E1B")]
		private void UpdateInternal(bool immediateSnap)
		{
		}

		// Token: 0x06005E1C RID: 24092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E1C")]
		protected void FocusToDrag(bool immediateSnap)
		{
		}

		// Token: 0x06005E1D RID: 24093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E1D")]
		protected void FocusToSpot(bool immediateSnap)
		{
		}

		// Token: 0x06005E1E RID: 24094 RVA: 0x000208B0 File Offset: 0x0001EAB0
		[Token(Token = "0x6005E1E")]
		private Vector2 ClampPosition(Vector2 targetPosition)
		{
			return default(Vector2);
		}

		// Token: 0x06005E1F RID: 24095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E1F")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06005E20 RID: 24096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005E20")]
		protected GuideMapPanel()
		{
		}

		// Token: 0x04005709 RID: 22281
		[Token(Token = "0x4005709")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private GuideMapController m_GuideMapController;

		// Token: 0x0400570A RID: 22282
		[Token(Token = "0x400570A")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform m_Min_Normal;

		// Token: 0x0400570B RID: 22283
		[Token(Token = "0x400570B")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform m_Max_Normal;

		// Token: 0x0400570C RID: 22284
		[Token(Token = "0x400570C")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform m_Center_Normal;

		// Token: 0x0400570D RID: 22285
		[Token(Token = "0x400570D")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform m_Min_Shrink;

		// Token: 0x0400570E RID: 22286
		[Token(Token = "0x400570E")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform m_Max_Shrink;

		// Token: 0x0400570F RID: 22287
		[Token(Token = "0x400570F")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform m_Center_Shrink;

		// Token: 0x04005710 RID: 22288
		[Token(Token = "0x4005710")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform m_Min_Expand;

		// Token: 0x04005711 RID: 22289
		[Token(Token = "0x4005711")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform m_Max_Expand;

		// Token: 0x04005712 RID: 22290
		[Token(Token = "0x4005712")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private RectTransform m_Center_Expand;

		// Token: 0x04005713 RID: 22291
		[Token(Token = "0x4005713")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float m_Duration;

		// Token: 0x04005714 RID: 22292
		[Token(Token = "0x4005714")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float m_DragDuration;

		// Token: 0x04005715 RID: 22293
		[Token(Token = "0x4005715")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Image m_HighLight;

		// Token: 0x04005716 RID: 22294
		[Token(Token = "0x4005716")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Image m_Background;

		// Token: 0x04005717 RID: 22295
		[Token(Token = "0x4005717")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float m_NormalSize;

		// Token: 0x04005718 RID: 22296
		[Token(Token = "0x4005718")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float m_ShrinkSize;

		// Token: 0x04005719 RID: 22297
		[Token(Token = "0x4005719")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private float m_ExpandSize;

		// Token: 0x0400571A RID: 22298
		[Token(Token = "0x400571A")]
		[FieldOffset(Offset = "0x0")]
		private RectTransform m_GuideMap;

		// Token: 0x0400571B RID: 22299
		[Token(Token = "0x400571B")]
		[FieldOffset(Offset = "0x0")]
		private RectTransform m_SelectedSpot;

		// Token: 0x0400571C RID: 22300
		[Token(Token = "0x400571C")]
		[FieldOffset(Offset = "0x0")]
		private RectTransform m_FocusingSpot;

		// Token: 0x0400571D RID: 22301
		[Token(Token = "0x400571D")]
		[FieldOffset(Offset = "0x0")]
		private Vector2 m_CurrentVelocity;

		// Token: 0x0400571E RID: 22302
		[Token(Token = "0x400571E")]
		[FieldOffset(Offset = "0x0")]
		private Vector2 m_GuideMapDragPosition;

		// Token: 0x0400571F RID: 22303
		[Token(Token = "0x400571F")]
		[FieldOffset(Offset = "0x0")]
		private Vector2 m_GuideMapStartDragOffset;

		// Token: 0x04005721 RID: 22305
		[Token(Token = "0x4005721")]
		[FieldOffset(Offset = "0x0")]
		private RectTransform m_Min_Current;

		// Token: 0x04005722 RID: 22306
		[Token(Token = "0x4005722")]
		[FieldOffset(Offset = "0x0")]
		private RectTransform m_Max_Current;

		// Token: 0x04005723 RID: 22307
		[Token(Token = "0x4005723")]
		[FieldOffset(Offset = "0x0")]
		private RectTransform m_Center_Current;

		// Token: 0x02000F9F RID: 3999
		[Token(Token = "0x2000F9F")]
		protected enum BackgroundFoldingMode
		{
			// Token: 0x04005725 RID: 22309
			[Token(Token = "0x4005725")]
			Normal,
			// Token: 0x04005726 RID: 22310
			[Token(Token = "0x4005726")]
			Expand,
			// Token: 0x04005727 RID: 22311
			[Token(Token = "0x4005727")]
			Shrink
		}
	}
}
