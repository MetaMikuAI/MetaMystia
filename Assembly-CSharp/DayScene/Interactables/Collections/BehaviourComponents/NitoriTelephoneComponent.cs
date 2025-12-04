using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DayScene.UI;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppDummyDll;
using UnityCSharpCleanupGenerator.Attribute;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000520 RID: 1312
	[Token(Token = "0x2000520")]
	[GenerateCleanupMethod]
	public class NitoriTelephoneComponent : EntityBehaviourComponent
	{
		// Token: 0x06001D55 RID: 7509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D55")]
		[Address(RVA = "0x4B77C0", Offset = "0x4B61C0", VA = "0x1804B77C0", Slot = "6")]
		public override void OnInteract()
		{
		}

		// Token: 0x06001D56 RID: 7510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D56")]
		[Address(RVA = "0x4B7BE0", Offset = "0x4B65E0", VA = "0x1804B7BE0")]
		private void OpenFirstMenu()
		{
		}

		// Token: 0x06001D57 RID: 7511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D57")]
		[Address(RVA = "0x4B74D0", Offset = "0x4B5ED0", VA = "0x1804B74D0")]
		private void GetOpenSpecialNPCSubMenuBtnConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001D58 RID: 7512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D58")]
		[Address(RVA = "0x4B7390", Offset = "0x4B5D90", VA = "0x1804B7390")]
		private void GetOpenMerchantNPCSubMenuBtnConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001D59 RID: 7513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D59")]
		[Address(RVA = "0x4B6DC0", Offset = "0x4B57C0", VA = "0x1804B6DC0")]
		private void GetMultiInviteFriendBtnConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001D5A RID: 7514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D5A")]
		[Address(RVA = "0x4B7700", Offset = "0x4B6100", VA = "0x1804B7700")]
		private static string GetTitle(IEnumerable<object> data, string title)
		{
			return null;
		}

		// Token: 0x06001D5B RID: 7515 RVA: 0x0000B040 File Offset: 0x00009240
		[Token(Token = "0x6001D5B")]
		[Address(RVA = "0x4B7680", Offset = "0x4B6080", VA = "0x1804B7680")]
		private static bool GetSubmitButtonAvailability([TupleElementNames(new string[] { "data", "requestedAvailability" })] ValueTuple<IEnumerable<object>, bool> data)
		{
			return default(bool);
		}

		// Token: 0x06001D5C RID: 7516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D5C")]
		[Address(RVA = "0x4B6B30", Offset = "0x4B5530", VA = "0x1804B6B30")]
		private void GetMultiCommitFriendBtnConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001D5D RID: 7517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D5D")]
		[Address(RVA = "0x4B6610", Offset = "0x4B5010", VA = "0x1804B6610")]
		private void GetMultiBuyMerchantBtnConfig(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06001D5E RID: 7518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D5E")]
		[Address(RVA = "0x4B8C10", Offset = "0x4B7610", VA = "0x1804B8C10")]
		private void OpenSpecialNPCMapSelectionMenu(DaySceneChatSelectionPannel.BaseInteractData parentInteractData)
		{
		}

		// Token: 0x06001D5F RID: 7519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D5F")]
		[Address(RVA = "0x4B7F70", Offset = "0x4B6970", VA = "0x1804B7F70")]
		private void OpenMerchantNPCMapSelectionMenu(DaySceneChatSelectionPannel.BaseInteractData parentInteractData)
		{
		}

		// Token: 0x06001D60 RID: 7520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D60")]
		[Address(RVA = "0x4B91D0", Offset = "0x4B7BD0", VA = "0x1804B91D0")]
		private void OpenSpecialNPCSelectionMenu(DaySceneChatSelectionPannel.BaseInteractData parentInteractData, Action closeChatSelectionPannelCallback)
		{
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D61")]
		[Address(RVA = "0x4B64E0", Offset = "0x4B4EE0", VA = "0x1804B64E0")]
		private string GetMerchantName(string targetNpcStrId)
		{
			return null;
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D62")]
		[Address(RVA = "0x4B8580", Offset = "0x4B6F80", VA = "0x1804B8580")]
		private void OpenMerchantNPCSelectionMenu(DaySceneChatSelectionPannel.BaseInteractData parentInteractData)
		{
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D63")]
		[Address(RVA = "0x4B7610", Offset = "0x4B6010", VA = "0x1804B7610")]
		private string GetSpecialGuestText(object id)
		{
			return null;
		}

		// Token: 0x06001D64 RID: 7524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001D64")]
		[Address(RVA = "0x4B6360", Offset = "0x4B4D60", VA = "0x1804B6360")]
		private string GetMerchantName(object id)
		{
			return null;
		}

		// Token: 0x06001D65 RID: 7525 RVA: 0x0000B058 File Offset: 0x00009258
		[Token(Token = "0x6001D65")]
		[Address(RVA = "0x4B96F0", Offset = "0x4B80F0", VA = "0x1804B96F0")]
		private ExtraMerchantData RefExtraMerchantData(string label)
		{
			return default(ExtraMerchantData);
		}

		// Token: 0x06001D66 RID: 7526 RVA: 0x0000B070 File Offset: 0x00009270
		[Token(Token = "0x6001D66")]
		[Address(RVA = "0x4B5EF0", Offset = "0x4B48F0", VA = "0x1804B5EF0")]
		private bool CheckConditionMerchantDoSell(string characterLabel)
		{
			return default(bool);
		}

		// Token: 0x06001D67 RID: 7527 RVA: 0x0000B088 File Offset: 0x00009288
		[Token(Token = "0x6001D67")]
		[Address(RVA = "0x4B5FF0", Offset = "0x4B49F0", VA = "0x1804B5FF0")]
		private bool CheckExtraMerchantDoSell(string characterLabel)
		{
			return default(bool);
		}

		// Token: 0x06001D68 RID: 7528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D68")]
		[Address(RVA = "0x4B7A20", Offset = "0x4B6420", VA = "0x1804B7A20")]
		private void OpenExtraMerchantShop(string characterLabel, Action onFinishCallback)
		{
		}

		// Token: 0x06001D69 RID: 7529 RVA: 0x0000B0A0 File Offset: 0x000092A0
		[Token(Token = "0x6001D69")]
		[Address(RVA = "0x4B6300", Offset = "0x4B4D00", VA = "0x1804B6300")]
		private int GetKizunaLevel(int id)
		{
			return 0;
		}

		// Token: 0x06001D6A RID: 7530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D6A")]
		[Address(RVA = "0x4A63B0", Offset = "0x4A4DB0", VA = "0x1804A63B0")]
		private void Call(Action action)
		{
		}

		// Token: 0x06001D6B RID: 7531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D6B")]
		[Address(RVA = "0x4B9810", Offset = "0x4B8210", VA = "0x1804B9810")]
		private void TryGoBack(Action handle)
		{
		}

		// Token: 0x06001D6C RID: 7532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D6C")]
		[Address(RVA = "0x4B7910", Offset = "0x4B6310", VA = "0x1804B7910")]
		private void OpenAfterChatMenu(DaySceneChatSelectionPannel.GetSelectionConfigurationCallback[] selectionLists, string endKey, DaySceneChatSelectionPannel.BaseInteractData parentInteractData)
		{
		}

		// Token: 0x06001D6D RID: 7533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D6D")]
		[Address(RVA = "0x4B6270", Offset = "0x4B4C70", VA = "0x1804B6270", Slot = "13")]
		protected override void Cleanup_Generated()
		{
		}

		// Token: 0x06001D6E RID: 7534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D6E")]
		[Address(RVA = "0x4B9BF0", Offset = "0x4B85F0", VA = "0x1804B9BF0")]
		public NitoriTelephoneComponent()
		{
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x0000B0B8 File Offset: 0x000092B8
		[Token(Token = "0x6001D6F")]
		[Address(RVA = "0x4B99D0", Offset = "0x4B83D0", VA = "0x1804B99D0")]
		[CompilerGenerated]
		internal static int <GetMultiBuyMerchantBtnConfig>g__GetPrice|17_6(Product productData, TrackedMerchant merchantData)
		{
			return 0;
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x0000B0D0 File Offset: 0x000092D0
		[Token(Token = "0x6001D70")]
		[Address(RVA = "0x4B9870", Offset = "0x4B8270", VA = "0x1804B9870")]
		[CompilerGenerated]
		internal static int <GetMultiBuyMerchantBtnConfig>g__CalculateCurrentPrice|17_10(int trueValue, ref NitoriTelephoneComponent.<>c__DisplayClass17_3 A_1)
		{
			return 0;
		}

		// Token: 0x04001B09 RID: 6921
		[Token(Token = "0x4001B09")]
		private const int ACTION_CONSUMPTION = 1;

		// Token: 0x04001B0A RID: 6922
		[Token(Token = "0x4001B0A")]
		[FieldOffset(Offset = "0x18")]
		public DialogPackage[] EndDialog;

		// Token: 0x04001B0B RID: 6923
		[Token(Token = "0x4001B0B")]
		[FieldOffset(Offset = "0x20")]
		public DialogPackage[] openDialog;

		// Token: 0x04001B0C RID: 6924
		[Token(Token = "0x4001B0C")]
		[FieldOffset(Offset = "0x28")]
		public string[] mapLabel;

		// Token: 0x04001B0D RID: 6925
		[Token(Token = "0x4001B0D")]
		[FieldOffset(Offset = "0x30")]
		public ExtraMerchantData[] extraMerchantData;

		// Token: 0x04001B0E RID: 6926
		[Token(Token = "0x4001B0E")]
		[FieldOffset(Offset = "0x38")]
		public ExtraMerchantConditionData[] extraMerchantConditionData;

		// Token: 0x04001B0F RID: 6927
		[Token(Token = "0x4001B0F")]
		[FieldOffset(Offset = "0x40")]
		public int targetKizunaLevel;

		// Token: 0x04001B10 RID: 6928
		[Token(Token = "0x4001B10")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, ExtraMerchantConditionData> conditionData;

		// Token: 0x04001B11 RID: 6929
		[Token(Token = "0x4001B11")]
		[FieldOffset(Offset = "0x50")]
		private string currentMapLabel;
	}
}
