using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Cysharp.Threading.Tasks;
using DayScene.UI.RogueLike;
using DEYU.Utils;
using GameData.RunTime.Common;
using GamePlatform.Systems;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Unity.Profiling;

namespace GameData.Utils
{
	// Token: 0x02000778 RID: 1912
	[Token(Token = "0x2000778")]
	public static class SaveManagement
	{
		// Token: 0x06002C6B RID: 11371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C6B")]
		[Address(RVA = "0x59C170", Offset = "0x59AB70", VA = "0x18059C170")]
		private static string GetRogueLikeSaveFolderPath(FileSystemHandle fileSystem)
		{
			return null;
		}

		// Token: 0x06002C6C RID: 11372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C6C")]
		[Address(RVA = "0x59C980", Offset = "0x59B380", VA = "0x18059C980")]
		private static string GetTestFlightRogueLikeSaveFolderPath(FileSystemHandle fileSystem)
		{
			return null;
		}

		// Token: 0x06002C6D RID: 11373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C6D")]
		[Address(RVA = "0x59C630", Offset = "0x59B030", VA = "0x18059C630")]
		private static string GetSaveFolderPath(FileSystemHandle fileSystem)
		{
			return null;
		}

		// Token: 0x06002C6E RID: 11374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C6E")]
		[Address(RVA = "0x59CD30", Offset = "0x59B730", VA = "0x18059CD30")]
		private static string GetTestFlightSaveFolderPath(FileSystemHandle fileSystem)
		{
			return null;
		}

		// Token: 0x06002C6F RID: 11375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C6F")]
		[Address(RVA = "0x59B940", Offset = "0x59A340", VA = "0x18059B940")]
		private static string GetBackupChildFolderPath(FileSystemHandle fileSystem)
		{
			return null;
		}

		// Token: 0x06002C70 RID: 11376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C70")]
		[Address(RVA = "0x59C890", Offset = "0x59B290", VA = "0x18059C890")]
		private static string GetSettingFolderPath(FileSystemHandle fileSystem)
		{
			return null;
		}

		// Token: 0x06002C71 RID: 11377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C71")]
		[Address(RVA = "0x59C7F0", Offset = "0x59B1F0", VA = "0x18059C7F0")]
		private static string GetSettingFilePath(FileSystemHandle fileSystem)
		{
			return null;
		}

		// Token: 0x06002C72 RID: 11378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C72")]
		[Address(RVA = "0x59C530", Offset = "0x59AF30", VA = "0x18059C530")]
		private static string GetSaveFilePath(int index, FileSystemHandle fileSystem)
		{
			return null;
		}

		// Token: 0x06002C73 RID: 11379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C73")]
		[Address(RVA = "0x59C070", Offset = "0x59AA70", VA = "0x18059C070")]
		private static string GetRogueLikeSaveFilePath(int index, FileSystemHandle fileSystem)
		{
			return null;
		}

		// Token: 0x06002C74 RID: 11380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C74")]
		[Address(RVA = "0x59C430", Offset = "0x59AE30", VA = "0x18059C430")]
		private static string GetRogueLikeTestFlightSaveFilePath(int index, FileSystemHandle fileSystem)
		{
			return null;
		}

