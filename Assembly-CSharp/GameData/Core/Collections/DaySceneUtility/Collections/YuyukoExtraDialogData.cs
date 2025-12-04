using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B58 RID: 2904
	[Token(Token = "0x2000B58")]
	[CreateAssetMenu(fileName = "YuyukoExtraDialogData", menuName = "GameData Profile/Extra Dialog Data/Yuyuko", order = 2)]
	public class YuyukoExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x06004523 RID: 17699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004523")]
		[Address(RVA = "0x74EFF0", Offset = "0x74D9F0", VA = "0x18074EFF0", Slot = "5")]
		public override void GetSpecialGuestExtraDialogData(out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] prependSelection, out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] appendSelections)
		{
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004524")]
		[Address(RVA = "0x74F100", Offset = "0x74DB00", VA = "0x18074F100")]
		private void Yuyuko_Challenge(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004525")]
		[Address(RVA = "0x495780", Offset = "0x494180", VA = "0x180495780")]
		public YuyukoExtraDialogData()
		{
		}

		// Token: 0x04003D57 RID: 15703
		[Token(Token = "0x4003D57")]
		private const string CHAT_KEY = "KIZUNA_SPECIAL_YUYUKO";

		// Token: 0x04003D58 RID: 15704
		[Token(Token = "0x4003D58")]
		[FieldOffset(Offset = "0x18")]
		public DialogPackage challengeStartDialog;

		// Token: 0x04003D59 RID: 15705
		[Token(Token = "0x4003D59")]
		[FieldOffset(Offset = "0x20")]
		public string challengeStartEvent;
	}
}
