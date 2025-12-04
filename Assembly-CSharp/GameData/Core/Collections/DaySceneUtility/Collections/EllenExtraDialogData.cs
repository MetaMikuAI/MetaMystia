using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B05 RID: 2821
	[Token(Token = "0x2000B05")]
	[CreateAssetMenu(fileName = "EllenExtraDialogData", menuName = "GameData Profile/Extra Dialog Data/Ellen", order = 5000)]
	public class EllenExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x06004405 RID: 17413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004405")]
		[Address(RVA = "0x719790", Offset = "0x718190", VA = "0x180719790", Slot = "5")]
		public override void GetSpecialGuestExtraDialogData(out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] prependSelection, out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] appendSelections)
		{
		}

		// Token: 0x06004406 RID: 17414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004406")]
		[Address(RVA = "0x7198A0", Offset = "0x7182A0", VA = "0x1807198A0")]
		private void Shop(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x06004407 RID: 17415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004407")]
		[Address(RVA = "0x719A70", Offset = "0x718470", VA = "0x180719A70")]
		public EllenExtraDialogData()
		{
		}

		// Token: 0x04003C11 RID: 15377
		[Token(Token = "0x4003C11")]
		[FieldOffset(Offset = "0x18")]
		public int needLevel;

		// Token: 0x04003C12 RID: 15378
		[Token(Token = "0x4003C12")]
		private const int ELLEN_ID = 5003;

		// Token: 0x04003C13 RID: 15379
		[Token(Token = "0x4003C13")]
		private const string DLC5_ELLEN_SHOP_TITLE = "DLC5_ELLEN_SHOP_TITLE";

		// Token: 0x04003C14 RID: 15380
		[Token(Token = "0x4003C14")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DialogPackage[] m_OpenShopDialog;

		// Token: 0x04003C15 RID: 15381
		[Token(Token = "0x4003C15")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DialogPackage[] m_EndDialog;

		// Token: 0x04003C16 RID: 15382
		[Token(Token = "0x4003C16")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DialogPackage[] m_FinishShoppingDialog;

		// Token: 0x04003C17 RID: 15383
		[Token(Token = "0x4003C17")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AssetReference m_EllenShopPanel;
	}
}