		// Token: 0x06002C75 RID: 11381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C75")]
		[Address(RVA = "0x59BFD0", Offset = "0x59A9D0", VA = "0x18059BFD0")]
		private static string GetRogueLikeAcievementFilePath(FileSystemHandle fileSystem)
		{
			return null;
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C76")]
		[Address(RVA = "0x59C390", Offset = "0x59AD90", VA = "0x18059C390")]
		private static string GetRogueLikeTestFlightAcievementFilePath(FileSystemHandle fileSystem)
		{
			return null;
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C77")]
		[Address(RVA = "0x59BF10", Offset = "0x59A910", VA = "0x18059BF10")]
		private static string GetMusicSaveFilePath(FileSystemHandle fileSystem)
		{
			return null;
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C78")]
		[Address(RVA = "0x59BEE0", Offset = "0x59A8E0", VA = "0x18059BEE0")]
		private static string GetMusicSaveFileName()
		{
			return null;
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C79")]
		[Address(RVA = "0x59BAF0", Offset = "0x59A4F0", VA = "0x18059BAF0")]
		private static string GetBindingFilePath(FileSystemHandle fileSystem)
		{
			return null;
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C7A")]
		[Address(RVA = "0x59CBA0", Offset = "0x59B5A0", VA = "0x18059CBA0")]
		private static string GetTestFlightSaveFilePath(int index, FileSystemHandle fileSystem)
		{
			return null;
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C7B")]
		[Address(RVA = "0x599180", Offset = "0x597B80", VA = "0x180599180")]
		public static void ExitGameEX()
		{
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		[Token(Token = "0x6002C7C")]
		[Address(RVA = "0x5DEB30", Offset = "0x5DD530", VA = "0x1805DEB30")]
		public static UniTask UpdateSaveFileCache(bool showLoadingIndicator)
		{
			return default(UniTask);
		}

		// Token: 0x06002C7D RID: 11389 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		[Token(Token = "0x6002C7D")]
		[Address(RVA = "0x5DEA50", Offset = "0x5DD450", VA = "0x1805DEA50")]
		private static UniTask UpdateSaveFileCacheInternal(FileSystemHandle fileSystemHandle, bool showLoadingIndicator)
		{
			return default(UniTask);
		}

		// Token: 0x06002C7E RID: 11390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C7E")]
		[Address(RVA = "0x59B8A0", Offset = "0x59A2A0", VA = "0x18059B8A0")]
		public static IReadOnlyDictionary<LoadedSaveDataInfo, int> GetAllCachedPlayerSaveFiles()
		{
			return null;
		}

		// Token: 0x06002C7F RID: 11391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C7F")]
		[Address(RVA = "0x59B8F0", Offset = "0x59A2F0", VA = "0x18059B8F0")]
		public static IReadOnlyDictionary<int, LoadedRogueLikeSaveDataInfo> GetAllCachedRoguelikePlayerSaveFiles()
		{
			return null;
		}

		// Token: 0x06002C80 RID: 11392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C80")]
		[Address(RVA = "0x598B60", Offset = "0x597560", VA = "0x180598B60")]
		public static void ClearAllCachedRoguelikePlayerSaveFiles()
		{
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
		[Token(Token = "0x6002C81")]
		[Address(RVA = "0x5A1450", Offset = "0x59FE50", VA = "0x1805A1450")]
		private static UniTask<Dictionary<LoadedSaveDataInfo, int>> ReadAllPlayerSaveFilesAsync(FileSystemHandle fileSystemHandle, bool showLoadingIndicator)
		{
			return default(UniTask<Dictionary<LoadedSaveDataInfo, int>>);
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x0000FD08 File Offset: 0x0000DF08
		[Token(Token = "0x6002C82")]
		[Address(RVA = "0x5991E0", Offset = "0x597BE0", VA = "0x1805991E0")]
		private static bool FileNameValid(string raw)
		{
			return default(bool);
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x0000FD20 File Offset: 0x0000DF20
		[Token(Token = "0x6002C83")]
		[Address(RVA = "0x5A4000", Offset = "0x5A2A00", VA = "0x1805A4000")]
		private static bool TryParseFileName(string raw, out int fileIndex)
		{
			return default(bool);
		}

		// Token: 0x06002C84 RID: 11396 RVA: 0x0000FD38 File Offset: 0x0000DF38
		[Token(Token = "0x6002C84")]
		[Address(RVA = "0x5A34A0", Offset = "0x5A1EA0", VA = "0x1805A34A0")]
		private static bool RogueFileNameValid(string raw)
		{
			return default(bool);
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x0000FD50 File Offset: 0x0000DF50
		[Token(Token = "0x6002C85")]
		[Address(RVA = "0x5A4100", Offset = "0x5A2B00", VA = "0x1805A4100")]
		private static bool TryParseRogueFileName(string raw, out int fileIndex)
		{
			return default(bool);
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C86")]
		[Address(RVA = "0x598BE0", Offset = "0x5975E0", VA = "0x180598BE0")]
		public static void DisposeGameStatusAndBackToMainMenu()
		{
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C87")]
		[Address(RVA = "0x598D90", Offset = "0x597790", VA = "0x180598D90")]
		public static void DisposeGameStatusAndRewindDay(int rewindDay)
		{
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C88")]
		private static void ExtractValid<T>(Dictionary<string, T> allDLCPartial, ICollection<string> currentActiveDLC, out Dictionary<string, T> loadedData, out Dictionary<string, T> notLoadedData) where T : PlayerSaveFile.IExtractable<T>
		{
		}

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x06002C89 RID: 11401 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06002C8A RID: 11402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000024")]
		public static event Action OnWillLoadNewPlayerData
		{
			[Token(Token = "0x6002C89")]
			[Address(RVA = "0x5DF700", Offset = "0x5DE100", VA = "0x1805DF700")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002C8A")]
			[Address(RVA = "0x5DF800", Offset = "0x5DE200", VA = "0x1805DF800")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C8B")]
		[Address(RVA = "0x59D990", Offset = "0x59C390", VA = "0x18059D990")]
		public static void LoadPlayerData(PlayerSaveFile playerSaveFile)
		{
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C8C")]
		[Address(RVA = "0x59F5B0", Offset = "0x59DFB0", VA = "0x18059F5B0")]
		private static void NotifyAllAchievements(PlayerSaveFile playerSaveFile)
		{
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x0000FD68 File Offset: 0x0000DF68
		[Token(Token = "0x6002C8D")]
		[Address(RVA = "0x5A4200", Offset = "0x5A2C00", VA = "0x1805A4200")]
		private static PlayerSaveFile TryUpgradeSaveVersion(PlayerSaveFile playerSaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C8E")]
		private static List<T> TryGetCollectionValue<T>(Dictionary<int, List<T>> collection, int date)
		{
			return null;
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C8F")]
		[Address(RVA = "0x5A2D40", Offset = "0x5A1740", VA = "0x1805A2D40")]
		public static void ResetGameStates(bool uninstallStatusTracker = true)
		{
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x0000FD80 File Offset: 0x0000DF80
		[Token(Token = "0x6002C90")]
		[Address(RVA = "0x599090", Offset = "0x597A90", VA = "0x180599090")]
		private static UniTask<string> DownloadArchiveAsync(string fileName)
		{
			return default(UniTask<string>);
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C91")]
		[Address(RVA = "0x59BEB0", Offset = "0x59A8B0", VA = "0x18059BEB0")]
		public static string GetKey()
		{
			return null;
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C92")]
		[Address(RVA = "0x59CDE0", Offset = "0x59B7E0", VA = "0x18059CDE0")]
		private static void GiveInitialResources()
		{
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C93")]
		[Address(RVA = "0x59BB90", Offset = "0x59A590", VA = "0x18059BB90")]
		private static string GetCurrentSaveVersion()
		{
			return null;
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C94")]
		[Address(RVA = "0x59D6C0", Offset = "0x59C0C0", VA = "0x18059D6C0")]
		public static void LoadNewPlayerData()
		{
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x0000FD98 File Offset: 0x0000DF98
		[Token(Token = "0x6002C95")]
		[Address(RVA = "0x5A3FA0", Offset = "0x5A29A0", VA = "0x1805A3FA0")]
		public static bool TryGetLastPlayerSaveFileIndex(out int saveIndex)
		{
			return default(bool);
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x0000FDB0 File Offset: 0x0000DFB0
		[Token(Token = "0x6002C96")]
		[Address(RVA = "0x599300", Offset = "0x597D00", VA = "0x180599300")]
		private static PlayerSaveFile GenerateCurrentPlayerSaveData()
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002C97 RID: 11415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C97")]
		[Address(RVA = "0x59BCC0", Offset = "0x59A6C0", VA = "0x18059BCC0")]
		private static Dictionary<int, List<string>> GetInitialEventData()
		{
			return null;
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		[Token(Token = "0x6002C98")]
		[Address(RVA = "0x599B60", Offset = "0x598560", VA = "0x180599B60")]
		private static PlayerSaveFile GenerateNewPlayerSaveData()
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C99")]
		[Address(RVA = "0x59B790", Offset = "0x59A190", VA = "0x18059B790")]
		private static string GenerateSaveString(PlayerSaveFile playerSaveData, Formatting formatting)
		{
			return null;
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C9A")]
		[Address(RVA = "0x59B680", Offset = "0x59A080", VA = "0x18059B680")]
		private static string GenerateSaveString(RogueLikeSaveData rogueLikeSaveData, Formatting formatting)
		{
			return null;
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		[Token(Token = "0x6002C9B")]
		[Address(RVA = "0x59B2C0", Offset = "0x599CC0", VA = "0x18059B2C0")]
		private static LoadedSaveDataInfo GenerateSaveData(string fileName, string playerSaveFile, bool isTestFlight)
		{
			return default(LoadedSaveDataInfo);
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		[Token(Token = "0x6002C9C")]
		[Address(RVA = "0x59B090", Offset = "0x599A90", VA = "0x18059B090")]
		private static LoadedRogueLikeSaveDataInfo GenerateRogueSaveData(string fileName, string playerSaveFile)
		{
			return default(LoadedRogueLikeSaveDataInfo);
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C9D")]
		[Address(RVA = "0x59D230", Offset = "0x59BC30", VA = "0x18059D230")]
		public static void LoadLastPlayerData(KeyValuePair<PlayerSaveFile, int> fallbackValue)
		{
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C9E")]
		[Address(RVA = "0x5A3AB0", Offset = "0x5A24B0", VA = "0x1805A3AB0")]
		public static void SaveBindingData(string data)
		{
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002C9F")]
		[Address(RVA = "0x5A3D00", Offset = "0x5A2700", VA = "0x1805A3D00")]
		public static void SaveSettingData(PlayerSettings playerSettings)
		{
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CA0")]
		[Address(RVA = "0x59CFE0", Offset = "0x59B9E0", VA = "0x18059CFE0")]
		public static string LoadBindingData()
		{
			return null;
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CA1")]
		[Address(RVA = "0x59F200", Offset = "0x59DC00", VA = "0x18059F200")]
		public static PlayerSettings LoadSettingData()
		{
			return null;
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CA2")]
		[Address(RVA = "0x5A0900", Offset = "0x59F300", VA = "0x1805A0900")]
		public static void PurgePlayerData(int slotIndex)
		{
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x0000FE10 File Offset: 0x0000E010
		[Token(Token = "0x6002CA3")]
		[Address(RVA = "0x5DEDC0", Offset = "0x5DD7C0", VA = "0x1805DEDC0")]
		public static UniTask<ValueTuple<string, string>> WriteCurrentPlayerDataToSlotAsync(int overrideSlot)
		{
			return default(UniTask<ValueTuple<string, string>>);
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x0000FE28 File Offset: 0x0000E028
		[Token(Token = "0x6002CA4")]
		[Address(RVA = "0x5DECB0", Offset = "0x5DD6B0", VA = "0x1805DECB0")]
		public static UniTask<bool> UploadPlayerSaveFileAsync(string fileName, string fileContent)
		{
			return default(UniTask<bool>);
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x0000FE40 File Offset: 0x0000E040
		[Token(Token = "0x6002CA5")]
		[Address(RVA = "0x5A3C40", Offset = "0x5A2640", VA = "0x1805A3C40")]
		public static UniTask SavePlayerMusicScoreData([TupleElementNames(new string[] { "EasyHighScore", "HardHighScore" })] Dictionary<string, ValueTuple<int, int>> data)
		{
			return default(UniTask);
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x0000FE58 File Offset: 0x0000E058
		[Token(Token = "0x6002CA6")]
		[Address(RVA = "0x5A1820", Offset = "0x5A0220", VA = "0x1805A1820")]
		public static UniTask<Dictionary<string, ValueTuple<int, int>>> ReadPlayerMusicScoreFile()
		{
			return default(UniTask<Dictionary<string, ValueTuple<int, int>>>);
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x0000FE70 File Offset: 0x0000E070
		[Token(Token = "0x6002CA7")]
		[Address(RVA = "0x5A1570", Offset = "0x59FF70", VA = "0x1805A1570")]
		private static bool ReadMusicSaveFile(FileSystemHandle fileSystemHandle, out PlayerMusicScoreSave playerMusicScoreSave)
		{
			return default(bool);
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x0000FE88 File Offset: 0x0000E088
		[Token(Token = "0x6002CA8")]
		[Address(RVA = "0x599920", Offset = "0x598320", VA = "0x180599920")]
		private static PlayerMusicScoreSave GenerateMusicData(string file)
		{
			return default(PlayerMusicScoreSave);
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
		[Token(Token = "0x6002CA9")]
		[Address(RVA = "0x5DEF20", Offset = "0x5DD920", VA = "0x1805DEF20")]
		public static UniTask<ValueTuple<string, string, Exception>> WriteRogueLikeSaveDataAsync(RogueLikeSaveData saveData, int associatedSaveIndex)
		{
			return default(UniTask<ValueTuple<string, string, Exception>>);
		}

		// Token: 0x06002CAA RID: 11434 RVA: 0x0000FEB8 File Offset: 0x0000E0B8
		[Token(Token = "0x6002CAA")]
		[Address(RVA = "0x5A1D70", Offset = "0x5A0770", VA = "0x1805A1D70")]
		public static UniTask<IReadOnlyDictionary<int, LoadedRogueLikeSaveDataInfo>> ReadRogueLikeSaveData()
		{
			return default(UniTask<IReadOnlyDictionary<int, LoadedRogueLikeSaveDataInfo>>);
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x0000FED0 File Offset: 0x0000E0D0
		[Token(Token = "0x6002CAB")]
		[Address(RVA = "0x5A1E50", Offset = "0x5A0850", VA = "0x1805A1E50")]
		public static UniTask<IReadOnlyDictionary<int, LoadedRogueLikeSaveDataInfo>> ReadRogueLikeSaveData(FileSystemHandle fileSystemHandle)
		{
			return default(UniTask<IReadOnlyDictionary<int, LoadedRogueLikeSaveDataInfo>>);
		}

		// Token: 0x06002CAC RID: 11436 RVA: 0x0000FEE8 File Offset: 0x0000E0E8
		[Token(Token = "0x6002CAC")]
		[Address(RVA = "0x5A3500", Offset = "0x5A1F00", VA = "0x1805A3500")]
		private static KeyValuePair<int, LoadedRogueLikeSaveDataInfo> RogueLikeParseTask(UnityEngineExtensionStatic.FileData loadInfo)
		{
			return default(KeyValuePair<int, LoadedRogueLikeSaveDataInfo>);
		}

		// Token: 0x06002CAD RID: 11437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CAD")]
		[Address(RVA = "0x5A10C0", Offset = "0x59FAC0", VA = "0x1805A10C0")]
		public static void PurgeRoguelikeSaveData(int slotIndex)
		{
		}

		// Token: 0x06002CAE RID: 11438 RVA: 0x0000FF00 File Offset: 0x0000E100
		[Token(Token = "0x6002CAE")]
		[Address(RVA = "0x5A2320", Offset = "0x5A0D20", VA = "0x1805A2320")]
		public static UniTask<RogueLikeAchievementSaveData?> ReadRoguelikeAchievementFile()
		{
			return default(UniTask<RogueLikeAchievementSaveData?>);
		}

		// Token: 0x06002CAF RID: 11439 RVA: 0x0000FF18 File Offset: 0x0000E118
		[Token(Token = "0x6002CAF")]
		[Address(RVA = "0x5A2420", Offset = "0x5A0E20", VA = "0x1805A2420")]
		public static UniTask<RogueLikeAchievementSaveData?> ReadRoguelikeAchievementFile(FileSystemHandle fileSystemHandle)
		{
			return default(UniTask<RogueLikeAchievementSaveData?>);
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x0000FF30 File Offset: 0x0000E130
		[Token(Token = "0x6002CB0")]
		[Address(RVA = "0x5A07D0", Offset = "0x59F1D0", VA = "0x1805A07D0")]
		private static RogueLikeAchievementSaveData? ProcessAchievementFile(string content)
		{
			return null;
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x0000FF48 File Offset: 0x0000E148
		[Token(Token = "0x6002CB1")]
		[Address(RVA = "0x5DF0D0", Offset = "0x5DDAD0", VA = "0x1805DF0D0")]
		public static UniTask WriteRoguelikeAchievementFile(RogueLikeAchievementSaveData rogueLikeAchievementSaveData, FileSystemHandle fileSystemHandle)
		{
			return default(UniTask);
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x0000FF60 File Offset: 0x0000E160
		[Token(Token = "0x6002CB2")]
		[Address(RVA = "0x5A1910", Offset = "0x5A0310", VA = "0x1805A1910")]
		private static bool ReadPlayerSaveFile(FileSystemHandle fileSystemHandle, int index, out PlayerSaveFile result)
		{
			return default(bool);
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x0000FF78 File Offset: 0x0000E178
		[Token(Token = "0x6002CB3")]
		[Address(RVA = "0x5A1F50", Offset = "0x5A0950", VA = "0x1805A1F50")]
		private static bool ReadRogueSaveFile(FileSystemHandle fileSystemHandle, int index, out RogueLikeSaveData? result)
		{
			return default(bool);
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x0000FF90 File Offset: 0x0000E190
		[Token(Token = "0x6002CB4")]
		[Address(RVA = "0x5A2550", Offset = "0x5A0F50", VA = "0x1805A2550")]
		private static UniTask ReadSaveDataAsync(FileSystemHandle fileSystemHandle, bool isTestFlight, IDictionary<LoadedSaveDataInfo, int> parsedData, bool showLoadingIndicator)
		{
			return default(UniTask);
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x0000FFA8 File Offset: 0x0000E1A8
		[Token(Token = "0x6002CB5")]
		[Address(RVA = "0x5A0490", Offset = "0x59EE90", VA = "0x1805A0490")]
		private static UniTask<ValueTuple<LoadedSaveDataInfo?, int>[]> ParseCore(FileSystemHandle fileSystemHandle, string folderPath, bool isTestFlight)
		{
			return default(UniTask<ValueTuple<LoadedSaveDataInfo?, int>[]>);
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		[Token(Token = "0x6002CB6")]
		[Address(RVA = "0x5A05D0", Offset = "0x59EFD0", VA = "0x1805A05D0")]
		private static UniTask<ValueTuple<LoadedSaveDataInfo?, int>> ParseTask(UnityEngineExtensionStatic.FileData loadInfo, bool isTestFlight)
		{
			return default(UniTask<ValueTuple<LoadedSaveDataInfo?, int>>);
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CB7")]
		[Address(RVA = "0x5A2660", Offset = "0x5A1060", VA = "0x1805A2660")]
		private static void RefreshBackupFile(FileSystemHandle fileSystem, int saveFileCount = 15)
		{
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CB8")]
		[Address(RVA = "0x59BBC0", Offset = "0x59A5C0", VA = "0x18059BBC0")]
		private static string GetDirectory(FileSystemHandle fileSystem, params string[] dirName)
		{
			return null;
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		[Token(Token = "0x6002CB9")]
		[Address(RVA = "0x5A3ED0", Offset = "0x5A28D0", VA = "0x1805A3ED0")]
		public static UniTask SyncFileWithSteam()
		{
			return default(UniTask);
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002CBA")]
		[Address(RVA = "0x5DEEC0", Offset = "0x5DD8C0", VA = "0x1805DEEC0")]
		private static void WriteFile(FileSystemHandle fileSystemHandle, string path, string content)
		{
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
		[Token(Token = "0x6002CBB")]
		[Address(RVA = "0x5DB780", Offset = "0x5DA180", VA = "0x1805DB780")]
		private static PlayerSaveFile TryUpgradeV9(PlayerSaveFile v9SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x00010008 File Offset: 0x0000E208
		[Token(Token = "0x6002CBC")]
		[Address(RVA = "0x5A4F90", Offset = "0x5A3990", VA = "0x1805A4F90")]
		private static PlayerSaveFile TryUpgradeV10(PlayerSaveFile v10SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CBD RID: 11453 RVA: 0x00010020 File Offset: 0x0000E220
		[Token(Token = "0x6002CBD")]
		[Address(RVA = "0x5A54F0", Offset = "0x5A3EF0", VA = "0x1805A54F0")]
		private static PlayerSaveFile TryUpgradeV11(PlayerSaveFile v11SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CBE RID: 11454 RVA: 0x00010038 File Offset: 0x0000E238
		[Token(Token = "0x6002CBE")]
		[Address(RVA = "0x5A5C30", Offset = "0x5A4630", VA = "0x1805A5C30")]
		private static PlayerSaveFile TryUpgradeV12(PlayerSaveFile v12SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CBF RID: 11455 RVA: 0x00010050 File Offset: 0x0000E250
		[Token(Token = "0x6002CBF")]
		[Address(RVA = "0x5A60B0", Offset = "0x5A4AB0", VA = "0x1805A60B0")]
		private static PlayerSaveFile TryUpgradeV13(PlayerSaveFile v13SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x00010068 File Offset: 0x0000E268
		[Token(Token = "0x6002CC0")]
		[Address(RVA = "0x5A6500", Offset = "0x5A4F00", VA = "0x1805A6500")]
		private static PlayerSaveFile TryUpgradeV14(PlayerSaveFile v14SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x00010080 File Offset: 0x0000E280
		[Token(Token = "0x6002CC1")]
		[Address(RVA = "0x5A7790", Offset = "0x5A6190", VA = "0x1805A7790")]
		private static PlayerSaveFile TryUpgradeV15(PlayerSaveFile v15SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x00010098 File Offset: 0x0000E298
		[Token(Token = "0x6002CC2")]
		[Address(RVA = "0x5A8450", Offset = "0x5A6E50", VA = "0x1805A8450")]
		private static PlayerSaveFile TryUpgradeV16(PlayerSaveFile v16SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x000100B0 File Offset: 0x0000E2B0
		[Token(Token = "0x6002CC3")]
		[Address(RVA = "0x5A8C50", Offset = "0x5A7650", VA = "0x1805A8C50")]
		private static PlayerSaveFile TryUpgradeV17(PlayerSaveFile v17SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x000100C8 File Offset: 0x0000E2C8
		[Token(Token = "0x6002CC4")]
		[Address(RVA = "0x5A9400", Offset = "0x5A7E00", VA = "0x1805A9400")]
		private static PlayerSaveFile TryUpgradeV18(PlayerSaveFile v18SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x000100E0 File Offset: 0x0000E2E0
		[Token(Token = "0x6002CC5")]
		[Address(RVA = "0x5A9890", Offset = "0x5A8290", VA = "0x1805A9890")]
		private static PlayerSaveFile TryUpgradeV19(PlayerSaveFile v19SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CC6 RID: 11462 RVA: 0x000100F8 File Offset: 0x0000E2F8
		[Token(Token = "0x6002CC6")]
		[Address(RVA = "0x5AA090", Offset = "0x5A8A90", VA = "0x1805AA090")]
		private static PlayerSaveFile TryUpgradeV20(PlayerSaveFile v20SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CC7 RID: 11463 RVA: 0x00010110 File Offset: 0x0000E310
		[Token(Token = "0x6002CC7")]
		[Address(RVA = "0x5AA9E0", Offset = "0x5A93E0", VA = "0x1805AA9E0")]
		private static PlayerSaveFile TryUpgradeV21(PlayerSaveFile v21SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CC8 RID: 11464 RVA: 0x00010128 File Offset: 0x0000E328
		[Token(Token = "0x6002CC8")]
		[Address(RVA = "0x5AAE00", Offset = "0x5A9800", VA = "0x1805AAE00")]
		private static PlayerSaveFile TryUpgradeV22(PlayerSaveFile v22SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x00010140 File Offset: 0x0000E340
		[Token(Token = "0x6002CC9")]
		[Address(RVA = "0x5AB4F0", Offset = "0x5A9EF0", VA = "0x1805AB4F0")]
		private static PlayerSaveFile TryUpgradeV23(PlayerSaveFile v23SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x00010158 File Offset: 0x0000E358
		[Token(Token = "0x6002CCA")]
		[Address(RVA = "0x5AB980", Offset = "0x5AA380", VA = "0x1805AB980")]
		private static PlayerSaveFile TryUpgradeV24(PlayerSaveFile v24SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CCB RID: 11467 RVA: 0x00010170 File Offset: 0x0000E370
		[Token(Token = "0x6002CCB")]
		[Address(RVA = "0x5AC8B0", Offset = "0x5AB2B0", VA = "0x1805AC8B0")]
		private static PlayerSaveFile TryUpgradeV25(PlayerSaveFile v25SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CCC RID: 11468 RVA: 0x00010188 File Offset: 0x0000E388
		[Token(Token = "0x6002CCC")]
		[Address(RVA = "0x5AE030", Offset = "0x5ACA30", VA = "0x1805AE030")]
		private static PlayerSaveFile TryUpgradeV26(PlayerSaveFile v26SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x000101A0 File Offset: 0x0000E3A0
		[Token(Token = "0x6002CCD")]
		[Address(RVA = "0x5AE5B0", Offset = "0x5ACFB0", VA = "0x1805AE5B0")]
		private static PlayerSaveFile TryUpgradeV27(PlayerSaveFile v27SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x000101B8 File Offset: 0x0000E3B8
		[Token(Token = "0x6002CCE")]
		[Address(RVA = "0x5AF6C0", Offset = "0x5AE0C0", VA = "0x1805AF6C0")]
		private static PlayerSaveFile TryUpgradeV28(PlayerSaveFile v28SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x000101D0 File Offset: 0x0000E3D0
		[Token(Token = "0x6002CCF")]
		[Address(RVA = "0x5AFB00", Offset = "0x5AE500", VA = "0x1805AFB00")]
		private static PlayerSaveFile TryUpgradeV29(PlayerSaveFile v29SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x000101E8 File Offset: 0x0000E3E8
		[Token(Token = "0x6002CD0")]
		[Address(RVA = "0x5AFF40", Offset = "0x5AE940", VA = "0x1805AFF40")]
		private static PlayerSaveFile TryUpgradeV30(PlayerSaveFile v30SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CD1 RID: 11473 RVA: 0x00010200 File Offset: 0x0000E400
		[Token(Token = "0x6002CD1")]
		[Address(RVA = "0x5B08E0", Offset = "0x5AF2E0", VA = "0x1805B08E0")]
		private static PlayerSaveFile TryUpgradeV31(PlayerSaveFile v31SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CD2 RID: 11474 RVA: 0x00010218 File Offset: 0x0000E418
		[Token(Token = "0x6002CD2")]
		[Address(RVA = "0x5B0FE0", Offset = "0x5AF9E0", VA = "0x1805B0FE0")]
		private static PlayerSaveFile TryUpgradeV32(PlayerSaveFile v32SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x00010230 File Offset: 0x0000E430
		[Token(Token = "0x6002CD3")]
		[Address(RVA = "0x5B2420", Offset = "0x5B0E20", VA = "0x1805B2420")]
		private static PlayerSaveFile TryUpgradeV33(PlayerSaveFile v33SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x00010248 File Offset: 0x0000E448
		[Token(Token = "0x6002CD4")]
		[Address(RVA = "0x5B2760", Offset = "0x5B1160", VA = "0x1805B2760")]
		private static PlayerSaveFile TryUpgradeV34(PlayerSaveFile v34SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CD5 RID: 11477 RVA: 0x00010260 File Offset: 0x0000E460
		[Token(Token = "0x6002CD5")]
		[Address(RVA = "0x5B4930", Offset = "0x5B3330", VA = "0x1805B4930")]
		private static PlayerSaveFile TryUpgradeV35(PlayerSaveFile v35SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x00010278 File Offset: 0x0000E478
		[Token(Token = "0x6002CD6")]
		[Address(RVA = "0x5B4DE0", Offset = "0x5B37E0", VA = "0x1805B4DE0")]
		private static PlayerSaveFile TryUpgradeV36(PlayerSaveFile v36SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CD7 RID: 11479 RVA: 0x00010290 File Offset: 0x0000E490
		[Token(Token = "0x6002CD7")]
		[Address(RVA = "0x5B66E0", Offset = "0x5B50E0", VA = "0x1805B66E0")]
		private static PlayerSaveFile TryUpgradeV37(PlayerSaveFile v37SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x000102A8 File Offset: 0x0000E4A8
		[Token(Token = "0x6002CD8")]
		[Address(RVA = "0x5B77F0", Offset = "0x5B61F0", VA = "0x1805B77F0")]
		private static PlayerSaveFile TryUpgradeV38(PlayerSaveFile v38SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x000102C0 File Offset: 0x0000E4C0
		[Token(Token = "0x6002CD9")]
		[Address(RVA = "0x5B82B0", Offset = "0x5B6CB0", VA = "0x1805B82B0")]
		private static PlayerSaveFile TryUpgradeV39(PlayerSaveFile v39SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x000102D8 File Offset: 0x0000E4D8
		[Token(Token = "0x6002CDA")]
		[Address(RVA = "0x5B9DD0", Offset = "0x5B87D0", VA = "0x1805B9DD0")]
		private static PlayerSaveFile TryUpgradeV40(PlayerSaveFile v40SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x000102F0 File Offset: 0x0000E4F0
		[Token(Token = "0x6002CDB")]
		[Address(RVA = "0x5BA500", Offset = "0x5B8F00", VA = "0x1805BA500")]
		private static PlayerSaveFile TryUpgradeV41(PlayerSaveFile v41SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x00010308 File Offset: 0x0000E508
		[Token(Token = "0x6002CDC")]
		[Address(RVA = "0x5BD4C0", Offset = "0x5BBEC0", VA = "0x1805BD4C0")]
		private static PlayerSaveFile TryUpgradeV42(PlayerSaveFile v42SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x00010320 File Offset: 0x0000E520
		[Token(Token = "0x6002CDD")]
		[Address(RVA = "0x5BD770", Offset = "0x5BC170", VA = "0x1805BD770")]
		private static PlayerSaveFile TryUpgradeV43(PlayerSaveFile v42SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x00010338 File Offset: 0x0000E538
		[Token(Token = "0x6002CDE")]
		[Address(RVA = "0x5BDD40", Offset = "0x5BC740", VA = "0x1805BDD40")]
		private static PlayerSaveFile TryUpgradeV44(PlayerSaveFile v43SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x00010350 File Offset: 0x0000E550
		[Token(Token = "0x6002CDF")]
		[Address(RVA = "0x5BE370", Offset = "0x5BCD70", VA = "0x1805BE370")]
		private static PlayerSaveFile TryUpgradeV45(PlayerSaveFile v44SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x00010368 File Offset: 0x0000E568
		[Token(Token = "0x6002CE0")]
		[Address(RVA = "0x5BE7E0", Offset = "0x5BD1E0", VA = "0x1805BE7E0")]
		private static PlayerSaveFile TryUpgradeV46(PlayerSaveFile v45SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x00010380 File Offset: 0x0000E580
		[Token(Token = "0x6002CE1")]
		[Address(RVA = "0x5BFF40", Offset = "0x5BE940", VA = "0x1805BFF40")]
		private static PlayerSaveFile TryUpgradeV47(PlayerSaveFile v46SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CE2 RID: 11490 RVA: 0x00010398 File Offset: 0x0000E598
		[Token(Token = "0x6002CE2")]
		[Address(RVA = "0x5C04A0", Offset = "0x5BEEA0", VA = "0x1805C04A0")]
		private static PlayerSaveFile TryUpgradeV48(PlayerSaveFile v47SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CE3 RID: 11491 RVA: 0x000103B0 File Offset: 0x0000E5B0
		[Token(Token = "0x6002CE3")]
		[Address(RVA = "0x5C0B80", Offset = "0x5BF580", VA = "0x1805C0B80")]
		private static PlayerSaveFile TryUpgradeV49(PlayerSaveFile v48SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CE4 RID: 11492 RVA: 0x000103C8 File Offset: 0x0000E5C8
		[Token(Token = "0x6002CE4")]
		[Address(RVA = "0x5C1090", Offset = "0x5BFA90", VA = "0x1805C1090")]
		private static PlayerSaveFile TryUpgradeV50(PlayerSaveFile v49SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CE5 RID: 11493 RVA: 0x000103E0 File Offset: 0x0000E5E0
		[Token(Token = "0x6002CE5")]
		[Address(RVA = "0x5C17B0", Offset = "0x5C01B0", VA = "0x1805C17B0")]
		private static PlayerSaveFile TryUpgradeV51(PlayerSaveFile v50SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CE6 RID: 11494 RVA: 0x000103F8 File Offset: 0x0000E5F8
		[Token(Token = "0x6002CE6")]
		[Address(RVA = "0x5C3110", Offset = "0x5C1B10", VA = "0x1805C3110")]
		private static PlayerSaveFile TryUpgradeV52(PlayerSaveFile v51SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CE7 RID: 11495 RVA: 0x00010410 File Offset: 0x0000E610
		[Token(Token = "0x6002CE7")]
		[Address(RVA = "0x5C3B20", Offset = "0x5C2520", VA = "0x1805C3B20")]
		private static PlayerSaveFile TryUpgradeV53(PlayerSaveFile v52SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CE8 RID: 11496 RVA: 0x00010428 File Offset: 0x0000E628
		[Token(Token = "0x6002CE8")]
		[Address(RVA = "0x5C45F0", Offset = "0x5C2FF0", VA = "0x1805C45F0")]
		private static PlayerSaveFile TryUpgradeV54(PlayerSaveFile v53SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CE9 RID: 11497 RVA: 0x00010440 File Offset: 0x0000E640
		[Token(Token = "0x6002CE9")]
		[Address(RVA = "0x5C4B80", Offset = "0x5C3580", VA = "0x1805C4B80")]
		private static PlayerSaveFile TryUpgradeV55(PlayerSaveFile v54SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CEA RID: 11498 RVA: 0x00010458 File Offset: 0x0000E658
		[Token(Token = "0x6002CEA")]
		[Address(RVA = "0x5C5260", Offset = "0x5C3C60", VA = "0x1805C5260")]
		private static PlayerSaveFile TryUpgradeV56(PlayerSaveFile v55SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CEB RID: 11499 RVA: 0x00010470 File Offset: 0x0000E670
		[Token(Token = "0x6002CEB")]
		[Address(RVA = "0x5C54D0", Offset = "0x5C3ED0", VA = "0x1805C54D0")]
		private static PlayerSaveFile TryUpgradeV57(PlayerSaveFile v56SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CEC RID: 11500 RVA: 0x00010488 File Offset: 0x0000E688
		[Token(Token = "0x6002CEC")]
		[Address(RVA = "0x5C5B50", Offset = "0x5C4550", VA = "0x1805C5B50")]
		private static PlayerSaveFile TryUpgradeV58(PlayerSaveFile v57SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CED RID: 11501 RVA: 0x000104A0 File Offset: 0x0000E6A0
		[Token(Token = "0x6002CED")]
		[Address(RVA = "0x5C6260", Offset = "0x5C4C60", VA = "0x1805C6260")]
		private static PlayerSaveFile TryUpgradeV59(PlayerSaveFile v58SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CEE RID: 11502 RVA: 0x000104B8 File Offset: 0x0000E6B8
		[Token(Token = "0x6002CEE")]
		[Address(RVA = "0x5C64D0", Offset = "0x5C4ED0", VA = "0x1805C64D0")]
		private static PlayerSaveFile TryUpgradeV60(PlayerSaveFile v59SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CEF RID: 11503 RVA: 0x000104D0 File Offset: 0x0000E6D0
		[Token(Token = "0x6002CEF")]
		[Address(RVA = "0x5C6A90", Offset = "0x5C5490", VA = "0x1805C6A90")]
		private static PlayerSaveFile TryUpgradeV61(PlayerSaveFile v60SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x000104E8 File Offset: 0x0000E6E8
		[Token(Token = "0x6002CF0")]
		[Address(RVA = "0x5C7510", Offset = "0x5C5F10", VA = "0x1805C7510")]
		private static PlayerSaveFile TryUpgradeV62(PlayerSaveFile v61SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x00010500 File Offset: 0x0000E700
		[Token(Token = "0x6002CF1")]
		[Address(RVA = "0x5C7FC0", Offset = "0x5C69C0", VA = "0x1805C7FC0")]
		private static PlayerSaveFile TryUpgradeV63(PlayerSaveFile v62SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x00010518 File Offset: 0x0000E718
		[Token(Token = "0x6002CF2")]
		[Address(RVA = "0x5C8990", Offset = "0x5C7390", VA = "0x1805C8990")]
		private static PlayerSaveFile TryUpgradeV64(PlayerSaveFile v63SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CF3 RID: 11507 RVA: 0x00010530 File Offset: 0x0000E730
		[Token(Token = "0x6002CF3")]
		[Address(RVA = "0x5C9600", Offset = "0x5C8000", VA = "0x1805C9600")]
		private static PlayerSaveFile TryUpgradeV65(PlayerSaveFile v64SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CF4 RID: 11508 RVA: 0x00010548 File Offset: 0x0000E748
		[Token(Token = "0x6002CF4")]
		[Address(RVA = "0x5C9DD0", Offset = "0x5C87D0", VA = "0x1805C9DD0")]
		private static PlayerSaveFile TryUpgradeV66(PlayerSaveFile v65SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x00010560 File Offset: 0x0000E760
		[Token(Token = "0x6002CF5")]
		[Address(RVA = "0x5CA960", Offset = "0x5C9360", VA = "0x1805CA960")]
		private static PlayerSaveFile TryUpgradeV67_68(PlayerSaveFile v66SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x00010578 File Offset: 0x0000E778
		[Token(Token = "0x6002CF6")]
		[Address(RVA = "0x5CAE60", Offset = "0x5C9860", VA = "0x1805CAE60")]
		private static PlayerSaveFile TryUpgradeV69(PlayerSaveFile v66SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CF7 RID: 11511 RVA: 0x00010590 File Offset: 0x0000E790
		[Token(Token = "0x6002CF7")]
		[Address(RVA = "0x5CB370", Offset = "0x5C9D70", VA = "0x1805CB370")]
		private static PlayerSaveFile TryUpgradeV70(PlayerSaveFile v66SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CF8 RID: 11512 RVA: 0x000105A8 File Offset: 0x0000E7A8
		[Token(Token = "0x6002CF8")]
		[Address(RVA = "0x5CBFB0", Offset = "0x5CA9B0", VA = "0x1805CBFB0")]
		private static PlayerSaveFile TryUpgradeV71(PlayerSaveFile v66SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CF9 RID: 11513 RVA: 0x000105C0 File Offset: 0x0000E7C0
		[Token(Token = "0x6002CF9")]
		[Address(RVA = "0x5CC550", Offset = "0x5CAF50", VA = "0x1805CC550")]
		private static PlayerSaveFile TryUpgradeV72(PlayerSaveFile v66SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CFA RID: 11514 RVA: 0x000105D8 File Offset: 0x0000E7D8
		[Token(Token = "0x6002CFA")]
		[Address(RVA = "0x5CC9E0", Offset = "0x5CB3E0", VA = "0x1805CC9E0")]
		private static PlayerSaveFile TryUpgradeV73(PlayerSaveFile v66SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CFB RID: 11515 RVA: 0x000105F0 File Offset: 0x0000E7F0
		[Token(Token = "0x6002CFB")]
		[Address(RVA = "0x5CCE70", Offset = "0x5CB870", VA = "0x1805CCE70")]
		private static PlayerSaveFile TryUpgradeV74(PlayerSaveFile v66SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CFC RID: 11516 RVA: 0x00010608 File Offset: 0x0000E808
		[Token(Token = "0x6002CFC")]
		[Address(RVA = "0x5CE540", Offset = "0x5CCF40", VA = "0x1805CE540")]
		private static PlayerSaveFile TryUpgradeV75(PlayerSaveFile v74SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CFD RID: 11517 RVA: 0x00010620 File Offset: 0x0000E820
		[Token(Token = "0x6002CFD")]
		[Address(RVA = "0x5CEFD0", Offset = "0x5CD9D0", VA = "0x1805CEFD0")]
		private static PlayerSaveFile TryUpgradeV76(PlayerSaveFile v75SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CFE RID: 11518 RVA: 0x00010638 File Offset: 0x0000E838
		[Token(Token = "0x6002CFE")]
		[Address(RVA = "0x5CF970", Offset = "0x5CE370", VA = "0x1805CF970")]
		private static PlayerSaveFile TryUpgradeV77(PlayerSaveFile v76SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002CFF RID: 11519 RVA: 0x00010650 File Offset: 0x0000E850
		[Token(Token = "0x6002CFF")]
		[Address(RVA = "0x5CFBE0", Offset = "0x5CE5E0", VA = "0x1805CFBE0")]
		private static PlayerSaveFile TryUpgradeV78(PlayerSaveFile v77SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x00010668 File Offset: 0x0000E868
		[Token(Token = "0x6002D00")]
		[Address(RVA = "0x5D0140", Offset = "0x5CEB40", VA = "0x1805D0140")]
		private static PlayerSaveFile TryUpgradeV79(PlayerSaveFile v78SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D01 RID: 11521 RVA: 0x00010680 File Offset: 0x0000E880
		[Token(Token = "0x6002D01")]
		[Address(RVA = "0x5D05A0", Offset = "0x5CEFA0", VA = "0x1805D05A0")]
		private static PlayerSaveFile TryUpgradeV80(PlayerSaveFile v79SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x00010698 File Offset: 0x0000E898
		[Token(Token = "0x6002D02")]
		[Address(RVA = "0x5D09D0", Offset = "0x5CF3D0", VA = "0x1805D09D0")]
		private static PlayerSaveFile TryUpgradeV81(PlayerSaveFile v80SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x000106B0 File Offset: 0x0000E8B0
		[Token(Token = "0x6002D03")]
		[Address(RVA = "0x5D0C40", Offset = "0x5CF640", VA = "0x1805D0C40")]
		private static PlayerSaveFile TryUpgradeV82(PlayerSaveFile v78SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D04 RID: 11524 RVA: 0x000106C8 File Offset: 0x0000E8C8
		[Token(Token = "0x6002D04")]
		[Address(RVA = "0x5D1410", Offset = "0x5CFE10", VA = "0x1805D1410")]
		private static PlayerSaveFile TryUpgradeV83(PlayerSaveFile v82SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x000106E0 File Offset: 0x0000E8E0
		[Token(Token = "0x6002D05")]
		[Address(RVA = "0x5D1C20", Offset = "0x5D0620", VA = "0x1805D1C20")]
		private static PlayerSaveFile TryUpgradeV84(PlayerSaveFile v83SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x000106F8 File Offset: 0x0000E8F8
		[Token(Token = "0x6002D06")]
		[Address(RVA = "0x5D2080", Offset = "0x5D0A80", VA = "0x1805D2080")]
		private static PlayerSaveFile TryUpgradeV85(PlayerSaveFile v84SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x00010710 File Offset: 0x0000E910
		[Token(Token = "0x6002D07")]
		[Address(RVA = "0x5D2E10", Offset = "0x5D1810", VA = "0x1805D2E10")]
		private static PlayerSaveFile TryUpgradeV86(PlayerSaveFile v85SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x00010728 File Offset: 0x0000E928
		[Token(Token = "0x6002D08")]
		[Address(RVA = "0x5D3CD0", Offset = "0x5D26D0", VA = "0x1805D3CD0")]
		private static PlayerSaveFile TryUpgradeV87(PlayerSaveFile v86SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x00010740 File Offset: 0x0000E940
		[Token(Token = "0x6002D09")]
		[Address(RVA = "0x5D3F40", Offset = "0x5D2940", VA = "0x1805D3F40")]
		private static PlayerSaveFile TryUpgradeV88(PlayerSaveFile v87SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x00010758 File Offset: 0x0000E958
		[Token(Token = "0x6002D0A")]
		[Address(RVA = "0x5D4570", Offset = "0x5D2F70", VA = "0x1805D4570")]
		private static PlayerSaveFile TryUpgradeV89(PlayerSaveFile v88SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x00010770 File Offset: 0x0000E970
		[Token(Token = "0x6002D0B")]
		[Address(RVA = "0x5D4EB0", Offset = "0x5D38B0", VA = "0x1805D4EB0")]
		private static PlayerSaveFile TryUpgradeV90(PlayerSaveFile v89SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x00010788 File Offset: 0x0000E988
		[Token(Token = "0x6002D0C")]
		[Address(RVA = "0x5D5650", Offset = "0x5D4050", VA = "0x1805D5650")]
		private static PlayerSaveFile TryUpgradeV91(PlayerSaveFile v90SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x000107A0 File Offset: 0x0000E9A0
		[Token(Token = "0x6002D0D")]
		[Address(RVA = "0x5D8230", Offset = "0x5D6C30", VA = "0x1805D8230")]
		private static PlayerSaveFile TryUpgradeV92(PlayerSaveFile v91SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x000107B8 File Offset: 0x0000E9B8
		[Token(Token = "0x6002D0E")]
		[Address(RVA = "0x5D8820", Offset = "0x5D7220", VA = "0x1805D8820")]
		private static PlayerSaveFile TryUpgradeV93(PlayerSaveFile v92SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x000107D0 File Offset: 0x0000E9D0
		[Token(Token = "0x6002D0F")]
		[Address(RVA = "0x5D9100", Offset = "0x5D7B00", VA = "0x1805D9100")]
		private static PlayerSaveFile TryUpgradeV94(PlayerSaveFile v91SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x000107E8 File Offset: 0x0000E9E8
		[Token(Token = "0x6002D10")]
		[Address(RVA = "0x5D9940", Offset = "0x5D8340", VA = "0x1805D9940")]
		private static PlayerSaveFile TryUpgradeV95(PlayerSaveFile v94SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x00010800 File Offset: 0x0000EA00
		[Token(Token = "0x6002D11")]
		[Address(RVA = "0x5D9F70", Offset = "0x5D8970", VA = "0x1805D9F70")]
		private static PlayerSaveFile TryUpgradeV96(PlayerSaveFile v95SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x00010818 File Offset: 0x0000EA18
		[Token(Token = "0x6002D12")]
		[Address(RVA = "0x5DAA60", Offset = "0x5D9460", VA = "0x1805DAA60")]
		private static PlayerSaveFile TryUpgradeV97(PlayerSaveFile v96SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x00010830 File Offset: 0x0000EA30
		[Token(Token = "0x6002D13")]
		[Address(RVA = "0x5DAE90", Offset = "0x5D9890", VA = "0x1805DAE90")]
		private static PlayerSaveFile TryUpgradeV98(PlayerSaveFile v97SaveFile)
		{
			return default(PlayerSaveFile);
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D15")]
		[Address(RVA = "0x5DD3C0", Offset = "0x5DBDC0", VA = "0x1805DD3C0")]
		[CompilerGenerated]
		internal static void <LoadPlayerData>g__TryAddGlobalData|80_9(int key, ref SaveManagement.<>c__DisplayClass80_1 A_1)
		{
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D16")]
		[Address(RVA = "0x5DD7C0", Offset = "0x5DC1C0", VA = "0x1805DD7C0")]
		[CompilerGenerated]
		internal static void <TryUpgradeV34>g__TryAdd|155_0(string missionLabel, int id, int amount, ref SaveManagement.<>c__DisplayClass155_0 A_3)
		{
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D17")]
		[Address(RVA = "0x5DD6B0", Offset = "0x5DC0B0", VA = "0x1805DD6B0")]
		[CompilerGenerated]
		internal static void <TryUpgradeV34>g__TryAddKourindo|155_1(string label, string[] finishedCollection, string[] merchandiseId, ref SaveManagement.<>c__DisplayClass155_0 A_3)
		{
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D18")]
		[Address(RVA = "0x5DD4B0", Offset = "0x5DBEB0", VA = "0x1805DD4B0")]
		[CompilerGenerated]
		internal static void <TryUpgradeV34>g__TryAddKizuna|155_2(string eventLabel, int id, ref SaveManagement.<>c__DisplayClass155_0 A_2)
		{
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D19")]
		[Address(RVA = "0x5DD9E0", Offset = "0x5DC3E0", VA = "0x1805DD9E0")]
		[CompilerGenerated]
		internal static void <TryUpgradeV35>g__TryAddKizuna|156_0(string eventLabel, int id, ref SaveManagement.<>c__DisplayClass156_0 A_2)
		{
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D1A")]
		[Address(RVA = "0x5DDC10", Offset = "0x5DC610", VA = "0x1805DDC10")]
		[CompilerGenerated]
		internal static void <TryUpgradeV36>g__TryAddAchievement|157_0(string eventLabel, ref SaveManagement.<>c__DisplayClass157_0 A_1)
		{
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D1B")]
		[Address(RVA = "0x5DDE00", Offset = "0x5DC800", VA = "0x1805DDE00")]
		[CompilerGenerated]
		internal static void <TryUpgradeV37>g__FinishMissionAcheivement|158_0(string missionLabel)
		{
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D1C")]
		[Address(RVA = "0x5DE480", Offset = "0x5DCE80", VA = "0x1805DE480")]
		[CompilerGenerated]
		internal static void <TryUpgradeV51>g__RepeatDialogeRewardEvent|172_3(string eventLabel, ref SaveManagement.<>c__DisplayClass172_0 A_1)
		{
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D1D")]
		[Address(RVA = "0x5DE640", Offset = "0x5DD040", VA = "0x1805DE640")]
		[CompilerGenerated]
		internal static void <TryUpgradeV51>g__RepeatDialogeRewardMission|172_4(string missionLabel, ref SaveManagement.<>c__DisplayClass172_0 A_1)
		{
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D1E")]
		[Address(RVA = "0x5DE070", Offset = "0x5DCA70", VA = "0x1805DE070")]
		[CompilerGenerated]
		internal static void <TryUpgradeV51>g__AddNPCDialogue|172_5(string characterLabel, string destinationLabel, string[] dialogPackageArray, ref SaveManagement.<>c__DisplayClass172_0 A_3)
		{
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D1F")]
		[Address(RVA = "0x5DE3D0", Offset = "0x5DCDD0", VA = "0x1805DE3D0")]
		[CompilerGenerated]
		internal static void <TryUpgradeV51>g__RemoveNPCDialoge|172_6(string characterLabel, string destinationLabel, string dialogPackage, ref SaveManagement.<>c__DisplayClass172_0 A_3)
		{
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D20")]
		[Address(RVA = "0x5DDE50", Offset = "0x5DC850", VA = "0x1805DDE50")]
		[CompilerGenerated]
		internal static void <TryUpgradeV51>g__AddNPCDialogeAfterEvent|172_7(string characterLabel, string destinationLabel, string[] dialogPackageArray, string targetEvent, ref SaveManagement.<>c__DisplayClass172_0 A_4)
		{
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D21")]
		[Address(RVA = "0x5DDF60", Offset = "0x5DC960", VA = "0x1805DDF60")]
		[CompilerGenerated]
		internal static void <TryUpgradeV51>g__AddNPCDialogeAfterMission|172_8(string characterLabel, string destinationLabel, string[] dialogPackageArray, string targetMission, ref SaveManagement.<>c__DisplayClass172_0 A_4)
		{
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D22")]
		[Address(RVA = "0x5DE2F0", Offset = "0x5DCCF0", VA = "0x1805DE2F0")]
		[CompilerGenerated]
		internal static void <TryUpgradeV51>g__RemoveNPCDialogeAfterEvent|172_9(string characterLabel, string destinationLabel, string dialogPackage, string targetEvent, ref SaveManagement.<>c__DisplayClass172_0 A_4)
		{
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D23")]
		[Address(RVA = "0x5DE150", Offset = "0x5DCB50", VA = "0x1805DE150")]
		[CompilerGenerated]
		internal static void <TryUpgradeV51>g__HideNPC|172_10(string characterLabel, string mapLabel)
		{
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D24")]
		[Address(RVA = "0x5DE800", Offset = "0x5DD200", VA = "0x1805DE800")]
		[CompilerGenerated]
		internal static void <TryUpgradeV51>g__ReturnNPC|172_11(string characterLabel)
		{
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002D25")]
		[Address(RVA = "0x5DE990", Offset = "0x5DD390", VA = "0x1805DE990")]
		[CompilerGenerated]
		internal static void <TryUpgradeV91>g__TryAdd|211_0(List<int> targetList, int[] ids)
		{
		}

		// Token: 0x0400287E RID: 10366
		[Token(Token = "0x400287E")]
		private const string ROOT = "Memory";

		// Token: 0x0400287F RID: 10367
		[Token(Token = "0x400287F")]
		private const string BACKUP_ROOT = "Backup";

		// Token: 0x04002880 RID: 10368
		[Token(Token = "0x4002880")]
		private const string BACKUP_SAVE_NAME = "Mystia";

		// Token: 0x04002881 RID: 10369
		[Token(Token = "0x4002881")]
		private const string BETA_SAVE_FOLDER = "BetaV9";

		// Token: 0x04002882 RID: 10370
		[Token(Token = "0x4002882")]
		private const string ROGUELIKE_SAVE_SUBFOLDER = "RogueLike";

		// Token: 0x04002883 RID: 10371
		[Token(Token = "0x4002883")]
		private const string TESTFLIGHT_ROGUELIKE_SAVE_SUBFOLDER = "RogueLike_TestFlight";

		// Token: 0x04002884 RID: 10372
		[Token(Token = "0x4002884")]
		private const string TESTFLIGHT_SAVE_FOLDER = "TestFlight";

		// Token: 0x04002885 RID: 10373
		[Token(Token = "0x4002885")]
		private const string SAVE_VERSION = "Save";

		// Token: 0x04002886 RID: 10374
		[Token(Token = "0x4002886")]
		private const string SAVE_EXTENSION = "memory";

		// Token: 0x04002887 RID: 10375
		[Token(Token = "0x4002887")]
		private const string ROGUE_SAVE_EXTENSION = "rmemory";

		// Token: 0x04002888 RID: 10376
		[Token(Token = "0x4002888")]
		private const string ROGUE_ACHIEVEMENT_FILE_NAME = "Mystia.rachievement";

		// Token: 0x04002889 RID: 10377
		[Token(Token = "0x4002889")]
		private const string SAVE_NAME = "Mystia";

		// Token: 0x0400288A RID: 10378
		[Token(Token = "0x400288A")]
		private const string ROGUELIKE_SAVE_NAME = "Mystia-RogueLike";

		// Token: 0x0400288B RID: 10379
		[Token(Token = "0x400288B")]
		private const string SAVE_NAME_MUSIC = "MusicBox";

		// Token: 0x0400288C RID: 10380
		[Token(Token = "0x400288C")]
		private const string SETTING_NAME = "Mystia";

		// Token: 0x0400288D RID: 10381
		[Token(Token = "0x400288D")]
		private const string SETTING_EXTENSION = "setting";

		// Token: 0x0400288E RID: 10382
		[Token(Token = "0x400288E")]
		private const string BINDING_NAME = "Mystia";

		// Token: 0x0400288F RID: 10383
		[Token(Token = "0x400288F")]
		private const string BINDING_EXTENSION = "binding";

		// Token: 0x04002890 RID: 10384
		[Token(Token = "0x4002890")]
		private const string CACHED_SAVEFILE_INDEX = "LAST_SAVED_SAVEFILE";

		// Token: 0x04002891 RID: 10385
		[Token(Token = "0x4002891")]
		private const string ENCRYPT_KEY = "MystiasRogueLike";

		// Token: 0x04002892 RID: 10386
		[Token(Token = "0x4002892")]
		private const int INITIAL_FUND = 0;

		// Token: 0x04002893 RID: 10387
		[Token(Token = "0x4002893")]
		private const string KEYSEGF = "Of";

		// Token: 0x04002894 RID: 10388
		[Token(Token = "0x4002894")]
		private const string KEYSEGA = "This";

		// Token: 0x04002895 RID: 10389
		[Token(Token = "0x4002895")]
		private const string KEYSEGB = "MystiaIzakaya";

		// Token: 0x04002896 RID: 10390
		[Token(Token = "0x4002896")]
		private const string KEYSEGC = "Is";

		// Token: 0x04002897 RID: 10391
		[Token(Token = "0x4002897")]
		private const string KEYSEGD = "A";

		// Token: 0x04002898 RID: 10392
		[Token(Token = "0x4002898")]
		private const string KEYSEGG = "Re0";

		// Token: 0x04002899 RID: 10393
		[Token(Token = "0x4002899")]
		private const string KEYSEGE = "Product";

		// Token: 0x0400289A RID: 10394
		[Token(Token = "0x400289A")]
		[FieldOffset(Offset = "0x0")]
		public static SaveManagement.NewGameMode newGameMode;

		// Token: 0x0400289B RID: 10395
		[Token(Token = "0x400289B")]
		private const bool TESTFLIGHT = false;

		// Token: 0x0400289C RID: 10396
		[Token(Token = "0x400289C")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<int, List<string>> additiveEvents;

		// Token: 0x0400289D RID: 10397
		[Token(Token = "0x400289D")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<int, List<RunTimeScheduler.TrackedMissionData>> additiveMissions;

		// Token: 0x0400289E RID: 10398
		[Token(Token = "0x400289E")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<int, List<string>> additiveNews;

		// Token: 0x0400289F RID: 10399
		[Token(Token = "0x400289F")]
		[FieldOffset(Offset = "0x20")]
		private static Dictionary<LoadedSaveDataInfo, int> s_CachedPlayerSaveFiles;

		// Token: 0x040028A0 RID: 10400
		[Token(Token = "0x40028A0")]
		[FieldOffset(Offset = "0x28")]
		private static Dictionary<int, LoadedRogueLikeSaveDataInfo> s_CachedRogueLikePlayerSaveFiles;

		// Token: 0x040028A1 RID: 10401
		[Token(Token = "0x40028A1")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Regex FileNameRegex;

		// Token: 0x040028A2 RID: 10402
		[Token(Token = "0x40028A2")]
		[FieldOffset(Offset = "0x38")]
		private static readonly Regex SaveFilePreProcessRegex;

		// Token: 0x040028A3 RID: 10403
		[Token(Token = "0x40028A3")]
		[FieldOffset(Offset = "0x40")]
		private static readonly Regex RogueLikeFileNameRegex;

		// Token: 0x040028A4 RID: 10404
		[Token(Token = "0x40028A4")]
		[FieldOffset(Offset = "0x48")]
		private static readonly JsonSerializerSettings m_JsonSerializerSettings;

		// Token: 0x040028A5 RID: 10405
		[Token(Token = "0x40028A5")]
		[FieldOffset(Offset = "0x50")]
		private static readonly int[] INITIAL_BEVERAGE;

		// Token: 0x040028A6 RID: 10406
		[Token(Token = "0x40028A6")]
		[FieldOffset(Offset = "0x58")]
		private static readonly int[] INITIAL_RECIPE;

		// Token: 0x040028A7 RID: 10407
		[Token(Token = "0x40028A7")]
		[FieldOffset(Offset = "0x60")]
		private static readonly int[] INITIAL_ALBUM_FOOD;

		// Token: 0x040028A8 RID: 10408
		[Token(Token = "0x40028A8")]
		[FieldOffset(Offset = "0x68")]
		private static readonly int[] INITIAL_COOKER;

		// Token: 0x040028A9 RID: 10409
		[Token(Token = "0x40028A9")]
		[FieldOffset(Offset = "0x70")]
		private static readonly int[] INITIAL_IZAKAYA;

		// Token: 0x040028AA RID: 10410
		[Token(Token = "0x40028AA")]
		[FieldOffset(Offset = "0x78")]
		private static readonly Dictionary<string, bool> INITIAL_OPENED_MAPS;

		// Token: 0x040028AB RID: 10411
		[Token(Token = "0x40028AB")]
		[FieldOffset(Offset = "0x80")]
		public static readonly string INITIAL_OPENED_MUSIC_MAP;

		// Token: 0x040028AD RID: 10413
		[Token(Token = "0x40028AD")]
		[FieldOffset(Offset = "0x90")]
		private static ProfilerMarker s_ReadSaveData_Parse;

		// Token: 0x040028AE RID: 10414
		[Token(Token = "0x40028AE")]
		private const string BETA_SAVE_VERSION = "BetaV99";

		// Token: 0x02000779 RID: 1913
		[Token(Token = "0x2000779")]
		public enum NewGameMode
		{
			// Token: 0x040028B0 RID: 10416
			[Token(Token = "0x40028B0")]
			IncludeTutorial,
			// Token: 0x040028B1 RID: 10417
			[Token(Token = "0x40028B1")]
			ExcludeTutorial,
			// Token: 0x040028B2 RID: 10418
			[Token(Token = "0x40028B2")]
			NoMission
		}
	}
}
