using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B14 RID: 2836
	[Token(Token = "0x2000B14")]
	[CreateAssetMenu(fileName = "KyoukoExtraDialogData", menuName = "GameData Profile/Extra Dialog Data/Kyouko", order = 4)]
	public class KyoukoExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x0600443D RID: 17469 RVA: 0x00018B58 File Offset: 0x00016D58
		[Token(Token = "0x170009B6")]
		public override bool DoNotSkipGreeting
		{
			[Token(Token = "0x600443D")]
			[Address(RVA = "0x71B820", Offset = "0x71A220", VA = "0x18071B820", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x0600443E RID: 17470 RVA: 0x00018B70 File Offset: 0x00016D70
		[Token(Token = "0x170009B7")]
		public bool ShowTutorial
		{
			[Token(Token = "0x600443E")]
			[Address(RVA = "0x71B880", Offset = "0x71A280", VA = "0x18071B880")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x0600443F RID: 17471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B8")]
		private KyoukoTutorialData[] AllKyoukoTutorialData
		{
			[Token(Token = "0x600443F")]
			[Address(RVA = "0x71B640", Offset = "0x71A040", VA = "0x18071B640")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004440")]
		[Address(RVA = "0x71B450", Offset = "0x719E50", VA = "0x18071B450", Slot = "5")]
		public override void GetSpecialGuestExtraDialogData(out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] prependSelection, out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] appendSelections)
		{
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x00018B88 File Offset: 0x00016D88
		[Token(Token = "0x6004441")]
		[Address(RVA = "0x71B1D0", Offset = "0x719BD0", VA = "0x18071B1D0")]
		public bool AllCurrentTutorialHaveFinished()
		{
			return default(bool);
		}

		// Token: 0x06004442 RID: 17474 RVA: 0x00018BA0 File Offset: 0x00016DA0
		[Token(Token = "0x6004442")]
		[Address(RVA = "0x71B5D0", Offset = "0x719FD0", VA = "0x18071B5D0")]
		private bool ShowButton(bool oldAvailability)
		{
			return default(bool);
		}

		// Token: 0x06004443 RID: 17475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004443")]
		[Address(RVA = "0x71B380", Offset = "0x719D80", VA = "0x18071B380")]
		private DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback GetButtonCallback(KyoukoTutorialData tutorialData)
		{
			return null;
		}

		// Token: 0x06004444 RID: 17476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004444")]
		[Address(RVA = "0x71B280", Offset = "0x719C80", VA = "0x18071B280")]
		private void ConfirmCallback(Action onFinish)
		{
		}

		// Token: 0x06004445 RID: 17477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004445")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public KyoukoExtraDialogData()
		{
		}

		// Token: 0x04003C59 RID: 15449
		[Token(Token = "0x4003C59")]
		private const string BEASTFOREST_LABEL = "BeastForest";

		// Token: 0x04003C5A RID: 15450
		[Token(Token = "0x4003C5A")]
		[FieldOffset(Offset = "0x18")]
		[Header("DialogPackages")]
		public DialogPackage tutorialConfirmDialog;

		// Token: 0x04003C5B RID: 15451
		[Token(Token = "0x4003C5B")]
		[FieldOffset(Offset = "0x20")]
		[Header("MapLabel")]
		public string partyStageLabel;

		// Token: 0x04003C5C RID: 15452
		[Token(Token = "0x4003C5C")]
		[FieldOffset(Offset = "0x28")]
		[Header("1-我应该做什么？")]
		public KyoukoTutorialData WhatShouldIDo;

		// Token: 0x04003C5D RID: 15453
		[Token(Token = "0x4003C5D")]
		[FieldOffset(Offset = "0x30")]
		[Header("2-想要回忆教程…")]
		public KyoukoTutorialData_Memory Memory;

		// Token: 0x04003C5E RID: 15454
		[Token(Token = "0x4003C5E")]
		[FieldOffset(Offset = "0x38")]
		[Header("3-如何存档…")]
		public KyoukoTutorialData HowToSave;

		// Token: 0x04003C5F RID: 15455
		[Token(Token = "0x4003C5F")]
		[FieldOffset(Offset = "0x40")]
		[Header("4-注意事项…")]
		public KyoukoTutorialData AttenionTip;

		// Token: 0x04003C60 RID: 15456
		[Token(Token = "0x4003C60")]
		[FieldOffset(Offset = "0x48")]
		[Header("5-一些小技巧…")]
		public KyoukoTutorialData_GameTip GameTip;
	}
}
