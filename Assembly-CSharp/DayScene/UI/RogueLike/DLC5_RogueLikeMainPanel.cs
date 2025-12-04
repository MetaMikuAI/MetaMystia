using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020003B0 RID: 944
	[Token(Token = "0x20003B0")]
	[TupleElementNames(new string[] { "LoadPanel", "RogueLikeAchievement", "DataProfile", "selection", "saveIndex", "difficulty" })]
	[GenerateCleanupMethod]
	public class DLC5_RogueLikeMainPanel : UIPanelParam<ValueTuple<DLC5_RogueLikeSaveLoadPanel, HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType>, IRogueLikeData>, ValueTuple<DLC5_RogueLikeMainPanel.Selection, Nullable<int>, NightSceneDirector.Difficulty>>
	{
		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060014E6 RID: 5350 RVA: 0x00007FB0 File Offset: 0x000061B0
		[Token(Token = "0x17000277")]
		public IRogueLikeData RogueLikeData
		{
			[Token(Token = "0x60014E6")]
			[Address(RVA = "0x444E10", Offset = "0x443810", VA = "0x180444E10")]
			get
			{
				return default(IRogueLikeData);
			}
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E7")]
		[Address(RVA = "0x4440A0", Offset = "0x442AA0", VA = "0x1804440A0", Slot = "22")]
		protected override void OnPanelInitialize()
		{
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E8")]
		[Address(RVA = "0x444000", Offset = "0x442A00", VA = "0x180444000")]
		private void ClosePanelWithData(DLC5_RogueLikeMainPanel.Selection selection, int? index)
		{
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014E9")]
		[Address(RVA = "0x444420", Offset = "0x442E20", VA = "0x180444420", Slot = "32")]
		protected override void OnPanelOpen([TupleElementNames(new string[] { "LoadPanel", "RogueLikeAchievement", "DataProfile" })] ValueTuple<DLC5_RogueLikeSaveLoadPanel, HashSet<DLC5_RogueLikeDataProfile.RogueLikeAchievementType>, IRogueLikeData> openParam)
		{
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x00007FC8 File Offset: 0x000061C8
		[Token(Token = "0x60014EA")]
		[Address(RVA = "0x444630", Offset = "0x443030", VA = "0x180444630")]
		private UniTask OpenStaffPanel()
		{
			return default(UniTask);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014EB")]
		[Address(RVA = "0x43ED60", Offset = "0x43D760", VA = "0x18043ED60", Slot = "24")]
		protected override void OnPanelDestroyed()
		{
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014EC")]
		[Address(RVA = "0x443EE0", Offset = "0x4428E0", VA = "0x180443EE0", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60014ED")]
		[Address(RVA = "0x444DD0", Offset = "0x4437D0", VA = "0x180444DD0")]
		public DLC5_RogueLikeMainPanel()
		{
		}

		// Token: 0x04001384 RID: 4996
		[Token(Token = "0x4001384")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private DLC5_RogueLikeNewGamePanel m_RogueLikeNewGamePanel;

		// Token: 0x04001385 RID: 4997
		[Token(Token = "0x4001385")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIButtonSimple m_ContinueButton;

		// Token: 0x04001386 RID: 4998
		[Token(Token = "0x4001386")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIButtonSimple m_NewGameButton;

		// Token: 0x04001387 RID: 4999
		[Token(Token = "0x4001387")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIButtonSimple m_CloseButton;

		// Token: 0x04001388 RID: 5000
		[Token(Token = "0x4001388")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIButtonSimple m_TutorialButton;

		// Token: 0x04001389 RID: 5001
		[Token(Token = "0x4001389")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIButtonSimple m_StaffButton;

		// Token: 0x0400138A RID: 5002
		[Token(Token = "0x400138A")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIButtonSimple m_BadgeButton;

		// Token: 0x0400138B RID: 5003
		[Token(Token = "0x400138B")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private DialogPackage m_BadgeDialog;

		// Token: 0x0400138C RID: 5004
		[Token(Token = "0x400138C")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private DLC5_RogueLikeMainBadgeRewardPanel m_BadgeClaimPanel;

		// Token: 0x0400138D RID: 5005
		[Token(Token = "0x400138D")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private AssetReference m_StaffPanel;

		// Token: 0x0400138E RID: 5006
		[Token(Token = "0x400138E")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private DialogPackage m_TutorialDialog;

		// Token: 0x0400138F RID: 5007
		[Token(Token = "0x400138F")]
		[FieldOffset(Offset = "0xF8")]
		private NightSceneDirector.Difficulty m_Difficulty;

		// Token: 0x04001390 RID: 5008
		[Token(Token = "0x4001390")]
		[FieldOffset(Offset = "0x100")]
		private RogueLikeAchievementRunTimeData m_AchievementRunTimeData;

		// Token: 0x04001391 RID: 5009
		[Token(Token = "0x4001391")]
		private const int MIKE_ID = 5015;

		// Token: 0x020003B1 RID: 945
		[Token(Token = "0x20003B1")]
		public enum Selection
		{
			// Token: 0x04001393 RID: 5011
			[Token(Token = "0x4001393")]
			Continue,
			// Token: 0x04001394 RID: 5012
			[Token(Token = "0x4001394")]
			NewGame,
			// Token: 0x04001395 RID: 5013
			[Token(Token = "0x4001395")]
			None
		}
	}
}
