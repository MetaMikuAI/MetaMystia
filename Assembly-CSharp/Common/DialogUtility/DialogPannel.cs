using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Common.DialogUtility.History;
using Cysharp.Threading.Tasks;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection.Async;
using DEYU.AssetHandleUtility;
using Il2CppDummyDll;
using TMPro;
using UnityCSharpCleanupGenerator.Attribute;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.DialogUtility
{
	// Token: 0x02000D86 RID: 3462
	[Token(Token = "0x2000D86")]
	[GenerateCleanupMethod]
	public class DialogPannel : AsyncUIPanelExtern
	{
		// Token: 0x17000B7B RID: 2939
		// (set) Token: 0x06005128 RID: 20776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B7B")]
		[CleanupIgnore]
		private Sprite LeftPortrayal
		{
			[Token(Token = "0x6005128")]
			[Address(RVA = "0x7DF140", Offset = "0x7DDB40", VA = "0x1807DF140")]
			set
			{
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (set) Token: 0x06005129 RID: 20777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B7C")]
		[CleanupIgnore]
		private Sprite RightPortrayal
		{
			[Token(Token = "0x6005129")]
			[Address(RVA = "0x7DF3E0", Offset = "0x7DDDE0", VA = "0x1807DF3E0")]
			set
			{
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (set) Token: 0x0600512A RID: 20778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B7D")]
		[CleanupIgnore]
		private bool LeftPortrayalDark
		{
			[Token(Token = "0x600512A")]
			[Address(RVA = "0x7DF060", Offset = "0x7DDA60", VA = "0x1807DF060")]
			set
			{
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (set) Token: 0x0600512B RID: 20779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B7E")]
		[CleanupIgnore]
		private bool RightPortrayalDark
		{
			[Token(Token = "0x600512B")]
			[Address(RVA = "0x7DF300", Offset = "0x7DDD00", VA = "0x1807DF300")]
			set
			{
			}
		}

		// Token: 0x17000B7F RID: 2943
		// (set) Token: 0x0600512C RID: 20780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B7F")]
		[CleanupIgnore]
		public Sprite BG
		{
			[Token(Token = "0x600512C")]
			[Address(RVA = "0x7DEB90", Offset = "0x7DD590", VA = "0x1807DEB90")]
			set
			{
			}
		}

		// Token: 0x17000B80 RID: 2944
		// (set) Token: 0x0600512D RID: 20781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B80")]
		[CleanupIgnore]
		public Sprite CG
		{
			[Token(Token = "0x600512D")]
			[Address(RVA = "0x7DEDF0", Offset = "0x7DD7F0", VA = "0x1807DEDF0")]
			set
			{
			}
		}

		// Token: 0x17000B81 RID: 2945
		// (set) Token: 0x0600512E RID: 20782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B81")]
		[CleanupIgnore]
		public AudioClip SoundFx
		{
			[Token(Token = "0x600512E")]
			[Address(RVA = "0x7DF5A0", Offset = "0x7DDFA0", VA = "0x1807DF5A0")]
			set
			{
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (set) Token: 0x0600512F RID: 20783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B82")]
		[CleanupIgnore]
		private bool LeftPortrayalHighLight
		{
			[Token(Token = "0x600512F")]
			[Address(RVA = "0x7DF0E0", Offset = "0x7DDAE0", VA = "0x1807DF0E0")]
			set
			{
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (set) Token: 0x06005130 RID: 20784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B83")]
		[CleanupIgnore]
		private bool RightPortrayalHighLight
		{
			[Token(Token = "0x6005130")]
			[Address(RVA = "0x7DF380", Offset = "0x7DDD80", VA = "0x1807DF380")]
			set
			{
			}
		}

		// Token: 0x17000B84 RID: 2948
		// (set) Token: 0x06005131 RID: 20785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B84")]
		[CleanupIgnore]
		private string LeftSpeakerName
		{
			[Token(Token = "0x6005131")]
			[Address(RVA = "0x7DF270", Offset = "0x7DDC70", VA = "0x1807DF270")]
			set
			{
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (set) Token: 0x06005132 RID: 20786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B85")]
		[CleanupIgnore]
		private string RightSpeakerName
		{
			[Token(Token = "0x6005132")]
			[Address(RVA = "0x7DF510", Offset = "0x7DDF10", VA = "0x1807DF510")]
			set
			{
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06005133 RID: 20787 RVA: 0x0001D7A8 File Offset: 0x0001B9A8
		[Token(Token = "0x17000B86")]
		public override bool MutePanelCloseAudio
		{
			[Token(Token = "0x6005133")]
			[Address(RVA = "0x4025B0", Offset = "0x400FB0", VA = "0x1804025B0", Slot = "19")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000B87 RID: 2951
		// (get) Token: 0x06005134 RID: 20788 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005135 RID: 20789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B87")]
		[CleanupIgnore]
		public DialogPannelOpenContextBase OpenContext
		{
			[Token(Token = "0x6005134")]
			[Address(RVA = "0x48A620", Offset = "0x489020", VA = "0x18048A620")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6005135")]
			[Address(RVA = "0x55B0D0", Offset = "0x559AD0", VA = "0x18055B0D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B88 RID: 2952
		// (get) Token: 0x06005136 RID: 20790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B88")]
		[CleanupIgnore]
		private StringBuilder ContentStringBuilder
		{
			[Token(Token = "0x6005136")]
			[Address(RVA = "0x7DEAF0", Offset = "0x7DD4F0", VA = "0x1807DEAF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06005137 RID: 20791 RVA: 0x0001D7C0 File Offset: 0x0001B9C0
		// (set) Token: 0x06005138 RID: 20792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000B89")]
		public int ExitCode
		{
			[Token(Token = "0x6005137")]
			[Address(RVA = "0x7DEB80", Offset = "0x7DD580", VA = "0x1807DEB80")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005138")]
			[Address(RVA = "0x7DF050", Offset = "0x7DDA50", VA = "0x1807DF050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005139 RID: 20793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005139")]
		[Address(RVA = "0x7DC2D0", Offset = "0x7DACD0", VA = "0x1807DC2D0")]
		private void OnGUI()
		{
		}

		// Token: 0x0600513A RID: 20794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600513A")]
		[Address(RVA = "0x7DB5B0", Offset = "0x7D9FB0", VA = "0x1807DB5B0")]
		public static void ClearDialogHistories()
		{
		}

		// Token: 0x0600513B RID: 20795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600513B")]
		[Address(RVA = "0x7DB530", Offset = "0x7D9F30", VA = "0x1807DB530")]
		private void ClearContent()
		{
		}

		// Token: 0x0600513C RID: 20796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600513C")]
		[Address(RVA = "0x7DC6C0", Offset = "0x7DB0C0", VA = "0x1807DC6C0")]
		private void SetContent(string value)
		{
		}

		// Token: 0x0600513D RID: 20797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600513D")]
		[Address(RVA = "0x7DAE20", Offset = "0x7D9820", VA = "0x1807DAE20")]
		private void AddContent(string value)
		{
		}

		// Token: 0x0600513E RID: 20798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600513E")]
		[Address(RVA = "0x7DC690", Offset = "0x7DB090", VA = "0x1807DC690")]
		private void SetContentMaxVisibleCharacters(int num)
		{
		}

		// Token: 0x0600513F RID: 20799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600513F")]
		[Address(RVA = "0x7DC780", Offset = "0x7DB180", VA = "0x1807DC780")]
		private void SetPortrayal(Sprite value, Image character, Image characterShade, Animator animator)
		{
		}

		// Token: 0x06005140 RID: 20800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005140")]
		[Address(RVA = "0x7DC950", Offset = "0x7DB350", VA = "0x1807DC950")]
		private void SetSpeakerName(string name, TextMeshProUGUI speaker, GameObject speakerNameField)
		{
		}

		// Token: 0x06005141 RID: 20801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005141")]
		[Address(RVA = "0x7DCB10", Offset = "0x7DB510", VA = "0x1807DCB10")]
		private void ToggleDialogUI(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06005142 RID: 20802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005142")]
		[Address(RVA = "0x7DC890", Offset = "0x7DB290", VA = "0x1807DC890")]
		private void SetSkippingProgress(float progress)
		{
		}

		// Token: 0x06005143 RID: 20803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005143")]
		[Address(RVA = "0x7DCC60", Offset = "0x7DB660", VA = "0x1807DCC60")]
		private DialogPannel ToggleOn()
		{
			return null;
		}

		// Token: 0x06005144 RID: 20804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005144")]
		[Address(RVA = "0x7DCB30", Offset = "0x7DB530", VA = "0x1807DCB30")]
		private DialogPannel ToggleOff()
		{
			return null;
		}

		// Token: 0x06005145 RID: 20805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005145")]
		[Address(RVA = "0x7DC680", Offset = "0x7DB080", VA = "0x1807DC680")]
		public void SetCanPlayFirstLine()
		{
		}

		// Token: 0x06005146 RID: 20806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005146")]
		[Address(RVA = "0x7DC2C0", Offset = "0x7DACC0", VA = "0x1807DC2C0", Slot = "32")]
		protected override void OnExitExtern()
		{
		}

		// Token: 0x06005147 RID: 20807 RVA: 0x0001D7D8 File Offset: 0x0001B9D8
		[Token(Token = "0x6005147")]
		[Address(RVA = "0x7DBB00", Offset = "0x7DA500", VA = "0x1807DBB00", Slot = "25")]
		public override float GetDuration()
		{
			return 0f;
		}

		// Token: 0x06005148 RID: 20808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005148")]
		[Address(RVA = "0x7DDAC0", Offset = "0x7DC4C0", VA = "0x1807DDAC0")]
		private void UpdateInputBinding(bool shouldBind)
		{
		}

		// Token: 0x06005149 RID: 20809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005149")]
		[Address(RVA = "0x7DC090", Offset = "0x7DAA90", VA = "0x1807DC090")]
		private void Interact(InputAction.CallbackContext _)
		{
		}

		// Token: 0x0600514A RID: 20810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600514A")]
		[Address(RVA = "0x7DC9E0", Offset = "0x7DB3E0", VA = "0x1807DC9E0")]
		private void StartSkipTiming(InputAction.CallbackContext _)
		{
		}

		// Token: 0x0600514B RID: 20811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600514B")]
		[Address(RVA = "0x7DB9D0", Offset = "0x7DA3D0", VA = "0x1807DB9D0")]
		private void EndSkipTiming(InputAction.CallbackContext _)
		{
		}

		// Token: 0x0600514C RID: 20812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600514C")]
		[Address(RVA = "0x7DB9D0", Offset = "0x7DA3D0", VA = "0x1807DB9D0")]
		private void EndSkipTiming()
		{
		}

		// Token: 0x0600514D RID: 20813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600514D")]
		[Address(RVA = "0x7DC0B0", Offset = "0x7DAAB0", VA = "0x1807DC0B0")]
		private void InterruptDialog(InputAction.CallbackContext _)
		{
		}

		// Token: 0x0600514E RID: 20814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600514E")]
		[Address(RVA = "0x7DC4E0", Offset = "0x7DAEE0", VA = "0x1807DC4E0")]
		private void OpenHistoryPanel()
		{
		}

		// Token: 0x0600514F RID: 20815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600514F")]
		[Address(RVA = "0x7DB0A0", Offset = "0x7D9AA0", VA = "0x1807DB0A0")]
		public void CleanAtPosition(Position position)
		{
		}

		// Token: 0x06005150 RID: 20816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005150")]
		[Address(RVA = "0x7DBA40", Offset = "0x7DA440", VA = "0x1807DBA40")]
		private IEnumerator ExecuteDialog(string dialogContext, bool needToExitOnLastLine, string speakerName)
		{
			return null;
		}

		// Token: 0x06005151 RID: 20817 RVA: 0x0001D7F0 File Offset: 0x0001B9F0
		[Token(Token = "0x6005151")]
		[Address(RVA = "0x7DCD80", Offset = "0x7DB780", VA = "0x1807DCD80")]
		private int TrimNextContentSegment(string line, int currentPlayIndex, out bool isFunctionalTrim)
		{
			return 0;
		}

		// Token: 0x06005152 RID: 20818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005152")]
		[Address(RVA = "0x7DD5D0", Offset = "0x7DBFD0", VA = "0x1807DD5D0")]
		private IEnumerator TypeFollowing(int showNum)
		{
			return null;
		}

		// Token: 0x06005153 RID: 20819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005153")]
		[Address(RVA = "0x7DB650", Offset = "0x7DA050", VA = "0x1807DB650")]
		private void Copy(InputAction.CallbackContext _)
		{
		}

		// Token: 0x06005154 RID: 20820 RVA: 0x0001D808 File Offset: 0x0001BA08
		[Token(Token = "0x6005154")]
		[Address(RVA = "0x7DC450", Offset = "0x7DAE50", VA = "0x1807DC450", Slot = "33")]
		protected override UniTaskVoid OnPanelOpenAsync()
		{
			return default(UniTaskVoid);
		}

		// Token: 0x06005155 RID: 20821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005155")]
		[Address(RVA = "0x7DC1B0", Offset = "0x7DABB0", VA = "0x1807DC1B0")]
		private IEnumerator OnExecutingDialogLoopInternal(IReadOnlyList<KeyValuePair<ValueTuple<DialogMeta, LoadedDialogActionData[]>, string>> dialogPack, IReadOnlyDictionary<int, string> textFile, IAssetHandleArray<Sprite> playerPortrayalCollection, IReadOnlyDictionary<int, IAssetHandleArray<Sprite>> specialNPCPortrayalCollectionDictionary, IReadOnlyDictionary<DialogMeta, IAssetHandle<Sprite>> overrideDialogMetaToSprites, Func<bool> onCanExecuteFirstLineCalllback, bool blackBG)
		{
			return null;
		}

		// Token: 0x06005156 RID: 20822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005156")]
		[Address(RVA = "0x7DC0C0", Offset = "0x7DAAC0", VA = "0x1807DC0C0")]
		private IEnumerator OnExecutingDialogLoopCore(IReadOnlyList<KeyValuePair<ValueTuple<DialogMeta, LoadedDialogActionData[]>, string>> dialogPack, IReadOnlyDictionary<int, string> textFile, IAssetHandleArray<Sprite> playerPortrayalCollection, IReadOnlyDictionary<int, IAssetHandleArray<Sprite>> specialNPCPortrayalCollectionDictionary, IReadOnlyDictionary<DialogMeta, IAssetHandle<Sprite>> overrideDialogMetaToSprites)
		{
			return null;
		}

		// Token: 0x06005157 RID: 20823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005157")]
		[Address(RVA = "0x7DDFA0", Offset = "0x7DC9A0", VA = "0x1807DDFA0")]
		private void UpdateMetaPresentation(ref string line, IAssetHandleArray<Sprite> playerPortrayalCollection, IReadOnlyDictionary<int, IAssetHandleArray<Sprite>> specialNPCPortrayalCollectionDictionary, IReadOnlyDictionary<DialogMeta, IAssetHandle<Sprite>> overrideDialogMetaToSprites, ValueTuple<DialogMeta, LoadedDialogActionData[]> data, out string speakerName)
		{
		}

		// Token: 0x06005158 RID: 20824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005158")]
		[Address(RVA = "0x7DBB20", Offset = "0x7DA520", VA = "0x1807DBB20")]
		private void GetSpeakerName(ref string line, DialogMeta meta, out string speakerName)
		{
		}

		// Token: 0x06005159 RID: 20825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005159")]
		[Address(RVA = "0x7DBDE0", Offset = "0x7DA7E0", VA = "0x1807DBDE0")]
		private void GetSpeakerVisual(IAssetHandleArray<Sprite> playerPortrayalCollection, IReadOnlyDictionary<int, IAssetHandleArray<Sprite>> specialNPCPortrayalCollectionDictionary, IReadOnlyDictionary<DialogMeta, IAssetHandle<Sprite>> overrideDialogMetaToSprites, DialogMeta meta, out Sprite visual)
		{
		}

		// Token: 0x0600515A RID: 20826 RVA: 0x0001D820 File Offset: 0x0001BA20
		[Token(Token = "0x600515A")]
		[Address(RVA = "0x7DAEB0", Offset = "0x7D98B0", VA = "0x1807DAEB0")]
		private static bool CheckAndApplyOverrideSprite(ref Sprite visual, in DialogMeta dialogMeta, IReadOnlyDictionary<DialogMeta, IAssetHandle<Sprite>> overrideDialogMetaToSprites)
		{
			return default(bool);
		}

		// Token: 0x0600515B RID: 20827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600515B")]
		[Address(RVA = "0x7DB240", Offset = "0x7D9C40", VA = "0x1807DB240", Slot = "31")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x0600515C RID: 20828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600515C")]
		[Address(RVA = "0x7DE8D0", Offset = "0x7DD2D0", VA = "0x1807DE8D0")]
		public DialogPannel()
		{
		}

		// Token: 0x06005162 RID: 20834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005162")]
		[Address(RVA = "0x7DD670", Offset = "0x7DC070", VA = "0x1807DD670")]
		[CompilerGenerated]
		internal static string <TrimNextContentSegment>g__GenerateContextData|106_1(string title, string indexer, string value, string referenceName)
		{
			return null;
		}

		// Token: 0x04004C0C RID: 19468
		[Token(Token = "0x4004C0C")]
		private const string UNKNOWN_CHARACTER_NAME = "?????";

		// Token: 0x04004C0D RID: 19469
		[Token(Token = "0x4004C0D")]
		private const string COPY_SUCCESS = "COPY_SUCCESS_TIP";

		// Token: 0x04004C0E RID: 19470
		[Token(Token = "0x4004C0E")]
		[FieldOffset(Offset = "0x0")]
		[CleanupIgnore]
		private static readonly List<DialogHistory> s_DialogHistories;

		// Token: 0x04004C0F RID: 19471
		[Token(Token = "0x4004C0F")]
		[FieldOffset(Offset = "0x8")]
		private static uint s_GlobalDialogPackageCount;

		// Token: 0x04004C10 RID: 19472
		[Token(Token = "0x4004C10")]
		[FieldOffset(Offset = "0x70")]
		public DialogHistoryPanel dialogHistoryPanel;

		// Token: 0x04004C11 RID: 19473
		[Token(Token = "0x4004C11")]
		[FieldOffset(Offset = "0x78")]
		public Image leftChatacter;

		// Token: 0x04004C12 RID: 19474
		[Token(Token = "0x4004C12")]
		[FieldOffset(Offset = "0x80")]
		public Image leftChatacterShade;

		// Token: 0x04004C13 RID: 19475
		[Token(Token = "0x4004C13")]
		[FieldOffset(Offset = "0x88")]
		public Image rightChatacter;

		// Token: 0x04004C14 RID: 19476
		[Token(Token = "0x4004C14")]
		[FieldOffset(Offset = "0x90")]
		public Image rightChatacterShade;

		// Token: 0x04004C15 RID: 19477
		[Token(Token = "0x4004C15")]
		[FieldOffset(Offset = "0x98")]
		public Image nextProgress;

		// Token: 0x04004C16 RID: 19478
		[Token(Token = "0x4004C16")]
		[FieldOffset(Offset = "0xA0")]
		public RectTransform customSpacingRect;

		// Token: 0x04004C17 RID: 19479
		[Token(Token = "0x4004C17")]
		[FieldOffset(Offset = "0xA8")]
		public Image bg;

		// Token: 0x04004C18 RID: 19480
		[Token(Token = "0x4004C18")]
		[FieldOffset(Offset = "0xB0")]
		public Image cg;

		// Token: 0x04004C19 RID: 19481
		[Token(Token = "0x4004C19")]
		[FieldOffset(Offset = "0xB8")]
		public Sprite blackBG;

		// Token: 0x04004C1A RID: 19482
		[Token(Token = "0x4004C1A")]
		[FieldOffset(Offset = "0xC0")]
		public CanvasGroup[] hidables;

		// Token: 0x04004C1B RID: 19483
		[Token(Token = "0x4004C1B")]
		[FieldOffset(Offset = "0xC8")]
		public CanvasGroup[] bgArea;

		// Token: 0x04004C1C RID: 19484
		[Token(Token = "0x4004C1C")]
		[FieldOffset(Offset = "0xD0")]
		public TextMeshProUGUI context;

		// Token: 0x04004C1D RID: 19485
		[Token(Token = "0x4004C1D")]
		[FieldOffset(Offset = "0xD8")]
		public GameObject leftSpeakerNameField;

		// Token: 0x04004C1E RID: 19486
		[Token(Token = "0x4004C1E")]
		[FieldOffset(Offset = "0xE0")]
		public GameObject rightSpeakerNameField;

		// Token: 0x04004C1F RID: 19487
		[Token(Token = "0x4004C1F")]
		[FieldOffset(Offset = "0xE8")]
		public TextMeshProUGUI leftSpeakerName;

		// Token: 0x04004C20 RID: 19488
		[Token(Token = "0x4004C20")]
		[FieldOffset(Offset = "0xF0")]
		public TextMeshProUGUI rightSpeakerName;

		// Token: 0x04004C21 RID: 19489
		[Token(Token = "0x4004C21")]
		[FieldOffset(Offset = "0xF8")]
		public float startSkippingOffset;

		// Token: 0x04004C22 RID: 19490
		[Token(Token = "0x4004C22")]
		[FieldOffset(Offset = "0xFC")]
		public int charTypeFrame;

		// Token: 0x04004C23 RID: 19491
		[Token(Token = "0x4004C23")]
		[FieldOffset(Offset = "0x100")]
		public AudioClip talkAudio;

		// Token: 0x04004C24 RID: 19492
		[Token(Token = "0x4004C24")]
		[FieldOffset(Offset = "0x108")]
		public GameObject selectionsParent;

		// Token: 0x04004C25 RID: 19493
		[Token(Token = "0x4004C25")]
		[FieldOffset(Offset = "0x110")]
		public CanvasGroup selectionPannel;

		// Token: 0x04004C26 RID: 19494
		[Token(Token = "0x4004C26")]
		[FieldOffset(Offset = "0x118")]
		public Color highlightColor;

		// Token: 0x04004C27 RID: 19495
		[Token(Token = "0x4004C27")]
		[FieldOffset(Offset = "0x128")]
		public GameObject hideOnLoad;

		// Token: 0x04004C28 RID: 19496
		[Token(Token = "0x4004C28")]
		[FieldOffset(Offset = "0x130")]
		public Animator leftCharacterAnimator;

		// Token: 0x04004C29 RID: 19497
		[Token(Token = "0x4004C29")]
		[FieldOffset(Offset = "0x138")]
		public Animator rightCharacterAnimator;

		// Token: 0x04004C2A RID: 19498
		[Token(Token = "0x4004C2A")]
		[FieldOffset(Offset = "0x140")]
		private readonly List<GameObject> allSelectionInstances;

		// Token: 0x04004C2B RID: 19499
		[Token(Token = "0x4004C2B")]
		[FieldOffset(Offset = "0x148")]
		private readonly UILogicalGroup m_AllSelectionGroup;

		// Token: 0x04004C2C RID: 19500
		[Token(Token = "0x4004C2C")]
		[FieldOffset(Offset = "0x150")]
		private readonly List<ValueTuple<DialogMeta, string>> m_CurrentDialogDataForCopy;

		// Token: 0x04004C2D RID: 19501
		[Token(Token = "0x4004C2D")]
		[FieldOffset(Offset = "0x158")]
		private readonly Dictionary<ValueTuple<SpeakerIdentity.Identity, int>, Position> nameOnStage;

		// Token: 0x04004C2E RID: 19502
		[Token(Token = "0x4004C2E")]
		[FieldOffset(Offset = "0x160")]
		private readonly Dictionary<ValueTuple<SpeakerIdentity.Identity, int>, Position> portrayalOnStage;

		// Token: 0x04004C2F RID: 19503
		[Token(Token = "0x4004C2F")]
		[FieldOffset(Offset = "0x168")]
		private bool canPlayFirstLine;

		// Token: 0x04004C30 RID: 19504
		[Token(Token = "0x4004C30")]
		[FieldOffset(Offset = "0x169")]
		private bool dialogIsOpen;

		// Token: 0x04004C31 RID: 19505
		[Token(Token = "0x4004C31")]
		[FieldOffset(Offset = "0x16A")]
		private bool fastForwardMode;

		// Token: 0x04004C32 RID: 19506
		[Token(Token = "0x4004C32")]
		[FieldOffset(Offset = "0x16B")]
		private bool hasInteracted;

		// Token: 0x04004C33 RID: 19507
		[Token(Token = "0x4004C33")]
		[FieldOffset(Offset = "0x16C")]
		private bool initialized;

		// Token: 0x04004C34 RID: 19508
		[Token(Token = "0x4004C34")]
		[FieldOffset(Offset = "0x170")]
		private StringBuilder contentStringBuilder;

		// Token: 0x04004C35 RID: 19509
		[Token(Token = "0x4004C35")]
		[FieldOffset(Offset = "0x178")]
		private bool m_IsHistoryPanelOpened;

		// Token: 0x04004C36 RID: 19510
		[Token(Token = "0x4004C36")]
		[FieldOffset(Offset = "0x179")]
		private bool m_IsSelectionOpen;

		// Token: 0x04004C37 RID: 19511
		[Token(Token = "0x4004C37")]
		[FieldOffset(Offset = "0x17A")]
		private bool m_ShouldInstantClose;

		// Token: 0x04004C38 RID: 19512
		[Token(Token = "0x4004C38")]
		[FieldOffset(Offset = "0x180")]
		private StringBuilder m_StringBuilder;

		// Token: 0x04004C39 RID: 19513
		[Token(Token = "0x4004C39")]
		[FieldOffset(Offset = "0x188")]
		private bool shouldInterrupt;

		// Token: 0x04004C3A RID: 19514
		[Token(Token = "0x4004C3A")]
		[FieldOffset(Offset = "0x189")]
		private bool shouldKeepSkipping;

		// Token: 0x04004C3B RID: 19515
		[Token(Token = "0x4004C3B")]
		[FieldOffset(Offset = "0x18C")]
		private int characterDrawAmount;

		// Token: 0x04004C3E RID: 19518
		[Token(Token = "0x4004C3E")]
		[FieldOffset(Offset = "0x1A0")]
		private string m_LastPanelOpenStack;

		// Token: 0x04004C3F RID: 19519
		[Token(Token = "0x4004C3F")]
		[FieldOffset(Offset = "0x1A8")]
		private bool m_ProtectionLock;
	}
}
