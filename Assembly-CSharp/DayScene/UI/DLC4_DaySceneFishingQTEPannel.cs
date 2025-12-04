using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.Managers;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

namespace DayScene.UI
{
	// Token: 0x020002EB RID: 747
	[Token(Token = "0x20002EB")]
	[GenerateCleanupMethod]
	public class DLC4_DaySceneFishingQTEPannel : UISubPanel<DLC4_DaySceneFishingPrePannel>
	{
		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x00006AC8 File Offset: 0x00004CC8
		// (set) Token: 0x060010FA RID: 4346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A5")]
		public DLC4_DaySceneFishingQTEPannel.FishMoveMode CurrentFishMoveMode
		{
			[Token(Token = "0x60010F9")]
			[Address(RVA = "0x91CAE0", Offset = "0x91B4E0", VA = "0x18091CAE0")]
			[CompilerGenerated]
			get
			{
				return DLC4_DaySceneFishingQTEPannel.FishMoveMode.Smooth;
			}
			[Token(Token = "0x60010FA")]
			[Address(RVA = "0x91CBC0", Offset = "0x91B5C0", VA = "0x18091CBC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x00006AE0 File Offset: 0x00004CE0
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001A6")]
		public DLC4_DaySceneFishingQTEPannel.FishingResult Result
		{
			[Token(Token = "0x60010FB")]
			[Address(RVA = "0x91CBB0", Offset = "0x91B5B0", VA = "0x18091CBB0")]
			[CompilerGenerated]
			get
			{
				return DLC4_DaySceneFishingQTEPannel.FishingResult.Fail;
			}
			[Token(Token = "0x60010FC")]
			[Address(RVA = "0x91CBD0", Offset = "0x91B5D0", VA = "0x18091CBD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x00006AF8 File Offset: 0x00004CF8
		[Token(Token = "0x170001A7")]
		private DLC4_DaySceneFishingQTEPannel.MoveModeProperty CurrentMoveMode
		{
			[Token(Token = "0x60010FD")]
			[Address(RVA = "0x91CAF0", Offset = "0x91B4F0", VA = "0x18091CAF0")]
			get
			{
				return default(DLC4_DaySceneFishingQTEPannel.MoveModeProperty);
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x00006B10 File Offset: 0x00004D10
		[Token(Token = "0x170001A8")]
		public override AdpUIPanelManager.RequestedInputMode RequestedInputMode
		{
			[Token(Token = "0x60010FE")]
			[Address(RVA = "0x44FC00", Offset = "0x44E600", VA = "0x18044FC00", Slot = "17")]
			get
			{
				return AdpUIPanelManager.RequestedInputMode.Player;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x00006B28 File Offset: 0x00004D28
		[Token(Token = "0x170001A9")]
		private float RandomFlowOffset
		{
			[Token(Token = "0x60010FF")]
			[Address(RVA = "0x91CB40", Offset = "0x91B540", VA = "0x18091CB40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001100")]
		[Address(RVA = "0x91C8B0", Offset = "0x91B2B0", VA = "0x18091C8B0")]
		private void Update()
		{
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001101")]
		[Address(RVA = "0x91B910", Offset = "0x91A310", VA = "0x18091B910", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001102")]
		[Address(RVA = "0x91C0D0", Offset = "0x91AAD0", VA = "0x18091C0D0")]
		private void OnSubmit(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001103")]
		[Address(RVA = "0x91B8A0", Offset = "0x91A2A0", VA = "0x18091B8A0")]
		private void OnCancel(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001104")]
		[Address(RVA = "0x91C750", Offset = "0x91B150", VA = "0x18091C750")]
		private void UpdateVisual()
		{
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001105")]
		[Address(RVA = "0x91C0E0", Offset = "0x91AAE0", VA = "0x18091C0E0")]
		private IEnumerator OnUpdateProgress()
		{
			return null;
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x00006B40 File Offset: 0x00004D40
		[Token(Token = "0x6001106")]
		[Address(RVA = "0x91B800", Offset = "0x91A200", VA = "0x18091B800")]
		private DLC4_DaySceneFishingQTEPannel.FishMoveMode GetLevel()
		{
			return DLC4_DaySceneFishingQTEPannel.FishMoveMode.Smooth;
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001107")]
		[Address(RVA = "0x91BBF0", Offset = "0x91A5F0", VA = "0x18091BBF0", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001108")]
		[Address(RVA = "0x91B740", Offset = "0x91A140", VA = "0x18091B740")]
		private void FreeFall()
		{
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001109")]
		[Address(RVA = "0x91C150", Offset = "0x91AB50", VA = "0x18091C150")]
		private void TryMoveFish()
		{
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600110A")]
		[Address(RVA = "0x91C510", Offset = "0x91AF10", VA = "0x18091C510")]
		private void UpdateFishingAndTreasureProgress()
		{
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600110B")]
		[Address(RVA = "0x91B8B0", Offset = "0x91A2B0", VA = "0x18091B8B0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600110C")]
		[Address(RVA = "0x91B630", Offset = "0x91A030", VA = "0x18091B630", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600110D")]
		[Address(RVA = "0x91CA60", Offset = "0x91B460", VA = "0x18091CA60")]
		public DLC4_DaySceneFishingQTEPannel()
		{
		}

		// Token: 0x04000F96 RID: 3990
		[Token(Token = "0x4000F96")]
		private const float G = 9.8f;

		// Token: 0x04000F97 RID: 3991
		[Token(Token = "0x4000F97")]
		private const int M = 10;

		// Token: 0x04000F98 RID: 3992
		[Token(Token = "0x4000F98")]
		[FieldOffset(Offset = "0x78")]
		[Header("钓鱼初始进度")]
		[SerializeField]
		private float m_FishingStartProgress;

		// Token: 0x04000F99 RID: 3993
		[Token(Token = "0x4000F99")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[Header("宝藏生成位置范围")]
		private Vector2 m_TreasureSpawnArea;

		// Token: 0x04000F9A RID: 3994
		[Token(Token = "0x4000F9A")]
		[FieldOffset(Offset = "0x84")]
		[Header("鱼开始时生成的位置范围")]
		[SerializeField]
		private Vector2 m_DeterminationPointStartProgress;

		// Token: 0x04000F9B RID: 3995
		[Token(Token = "0x4000F9B")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		[Header("浮标长度（按比例）")]
		private float m_SliderBoxLength;

		// Token: 0x04000F9C RID: 3996
		[Token(Token = "0x4000F9C")]
		[FieldOffset(Offset = "0x90")]
		[Header("浮标命中鱼时视觉上每帧增加的值")]
		[SerializeField]
		private float m_SliderBoxProgressChangeAmount;

		// Token: 0x04000F9D RID: 3997
		[Token(Token = "0x4000F9D")]
		[FieldOffset(Offset = "0x94")]
		[Header("浮标命中鱼时每秒增加的进度")]
		[SerializeField]
		private float m_FishingProgressAddPerSec;

		// Token: 0x04000F9E RID: 3998
		[Token(Token = "0x4000F9E")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Header("浮标未命中鱼时每秒失去的进度")]
		private float m_FishingProgressLosePerSec;

		// Token: 0x04000F9F RID: 3999
		[Token(Token = "0x4000F9F")]
		[FieldOffset(Offset = "0x9C")]
		[Header("浮标处于按下状态时对浮标施加的向上的力（牛），至少98N")]
		[SerializeField]
		private float m_ForceWhenPressed;

		// Token: 0x04000FA0 RID: 4000
		[Token(Token = "0x4000FA0")]
		[FieldOffset(Offset = "0xA0")]
		[Header("速度对进度条的影响比例")]
		[SerializeField]
		private float m_SpeedToProgressPercentage;

		// Token: 0x04000FA1 RID: 4001
		[Token(Token = "0x4000FA1")]
		[FieldOffset(Offset = "0xA4")]
		[Header("浮标命中宝藏时每秒增加的进度")]
		[SerializeField]
		private float m_TreasureProgressGetPerSec;

		// Token: 0x04000FA2 RID: 4002
		[Token(Token = "0x4000FA2")]
		[FieldOffset(Offset = "0xA8")]
		[Header("浮标未命中宝藏时每秒失去的进度")]
		[SerializeField]
		private float m_TreasureProgressLosePerSec;

		// Token: 0x04000FA3 RID: 4003
		[Token(Token = "0x4000FA3")]
		[FieldOffset(Offset = "0xB0")]
		[Header("鱼类运动模式")]
		[SerializeField]
		private DLC4_DaySceneFishingQTEPannel.MoveModeProperty[] m_FishMoveMode;

		// Token: 0x04000FA4 RID: 4004
		[Token(Token = "0x4000FA4")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Header("浮动时间")]
		private Vector3 m_ShakeFlow;

		// Token: 0x04000FA5 RID: 4005
		[Token(Token = "0x4000FA5")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[Header("浮动振幅")]
		private float m_ShakeOffset;

		// Token: 0x04000FA6 RID: 4006
		[Token(Token = "0x4000FA6")]
		[FieldOffset(Offset = "0xC8")]
		[Header("以下为UI组件无需调整")]
		[SerializeField]
		private RectTransform m_WholeUIParent;

		// Token: 0x04000FA7 RID: 4007
		[Token(Token = "0x4000FA7")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Vector3 m_Offset;

		// Token: 0x04000FA8 RID: 4008
		[Token(Token = "0x4000FA8")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private RectTransform m_FishingArea;

		// Token: 0x04000FA9 RID: 4009
		[Token(Token = "0x4000FA9")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private RectTransform m_TreasureImage;

		// Token: 0x04000FAA RID: 4010
		[Token(Token = "0x4000FAA")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private CanvasGroup m_TreasureArea;

		// Token: 0x04000FAB RID: 4011
		[Token(Token = "0x4000FAB")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_TreasureProgressIndicator;

		// Token: 0x04000FAC RID: 4012
		[Token(Token = "0x4000FAC")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_FishingProgressIndicator;

		// Token: 0x04000FAD RID: 4013
		[Token(Token = "0x4000FAD")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_SliderBoxProgressIndicator;

		// Token: 0x04000FAE RID: 4014
		[Token(Token = "0x4000FAE")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Animator m_TreasureAnimator;

		// Token: 0x04000FAF RID: 4015
		[Token(Token = "0x4000FAF")]
		[FieldOffset(Offset = "0x118")]
		[FormerlySerializedAs("m_DeterminedBoxProgressIndicator")]
		[SerializeField]
		private AdpProgressIndicatorComponent m_DeterminedPointIndicator;

		// Token: 0x04000FB0 RID: 4016
		[Token(Token = "0x4000FB0")]
		[FieldOffset(Offset = "0x120")]
		private readonly int AnimatorKey_Disappear;

		// Token: 0x04000FB1 RID: 4017
		[Token(Token = "0x4000FB1")]
		[FieldOffset(Offset = "0x124")]
		private readonly int AnimatorKey_Idle;

		// Token: 0x04000FB2 RID: 4018
		[Token(Token = "0x4000FB2")]
		[FieldOffset(Offset = "0x128")]
		private float currentDeterminationPointProgress;

		// Token: 0x04000FB3 RID: 4019
		[Token(Token = "0x4000FB3")]
		[FieldOffset(Offset = "0x12C")]
		private float currentFishingProgress;

		// Token: 0x04000FB4 RID: 4020
		[Token(Token = "0x4000FB4")]
		[FieldOffset(Offset = "0x130")]
		private float currentSliderBoxProgress;

		// Token: 0x04000FB5 RID: 4021
		[Token(Token = "0x4000FB5")]
		[FieldOffset(Offset = "0x134")]
		private float currentSpeed;

		// Token: 0x04000FB6 RID: 4022
		[Token(Token = "0x4000FB6")]
		[FieldOffset(Offset = "0x138")]
		private float currentTreasureGetProgress;

		// Token: 0x04000FB7 RID: 4023
		[Token(Token = "0x4000FB7")]
		[FieldOffset(Offset = "0x13C")]
		private float fishingAreaHeight;

		// Token: 0x04000FB8 RID: 4024
		[Token(Token = "0x4000FB8")]
		[FieldOffset(Offset = "0x140")]
		private bool getTreasure;

		// Token: 0x04000FB9 RID: 4025
		[Token(Token = "0x4000FB9")]
		[FieldOffset(Offset = "0x141")]
		private bool hasEnd;

		// Token: 0x04000FBA RID: 4026
		[Token(Token = "0x4000FBA")]
		[FieldOffset(Offset = "0x142")]
		private bool inArea;

		// Token: 0x04000FBB RID: 4027
		[Token(Token = "0x4000FBB")]
		[FieldOffset(Offset = "0x144")]
		private float initialDeterminationPointProgress;

		// Token: 0x04000FBC RID: 4028
		[Token(Token = "0x4000FBC")]
		[FieldOffset(Offset = "0x148")]
		private float initialMoveSpeed;

		// Token: 0x04000FBD RID: 4029
		[Token(Token = "0x4000FBD")]
		[FieldOffset(Offset = "0x14C")]
		private bool isPressed;

		// Token: 0x04000FBE RID: 4030
		[Token(Token = "0x4000FBE")]
		[FieldOffset(Offset = "0x150")]
		private int m_CurrentModeIndex;

		// Token: 0x04000FBF RID: 4031
		[Token(Token = "0x4000FBF")]
		[FieldOffset(Offset = "0x154")]
		private float moveDuration;

		// Token: 0x04000FC0 RID: 4032
		[Token(Token = "0x4000FC0")]
		[FieldOffset(Offset = "0x158")]
		private DLC4_DaySceneFishingQTEPannel.MoveStatus moveStatus;

		// Token: 0x04000FC1 RID: 4033
		[Token(Token = "0x4000FC1")]
		[FieldOffset(Offset = "0x15C")]
		private float needWaitTime;

		// Token: 0x04000FC2 RID: 4034
		[Token(Token = "0x4000FC2")]
		[FieldOffset(Offset = "0x160")]
		private Coroutine onUpdatingData;

		// Token: 0x04000FC3 RID: 4035
		[Token(Token = "0x4000FC3")]
		[FieldOffset(Offset = "0x168")]
		private bool shouldShowTreasure;

		// Token: 0x04000FC4 RID: 4036
		[Token(Token = "0x4000FC4")]
		[FieldOffset(Offset = "0x16C")]
		private float targetFishYPosition;

		// Token: 0x04000FC5 RID: 4037
		[Token(Token = "0x4000FC5")]
		[FieldOffset(Offset = "0x170")]
		private float targetSliderBoxProgress;

		// Token: 0x04000FC6 RID: 4038
		[Token(Token = "0x4000FC6")]
		[FieldOffset(Offset = "0x174")]
		private float timer;

		// Token: 0x04000FC7 RID: 4039
		[Token(Token = "0x4000FC7")]
		[FieldOffset(Offset = "0x178")]
		private float treasurePosition;

		// Token: 0x020002EC RID: 748
		[Token(Token = "0x20002EC")]
		public enum FishingResult
		{
			// Token: 0x04000FCB RID: 4043
			[Token(Token = "0x4000FCB")]
			Fail,
			// Token: 0x04000FCC RID: 4044
			[Token(Token = "0x4000FCC")]
			Success,
			// Token: 0x04000FCD RID: 4045
			[Token(Token = "0x4000FCD")]
			SuccessAndGetTreasure
		}

		// Token: 0x020002ED RID: 749
		[Token(Token = "0x20002ED")]
		public enum FishMoveMode
		{
			// Token: 0x04000FCF RID: 4047
			[Token(Token = "0x4000FCF")]
			[InspectorName("平滑型-简单")]
			Smooth,
			// Token: 0x04000FD0 RID: 4048
			[Token(Token = "0x4000FD0")]
			[InspectorName("混合型-中等")]
			Mixed,
			// Token: 0x04000FD1 RID: 4049
			[Token(Token = "0x4000FD1")]
			[InspectorName("猛冲型-困难")]
			Dart
		}

		// Token: 0x020002EE RID: 750
		[Token(Token = "0x20002EE")]
		[Serializable]
		public struct MoveModeProperty
		{
			// Token: 0x170001AA RID: 426
			// (get) Token: 0x0600110E RID: 4366 RVA: 0x00006B58 File Offset: 0x00004D58
			[Token(Token = "0x170001AA")]
			public DLC4_DaySceneFishingQTEPannel.FishMoveMode FishMoveMode
			{
				[Token(Token = "0x600110E")]
				[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
				get
				{
					return DLC4_DaySceneFishingQTEPannel.FishMoveMode.Smooth;
				}
			}

			// Token: 0x170001AB RID: 427
			// (get) Token: 0x0600110F RID: 4367 RVA: 0x00006B70 File Offset: 0x00004D70
			[Token(Token = "0x170001AB")]
			public Vector2 DisplacementDistance
			{
				[Token(Token = "0x600110F")]
				[Address(RVA = "0x943980", Offset = "0x942380", VA = "0x180943980")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x170001AC RID: 428
			// (get) Token: 0x06001110 RID: 4368 RVA: 0x00006B88 File Offset: 0x00004D88
			[Token(Token = "0x170001AC")]
			public Vector2 DisplacementSpeed
			{
				[Token(Token = "0x6001110")]
				[Address(RVA = "0x9439A0", Offset = "0x9423A0", VA = "0x1809439A0")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x170001AD RID: 429
			// (get) Token: 0x06001111 RID: 4369 RVA: 0x00006BA0 File Offset: 0x00004DA0
			[Token(Token = "0x170001AD")]
			public Vector2 WaitTime
			{
				[Token(Token = "0x6001111")]
				[Address(RVA = "0x9439C0", Offset = "0x9423C0", VA = "0x1809439C0")]
				get
				{
					return default(Vector2);
				}
			}

			// Token: 0x170001AE RID: 430
			// (get) Token: 0x06001112 RID: 4370 RVA: 0x00006BB8 File Offset: 0x00004DB8
			[Token(Token = "0x170001AE")]
			public float Rate
			{
				[Token(Token = "0x6001112")]
				[Address(RVA = "0x43B0A0", Offset = "0x439AA0", VA = "0x18043B0A0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x04000FD2 RID: 4050
			[Token(Token = "0x4000FD2")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private DLC4_DaySceneFishingQTEPannel.FishMoveMode fishMoveMode;

			// Token: 0x04000FD3 RID: 4051
			[Token(Token = "0x4000FD3")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			private Vector2 displacementDistance;

			// Token: 0x04000FD4 RID: 4052
			[Token(Token = "0x4000FD4")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private Vector2 displacementSpeed;

			// Token: 0x04000FD5 RID: 4053
			[Token(Token = "0x4000FD5")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private Vector2 waitTime;

			// Token: 0x04000FD6 RID: 4054
			[Token(Token = "0x4000FD6")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private float rate;
		}

		// Token: 0x020002EF RID: 751
		[Token(Token = "0x20002EF")]
		private enum MoveStatus
		{
			// Token: 0x04000FD8 RID: 4056
			[Token(Token = "0x4000FD8")]
			Moving,
			// Token: 0x04000FD9 RID: 4057
			[Token(Token = "0x4000FD9")]
			Waiting
		}
	}
}
