using System;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000341 RID: 833
	[Token(Token = "0x2000341")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardMoreFish", menuName = "DLC5_RogueCard/DLC5_RogueLikeCardMoreFish", order = 15)]
	public class DLC5_RogueLikeCardMoreFish : DLC5_RogueLikeCardGiveItemAfterSettle
	{
		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x00007338 File Offset: 0x00005538
		[Token(Token = "0x170001E9")]
		protected override int TypeIndex
		{
			[Token(Token = "0x60012CD")]
			[Address(RVA = "0x44F9D0", Offset = "0x44E3D0", VA = "0x18044F9D0", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060012CE RID: 4814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60012CE")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardMoreFish()
		{
		}
	}
}
