using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common;
using Cysharp.Threading.Tasks;
using DayScene;
using DEYU.AssetHandleUtility;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using UnityEngine.AddressableAssets;

namespace GameData.Core.Collections.DaySceneUtility
{
	// Token: 0x02000AF0 RID: 2800
	[Token(Token = "0x2000AF0")]
	public static class DataBaseDay
	{
		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x0600435F RID: 17247 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004360 RID: 17248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009A8")]
		private static Dictionary<string, string> AllCollectablesMapping
		{
			[Token(Token = "0x600435F")]
			[Address(RVA = "0x7191C0", Offset = "0x717BC0", VA = "0x1807191C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004360")]
			[Address(RVA = "0x719380", Offset = "0x717D80", VA = "0x180719380")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06004361 RID: 17249 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004362 RID: 17250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009A9")]
		private static Dictionary<string, string> AllNPCsMapping
		{
			[Token(Token = "0x6004361")]
			[Address(RVA = "0x719280", Offset = "0x717C80", VA = "0x180719280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004362")]
			[Address(RVA = "0x7194A0", Offset = "0x717EA0", VA = "0x1807194A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06004363 RID: 17251 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004364 RID: 17252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009AA")]
		public static Dictionary<string, string> AllMappedNPCsMapping
		{
			[Token(Token = "0x6004363")]
			[Address(RVA = "0x719200", Offset = "0x717C00", VA = "0x180719200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004364")]
			[Address(RVA = "0x7193E0", Offset = "0x717DE0", VA = "0x1807193E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06004365 RID: 17253 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004366 RID: 17254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009AB")]
		private static Dictionary<string, string> AllMerchantsMapping
		{
			[Token(Token = "0x6004365")]
			[Address(RVA = "0x719240", Offset = "0x717C40", VA = "0x180719240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004366")]
			[Address(RVA = "0x719440", Offset = "0x717E40", VA = "0x180719440")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06004367 RID: 17255 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004368 RID: 17256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009AC")]
		private static Dictionary<string, string> MapDataMapping
		{
			[Token(Token = "0x6004367")]
			[Address(RVA = "0x719340", Offset = "0x717D40", VA = "0x180719340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004368")]
			[Address(RVA = "0x7195C0", Offset = "0x717FC0", VA = "0x1807195C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06004369 RID: 17257 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600436A RID: 17258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009AD")]
		private static Dictionary<string, string> KourindoStaticMerchandiseMapping
		{
			[Token(Token = "0x6004369")]
			[Address(RVA = "0x719300", Offset = "0x717D00", VA = "0x180719300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600436A")]
			[Address(RVA = "0x719560", Offset = "0x717F60", VA = "0x180719560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x0600436B RID: 17259 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600436C RID: 17260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009AE")]
		private static Dictionary<int, string> FlandreHomeFurnitureMapping
		{
			[Token(Token = "0x600436B")]
			[Address(RVA = "0x7192C0", Offset = "0x717CC0", VA = "0x1807192C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600436C")]
			[Address(RVA = "0x719500", Offset = "0x717F00", VA = "0x180719500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600436D RID: 17261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436D")]
		[Address(RVA = "0x715C30", Offset = "0x714630", VA = "0x180715C30")]
		public static List<RunTimeScheduler.CGPicture> GetFanArtCG(string artLabel)
		{
			return null;
		}

		// Token: 0x0600436E RID: 17262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436E")]
		[Address(RVA = "0x715AA0", Offset = "0x7144A0", VA = "0x180715AA0")]
		public static string GetCollectablesDLCMapping(this string key)
		{
			return null;
		}

		// Token: 0x0600436F RID: 17263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600436F")]
		[Address(RVA = "0x716600", Offset = "0x715000", VA = "0x180716600")]
		public static string GetNPCDLCMapping(this string key)
		{
			return null;
		}

		// Token: 0x06004370 RID: 17264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004370")]
		[Address(RVA = "0x7163C0", Offset = "0x714DC0", VA = "0x1807163C0")]
		public static string GetMerchantsDLCMapping(this string key)
		{
			return null;
		}

		// Token: 0x06004371 RID: 17265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004371")]
		[Address(RVA = "0x7160B0", Offset = "0x714AB0", VA = "0x1807160B0")]
		public static string GetMapDataDLCMapping(this string key)
		{
			return null;
		}

		// Token: 0x06004372 RID: 17266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004372")]
		[Address(RVA = "0x716030", Offset = "0x714A30", VA = "0x180716030")]
		public static string GetKourindoStaticMerchandiseDLCMapping(this string key)
		{
			return null;
		}

		// Token: 0x06004373 RID: 17267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004373")]
		[Address(RVA = "0x715CA0", Offset = "0x7146A0", VA = "0x180715CA0")]
		public static string GetFlandreHomeFurnitureDataDLCMapping(this int key)
		{
			return null;
		}

		// Token: 0x06004374 RID: 17268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004374")]
		[Address(RVA = "0x7152C0", Offset = "0x713CC0", VA = "0x1807152C0")]
		public static int[] GetAllDaySceneNormalGuestIndex()
		{
			return null;
		}

		// Token: 0x06004375 RID: 17269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004375")]
		[Address(RVA = "0x715750", Offset = "0x714150", VA = "0x180715750")]
		public static IEnumerable<AssetReference> GetAllMapAssetReferences()
		{
			return null;
		}

		// Token: 0x06004376 RID: 17270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004376")]
		[Address(RVA = "0x7168A0", Offset = "0x7152A0", VA = "0x1807168A0")]
		public static void Initialize(Dictionary<string, DataBaseDay.DataBaseDayData> dayData, Dictionary<string, DialogPackage> dialogPackages, List<int> ignoreIngredients, List<int> missionIngredientsData, Dictionary<string, DaySceneMapProfile.MapNode> loadedMapRef, Dictionary<string, List<ExpandableGameDataPack.MapAdditiveData>> mapAdditiveData, List<int> onlyOneDayValidItems, List<SpecialGuestPublicExtraDialogData> publicExtraDiaglogSelectionsData, Dictionary<string, List<RunTimeScheduler.CGPicture>> fanArtCGData, Dictionary<string, MusicGameMappingProfile.MusicMapping> musicMapMapping, List<MusicGameChapterProfile.MusicChapter> musicChapterData)
		{
		}

		// Token: 0x06004377 RID: 17271 RVA: 0x000185B8 File Offset: 0x000167B8
		[Token(Token = "0x6004377")]
		[Address(RVA = "0x7184E0", Offset = "0x716EE0", VA = "0x1807184E0")]
		public static UniTask LoadSpecialGuestExtraDialogData()
		{
			return default(UniTask);
		}

		// Token: 0x06004378 RID: 17272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004378")]
		[Address(RVA = "0x718FC0", Offset = "0x7179C0", VA = "0x180718FC0")]
		public static void UnloadSpecialGuestExtraDialogData()
		{
		}

		// Token: 0x06004379 RID: 17273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004379")]
		[Address(RVA = "0x715110", Offset = "0x713B10", VA = "0x180715110")]
		public static SpecialGuestExtraDialogData DaySceneGetSpecialGuestExtraDialogData(this int specialGuestId)
		{
			return null;
		}

		// Token: 0x0600437A RID: 17274 RVA: 0x000185D0 File Offset: 0x000167D0
		[Token(Token = "0x600437A")]
		[Address(RVA = "0x714F90", Offset = "0x713990", VA = "0x180714F90")]
		public static bool DaySceneCheckSpecialGuestNotSkipGreeting(this int specialGuestId)
		{
			return default(bool);
		}

		// Token: 0x0600437B RID: 17275 RVA: 0x000185E8 File Offset: 0x000167E8
		[Token(Token = "0x600437B")]
		[Address(RVA = "0x715D20", Offset = "0x714720", VA = "0x180715D20")]
		public static ValueTuple<IReadOnlyList<int>, IReadOnlyList<int>, IReadOnlyList<int>> GetIzakayaDataFromDaySceneMapId(string daySceneMapData)
		{
			return default(ValueTuple<IReadOnlyList<int>, IReadOnlyList<int>, IReadOnlyList<int>>);
		}

		// Token: 0x0600437C RID: 17276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437C")]
		[Address(RVA = "0x715BA0", Offset = "0x7145A0", VA = "0x180715BA0")]
		public static string GetDaySceneMapDataFromIzakayaId(int izakayaId)
		{
			return null;
		}

		// Token: 0x0600437D RID: 17277 RVA: 0x00018600 File Offset: 0x00016800
		[Token(Token = "0x600437D")]
		[Address(RVA = "0x715E40", Offset = "0x714840", VA = "0x180715E40")]
		public static int GetIzakayaLevel(int izakayaId)
		{
			return 0;
		}

		// Token: 0x0600437E RID: 17278 RVA: 0x00018618 File Offset: 0x00016818
		[Token(Token = "0x600437E")]
		[Address(RVA = "0x718A30", Offset = "0x717430", VA = "0x180718A30")]
		public static KourindoStaticMerchandiseProfile.KourindoStaticMerchandise RefKourindoStaticMerchandise(this string label)
		{
			return default(KourindoStaticMerchandiseProfile.KourindoStaticMerchandise);
		}

		// Token: 0x0600437F RID: 17279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600437F")]
		[Address(RVA = "0x7155F0", Offset = "0x713FF0", VA = "0x1807155F0")]
		public static IEnumerable<string> GetAllKourindouLabels()
		{
			return null;
		}

		// Token: 0x06004380 RID: 17280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004380")]
		[Address(RVA = "0x715B20", Offset = "0x714520", VA = "0x180715B20")]
		public static string[] GetCollectablesFromMap(this string mapLabel)
		{
			return null;
		}

		// Token: 0x06004381 RID: 17281 RVA: 0x00018630 File Offset: 0x00016830
		[Token(Token = "0x6004381")]
		[Address(RVA = "0x718EB0", Offset = "0x7178B0", VA = "0x180718EB0")]
		public static UniTask<ValueTuple<IGameObjectAssetHandle<DaySceneMap>, DaySceneMap>> SpawnMapReferenceAsync(string mapLabel)
		{
			return default(UniTask<ValueTuple<IGameObjectAssetHandle<DaySceneMap>, DaySceneMap>>);
		}

		// Token: 0x06004382 RID: 17282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004382")]
		[Address(RVA = "0x716130", Offset = "0x714B30", VA = "0x180716130")]
		public static string GetMapLabelFromSpawnMarker(this string spawnMarker)
		{
			return null;
		}

		// Token: 0x06004383 RID: 17283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004383")]
		[Address(RVA = "0x7157B0", Offset = "0x7141B0", VA = "0x1807157B0")]
		public static IEnumerable<string> GetAllMaps()
		{
			return null;
		}

		// Token: 0x06004384 RID: 17284 RVA: 0x00018648 File Offset: 0x00016848
		[Token(Token = "0x6004384")]
		[Address(RVA = "0x714EB0", Offset = "0x7138B0", VA = "0x180714EB0")]
		public static bool CheckIngredientNotIgnore(int id)
		{
			return default(bool);
		}

		// Token: 0x06004385 RID: 17285 RVA: 0x00018660 File Offset: 0x00016860
		[Token(Token = "0x6004385")]
		[Address(RVA = "0x718310", Offset = "0x716D10", VA = "0x180718310")]
		public static bool IsMissionIngredient(int id)
		{
			return default(bool);
		}

		// Token: 0x06004386 RID: 17286 RVA: 0x00018678 File Offset: 0x00016878
		[Token(Token = "0x6004386")]
		[Address(RVA = "0x718370", Offset = "0x716D70", VA = "0x180718370")]
		public static bool IsMissionOrIgnoreIngredient(int id)
		{
			return default(bool);
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x00018690 File Offset: 0x00016890
		[Token(Token = "0x6004387")]
		[Address(RVA = "0x718410", Offset = "0x716E10", VA = "0x180718410")]
		public static bool IsOneDayValidItem(int id)
		{
			return default(bool);
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004388")]
		[Address(RVA = "0x715550", Offset = "0x713F50", VA = "0x180715550")]
		public static List<SpecialGuestPublicExtraDialogData> GetAllExtraDialogData()
		{
			return null;
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x000186A8 File Offset: 0x000168A8
		[Token(Token = "0x6004389")]
		[Address(RVA = "0x718B40", Offset = "0x717540", VA = "0x180718B40")]
		public static DaySceneMapProfile.MapNode RefMapNode(this string mapLabel)
		{
			return default(DaySceneMapProfile.MapNode);
		}

		// Token: 0x0600438A RID: 17290 RVA: 0x000186C0 File Offset: 0x000168C0
		[Token(Token = "0x600438A")]
		[Address(RVA = "0x718230", Offset = "0x716C30", VA = "0x180718230")]
		public static bool IsMapNodePresent(this string mapLabel)
		{
			return default(bool);
		}

		// Token: 0x0600438B RID: 17291 RVA: 0x000186D8 File Offset: 0x000168D8
		[Token(Token = "0x600438B")]
		[Address(RVA = "0x718780", Offset = "0x717180", VA = "0x180718780")]
		public static Collectable RefCollectable(this string key)
		{
			return default(Collectable);
		}

		// Token: 0x0600438C RID: 17292 RVA: 0x000186F0 File Offset: 0x000168F0
		[Token(Token = "0x600438C")]
		[Address(RVA = "0x718DA0", Offset = "0x7177A0", VA = "0x180718DA0")]
		public static NPC RefNPC(this string key)
		{
			return default(NPC);
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600438D")]
		[Address(RVA = "0x715A40", Offset = "0x714440", VA = "0x180715A40")]
		public static IEnumerable<string> GetAllNPCKeys()
		{
			return null;
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x00018708 File Offset: 0x00016908
		[Token(Token = "0x600438E")]
		[Address(RVA = "0x718C10", Offset = "0x717610", VA = "0x180718C10")]
		public static Merchant RefMerchant(this string key)
		{
			return default(Merchant);
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x00018720 File Offset: 0x00016920
		[Token(Token = "0x600438F")]
		[Address(RVA = "0x7182A0", Offset = "0x716CA0", VA = "0x1807182A0")]
		public static bool IsMerchant(this string key)
		{
			return default(bool);
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004390")]
		[Address(RVA = "0x718890", Offset = "0x717290", VA = "0x180718890")]
		public static DialogPackage RefDialogPackage(this string key)
		{
			return null;
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x00018738 File Offset: 0x00016938
		[Token(Token = "0x6004391")]
		[Address(RVA = "0x7181B0", Offset = "0x716BB0", VA = "0x1807181B0")]
		public static bool IsDialogPackage(this string key)
		{
			return default(bool);
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004392")]
		[Address(RVA = "0x715280", Offset = "0x713C80", VA = "0x180715280")]
		public static Dictionary<string, HashSet<string>> GetAllCollectableLabels()
		{
			return null;
		}

		// Token: 0x06004393 RID: 17299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004393")]
		[Address(RVA = "0x716730", Offset = "0x715130", VA = "0x180716730")]
		public static KeyValuePair<string, string>[] GetRegionMappingData()
		{
			return null;
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x00018750 File Offset: 0x00016950
		[Token(Token = "0x6004394")]
		[Address(RVA = "0x716890", Offset = "0x715290", VA = "0x180716890")]
		public static int HoursToActions(this int hour)
		{
			return 0;
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004395")]
		[Address(RVA = "0x7185F0", Offset = "0x716FF0", VA = "0x1807185F0")]
		public static string MapNPCIdentity(SceneDirector.Identity identity, int id)
		{
			return null;
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004396")]
		[Address(RVA = "0x715810", Offset = "0x714210", VA = "0x180715810")]
		public static IEnumerable<MusicGameMappingProfile.MusicMapping> GetAllMusicChapterCollection()
		{
			return null;
		}

		// Token: 0x06004397 RID: 17303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004397")]
		[Address(RVA = "0x7162A0", Offset = "0x714CA0", VA = "0x1807162A0")]
		public static string[] GetMapMusicLabels(string mapLabel)
		{
			return null;
		}

		// Token: 0x06004398 RID: 17304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004398")]
		[Address(RVA = "0x716440", Offset = "0x714E40", VA = "0x180716440")]
		public static string GetMusicChapterMap(string musicLabel)
		{
			return null;
		}

		// Token: 0x06004399 RID: 17305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004399")]
		[Address(RVA = "0x716330", Offset = "0x714D30", VA = "0x180716330")]
		public static string[] GetMapMusicUnlockedLabels(string mapLabel)
		{
			return null;
		}

		// Token: 0x0600439A RID: 17306 RVA: 0x00018768 File Offset: 0x00016968
		[Token(Token = "0x600439A")]
		[Address(RVA = "0x718CB0", Offset = "0x7176B0", VA = "0x180718CB0")]
		public static MusicGameChapterProfile.MusicChapter RefMusicChapter(this string musicLabel)
		{
			return default(MusicGameChapterProfile.MusicChapter);
		}

		// Token: 0x0600439B RID: 17307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600439B")]
		[Address(RVA = "0x715590", Offset = "0x713F90", VA = "0x180715590")]
		public static IEnumerable<int> GetAllFurnitures()
		{
			return null;
		}

		// Token: 0x0600439C RID: 17308 RVA: 0x00018780 File Offset: 0x00016980
		[Token(Token = "0x600439C")]
		[Address(RVA = "0x718900", Offset = "0x717300", VA = "0x180718900")]
		public static FlandreHomeFurnitureProfile.FlandreHomeFurniture RefFurniture(this int label)
		{
			return default(FlandreHomeFurnitureProfile.FlandreHomeFurniture);
		}

		// Token: 0x0600439D RID: 17309 RVA: 0x00018798 File Offset: 0x00016998
		[Token(Token = "0x600439D")]
		[Address(RVA = "0x714F20", Offset = "0x713920", VA = "0x180714F20")]
		public static bool CollectableExists(string label)
		{
			return default(bool);
		}

		// Token: 0x0600439E RID: 17310 RVA: 0x000187B0 File Offset: 0x000169B0
		[Token(Token = "0x600439E")]
		[Address(RVA = "0x718710", Offset = "0x717110", VA = "0x180718710")]
		public static bool NPCExists(this string label)
		{
			return default(bool);
		}

		// Token: 0x0600439F RID: 17311 RVA: 0x000187C8 File Offset: 0x000169C8
		[Token(Token = "0x600439F")]
		[Address(RVA = "0x718580", Offset = "0x716F80", VA = "0x180718580")]
		public static bool MapExists(string label)
		{
			return default(bool);
		}

		// Token: 0x060043A0 RID: 17312 RVA: 0x000187E0 File Offset: 0x000169E0
		[Token(Token = "0x60043A0")]
		[Address(RVA = "0x718470", Offset = "0x716E70", VA = "0x180718470")]
		public static bool KourindouStaticMerchandiseExists(string label)
		{
			return default(bool);
		}

		// Token: 0x060043A1 RID: 17313 RVA: 0x000187F8 File Offset: 0x000169F8
		[Token(Token = "0x60043A1")]
		[Address(RVA = "0x715220", Offset = "0x713C20", VA = "0x180715220")]
		public static bool FlandreHomeFurnitureExists(int id)
		{
			return default(bool);
		}

		// Token: 0x04003B88 RID: 15240
		[Token(Token = "0x4003B88")]
		private const int HOUR_DIVISIONS = 2;

		// Token: 0x04003B89 RID: 15241
		[Token(Token = "0x4003B89")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, List<RunTimeScheduler.CGPicture>> fanArtCG;

		// Token: 0x04003B8A RID: 15242
		[Token(Token = "0x4003B8A")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, Collectable> allCollectables;

		// Token: 0x04003B8B RID: 15243
		[Token(Token = "0x4003B8B")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<string, NPC> allNPCs;

		// Token: 0x04003B8C RID: 15244
		[Token(Token = "0x4003B8C")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<string, DialogPackage> allDialogPackages;

		// Token: 0x04003B8D RID: 15245
		[Token(Token = "0x4003B8D")]
		[FieldOffset(Offset = "0x20")]
		private static Dictionary<string, Merchant> allMerchants;

		// Token: 0x04003B8E RID: 15246
		[Token(Token = "0x4003B8E")]
		[FieldOffset(Offset = "0x28")]
		private static Dictionary<string, DaySceneMapProfile.MapNode> mapData;

		// Token: 0x04003B8F RID: 15247
		[Token(Token = "0x4003B8F")]
		[FieldOffset(Offset = "0x30")]
		private static Dictionary<string, AssetReference> mapReference;

		// Token: 0x04003B90 RID: 15248
		[Token(Token = "0x4003B90")]
		[FieldOffset(Offset = "0x38")]
		private static Dictionary<int, string> izakayaIdToMap;

		// Token: 0x04003B91 RID: 15249
		[Token(Token = "0x4003B91")]
		[FieldOffset(Offset = "0x40")]
		private static Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise> kourindoStaticMerchandiseData;

		// Token: 0x04003B92 RID: 15250
		[Token(Token = "0x4003B92")]
		[FieldOffset(Offset = "0x48")]
		private static Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture> flandreHomeFurnitureData;

		// Token: 0x04003B93 RID: 15251
		[Token(Token = "0x4003B93")]
		[FieldOffset(Offset = "0x50")]
		private static List<int> globalIgnoreIngredients;

		// Token: 0x04003B94 RID: 15252
		[Token(Token = "0x4003B94")]
		[FieldOffset(Offset = "0x58")]
		private static List<int> missionIngredients;

		// Token: 0x04003B95 RID: 15253
		[Token(Token = "0x4003B95")]
		[FieldOffset(Offset = "0x60")]
		private static List<int> globalOnlyOneDayValidItems;

		// Token: 0x04003B96 RID: 15254
		[Token(Token = "0x4003B96")]
		[FieldOffset(Offset = "0x68")]
		private static List<SpecialGuestPublicExtraDialogData> globalPublicExtraDiaglogSelectionsData;

		// Token: 0x04003B97 RID: 15255
		[Token(Token = "0x4003B97")]
		[FieldOffset(Offset = "0x70")]
		private static Dictionary<string, HashSet<string>> allCollectablesLabels;

		// Token: 0x04003B98 RID: 15256
		[Token(Token = "0x4003B98")]
		[FieldOffset(Offset = "0x78")]
		private static Dictionary<string, HashSet<string>> allSpawnMarkerLabels;

		// Token: 0x04003B99 RID: 15257
		[Token(Token = "0x4003B99")]
		[FieldOffset(Offset = "0x80")]
		private static Dictionary<string, List<ExpandableGameDataPack.MapAdditiveData>> additiveMapData;

		// Token: 0x04003B9A RID: 15258
		[Token(Token = "0x4003B9A")]
		[FieldOffset(Offset = "0x88")]
		private static Dictionary<string, MusicGameMappingProfile.MusicMapping> globalMusicMapMappingData;

		// Token: 0x04003B9B RID: 15259
		[Token(Token = "0x4003B9B")]
		[FieldOffset(Offset = "0x90")]
		private static Dictionary<string, MusicGameChapterProfile.MusicChapter> globalMusicChapterData;

		// Token: 0x04003B9C RID: 15260
		[Token(Token = "0x4003B9C")]
		[FieldOffset(Offset = "0x98")]
		private static Dictionary<int, IAssetHandle<SpecialGuestExtraDialogData>> m_LoadedSpecialGuestDialogData;

		// Token: 0x02000AF1 RID: 2801
		[Token(Token = "0x2000AF1")]
		public class DataBaseDayData
		{
			// Token: 0x060043A2 RID: 17314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60043A2")]
			[Address(RVA = "0x714E00", Offset = "0x713800", VA = "0x180714E00")]
			public DataBaseDayData(Dictionary<string, Collectable> allCollectables, Dictionary<string, NPC> allNPCs, Dictionary<string, Merchant> allMerchants, Dictionary<string, DaySceneMapProfile.MapNode> mapData, Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise> kourindoStaticMerchandise, Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture> flandreHomeFurniture)
			{
			}

			// Token: 0x170009AF RID: 2479
			// (get) Token: 0x060043A3 RID: 17315 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060043A4 RID: 17316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170009AF")]
			internal Dictionary<string, Collectable> AllCollectables
			{
				[Token(Token = "0x60043A3")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60043A4")]
				[Address(RVA = "0x4A6ED0", Offset = "0x4A58D0", VA = "0x1804A6ED0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170009B0 RID: 2480
			// (get) Token: 0x060043A5 RID: 17317 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060043A6 RID: 17318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170009B0")]
			internal Dictionary<string, NPC> AllNPCs
			{
				[Token(Token = "0x60043A5")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60043A6")]
				[Address(RVA = "0x3FC090", Offset = "0x3FAA90", VA = "0x1803FC090")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170009B1 RID: 2481
			// (get) Token: 0x060043A7 RID: 17319 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060043A8 RID: 17320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170009B1")]
			internal Dictionary<string, Merchant> AllMerchants
			{
				[Token(Token = "0x60043A7")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60043A8")]
				[Address(RVA = "0x3F2100", Offset = "0x3F0B00", VA = "0x1803F2100")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170009B2 RID: 2482
			// (get) Token: 0x060043A9 RID: 17321 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060043AA RID: 17322 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170009B2")]
			internal Dictionary<string, DaySceneMapProfile.MapNode> MapData
			{
				[Token(Token = "0x60043A9")]
				[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60043AA")]
				[Address(RVA = "0x47DD00", Offset = "0x47C700", VA = "0x18047DD00")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170009B3 RID: 2483
			// (get) Token: 0x060043AB RID: 17323 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060043AC RID: 17324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170009B3")]
			internal Dictionary<string, KourindoStaticMerchandiseProfile.KourindoStaticMerchandise> KourindoStaticMerchandise
			{
				[Token(Token = "0x60043AB")]
				[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60043AC")]
				[Address(RVA = "0x531450", Offset = "0x52FE50", VA = "0x180531450")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170009B4 RID: 2484
			// (get) Token: 0x060043AD RID: 17325 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060043AE RID: 17326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170009B4")]
			internal Dictionary<int, FlandreHomeFurnitureProfile.FlandreHomeFurniture> FlandreHomeFurniture
			{
				[Token(Token = "0x60043AD")]
				[Address(RVA = "0x440280", Offset = "0x43EC80", VA = "0x180440280")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60043AE")]
				[Address(RVA = "0x4AD3C0", Offset = "0x4ABDC0", VA = "0x1804AD3C0")]
				[CompilerGenerated]
				set
				{
				}
			}
		}
	}
}
