using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000178 RID: 376
	[Token(Token = "0x2000178")]
	public enum FlandreTypeIndex
	{
		// Token: 0x040007E6 RID: 2022
		[Token(Token = "0x40007E6")]
		[InspectorName("芙兰朵露·喜")]
		Pleased,
		// Token: 0x040007E7 RID: 2023
		[Token(Token = "0x40007E7")]
		[InspectorName("芙兰朵露·怒")]
		Angry,
		// Token: 0x040007E8 RID: 2024
		[Token(Token = "0x40007E8")]
		[InspectorName("芙兰朵露·哀")]
		Sad,
		// Token: 0x040007E9 RID: 2025
		[Token(Token = "0x40007E9")]
		[InspectorName("芙兰朵露·乐")]
		Glad,
		// Token: 0x040007EA RID: 2026
		[Token(Token = "0x40007EA")]
		[InspectorName("芙兰朵露·破坏之王")]
		HakaiShin,
		// Token: 0x040007EB RID: 2027
		[Token(Token = "0x40007EB")]
		[InspectorName("喜怒哀乐随机")]
		RandomNormalFlandre = 1000,
		// Token: 0x040007EC RID: 2028
		[Token(Token = "0x40007EC")]
		[InspectorName("喜怒哀乐Boss随机")]
		RandomFlandre
	}
}
