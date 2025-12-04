using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using DayScene.UI;
using DEYU.AssetHandleUtility;
using GameData.Profile;
using Il2CppDummyDll;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B17 RID: 2839
	[Token(Token = "0x2000B17")]
	[Serializable]
	public class KyoukoTutorialData
	{
		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x0600444B RID: 17483 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600444C RID: 17484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009B9")]
		public static Action<Action> KyoukoExtraDialogDataConfirmCallback
		{
			[Token(Token = "0x600444B")]
			[Address(RVA = "0x71D9F0", Offset = "0x71C3F0", VA = "0x18071D9F0")]
			private get
			{
				return null;
			}
			[Token(Token = "0x600444C")]
			[Address(RVA = "0x71DAE0", Offset = "0x71C4E0", VA = "0x18071DAE0")]
			set
			{
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x0600444D RID: 17485 RVA: 0x00018BB8 File Offset: 0x00016DB8
		[Token(Token = "0x170009BA")]
		public virtual bool NeedToShow
		{
			[Token(Token = "0x600444D")]
			[Address(RVA = "0x71DA30", Offset = "0x71C430", VA = "0x18071DA30", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x0600444E RID: 17486 RVA: 0x00018BD0 File Offset: 0x00016DD0
		[Token(Token = "0x170009BB")]
		protected virtual bool NeedCheckSwitch
		{
			[Token(Token = "0x600444E")]
			[Address(RVA = "0x42E0B0", Offset = "0x42CAB0", VA = "0x18042E0B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x0600444F RID: 17487 RVA: 0x00018BE8 File Offset: 0x00016DE8
		[Token(Token = "0x170009BC")]
		public virtual bool HaveFinishedTutorial
		{
			[Token(Token = "0x600444F")]
			[Address(RVA = "0x71D960", Offset = "0x71C360", VA = "0x18071D960", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06004450 RID: 17488 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004451 RID: 17489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009BD")]
		private Action SelectionCloseCallback
		{
			[Token(Token = "0x6004450")]
			[Address(RVA = "0x48B8D0", Offset = "0x48A2D0", VA = "0x18048B8D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004451")]
			[Address(RVA = "0x608700", Offset = "0x607100", VA = "0x180608700")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06004452 RID: 17490 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004453 RID: 17491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009BE")]
		public KyoukoTutorialData ParentSelection
		{
			[Token(Token = "0x6004452")]
			[Address(RVA = "0x440300", Offset = "0x43ED00", VA = "0x180440300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004453")]
			[Address(RVA = "0x51AAD0", Offset = "0x5194D0", VA = "0x18051AAD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004454 RID: 17492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004454")]
		[Address(RVA = "0x71CE30", Offset = "0x71B830", VA = "0x18071CE30", Slot = "7")]
		protected virtual string GetTutorialTitle(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			return null;
		}

		// Token: 0x06004455 RID: 17493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004455")]
		[Address(RVA = "0x71D440", Offset = "0x71BE40", VA = "0x18071D440", Slot = "8")]
		protected virtual void OnButtonInteract(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
		}

		// Token: 0x06004456 RID: 17494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004456")]
		[Address(RVA = "0x71C2F0", Offset = "0x71ACF0", VA = "0x18071C2F0")]
		protected void AfterDialog(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
		}

		// Token: 0x06004457 RID: 17495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004457")]
		[Address(RVA = "0x4A63B0", Offset = "0x4A4DB0", VA = "0x1804A63B0")]
		protected void Call(Action action)
		{
		}

		// Token: 0x06004458 RID: 17496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004458")]
		[Address(RVA = "0x71D430", Offset = "0x71BE30", VA = "0x18071D430", Slot = "9")]
		protected virtual void OnButtonInteractDialogPackageClose(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
		}

		// Token: 0x06004459 RID: 17497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004459")]
		[Address(RVA = "0x71C740", Offset = "0x71B140", VA = "0x18071C740")]
		protected void FinishTutorialEvent(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445A")]
		[Address(RVA = "0x71CCD0", Offset = "0x71B6D0", VA = "0x18071CCD0")]
		public void GetButton(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData, Func<bool, bool> extraCheck, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x00018C00 File Offset: 0x00016E00
		[Token(Token = "0x600445B")]
		[Address(RVA = "0x71D350", Offset = "0x71BD50", VA = "0x18071D350")]
		protected static UniTask<IAssetHandle<GameObject>> OnButtonInteractAsync(AssetReference targetGameObject)
		{
			return default(UniTask<IAssetHandle<GameObject>>);
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445C")]
		[Address(RVA = "0x71C5B0", Offset = "0x71AFB0", VA = "0x18071C5B0")]
		protected void CloseAllSelection()
		{
		}

		// Token: 0x0600445D RID: 17501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600445D")]
		[Address(RVA = "0x3EBEB0", Offset = "0x3EA8B0", VA = "0x1803EBEB0")]
		public KyoukoTutorialData()
		{
		}

		// Token: 0x04003C64 RID: 15460
		[Token(Token = "0x4003C64")]
		private const string EVENT_MARK_KEY = "KYOUKOU_TUTORIAL_EVENT_MARK";

		// Token: 0x04003C65 RID: 15461
		[Token(Token = "0x4003C65")]
		[FieldOffset(Offset = "0x0")]
		private static Action<Action> s_KyoukoExtraDialogDataConfirmCallback;

		// Token: 0x04003C66 RID: 15462
		[Token(Token = "0x4003C66")]
		[FieldOffset(Offset = "0x10")]
		[CanBeNull]
		public DialogPackage tutorialStartDialogForKeyBoard;

		// Token: 0x04003C67 RID: 15463
		[Token(Token = "0x4003C67")]
		[FieldOffset(Offset = "0x18")]
		[CanBeNull]
		public DialogPackage tutorialStartDialogForSwitch;

		// Token: 0x04003C68 RID: 15464
		[Token(Token = "0x4003C68")]
		[FieldOffset(Offset = "0x20")]
		[CanBeNull]
		public DialogPackage tutorialStartDialogNSAlternative;

		// Token: 0x04003C69 RID: 15465
		[Token(Token = "0x4003C69")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("不需要提醒玩家查看")]
		[SerializeField]
		private bool notDefaultPrompt;

		// Token: 0x04003C6A RID: 15466
		[Token(Token = "0x4003C6A")]
		[FieldOffset(Offset = "0x30")]
		[NotNull]
		[SerializeField]
		protected string tutorialPhraseKey;

		// Token: 0x04003C6B RID: 15467
		[Token(Token = "0x4003C6B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[CanBeNull]
		[FormerlySerializedAs("tutorialEventLabel")]
		protected string tutorialEventOrTrackedLabel;

		// Token: 0x04003C6C RID: 15468
		[Token(Token = "0x4003C6C")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("为true时，上个字符串代表事件Label，否则代表TrackedSwitchLabel")]
		[SerializeField]
		protected bool eventLabelMode;

		// Token: 0x04003C6D RID: 15469
		[Token(Token = "0x4003C6D")]
		[FieldOffset(Offset = "0x48")]
		[CanBeNull]
		[SerializeField]
		protected string beginEvent;

		// Token: 0x04003C6E RID: 15470
		[Token(Token = "0x4003C6E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[CanBeNull]
		protected string beginMission;

		// Token: 0x04003C6F RID: 15471
		[Token(Token = "0x4003C6F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected bool needToConfirm;
	}
}
