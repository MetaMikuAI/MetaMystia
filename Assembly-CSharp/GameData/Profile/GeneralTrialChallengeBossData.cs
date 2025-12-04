using System;
using System.Collections;
using Cysharp.Threading.Tasks;
using GameData.Core.Collections.NightSceneUtility;
using GameData.RunTime.NightSceneUtility;
using Il2CppDummyDll;
using NightScene;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.UI;
using NightScene.UI.HUDUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C5B RID: 3163
	[Token(Token = "0x2000C5B")]
	public class GeneralTrialChallengeBossData : BossData
	{
		// Token: 0x060049F2 RID: 18930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F2")]
		[Address(RVA = "0x77E060", Offset = "0x77CA60", VA = "0x18077E060", Slot = "6")]
		protected virtual void OnPreloadGeneralChallenge()
		{
		}

		// Token: 0x060049F3 RID: 18931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F3")]
		[Address(RVA = "0x77E040", Offset = "0x77CA40", VA = "0x18077E040", Slot = "7")]
		protected virtual void OnChallengeEnd()
		{
		}

		// Token: 0x060049F4 RID: 18932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60049F4")]
		[Address(RVA = "0x77DF80", Offset = "0x77C980", VA = "0x18077DF80", Slot = "5")]
		public sealed override IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			return null;
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F5")]
		[Address(RVA = "0x77E130", Offset = "0x77CB30", VA = "0x18077E130")]
		private void SetGlobalInput(UIManager uiManager, bool active)
		{
		}

		// Token: 0x060049F6 RID: 18934 RVA: 0x0001AC70 File Offset: 0x00018E70
		[Token(Token = "0x60049F6")]
		[Address(RVA = "0x77DD70", Offset = "0x77C770", VA = "0x18077DD70")]
		private UniTask MainChallengeLoopAsync(BossData.BossDataContext bossDataContext)
		{
			return default(UniTask);
		}

		// Token: 0x060049F7 RID: 18935 RVA: 0x0001AC88 File Offset: 0x00018E88
		[Token(Token = "0x60049F7")]
		[Address(RVA = "0x77DB90", Offset = "0x77C590", VA = "0x18077DB90")]
		private UniTask<bool> ExecuteRoundAsync(EventManager eventManager, UIManager uiManager, GuestsManager guestsManager, IzakayaConfigure izakayaConfigure, CookSystemManager cookSystemManagerInstance, SpecialGuest youm, bool includesSpecialGuest, IncomeControllerChallenge incomeControllerChallenge, int roundNum)
		{
			return default(UniTask<bool>);
		}

		// Token: 0x060049F8 RID: 18936 RVA: 0x0001ACA0 File Offset: 0x00018EA0
		[Token(Token = "0x60049F8")]
		[Address(RVA = "0x77DD30", Offset = "0x77C730", VA = "0x18077DD30")]
		private bool HaveReachTargetRequirement(EventManager eventManager, bool includesSpecialGuest, SceneManager.DataPair item, int gainedSpellCard, int currentRequiredSpellAmount)
		{
			return default(bool);
		}

		// Token: 0x060049F9 RID: 18937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60049F9")]
		[Address(RVA = "0x764840", Offset = "0x763240", VA = "0x180764840")]
		public GeneralTrialChallengeBossData()
		{
		}

		// Token: 0x040043FB RID: 17403
		[Token(Token = "0x40043FB")]
		private const int BASIC_SPELL_LANG_BEGIN = 2;

		// Token: 0x040043FC RID: 17404
		[Token(Token = "0x40043FC")]
		private const int ADVANCED_SPELL_LANG_BEGIN = 5;

		// Token: 0x040043FD RID: 17405
		[Token(Token = "0x40043FD")]
		[FieldOffset(Offset = "0x30")]
		[Header("- General Trial Challenge Boss Data")]
		[SerializeField]
		protected int singleRoundDuration;

		// Token: 0x040043FE RID: 17406
		[Token(Token = "0x40043FE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SceneManager.DataPair[] roundConfiguration;

		// Token: 0x040043FF RID: 17407
		[Token(Token = "0x40043FF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2Int baseFundRange;

		// Token: 0x04004400 RID: 17408
		[Token(Token = "0x4004400")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector2Int normalGuestInterval;

		// Token: 0x04004401 RID: 17409
		[Token(Token = "0x4004401")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float specialGuestGachaInterval;

		// Token: 0x04004402 RID: 17410
		[Token(Token = "0x4004402")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int[] specialGuestSpellRequirement;

		// Token: 0x04004403 RID: 17411
		[Token(Token = "0x4004403")]
		[FieldOffset(Offset = "0x60")]
		protected Action onChallengeEnd;
	}
}
