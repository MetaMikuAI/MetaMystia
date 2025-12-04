using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Timers;
using DEYU.Singletons;
using Il2CppDummyDll;
using Omt.Net.Http;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace PrototypingManagers
{
	// Token: 0x020000FA RID: 250
	[Token(Token = "0x20000FA")]
	public class GlobalDebugConsole : MonoSingletonPersistant<GlobalDebugConsole>
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x00003738 File Offset: 0x00001938
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006F")]
		public static bool EnableConsole
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x6E9BC0", Offset = "0x6E85C0", VA = "0x1806E9BC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x6E9C10", Offset = "0x6E8610", VA = "0x1806E9C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x6E9760", Offset = "0x6E8160", VA = "0x1806E9760")]
		private void Start()
		{
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x6E99A0", Offset = "0x6E83A0", VA = "0x1806E99A0")]
		private void Update()
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x6E8300", Offset = "0x6E6D00", VA = "0x1806E8300")]
		private void OnGUI()
		{
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x6E80F0", Offset = "0x6E6AF0", VA = "0x1806E80F0")]
		public string GetAddress(GlobalDebugConsole.AddressType addressType)
		{
			return null;
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x6E8130", Offset = "0x6E6B30", VA = "0x1806E8130")]
		public void Initialize(HttpRequester httpRequester, string name, string deviceId)
		{
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x6E9860", Offset = "0x6E8260", VA = "0x1806E9860")]
		private void Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x6E88F0", Offset = "0x6E72F0", VA = "0x1806E88F0")]
		private void OnLogMessageRecived(string condition, string stackTrace, LogType type)
		{
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x6E8A70", Offset = "0x6E7470", VA = "0x1806E8A70")]
		private void ShowAudioSystem()
		{
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x6E8B20", Offset = "0x6E7520", VA = "0x1806E8B20")]
		private void ShowDebugConsole()
		{
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x6E9B20", Offset = "0x6E8520", VA = "0x1806E9B20")]
		public GlobalDebugConsole()
		{
		}

		// Token: 0x04000591 RID: 1425
		[Token(Token = "0x4000591")]
		private const int SyncMinutes = 5;

		// Token: 0x04000592 RID: 1426
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x18")]
		public bool couldReset;

		// Token: 0x04000593 RID: 1427
		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x20")]
		[AssetReferenceUILabelRestriction(new string[] { "Scene" })]
		public AssetReference mainScene;

		// Token: 0x04000594 RID: 1428
		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x28")]
		[AssetReferenceUILabelRestriction(new string[] { "Scene" })]
		public AssetReference loadScene;

		// Token: 0x04000595 RID: 1429
		[Token(Token = "0x4000595")]
		[FieldOffset(Offset = "0x30")]
		private readonly Queue<GlobalDebugConsole.LogMessage> logMessages;

		// Token: 0x04000596 RID: 1430
		[Token(Token = "0x4000596")]
		[FieldOffset(Offset = "0x38")]
		private string m_LoginDevice;

		// Token: 0x04000597 RID: 1431
		[Token(Token = "0x4000597")]
		[FieldOffset(Offset = "0x40")]
		private string m_LoginName;

		// Token: 0x04000598 RID: 1432
		[Token(Token = "0x4000598")]
		[FieldOffset(Offset = "0x48")]
		private HttpRequester m_Requester;

		// Token: 0x04000599 RID: 1433
		[Token(Token = "0x4000599")]
		[FieldOffset(Offset = "0x50")]
		private Timer m_Timer;

		// Token: 0x0400059A RID: 1434
		[Token(Token = "0x400059A")]
		[FieldOffset(Offset = "0x58")]
		private string m_UpdateAddress;

		// Token: 0x0400059B RID: 1435
		[Token(Token = "0x400059B")]
		[FieldOffset(Offset = "0x60")]
		private Vector2 scrollPosition;

		// Token: 0x0400059C RID: 1436
		[Token(Token = "0x400059C")]
		[FieldOffset(Offset = "0x68")]
		private bool shouldOnGUIAudioStatusShown;

		// Token: 0x0400059D RID: 1437
		[Token(Token = "0x400059D")]
		[FieldOffset(Offset = "0x69")]
		private bool shouldOnGUIBuffConsoleShown;

		// Token: 0x0400059E RID: 1438
		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0x6A")]
		private bool showError;

		// Token: 0x0400059F RID: 1439
		[Token(Token = "0x400059F")]
		[FieldOffset(Offset = "0x6B")]
		private bool showNormal;

		// Token: 0x040005A0 RID: 1440
		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0x6C")]
		private bool showWarning;

		// Token: 0x020000FB RID: 251
		[Token(Token = "0x20000FB")]
		public enum AddressType
		{
			// Token: 0x040005A3 RID: 1443
			[Token(Token = "0x40005A3")]
			Login,
			// Token: 0x040005A4 RID: 1444
			[Token(Token = "0x40005A4")]
			Update
		}

		// Token: 0x020000FC RID: 252
		[Token(Token = "0x20000FC")]
		private struct LogMessage
		{
			// Token: 0x060005B8 RID: 1464 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x6ECA70", Offset = "0x6EB470", VA = "0x1806ECA70")]
			public LogMessage(string condition, string stackTrace, LogType type, string time)
			{
			}

			// Token: 0x040005A5 RID: 1445
			[Token(Token = "0x40005A5")]
			[FieldOffset(Offset = "0x0")]
			public readonly string condition;

			// Token: 0x040005A6 RID: 1446
			[Token(Token = "0x40005A6")]
			[FieldOffset(Offset = "0x8")]
			public readonly string stackTrace;

			// Token: 0x040005A7 RID: 1447
			[Token(Token = "0x40005A7")]
			[FieldOffset(Offset = "0x10")]
			public readonly LogType type;

			// Token: 0x040005A8 RID: 1448
			[Token(Token = "0x40005A8")]
			[FieldOffset(Offset = "0x18")]
			public readonly string time;
		}
	}
}
