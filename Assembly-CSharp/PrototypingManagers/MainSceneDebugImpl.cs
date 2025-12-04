using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Common;
using DEYU.UnityWebDebugBridge;
using GameData;
using GameData.Utils;
using Il2CppDummyDll;

namespace PrototypingManagers
{
	// Token: 0x02000106 RID: 262
	[Token(Token = "0x2000106")]
	[WebDebugHeader("主菜单")]
	public static class MainSceneDebugImpl
	{
		// Token: 0x060005DB RID: 1499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x6F1160", Offset = "0x6EFB60", VA = "0x1806F1160")]
		public static void RegisterMethod()
		{
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x6F1270", Offset = "0x6EFC70", VA = "0x1806F1270")]
		public static void UnRegisterMethod()
		{
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x6F1200", Offset = "0x6EFC00", VA = "0x1806F1200")]
		[WebDebug("设置新游戏模式")]
		public static void SetNewGameMode(SaveManagement.NewGameMode mode)
		{
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x6F11F0", Offset = "0x6EFBF0", VA = "0x1806F11F0")]
		[WebDebug("设置游戏语言")]
		public static void SetGameLanguage(MultiLanguageTextMesh.LoadLanguageType language)
		{
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x6F0B40", Offset = "0x6EF540", VA = "0x1806F0B40")]
		[WebDebug("进入测试营业场景")]
		public static void GotoTestWorkScene([DataSource("GetIzakayaOptionsMapping", null)] MainSceneDebugConsole.TempIzakayaSelection izakaya, [DataSource("GetPlayerSkinOptionsMapping", null)] MainSceneDebugConsole.SkinSelection playerSkin, MainSceneDebugConsole.IzakayaSkinSelections izakayaSkin, MainSceneDebugConsole.PartnerCharacterSelections partner0, MainSceneDebugConsole.PartnerSelections job0, MainSceneDebugConsole.PartnerCharacterSelections partner1, MainSceneDebugConsole.PartnerSelections job1, MainSceneDebugConsole.PartnerCharacterSelections partner2, MainSceneDebugConsole.PartnerSelections job2, bool useAllDecorations)
		{
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x6F0970", Offset = "0x6EF370", VA = "0x1806F0970")]
		[WebDebug("进入测试结算场景")]
		public static void GotoTestResultScene()
		{
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x6F0720", Offset = "0x6EF120", VA = "0x1806F0720")]
		[WebDebug("进入测试人员名单")]
		public static void GotoStaffScene(SceneDirector.StaffScenePlayBackIndicator mode)
		{
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x6F0120", Offset = "0x6EEB20", VA = "0x1806F0120")]
		private static Dictionary<string, object> GetIzakayaOptionsMapping()
		{
			return null;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x6F0520", Offset = "0x6EEF20", VA = "0x1806F0520")]
		private static Dictionary<string, object> GetPlayerSkinOptionsMapping()
		{
			return null;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x6F0320", Offset = "0x6EED20", VA = "0x1806F0320")]
		private static Dictionary<string, object> GetPartnerSelectionsMapping()
		{
			return null;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x6F1260", Offset = "0x6EFC60", VA = "0x1806F1260")]
		[CompilerGenerated]
		internal static int <GotoTestResultScene>g__RandomInteger|6_1()
		{
			return 0;
		}

		// Token: 0x0400062B RID: 1579
		[Token(Token = "0x400062B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ValueTuple<MainSceneDebugConsole.PartnerCharacterSelections, MainSceneDebugConsole.PartnerSelections>[] m_PartnerSelections;
	}
}
