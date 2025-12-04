using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Common.UI;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AssetHandleUtility;
using DEYU.Utils;
using GameData;
using GameData.Core.Collections;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene.EventUtility;
using TMPro;
using Unity.Profiling;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace Common
{
	// Token: 0x02000D29 RID: 3369
	[Token(Token = "0x2000D29")]
	[GenerateCleanupMethod]
	public class LoadingSceneManager : MonoBehaviour
	{
		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06004E50 RID: 20048 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004E51 RID: 20049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B52")]
		[CleanupIgnore]
		public static string VersionData
		{
			[Token(Token = "0x6004E50")]
			[Address(RVA = "0x7B2610", Offset = "0x7B1010", VA = "0x1807B2610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E51")]
			[Address(RVA = "0x7B2930", Offset = "0x7B1330", VA = "0x1807B2930")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06004E52 RID: 20050 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004E53 RID: 20051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B53")]
		[CleanupIgnore]
		public static GameDataProfile LoadedGameDataProfile
		{
			[Token(Token = "0x6004E52")]
			[Address(RVA = "0x7B25C0", Offset = "0x7B0FC0", VA = "0x1807B25C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004E53")]
			[Address(RVA = "0x7B28C0", Offset = "0x7B12C0", VA = "0x1807B28C0")]
			private set
			{
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06004E54 RID: 20052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B54")]
		[CleanupIgnore]
		public static Dictionary<int, AssetReference> BufferedIzakayaMusicProfile
		{
			[Token(Token = "0x6004E54")]
			[Address(RVA = "0x7B1E90", Offset = "0x7B0890", VA = "0x1807B1E90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004E55 RID: 20053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E55")]
		[Address(RVA = "0x7AF680", Offset = "0x7AE080", VA = "0x1807AF680")]
		public static void NotifyLoadingSceneReady()
		{
		}

		// Token: 0x06004E56 RID: 20054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E56")]
		[Address(RVA = "0x3E5E00", Offset = "0x3E4800", VA = "0x1803E5E00")]
		private void OnDestroy()
		{
		}

		// Token: 0x06004E57 RID: 20055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E57")]
		[Address(RVA = "0x7ADEE0", Offset = "0x7AC8E0", VA = "0x1807ADEE0")]
		private void Awake()
		{
		}

		// Token: 0x06004E58 RID: 20056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E58")]
		[Address(RVA = "0x7ADC70", Offset = "0x7AC670", VA = "0x1807ADC70")]
		private void AppendErrorMessage(string errorMessage)
		{
		}

		// Token: 0x06004E59 RID: 20057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E59")]
		[Address(RVA = "0x7AF420", Offset = "0x7ADE20", VA = "0x1807AF420")]
		private void LoadingExceptionHandler(AsyncOperationHandle handle, Exception e)
		{
		}

		// Token: 0x06004E5A RID: 20058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E5A")]
		[Address(RVA = "0x7AF460", Offset = "0x7ADE60", VA = "0x1807AF460")]
		private void LoadingLogExceptionHandler(string condition, string stackTrace, LogType type)
		{
		}

		// Token: 0x06004E5B RID: 20059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E5B")]
		[Address(RVA = "0x7AE6E0", Offset = "0x7AD0E0", VA = "0x1807AE6E0")]
		private string[] CheckLogExceptionLabels(string message)
		{
			return null;
		}

		// Token: 0x06004E5C RID: 20060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E5C")]
		[Address(RVA = "0x7AF720", Offset = "0x7AE120", VA = "0x1807AF720")]
		private void SetupLoadingExceptionHandling(bool reg)
		{
		}

		// Token: 0x06004E5D RID: 20061 RVA: 0x0001C728 File Offset: 0x0001A928
		[Token(Token = "0x6004E5D")]
		[Address(RVA = "0x7AF5C0", Offset = "0x7ADFC0", VA = "0x1807AF5C0")]
		private UniTask MainLoadingCycle()
		{
			return default(UniTask);
		}

		// Token: 0x06004E5E RID: 20062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E5E")]
		[Address(RVA = "0x7AED20", Offset = "0x7AD720", VA = "0x1807AED20")]
		private void IncreaseOperationCount()
		{
		}

		// Token: 0x06004E5F RID: 20063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E5F")]
		[Address(RVA = "0x7AEBC0", Offset = "0x7AD5C0", VA = "0x1807AEBC0")]
		private void DeductOperationCount()
		{
		}

		// Token: 0x06004E60 RID: 20064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E60")]
		[Address(RVA = "0x7B1780", Offset = "0x7B0180", VA = "0x1807B1780")]
		private void UpdateGlobalProgress()
		{
		}

		// Token: 0x06004E61 RID: 20065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E61")]
		[Address(RVA = "0x7B1840", Offset = "0x7B0240", VA = "0x1807B1840")]
		private void UpdateProgress()
		{
		}

		// Token: 0x06004E62 RID: 20066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E62")]
		[Address(RVA = "0x7AF900", Offset = "0x7AE300", VA = "0x1807AF900")]
		private void ShowLoadingMessage(string message)
		{
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06004E63 RID: 20067 RVA: 0x0001C740 File Offset: 0x0001A940
		// (set) Token: 0x06004E64 RID: 20068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B55")]
		public static bool IsDependenciesLoaded
		{
			[Token(Token = "0x6004E63")]
			[Address(RVA = "0x7B2480", Offset = "0x7B0E80", VA = "0x1807B2480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004E64")]
			[Address(RVA = "0x7B2740", Offset = "0x7B1140", VA = "0x1807B2740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06004E65 RID: 20069 RVA: 0x0001C758 File Offset: 0x0001A958
		// (set) Token: 0x06004E66 RID: 20070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B56")]
		public static bool IsCoreLoaded
		{
			[Token(Token = "0x6004E65")]
			[Address(RVA = "0x7B23E0", Offset = "0x7B0DE0", VA = "0x1807B23E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004E66")]
			[Address(RVA = "0x7B2680", Offset = "0x7B1080", VA = "0x1807B2680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06004E67 RID: 20071 RVA: 0x0001C770 File Offset: 0x0001A970
		// (set) Token: 0x06004E68 RID: 20072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B57")]
		public static bool IsDayLoaded
		{
			[Token(Token = "0x6004E67")]
			[Address(RVA = "0x7B2430", Offset = "0x7B0E30", VA = "0x1807B2430")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004E68")]
			[Address(RVA = "0x7B26E0", Offset = "0x7B10E0", VA = "0x1807B26E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06004E69 RID: 20073 RVA: 0x0001C788 File Offset: 0x0001A988
		// (set) Token: 0x06004E6A RID: 20074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B58")]
		public static bool IsNightLoaded
		{
			[Token(Token = "0x6004E69")]
			[Address(RVA = "0x7B24D0", Offset = "0x7B0ED0", VA = "0x1807B24D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004E6A")]
			[Address(RVA = "0x7B27A0", Offset = "0x7B11A0", VA = "0x1807B27A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06004E6B RID: 20075 RVA: 0x0001C7A0 File Offset: 0x0001A9A0
		// (set) Token: 0x06004E6C RID: 20076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B59")]
		public static bool IsStaffLoaded
		{
			[Token(Token = "0x6004E6B")]
			[Address(RVA = "0x7B2520", Offset = "0x7B0F20", VA = "0x1807B2520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004E6C")]
			[Address(RVA = "0x7B2800", Offset = "0x7B1200", VA = "0x1807B2800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06004E6E RID: 20078 RVA: 0x0001C7B8 File Offset: 0x0001A9B8
		// (set) Token: 0x06004E6D RID: 20077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B5A")]
		private int GlobalOperationCount
		{
			[Token(Token = "0x6004E6E")]
			[Address(RVA = "0x48A7B0", Offset = "0x4891B0", VA = "0x18048A7B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004E6D")]
			[Address(RVA = "0x7B2660", Offset = "0x7B1060", VA = "0x1807B2660")]
			set
			{
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (set) Token: 0x06004E6F RID: 20079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B5B")]
		private int GlobalTotalOperationCount
		{
			[Token(Token = "0x6004E6F")]
			[Address(RVA = "0x7B2670", Offset = "0x7B1070", VA = "0x1807B2670")]
			set
			{
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06004E70 RID: 20080 RVA: 0x0001C7D0 File Offset: 0x0001A9D0
		// (set) Token: 0x06004E71 RID: 20081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B5C")]
		public static int IzakayaMapIndex
		{
			[Token(Token = "0x6004E70")]
			[Address(RVA = "0x7B2570", Offset = "0x7B0F70", VA = "0x1807B2570")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6004E71")]
			[Address(RVA = "0x7B2860", Offset = "0x7B1260", VA = "0x1807B2860")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004E72 RID: 20082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E72")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500")]
		private static void LoadLog(string logMessage)
		{
		}

		// Token: 0x06004E73 RID: 20083 RVA: 0x0001C7E8 File Offset: 0x0001A9E8
		[Token(Token = "0x6004E73")]
		[Address(RVA = "0x7AEEC0", Offset = "0x7AD8C0", VA = "0x1807AEEC0")]
		private UniTask LoadDependenciesAsync()
		{
			return default(UniTask);
		}

		// Token: 0x06004E74 RID: 20084 RVA: 0x0001C800 File Offset: 0x0001AA00
		[Token(Token = "0x6004E74")]
		[Address(RVA = "0x7AED40", Offset = "0x7AD740", VA = "0x1807AED40")]
		private UniTask LoadCoreAsync()
		{
			return default(UniTask);
		}

		// Token: 0x06004E75 RID: 20085 RVA: 0x0001C818 File Offset: 0x0001AA18
		[Token(Token = "0x6004E75")]
		[Address(RVA = "0x7AEE00", Offset = "0x7AD800", VA = "0x1807AEE00")]
		private UniTask LoadDayAsync()
		{
			return default(UniTask);
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x0001C830 File Offset: 0x0001AA30
		[Token(Token = "0x6004E76")]
		[Address(RVA = "0x7AF100", Offset = "0x7ADB00", VA = "0x1807AF100")]
		private UniTask LoadNight()
		{
			return default(UniTask);
		}

		// Token: 0x06004E77 RID: 20087 RVA: 0x0001C848 File Offset: 0x0001AA48
		[Token(Token = "0x6004E77")]
		[Address(RVA = "0x7AF290", Offset = "0x7ADC90", VA = "0x1807AF290")]
		private UniTask LoadStaffAsync()
		{
			return default(UniTask);
		}

		// Token: 0x06004E78 RID: 20088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E78")]
		private static Dictionary<TKey, TValue> CompareIndex<TKey, TValue>(Dictionary<TKey, TValue> languageSource, IEnumerable<TKey> indexes, Func<TKey, TValue> nullContent)
		{
			return null;
		}

		// Token: 0x06004E79 RID: 20089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E79")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500")]
		private void ShowGenerateLibraryLog(string libType)
		{
		}

		// Token: 0x06004E7A RID: 20090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E7A")]
		[Address(RVA = "0x3EE500", Offset = "0x3ECF00", VA = "0x1803EE500")]
		private void ShowGenerateLanguageLibraryLog(string libType)
		{
		}

		// Token: 0x06004E7B RID: 20091 RVA: 0x0001C860 File Offset: 0x0001AA60
		[Token(Token = "0x6004E7B")]
		[Address(RVA = "0x7AF040", Offset = "0x7ADA40", VA = "0x1807AF040")]
		private UniTask LoadIzakayaMusicPackageAsync()
		{
			return default(UniTask);
		}

		// Token: 0x06004E7C RID: 20092 RVA: 0x0001C878 File Offset: 0x0001AA78
		[Token(Token = "0x6004E7C")]
		[Address(RVA = "0x7AEF80", Offset = "0x7AD980", VA = "0x1807AEF80")]
		private UniTask LoadIzakayaMapAsync()
		{
			return default(UniTask);
		}

		// Token: 0x06004E7D RID: 20093 RVA: 0x0001C890 File Offset: 0x0001AA90
		[Token(Token = "0x6004E7D")]
		[Address(RVA = "0x7AF360", Offset = "0x7ADD60", VA = "0x1807AF360")]
		private UniTask LoadWorkSceneCharacterPortrayalAsync()
		{
			return default(UniTask);
		}

		// Token: 0x06004E7E RID: 20094 RVA: 0x0001C8A8 File Offset: 0x0001AAA8
		[Token(Token = "0x6004E7E")]
		[Address(RVA = "0x7AEBD0", Offset = "0x7AD5D0", VA = "0x1807AEBD0")]
		private static UniTask ExecuteTimed(Func<UniTask> uniTaskFactory, string profileString)
		{
			return default(UniTask);
		}

		// Token: 0x06004E7F RID: 20095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E7F")]
		[Address(RVA = "0x681350", Offset = "0x67FD50", VA = "0x180681350")]
		private static object DetachEditorAsset(object asset)
		{
			return null;
		}

		// Token: 0x06004E80 RID: 20096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E80")]
		private static IEnumerable<KeyValuePair<string, T[]>> GetAssets<T>(Func<ExpandableGameDataPack, T[]> getAssetCallback)
		{
			return null;
		}

		// Token: 0x06004E81 RID: 20097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E81")]
		[Address(RVA = "0x7AEC80", Offset = "0x7AD680", VA = "0x1807AEC80")]
		private static IEnumerable<KeyValuePair<string, AssetReference>> GetAssets(Func<ExpandableGameDataPack, AssetReference> getAssetCallback)
		{
			return null;
		}

		// Token: 0x06004E82 RID: 20098 RVA: 0x0001C8C0 File Offset: 0x0001AAC0
		[Token(Token = "0x6004E82")]
		private UniTask<IAssetHandle<T>> LoadResourceAsync<T>(AssetReference assetReference, AssetLifetime assetLifetime = AssetLifetime.Persistent) where T : class
		{
			return default(UniTask<IAssetHandle<T>>);
		}

		// Token: 0x06004E83 RID: 20099 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
		[Token(Token = "0x6004E83")]
		private UniTask<ValueTuple<List<IAssetHandle<T>>, Dictionary<IAssetHandle<T>, string>>> LoadResourceMultipleInternalAsync<T>([TupleElementNames(new string[] { "DLCKey", "ObjectAssetReference" })] IEnumerable<ValueTuple<string, AssetReference>> assetReferences, bool recordMapping, AssetLifetime assetLifetime = AssetLifetime.Persistent) where T : class
		{
			return default(UniTask<ValueTuple<List<IAssetHandle<T>>, Dictionary<IAssetHandle<T>, string>>>);
		}

		// Token: 0x06004E84 RID: 20100 RVA: 0x0001C8F0 File Offset: 0x0001AAF0
		[Token(Token = "0x6004E84")]
		private UniTask<IAssetHandleArray<T>> CallResourceMultipleOrderedInternal<T>(IEnumerable<AssetReference> assetReferences, AssetLifetime assetLifetime = AssetLifetime.Persistent) where T : class
		{
			return default(UniTask<IAssetHandleArray<T>>);
		}

		// Token: 0x06004E85 RID: 20101 RVA: 0x0001C908 File Offset: 0x0001AB08
		[Token(Token = "0x6004E85")]
		private UniTask<T> LoadSingleLargeResourceAndShowProgress<T>(AssetReference assetReference) where T : global::UnityEngine.Object
		{
			return default(UniTask<T>);
		}

		// Token: 0x06004E86 RID: 20102 RVA: 0x0001C920 File Offset: 0x0001AB20
		[Token(Token = "0x6004E86")]
		[Address(RVA = "0x7AF1C0", Offset = "0x7ADBC0", VA = "0x1807AF1C0")]
		private UniTask LoadScene()
		{
			return default(UniTask);
		}

		// Token: 0x06004E87 RID: 20103 RVA: 0x0001C938 File Offset: 0x0001AB38
		[Token(Token = "0x6004E87")]
		private UniTask<ValueTuple<List<IAssetHandle<T>>, Dictionary<IAssetHandle<T>, string>>> LoadResourceMultipleAsync<T>(Func<ExpandableGameDataPack, AssetReference> getAssetReferenceCallback, bool recordMapping, AssetLifetime assetLifetime = AssetLifetime.Persistent) where T : class
		{
			return default(UniTask<ValueTuple<List<IAssetHandle<T>>, Dictionary<IAssetHandle<T>, string>>>);
		}

		// Token: 0x06004E88 RID: 20104 RVA: 0x0001C950 File Offset: 0x0001AB50
		[Token(Token = "0x6004E88")]
		private UniTask<IAssetHandleArray<T>> CallResourceMultipleOrdered<T>(Func<ExpandableGameDataPack, AssetReference[]> getAssetReferenceCallback, AssetLifetime assetLifetime = AssetLifetime.Persistent) where T : class
		{
			return default(UniTask<IAssetHandleArray<T>>);
		}

		// Token: 0x06004E89 RID: 20105 RVA: 0x0001C968 File Offset: 0x0001AB68
		[Token(Token = "0x6004E89")]
		private UniTask<ValueTuple<List<IAssetHandle<T>>, Dictionary<IAssetHandle<T>, string>>> LoadResourceMultipleAsync<T>(Func<ExpandableGameDataPack, AssetReference[]> getAssetReferenceCallback, bool recordMapping, AssetLifetime assetLifetime = AssetLifetime.Persistent) where T : class
		{
			return default(UniTask<ValueTuple<List<IAssetHandle<T>>, Dictionary<IAssetHandle<T>, string>>>);
		}

		// Token: 0x06004E8A RID: 20106 RVA: 0x0001C980 File Offset: 0x0001AB80
		[Token(Token = "0x6004E8A")]
		private UniTask<Dictionary<TKey, TObject>> LoadResourceSubResourcesAsync<TKey, TObject>(AssetReference assetReference, Func<string, TKey> objectToKeyHandler) where TObject : global::UnityEngine.Object
		{
			return default(UniTask<Dictionary<TKey, TObject>>);
		}

		// Token: 0x06004E8B RID: 20107 RVA: 0x0001C998 File Offset: 0x0001AB98
		[Token(Token = "0x6004E8B")]
		private UniTask<Dictionary<TKey, TObject>> LoadResourceSubResourcesMultipleAsync<TKey, TObject>(Func<ExpandableGameDataPack, AssetReference> getAssetReferenceCallback, Func<string, TKey> objectToKeyHandler, AssetLifetime assetLifetime = AssetLifetime.Persistent) where TObject : global::UnityEngine.Object
		{
			return default(UniTask<Dictionary<TKey, TObject>>);
		}

		// Token: 0x06004E8C RID: 20108 RVA: 0x0001C9B0 File Offset: 0x0001ABB0
		[Token(Token = "0x6004E8C")]
		private UniTask<IEnumerable<T>> LoadTSVResourceAsync<T>(MultiLanguageTextMesh.MultiLanguageAssetReference assetReference, Func<string[], T> conversionHandler)
		{
			return default(UniTask<IEnumerable<T>>);
		}

		// Token: 0x06004E8D RID: 20109 RVA: 0x0001C9C8 File Offset: 0x0001ABC8
		[Token(Token = "0x6004E8D")]
		private UniTask<IEnumerable<T>> LoadTSVResourceMultipleAsync<T>(Func<ExpandableGameDataPack, MultiLanguageTextMesh.MultiLanguageAssetReference> getAssetReferenceCallback, Func<string, string[], T> conversionHandler)
		{
			return default(UniTask<IEnumerable<T>>);
		}

		// Token: 0x06004E8E RID: 20110 RVA: 0x0001C9E0 File Offset: 0x0001ABE0
		[Token(Token = "0x6004E8E")]
		[Address(RVA = "0x7AE4A0", Offset = "0x7ACEA0", VA = "0x1807AE4A0")]
		private UniTask<Dictionary<int, string>> CallTSVResourceAsPlainLanguageMultiple(Func<ExpandableGameDataPack, MultiLanguageTextMesh.MultiLanguageAssetReference> getAssetReferenceCallback)
		{
			return default(UniTask<Dictionary<int, string>>);
		}

		// Token: 0x06004E8F RID: 20111 RVA: 0x0001C9F8 File Offset: 0x0001ABF8
		[Token(Token = "0x6004E8F")]
		[Address(RVA = "0x7AE240", Offset = "0x7ACC40", VA = "0x1807AE240")]
		private UniTask<Dictionary<int, LanguageBase>> CallTSVResourceAsIntLanguageBaseMultiple(Func<ExpandableGameDataPack, MultiLanguageTextMesh.MultiLanguageAssetReference> getAssetReferenceCallback)
		{
			return default(UniTask<Dictionary<int, LanguageBase>>);
		}

		// Token: 0x06004E90 RID: 20112 RVA: 0x0001CA10 File Offset: 0x0001AC10
		[Token(Token = "0x6004E90")]
		[Address(RVA = "0x7AE5C0", Offset = "0x7ACFC0", VA = "0x1807AE5C0")]
		private UniTask<Dictionary<string, LanguageBase>> CallTSVResourceAsStringLanguageBaseMultiple(Func<ExpandableGameDataPack, MultiLanguageTextMesh.MultiLanguageAssetReference> getAssetReferenceCallback)
		{
			return default(UniTask<Dictionary<string, LanguageBase>>);
		}

		// Token: 0x06004E91 RID: 20113 RVA: 0x0001CA28 File Offset: 0x0001AC28
		[Token(Token = "0x6004E91")]
		[Address(RVA = "0x7AE360", Offset = "0x7ACD60", VA = "0x1807AE360")]
		private UniTask<Dictionary<int, ObjectLanguageBase>> CallTSVResourceAsObjectLanguageBaseMultiple(Func<ExpandableGameDataPack, MultiLanguageTextMesh.MultiLanguageAssetReference> getAssetReferenceCallback, Dictionary<int, Sprite> visuals)
		{
			return default(UniTask<Dictionary<int, ObjectLanguageBase>>);
		}

		// Token: 0x06004E92 RID: 20114 RVA: 0x0001CA40 File Offset: 0x0001AC40
		[Token(Token = "0x6004E92")]
		private UniTask<Dictionary<TKey, ObjectLanguageBase>> CallTSVResourceAsObjectLanguageBase<TKey>(MultiLanguageTextMesh.MultiLanguageAssetReference assetReference, Dictionary<TKey, Sprite> visuals, Func<string, TKey> keyConversionHandler)
		{
			return default(UniTask<Dictionary<TKey, ObjectLanguageBase>>);
		}

		// Token: 0x06004E93 RID: 20115 RVA: 0x0001CA58 File Offset: 0x0001AC58
		[Token(Token = "0x6004E93")]
		private UniTask<Dictionary<TKey, ObjectLanguageBase>> CallTSVResourceAsObjectLanguageBaseMultiple<TKey>(Func<ExpandableGameDataPack, MultiLanguageTextMesh.MultiLanguageAssetReference> getAssetReferenceCallback, Dictionary<TKey, Sprite> visuals, Func<string, TKey> keyConversionHandler)
		{
			return default(UniTask<Dictionary<TKey, ObjectLanguageBase>>);
		}

		// Token: 0x06004E94 RID: 20116 RVA: 0x0001CA70 File Offset: 0x0001AC70
		[Token(Token = "0x6004E94")]
		private static UniTask<T> CreateChecked<T>(UniTask<T> call, string errorMessage)
		{
			return default(UniTask<T>);
		}

		// Token: 0x06004E95 RID: 20117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E95")]
		[Address(RVA = "0x7AE950", Offset = "0x7AD350", VA = "0x1807AE950", Slot = "4")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06004E96 RID: 20118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E96")]
		[Address(RVA = "0x7B1E30", Offset = "0x7B0830", VA = "0x1807B1E30")]
		public LoadingSceneManager()
		{
		}

		// Token: 0x06004E99 RID: 20121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E99")]
		[Address(RVA = "0x7AF9B0", Offset = "0x7AE3B0", VA = "0x1807AF9B0")]
		[CompilerGenerated]
		internal static void <LoadCoreAsync>g__LoadPortrayal|109_181(CharacterPortrayal portrayal, ICollection<UniTask> loadTaskPool)
		{
		}

		// Token: 0x06004E9A RID: 20122 RVA: 0x0001CA88 File Offset: 0x0001AC88
		[Token(Token = "0x6004E9A")]
		[Address(RVA = "0x7B0140", Offset = "0x7AEB40", VA = "0x1807B0140")]
		[CompilerGenerated]
		internal static EventManager.BuffType <LoadCoreAsync>g__ParseBuffTypeString|109_80(string raw)
		{
			return EventManager.BuffType.Null;
		}

		// Token: 0x06004E9B RID: 20123 RVA: 0x0001CAA0 File Offset: 0x0001ACA0
		[Token(Token = "0x6004E9B")]
		[Address(RVA = "0x7B0300", Offset = "0x7AED00", VA = "0x1807B0300")]
		[CompilerGenerated]
		internal static Cooker.CookerType <LoadCoreAsync>g__ParseCookerTypeString|109_81(string raw)
		{
			return Cooker.CookerType.Empty;
		}

		// Token: 0x06004E9C RID: 20124 RVA: 0x0001CAB8 File Offset: 0x0001ACB8
		[Token(Token = "0x6004E9C")]
		[Address(RVA = "0x7B0220", Offset = "0x7AEC20", VA = "0x1807B0220")]
		[CompilerGenerated]
		internal static Cooker.CookerSeries <LoadCoreAsync>g__ParseCookerSeriesString|109_82(string raw)
		{
			return Cooker.CookerSeries.Base;
		}

		// Token: 0x06004E9D RID: 20125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E9D")]
		[CompilerGenerated]
		internal static Dictionary<T, Sprite> <LoadCoreAsync>g__FillterSprites|109_83<T>(IEnumerable<KeyValuePair<T, Sprite>> source, T exclude) where T : IComparable
		{
			return null;
		}

		// Token: 0x06004E9E RID: 20126 RVA: 0x0001CAD0 File Offset: 0x0001ACD0
		[Token(Token = "0x6004E9E")]
		[Address(RVA = "0x7AFC90", Offset = "0x7AE690", VA = "0x1807AFC90")]
		[CompilerGenerated]
		internal static bool <LoadCoreAsync>g__MatchPass|109_185(string nameToMatch, Sprite sprite, Regex matchRegex, IDictionary<int, Sprite> collectionToAdd, ref LoadingSceneManager.<>c__DisplayClass109_3 A_4)
		{
			return default(bool);
		}

		// Token: 0x06004EA0 RID: 20128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA0")]
		[Address(RVA = "0x7B0460", Offset = "0x7AEE60", VA = "0x1807B0460")]
		[CompilerGenerated]
		private Dictionary<int, UnityEngineExtensionStatic.StructPtr<string>[]> <LoadNight>g__IndexConvData|111_18(Dictionary<int, int[]> convWeightData, Dictionary<int, string[]> convLangData)
		{
			return null;
		}

		// Token: 0x06004EA1 RID: 20129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA1")]
		[Address(RVA = "0x7B0C90", Offset = "0x7AF690", VA = "0x1807B0C90")]
		[CompilerGenerated]
		internal static Dictionary<int, string[]> <LoadNight>g__IndexEvalData|111_19(Dictionary<int, string[]> languageSource, int[] indexes, bool isSpecial)
		{
			return null;
		}

		// Token: 0x06004EA2 RID: 20130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EA2")]
		[Address(RVA = "0x7B16E0", Offset = "0x7B00E0", VA = "0x1807B16E0")]
		[CompilerGenerated]
		internal static string <LoadNight>g__Missing|111_36(int number, ref LoadingSceneManager.<>c__DisplayClass111_0 A_1, ref LoadingSceneManager.<>c__DisplayClass111_1 A_2)
		{
			return null;
		}

		// Token: 0x040047D3 RID: 18387
		[Token(Token = "0x40047D3")]
		[FieldOffset(Offset = "0x8")]
		public static LoadingSceneManager.DataLoadType loadType;

		// Token: 0x040047D4 RID: 18388
		[Token(Token = "0x40047D4")]
		[FieldOffset(Offset = "0xC")]
		public static SceneDirector.StaffScenePlayBackIndicator staffScenePlaybackLoadHint;

		// Token: 0x040047D5 RID: 18389
		[Token(Token = "0x40047D5")]
		[FieldOffset(Offset = "0x10")]
		[CleanupIgnore]
		public static AssetReference targetScene;

		// Token: 0x040047D6 RID: 18390
		[Token(Token = "0x40047D6")]
		[FieldOffset(Offset = "0x18")]
		[CleanupIgnore]
		public static Action hasLoadedSceneReady;

		// Token: 0x040047D7 RID: 18391
		[Token(Token = "0x40047D7")]
		[FieldOffset(Offset = "0x18")]
		public Action<float> onLoadingProgressUpdate;

		// Token: 0x040047D8 RID: 18392
		[Token(Token = "0x40047D8")]
		[FieldOffset(Offset = "0x20")]
		public Action<string> onLoadingMessageUpdate;

		// Token: 0x040047D9 RID: 18393
		[Token(Token = "0x40047D9")]
		[FieldOffset(Offset = "0x20")]
		[CleanupIgnore]
		private static GameDataProfile loadedGameDataProfile;

		// Token: 0x040047DA RID: 18394
		[Token(Token = "0x40047DA")]
		[FieldOffset(Offset = "0x28")]
		[CleanupIgnore]
		private static Dictionary<int, AssetReference> bufferedIzakayaMusicProfile;

		// Token: 0x040047DB RID: 18395
		[Token(Token = "0x40047DB")]
		[FieldOffset(Offset = "0x28")]
		[Header("Text")]
		[SerializeField]
		private MultiLanguageTextMesh.MultiLanguageString loadingMessage;

		// Token: 0x040047DC RID: 18396
		[Token(Token = "0x40047DC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI[] loadingText;

		// Token: 0x040047DD RID: 18397
		[Token(Token = "0x40047DD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI loadingProgressText;

		// Token: 0x040047DE RID: 18398
		[Token(Token = "0x40047DE")]
		[FieldOffset(Offset = "0x40")]
		[Header("Character Parent")]
		[SerializeField]
		private AssetReference aStarCharacter;

		// Token: 0x040047DF RID: 18399
		[Token(Token = "0x40047DF")]
		[FieldOffset(Offset = "0x48")]
		[Header("GameData")]
		[SerializeField]
		private AssetReference gameDataProfile;

		// Token: 0x040047E0 RID: 18400
		[Token(Token = "0x40047E0")]
		[FieldOffset(Offset = "0x50")]
		[Header("Loading Animation")]
		[SerializeField]
		private Animator loadingAnimation;

		// Token: 0x040047E1 RID: 18401
		[Token(Token = "0x40047E1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Header("Loading Info")]
		private AdpProgressIndicatorComponent m_ProgressIndicator;

		// Token: 0x040047E2 RID: 18402
		[Token(Token = "0x40047E2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GenericErrorPanel m_LoadingErrorPannel;

		// Token: 0x040047E3 RID: 18403
		[Token(Token = "0x40047E3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform m_LoadingScenePannelRoot;

		// Token: 0x040047E4 RID: 18404
		[Token(Token = "0x40047E4")]
		[FieldOffset(Offset = "0x70")]
		[Header("Defaults")]
		[SerializeField]
		private AssetReference prdProfile;

		// Token: 0x040047E5 RID: 18405
		[Token(Token = "0x40047E5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AssetReference levelProfile;

		// Token: 0x040047E6 RID: 18406
		[Token(Token = "0x40047E6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AssetReference collabProfile;

		// Token: 0x040047E7 RID: 18407
		[Token(Token = "0x40047E7")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AssetReference characterPixelBase;

		// Token: 0x040047E8 RID: 18408
		[Token(Token = "0x40047E8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AssetReference playerPixelProfile;

		// Token: 0x040047E9 RID: 18409
		[Token(Token = "0x40047E9")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AssetReference playerPortrayalProfile;

		// Token: 0x040047EA RID: 18410
		[Token(Token = "0x40047EA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AssetReference pixelsCompactProfile;

		// Token: 0x040047EB RID: 18411
		[Token(Token = "0x40047EB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AssetReference pixelsFullProfile;

		// Token: 0x040047EC RID: 18412
		[Token(Token = "0x40047EC")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AssetReference portrayalProfile;

		// Token: 0x040047ED RID: 18413
		[Token(Token = "0x40047ED")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AssetReference defauleNullSprite;

		// Token: 0x040047EE RID: 18414
		[Token(Token = "0x40047EE")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AssetReference standardCookerSprite;

		// Token: 0x040047EF RID: 18415
		[Token(Token = "0x40047EF")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private AssetReference cookerBGSprite;

		// Token: 0x040047F0 RID: 18416
		[Token(Token = "0x40047F0")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private MultiLanguageTextMesh.MultiLanguageAssetReference fontProfile;

		// Token: 0x040047F1 RID: 18417
		[Token(Token = "0x40047F1")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private MultiLanguageTextMesh.MultiLanguageAssetReference standardCookersLanguageTSV;

		// Token: 0x040047F2 RID: 18418
		[Token(Token = "0x40047F2")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Header("Celeb")]
		private AssetReference[] fanArtCGDatas;

		// Token: 0x040047F3 RID: 18419
		[Token(Token = "0x40047F3")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private MultiLanguageTextMesh.MultiLanguageString _loadingErrorTitle;

		// Token: 0x040047F4 RID: 18420
		[Token(Token = "0x40047F4")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private MultiLanguageTextMesh.MultiLanguageString _loadingErrorSupport;

		// Token: 0x040047F5 RID: 18421
		[Token(Token = "0x40047F5")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private MultiLanguageTextMesh.MultiLanguageString _loadingErrorCRC;

		// Token: 0x040047F6 RID: 18422
		[Token(Token = "0x40047F6")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Regex FoodRegex;

		// Token: 0x040047F7 RID: 18423
		[Token(Token = "0x40047F7")]
		[FieldOffset(Offset = "0x38")]
		private static readonly Regex BeveragesRegex;

		// Token: 0x040047F8 RID: 18424
		[Token(Token = "0x40047F8")]
		[FieldOffset(Offset = "0x40")]
		private static readonly Regex IngredientsRegex;

		// Token: 0x040047F9 RID: 18425
		[Token(Token = "0x40047F9")]
		[FieldOffset(Offset = "0x48")]
		private static readonly Regex ItemsRegex;

		// Token: 0x040047FA RID: 18426
		[Token(Token = "0x40047FA")]
		[FieldOffset(Offset = "0x50")]
		private static readonly Regex BadgesRegex;

		// Token: 0x040047FB RID: 18427
		[Token(Token = "0x40047FB")]
		[FieldOffset(Offset = "0x58")]
		private static readonly Regex CookersRegex;

		// Token: 0x040047FC RID: 18428
		[Token(Token = "0x40047FC")]
		[FieldOffset(Offset = "0x60")]
		[CleanupIgnore]
		public static bool isFirstLaunch;

		// Token: 0x040047FD RID: 18429
		[Token(Token = "0x40047FD")]
		private const string AA_ERROR_DATA = "Failed to read data for the AssetBundle";

		// Token: 0x040047FE RID: 18430
		[Token(Token = "0x40047FE")]
		private const string AA_ERROR_HEADER = "Unable to read header from archive file";

		// Token: 0x040047FF RID: 18431
		[Token(Token = "0x40047FF")]
		private const string AA_ERROR_CRC = "CRC Mismatch. Provided";

		// Token: 0x04004800 RID: 18432
		[Token(Token = "0x4004800")]
		private const string EDITOR_IGNORE_ERROR = "Invalid editor window of type: UnityEditor.FallbackEditorWindow, title: Failed to load";

		// Token: 0x04004801 RID: 18433
		[Token(Token = "0x4004801")]
		[FieldOffset(Offset = "0x100")]
		private string _errorMessageBuffer;

		// Token: 0x04004802 RID: 18434
		[Token(Token = "0x4004802")]
		[FieldOffset(Offset = "0x108")]
		private string _errorMessageContext;

		// Token: 0x04004803 RID: 18435
		[Token(Token = "0x4004803")]
		[FieldOffset(Offset = "0x110")]
		private GenericErrorPanel m_OpenedErrorPanel;

		// Token: 0x04004804 RID: 18436
		[Token(Token = "0x4004804")]
		[FieldOffset(Offset = "0x118")]
		private int m_GlobalOperationCount;

		// Token: 0x04004805 RID: 18437
		[Token(Token = "0x4004805")]
		[FieldOffset(Offset = "0x11C")]
		private int m_GlobalTotalOperationCount;

		// Token: 0x04004806 RID: 18438
		[Token(Token = "0x4004806")]
		[FieldOffset(Offset = "0x120")]
		private int m_OperationCount;

		// Token: 0x04004807 RID: 18439
		[Token(Token = "0x4004807")]
		[FieldOffset(Offset = "0x124")]
		private int m_TotalOperationCount;

		// Token: 0x04004808 RID: 18440
		[Token(Token = "0x4004808")]
		[FieldOffset(Offset = "0x64")]
		private static readonly int Variant;

		// Token: 0x0400480F RID: 18447
		[Token(Token = "0x400480F")]
		private const string LOAD_DEPENDENCIES_ASYNC_PROFILE = "Game Asset Loading: Load Dependencies";

		// Token: 0x04004810 RID: 18448
		[Token(Token = "0x4004810")]
		private const string LOAD_CORE_ASYNC_PROFILE = "Game Asset Loading: Load Core";

		// Token: 0x04004811 RID: 18449
		[Token(Token = "0x4004811")]
		private const string LOAD_DAY_ASYNC_PROFILE = "Game Asset Loading: Load Day";

		// Token: 0x04004812 RID: 18450
		[Token(Token = "0x4004812")]
		private const string LOAD_ACTIVE_PLAYER_SKIN_ASYNC_PROFILE = "Game Asset Loading: Load ActivePlayerSkin";

		// Token: 0x04004813 RID: 18451
		[Token(Token = "0x4004813")]
		private const string LOAD_NIGHT_PROFILE = "Game Asset Loading: Load Night";

		// Token: 0x04004814 RID: 18452
		[Token(Token = "0x4004814")]
		private const string LOAD_STAFF_ASYNC_PROFILE = "Game Asset Loading: Load Staff";

		// Token: 0x04004815 RID: 18453
		[Token(Token = "0x4004815")]
		private const string LOAD_IZAKAYA_MAP_ASYNC_PROFILE = "Game Asset Loading: Load IzakayaMap";

		// Token: 0x04004816 RID: 18454
		[Token(Token = "0x4004816")]
		private const string LOAD_IZAKAYA_MUSIC_PACKAGE_ASYNC_PROFILE = "Game Asset Loading: Load IzakayaMusicPackage";

		// Token: 0x04004817 RID: 18455
		[Token(Token = "0x4004817")]
		private const string LOAD_WORK_SCENE_CHARACTER_PORTRAYAL_ASYNC_PROFILE = "Game Asset Loading: Load WorkSceneCharacterPortrayal";

		// Token: 0x04004818 RID: 18456
		[Token(Token = "0x4004818")]
		private const string LOAD_SPECIAL_GUEST_EXTRA_DIALOG_DATA_PROFILE = "Game Asset Loading: Load LoadSpecialGuestExtraDialogData";

		// Token: 0x04004819 RID: 18457
		[Token(Token = "0x4004819")]
		[FieldOffset(Offset = "0x78")]
		private static readonly ProfilerMarker s_LoadResourceAsync_Profiler;

		// Token: 0x0400481A RID: 18458
		[Token(Token = "0x400481A")]
		[FieldOffset(Offset = "0x80")]
		private static readonly ProfilerMarker s_DetachEditorAsset_Profiler;

		// Token: 0x0400481B RID: 18459
		[Token(Token = "0x400481B")]
		[FieldOffset(Offset = "0x88")]
		private static readonly ProfilerMarker s_LoadResourceMultipleInternalAsync_CreateTask_Profiler;

		// Token: 0x0400481C RID: 18460
		[Token(Token = "0x400481C")]
		[FieldOffset(Offset = "0x90")]
		private static readonly ProfilerMarker s_LoadResourceMultipleInternalAsync_Collect_Profiler;

		// Token: 0x0400481D RID: 18461
		[Token(Token = "0x400481D")]
		[FieldOffset(Offset = "0x98")]
		private static readonly ProfilerMarker s_LoadTSVResourceAsync_Profiler;

		// Token: 0x0400481E RID: 18462
		[Token(Token = "0x400481E")]
		[FieldOffset(Offset = "0xA0")]
		private static readonly ProfilerMarker s_LoadTSVResourceOrderedAsync_Profiler;

		// Token: 0x0400481F RID: 18463
		[Token(Token = "0x400481F")]
		[FieldOffset(Offset = "0xA8")]
		private static readonly ProfilerMarker s_LoadTSVResourceMultipleAsync_Profiler;

		// Token: 0x02000D2A RID: 3370
		[Token(Token = "0x2000D2A")]
		public enum DataLoadType
		{
			// Token: 0x04004821 RID: 18465
			[Token(Token = "0x4004821")]
			Dependencies,
			// Token: 0x04004822 RID: 18466
			[Token(Token = "0x4004822")]
			Day,
			// Token: 0x04004823 RID: 18467
			[Token(Token = "0x4004823")]
			Night,
			// Token: 0x04004824 RID: 18468
			[Token(Token = "0x4004824")]
			Dry,
			// Token: 0x04004825 RID: 18469
			[Token(Token = "0x4004825")]
			Staff
		}

		// Token: 0x02000D2B RID: 3371
		[Token(Token = "0x2000D2B")]
		private class LoadedAssetHandle<T> : IAssetHandle<T>, IDisposable where T : class
		{
			// Token: 0x06004EA3 RID: 20131 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EA3")]
			public LoadedAssetHandle(IAssetHandle<T> assetHandle)
			{
			}

			// Token: 0x17000B5D RID: 2909
			// (get) Token: 0x06004EA4 RID: 20132 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000B5D")]
			public T Asset
			{
				[Token(Token = "0x6004EA4")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000B5E RID: 2910
			// (get) Token: 0x06004EA5 RID: 20133 RVA: 0x0001CB00 File Offset: 0x0001AD00
			[Token(Token = "0x17000B5E")]
			public bool IsPersistentAsset
			{
				[Token(Token = "0x6004EA5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06004EA6 RID: 20134 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004EA6")]
			public void Dispose()
			{
			}

			// Token: 0x04004826 RID: 18470
			[Token(Token = "0x4004826")]
			[FieldOffset(Offset = "0x0")]
			private readonly IAssetHandle<T> m_AssetHandle;

			// Token: 0x04004827 RID: 18471
			[Token(Token = "0x4004827")]
			[FieldOffset(Offset = "0x0")]
			private T m_CachedAsset;
		}
	}
}
