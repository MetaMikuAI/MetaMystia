using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppDummyDll;
using NightScene;
using UnityEngine;
using UnityEngine.Playables;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B42 RID: 2882
	[Token(Token = "0x2000B42")]
	[CreateAssetMenu(fileName = "SatoriExtraDialogData", menuName = "GameData Profile/Extra Dialog Data/Satori", order = 5)]
	public class SatoriExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x060044CA RID: 17610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CA")]
		[Address(RVA = "0x71F730", Offset = "0x71E130", VA = "0x18071F730", Slot = "5")]
		public override void GetSpecialGuestExtraDialogData(out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] prependSelection, out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] appendSelections)
		{
		}

		// Token: 0x060044CB RID: 17611 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CB")]
		[Address(RVA = "0x71F3C0", Offset = "0x71DDC0", VA = "0x18071F3C0")]
		private void AddRepeatChallengeItem(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x060044CC RID: 17612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CC")]
		[Address(RVA = "0x71F530", Offset = "0x71DF30", VA = "0x18071F530")]
		private void DifficultButtonConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, NightSceneDirector.Difficulty difficulty, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x060044CD RID: 17613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044CD")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public SatoriExtraDialogData()
		{
		}

		// Token: 0x04003CEB RID: 15595
		[Token(Token = "0x4003CEB")]
		private const string OPTION_REPEATCHALLENGE = "KIZUNA_SPECIAL_SATORI_CHALLANGE_REMENBER";

		// Token: 0x04003CEC RID: 15596
		[Token(Token = "0x4003CEC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string firstChallengeSuccessEventId;

		// Token: 0x04003CED RID: 15597
		[Token(Token = "0x4003CED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string repeatChallengeEventId;

		// Token: 0x04003CEE RID: 15598
		[Token(Token = "0x4003CEE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DialogPackage confirm;

		// Token: 0x04003CEF RID: 15599
		[Token(Token = "0x4003CEF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DialogPackage enter;

		// Token: 0x04003CF0 RID: 15600
		[Token(Token = "0x4003CF0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DialogPackage refuse;

		// Token: 0x04003CF1 RID: 15601
		[Token(Token = "0x4003CF1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PlayableAsset introTimeline;
	}
}
