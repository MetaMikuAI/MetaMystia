using System;
using System.Runtime.CompilerServices;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace MusicGame.UI
{
	// Token: 0x02000075 RID: 117
	[Token(Token = "0x2000075")]
	public readonly struct DLC3_MusicGameMainPannelOpenContext
	{
		// Token: 0x06000287 RID: 647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x421E40", Offset = "0x420840", VA = "0x180421E40")]
		public DLC3_MusicGameMainPannelOpenContext(MusicGameChapterProfile.MusicChapter musicChapter, float musicalNoteSpeed, Vector2Int missedNoteNum, ValueTuple<DLC3_MusicGameStartPannel.RockSprites, DLC3_MusicGameStartPannel.RockSprites> rockSpritePair)
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x1700004B")]
		[TupleElementNames(new string[] { "BossRockSprites", "PlayerRockSprites" })]
		public ValueTuple<DLC3_MusicGameStartPannel.RockSprites, DLC3_MusicGameStartPannel.RockSprites> RockSpritesPair
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x421EF0", Offset = "0x4208F0", VA = "0x180421EF0")]
			get
			{
				return default(ValueTuple<DLC3_MusicGameStartPannel.RockSprites, DLC3_MusicGameStartPannel.RockSprites>);
			}
		}

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x0")]
		public readonly MusicGameChapterProfile.MusicChapter MusicChapter;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x60")]
		public readonly float MusicalNoteSpeed;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x64")]
		public readonly Vector2Int MissedNoteNum;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x70")]
		private readonly ValueTuple<DLC3_MusicGameStartPannel.RockSprites, DLC3_MusicGameStartPannel.RockSprites> rockSpritePair;
	}
}
