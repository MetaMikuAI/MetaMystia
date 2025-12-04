using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DEYU.AssetHandleUtility;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using GameData.RunTime.Common;
using GameData.RunTime.NightSceneUtility;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Night.RogueLike;
using Night.UI.HUD;
using NightScene;
using NightScene.EventUtility;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200044F RID: 1103
	[Token(Token = "0x200044F")]
	public class RogueLikeRunTimeData
	{
		// Token: 0x060018ED RID: 6381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018ED")]
		[Address(RVA = "0x4871A0", Offset = "0x485BA0", VA = "0x1804871A0")]
		private RogueLikeRunTimeData(NightSceneDirector.Difficulty difficulty, Dictionary<string, UnlockedIzakayaInfo> unlockedSpots, HashSet<string> visitedSpots, IRogueLikeData dataProfile, RunTimeStorage.RuntimePlayerDataCache runtimePlayerDataCache, RunTimeAlbum.RuntimePlayerSkinDataCache runtimePlayerSkinDataCache, RunTimeAlbum.RuntimeAlbumCache runtimeAlbumCache, string currentMapName, int currentRoundNum, int funds, ValueTuple<int, bool> gainedAyaBuff, IEnumerable<Product> generatedProducts, IEnumerable<int> selectedClothes, IEnumerable<int> selectedDecorations, float wholeTime, Dictionary<int, int> wholeCostIngredient, Dictionary<int, int> wholeCostBeverage, Dictionary<int, int> wholeCostFood, int wholeCollectSpellCard, int wholeCollectMikeCard, int wholeCollectFund, int maxEarnedFund, int servedGuestNum, int servedSpecialGuestNum, int wholeCostInKourindou, List<int> activatedToastTip, RogueLikeRunTimeData.RogueLikeProductPool rogueLikeRecipePool, RogueLikeRunTimeData.RogueLikeProductPool rogueLikeBeveragePool, Dictionary<RogueLikePersistentCardInstance, int> gainedCardPool, List<int> enabledEliteSpecialGuests, List<RogueLikeRunTimeData.EliteChallengeCache> hasFinishedEliteType, Dictionary<string, RogueLikeRunTimeData.EliteChallengeCache> allActiveEliteChallenge)
		{
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034B")]
		public static RogueLikeRunTimeData Instance
		{
			[Token(Token = "0x60018EE")]
			[Address(RVA = "0x48A7C0", Offset = "0x4891C0", VA = "0x18048A7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x000097C8 File Offset: 0x000079C8
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700034C")]
		public NightSceneDirector.Difficulty CurrentDifficulty
		{
			[Token(Token = "0x60018EF")]
			[Address(RVA = "0x48A640", Offset = "0x489040", VA = "0x18048A640")]
			[CompilerGenerated]
			get
			{
				return NightSceneDirector.Difficulty.None;
			}
			[Token(Token = "0x60018F0")]
			[Address(RVA = "0x486940", Offset = "0x485340", VA = "0x180486940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x486940", Offset = "0x485340", VA = "0x180486940")]
		public void SetDifficultyPeakByConsole(NightSceneDirector.Difficulty difficulty)
		{
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034D")]
		public IEnumerable<Product> GeneratedProducts
		{
			[Token(Token = "0x60018F2")]
			[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034E")]
		public IList<int> SelectedClothes
		{
			[Token(Token = "0x60018F3")]
			[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700034F")]
		public IList<int> SelectedDecorations
		{
			[Token(Token = "0x60018F4")]
			[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000350")]
		public Dictionary<string, UnlockedIzakayaInfo> UnlockedSpots
		{
			[Token(Token = "0x60018F5")]
			[Address(RVA = "0x440300", Offset = "0x43ED00", VA = "0x180440300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000351")]
		public HashSet<string> VisitedSpots
		{
			[Token(Token = "0x60018F6")]
			[Address(RVA = "0x48A940", Offset = "0x489340", VA = "0x18048A940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x060018F7 RID: 6391 RVA: 0x000097E0 File Offset: 0x000079E0
		[Token(Token = "0x17000352")]
		public IRogueLikeData DataProfile
		{
			[Token(Token = "0x60018F7")]
			[Address(RVA = "0x48A650", Offset = "0x489050", VA = "0x18048A650")]
			[CompilerGenerated]
			get
			{
				return default(IRogueLikeData);
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000353")]
		public IList<int> InvitedGuests
		{
			[Token(Token = "0x60018F8")]
			[Address(RVA = "0x4402C0", Offset = "0x43ECC0", VA = "0x1804402C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000354")]
		public IList<int> InvitedPartners
		{
			[Token(Token = "0x60018F9")]
			[Address(RVA = "0x45A7E0", Offset = "0x4591E0", VA = "0x18045A7E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060018FB RID: 6395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000355")]
		public string CurrentMapName
		{
			[Token(Token = "0x60018FA")]
			[Address(RVA = "0x440500", Offset = "0x43EF00", VA = "0x180440500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60018FB")]
			[Address(RVA = "0x48AAA0", Offset = "0x4894A0", VA = "0x18048AAA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x000097F8 File Offset: 0x000079F8
		// (set) Token: 0x060018FD RID: 6397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000356")]
		public bool FirstArrival
		{
			[Token(Token = "0x60018FC")]
			[Address(RVA = "0x48A750", Offset = "0x489150", VA = "0x18048A750")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60018FD")]
			[Address(RVA = "0x48AB60", Offset = "0x489560", VA = "0x18048AB60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x00009810 File Offset: 0x00007A10
		// (set) Token: 0x060018FF RID: 6399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000357")]
		public int CurrentRoundNum
		{
			[Token(Token = "0x60018FE")]
			[Address(RVA = "0x477FA0", Offset = "0x4769A0", VA = "0x180477FA0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60018FF")]
			[Address(RVA = "0x48AAC0", Offset = "0x4894C0", VA = "0x18048AAC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x00009828 File Offset: 0x00007A28
		// (set) Token: 0x06001901 RID: 6401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000358")]
		public int Funds
		{
			[Token(Token = "0x6001900")]
			[Address(RVA = "0x48A760", Offset = "0x489160", VA = "0x18048A760")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001901")]
			[Address(RVA = "0x48AB70", Offset = "0x489570", VA = "0x18048AB70")]
			set
			{
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06001902 RID: 6402 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001903 RID: 6403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000B")]
		public event Action<int> OnFundsUpdated
		{
			[Token(Token = "0x6001902")]
			[Address(RVA = "0x48A3F0", Offset = "0x488DF0", VA = "0x18048A3F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001903")]
			[Address(RVA = "0x48A9C0", Offset = "0x4893C0", VA = "0x18048A9C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x00009840 File Offset: 0x00007A40
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000359")]
		public bool RoundFailed
		{
			[Token(Token = "0x6001904")]
			[Address(RVA = "0x48A900", Offset = "0x489300", VA = "0x18048A900")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001905")]
			[Address(RVA = "0x48AC70", Offset = "0x489670", VA = "0x18048AC70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x00009858 File Offset: 0x00007A58
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035A")]
		public ValueTuple<int, bool> GainedAyaBuff
		{
			[Token(Token = "0x6001906")]
			[Address(RVA = "0x48A770", Offset = "0x489170", VA = "0x18048A770")]
			[CompilerGenerated]
			get
			{
				return default(ValueTuple<int, bool>);
			}
			[Token(Token = "0x6001907")]
			[Address(RVA = "0x48AB90", Offset = "0x489590", VA = "0x18048AB90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x00009870 File Offset: 0x00007A70
		[Token(Token = "0x1700035B")]
		public bool UnlockedAllLevel2Spot
		{
			[Token(Token = "0x6001908")]
			[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06001909 RID: 6409 RVA: 0x00009888 File Offset: 0x00007A88
		[Token(Token = "0x1700035C")]
		public bool UnlockedAllLevel3Spot
		{
			[Token(Token = "0x6001909")]
			[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035D")]
		public static Action OnRogueLikeRunTimeDataEndCallback
		{
			[Token(Token = "0x600190A")]
			[Address(RVA = "0x48A870", Offset = "0x489270", VA = "0x18048A870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600190B")]
			[Address(RVA = "0x48ABE0", Offset = "0x4895E0", VA = "0x18048ABE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700035E")]
		public RogueLikeAchievementRunTimeData RogueLikeAchievementRunTimeData
		{
			[Token(Token = "0x600190C")]
			[Address(RVA = "0x48A8D0", Offset = "0x4892D0", VA = "0x18048A8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600190D")]
			[Address(RVA = "0x48AC50", Offset = "0x489650", VA = "0x18048AC50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700035F")]
		public Dictionary<Cooker.CookerSeries, int> CookerPrices
		{
			[Token(Token = "0x600190E")]
			[Address(RVA = "0x4402A0", Offset = "0x43ECA0", VA = "0x1804402A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600190F RID: 6415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600190F")]
		[Address(RVA = "0x480A00", Offset = "0x47F400", VA = "0x180480A00")]
		public static RogueLikeRunTimeData Create(IRogueLikeData customizedDataProfile, RunTimeStorage.RuntimePlayerDataCache runtimePlayerDataCache, RunTimeAlbum.RuntimePlayerSkinDataCache runtimePlayerSkinDataCache, RunTimeAlbum.RuntimeAlbumCache runtimeAlbumCache, NightSceneDirector.Difficulty difficulty)
		{
			return null;
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001910")]
		[Address(RVA = "0x484EB0", Offset = "0x4838B0", VA = "0x180484EB0")]
		public static void Load(RogueLikeSaveData saveData, IRogueLikeData customizedDataProfile, RunTimeAlbum.RuntimePlayerSkinDataCache runtimePlayerSkinDataCache, RunTimeStorage.RuntimePlayerDataCache runtimePlayerDataCache, RunTimeAlbum.RuntimeAlbumCache runtimeAlbumCache)
		{
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x000098A0 File Offset: 0x00007AA0
		[Token(Token = "0x6001911")]
		[Address(RVA = "0x484E20", Offset = "0x483820", VA = "0x180484E20")]
		public bool IsMaxRound()
		{
			return default(bool);
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x000098B8 File Offset: 0x00007AB8
		[Token(Token = "0x6001912")]
		[Address(RVA = "0x4811E0", Offset = "0x47FBE0", VA = "0x1804811E0")]
		public static UniTask ExitRogueLike()
		{
			return default(UniTask);
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001913")]
		[Address(RVA = "0x480110", Offset = "0x47EB10", VA = "0x180480110")]
		public static void CleanRogueInstance()
		{
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001914")]
		[Address(RVA = "0x485BB0", Offset = "0x4845B0", VA = "0x180485BB0")]
		public static void PreLeaveRogueLike()
		{
		}

		// Token: 0x17000360 RID: 864
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x000098D0 File Offset: 0x00007AD0
		[Token(Token = "0x17000360")]
		public static bool IsInRogueLike
		{
			[Token(Token = "0x6001915")]
			[Address(RVA = "0x48A800", Offset = "0x489200", VA = "0x18048A800")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x000098E8 File Offset: 0x00007AE8
		[Token(Token = "0x6001916")]
		[Address(RVA = "0x483850", Offset = "0x482250", VA = "0x180483850")]
		public DLC5_RogueLikeDataProfile.MapSetup GetMapSetup(string mapName)
		{
			return default(DLC5_RogueLikeDataProfile.MapSetup);
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001917")]
		[Address(RVA = "0x481A40", Offset = "0x480440", VA = "0x180481A40")]
		public void GenerateProductsForArea(string mapName, bool onlyGenerateIngredients = false)
		{
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001918")]
		[Address(RVA = "0x481290", Offset = "0x47FC90", VA = "0x180481290")]
		public void GenerateIngredientsForCurrentArea(string spotName)
		{
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00009900 File Offset: 0x00007B00
		[Token(Token = "0x6001919")]
		[Address(RVA = "0x4839A0", Offset = "0x4823A0", VA = "0x1804839A0")]
		public int GetPartnerPrice(PartnerInfoBase partnerData)
		{
			return 0;
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191A")]
		[Address(RVA = "0x47E130", Offset = "0x47CB30", VA = "0x18047E130")]
		public void AddProductsFromPoolToGenerateProducts()
		{
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191B")]
		[Address(RVA = "0x4849B0", Offset = "0x4833B0", VA = "0x1804849B0")]
		public void IncreaseExtraIngNum()
		{
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191C")]
		[Address(RVA = "0x47E040", Offset = "0x47CA40", VA = "0x18047E040")]
		public void AddProductToGenerateProduct(Product product)
		{
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00009918 File Offset: 0x00007B18
		[Token(Token = "0x600191D")]
		[Address(RVA = "0x485D90", Offset = "0x484790", VA = "0x180485D90")]
		public bool RemoveProductFromGenerateProduct(Product product)
		{
			return default(bool);
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600191E")]
		[Address(RVA = "0x4818D0", Offset = "0x4802D0", VA = "0x1804818D0")]
		public void GeneratePopularTag()
		{
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00009930 File Offset: 0x00007B30
		[Token(Token = "0x600191F")]
		[Address(RVA = "0x4803F0", Offset = "0x47EDF0", VA = "0x1804803F0")]
		public RogueLikeSaveData CreateSave(RunTimeStorage.RuntimePlayerDataCache cache)
		{
			return default(RogueLikeSaveData);
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001920")]
		[Address(RVA = "0x481140", Offset = "0x47FB40", VA = "0x180481140")]
		private static void EnsureInstanceIsNull()
		{
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001921")]
		[Address(RVA = "0x4859E0", Offset = "0x4843E0", VA = "0x1804859E0")]
		public void OpenExtraMenuPanel(DLC5_RogueLikeExtraMenuSubPanel rogueLikeExtraMenuSubPanel, Action<DLC5_RogueLikeExtraMenuSubPanel.CloseContext> closeParentCallback, [Optional] Action onPanelCloseCallback, [Optional] Action<DLC5_RogueLikeExtraMenuSubPanel> afterPanelOpenedCallback)
		{
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00009948 File Offset: 0x00007B48
		[Token(Token = "0x6001922")]
		[Address(RVA = "0x486A90", Offset = "0x485490", VA = "0x180486A90")]
		public static UniTask<ValueTuple<DLC5_RogueLikeDataProfile, DLC5_RogueLikeDataProfileUnchangeable>> TryLoadRogueLikeDta(AssetReference dataProfileReference, AssetReference unchangeableDataProfileReference)
		{
			return default(UniTask<ValueTuple<DLC5_RogueLikeDataProfile, DLC5_RogueLikeDataProfileUnchangeable>>);
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001923")]
		[Address(RVA = "0x486BB0", Offset = "0x4855B0", VA = "0x180486BB0")]
		public static void TryReleaseRogueLikeData()
		{
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000361")]
		public List<int> EnabledEliteSpecialGuests
		{
			[Token(Token = "0x6001924")]
			[Address(RVA = "0x48A680", Offset = "0x489080", VA = "0x18048A680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000362")]
		public List<RogueLikeRunTimeData.EliteChallengeCache> HasFinishedEliteType
		{
			[Token(Token = "0x6001925")]
			[Address(RVA = "0x48A7A0", Offset = "0x4891A0", VA = "0x18048A7A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00009960 File Offset: 0x00007B60
		[Token(Token = "0x6001926")]
		[Address(RVA = "0x4834F0", Offset = "0x481EF0", VA = "0x1804834F0")]
		public int GetFinishEliteNum()
		{
			return 0;
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000363")]
		public Dictionary<RogueLikeRunTimeData.EliteChallengeType, RogueLikeRunTimeData.EliteChallengeBase> AllEliteChallengeData
		{
			[Token(Token = "0x6001927")]
			[Address(RVA = "0x48A4C0", Offset = "0x488EC0", VA = "0x18048A4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001928")]
		[Address(RVA = "0x483490", Offset = "0x481E90", VA = "0x180483490")]
		public RogueLikeRunTimeData.EliteChallengeBase GetEliteChallengeData(RogueLikeRunTimeData.EliteChallengeType challengeType)
		{
			return null;
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600192A RID: 6442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000364")]
		public RogueLikeRunTimeData.EliteChallengeCache CurrentEliteChallenge
		{
			[Token(Token = "0x6001929")]
			[Address(RVA = "0x449340", Offset = "0x447D40", VA = "0x180449340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600192A")]
			[Address(RVA = "0x48AA80", Offset = "0x489480", VA = "0x18048AA80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000365")]
		public Dictionary<string, RogueLikeRunTimeData.EliteChallengeCache> AllActiveEliteChallenge
		{
			[Token(Token = "0x600192B")]
			[Address(RVA = "0x4405A0", Offset = "0x43EFA0", VA = "0x1804405A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600192C RID: 6444 RVA: 0x00009978 File Offset: 0x00007B78
		[Token(Token = "0x600192C")]
		[Address(RVA = "0x4800E0", Offset = "0x47EAE0", VA = "0x1804800E0")]
		public bool CheckShouldSpawnEliteChallenge()
		{
			return default(bool);
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600192D")]
		[Address(RVA = "0x483A60", Offset = "0x482460", VA = "0x180483A60")]
		public RogueLikeRunTimeData.EliteChallengeCache GetRandomEliteChallenge()
		{
			return null;
		}

		// Token: 0x0600192E RID: 6446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600192E")]
		[Address(RVA = "0x484880", Offset = "0x483280", VA = "0x180484880")]
		public RogueLikeRunTimeData.EliteChallengeCache GetTargetEliteChallenge(RogueLikeRunTimeData.EliteChallengeType challengeType)
		{
			return null;
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000366")]
		public Dictionary<RogueLikeCardBase.Rarity, List<RogueLikeCard>> CardMappingByRarityDic
		{
			[Token(Token = "0x600192F")]
			[Address(RVA = "0x48A630", Offset = "0x489030", VA = "0x18048A630")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x00009990 File Offset: 0x00007B90
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000367")]
		public int HasSelectedRecipeNum
		{
			[Token(Token = "0x6001930")]
			[Address(RVA = "0x48A7B0", Offset = "0x4891B0", VA = "0x18048A7B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001931")]
			[Address(RVA = "0x48ABC0", Offset = "0x4895C0", VA = "0x18048ABC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x000099A8 File Offset: 0x00007BA8
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000368")]
		public int ExtraRecipeGachaNum
		{
			[Token(Token = "0x6001932")]
			[Address(RVA = "0x48A710", Offset = "0x489110", VA = "0x18048A710")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001933")]
			[Address(RVA = "0x48AB20", Offset = "0x489520", VA = "0x18048AB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x000099C0 File Offset: 0x00007BC0
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000369")]
		public int ExtraBevGachaNum
		{
			[Token(Token = "0x6001934")]
			[Address(RVA = "0x45EA70", Offset = "0x45D470", VA = "0x18045EA70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001935")]
			[Address(RVA = "0x48AAF0", Offset = "0x4894F0", VA = "0x18048AAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x000099D8 File Offset: 0x00007BD8
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036A")]
		public int ExtraRecipeSelectNum
		{
			[Token(Token = "0x6001936")]
			[Address(RVA = "0x48A720", Offset = "0x489120", VA = "0x18048A720")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001937")]
			[Address(RVA = "0x48AB30", Offset = "0x489530", VA = "0x18048AB30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x000099F0 File Offset: 0x00007BF0
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036B")]
		public int ExtraIngredientNumWhenGetRecipe
		{
			[Token(Token = "0x6001938")]
			[Address(RVA = "0x48A690", Offset = "0x489090", VA = "0x18048A690")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001939")]
			[Address(RVA = "0x48AB00", Offset = "0x489500", VA = "0x18048AB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x00009A08 File Offset: 0x00007C08
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036C")]
		public int MoveAction
		{
			[Token(Token = "0x600193A")]
			[Address(RVA = "0x48A860", Offset = "0x489260", VA = "0x18048A860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600193B")]
			[Address(RVA = "0x48ABD0", Offset = "0x4895D0", VA = "0x18048ABD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x00009A20 File Offset: 0x00007C20
		[Token(Token = "0x1700036D")]
		public int ExtraMoveAction
		{
			[Token(Token = "0x600193C")]
			[Address(RVA = "0x48A6B0", Offset = "0x4890B0", VA = "0x18048A6B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x00009A38 File Offset: 0x00007C38
		// (set) Token: 0x0600193E RID: 6462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036E")]
		public float ExtraKourindouDiscount
		{
			[Token(Token = "0x600193D")]
			[Address(RVA = "0x48A6A0", Offset = "0x4890A0", VA = "0x18048A6A0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600193E")]
			[Address(RVA = "0x48AB10", Offset = "0x489510", VA = "0x18048AB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x00009A50 File Offset: 0x00007C50
		// (set) Token: 0x06001940 RID: 6464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700036F")]
		public int ExtraSoldBevNum
		{
			[Token(Token = "0x600193F")]
			[Address(RVA = "0x48A730", Offset = "0x489130", VA = "0x18048A730")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001940")]
			[Address(RVA = "0x48AB40", Offset = "0x489540", VA = "0x18048AB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x00009A68 File Offset: 0x00007C68
		// (set) Token: 0x06001942 RID: 6466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000370")]
		public float ExtraSoldIngMultiplier
		{
			[Token(Token = "0x6001941")]
			[Address(RVA = "0x48A740", Offset = "0x489140", VA = "0x18048A740")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6001942")]
			[Address(RVA = "0x48AB50", Offset = "0x489550", VA = "0x18048AB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x00009A80 File Offset: 0x00007C80
		// (set) Token: 0x06001944 RID: 6468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000371")]
		public int DecreaseNumForComboGacha
		{
			[Token(Token = "0x6001943")]
			[Address(RVA = "0x48A660", Offset = "0x489060", VA = "0x18048A660")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001944")]
			[Address(RVA = "0x48AAD0", Offset = "0x4894D0", VA = "0x18048AAD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x00009A98 File Offset: 0x00007C98
		// (set) Token: 0x06001946 RID: 6470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000372")]
		public int DecreaseNumForEvalGacha
		{
			[Token(Token = "0x6001945")]
			[Address(RVA = "0x48A670", Offset = "0x489070", VA = "0x18048A670")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001946")]
			[Address(RVA = "0x48AAE0", Offset = "0x4894E0", VA = "0x18048AAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00009AB0 File Offset: 0x00007CB0
		[Token(Token = "0x6001947")]
		[Address(RVA = "0x484360", Offset = "0x482D60", VA = "0x180484360")]
		public int GetRecipeGachaNum()
		{
			return 0;
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00009AC8 File Offset: 0x00007CC8
		[Token(Token = "0x6001948")]
		[Address(RVA = "0x4833C0", Offset = "0x481DC0", VA = "0x1804833C0")]
		public int GetBevGachaNum()
		{
			return 0;
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00009AE0 File Offset: 0x00007CE0
		[Token(Token = "0x6001949")]
		[Address(RVA = "0x4843E0", Offset = "0x482DE0", VA = "0x1804843E0")]
		public int GetRecipeSelectNum()
		{
			return 0;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00009AF8 File Offset: 0x00007CF8
		[Token(Token = "0x600194A")]
		[Address(RVA = "0x4838F0", Offset = "0x4822F0", VA = "0x1804838F0")]
		public int GetMoveAction()
		{
			return 0;
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x00009B10 File Offset: 0x00007D10
		[Token(Token = "0x600194B")]
		[Address(RVA = "0x483610", Offset = "0x482010", VA = "0x180483610")]
		public int GetGachaNeedComboNum()
		{
			return 0;
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x00009B28 File Offset: 0x00007D28
		[Token(Token = "0x600194C")]
		[Address(RVA = "0x483670", Offset = "0x482070", VA = "0x180483670")]
		public int GetGachaNeedSpellNum()
		{
			return 0;
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x00009B40 File Offset: 0x00007D40
		[Token(Token = "0x600194D")]
		[Address(RVA = "0x4836D0", Offset = "0x4820D0", VA = "0x1804836D0")]
		public int GetIngredientNumWhenGetRecipe()
		{
			return 0;
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000373")]
		public Dictionary<string, int> MapSpotDistanceDictionary
		{
			[Token(Token = "0x600194E")]
			[Address(RVA = "0x48A840", Offset = "0x489240", VA = "0x18048A840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600194F")]
		[Address(RVA = "0x484C00", Offset = "0x483600", VA = "0x180484C00")]
		private void InitializeExtraProperty()
		{
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000374")]
		public HashSet<int> SpecialGuestVisitEverywhere
		{
			[Token(Token = "0x6001950")]
			[Address(RVA = "0x48A930", Offset = "0x489330", VA = "0x18048A930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000375")]
		public List<int> BannedCollabKey
		{
			[Token(Token = "0x6001951")]
			[Address(RVA = "0x48A610", Offset = "0x489010", VA = "0x18048A610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001952")]
		[Address(RVA = "0x484440", Offset = "0x482E40", VA = "0x180484440")]
		public Dictionary<int, Vector2> GetSpecialGuestPool(string daySceneMapLabel, out float finalProbability)
		{
			return null;
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001953 RID: 6483 RVA: 0x00009B58 File Offset: 0x00007D58
		// (set) Token: 0x06001954 RID: 6484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000376")]
		public int RefreshCardNum
		{
			[Token(Token = "0x6001953")]
			[Address(RVA = "0x48A8C0", Offset = "0x4892C0", VA = "0x18048A8C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001954")]
			[Address(RVA = "0x48AC40", Offset = "0x489640", VA = "0x18048AC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001955 RID: 6485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000377")]
		public RogueLikeRunTimeData.RogueLikeProductPool RogueLikeRecipePool
		{
			[Token(Token = "0x6001955")]
			[Address(RVA = "0x48A8F0", Offset = "0x4892F0", VA = "0x18048A8F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000378")]
		public RogueLikeRunTimeData.RogueLikeProductPool RogueLikeBeveragePool
		{
			[Token(Token = "0x6001956")]
			[Address(RVA = "0x48A8E0", Offset = "0x4892E0", VA = "0x18048A8E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001957 RID: 6487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000379")]
		public IEnumerable<int> AvailableBeverages
		{
			[Token(Token = "0x6001957")]
			[Address(RVA = "0x48A4D0", Offset = "0x488ED0", VA = "0x18048A4D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037A")]
		public Dictionary<RogueLikePersistentCardInstance, int> GainedCardPool
		{
			[Token(Token = "0x6001958")]
			[Address(RVA = "0x48A790", Offset = "0x489190", VA = "0x18048A790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001959 RID: 6489 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600195A RID: 6490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700037B")]
		public Dictionary<RogueLikeCardBase.CardType, int> GainedCardGroupByCardTypePool
		{
			[Token(Token = "0x6001959")]
			[Address(RVA = "0x48A780", Offset = "0x489180", VA = "0x18048A780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600195A")]
			[Address(RVA = "0x48ABA0", Offset = "0x4895A0", VA = "0x18048ABA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037C")]
		public Dictionary<int, int> RecipeRefreshWaveIndex
		{
			[Token(Token = "0x600195B")]
			[Address(RVA = "0x48A8B0", Offset = "0x4892B0", VA = "0x18048A8B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037D")]
		public Dictionary<int, int> BevRefreshWaveIndex
		{
			[Token(Token = "0x600195C")]
			[Address(RVA = "0x48A620", Offset = "0x489020", VA = "0x18048A620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600195D")]
		[Address(RVA = "0x47EB40", Offset = "0x47D540", VA = "0x18047EB40")]
		public void AddToGachaPool(IEnumerable<int> recipeId, IEnumerable<int> bevId, bool suppressCallbacks = false, [Optional] Action onPanelCloseCallback)
		{
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600195E")]
		[Address(RVA = "0x486970", Offset = "0x485370", VA = "0x180486970")]
		public void ShowPool(DLC5_RogueLikePoolViewerPanel.PoolViewerType poolViewerType, [Optional] Action onPanelCloseCallback)
		{
		}

		// Token: 0x0600195F RID: 6495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600195F")]
		[Address(RVA = "0x4843C0", Offset = "0x482DC0", VA = "0x1804843C0")]
		public HashSet<int> GetRecipeGachaResult()
		{
			return null;
		}

		// Token: 0x06001960 RID: 6496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001960")]
		[Address(RVA = "0x483420", Offset = "0x481E20", VA = "0x180483420")]
		public HashSet<int> GetBevGachaResult()
		{
			return null;
		}

		// Token: 0x06001961 RID: 6497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001961")]
		[Address(RVA = "0x47E8D0", Offset = "0x47D2D0", VA = "0x18047E8D0")]
		public void AddToCardPool(RogueLikePersistentCardInstance card, int addNum)
		{
		}

		// Token: 0x06001962 RID: 6498 RVA: 0x00009B70 File Offset: 0x00007D70
		[Token(Token = "0x6001962")]
		[Address(RVA = "0x483440", Offset = "0x481E40", VA = "0x180483440")]
		public int GetCardNum(RogueLikeCardBase.CardType cardType)
		{
			return 0;
		}

		// Token: 0x06001963 RID: 6499 RVA: 0x00009B88 File Offset: 0x00007D88
		[Token(Token = "0x6001963")]
		[Address(RVA = "0x483180", Offset = "0x481B80", VA = "0x180483180")]
		public int GetActivedCardNum(RogueLikeCardBase.CardType cardType)
		{
			return 0;
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037E")]
		private IEnumerable<KeyValuePair<RogueLikeCardBase.CardType, int>> GainedCardPairs
		{
			[Token(Token = "0x6001964")]
			[Address(RVA = "0x48A780", Offset = "0x489180", VA = "0x18048A780")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001965")]
		[Address(RVA = "0x486E80", Offset = "0x485880", VA = "0x180486E80")]
		public void UpdateGainedCardGroupByCardTypePool()
		{
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037F")]
		public string[] ActiveDLCs
		{
			[Token(Token = "0x6001966")]
			[Address(RVA = "0x48A4B0", Offset = "0x488EB0", VA = "0x18048A4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001967 RID: 6503 RVA: 0x00009BA0 File Offset: 0x00007DA0
		[Token(Token = "0x17000380")]
		public float WholeTime
		{
			[Token(Token = "0x6001967")]
			[Address(RVA = "0x48A9B0", Offset = "0x4893B0", VA = "0x18048A9B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000381")]
		public IReadOnlyDictionary<int, int> WholeCostIngredient
		{
			[Token(Token = "0x6001968")]
			[Address(RVA = "0x48A9A0", Offset = "0x4893A0", VA = "0x18048A9A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001969 RID: 6505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000382")]
		public IReadOnlyDictionary<int, int> WholeCostBeverage
		{
			[Token(Token = "0x6001969")]
			[Address(RVA = "0x48A980", Offset = "0x489380", VA = "0x18048A980")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000383")]
		public IReadOnlyDictionary<int, int> WholeCostFood
		{
			[Token(Token = "0x600196A")]
			[Address(RVA = "0x45EA30", Offset = "0x45D430", VA = "0x18045EA30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x0600196B RID: 6507 RVA: 0x00009BB8 File Offset: 0x00007DB8
		[Token(Token = "0x17000384")]
		public int WholeCollectSpellCard
		{
			[Token(Token = "0x600196B")]
			[Address(RVA = "0x48A970", Offset = "0x489370", VA = "0x18048A970")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x00009BD0 File Offset: 0x00007DD0
		[Token(Token = "0x17000385")]
		public int WholeCollectMikeCard
		{
			[Token(Token = "0x600196C")]
			[Address(RVA = "0x48A960", Offset = "0x489360", VA = "0x18048A960")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x0600196D RID: 6509 RVA: 0x00009BE8 File Offset: 0x00007DE8
		[Token(Token = "0x17000386")]
		public int WholeCollectFund
		{
			[Token(Token = "0x600196D")]
			[Address(RVA = "0x48A950", Offset = "0x489350", VA = "0x18048A950")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x0600196E RID: 6510 RVA: 0x00009C00 File Offset: 0x00007E00
		[Token(Token = "0x17000387")]
		public int MaxEarnedFund
		{
			[Token(Token = "0x600196E")]
			[Address(RVA = "0x48A850", Offset = "0x489250", VA = "0x18048A850")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x0600196F RID: 6511 RVA: 0x00009C18 File Offset: 0x00007E18
		[Token(Token = "0x17000388")]
		public int ServedGuestNum
		{
			[Token(Token = "0x600196F")]
			[Address(RVA = "0x48A910", Offset = "0x489310", VA = "0x18048A910")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001970 RID: 6512 RVA: 0x00009C30 File Offset: 0x00007E30
		[Token(Token = "0x17000389")]
		public int ServedSpecialGuestNum
		{
			[Token(Token = "0x6001970")]
			[Address(RVA = "0x48A920", Offset = "0x489320", VA = "0x18048A920")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001971 RID: 6513 RVA: 0x00009C48 File Offset: 0x00007E48
		[Token(Token = "0x1700038A")]
		public int WholeCostInKourindou
		{
			[Token(Token = "0x6001971")]
			[Address(RVA = "0x48A990", Offset = "0x489390", VA = "0x18048A990")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001972")]
		[Address(RVA = "0x47ED90", Offset = "0x47D790", VA = "0x18047ED90")]
		public void AddWholeTime(float value)
		{
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001973")]
		[Address(RVA = "0x47ED70", Offset = "0x47D770", VA = "0x18047ED70")]
		public void AddWholeCollectSpellCard(int value)
		{
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001974")]
		[Address(RVA = "0x47ED60", Offset = "0x47D760", VA = "0x18047ED60")]
		public void AddWholeCollectMikeCard(int value)
		{
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001975")]
		[Address(RVA = "0x47ED50", Offset = "0x47D750", VA = "0x18047ED50")]
		public void AddWholeCollectFund(int value)
		{
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001976")]
		[Address(RVA = "0x486950", Offset = "0x485350", VA = "0x180486950")]
		public void SetMaxEarnedFund(int value)
		{
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001977")]
		[Address(RVA = "0x47E8B0", Offset = "0x47D2B0", VA = "0x18047E8B0")]
		public void AddServedGuestNum(int value)
		{
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001978")]
		[Address(RVA = "0x47E8C0", Offset = "0x47D2C0", VA = "0x18047E8C0")]
		public void AddServedSpecialGuestNum(int value)
		{
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001979")]
		[Address(RVA = "0x47ED80", Offset = "0x47D780", VA = "0x18047ED80")]
		public void AddWholeCostInKourindou(int value)
		{
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197A")]
		[Address(RVA = "0x47ED30", Offset = "0x47D730", VA = "0x18047ED30")]
		public void AddToWholeCostIngredient(IEnumerable<int> elements)
		{
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197B")]
		[Address(RVA = "0x47ECF0", Offset = "0x47D6F0", VA = "0x18047ECF0")]
		public void AddToWholeCostBeverage(IEnumerable<int> elements)
		{
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197C")]
		[Address(RVA = "0x47ED10", Offset = "0x47D710", VA = "0x18047ED10")]
		public void AddToWholeCostFood(IEnumerable<int> elements)
		{
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197D")]
		[Address(RVA = "0x485520", Offset = "0x483F20", VA = "0x180485520")]
		private void ObjectsInRange(Dictionary<int, int> objectPool, IEnumerable<int> objectIds)
		{
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600197E")]
		[Address(RVA = "0x485920", Offset = "0x484320", VA = "0x180485920")]
		private void ObjectsIn(Dictionary<int, int> objectPool, int objectId)
		{
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197F")]
		[Address(RVA = "0x483730", Offset = "0x482130", VA = "0x180483730")]
		public string GetLangFromDLCLabel(string dlcLabel)
		{
			return null;
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00009C60 File Offset: 0x00007E60
		[Token(Token = "0x6001980")]
		[Address(RVA = "0x47EDB0", Offset = "0x47D7B0", VA = "0x18047EDB0")]
		public float CalculateCollectRate(out float waveCorrectRate)
		{
			return 0f;
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001981")]
		[Address(RVA = "0x486D20", Offset = "0x485720", VA = "0x180486D20")]
		public void UpdateCollectRate()
		{
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00009C78 File Offset: 0x00007E78
		[Token(Token = "0x6001982")]
		[Address(RVA = "0x47EF80", Offset = "0x47D980", VA = "0x18047EF80")]
		private RogueLikeRunTimeData.DLCAreaCollectRate CalculateTargetSpotCollectRate(string dlcKey)
		{
			return default(RogueLikeRunTimeData.DLCAreaCollectRate);
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00009C90 File Offset: 0x00007E90
		[Token(Token = "0x6001983")]
		[Address(RVA = "0x4867E0", Offset = "0x4851E0", VA = "0x1804867E0")]
		private static RogueLikeSaveData Rogue_TryUpgradeSaveVersion(RogueLikeSaveData rogueSaveFile, IRogueLikeData customizedDataProfile)
		{
			return default(RogueLikeSaveData);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00009CA8 File Offset: 0x00007EA8
		[Token(Token = "0x6001984")]
		[Address(RVA = "0x485E00", Offset = "0x484800", VA = "0x180485E00")]
		private static RogueLikeSaveData Rogue_TryUpgradeSaveV0(RogueLikeSaveData rogueSaveFile, IRogueLikeData customizedDataProfile)
		{
			return default(RogueLikeSaveData);
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00009CC0 File Offset: 0x00007EC0
		[Token(Token = "0x6001985")]
		[Address(RVA = "0x486190", Offset = "0x484B90", VA = "0x180486190")]
		private static RogueLikeSaveData Rogue_TryUpgradeSaveV1(RogueLikeSaveData rogueSaveFile, IRogueLikeData customizedDataProfile)
		{
			return default(RogueLikeSaveData);
		}

		// Token: 0x04001705 RID: 5893
		[Token(Token = "0x4001705")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RogueLikeRunTimeData s_Instance;

		// Token: 0x04001706 RID: 5894
		[Token(Token = "0x4001706")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<Product> m_GeneratedProducts;

		// Token: 0x04001707 RID: 5895
		[Token(Token = "0x4001707")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<int> m_SelectedClothes;

		// Token: 0x04001708 RID: 5896
		[Token(Token = "0x4001708")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<int> m_SelectedDecorations;

		// Token: 0x04001709 RID: 5897
		[Token(Token = "0x4001709")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly RunTimeStorage.RuntimePlayerDataCache m_RuntimePlayerDataCache;

		// Token: 0x0400170A RID: 5898
		[Token(Token = "0x400170A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly RunTimeAlbum.RuntimePlayerSkinDataCache m_RuntimePlayerSkinDataCache;

		// Token: 0x0400170B RID: 5899
		[Token(Token = "0x400170B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly RunTimeAlbum.RuntimeAlbumCache m_RuntimeAlbumCache;

		// Token: 0x0400170C RID: 5900
		[Token(Token = "0x400170C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Dictionary<Cooker.CookerSeries, int> m_CookerPrices;

		// Token: 0x0400170D RID: 5901
		[Token(Token = "0x400170D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly Dictionary<string, DLC5_RogueLikeDataProfile.MapSetup> m_MapSetups;

		// Token: 0x0400170E RID: 5902
		[Token(Token = "0x400170E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Dictionary<int, int> m_PartnerPriceDictionary;

		// Token: 0x0400170F RID: 5903
		[Token(Token = "0x400170F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_Funds;

		// Token: 0x04001710 RID: 5904
		[Token(Token = "0x4001710")]
		public const string ROGUELIKE_PANEL_NAME = "RogueLikePanel";

		// Token: 0x04001712 RID: 5906
		[Token(Token = "0x4001712")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public readonly IReadOnlyList<int> DoNotAutoEnableDecorations;

		// Token: 0x04001720 RID: 5920
		[Token(Token = "0x4001720")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IAssetHandle<DLC5_RogueLikeDataProfile> dataProfileHandle;

		// Token: 0x04001721 RID: 5921
		[Token(Token = "0x4001721")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IAssetHandle<DLC5_RogueLikeDataProfileUnchangeable> unchangeableDataProfileHandle;

		// Token: 0x04001727 RID: 5927
		[Token(Token = "0x4001727")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private readonly Dictionary<RogueLikeCardBase.Rarity, List<RogueLikeCard>> m_CardMappingByRarityDic;

		// Token: 0x04001728 RID: 5928
		[Token(Token = "0x4001728")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public readonly Dictionary<RogueLikeCardBase.CardType, RogueLikeCard> RogueLikeCardsDic;

		// Token: 0x04001729 RID: 5929
		[Token(Token = "0x4001729")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public readonly Dictionary<RogueLikeCardBase.CardType, RogueLikeCardPersistent> RogueLikePersistentCardsDic;

		// Token: 0x0400172A RID: 5930
		[Token(Token = "0x400172A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public readonly Dictionary<RogueLikeCardBase.CardType, string[]> RogueLikeCardsLangDic;

		// Token: 0x0400172B RID: 5931
		[Token(Token = "0x400172B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public readonly Dictionary<int, DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest> SpecialGuestVisitEverywhereDic;

		// Token: 0x04001741 RID: 5953
		[Token(Token = "0x4001741")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private readonly string[] m_ActiveDLCs;

		// Token: 0x04001742 RID: 5954
		[Token(Token = "0x4001742")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float m_WholeTime;

		// Token: 0x04001743 RID: 5955
		[Token(Token = "0x4001743")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private readonly Dictionary<int, int> m_WholeCostIngredient;

		// Token: 0x04001744 RID: 5956
		[Token(Token = "0x4001744")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly Dictionary<int, int> m_WholeCostBeverage;

		// Token: 0x04001745 RID: 5957
		[Token(Token = "0x4001745")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private readonly Dictionary<int, int> m_WholeCostFood;

		// Token: 0x04001746 RID: 5958
		[Token(Token = "0x4001746")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private int m_WholeCollectSpellCard;

		// Token: 0x04001747 RID: 5959
		[Token(Token = "0x4001747")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private int m_WholeCollectMikeCard;

		// Token: 0x04001748 RID: 5960
		[Token(Token = "0x4001748")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private int m_WholeCollectFund;

		// Token: 0x04001749 RID: 5961
		[Token(Token = "0x4001749")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private int m_MaxEarnedFund;

		// Token: 0x0400174A RID: 5962
		[Token(Token = "0x400174A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private int m_ServedGuestNum;

		// Token: 0x0400174B RID: 5963
		[Token(Token = "0x400174B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private int m_ServedSpecialGuestNum;

		// Token: 0x0400174C RID: 5964
		[Token(Token = "0x400174C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private int m_WholeCostInKourindou;

		// Token: 0x0400174D RID: 5965
		[Token(Token = "0x400174D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly List<string> DLCLabelList;

		// Token: 0x0400174E RID: 5966
		[Token(Token = "0x400174E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public readonly Dictionary<string, RogueLikeRunTimeData.DLCAreaCollectRate> CollectRatesDic;

		// Token: 0x0400174F RID: 5967
		[Token(Token = "0x400174F")]
		private const string ROGUE_SAVE_VERSION = "RogueV2";

		// Token: 0x02000450 RID: 1104
		[Token(Token = "0x2000450")]
		public enum EliteChallengeType
		{
			// Token: 0x04001751 RID: 5969
			[Token(Token = "0x4001751")]
			幽冥试炼,
			// Token: 0x04001752 RID: 5970
			[Token(Token = "0x4001752")]
			墨染之樱,
			// Token: 0x04001753 RID: 5971
			[Token(Token = "0x4001753")]
			血口煞星,
			// Token: 0x04001754 RID: 5972
			[Token(Token = "0x4001754")]
			怪诞狂想,
			// Token: 0x04001755 RID: 5973
			[Token(Token = "0x4001755")]
			动感节拍,
			// Token: 0x04001756 RID: 5974
			[Token(Token = "0x4001756")]
			无人生还,
			// Token: 0x04001757 RID: 5975
			[Token(Token = "0x4001757")]
			反狱修罗
		}

		// Token: 0x02000451 RID: 1105
		[Token(Token = "0x2000451")]
		public abstract class EliteChallengeBase : ScriptableObject
		{
			// Token: 0x1700038B RID: 907
			// (get) Token: 0x06001987 RID: 6535 RVA: 0x00009CF0 File Offset: 0x00007EF0
			[Token(Token = "0x1700038B")]
			public RogueLikeRunTimeData.EliteChallengeType ChallengeType
			{
				[Token(Token = "0x6001987")]
				[Address(RVA = "0x403830", Offset = "0x402230", VA = "0x180403830")]
				get
				{
					return RogueLikeRunTimeData.EliteChallengeType.幽冥试炼;
				}
			}

			// Token: 0x1700038C RID: 908
			// (get) Token: 0x06001988 RID: 6536 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700038C")]
			public string MappingDLC
			{
				[Token(Token = "0x6001988")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700038D RID: 909
			// (get) Token: 0x06001989 RID: 6537 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700038D")]
			public RogueLikeRunTimeData.EliteChallengeBase.EliteReward[] Rewards
			{
				[Token(Token = "0x6001989")]
				[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700038E RID: 910
			// (get) Token: 0x0600198A RID: 6538 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700038E")]
			public GameObject BossUI
			{
				[Token(Token = "0x600198A")]
				[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700038F RID: 911
			// (get) Token: 0x0600198B RID: 6539 RVA: 0x00009D08 File Offset: 0x00007F08
			[Token(Token = "0x1700038F")]
			public int BossID
			{
				[Token(Token = "0x600198B")]
				[Address(RVA = "0x440570", Offset = "0x43EF70", VA = "0x180440570")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000390 RID: 912
			// (get) Token: 0x0600198C RID: 6540 RVA: 0x00009D20 File Offset: 0x00007F20
			[Token(Token = "0x17000390")]
			public int BGMId
			{
				[Token(Token = "0x600198C")]
				[Address(RVA = "0x476FF0", Offset = "0x4759F0", VA = "0x180476FF0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600198D RID: 6541
			[Token(Token = "0x600198D")]
			public abstract string GetEliteTitle(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache);

			// Token: 0x0600198E RID: 6542
			[Token(Token = "0x600198E")]
			public abstract string GetEliteDescription(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel);

			// Token: 0x0600198F RID: 6543 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600198F")]
			[Address(RVA = "0x476F80", Offset = "0x475980", VA = "0x180476F80")]
			protected string OverrideMapLabel(string oldString, string mapLabel)
			{
				return null;
			}

			// Token: 0x06001990 RID: 6544 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001990")]
			[Address(RVA = "0x476EF0", Offset = "0x4758F0", VA = "0x180476EF0", Slot = "6")]
			public virtual RogueLikeRunTimeData.EliteChallengeCache GenerateEliteChallengeCache(RogueLikeRunTimeData rogueLikeRunTimeData, string mapLabel)
			{
				return null;
			}

			// Token: 0x06001991 RID: 6545
			[Token(Token = "0x6001991")]
			public abstract void EliteBossChallenge(RogueLikeRunTimeData runTimeData, BossData.BossDataContext bossDataContext, IncomeControllerRogueLike statusDisplay, RogueLikeManager roguelikeManager);

			// Token: 0x06001992 RID: 6546
			[Token(Token = "0x6001992")]
			public abstract IEnumerator EliteBossSpellCardDeclaration(EventManager eventManager, RogueLikeRunTimeData runTimeData);

			// Token: 0x06001993 RID: 6547 RVA: 0x00009D38 File Offset: 0x00007F38
			[Token(Token = "0x6001993")]
			[Address(RVA = "0x476EA0", Offset = "0x4758A0", VA = "0x180476EA0", Slot = "9")]
			public virtual bool CheckNeedNoticeBeforeWork(RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, IzakayaConfigure izakayaConfigure, out string message)
			{
				return default(bool);
			}

			// Token: 0x06001994 RID: 6548 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001994")]
			[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
			protected EliteChallengeBase()
			{
			}

			// Token: 0x04001758 RID: 5976
			[Token(Token = "0x4001758")]
			protected const string CORE_KEY = "CORE";

			// Token: 0x04001759 RID: 5977
			[Token(Token = "0x4001759")]
			protected const string DLC1_KEY = "DLC1";

			// Token: 0x0400175A RID: 5978
			[Token(Token = "0x400175A")]
			protected const string DLC2_KEY = "DLC2";

			// Token: 0x0400175B RID: 5979
			[Token(Token = "0x400175B")]
			protected const string DLC3_KEY = "DLC3";

			// Token: 0x0400175C RID: 5980
			[Token(Token = "0x400175C")]
			protected const string DLC4_KEY = "DLC4";

			// Token: 0x0400175D RID: 5981
			[Token(Token = "0x400175D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private RogueLikeRunTimeData.EliteChallengeType m_ChallengeType;

			// Token: 0x0400175E RID: 5982
			[Token(Token = "0x400175E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private string m_MappingDLC;

			// Token: 0x0400175F RID: 5983
			[Token(Token = "0x400175F")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			private RogueLikeRunTimeData.EliteChallengeBase.EliteReward[] m_Rewards;

			// Token: 0x04001760 RID: 5984
			[Token(Token = "0x4001760")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[SerializeField]
			private GameObject m_BossUI;

			// Token: 0x04001761 RID: 5985
			[Token(Token = "0x4001761")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[SerializeField]
			private int m_BossId;

			// Token: 0x04001762 RID: 5986
			[Token(Token = "0x4001762")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			[SerializeField]
			private int m_BGMId;

			// Token: 0x02000452 RID: 1106
			[Token(Token = "0x2000452")]
			public enum EliteRewardType
			{
				// Token: 0x04001764 RID: 5988
				[Token(Token = "0x4001764")]
				Partner,
				// Token: 0x04001765 RID: 5989
				[Token(Token = "0x4001765")]
				EliteSGuest,
				// Token: 0x04001766 RID: 5990
				[Token(Token = "0x4001766")]
				Bev,
				// Token: 0x04001767 RID: 5991
				[Token(Token = "0x4001767")]
				Score
			}

			// Token: 0x02000453 RID: 1107
			[Token(Token = "0x2000453")]
			[Serializable]
			public struct EliteReward
			{
				// Token: 0x06001995 RID: 6549 RVA: 0x00009D50 File Offset: 0x00007F50
				[Token(Token = "0x6001995")]
				[Address(RVA = "0x4771D0", Offset = "0x475BD0", VA = "0x1804771D0")]
				public int GetRealScoreIntValue(RogueLikeRunTimeData runTimeData)
				{
					return 0;
				}

				// Token: 0x06001996 RID: 6550 RVA: 0x00009D68 File Offset: 0x00007F68
				[Token(Token = "0x6001996")]
				[Address(RVA = "0x4771A0", Offset = "0x475BA0", VA = "0x1804771A0")]
				public int GetRealBevIntValue(RogueLikeRunTimeData runTimeData)
				{
					return 0;
				}

				// Token: 0x06001997 RID: 6551 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6001997")]
				[Address(RVA = "0x477200", Offset = "0x475C00", VA = "0x180477200")]
				public string GetRewardDescription(RogueLikeRunTimeData runTimeData)
				{
					return null;
				}

				// Token: 0x06001998 RID: 6552 RVA: 0x00009D80 File Offset: 0x00007F80
				[Token(Token = "0x6001998")]
				[Address(RVA = "0x477560", Offset = "0x475F60", VA = "0x180477560")]
				public bool HasFinishedReward(RogueLikeRunTimeData runTimeData)
				{
					return default(bool);
				}

				// Token: 0x04001768 RID: 5992
				[Token(Token = "0x4001768")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[SerializeField]
				public RogueLikeRunTimeData.EliteChallengeBase.EliteRewardType RewardType;

				// Token: 0x04001769 RID: 5993
				[Token(Token = "0x4001769")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				[SerializeField]
				public int IntValue;

				// Token: 0x0400176A RID: 5994
				[Token(Token = "0x400176A")]
				[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				[SerializeField]
				public int[] IntArrayValue;
			}
		}

		// Token: 0x02000456 RID: 1110
		[Token(Token = "0x2000456")]
		public class EliteChallengeCache
		{
			// Token: 0x17000391 RID: 913
			// (get) Token: 0x0600199E RID: 6558 RVA: 0x00009DB0 File Offset: 0x00007FB0
			[Token(Token = "0x17000391")]
			public RogueLikeRunTimeData.EliteChallengeType ChallengeType
			{
				[Token(Token = "0x600199E")]
				[Address(RVA = "0x3E5870", Offset = "0x3E4270", VA = "0x1803E5870")]
				[CompilerGenerated]
				get
				{
					return RogueLikeRunTimeData.EliteChallengeType.幽冥试炼;
				}
			}

			// Token: 0x17000392 RID: 914
			// (get) Token: 0x0600199F RID: 6559 RVA: 0x00009DC8 File Offset: 0x00007FC8
			[Token(Token = "0x17000392")]
			public int CacheValue
			{
				[Token(Token = "0x600199F")]
				[Address(RVA = "0x403840", Offset = "0x402240", VA = "0x180403840")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000393 RID: 915
			// (get) Token: 0x060019A0 RID: 6560 RVA: 0x00009DE0 File Offset: 0x00007FE0
			// (set) Token: 0x060019A1 RID: 6561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000393")]
			public bool Finished
			{
				[Token(Token = "0x60019A0")]
				[Address(RVA = "0x438D10", Offset = "0x437710", VA = "0x180438D10")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60019A1")]
				[Address(RVA = "0x477190", Offset = "0x475B90", VA = "0x180477190")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000394 RID: 916
			// (get) Token: 0x060019A2 RID: 6562 RVA: 0x00009DF8 File Offset: 0x00007FF8
			// (set) Token: 0x060019A3 RID: 6563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000394")]
			public bool Active
			{
				[Token(Token = "0x60019A2")]
				[Address(RVA = "0x477170", Offset = "0x475B70", VA = "0x180477170")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60019A3")]
				[Address(RVA = "0x477180", Offset = "0x475B80", VA = "0x180477180")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000395 RID: 917
			// (get) Token: 0x060019A4 RID: 6564 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060019A5 RID: 6565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000395")]
			public string MapLabel
			{
				[Token(Token = "0x60019A4")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60019A5")]
				[Address(RVA = "0x3F2100", Offset = "0x3F0B00", VA = "0x1803F2100")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x060019A6 RID: 6566 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019A6")]
			[Address(RVA = "0x477060", Offset = "0x475A60", VA = "0x180477060")]
			public EliteChallengeCache(RogueLikeRunTimeData.EliteChallengeType challengeType, int cacheValue, string mapLabel)
			{
			}

			// Token: 0x060019A7 RID: 6567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019A7")]
			[Address(RVA = "0x4770C0", Offset = "0x475AC0", VA = "0x1804770C0")]
			public EliteChallengeCache(RogueLikeRunTimeData.EliteChallengeType challengeType, string mapLabel)
			{
			}

			// Token: 0x060019A8 RID: 6568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019A8")]
			[Address(RVA = "0x477110", Offset = "0x475B10", VA = "0x180477110")]
			[JsonConstructor]
			public EliteChallengeCache(RogueLikeRunTimeData.EliteChallengeType challengeType, int cacheValue, bool finished, bool active, string mapLabel)
			{
			}

			// Token: 0x060019A9 RID: 6569 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60019A9")]
			[Address(RVA = "0x477000", Offset = "0x475A00", VA = "0x180477000")]
			public RogueLikeRunTimeData.EliteChallengeBase GetEliteData(RogueLikeRunTimeData runTimeData)
			{
				return null;
			}
		}

		// Token: 0x02000457 RID: 1111
		[Token(Token = "0x2000457")]
		[JsonObject(MemberSerialization.OptIn)]
		public class RogueLikeProductPool : IDeepClonable<RogueLikeRunTimeData.RogueLikeProductPool>
		{
			// Token: 0x17000396 RID: 918
			// (get) Token: 0x060019AA RID: 6570 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000396")]
			public HashSet<int> RemainedProductPool
			{
				[Token(Token = "0x60019AA")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000397 RID: 919
			// (get) Token: 0x060019AB RID: 6571 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000397")]
			public HashSet<int> ObtainedProductPool
			{
				[Token(Token = "0x60019AB")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000398 RID: 920
			// (get) Token: 0x060019AC RID: 6572 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000398")]
			public HashSet<int> GachaProductPool
			{
				[Token(Token = "0x60019AC")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x060019AD RID: 6573 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019AD")]
			[Address(RVA = "0x47DF50", Offset = "0x47C950", VA = "0x18047DF50")]
			public RogueLikeProductPool()
			{
			}

			// Token: 0x060019AE RID: 6574 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019AE")]
			[Address(RVA = "0x47DE00", Offset = "0x47C800", VA = "0x18047DE00")]
			[JsonConstructor]
			public RogueLikeProductPool(HashSet<int> remainedProductPool, HashSet<int> obtainedProductPool, HashSet<int> gachaProductPool)
			{
			}

			// Token: 0x060019AF RID: 6575 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019AF")]
			[Address(RVA = "0x47DD00", Offset = "0x47C700", VA = "0x18047DD00")]
			public void SetCheckElementExistCallback(Func<int, bool> checkElementExistCallback)
			{
			}

			// Token: 0x060019B0 RID: 6576 RVA: 0x00009E10 File Offset: 0x00008010
			[Token(Token = "0x60019B0")]
			[Address(RVA = "0x47DB60", Offset = "0x47C560", VA = "0x18047DB60")]
			public bool CheckElementExist(int element)
			{
				return default(bool);
			}

			// Token: 0x060019B1 RID: 6577 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019B1")]
			[Address(RVA = "0x47DD10", Offset = "0x47C710", VA = "0x18047DD10")]
			public void TryGacha(int gachaNumPerWave, params int[] exceptIds)
			{
			}

			// Token: 0x060019B2 RID: 6578 RVA: 0x00009E28 File Offset: 0x00008028
			[Token(Token = "0x60019B2")]
			[Address(RVA = "0x47D7D0", Offset = "0x47C1D0", VA = "0x18047D7D0")]
			public bool AddToRemainedPool(IEnumerable<int> elements, out List<int> successAdd)
			{
				return default(bool);
			}

			// Token: 0x060019B3 RID: 6579 RVA: 0x00009E40 File Offset: 0x00008040
			[Token(Token = "0x60019B3")]
			[Address(RVA = "0x47D430", Offset = "0x47BE30", VA = "0x18047D430")]
			public bool AddToObtainedPool(IEnumerable<int> elements, out List<int> successAdd)
			{
				return default(bool);
			}

			// Token: 0x060019B4 RID: 6580 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60019B4")]
			[Address(RVA = "0x47DC30", Offset = "0x47C630", VA = "0x18047DC30", Slot = "4")]
			public RogueLikeRunTimeData.RogueLikeProductPool Clone()
			{
				return null;
			}

			// Token: 0x04001773 RID: 6003
			[Token(Token = "0x4001773")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[JsonProperty("Remained")]
			protected readonly HashSet<int> m_RemainedProductPool;

			// Token: 0x04001774 RID: 6004
			[Token(Token = "0x4001774")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[JsonProperty("Obtained")]
			protected readonly HashSet<int> m_ObtainedProductPool;

			// Token: 0x04001775 RID: 6005
			[Token(Token = "0x4001775")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[JsonProperty("Gacha")]
			protected readonly HashSet<int> m_GachaProductPool;

			// Token: 0x04001776 RID: 6006
			[Token(Token = "0x4001776")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Func<int, bool> m_CheckElementExistCallback;
		}

		// Token: 0x02000458 RID: 1112
		[Token(Token = "0x2000458")]
		public readonly struct DLCAreaCollectRate
		{
			// Token: 0x060019B5 RID: 6581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60019B5")]
			[Address(RVA = "0x476E80", Offset = "0x475880", VA = "0x180476E80")]
			public DLCAreaCollectRate(float wholeCollectRate, KeyValuePair<int, int> collectRecipeData, KeyValuePair<int, int> collectItemData, KeyValuePair<int, int> collectPartnerData, KeyValuePair<int, int> collectIzakayaData)
			{
			}

			// Token: 0x04001777 RID: 6007
			[Token(Token = "0x4001777")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly float WholeCollectRate;

			// Token: 0x04001778 RID: 6008
			[Token(Token = "0x4001778")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public readonly KeyValuePair<int, int> CollectRecipeData;

			// Token: 0x04001779 RID: 6009
			[Token(Token = "0x4001779")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public readonly KeyValuePair<int, int> CollectItemData;

			// Token: 0x0400177A RID: 6010
			[Token(Token = "0x400177A")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public readonly KeyValuePair<int, int> CollectPartnerData;

			// Token: 0x0400177B RID: 6011
			[Token(Token = "0x400177B")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public readonly KeyValuePair<int, int> CollectIzakayaData;
		}
	}
}
