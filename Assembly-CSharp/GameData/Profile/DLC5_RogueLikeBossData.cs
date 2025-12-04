using System;
using System.Collections;
using System.Threading;
using Il2CppDummyDll;
using Night.RogueLike;
using NightScene.EventUtility;
using PrepNightScene.UI;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000C4F RID: 3151
	[Token(Token = "0x2000C4F")]
	[CreateAssetMenu(fileName = "DLC5_RogueLikeBossData", menuName = "GameData Profile/BossData/DLC5_RogueLikeBossData", order = 7)]
	public class DLC5_RogueLikeBossData : BossData
	{
		// Token: 0x06004998 RID: 18840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004998")]
		[Address(RVA = "0x7646B0", Offset = "0x7630B0", VA = "0x1807646B0", Slot = "5")]
		public override IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			return null;
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004999")]
		[Address(RVA = "0x764770", Offset = "0x763170", VA = "0x180764770")]
		private IEnumerator Timing(EventManager eventManager, int duration, CancellationTokenSource tokenSource, RogueLikeManager rogueLikeManager)
		{
			return null;
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600499A")]
		[Address(RVA = "0x764840", Offset = "0x763240", VA = "0x180764840")]
		public DLC5_RogueLikeBossData()
		{
		}

		// Token: 0x0400439A RID: 17306
		[Token(Token = "0x400439A")]
		private const string RogueLikeEndEvent = "DLC5_RogueLike_End";

		// Token: 0x0400439B RID: 17307
		[Token(Token = "0x400439B")]
		private const float DELAY_GACHA_PANEL = 1f;

		// Token: 0x0400439C RID: 17308
		[Token(Token = "0x400439C")]
		[FieldOffset(Offset = "0x30")]
		public IzakayaConfigSubPannelForRogueLike SubPannelForRogueLike;

		// Token: 0x0400439D RID: 17309
		[Token(Token = "0x400439D")]
		[FieldOffset(Offset = "0x38")]
		public RemindSubPanel RemindPanel;

		// Token: 0x0400439E RID: 17310
		[Token(Token = "0x400439E")]
		[FieldOffset(Offset = "0x40")]
		public LoopedBGMPackage endBgm;
	}
}
