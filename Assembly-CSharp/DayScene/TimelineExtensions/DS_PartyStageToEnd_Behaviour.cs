using System;
using System.Collections.Generic;
using Common;
using Common.TimelineExtestion;
using Cysharp.Threading.Tasks;
using GameData.Profile;
using Il2CppDummyDll;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200049A RID: 1178
	[Token(Token = "0x200049A")]
	public class DS_PartyStageToEnd_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06001B04 RID: 6916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B04")]
		[Address(RVA = "0x499C40", Offset = "0x498640", VA = "0x180499C40", Slot = "22")]
		protected override void OnBehaviourEnter()
		{
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0000A728 File Offset: 0x00008928
		[Token(Token = "0x6001B05")]
		[Address(RVA = "0x499BB0", Offset = "0x4985B0", VA = "0x180499BB0")]
		private UniTaskVoid OnBehaviourEnterAsync()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B06")]
		[Address(RVA = "0x499CE0", Offset = "0x4986E0", VA = "0x180499CE0")]
		private void ToEnd(SceneDirector.StaffScenePlayBackIndicator dlcIndicator)
		{
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x0000A740 File Offset: 0x00008940
		[Token(Token = "0x6001B07")]
		[Address(RVA = "0x499B10", Offset = "0x498510", VA = "0x180499B10")]
		private static bool IsAllKizunaMaxLevel(IReadOnlyCollection<int> lv5Kizuna, int[] specialNPCs)
		{
			return default(bool);
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B08")]
		[Address(RVA = "0x499A80", Offset = "0x498480", VA = "0x180499A80")]
		private static string GetTitle(string key, bool isNew = false)
		{
			return null;
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B09")]
		[Address(RVA = "0x497990", Offset = "0x496390", VA = "0x180497990")]
		public DS_PartyStageToEnd_Behaviour()
		{
		}

		// Token: 0x040018B6 RID: 6326
		[Token(Token = "0x40018B6")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<SceneDirector.StaffScenePlayBackIndicator, string> dlcPartyStageKey;

		// Token: 0x040018B7 RID: 6327
		[Token(Token = "0x40018B7")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<SceneDirector.StaffScenePlayBackIndicator, string> dlcCGEventKey;

		// Token: 0x040018B8 RID: 6328
		[Token(Token = "0x40018B8")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int[] mainKizuna;

		// Token: 0x040018B9 RID: 6329
		[Token(Token = "0x40018B9")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int[] dlc1Kizuna;

		// Token: 0x040018BA RID: 6330
		[Token(Token = "0x40018BA")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int[] dlc2Kizuna;

		// Token: 0x040018BB RID: 6331
		[Token(Token = "0x40018BB")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int[] dlc3Kizuna;

		// Token: 0x040018BC RID: 6332
		[Token(Token = "0x40018BC")]
		[FieldOffset(Offset = "0x30")]
		private static readonly int[] dlc4Kizuna;

		// Token: 0x040018BD RID: 6333
		[Token(Token = "0x40018BD")]
		[FieldOffset(Offset = "0x38")]
		private static readonly int[] dlc5Kizuna;

		// Token: 0x040018BE RID: 6334
		[Token(Token = "0x40018BE")]
		[FieldOffset(Offset = "0x10")]
		public bool mainStory;

		// Token: 0x040018BF RID: 6335
		[Token(Token = "0x40018BF")]
		[FieldOffset(Offset = "0x18")]
		public DialogPackage readyDialog;

		// Token: 0x040018C0 RID: 6336
		[Token(Token = "0x40018C0")]
		[FieldOffset(Offset = "0x20")]
		public DialogPackage newMusicReadyDialog;

		// Token: 0x040018C1 RID: 6337
		[Token(Token = "0x40018C1")]
		[FieldOffset(Offset = "0x28")]
		public DialogPackage startDialog;

		// Token: 0x040018C2 RID: 6338
		[Token(Token = "0x40018C2")]
		[FieldOffset(Offset = "0x30")]
		public DialogPackage extraStartDialog;

		// Token: 0x040018C3 RID: 6339
		[Token(Token = "0x40018C3")]
		[FieldOffset(Offset = "0x38")]
		public int acceptAddFrames;

		// Token: 0x040018C4 RID: 6340
		[Token(Token = "0x40018C4")]
		[FieldOffset(Offset = "0x3C")]
		public int refuseAddFrames;
	}
}
