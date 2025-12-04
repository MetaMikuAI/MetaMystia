using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Profile;
using Il2CppDummyDll;
using MusicGame.UI;
using NightScene;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

// Token: 0x02000029 RID: 41
[Token(Token = "0x2000029")]
[GenerateCleanupMethod]
public class DLC3_MusicGameStartPannel : UIPanel
{
	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060000D5 RID: 213 RVA: 0x00002388 File Offset: 0x00000588
	// (set) Token: 0x060000D6 RID: 214 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000013")]
	public float MusicalNoteSpeed
	{
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x409CE0", Offset = "0x4086E0", VA = "0x180409CE0")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x409D20", Offset = "0x408720", VA = "0x180409D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060000D7 RID: 215 RVA: 0x000023A0 File Offset: 0x000005A0
	// (set) Token: 0x060000D8 RID: 216 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000014")]
	public NightSceneDirector.ChallengeType BossLabel
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x409CD0", Offset = "0x4086D0", VA = "0x180409CD0")]
		[CompilerGenerated]
		private get
		{
			return NightSceneDirector.ChallengeType.NotChallenge;
		}
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x409D10", Offset = "0x408710", VA = "0x180409D10")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x060000D9 RID: 217 RVA: 0x000023B8 File Offset: 0x000005B8
	// (set) Token: 0x060000DA RID: 218 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000015")]
	public DLC3_MusicGameStartPannel.FinalResult ResultMode
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x409CF0", Offset = "0x4086F0", VA = "0x180409CF0")]
		[CompilerGenerated]
		private get
		{
			return DLC3_MusicGameStartPannel.FinalResult.Win;
		}
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x409D30", Offset = "0x408730", VA = "0x180409D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x060000DB RID: 219 RVA: 0x000023D0 File Offset: 0x000005D0
	// (set) Token: 0x060000DC RID: 220 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000016")]
	public DLC3_MusicGameStartPannel.PlaySkipMode playMode
	{
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x409D00", Offset = "0x408700", VA = "0x180409D00")]
		[CompilerGenerated]
		get
		{
			return DLC3_MusicGameStartPannel.PlaySkipMode.Win;
		}
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x409D40", Offset = "0x408740", VA = "0x180409D40")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x060000DD RID: 221 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x409020", Offset = "0x407A20", VA = "0x180409020")]
	private void OnGUI()
	{
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x4092A0", Offset = "0x407CA0", VA = "0x1804092A0", Slot = "22")]
	protected override void OnPanelInitialize()
	{
	}

	// Token: 0x060000DF RID: 223 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x409790", Offset = "0x408190", VA = "0x180409790", Slot = "21")]
	protected override void OnPanelOpen()
	{
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x409900", Offset = "0x408300", VA = "0x180409900")]
	private void OpenMainPannel()
	{
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x409AB0", Offset = "0x4084B0", VA = "0x180409AB0")]
	private void OpenResultPannel(DLC3_MusicGameMainPannel closedMainPannel)
	{
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x408EB0", Offset = "0x4078B0", VA = "0x180408EB0")]
	private void AfterChallenge()
	{
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x408FA0", Offset = "0x4079A0", VA = "0x180408FA0", Slot = "31")]
	protected override void Cleanup_Generated()
	{
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x408E80", Offset = "0x407880", VA = "0x180408E80")]
	public DLC3_MusicGameStartPannel()
	{
	}

	// Token: 0x040000A5 RID: 165
	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x70")]
	public DLC3_MusicGameStartPannel.BossMusicChapterMapping[] bossAndChapterMapping;

	// Token: 0x040000A6 RID: 166
	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x78")]
	public DLC3_MusicGameMainPannel DLC3_MusicGameMainPannel;

	// Token: 0x040000A7 RID: 167
	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x80")]
	public DLC3_BossBattleResultPannel ResultPannel;

	// Token: 0x040000A8 RID: 168
	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x88")]
	public MusicSelectorReconfirmPannel reconfirmPannel;

	// Token: 0x040000A9 RID: 169
	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x90")]
	public DLC3_MusicGameStartPannel.RockSprites mystiaSprites;

	// Token: 0x040000AA RID: 170
	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0xB8")]
	private Dictionary<NightSceneDirector.ChallengeType, ValueTuple<MusicGameChapterProfile.MusicChapter, DLC3_MusicGameStartPannel.BossMusicChapterMapping>> chapterDic;

	// Token: 0x0200002A RID: 42
	[Token(Token = "0x200002A")]
	public enum FinalResult
	{
		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		Win,
		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		Lose
	}

	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	public enum PlaySkipMode
	{
		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		Win,
		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		Lose,
		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		Normal
	}

	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	[Serializable]
	public struct RockSprites
	{
		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public Sprite wait;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		public Sprite wait2;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		public Sprite rock;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Sprite rock2;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Sprite wrong;
	}

	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	[Serializable]
	public struct BossMusicChapterMapping
	{
		// Token: 0x060000E6 RID: 230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x406C40", Offset = "0x405640", VA = "0x180406C40")]
		public BossMusicChapterMapping(NightSceneDirector.ChallengeType bossLabel, string chapterLabel, Vector2Int missCombo, DLC3_MusicGameStartPannel.RockSprites rockSprites)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x17000017")]
		public NightSceneDirector.ChallengeType BossLabel
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x406CA0", Offset = "0x4056A0", VA = "0x180406CA0")]
			get
			{
				return NightSceneDirector.ChallengeType.NotChallenge;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000018")]
		public string ChapterLabel
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x17000019")]
		public Vector2Int MissCombo
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
			get
			{
				return default(Vector2Int);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x1700001A")]
		public DLC3_MusicGameStartPannel.RockSprites RockSprites
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x406CD0", Offset = "0x4056D0", VA = "0x180406CD0")]
			get
			{
				return default(DLC3_MusicGameStartPannel.RockSprites);
			}
		}

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private NightSceneDirector.ChallengeType bossLabel;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private string chapterLabel;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Vector2Int missCombo;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DLC3_MusicGameStartPannel.RockSprites rockSprites;
	}
}
