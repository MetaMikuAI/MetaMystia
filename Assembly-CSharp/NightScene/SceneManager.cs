using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cinemachine;
using Common.CharacterUtility;
using DEYU.Singletons;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.Input;
using NightScene.MusicUtility;
using NightScene.Tiles;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace NightScene
{
	// Token: 0x02000559 RID: 1369
	[Token(Token = "0x2000559")]
	[GenerateCleanupMethod]
	[RequireComponent(typeof(GuestsManager), typeof(CookSystemManager), typeof(TileManager))]
	[RequireComponent(typeof(MusicManager), typeof(EventManager))]
	public class SceneManager : MonoSingleton<SceneManager>
	{
		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x0000B640 File Offset: 0x00009840
		// (set) Token: 0x06001E78 RID: 7800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F8")]
		public InteractableTile.TileType? MustOpenTileType
		{
			[Token(Token = "0x6001E77")]
			[Address(RVA = "0x440320", Offset = "0x43ED20", VA = "0x180440320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E78")]
			[Address(RVA = "0x4BE680", Offset = "0x4BD080", VA = "0x1804BE680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001E79 RID: 7801 RVA: 0x0000B658 File Offset: 0x00009858
		// (set) Token: 0x06001E7A RID: 7802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003F9")]
		public Cooker.CookerType? MustOpenCookerType
		{
			[Token(Token = "0x6001E79")]
			[Address(RVA = "0x4402B0", Offset = "0x43ECB0", VA = "0x1804402B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E7A")]
			[Address(RVA = "0x4BE660", Offset = "0x4BD060", VA = "0x1804BE660")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x0000B670 File Offset: 0x00009870
		// (set) Token: 0x06001E7C RID: 7804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FA")]
		public int? CookerMustIncludeIngredientId
		{
			[Token(Token = "0x6001E7B")]
			[Address(RVA = "0x4402C0", Offset = "0x43ECC0", VA = "0x1804402C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E7C")]
			[Address(RVA = "0x4BE5E0", Offset = "0x4BCFE0", VA = "0x1804BE5E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x0000B688 File Offset: 0x00009888
		// (set) Token: 0x06001E7E RID: 7806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FB")]
		public int? CookerMustSelecRecipetId
		{
			[Token(Token = "0x6001E7D")]
			[Address(RVA = "0x45A7E0", Offset = "0x4591E0", VA = "0x18045A7E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E7E")]
			[Address(RVA = "0x4BE5F0", Offset = "0x4BCFF0", VA = "0x1804BE5F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x0000B6A0 File Offset: 0x000098A0
		// (set) Token: 0x06001E80 RID: 7808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FC")]
		public int? BeverageStorageMustIncludeTagId
		{
			[Token(Token = "0x6001E7F")]
			[Address(RVA = "0x440500", Offset = "0x43EF00", VA = "0x180440500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E80")]
			[Address(RVA = "0x4BE5D0", Offset = "0x4BCFD0", VA = "0x1804BE5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001E81 RID: 7809 RVA: 0x0000B6B8 File Offset: 0x000098B8
		// (set) Token: 0x06001E82 RID: 7810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FD")]
		public int? MustOpenGuestDeskCode
		{
			[Token(Token = "0x6001E81")]
			[Address(RVA = "0x426F70", Offset = "0x425970", VA = "0x180426F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E82")]
			[Address(RVA = "0x4BE670", Offset = "0x4BD070", VA = "0x1804BE670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001E84 RID: 7812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003FE")]
		public WorkScenePlayerInputGenerator PlayerCharacter
		{
			[Token(Token = "0x6001E83")]
			[Address(RVA = "0x4BE490", Offset = "0x4BCE90", VA = "0x1804BE490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E84")]
			[Address(RVA = "0x4BE690", Offset = "0x4BD090", VA = "0x1804BE690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x0000B6D0 File Offset: 0x000098D0
		[Token(Token = "0x170003FF")]
		public bool isCharacterStuned
		{
			[Token(Token = "0x6001E85")]
			[Address(RVA = "0x4BE4A0", Offset = "0x4BCEA0", VA = "0x1804BE4A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x0000B6E8 File Offset: 0x000098E8
		// (set) Token: 0x06001E87 RID: 7815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000400")]
		public static bool IfTewiWillComeTonight
		{
			[Token(Token = "0x6001E86")]
			[Address(RVA = "0x4BE440", Offset = "0x4BCE40", VA = "0x1804BE440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001E87")]
			[Address(RVA = "0x4BE600", Offset = "0x4BD000", VA = "0x1804BE600")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000401")]
		public static Queue<Action<Action>> AdditiveBuff
		{
			[Token(Token = "0x6001E88")]
			[Address(RVA = "0x4BE3F0", Offset = "0x4BCDF0", VA = "0x1804BE3F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06001E89 RID: 7817 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06001E8A RID: 7818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1400000E")]
		public static event Action OnNightSceneDisposeCallback
		{
			[Token(Token = "0x6001E89")]
			[Address(RVA = "0x4BE2F0", Offset = "0x4BCCF0", VA = "0x1804BE2F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001E8A")]
			[Address(RVA = "0x4BE4D0", Offset = "0x4BCED0", VA = "0x1804BE4D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E8B")]
		[Address(RVA = "0x4BCF40", Offset = "0x4BB940", VA = "0x1804BCF40")]
		private void Start()
		{
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x0000B700 File Offset: 0x00009900
		[Token(Token = "0x6001E8C")]
		[Address(RVA = "0x4BB4C0", Offset = "0x4B9EC0", VA = "0x1804BB4C0")]
		public static bool CheckIfBuffHasAdded(Action<Action> buff)
		{
			return default(bool);
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E8D")]
		[Address(RVA = "0x4BCE60", Offset = "0x4BB860", VA = "0x1804BCE60")]
		private void STDOnEventFinishCallback()
		{
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E8E")]
		[Address(RVA = "0x4BBA10", Offset = "0x4BA410", VA = "0x1804BBA10")]
		private Action<AStarInputGeneratorComponent> GetPostProcessCharacterDataCallback()
		{
			return null;
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E8F")]
		[Address(RVA = "0x4BC3F0", Offset = "0x4BADF0", VA = "0x1804BC3F0")]
		private void InitializeAsGeneralWorkScene(Action onEventFinishCallback)
		{
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E90")]
		[Address(RVA = "0x4BC160", Offset = "0x4BAB60", VA = "0x1804BC160")]
		private void InitializeAsChallengeScene(Action onEventFinishCallback)
		{
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E91")]
		[Address(RVA = "0x4BCAD0", Offset = "0x4BB4D0", VA = "0x1804BCAD0")]
		private void OnRequestedBossDataLoadFinishCallback(Action onEventFinishCallback, BossData loadedBossData)
		{
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E92")]
		[Address(RVA = "0x4BBAE0", Offset = "0x4BA4E0", VA = "0x1804BBAE0")]
		private void GhostModeProcessCharacterCallback(AStarInputGeneratorComponent component)
		{
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E93")]
		[Address(RVA = "0x4BC870", Offset = "0x4BB270", VA = "0x1804BC870")]
		private void InitializeAsKyoukoTutorialScene(Action onEventFinishCallback, Action onTimelineFinishCallback)
		{
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E94")]
		[Address(RVA = "0x4BB710", Offset = "0x4BA110", VA = "0x1804BB710")]
		private void Dispose()
		{
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E95")]
		[Address(RVA = "0x4BCF10", Offset = "0x4BB910", VA = "0x1804BCF10")]
		public void SetPlayerCharacterToDefaultSpawn()
		{
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E96")]
		[Address(RVA = "0x4BCD10", Offset = "0x4BB710", VA = "0x1804BCD10")]
		public static void ResetNightSetting()
		{
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E97")]
		[Address(RVA = "0x4BBB50", Offset = "0x4BA550", VA = "0x1804BBB50")]
		public void HandleCharacterArrivalCallback(Vector3Int targetPos, Vector3Int characterPosition, out int rotateDirection)
		{
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E98")]
		[Address(RVA = "0x4BDE70", Offset = "0x4BC870", VA = "0x1804BDE70")]
		public void ToResult()
		{
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E99")]
		[Address(RVA = "0x4BCA80", Offset = "0x4BB480", VA = "0x1804BCA80", Slot = "5")]
		protected override void OnInstanceDestroyed()
		{
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E9A")]
		[Address(RVA = "0x4BB570", Offset = "0x4B9F70", VA = "0x1804BB570", Slot = "6")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E9B")]
		[Address(RVA = "0x4BE250", Offset = "0x4BCC50", VA = "0x1804BE250")]
		public SceneManager()
		{
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E9D")]
		[Address(RVA = "0x4BDFD0", Offset = "0x4BC9D0", VA = "0x1804BDFD0")]
		[CompilerGenerated]
		internal static void <InitializeAsKyoukoTutorialScene>g__ExecuteNext|66_0(ref SceneManager.<>c__DisplayClass66_0 A_0)
		{
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E9E")]
		[Address(RVA = "0x4BE120", Offset = "0x4BCB20", VA = "0x1804BE120")]
		[CompilerGenerated]
		internal static void <ToResult>g__OnFadeFinish|71_0()
		{
		}

		// Token: 0x04001C2A RID: 7210
		[Token(Token = "0x4001C2A")]
		public const int NIGHT_WHOLE_TIME = 240;

		// Token: 0x04001C2B RID: 7211
		[Token(Token = "0x4001C2B")]
		private const int TEWI_ID = 16;

		// Token: 0x04001C2C RID: 7212
		[Token(Token = "0x4001C2C")]
		private const string TEWI_HOME = "BambooForest";

		// Token: 0x04001C2D RID: 7213
		[Token(Token = "0x4001C2D")]
		private const string TEWI_SPAWN_PRD_LABEL = "TewiSpawnRate";

		// Token: 0x04001C2E RID: 7214
		[Token(Token = "0x4001C2E")]
		public const string AYA_FAMOUS_IZAKAYA = "Aya_FamousIzakaya";

		// Token: 0x04001C2F RID: 7215
		[Token(Token = "0x4001C2F")]
		[FieldOffset(Offset = "0x18")]
		public AudioClip onIzakayaOpen;

		// Token: 0x04001C30 RID: 7216
		[Token(Token = "0x4001C30")]
		[FieldOffset(Offset = "0x20")]
		public AudioClip onIzakayaClose;

		// Token: 0x04001C31 RID: 7217
		[Token(Token = "0x4001C31")]
		[FieldOffset(Offset = "0x28")]
		public CinemachineVirtualCamera virtualCamera;

		// Token: 0x04001C32 RID: 7218
		[Token(Token = "0x4001C32")]
		[FieldOffset(Offset = "0x30")]
		public bool canOpenTrash;

		// Token: 0x04001C33 RID: 7219
		[Token(Token = "0x4001C33")]
		[FieldOffset(Offset = "0x38")]
		public SceneManager.BossBattleData[] bossBattleData;

		// Token: 0x04001C34 RID: 7220
		[Token(Token = "0x4001C34")]
		[FieldOffset(Offset = "0x40")]
		public Material ghostCharacter;

		// Token: 0x04001C35 RID: 7221
		[Token(Token = "0x4001C35")]
		[FieldOffset(Offset = "0x48")]
		public Material ghostCharacterEyes;

		// Token: 0x04001C36 RID: 7222
		[Token(Token = "0x4001C36")]
		[FieldOffset(Offset = "0x50")]
		public Action OnEnd;

		// Token: 0x04001C37 RID: 7223
		[Token(Token = "0x4001C37")]
		[FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float tewiSpawnProbability;

		// Token: 0x04001C38 RID: 7224
		[Token(Token = "0x4001C38")]
		[FieldOffset(Offset = "0x5C")]
		public float famousIzakayaAddSpawnRate;

		// Token: 0x04001C39 RID: 7225
		[Token(Token = "0x4001C39")]
		[FieldOffset(Offset = "0x60")]
		public float famousIzakayaAddExtraFundRate;

		// Token: 0x04001C3A RID: 7226
		[Token(Token = "0x4001C3A")]
		[FieldOffset(Offset = "0x68")]
		private readonly Queue<AssetReference> releaseQueue;

		// Token: 0x04001C3B RID: 7227
		[Token(Token = "0x4001C3B")]
		[FieldOffset(Offset = "0x70")]
		private BossData m_LoadedBossData;

		// Token: 0x0200055A RID: 1370
		[Token(Token = "0x200055A")]
		[Serializable]
		public struct DataPair
		{
			// Token: 0x04001C46 RID: 7238
			[Token(Token = "0x4001C46")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public int[] izakayaIndexes;

			// Token: 0x04001C47 RID: 7239
			[Token(Token = "0x4001C47")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public int targetPoint;
		}

		// Token: 0x0200055B RID: 1371
		[Token(Token = "0x200055B")]
		[Serializable]
		public struct BossBattleData
		{
			// Token: 0x04001C48 RID: 7240
			[Token(Token = "0x4001C48")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public NightSceneDirector.ChallengeType challengeType;

			// Token: 0x04001C49 RID: 7241
			[Token(Token = "0x4001C49")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public AssetReference bossDataAssetReference;
		}
	}
}
