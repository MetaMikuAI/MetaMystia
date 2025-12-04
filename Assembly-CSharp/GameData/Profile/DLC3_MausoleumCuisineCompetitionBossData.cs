using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using NightScene;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C10 RID: 3088
	[Token(Token = "0x2000C10")]
	[CreateAssetMenu(fileName = "DLC3_MausoleumCuisineCompetitionBossData", menuName = "GameData Profile/BossData/DLC3_MausoleumCuisineCompetitionBossData", order = 6)]
	public class DLC3_MausoleumCuisineCompetitionBossData : BossData
	{
		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06004860 RID: 18528 RVA: 0x0001A1F0 File Offset: 0x000183F0
		[Token(Token = "0x17000A8A")]
		private DLC3_MausoleumCuisineCompetitionBossData.ChallengeTime challengeTime
		{
			[Token(Token = "0x6004860")]
			[Address(RVA = "0x74FD20", Offset = "0x74E720", VA = "0x18074FD20")]
			get
			{
				return DLC3_MausoleumCuisineCompetitionBossData.ChallengeTime.First;
			}
		}

		// Token: 0x06004861 RID: 18529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004861")]
		[Address(RVA = "0x74F6F0", Offset = "0x74E0F0", VA = "0x18074F6F0")]
		private void OnPreloadGeneralChallenge()
		{
		}

		// Token: 0x06004862 RID: 18530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004862")]
		[Address(RVA = "0x74F2D0", Offset = "0x74DCD0", VA = "0x18074F2D0", Slot = "4")]
		public override void GotoBossChallengeScene()
		{
		}

		// Token: 0x06004863 RID: 18531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004863")]
		[Address(RVA = "0x74F6D0", Offset = "0x74E0D0", VA = "0x18074F6D0")]
		private void OnChallengeEnd()
		{
		}

		// Token: 0x06004864 RID: 18532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004864")]
		[Address(RVA = "0x74F870", Offset = "0x74E270", VA = "0x18074F870")]
		private IEnumerator P1Start(DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType)
		{
			return null;
		}

		// Token: 0x06004865 RID: 18533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004865")]
		[Address(RVA = "0x74F7D0", Offset = "0x74E1D0", VA = "0x18074F7D0")]
		private IEnumerator P1End(bool isSucceed, DLC3_MausoleumCuisineCompetitionBossData.PartnerType partnerType)
		{
			return null;
		}

		// Token: 0x06004866 RID: 18534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004866")]
		[Address(RVA = "0x74F9B0", Offset = "0x74E3B0", VA = "0x18074F9B0")]
		private IEnumerator P2Start(DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType)
		{
			return null;
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004867")]
		[Address(RVA = "0x74F900", Offset = "0x74E300", VA = "0x18074F900")]
		private IEnumerator P2End(bool previousSucceed, bool currentSucceed, DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType)
		{
			return null;
		}

		// Token: 0x06004868 RID: 18536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004868")]
		[Address(RVA = "0x74FB00", Offset = "0x74E500", VA = "0x18074FB00")]
		private IEnumerator P3Start(DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType)
		{
			return null;
		}

		// Token: 0x06004869 RID: 18537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004869")]
		[Address(RVA = "0x74FA40", Offset = "0x74E440", VA = "0x18074FA40")]
		private IEnumerator P3End(bool firstSucceed, bool secondSucceed, bool currentSucceed, DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType)
		{
			return null;
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600486A")]
		[Address(RVA = "0x74FB90", Offset = "0x74E590", VA = "0x18074FB90")]
		private IEnumerator PhaseStart(DLC3_MausoleumCuisineCompetitionBossData.PartnerType selectedPartnerType, DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage characterSelectDialog, DialogPackage startPackage)
		{
			return null;
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600486B")]
		[Address(RVA = "0x74F610", Offset = "0x74E010", VA = "0x18074F610", Slot = "5")]
		public override IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			return null;
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600486C")]
		[Address(RVA = "0x74FC40", Offset = "0x74E640", VA = "0x18074FC40")]
		public DLC3_MausoleumCuisineCompetitionBossData()
		{
		}

		// Token: 0x040041A5 RID: 16805
		[Token(Token = "0x40041A5")]
		private const string P1TrackedInteractableKey = "DLC3_MausoleumCuisineCompetition_Result_P1";

		// Token: 0x040041A6 RID: 16806
		[Token(Token = "0x40041A6")]
		private const string P2TrackedInteractableKey = "DLC3_MausoleumCuisineCompetition_Result_P2";

		// Token: 0x040041A7 RID: 16807
		[Token(Token = "0x40041A7")]
		[FieldOffset(Offset = "0x30")]
		public string finalMissionKey;

		// Token: 0x040041A8 RID: 16808
		[Token(Token = "0x40041A8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Header("- General Trial Challenge Boss Data")]
		protected int singleRoundDuration;

		// Token: 0x040041A9 RID: 16809
		[Token(Token = "0x40041A9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int[] izakayaIndexes;

		// Token: 0x040041AA RID: 16810
		[Token(Token = "0x40041AA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2Int baseFundRange;

		// Token: 0x040041AB RID: 16811
		[Token(Token = "0x40041AB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector2Int normalGuestInterval;

		// Token: 0x040041AC RID: 16812
		[Token(Token = "0x40041AC")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float specialGuestGachaInterval;

		// Token: 0x040041AD RID: 16813
		[Token(Token = "0x40041AD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Header("目标BossId")]
		private DLC3_MausoleumCuisineCompetitionBossData.BossMapping[] allBosses;

		// Token: 0x040041AE RID: 16814
		[Token(Token = "0x40041AE")]
		[FieldOffset(Offset = "0x68")]
		[Header("已被占领的桌子的图标")]
		[SerializeField]
		private GameObject mystiaIcon;

		// Token: 0x040041AF RID: 16815
		[Token(Token = "0x40041AF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector2 offset;

		// Token: 0x040041B0 RID: 16816
		[Token(Token = "0x40041B0")]
		[FieldOffset(Offset = "0x78")]
		[Header("伙伴能力对应")]
		[SerializeField]
		private DLC3_MausoleumCuisineCompetitionBossData.PartnerAbilityMapping[] allPartnerQTERewards;

		// Token: 0x040041B1 RID: 16817
		[Token(Token = "0x40041B1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Header("P1挑战对话")]
		private DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase1_CharSelect;

		// Token: 0x040041B2 RID: 16818
		[Token(Token = "0x40041B2")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private DialogPackage m_Phase1_Start;

		// Token: 0x040041B3 RID: 16819
		[Token(Token = "0x40041B3")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private DialogPackage m_Phase1_Succeed;

		// Token: 0x040041B4 RID: 16820
		[Token(Token = "0x40041B4")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase1_Succeed_Char;

		// Token: 0x040041B5 RID: 16821
		[Token(Token = "0x40041B5")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private DialogPackage m_Phase1_Failed;

		// Token: 0x040041B6 RID: 16822
		[Token(Token = "0x40041B6")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase1_Failed_Char;

		// Token: 0x040041B7 RID: 16823
		[Token(Token = "0x40041B7")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private string m_Phase1_NextEventLabel;

		// Token: 0x040041B8 RID: 16824
		[Token(Token = "0x40041B8")]
		[FieldOffset(Offset = "0xE8")]
		[Header("P2挑战对话")]
		[SerializeField]
		private DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase2_CharSelect;

		// Token: 0x040041B9 RID: 16825
		[Token(Token = "0x40041B9")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private DialogPackage m_Phase2_Start;

		// Token: 0x040041BA RID: 16826
		[Token(Token = "0x40041BA")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private DialogPackage m_Phase2_Succeed;

		// Token: 0x040041BB RID: 16827
		[Token(Token = "0x40041BB")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase2_Succeed_Char;

		// Token: 0x040041BC RID: 16828
		[Token(Token = "0x40041BC")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private DialogPackage m_Phase2_Failed;

		// Token: 0x040041BD RID: 16829
		[Token(Token = "0x40041BD")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase2_Failed_Char;

		// Token: 0x040041BE RID: 16830
		[Token(Token = "0x40041BE")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private DialogPackage m_Phase2_DoubleSucceed;

		// Token: 0x040041BF RID: 16831
		[Token(Token = "0x40041BF")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		private DialogPackage m_Phase2_DoubleFailed;

		// Token: 0x040041C0 RID: 16832
		[Token(Token = "0x40041C0")]
		[FieldOffset(Offset = "0x158")]
		[SerializeField]
		private string m_Phase2_DoubleSucceed_EventLabel;

		// Token: 0x040041C1 RID: 16833
		[Token(Token = "0x40041C1")]
		[FieldOffset(Offset = "0x160")]
		[SerializeField]
		private string m_Phase2_DoubleFailed_EventLabel;

		// Token: 0x040041C2 RID: 16834
		[Token(Token = "0x40041C2")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private string m_Phase2_NextEventLabel;

		// Token: 0x040041C3 RID: 16835
		[Token(Token = "0x40041C3")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		[Header("P3挑战对话")]
		private DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase3_CharSelect;

		// Token: 0x040041C4 RID: 16836
		[Token(Token = "0x40041C4")]
		[FieldOffset(Offset = "0x188")]
		[SerializeField]
		private DialogPackage m_Phase3_Start;

		// Token: 0x040041C5 RID: 16837
		[Token(Token = "0x40041C5")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private DialogPackage m_Phase3_SucceedA;

		// Token: 0x040041C6 RID: 16838
		[Token(Token = "0x40041C6")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		private DialogPackage m_Phase3_SucceedB;

		// Token: 0x040041C7 RID: 16839
		[Token(Token = "0x40041C7")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		private DialogPackage m_Phase3_Add_FailedA;

		// Token: 0x040041C8 RID: 16840
		[Token(Token = "0x40041C8")]
		[FieldOffset(Offset = "0x1A8")]
		[SerializeField]
		private DialogPackage m_Phase3_Add_FailedB;

		// Token: 0x040041C9 RID: 16841
		[Token(Token = "0x40041C9")]
		[FieldOffset(Offset = "0x1B0")]
		[SerializeField]
		private DialogPackage m_Phase3_Failed;

		// Token: 0x040041CA RID: 16842
		[Token(Token = "0x40041CA")]
		[FieldOffset(Offset = "0x1B8")]
		[SerializeField]
		private DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase3_Failed_Char;

		// Token: 0x040041CB RID: 16843
		[Token(Token = "0x40041CB")]
		[FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		private DLC3_MausoleumCuisineCompetitionBossData.CharacterSpecificDialogPackage m_Phase3_Add_Failed_Char;

		// Token: 0x040041CC RID: 16844
		[Token(Token = "0x40041CC")]
		[FieldOffset(Offset = "0x1E8")]
		public DLC3_BossBattleEmployeeSelectorPannel bossBattleEmployeeSelectorPannel;

		// Token: 0x040041CD RID: 16845
		[Token(Token = "0x40041CD")]
		[FieldOffset(Offset = "0x1F0")]
		public DLC3_BossBattleResultPannel bossBattleResultPannel;

		// Token: 0x040041CE RID: 16846
		[Token(Token = "0x40041CE")]
		[FieldOffset(Offset = "0x1F8")]
		public float springMovementSpeedMultiplier;

		// Token: 0x040041CF RID: 16847
		[Token(Token = "0x40041CF")]
		[FieldOffset(Offset = "0x200")]
		private readonly Dictionary<int, ValueTuple<int, GameObject>> iconDic;

		// Token: 0x040041D0 RID: 16848
		[Token(Token = "0x40041D0")]
		[FieldOffset(Offset = "0x208")]
		private Dictionary<NightSceneDirector.ChallengeType, DLC3_MausoleumCuisineCompetitionBossData.BossMapping> bossMapping;

		// Token: 0x040041D1 RID: 16849
		[Token(Token = "0x40041D1")]
		[FieldOffset(Offset = "0x210")]
		private Action onChallengeEnd;

		// Token: 0x02000C11 RID: 3089
		[Token(Token = "0x2000C11")]
		public enum ChallengeTime
		{
			// Token: 0x040041D3 RID: 16851
			[Token(Token = "0x40041D3")]
			First,
			// Token: 0x040041D4 RID: 16852
			[Token(Token = "0x40041D4")]
			Second,
			// Token: 0x040041D5 RID: 16853
			[Token(Token = "0x40041D5")]
			Third
		}

		// Token: 0x02000C12 RID: 3090
		[Token(Token = "0x2000C12")]
		public enum PartnerType
		{
			// Token: 0x040041D7 RID: 16855
			[Token(Token = "0x40041D7")]
			Mystia = -1,
			// Token: 0x040041D8 RID: 16856
			[Token(Token = "0x40041D8")]
			Kyouko = 14,
			// Token: 0x040041D9 RID: 16857
			[Token(Token = "0x40041D9")]
			Kosuzu = 18,
			// Token: 0x040041DA RID: 16858
			[Token(Token = "0x40041DA")]
			Aunn
		}

		// Token: 0x02000C13 RID: 3091
		[Token(Token = "0x2000C13")]
		[Serializable]
		public struct BossMapping
		{
			// Token: 0x040041DB RID: 16859
			[Token(Token = "0x40041DB")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public NightSceneDirector.ChallengeType challengType;

			// Token: 0x040041DC RID: 16860
			[Token(Token = "0x40041DC")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public int targetBossId;

			// Token: 0x040041DD RID: 16861
			[Token(Token = "0x40041DD")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public GameObject bossDeskIcon;

			// Token: 0x040041DE RID: 16862
			[Token(Token = "0x40041DE")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public int lockPassion;
		}

		// Token: 0x02000C14 RID: 3092
		[Token(Token = "0x2000C14")]
		[Serializable]
		public struct PartnerAbilityMapping
		{
			// Token: 0x040041DF RID: 16863
			[Token(Token = "0x40041DF")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public int partnerId;

			// Token: 0x040041E0 RID: 16864
			[Token(Token = "0x40041E0")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public Sprite overridePortrayal;

			// Token: 0x040041E1 RID: 16865
			[Token(Token = "0x40041E1")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public float speedMultipier;

			// Token: 0x040041E2 RID: 16866
			[Token(Token = "0x40041E2")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			public float cookSpeedMultipier;

			// Token: 0x040041E3 RID: 16867
			[Token(Token = "0x40041E3")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public QTEBuffReward partnerAbilityReward;

			// Token: 0x040041E4 RID: 16868
			[Token(Token = "0x40041E4")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			public Vector2 offset;

			// Token: 0x040041E5 RID: 16869
			[Token(Token = "0x40041E5")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			public DLC3_MausoleumCuisineCompetitionBossData.PartnerType partnerType;
		}

		// Token: 0x02000C15 RID: 3093
		[Token(Token = "0x2000C15")]
		[Serializable]
		public struct CharacterSpecificDialogPackage
		{
			// Token: 0x0600486D RID: 18541 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600486D")]
			[Address(RVA = "0x74F240", Offset = "0x74DC40", VA = "0x18074F240")]
			public IEnumerator PlayDialog(DLC3_MausoleumCuisineCompetitionBossData.PartnerType partnerType)
			{
				return null;
			}

			// Token: 0x040041E6 RID: 16870
			[Token(Token = "0x40041E6")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private DialogPackage Mystia;

			// Token: 0x040041E7 RID: 16871
			[Token(Token = "0x40041E7")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private DialogPackage Kosuzu;

			// Token: 0x040041E8 RID: 16872
			[Token(Token = "0x40041E8")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private DialogPackage Aunn;
		}
	}
}
