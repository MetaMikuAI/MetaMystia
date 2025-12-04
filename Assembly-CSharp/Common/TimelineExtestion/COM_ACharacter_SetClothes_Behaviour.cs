using System;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Common.TimelineExtestion
{
	// Token: 0x02001011 RID: 4113
	[Token(Token = "0x2001011")]
	public class COM_ACharacter_SetClothes_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06005F42 RID: 24386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F42")]
		[Address(RVA = "0x8BC290", Offset = "0x8BAC90", VA = "0x1808BC290", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06005F43 RID: 24387 RVA: 0x00020F58 File Offset: 0x0001F158
		[Token(Token = "0x6005F43")]
		[Address(RVA = "0x8BC1E0", Offset = "0x8BABE0", VA = "0x1808BC1E0")]
		private UniTask OnBehaviourEnterAsync()
		{
			return default(UniTask);
		}

		// Token: 0x06005F44 RID: 24388 RVA: 0x00020F70 File Offset: 0x0001F170
		[Token(Token = "0x6005F44")]
		[Address(RVA = "0x8BC3C0", Offset = "0x8BADC0", VA = "0x1808BC3C0")]
		public static bool TryGetSourceClothesId(out int clothesId)
		{
			return default(bool);
		}

		// Token: 0x06005F45 RID: 24389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F45")]
		[Address(RVA = "0x818FD0", Offset = "0x8179D0", VA = "0x180818FD0")]
		public COM_ACharacter_SetClothes_Behaviour()
		{
		}

		// Token: 0x0400584D RID: 22605
		[Token(Token = "0x400584D")]
		[FieldOffset(Offset = "0x0")]
		private static int m_SourceClothesId;

		// Token: 0x0400584E RID: 22606
		[Token(Token = "0x400584E")]
		[FieldOffset(Offset = "0x10")]
		public int clothesId;
	}
}
