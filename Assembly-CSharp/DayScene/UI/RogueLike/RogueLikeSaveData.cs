using System;
using System.Collections.Generic;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using Newtonsoft.Json;
using NightScene;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000466 RID: 1126
	[Token(Token = "0x2000466")]
	[JsonObject(MemberSerialization.OptIn)]
	public struct RogueLikeSaveData : IDeepClonable<RogueLikeSaveData>
	{
		// Token: 0x060019FB RID: 6651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019FB")]
		[Address(RVA = "0x48B2F0", Offset = "0x489CF0", VA = "0x18048B2F0")]
		[JsonConstructor]
		public RogueLikeSaveData(string fileVersion, NightSceneDirector.Difficulty difficulty, string currentMapName, string currentMapNameLang, Product[] generatedProducts, Dictionary<string, UnlockedIzakayaInfo> unlockedSpots, HashSet<string> visitedSpots, int currentRoundNum, int funds, int[] selectedClothes, int[] selectedDecorations, RunTimeStorage.RuntimePlayerDataCache storageData, ValueTuple<int, bool> gainedAyaBuff, DateTime realSaveTimeCode, string[] activeDLCs, float wholeTime, Dictionary<int, int> wholeCostIngredient, Dictionary<int, int> wholeCostBeverage, Dictionary<int, int> wholeCostFood, int wholeCollectSpellCard, int wholeCollectMikeCard, int wholeCollectFund, int maxEarnedFund, int servedGuestNum, int servedSpecialGuestNum, int wholeCostInKourindou, List<int> activatedToastTip, RogueLikeRunTimeData.RogueLikeProductPool rogueLikeRecipePool, RogueLikeRunTimeData.RogueLikeProductPool rogueLikeBeveragePool, List<KeyValuePair<RogueLikePersistentCardInstance, int>> gainedCardPool, float currentDifficultyCoefficient, int currentDifficultyPeak, float collectRate, List<int> enabledEliteSpecialGuests, List<RogueLikeRunTimeData.EliteChallengeCache> hasFinishedEliteType, List<KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache>> allActiveEliteChallenge)
		{
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x0000A2D8 File Offset: 0x000084D8
		[Token(Token = "0x17000399")]
		public NightSceneDirector.Difficulty Difficulty
		{
			[Token(Token = "0x60019FC")]
			[Address(RVA = "0x48B8C0", Offset = "0x48A2C0", VA = "0x18048B8C0")]
			get
			{
				return NightSceneDirector.Difficulty.None;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039A")]
		public string CurrentMapName
		{
			[Token(Token = "0x60019FD")]
			[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039B")]
		public string CurrentMapNameLang
		{
			[Token(Token = "0x60019FE")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039C")]
		public IReadOnlyList<Product> GeneratedProducts
		{
			[Token(Token = "0x60019FF")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039D")]
		public IReadOnlyDictionary<string, UnlockedIzakayaInfo> UnlockedSpots
		{
			[Token(Token = "0x6001A00")]
			[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039E")]
		public HashSet<string> VisitedSpots
		{
			[Token(Token = "0x6001A01")]
			[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x0000A2F0 File Offset: 0x000084F0
		[Token(Token = "0x1700039F")]
		public int CurrentRoundNum
		{
			[Token(Token = "0x6001A02")]
			[Address(RVA = "0x440570", Offset = "0x43EF70", VA = "0x180440570")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x0000A308 File Offset: 0x00008508
		[Token(Token = "0x170003A0")]
		public int Funds
		{
			[Token(Token = "0x6001A03")]
			[Address(RVA = "0x476FF0", Offset = "0x4759F0", VA = "0x180476FF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x0000A320 File Offset: 0x00008520
		[Token(Token = "0x170003A1")]
		public ValueTuple<int, bool> GainedAyaBuff
		{
			[Token(Token = "0x6001A04")]
			[Address(RVA = "0x477F80", Offset = "0x476980", VA = "0x180477F80")]
			get
			{
				return default(ValueTuple<int, bool>);
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A2")]
		public IReadOnlyList<int> SelectedClothes
		{
			[Token(Token = "0x6001A05")]
			[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A3")]
		public IReadOnlyList<int> SelectedDecorations
		{
			[Token(Token = "0x6001A06")]
			[Address(RVA = "0x440290", Offset = "0x43EC90", VA = "0x180440290")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A4")]
		public RunTimeStorage.RuntimePlayerDataCache StorageData
		{
			[Token(Token = "0x6001A07")]
			[Address(RVA = "0x440270", Offset = "0x43EC70", VA = "0x180440270")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x0000A338 File Offset: 0x00008538
		[Token(Token = "0x170003A5")]
		public DateTime RealSaveTimeCode
		{
			[Token(Token = "0x6001A08")]
			[Address(RVA = "0x48B8D0", Offset = "0x48A2D0", VA = "0x18048B8D0")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A6")]
		public ICollection<string> ActiveDLCs
		{
			[Token(Token = "0x6001A09")]
			[Address(RVA = "0x440300", Offset = "0x43ED00", VA = "0x180440300")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x0000A350 File Offset: 0x00008550
		[Token(Token = "0x170003A7")]
		public float WholeTime
		{
			[Token(Token = "0x6001A0A")]
			[Address(RVA = "0x477F30", Offset = "0x476930", VA = "0x180477F30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A8")]
		public Dictionary<int, int> WholeCostIngredient
		{
			[Token(Token = "0x6001A0B")]
			[Address(RVA = "0x440320", Offset = "0x43ED20", VA = "0x180440320")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001A0C RID: 6668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003A9")]
		public Dictionary<int, int> WholeCostBeverage
		{
			[Token(Token = "0x6001A0C")]
			[Address(RVA = "0x4402B0", Offset = "0x43ECB0", VA = "0x1804402B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001A0D RID: 6669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003AA")]
		public Dictionary<int, int> WholeCostFood
		{
			[Token(Token = "0x6001A0D")]
			[Address(RVA = "0x4402C0", Offset = "0x43ECC0", VA = "0x1804402C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x0000A368 File Offset: 0x00008568
		[Token(Token = "0x170003AB")]
		public int WholeCollectSpellCard
		{
			[Token(Token = "0x6001A0E")]
			[Address(RVA = "0x4405B0", Offset = "0x43EFB0", VA = "0x1804405B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x0000A380 File Offset: 0x00008580
		[Token(Token = "0x170003AC")]
		public int WholeCollectMikeCard
		{
			[Token(Token = "0x6001A0F")]
			[Address(RVA = "0x4405C0", Offset = "0x43EFC0", VA = "0x1804405C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x0000A398 File Offset: 0x00008598
		[Token(Token = "0x170003AD")]
		public int WholeCollectFund
		{
			[Token(Token = "0x6001A10")]
			[Address(RVA = "0x477F00", Offset = "0x476900", VA = "0x180477F00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x0000A3B0 File Offset: 0x000085B0
		[Token(Token = "0x170003AE")]
		public int MaxEarnedFund
		{
			[Token(Token = "0x6001A11")]
			[Address(RVA = "0x477EF0", Offset = "0x4768F0", VA = "0x180477EF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x0000A3C8 File Offset: 0x000085C8
		[Token(Token = "0x170003AF")]
		public int ServedGuestNum
		{
			[Token(Token = "0x6001A12")]
			[Address(RVA = "0x477F90", Offset = "0x476990", VA = "0x180477F90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x0000A3E0 File Offset: 0x000085E0
		[Token(Token = "0x170003B0")]
		public int ServedSpecialGuestNum
		{
			[Token(Token = "0x6001A13")]
			[Address(RVA = "0x477FA0", Offset = "0x4769A0", VA = "0x180477FA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001A14 RID: 6676 RVA: 0x0000A3F8 File Offset: 0x000085F8
		[Token(Token = "0x170003B1")]
		public int WholeCostInKourindou
		{
			[Token(Token = "0x6001A14")]
			[Address(RVA = "0x48B8E0", Offset = "0x48A2E0", VA = "0x18048B8E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B2")]
		public List<int> ActivatedToastTip
		{
			[Token(Token = "0x6001A15")]
			[Address(RVA = "0x48B890", Offset = "0x48A290", VA = "0x18048B890")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B3")]
		public RogueLikeRunTimeData.RogueLikeProductPool RogueLikeRecipePool
		{
			[Token(Token = "0x6001A16")]
			[Address(RVA = "0x428D60", Offset = "0x427760", VA = "0x180428D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B4")]
		public RogueLikeRunTimeData.RogueLikeProductPool RogueLikeBeveragePool
		{
			[Token(Token = "0x6001A17")]
			[Address(RVA = "0x48A8D0", Offset = "0x4892D0", VA = "0x18048A8D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B5")]
		public List<KeyValuePair<RogueLikePersistentCardInstance, int>> GainedCardPool
		{
			[Token(Token = "0x6001A18")]
			[Address(RVA = "0x48A680", Offset = "0x489080", VA = "0x18048A680")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x0000A410 File Offset: 0x00008610
		[Token(Token = "0x170003B6")]
		public float CurrentDifficultyCoefficient
		{
			[Token(Token = "0x6001A19")]
			[Address(RVA = "0x48B8B0", Offset = "0x48A2B0", VA = "0x18048B8B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x0000A428 File Offset: 0x00008628
		[Token(Token = "0x170003B7")]
		public int CurrentDifficultyPeak
		{
			[Token(Token = "0x6001A1A")]
			[Address(RVA = "0x4404C0", Offset = "0x43EEC0", VA = "0x1804404C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x0000A440 File Offset: 0x00008640
		[Token(Token = "0x170003B8")]
		public float CollectRate
		{
			[Token(Token = "0x6001A1B")]
			[Address(RVA = "0x48B8A0", Offset = "0x48A2A0", VA = "0x18048B8A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003B9")]
		public List<int> EnabledEliteSpecialGuests
		{
			[Token(Token = "0x6001A1C")]
			[Address(RVA = "0x449340", Offset = "0x447D40", VA = "0x180449340")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BA")]
		public List<RogueLikeRunTimeData.EliteChallengeCache> HasFinishedEliteType
		{
			[Token(Token = "0x6001A1D")]
			[Address(RVA = "0x4405A0", Offset = "0x43EFA0", VA = "0x1804405A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BB")]
		public List<KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache>> AllActiveEliteChallenge
		{
			[Token(Token = "0x6001A1E")]
			[Address(RVA = "0x48A630", Offset = "0x489030", VA = "0x18048A630")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0000A458 File Offset: 0x00008658
		[Token(Token = "0x6001A1F")]
		[Address(RVA = "0x48AC80", Offset = "0x489680", VA = "0x18048AC80", Slot = "4")]
		public RogueLikeSaveData Clone()
		{
			return default(RogueLikeSaveData);
		}

		// Token: 0x040017BC RID: 6076
		[Token(Token = "0x40017BC")]
		[FieldOffset(Offset = "0x0")]
		[JsonProperty("FileVersion")]
		public string fileVersion;

		// Token: 0x040017BD RID: 6077
		[Token(Token = "0x40017BD")]
		[FieldOffset(Offset = "0x8")]
		[JsonProperty("Difficulty")]
		public NightSceneDirector.Difficulty m_Difficulty;

		// Token: 0x040017BE RID: 6078
		[Token(Token = "0x40017BE")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty("CurrentMapName")]
		private string m_CurrentMapName;

		// Token: 0x040017BF RID: 6079
		[Token(Token = "0x40017BF")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("CurrentMapNameLang")]
		private string m_CurrentMapNameLang;

		// Token: 0x040017C0 RID: 6080
		[Token(Token = "0x40017C0")]
		[FieldOffset(Offset = "0x20")]
		[JsonProperty("GeneratedProducts")]
		private Product[] m_GeneratedProducts;

		// Token: 0x040017C1 RID: 6081
		[Token(Token = "0x40017C1")]
		[FieldOffset(Offset = "0x28")]
		[JsonProperty("UnlockedSpots")]
		private readonly Dictionary<string, UnlockedIzakayaInfo> m_UnlockedSpots;

		// Token: 0x040017C2 RID: 6082
		[Token(Token = "0x40017C2")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty("VisitedSpots")]
		private readonly HashSet<string> m_VisitedSpots;

		// Token: 0x040017C3 RID: 6083
		[Token(Token = "0x40017C3")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("CurrentRoundNum")]
		private int m_CurrentRoundNum;

		// Token: 0x040017C4 RID: 6084
		[Token(Token = "0x40017C4")]
		[FieldOffset(Offset = "0x3C")]
		[JsonProperty("Funds")]
		private int m_Funds;

		// Token: 0x040017C5 RID: 6085
		[Token(Token = "0x40017C5")]
		[FieldOffset(Offset = "0x40")]
		[JsonProperty("SelectedClothes")]
		private int[] m_SelectedClothes;

		// Token: 0x040017C6 RID: 6086
		[Token(Token = "0x40017C6")]
		[FieldOffset(Offset = "0x48")]
		[JsonProperty("SelectedDecorations")]
		private int[] m_SelectedDecorations;

		// Token: 0x040017C7 RID: 6087
		[Token(Token = "0x40017C7")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty("StorageData")]
		private RunTimeStorage.RuntimePlayerDataCache m_StorageData;

		// Token: 0x040017C8 RID: 6088
		[Token(Token = "0x40017C8")]
		[FieldOffset(Offset = "0x58")]
		[JsonProperty("GainedAyaBuff")]
		private ValueTuple<int, bool> m_GainedAyaBuff;

		// Token: 0x040017C9 RID: 6089
		[Token(Token = "0x40017C9")]
		[FieldOffset(Offset = "0x60")]
		[JsonProperty("RealSaveTimeCode")]
		private DateTime m_RealSaveTimeCode;

		// Token: 0x040017CA RID: 6090
		[Token(Token = "0x40017CA")]
		[FieldOffset(Offset = "0x68")]
		[JsonProperty("ActiveDLCs")]
		private string[] m_ActiveDLCs;

		// Token: 0x040017CB RID: 6091
		[Token(Token = "0x40017CB")]
		[FieldOffset(Offset = "0x70")]
		[JsonProperty("WholeTime")]
		private float m_WholeTime;

		// Token: 0x040017CC RID: 6092
		[Token(Token = "0x40017CC")]
		[FieldOffset(Offset = "0x78")]
		[JsonProperty("WholeCostIngredient")]
		private readonly Dictionary<int, int> m_WholeCostIngredient;

		// Token: 0x040017CD RID: 6093
		[Token(Token = "0x40017CD")]
		[FieldOffset(Offset = "0x80")]
		[JsonProperty("WholeCostBeverage")]
		private readonly Dictionary<int, int> m_WholeCostBeverage;

		// Token: 0x040017CE RID: 6094
		[Token(Token = "0x40017CE")]
		[FieldOffset(Offset = "0x88")]
		[JsonProperty("WholeCostFood")]
		private readonly Dictionary<int, int> m_WholeCostFood;

		// Token: 0x040017CF RID: 6095
		[Token(Token = "0x40017CF")]
		[FieldOffset(Offset = "0x90")]
		[JsonProperty("WholeCollectSpellCard")]
		private int m_WholeCollectSpellCard;

		// Token: 0x040017D0 RID: 6096
		[Token(Token = "0x40017D0")]
		[FieldOffset(Offset = "0x94")]
		[JsonProperty("WholeCollectMikeCard")]
		private int m_WholeCollectMikeCard;

		// Token: 0x040017D1 RID: 6097
		[Token(Token = "0x40017D1")]
		[FieldOffset(Offset = "0x98")]
		[JsonProperty("WholeCollectFund")]
		private int m_WholeCollectFund;

		// Token: 0x040017D2 RID: 6098
		[Token(Token = "0x40017D2")]
		[FieldOffset(Offset = "0x9C")]
		[JsonProperty("MaxEarnedFund")]
		private int m_MaxEarnedFund;

		// Token: 0x040017D3 RID: 6099
		[Token(Token = "0x40017D3")]
		[FieldOffset(Offset = "0xA0")]
		[JsonProperty("ServedGuestNum")]
		private int m_ServedGuestNum;

		// Token: 0x040017D4 RID: 6100
		[Token(Token = "0x40017D4")]
		[FieldOffset(Offset = "0xA4")]
		[JsonProperty("ServedSpecialGuestNum")]
		private int m_ServedSpecialGuestNum;

		// Token: 0x040017D5 RID: 6101
		[Token(Token = "0x40017D5")]
		[FieldOffset(Offset = "0xA8")]
		[JsonProperty("WholeCostInKourindou")]
		private int m_WholeCostInKourindou;

		// Token: 0x040017D6 RID: 6102
		[Token(Token = "0x40017D6")]
		[FieldOffset(Offset = "0xB0")]
		[JsonProperty("ActivatedToastTip")]
		private List<int> m_ActivatedToastTip;

		// Token: 0x040017D7 RID: 6103
		[Token(Token = "0x40017D7")]
		[FieldOffset(Offset = "0xB8")]
		[JsonProperty("RogueLikeRecipePool")]
		private RogueLikeRunTimeData.RogueLikeProductPool m_RogueLikeRecipePool;

		// Token: 0x040017D8 RID: 6104
		[Token(Token = "0x40017D8")]
		[FieldOffset(Offset = "0xC0")]
		[JsonProperty("RogueLikeBeveragePool")]
		private RogueLikeRunTimeData.RogueLikeProductPool m_RogueLikeBeveragePool;

		// Token: 0x040017D9 RID: 6105
		[Token(Token = "0x40017D9")]
		[FieldOffset(Offset = "0xC8")]
		[JsonProperty("GainedCardPool")]
		public List<KeyValuePair<RogueLikePersistentCardInstance, int>> m_GainedCardPool;

		// Token: 0x040017DA RID: 6106
		[Token(Token = "0x40017DA")]
		[FieldOffset(Offset = "0xD0")]
		[JsonProperty("CurrentDifficultyCoefficient")]
		private float m_CurrentDifficultyCoefficient;

		// Token: 0x040017DB RID: 6107
		[Token(Token = "0x40017DB")]
		[FieldOffset(Offset = "0xD4")]
		[JsonProperty("CurrentDifficultyPeak")]
		private int m_CurrentDifficultyPeak;

		// Token: 0x040017DC RID: 6108
		[Token(Token = "0x40017DC")]
		[FieldOffset(Offset = "0xD8")]
		[JsonProperty("CollectRate")]
		private float m_CollectRate;

		// Token: 0x040017DD RID: 6109
		[Token(Token = "0x40017DD")]
		[FieldOffset(Offset = "0xE0")]
		[JsonProperty("EnabledEliteSpecialGuests")]
		private List<int> m_EnabledEliteSpecialGuests;

		// Token: 0x040017DE RID: 6110
		[Token(Token = "0x40017DE")]
		[FieldOffset(Offset = "0xE8")]
		[JsonProperty("HasFinishedEliteType")]
		private List<RogueLikeRunTimeData.EliteChallengeCache> m_HasFinishedEliteType;

		// Token: 0x040017DF RID: 6111
		[Token(Token = "0x40017DF")]
		[FieldOffset(Offset = "0xF0")]
		[JsonProperty("AllActiveEliteChallenge")]
		private List<KeyValuePair<string, RogueLikeRunTimeData.EliteChallengeCache>> m_AllActiveEliteChallenge;
	}
}
