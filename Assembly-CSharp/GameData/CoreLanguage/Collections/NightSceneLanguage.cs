using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.Utils;
using Il2CppDummyDll;

namespace GameData.CoreLanguage.Collections
{
	// Token: 0x020007D5 RID: 2005
	[Token(Token = "0x20007D5")]
	public static class NightSceneLanguage
	{
		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06002F01 RID: 12033 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F02 RID: 12034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000621")]
		public static Dictionary<int, string[]> SpecialEvaluation
		{
			[Token(Token = "0x6002F01")]
			[Address(RVA = "0x60A280", Offset = "0x608C80", VA = "0x18060A280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F02")]
			[Address(RVA = "0x60A3E0", Offset = "0x608DE0", VA = "0x18060A3E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06002F03 RID: 12035 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F04 RID: 12036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000622")]
		public static Dictionary<int, string[]> NormalEvaluation
		{
			[Token(Token = "0x6002F03")]
			[Address(RVA = "0x60A200", Offset = "0x608C00", VA = "0x18060A200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F04")]
			[Address(RVA = "0x60A320", Offset = "0x608D20", VA = "0x18060A320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06002F05 RID: 12037 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F06 RID: 12038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000623")]
		public static Dictionary<int, UnityEngineExtensionStatic.StructPtr<string>[]> SpecialConversation
		{
			[Token(Token = "0x6002F05")]
			[Address(RVA = "0x60A240", Offset = "0x608C40", VA = "0x18060A240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F06")]
			[Address(RVA = "0x60A380", Offset = "0x608D80", VA = "0x18060A380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002F08 RID: 12040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000624")]
		public static Dictionary<int, UnityEngineExtensionStatic.StructPtr<string>[]> NormalConversation
		{
			[Token(Token = "0x6002F07")]
			[Address(RVA = "0x60A1C0", Offset = "0x608BC0", VA = "0x18060A1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002F08")]
			[Address(RVA = "0x60A2C0", Offset = "0x608CC0", VA = "0x18060A2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002F09")]
		[Address(RVA = "0x60A070", Offset = "0x608A70", VA = "0x18060A070")]
		public static void Initialize(Dictionary<int, string[]> normalEvaluation, Dictionary<int, string[]> specialEvaluation, Dictionary<int, UnityEngineExtensionStatic.StructPtr<string>[]> normalConversation, Dictionary<int, UnityEngineExtensionStatic.StructPtr<string>[]> specialConversation)
		{
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F0A")]
		[Address(RVA = "0x609C60", Offset = "0x608660", VA = "0x180609C60")]
		public static string GenerateNormalConv(int id)
		{
			return null;
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F0B")]
		[Address(RVA = "0x609D70", Offset = "0x608770", VA = "0x180609D70")]
		public static string GenerateSpecialConv(int id)
		{
			return null;
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F0C")]
		[Address(RVA = "0x609E80", Offset = "0x608880", VA = "0x180609E80")]
		public static string GenerateSpecialConv(int id, List<string> extraConv)
		{
			return null;
		}

		// Token: 0x020007D6 RID: 2006
		[Token(Token = "0x20007D6")]
		public struct GuestEvaluation
		{
			// Token: 0x06002F0D RID: 12045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002F0D")]
			[Address(RVA = "0x604E50", Offset = "0x603850", VA = "0x180604E50")]
			public GuestEvaluation(string[] exbad, string[] bad, string[] normal, string[] good, string[] exgood, string[] warning, string[] overpay)
			{
			}

			// Token: 0x06002F0E RID: 12046 RVA: 0x000111D8 File Offset: 0x0000F3D8
			[Token(Token = "0x6002F0E")]
			[Address(RVA = "0x604920", Offset = "0x603320", VA = "0x180604920")]
			public static NightSceneLanguage.GuestEvaluation Empty()
			{
				return default(NightSceneLanguage.GuestEvaluation);
			}

			// Token: 0x06002F0F RID: 12047 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002F0F")]
			[Address(RVA = "0x604D60", Offset = "0x603760", VA = "0x180604D60")]
			public string GetEvaluation(NightSceneLanguage.GuestEvaluation.EvaluationType type)
			{
				return null;
			}

			// Token: 0x04002A78 RID: 10872
			[Token(Token = "0x4002A78")]
			[FieldOffset(Offset = "0x0")]
			private readonly string[] exbad;

			// Token: 0x04002A79 RID: 10873
			[Token(Token = "0x4002A79")]
			[FieldOffset(Offset = "0x8")]
			private readonly string[] bad;

			// Token: 0x04002A7A RID: 10874
			[Token(Token = "0x4002A7A")]
			[FieldOffset(Offset = "0x10")]
			private readonly string[] normal;

			// Token: 0x04002A7B RID: 10875
			[Token(Token = "0x4002A7B")]
			[FieldOffset(Offset = "0x18")]
			private readonly string[] good;

			// Token: 0x04002A7C RID: 10876
			[Token(Token = "0x4002A7C")]
			[FieldOffset(Offset = "0x20")]
			private readonly string[] exgood;

			// Token: 0x04002A7D RID: 10877
			[Token(Token = "0x4002A7D")]
			[FieldOffset(Offset = "0x28")]
			private readonly string[] warning;

			// Token: 0x04002A7E RID: 10878
			[Token(Token = "0x4002A7E")]
			[FieldOffset(Offset = "0x30")]
			private readonly string[] overpay;

			// Token: 0x020007D7 RID: 2007
			[Token(Token = "0x20007D7")]
			public enum EvaluationType
			{
				// Token: 0x04002A80 RID: 10880
				[Token(Token = "0x4002A80")]
				Exbad,
				// Token: 0x04002A81 RID: 10881
				[Token(Token = "0x4002A81")]
				Bad,
				// Token: 0x04002A82 RID: 10882
				[Token(Token = "0x4002A82")]
				Normal,
				// Token: 0x04002A83 RID: 10883
				[Token(Token = "0x4002A83")]
				Good,
				// Token: 0x04002A84 RID: 10884
				[Token(Token = "0x4002A84")]
				ExGood,
				// Token: 0x04002A85 RID: 10885
				[Token(Token = "0x4002A85")]
				Warning,
				// Token: 0x04002A86 RID: 10886
				[Token(Token = "0x4002A86")]
				Overpay
			}
		}
	}
}
