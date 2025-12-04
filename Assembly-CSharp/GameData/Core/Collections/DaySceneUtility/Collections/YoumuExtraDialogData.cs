using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B48 RID: 2888
	[Token(Token = "0x2000B48")]
	[CreateAssetMenu(fileName = "YoumuExtraDialogData", menuName = "GameData Profile/Extra Dialog Data/Youmu", order = 2)]
	public class YoumuExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x060044E1 RID: 17633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E1")]
		[Address(RVA = "0x731250", Offset = "0x72FC50", VA = "0x180731250", Slot = "5")]
		public override void GetSpecialGuestExtraDialogData(out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] prependSelection, out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] appendSelections)
		{
		}

		// Token: 0x060044E2 RID: 17634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E2")]
		[Address(RVA = "0x7313E0", Offset = "0x72FDE0", VA = "0x1807313E0")]
		private void YoumuChallenge_Advanced(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x060044E3 RID: 17635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E3")]
		[Address(RVA = "0x731520", Offset = "0x72FF20", VA = "0x180731520")]
		private void YoumuChallenge_Basic(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x060044E4 RID: 17636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044E4")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public YoumuExtraDialogData()
		{
		}

		// Token: 0x04003CFD RID: 15613
		[Token(Token = "0x4003CFD")]
		private const string CHAT_KEY_A = "KIZUNA_SPECIAL_YOUMU_A";

		// Token: 0x04003CFE RID: 15614
		[Token(Token = "0x4003CFE")]
		private const string CHAT_KEY_B = "KIZUNA_SPECIAL_YOUMU_B";

		// Token: 0x04003CFF RID: 15615
		[Token(Token = "0x4003CFF")]
		[FieldOffset(Offset = "0x18")]
		public DialogPackage challengeAStartDialog;

		// Token: 0x04003D00 RID: 15616
		[Token(Token = "0x4003D00")]
		[FieldOffset(Offset = "0x20")]
		public string challengeAEvent;

		// Token: 0x04003D01 RID: 15617
		[Token(Token = "0x4003D01")]
		[FieldOffset(Offset = "0x28")]
		public DialogPackage challengeBStartDialog;

		// Token: 0x04003D02 RID: 15618
		[Token(Token = "0x4003D02")]
		[FieldOffset(Offset = "0x30")]
		public string challengeBEvent;
	}
}
