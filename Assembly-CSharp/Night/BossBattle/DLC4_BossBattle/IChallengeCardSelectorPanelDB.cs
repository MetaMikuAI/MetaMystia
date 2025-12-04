using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200020A RID: 522
	[Token(Token = "0x200020A")]
	public interface IChallengeCardSelectorPanelDB
	{
		// Token: 0x06000C70 RID: 3184
		[Token(Token = "0x6000C70")]
		IEnumerable<GuestGuardMapping> GetCards();

		// Token: 0x06000C71 RID: 3185
		[Token(Token = "0x6000C71")]
		float GetCardCoolDownProgress(in GuestGuardMapping mapping);

		// Token: 0x06000C72 RID: 3186
		[Token(Token = "0x6000C72")]
		bool CanBuyCard(in GuestGuardMapping mapping);

		// Token: 0x06000C73 RID: 3187
		[Token(Token = "0x6000C73")]
		bool IsCardOnField(in GuestGuardMapping mapping);

		// Token: 0x06000C74 RID: 3188
		[Token(Token = "0x6000C74")]
		bool IsCardBought(in GuestGuardMapping mapping);

		// Token: 0x06000C75 RID: 3189
		[Token(Token = "0x6000C75")]
		void BuyCard(in GuestGuardMapping mapping);

		// Token: 0x06000C76 RID: 3190
		[Token(Token = "0x6000C76")]
		void UseCard(in GuestGuardMapping mapping);
	}
}
