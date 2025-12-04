using System;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000B70 RID: 2928
	[Token(Token = "0x2000B70")]
	[CreateAssetMenu(fileName = "AchievementProfile", menuName = "GameData Profile/AchievementProfile")]
	public class AchievementProfile : ScriptableObject
	{
		// Token: 0x06004619 RID: 17945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004619")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public AchievementProfile()
		{
		}

		// Token: 0x04003DF2 RID: 15858
		[Token(Token = "0x4003DF2")]
		[FieldOffset(Offset = "0x18")]
		public AchievementData[] Achievements;
	}
}
