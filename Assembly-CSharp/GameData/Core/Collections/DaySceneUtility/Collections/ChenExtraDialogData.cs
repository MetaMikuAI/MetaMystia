using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B02 RID: 2818
	[Token(Token = "0x2000B02")]
	[CreateAssetMenu(fileName = "ChenExtraDialogData", menuName = "GameData Profile/Extra Dialog Data/Chen", order = 3)]
	public class ChenExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x060043FD RID: 17405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043FD")]
		[Address(RVA = "0x714C30", Offset = "0x713630", VA = "0x180714C30", Slot = "5")]
		public override void GetSpecialGuestExtraDialogData(out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] prependSelection, out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] appendSelections)
		{
		}

		// Token: 0x060043FE RID: 17406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043FE")]
		[Address(RVA = "0x714AB0", Offset = "0x7134B0", VA = "0x180714AB0")]
		private void Chen_Concert(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x060043FF RID: 17407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60043FF")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public ChenExtraDialogData()
		{
		}

		// Token: 0x04003C07 RID: 15367
		[Token(Token = "0x4003C07")]
		private const string TARGET_EVENT = "Main_5_BambooForest_028_Event";

		// Token: 0x04003C08 RID: 15368
		[Token(Token = "0x4003C08")]
		private const string CONCERT_KEY = "KIZUNA_ABOUTCONCERT";

		// Token: 0x04003C09 RID: 15369
		[Token(Token = "0x4003C09")]
		private const string PARTY_STAGE = "PartyStage";

		// Token: 0x04003C0A RID: 15370
		[Token(Token = "0x4003C0A")]
		[FieldOffset(Offset = "0x18")]
		public DialogPackage beginDialog;

		// Token: 0x04003C0B RID: 15371
		[Token(Token = "0x4003C0B")]
		[FieldOffset(Offset = "0x20")]
		public DialogPackage closeDialog;

		// Token: 0x04003C0C RID: 15372
		[Token(Token = "0x4003C0C")]
		[FieldOffset(Offset = "0x28")]
		public string hostConcertAgainEvent;
	}
}
