using System;
using System.Runtime.CompilerServices;
using DEYU.Singletons;
using Il2CppDummyDll;

namespace PrototypingManagers
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	public class EADebugConsole : MonoSingletonPersistant<EADebugConsole>
	{
		// Token: 0x060005A2 RID: 1442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x6E71B0", Offset = "0x6E5BB0", VA = "0x1806E71B0")]
		private void OnGUI()
		{
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x6E7160", Offset = "0x6E5B60", VA = "0x1806E7160", Slot = "6")]
		protected override void OnAwake()
		{
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x6E7740", Offset = "0x6E6140", VA = "0x1806E7740")]
		private void RefreshText()
		{
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x6E79C0", Offset = "0x6E63C0", VA = "0x1806E79C0")]
		private void ShowExplorer(string itemPath)
		{
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x6E6F70", Offset = "0x6E5970", VA = "0x1806E6F70")]
		public static void CopyFilesRecursively(string sourcePath, string targetPath)
		{
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x6E70B0", Offset = "0x6E5AB0", VA = "0x1806E70B0")]
		public static void DeletDirectoriesRecursive(string name)
		{
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x6E7B60", Offset = "0x6E6560", VA = "0x1806E7B60")]
		public EADebugConsole()
		{
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x6E7AC0", Offset = "0x6E64C0", VA = "0x1806E7AC0")]
		[CompilerGenerated]
		internal static void <DeletDirectoriesRecursive>g__DeleteFiles|14_0(string path)
		{
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x6E7A30", Offset = "0x6E6430", VA = "0x1806E7A30")]
		[CompilerGenerated]
		internal static void <DeletDirectoriesRecursive>g__DeleteDirectories|14_1(string path)
		{
		}

		// Token: 0x04000588 RID: 1416
		[Token(Token = "0x4000588")]
		[FieldOffset(Offset = "0x18")]
		private string bugHelperText;

		// Token: 0x04000589 RID: 1417
		[Token(Token = "0x4000589")]
		[FieldOffset(Offset = "0x20")]
		private string exportText;

		// Token: 0x0400058A RID: 1418
		[Token(Token = "0x400058A")]
		[FieldOffset(Offset = "0x28")]
		private string hideConsoleText;

		// Token: 0x0400058B RID: 1419
		[Token(Token = "0x400058B")]
		[FieldOffset(Offset = "0x30")]
		private bool newGameMode;

		// Token: 0x0400058C RID: 1420
		[Token(Token = "0x400058C")]
		[FieldOffset(Offset = "0x38")]
		private string openLogText;

		// Token: 0x0400058D RID: 1421
		[Token(Token = "0x400058D")]
		[FieldOffset(Offset = "0x40")]
		private bool shouldOnGUIBuffConsoleShown;

		// Token: 0x0400058E RID: 1422
		[Token(Token = "0x400058E")]
		[FieldOffset(Offset = "0x48")]
		private string showConsoleText;

		// Token: 0x0400058F RID: 1423
		[Token(Token = "0x400058F")]
		[FieldOffset(Offset = "0x50")]
		private string skipText;

		// Token: 0x04000590 RID: 1424
		[Token(Token = "0x4000590")]
		[FieldOffset(Offset = "0x58")]
		private string welcomeText;
	}
}
