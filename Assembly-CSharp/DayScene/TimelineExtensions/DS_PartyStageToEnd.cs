using System;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x020004AB RID: 1195
	[Token(Token = "0x20004AB")]
	public class DS_PartyStageToEnd : PlayableAsset
	{
		// Token: 0x06001B30 RID: 6960 RVA: 0x0000A878 File Offset: 0x00008A78
		[Token(Token = "0x6001B30")]
		[Address(RVA = "0x49A2B0", Offset = "0x498CB0", VA = "0x18049A2B0", Slot = "6")]
		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B31")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public DS_PartyStageToEnd()
		{
		}

		// Token: 0x04001901 RID: 6401
		[Token(Token = "0x4001901")]
		[FieldOffset(Offset = "0x18")]
		public bool mainStory;

		// Token: 0x04001902 RID: 6402
		[Token(Token = "0x4001902")]
		[FieldOffset(Offset = "0x20")]
		public DialogPackage readyDialog;

		// Token: 0x04001903 RID: 6403
		[Token(Token = "0x4001903")]
		[FieldOffset(Offset = "0x28")]
		public DialogPackage newMusicReadyDialog;

		// Token: 0x04001904 RID: 6404
		[Token(Token = "0x4001904")]
		[FieldOffset(Offset = "0x30")]
		public DialogPackage startDialog;

		// Token: 0x04001905 RID: 6405
		[Token(Token = "0x4001905")]
		[FieldOffset(Offset = "0x38")]
		public DialogPackage extraStartDialog;

		// Token: 0x04001906 RID: 6406
		[Token(Token = "0x4001906")]
		[FieldOffset(Offset = "0x40")]
		public int acceptAddFrames;

		// Token: 0x04001907 RID: 6407
		[Token(Token = "0x4001907")]
		[FieldOffset(Offset = "0x44")]
		public int refuseAddFrames;
	}
}
