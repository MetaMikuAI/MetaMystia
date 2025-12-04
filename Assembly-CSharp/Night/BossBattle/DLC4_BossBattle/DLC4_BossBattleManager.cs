using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Common.Audio;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.Tiles;
using NightScene.UI;
using NightScene.UI.HUDUtility;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.Pool;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000183 RID: 387
	[Token(Token = "0x2000183")]
	[GenerateCleanupMethod]
	public class DLC4_BossBattleManager : MonoBehaviour, IChallengeCardSelectorPanelDB
	{
		// Token: 0x060008ED RID: 2285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x81C890", Offset = "0x81B290", VA = "0x18081C890")]
		public IEnumerator MainGameLoop(float firstRefreshEnemyNeedToWait, float damageCheckingPercentage, float minWaitTimeToNextWave, float waitTimeToNextWaveDueToDamage, Vector2 toRefreshNextWaveLeastWait, float toRefreshNextBigWaveLeastWait, DLC4_MystiaVSFlandreBossData.BigWaveProperty[] wholeBigWaveProperty, Action<bool> onWaveEndRefresh, Func<IEnumerator> onBigWaveEnd, Action<int, float> onWaveReadyRefresh, Action<int> onWaitForGameBegin, Action onGameBegin)
		{
			return null;
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x821630", Offset = "0x820030", VA = "0x180821630")]
		public void WaitSecondsToExcute(float waitSec, Action onFinish)
		{
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x821600", Offset = "0x820000", VA = "0x180821600")]
		public void WaitSecondsToExcuteForGuard(float waitSec, DLC4_GuardController guardController, Action onFinish)
		{
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x821570", Offset = "0x81FF70", VA = "0x180821570")]
		private IEnumerator WaitIEnumerator(float waitSec, Action onFinish)
		{
			return null;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F1")]
		private T CreateObjectInstance<T>(GameObject parent) where T : Component
		{
			return null;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008F2")]
		private void DestroyInstance<T>(T instance) where T : Component
		{
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x81AFB0", Offset = "0x8199B0", VA = "0x18081AFB0")]
		private int GetSpawnLinePositionY(bool isNormalDistribution)
		{
			return 0;
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x81F160", Offset = "0x81DB60", VA = "0x18081F160")]
		public DLC4_FlandreEnemyCharacterController SpawnFlandre(FlandreTypeIndex id, DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty.SpawnType spawnType, DLC4_MystiaVSFlandreBossData.EnemyRefreshProperty.RefreshNextWaveType refreshNextWaveType, [Optional] Vector2? spawnPosition)
		{
			return null;
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x819D70", Offset = "0x818770", VA = "0x180819D70")]
		private void ChangeFlandreNum()
		{
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x81CAF0", Offset = "0x81B4F0", VA = "0x18081CAF0")]
		private void OnControllerEnable(DLC4_FlandreEnemyCharacterController controller)
		{
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x820790", Offset = "0x81F190", VA = "0x180820790")]
		private void TryReleaseFlandreController(DLC4_FlandreEnemyCharacterController controller)
		{
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x81CD20", Offset = "0x81B720", VA = "0x18081CD20")]
		private void OnControllerRelease(DLC4_FlandreEnemyCharacterController controller)
		{
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x819E80", Offset = "0x818880", VA = "0x180819E80")]
		private bool CheckAttackCondition(bool moveToLeft, float attackRange, int currentLine, Vector2 controllerPosition, out DLC4_GuardController guestFortification)
		{
			return default(bool);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FA")]
		public T SpawnBulletTeam<T>(DLC4_GuardController.TeamBulletProperty bulletTeamObject, DLC4_GuardController guardController, Vector2 spawnPosition, [Optional] Action<T> afterSpawn) where T : DLC4_BulletTeam
		{
			return null;
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FB")]
		public T SpawnBulletEnemy<T>(DLC4_FlandreEnemyCharacterController.FlandreBullet bulletEnemyObject, DLC4_FlandreEnemyCharacterController enemyController, Vector2 spawnPosition, [Optional] Action<T> afterSpawn) where T : DLC4_BulletEnemy
		{
			return null;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x81E050", Offset = "0x81CA50", VA = "0x18081E050")]
		public void ReleaseBullet(DLC4_BulletBase bulletTeam)
		{
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x81EDB0", Offset = "0x81D7B0", VA = "0x18081EDB0")]
		private DLC4_BulletBase SpawnBulletBase(BulletTypeIndex id, GameObject parent)
		{
			return null;
		}

		// Token: 0x060008FE RID: 2302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x81CA50", Offset = "0x81B450", VA = "0x18081CA50")]
		private void OnBulletEnable(DLC4_BulletBase bulletTeam)
		{
		}

		// Token: 0x060008FF RID: 2303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x81CAA0", Offset = "0x81B4A0", VA = "0x18081CAA0")]
		private void OnBulletRelease(DLC4_BulletBase bulletTeam)
		{
		}

		// Token: 0x06000900 RID: 2304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000900")]
		[Address(RVA = "0x820840", Offset = "0x81F240", VA = "0x180820840")]
		public void TryReleaseVFX(BossBattleVFX vfxType, GameObject vfx, float delay = 0f)
		{
		}

		// Token: 0x06000901 RID: 2305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000901")]
		[Address(RVA = "0x820030", Offset = "0x81EA30", VA = "0x180820030")]
		public GameObject SpawnVFX(VFXPrefab vfxPrefab, [Optional] Vector2? position)
		{
			return null;
		}

		// Token: 0x06000902 RID: 2306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000902")]
		[Address(RVA = "0x57A060", Offset = "0x578A60", VA = "0x18057A060")]
		private void OnVFXRelease(GameObject vfx)
		{
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000903")]
		[Address(RVA = "0x81E1B0", Offset = "0x81CBB0", VA = "0x18081E1B0")]
		private IEnumerator ReleaseVFXTimed(BossBattleVFX vfxType, GameObject vfx, float duration)
		{
			return null;
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000904")]
		[Address(RVA = "0x81FAC0", Offset = "0x81E4C0", VA = "0x18081FAC0")]
		public DLC4_GuardController SpawnGuardController(int letterId)
		{
			return null;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000905")]
		[Address(RVA = "0x81E2F0", Offset = "0x81CCF0", VA = "0x18081E2F0")]
		public void RemoveTargetDeskCodeGuardController(DLC4_GuardController guard)
		{
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000906")]
		[Address(RVA = "0x81E100", Offset = "0x81CB00", VA = "0x18081E100")]
		public void ReleaseGuardControllerAddress(int poolId, DLC4_GuardController guard)
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000907")]
		[Address(RVA = "0x81D800", Offset = "0x81C200", VA = "0x18081D800")]
		private void OnGuardEnable(DLC4_GuardController guard)
		{
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000908")]
		[Address(RVA = "0x81D850", Offset = "0x81C250", VA = "0x18081D850")]
		private void OnGuardRelease(DLC4_GuardController guard)
		{
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000909")]
		[Address(RVA = "0x81CE50", Offset = "0x81B850", VA = "0x18081CE50")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600090A")]
		[Address(RVA = "0x81ACE0", Offset = "0x8196E0", VA = "0x18081ACE0", Slot = "4")]
		public IEnumerable<GuestGuardMapping> GetCards()
		{
			return null;
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x600090B")]
		[Address(RVA = "0x81AC80", Offset = "0x819680", VA = "0x18081AC80")]
		public float GetCardCoolDownProgress(in GuestGuardMapping mapping)
		{
			return 0f;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x600090C")]
		[Address(RVA = "0x819D60", Offset = "0x818760", VA = "0x180819D60")]
		public bool CanBuyCard(in GuestGuardMapping mapping)
		{
			return default(bool);
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x600090D")]
		[Address(RVA = "0x81C4F0", Offset = "0x81AEF0", VA = "0x18081C4F0")]
		public bool IsCardOnField(in GuestGuardMapping mapping)
		{
			return default(bool);
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x600090E")]
		[Address(RVA = "0x81C490", Offset = "0x81AE90", VA = "0x18081C490")]
		public bool IsCardBought(in GuestGuardMapping mapping)
		{
			return default(bool);
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600090F")]
		[Address(RVA = "0x819B70", Offset = "0x818570", VA = "0x180819B70")]
		public void BuyCard(in GuestGuardMapping mapping)
		{
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x81CA20", Offset = "0x81B420", VA = "0x18081CA20")]
		public void UseCard(in GuestGuardMapping mapping)
		{
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x81DEE0", Offset = "0x81C8E0", VA = "0x18081DEE0")]
		public void PlayTeamBulletHitSfx()
		{
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x81DE90", Offset = "0x81C890", VA = "0x18081DE90")]
		public void PlayAudio(AudioClip audioClip)
		{
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000913")]
		[Address(RVA = "0x81DDA0", Offset = "0x81C7A0", VA = "0x18081DDA0")]
		public void PlayAudioDelayed(AudioClip audioClip, float offset)
		{
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000914")]
		[Address(RVA = "0x81DD10", Offset = "0x81C710", VA = "0x18081DD10")]
		public void PlayAudioDelayed(GlobalAudioManager.DelayAudioClip delayAudioClip)
		{
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000915")]
		[Address(RVA = "0x81DE30", Offset = "0x81C830", VA = "0x18081DE30")]
		public void PlayAudioLooped(global::UnityEngine.Object identifier, LoopedBGMPackage loopedBGMPackage)
		{
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000916")]
		[Address(RVA = "0x819B00", Offset = "0x818500", VA = "0x180819B00")]
		public IEnumerator BattleEnd()
		{
			return null;
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000917")]
		[Address(RVA = "0x81A720", Offset = "0x819120", VA = "0x18081A720")]
		public void DeRegister()
		{
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000918")]
		[Address(RVA = "0x81CFA0", Offset = "0x81B9A0", VA = "0x18081CFA0")]
		private void OnDispose()
		{
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000919")]
		[Address(RVA = "0x81B140", Offset = "0x819B40", VA = "0x18081B140")]
		public void Initialize(DLC4_MystiaVSFlandreBossData bossData, GuestGuardMapping[] itemIdToGuardControllerDic, List<int> playerUnlockedLetterId, UIManager uiManager, TileManager tileManager, EventManager eventManager, GuestsManager guestsManager, Dictionary<FlandreTypeIndex, DLC4_FlandreEnemyCharacterController> flandrePrefabs, Func<PatchouliMagicSpellCardIndex, LanguageBase> getPatchouliText, IncomeControllerFlandre flandreControllerInUI, float lastLineXPosition)
		{
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091A")]
		[Address(RVA = "0x81A8B0", Offset = "0x8192B0", VA = "0x18081A8B0")]
		private void ForceUseSkill(int deskCode)
		{
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091B")]
		[Address(RVA = "0x820400", Offset = "0x81EE00", VA = "0x180820400")]
		private void SpawnWaitingHeroes()
		{
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091C")]
		[Address(RVA = "0x81E7F0", Offset = "0x81D1F0", VA = "0x18081E7F0")]
		private void SpawnAirDesk(DLC4_BossBattleShopPanel bossBattleShopPanel, Func<PatchouliMagicSpellCardIndex, LanguageBase> getSpellText)
		{
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091D")]
		[Address(RVA = "0x81E610", Offset = "0x81D010", VA = "0x18081E610")]
		private void SetOrder(int deskCode)
		{
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600091E")]
		[Address(RVA = "0x8191C0", Offset = "0x817BC0", VA = "0x1808191C0")]
		private void AfterPutCard(int selectedCard)
		{
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000B9")]
		public EventManager EventManager
		{
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x4D1ED0", Offset = "0x4D08D0", VA = "0x1804D1ED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000920")]
			[Address(RVA = "0x4D2610", Offset = "0x4D1010", VA = "0x1804D2610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000BA")]
		public UIManager UIManager
		{
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x4D1E90", Offset = "0x4D0890", VA = "0x1804D1E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000922")]
			[Address(RVA = "0x4D24F0", Offset = "0x4D0EF0", VA = "0x1804D24F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000924 RID: 2340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000BB")]
		public GuestsManager GuestsManager
		{
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x4D2230", Offset = "0x4D0C30", VA = "0x1804D2230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x4D2740", Offset = "0x4D1140", VA = "0x1804D2740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x00004428 File Offset: 0x00002628
		// (set) Token: 0x06000926 RID: 2342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000BC")]
		public bool HasInitialized
		{
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x822470", Offset = "0x820E70", VA = "0x180822470")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000926")]
			[Address(RVA = "0x822610", Offset = "0x821010", VA = "0x180822610")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x00004440 File Offset: 0x00002640
		// (set) Token: 0x06000928 RID: 2344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000BD")]
		public bool HasEnd
		{
			[Token(Token = "0x6000927")]
			[Address(RVA = "0x822460", Offset = "0x820E60", VA = "0x180822460")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x822600", Offset = "0x821000", VA = "0x180822600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00004458 File Offset: 0x00002658
		// (set) Token: 0x0600092A RID: 2346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000BE")]
		public int RemainingPPoint
		{
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x4404B0", Offset = "0x43EEB0", VA = "0x1804404B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600092A")]
			[Address(RVA = "0x822620", Offset = "0x821020", VA = "0x180822620")]
			set
			{
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00004470 File Offset: 0x00002670
		[Token(Token = "0x170000BF")]
		public float GetNextRefreshTime
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x822440", Offset = "0x820E40", VA = "0x180822440")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00004488 File Offset: 0x00002688
		// (set) Token: 0x0600092D RID: 2349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C0")]
		public int CurrentBigWave
		{
			[Token(Token = "0x600092C")]
			[Address(RVA = "0x48A860", Offset = "0x489260", VA = "0x18048A860")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600092D")]
			[Address(RVA = "0x48ABD0", Offset = "0x4895D0", VA = "0x18048ABD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x000044A0 File Offset: 0x000026A0
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C1")]
		public int CurrentRefreshWaveIndex
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0x419CF0", Offset = "0x4186F0", VA = "0x180419CF0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600092F")]
			[Address(RVA = "0x419D40", Offset = "0x418740", VA = "0x180419D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x000044B8 File Offset: 0x000026B8
		[Token(Token = "0x170000C2")]
		public int FarthestAttackPoint
		{
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x822420", Offset = "0x820E20", VA = "0x180822420")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x000044D0 File Offset: 0x000026D0
		[Token(Token = "0x170000C3")]
		public float FarthestEnemyPoint
		{
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x822430", Offset = "0x820E30", VA = "0x180822430")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000933 RID: 2355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C4")]
		public IncomeControllerFlandre FlandreControllerInUI
		{
			[Token(Token = "0x6000932")]
			[Address(RVA = "0x4E07A0", Offset = "0x4DF1A0", VA = "0x1804E07A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000933")]
			[Address(RVA = "0x4E0B60", Offset = "0x4DF560", VA = "0x1804E0B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C5")]
		public GameObject PoisonVFX
		{
			[Token(Token = "0x6000934")]
			[Address(RVA = "0x8225E0", Offset = "0x820FE0", VA = "0x1808225E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C6")]
		public IEnumerable<DLC4_GuardController> AllActiveGuardControllers
		{
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x821C70", Offset = "0x820670", VA = "0x180821C70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C7")]
		public Dictionary<int, DLC4_GuardController> AllActiveDeskAndGuardControllers
		{
			[Token(Token = "0x6000936")]
			[Address(RVA = "0x4D1EC0", Offset = "0x4D08C0", VA = "0x1804D1EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C8")]
		public List<DLC4_FlandreEnemyCharacterController> AllAliveFlandreControllers
		{
			[Token(Token = "0x6000937")]
			[Address(RVA = "0x821CC0", Offset = "0x8206C0", VA = "0x180821CC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C9")]
		public List<DLC4_FlandreEnemyCharacterController> AllEnabledFlandreControllers
		{
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x821ED0", Offset = "0x8208D0", VA = "0x180821ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CA")]
		[TupleElementNames(new string[] { "BigWaveIndex", "WaveIndex" })]
		public Dictionary<DLC4_FlandreEnemyCharacterController, ValueTuple<int, int>> AllFlandreControllersForConsole
		{
			[Token(Token = "0x6000939")]
			[Address(RVA = "0x48A840", Offset = "0x489240", VA = "0x18048A840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x81B0A0", Offset = "0x819AA0", VA = "0x18081B0A0")]
		public GuestGuardMapping GetTargetControllerMapping(int poolId)
		{
			return default(GuestGuardMapping);
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CB")]
		public IEnumerable<KeyValuePair<int, GuestGuardMapping>> AllCouldUseGuardController
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x821E30", Offset = "0x820830", VA = "0x180821E30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CC")]
		public IEnumerable<int> AllLetterIds
		{
			[Token(Token = "0x600093C")]
			[Address(RVA = "0x821F40", Offset = "0x820940", VA = "0x180821F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600093D RID: 2365 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x170000CD")]
		public float PPointGetMultiplier
		{
			[Token(Token = "0x600093D")]
			[Address(RVA = "0x822480", Offset = "0x820E80", VA = "0x180822480")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x170000CE")]
		public float AttackSpeedMultiplier
		{
			[Token(Token = "0x600093E")]
			[Address(RVA = "0x822160", Offset = "0x820B60", VA = "0x180822160")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x170000CF")]
		public float CoolDownMultiplier
		{
			[Token(Token = "0x600093F")]
			[Address(RVA = "0x8222C0", Offset = "0x820CC0", VA = "0x1808222C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D0")]
		public List<KeyValuePair<int, TileManager.GuestTableData>> AllDeskTables
		{
			[Token(Token = "0x6000940")]
			[Address(RVA = "0x48A930", Offset = "0x489330", VA = "0x18048A930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x4D2320", Offset = "0x4D0D20", VA = "0x1804D2320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D1")]
		public List<int> AllDeskY
		{
			[Token(Token = "0x6000942")]
			[Address(RVA = "0x48A610", Offset = "0x489010", VA = "0x18048A610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000943")]
			[Address(RVA = "0x4D2450", Offset = "0x4D0E50", VA = "0x1804D2450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x820720", Offset = "0x81F120", VA = "0x180820720")]
		public bool TryGetTargetPositionGuardController(int deskCode, out DLC4_GuardController guardController)
		{
			return default(bool);
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000946 RID: 2374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000D2")]
		public Action<DLC4_FlandreEnemyCharacterController> OnEnemySpawn
		{
			[Token(Token = "0x6000945")]
			[Address(RVA = "0x4D1E30", Offset = "0x4D0830", VA = "0x1804D1E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000946")]
			[Address(RVA = "0x4D2430", Offset = "0x4D0E30", VA = "0x1804D2430")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x821660", Offset = "0x820060", VA = "0x180821660")]
		public void WhenHakaishinDie()
		{
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000948")]
		[Address(RVA = "0x8191B0", Offset = "0x817BB0", VA = "0x1808191B0")]
		public void AfterHakaishinCompletelyDie()
		{
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x6000949")]
		[Address(RVA = "0x81A120", Offset = "0x818B20", VA = "0x18081A120")]
		public bool CheckIfFailed()
		{
			return default(bool);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x600094A")]
		[Address(RVA = "0x819DE0", Offset = "0x8187E0", VA = "0x180819DE0")]
		public bool CheckAliveFlandre()
		{
			return default(bool);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x600094B")]
		[Address(RVA = "0x81AD80", Offset = "0x819780", VA = "0x18081AD80")]
		public Vector3Int GetGuestTable(int deskCode)
		{
			return default(Vector3Int);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600094C")]
		[Address(RVA = "0x81A950", Offset = "0x819350", VA = "0x18081A950")]
		private GuestsManager.OrderBase GenerateOrder(GuestGroupController guest, out string orderGenerationMessage)
		{
			return null;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600094D")]
		[Address(RVA = "0x81D400", Offset = "0x81BE00", VA = "0x18081D400")]
		private void OnGuardDefeatedByFlandre(int deskCode, Action onBuffEnd)
		{
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600094E")]
		[Address(RVA = "0x818FE0", Offset = "0x8179E0", VA = "0x180818FE0")]
		public void AddPPoint(int value)
		{
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600094F")]
		[Address(RVA = "0x81A6C0", Offset = "0x8190C0", VA = "0x18081A6C0")]
		public void CostPPoint(int value)
		{
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x6000950")]
		[Address(RVA = "0x81A1D0", Offset = "0x818BD0", VA = "0x18081A1D0")]
		public bool CheckLetter(int letterId)
		{
			return default(bool);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000951")]
		[Address(RVA = "0x81AE10", Offset = "0x819810", VA = "0x18081AE10")]
		private void GetLetter(params int[] letterIds)
		{
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000952")]
		[Address(RVA = "0x81E260", Offset = "0x81CC60", VA = "0x18081E260")]
		private void RemoveLetter(params int[] letterIds)
		{
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x81D8E0", Offset = "0x81C2E0", VA = "0x18081D8E0")]
		public void OnTickUpdate()
		{
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000954")]
		[Address(RVA = "0x81E420", Offset = "0x81CE20", VA = "0x18081E420")]
		private void SetCoolDownProgressInIndicator(bool startCoolDown)
		{
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x81E370", Offset = "0x81CD70", VA = "0x18081E370")]
		private void ResetRemainingCoolDown(IEnumerable<int> guardLetterIds)
		{
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000956")]
		[Address(RVA = "0x81CA30", Offset = "0x81B430", VA = "0x18081CA30")]
		public void OnActiveEnemyHpChange()
		{
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000957")]
		[Address(RVA = "0x81D8C0", Offset = "0x81C2C0", VA = "0x18081D8C0")]
		public void OnRefreshTimeModify()
		{
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000958")]
		[Address(RVA = "0x81D8A0", Offset = "0x81C2A0", VA = "0x18081D8A0")]
		public void OnRefreshNextBigWave()
		{
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000959")]
		[Address(RVA = "0x81FD60", Offset = "0x81E760", VA = "0x18081FD60")]
		public GameObject SpawnLevelFlag1VFX(Vector3 tablePosition)
		{
			return null;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095A")]
		[Address(RVA = "0x81FE70", Offset = "0x81E870", VA = "0x18081FE70")]
		public GameObject SpawnLevelFlag2VFX(Vector3 tablePosition)
		{
			return null;
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095B")]
		[Address(RVA = "0x81C6C0", Offset = "0x81B0C0", VA = "0x18081C6C0")]
		public GameObject LevelUpTo2(Vector3 guardPosition)
		{
			return null;
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095C")]
		[Address(RVA = "0x81C570", Offset = "0x81AF70", VA = "0x18081C570")]
		public GameObject LevelUpAndUseSkill(Vector3 guardPosition)
		{
			return null;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600095D")]
		[Address(RVA = "0x81DC00", Offset = "0x81C600", VA = "0x18081DC00")]
		private void PatchouliSpellCardStartCoolDown(bool showEndVFX)
		{
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600095E")]
		[Address(RVA = "0x81DFB0", Offset = "0x81C9B0", VA = "0x18081DFB0")]
		private void RefreshPatchiCards()
		{
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600095F")]
		[Address(RVA = "0x8214F0", Offset = "0x81FEF0", VA = "0x1808214F0")]
		private IEnumerator UsePatchouliSpell(PatchouliMagicSpellCardIndex spellCardIndex)
		{
			return null;
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000960")]
		[Address(RVA = "0x81FF80", Offset = "0x81E980", VA = "0x18081FF80")]
		private GameObject SpawnMagicVfx(PatchouliSpellBase spellBase)
		{
			return null;
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000961")]
		[Address(RVA = "0x81F050", Offset = "0x81DA50", VA = "0x18081F050")]
		private void SpawnEndVfx(PatchouliSpellBase spellBase, GameObject currentVfx)
		{
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000962")]
		[Address(RVA = "0x81AEA0", Offset = "0x8198A0", VA = "0x18081AEA0")]
		private string GetPatchouliSpellReplacedMethodBuff(PatchouliMagicSpellCardIndex spellCardIndex, string oldText, int currentTime)
		{
			return null;
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000963")]
		[Address(RVA = "0x81AF30", Offset = "0x819930", VA = "0x18081AF30")]
		private string GetPatchouliSpellReplacedMethodDescription(PatchouliMagicSpellCardIndex spellCardIndex, string oldText)
		{
			return null;
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000964")]
		[Address(RVA = "0x81A230", Offset = "0x818C30", VA = "0x18081A230", Slot = "11")]
		protected virtual void Cleanup_Generated()
		{
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x821670", Offset = "0x820070", VA = "0x180821670")]
		public DLC4_BossBattleManager()
		{
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x6000966")]
		[Address(RVA = "0x81AC80", Offset = "0x819680", VA = "0x18081AC80", Slot = "5")]
		private float Night.BossBattle.DLC4_BossBattle.IChallengeCardSelectorPanelDB.GetCardCoolDownProgress(in GuestGuardMapping mapping)
		{
			return 0f;
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x6000967")]
		[Address(RVA = "0x819D60", Offset = "0x818760", VA = "0x180819D60", Slot = "6")]
		private bool Night.BossBattle.DLC4_BossBattle.IChallengeCardSelectorPanelDB.CanBuyCard(in GuestGuardMapping mapping)
		{
			return default(bool);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x81C4F0", Offset = "0x81AEF0", VA = "0x18081C4F0", Slot = "7")]
		private bool Night.BossBattle.DLC4_BossBattle.IChallengeCardSelectorPanelDB.IsCardOnField(in GuestGuardMapping mapping)
		{
			return default(bool);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00004608 File Offset: 0x00002808
		[Token(Token = "0x6000969")]
		[Address(RVA = "0x81C490", Offset = "0x81AE90", VA = "0x18081C490", Slot = "8")]
		private bool Night.BossBattle.DLC4_BossBattle.IChallengeCardSelectorPanelDB.IsCardBought(in GuestGuardMapping mapping)
		{
			return default(bool);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600096A")]
		[Address(RVA = "0x81CA10", Offset = "0x81B410", VA = "0x18081CA10", Slot = "9")]
		private void Night.BossBattle.DLC4_BossBattle.IChallengeCardSelectorPanelDB.BuyCard(in GuestGuardMapping mapping)
		{
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600096B")]
		[Address(RVA = "0x81CA20", Offset = "0x81B420", VA = "0x18081CA20", Slot = "10")]
		private void Night.BossBattle.DLC4_BossBattle.IChallengeCardSelectorPanelDB.UseCard(in GuestGuardMapping mapping)
		{
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600096E")]
		[Address(RVA = "0x8212E0", Offset = "0x81FCE0", VA = "0x1808212E0")]
		[CompilerGenerated]
		private void <Initialize>g__AddPatchouliSpellModels|44_7(PatchouliSpellBase model)
		{
		}

		// Token: 0x0400083F RID: 2111
		[Token(Token = "0x400083F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DLC4_MystiaVSFlandreBossData bossDataScriptObject;

		// Token: 0x04000840 RID: 2112
		[Token(Token = "0x4000840")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<int, DLC4_BossBattleManager.HeroGuestGuardController> AllHeroGuests;

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<int, NormalGuestsController> AllFakeTables;

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly HashSet<PatchouliMagicSpellCardIndex> couldUsedPatchouliMagicSpellCards;

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<PatchouliMagicSpellCardIndex> currentPatchouliMagicSpellCards;

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Dictionary<PatchouliMagicSpellCardIndex, PatchouliSpellBase> patchouliSpellCardTextMethods;

		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x4000845")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<float> pPointGetModifier;

		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly List<float> attackSpeedModifier;

		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly List<float> coolDownModifier;

		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly Dictionary<FlandreTypeIndex, ObjectPool<DLC4_FlandreEnemyCharacterController>> FlandrePool;

		// Token: 0x04000849 RID: 2121
		[Token(Token = "0x4000849")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private readonly Dictionary<int, ObjectPool<DLC4_GuardController>> GuardPool;

		// Token: 0x0400084A RID: 2122
		[Token(Token = "0x400084A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private readonly Dictionary<BulletTypeIndex, ObjectPool<DLC4_BulletBase>> BulletPool;

		// Token: 0x0400084B RID: 2123
		[Token(Token = "0x400084B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Dictionary<BossBattleVFX, ObjectPool<GameObject>> VFXPool;

		// Token: 0x0400084C RID: 2124
		[Token(Token = "0x400084C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private List<int> GuardsInCoolDown;

		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x400084D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<int> AllPlayerUnlockedLetterId;

		// Token: 0x0400084E RID: 2126
		[Token(Token = "0x400084E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private HashSet<int> AllPlayerHoldingLetter;

		// Token: 0x0400084F RID: 2127
		[Token(Token = "0x400084F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<int, GuestGuardMapping> ItemIdToGuardControllerDic;

		// Token: 0x04000850 RID: 2128
		[Token(Token = "0x4000850")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<int, float> GuardRemainingCoolDownDic;

		// Token: 0x04000851 RID: 2129
		[Token(Token = "0x4000851")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Dictionary<FlandreTypeIndex, DLC4_FlandreEnemyCharacterController> FlandrePrefabs;

		// Token: 0x04000852 RID: 2130
		[Token(Token = "0x4000852")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TileManager tileManager;

		// Token: 0x04000853 RID: 2131
		[Token(Token = "0x4000853")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int remainingPPoint;

		// Token: 0x04000854 RID: 2132
		[Token(Token = "0x4000854")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float remainingPatchouliCoolDownTime;

		// Token: 0x04000855 RID: 2133
		[Token(Token = "0x4000855")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float lastLineXPosition;

		// Token: 0x04000856 RID: 2134
		[Token(Token = "0x4000856")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Action onActiveEnemyHpChangeCallback;

		// Token: 0x04000857 RID: 2135
		[Token(Token = "0x4000857")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Action onRefreshTimeModifyCallback;

		// Token: 0x04000858 RID: 2136
		[Token(Token = "0x4000858")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Action onRefreshNextBigWaveCallback;

		// Token: 0x04000859 RID: 2137
		[Token(Token = "0x4000859")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Action onTickUpdateCallback;

		// Token: 0x0400085A RID: 2138
		[Token(Token = "0x400085A")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Action<int> onFlandreNumChangeCallback;

		// Token: 0x0400085B RID: 2139
		[Token(Token = "0x400085B")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Func<float> getNextRefreshTime;

		// Token: 0x0400085C RID: 2140
		[Token(Token = "0x400085C")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int bossFlandreAliveCheck;

		// Token: 0x0400085D RID: 2141
		[Token(Token = "0x400085D")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private int currentOpenedDeskCode;

		// Token: 0x0400085E RID: 2142
		[Token(Token = "0x400085E")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int lastSpawnLine;

		// Token: 0x0400085F RID: 2143
		[Token(Token = "0x400085F")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public readonly List<int> HasSpawnLine;

		// Token: 0x0400086D RID: 2157
		[Token(Token = "0x400086D")]
		private const int FARTHEST_ATTACK_POINT = 11;

		// Token: 0x0400086E RID: 2158
		[Token(Token = "0x400086E")]
		private const int SHOP_GUESTTABLE = 12;

		// Token: 0x0400086F RID: 2159
		[Token(Token = "0x400086F")]
		private const int PATCHOULI_GUEST_TABLE = 13;

		// Token: 0x04000870 RID: 2160
		[Token(Token = "0x4000870")]
		private const float SPAWN_LINE_X_POSITION = 11f;

		// Token: 0x04000871 RID: 2161
		[Token(Token = "0x4000871")]
		private const int PATCHOULI_GUEST_ID = 27;

		// Token: 0x04000872 RID: 2162
		[Token(Token = "0x4000872")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int tableNum;

		// Token: 0x02000184 RID: 388
		[Token(Token = "0x2000184")]
		private class HeroGuestGuardController
		{
			// Token: 0x0600097C RID: 2428 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600097C")]
			[Address(RVA = "0x82C830", Offset = "0x82B230", VA = "0x18082C830")]
			public HeroGuestGuardController(SpecialGuestsController controller, Vector3Int idlePosition, int idleRotation, bool hasIdled)
			{
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x0600097D RID: 2429 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600097E RID: 2430 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170000D3")]
			public SpecialGuestsController Controller
			{
				[Token(Token = "0x600097D")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600097E")]
				[Address(RVA = "0x4A6ED0", Offset = "0x4A58D0", VA = "0x1804A6ED0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x0600097F RID: 2431 RVA: 0x00004680 File Offset: 0x00002880
			[Token(Token = "0x170000D4")]
			public Vector3Int IdlePosition
			{
				[Token(Token = "0x600097F")]
				[Address(RVA = "0x6AE7D0", Offset = "0x6AD1D0", VA = "0x1806AE7D0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3Int);
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x06000980 RID: 2432 RVA: 0x00004698 File Offset: 0x00002898
			[Token(Token = "0x170000D5")]
			public int IdleRotation
			{
				[Token(Token = "0x6000980")]
				[Address(RVA = "0x5E3C40", Offset = "0x5E2640", VA = "0x1805E3C40")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x06000981 RID: 2433 RVA: 0x000046B0 File Offset: 0x000028B0
			// (set) Token: 0x06000982 RID: 2434 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170000D6")]
			public bool HasIdled
			{
				[Token(Token = "0x6000981")]
				[Address(RVA = "0x685340", Offset = "0x683D40", VA = "0x180685340")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000982")]
				[Address(RVA = "0x6FC830", Offset = "0x6FB230", VA = "0x1806FC830")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000983 RID: 2435 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x4A6ED0", Offset = "0x4A58D0", VA = "0x1804A6ED0")]
			public void SetNewController(SpecialGuestsController controller)
			{
			}

			// Token: 0x06000984 RID: 2436 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x6FC830", Offset = "0x6FB230", VA = "0x1806FC830")]
			public void SetIdleState(bool state)
			{
			}
		}
	}
}
