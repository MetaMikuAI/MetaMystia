using System;
using DEYU.UnityWebDebugBridge;
using Il2CppDummyDll;

namespace PrototypingManagers
{
	// Token: 0x020000FE RID: 254
	[Token(Token = "0x20000FE")]
	[WebDebugHeader("全局")]
	public static class GlobalDebugImpl
	{
		// Token: 0x060005BE RID: 1470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x6E9FF0", Offset = "0x6E89F0", VA = "0x1806E9FF0")]
		public static void RegisterMethod()
		{
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x6E9DE0", Offset = "0x6E87E0", VA = "0x1806E9DE0")]
		[WebDebug("导出存档和日志")]
		public static void OutputArchiveAndLog()
		{
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x6E9D10", Offset = "0x6E8710", VA = "0x1806E9D10")]
		[WebDebug("打开日志目录")]
		public static void OpenLogDirectory()
		{
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x6E9C70", Offset = "0x6E8670", VA = "0x1806E9C70")]
		[WebDebug("前往空场景(内存泄漏测试)")]
		public static void GotoEmptyScene()
		{
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x6E9CC0", Offset = "0x6E86C0", VA = "0x1806E9CC0")]
		[WebDebug("前往主菜单")]
		public static void GotoMainScene()
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x6EA080", Offset = "0x6E8A80", VA = "0x1806EA080")]
		private static void ShowExplorer(string path)
		{
		}
	}
}
