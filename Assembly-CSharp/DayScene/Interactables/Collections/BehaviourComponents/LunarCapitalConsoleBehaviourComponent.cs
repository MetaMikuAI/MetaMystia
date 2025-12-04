using System;
using System.Collections.Generic;
using DayScene.UI;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000501 RID: 1281
	[Token(Token = "0x2000501")]
	public class LunarCapitalConsoleBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06001CC0 RID: 7360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC0")]
		[Address(RVA = "0x4AFDF0", Offset = "0x4AE7F0", VA = "0x1804AFDF0", Slot = "12")]
		protected override void OnInitialize()
		{
		}

		// Token: 0x06001CC1 RID: 7361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC1")]
		[Address(RVA = "0x4B0440", Offset = "0x4AEE40", VA = "0x1804B0440", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC2")]
		[Address(RVA = "0x494410", Offset = "0x492E10", VA = "0x180494410")]
		private static void OnCloseButtonSubmit(Action action)
		{
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC3")]
		[Address(RVA = "0x4B0980", Offset = "0x4AF380", VA = "0x1804B0980")]
		private void OpenTreasureToolsPanel(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC4")]
		[Address(RVA = "0x4B0670", Offset = "0x4AF070", VA = "0x1804B0670")]
		private void OpenRepeatChallengePanel(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC5")]
		[Address(RVA = "0x4B0860", Offset = "0x4AF260", VA = "0x1804B0860")]
		private void OpenRogueLikePanel(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC6")]
		[Address(RVA = "0x4B0590", Offset = "0x4AEF90", VA = "0x1804B0590")]
		private void OpenEternalBox(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC7")]
		[Address(RVA = "0x4AF9A0", Offset = "0x4AE3A0", VA = "0x1804AF9A0")]
		private void EnterPracticeA(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC8")]
		[Address(RVA = "0x4AFB10", Offset = "0x4AE510", VA = "0x1804AFB10")]
		private void EnterPracticeB(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CC9")]
		[Address(RVA = "0x4AFC80", Offset = "0x4AE680", VA = "0x1804AFC80")]
		private void EnterPracticeC(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCA")]
		[Address(RVA = "0x4AF4E0", Offset = "0x4ADEE0", VA = "0x1804AF4E0")]
		private void EnterArrestMizuchi(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCB")]
		[Address(RVA = "0x4B0A60", Offset = "0x4AF460", VA = "0x1804B0A60")]
		private static void SwitchMizuchiBuffs(string[] options)
		{
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001CCC")]
		[Address(RVA = "0x3E89A0", Offset = "0x3E73A0", VA = "0x1803E89A0")]
		public LunarCapitalConsoleBehaviourComponent()
		{
		}

		// Token: 0x04001A78 RID: 6776
		[Token(Token = "0x4001A78")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DaySceneChatSelectionPannel.GetSelectionConfigurationCallback[] m_TopMenuOptions;

		// Token: 0x04001A79 RID: 6777
		[Token(Token = "0x4001A79")]
		[FieldOffset(Offset = "0x8")]
		private static readonly DaySceneChatSelectionPannel.GetSelectionConfigurationCallback[] m_TreasureToolsOptions;

		// Token: 0x04001A7A RID: 6778
		[Token(Token = "0x4001A7A")]
		[FieldOffset(Offset = "0x10")]
		private static readonly DaySceneChatSelectionPannel.GetSelectionConfigurationCallback[] m_RepeatChallengeMenuOptions;

		// Token: 0x04001A7B RID: 6779
		[Token(Token = "0x4001A7B")]
		[FieldOffset(Offset = "0x18")]
		private static readonly object[] m_MizuchiBuffs;

		// Token: 0x04001A7C RID: 6780
		[Token(Token = "0x4001A7C")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Dictionary<object, string> m_MizuchiBuffsTitle;

		// Token: 0x04001A7D RID: 6781
		[Token(Token = "0x4001A7D")]
		[FieldOffset(Offset = "0x18")]
		private bool m_IsEnterChallenge;

		// Token: 0x04001A7E RID: 6782
		[Token(Token = "0x4001A7E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("[Challenge Finished Event]")]
		private string m_PracticeAChallengeFinishedEvent;

		// Token: 0x04001A7F RID: 6783
		[Token(Token = "0x4001A7F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string m_PracticeBChallengeFinishedEvent;

		// Token: 0x04001A80 RID: 6784
		[Token(Token = "0x4001A80")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_PracticeCChallengeFinishedEvent;

		// Token: 0x04001A81 RID: 6785
		[Token(Token = "0x4001A81")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string m_ArrestMizuchiChallengeFinishedEvent;

		// Token: 0x04001A82 RID: 6786
		[Token(Token = "0x4001A82")]
		[FieldOffset(Offset = "0x40")]
		[Header("[Repeat Challenge Start Event]")]
		[Space]
		[SerializeField]
		private string m_PracticeARepeatChallengeStartEvent;

		// Token: 0x04001A83 RID: 6787
		[Token(Token = "0x4001A83")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string m_PracticeBRepeatChallengeStartEvent;

		// Token: 0x04001A84 RID: 6788
		[Token(Token = "0x4001A84")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string m_PracticeCRepeatChallengeStartEvent;

		// Token: 0x04001A85 RID: 6789
		[Token(Token = "0x4001A85")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string m_ArrestMizuchiRepeatChallengeStartEvent;

		// Token: 0x04001A86 RID: 6790
		[Token(Token = "0x4001A86")]
		[FieldOffset(Offset = "0x60")]
		[Space]
		[SerializeField]
		[Header("[Dialog Package]")]
		private DialogPackage m_WelcomeDialog;

		// Token: 0x04001A87 RID: 6791
		[Token(Token = "0x4001A87")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private DialogPackage m_TreasureToolsNoneDialog;

		// Token: 0x04001A88 RID: 6792
		[Token(Token = "0x4001A88")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private DialogPackage m_RepeatChallengeArrestMizuchiDialog;
	}
}
