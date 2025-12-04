using System;
using DayScene.UI;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B37 RID: 2871
	[Token(Token = "0x2000B37")]
	[CreateAssetMenu(fileName = "NitoriExtraDialogData", menuName = "GameData Profile/Extra Dialog Data/Nitori", order = 3)]
	public class NitoriExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x060044AA RID: 17578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044AA")]
		[Address(RVA = "0x71E290", Offset = "0x71CC90", VA = "0x18071E290", Slot = "5")]
		public override void GetSpecialGuestExtraDialogData(out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] prependSelection, out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] appendSelections)
		{
		}

		// Token: 0x060044AB RID: 17579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044AB")]
		[Address(RVA = "0x71E0E0", Offset = "0x71CAE0", VA = "0x18071E0E0")]
		private void AddRepeatChallengeItem(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x060044AC RID: 17580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044AC")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public NitoriExtraDialogData()
		{
		}

		// Token: 0x04003CBD RID: 15549
		[Token(Token = "0x4003CBD")]
		private const string OPTION_FIRST_REPEATCHALLENGE = "KIZUNA_SPECIAL_NITORI_REPEATCHALLENGE_FIRST";

		// Token: 0x04003CBE RID: 15550
		[Token(Token = "0x4003CBE")]
		private const string OPTION_REPEATCHALLENGE = "KIZUNA_SPECIAL_NITORI_REPEATCHALLENGE";

		// Token: 0x04003CBF RID: 15551
		[Token(Token = "0x4003CBF")]
		private const string CHALLENGESUCCESS_EVENT_ID = "DLC1_Main_Toutetsu_004_Challange_Success";

		// Token: 0x04003CC0 RID: 15552
		[Token(Token = "0x4003CC0")]
		private const string FIRST_REPEATCHALLENGE_EVENT_ID = "DLC1_Main_Toutetsu_First_RepeatChallenge_P1";

		// Token: 0x04003CC1 RID: 15553
		[Token(Token = "0x4003CC1")]
		private const string REPEATCHALLENGE_EVENT_ID = "DLC1_Main_Toutetsu_RepeatChallenge_P1";
	}
}
