using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Playables;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B3B RID: 2875
	[Token(Token = "0x2000B3B")]
	[CreateAssetMenu(fileName = "GeneralPublicExtraDialogData", menuName = "GameData Profile/Extra Dialog Data/Public Extra Dialog Data/General Public Extra Dialog Data", order = 0)]
	public class GeneralPublicExtraDialogData : SpecialGuestPublicExtraDialogData
	{
		// Token: 0x060044B8 RID: 17592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B8")]
		[Address(RVA = "0x71A300", Offset = "0x718D00", VA = "0x18071A300", Slot = "5")]
		public override void GetSpecialGuestExtraDialogData(out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] prependSelection, out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] appendSelections)
		{
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044B9")]
		[Address(RVA = "0x71A4B0", Offset = "0x718EB0", VA = "0x18071A4B0")]
		private void OnInteract(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x060044BA RID: 17594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BA")]
		[Address(RVA = "0x71A830", Offset = "0x719230", VA = "0x18071A830")]
		private void Play(GeneralPublicExtraDialogData.SGuestDialogPackage package, bool finishEventIsEmpty)
		{
		}

		// Token: 0x060044BB RID: 17595 RVA: 0x00018D80 File Offset: 0x00016F80
		[Token(Token = "0x60044BB")]
		[Address(RVA = "0x71AAD0", Offset = "0x7194D0", VA = "0x18071AAD0")]
		private bool TryFindSGuestDialogPackage(string guestLabel, out GeneralPublicExtraDialogData.SGuestDialogPackage sGuestDialogPackage)
		{
			return default(bool);
		}

		// Token: 0x060044BC RID: 17596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BC")]
		[Address(RVA = "0x71AA60", Offset = "0x719460", VA = "0x18071AA60")]
		private void ScheduledEvent(string eventId, bool isEmpty, bool isManualComplete)
		{
		}

		// Token: 0x060044BD RID: 17597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044BD")]
		[Address(RVA = "0x3EC0C0", Offset = "0x3EAAC0", VA = "0x1803EC0C0")]
		public GeneralPublicExtraDialogData()
		{
		}

		// Token: 0x04003CCE RID: 15566
		[Token(Token = "0x4003CCE")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("前置选项Or后置选项，勾上为后置")]
		public bool appendOrPrepend;

		// Token: 0x04003CCF RID: 15567
		[Token(Token = "0x4003CCF")]
		[FieldOffset(Offset = "0x28")]
		public string optionTitleKey;

		// Token: 0x04003CD0 RID: 15568
		[Token(Token = "0x4003CD0")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("开启额外对话选项需要完成的事件，若为空则跳过判断")]
		public string beginEvent;

		// Token: 0x04003CD1 RID: 15569
		[Token(Token = "0x4003CD1")]
		[FieldOffset(Offset = "0x38")]
		public bool alwaysOpen;

		// Token: 0x04003CD2 RID: 15570
		[Token(Token = "0x4003CD2")]
		[FieldOffset(Offset = "0x40")]
		public GeneralPublicExtraDialogData.SGuestDialogPackage[] dialogPackages;

		// Token: 0x02000B3C RID: 2876
		[Token(Token = "0x2000B3C")]
		[Serializable]
		public struct SGuestDialogPackage
		{
			// Token: 0x04003CD3 RID: 15571
			[Token(Token = "0x4003CD3")]
			[FieldOffset(Offset = "0x0")]
			public string guestLabel;

			// Token: 0x04003CD4 RID: 15572
			[Token(Token = "0x4003CD4")]
			[FieldOffset(Offset = "0x8")]
			public string extraBeginLabel;

			// Token: 0x04003CD5 RID: 15573
			[Token(Token = "0x4003CD5")]
			[FieldOffset(Offset = "0x10")]
			[Header("[Content]")]
			public SchedulerNode.Event.EventType eventType;

			// Token: 0x04003CD6 RID: 15574
			[Token(Token = "0x4003CD6")]
			[FieldOffset(Offset = "0x18")]
			public DialogPackage dialogPackage;

			// Token: 0x04003CD7 RID: 15575
			[Token(Token = "0x4003CD7")]
			[FieldOffset(Offset = "0x20")]
			public AssetReferenceT<PlayableAsset> timelineAssetReference;

			// Token: 0x04003CD8 RID: 15576
			[Token(Token = "0x4003CD8")]
			[FieldOffset(Offset = "0x28")]
			[Header("[Execute]")]
			public bool needChat;

			// Token: 0x04003CD9 RID: 15577
			[Token(Token = "0x4003CD9")]
			[FieldOffset(Offset = "0x30")]
			public string extraSelectionsFinishEvent;

			// Token: 0x04003CDA RID: 15578
			[Token(Token = "0x4003CDA")]
			[FieldOffset(Offset = "0x38")]
			public bool executeOnce;

			// Token: 0x04003CDB RID: 15579
			[Token(Token = "0x4003CDB")]
			[FieldOffset(Offset = "0x39")]
			public bool manualCompleteFinishEvent;
		}
	}
}
