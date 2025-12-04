using System;
using System.Collections;
using System.Collections.Generic;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;
using Night.BossBattle.DLC4_BossBattle;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.HUDUtility
{
	// Token: 0x020006D4 RID: 1748
	[Token(Token = "0x20006D4")]
	[GenerateCleanupMethod]
	public class IncomeControllerFlandre : IncomeControllerBase
	{
		// Token: 0x0600296C RID: 10604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296C")]
		[Address(RVA = "0x548E50", Offset = "0x547850", VA = "0x180548E50")]
		public void OnDestroy()
		{
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296D")]
		[Address(RVA = "0x548790", Offset = "0x547190", VA = "0x180548790", Slot = "4")]
		public override void Initialize()
		{
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296E")]
		[Address(RVA = "0x549410", Offset = "0x547E10", VA = "0x180549410")]
		public void SetManager(DLC4_BossBattleManager manager)
		{
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600296F")]
		[Address(RVA = "0x5495C0", Offset = "0x547FC0", VA = "0x1805495C0")]
		public void SetTargetProgress(int targetValue)
		{
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002970")]
		[Address(RVA = "0x5486F0", Offset = "0x5470F0", VA = "0x1805486F0")]
		public void FinishBigWave()
		{
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002971")]
		[Address(RVA = "0x549490", Offset = "0x547E90", VA = "0x180549490")]
		public void SetTargetProgressImmediate(int targetValue)
		{
		}

		// Token: 0x06002972 RID: 10610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002972")]
		[Address(RVA = "0x549950", Offset = "0x548350", VA = "0x180549950")]
		private void TryUpdateData()
		{
		}

		// Token: 0x06002973 RID: 10611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002973")]
		[Address(RVA = "0x549AF0", Offset = "0x5484F0", VA = "0x180549AF0")]
		private void UpdateVisual()
		{
		}

		// Token: 0x06002974 RID: 10612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002974")]
		[Address(RVA = "0x548ED0", Offset = "0x5478D0", VA = "0x180548ED0")]
		private IEnumerator OnUpdateFund()
		{
			return null;
		}

		// Token: 0x06002975 RID: 10613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002975")]
		[Address(RVA = "0x5490D0", Offset = "0x547AD0", VA = "0x1805490D0")]
		public void SetFlags(int flagNum)
		{
		}

		// Token: 0x06002976 RID: 10614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002976")]
		[Address(RVA = "0x549250", Offset = "0x547C50", VA = "0x180549250")]
		public void SetFlandreNum(int num)
		{
		}

		// Token: 0x06002977 RID: 10615 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		[Token(Token = "0x6002977")]
		[Address(RVA = "0x5496A0", Offset = "0x5480A0", VA = "0x1805496A0")]
		public IncomeControllerFlandre.FlandreBossHPContext SpawnBossHpContext(DLC4_FlandreEnemyCharacterController flandreEnemyCharacterController)
		{
			return default(IncomeControllerFlandre.FlandreBossHPContext);
		}

		// Token: 0x06002978 RID: 10616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002978")]
		[Address(RVA = "0x548D70", Offset = "0x547770", VA = "0x180548D70")]
		public void OnBossDie(IncomeControllerFlandre.FlandreBossHPContext flandreBossHpContext)
		{
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002979")]
		[Address(RVA = "0x549440", Offset = "0x547E40", VA = "0x180549440")]
		public void SetPPoint(int currentPPoint)
		{
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297A")]
		[Address(RVA = "0x549A40", Offset = "0x548440", VA = "0x180549A40")]
		public void TryUpdateVisualInIndicatorBegin()
		{
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297B")]
		[Address(RVA = "0x549A10", Offset = "0x548410", VA = "0x180549A10")]
		public void TryUpdateVisualInIndicatorAfter()
		{
		}

		// Token: 0x0600297C RID: 10620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297C")]
		[Address(RVA = "0x549000", Offset = "0x547A00", VA = "0x180549000")]
		public void SetCoolDown(int poolId, float progress)
		{
		}

		// Token: 0x0600297D RID: 10621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297D")]
		[Address(RVA = "0x548F50", Offset = "0x547950", VA = "0x180548F50")]
		public void PatchouliMagicStartCoolDown(bool showEndVFX, bool lastCard)
		{
		}

		// Token: 0x0600297E RID: 10622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297E")]
		[Address(RVA = "0x549270", Offset = "0x547C70", VA = "0x180549270")]
		public void SetMagicProgress(float newProgress)
		{
		}

		// Token: 0x0600297F RID: 10623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600297F")]
		[Address(RVA = "0x548500", Offset = "0x546F00", VA = "0x180548500", Slot = "5")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06002980 RID: 10624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002980")]
		[Address(RVA = "0x549DC0", Offset = "0x5487C0", VA = "0x180549DC0")]
		public IncomeControllerFlandre()
		{
		}

		// Token: 0x040025D5 RID: 9685
		[Token(Token = "0x40025D5")]
		private const int CHANGE_AMOUNT = 5;

		// Token: 0x040025D6 RID: 9686
		[Token(Token = "0x40025D6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject m_Flag;

		// Token: 0x040025D7 RID: 9687
		[Token(Token = "0x40025D7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform m_FlagContent;

		// Token: 0x040025D8 RID: 9688
		[Token(Token = "0x40025D8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image progressBar1;

		// Token: 0x040025D9 RID: 9689
		[Token(Token = "0x40025D9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image progressBar2;

		// Token: 0x040025DA RID: 9690
		[Token(Token = "0x40025DA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image timeBar;

		// Token: 0x040025DB RID: 9691
		[Token(Token = "0x40025DB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ComboController remainingFlandreNum;

		// Token: 0x040025DC RID: 9692
		[Token(Token = "0x40025DC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TextMeshProUGUI progressLiteral;

		// Token: 0x040025DD RID: 9693
		[Token(Token = "0x40025DD")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TextMeshProUGUI pPoint;

		// Token: 0x040025DE RID: 9694
		[Token(Token = "0x40025DE")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject m_FlandreHPContext;

		// Token: 0x040025DF RID: 9695
		[Token(Token = "0x40025DF")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector2 m_FlandreBossHpOffset;

		// Token: 0x040025E0 RID: 9696
		[Token(Token = "0x40025E0")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform m_WaitFlandreHPContent;

		// Token: 0x040025E1 RID: 9697
		[Token(Token = "0x40025E1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private IncomeControllerFlandre_CardRechargeIndicator m_CardRechargeIndicator;

		// Token: 0x040025E2 RID: 9698
		[Token(Token = "0x40025E2")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup m_MagicProgressCanvasGroup;

		// Token: 0x040025E3 RID: 9699
		[Token(Token = "0x40025E3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image m_MagicProgress;

		// Token: 0x040025E4 RID: 9700
		[Token(Token = "0x40025E4")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject m_MagicVFXObject;

		// Token: 0x040025E5 RID: 9701
		[Token(Token = "0x40025E5")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject m_MagicEndVFXObject;

		// Token: 0x040025E6 RID: 9702
		[Token(Token = "0x40025E6")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RectTransform m_MagicPosition;

		// Token: 0x040025E7 RID: 9703
		[Token(Token = "0x40025E7")]
		[FieldOffset(Offset = "0xA0")]
		private readonly Queue<CanvasGroup> flagCanvasGroupQueue;

		// Token: 0x040025E8 RID: 9704
		[Token(Token = "0x40025E8")]
		[FieldOffset(Offset = "0xA8")]
		private readonly List<IncomeControllerFlandre.FlandreBossHPContext> flandreBossHpContexts;

		// Token: 0x040025E9 RID: 9705
		[Token(Token = "0x40025E9")]
		[FieldOffset(Offset = "0xB0")]
		private readonly List<RechargeInfo> m_CardRechargeLists;

		// Token: 0x040025EA RID: 9706
		[Token(Token = "0x40025EA")]
		[FieldOffset(Offset = "0xB8")]
		private int currentProgress;

		// Token: 0x040025EB RID: 9707
		[Token(Token = "0x40025EB")]
		[FieldOffset(Offset = "0xC0")]
		private ParticleSystem m_MagicEndVFX;

		// Token: 0x040025EC RID: 9708
		[Token(Token = "0x40025EC")]
		[FieldOffset(Offset = "0xC8")]
		private ParticleSystem m_MagicVFX;

		// Token: 0x040025ED RID: 9709
		[Token(Token = "0x40025ED")]
		[FieldOffset(Offset = "0xD0")]
		private Coroutine onUpdatingData;

		// Token: 0x040025EE RID: 9710
		[Token(Token = "0x40025EE")]
		[FieldOffset(Offset = "0xD8")]
		private int targetProgress;

		// Token: 0x020006D5 RID: 1749
		[Token(Token = "0x20006D5")]
		public struct FlandreBossHPContext
		{
			// Token: 0x170005D1 RID: 1489
			// (get) Token: 0x06002984 RID: 10628 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170005D1")]
			public GameObject ContextObject
			{
				[Token(Token = "0x6002984")]
				[Address(RVA = "0x547080", Offset = "0x545A80", VA = "0x180547080")]
				get
				{
					return null;
				}
			}

			// Token: 0x06002985 RID: 10629 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002985")]
			[Address(RVA = "0x3EC190", Offset = "0x3EAB90", VA = "0x1803EC190")]
			public FlandreBossHPContext(UIElementCluster cluster)
			{
			}

			// Token: 0x06002986 RID: 10630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002986")]
			[Address(RVA = "0x546FA0", Offset = "0x5459A0", VA = "0x180546FA0")]
			public void SetHP(float currentProgress)
			{
			}

			// Token: 0x06002987 RID: 10631 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002987")]
			[Address(RVA = "0x546E80", Offset = "0x545880", VA = "0x180546E80")]
			public void OnBossDie(Action onFinish)
			{
			}

			// Token: 0x06002988 RID: 10632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002988")]
			[Address(RVA = "0x546F50", Offset = "0x545950", VA = "0x180546F50")]
			public void OnBossSpawn()
			{
			}

			// Token: 0x040025EF RID: 9711
			[Token(Token = "0x40025EF")]
			[FieldOffset(Offset = "0x0")]
			private readonly UIElementCluster cluster;
		}
	}
}
