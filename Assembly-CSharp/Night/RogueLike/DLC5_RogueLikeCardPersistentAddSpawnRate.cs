using System;
using DayScene.UI.RogueLike;
using Il2CppDummyDll;
using NightScene.EventUtility;
using UnityEngine;

namespace Night.RogueLike
{
	// Token: 0x02000134 RID: 308
	[Token(Token = "0x2000134")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeCardPersistentAddSpawnRate", menuName = "DLC5_RogueCard/Persistent/DLC5_RogueLikeCardPersistentAddSpawnRate", order = 16)]
	public class DLC5_RogueLikeCardPersistentAddSpawnRate : RogueLikeCardPersistent
	{
		// Token: 0x06000788 RID: 1928 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x828260", Offset = "0x826C60", VA = "0x180828260", Slot = "5")]
		public override string OverrideDescription(string oldDescription, RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int cardNum)
		{
			return null;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x828110", Offset = "0x826B10", VA = "0x180828110", Slot = "8")]
		public override void CardEffectBeforeWorking(RogueLikeManager rogueLikeManager, EventManager eventManager, int cardNum, RogueLikePersistentCardInstance rogueLikeCardInstance)
		{
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x6DEC40", Offset = "0x6DD640", VA = "0x1806DEC40", Slot = "14")]
		public override string GetBuffValueDescription(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikePersistentCardInstance rogueLikeCardInstance, int num)
		{
			return null;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DLC5_RogueLikeCardPersistentAddSpawnRate()
		{
		}

		// Token: 0x04000700 RID: 1792
		[Token(Token = "0x4000700")]
		[FieldOffset(Offset = "0x40")]
		public float extraSpawnRate;
	}
}
