using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace GameData.CoreLanguage.Collections
{
	// Token: 0x020007D4 RID: 2004
	[Token(Token = "0x20007D4")]
	public static class DaySceneLanguage
	{
		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06002EF7 RID: 12023 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EF8 RID: 12024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061E")]
		private static Dictionary<string, string> DaySceneNPCLanguage
		{
			[Token(Token = "0x6002EF7")]
			[Address(RVA = "0x603D40", Offset = "0x602740", VA = "0x180603D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EF8")]
			[Address(RVA = "0x603E20", Offset = "0x602820", VA = "0x180603E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x06002EF9 RID: 12025 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EFA RID: 12026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700061F")]
		private static Dictionary<string, string> DaySceneInteractableEntitiesLanguage
		{
			[Token(Token = "0x6002EF9")]
			[Address(RVA = "0x603D00", Offset = "0x602700", VA = "0x180603D00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EFA")]
			[Address(RVA = "0x603DC0", Offset = "0x6027C0", VA = "0x180603DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06002EFB RID: 12027 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002EFC RID: 12028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000620")]
		private static Dictionary<string, LanguageBase> MapLanguageData
		{
			[Token(Token = "0x6002EFB")]
			[Address(RVA = "0x603D80", Offset = "0x602780", VA = "0x180603D80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EFC")]
			[Address(RVA = "0x603E80", Offset = "0x602880", VA = "0x180603E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002EFD RID: 12029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EFD")]
		[Address(RVA = "0x603A70", Offset = "0x602470", VA = "0x180603A70")]
		public static void Initialize(Dictionary<string, LanguageBase> mapLanguageData, Dictionary<string, string> normalNPC, Dictionary<string, string> daySceneInteractableEntitiesLanguageData)
		{
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EFE")]
		[Address(RVA = "0x603B70", Offset = "0x602570", VA = "0x180603B70")]
		public static string RefDaySceneName(this string npcId)
		{
			return null;
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EFF")]
		[Address(RVA = "0x603C60", Offset = "0x602660", VA = "0x180603C60")]
		public static string RefInteractableEntitiesName(this string interactableEnetityName)
		{
			return null;
		}

		// Token: 0x06002F00 RID: 12032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F00")]
		[Address(RVA = "0x603900", Offset = "0x602300", VA = "0x180603900")]
		public static LanguageBase GetMapLanguageData(this string mapLabel)
		{
			return null;
		}
	}
}
