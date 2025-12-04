using System;
using GameData;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200039F RID: 927
	[Token(Token = "0x200039F")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeDataProfileUnChangeable", menuName = "GameData Profile/Rogue Like Data Profile Unchangeable", order = 0)]
	public class DLC5_RogueLikeDataProfileUnchangeable : ScriptableObject
	{
		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000266")]
		public DLC5_RogueLikePoolResultPanel RoguelikePoolEditMessagePanel
		{
			[Token(Token = "0x6001483")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000267")]
		public DLC5_RogueLikePoolViewerPanel RoguelikePoolViewerPanel
		{
			[Token(Token = "0x6001484")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000268")]
		public AssetReference RoguelikeTutorialPanel
		{
			[Token(Token = "0x6001485")]
			[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000269")]
		public AssetReference RogueLikeCardScorePanel
		{
			[Token(Token = "0x6001486")]
			[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026A")]
		public DLC5_RogueLikeCardSelectorPanel CardSelectorPanel
		{
			[Token(Token = "0x6001487")]
			[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026B")]
		public RogueLikeCard[] Cards
		{
			[Token(Token = "0x6001488")]
			[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026C")]
		public MultiLanguageTextMesh.MultiLanguageTextAsset CardDescriptionLang
		{
			[Token(Token = "0x6001489")]
			[Address(RVA = "0x440270", Offset = "0x43EC70", VA = "0x180440270")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x0600148A RID: 5258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700026D")]
		public RogueLikeCardPersistent[] CardsPersistent
		{
			[Token(Token = "0x600148A")]
			[Address(RVA = "0x440290", Offset = "0x43EC90", VA = "0x180440290")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600148B RID: 5259 RVA: 0x00007F08 File Offset: 0x00006108
		[Token(Token = "0x1700026E")]
		public float RecipeCollectRateWeight
		{
			[Token(Token = "0x600148B")]
			[Address(RVA = "0x440310", Offset = "0x43ED10", VA = "0x180440310")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600148C RID: 5260 RVA: 0x00007F20 File Offset: 0x00006120
		[Token(Token = "0x1700026F")]
		public float ItemCollectRateWeight
		{
			[Token(Token = "0x600148C")]
			[Address(RVA = "0x4402D0", Offset = "0x43ECD0", VA = "0x1804402D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600148D RID: 5261 RVA: 0x00007F38 File Offset: 0x00006138
		[Token(Token = "0x17000270")]
		public float PartnerCollectRateWeight
		{
			[Token(Token = "0x600148D")]
			[Address(RVA = "0x4402F0", Offset = "0x43ECF0", VA = "0x1804402F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x00007F50 File Offset: 0x00006150
		[Token(Token = "0x17000271")]
		public float IzakayaCollectRateWeight
		{
			[Token(Token = "0x600148E")]
			[Address(RVA = "0x4402E0", Offset = "0x43ECE0", VA = "0x1804402E0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600148F RID: 5263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000272")]
		public DLC5_RogueLikeDataProfile.RogueLikeAchievement[] RogueLikeAchievements
		{
			[Token(Token = "0x600148F")]
			[Address(RVA = "0x440320", Offset = "0x43ED20", VA = "0x180440320")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000273")]
		public Vector2Int[] PartnerPrice
		{
			[Token(Token = "0x6001490")]
			[Address(RVA = "0x440300", Offset = "0x43ED00", VA = "0x180440300")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06001491 RID: 5265 RVA: 0x00007F68 File Offset: 0x00006168
		[Token(Token = "0x17000274")]
		public int FirstRefreshCardPrice
		{
			[Token(Token = "0x6001491")]
			[Address(RVA = "0x3EBDA0", Offset = "0x3EA7A0", VA = "0x1803EBDA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000275")]
		public RogueLikeRunTimeData.EliteChallengeBase[] EliteChallengeProfiles
		{
			[Token(Token = "0x6001492")]
			[Address(RVA = "0x4402B0", Offset = "0x43ECB0", VA = "0x1804402B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06001493 RID: 5267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000276")]
		public DLC5_RogueLikeEliteRewardSelectionPanel EliteRewardSelectionPanel
		{
			[Token(Token = "0x6001493")]
			[Address(RVA = "0x4402C0", Offset = "0x43ECC0", VA = "0x1804402C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001494")]
		[Address(RVA = "0x440240", Offset = "0x43EC40", VA = "0x180440240")]
		public DLC5_RogueLikeDataProfileUnchangeable()
		{
		}

		// Token: 0x04001329 RID: 4905
		[Token(Token = "0x4001329")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DLC5_RogueLikePoolResultPanel m_RoguelikePoolEditMessagePanel;

		// Token: 0x0400132A RID: 4906
		[Token(Token = "0x400132A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DLC5_RogueLikePoolViewerPanel m_RoguelikePoolViewerPanel;

		// Token: 0x0400132B RID: 4907
		[Token(Token = "0x400132B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AssetReference m_RogueLikeCardScorePanel;

		// Token: 0x0400132C RID: 4908
		[Token(Token = "0x400132C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AssetReference m_RoguelikeTutorialPanel;

		// Token: 0x0400132D RID: 4909
		[Token(Token = "0x400132D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DLC5_RogueLikeCardSelectorPanel m_CardSelectorPanel;

		// Token: 0x0400132E RID: 4910
		[Token(Token = "0x400132E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RogueLikeCard[] m_Cards;

		// Token: 0x0400132F RID: 4911
		[Token(Token = "0x400132F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RogueLikeCardPersistent[] m_CardsPersistent;

		// Token: 0x04001330 RID: 4912
		[Token(Token = "0x4001330")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MultiLanguageTextMesh.MultiLanguageTextAsset m_CardDescriptionLang;

		// Token: 0x04001331 RID: 4913
		[Token(Token = "0x4001331")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_RecipeCollectRateWeight;

		// Token: 0x04001332 RID: 4914
		[Token(Token = "0x4001332")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_ItemCollectRateWeight;

		// Token: 0x04001333 RID: 4915
		[Token(Token = "0x4001333")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_PartnerCollectRateWeight;

		// Token: 0x04001334 RID: 4916
		[Token(Token = "0x4001334")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_IzakayaCollectRateWeight;

		// Token: 0x04001335 RID: 4917
		[Token(Token = "0x4001335")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Vector2Int[] m_PartnerPrice;

		// Token: 0x04001336 RID: 4918
		[Token(Token = "0x4001336")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int m_FirstRefreshCardPrice;

		// Token: 0x04001337 RID: 4919
		[Token(Token = "0x4001337")]
		[FieldOffset(Offset = "0x78")]
		[Header("徽章")]
		[SerializeField]
		private DLC5_RogueLikeDataProfile.RogueLikeAchievement[] m_RogueLikeAchievements;

		// Token: 0x04001338 RID: 4920
		[Token(Token = "0x4001338")]
		[FieldOffset(Offset = "0x80")]
		[Header("Boss挑战")]
		[SerializeField]
		private RogueLikeRunTimeData.EliteChallengeBase[] m_EliteChallengeProfiles;

		// Token: 0x04001339 RID: 4921
		[Token(Token = "0x4001339")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private DLC5_RogueLikeEliteRewardSelectionPanel m_EliteRewardSelectionPanel;
	}
}
