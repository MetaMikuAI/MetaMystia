using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GameData.RunTime.Common;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000467 RID: 1127
	[Token(Token = "0x2000467")]
	[Serializable]
	public struct RogueLikeAchievementSaveData : IDeepClonable<RogueLikeAchievementSaveData>
	{
		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BC")]
		public readonly HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> ActiveAchievementTypes
		{
			[Token(Token = "0x6001A20")]
			[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x0000A470 File Offset: 0x00008670
		[Token(Token = "0x170003BD")]
		public DateTime RealSaveTimeCode
		{
			[Token(Token = "0x6001A21")]
			[Address(RVA = "0x4070A0", Offset = "0x405AA0", VA = "0x1804070A0")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001A22")]
		[Address(RVA = "0x47ACB0", Offset = "0x4796B0", VA = "0x18047ACB0")]
		[JsonConstructor]
		public RogueLikeAchievementSaveData(DateTime realSaveTimeCode, HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType> activeAchievementTypes)
		{
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x0000A488 File Offset: 0x00008688
		[Token(Token = "0x6001A23")]
		[Address(RVA = "0x47ABF0", Offset = "0x4795F0", VA = "0x18047ABF0", Slot = "4")]
		public RogueLikeAchievementSaveData Clone()
		{
			return default(RogueLikeAchievementSaveData);
		}

		// Token: 0x040017E0 RID: 6112
		[Token(Token = "0x40017E0")]
		[FieldOffset(Offset = "0x0")]
		private DateTime realSaveTimeCode;
	}
}
