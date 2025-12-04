using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200034A RID: 842
	[Token(Token = "0x200034A")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardMoreVeg", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardMoreVeg", order = 13)]
	public class DLC5_RogueLikeCardMoreVeg : DLC5_RogueLikeCardGiveItemAfterSettle
	{
		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x000073E0 File Offset: 0x000055E0
		[Token(Token = "0x170001EF")]
		protected override int TypeIndex
		{
			[Token(Token = "0x60012EC")]
			[Address(RVA = "0x8D9E70", Offset = "0x8D8870", VA = "0x1808D9E70", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012ED")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardMoreVeg()
		{
		}
	}
}
