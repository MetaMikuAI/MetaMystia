using System;
using Il2CppDummyDll;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200039E RID: 926
	[Token(Token = "0x200039E")]
	[Serializable]
	public class RarityDataMappingForMultiplier : RarityDataMapping
	{
		// Token: 0x06001482 RID: 5250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001482")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public RarityDataMappingForMultiplier()
		{
		}

		// Token: 0x04001328 RID: 4904
		[Token(Token = "0x4001328")]
		[FieldOffset(Offset = "0x18")]
		public float Multiplier;
	}
}
