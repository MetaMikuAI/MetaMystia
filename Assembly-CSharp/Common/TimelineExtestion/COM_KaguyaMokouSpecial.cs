using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02001030 RID: 4144
	[Token(Token = "0x2001030")]
	public class COM_KaguyaMokouSpecial : PlayableAsset
	{
		// Token: 0x06005F8C RID: 24460 RVA: 0x00021030 File Offset: 0x0001F230
		[Token(Token = "0x6005F8C")]
		[Address(RVA = "0x8BF840", Offset = "0x8BE240", VA = "0x1808BF840", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06005F8D RID: 24461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005F8D")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public COM_KaguyaMokouSpecial()
		{
		}

		// Token: 0x04005881 RID: 22657
		[Token(Token = "0x4005881")]
		[FieldOffset(Offset = "0x18")]
		public string missionLabel;

		// Token: 0x04005882 RID: 22658
		[Token(Token = "0x4005882")]
		[FieldOffset(Offset = "0x20")]
		public int firstItemTicks;

		// Token: 0x04005883 RID: 22659
		[Token(Token = "0x4005883")]
		[FieldOffset(Offset = "0x24")]
		public int secondItemTicks;

		// Token: 0x04005884 RID: 22660
		[Token(Token = "0x4005884")]
		[FieldOffset(Offset = "0x28")]
		public int equalTicks;

		// Token: 0x04005885 RID: 22661
		[Token(Token = "0x4005885")]
		[FieldOffset(Offset = "0x2C")]
		public bool setAchievements;

		// Token: 0x04005886 RID: 22662
		[Token(Token = "0x4005886")]
		[FieldOffset(Offset = "0x30")]
		[Header("循环挑战用，检查存档完成事件")]
		public string recordedMokouWinLabel;

		// Token: 0x04005887 RID: 22663
		[Token(Token = "0x4005887")]
		[FieldOffset(Offset = "0x38")]
		public string recordedKaguyaWinLabel;

		// Token: 0x04005888 RID: 22664
		[Token(Token = "0x4005888")]
		[FieldOffset(Offset = "0x40")]
		public string recordedEqualLabel;
	}
}
