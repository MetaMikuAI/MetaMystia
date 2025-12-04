using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000BD5 RID: 3029
	[Token(Token = "0x2000BD5")]
	[CreateAssetMenu(fileName = "BasicChallengeTrialOneData", menuName = "GameData Profile/BossData/BasicChallengeTrialOneData", order = 1)]
	public class BasicChallengeTrialOneData : GeneralTrialChallengeBossData
	{
		// Token: 0x060046DA RID: 18138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DA")]
		[Address(RVA = "0x732AA0", Offset = "0x7314A0", VA = "0x180732AA0", Slot = "6")]
		protected override void OnPreloadGeneralChallenge()
		{
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60046DB")]
		[Address(RVA = "0x732A90", Offset = "0x731490", VA = "0x180732A90")]
		public BasicChallengeTrialOneData()
		{
		}

		// Token: 0x04004000 RID: 16384
		[Token(Token = "0x4004000")]
		[FieldOffset(Offset = "0x68")]
		[Header("- Basic Challenge Trial One Boss Data")]
		public int easyChallengeIngredientCount;
	}
}
