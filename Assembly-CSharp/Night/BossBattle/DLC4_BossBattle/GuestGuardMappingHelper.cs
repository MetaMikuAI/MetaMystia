using System;
using DEYU.UniversalUISystem;
using Il2CppDummyDll;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000215 RID: 533
	[Token(Token = "0x2000215")]
	public static class GuestGuardMappingHelper
	{
		// Token: 0x06000CAD RID: 3245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x8EBAE0", Offset = "0x8EA4E0", VA = "0x1808EBAE0")]
		public static void ModifyCharacterElement(UIElementCluster uiElement, in GuestGuardMapping guard, bool modifyName = true)
		{
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x8EB6D0", Offset = "0x8EA0D0", VA = "0x1808EB6D0")]
		public static string GetCharacterName(GuestGuardMapping guard, bool useBrief = true)
		{
			return null;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x8EB680", Offset = "0x8EA080", VA = "0x1808EB680")]
		private static string FormatString(string data)
		{
			return null;
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB0")]
		[Address(RVA = "0x6028B0", Offset = "0x6012B0", VA = "0x1806028B0")]
		public static string GetLang(string titleLang)
		{
			return null;
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x8EB7A0", Offset = "0x8EA1A0", VA = "0x1808EB7A0")]
		public static string GetText(GuestGuardMapping guard)
		{
			return null;
		}

		// Token: 0x04000B4D RID: 2893
		[Token(Token = "0x4000B4D")]
		private const int PASSIVE_LINE = 1;

		// Token: 0x04000B4E RID: 2894
		[Token(Token = "0x4000B4E")]
		private const int YOUSEI_LINE = 1;

		// Token: 0x04000B4F RID: 2895
		[Token(Token = "0x4000B4F")]
		private const int LEVEL1_LINE = 2;

		// Token: 0x04000B50 RID: 2896
		[Token(Token = "0x4000B50")]
		private const int LEVEL2_LINE = 3;

		// Token: 0x04000B51 RID: 2897
		[Token(Token = "0x4000B51")]
		private const int ULTIMATE_SKILL_LINE = 4;
	}
}
