using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x020008F4 RID: 2292
	[Token(Token = "0x20008F4")]
	[Serializable]
	public class WeightedConversationGroup
	{
		// Token: 0x06003945 RID: 14661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003945")]
		[Address(RVA = "0x46C510", Offset = "0x46AF10", VA = "0x18046C510")]
		public WeightedConversationGroup(int id, int[] weights)
		{
		}

		// Token: 0x040030CE RID: 12494
		[Token(Token = "0x40030CE")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public int id;

		// Token: 0x040030CF RID: 12495
		[Token(Token = "0x40030CF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public int[] weights;

		// Token: 0x020008F5 RID: 2293
		[Token(Token = "0x20008F5")]
		public enum ConvType
		{
			// Token: 0x040030D1 RID: 12497
			[Token(Token = "0x40030D1")]
			Norm,
			// Token: 0x040030D2 RID: 12498
			[Token(Token = "0x40030D2")]
			Spec
		}
	}
}
