using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.ShapedLayoutGroup;
using DEYU.UniversalUISystem;
using GameData.Profile;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;

namespace MusicGame.UI
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	[GenerateCleanupMethod]
	public class MusicRankPannel : UISubPanel<MusicSelectorPannel>
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00002838 File Offset: 0x00000A38
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002F")]
		public MusicResultPannel.MusicFinalScoreOpenContext OpenContext
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x418FF0", Offset = "0x4179F0", VA = "0x180418FF0")]
			[CompilerGenerated]
			private get
			{
				return default(MusicResultPannel.MusicFinalScoreOpenContext);
			}
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x419020", Offset = "0x417A20", VA = "0x180419020")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00002850 File Offset: 0x00000A50
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000030")]
		public bool HasContinueButton
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x418FE0", Offset = "0x4179E0", VA = "0x180418FE0")]
			[CompilerGenerated]
			private get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x419010", Offset = "0x417A10", VA = "0x180419010")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x17000031")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x417760", Offset = "0x416160", VA = "0x180417760", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x4173C0", Offset = "0x415DC0", VA = "0x1804173C0")]
		private void OnElementEnable(KeyValuePair<int, MusicGameChapterProfile.NPCMusicRank> data, UIElementCluster ui, UIButtonSimple button)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x417320", Offset = "0x415D20", VA = "0x180417320")]
		private void OnClose()
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x417C20", Offset = "0x416620", VA = "0x180417C20", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x4176E0", Offset = "0x4160E0", VA = "0x1804176E0", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x4185E0", Offset = "0x416FE0", VA = "0x1804185E0")]
		private void ProcessRankElementShared(MusicGameChapterProfile.NPCMusicRank data, UIElementCluster cluster)
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x418D70", Offset = "0x417770", VA = "0x180418D70")]
		private void ProcessTopRankElement(UIElementCluster cluster, KeyValuePair<int, MusicGameChapterProfile.NPCMusicRank> dataPair)
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x418510", Offset = "0x416F10", VA = "0x180418510")]
		private void ProcessNormalRankElement(UIElementCluster cluster, KeyValuePair<int, MusicGameChapterProfile.NPCMusicRank> dataPair)
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x417230", Offset = "0x415C30", VA = "0x180417230", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x418FA0", Offset = "0x4179A0", VA = "0x180418FA0")]
		public MusicRankPannel()
		{
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x418F70", Offset = "0x417970", VA = "0x180418F70")]
		[CompilerGenerated]
		private int <OnPanelOpen>g__GetScore|27_0(MusicGameChapterProfile.NPCMusicRank nPC)
		{
			return 0;
		}

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		private const string SELF_TOP_INDICATOR = "CHARACTER_SELF_TOP";

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		private const string SELF_INDICATOR = "CHARACTER_SELF";

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		private const string INPUTHELPER_CONTINUE = "INPUTHELPER_CONTINUE";

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		private const string INPUTHELPER_BACK = "INPUTHELPER_BACK";

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x78")]
		public GameObject AIORankElement;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x80")]
		public ShapedLayoutGroup RankTransform;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x88")]
		public UIButtonSimple Btn;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x90")]
		public TextMeshProUGUI BtnText;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x98")]
		public UIElementCluster CDComponent;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0xA0")]
		public Sprite Top1RankSprite;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0xA8")]
		public Sprite Top2RankSprite;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0xB0")]
		public Sprite Top3RankSprite;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0xB8")]
		private StaticVirtualScrollListUILogicalGroupT<KeyValuePair<int, MusicGameChapterProfile.NPCMusicRank>, UIElementCluster, UIButtonSimple> m_List;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0xC0")]
		private Sprite[] m_TopRankSprites;
	}
}
