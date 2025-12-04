using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using DayScene.Input;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using GameData.RunTime.Common;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.RunTime.DaySceneUtility
{
	// Token: 0x020007E7 RID: 2023
	[Token(Token = "0x20007E7")]
	public static class RunTimeDayScene
	{
		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06002FB0 RID: 12208 RVA: 0x000116D0 File Offset: 0x0000F8D0
		// (set) Token: 0x06002FB1 RID: 12209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064C")]
		public static int RemainActions
		{
			[Token(Token = "0x6002FB0")]
			[Address(RVA = "0x616300", Offset = "0x614D00", VA = "0x180616300")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002FB1")]
			[Address(RVA = "0x616400", Offset = "0x614E00", VA = "0x180616400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06002FB2 RID: 12210 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002FB3 RID: 12211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064D")]
		public static Action OnRequireCurrentMapRefreshCallback
		{
			[Token(Token = "0x6002FB2")]
			[Address(RVA = "0x616280", Offset = "0x614C80", VA = "0x180616280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002FB3")]
			[Address(RVA = "0x616340", Offset = "0x614D40", VA = "0x180616340")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06002FB4 RID: 12212 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002FB5 RID: 12213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700064E")]
		public static Action<string, bool> OnToggleTrackedSwitch
		{
			[Token(Token = "0x6002FB4")]
			[Address(RVA = "0x6162C0", Offset = "0x614CC0", VA = "0x1806162C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002FB5")]
			[Address(RVA = "0x6163A0", Offset = "0x614DA0", VA = "0x1806163A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002FB6 RID: 12214 RVA: 0x000116E8 File Offset: 0x0000F8E8
		[Token(Token = "0x6002FB6")]
		[Address(RVA = "0x612280", Offset = "0x610C80", VA = "0x180612280")]
		public static bool GetTrackedSwitch(string key, bool onByDefault)
		{
			return default(bool);
		}

		// Token: 0x06002FB7 RID: 12215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB7")]
		[Address(RVA = "0x6152D0", Offset = "0x613CD0", VA = "0x1806152D0")]
		public static void ToggleTrackedSwitch(string key, bool isOpen)
		{
		}

		// Token: 0x06002FB8 RID: 12216 RVA: 0x00011700 File Offset: 0x0000F900
		[Token(Token = "0x6002FB8")]
		[Address(RVA = "0x613EE0", Offset = "0x6128E0", VA = "0x180613EE0")]
		public static bool RefTrackedSwitchAvailability(this string key, bool onByDefault)
		{
			return default(bool);
		}

		// Token: 0x06002FB9 RID: 12217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FB9")]
		[Address(RVA = "0x610090", Offset = "0x60EA90", VA = "0x180610090")]
		public static TrackedCollectable[] GetAllCollectables()
		{
			return null;
		}

		// Token: 0x06002FBA RID: 12218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBA")]
		[Address(RVA = "0x610540", Offset = "0x60EF40", VA = "0x180610540")]
		public static string GetAllTrackedCollectablesData()
		{
			return null;
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBB")]
		[Address(RVA = "0x6108C0", Offset = "0x60F2C0", VA = "0x1806108C0")]
		public static string GetAllTrackedNPCsData()
		{
			return null;
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x00011718 File Offset: 0x0000F918
		[Token(Token = "0x6002FBC")]
		[Address(RVA = "0x60FE60", Offset = "0x60E860", VA = "0x18060FE60")]
		public static PlayerSaveFile.RunTimeDaySceneSaveDataPartial GenerateSaveData()
		{
			return default(PlayerSaveFile.RunTimeDaySceneSaveDataPartial);
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FBD")]
		[Address(RVA = "0x612460", Offset = "0x610E60", VA = "0x180612460")]
		public static void Initialize(PlayerSaveFile.RunTimeDaySceneSaveDataPartial dataPartial, Dictionary<string, PlayerSaveFile.DLCDaySceneSaveData> dayScenePartialDLC)
		{
		}

		// Token: 0x06002FBE RID: 12222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FBE")]
		[Address(RVA = "0x613060", Offset = "0x611A60", VA = "0x180613060")]
		private static void InitilizeTrackedNPC(PlayerSaveFile.RunTimeDaySceneSaveDataPartial dataPartial, Dictionary<string, PlayerSaveFile.DLCDaySceneSaveData> dayScenePartialDLC)
		{
		}

		// Token: 0x06002FBF RID: 12223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FBF")]
		[Address(RVA = "0x614FA0", Offset = "0x6139A0", VA = "0x180614FA0")]
		public static void SetupDay(Action onDayEnd)
		{
		}

		// Token: 0x06002FC0 RID: 12224 RVA: 0x00011730 File Offset: 0x0000F930
		[Token(Token = "0x6002FC0")]
		[Address(RVA = "0x611C50", Offset = "0x610650", VA = "0x180611C50")]
		public static int GetTotalActions()
		{
			return 0;
		}

		// Token: 0x06002FC1 RID: 12225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC1")]
		[Address(RVA = "0x610A20", Offset = "0x60F420", VA = "0x180610A20")]
		public static List<string> GetAllUnlockedMap()
		{
			return null;
		}

		// Token: 0x06002FC2 RID: 12226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC2")]
		[Address(RVA = "0x615780", Offset = "0x614180", VA = "0x180615780")]
		public static void UnlockMap(string key)
		{
		}

		// Token: 0x06002FC3 RID: 12227 RVA: 0x00011748 File Offset: 0x0000F948
		[Token(Token = "0x6002FC3")]
		[Address(RVA = "0x611830", Offset = "0x610230", VA = "0x180611830")]
		public static bool GetMapOpenStatus(string key)
		{
			return default(bool);
		}

		// Token: 0x06002FC4 RID: 12228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC4")]
		[Address(RVA = "0x6156A0", Offset = "0x6140A0", VA = "0x1806156A0")]
		public static void TryRefreshMerchantData(string key)
		{
		}

		// Token: 0x06002FC5 RID: 12229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FC5")]
		[Address(RVA = "0x611C60", Offset = "0x610660", VA = "0x180611C60")]
		private static TrackedCollectable GetTrackedCollectable(string key)
		{
			return null;
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x00011760 File Offset: 0x0000F960
		[Token(Token = "0x6002FC6")]
		[Address(RVA = "0x612430", Offset = "0x610E30", VA = "0x180612430")]
		public static bool HasCollectableUnlocked(Collectable collectable)
		{
			return default(bool);
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x00011778 File Offset: 0x0000F978
		[Token(Token = "0x6002FC7")]
		[Address(RVA = "0x613D30", Offset = "0x612730", VA = "0x180613D30")]
		public static bool RefTrackedCollectableAvailability(this string key)
		{
			return default(bool);
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC8")]
		[Address(RVA = "0x6151D0", Offset = "0x613BD0", VA = "0x1806151D0")]
		public static void ToggleTrackedCollectable(string key, bool shouldOn)
		{
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FC9")]
		[Address(RVA = "0x60FCB0", Offset = "0x60E6B0", VA = "0x18060FCB0")]
		public static void CollectTrackedCollectable(string key)
		{
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FCA")]
		[Address(RVA = "0x615B50", Offset = "0x614550", VA = "0x180615B50")]
		public static void UpdateTrackedCollectableCoolDown(int actions)
		{
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FCB")]
		[Address(RVA = "0x611370", Offset = "0x60FD70", VA = "0x180611370")]
		public static KourindoStaticMerchandiseProfile.KourindoStaticMerchandise[] GetKourindoStaticMerchandises()
		{
			return null;
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FCC")]
		[Address(RVA = "0x60F8B0", Offset = "0x60E2B0", VA = "0x18060F8B0")]
		public static void AddToKourindoStaticMerchandise(IEnumerable<string> data)
		{
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FCD")]
		[Address(RVA = "0x613FB0", Offset = "0x6129B0", VA = "0x180613FB0")]
		public static void RemoveFromKourindoStaticMerchandise(IEnumerable<string> data)
		{
		}

		// Token: 0x06002FCE RID: 12238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FCE")]
		[Address(RVA = "0x615430", Offset = "0x613E30", VA = "0x180615430")]
		public static void TryDeductProductNum(string label, int productNum)
		{
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FCF")]
		[Address(RVA = "0x611F60", Offset = "0x610960", VA = "0x180611F60")]
		private static TrackedNPC GetTrackedNPC(string key)
		{
			return null;
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD0")]
		[Address(RVA = "0x6145E0", Offset = "0x612FE0", VA = "0x1806145E0")]
		private static void RemoveNPC(string npcLabel)
		{
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD1")]
		[Address(RVA = "0x60F840", Offset = "0x60E240", VA = "0x18060F840")]
		private static void AddNPC(TrackedNPC npc, string mapLabel)
		{
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD2")]
		[Address(RVA = "0x6116E0", Offset = "0x6100E0", VA = "0x1806116E0")]
		public static Dictionary<string, TrackedNPC> GetMapNPCs(string mapLabel)
		{
			return null;
		}

		// Token: 0x06002FD3 RID: 12243 RVA: 0x00011790 File Offset: 0x0000F990
		[Token(Token = "0x6002FD3")]
		[Address(RVA = "0x615550", Offset = "0x613F50", VA = "0x180615550")]
		public static bool TryGetNpcOverridePositionAndRotation(string characterLabel, out Vector2 position, out DayScenePlayerInputGenerator.CharacterRotation rotation)
		{
			return default(bool);
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x000117A8 File Offset: 0x0000F9A8
		[Token(Token = "0x6002FD4")]
		[Address(RVA = "0x613E80", Offset = "0x612880", VA = "0x180613E80")]
		public static bool RefTrackedNPCAvailability(this string key)
		{
			return default(bool);
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD5")]
		[Address(RVA = "0x615260", Offset = "0x613C60", VA = "0x180615260")]
		public static void ToggleTrackedNPC(string key, bool shouldOn)
		{
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD6")]
		[Address(RVA = "0x613830", Offset = "0x612230", VA = "0x180613830")]
		public static void MoveCharacter(string characterLabel, string mapLabel, Vector2 position, int rotation, out TrackedNPC.OverridePosition oldNPCData)
		{
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD7")]
		[Address(RVA = "0x614700", Offset = "0x613100", VA = "0x180614700")]
		public static void ReturnCharacter(string characterLabel)
		{
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD8")]
		[Address(RVA = "0x60F720", Offset = "0x60E120", VA = "0x18060F720")]
		public static void AddNPCDialog(string characterLabel, string destinationLabel, string dialogPackage)
		{
		}

		// Token: 0x06002FD9 RID: 12249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FD9")]
		[Address(RVA = "0x6145A0", Offset = "0x612FA0", VA = "0x1806145A0")]
		public static void RemoveNPCDialog(string characterLabel, string destinationLabel, string dialogPackage)
		{
		}

		// Token: 0x06002FDA RID: 12250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FDA")]
		[Address(RVA = "0x614D60", Offset = "0x613760", VA = "0x180614D60")]
		public static void SetNPCDialog(string characterLabel, string destinationLabel, string[] dialogPackageIds)
		{
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x000117C0 File Offset: 0x0000F9C0
		[Token(Token = "0x6002FDB")]
		[Address(RVA = "0x613800", Offset = "0x612200", VA = "0x180613800")]
		public static bool IsNPCOverridePosition(string characterLabel)
		{
			return default(bool);
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x000117D8 File Offset: 0x0000F9D8
		[Token(Token = "0x6002FDC")]
		[Address(RVA = "0x611A10", Offset = "0x610410", VA = "0x180611A10")]
		public static float GetNPCToTargetDistance(string characterLabel, Vector2 targetPosition)
		{
			return 0f;
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x000117F0 File Offset: 0x0000F9F0
		[Token(Token = "0x6002FDD")]
		[Address(RVA = "0x612350", Offset = "0x610D50", VA = "0x180612350")]
		public static bool HasChatData(string characterLabel)
		{
			return default(bool);
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FDE")]
		[Address(RVA = "0x610D50", Offset = "0x60F750", VA = "0x180610D50")]
		public static DialogPackage GetCharacterChatData(string characterKey, bool isPostChat)
		{
			return null;
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FDF")]
		[Address(RVA = "0x611980", Offset = "0x610380", VA = "0x180611980")]
		public static TrackedMerchant GetMerchantData(string characterKey)
		{
			return null;
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x00011808 File Offset: 0x0000FA08
		[Token(Token = "0x6002FE0")]
		[Address(RVA = "0x60FD30", Offset = "0x60E730", VA = "0x18060FD30")]
		public static bool DoSell(string characterKey)
		{
			return default(bool);
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x00011820 File Offset: 0x0000FA20
		[Token(Token = "0x6002FE1")]
		[Address(RVA = "0x613790", Offset = "0x612190", VA = "0x180613790")]
		public static bool IsMerchant(string characterKey)
		{
			return default(bool);
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE2")]
		[Address(RVA = "0x60FDF0", Offset = "0x60E7F0", VA = "0x18060FDF0")]
		public static void EnableTrackedNPC(string key)
		{
		}

		// Token: 0x06002FE3 RID: 12259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FE3")]
		[Address(RVA = "0x611E50", Offset = "0x610850", VA = "0x180611E50")]
		private static TrackedInteractable GetTrackedInteractable(string key)
		{
			return null;
		}

		// Token: 0x06002FE4 RID: 12260 RVA: 0x00011838 File Offset: 0x0000FA38
		[Token(Token = "0x6002FE4")]
		[Address(RVA = "0x613E40", Offset = "0x612840", VA = "0x180613E40")]
		public static bool RefTrackedInteractableAvailability(this string key)
		{
			return default(bool);
		}

		// Token: 0x06002FE5 RID: 12261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE5")]
		[Address(RVA = "0x614EF0", Offset = "0x6138F0", VA = "0x180614EF0")]
		public static void SetTrackedInteractableAvailability(this string key, bool openStatus)
		{
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x00011850 File Offset: 0x0000FA50
		[Token(Token = "0x6002FE6")]
		[Address(RVA = "0x613E60", Offset = "0x612860", VA = "0x180613E60")]
		public static int RefTrackedInteractableTime(this string key)
		{
			return 0;
		}

		// Token: 0x06002FE7 RID: 12263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE7")]
		[Address(RVA = "0x614F70", Offset = "0x613970", VA = "0x180614F70")]
		public static void SetTrackedInteractableTime(this string key, int trackedTime)
		{
		}

		// Token: 0x06002FE8 RID: 12264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE8")]
		[Address(RVA = "0x613C40", Offset = "0x612640", VA = "0x180613C40")]
		public static void OnTrackedInteractableActivate(this string key)
		{
		}

		// Token: 0x06002FE9 RID: 12265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FE9")]
		[Address(RVA = "0x615730", Offset = "0x614130", VA = "0x180615730")]
		private static void TryRefreshNPCs()
		{
		}

		// Token: 0x06002FEA RID: 12266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEA")]
		[Address(RVA = "0x616200", Offset = "0x614C00", VA = "0x180616200")]
		public static void WarpHours(int hours, Action<Action> onCustomEventFinish)
		{
		}

		// Token: 0x06002FEB RID: 12267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEB")]
		[Address(RVA = "0x616230", Offset = "0x614C30", VA = "0x180616230")]
		public static void WarpToNight(Action<Action> onCustomEventFinish)
		{
		}

		// Token: 0x06002FEC RID: 12268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEC")]
		[Address(RVA = "0x6139E0", Offset = "0x6123E0", VA = "0x1806139E0")]
		public static void OnDayEnd()
		{
		}

		// Token: 0x06002FED RID: 12269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FED")]
		[Address(RVA = "0x615D20", Offset = "0x614720", VA = "0x180615D20")]
		public static void WarpActions(int actions, Action<Action> onCustomEventFinish)
		{
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEE")]
		[Address(RVA = "0x615C50", Offset = "0x614650", VA = "0x180615C50")]
		public static void WarpActionsAsync(int actions, Func<UniTask> beforeDayEndEvent)
		{
		}

		// Token: 0x06002FEF RID: 12271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FEF")]
		[Address(RVA = "0x6147E0", Offset = "0x6131E0", VA = "0x1806147E0")]
		public static void SetActions(int actions)
		{
		}

		// Token: 0x06002FF0 RID: 12272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF0")]
		[Address(RVA = "0x615650", Offset = "0x614050", VA = "0x180615650")]
		private static void TryInvokeOnDayOverEvent()
		{
		}

		// Token: 0x06002FF1 RID: 12273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF1")]
		[Address(RVA = "0x613B70", Offset = "0x612570", VA = "0x180613B70")]
		private static void OnTimePassInternal(int actions)
		{
		}

		// Token: 0x06002FF2 RID: 12274 RVA: 0x00011868 File Offset: 0x0000FA68
		[Token(Token = "0x6002FF2")]
		[Address(RVA = "0x611DC0", Offset = "0x6107C0", VA = "0x180611DC0")]
		public static int GetTrackedCount(string id)
		{
			return 0;
		}

		// Token: 0x06002FF3 RID: 12275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF3")]
		[Address(RVA = "0x614E10", Offset = "0x613810", VA = "0x180614E10")]
		public static void SetTrackedCount(string id, int count)
		{
		}

		// Token: 0x06002FF4 RID: 12276 RVA: 0x00011880 File Offset: 0x0000FA80
		[Token(Token = "0x6002FF4")]
		[Address(RVA = "0x615480", Offset = "0x613E80", VA = "0x180615480")]
		public static bool TryGetMusicalNoteSpeed(string musicId, bool isEasy, out float musicalNoteSpeed)
		{
			return default(bool);
		}

		// Token: 0x06002FF5 RID: 12277 RVA: 0x00011898 File Offset: 0x0000FA98
		[Token(Token = "0x6002FF5")]
		[Address(RVA = "0x611B10", Offset = "0x610510", VA = "0x180611B10")]
		public static float GetNoteSpeed(float progress)
		{
			return 0f;
		}

		// Token: 0x06002FF6 RID: 12278 RVA: 0x000118B0 File Offset: 0x0000FAB0
		[Token(Token = "0x6002FF6")]
		[Address(RVA = "0x6111F0", Offset = "0x60FBF0", VA = "0x1806111F0")]
		public static float GetDefaultMusicGameSpeed()
		{
			return 0f;
		}

		// Token: 0x06002FF7 RID: 12279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF7")]
		[Address(RVA = "0x6148E0", Offset = "0x6132E0", VA = "0x1806148E0")]
		public static void SetDefaultMusicGameSpeed(float value)
		{
		}

		// Token: 0x06002FF8 RID: 12280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FF8")]
		[Address(RVA = "0x614BA0", Offset = "0x6135A0", VA = "0x180614BA0")]
		public static void SetMusicalNoteSpeed(string musicId, bool isEasy, float musicalNoteSpeed)
		{
		}

		// Token: 0x06002FF9 RID: 12281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FF9")]
		[Address(RVA = "0x610360", Offset = "0x60ED60", VA = "0x180610360")]
		public static HashSet<int> GetAllRemainingFurnitures()
		{
			return null;
		}

		// Token: 0x06002FFA RID: 12282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FFA")]
		[Address(RVA = "0x610110", Offset = "0x60EB10", VA = "0x180610110")]
		public static HashSet<int> GetAllOccupiedFlandreFurnitureId()
		{
			return null;
		}

		// Token: 0x06002FFB RID: 12283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FFB")]
		[Address(RVA = "0x611300", Offset = "0x60FD00", VA = "0x180611300")]
		public static List<Vector2Int> GetFurniturePositions(this int furnitureId)
		{
			return null;
		}

		// Token: 0x06002FFC RID: 12284 RVA: 0x000118C8 File Offset: 0x0000FAC8
		[Token(Token = "0x6002FFC")]
		[Address(RVA = "0x611B50", Offset = "0x610550", VA = "0x180611B50")]
		public static int GetTargetPositionFurnitureId(Vector2Int position)
		{
			return 0;
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x000118E0 File Offset: 0x0000FAE0
		[Token(Token = "0x6002FFD")]
		[Address(RVA = "0x611250", Offset = "0x60FC50", VA = "0x180611250")]
		public static int GetFurnitureCanUseNum(int furnitureId)
		{
			return 0;
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FFE")]
		[Address(RVA = "0x60F570", Offset = "0x60DF70", VA = "0x18060F570")]
		public static void AddFurnitureNum(int furnitureId, int num)
		{
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FFF")]
		[Address(RVA = "0x614440", Offset = "0x612E40", VA = "0x180614440")]
		public static void RemoveFurnitureNum(int furnitureId, int num)
		{
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003000")]
		[Address(RVA = "0x614930", Offset = "0x613330", VA = "0x180614930")]
		public static void SetFurniturePosition(int furnitureId, Vector2Int? oldPosition, Vector2Int? position)
		{
		}

		// Token: 0x04002AD7 RID: 10967
		[Token(Token = "0x4002AD7")]
		private const int TOTAL_ACTIVE_HOUR = 8;

		// Token: 0x04002AD8 RID: 10968
		[Token(Token = "0x4002AD8")]
		public const string KOURINDOU_ID = "Rinnosuke";

		// Token: 0x04002AD9 RID: 10969
		[Token(Token = "0x4002AD9")]
		private const string LAST_MUSIC_GAME_SPEED_KEY = "LAST_MUSIC_GAME_SPEED";

		// Token: 0x04002ADA RID: 10970
		[Token(Token = "0x4002ADA")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, TrackedCollectable> trackedCollectables;

		// Token: 0x04002ADB RID: 10971
		[Token(Token = "0x4002ADB")]
		[FieldOffset(Offset = "0x8")]
		private static Dictionary<string, TrackedMerchant> trackedMerchants;

		// Token: 0x04002ADC RID: 10972
		[Token(Token = "0x4002ADC")]
		[FieldOffset(Offset = "0x10")]
		private static Dictionary<string, Dictionary<string, TrackedNPC>> trackedNPCs;

		// Token: 0x04002ADD RID: 10973
		[Token(Token = "0x4002ADD")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<string, TrackedInteractable> trackedInteradctables;

		// Token: 0x04002ADE RID: 10974
		[Token(Token = "0x4002ADE")]
		[FieldOffset(Offset = "0x20")]
		private static Dictionary<string, bool> trackedSwitch;

		// Token: 0x04002ADF RID: 10975
		[Token(Token = "0x4002ADF")]
		[FieldOffset(Offset = "0x28")]
		private static Dictionary<string, bool> trackedMaps;

		// Token: 0x04002AE0 RID: 10976
		[Token(Token = "0x4002AE0")]
		[FieldOffset(Offset = "0x30")]
		private static List<ValueTuple<string, int>> kourindouStaticMerchandiseNum;

		// Token: 0x04002AE1 RID: 10977
		[Token(Token = "0x4002AE1")]
		[FieldOffset(Offset = "0x38")]
		private static Dictionary<string, int> trackedSpecialDayNPCInteractCount;

		// Token: 0x04002AE2 RID: 10978
		[Token(Token = "0x4002AE2")]
		[FieldOffset(Offset = "0x40")]
		[TupleElementNames(new string[] { "EasySpeed", "HardSpeed" })]
		private static Dictionary<string, ValueTuple<float, float>> musicgameMusicalsNoteSpeed;

		// Token: 0x04002AE3 RID: 10979
		[Token(Token = "0x4002AE3")]
		[FieldOffset(Offset = "0x48")]
		[TupleElementNames(new string[] { "RemainingNum", "PlacedPosition" })]
		private static Dictionary<int, ValueTuple<int, List<Vector2Int>>> flandreHomeFurniture;

		// Token: 0x04002AE4 RID: 10980
		[Token(Token = "0x4002AE4")]
		[FieldOffset(Offset = "0x50")]
		private static Action onDayOver;

		// Token: 0x04002AE5 RID: 10981
		[Token(Token = "0x4002AE5")]
		[FieldOffset(Offset = "0x58")]
		public static Action<int> OnTimePass;

		// Token: 0x04002AE6 RID: 10982
		[Token(Token = "0x4002AE6")]
		[FieldOffset(Offset = "0x60")]
		public static Action<int> OnTimeSet;
	}
}
