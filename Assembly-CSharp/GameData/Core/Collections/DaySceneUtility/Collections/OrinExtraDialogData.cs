using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B39 RID: 2873
	[Token(Token = "0x2000B39")]
	[CreateAssetMenu(fileName = "OrinExtraDialogData", menuName = "GameData Profile/Extra Dialog Data/Orin", order = 3)]
	public class OrinExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x060044B0 RID: 17584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B0")]
		[Address(RVA = "0x71E510", Offset = "0x71CF10", VA = "0x18071E510", Slot = "5")]
		public override void GetSpecialGuestExtraDialogData(out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] prependSelection, out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] appendSelections)
		{
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B1")]
		[Address(RVA = "0x71E3A0", Offset = "0x71CDA0", VA = "0x18071E3A0")]
		private void AddRepeatChallengeItem(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B2")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public OrinExtraDialogData()
		{
		}

		// Token: 0x04003CC4 RID: 15556
		[Token(Token = "0x4003CC4")]
		private const string OPTION_REPEATCHALLENGE = "KIZUNA_SPECIAL_ORIN_REPEATCHALLENGE";

		// Token: 0x04003CC5 RID: 15557
		[Token(Token = "0x4003CC5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string challengeMissionId;

		// Token: 0x04003CC6 RID: 15558
		[Token(Token = "0x4003CC6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string repeatChallengeEventId;

		// Token: 0x04003CC7 RID: 15559
		[Token(Token = "0x4003CC7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DialogPackage confirm;

		// Token: 0x04003CC8 RID: 15560
		[Token(Token = "0x4003CC8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DialogPackage enter;

		// Token: 0x04003CC9 RID: 15561
		[Token(Token = "0x4003CC9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DialogPackage refuse;
	}
}
