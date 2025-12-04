using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using DEYU.Singletons;
using Il2CppDummyDll;
using NightScene;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace DayScene
{
	// Token: 0x0200021D RID: 541
	[Token(Token = "0x200021D")]
	[GenerateCleanupMethod]
	public class DaySceneDirector : MonoSingleton<DaySceneDirector>
	{
		// Token: 0x06000CD9 RID: 3289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CD9")]
		[Address(RVA = "0x8E8EE0", Offset = "0x8E78E0", VA = "0x1808E8EE0", Slot = "5")]
		protected override void OnInstanceDestroyed()
		{
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0x8E93A0", Offset = "0x8E7DA0", VA = "0x1808E93A0")]
		public void StartManualWorkSceneSession(int izakayaIndex, int[] dailyRecipes, int[] dailyBeverages, DaySceneDirector.IndexCookerPair[] cookerConfigurations, Action onFinish)
		{
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0x8E9140", Offset = "0x8E7B40", VA = "0x1808E9140")]
		public void StartKyoukoTutorial(int mapIndex = 0, [Optional] Action onFinishCallback, [Optional] Action onBackToDayCallback)
		{
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x8E9030", Offset = "0x8E7A30", VA = "0x1808E9030")]
		public void StartChallengeSession(NightSceneDirector.ChallengeType challengeType, bool doNotFadeOut, NightSceneDirector.Difficulty difficulty = NightSceneDirector.Difficulty.None, [Optional] int? overrideChallengeIzakayaId)
		{
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x8E9670", Offset = "0x8E8070", VA = "0x1808E9670")]
		private void StartWorkSceneChallengeSession(NightSceneDirector.ChallengeType challengeType, bool doNotFadeOut, NightSceneDirector.Difficulty difficulty = NightSceneDirector.Difficulty.None, [Optional] int? overrideChallengeIzakayaId)
		{
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CDE")]
		[Address(RVA = "0x8E95E0", Offset = "0x8E7FE0", VA = "0x1808E95E0")]
		private static void StartMusicGameChallengeSession(NightSceneDirector.ChallengeType challengeType)
		{
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x00005868 File Offset: 0x00003A68
		[Token(Token = "0x6000CDF")]
		[Address(RVA = "0x8E9560", Offset = "0x8E7F60", VA = "0x1808E9560")]
		private static UniTaskVoid StartMusicGameChallengeSessionAsyncInternal(NightSceneDirector.ChallengeType challengeType)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x8E8E00", Offset = "0x8E7800", VA = "0x1808E8E00")]
		public void MoveToMap(string targetMapLabel, string targetMarkerName, bool shouldCostAction, bool shouldFadeInFadeOut, bool triggerEnterMapEvent, Action onFinishCallback)
		{
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0x8E8B20", Offset = "0x8E7520", VA = "0x1808E8B20")]
		public void GiveResource(int resourceCode)
		{
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0x8E8F30", Offset = "0x8E7930", VA = "0x1808E8F30")]
		public void SetSelectedMap(string mapLabel)
		{
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CE3")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CE4")]
		[Address(RVA = "0x8E99D0", Offset = "0x8E83D0", VA = "0x1808E99D0")]
		public DaySceneDirector()
		{
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CE5")]
		[Address(RVA = "0x8E9880", Offset = "0x8E8280", VA = "0x1808E9880")]
		[CompilerGenerated]
		internal static void <StartKyoukoTutorial>g__OnLoadedSceneReady|6_1()
		{
		}

		// Token: 0x04000B69 RID: 2921
		[Token(Token = "0x4000B69")]
		public const string OPTION_SELECTDIFFICULTY_EASY = "SELECT_DIFFICULTY_MODE_EASY";

		// Token: 0x04000B6A RID: 2922
		[Token(Token = "0x4000B6A")]
		public const string OPTION_SELECTDIFFICULTY_NORMAL = "SELECT_DIFFICULTY_MODE_NORMAL";

		// Token: 0x04000B6B RID: 2923
		[Token(Token = "0x4000B6B")]
		public const string OPTION_SELECTDIFFICULTY_HARD = "SELECT_DIFFICULTY_MODE_HARD";

		// Token: 0x04000B6C RID: 2924
		[Token(Token = "0x4000B6C")]
		public const string OPTION_SELECTDIFFICULTY_LUNATIC = "SELECT_DIFFICULTY_MODE_LUNATIC";

		// Token: 0x0200021E RID: 542
		[Token(Token = "0x200021E")]
		[Serializable]
		public struct IndexCookerPair
		{
			// Token: 0x04000B6D RID: 2925
			[Token(Token = "0x4000B6D")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			public int index;

			// Token: 0x04000B6E RID: 2926
			[Token(Token = "0x4000B6E")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[SerializeField]
			public int id;
		}
	}
}
