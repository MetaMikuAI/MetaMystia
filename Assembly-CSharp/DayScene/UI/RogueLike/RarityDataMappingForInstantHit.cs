using System;
using Il2CppDummyDll;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000334 RID: 820
	[Token(Token = "0x2000334")]
	[Serializable]
	public class RarityDataMappingForInstantHit : RarityDataMapping
	{
		// Token: 0x06001290 RID: 4752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001290")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public RarityDataMappingForInstantHit()
		{
		}

		// Token: 0x0400112A RID: 4394
		[Token(Token = "0x400112A")]
		[FieldOffset(Offset = "0x18")]
		public int giveIng;

		// Token: 0x0400112B RID: 4395
		[Token(Token = "0x400112B")]
		[FieldOffset(Offset = "0x1C")]
		public int giveBev;
	}
}
