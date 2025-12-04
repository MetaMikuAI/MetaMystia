using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B08 RID: 2824
	[Token(Token = "0x2000B08")]
	[CreateAssetMenu(fileName = "FlandreExtraDialogData", menuName = "GameData Profile/Extra Dialog Data/DLC4/Flandre", order = 0)]
	public class FlandreExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x0600440E RID: 17422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440E")]
		[Address(RVA = "0x719F00", Offset = "0x718900", VA = "0x180719F00", Slot = "5")]
		public override void GetSpecialGuestExtraDialogData(out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] prependSelection, out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] appendSelections)
		{
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600440F")]
		[Address(RVA = "0x719BC0", Offset = "0x7185C0", VA = "0x180719BC0")]
		private void Decoration(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004410")]
		[Address(RVA = "0x71A090", Offset = "0x718A90", VA = "0x18071A090")]
		private void Rechallenge(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004411")]
		[Address(RVA = "0x719D00", Offset = "0x718700", VA = "0x180719D00")]
		private void DifficultButtonConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, NightSceneDirector.Difficulty difficulty, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06004412 RID: 17426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004412")]
		[Address(RVA = "0x719A80", Offset = "0x718480", VA = "0x180719A80")]
		private void Confirm(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06004413 RID: 17427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004413")]
		[Address(RVA = "0x71A200", Offset = "0x718C00", VA = "0x18071A200")]
		private void Refuse(Action closePannelCallback)
		{
		}

		// Token: 0x06004414 RID: 17428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004414")]
		[Address(RVA = "0x71A280", Offset = "0x718C80", VA = "0x18071A280")]
		public FlandreExtraDialogData()
		{
		}

		// Token: 0x04003C1F RID: 15391
		[Token(Token = "0x4003C1F")]
		private const string DECORATION_TITLE = "DLC4_FLANDRE_HOME_DECORATE";

		// Token: 0x04003C20 RID: 15392
		[Token(Token = "0x4003C20")]
		private const string RECHALLENGE_TITLE = "DLC4_MAIN_ENTER_FLANDRE_REPEAT_CHALLENGE";

		// Token: 0x04003C21 RID: 15393
		[Token(Token = "0x4003C21")]
		private const string RECHALLENGE_CONFIRM = "DLC4_MAIN_ENTER_FLANDRE_REPEAT_CHALLENGE_YES";

		// Token: 0x04003C22 RID: 15394
		[Token(Token = "0x4003C22")]
		private const string RECHALLENGE_REFUSE = "DLC4_MAIN_ENTER_FLANDRE_REPEAT_CHALLENGE_NO";

		// Token: 0x04003C23 RID: 15395
		[Token(Token = "0x4003C23")]
		[FieldOffset(Offset = "0x18")]
		public DialogPackage decorationDialog;

		// Token: 0x04003C24 RID: 15396
		[Token(Token = "0x4003C24")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DLC4_FlandreHomeDecorationEditorPanel m_DecorationEditorPanel;

		// Token: 0x04003C25 RID: 15397
		[Token(Token = "0x4003C25")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string m_BeginEventLabel;

		// Token: 0x04003C26 RID: 15398
		[Token(Token = "0x4003C26")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string m_RepeatChallengeEventId;

		// Token: 0x04003C27 RID: 15399
		[Token(Token = "0x4003C27")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DialogPackage m_ConfirmDialog;

		// Token: 0x04003C28 RID: 15400
		[Token(Token = "0x4003C28")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DialogPackage m_RefuseDialog;

		// Token: 0x04003C29 RID: 15401
		[Token(Token = "0x4003C29")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private DialogPackage m_ReChallengeDialog;
	}
}
