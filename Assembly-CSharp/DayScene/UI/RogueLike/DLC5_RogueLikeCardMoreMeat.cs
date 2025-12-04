using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000345 RID: 837
	[Token(Token = "0x2000345")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardMoreMeat", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardMoreMeat", order = 14)]
	public class DLC5_RogueLikeCardMoreMeat : DLC5_RogueLikeCardGiveItemAfterSettle
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x00007398 File Offset: 0x00005598
		[Token(Token = "0x170001EB")]
		protected override int TypeIndex
		{
			[Token(Token = "0x60012DB")]
			[Address(RVA = "0x7B2C90", Offset = "0x7B1690", VA = "0x1807B2C90", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060012DC RID: 4828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012DC")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardMoreMeat()
		{
		}
	}
}
