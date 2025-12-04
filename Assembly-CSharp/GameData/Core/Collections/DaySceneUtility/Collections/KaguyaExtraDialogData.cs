using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B0D RID: 2829
	[Token(Token = "0x2000B0D")]
	[CreateAssetMenu(fileName = "KaguyaExtraDialogData", menuName = "GameData Profile/Extra Dialog Data/Kaguya", order = 20)]
	public class KaguyaExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x06004424 RID: 17444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004424")]
		[Address(RVA = "0x71ABD0", Offset = "0x7195D0", VA = "0x18071ABD0", Slot = "5")]
		public override void GetSpecialGuestExtraDialogData(out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] prependSelection, out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] appendSelections)
		{
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004425")]
		[Address(RVA = "0x71ACE0", Offset = "0x7196E0", VA = "0x18071ACE0")]
		private void KaguyaVSMokou_FoodBattle(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004426")]
		[Address(RVA = "0x71AE80", Offset = "0x719880", VA = "0x18071AE80")]
		public KaguyaExtraDialogData()
		{
		}

		// Token: 0x04003C36 RID: 15414
		[Token(Token = "0x4003C36")]
		private const string KIZUNA_TITLE = "KIZUNA_KAGUYAVSMOKOU_FOODBATTLE";

		// Token: 0x04003C37 RID: 15415
		[Token(Token = "0x4003C37")]
		[FieldOffset(Offset = "0x18")]
		[Header("同意对话")]
		public DialogPackage agreeDialog;

		// Token: 0x04003C38 RID: 15416
		[Token(Token = "0x4003C38")]
		[FieldOffset(Offset = "0x20")]
		[Header("上一次辉夜胜利对话")]
		public DialogPackage kaguyaWinStartDialog;

		// Token: 0x04003C39 RID: 15417
		[Token(Token = "0x4003C39")]
		[FieldOffset(Offset = "0x28")]
		public DialogPackage kaguyaWinRefuseDialog;

		// Token: 0x04003C3A RID: 15418
		[Token(Token = "0x4003C3A")]
		[FieldOffset(Offset = "0x30")]
		[Header("上一次妹红胜利对话")]
		public DialogPackage mokouWinStartDialog;

		// Token: 0x04003C3B RID: 15419
		[Token(Token = "0x4003C3B")]
		[FieldOffset(Offset = "0x38")]
		public DialogPackage mokouWinRefuseDialog;

		// Token: 0x04003C3C RID: 15420
		[Token(Token = "0x4003C3C")]
		[FieldOffset(Offset = "0x40")]
		public string preliminaryTask;

		// Token: 0x04003C3D RID: 15421
		[Token(Token = "0x4003C3D")]
		[FieldOffset(Offset = "0x48")]
		public string scheduledTask;

		// Token: 0x04003C3E RID: 15422
		[Token(Token = "0x4003C3E")]
		[FieldOffset(Offset = "0x50")]
		public string battleEvent;

		// Token: 0x04003C3F RID: 15423
		[Token(Token = "0x4003C3F")]
		[FieldOffset(Offset = "0x58")]
		public string mokouWinEvent;

		// Token: 0x04003C40 RID: 15424
		[Token(Token = "0x4003C40")]
		[FieldOffset(Offset = "0x60")]
		public string kaguyaWinEvent;
	}
}
