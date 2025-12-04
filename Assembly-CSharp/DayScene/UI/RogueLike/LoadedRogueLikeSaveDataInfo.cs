using System;
using Il2CppDummyDll;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000465 RID: 1125
	[Token(Token = "0x2000465")]
	public readonly struct LoadedRogueLikeSaveDataInfo
	{
		// Token: 0x060019FA RID: 6650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60019FA")]
		[Address(RVA = "0x478FD0", Offset = "0x4779D0", VA = "0x180478FD0")]
		public LoadedRogueLikeSaveDataInfo(RogueLikeSaveData? fileData, Exception loadException, string fileName)
		{
		}

		// Token: 0x040017B9 RID: 6073
		[Token(Token = "0x40017B9")]
		[FieldOffset(Offset = "0x0")]
		public readonly RogueLikeSaveData? FileData;

		// Token: 0x040017BA RID: 6074
		[Token(Token = "0x40017BA")]
		[FieldOffset(Offset = "0x100")]
		public readonly Exception LoadException;

		// Token: 0x040017BB RID: 6075
		[Token(Token = "0x40017BB")]
		[FieldOffset(Offset = "0x108")]
		public readonly string FileName;
	}
}
