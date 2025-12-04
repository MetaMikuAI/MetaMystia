using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200038C RID: 908
	[Token(Token = "0x200038C")]
	public enum TriggerCardCondition
	{
		// Token: 0x040012AF RID: 4783
		[Token(Token = "0x40012AF")]
		[InspectorName("达成指定Combo数量")]
		EnoughCombo,
		// Token: 0x040012B0 RID: 4784
		[Token(Token = "0x40012B0")]
		[InspectorName("气氛升级")]
		PassionLevelUp,
		// Token: 0x040012B1 RID: 4785
		[Token(Token = "0x40012B1")]
		[InspectorName("达成指定粉评数量")]
		EnoughSpellNum,
		// Token: 0x040012B2 RID: 4786
		[Token(Token = "0x40012B2")]
		[InspectorName("达成营业额目标")]
		EnoughFund,
		// Token: 0x040012B3 RID: 4787
		[Token(Token = "0x40012B3")]
		[InspectorName("指标抽卡")]
		AfterWave
	}
}
