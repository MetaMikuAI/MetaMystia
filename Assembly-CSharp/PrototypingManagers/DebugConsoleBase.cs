using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PrototypingManagers
{
	// Token: 0x020000F7 RID: 247
	[Token(Token = "0x20000F7")]
	public abstract class DebugConsoleBase : MonoBehaviour
	{
		// Token: 0x0600059A RID: 1434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x6E6CC0", Offset = "0x6E56C0", VA = "0x1806E6CC0")]
		private void Start()
		{
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x6E6C20", Offset = "0x6E5620", VA = "0x1806E6C20")]
		private void OnGUI()
		{
		}

		// Token: 0x0600059C RID: 1436
		[Token(Token = "0x600059C")]
		protected abstract void OnStart();

		// Token: 0x0600059D RID: 1437
		[Token(Token = "0x600059D")]
		protected abstract void OnDrawDebugConsole();

		// Token: 0x0600059E RID: 1438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		protected DebugConsoleBase()
		{
		}
	}
}
