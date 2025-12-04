using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x02000143 RID: 323
	[Token(Token = "0x2000143")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentRandomProduct", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentRandomProduct", order = 11)]
	public class DLC5_RogueLikeCardPersistentRandomProduct : RogueLikeCardPersistent
	{
		// Token: 0x060007C3 RID: 1987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x828F70", Offset = "0x827970", VA = "0x180828F70", Slot = "12")]
		public override void AfterInitialize(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x829A70", Offset = "0x828470", VA = "0x180829A70", Slot = "10")]
		public override void AfterSelect(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x82A970", Offset = "0x829370", VA = "0x18082A970")]
		public DLC5_RogueLikeCardPersistentRandomProduct()
		{
		}

		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		[FieldOffset(Offset = "0x40")]
		public int randomCount;
	}
}
