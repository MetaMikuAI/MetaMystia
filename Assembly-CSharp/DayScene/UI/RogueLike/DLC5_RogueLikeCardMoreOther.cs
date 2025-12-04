using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000349 RID: 841
	[Token(Token = "0x2000349")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardMoreOther", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardMoreOther", order = 22)]
	public class DLC5_RogueLikeCardMoreOther : DLC5_RogueLikeCardGiveItemAfterSettle
	{
		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x000073C8 File Offset: 0x000055C8
		[Token(Token = "0x170001EE")]
		protected override int TypeIndex
		{
			[Token(Token = "0x60012EA")]
			[Address(RVA = "0x518710", Offset = "0x517110", VA = "0x180518710", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012EB")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardMoreOther()
		{
		}
	}
}
