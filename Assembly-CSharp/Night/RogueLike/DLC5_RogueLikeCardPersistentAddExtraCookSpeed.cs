using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x02000124 RID: 292
	[Token(Token = "0x2000124")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentAddExtraCookSpeed", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentAddExtraCookSpeed", order = 13)]
	public class DLC5_RogueLikeCardPersistentAddExtraCookSpeed : RogueLikeCardPersistent
	{
		// Token: 0x06000737 RID: 1847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x6DEC60", Offset = "0x6DD660", VA = "0x1806DEC60", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x6DEA70", Offset = "0x6DD470", VA = "0x1806DEA70", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x6DEC40", Offset = "0x6DD640", VA = "0x1806DEC40", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentAddExtraCookSpeed()
		{
		}

		// Token: 0x040006DD RID: 1757
		[Token(Token = "0x40006DD")]
		[FieldOffset(Offset = "0x40")]
		public float extraCookSpeed;
	}
}
