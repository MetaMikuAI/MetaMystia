using System;
using System.Runtime.CompilerServices;
using System.Timers;
using Il2CppDummyDll;
using Omt.Net.Http;

namespace UnityEngine.ServerExtensions
{
	// Token: 0x02001045 RID: 4165
	[Token(Token = "0x2001045")]
	public class ServerVerificationModule : MonoBehaviour
	{
		// Token: 0x17000D53 RID: 3411
		// (get) Token: 0x0600604F RID: 24655 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006050 RID: 24656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D53")]
		public static ServerVerificationModule Instance
		{
			[Token(Token = "0x600604F")]
			[Address(RVA = "0x8C9280", Offset = "0x8C7C80", VA = "0x1808C9280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006050")]
			[Address(RVA = "0x8C92C0", Offset = "0x8C7CC0", VA = "0x1808C92C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06006051 RID: 24657 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006052 RID: 24658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D54")]
		public MCResponseModel MCLinkageData
		{
			[Token(Token = "0x6006051")]
			[Address(RVA = "0x3F1D60", Offset = "0x3F0760", VA = "0x1803F1D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006052")]
			[Address(RVA = "0x531450", Offset = "0x52FE50", VA = "0x180531450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006053 RID: 24659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006053")]
		[Address(RVA = "0x8C8B40", Offset = "0x8C7540", VA = "0x1808C8B40")]
		private void Awake()
		{
		}

		// Token: 0x06006054 RID: 24660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006054")]
		[Address(RVA = "0x8C9080", Offset = "0x8C7A80", VA = "0x1808C9080")]
		private void Start()
		{
		}

		// Token: 0x06006055 RID: 24661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006055")]
		[Address(RVA = "0x8C8C50", Offset = "0x8C7650", VA = "0x1808C8C50")]
		private void Init()
		{
		}

		// Token: 0x06006056 RID: 24662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006056")]
		[Address(RVA = "0x8C8F90", Offset = "0x8C7990", VA = "0x1808C8F90")]
		private void StartTimingModule()
		{
		}

		// Token: 0x06006057 RID: 24663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006057")]
		[Address(RVA = "0x8C8CF0", Offset = "0x8C76F0", VA = "0x1808C8CF0")]
		private void StartMCLinkageModule()
		{
		}

		// Token: 0x06006058 RID: 24664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006058")]
		[Address(RVA = "0x8C8E40", Offset = "0x8C7840", VA = "0x1808C8E40")]
		private void SendRequestLoop()
		{
		}

		// Token: 0x06006059 RID: 24665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006059")]
		[Address(RVA = "0x8C8CF0", Offset = "0x8C76F0", VA = "0x1808C8CF0")]
		private void RequestMCKey()
		{
		}

		// Token: 0x0600605A RID: 24666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600605A")]
		[Address(RVA = "0x8C9180", Offset = "0x8C7B80", VA = "0x1808C9180")]
		public ServerVerificationModule()
		{
		}

		// Token: 0x0400590D RID: 22797
		[Token(Token = "0x400590D")]
		[FieldOffset(Offset = "0x18")]
		private readonly HttpRequester m_HttpRequester;

		// Token: 0x0400590E RID: 22798
		[Token(Token = "0x400590E")]
		[FieldOffset(Offset = "0x20")]
		private readonly Timer m_Timer;

		// Token: 0x0400590F RID: 22799
		[Token(Token = "0x400590F")]
		[FieldOffset(Offset = "0x28")]
		private string m_SteamId;
	}
}
