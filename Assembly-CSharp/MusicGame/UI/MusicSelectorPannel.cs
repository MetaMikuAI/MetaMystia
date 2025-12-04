using System;
using System.Collections.Generic;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.ShapedLayoutGroup;
using DEYU.UniversalUISystem;
using GameData.Profile;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace MusicGame.UI
{
	// Token: 0x0200006A RID: 106
	[Token(Token = "0x200006A")]
	[GenerateCleanupMethod]
	public class MusicSelectorPannel : UISubPanel<MusicGameMapSelectPannel>
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		public Sprite DefaultPic
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x428D60", Offset = "0x427760", VA = "0x180428D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x17000043")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x4278D0", Offset = "0x4262D0", VA = "0x1804278D0")]
		private void OnGUI()
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x4288F0", Offset = "0x4272F0", VA = "0x1804288F0")]
		public void SetMusicItemsInfo(string mapLabel, List<string> musicLabels)
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x428380", Offset = "0x426D80", VA = "0x180428380", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x4286D0", Offset = "0x4270D0", VA = "0x1804286D0")]
		private void OnWillClose(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x428540", Offset = "0x426F40", VA = "0x180428540", Slot = "21")]
		protected override void OnPanelOpen()
		{
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x428770", Offset = "0x427170", VA = "0x180428770")]
		private void RefreshPannel()
		{
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x4277E0", Offset = "0x4261E0", VA = "0x1804277E0")]
		private int GetScoreLevel(int score)
		{
			return 0;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x4272B0", Offset = "0x425CB0", VA = "0x1804272B0")]
		public void CheckBadgeCondition(bool isEasyMode)
		{
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x428220", Offset = "0x426C20", VA = "0x180428220", Slot = "23")]
		protected override void OnPanelClose()
		{
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x427CA0", Offset = "0x4266A0", VA = "0x180427CA0")]
		private void OnMusicItemEnable(string data, UIElementCluster ui, UIButtonSimple button)
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x427DD0", Offset = "0x4267D0", VA = "0x180427DD0")]
		private void OnMusicItemSelected(string data, UIElementCluster ui, UIButtonSimple button)
		{
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x427810", Offset = "0x426210", VA = "0x180427810")]
		private void OnConfirmPannelClose()
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x427910", Offset = "0x426310", VA = "0x180427910")]
		private void OnMusicGameMainPannelClose()
		{
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x427EA0", Offset = "0x4268A0", VA = "0x180427EA0")]
		private void OnMusicResultPannelClose()
		{
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x4275E0", Offset = "0x425FE0", VA = "0x1804275E0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x428C70", Offset = "0x427670", VA = "0x180428C70")]
		public MusicSelectorPannel()
		{
		}

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		private const int LEVEL_TOTAL_NUM = 6;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject m_MusicItemPrefab;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private MusicSelectorInfoPannel m_MusicSelectorInfoPannelPrefab;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private MusicSelectorConfirmPannel m_MusicSelectorConfirmPannelPrefab;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private MusicGameMainPannel m_MusicGameMainPannelPrefab;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private MusicResultPannel m_MusicResultPannelPrefab;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private MusicRankPannel m_MusicRankPannelPrefab;

		// Token: 0x0400021A RID: 538
		[Token(Token = "0x400021A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ShapedLayoutGroup m_MusicItemContainer;

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIElementCluster m_RecordCluster;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Sprite m_DefaultPic;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Header("All Pass Event")]
		private string m_AllpassEventId;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0xC8")]
		[Header("Badge")]
		[SerializeField]
		private int getBadgeLevelLine;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0xD0")]
		private readonly HashSet<AsyncOperationHandle<LoopedBGMPackage>> m_LoadedHandle;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0xD8")]
		private readonly Dictionary<string, LoopedBGMPackage> m_PreviewMusic;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0xE0")]
		private string m_CurrentMapLabel;

		// Token: 0x04000222 RID: 546
		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0xE8")]
		private string m_CurrentMusicID;

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0xF0")]
		private StaticVirtualScrollListUILogicalGroupT<string, UIElementCluster, UIButtonSimple> m_List;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0xF8")]
		private List<string> m_MusicLabel;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x100")]
		private bool m_ShouldInterrupt;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x108")]
		private MusicGameMainPannel m_MusicGameMainPanel;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x110")]
		private MusicResultPannel m_MusicResultPannel;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x118")]
		private MusicSelectorConfirmPannel m_MusicSelectorConfirmPannel;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x120")]
		private MusicSelectorInfoPannel m_MusicSelectorInfoPannel;

		// Token: 0x0200006B RID: 107
		[Token(Token = "0x200006B")]
		public enum PannelCloseMode
		{
			// Token: 0x0400022B RID: 555
			[Token(Token = "0x400022B")]
			Default,
			// Token: 0x0400022C RID: 556
			[Token(Token = "0x400022C")]
			Restart
		}
	}
}
