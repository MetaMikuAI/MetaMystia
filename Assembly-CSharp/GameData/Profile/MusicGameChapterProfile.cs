using System;
using DEYU.UniversalUISystem;
using GameData.Core.MusicUtility;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Profile
{
	// Token: 0x02000BA8 RID: 2984
	[Token(Token = "0x2000BA8")]
	[CreateAssetMenu(fileName = "DaySceneMusicGameChapterProfile", menuName = "GameData Profile/CreateDaySceneMusicGameChapterProfile", order = 2501)]
	public class MusicGameChapterProfile : ScriptableObject
	{
		// Token: 0x06004692 RID: 18066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004692")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public MusicGameChapterProfile()
		{
		}

		// Token: 0x04003F16 RID: 16150
		[Token(Token = "0x4003F16")]
		[FieldOffset(Offset = "0x18")]
		public MusicGameChapterProfile.MusicChapter[] Chapters;

		// Token: 0x02000BA9 RID: 2985
		[Token(Token = "0x2000BA9")]
		[Serializable]
		public struct NPCMusicRank
		{
			// Token: 0x06004693 RID: 18067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004693")]
			[Address(RVA = "0x73F720", Offset = "0x73E120", VA = "0x18073F720")]
			public NPCMusicRank(string npcLabel, Vector2Int npcScore)
			{
			}

			// Token: 0x17000A49 RID: 2633
			// (get) Token: 0x06004694 RID: 18068 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A49")]
			public string NpcLabel
			{
				[Token(Token = "0x6004694")]
				[Address(RVA = "0x4070A0", Offset = "0x405AA0", VA = "0x1804070A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A4A RID: 2634
			// (get) Token: 0x06004695 RID: 18069 RVA: 0x00019650 File Offset: 0x00017850
			[Token(Token = "0x17000A4A")]
			public Vector2Int NpcScore
			{
				[Token(Token = "0x6004695")]
				[Address(RVA = "0x406CB0", Offset = "0x4056B0", VA = "0x180406CB0")]
				get
				{
					return default(Vector2Int);
				}
			}

			// Token: 0x04003F17 RID: 16151
			[Token(Token = "0x4003F17")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private string npcLabel;

			// Token: 0x04003F18 RID: 16152
			[Token(Token = "0x4003F18")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private Vector2Int npcScore;
		}

		// Token: 0x02000BAA RID: 2986
		[Token(Token = "0x2000BAA")]
		[Serializable]
		public struct MusicChapter
		{
			// Token: 0x17000A4B RID: 2635
			// (get) Token: 0x06004696 RID: 18070 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A4B")]
			public string MusicLabel
			{
				[Token(Token = "0x6004696")]
				[Address(RVA = "0x4070A0", Offset = "0x405AA0", VA = "0x1804070A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A4C RID: 2636
			// (get) Token: 0x06004697 RID: 18071 RVA: 0x00019668 File Offset: 0x00017868
			[Token(Token = "0x17000A4C")]
			public int EasyModeLevel
			{
				[Token(Token = "0x6004697")]
				[Address(RVA = "0x48B8C0", Offset = "0x48A2C0", VA = "0x18048B8C0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000A4D RID: 2637
			// (get) Token: 0x06004698 RID: 18072 RVA: 0x00019680 File Offset: 0x00017880
			[Token(Token = "0x17000A4D")]
			public int HardModeLevel
			{
				[Token(Token = "0x6004698")]
				[Address(RVA = "0x517C80", Offset = "0x516680", VA = "0x180517C80")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000A4E RID: 2638
			// (get) Token: 0x06004699 RID: 18073 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A4E")]
			public IzakayaMusic.SingleNote[] EasySingleNote
			{
				[Token(Token = "0x6004699")]
				[Address(RVA = "0x406CC0", Offset = "0x4056C0", VA = "0x180406CC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A4F RID: 2639
			// (get) Token: 0x0600469A RID: 18074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A4F")]
			public IzakayaMusic.SingleNote[] HardSingleNote
			{
				[Token(Token = "0x600469A")]
				[Address(RVA = "0x3F9450", Offset = "0x3F7E50", VA = "0x1803F9450")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A50 RID: 2640
			// (get) Token: 0x0600469B RID: 18075 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A50")]
			public Sprite CoverPic
			{
				[Token(Token = "0x600469B")]
				[Address(RVA = "0x403820", Offset = "0x402220", VA = "0x180403820")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A51 RID: 2641
			// (get) Token: 0x0600469C RID: 18076 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A51")]
			public AssetReference MusicAudioPackage
			{
				[Token(Token = "0x600469C")]
				[Address(RVA = "0x440290", Offset = "0x43EC90", VA = "0x180440290")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A52 RID: 2642
			// (get) Token: 0x0600469D RID: 18077 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A52")]
			public long[] NoteClick
			{
				[Token(Token = "0x600469D")]
				[Address(RVA = "0x3F20F0", Offset = "0x3F0AF0", VA = "0x1803F20F0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A53 RID: 2643
			// (get) Token: 0x0600469E RID: 18078 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A53")]
			public MusicGameChapterProfile.NPCMusicRank[] NpcMusicRanks
			{
				[Token(Token = "0x600469E")]
				[Address(RVA = "0x73F4A0", Offset = "0x73DEA0", VA = "0x18073F4A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000A54 RID: 2644
			// (get) Token: 0x0600469F RID: 18079 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000A54")]
			public AssetReference PreviewMusic
			{
				[Token(Token = "0x600469F")]
				[Address(RVA = "0x477F80", Offset = "0x476980", VA = "0x180477F80")]
				get
				{
					return null;
				}
			}

			// Token: 0x060046A0 RID: 18080 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60046A0")]
			[Address(RVA = "0x73F460", Offset = "0x73DE60", VA = "0x18073F460")]
			public void UpdateMap(IzakayaMusic.SingleNote[] newEasy, IzakayaMusic.SingleNote[] newHard)
			{
			}

			// Token: 0x060046A1 RID: 18081 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60046A1")]
			[Address(RVA = "0x73F360", Offset = "0x73DD60", VA = "0x18073F360")]
			public void ApplyCDImage(UIElementCluster imageComponent)
			{
			}

			// Token: 0x060046A2 RID: 18082 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60046A2")]
			[Address(RVA = "0x51B160", Offset = "0x519B60", VA = "0x18051B160")]
			public void SetNpcMusicRanks(MusicGameChapterProfile.NPCMusicRank[] ranks)
			{
			}

			// Token: 0x04003F19 RID: 16153
			[Token(Token = "0x4003F19")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private string musicLabel;

			// Token: 0x04003F1A RID: 16154
			[Token(Token = "0x4003F1A")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			private int easyModeLevel;

			// Token: 0x04003F1B RID: 16155
			[Token(Token = "0x4003F1B")]
			[FieldOffset(Offset = "0xC")]
			[SerializeField]
			private int hardModeLevel;

			// Token: 0x04003F1C RID: 16156
			[Token(Token = "0x4003F1C")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private IzakayaMusic.SingleNote[] easySingleNote;

			// Token: 0x04003F1D RID: 16157
			[Token(Token = "0x4003F1D")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private IzakayaMusic.SingleNote[] hardSingleNote;

			// Token: 0x04003F1E RID: 16158
			[Token(Token = "0x4003F1E")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private long[] noteClick;

			// Token: 0x04003F1F RID: 16159
			[Token(Token = "0x4003F1F")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Sprite coverPic;

			// Token: 0x04003F20 RID: 16160
			[Token(Token = "0x4003F20")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Vector2 coverPicOffset;

			// Token: 0x04003F21 RID: 16161
			[Token(Token = "0x4003F21")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Color coverPicBorderColor;

			// Token: 0x04003F22 RID: 16162
			[Token(Token = "0x4003F22")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private AssetReference musicAudioPackage;

			// Token: 0x04003F23 RID: 16163
			[Token(Token = "0x4003F23")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private MusicGameChapterProfile.NPCMusicRank[] npcMusicRanks;

			// Token: 0x04003F24 RID: 16164
			[Token(Token = "0x4003F24")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			private AssetReference previewMusic;
		}
	}
}
