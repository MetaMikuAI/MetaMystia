using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using DayScene.UI;
using GameData.Profile;
using Il2CppDummyDll;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x02000B4B RID: 2891
	[Token(Token = "0x2000B4B")]
	[CreateAssetMenu(fileName = "YuugiExtraDialogData", menuName = "GameData Profile/Extra Dialog Data/Yuugi", order = 4)]
	public class YuugiExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x060044ED RID: 17645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044ED")]
		[Address(RVA = "0x732180", Offset = "0x730B80", VA = "0x180732180", Slot = "5")]
		public override void GetSpecialGuestExtraDialogData(out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] prependSelection, out DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback[] appendSelections)
		{
		}

		// Token: 0x060044EE RID: 17646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044EE")]
		[Address(RVA = "0x7322A0", Offset = "0x730CA0", VA = "0x1807322A0")]
		private void GotoSpring(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
		}

		// Token: 0x060044EF RID: 17647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044EF")]
		[Address(RVA = "0x731E50", Offset = "0x730850", VA = "0x180731E50")]
		private object[] GetPartnerData()
		{
			return null;
		}

		// Token: 0x060044F0 RID: 17648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F0")]
		[Address(RVA = "0x731D80", Offset = "0x730780", VA = "0x180731D80")]
		private IEnumerable<ValueTuple<object, string, string>> GetExtraSelectionsCallback()
		{
			return null;
		}

		// Token: 0x060044F1 RID: 17649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60044F1")]
		[Address(RVA = "0x731DE0", Offset = "0x7307E0", VA = "0x180731DE0")]
		private string GetName(object id)
		{
			return null;
		}

		// Token: 0x060044F2 RID: 17650 RVA: 0x00018DE0 File Offset: 0x00016FE0
		[Token(Token = "0x60044F2")]
		[Address(RVA = "0x732100", Offset = "0x730B00", VA = "0x180732100")]
		private ValueTuple<int, string, string> GetSelectAllSelectionCallback()
		{
			return default(ValueTuple<int, string, string>);
		}

		// Token: 0x060044F3 RID: 17651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F3")]
		[Address(RVA = "0x732410", Offset = "0x730E10", VA = "0x180732410")]
		private void OnPanelClosed(int[] selections)
		{
		}

		// Token: 0x060044F4 RID: 17652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F4")]
		[Address(RVA = "0x731660", Offset = "0x730060", VA = "0x180731660")]
		public void AddExtraSpringBuffToWorkScene(int partnerId)
		{
		}

		// Token: 0x060044F5 RID: 17653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F5")]
		[Address(RVA = "0x732620", Offset = "0x731020", VA = "0x180732620")]
		private void PlayConfirmDialog(int[] partnerIds)
		{
		}

		// Token: 0x060044F6 RID: 17654 RVA: 0x00018DF8 File Offset: 0x00016FF8
		[Token(Token = "0x60044F6")]
		[Address(RVA = "0x732560", Offset = "0x730F60", VA = "0x180732560")]
		private UniTaskVoid PlayConfirmDialogAsync(int[] partnerIds)
		{
			return default(UniTaskVoid);
		}

		// Token: 0x060044F7 RID: 17655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60044F7")]
		[Address(RVA = "0x7326F0", Offset = "0x7310F0", VA = "0x1807326F0")]
		public YuugiExtraDialogData()
		{
		}

		// Token: 0x04003D0B RID: 15627
		[Token(Token = "0x4003D0B")]
		private const string ABOUT_SPRING = "KIZUNA_SPECIAL_YUGI_ABOUT_SPRING";

		// Token: 0x04003D0C RID: 15628
		[Token(Token = "0x4003D0C")]
		private const int ACTION_CONSUMPTION = 1;

		// Token: 0x04003D0D RID: 15629
		[Token(Token = "0x4003D0D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string openSpringEventId;

		// Token: 0x04003D0E RID: 15630
		[Token(Token = "0x4003D0E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DialogPackage introduceSpringDialog;

		// Token: 0x04003D0F RID: 15631
		[Token(Token = "0x4003D0F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DialogPackage springPriceConfirmSingleDialog;

		// Token: 0x04003D10 RID: 15632
		[Token(Token = "0x4003D10")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DialogPackage springPriceConfirmMultiDialog;

		// Token: 0x04003D11 RID: 15633
		[Token(Token = "0x4003D11")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DialogPackage springPriceConfirmTogetherDialog;

		// Token: 0x04003D12 RID: 15634
		[Token(Token = "0x4003D12")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DialogPackage finalConfirmDialog;

		// Token: 0x04003D13 RID: 15635
		[Token(Token = "0x4003D13")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private DialogPackage endSpringDialog;

		// Token: 0x04003D14 RID: 15636
		[Token(Token = "0x4003D14")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DialogPackage lackMoneyDialog;

		// Token: 0x04003D15 RID: 15637
		[Token(Token = "0x4003D15")]
		[FieldOffset(Offset = "0x58")]
		public GameObject showerCGGameObject;

		// Token: 0x04003D16 RID: 15638
		[Token(Token = "0x4003D16")]
		[FieldOffset(Offset = "0x60")]
		[Header("小碎骨一个人泡温泉")]
		public YuugiExtraDialogData.PartnerSpringData mystiaData;

		// Token: 0x04003D17 RID: 15639
		[Token(Token = "0x4003D17")]
		[FieldOffset(Offset = "0x88")]
		[Header("伙伴泡温泉")]
		public YuugiExtraDialogData.PartnerSpringData[] springData;

		// Token: 0x04003D18 RID: 15640
		[Token(Token = "0x4003D18")]
		[FieldOffset(Offset = "0x90")]
		public int cost;

		// Token: 0x04003D19 RID: 15641
		[Token(Token = "0x4003D19")]
		[FieldOffset(Offset = "0x94")]
		public int preferentialEachPerson;

		// Token: 0x04003D1A RID: 15642
		[Token(Token = "0x4003D1A")]
		[FieldOffset(Offset = "0x98")]
		public float rewardMoveSpeedRate;

		// Token: 0x04003D1B RID: 15643
		[Token(Token = "0x4003D1B")]
		[FieldOffset(Offset = "0x9C")]
		public float rewardCookSpeedRate;

		// Token: 0x04003D1C RID: 15644
		[Token(Token = "0x4003D1C")]
		[FieldOffset(Offset = "0xA0")]
		private Queue<YuugiExtraDialogData.PartnerSpringData> targetPartner;

		// Token: 0x02000B4C RID: 2892
		[Token(Token = "0x2000B4C")]
		public enum DLCMapping
		{
			// Token: 0x04003D1E RID: 15646
			[Token(Token = "0x4003D1E")]
			Main,
			// Token: 0x04003D1F RID: 15647
			[Token(Token = "0x4003D1F")]
			DLC1,
			// Token: 0x04003D20 RID: 15648
			[Token(Token = "0x4003D20")]
			DLC2,
			// Token: 0x04003D21 RID: 15649
			[Token(Token = "0x4003D21")]
			DLC3,
			// Token: 0x04003D22 RID: 15650
			[Token(Token = "0x4003D22")]
			DLC4,
			// Token: 0x04003D23 RID: 15651
			[Token(Token = "0x4003D23")]
			DLC5
		}

		// Token: 0x02000B4D RID: 2893
		[Token(Token = "0x2000B4D")]
		public enum ShowerType
		{
			// Token: 0x04003D25 RID: 15653
			[Token(Token = "0x4003D25")]
			Single,
			// Token: 0x04003D26 RID: 15654
			[Token(Token = "0x4003D26")]
			Multi,
			// Token: 0x04003D27 RID: 15655
			[Token(Token = "0x4003D27")]
			Together
		}

		// Token: 0x02000B4E RID: 2894
		[Token(Token = "0x2000B4E")]
		[Serializable]
		public struct PartnerSpringData
		{
			// Token: 0x04003D28 RID: 15656
			[Token(Token = "0x4003D28")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			public int partnerId;

			// Token: 0x04003D29 RID: 15657
			[Token(Token = "0x4003D29")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			public YuugiExtraDialogData.DLCMapping dLCMapping;

			// Token: 0x04003D2A RID: 15658
			[Token(Token = "0x4003D2A")]
			[FieldOffset(Offset = "0x8")]
			[SerializeField]
			public Sprite showerCG;

			// Token: 0x04003D2B RID: 15659
			[Token(Token = "0x4003D2B")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			public DialogPackage beginDialog;

			// Token: 0x04003D2C RID: 15660
			[Token(Token = "0x4003D2C")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public DialogPackage showeringDialog;

			// Token: 0x04003D2D RID: 15661
			[Token(Token = "0x4003D2D")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			public DialogPackage endDialog;
		}
	}
}
