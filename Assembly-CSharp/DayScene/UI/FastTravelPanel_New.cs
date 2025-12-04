using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common.UI;
using Common.UI.GlobalMap;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020002F3 RID: 755
	[Token(Token = "0x20002F3")]
	[GenerateCleanupMethod]
	public sealed class FastTravelPanel_New : GuideMapPanel<FastTravelPanel_New.FastTravelPanelOpenContext, VoidType>, IExternalPanel
	{
		// Token: 0x06001123 RID: 4387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001123")]
		[Address(RVA = "0x943210", Offset = "0x941C10", VA = "0x180943210", Slot = "46")]
		protected override void OnSecondarySwitchUpdate()
		{
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001124")]
		[Address(RVA = "0x942500", Offset = "0x940F00", VA = "0x180942500", Slot = "34")]
		protected override void OnGuideMapInitialize()
		{
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001125")]
		[Address(RVA = "0x942300", Offset = "0x940D00", VA = "0x180942300", Slot = "47")]
		public void CloseExternPanel()
		{
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001126")]
		[Address(RVA = "0x942420", Offset = "0x940E20", VA = "0x180942420", Slot = "45")]
		protected override void OnGuideMapClose(VoidType voidType)
		{
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001127")]
		[Address(RVA = "0x942780", Offset = "0x941180", VA = "0x180942780", Slot = "36")]
		protected override void OnGuideMapPanelPostOpen(FastTravelPanel_New.FastTravelPanelOpenContext openContext)
		{
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00006BE8 File Offset: 0x00004DE8
		[Token(Token = "0x6001128")]
		[Address(RVA = "0x942340", Offset = "0x940D40", VA = "0x180942340", Slot = "39")]
		protected override bool GetSpotOpenStatus(IGuideMapSpot guideMapSpot)
		{
			return default(bool);
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001129")]
		[Address(RVA = "0x942B10", Offset = "0x941510", VA = "0x180942B10", Slot = "42")]
		protected override void OnGuideMapSpotSelected(IGuideMapSpot guideMapSpot)
		{
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112A")]
		[Address(RVA = "0x943160", Offset = "0x941B60", VA = "0x180943160", Slot = "44")]
		protected override void OnGuideMapSpotSubmit(IGuideMapSpot guideMapSpot)
		{
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00006C00 File Offset: 0x00004E00
		[Token(Token = "0x600112B")]
		[Address(RVA = "0x942F80", Offset = "0x941980", VA = "0x180942F80")]
		private UniTask OnGuideMapSpotSubmitAsync(IGuideMapSpot guideMapSpot)
		{
			return default(UniTask);
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00006C18 File Offset: 0x00004E18
		[Token(Token = "0x600112C")]
		[Address(RVA = "0x942390", Offset = "0x940D90", VA = "0x180942390", Slot = "41")]
		protected override bool? IsFirstToSelectSpot(IGuideMapSpot guideMapSpot)
		{
			return null;
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112D")]
		[Address(RVA = "0x942210", Offset = "0x940C10", VA = "0x180942210", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600112E")]
		[Address(RVA = "0x9432C0", Offset = "0x941CC0", VA = "0x1809432C0")]
		public FastTravelPanel_New()
		{
		}

		// Token: 0x04000FE8 RID: 4072
		[Token(Token = "0x4000FE8")]
		public const string YUKARI_TELEPORT_EVENT_ID = "Special_HakureiMoneyBox_Yukari_Event";

		// Token: 0x04000FE9 RID: 4073
		[Token(Token = "0x4000FE9")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private Image m_PlayerCurrentPosition;

		// Token: 0x04000FEA RID: 4074
		[Token(Token = "0x4000FEA")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private FastTravelPanel_TimeIndicator m_TimeIndicator;

		// Token: 0x04000FEB RID: 4075
		[Token(Token = "0x4000FEB")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private DaySceneFastTravelSubPannel m_SubPanel;

		// Token: 0x04000FEC RID: 4076
		[Token(Token = "0x4000FEC")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private DaySceneMapDescriber m_MapDescriber;

		// Token: 0x04000FED RID: 4077
		[Token(Token = "0x4000FED")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private int m_UnitPriceForTeleport;

		// Token: 0x04000FEE RID: 4078
		[Token(Token = "0x4000FEE")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private FastTravelPanel_New.FloatMenuModifier[] m_FloatMenuModifiers;

		// Token: 0x04000FEF RID: 4079
		[Token(Token = "0x4000FEF")]
		[FieldOffset(Offset = "0x180")]
		[SerializeField]
		private CanvasGroup m_MainContent;

		// Token: 0x04000FF0 RID: 4080
		[Token(Token = "0x4000FF0")]
		[FieldOffset(Offset = "0x188")]
		private IGuideMapSpot m_CurrentSpot;

		// Token: 0x04000FF1 RID: 4081
		[Token(Token = "0x4000FF1")]
		[FieldOffset(Offset = "0x190")]
		private DaySceneFastTravelSubPannel.OpenContext m_CachedOpenContext;

		// Token: 0x04000FF2 RID: 4082
		[Token(Token = "0x4000FF2")]
		[FieldOffset(Offset = "0x1A0")]
		private TimeIndicatorContext m_CachedTimeIndicatorContext;

		// Token: 0x04000FF3 RID: 4083
		[Token(Token = "0x4000FF3")]
		[FieldOffset(Offset = "0x1C0")]
		private Dictionary<IGuideMapSpot, Vector2> m_FloatMenuModifierDictionary;

		// Token: 0x020002F4 RID: 756
		[Token(Token = "0x20002F4")]
		public struct FastTravelPanelOpenContext
		{
			// Token: 0x170001B1 RID: 433
			// (get) Token: 0x06001130 RID: 4400 RVA: 0x00006C30 File Offset: 0x00004E30
			[Token(Token = "0x170001B1")]
			public readonly bool IsOpenThroughYukariTeleport
			{
				[Token(Token = "0x6001130")]
				[Address(RVA = "0x942200", Offset = "0x940C00", VA = "0x180942200")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170001B2 RID: 434
			// (get) Token: 0x06001131 RID: 4401 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170001B2")]
			public readonly Predicate<IGuideMapSpot> GetFirstToSelectNodeHandler
			{
				[Token(Token = "0x6001131")]
				[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06001132 RID: 4402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001132")]
			[Address(RVA = "0x9421E0", Offset = "0x940BE0", VA = "0x1809421E0")]
			public FastTravelPanelOpenContext(bool isOpenThroughYukariTeleport, Predicate<IGuideMapSpot> getFirstToSelectNodeHandler)
			{
			}
		}

		// Token: 0x020002F5 RID: 757
		[Token(Token = "0x20002F5")]
		[Serializable]
		public struct FloatMenuModifier
		{
			// Token: 0x04000FF6 RID: 4086
			[Token(Token = "0x4000FF6")]
			[FieldOffset(Offset = "0x0")]
			public GuideMapSpot GuideMapSpot;

			// Token: 0x04000FF7 RID: 4087
			[Token(Token = "0x4000FF7")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 OverrideOffset;
		}
	}
}
