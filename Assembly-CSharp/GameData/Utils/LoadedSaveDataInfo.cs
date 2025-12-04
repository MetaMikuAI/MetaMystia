using System;
using GameData.RunTime.Common;
using Il2CppDummyDll;

namespace GameData.Utils
{
	// Token: 0x020007D0 RID: 2000
	[Token(Token = "0x20007D0")]
	public struct LoadedSaveDataInfo
	{
		// Token: 0x06002E81 RID: 11905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E81")]
		[Address(RVA = "0x6093D0", Offset = "0x607DD0", VA = "0x1806093D0")]
		public LoadedSaveDataInfo(PlayerSaveFile? fileData, bool loadError, string fileName, Exception loadException, bool testFlight)
		{
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06002E82 RID: 11906 RVA: 0x00011040 File Offset: 0x0000F240
		[Token(Token = "0x17000603")]
		public static LoadedSaveDataInfo NullInfo
		{
			[Token(Token = "0x6002E82")]
			[Address(RVA = "0x6094D0", Offset = "0x607ED0", VA = "0x1806094D0")]
			get
			{
				return default(LoadedSaveDataInfo);
			}
		}

		// Token: 0x04002A3A RID: 10810
		[Token(Token = "0x4002A3A")]
		[FieldOffset(Offset = "0x0")]
		public PlayerSaveFile? fileData;

		// Token: 0x04002A3B RID: 10811
		[Token(Token = "0x4002A3B")]
		[FieldOffset(Offset = "0x2D0")]
		public readonly bool loadError;

		// Token: 0x04002A3C RID: 10812
		[Token(Token = "0x4002A3C")]
		[FieldOffset(Offset = "0x2D8")]
		public readonly string fileName;

		// Token: 0x04002A3D RID: 10813
		[Token(Token = "0x4002A3D")]
		[FieldOffset(Offset = "0x2E0")]
		public readonly Exception loadException;

		// Token: 0x04002A3E RID: 10814
		[Token(Token = "0x4002A3E")]
		[FieldOffset(Offset = "0x2E8")]
		public readonly bool testFlight;
	}
}
