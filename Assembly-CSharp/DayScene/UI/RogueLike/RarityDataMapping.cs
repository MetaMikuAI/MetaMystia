using System;
using Il2CppDummyDll;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200039C RID: 924
	[Token(Token = "0x200039C")]
	[Serializable]
	public abstract class RarityDataMapping
	{
		// Token: 0x06001480 RID: 5248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001480")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		protected RarityDataMapping()
		{
		}

		// Token: 0x04001326 RID: 4902
		[Token(Token = "0x4001326")]
		[FieldOffset(Offset = "0x10")]
		public RogueLikeCardBase.Rarity Rarity;
	}
}
