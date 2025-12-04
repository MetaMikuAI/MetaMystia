using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Night.RogueLike;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200038F RID: 911
	[Token(Token = "0x200038F")]
	public interface IRogueLikeCardAssociatedRecord
	{
		// Token: 0x06001434 RID: 5172
		[Token(Token = "0x6001434")]
		void ModifyAssociatedRogueLikeCardInstances(List<RogueLikeCardInstance> associatedRogueLikeCards, RogueLikeManager rogueLikeManager);
	}
}
